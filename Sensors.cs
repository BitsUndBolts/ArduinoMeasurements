using System;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;

namespace ArduinoTemperatureMonitor
{
    public partial class Sensors : Form
    {
        private readonly SerialPort _port = new SerialPort();
        private readonly StringBuilder _portData = new StringBuilder();
        private const char SEPARATOR = ':';
        private const char TERMINATOR = ';';
        private char[] _activity = new char[] { '|', '/', '-', '\\' };
        private byte _activityPos = 0;

    public Sensors()
        {
            InitializeComponent();
            FillComPorts();
        }

        private void FillComPorts()
        {
            comPorts.Items.Clear();
            var availablePorts = SerialPort.GetPortNames();
            Array.Sort(availablePorts);

            foreach (var port in availablePorts)
            {
                comPorts.Items.Add(port);
                comPorts.SelectedIndex = 0;
            }
        }

        delegate void SetTextCallback(Control control, string text);

        private void SetText(Control control, string text)
        {
            if (control.InvokeRequired)
            {
                try
                {
                    SetTextCallback d = new SetTextCallback(SetText);
                    BeginInvoke(d, new object[] { control, text });
                }
                catch { }
            }
            else
            {
                control.Text = text;
            }
        }

        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int bytesToRead = _port.BytesToRead;
            char[] z = new char[bytesToRead];
            _port.Read(z, 0, bytesToRead);
            _portData.Append(z);

            if (Array.IndexOf(z, TERMINATOR) > -1)
            {
                while (_portData.ToString().IndexOf(TERMINATOR) > -1)
                {
                    var fullPortData = _portData.ToString();
                    var terminatorPosition = fullPortData.IndexOf(TERMINATOR);
                    var dataPortion = fullPortData.Substring(0, terminatorPosition);
                    _portData.Remove(0, terminatorPosition + 1);
                    var dataElements = dataPortion.Split(SEPARATOR, TERMINATOR);
                    UpdateDataDisplay(dataElements);

                    if (dataElements.Length != 6)
                    {
                        continue;
                    }

                    SetText(temp_A0, dataElements[0].Length > 0 ? $"{dataElements[0]} °C" : string.Empty);
                    SetText(temp_A1, dataElements[1].Length > 0 ? $"{dataElements[1]} °C" : string.Empty);
                    SetText(temp_A2, dataElements[2].Length > 0 ? $"{dataElements[2]} °C" : string.Empty);
                    SetText(volt_A3, dataElements[3].Length > 0 ? $"{dataElements[3]} V" : string.Empty);
                    SetText(volt_A4, dataElements[4].Length > 0 ? $"{dataElements[4]} V" : string.Empty);
                    SetText(volt_A5, dataElements[5].Length > 0 ? $"{dataElements[5]} V" : string.Empty);
                }
            }
        }

        private void UpdateDataDisplay(string[] dataElements)
        {
            bool dataAvailable = false;
            string dataText = string.Empty;
            for (var i = 0; i < dataElements.Length; i++)
            {
                if (dataElements[i].Length == 0)
                {
                    continue;
                }

                if (dataAvailable)
                {
                    dataText += $", A{i}: {dataElements[i]}";
                }
                else
                {
                    dataText += $"A{i}: {dataElements[i]}";
                }
                dataAvailable = true;
            }

            if (!dataAvailable)
            {
                dataText = "Empty data received";
            }

            Data_Display.Text = $"{dataText}  {_activity[_activityPos]}";

            _activityPos++;
            if (_activityPos > 3)
            {
                _activityPos = 0;
            }
        }

        private void Start_click(object sender, EventArgs e)
        {
            if (!_port.IsOpen)
            {
                _portData.Length = 0;
                StartMonitor();
            }
            else
            {
                StopMonitor();
            }
        }

        private void StartMonitor()
        {
            try
            {
                _port.PortName = comPorts.Items[comPorts.SelectedIndex].ToString();
                _port.BaudRate = int.Parse(baudRate.Text);
                _port.DataReceived += Port_DataReceived;
                _port.Open();
                startStopButton.Text = "Disconnect";
            }
            catch (Exception ex)
            {
                StopMonitor();
                _port.DataReceived -= Port_DataReceived;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StopMonitor()
        {
            if (_port.IsOpen)
            {
                _port.DataReceived -= Port_DataReceived;
                _port.Close();

                temp_A0.Text = temp_A1.Text = temp_A2.Text = string.Empty;
                volt_A3.Text = volt_A4.Text = volt_A5.Text = string.Empty;
                Data_Display.Text = string.Empty;
                startStopButton.Text = "Connect";
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            StopMonitor();
            FillComPorts();
        }

        private void SensorLabel_Click(object sender, EventArgs e)
        {
            var index = int.Parse(((Label)sender).Tag.ToString());
            ToggleActivePin(index);
        }

        private void ToggleActivePin(int pinIndex)
        {
            if (_port.IsOpen)
            {
                _port.Write(BitConverter.GetBytes(pinIndex), 0, 1);
            }
        }
    }
}
