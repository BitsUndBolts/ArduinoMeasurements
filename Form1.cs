using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

namespace ArduinoTemperatureMonitor
{
    public partial class Form1 : Form
    {
        readonly Random rnd = new Random();
        readonly SerialPort _port = new SerialPort();

        public Form1()
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
            }

            if (availablePorts.Length > 0)
            {
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
                    Invoke(d, new object[] { temp_label, text });
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

            SetText(temp_label, $"{new string(z)} °C");
        }

        private void Start_click(object sender, EventArgs e)
        {
            if (StartMonitor())
            {
                startStopButton.Text = "Stop";
            }
            else
            {
                StopMonitor();
                startStopButton.Text = "Start";
            }
        }

        private bool StartMonitor()
        {
            if (!_port.IsOpen)
            {
                try
                {
                    _port.PortName = comPorts.Items[comPorts.SelectedIndex].ToString();
                    _port.BaudRate = int.Parse(baudRate.Text);
                    _port.DataReceived += Port_DataReceived;
                    _port.Open();
                    return true;
                }
                catch (Exception ex)
                {
                    StopMonitor();
                    _port.DataReceived -= Port_DataReceived;
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return false;
        }

        private bool StopMonitor()
        {
            if (_port.IsOpen)
            {
                _port.DataReceived -= Port_DataReceived;
                _port.Close();
                temp_label.Text = "No Data";
                return true;
            }
            return false;
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            StopMonitor();
            FillComPorts();
        }

        private void TempLabel_Click(object sender, EventArgs e)
        {
            if (((MouseEventArgs)e).Button == MouseButtons.Right)
            {
                temp_label.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                temp_label.ForeColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            }
            else if (((MouseEventArgs)e).Button == MouseButtons.Left)
            {
                temp_label.BackColor = Color.Blue;
                temp_label.ForeColor = Color.White;
            }
            else if (((MouseEventArgs)e).Button == MouseButtons.Middle)
            {
                temp_label.BackColor = DefaultBackColor;
                temp_label.ForeColor = Color.Black;
            }
        }
    }
}
