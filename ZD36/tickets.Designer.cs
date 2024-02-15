namespace ZD36
{
    partial class tickets
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tickets));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.id_bilet = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.vibor_seansov = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numberseansDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timestartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dlitminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seansBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gallery1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gallery1 = new ZD36.gallery1();
            this.pokazat = new System.Windows.Forms.Button();
            this.vibor_seansa = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.skrit = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.fio_pol = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.oplata = new System.Windows.Forms.Button();
            this.card = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.price_tb = new System.Windows.Forms.TextBox();
            this.time_tb = new System.Windows.Forms.TextBox();
            this.data_tb = new System.Windows.Forms.TextBox();
            this.id_bilet2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.zagruzka = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.vibor_dati = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.seansTableAdapter = new ZD36.gallery1TableAdapters.seansTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.vibor_seansov.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seansBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gallery1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gallery1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.zagruzka.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 62);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1016, 489);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(209)))), ((int)(((byte)(168)))));
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1008, 456);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Выбор билета";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.id_bilet);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.vibor_seansov);
            this.panel2.Controls.Add(this.pokazat);
            this.panel2.Controls.Add(this.vibor_seansa);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.skrit);
            this.panel2.Location = new System.Drawing.Point(24, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(974, 411);
            this.panel2.TabIndex = 10;
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button5.Location = new System.Drawing.Point(785, 322);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(178, 69);
            this.button5.TabIndex = 15;
            this.button5.Text = "Перейти к оплате";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // id_bilet
            // 
            this.id_bilet.Location = new System.Drawing.Point(863, 135);
            this.id_bilet.Name = "id_bilet";
            this.id_bilet.ReadOnly = true;
            this.id_bilet.Size = new System.Drawing.Size(76, 26);
            this.id_bilet.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(704, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Номер билета:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(32, 135);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(666, 257);
            this.dataGridView2.TabIndex = 12;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button4.Location = new System.Drawing.Point(8, 72);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(433, 37);
            this.button4.TabIndex = 11;
            this.button4.Text = "Найти билет";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(3, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(305, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Выберите ваш билет: (Нажать)";
            // 
            // vibor_seansov
            // 
            this.vibor_seansov.Controls.Add(this.dataGridView1);
            this.vibor_seansov.Location = new System.Drawing.Point(447, 3);
            this.vibor_seansov.Name = "vibor_seansov";
            this.vibor_seansov.Size = new System.Drawing.Size(516, 123);
            this.vibor_seansov.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberseansDataGridViewTextBoxColumn,
            this.timestartDataGridViewTextBoxColumn,
            this.dlitminDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.seansBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(516, 123);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // numberseansDataGridViewTextBoxColumn
            // 
            this.numberseansDataGridViewTextBoxColumn.DataPropertyName = "number_seans";
            this.numberseansDataGridViewTextBoxColumn.HeaderText = "number_seans";
            this.numberseansDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.numberseansDataGridViewTextBoxColumn.Name = "numberseansDataGridViewTextBoxColumn";
            this.numberseansDataGridViewTextBoxColumn.ReadOnly = true;
            this.numberseansDataGridViewTextBoxColumn.Width = 150;
            // 
            // timestartDataGridViewTextBoxColumn
            // 
            this.timestartDataGridViewTextBoxColumn.DataPropertyName = "time_start";
            this.timestartDataGridViewTextBoxColumn.HeaderText = "time_start";
            this.timestartDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.timestartDataGridViewTextBoxColumn.Name = "timestartDataGridViewTextBoxColumn";
            this.timestartDataGridViewTextBoxColumn.ReadOnly = true;
            this.timestartDataGridViewTextBoxColumn.Width = 150;
            // 
            // dlitminDataGridViewTextBoxColumn
            // 
            this.dlitminDataGridViewTextBoxColumn.DataPropertyName = "dlit(min)";
            this.dlitminDataGridViewTextBoxColumn.HeaderText = "dlit(min)";
            this.dlitminDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dlitminDataGridViewTextBoxColumn.Name = "dlitminDataGridViewTextBoxColumn";
            this.dlitminDataGridViewTextBoxColumn.ReadOnly = true;
            this.dlitminDataGridViewTextBoxColumn.Width = 150;
            // 
            // seansBindingSource
            // 
            this.seansBindingSource.DataMember = "seans";
            this.seansBindingSource.DataSource = this.gallery1BindingSource;
            // 
            // gallery1BindingSource
            // 
            this.gallery1BindingSource.DataSource = this.gallery1;
            this.gallery1BindingSource.Position = 0;
            // 
            // gallery1
            // 
            this.gallery1.DataSetName = "gallery1";
            this.gallery1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pokazat
            // 
            this.pokazat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pokazat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.pokazat.Location = new System.Drawing.Point(347, 28);
            this.pokazat.Name = "pokazat";
            this.pokazat.Size = new System.Drawing.Size(94, 28);
            this.pokazat.TabIndex = 7;
            this.pokazat.Text = "Показать";
            this.pokazat.UseVisualStyleBackColor = true;
            this.pokazat.Click += new System.EventHandler(this.pokazat_Click);
            // 
            // vibor_seansa
            // 
            this.vibor_seansa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vibor_seansa.FormattingEnabled = true;
            this.vibor_seansa.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.vibor_seansa.Location = new System.Drawing.Point(177, 25);
            this.vibor_seansa.Name = "vibor_seansa";
            this.vibor_seansa.Size = new System.Drawing.Size(164, 33);
            this.vibor_seansa.TabIndex = 2;
            this.vibor_seansa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.vibor_seansa_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Выберите сеанс:";
            // 
            // skrit
            // 
            this.skrit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skrit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.skrit.Location = new System.Drawing.Point(347, 30);
            this.skrit.Name = "skrit";
            this.skrit.Size = new System.Drawing.Size(94, 28);
            this.skrit.TabIndex = 9;
            this.skrit.Text = "Скрыть";
            this.skrit.UseVisualStyleBackColor = true;
            this.skrit.Click += new System.EventHandler(this.skrit_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(209)))), ((int)(((byte)(168)))));
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1008, 456);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Оплата";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.fio_pol);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.oplata);
            this.panel4.Controls.Add(this.card);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.price_tb);
            this.panel4.Controls.Add(this.time_tb);
            this.panel4.Controls.Add(this.data_tb);
            this.panel4.Controls.Add(this.id_bilet2);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.button6);
            this.panel4.Location = new System.Drawing.Point(36, 29);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(927, 407);
            this.panel4.TabIndex = 0;
            // 
            // fio_pol
            // 
            this.fio_pol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fio_pol.Location = new System.Drawing.Point(244, 196);
            this.fio_pol.MaxLength = 50;
            this.fio_pol.Name = "fio_pol";
            this.fio_pol.Size = new System.Drawing.Size(372, 30);
            this.fio_pol.TabIndex = 16;
            this.fio_pol.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.fio_pol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(61, 199);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(177, 25);
            this.label12.TabIndex = 14;
            this.label12.Text = "ФИО посетителя";
            // 
            // oplata
            // 
            this.oplata.BackColor = System.Drawing.Color.DarkOrange;
            this.oplata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oplata.Location = new System.Drawing.Point(432, 251);
            this.oplata.Name = "oplata";
            this.oplata.Size = new System.Drawing.Size(123, 83);
            this.oplata.TabIndex = 13;
            this.oplata.Text = "Оплатить";
            this.oplata.UseVisualStyleBackColor = false;
            this.oplata.Click += new System.EventHandler(this.oplata_Click);
            // 
            // card
            // 
            this.card.Location = new System.Drawing.Point(276, 251);
            this.card.MaxLength = 4;
            this.card.Name = "card";
            this.card.Size = new System.Drawing.Size(100, 26);
            this.card.TabIndex = 12;
            this.card.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(61, 250);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(209, 25);
            this.label11.TabIndex = 11;
            this.label11.Text = "Последние 4 цифры:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(662, 172);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 223);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Location = new System.Drawing.Point(405, 35);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(488, 131);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // price_tb
            // 
            this.price_tb.Location = new System.Drawing.Point(229, 140);
            this.price_tb.Name = "price_tb";
            this.price_tb.ReadOnly = true;
            this.price_tb.Size = new System.Drawing.Size(100, 26);
            this.price_tb.TabIndex = 8;
            // 
            // time_tb
            // 
            this.time_tb.Location = new System.Drawing.Point(229, 105);
            this.time_tb.Name = "time_tb";
            this.time_tb.ReadOnly = true;
            this.time_tb.Size = new System.Drawing.Size(100, 26);
            this.time_tb.TabIndex = 7;
            // 
            // data_tb
            // 
            this.data_tb.Location = new System.Drawing.Point(229, 69);
            this.data_tb.MaxLength = 10;
            this.data_tb.Name = "data_tb";
            this.data_tb.ReadOnly = true;
            this.data_tb.Size = new System.Drawing.Size(100, 26);
            this.data_tb.TabIndex = 6;
            // 
            // id_bilet2
            // 
            this.id_bilet2.Location = new System.Drawing.Point(229, 36);
            this.id_bilet2.Name = "id_bilet2";
            this.id_bilet2.ReadOnly = true;
            this.id_bilet2.Size = new System.Drawing.Size(100, 26);
            this.id_bilet2.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(61, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 25);
            this.label10.TabIndex = 4;
            this.label10.Text = "Стоимость:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(61, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 25);
            this.label9.TabIndex = 3;
            this.label9.Text = "Время начала:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(61, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "Дата:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(61, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "Билет №";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(3, 352);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(152, 52);
            this.button6.TabIndex = 0;
            this.button6.Text = "Вернуться к выбору билетов";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // zagruzka
            // 
            this.zagruzka.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.zagruzka.Controls.Add(this.label3);
            this.zagruzka.Controls.Add(this.button3);
            this.zagruzka.Controls.Add(this.panel3);
            this.zagruzka.Controls.Add(this.vibor_dati);
            this.zagruzka.Location = new System.Drawing.Point(1008, 51);
            this.zagruzka.Name = "zagruzka";
            this.zagruzka.Size = new System.Drawing.Size(712, 421);
            this.zagruzka.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(35, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(643, 64);
            this.label3.TabIndex = 2;
            this.label3.Text = "Выберите дату, когда вы собираетесь посетить\r\nнашу галерею\r\n";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(144, 268);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(450, 55);
            this.button3.TabIndex = 3;
            this.button3.Text = "Выбрать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(712, 80);
            this.panel3.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(209)))), ((int)(((byte)(168)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(607, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 56);
            this.button2.TabIndex = 2;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(178, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(390, 59);
            this.label2.TabIndex = 1;
            this.label2.Text = "Выберите дату";
            // 
            // vibor_dati
            // 
            this.vibor_dati.Location = new System.Drawing.Point(41, 194);
            this.vibor_dati.Name = "vibor_dati";
            this.vibor_dati.Size = new System.Drawing.Size(637, 26);
            this.vibor_dati.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.zagruzka);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1016, 551);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(845, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 56);
            this.button1.TabIndex = 1;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(288, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выбор билетов";
            // 
            // seansTableAdapter
            // 
            this.seansTableAdapter.ClearBeforeFill = true;
            // 
            // tickets
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(209)))), ((int)(((byte)(168)))));
            this.ClientSize = new System.Drawing.Size(1016, 551);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "tickets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tickets";
            this.Load += new System.EventHandler(this.tickets_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.vibor_seansov.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seansBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gallery1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gallery1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.zagruzka.ResumeLayout(false);
            this.zagruzka.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel zagruzka;
        private System.Windows.Forms.DateTimePicker vibor_dati;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox vibor_seansa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource gallery1BindingSource;
        private gallery1 gallery1;
        private System.Windows.Forms.BindingSource seansBindingSource;
        private gallery1TableAdapters.seansTableAdapter seansTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberseansDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timestartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dlitminDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel vibor_seansov;
        private System.Windows.Forms.Button pokazat;
        private System.Windows.Forms.Button skrit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox id_bilet;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox price_tb;
        private System.Windows.Forms.TextBox time_tb;
        private System.Windows.Forms.TextBox data_tb;
        private System.Windows.Forms.TextBox id_bilet2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox card;
        private System.Windows.Forms.Button oplata;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox fio_pol;
    }
}