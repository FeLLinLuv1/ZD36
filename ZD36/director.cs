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
    public partial class director : Form
    {
        public director()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sotr mar = new sotr();
            this.Hide();
            mar.ShowDialog();
            this.Show();
            this.Close();
        }

        private void bilets_Click(object sender, EventArgs e)
        {
            cell_bilets cel = new cell_bilets();
            this.Hide();
            cel.ShowDialog();
            this.Show();
          
        }

        private void sotr_Click(object sender, EventArgs e)
        {
            employee em = new employee();
            this.Hide();
            em.ShowDialog();
            this.Show();
        }
    }
}
