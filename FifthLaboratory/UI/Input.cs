﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5.Main
{
    public partial class Input : Form
    {
        public Input()
        {
            InitializeComponent();
        }
        public string Value { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!= "")
            {
                Value = textBox1.Text;
                DialogResult = DialogResult.OK;
            }
        }
    }
}
