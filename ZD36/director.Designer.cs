namespace ZD36
{
    partial class director
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(director));
            this.panel1 = new System.Windows.Forms.Panel();
            this.sotr = new System.Windows.Forms.Button();
            this.bilets = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.bilets);
            this.panel1.Controls.Add(this.sotr);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(870, 288);
            this.panel1.TabIndex = 0;
            // 
            // sotr
            // 
            this.sotr.Location = new System.Drawing.Point(128, 50);
            this.sotr.Name = "sotr";
            this.sotr.Size = new System.Drawing.Size(224, 61);
            this.sotr.TabIndex = 0;
            this.sotr.Text = "Мои сотрудники";
            this.sotr.UseVisualStyleBackColor = true;
            this.sotr.Click += new System.EventHandler(this.sotr_Click);
            // 
            // bilets
            // 
            this.bilets.Location = new System.Drawing.Point(494, 50);
            this.bilets.Name = "bilets";
            this.bilets.Size = new System.Drawing.Size(232, 61);
            this.bilets.TabIndex = 1;
            this.bilets.Text = "Купленные билеты";
            this.bilets.UseVisualStyleBackColor = true;
            this.bilets.Click += new System.EventHandler(this.bilets_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(656, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 94);
            this.button1.TabIndex = 13;
            this.button1.Text = "Вернуться на авторизацию";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // director
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(209)))), ((int)(((byte)(168)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(905, 532);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "director";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "director";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bilets;
        private System.Windows.Forms.Button sotr;
        private System.Windows.Forms.Button button1;
    }
}