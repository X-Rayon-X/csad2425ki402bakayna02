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
            InitializeSerialPort();
        }

        private void InitializeSerialPort()
        {
            serialPort = new SerialPort("COM5", 9600);  // Вкажіть правильний COM порт
            serialPort.ReadTimeout = 5000;  // Тайм-аут на читання 5000 мс (5 секунд)
            serialPort.Open();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Отримуємо текст з TextBox
                string inputText = inputTextBox.Text;

                // Відправляємо на Arduino
                serialPort.WriteLine(inputText);

                // Читаємо змінений текст з Arduino з тайм-аутом
                string modifiedText = serialPort.ReadLine();

                // Відображаємо змінений текст в Label
                resultLabel.Text = "Modified Text: " + modifiedText;
            }
            catch (TimeoutException)
            {
                MessageBox.Show("Error: Arduino did not respond within the timeout period.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }
        }
    }
}
