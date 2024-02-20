namespace ZD36
{
    partial class glavn_sotr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(glavn_sotr));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.new_raspis = new System.Windows.Forms.Button();
            this.close_but = new System.Windows.Forms.Button();
            this.raspis = new System.Windows.Forms.Button();
            this.prosm_bilet = new System.Windows.Forms.Button();
            this.raspisan = new System.Windows.Forms.Button();
            this.clients = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1043, 700);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // new_raspis
            // 
            this.new_raspis.BackColor = System.Drawing.Color.LightSteelBlue;
            this.new_raspis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.new_raspis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.new_raspis.Location = new System.Drawing.Point(354, 121);
            this.new_raspis.Name = "new_raspis";
            this.new_raspis.Size = new System.Drawing.Size(176, 61);
            this.new_raspis.TabIndex = 3;
            this.new_raspis.Text = "Редактировать расписание";
            this.new_raspis.UseVisualStyleBackColor = false;
            this.new_raspis.Click += new System.EventHandler(this.new_raspis_Click);
            // 
            // close_but
            // 
            this.close_but.BackColor = System.Drawing.Color.Red;
            this.close_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_but.Location = new System.Drawing.Point(993, 0);
            this.close_but.Name = "close_but";
            this.close_but.Size = new System.Drawing.Size(50, 42);
            this.close_but.TabIndex = 8;
            this.close_but.Text = "X";
            this.close_but.UseVisualStyleBackColor = false;
            this.close_but.Click += new System.EventHandler(this.close_but_Click);
            // 
            // raspis
            // 
            this.raspis.BackColor = System.Drawing.Color.LightSteelBlue;
            this.raspis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.raspis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.raspis.Location = new System.Drawing.Point(354, 22);
            this.raspis.Name = "raspis";
            this.raspis.Size = new System.Drawing.Size(176, 61);
            this.raspis.TabIndex = 3;
            this.raspis.Text = "Просмотреть расписание";
            this.raspis.UseVisualStyleBackColor = false;
            this.raspis.Click += new System.EventHandler(this.raspis_Click);
            // 
            // prosm_bilet
            // 
            this.prosm_bilet.BackColor = System.Drawing.Color.LightSteelBlue;
            this.prosm_bilet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.prosm_bilet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prosm_bilet.Location = new System.Drawing.Point(20, 222);
            this.prosm_bilet.Name = "prosm_bilet";
            this.prosm_bilet.Size = new System.Drawing.Size(176, 61);
            this.prosm_bilet.TabIndex = 3;
            this.prosm_bilet.Text = "Подтвердить оплату";
            this.prosm_bilet.UseVisualStyleBackColor = false;
            this.prosm_bilet.Click += new System.EventHandler(this.button1_Click);
            // 
            // raspisan
            // 
            this.raspisan.BackColor = System.Drawing.Color.LightSteelBlue;
            this.raspisan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.raspisan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.raspisan.Location = new System.Drawing.Point(20, 22);
            this.raspisan.Name = "raspisan";
            this.raspisan.Size = new System.Drawing.Size(176, 61);
            this.raspisan.TabIndex = 8;
            this.raspisan.Text = "Просмотреть сеансы";
            this.raspisan.UseVisualStyleBackColor = false;
            this.raspisan.Click += new System.EventHandler(this.raspisan_Click);
            // 
            // clients
            // 
            this.clients.BackColor = System.Drawing.Color.LightSteelBlue;
            this.clients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clients.Location = new System.Drawing.Point(20, 121);
            this.clients.Name = "clients";
            this.clients.Size = new System.Drawing.Size(176, 61);
            this.clients.TabIndex = 4;
            this.clients.Text = "Просмотреть клиентов";
            this.clients.UseVisualStyleBackColor = false;
            this.clients.Click += new System.EventHandler(this.clients_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(24, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 109);
            this.panel1.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(227, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(292, 35);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(124, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Вы вошли в систему";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сотрудник:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(209)))), ((int)(((byte)(168)))));
            this.panel2.Controls.Add(this.raspisan);
            this.panel2.Controls.Add(this.prosm_bilet);
            this.panel2.Controls.Add(this.clients);
            this.panel2.Controls.Add(this.new_raspis);
            this.panel2.Controls.Add(this.raspis);
            this.panel2.Location = new System.Drawing.Point(24, 156);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(566, 381);
            this.panel2.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(820, 584);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 94);
            this.button1.TabIndex = 12;
            this.button1.Text = "Вернуться на авторизацию";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // glavn_sotr
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1043, 700);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.close_but);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "glavn_sotr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "glavn_sotr";
            this.Load += new System.EventHandler(this.glavn_sotr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button new_raspis;
        private System.Windows.Forms.Button raspis;
        private System.Windows.Forms.Button prosm_bilet;
        private System.Windows.Forms.Button raspisan;
        private System.Windows.Forms.Button clients;
        private System.Windows.Forms.Button close_but;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
    }
}