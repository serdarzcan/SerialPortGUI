using serialport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace serialportgui
{
    public partial class SettingsForm : Form
    {
        private SerialPort port;
        private SavedSettings settings;
        private bool baud;
        private bool dataBits;
        private bool discardNull;
        private bool dtr;
        private bool handshake;
        private bool parity;
        private bool parityReplace;
        private bool readBufferSize;
        private bool readTimeout;
        private bool receivedByte;
        private bool rts;
        private bool stopBits;

        public SettingsForm(SerialPort port, SavedSettings ss)
        {
            InitializeComponent();
            this.port = port;
            settings = ss;
            loadFromSettings(settings);
        }

        private void loadFromSettings(SavedSettings settings)
        {
            this.textBoxBaudRate.Text = settings.baudRate.ToString();
            this.textBoxDataBits.Text = settings.dataBits.ToString();
            this.CB_DISCARDNULL.SelectedIndex = settings.discardNull;
            this.CB_DTRENABLE.SelectedIndex = settings.dtrEnable;
            this.CB_HANDSHAKE.SelectedIndex = settings.handshake;
            this.CB_PARITY.SelectedIndex = settings.parity;
            this.textBoxParityReplace.Text = settings.parityReplace.ToString();
            this.textBoxReadBufferSize.Text = settings.readBufferSize.ToString();
            this.textBoxReadTimeout.Text = settings.readTimeout.ToString();
            this.textBoxReceivedByteThr.Text = settings.receivedBytesThr.ToString();
            this.CB_RTSENABLE.SelectedIndex = settings.rtsEnable;
            this.CB_STOPBITS.SelectedIndex = settings.stopBits;
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //saveSettings();
        }

        private void CANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void setDefaults()
        {
            this.textBoxBaudRate.Text = 115200.ToString();
            this.textBoxDataBits.Text = 8.ToString();
            this.CB_DISCARDNULL.SelectedIndex = 1;
            this.CB_DTRENABLE.SelectedIndex = 1;
            this.CB_HANDSHAKE.SelectedIndex = 0;
            this.CB_PARITY.SelectedIndex = 0;
            this.textBoxParityReplace.Text = 63.ToString();
            this.textBoxReadBufferSize.Text = 4096.ToString();
            this.textBoxReadTimeout.Text = (-1).ToString();
            this.textBoxReceivedByteThr.Text = 1.ToString();
            this.CB_RTSENABLE.SelectedIndex = 1;
            this.CB_STOPBITS.SelectedIndex = 1;
        }

        private void SETDEFAULTS_Click(object sender, EventArgs e)
        {
            setDefaults();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            // Set Baud
            int x = 0;
            if (Int32.TryParse(this.textBoxBaudRate.Text, out x)) { port.BaudRate = x; baud = false; settings.baudRate = x; }
            else baud = true;

            // Set DataBits
            if (Int32.TryParse(this.textBoxDataBits.Text, out x)) { port.DataBits = x; dataBits = false; settings.dataBits = x; }
            else dataBits = true;

            // Set DiscardNull
            settings.discardNull = CB_DISCARDNULL.SelectedIndex;
            switch (CB_DISCARDNULL.SelectedIndex)
            {
                case 0: { port.DiscardNull = true; discardNull = false; break; }
                case 1: { port.DiscardNull = false; discardNull = false; break; }
                default: { discardNull = true; break; }
            }

            // Set DtrEnable
            settings.dtrEnable = CB_DTRENABLE.SelectedIndex;
            switch (CB_DTRENABLE.SelectedIndex)
            {
                case 0: { port.DtrEnable = true; dtr = false; break; }
                case 1: { port.DtrEnable = false; dtr = false; break; }
                default: { dtr = true; break; }
            }

            // Set Handshake
            settings.handshake = CB_HANDSHAKE.SelectedIndex;
            switch (CB_HANDSHAKE.SelectedIndex)
            {
                case 0: { port.Handshake = Handshake.None; handshake = false; break; }
                case 1: { port.Handshake = Handshake.XOnXOff; handshake = false; break; }
                case 2: { port.Handshake = Handshake.RequestToSend; handshake = false;  break; }
                case 3: { port.Handshake = Handshake.RequestToSendXOnXOff; handshake = false; break; }
                default: { handshake = true; break; }
            }

            // Set Parity
            settings.parity = CB_PARITY.SelectedIndex;
            switch (CB_PARITY.SelectedIndex)
            {
                case 0: { port.Parity = Parity.None; parity = false; break; }
                case 1: { port.Parity = Parity.Odd; parity = false; break; }
                case 2: { port.Parity = Parity.Even; parity = false; break; }
                case 3: { port.Parity = Parity.Mark; parity = false; break; }
                case 4: { port.Parity = Parity.Space; parity = false; break; }
                default: { parity = true; break; }
            }

            // Set ParityReplace
            if (Int32.TryParse(this.textBoxParityReplace.Text, out x)) { port.ParityReplace = (byte)x; parityReplace = false; settings.parityReplace = x; }
            else parityReplace = true;

            // Set ReadBufferSize
            if (Int32.TryParse(this.textBoxReadBufferSize.Text, out x)) { port.ReadBufferSize = x; readBufferSize = false; settings.readBufferSize = x; }
            else readBufferSize = true;

            // Set ReadTimeout
            if (Int32.TryParse(this.textBoxReadTimeout.Text, out x)) { port.ReadTimeout = x; readTimeout = false; settings.readTimeout = x; }
            else readTimeout = true;

            // Set ReceivedBytesThreshold
            if (Int32.TryParse(this.textBoxReceivedByteThr.Text, out x)) { port.ReceivedBytesThreshold = x; receivedByte = false; settings.receivedBytesThr = x; }
            else receivedByte = true;

            // Set RtsEnable
            settings.rtsEnable = CB_RTSENABLE.SelectedIndex;
            switch (CB_RTSENABLE.SelectedIndex)
            {
                case 0: { port.RtsEnable = true; rts = false; break; }
                case 1: { port.RtsEnable = false; rts = false; break; }
                default: { rts = true; break; }
            }

            // Set StopBits
            settings.stopBits = CB_STOPBITS.SelectedIndex;
            switch (CB_STOPBITS.SelectedIndex)
            {
                case 0: { MessageBox.Show("StopBits.None value is not supported!", "Illegal StopBits", MessageBoxButtons.OK, MessageBoxIcon.Error); stopBits = true; break; }
                case 1: { port.StopBits = StopBits.One; stopBits = false; break; }
                case 2: { port.StopBits = StopBits.Two; stopBits = false; break; }
                case 3: { port.StopBits = StopBits.OnePointFive; stopBits = false; break; }
                default: { stopBits = true; break; }
            }

            // Check flags for any unwanted input
            if (!checkFlags()) { this.Close(); }
        }

        private bool checkFlags()
        {
            if (baud) MessageBox.Show("Enter a valid BaudRate!", "Illegal BaudRate", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (dataBits) MessageBox.Show("Enter a valid DataBits!", "Illegal DataBits", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (discardNull) MessageBox.Show("Select a DiscardNull option!", "Illegal DiscardNull", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (dtr) MessageBox.Show("Select a DtrEnable option!", "Illegal DtrEnable", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (handshake) MessageBox.Show("Select a Handshake option!", "Illegal Handshake", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (parity) MessageBox.Show("Select a Parity option!", "Illegal Parity", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (parityReplace) MessageBox.Show("Enter a valid ParityReplace option!", "Illegal ParityReplace", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (readTimeout) MessageBox.Show("Enter a valid ReadTimeout option!", "Illegal ReadTimeout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (readBufferSize) MessageBox.Show("Enter a valid ReadBufferSize option!", "Illegal ReadBufferSize", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (receivedByte) MessageBox.Show("Enter a valid ReceivedByteThreshold option!", "Illegal ReceivedByteThreshold", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (rts) MessageBox.Show("Select a RtsEnable option!", "Illegal RtsEnable", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (stopBits) MessageBox.Show("Select a StopBits option!", "Illegal StopBits", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return (baud | dataBits | dtr | handshake | parity | parityReplace | readTimeout | readBufferSize | receivedByte | rts | stopBits);
        }
    }
}
