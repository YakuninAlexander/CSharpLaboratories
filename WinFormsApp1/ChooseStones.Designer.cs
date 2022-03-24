
namespace WinFormsApp1
{
    partial class ChooseStones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FirstStone_rdbtn = new System.Windows.Forms.RadioButton();
            this.SecondStone_rdbtn = new System.Windows.Forms.RadioButton();
            this.ThirdStone_rdbtn = new System.Windows.Forms.RadioButton();
            this.FourthStone_rdbtn = new System.Windows.Forms.RadioButton();
            this.FifthStone_rdbtn = new System.Windows.Forms.RadioButton();
            this.ConfirmChoose_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstStone_rdbtn
            // 
            this.FirstStone_rdbtn.AutoSize = true;
            this.FirstStone_rdbtn.Location = new System.Drawing.Point(45, 24);
            this.FirstStone_rdbtn.Name = "FirstStone_rdbtn";
            this.FirstStone_rdbtn.Size = new System.Drawing.Size(94, 19);
            this.FirstStone_rdbtn.TabIndex = 0;
            this.FirstStone_rdbtn.TabStop = true;
            this.FirstStone_rdbtn.Text = "radioButton1";
            this.FirstStone_rdbtn.UseVisualStyleBackColor = true;
            // 
            // SecondStone_rdbtn
            // 
            this.SecondStone_rdbtn.AutoSize = true;
            this.SecondStone_rdbtn.Location = new System.Drawing.Point(241, 24);
            this.SecondStone_rdbtn.Name = "SecondStone_rdbtn";
            this.SecondStone_rdbtn.Size = new System.Drawing.Size(94, 19);
            this.SecondStone_rdbtn.TabIndex = 1;
            this.SecondStone_rdbtn.TabStop = true;
            this.SecondStone_rdbtn.Text = "radioButton2";
            this.SecondStone_rdbtn.UseVisualStyleBackColor = true;
            // 
            // ThirdStone_rdbtn
            // 
            this.ThirdStone_rdbtn.AutoSize = true;
            this.ThirdStone_rdbtn.Location = new System.Drawing.Point(45, 72);
            this.ThirdStone_rdbtn.Name = "ThirdStone_rdbtn";
            this.ThirdStone_rdbtn.Size = new System.Drawing.Size(94, 19);
            this.ThirdStone_rdbtn.TabIndex = 2;
            this.ThirdStone_rdbtn.TabStop = true;
            this.ThirdStone_rdbtn.Text = "radioButton3";
            this.ThirdStone_rdbtn.UseVisualStyleBackColor = true;
            // 
            // FourthStone_rdbtn
            // 
            this.FourthStone_rdbtn.AutoSize = true;
            this.FourthStone_rdbtn.Location = new System.Drawing.Point(241, 72);
            this.FourthStone_rdbtn.Name = "FourthStone_rdbtn";
            this.FourthStone_rdbtn.Size = new System.Drawing.Size(94, 19);
            this.FourthStone_rdbtn.TabIndex = 3;
            this.FourthStone_rdbtn.TabStop = true;
            this.FourthStone_rdbtn.Text = "radioButton4";
            this.FourthStone_rdbtn.UseVisualStyleBackColor = true;
            // 
            // FifthStone_rdbtn
            // 
            this.FifthStone_rdbtn.AutoSize = true;
            this.FifthStone_rdbtn.Location = new System.Drawing.Point(142, 115);
            this.FifthStone_rdbtn.Name = "FifthStone_rdbtn";
            this.FifthStone_rdbtn.Size = new System.Drawing.Size(94, 19);
            this.FifthStone_rdbtn.TabIndex = 4;
            this.FifthStone_rdbtn.TabStop = true;
            this.FifthStone_rdbtn.Text = "radioButton5";
            this.FifthStone_rdbtn.UseVisualStyleBackColor = true;
            // 
            // ConfirmChoose_btn
            // 
            this.ConfirmChoose_btn.Location = new System.Drawing.Point(142, 150);
            this.ConfirmChoose_btn.Name = "ConfirmChoose_btn";
            this.ConfirmChoose_btn.Size = new System.Drawing.Size(94, 23);
            this.ConfirmChoose_btn.TabIndex = 5;
            this.ConfirmChoose_btn.Text = "OK";
            this.ConfirmChoose_btn.UseVisualStyleBackColor = true;
            this.ConfirmChoose_btn.Click += new System.EventHandler(this.ConfirmChoose_btn_Click);
            // 
            // ChooseStones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 194);
            this.Controls.Add(this.ConfirmChoose_btn);
            this.Controls.Add(this.FifthStone_rdbtn);
            this.Controls.Add(this.FourthStone_rdbtn);
            this.Controls.Add(this.ThirdStone_rdbtn);
            this.Controls.Add(this.SecondStone_rdbtn);
            this.Controls.Add(this.FirstStone_rdbtn);
            this.Name = "ChooseStones";
            this.Text = "ChooseStones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton FirstStone_rdbtn;
        private System.Windows.Forms.RadioButton SecondStone_rdbtn;
        private System.Windows.Forms.RadioButton ThirdStone_rdbtn;
        private System.Windows.Forms.RadioButton FourthStone_rdbtn;
        private System.Windows.Forms.RadioButton FifthStone_rdbtn;
        private System.Windows.Forms.Button ConfirmChoose_btn;
    }
}