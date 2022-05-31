using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyClasses;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        Meeting meeting;
        Class2 class2;

        public Form1()
        {
            InitializeComponent();
            meeting = new Meeting();
            class2 = new Class2();
        }

        private void countBtn1_Click(object sender, EventArgs e)
        {
            if (nameTxb1.Text != "" && speakerCount1.Value > 0 && visitorsCount1.Value > 0)
            {
                meeting.Name = nameTxb1.Text;
                meeting.CountOfSpeakers = (int)speakerCount1.Value;
                meeting.CountOfParticipant = (int)visitorsCount1.Value;
                resultMeeting.Text = meeting.Q().ToString();
            }
            else MessageBox.Show("Count error!", "Error");
        }

        private void fillBtn_Click(object sender, EventArgs e)
        {
            nameTxb2.Text = nameTxb1.Text;
            speakerCount2.Value = speakerCount1.Value;
            visitorsCount2.Value = visitorsCount1.Value;
        }

        private void countBtn2_Click(object sender, EventArgs e)
        {

            if (nameTxb1.Text != "" && speakerCount1.Value > 0 && visitorsCount1.Value > 0)
            {
                class2.Name = nameTxb2.Text;
                class2.CountOfSpeakers = (int)speakerCount2.Value;
                class2.CountOfParticipant = (int)visitorsCount2.Value;
                class2.CountOfGroup = (int)onePointSpeakers.Value;
                qualityQ.Text = class2.Quality().ToString();
                resultClass2.Text = class2.Q().ToString();
            }
            else MessageBox.Show("Count error!", "Error");
        }
    }
}
