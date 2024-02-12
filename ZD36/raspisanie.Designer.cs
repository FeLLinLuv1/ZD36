namespace ZD36
{
    partial class raspisanie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(raspisanie));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.close_button = new System.Windows.Forms.Button();
            this.gallery1 = new ZD36.gallery1();
            this.raspisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.raspisTableAdapter = new ZD36.gallery1TableAdapters.raspisTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idseansDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberseansDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolgruppDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gallery1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raspisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(209)))), ((int)(((byte)(168)))));
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 453);
            this.panel1.TabIndex = 9;
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
            this.textBox1.Text = "Здесь вы можете просмотреть расписание посещения галлереи";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idseansDataGridViewTextBoxColumn,
            this.numberseansDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.kolgruppDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.raspisBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(668, 349);
            this.dataGridView1.TabIndex = 6;
            // 
            // close_button
            // 
            this.close_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.close_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_button.FlatAppearance.BorderSize = 0;
            this.close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close_button.ForeColor = System.Drawing.Color.Black;
            this.close_button.Location = new System.Drawing.Point(761, 1);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(142, 54);
            this.close_button.TabIndex = 10;
            this.close_button.Text = "Назад";
            this.close_button.UseVisualStyleBackColor = false;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // gallery1
            // 
            this.gallery1.DataSetName = "gallery1";
            this.gallery1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // raspisBindingSource
            // 
            this.raspisBindingSource.DataMember = "raspis";
            this.raspisBindingSource.DataSource = this.gallery1;
            // 
            // raspisTableAdapter
            // 
            this.raspisTableAdapter.ClearBeforeFill = true;
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
            // idseansDataGridViewTextBoxColumn
            // 
            this.idseansDataGridViewTextBoxColumn.DataPropertyName = "id_seans";
            this.idseansDataGridViewTextBoxColumn.HeaderText = "id_seans";
            this.idseansDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idseansDataGridViewTextBoxColumn.Name = "idseansDataGridViewTextBoxColumn";
            this.idseansDataGridViewTextBoxColumn.ReadOnly = true;
            this.idseansDataGridViewTextBoxColumn.Width = 150;
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
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 150;
            // 
            // kolgruppDataGridViewTextBoxColumn
            // 
            this.kolgruppDataGridViewTextBoxColumn.DataPropertyName = "kol_grupp";
            this.kolgruppDataGridViewTextBoxColumn.HeaderText = "kol_grupp";
            this.kolgruppDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.kolgruppDataGridViewTextBoxColumn.Name = "kolgruppDataGridViewTextBoxColumn";
            this.kolgruppDataGridViewTextBoxColumn.ReadOnly = true;
            this.kolgruppDataGridViewTextBoxColumn.Width = 150;
            // 
            // raspisanie
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(905, 541);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "raspisanie";
            this.Text = "raspisanie";
            this.Load += new System.EventHandler(this.raspisanie_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gallery1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raspisBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button close_button;
        private gallery1 gallery1;
        private System.Windows.Forms.BindingSource raspisBindingSource;
        private gallery1TableAdapters.raspisTableAdapter raspisTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idseansDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberseansDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolgruppDataGridViewTextBoxColumn;
    }
}