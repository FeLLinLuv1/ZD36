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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.raspis = new System.Windows.Forms.Button();
            this.prosm_bilet = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.raspisan = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.clients = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.close_but = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.new_raspis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(118)))), ((int)(((byte)(197)))));
            this.new_raspis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.new_raspis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.new_raspis.Location = new System.Drawing.Point(22, 104);
            this.new_raspis.Name = "new_raspis";
            this.new_raspis.Size = new System.Drawing.Size(176, 61);
            this.new_raspis.TabIndex = 3;
            this.new_raspis.Text = "Редактировать расписание";
            this.new_raspis.UseVisualStyleBackColor = false;
            this.new_raspis.Click += new System.EventHandler(this.new_raspis_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(118)))), ((int)(((byte)(197)))));
            this.panel1.Controls.Add(this.close_but);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1043, 98);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Среда сотрудника";
            // 
            // raspis
            // 
            this.raspis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(118)))), ((int)(((byte)(197)))));
            this.raspis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.raspis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.raspis.Location = new System.Drawing.Point(274, 104);
            this.raspis.Name = "raspis";
            this.raspis.Size = new System.Drawing.Size(176, 61);
            this.raspis.TabIndex = 3;
            this.raspis.Text = "Просмотреть расписание";
            this.raspis.UseVisualStyleBackColor = false;
            this.raspis.Click += new System.EventHandler(this.raspis_Click);
            // 
            // prosm_bilet
            // 
            this.prosm_bilet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(118)))), ((int)(((byte)(197)))));
            this.prosm_bilet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.prosm_bilet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prosm_bilet.Location = new System.Drawing.Point(274, 9);
            this.prosm_bilet.Name = "prosm_bilet";
            this.prosm_bilet.Size = new System.Drawing.Size(176, 61);
            this.prosm_bilet.TabIndex = 3;
            this.prosm_bilet.Text = "Просмореть билеты";
            this.prosm_bilet.UseVisualStyleBackColor = false;
            this.prosm_bilet.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(205)))), ((int)(((byte)(243)))));
            this.panel2.Location = new System.Drawing.Point(0, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(477, 78);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(205)))), ((int)(((byte)(243)))));
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.raspisan);
            this.panel3.Location = new System.Drawing.Point(0, 230);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(477, 77);
            this.panel3.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(118)))), ((int)(((byte)(197)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(22, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 61);
            this.button1.TabIndex = 9;
            this.button1.Text = "Редактировать маршруты";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // raspisan
            // 
            this.raspisan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(118)))), ((int)(((byte)(197)))));
            this.raspisan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.raspisan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.raspisan.Location = new System.Drawing.Point(274, 8);
            this.raspisan.Name = "raspisan";
            this.raspisan.Size = new System.Drawing.Size(176, 61);
            this.raspisan.TabIndex = 8;
            this.raspisan.Text = "Просмотреть маршруты";
            this.raspisan.UseVisualStyleBackColor = false;
            this.raspisan.Click += new System.EventHandler(this.raspisan_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(205)))), ((int)(((byte)(243)))));
            this.panel4.Controls.Add(this.clients);
            this.panel4.Controls.Add(this.prosm_bilet);
            this.panel4.Location = new System.Drawing.Point(0, 363);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(477, 79);
            this.panel4.TabIndex = 7;
            // 
            // clients
            // 
            this.clients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(118)))), ((int)(((byte)(197)))));
            this.clients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clients.Location = new System.Drawing.Point(22, 9);
            this.clients.Name = "clients";
            this.clients.Size = new System.Drawing.Size(176, 61);
            this.clients.TabIndex = 4;
            this.clients.Text = "Просмотреть клиентов";
            this.clients.UseVisualStyleBackColor = false;
            this.clients.Click += new System.EventHandler(this.clients_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(619, 213);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(395, 243);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // close_but
            // 
            this.close_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_but.Location = new System.Drawing.Point(993, 0);
            this.close_but.Name = "close_but";
            this.close_but.Size = new System.Drawing.Size(50, 42);
            this.close_but.TabIndex = 8;
            this.close_but.Text = "X";
            this.close_but.UseVisualStyleBackColor = true;
            this.close_but.Click += new System.EventHandler(this.close_but_Click);
            // 
            // glavn_sotr
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1043, 700);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.new_raspis);
            this.Controls.Add(this.raspis);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "glavn_sotr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "glavn_sotr";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button new_raspis;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button raspis;
        private System.Windows.Forms.Button prosm_bilet;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button raspisan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button clients;
        private System.Windows.Forms.Button close_but;
    }
}