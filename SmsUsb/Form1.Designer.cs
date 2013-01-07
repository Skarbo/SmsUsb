namespace SmsUsb
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
            this.devicesButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.adbPathTextBox = new System.Windows.Forms.TextBox();
            this.devicesListBox = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.recievePathTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sendPathTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deviceSelectedRadioButton = new System.Windows.Forms.RadioButton();
            this.deviceRunningRadioButton = new System.Windows.Forms.RadioButton();
            this.deviceUsbRadioButton = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.sendMessageInfoLabel = new System.Windows.Forms.Label();
            this.messageSendTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.receiverTextBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.recieveDateTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.receiveInfoLabel = new System.Windows.Forms.Label();
            this.replyButton = new System.Windows.Forms.Button();
            this.recieveMessageTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.recieveSenderTextBox = new System.Windows.Forms.TextBox();
            this.receiveMessageButton = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // devicesButton
            // 
            this.devicesButton.Location = new System.Drawing.Point(6, 91);
            this.devicesButton.Name = "devicesButton";
            this.devicesButton.Size = new System.Drawing.Size(75, 23);
            this.devicesButton.TabIndex = 0;
            this.devicesButton.Text = "Devices";
            this.devicesButton.UseVisualStyleBackColor = true;
            this.devicesButton.Click += new System.EventHandler(this.devicesButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ADB folder path";
            // 
            // adbPathTextBox
            // 
            this.adbPathTextBox.Location = new System.Drawing.Point(94, 6);
            this.adbPathTextBox.Name = "adbPathTextBox";
            this.adbPathTextBox.Size = new System.Drawing.Size(411, 20);
            this.adbPathTextBox.TabIndex = 2;
            this.adbPathTextBox.TextChanged += new System.EventHandler(this.adbPathTextBox_TextChanged);
            // 
            // devicesListBox
            // 
            this.devicesListBox.FormattingEnabled = true;
            this.devicesListBox.Location = new System.Drawing.Point(6, 120);
            this.devicesListBox.Name = "devicesListBox";
            this.devicesListBox.Size = new System.Drawing.Size(484, 69);
            this.devicesListBox.TabIndex = 4;
            this.devicesListBox.SelectedIndexChanged += new System.EventHandler(this.devicesListBox_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(519, 327);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.recievePathTextBox);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.sendPathTextBox);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.adbPathTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(511, 301);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Config";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // recievePathTextBox
            // 
            this.recievePathTextBox.Location = new System.Drawing.Point(104, 266);
            this.recievePathTextBox.Name = "recievePathTextBox";
            this.recievePathTextBox.Size = new System.Drawing.Size(395, 20);
            this.recievePathTextBox.TabIndex = 9;
            this.recievePathTextBox.TextChanged += new System.EventHandler(this.recievePathTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Recieve file path";
            // 
            // sendPathTextBox
            // 
            this.sendPathTextBox.Location = new System.Drawing.Point(104, 240);
            this.sendPathTextBox.Name = "sendPathTextBox";
            this.sendPathTextBox.Size = new System.Drawing.Size(395, 20);
            this.sendPathTextBox.TabIndex = 7;
            this.sendPathTextBox.TextChanged += new System.EventHandler(this.sendPathTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Send file path";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deviceSelectedRadioButton);
            this.groupBox1.Controls.Add(this.deviceRunningRadioButton);
            this.groupBox1.Controls.Add(this.deviceUsbRadioButton);
            this.groupBox1.Controls.Add(this.devicesButton);
            this.groupBox1.Controls.Add(this.devicesListBox);
            this.groupBox1.Location = new System.Drawing.Point(9, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 201);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Device";
            // 
            // deviceSelectedRadioButton
            // 
            this.deviceSelectedRadioButton.AutoSize = true;
            this.deviceSelectedRadioButton.Location = new System.Drawing.Point(6, 68);
            this.deviceSelectedRadioButton.Name = "deviceSelectedRadioButton";
            this.deviceSelectedRadioButton.Size = new System.Drawing.Size(102, 17);
            this.deviceSelectedRadioButton.TabIndex = 7;
            this.deviceSelectedRadioButton.Text = "Selected device";
            this.deviceSelectedRadioButton.UseVisualStyleBackColor = true;
            this.deviceSelectedRadioButton.CheckedChanged += new System.EventHandler(this.deviceSelectedRadioButton_CheckedChanged);
            // 
            // deviceRunningRadioButton
            // 
            this.deviceRunningRadioButton.AutoSize = true;
            this.deviceRunningRadioButton.Location = new System.Drawing.Point(7, 44);
            this.deviceRunningRadioButton.Name = "deviceRunningRadioButton";
            this.deviceRunningRadioButton.Size = new System.Drawing.Size(108, 17);
            this.deviceRunningRadioButton.TabIndex = 6;
            this.deviceRunningRadioButton.Text = "Running emulator";
            this.deviceRunningRadioButton.UseVisualStyleBackColor = true;
            this.deviceRunningRadioButton.CheckedChanged += new System.EventHandler(this.deviceRunningRadioButton_CheckedChanged);
            // 
            // deviceUsbRadioButton
            // 
            this.deviceUsbRadioButton.AutoSize = true;
            this.deviceUsbRadioButton.Checked = true;
            this.deviceUsbRadioButton.Location = new System.Drawing.Point(7, 20);
            this.deviceUsbRadioButton.Name = "deviceUsbRadioButton";
            this.deviceUsbRadioButton.Size = new System.Drawing.Size(102, 17);
            this.deviceUsbRadioButton.TabIndex = 5;
            this.deviceUsbRadioButton.TabStop = true;
            this.deviceUsbRadioButton.Text = "Connected USB";
            this.deviceUsbRadioButton.UseVisualStyleBackColor = true;
            this.deviceUsbRadioButton.CheckedChanged += new System.EventHandler(this.deviceUsbRadioButton_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.sendMessageInfoLabel);
            this.tabPage2.Controls.Add(this.messageSendTextBox);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.receiverTextBox);
            this.tabPage2.Controls.Add(this.sendButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(511, 301);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Send";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // sendMessageInfoLabel
            // 
            this.sendMessageInfoLabel.AutoSize = true;
            this.sendMessageInfoLabel.Location = new System.Drawing.Point(10, 273);
            this.sendMessageInfoLabel.Name = "sendMessageInfoLabel";
            this.sendMessageInfoLabel.Size = new System.Drawing.Size(10, 13);
            this.sendMessageInfoLabel.TabIndex = 4;
            this.sendMessageInfoLabel.Text = " ";
            // 
            // messageSendTextBox
            // 
            this.messageSendTextBox.Location = new System.Drawing.Point(10, 35);
            this.messageSendTextBox.Multiline = true;
            this.messageSendTextBox.Name = "messageSendTextBox";
            this.messageSendTextBox.Size = new System.Drawing.Size(495, 231);
            this.messageSendTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Reciever:";
            // 
            // receiverTextBox
            // 
            this.receiverTextBox.Location = new System.Drawing.Point(63, 4);
            this.receiverTextBox.Name = "receiverTextBox";
            this.receiverTextBox.Size = new System.Drawing.Size(201, 20);
            this.receiverTextBox.TabIndex = 1;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(430, 272);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 0;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.recieveDateTextBox);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.receiveInfoLabel);
            this.tabPage4.Controls.Add(this.replyButton);
            this.tabPage4.Controls.Add(this.recieveMessageTextBox);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.recieveSenderTextBox);
            this.tabPage4.Controls.Add(this.receiveMessageButton);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(511, 301);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Recieve";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // recieveDateTextBox
            // 
            this.recieveDateTextBox.Location = new System.Drawing.Point(262, 6);
            this.recieveDateTextBox.Name = "recieveDateTextBox";
            this.recieveDateTextBox.ReadOnly = true;
            this.recieveDateTextBox.Size = new System.Drawing.Size(110, 20);
            this.recieveDateTextBox.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(225, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Date";
            // 
            // receiveInfoLabel
            // 
            this.receiveInfoLabel.AutoSize = true;
            this.receiveInfoLabel.Location = new System.Drawing.Point(7, 273);
            this.receiveInfoLabel.Name = "receiveInfoLabel";
            this.receiveInfoLabel.Size = new System.Drawing.Size(10, 13);
            this.receiveInfoLabel.TabIndex = 5;
            this.receiveInfoLabel.Text = " ";
            // 
            // replyButton
            // 
            this.replyButton.Enabled = false;
            this.replyButton.Location = new System.Drawing.Point(349, 272);
            this.replyButton.Name = "replyButton";
            this.replyButton.Size = new System.Drawing.Size(75, 23);
            this.replyButton.TabIndex = 4;
            this.replyButton.Text = "Reply";
            this.replyButton.UseVisualStyleBackColor = true;
            this.replyButton.Click += new System.EventHandler(this.replyButton_Click);
            // 
            // recieveMessageTextBox
            // 
            this.recieveMessageTextBox.Location = new System.Drawing.Point(6, 32);
            this.recieveMessageTextBox.Multiline = true;
            this.recieveMessageTextBox.Name = "recieveMessageTextBox";
            this.recieveMessageTextBox.ReadOnly = true;
            this.recieveMessageTextBox.Size = new System.Drawing.Size(499, 234);
            this.recieveMessageTextBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Sender";
            // 
            // recieveSenderTextBox
            // 
            this.recieveSenderTextBox.Location = new System.Drawing.Point(50, 6);
            this.recieveSenderTextBox.Name = "recieveSenderTextBox";
            this.recieveSenderTextBox.ReadOnly = true;
            this.recieveSenderTextBox.Size = new System.Drawing.Size(168, 20);
            this.recieveSenderTextBox.TabIndex = 1;
            this.recieveSenderTextBox.TextChanged += new System.EventHandler(this.recieveSenderTextBox_TextChanged);
            // 
            // receiveMessageButton
            // 
            this.receiveMessageButton.Location = new System.Drawing.Point(430, 272);
            this.receiveMessageButton.Name = "receiveMessageButton";
            this.receiveMessageButton.Size = new System.Drawing.Size(75, 23);
            this.receiveMessageButton.TabIndex = 0;
            this.receiveMessageButton.Text = "Recieve";
            this.receiveMessageButton.UseVisualStyleBackColor = true;
            this.receiveMessageButton.Click += new System.EventHandler(this.receiveMessageButton_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox2);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(511, 301);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Run";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(7, 33);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(498, 262);
            this.textBox2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 350);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button devicesButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox adbPathTextBox;
        private System.Windows.Forms.ListBox devicesListBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton deviceSelectedRadioButton;
        private System.Windows.Forms.RadioButton deviceRunningRadioButton;
        private System.Windows.Forms.RadioButton deviceUsbRadioButton;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox messageSendTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox receiverTextBox;
        private System.Windows.Forms.TextBox recievePathTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sendPathTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label sendMessageInfoLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label receiveInfoLabel;
        private System.Windows.Forms.Button replyButton;
        private System.Windows.Forms.TextBox recieveMessageTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox recieveSenderTextBox;
        private System.Windows.Forms.Button receiveMessageButton;
        private System.Windows.Forms.TextBox recieveDateTextBox;
        private System.Windows.Forms.Label label6;
    }
}

