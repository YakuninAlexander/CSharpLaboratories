using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirstLaboratory.Domain.Rocks;
using FirstLaboratory.Services.Jewel;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Necklace necklace;
        public Form1()
        {
            InitializeComponent();
        }

        private void printStones()
        {
            necklaceDisplay_txb.Text = "";
            for (int i = 0; i < necklace.Stones.Count; i++)
            {
                necklaceDisplay_txb.Text += necklace.Stones[i].Name + " ";
            }
        }
        private void getNecklace_btn_Click(object sender, EventArgs e)
        {
            ChooseStones choose = new ChooseStones();
            
            if (choose.ShowDialog() == DialogResult.OK)
            {
                necklace = new Necklace(choose.Value);

                printStones();
            }
            else
            {
                necklaceDisplay_txb.Text = "Камни не выбраны!";
            }
        }

        private void sortNecklace_btn_Click(object sender, EventArgs e)
        {
            var sort = necklace.sortStones();
            string result = "";
            foreach(var elem in sort)
            {
                result += $"Имя: {elem.Name}, Стоимость: {elem.Price}\n";
            }
            MessageBox.Show(result,"Сортированные по стоимости!");
            printStones();
        }

        private void calculateTotal_btn_Click(object sender, EventArgs e)
        {
            double totalPrice = necklace.calculateTotalPrice();
            double totalWeight = necklace.calculateTotalWeight();
            MessageBox.Show($"Вес ожерелья: {totalWeight}, Цена ожерелья: {totalPrice}");
        }

        private void getForTransparency_Click(object sender, EventArgs e)
        {
            GetDiapasone diapasone = new GetDiapasone();
            if (diapasone.ShowDialog() == DialogResult.OK)
            {
                
                IEnumerable<Stone> transparencyStone = 
                    necklace.getStonesByTransparency(diapasone.Min, diapasone.Max);

                string result = "";
                foreach (Stone s in transparencyStone)
                {
                    result += s.Name + " ";
                }
                MessageBox.Show($"Камни с прозрачностью от {diapasone.Min} до {diapasone.Max}:\n{result}!");
            }
            else
            {
                MessageBox.Show($"Не был выбран диапазон!");
            }
            diapasone.Dispose();
        }

        private void info_Click(object sender, EventArgs e)
        {
            string s;
            s = necklace.getInfo();
            MessageBox.Show(s);
        }
    }
}
