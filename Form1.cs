using serialportgui;
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


namespace serialport
{
    public partial class Form1 : Form
    {
        // Attirbutes
        SavedSettings settings;
        bool isConnected;
        string RxString;
        string[] ports;
        string msg;
        byte[] rxByteArray;
        List<List<DataPack>> listList;
        List<DataPack> curr, prev;
        string RXed;
        List<string> listRXed;
        int nextIndex, roamIndex;
        byte[] testByte = { 0xA, 0x1, 0x1 , 0xB, 0x2, 0x0, 0x2, 0xC, 0x3, 0x0, 0x0, 0x3, 0xD, 0x4, 0x0, 0x0, 0x0, 0x4 };
        //int BAUDRATE = 115200;


        public Form1()
        {
            InitializeComponent();
            this.toggleButtons();
            settings = new SavedSettings();
            listList = new List< List<DataPack> > ();
            curr = new List<DataPack>();
            prev = new List<DataPack>();
            listRXed = new List<string>();
            nextIndex = 0;
            roamIndex = 0;
        }

        private void setDefaultSettings()
        {
            throw new NotImplementedException();
        }



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

            serialPort1.BaudRate = settings.baudRate;

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

            //test();

            //MessageBox.Show("Connected", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void test()
        {
            buildCurr(0, testByte.Length);
            foreach(DataPack dp in curr) {
                //RXDETAILED.AppendText(stringToHex(dp.ToString()));
                RXDETAILED.AppendText(dp.ToString() + "\n");
            }
            
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
            //RxString = serialPort1.ReadExisting();
            rxByteArray = new byte[serialPort1.BytesToRead];
            serialPort1.Read(rxByteArray, 0, serialPort1.BytesToRead);
            this.Invoke(new EventHandler(DisplayText));
        }

        private void DisplayText(object sender, EventArgs e)
        {
            RXWINDOW.Clear();
            //RXDETAILED.Clear();
            //RXWINDOW.AppendText(stringToHex(RxString) + "\n");
            RXed = BitConverter.ToString(rxByteArray).Replace("-", string.Empty);
            RXWINDOW.AppendText(RXed + "\n");

            curr.Clear();
            buildCurr(0, rxByteArray.Length);
            //RXWINDOW.AppendText(curr.ToString());
            printList(curr);

            //compareLists(prev, curr);
            listList.Add(curr);
            Console.WriteLine(listList.Count);
            listRXed.Add(RXed);
            /*if (currentIndex == 0)
            {
                currentIndex++;
            }
            prev = null;
            prev = curr;*/
            nextIndex++;
            roamIndex = getCurrentIndex();
            leftArrow.Enabled = true;
            rightArrow.Enabled = false;
        }

        private void buildCurr(int index, int size)
        {
            Console.WriteLine("index: " + index + "\t size: " + size);
            if (index < size)
            {
                // Create DataPack object to add current list (curr)
                DataPack dp = new DataPack();

                // Convert first byte to hex to set type of the data
                dp.type = rxByteArray[index].ToString("X2");
                //dp.type = testByte[index].ToString("X2");

                index++;

                // Set size of the data
                dp.size = rxByteArray[index];
                //dp.size = testByte[index];

                index++;

                // Convert data bytes to hexadecimal
                byte[] tempArray = new byte[dp.size];
                Buffer.BlockCopy(rxByteArray, index, tempArray, 0, dp.size);
                //Buffer.BlockCopy(testByte, index, tempArray, 0, dp.size);
                dp.data = BitConverter.ToString(tempArray);

                // Add DataPack object to curr
                curr.Add(dp);

                index += dp.size;

                buildCurr(index, size);
            }

            //return curr;
        }

        /*private void compareLists(List<DataPack> olderList, List<DataPack> newerList)
        {
            
        }

        private void compareDPAndPrint(DataPack older, DataPack newer)
        {
            foreach (DataPack dp in listList[0])
            {
                RXDETAILED.AppendText(dp.ToString() + "\n");
            }
        }*/

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

        private void printList(List<DataPack> list)
        {
            RXDETAILED.Clear();
            foreach (DataPack dp in list)
            {
                RXDETAILED.AppendText(dp.ToString() + "\n");
            }
        }

        private void leftArrow_Click(object sender, EventArgs e)
        {
            if (roamIndex > 0)
            {
                roamIndex--;
                RXWINDOW.Clear();
                RXDETAILED.Clear();
                RXWINDOW.Text = listRXed[roamIndex];
                printList(listList[roamIndex]);
                Console.WriteLine(listList[roamIndex].Last().data);
            }
            else
            {
                leftArrow.Enabled = false;
            }
            rightArrow.Enabled = true;
        }

        private void rightArrow_Click(object sender, EventArgs e)
        {
            if (roamIndex < getCurrentIndex())
            {
                roamIndex++;
                RXWINDOW.Clear();
                RXDETAILED.Clear();
                RXWINDOW.Text = listRXed[roamIndex];
                printList(listList[roamIndex]);
            }
            else
            {
                rightArrow.Enabled = false;
            }
            leftArrow.Enabled = true;
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

        private void SETTTINGS_Click(object sender, EventArgs e)
        {
            // Create a new instance of the SettingsForm class
            SettingsForm settingsForm = new SettingsForm(serialPort1, settings);

            // Show the settings form
            settingsForm.ShowDialog();
        }

        private string stringToHex(string s)
        {
            byte[] ba = Encoding.Default.GetBytes(s);
            var hexString = BitConverter.ToString(ba);
            hexString = hexString.Replace("-", "");
            return hexString;
        }

        private int getCurrentIndex()
        {
            return nextIndex - 1;
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
