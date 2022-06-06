﻿using System;
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
    public partial class CallMessageForm : Form
    {
        public CallMessageForm(bool isCall)
        {
            InitializeComponent();
            if(isCall) textBox2.Enabled = false;
            else textBox2.Enabled = true;
        }
        
        public string Number { get; private set; }
        public string Message { get; private set; }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Number = textBox1.Text;
                Message = textBox2.Text;
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Не заполнено!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
