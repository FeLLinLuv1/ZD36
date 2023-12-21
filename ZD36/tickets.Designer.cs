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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tickets));
            this.panel2 = new System.Windows.Forms.Panel();
            this.close_but = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.Button();
            this.stan2 = new System.Windows.Forms.Button();
            this.stan1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(205)))), ((int)(((byte)(243)))));
            this.panel2.Controls.Add(this.close_but);
            this.panel2.Controls.Add(this.date);
            this.panel2.Controls.Add(this.stan2);
            this.panel2.Controls.Add(this.stan1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(857, 500);
            this.panel2.TabIndex = 6;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // close_but
            // 
            this.close_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_but.Location = new System.Drawing.Point(807, 89);
            this.close_but.Name = "close_but";
            this.close_but.Size = new System.Drawing.Size(50, 42);
            this.close_but.TabIndex = 7;
            this.close_but.Text = "X";
            this.close_but.UseVisualStyleBackColor = true;
            this.close_but.Click += new System.EventHandler(this.close_but_Click);
            // 
            // date
            // 
            this.date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(118)))), ((int)(((byte)(197)))));
            this.date.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.date.Location = new System.Drawing.Point(460, 103);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(189, 57);
            this.date.TabIndex = 6;
            this.date.Text = "Выбрать дату поездки";
            this.date.UseVisualStyleBackColor = false;
            this.date.Click += new System.EventHandler(this.button1_Click);
            // 
            // stan2
            // 
            this.stan2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(118)))), ((int)(((byte)(197)))));
            this.stan2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stan2.Location = new System.Drawing.Point(238, 103);
            this.stan2.Name = "stan2";
            this.stan2.Size = new System.Drawing.Size(189, 57);
            this.stan2.TabIndex = 6;
            this.stan2.Text = "Выбрать станцию прибытия";
            this.stan2.UseVisualStyleBackColor = false;
            this.stan2.Click += new System.EventHandler(this.button1_Click);
            // 
            // stan1
            // 
            this.stan1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(118)))), ((int)(((byte)(197)))));
            this.stan1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stan1.Location = new System.Drawing.Point(12, 103);
            this.stan1.Name = "stan1";
            this.stan1.Size = new System.Drawing.Size(189, 57);
            this.stan1.TabIndex = 6;
            this.stan1.Text = "Выбрать станцию отправления";
            this.stan1.UseVisualStyleBackColor = false;
            this.stan1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(118)))), ((int)(((byte)(197)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(695, 431);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 57);
            this.button1.TabIndex = 6;
            this.button1.Text = "Забронировать билет";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(118)))), ((int)(((byte)(197)))));
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(857, 88);
            this.panel1.TabIndex = 5;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(737, 12);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(108, 71);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 14;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Билеты";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tickets
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(857, 500);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "tickets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tickets";
            this.Load += new System.EventHandler(this.tickets_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button date;
        private System.Windows.Forms.Button stan2;
        private System.Windows.Forms.Button stan1;
        private System.Windows.Forms.Button close_but;
    }
}