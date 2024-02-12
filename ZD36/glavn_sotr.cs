using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZD36
{
    public partial class glavn_sotr : Form
    {
        public glavn_sotr()
        {
            InitializeComponent();
        }

        string log = DataBank.Login_sotr;

        private void button1_Click(object sender, EventArgs e)
        {
            full_billets bil = new full_billets();
            this.Hide();
            bil.ShowDialog();
            this.Show();
        }


        Point LastPoint;

        private void raspis_Click(object sender, EventArgs e)
        {
            raspisanie rasp = new raspisanie();
            this.Hide();
            rasp.ShowDialog();
            this.Show();
           
        }

        private void new_raspis_Click(object sender, EventArgs e)
        {
            new_raspis nr = new new_raspis();
            this.Hide();
            nr.ShowDialog();
            this.Show();
        }

       

        private void clients_Click(object sender, EventArgs e)
        {
            clients cl = new clients();
            this.Hide();
            cl.ShowDialog();
            this.Show();
        }

        private void raspisan_Click(object sender, EventArgs e)
        {
            seans mar = new seans();
            this.Hide();
            mar.ShowDialog();
            this.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void close_but_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void glavn_sotr_Load(object sender, EventArgs e)
        {
            textBox1.Text = log;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            sotr mar = new sotr();
            this.Hide();
            mar.ShowDialog();
            this.Show();
            this.Close();
        }
    }
}
