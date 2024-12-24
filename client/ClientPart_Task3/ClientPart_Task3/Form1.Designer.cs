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
            this.modeComboBox = new System.Windows.Forms.ComboBox();
            this.setModeButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.player1TextBox = new System.Windows.Forms.TextBox();
            this.player1ResultLabel = new System.Windows.Forms.Label();
            this.player2ResultLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.player2TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // modeComboBox
            // 
            this.modeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modeComboBox.FormattingEnabled = true;
            this.modeComboBox.Items.AddRange(new object[] {
            "Man vs AI",
            "Man vs Man",
            "AI vs AI"});
            this.modeComboBox.Location = new System.Drawing.Point(16, 15);
            this.modeComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.modeComboBox.Name = "modeComboBox";
            this.modeComboBox.Size = new System.Drawing.Size(265, 24);
            this.modeComboBox.TabIndex = 0;
            // 
            // setModeButton
            // 
            this.setModeButton.Location = new System.Drawing.Point(293, 12);
            this.setModeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.setModeButton.Name = "setModeButton";
            this.setModeButton.Size = new System.Drawing.Size(100, 28);
            this.setModeButton.TabIndex = 1;
            this.setModeButton.Text = "Set Mode";
            this.setModeButton.UseVisualStyleBackColor = true;
            this.setModeButton.Click += new System.EventHandler(this.SetModeButton_Click);
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(16, 62);
            this.playButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(100, 28);
            this.playButton.TabIndex = 2;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(16, 128);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 28);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(133, 128);
            this.loadButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(100, 28);
            this.loadButton.TabIndex = 4;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // player1TextBox
            // 
            this.player1TextBox.Location = new System.Drawing.Point(133, 64);
            this.player1TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.player1TextBox.Name = "player1TextBox";
            this.player1TextBox.Size = new System.Drawing.Size(148, 22);
            this.player1TextBox.TabIndex = 5;
            // 
            // player1ResultLabel
            // 
            this.player1ResultLabel.AutoSize = true;
            this.player1ResultLabel.Location = new System.Drawing.Point(16, 160);
            this.player1ResultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.player1ResultLabel.Name = "player1ResultLabel";
            this.player1ResultLabel.Size = new System.Drawing.Size(62, 16);
            this.player1ResultLabel.TabIndex = 6;
            this.player1ResultLabel.Text = "Player 1: ";
            // 
            // player2ResultLabel
            // 
            this.player2ResultLabel.AutoSize = true;
            this.player2ResultLabel.Location = new System.Drawing.Point(16, 185);
            this.player2ResultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.player2ResultLabel.Name = "player2ResultLabel";
            this.player2ResultLabel.Size = new System.Drawing.Size(62, 16);
            this.player2ResultLabel.TabIndex = 7;
            this.player2ResultLabel.Text = "Player 2: ";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(16, 209);
            this.resultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(51, 16);
            this.resultLabel.TabIndex = 8;
            this.resultLabel.Text = "Result: ";
            // 
            // player2TextBox
            // 
            this.player2TextBox.Location = new System.Drawing.Point(133, 94);
            this.player2TextBox.Name = "player2TextBox";
            this.player2TextBox.Size = new System.Drawing.Size(148, 22);
            this.player2TextBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 246);
            this.Controls.Add(this.player2TextBox);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.player2ResultLabel);
            this.Controls.Add(this.player1ResultLabel);
            this.Controls.Add(this.player1TextBox);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.setModeButton);
            this.Controls.Add(this.modeComboBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Rock Paper Scissors";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox modeComboBox;
        private System.Windows.Forms.Button setModeButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.TextBox player1TextBox;
        private System.Windows.Forms.Label player1ResultLabel;
        private System.Windows.Forms.Label player2ResultLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TextBox player2TextBox;
    }
}


