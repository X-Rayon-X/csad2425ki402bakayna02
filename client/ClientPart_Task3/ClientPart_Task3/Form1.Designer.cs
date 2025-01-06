namespace ClientPart_Task3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.portComboBox = new System.Windows.Forms.ComboBox();
            this.baudRateComboBox = new System.Windows.Forms.ComboBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.labelPort = new System.Windows.Forms.Label();
            this.labelBaudRate = new System.Windows.Forms.Label();
            this.modeComboBox = new System.Windows.Forms.ComboBox();
            this.setModeButton = new System.Windows.Forms.Button();
            this.player1TextBox = new System.Windows.Forms.TextBox();
            this.player2TextBox = new System.Windows.Forms.TextBox();
            this.playButton = new System.Windows.Forms.Button();
            this.player1ResultLabel = new System.Windows.Forms.Label();
            this.player2ResultLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // portComboBox
            // 
            this.portComboBox.FormattingEnabled = true;
            this.portComboBox.Location = new System.Drawing.Point(120, 30);
            this.portComboBox.Name = "portComboBox";
            this.portComboBox.Size = new System.Drawing.Size(121, 24);
            this.portComboBox.TabIndex = 0;
            // 
            // baudRateComboBox
            // 
            this.baudRateComboBox.FormattingEnabled = true;
            this.baudRateComboBox.Location = new System.Drawing.Point(120, 70);
            this.baudRateComboBox.Name = "baudRateComboBox";
            this.baudRateComboBox.Size = new System.Drawing.Size(121, 24);
            this.baudRateComboBox.TabIndex = 1;
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(120, 110);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 2;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // disconnectButton
            // 
            this.disconnectButton.Location = new System.Drawing.Point(220, 110);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(100, 23);
            this.disconnectButton.TabIndex = 3;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(38, 33);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(34, 16);
            this.labelPort.TabIndex = 4;
            this.labelPort.Text = "Port:";
            // 
            // labelBaudRate
            // 
            this.labelBaudRate.AutoSize = true;
            this.labelBaudRate.Location = new System.Drawing.Point(38, 73);
            this.labelBaudRate.Name = "labelBaudRate";
            this.labelBaudRate.Size = new System.Drawing.Size(74, 16);
            this.labelBaudRate.TabIndex = 5;
            this.labelBaudRate.Text = "Baud Rate:";
            // 
            // modeComboBox
            // 
            this.modeComboBox.FormattingEnabled = true;
            this.modeComboBox.Items.AddRange(new object[] {
            "Man vs AI",
            "AI vs AI",
            "Man vs Man"});
            this.modeComboBox.Location = new System.Drawing.Point(120, 150);
            this.modeComboBox.Name = "modeComboBox";
            this.modeComboBox.Size = new System.Drawing.Size(121, 24);
            this.modeComboBox.TabIndex = 6;
            // 
            // setModeButton
            // 
            this.setModeButton.Location = new System.Drawing.Point(120, 180);
            this.setModeButton.Name = "setModeButton";
            this.setModeButton.Size = new System.Drawing.Size(75, 23);
            this.setModeButton.TabIndex = 7;
            this.setModeButton.Text = "Set Mode";
            this.setModeButton.UseVisualStyleBackColor = true;
            this.setModeButton.Click += new System.EventHandler(this.SetModeButton_Click);
            // 
            // player1TextBox
            // 
            this.player1TextBox.Location = new System.Drawing.Point(120, 210);
            this.player1TextBox.Name = "player1TextBox";
            this.player1TextBox.Size = new System.Drawing.Size(121, 22);
            this.player1TextBox.TabIndex = 8;
            // 
            // player2TextBox
            // 
            this.player2TextBox.Location = new System.Drawing.Point(120, 240);
            this.player2TextBox.Name = "player2TextBox";
            this.player2TextBox.Size = new System.Drawing.Size(121, 22);
            this.player2TextBox.TabIndex = 9;
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(120, 270);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 23);
            this.playButton.TabIndex = 10;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // player1ResultLabel
            // 
            this.player1ResultLabel.AutoSize = true;
            this.player1ResultLabel.Location = new System.Drawing.Point(50, 300);
            this.player1ResultLabel.Name = "player1ResultLabel";
            this.player1ResultLabel.Size = new System.Drawing.Size(62, 16);
            this.player1ResultLabel.TabIndex = 11;
            this.player1ResultLabel.Text = "Player 1: ";
            // 
            // player2ResultLabel
            // 
            this.player2ResultLabel.AutoSize = true;
            this.player2ResultLabel.Location = new System.Drawing.Point(50, 320);
            this.player2ResultLabel.Name = "player2ResultLabel";
            this.player2ResultLabel.Size = new System.Drawing.Size(62, 16);
            this.player2ResultLabel.TabIndex = 12;
            this.player2ResultLabel.Text = "Player 2: ";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(50, 340);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(51, 16);
            this.resultLabel.TabIndex = 13;
            this.resultLabel.Text = "Result: ";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(120, 370);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 14;
            this.saveButton.Text = "Save Game";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(220, 370);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 15;
            this.loadButton.Text = "Load Game";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(404, 411);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.player2ResultLabel);
            this.Controls.Add(this.player1ResultLabel);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.player2TextBox);
            this.Controls.Add(this.player1TextBox);
            this.Controls.Add(this.setModeButton);
            this.Controls.Add(this.modeComboBox);
            this.Controls.Add(this.labelBaudRate);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.disconnectButton);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.baudRateComboBox);
            this.Controls.Add(this.portComboBox);
            this.Name = "Form1";
            this.Text = "Serial Port Configuration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox portComboBox;
        private System.Windows.Forms.ComboBox baudRateComboBox;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.Label labelBaudRate;
        private System.Windows.Forms.ComboBox modeComboBox;
        private System.Windows.Forms.Button setModeButton;
        private System.Windows.Forms.TextBox player1TextBox;
        private System.Windows.Forms.TextBox player2TextBox;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label player1ResultLabel;
        private System.Windows.Forms.Label player2ResultLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
    }
}


