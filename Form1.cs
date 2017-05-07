﻿using serialportgui;
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


namespace serialcom
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.toggleButtons();
        }
        bool isConnected;
        string RxString;
        string[] ports;
        string msg;
        int BAUDRATE = 115200;



        private void CONNECT_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = CB_PORTS.SelectedItem.ToString();
            }
            catch (Exception ex)
            {
                msg = "Error on selected port: " + ex.Message;
                //msg. = System.Drawing.Color.Red;
                LOGWINDOW.AppendText(msg + "\n", System.Drawing.Color.Red);
                //LOGWINDOW.ForeColor = System.Drawing.Color.Red;
            }
            serialPort1.BaudRate = BAUDRATE;
            try
            {
                serialPort1.Open();
            }
            catch (Exception ex)
            {
                msg = "Error opening port: " + ex.Message;
                LOGWINDOW.AppendText(msg + "\n", System.Drawing.Color.Red);
            }

            if (!serialPort1.IsOpen)
            {
                return;
            }
            else
            {
                msg = "Connected to " + serialPort1.PortName;
                LOGWINDOW.AppendText(msg + "\n", System.Drawing.Color.Black);

                isConnected = true;
                toggleButtons();
            }

            //MessageBox.Show("Connected", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void DISCONNECT_Click(object sender, EventArgs e)
        {

            if (serialPort1.IsOpen)
            serialPort1.Close();

            msg = "Disconnected from " + serialPort1.PortName;
            LOGWINDOW.AppendText(msg + "\n", System.Drawing.Color.Red);

            isConnected = false;
            toggleButtons();

            //MessageBox.Show("Disconnected", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /*private void SEND_Click(object sender, EventArgs e)
        {
            string tx = TXWINDOW.Text;
            serialPort1.Write(tx);
            TXWINDOW.Clear();
        }*/

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen) serialPort1.Close();
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            RxString = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(DisplayText));
            /*
            int[] array = new int[serialPort1.BytesToRead];
            int i = 0;
            while (serialPort1.BytesToRead > 0)
            {
                array[i] = serialPort1.ReadByte();
                i++;
            }*/
        }
        private void DisplayText(object sender, EventArgs e)
        {
            RXWINDOW.AppendText(RxString + "\n");

        }

        private void REFRESH_Click(object sender, EventArgs e)
        {
            CB_PORTS.SelectedIndex = -1;
            searchPorts();
        }

        private void searchPorts()
        {
            CB_PORTS.Items.Clear();
            ports = SerialPort.GetPortNames();
            foreach(string port in ports)
            {
                CB_PORTS.Items.Add(port);
            }
        }

        public void toggleButtons()
        {
            if (!isConnected)
            {
                CB_PORTS.Enabled = true;
                REFRESH.Enabled = true;
                SETTTINGS.Enabled = true;
                if (CB_PORTS.SelectedIndex < 0)
                {
                    CONNECT.Enabled = false;
                }
                else
                {
                    CONNECT.Enabled = true;
                }
                DISCONNECT.Enabled = false;
            }
            else
            {
                CB_PORTS.Enabled = false;
                REFRESH.Enabled = false;
                CONNECT.Enabled = false;
                DISCONNECT.Enabled = true;
                SETTTINGS.Enabled = false;
            }
        }

        private void leftArrow_Click(object sender, EventArgs e)
        {

        }

        private void rightArrow_Click(object sender, EventArgs e)
        {

        }

        private void CB_PORTS_SelectedIndexChanged(object sender, EventArgs e)
        {
            toggleButtons();
        }

        /*private void clearTable()
        {
            table.SuspendLayout();

            while (table.RowCount > 1)
            {
                int row = table.RowCount - 1;
                for (int i = 0; i < table.ColumnCount; i++)
                {
                    Control c = table.GetControlFromPosition(i, row);
                    table.Controls.Remove(c);
                    c.Dispose();
                }

                table.RowStyles.RemoveAt(row);
                table.RowCount--;
            }

            table.ResumeLayout(false);
            table.PerformLayout();
        }*/

        private string stringToHex(string s)
        {
            byte[] ba = Encoding.Default.GetBytes(s);
            var hexString = BitConverter.ToString(ba);
            hexString = hexString.Replace("-", "");
            return hexString;
        }

        private void SETTTINGS_Click(object sender, EventArgs e)
        {
            // Create a new instance of the SettingsForm class
            SettingsForm settingsForm = new SettingsForm();

            // Show the settings form
            settingsForm.Show();
        }
    }


}


public static class RichTextBoxExtensions
{
    public static void AppendText(this RichTextBox box, string text, Color color)
    {
        box.SelectionStart = box.TextLength;
        box.SelectionLength = 0;

        box.SelectionColor = color;
        box.AppendText(text);
        box.SelectionColor = box.ForeColor;
    }
}
