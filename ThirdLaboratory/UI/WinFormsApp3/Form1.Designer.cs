
namespace WinFormsApp3
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.функцииТелефонаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PowerSwicthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SendMessageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenChromeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VirusCheckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.устройстваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 40);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(336, 379);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.функцииТелефонаToolStripMenuItem,
            this.устройстваToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(360, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // функцииТелефонаToolStripMenuItem
            // 
            this.функцииТелефонаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PowerSwicthToolStripMenuItem,
            this.toolStripSeparator1,
            this.CallToolStripMenuItem,
            this.SendMessageToolStripMenuItem,
            this.OpenChromeToolStripMenuItem,
            this.VirusCheckToolStripMenuItem});
            this.функцииТелефонаToolStripMenuItem.Name = "функцииТелефонаToolStripMenuItem";
            this.функцииТелефонаToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.функцииТелефонаToolStripMenuItem.Text = "Функции телефона";
            // 
            // PowerSwicthToolStripMenuItem
            // 
            this.PowerSwicthToolStripMenuItem.Name = "PowerSwicthToolStripMenuItem";
            this.PowerSwicthToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.PowerSwicthToolStripMenuItem.Text = "Нажать кнопку включения";
            this.PowerSwicthToolStripMenuItem.Click += new System.EventHandler(this.PowerSwicthToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(219, 6);
            // 
            // CallToolStripMenuItem
            // 
            this.CallToolStripMenuItem.Name = "CallToolStripMenuItem";
            this.CallToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.CallToolStripMenuItem.Text = "Позвонить";
            this.CallToolStripMenuItem.Click += new System.EventHandler(this.CallToolStripMenuItem_Click);
            // 
            // SendMessageToolStripMenuItem
            // 
            this.SendMessageToolStripMenuItem.Name = "SendMessageToolStripMenuItem";
            this.SendMessageToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.SendMessageToolStripMenuItem.Text = "Отправить сообщение";
            this.SendMessageToolStripMenuItem.Click += new System.EventHandler(this.SendMessageToolStripMenuItem_Click);
            // 
            // OpenChromeToolStripMenuItem
            // 
            this.OpenChromeToolStripMenuItem.Name = "OpenChromeToolStripMenuItem";
            this.OpenChromeToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.OpenChromeToolStripMenuItem.Text = "Запустить Chrome";
            this.OpenChromeToolStripMenuItem.Click += new System.EventHandler(this.OpenChromeToolStripMenuItem_Click);
            // 
            // VirusCheckToolStripMenuItem
            // 
            this.VirusCheckToolStripMenuItem.Name = "VirusCheckToolStripMenuItem";
            this.VirusCheckToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.VirusCheckToolStripMenuItem.Text = "Проверка на вирусы";
            this.VirusCheckToolStripMenuItem.Click += new System.EventHandler(this.VirusCheckToolStripMenuItem_Click);
            // 
            // устройстваToolStripMenuItem
            // 
            this.устройстваToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToolStripMenuItem,
            this.DeleteToolStripMenuItem});
            this.устройстваToolStripMenuItem.Name = "устройстваToolStripMenuItem";
            this.устройстваToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.устройстваToolStripMenuItem.Text = "Устройства";
            // 
            // AddToolStripMenuItem
            // 
            this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
            this.AddToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AddToolStripMenuItem.Text = "Добавить";
            this.AddToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.DeleteToolStripMenuItem.Text = "Удалить";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 432);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem функцииТелефонаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PowerSwicthToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem CallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SendMessageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenChromeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VirusCheckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem устройстваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
    }
}
