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
    public partial class Glavnaya : Form
    {
        public Glavnaya()
        {
            InitializeComponent();
        }

        private void Glavnaya_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void close_button_MouseEnter_1(object sender, EventArgs e)
        {
            close_button.ForeColor = Color.Red;
        }

        private void close_button_MouseLeave_1(object sender, EventArgs e)
        {
            close_button.ForeColor = Color.White;
        }


        Point LastPoint;
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

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void my_tickets_Click(object sender, EventArgs e)
        {
            my_bilets bil = new my_bilets();
            this.Hide();
            bil.ShowDialog();
            this.Show();
        }

        private void raspisan_Click(object sender, EventArgs e)
        {
            kartini ras = new kartini();
            this.Hide();
            ras.ShowDialog();
            this.Show();
        }

        private void new_raspis_Click(object sender, EventArgs e)
        {
            seans mar = new seans();
            this.Hide();
            mar.ShowDialog();
            this.Show();
        }

        private void tick_Click(object sender, EventArgs e)
        {
            tickets tic = new tickets();
            this.Hide();
            tic.ShowDialog();
            this.Show();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            avtorizacia2 avt = new avtorizacia2();
            this.Hide();
            avt.ShowDialog();
            this.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            raspisanie rasp = new raspisanie();
            this.Hide();
            rasp.ShowDialog();
            this.Show();
            
        }
    }
}
