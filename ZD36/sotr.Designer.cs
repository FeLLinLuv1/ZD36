namespace ZD36
{
    partial class sotr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sotr));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pas_sotr = new System.Windows.Forms.TextBox();
            this.log_sotr = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.avtoriz_sotr_label = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.nazad = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.vhod = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(181)))), ((int)(((byte)(197)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.pas_sotr);
            this.panel1.Controls.Add(this.log_sotr);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(903, 610);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(335, 280);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(0, 0);
            this.textBox2.TabIndex = 4;
            // 
            // pas_sotr
            // 
            this.pas_sotr.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pas_sotr.Location = new System.Drawing.Point(257, 262);
            this.pas_sotr.Name = "pas_sotr";
            this.pas_sotr.Size = new System.Drawing.Size(453, 48);
            this.pas_sotr.TabIndex = 2;
            this.pas_sotr.UseSystemPasswordChar = true;

            this.pas_sotr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pas_sotr_KeyPress);
            // 
            // log_sotr
            // 
            this.log_sotr.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.log_sotr.Location = new System.Drawing.Point(257, 150);
            this.log_sotr.Name = "log_sotr";
            this.log_sotr.Size = new System.Drawing.Size(453, 48);
            this.log_sotr.TabIndex = 1;
   
            this.log_sotr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.log_sotr_KeyPress);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(118)))), ((int)(((byte)(197)))));
            this.panel2.Controls.Add(this.avtoriz_sotr_label);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(903, 100);
            this.panel2.TabIndex = 0;
            // 
            // avtoriz_sotr_label
            // 
            this.avtoriz_sotr_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(209)))), ((int)(((byte)(168)))));
            this.avtoriz_sotr_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.avtoriz_sotr_label.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.avtoriz_sotr_label.Location = new System.Drawing.Point(0, 0);
            this.avtoriz_sotr_label.Name = "avtoriz_sotr_label";
            this.avtoriz_sotr_label.Size = new System.Drawing.Size(903, 100);
            this.avtoriz_sotr_label.TabIndex = 0;
            this.avtoriz_sotr_label.Text = "Авторизация сотрудников";
            this.avtoriz_sotr_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.avtoriz_sotr_label.Click += new System.EventHandler(this.avtoriz_sotr_label_Click);
            this.avtoriz_sotr_label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.avtoriz_sotr_label_MouseDown);
            this.avtoriz_sotr_label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.avtoriz_sotr_label_MouseMove);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(209)))), ((int)(((byte)(168)))));
            this.panel3.Controls.Add(this.nazad);
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Controls.Add(this.vhod);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.pictureBox5);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(96, 135);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(721, 306);
            this.panel3.TabIndex = 15;
            // 
            // nazad
            // 
            this.nazad.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.nazad.Location = new System.Drawing.Point(3, 254);
            this.nazad.Name = "nazad";
            this.nazad.Size = new System.Drawing.Size(143, 40);
            this.nazad.TabIndex = 4;
            this.nazad.Text = "Назад";
            this.nazad.UseVisualStyleBackColor = true;
            this.nazad.Click += new System.EventHandler(this.nazad_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(209)))), ((int)(((byte)(168)))));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(638, 127);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(48, 48);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // vhod
            // 
            this.vhod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vhod.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.vhod.Location = new System.Drawing.Point(287, 193);
            this.vhod.Name = "vhod";
            this.vhod.Size = new System.Drawing.Size(156, 82);
            this.vhod.TabIndex = 3;
            this.vhod.Text = "Войти";
            this.vhod.UseVisualStyleBackColor = true;
            this.vhod.Click += new System.EventHandler(this.vhod_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 46);
            this.label3.TabIndex = 14;
            this.label3.Text = "Пароль";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(209)))), ((int)(((byte)(168)))));
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(638, 126);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(48, 48);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 46);
            this.label2.TabIndex = 13;
            this.label2.Text = "Логин";
            // 
            // sotr
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(903, 610);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "sotr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sotr";
            this.Load += new System.EventHandler(this.sotr_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button vhod;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox pas_sotr;
        private System.Windows.Forms.TextBox log_sotr;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label avtoriz_sotr_label;
        private System.Windows.Forms.Button nazad;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
    }
}