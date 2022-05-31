
namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.resultMeeting = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.countBtn1 = new System.Windows.Forms.Button();
            this.visitorsCount1 = new System.Windows.Forms.NumericUpDown();
            this.speakerCount1 = new System.Windows.Forms.NumericUpDown();
            this.nameTxb1 = new System.Windows.Forms.TextBox();
            this.visitorsCountLbl1 = new System.Windows.Forms.Label();
            this.speakersCountLbl1 = new System.Windows.Forms.Label();
            this.MeetingNameLbl1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.qualityQ = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.resultClass2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fillBtn = new System.Windows.Forms.Button();
            this.countBtn2 = new System.Windows.Forms.Button();
            this.onePointSpeakers = new System.Windows.Forms.NumericUpDown();
            this.visitorsCount2 = new System.Windows.Forms.NumericUpDown();
            this.nameTxb2 = new System.Windows.Forms.TextBox();
            this.speakerCount2 = new System.Windows.Forms.NumericUpDown();
            this.visitorsCountLbl2 = new System.Windows.Forms.Label();
            this.speakersCountLbl2 = new System.Windows.Forms.Label();
            this.MeetingNameLbl2 = new System.Windows.Forms.Label();
            this.onePointSpeakersLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitorsCount1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speakerCount1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.onePointSpeakers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitorsCount2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speakerCount2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.resultMeeting);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.countBtn1);
            this.panel1.Controls.Add(this.visitorsCount1);
            this.panel1.Controls.Add(this.speakerCount1);
            this.panel1.Controls.Add(this.nameTxb1);
            this.panel1.Controls.Add(this.visitorsCountLbl1);
            this.panel1.Controls.Add(this.speakersCountLbl1);
            this.panel1.Controls.Add(this.MeetingNameLbl1);
            this.panel1.Location = new System.Drawing.Point(7, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 369);
            this.panel1.TabIndex = 0;
            // 
            // resultMeeting
            // 
            this.resultMeeting.Location = new System.Drawing.Point(175, 230);
            this.resultMeeting.Name = "resultMeeting";
            this.resultMeeting.ReadOnly = true;
            this.resultMeeting.Size = new System.Drawing.Size(204, 23);
            this.resultMeeting.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Качество события Q:";
            // 
            // countBtn1
            // 
            this.countBtn1.Location = new System.Drawing.Point(15, 318);
            this.countBtn1.Name = "countBtn1";
            this.countBtn1.Size = new System.Drawing.Size(148, 40);
            this.countBtn1.TabIndex = 10;
            this.countBtn1.Text = "Вычислить!";
            this.countBtn1.UseVisualStyleBackColor = true;
            this.countBtn1.Click += new System.EventHandler(this.countBtn1_Click);
            // 
            // visitorsCount1
            // 
            this.visitorsCount1.Location = new System.Drawing.Point(175, 123);
            this.visitorsCount1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.visitorsCount1.Name = "visitorsCount1";
            this.visitorsCount1.Size = new System.Drawing.Size(204, 23);
            this.visitorsCount1.TabIndex = 5;
            // 
            // speakerCount1
            // 
            this.speakerCount1.Location = new System.Drawing.Point(175, 76);
            this.speakerCount1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.speakerCount1.Name = "speakerCount1";
            this.speakerCount1.Size = new System.Drawing.Size(204, 23);
            this.speakerCount1.TabIndex = 4;
            // 
            // nameTxb1
            // 
            this.nameTxb1.Location = new System.Drawing.Point(175, 32);
            this.nameTxb1.Name = "nameTxb1";
            this.nameTxb1.Size = new System.Drawing.Size(204, 23);
            this.nameTxb1.TabIndex = 3;
            // 
            // visitorsCountLbl1
            // 
            this.visitorsCountLbl1.AutoSize = true;
            this.visitorsCountLbl1.Location = new System.Drawing.Point(15, 125);
            this.visitorsCountLbl1.Name = "visitorsCountLbl1";
            this.visitorsCountLbl1.Size = new System.Drawing.Size(141, 15);
            this.visitorsCountLbl1.TabIndex = 2;
            this.visitorsCountLbl1.Text = "Количество участников:";
            // 
            // speakersCountLbl1
            // 
            this.speakersCountLbl1.AutoSize = true;
            this.speakersCountLbl1.Location = new System.Drawing.Point(15, 78);
            this.speakersCountLbl1.Name = "speakersCountLbl1";
            this.speakersCountLbl1.Size = new System.Drawing.Size(130, 15);
            this.speakersCountLbl1.TabIndex = 1;
            this.speakersCountLbl1.Text = "Количество ораторов:";
            // 
            // MeetingNameLbl1
            // 
            this.MeetingNameLbl1.AutoSize = true;
            this.MeetingNameLbl1.Location = new System.Drawing.Point(15, 35);
            this.MeetingNameLbl1.Name = "MeetingNameLbl1";
            this.MeetingNameLbl1.Size = new System.Drawing.Size(112, 15);
            this.MeetingNameLbl1.TabIndex = 0;
            this.MeetingNameLbl1.Text = "Название события:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.qualityQ);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.resultClass2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.fillBtn);
            this.panel2.Controls.Add(this.countBtn2);
            this.panel2.Controls.Add(this.onePointSpeakers);
            this.panel2.Controls.Add(this.visitorsCount2);
            this.panel2.Controls.Add(this.nameTxb2);
            this.panel2.Controls.Add(this.speakerCount2);
            this.panel2.Controls.Add(this.visitorsCountLbl2);
            this.panel2.Controls.Add(this.speakersCountLbl2);
            this.panel2.Controls.Add(this.MeetingNameLbl2);
            this.panel2.Controls.Add(this.onePointSpeakersLbl);
            this.panel2.Location = new System.Drawing.Point(401, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(581, 370);
            this.panel2.TabIndex = 1;
            // 
            // qualityQ
            // 
            this.qualityQ.Location = new System.Drawing.Point(234, 231);
            this.qualityQ.Name = "qualityQ";
            this.qualityQ.ReadOnly = true;
            this.qualityQ.Size = new System.Drawing.Size(330, 23);
            this.qualityQ.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Качество события Q:";
            // 
            // resultClass2
            // 
            this.resultClass2.Location = new System.Drawing.Point(234, 276);
            this.resultClass2.Name = "resultClass2";
            this.resultClass2.ReadOnly = true;
            this.resultClass2.Size = new System.Drawing.Size(330, 23);
            this.resultClass2.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Качество события Qp:";
            // 
            // fillBtn
            // 
            this.fillBtn.Location = new System.Drawing.Point(416, 319);
            this.fillBtn.Name = "fillBtn";
            this.fillBtn.Size = new System.Drawing.Size(148, 40);
            this.fillBtn.TabIndex = 11;
            this.fillBtn.Text = "Заполнить из левого окна!";
            this.fillBtn.UseVisualStyleBackColor = true;
            this.fillBtn.Click += new System.EventHandler(this.fillBtn_Click);
            // 
            // countBtn2
            // 
            this.countBtn2.Location = new System.Drawing.Point(16, 319);
            this.countBtn2.Name = "countBtn2";
            this.countBtn2.Size = new System.Drawing.Size(148, 40);
            this.countBtn2.TabIndex = 10;
            this.countBtn2.Text = "Вычислить!";
            this.countBtn2.UseVisualStyleBackColor = true;
            this.countBtn2.Click += new System.EventHandler(this.countBtn2_Click);
            // 
            // onePointSpeakers
            // 
            this.onePointSpeakers.Location = new System.Drawing.Point(234, 187);
            this.onePointSpeakers.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.onePointSpeakers.Name = "onePointSpeakers";
            this.onePointSpeakers.Size = new System.Drawing.Size(330, 23);
            this.onePointSpeakers.TabIndex = 8;
            // 
            // visitorsCount2
            // 
            this.visitorsCount2.Location = new System.Drawing.Point(234, 137);
            this.visitorsCount2.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.visitorsCount2.Name = "visitorsCount2";
            this.visitorsCount2.Size = new System.Drawing.Size(330, 23);
            this.visitorsCount2.TabIndex = 7;
            // 
            // nameTxb2
            // 
            this.nameTxb2.Location = new System.Drawing.Point(234, 33);
            this.nameTxb2.Name = "nameTxb2";
            this.nameTxb2.Size = new System.Drawing.Size(330, 23);
            this.nameTxb2.TabIndex = 7;
            // 
            // speakerCount2
            // 
            this.speakerCount2.Location = new System.Drawing.Point(234, 88);
            this.speakerCount2.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.speakerCount2.Name = "speakerCount2";
            this.speakerCount2.Size = new System.Drawing.Size(330, 23);
            this.speakerCount2.TabIndex = 6;
            // 
            // visitorsCountLbl2
            // 
            this.visitorsCountLbl2.AutoSize = true;
            this.visitorsCountLbl2.Location = new System.Drawing.Point(16, 139);
            this.visitorsCountLbl2.Name = "visitorsCountLbl2";
            this.visitorsCountLbl2.Size = new System.Drawing.Size(141, 15);
            this.visitorsCountLbl2.TabIndex = 3;
            this.visitorsCountLbl2.Text = "Количество участников:";
            // 
            // speakersCountLbl2
            // 
            this.speakersCountLbl2.AutoSize = true;
            this.speakersCountLbl2.Location = new System.Drawing.Point(16, 90);
            this.speakersCountLbl2.Name = "speakersCountLbl2";
            this.speakersCountLbl2.Size = new System.Drawing.Size(130, 15);
            this.speakersCountLbl2.TabIndex = 6;
            this.speakersCountLbl2.Text = "Количество ораторов:";
            // 
            // MeetingNameLbl2
            // 
            this.MeetingNameLbl2.AutoSize = true;
            this.MeetingNameLbl2.Location = new System.Drawing.Point(16, 36);
            this.MeetingNameLbl2.Name = "MeetingNameLbl2";
            this.MeetingNameLbl2.Size = new System.Drawing.Size(112, 15);
            this.MeetingNameLbl2.TabIndex = 5;
            this.MeetingNameLbl2.Text = "Название события:";
            // 
            // onePointSpeakersLbl
            // 
            this.onePointSpeakersLbl.AutoSize = true;
            this.onePointSpeakersLbl.Location = new System.Drawing.Point(16, 189);
            this.onePointSpeakersLbl.Name = "onePointSpeakersLbl";
            this.onePointSpeakersLbl.Size = new System.Drawing.Size(198, 15);
            this.onePointSpeakersLbl.TabIndex = 3;
            this.onePointSpeakersLbl.Text = "Высказывали одинаковые мысли: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 387);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitorsCount1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speakerCount1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.onePointSpeakers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitorsCount2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speakerCount2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox resultMeeting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button countBtn1;
        private System.Windows.Forms.NumericUpDown visitorsCount1;
        private System.Windows.Forms.NumericUpDown speakerCount1;
        private System.Windows.Forms.TextBox nameTxb1;
        private System.Windows.Forms.Label visitorsCountLbl1;
        private System.Windows.Forms.Label speakersCountLbl1;
        private System.Windows.Forms.Label MeetingNameLbl1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox resultClass2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button fillBtn;
        private System.Windows.Forms.Button countBtn2;
        private System.Windows.Forms.NumericUpDown onePointSpeakers;
        private System.Windows.Forms.NumericUpDown visitorsCount2;
        private System.Windows.Forms.TextBox nameTxb2;
        private System.Windows.Forms.NumericUpDown speakerCount2;
        private System.Windows.Forms.Label visitorsCountLbl2;
        private System.Windows.Forms.Label speakersCountLbl2;
        private System.Windows.Forms.Label MeetingNameLbl2;
        private System.Windows.Forms.Label onePointSpeakersLbl;
        private System.Windows.Forms.TextBox qualityQ;
        private System.Windows.Forms.Label label3;
    }
}
