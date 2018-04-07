namespace Task2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.заданияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.гистограммаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.эквализацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.приведенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(425, 250);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(461, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Открыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заданияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(640, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // заданияToolStripMenuItem
            // 
            this.заданияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.гистограммаToolStripMenuItem,
            this.эквализацияToolStripMenuItem,
            this.приведенияToolStripMenuItem});
            this.заданияToolStripMenuItem.Name = "заданияToolStripMenuItem";
            this.заданияToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.заданияToolStripMenuItem.Text = "Задания";
            // 
            // гистограммаToolStripMenuItem
            // 
            this.гистограммаToolStripMenuItem.Name = "гистограммаToolStripMenuItem";
            this.гистограммаToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.гистограммаToolStripMenuItem.Text = "Гистограмма";
            this.гистограммаToolStripMenuItem.Click += new System.EventHandler(this.гистограммаToolStripMenuItem_Click);
            // 
            // эквализацияToolStripMenuItem
            // 
            this.эквализацияToolStripMenuItem.Name = "эквализацияToolStripMenuItem";
            this.эквализацияToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.эквализацияToolStripMenuItem.Text = "Метод эквализации гистограммы";
            this.эквализацияToolStripMenuItem.Click += new System.EventHandler(this.эквализацияToolStripMenuItem_Click);
            // 
            // приведенияToolStripMenuItem
            // 
            this.приведенияToolStripMenuItem.Name = "приведенияToolStripMenuItem";
            this.приведенияToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.приведенияToolStripMenuItem.Text = "Метод приведение гистограммы";
            this.приведенияToolStripMenuItem.Click += new System.EventHandler(this.приведенияToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 319);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Гистограммные методы преобразования цифровых изображений";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem заданияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem гистограммаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem эквализацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem приведенияToolStripMenuItem;
    }
}

