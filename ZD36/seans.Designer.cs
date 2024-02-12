namespace ZD36
{
    partial class seans
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(seans));
            this.panel2 = new System.Windows.Forms.Panel();
            this.close_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numberseansDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timestartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dlitminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seansBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.galleryDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.galleryDataSet1 = new ZD36.GalleryDataSet1();
            this.galleryDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seansTableAdapter = new ZD36.GalleryDataSet1TableAdapters.seansTableAdapter();
            this.gallery1 = new ZD36.gallery1();
            this.seansBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.seansTableAdapter1 = new ZD36.gallery1TableAdapters.seansTableAdapter();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seansBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gallery1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seansBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(205)))), ((int)(((byte)(243)))));
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.close_button);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(861, 630);
            this.panel2.TabIndex = 9;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // close_button
            // 
            this.close_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.close_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_button.FlatAppearance.BorderSize = 0;
            this.close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close_button.ForeColor = System.Drawing.Color.Black;
            this.close_button.Location = new System.Drawing.Point(716, 3);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(142, 54);
            this.close_button.TabIndex = 3;
            this.close_button.Text = "Назад";
            this.close_button.UseVisualStyleBackColor = false;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(209)))), ((int)(((byte)(168)))));
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 404);
            this.panel1.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(16, 16);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(668, 66);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Здесь вы можете просмотреть расписание сеансов посещения галереи";
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
            this.dataGridView1.DataSource = this.seansBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(16, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(516, 219);
            this.dataGridView1.TabIndex = 6;
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
            this.seansBindingSource.DataSource = this.galleryDataSet1BindingSource;
            // 
            // galleryDataSet1BindingSource
            // 
            this.galleryDataSet1BindingSource.DataSource = this.galleryDataSet1;
            this.galleryDataSet1BindingSource.Position = 0;
            // 
            // galleryDataSet1
            // 
            this.galleryDataSet1.DataSetName = "GalleryDataSet1";
            this.galleryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // seansTableAdapter
            // 
            this.seansTableAdapter.ClearBeforeFill = true;
            // 
            // gallery1
            // 
            this.gallery1.DataSetName = "gallery1";
            this.gallery1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // seansBindingSource1
            // 
            this.seansBindingSource1.DataMember = "seans";
            this.seansBindingSource1.DataSource = this.gallery1;
            // 
            // seansTableAdapter1
            // 
            this.seansTableAdapter1.ClearBeforeFill = true;
            // 
            // seans
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(861, 630);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "seans";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "marsh";
            this.Load += new System.EventHandler(this.marsh_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seansBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gallery1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seansBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource galleryDataSetBindingSource;
        private System.Windows.Forms.BindingSource galleryDataSet1BindingSource;
        private GalleryDataSet1 galleryDataSet1;
        private GalleryDataSet1TableAdapters.seansTableAdapter seansTableAdapter;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberseansDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timestartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dlitminDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource seansBindingSource;
        private gallery1 gallery1;
        private System.Windows.Forms.BindingSource seansBindingSource1;
        private gallery1TableAdapters.seansTableAdapter seansTableAdapter1;
    }
}