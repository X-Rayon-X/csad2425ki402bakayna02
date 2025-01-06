namespace ClientPart_Task2
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

        //#region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.comboBoxPorts = new System.Windows.Forms.ComboBox();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.textBoxSend = new System.Windows.Forms.TextBox();
            this.textBoxReceived = new System.Windows.Forms.TextBox();
            this.labelPorts = new System.Windows.Forms.Label();
            this.labelBaudRate = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // comboBoxPorts
            this.comboBoxPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(20, 30);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPorts.TabIndex = 0;

            // comboBoxBaudRate
            this.comboBoxBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Location = new System.Drawing.Point(20, 80);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBaudRate.TabIndex = 1;

            // buttonConnect
            this.buttonConnect.Location = new System.Drawing.Point(160, 30);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;

            // buttonSend
            this.buttonSend.Location = new System.Drawing.Point(160, 80);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 3;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;

            // textBoxSend
            this.textBoxSend.Location = new System.Drawing.Point(20, 130);
            this.textBoxSend.Name = "textBoxSend";
            this.textBoxSend.Size = new System.Drawing.Size(215, 20);
            this.textBoxSend.TabIndex = 4;

            // textBoxReceived
            this.textBoxReceived.Location = new System.Drawing.Point(20, 180);
            this.textBoxReceived.Name = "textBoxReceived";
            this.textBoxReceived.ReadOnly = true;
            this.textBoxReceived.Size = new System.Drawing.Size(215, 20);
            this.textBoxReceived.TabIndex = 5;

            // labelPorts
            this.labelPorts.AutoSize = true;
            this.labelPorts.Location = new System.Drawing.Point(20, 10);
            this.labelPorts.Name = "labelPorts";
            this.labelPorts.Size = new System.Drawing.Size(31, 13);
            this.labelPorts.TabIndex = 6;
            this.labelPorts.Text = "Ports";

            // labelBaudRate
            this.labelBaudRate.AutoSize = true;
            this.labelBaudRate.Location = new System.Drawing.Point(20, 60);
            this.labelBaudRate.Name = "labelBaudRate";
            this.labelBaudRate.Size = new System.Drawing.Size(58, 13);
            this.labelBaudRate.TabIndex = 7;
            this.labelBaudRate.Text = "Baud Rate";

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.labelBaudRate);
            this.Controls.Add(this.labelPorts);
            this.Controls.Add(this.textBoxReceived);
            this.Controls.Add(this.textBoxSend);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.comboBoxBaudRate);
            this.Controls.Add(this.comboBoxPorts);
            this.Name = "Form1";
            this.Text = "Serial Port Communication";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ComboBox comboBoxPorts;
        private System.Windows.Forms.ComboBox comboBoxBaudRate;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.TextBox textBoxSend;
        private System.Windows.Forms.TextBox textBoxReceived;
        private System.Windows.Forms.Label labelPorts;
        private System.Windows.Forms.Label labelBaudRate;
    }
}


