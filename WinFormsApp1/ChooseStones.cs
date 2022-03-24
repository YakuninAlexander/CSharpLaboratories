using FirstLaboratory.Domain.Rocks;
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
    public partial class ChooseStones : Form
    {
        private List<Stone> allStones = new List<Stone>() { new PreciousStone("Алмаз", 87, 26000.98, 0.02, 1 ), new PreciousStone("Сапфир", 76, 15000.23, 0.05, 13),
                    new SemipreciousStone("Нефрит"), new SemipreciousStone("Лазурит", 25,120,1.5), new SemipreciousStone("Глауконит", 28, 1.8, 1.0) };
        public List<Stone> Value { get; set; }
        public ChooseStones()
        {            
            InitializeComponent();
            FirstStone_rdbtn.Text = allStones[0].Name;
            SecondStone_rdbtn.Text = allStones[1].Name;
            ThirdStone_rdbtn.Text = allStones[2].Name;
            FourthStone_rdbtn.Text = allStones[3].Name;
            FifthStone_rdbtn.Text = allStones[4].Name;
            Value = new List<Stone>();
        }

        private void ConfirmChoose_btn_Click(object sender, EventArgs e)
        {
            if (FirstStone_rdbtn.Checked)
                Value.Add(allStones[0]);
            if (SecondStone_rdbtn.Checked)
                Value.Add(allStones[1]);
            if (ThirdStone_rdbtn.Checked)
                Value.Add(allStones[2]);
            if (FourthStone_rdbtn.Checked)
                Value.Add(allStones[3]);
            if (FifthStone_rdbtn.Checked)
                Value.Add(allStones[4]);

            DialogResult = DialogResult.OK;
        }
    }
}
