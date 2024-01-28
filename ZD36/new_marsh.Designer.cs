namespace ZD36
{
    partial class new_marsh
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numb_marsh = new System.Windows.Forms.TextBox();
            this.insert = new System.Windows.Forms.Button();
            this.otpr = new System.Windows.Forms.TextBox();
            this.prib = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.close_but = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.close_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.zD36DataSet6 = new ZD36.ZD36DataSet6();
            this.waysBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.waysTableAdapter = new ZD36.ZD36DataSet6TableAdapters.WaysTableAdapter();
            this.zD36DataSet7 = new ZD36.ZD36DataSet7();
            this.waysBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.waysTableAdapter1 = new ZD36.ZD36DataSet7TableAdapters.WaysTableAdapter();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zD36DataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waysBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zD36DataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waysBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(205)))), ((int)(((byte)(243)))));
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Controls.Add(this.close_but);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(857, 600);
            this.panel2.TabIndex = 8;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 88);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(857, 512);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(205)))), ((int)(((byte)(243)))));
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.numb_marsh);
            this.tabPage1.Controls.Add(this.insert);
            this.tabPage1.Controls.Add(this.otpr);
            this.tabPage1.Controls.Add(this.prib);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(849, 479);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Добавить";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(11, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Станция прибытия";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(11, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Станция отправления";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(11, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Номер маршрута";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // numb_marsh
            // 
            this.numb_marsh.Location = new System.Drawing.Point(305, 6);
            this.numb_marsh.Multiline = true;
            this.numb_marsh.Name = "numb_marsh";
            this.numb_marsh.Size = new System.Drawing.Size(274, 77);
            this.numb_marsh.TabIndex = 2;
            this.numb_marsh.TextChanged += new System.EventHandler(this.numb_marsh_TextChanged);
            this.numb_marsh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numb_marsh_KeyPress);
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(616, 215);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(122, 77);
            this.insert.TabIndex = 1;
            this.insert.Text = "Добавить";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // otpr
            // 
            this.otpr.Location = new System.Drawing.Point(305, 109);
            this.otpr.Multiline = true;
            this.otpr.Name = "otpr";
            this.otpr.Size = new System.Drawing.Size(274, 77);
            this.otpr.TabIndex = 0;
            this.otpr.TextChanged += new System.EventHandler(this.otpr_TextChanged);
            // 
            // prib
            // 
            this.prib.Location = new System.Drawing.Point(305, 215);
            this.prib.Multiline = true;
            this.prib.Name = "prib";
            this.prib.Size = new System.Drawing.Size(274, 77);
            this.prib.TabIndex = 0;
            this.prib.TextChanged += new System.EventHandler(this.prib_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(205)))), ((int)(((byte)(243)))));
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(849, 479);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Удалить";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(188, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 66);
            this.button2.TabIndex = 5;
            this.button2.Text = "удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(183, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(564, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Выберите номер маршрута, который необходимо удалить";
            // 
            // close_but
            // 
            this.close_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_but.Location = new System.Drawing.Point(807, 89);
            this.close_but.Name = "close_but";
            this.close_but.Size = new System.Drawing.Size(50, 42);
            this.close_but.TabIndex = 9;
            this.close_but.Text = "X";
            this.close_but.UseVisualStyleBackColor = true;
            this.close_but.Click += new System.EventHandler(this.close_but_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(118)))), ((int)(((byte)(197)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(695, 494);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 57);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ок";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(118)))), ((int)(((byte)(197)))));
            this.panel1.Controls.Add(this.close_button);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(857, 88);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // close_button
            // 
            this.close_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_button.FlatAppearance.BorderSize = 0;
            this.close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close_button.ForeColor = System.Drawing.Color.White;
            this.close_button.Location = new System.Drawing.Point(799, 3);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(55, 39);
            this.close_button.TabIndex = 3;
            this.close_button.Text = "X";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(543, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Редактор маршрутов";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.waysBindingSource;
            this.comboBox1.DisplayMember = "num_marsh";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(18, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(128, 28);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.ValueMember = "num_marsh";
            // 
            // zD36DataSet6
            // 
            this.zD36DataSet6.DataSetName = "ZD36DataSet6";
            this.zD36DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // waysBindingSource
            // 
            this.waysBindingSource.DataMember = "Ways";
            this.waysBindingSource.DataSource = this.zD36DataSet6;
            // 
            // waysTableAdapter
            // 
            this.waysTableAdapter.ClearBeforeFill = true;
            // 
            // zD36DataSet7
            // 
            this.zD36DataSet7.DataSetName = "ZD36DataSet7";
            this.zD36DataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // waysBindingSource1
            // 
            this.waysBindingSource1.DataMember = "Ways";
            this.waysBindingSource1.DataSource = this.zD36DataSet7;
            // 
            // waysTableAdapter1
            // 
            this.waysTableAdapter1.ClearBeforeFill = true;
            // 
            // new_marsh
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(857, 600);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "new_marsh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "new_marsh";
            this.Load += new System.EventHandler(this.new_marsh_Load);
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zD36DataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waysBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zD36DataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waysBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button close_but;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox prib;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.TextBox otpr;
        private System.Windows.Forms.TextBox numb_marsh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.ComboBox comboBox1;
        private ZD36DataSet6 zD36DataSet6;
        private System.Windows.Forms.BindingSource waysBindingSource;
        private ZD36DataSet6TableAdapters.WaysTableAdapter waysTableAdapter;
        private ZD36DataSet7 zD36DataSet7;
        private System.Windows.Forms.BindingSource waysBindingSource1;
        private ZD36DataSet7TableAdapters.WaysTableAdapter waysTableAdapter1;
    }
}