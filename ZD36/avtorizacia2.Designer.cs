namespace ZD36
{
    partial class avtorizacia2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(avtorizacia2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.vvod_parola = new System.Windows.Forms.TextBox();
            this.vvod_logina = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.close_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.new_akk = new System.Windows.Forms.Button();
            this.Sotrud = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.voiti = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.vvod_parola);
            this.panel1.Controls.Add(this.vvod_logina);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(895, 604);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown_1);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(703, 483);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 83);
            this.button2.TabIndex = 15;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 468);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 112);
            this.button1.TabIndex = 14;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(335, 280);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(0, 0);
            this.textBox2.TabIndex = 4;
            // 
            // vvod_parola
            // 
            this.vvod_parola.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vvod_parola.Location = new System.Drawing.Point(257, 262);
            this.vvod_parola.Name = "vvod_parola";
            this.vvod_parola.Size = new System.Drawing.Size(464, 48);
            this.vvod_parola.TabIndex = 2;
            this.vvod_parola.UseSystemPasswordChar = true;
            this.vvod_parola.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.vvod_parola_KeyPress);
            // 
            // vvod_logina
            // 
            this.vvod_logina.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vvod_logina.Location = new System.Drawing.Point(257, 150);
            this.vvod_logina.Name = "vvod_logina";
            this.vvod_logina.Size = new System.Drawing.Size(464, 48);
            this.vvod_logina.TabIndex = 1;
            this.vvod_logina.TextChanged += new System.EventHandler(this.vvod_logina_TextChanged);
            this.vvod_logina.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.vvod_logina_KeyPress);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(118)))), ((int)(((byte)(197)))));
            this.panel2.Controls.Add(this.close_button);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(895, 100);
            this.panel2.TabIndex = 0;
            // 
            // close_button
            // 
            this.close_button.BackColor = System.Drawing.Color.Red;
            this.close_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_button.FlatAppearance.BorderSize = 0;
            this.close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close_button.ForeColor = System.Drawing.Color.White;
            this.close_button.Location = new System.Drawing.Point(837, 3);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(55, 39);
            this.close_button.TabIndex = 6;
            this.close_button.Text = "X";
            this.close_button.UseVisualStyleBackColor = false;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(209)))), ((int)(((byte)(168)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(895, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добро пожаловать!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown_1);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(209)))), ((int)(((byte)(168)))));
            this.panel3.Controls.Add(this.new_akk);
            this.panel3.Controls.Add(this.Sotrud);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.voiti);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Location = new System.Drawing.Point(84, 129);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(754, 304);
            this.panel3.TabIndex = 13;
            // 
            // new_akk
            // 
            this.new_akk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.new_akk.FlatAppearance.BorderSize = 0;
            this.new_akk.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.new_akk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_akk.ForeColor = System.Drawing.SystemColors.GrayText;
            this.new_akk.Location = new System.Drawing.Point(619, 251);
            this.new_akk.Name = "new_akk";
            this.new_akk.Size = new System.Drawing.Size(132, 50);
            this.new_akk.TabIndex = 4;
            this.new_akk.Text = "Регистрация";
            this.new_akk.UseVisualStyleBackColor = true;
            this.new_akk.Click += new System.EventHandler(this.new_akk_Click);
            // 
            // Sotrud
            // 
            this.Sotrud.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Sotrud.Location = new System.Drawing.Point(3, 251);
            this.Sotrud.Name = "Sotrud";
            this.Sotrud.Size = new System.Drawing.Size(141, 50);
            this.Sotrud.TabIndex = 5;
            this.Sotrud.Text = "Войти как сотрудник";
            this.Sotrud.UseVisualStyleBackColor = true;
            this.Sotrud.Click += new System.EventHandler(this.Sotrud_Click_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(660, 133);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click_1);
            // 
            // voiti
            // 
            this.voiti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.voiti.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.voiti.Location = new System.Drawing.Point(301, 217);
            this.voiti.Name = "voiti";
            this.voiti.Size = new System.Drawing.Size(193, 65);
            this.voiti.TabIndex = 3;
            this.voiti.Text = "Войти";
            this.voiti.UseVisualStyleBackColor = true;
            this.voiti.Click += new System.EventHandler(this.voiti_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 46);
            this.label3.TabIndex = 12;
            this.label3.Text = "Пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 46);
            this.label2.TabIndex = 12;
            this.label2.Text = "Логин";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(660, 133);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(48, 48);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click_1);
            // 
            // avtorizacia2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(895, 604);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "avtorizacia2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "avtorizacia2";
            this.Load += new System.EventHandler(this.avtorizacia2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button Sotrud;
        private System.Windows.Forms.Button new_akk;
        private System.Windows.Forms.Button voiti;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox vvod_parola;
        private System.Windows.Forms.TextBox vvod_logina;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}