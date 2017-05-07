using System.Windows.Forms;

namespace serialcom
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CONNECT = new System.Windows.Forms.Button();
            this.DISCONNECT = new System.Windows.Forms.Button();
            this.REFRESH = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.CB_PORTS = new System.Windows.Forms.ComboBox();
            this.rightArrow = new System.Windows.Forms.PictureBox();
            this.leftArrow = new System.Windows.Forms.PictureBox();
            this.LOGWINDOW = new System.Windows.Forms.RichTextBox();
            this.RXWINDOW = new System.Windows.Forms.RichTextBox();
            this.TABLEPANEL = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textPanel = new System.Windows.Forms.Panel();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.SETTTINGS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rightArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftArrow)).BeginInit();
            this.TABLEPANEL.SuspendLayout();
            this.textPanel.SuspendLayout();
            this.buttonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CONNECT
            // 
            this.CONNECT.Location = new System.Drawing.Point(6, 62);
            this.CONNECT.Margin = new System.Windows.Forms.Padding(6);
            this.CONNECT.Name = "CONNECT";
            this.CONNECT.Size = new System.Drawing.Size(150, 44);
            this.CONNECT.TabIndex = 0;
            this.CONNECT.Text = "CONNECT";
            this.CONNECT.UseVisualStyleBackColor = true;
            this.CONNECT.Click += new System.EventHandler(this.CONNECT_Click);
            // 
            // DISCONNECT
            // 
            this.DISCONNECT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DISCONNECT.Location = new System.Drawing.Point(160, 62);
            this.DISCONNECT.Margin = new System.Windows.Forms.Padding(6);
            this.DISCONNECT.Name = "DISCONNECT";
            this.DISCONNECT.Size = new System.Drawing.Size(176, 44);
            this.DISCONNECT.TabIndex = 1;
            this.DISCONNECT.Text = "DISCONNECT";
            this.DISCONNECT.UseVisualStyleBackColor = true;
            this.DISCONNECT.Click += new System.EventHandler(this.DISCONNECT_Click);
            // 
            // REFRESH
            // 
            this.REFRESH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.REFRESH.Location = new System.Drawing.Point(186, 6);
            this.REFRESH.Margin = new System.Windows.Forms.Padding(6);
            this.REFRESH.Name = "REFRESH";
            this.REFRESH.Size = new System.Drawing.Size(150, 44);
            this.REFRESH.TabIndex = 2;
            this.REFRESH.Text = "REFRESH";
            this.REFRESH.UseVisualStyleBackColor = true;
            this.REFRESH.Click += new System.EventHandler(this.REFRESH_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // CB_PORTS
            // 
            this.CB_PORTS.FormattingEnabled = true;
            this.CB_PORTS.Location = new System.Drawing.Point(3, 3);
            this.CB_PORTS.Name = "CB_PORTS";
            this.CB_PORTS.Size = new System.Drawing.Size(150, 33);
            this.CB_PORTS.TabIndex = 7;
            this.CB_PORTS.SelectedIndexChanged += new System.EventHandler(this.CB_PORTS_SelectedIndexChanged);
            // 
            // rightArrow
            // 
            this.rightArrow.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rightArrow.Image = ((System.Drawing.Image)(resources.GetObject("rightArrow.Image")));
            this.rightArrow.Location = new System.Drawing.Point(1812, 584);
            this.rightArrow.Name = "rightArrow";
            this.rightArrow.Size = new System.Drawing.Size(58, 72);
            this.rightArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rightArrow.TabIndex = 11;
            this.rightArrow.TabStop = false;
            this.rightArrow.Click += new System.EventHandler(this.rightArrow_Click);
            // 
            // leftArrow
            // 
            this.leftArrow.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.leftArrow.Image = ((System.Drawing.Image)(resources.GetObject("leftArrow.Image")));
            this.leftArrow.InitialImage = null;
            this.leftArrow.Location = new System.Drawing.Point(12, 584);
            this.leftArrow.Name = "leftArrow";
            this.leftArrow.Size = new System.Drawing.Size(58, 72);
            this.leftArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.leftArrow.TabIndex = 12;
            this.leftArrow.TabStop = false;
            this.leftArrow.Click += new System.EventHandler(this.leftArrow_Click);
            // 
            // LOGWINDOW
            // 
            this.LOGWINDOW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LOGWINDOW.Dock = System.Windows.Forms.DockStyle.Left;
            this.LOGWINDOW.Enabled = false;
            this.LOGWINDOW.Location = new System.Drawing.Point(0, 0);
            this.LOGWINDOW.Name = "LOGWINDOW";
            this.LOGWINDOW.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.LOGWINDOW.Size = new System.Drawing.Size(610, 225);
            this.LOGWINDOW.TabIndex = 13;
            this.LOGWINDOW.Text = "";
            // 
            // RXWINDOW
            // 
            this.RXWINDOW.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RXWINDOW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RXWINDOW.Enabled = false;
            this.RXWINDOW.Location = new System.Drawing.Point(616, 0);
            this.RXWINDOW.Name = "RXWINDOW";
            this.RXWINDOW.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.RXWINDOW.Size = new System.Drawing.Size(894, 225);
            this.RXWINDOW.TabIndex = 14;
            this.RXWINDOW.Text = "";
            // 
            // TABLEPANEL
            // 
            this.TABLEPANEL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TABLEPANEL.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TABLEPANEL.Controls.Add(this.richTextBox1);
            this.TABLEPANEL.Location = new System.Drawing.Point(76, 251);
            this.TABLEPANEL.Name = "TABLEPANEL";
            this.TABLEPANEL.Size = new System.Drawing.Size(1733, 737);
            this.TABLEPANEL.TabIndex = 15;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1733, 737);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // textPanel
            // 
            this.textPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.textPanel.Controls.Add(this.RXWINDOW);
            this.textPanel.Controls.Add(this.LOGWINDOW);
            this.textPanel.Location = new System.Drawing.Point(360, 12);
            this.textPanel.Name = "textPanel";
            this.textPanel.Size = new System.Drawing.Size(1510, 225);
            this.textPanel.TabIndex = 16;
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.AutoScroll = true;
            this.buttonsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonsPanel.Controls.Add(this.SETTTINGS);
            this.buttonsPanel.Controls.Add(this.REFRESH);
            this.buttonsPanel.Controls.Add(this.DISCONNECT);
            this.buttonsPanel.Controls.Add(this.CONNECT);
            this.buttonsPanel.Controls.Add(this.CB_PORTS);
            this.buttonsPanel.Location = new System.Drawing.Point(12, 12);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(342, 225);
            this.buttonsPanel.TabIndex = 17;
            // 
            // SETTTINGS
            // 
            this.SETTTINGS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SETTTINGS.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SETTTINGS.Location = new System.Drawing.Point(6, 115);
            this.SETTTINGS.Name = "SETTTINGS";
            this.SETTTINGS.Size = new System.Drawing.Size(330, 52);
            this.SETTTINGS.TabIndex = 8;
            this.SETTTINGS.Text = "CONNECTION SETTINGS";
            this.SETTTINGS.UseVisualStyleBackColor = true;
            this.SETTTINGS.Click += new System.EventHandler(this.SETTTINGS_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1882, 1000);
            this.Controls.Add(this.textPanel);
            this.Controls.Add(this.buttonsPanel);
            this.Controls.Add(this.TABLEPANEL);
            this.Controls.Add(this.leftArrow);
            this.Controls.Add(this.rightArrow);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Serial Port GUI";
            ((System.ComponentModel.ISupportInitialize)(this.rightArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftArrow)).EndInit();
            this.TABLEPANEL.ResumeLayout(false);
            this.textPanel.ResumeLayout(false);
            this.buttonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CONNECT;
        private System.Windows.Forms.Button DISCONNECT;
        private System.Windows.Forms.Button REFRESH;
        private System.Windows.Forms.ComboBox CB_PORTS;
        private System.Windows.Forms.PictureBox rightArrow;
        private System.Windows.Forms.PictureBox leftArrow;
        private System.Windows.Forms.RichTextBox LOGWINDOW;
        private System.Windows.Forms.RichTextBox RXWINDOW;
        private Panel TABLEPANEL;
        private RichTextBox richTextBox1;
        private Panel textPanel;
        private Panel buttonsPanel;
        private Button SETTTINGS;
        public System.IO.Ports.SerialPort serialPort1;
    }
}

