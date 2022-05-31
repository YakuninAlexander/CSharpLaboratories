
namespace WinFormsApp1
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
            this.getNecklace_btn = new System.Windows.Forms.Button();
            this.sortNecklace_btn = new System.Windows.Forms.Button();
            this.calculateTotal_btn = new System.Windows.Forms.Button();
            this.getForTransparency = new System.Windows.Forms.Button();
            this.necklaceDisplay_txb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // getNecklace_btn
            // 
            this.getNecklace_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.getNecklace_btn.Location = new System.Drawing.Point(12, 89);
            this.getNecklace_btn.Name = "getNecklace_btn";
            this.getNecklace_btn.Size = new System.Drawing.Size(129, 47);
            this.getNecklace_btn.TabIndex = 0;
            this.getNecklace_btn.Text = "Собрать ожерелье";
            this.getNecklace_btn.UseVisualStyleBackColor = true;
            this.getNecklace_btn.Click += new System.EventHandler(this.getNecklace_btn_Click);
            // 
            // sortNecklace_btn
            // 
            this.sortNecklace_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sortNecklace_btn.Location = new System.Drawing.Point(147, 89);
            this.sortNecklace_btn.Name = "sortNecklace_btn";
            this.sortNecklace_btn.Size = new System.Drawing.Size(129, 47);
            this.sortNecklace_btn.TabIndex = 1;
            this.sortNecklace_btn.Text = "Отсортировать \r\nпо стоимости";
            this.sortNecklace_btn.UseVisualStyleBackColor = true;
            this.sortNecklace_btn.Click += new System.EventHandler(this.sortNecklace_btn_Click);
            // 
            // calculateTotal_btn
            // 
            this.calculateTotal_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calculateTotal_btn.Location = new System.Drawing.Point(282, 89);
            this.calculateTotal_btn.Name = "calculateTotal_btn";
            this.calculateTotal_btn.Size = new System.Drawing.Size(129, 47);
            this.calculateTotal_btn.TabIndex = 2;
            this.calculateTotal_btn.Text = "Посчитать \r\nвес и цену";
            this.calculateTotal_btn.UseVisualStyleBackColor = true;
            this.calculateTotal_btn.Click += new System.EventHandler(this.calculateTotal_btn_Click);
            // 
            // getForTransparency
            // 
            this.getForTransparency.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.getForTransparency.Location = new System.Drawing.Point(417, 89);
            this.getForTransparency.Name = "getForTransparency";
            this.getForTransparency.Size = new System.Drawing.Size(129, 47);
            this.getForTransparency.TabIndex = 3;
            this.getForTransparency.Text = "Отобрать по прозрачности";
            this.getForTransparency.UseVisualStyleBackColor = true;
            this.getForTransparency.Click += new System.EventHandler(this.getForTransparency_Click);
            // 
            // necklaceDisplay_txb
            // 
            this.necklaceDisplay_txb.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.necklaceDisplay_txb.Location = new System.Drawing.Point(12, 50);
            this.necklaceDisplay_txb.Name = "necklaceDisplay_txb";
            this.necklaceDisplay_txb.Size = new System.Drawing.Size(534, 33);
            this.necklaceDisplay_txb.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(208, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ваше ожерелье";
            // 
            // info
            // 
            this.info.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.info.Location = new System.Drawing.Point(217, 142);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(129, 47);
            this.info.TabIndex = 6;
            this.info.Text = "Информация о камнях";
            this.info.UseVisualStyleBackColor = true;
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 199);
            this.Controls.Add(this.info);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.necklaceDisplay_txb);
            this.Controls.Add(this.getForTransparency);
            this.Controls.Add(this.calculateTotal_btn);
            this.Controls.Add(this.sortNecklace_btn);
            this.Controls.Add(this.getNecklace_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getNecklace_btn;
        private System.Windows.Forms.Button sortNecklace_btn;
        private System.Windows.Forms.Button calculateTotal_btn;
        private System.Windows.Forms.Button getForTransparency;
        private System.Windows.Forms.TextBox necklaceDisplay_txb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button info;
    }
}
