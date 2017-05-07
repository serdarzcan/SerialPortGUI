namespace serialportgui
{
    partial class SettingsForm
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
            this.labelBaud = new System.Windows.Forms.Label();
            this.textBoxBaudRate = new System.Windows.Forms.TextBox();
            this.labelDataBits = new System.Windows.Forms.Label();
            this.textBoxDataBits = new System.Windows.Forms.TextBox();
            this.labelHandshake = new System.Windows.Forms.Label();
            this.CB_HANDSHAKE = new System.Windows.Forms.ComboBox();
            this.labelParity = new System.Windows.Forms.Label();
            this.CB_PARITY = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_DISCARDNULL = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CB_DTRENABLE = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxParityReplace = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxReadBufferSize = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxReadTimeout = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxReceivedByteThr = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CB_RTSENABLE = new System.Windows.Forms.ComboBox();
            this.SETDEFAULTS = new System.Windows.Forms.Button();
            this.CANCEL = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.CB_STOPBITS = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelBaud
            // 
            this.labelBaud.AutoSize = true;
            this.labelBaud.Location = new System.Drawing.Point(12, 9);
            this.labelBaud.Name = "labelBaud";
            this.labelBaud.Size = new System.Drawing.Size(107, 25);
            this.labelBaud.TabIndex = 0;
            this.labelBaud.Text = "BaudRate";
            // 
            // textBoxBaudRate
            // 
            this.textBoxBaudRate.Location = new System.Drawing.Point(271, 9);
            this.textBoxBaudRate.Name = "textBoxBaudRate";
            this.textBoxBaudRate.Size = new System.Drawing.Size(288, 31);
            this.textBoxBaudRate.TabIndex = 1;
            // 
            // labelDataBits
            // 
            this.labelDataBits.AutoSize = true;
            this.labelDataBits.Location = new System.Drawing.Point(12, 54);
            this.labelDataBits.Name = "labelDataBits";
            this.labelDataBits.Size = new System.Drawing.Size(93, 25);
            this.labelDataBits.TabIndex = 2;
            this.labelDataBits.Text = "DataBits";
            // 
            // textBoxDataBits
            // 
            this.textBoxDataBits.Location = new System.Drawing.Point(271, 54);
            this.textBoxDataBits.Name = "textBoxDataBits";
            this.textBoxDataBits.Size = new System.Drawing.Size(288, 31);
            this.textBoxDataBits.TabIndex = 3;
            // 
            // labelHandshake
            // 
            this.labelHandshake.AutoSize = true;
            this.labelHandshake.Location = new System.Drawing.Point(12, 189);
            this.labelHandshake.Name = "labelHandshake";
            this.labelHandshake.Size = new System.Drawing.Size(121, 25);
            this.labelHandshake.TabIndex = 4;
            this.labelHandshake.Text = "Handshake";
            // 
            // CB_HANDSHAKE
            // 
            this.CB_HANDSHAKE.FormattingEnabled = true;
            this.CB_HANDSHAKE.Items.AddRange(new object[] {
            "None",
            "XOnXOff",
            "RequestToSend",
            "RequestToSendXOnXOff"});
            this.CB_HANDSHAKE.Location = new System.Drawing.Point(271, 189);
            this.CB_HANDSHAKE.Name = "CB_HANDSHAKE";
            this.CB_HANDSHAKE.Size = new System.Drawing.Size(288, 33);
            this.CB_HANDSHAKE.TabIndex = 5;
            // 
            // labelParity
            // 
            this.labelParity.AutoSize = true;
            this.labelParity.Location = new System.Drawing.Point(13, 234);
            this.labelParity.Name = "labelParity";
            this.labelParity.Size = new System.Drawing.Size(67, 25);
            this.labelParity.TabIndex = 6;
            this.labelParity.Text = "Parity";
            // 
            // CB_PARITY
            // 
            this.CB_PARITY.FormattingEnabled = true;
            this.CB_PARITY.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.CB_PARITY.Location = new System.Drawing.Point(271, 234);
            this.CB_PARITY.Name = "CB_PARITY";
            this.CB_PARITY.Size = new System.Drawing.Size(288, 33);
            this.CB_PARITY.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "DiscardNull";
            // 
            // CB_DISCARDNULL
            // 
            this.CB_DISCARDNULL.FormattingEnabled = true;
            this.CB_DISCARDNULL.Items.AddRange(new object[] {
            "True",
            "False"});
            this.CB_DISCARDNULL.Location = new System.Drawing.Point(271, 99);
            this.CB_DISCARDNULL.Name = "CB_DISCARDNULL";
            this.CB_DISCARDNULL.Size = new System.Drawing.Size(288, 33);
            this.CB_DISCARDNULL.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "DtrEnable";
            // 
            // CB_DTRENABLE
            // 
            this.CB_DTRENABLE.FormattingEnabled = true;
            this.CB_DTRENABLE.Items.AddRange(new object[] {
            "True",
            "False"});
            this.CB_DTRENABLE.Location = new System.Drawing.Point(271, 144);
            this.CB_DTRENABLE.Name = "CB_DTRENABLE";
            this.CB_DTRENABLE.Size = new System.Drawing.Size(288, 33);
            this.CB_DTRENABLE.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "ParityReplace";
            // 
            // textBoxParityReplace
            // 
            this.textBoxParityReplace.Location = new System.Drawing.Point(271, 279);
            this.textBoxParityReplace.Name = "textBoxParityReplace";
            this.textBoxParityReplace.Size = new System.Drawing.Size(288, 31);
            this.textBoxParityReplace.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "ReadBufferSize";
            // 
            // textBoxReadBufferSize
            // 
            this.textBoxReadBufferSize.Location = new System.Drawing.Point(271, 324);
            this.textBoxReadBufferSize.Name = "textBoxReadBufferSize";
            this.textBoxReadBufferSize.Size = new System.Drawing.Size(288, 31);
            this.textBoxReadBufferSize.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "ReadTimeout";
            // 
            // textBoxReadTimeout
            // 
            this.textBoxReadTimeout.Location = new System.Drawing.Point(271, 369);
            this.textBoxReadTimeout.Name = "textBoxReadTimeout";
            this.textBoxReadTimeout.Size = new System.Drawing.Size(288, 31);
            this.textBoxReadTimeout.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 414);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(252, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "ReceivedBytesThreshold";
            // 
            // textBoxReceivedByteThr
            // 
            this.textBoxReceivedByteThr.Location = new System.Drawing.Point(271, 414);
            this.textBoxReceivedByteThr.Name = "textBoxReceivedByteThr";
            this.textBoxReceivedByteThr.Size = new System.Drawing.Size(288, 31);
            this.textBoxReceivedByteThr.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 504);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 25);
            this.label7.TabIndex = 20;
            this.label7.Text = "StopBits";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 459);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 25);
            this.label8.TabIndex = 22;
            this.label8.Text = "RtsEnable";
            // 
            // CB_RTSENABLE
            // 
            this.CB_RTSENABLE.FormattingEnabled = true;
            this.CB_RTSENABLE.Items.AddRange(new object[] {
            "True",
            "False"});
            this.CB_RTSENABLE.Location = new System.Drawing.Point(271, 459);
            this.CB_RTSENABLE.Name = "CB_RTSENABLE";
            this.CB_RTSENABLE.Size = new System.Drawing.Size(288, 33);
            this.CB_RTSENABLE.TabIndex = 23;
            // 
            // SETDEFAULTS
            // 
            this.SETDEFAULTS.Location = new System.Drawing.Point(349, 563);
            this.SETDEFAULTS.Name = "SETDEFAULTS";
            this.SETDEFAULTS.Size = new System.Drawing.Size(205, 42);
            this.SETDEFAULTS.TabIndex = 24;
            this.SETDEFAULTS.Text = "Set Defaults";
            this.SETDEFAULTS.UseVisualStyleBackColor = true;
            this.SETDEFAULTS.Click += new System.EventHandler(this.SETDEFAULTS_Click);
            // 
            // CANCEL
            // 
            this.CANCEL.Location = new System.Drawing.Point(349, 631);
            this.CANCEL.Name = "CANCEL";
            this.CANCEL.Size = new System.Drawing.Size(205, 42);
            this.CANCEL.TabIndex = 25;
            this.CANCEL.Text = "Cancel";
            this.CANCEL.UseVisualStyleBackColor = true;
            this.CANCEL.Click += new System.EventHandler(this.CANCEL_Click);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(138, 631);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(205, 42);
            this.OK.TabIndex = 26;
            this.OK.Text = "Ok";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // CB_STOPBITS
            // 
            this.CB_STOPBITS.FormattingEnabled = true;
            this.CB_STOPBITS.Items.AddRange(new object[] {
            "None",
            "One",
            "Two",
            "OnePointFive"});
            this.CB_STOPBITS.Location = new System.Drawing.Point(271, 504);
            this.CB_STOPBITS.Name = "CB_STOPBITS";
            this.CB_STOPBITS.Size = new System.Drawing.Size(288, 33);
            this.CB_STOPBITS.TabIndex = 27;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 699);
            this.Controls.Add(this.CB_STOPBITS);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.CANCEL);
            this.Controls.Add(this.SETDEFAULTS);
            this.Controls.Add(this.CB_RTSENABLE);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxReceivedByteThr);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxReadTimeout);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxReadBufferSize);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxParityReplace);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CB_DTRENABLE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CB_DISCARDNULL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_PARITY);
            this.Controls.Add(this.labelParity);
            this.Controls.Add(this.CB_HANDSHAKE);
            this.Controls.Add(this.labelHandshake);
            this.Controls.Add(this.textBoxDataBits);
            this.Controls.Add(this.labelDataBits);
            this.Controls.Add(this.textBoxBaudRate);
            this.Controls.Add(this.labelBaud);
            this.Name = "SettingsForm";
            this.Text = "Connection Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelBaud;
        private System.Windows.Forms.TextBox textBoxBaudRate;
        private System.Windows.Forms.Label labelDataBits;
        private System.Windows.Forms.TextBox textBoxDataBits;
        private System.Windows.Forms.Label labelHandshake;
        private System.Windows.Forms.ComboBox CB_HANDSHAKE;
        private System.Windows.Forms.Label labelParity;
        private System.Windows.Forms.ComboBox CB_PARITY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_DISCARDNULL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CB_DTRENABLE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxParityReplace;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxReadBufferSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxReadTimeout;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxReceivedByteThr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CB_RTSENABLE;
        private System.Windows.Forms.Button SETDEFAULTS;
        private System.Windows.Forms.Button CANCEL;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.ComboBox CB_STOPBITS;
    }
}