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
    public partial class marsh : Form
    {
        public marsh()
        {
            InitializeComponent();
        }

        private void na_glavn_Click(object sender, EventArgs e)
        {
            Glavnaya glv = new Glavnaya();
            this.Hide();
            glv.ShowDialog();
            this.Show();
        }

        private void close_but_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
