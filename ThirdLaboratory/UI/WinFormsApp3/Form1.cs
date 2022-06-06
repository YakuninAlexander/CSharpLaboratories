using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThirdLaboratory.Services.Phones;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            PowerSwicthToolStripMenuItem.Enabled = false;
            setEnableFunctions(false);
        }
        List<Smartphone> smartphones = new List<Smartphone>();

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewDeviceForm addNew = new AddNewDeviceForm();

            addNew.ShowDialog();
            if(addNew.DialogResult == DialogResult.OK)
            {
                smartphones.Add(addNew.Value);
                listBox1.Items.Add(addNew.Value.OwnNumber);
            }
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            smartphones.RemoveAt(listBox1.SelectedIndex);
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void PowerSwicthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            smartphones[listBox1.SelectedIndex].powerSwitch();
            if(smartphones[listBox1.SelectedIndex].Power==true)
                setEnableFunctions(true);
        }

        private void CallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CallMessageForm call = new CallMessageForm(true);
            call.ShowDialog();
            if (call.DialogResult == DialogResult.OK) {
                MessageBox.Show($"Вызван абонент с номером: {smartphones[listBox1.SelectedIndex].call(call.Number)}","Вызов!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void SendMessageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CallMessageForm call = new CallMessageForm(false);
            call.ShowDialog();
            if (call.DialogResult == DialogResult.OK)
            {
                MessageBox.Show(smartphones[listBox1.SelectedIndex].sendMessage(call.Message, call.Number), "Вызов!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void OpenChromeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(smartphones[listBox1.SelectedIndex].browseChrome(), "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void VirusCheckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(smartphones[listBox1.SelectedIndex].checkViruses(), "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex>-1)
            {
                PowerSwicthToolStripMenuItem.Enabled = true;

                if(smartphones[listBox1.SelectedIndex].Power==true)
                    setEnableFunctions(true);
                else
                    setEnableFunctions(false);
            }
        }

        private void setEnableFunctions(bool enable)
        {
            CallToolStripMenuItem.Enabled = enable;
            SendMessageToolStripMenuItem.Enabled = enable;
            OpenChromeToolStripMenuItem.Enabled = enable;
            VirusCheckToolStripMenuItem.Enabled = enable;
            DeleteToolStripMenuItem.Enabled = enable;
        }
    }
}
