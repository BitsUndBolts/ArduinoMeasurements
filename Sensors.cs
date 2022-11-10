using System;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;

namespace ArduinoTemperatureMonitor
{
    public partial class Sensors : Form
    {
        private readonly SerialPort _port = new SerialPort();
        private readonly StringBuilder portData = new StringBuilder();
        private const char SEPARATOR = '|';
        private const char TERMINATOR = ';';
        private readonly bool[] activePanels = new bool[6] { true, false, false, true, false, false };

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
                    Invoke(d, new object[] { control, text });
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
            portData.Append(z);

            if (Array.IndexOf(z, TERMINATOR) > -1)
            {
                while (portData.ToString().IndexOf(TERMINATOR) > -1)
                {
                    var fullPortData = portData.ToString();
                    var terminatorPosition = fullPortData.IndexOf(TERMINATOR);
                    var dataPortion = fullPortData.Substring(0, terminatorPosition);
                    portData.Remove(0, terminatorPosition + 1);
                    var dataElements = dataPortion.Split(SEPARATOR, TERMINATOR);

                    if (dataElements.Length != 6)
                    {
                        continue;
                    }

                    SetText(temp_A0, activePanels[0] && dataElements[0].Length > 0 ? $"{dataElements[0]} °C" : string.Empty);
                    SetText(temp_A1, activePanels[1] && dataElements[1].Length > 0 ? $"{dataElements[1]} °C" : string.Empty);
                    SetText(temp_A2, activePanels[2] && dataElements[2].Length > 0 ? $"{dataElements[2]} °C" : string.Empty);
                    SetText(volt_A3, activePanels[3] && dataElements[3].Length > 0 ? $"{dataElements[3]} V" : string.Empty);
                    SetText(volt_A4, activePanels[4] && dataElements[4].Length > 0 ? $"{dataElements[4]} V" : string.Empty);
                    SetText(volt_A5, activePanels[5] && dataElements[5].Length > 0 ? $"{dataElements[5]} V" : string.Empty);
                }
            }
        }

        private void Start_click(object sender, EventArgs e)
        {
            if (!_port.IsOpen)
            {
                portData.Length = 0;
                StartMonitor();
                UpdateArduino();
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
                startStopButton.Text = "Stop";
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
                SetText(temp_A0, string.Empty);
                SetText(temp_A1, string.Empty);
                SetText(temp_A2, string.Empty);
                SetText(volt_A3, string.Empty);
                SetText(volt_A4, string.Empty);
                SetText(volt_A5, string.Empty);
                startStopButton.Text = "Start";
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
            activePanels[index] = !activePanels[index];
            UpdateArduino();
        }

        private void UpdateArduino()
        {
            if (_port.IsOpen)
            {
                foreach(var panel in activePanels)
                {
                    _port.Write(panel ? "1" : "0");
                }
            }
        }
    }
}
