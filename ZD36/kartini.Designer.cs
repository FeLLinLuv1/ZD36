namespace ZD36
{
    partial class kartini
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kartini));
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.close_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avtorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisanieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kartinsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.galleryDataSet1 = new ZD36.GalleryDataSet1();
            this.kartinsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kartinsTableAdapter = new ZD36.GalleryDataSet1TableAdapters.kartinsTableAdapter();
            this.gallery1 = new ZD36.gallery1();
            this.kartinsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.kartinsTableAdapter1 = new ZD36.gallery1TableAdapters.kartinsTableAdapter();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kartinsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kartinsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gallery1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kartinsBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(205)))), ((int)(((byte)(243)))));
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.close_button);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1095, 603);
            this.panel2.TabIndex = 8;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Location = new System.Drawing.Point(234, 519);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(420, 72);
            this.button1.TabIndex = 9;
            this.button1.Text = "Я ВАМ НЕ ВЕРЮ! (купить билет, чтобы проверить)";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Bisque;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(12, 428);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(830, 71);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "Заинтересовало что-то? Не верите, что у нас в галерее есть ТАКИЕ шедевры? Тогда п" +
    "окупайте билет по кнопке и приходите убедиться. ";
            // 
            // close_button
            // 
            this.close_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(209)))), ((int)(((byte)(168)))));
            this.close_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_button.FlatAppearance.BorderSize = 0;
            this.close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close_button.ForeColor = System.Drawing.Color.DarkRed;
            this.close_button.Location = new System.Drawing.Point(901, 3);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(191, 59);
            this.close_button.TabIndex = 3;
            this.close_button.Text = "Назад";
            this.close_button.UseVisualStyleBackColor = false;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(769, 68);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(314, 327);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Описание:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameeDataGridViewTextBoxColumn,
            this.avtorDataGridViewTextBoxColumn,
            this.opisanieDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kartinsBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(22, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(517, 327);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameeDataGridViewTextBoxColumn
            // 
            this.nameeDataGridViewTextBoxColumn.DataPropertyName = "namee";
            this.nameeDataGridViewTextBoxColumn.HeaderText = "namee";
            this.nameeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameeDataGridViewTextBoxColumn.Name = "nameeDataGridViewTextBoxColumn";
            this.nameeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameeDataGridViewTextBoxColumn.Width = 150;
            // 
            // avtorDataGridViewTextBoxColumn
            // 
            this.avtorDataGridViewTextBoxColumn.DataPropertyName = "avtor";
            this.avtorDataGridViewTextBoxColumn.HeaderText = "avtor";
            this.avtorDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.avtorDataGridViewTextBoxColumn.Name = "avtorDataGridViewTextBoxColumn";
            this.avtorDataGridViewTextBoxColumn.ReadOnly = true;
            this.avtorDataGridViewTextBoxColumn.Width = 150;
            // 
            // opisanieDataGridViewTextBoxColumn
            // 
            this.opisanieDataGridViewTextBoxColumn.DataPropertyName = "opisanie";
            this.opisanieDataGridViewTextBoxColumn.HeaderText = "opisanie";
            this.opisanieDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.opisanieDataGridViewTextBoxColumn.Name = "opisanieDataGridViewTextBoxColumn";
            this.opisanieDataGridViewTextBoxColumn.ReadOnly = true;
            this.opisanieDataGridViewTextBoxColumn.Width = 150;
            // 
            // kartinsBindingSource1
            // 
            this.kartinsBindingSource1.DataMember = "kartins";
            this.kartinsBindingSource1.DataSource = this.galleryDataSet1;
            // 
            // galleryDataSet1
            // 
            this.galleryDataSet1.DataSetName = "GalleryDataSet1";
            this.galleryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kartinsTableAdapter
            // 
            this.kartinsTableAdapter.ClearBeforeFill = true;
            // 
            // gallery1
            // 
            this.gallery1.DataSetName = "gallery1";
            this.gallery1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kartinsBindingSource2
            // 
            this.kartinsBindingSource2.DataMember = "kartins";
            this.kartinsBindingSource2.DataSource = this.gallery1;
            // 
            // kartinsTableAdapter1
            // 
            this.kartinsTableAdapter1.ClearBeforeFill = true;
            // 
            // kartini
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1095, 603);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "kartini";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "raspisanie";
            this.Load += new System.EventHandler(this.raspisanie_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kartinsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kartinsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gallery1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kartinsBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private GalleryDataSet1 galleryDataSet1;
        private System.Windows.Forms.BindingSource kartinsBindingSource;
        private GalleryDataSet1TableAdapters.kartinsTableAdapter kartinsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn avtorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisanieDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource kartinsBindingSource1;
        private gallery1 gallery1;
        private System.Windows.Forms.BindingSource kartinsBindingSource2;
        private gallery1TableAdapters.kartinsTableAdapter kartinsTableAdapter1;
    }
}