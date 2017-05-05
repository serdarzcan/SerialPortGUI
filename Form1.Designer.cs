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
            this.label2 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.CB_PORTS = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.rightArrow = new System.Windows.Forms.PictureBox();
            this.leftArrow = new System.Windows.Forms.PictureBox();
            this.LOGWINDOW = new System.Windows.Forms.RichTextBox();
            this.RXWINDOW = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.rightArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftArrow)).BeginInit();
            this.SuspendLayout();
            // 
            // CONNECT
            // 
            this.CONNECT.Location = new System.Drawing.Point(334, 13);
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
            this.DISCONNECT.Location = new System.Drawing.Point(496, 13);
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
            this.REFRESH.Location = new System.Drawing.Point(172, 13);
            this.REFRESH.Margin = new System.Windows.Forms.Padding(6);
            this.REFRESH.Name = "REFRESH";
            this.REFRESH.Size = new System.Drawing.Size(150, 44);
            this.REFRESH.TabIndex = 2;
            this.REFRESH.Text = "REFRESH";
            this.REFRESH.UseVisualStyleBackColor = true;
            this.REFRESH.Click += new System.EventHandler(this.REFRESH_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(759, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "RX";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // CB_PORTS
            // 
            this.CB_PORTS.FormattingEnabled = true;
            this.CB_PORTS.Location = new System.Drawing.Point(13, 13);
            this.CB_PORTS.Name = "CB_PORTS";
            this.CB_PORTS.Size = new System.Drawing.Size(150, 33);
            this.CB_PORTS.TabIndex = 7;
            this.CB_PORTS.SelectedIndexChanged += new System.EventHandler(this.CB_PORTS_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(681, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "LOG";
            // 
            // table
            // 
            this.table.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.table.AutoScroll = true;
            this.table.AutoSize = true;
            this.table.ColumnCount = 4;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.table.Location = new System.Drawing.Point(76, 251);
            this.table.Name = "table";
            this.table.RowCount = 1;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table.Size = new System.Drawing.Size(1432, 773);
            this.table.TabIndex = 10;
            // 
            // rightArrow
            // 
            this.rightArrow.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rightArrow.Image = ((System.Drawing.Image)(resources.GetObject("rightArrow.Image")));
            this.rightArrow.Location = new System.Drawing.Point(1514, 602);
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
            this.leftArrow.Location = new System.Drawing.Point(12, 602);
            this.leftArrow.Name = "leftArrow";
            this.leftArrow.Size = new System.Drawing.Size(58, 72);
            this.leftArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.leftArrow.TabIndex = 12;
            this.leftArrow.TabStop = false;
            this.leftArrow.Click += new System.EventHandler(this.leftArrow_Click);
            // 
            // LOGWINDOW
            // 
            this.LOGWINDOW.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LOGWINDOW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LOGWINDOW.Location = new System.Drawing.Point(12, 66);
            this.LOGWINDOW.Name = "LOGWINDOW";
            this.LOGWINDOW.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.LOGWINDOW.Size = new System.Drawing.Size(791, 179);
            this.LOGWINDOW.TabIndex = 13;
            this.LOGWINDOW.Text = "";
            this.LOGWINDOW.Enabled = false;
            // 
            // RXWINDOW
            // 
            this.RXWINDOW.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.RXWINDOW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RXWINDOW.Location = new System.Drawing.Point(809, 12);
            this.RXWINDOW.Name = "RXWINDOW";
            this.RXWINDOW.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.RXWINDOW.Size = new System.Drawing.Size(763, 233);
            this.RXWINDOW.TabIndex = 14;
            this.RXWINDOW.Text = "";
            this.RXWINDOW.Enabled = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 1036);
            this.Controls.Add(this.RXWINDOW);
            this.Controls.Add(this.LOGWINDOW);
            this.Controls.Add(this.leftArrow);
            this.Controls.Add(this.rightArrow);
            this.Controls.Add(this.table);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_PORTS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.REFRESH);
            this.Controls.Add(this.DISCONNECT);
            this.Controls.Add(this.CONNECT);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Serial Port GUI";
            ((System.ComponentModel.ISupportInitialize)(this.rightArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftArrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CONNECT;
        private System.Windows.Forms.Button DISCONNECT;
        private System.Windows.Forms.Button REFRESH;
        private System.Windows.Forms.Label label2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox CB_PORTS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel table;
        private System.Windows.Forms.PictureBox rightArrow;
        private System.Windows.Forms.PictureBox leftArrow;
        private System.Windows.Forms.RichTextBox LOGWINDOW;
        private System.Windows.Forms.RichTextBox RXWINDOW;
    }
}

