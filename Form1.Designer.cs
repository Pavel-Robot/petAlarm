namespace MyProject
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.дата1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.дата2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Текущие_попытки = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.активностьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновпопыткиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.завершитьпотокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.databaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(18, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Заголовок";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(360, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 56);
            this.button1.TabIndex = 1;
            this.button1.Text = "Загрузить новое напоминание";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Программа для напоминаний";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(18, 122);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(282, 23);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Запись";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(18, 169);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(178, 23);
            this.dateTimePicker2.TabIndex = 5;
            this.dateTimePicker2.Value = new System.DateTime(2023, 11, 11, 23, 7, 51, 0);
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            this.dateTimePicker3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker3.Location = new System.Drawing.Point(18, 215);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(178, 23);
            this.dateTimePicker3.TabIndex = 6;
            this.dateTimePicker3.Value = new System.DateTime(2023, 11, 12, 13, 51, 0, 0);
            this.dateTimePicker3.ValueChanged += new System.EventHandler(this.dateTimePicker3_ValueChanged);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(404, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 41);
            this.button3.TabIndex = 8;
            this.button3.Text = "Настройки Default";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.дата1,
            this.дата2,
            this.Column3,
            this.Column4,
            this.Текущие_попытки,
            this.Column5});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.Location = new System.Drawing.Point(18, 284);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 40;
            this.dataGridView1.Size = new System.Drawing.Size(744, 136);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Заголовок";
            this.Column1.Name = "Column1";
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Описание";
            this.Column2.Name = "Column2";
            this.Column2.Width = 120;
            // 
            // дата1
            // 
            this.дата1.HeaderText = "Дата1";
            this.дата1.Name = "дата1";
            this.дата1.Width = 150;
            // 
            // дата2
            // 
            this.дата2.HeaderText = "Дата2";
            this.дата2.Name = "дата2";
            this.дата2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Время повтора, м";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Попыток";
            this.Column4.Name = "Column4";
            this.Column4.Width = 50;
            // 
            // Текущие_попытки
            // 
            this.Текущие_попытки.HeaderText = "Попытки текущие";
            this.Текущие_попытки.Name = "Текущие_попытки";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Работает?";
            this.Column5.Name = "Column5";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьToolStripMenuItem,
            this.изменитьToolStripMenuItem,
            this.активностьToolStripMenuItem,
            this.обновпопыткиToolStripMenuItem,
            this.завершитьпотокToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(171, 114);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.удалитьToolStripMenuItem.Text = "удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click_2);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.изменитьToolStripMenuItem.Text = "изменить";
            // 
            // активностьToolStripMenuItem
            // 
            this.активностьToolStripMenuItem.Name = "активностьToolStripMenuItem";
            this.активностьToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.активностьToolStripMenuItem.Text = "активность";
            this.активностьToolStripMenuItem.Click += new System.EventHandler(this.активностьToolStripMenuItem_Click);
            // 
            // обновпопыткиToolStripMenuItem
            // 
            this.обновпопыткиToolStripMenuItem.Name = "обновпопыткиToolStripMenuItem";
            this.обновпопыткиToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.обновпопыткиToolStripMenuItem.Text = "обнов_попытки";
            this.обновпопыткиToolStripMenuItem.Click += new System.EventHandler(this.обновпопыткиToolStripMenuItem_Click);
            // 
            // завершитьпотокToolStripMenuItem
            // 
            this.завершитьпотокToolStripMenuItem.Name = "завершитьпотокToolStripMenuItem";
            this.завершитьпотокToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.завершитьпотокToolStripMenuItem.Text = "завершить_поток";
            this.завершитьпотокToolStripMenuItem.Click += new System.EventHandler(this.завершитьпотокToolStripMenuItem_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(620, 246);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(142, 27);
            this.button4.TabIndex = 10;
            this.button4.Text = "Показать";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(552, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(145, 41);
            this.button5.TabIndex = 11;
            this.button5.Text = "Загрузить в Current";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(720, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Restart";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(709, 41);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(82, 23);
            this.button6.TabIndex = 15;
            this.button6.Text = "NowData";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(223, 171);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(77, 23);
            this.textBox3.TabIndex = 16;
            this.textBox3.Text = "t повтора";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(223, 217);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(119, 23);
            this.textBox4.TabIndex = 17;
            this.textBox4.Text = "кол-во повторов";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox5.Location = new System.Drawing.Point(317, 171);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(119, 23);
            this.textBox5.TabIndex = 18;
            this.textBox5.Text = "Тип объекта 1-2";
            // 
            // databaseBindingSource
            // 
            this.databaseBindingSource.DataSource = typeof(DataBaseWithObj.DataBase);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.databaseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.BindingSource databaseBindingSource;
        private System.Windows.Forms.Button button5;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem активностьToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn дата1;
        private System.Windows.Forms.DataGridViewTextBoxColumn дата2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Текущие_попытки;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.ToolStripMenuItem обновпопыткиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem завершитьпотокToolStripMenuItem;
    }
}

