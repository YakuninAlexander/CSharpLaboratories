using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThirdLaboratory.Domain.Data.Enums;
using ThirdLaboratory.Services.Phones;

namespace WinFormsApp3
{
    public partial class AddNewDeviceForm : Form
    {
        public AddNewDeviceForm()
        {
            InitializeComponent();
            TypeOfScreen.DataSource = Enum.GetValues(typeof(ScreenTypes)); 
        }

        public Smartphone Value { get;private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TypeOfScreen.SelectedIndex != -1 && SizeOfScreen.Text != "" && PhoneNumber.Text != "" && PhonePrice.Text != "" && CountPixels.Text != "")
            {
                Value = new Smartphone((ScreenTypes)TypeOfScreen.SelectedItem, Convert.ToDouble(SizeOfScreen.Text), PhoneNumber.Text, Convert.ToInt32(PhonePrice.Text), Convert.ToInt32(CountPixels.Text));
                DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Не заполнено!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
