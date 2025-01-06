using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace ClientPart_Task2
{
    public partial class Form1 : Form
    {
        private SerialPort serialPort;

        public Form1()
        {
            InitializeComponent();
            InitializeSerialPortSettings();
        }

        private void InitializeSerialPortSettings()
        {
            comboBoxPorts.Items.AddRange(SerialPort.GetPortNames());
            comboBoxBaudRate.Items.AddRange(new object[] { 9600, 19200, 38400, 57600, 115200 });
            comboBoxBaudRate.SelectedIndex = 0; // Default baud rate

            buttonConnect.Click += ButtonConnect_Click;
            buttonSend.Click += ButtonSend_Click;
        }

        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            if (serialPort == null)
            {
                try
                {
                    string selectedPort = comboBoxPorts.SelectedItem.ToString();
                    int baudRate = int.Parse(comboBoxBaudRate.SelectedItem.ToString());

                    serialPort = new SerialPort(selectedPort, baudRate);
                    serialPort.DataReceived += SerialPort_DataReceived;
                    serialPort.Open();

                    MessageBox.Show("Connected to " + selectedPort);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void ButtonSend_Click(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                try
                {
                    string message = textBoxSend.Text;
                    serialPort.WriteLine(message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Serial port is not connected.");
            }
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string receivedData = serialPort.ReadLine();
            Invoke(new Action(() => textBoxReceived.Text = receivedData));
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.Close();
            }
        }
    }
}