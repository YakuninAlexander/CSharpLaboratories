using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class GetDiapasone : Form
    {
        public int Min { get; private set; }
        public int Max { get; private set; }
        public GetDiapasone()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown2.Minimum = numericUpDown2.Value;
        }

        private void OK_btn_Click(object sender, EventArgs e)
        {
            Min = Convert.ToInt32(numericUpDown1.Value);
            Max = Convert.ToInt32(numericUpDown2.Value);
            
            DialogResult = DialogResult.OK;
        }
    }
}
