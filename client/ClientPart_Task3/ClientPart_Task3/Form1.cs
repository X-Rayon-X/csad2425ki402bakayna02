using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace ClientPart_Task3
{
    public partial class Form1 : Form
    {
        private SerialPort serialPort;

        public Form1()
        {
            InitializeComponent();
            serialPort = new SerialPort("COM5", 9600);
            serialPort.ReadTimeout = 5000;  // 5 секунд для зчитування
            serialPort.WriteTimeout = 5000; // 5 секунд для запису
            serialPort.Open();
        }

        public string globalSelectedMode;


        private void SetModeButton_Click(object sender, EventArgs e)
        {
            string selectedMode = modeComboBox.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedMode))
            {
                try
                {
                    globalSelectedMode = selectedMode;
                    // Send the command to set the game mode
                    serialPort.WriteLine("set_mode " + selectedMode);
                    MessageBox.Show("Mode set to: " + selectedMode);
                }
                catch (TimeoutException)
                {
                    MessageBox.Show("Timeout while setting mode.");
                }
            }
            else
            {
                MessageBox.Show("Please select a mode.");
            }
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            if (globalSelectedMode == "Man vs AI")
            {
                string player1 = player1TextBox.Text;

                if (string.IsNullOrEmpty(player1))
                {
                    MessageBox.Show("Player 1 must make a choice.");
                    return;
                }

                try
                {
                    // Send the play command with player1's choice
                    serialPort.WriteLine("play player1 " + player1);

                    string response1 = serialPort.ReadLine();
                    //MessageBox.Show("Response from Arduino: " + response1); // Для перевірки
                    string response2 = serialPort.ReadLine();
                    //MessageBox.Show("Response from Arduino: " + response2); // Для перевірки
                    string response3 = serialPort.ReadLine();
                    //MessageBox.Show("Response from Arduino: " + response3); // Для перевірки

                    // Перевірка, чи містить відповідь необхідні рядки
                    string result1 = response1;
                    string result2 = response2;
                    string result3 = response3;
                    if (result1.Length >= 3 && result2.Length >= 3 && result3.Length >= 3) // Перевірка на кількість елементів
                    {
                        player1ResultLabel.Text = "Player 1: " + result1;
                        player2ResultLabel.Text = "Player 2: " + result2;
                        resultLabel.Text = "Result: " + result3;
                    }
                    else
                    {
                        MessageBox.Show("Invalid response from Arduino.");
                    }
                }

                catch (TimeoutException)
                {
                    MessageBox.Show("Timeout while waiting for response.");
                }
                catch (IndexOutOfRangeException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else if (globalSelectedMode == "AI vs AI")
            {

                try
                {
                    // Send the play command
                    serialPort.WriteLine("play");

                    string response1 = serialPort.ReadLine();
                    //MessageBox.Show("Response from Arduino: " + response1); // Для перевірки
                    string response2 = serialPort.ReadLine();
                    //MessageBox.Show("Response from Arduino: " + response2); // Для перевірки
                    string response3 = serialPort.ReadLine();
                    //MessageBox.Show("Response from Arduino: " + response3); // Для перевірки

                    // Перевірка, чи містить відповідь необхідні рядки
                    string result1 = response1;
                    string result2 = response2;
                    string result3 = response3;
                    if (result1.Length >= 3 && result2.Length >= 3 && result3.Length >= 3) // Перевірка на кількість елементів
                    {
                        player1ResultLabel.Text = "Player 1: " + result1;
                        player2ResultLabel.Text = "Player 2: " + result2;
                        resultLabel.Text = "Result: " + result3;
                    }
                    else
                    {
                        MessageBox.Show("Invalid response from Arduino.");
                    }
                }

                catch (TimeoutException)
                {
                    MessageBox.Show("Timeout while waiting for response.");
                }
                catch (IndexOutOfRangeException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                try
                {
                    // Надсилаємо команду для гри
                    string player1Choice = player1TextBox.Text; // Вибір гравця 1 з текстового поля
                    string player2Choice = player2TextBox.Text; // Додаємо текстове поле для гравця 2

                    // Перевіряємо, чи обидва гравці зробили вибір
                    if (string.IsNullOrEmpty(player1Choice) || string.IsNullOrEmpty(player2Choice))
                    {
                        MessageBox.Show("Both players must make a choice!");
                        return;
                    }

                    // Формуємо команду для Arduino
                    string command = $"play player1 {player1Choice} player2 {player2Choice}";
                    serialPort.WriteLine(command);

                    // Отримуємо відповідь від Arduino
                    string response1 = serialPort.ReadLine(); // Хід гравця 1
                    string response2 = serialPort.ReadLine(); // Хід гравця 2
                    string response3 = serialPort.ReadLine(); // Результат

                    // Оновлюємо інтерфейс
                    if (!string.IsNullOrEmpty(response1) &&
                        !string.IsNullOrEmpty(response2) &&
                        !string.IsNullOrEmpty(response3))
                    {
                        player1ResultLabel.Text = "Player 1: " + response1;
                        player2ResultLabel.Text = "Player 2: " + response2;
                        resultLabel.Text = "Result: " + response3;
                    }
                    else
                    {
                        MessageBox.Show("Invalid response from Arduino. Ensure Arduino sends correct data.");
                    }
                }

                catch (TimeoutException)
                {
                    MessageBox.Show("Timeout while waiting for response.");
                }
                catch (IndexOutOfRangeException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Send save command
                serialPort.WriteLine("save");
                MessageBox.Show("Game state saved.");
            }
            catch (TimeoutException)
            {
                MessageBox.Show("Timeout while saving the game.");
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Send load command
                serialPort.WriteLine("load");
                MessageBox.Show("Game state loaded.");
                string response1 = serialPort.ReadLine();
                string response2 = serialPort.ReadLine(); // Хід гравця 1
                string response3 = serialPort.ReadLine(); // Хід гравця 2
                string response4 = serialPort.ReadLine(); // Результат


                // Оновлюємо інтерфейс
                if (!string.IsNullOrEmpty(response1) &&
                    !string.IsNullOrEmpty(response2) &&
                    !string.IsNullOrEmpty(response3) &&
                    !string.IsNullOrEmpty(response4))
                {
                    // Видаляємо зайві пробіли
                    response1 = response1.Trim();

                    // Вибираємо відповідний режим у ComboBox
                    if (modeComboBox.Items.Contains(response1))
                    {
                        modeComboBox.SelectedItem = response1;
                        SetModeButton_Click(this, EventArgs.Empty);
                    }
                    else
                    {
                        MessageBox.Show($"Unknown mode: '{response1}'. Please check Arduino's output.");
                    }

                    player1ResultLabel.Text = "Player 1: " + response2;
                    player2ResultLabel.Text = "Player 2: " + response3;
                    resultLabel.Text = "Result: " + response4;
                }
                else
                {
                    MessageBox.Show("Invalid response from Arduino. Ensure Arduino sends correct data.");
                }
            }
            catch (TimeoutException)
            {
                MessageBox.Show("Timeout while loading the game.");
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialPort.Close();
        }
    }
}
