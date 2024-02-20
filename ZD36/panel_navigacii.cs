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
    public partial class panel_navigacii : Form
    {
        public panel_navigacii()
        {
            InitializeComponent();
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
        private void button1_Click(object sender, EventArgs e)
        {
            client_avtrorizac avt = new client_avtrorizac();
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
