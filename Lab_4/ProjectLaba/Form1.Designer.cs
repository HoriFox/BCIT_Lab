namespace Lab_4
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
            this.loadb = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.findb = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Кнопка загрузки новых данных
            // 
            this.loadb.Location = new System.Drawing.Point(28, 12);
            this.loadb.Name = "loadb";
            this.loadb.Size = new System.Drawing.Size(120, 23);
            this.loadb.TabIndex = 0;
            this.loadb.Text = "Загрузить данные";
            this.loadb.UseVisualStyleBackColor = true;
            this.loadb.Click += new System.EventHandler(this.button1_Click);
            // 
            // Окно разобранных слов
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(28, 48);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(200, 300);
            this.listBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // Кнопка поиска текста
            // 
            this.findb.Location = new System.Drawing.Point(411, 12);
            this.findb.Name = "findb";
            this.findb.Size = new System.Drawing.Size(120, 23);
            this.findb.TabIndex = 5;
            this.findb.Text = "Найти слово";
            this.findb.UseVisualStyleBackColor = true;
            this.findb.Click += new System.EventHandler(this.findb_Click);
            // 
            // Строка поиска слова
            // 
            this.textBox1.Location = new System.Drawing.Point(256, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 20);
            this.textBox1.TabIndex = 6;
            // 
            // Главное окно
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 350);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.findb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.loadb);
            this.Name = "Form1";
            this.Text = "Lab_4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadb;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button findb;
        private System.Windows.Forms.TextBox textBox1;
    }
}

