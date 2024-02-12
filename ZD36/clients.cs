using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZD36
{
    public partial class clients : Form
    {
        public clients()
        {
            InitializeComponent();
        }

        database database = new database();
        DataTable table = new DataTable();
        SqlDataAdapter adapter = new SqlDataAdapter();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void na_glavn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Point LastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void clients_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gallery1.clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter1.Fill(this.gallery1.clients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "galleryDataSet1.clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.galleryDataSet1.clients);
            database.openConnection();

            dataGridView1.Columns[0].HeaderText = "id";
            dataGridView1.Columns[1].HeaderText = "FIO";
            dataGridView1.Columns[2].HeaderText = "Login";
            dataGridView1.Columns[3].HeaderText = "ps";
            dataGridView1.Columns[3].Visible = false;



            dataGridView1.ClearSelection();
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
