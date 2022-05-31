
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
            this.ConfirmChoose_btn = new System.Windows.Forms.Button();
            this.FirstStone_rdbtn = new System.Windows.Forms.CheckBox();
            this.SecondStone_rdbtn = new System.Windows.Forms.CheckBox();
            this.ThirdStone_rdbtn = new System.Windows.Forms.CheckBox();
            this.FourthStone_rdbtn = new System.Windows.Forms.CheckBox();
            this.FifthStone_rdbtn = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
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
            // FirstStone_rdbtn
            // 
            this.FirstStone_rdbtn.AutoSize = true;
            this.FirstStone_rdbtn.Location = new System.Drawing.Point(39, 22);
            this.FirstStone_rdbtn.Name = "FirstStone_rdbtn";
            this.FirstStone_rdbtn.Size = new System.Drawing.Size(83, 19);
            this.FirstStone_rdbtn.TabIndex = 6;
            this.FirstStone_rdbtn.Text = "checkBox1";
            this.FirstStone_rdbtn.UseVisualStyleBackColor = true;
            // 
            // SecondStone_rdbtn
            // 
            this.SecondStone_rdbtn.AutoSize = true;
            this.SecondStone_rdbtn.Location = new System.Drawing.Point(39, 61);
            this.SecondStone_rdbtn.Name = "SecondStone_rdbtn";
            this.SecondStone_rdbtn.Size = new System.Drawing.Size(83, 19);
            this.SecondStone_rdbtn.TabIndex = 7;
            this.SecondStone_rdbtn.Text = "checkBox2";
            this.SecondStone_rdbtn.UseVisualStyleBackColor = true;
            // 
            // ThirdStone_rdbtn
            // 
            this.ThirdStone_rdbtn.AutoSize = true;
            this.ThirdStone_rdbtn.Location = new System.Drawing.Point(253, 22);
            this.ThirdStone_rdbtn.Name = "ThirdStone_rdbtn";
            this.ThirdStone_rdbtn.Size = new System.Drawing.Size(83, 19);
            this.ThirdStone_rdbtn.TabIndex = 8;
            this.ThirdStone_rdbtn.Text = "checkBox3";
            this.ThirdStone_rdbtn.UseVisualStyleBackColor = true;
            // 
            // FourthStone_rdbtn
            // 
            this.FourthStone_rdbtn.AutoSize = true;
            this.FourthStone_rdbtn.Location = new System.Drawing.Point(253, 61);
            this.FourthStone_rdbtn.Name = "FourthStone_rdbtn";
            this.FourthStone_rdbtn.Size = new System.Drawing.Size(83, 19);
            this.FourthStone_rdbtn.TabIndex = 9;
            this.FourthStone_rdbtn.Text = "checkBox4";
            this.FourthStone_rdbtn.UseVisualStyleBackColor = true;
            // 
            // FifthStone_rdbtn
            // 
            this.FifthStone_rdbtn.AutoSize = true;
            this.FifthStone_rdbtn.Location = new System.Drawing.Point(153, 97);
            this.FifthStone_rdbtn.Name = "FifthStone_rdbtn";
            this.FifthStone_rdbtn.Size = new System.Drawing.Size(83, 19);
            this.FifthStone_rdbtn.TabIndex = 10;
            this.FifthStone_rdbtn.Text = "checkBox5";
            this.FifthStone_rdbtn.UseVisualStyleBackColor = true;
            // 
            // ChooseStones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 194);
            this.Controls.Add(this.FifthStone_rdbtn);
            this.Controls.Add(this.FourthStone_rdbtn);
            this.Controls.Add(this.ThirdStone_rdbtn);
            this.Controls.Add(this.SecondStone_rdbtn);
            this.Controls.Add(this.FirstStone_rdbtn);
            this.Controls.Add(this.ConfirmChoose_btn);
            this.Name = "ChooseStones";
            this.Text = "ChooseStones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ConfirmChoose_btn;
        private System.Windows.Forms.CheckBox FirstStone_rdbtn;
        private System.Windows.Forms.CheckBox SecondStone_rdbtn;
        private System.Windows.Forms.CheckBox ThirdStone_rdbtn;
        private System.Windows.Forms.CheckBox FourthStone_rdbtn;
        private System.Windows.Forms.CheckBox FifthStone_rdbtn;
    }
}