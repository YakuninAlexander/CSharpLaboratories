namespace WinFormsApp4
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
            this.label1 = new System.Windows.Forms.Label();
            this.class_cmbx = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.method_cmbx = new System.Windows.Forms.ComboBox();
            this.properties_lbx = new System.Windows.Forms.ListBox();
            this.parameters_lbx = new System.Windows.Forms.ListBox();
            this.create_btn = new System.Windows.Forms.Button();
            this.setParameters_btn = new System.Windows.Forms.Button();
            this.methodExecute_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Класс:";
            // 
            // class_cmbx
            // 
            this.class_cmbx.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.class_cmbx.FormattingEnabled = true;
            this.class_cmbx.Location = new System.Drawing.Point(83, 18);
            this.class_cmbx.Name = "class_cmbx";
            this.class_cmbx.Size = new System.Drawing.Size(236, 33);
            this.class_cmbx.TabIndex = 1;
            this.class_cmbx.SelectedIndexChanged += new System.EventHandler(this.class_cmbx_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Свойства:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(350, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Параметры метода:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(350, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Метод:";
            // 
            // method_cmbx
            // 
            this.method_cmbx.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.method_cmbx.FormattingEnabled = true;
            this.method_cmbx.Location = new System.Drawing.Point(428, 18);
            this.method_cmbx.Name = "method_cmbx";
            this.method_cmbx.Size = new System.Drawing.Size(368, 33);
            this.method_cmbx.TabIndex = 6;
            this.method_cmbx.SelectedIndexChanged += new System.EventHandler(this.method_cmbx_SelectedIndexChanged);
            // 
            // properties_lbx
            // 
            this.properties_lbx.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.properties_lbx.FormattingEnabled = true;
            this.properties_lbx.ItemHeight = 25;
            this.properties_lbx.Location = new System.Drawing.Point(12, 102);
            this.properties_lbx.Name = "properties_lbx";
            this.properties_lbx.Size = new System.Drawing.Size(307, 279);
            this.properties_lbx.TabIndex = 7;
            // 
            // parameters_lbx
            // 
            this.parameters_lbx.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.parameters_lbx.FormattingEnabled = true;
            this.parameters_lbx.ItemHeight = 25;
            this.parameters_lbx.Location = new System.Drawing.Point(350, 102);
            this.parameters_lbx.Name = "parameters_lbx";
            this.parameters_lbx.Size = new System.Drawing.Size(446, 279);
            this.parameters_lbx.TabIndex = 8;
            // 
            // create_btn
            // 
            this.create_btn.Enabled = false;
            this.create_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.create_btn.Location = new System.Drawing.Point(12, 400);
            this.create_btn.Name = "create_btn";
            this.create_btn.Size = new System.Drawing.Size(163, 38);
            this.create_btn.TabIndex = 9;
            this.create_btn.Text = "Создать объект";
            this.create_btn.UseVisualStyleBackColor = true;
            this.create_btn.Click += new System.EventHandler(this.create_btn_Click);
            // 
            // setParameters_btn
            // 
            this.setParameters_btn.Enabled = false;
            this.setParameters_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.setParameters_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.setParameters_btn.Location = new System.Drawing.Point(350, 400);
            this.setParameters_btn.Name = "setParameters_btn";
            this.setParameters_btn.Size = new System.Drawing.Size(163, 38);
            this.setParameters_btn.TabIndex = 10;
            this.setParameters_btn.Text = "Ввести параметры";
            this.setParameters_btn.UseVisualStyleBackColor = true;
            this.setParameters_btn.Click += new System.EventHandler(this.setParameters_btn_Click);
            // 
            // methodExecute_btn
            // 
            this.methodExecute_btn.Enabled = false;
            this.methodExecute_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.methodExecute_btn.Location = new System.Drawing.Point(633, 400);
            this.methodExecute_btn.Name = "methodExecute_btn";
            this.methodExecute_btn.Size = new System.Drawing.Size(163, 38);
            this.methodExecute_btn.TabIndex = 11;
            this.methodExecute_btn.Text = "Выполнить метод";
            this.methodExecute_btn.UseVisualStyleBackColor = true;
            this.methodExecute_btn.Click += new System.EventHandler(this.methodExecute_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(328, 450);
            this.Controls.Add(this.methodExecute_btn);
            this.Controls.Add(this.setParameters_btn);
            this.Controls.Add(this.create_btn);
            this.Controls.Add(this.parameters_lbx);
            this.Controls.Add(this.properties_lbx);
            this.Controls.Add(this.method_cmbx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.class_cmbx);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox class_cmbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox method_cmbx;
        private System.Windows.Forms.ListBox properties_lbx;
        private System.Windows.Forms.ListBox parameters_lbx;
        private System.Windows.Forms.Button create_btn;
        private System.Windows.Forms.Button setParameters_btn;
        private System.Windows.Forms.Button methodExecute_btn;
    }
}
