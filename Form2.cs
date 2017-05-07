using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace serialportgui
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // No need to do anything
        }

        private void SETDEFAULTS_Click(object sender, EventArgs e)
        {
            this.textBoxBaudRate.Text = 9600.ToString();
        }

        private void OK_Click(object sender, EventArgs e)
        {

        }

        private void CANCEL_Click(object sender, EventArgs e)
        {

        }

        private void CB_PARITY_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
