namespace Task1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.заданияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьИзображениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.квантованиеИзображенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уменьшениеРазрешенияИзображенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.линейноеКонтрастированиеИзображенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фрагментИзображенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заменаЗначенияЯркостиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.гистограммаРаспределенияЯркостейЗашумленногоИзображенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.поэлементноеПреобразованиеИзображенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заданияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(504, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // заданияToolStripMenuItem
            // 
            this.заданияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьИзображениеToolStripMenuItem,
            this.квантованиеИзображенияToolStripMenuItem,
            this.уменьшениеРазрешенияИзображенияToolStripMenuItem,
            this.линейноеКонтрастированиеИзображенияToolStripMenuItem,
            this.фрагментИзображенияToolStripMenuItem,
            this.заменаЗначенияЯркостиToolStripMenuItem,
            this.гистограммаРаспределенияЯркостейЗашумленногоИзображенияToolStripMenuItem,
            this.toolStripMenuItem2,
            this.поэлементноеПреобразованиеИзображенияToolStripMenuItem});
            this.заданияToolStripMenuItem.Name = "заданияToolStripMenuItem";
            this.заданияToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.заданияToolStripMenuItem.Text = "Задания";
            // 
            // открытьИзображениеToolStripMenuItem
            // 
            this.открытьИзображениеToolStripMenuItem.Name = "открытьИзображениеToolStripMenuItem";
            this.открытьИзображениеToolStripMenuItem.Size = new System.Drawing.Size(515, 22);
            this.открытьИзображениеToolStripMenuItem.Text = "Открыть изображение";
            this.открытьИзображениеToolStripMenuItem.Click += new System.EventHandler(this.открытьИзображениеToolStripMenuItem_Click);
            // 
            // квантованиеИзображенияToolStripMenuItem
            // 
            this.квантованиеИзображенияToolStripMenuItem.Name = "квантованиеИзображенияToolStripMenuItem";
            this.квантованиеИзображенияToolStripMenuItem.Size = new System.Drawing.Size(515, 22);
            this.квантованиеИзображенияToolStripMenuItem.Text = "Уменьшить частоту квантования изображения ";
            this.квантованиеИзображенияToolStripMenuItem.Click += new System.EventHandler(this.квантованиеИзображенияToolStripMenuItem_Click);
            // 
            // уменьшениеРазрешенияИзображенияToolStripMenuItem
            // 
            this.уменьшениеРазрешенияИзображенияToolStripMenuItem.Name = "уменьшениеРазрешенияИзображенияToolStripMenuItem";
            this.уменьшениеРазрешенияИзображенияToolStripMenuItem.Size = new System.Drawing.Size(515, 22);
            this.уменьшениеРазрешенияИзображенияToolStripMenuItem.Text = "Уменьшение разрешения изображения";
            this.уменьшениеРазрешенияИзображенияToolStripMenuItem.Click += new System.EventHandler(this.уменьшениеРазрешенияИзображенияToolStripMenuItem_Click);
            // 
            // линейноеКонтрастированиеИзображенияToolStripMenuItem
            // 
            this.линейноеКонтрастированиеИзображенияToolStripMenuItem.Name = "линейноеКонтрастированиеИзображенияToolStripMenuItem";
            this.линейноеКонтрастированиеИзображенияToolStripMenuItem.Size = new System.Drawing.Size(515, 22);
            this.линейноеКонтрастированиеИзображенияToolStripMenuItem.Text = "Линейное контрастирование изображения ";
            this.линейноеКонтрастированиеИзображенияToolStripMenuItem.Click += new System.EventHandler(this.линейноеКонтрастированиеИзображенияToolStripMenuItem_Click);
            // 
            // фрагментИзображенияToolStripMenuItem
            // 
            this.фрагментИзображенияToolStripMenuItem.Name = "фрагментИзображенияToolStripMenuItem";
            this.фрагментИзображенияToolStripMenuItem.Size = new System.Drawing.Size(515, 22);
            this.фрагментИзображенияToolStripMenuItem.Text = "Фрагмент изображения ";
            this.фрагментИзображенияToolStripMenuItem.Click += new System.EventHandler(this.фрагментИзображенияToolStripMenuItem_Click);
            // 
            // заменаЗначенияЯркостиToolStripMenuItem
            // 
            this.заменаЗначенияЯркостиToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.заменаЗначенияЯркостиToolStripMenuItem.Name = "заменаЗначенияЯркостиToolStripMenuItem";
            this.заменаЗначенияЯркостиToolStripMenuItem.Size = new System.Drawing.Size(515, 22);
            this.заменаЗначенияЯркостиToolStripMenuItem.Text = "Случайным образом заменить значения яркости заданного процента пикселей";
            this.заменаЗначенияЯркостиToolStripMenuItem.Click += new System.EventHandler(this.заменаЗначенияЯркостиToolStripMenuItem_Click);
            // 
            // гистограммаРаспределенияЯркостейЗашумленногоИзображенияToolStripMenuItem
            // 
            this.гистограммаРаспределенияЯркостейЗашумленногоИзображенияToolStripMenuItem.Name = "гистограммаРаспределенияЯркостейЗашумленногоИзображенияToolStripMenuItem";
            this.гистограммаРаспределенияЯркостейЗашумленногоИзображенияToolStripMenuItem.Size = new System.Drawing.Size(515, 22);
            this.гистограммаРаспределенияЯркостейЗашумленногоИзображенияToolStripMenuItem.Text = "Гистограмма распределения яркостей зашумленного изображения";
            this.гистограммаРаспределенияЯркостейЗашумленногоИзображенияToolStripMenuItem.Click += new System.EventHandler(this.гистограммаРаспределенияЯркостейЗашумленногоИзображенияToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(515, 22);
            this.toolStripMenuItem2.Text = "Оценить  максимальное  и  минимальное  значение  элементов изображения";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // поэлементноеПреобразованиеИзображенияToolStripMenuItem
            // 
            this.поэлементноеПреобразованиеИзображенияToolStripMenuItem.Name = "поэлементноеПреобразованиеИзображенияToolStripMenuItem";
            this.поэлементноеПреобразованиеИзображенияToolStripMenuItem.Size = new System.Drawing.Size(515, 22);
            this.поэлементноеПреобразованиеИзображенияToolStripMenuItem.Text = "Преобразование в негатив";
            this.поэлементноеПреобразованиеИзображенияToolStripMenuItem.Click += new System.EventHandler(this.поэлементноеПреобразованиеИзображенияToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 150);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(447, 323);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(12, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(447, 84);
            this.button1.TabIndex = 2;
            this.button1.Text = "Преобразовать изображение к 256";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(504, 500);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Поэлементные преобразования цифровых изображений";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem заданияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьИзображениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem квантованиеИзображенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem уменьшениеРазрешенияИзображенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem линейноеКонтрастированиеИзображенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фрагментИзображенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заменаЗначенияЯркостиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem гистограммаРаспределенияЯркостейЗашумленногоИзображенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem поэлементноеПреобразованиеИзображенияToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}

