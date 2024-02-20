using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZD36
{
    public partial class kartini : Form
    {
        database database = new database();

        DataTable table = new DataTable();

        SqlDataAdapter adapter = new SqlDataAdapter();

        int selectedRow;

        public kartini()
        {
            InitializeComponent();
        }

        private void raspisanie_Load(object sender, EventArgs e)
        {
            database.openConnection();

            string vivod = $"SELECT * FROM kartins";

            SqlCommand command = new SqlCommand(vivod, database.getConnection());

            DataSet dataset = new DataSet();

            adapter.SelectCommand = command;
            adapter.Fill(dataset);

            dataGridView1.DataSource = dataset.Tables[0];

            database.closeConnection();

        
            dataGridView1.Columns[0].HeaderText = "id";
            dataGridView1.Columns[1].HeaderText = "Название";
            dataGridView1.Columns[2].HeaderText = "Автор";
            dataGridView1.Columns[3].HeaderText = "Описание";
            dataGridView1.Columns[3].Visible = false;



            dataGridView1.ClearSelection();
        }

        private void na_glavn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        Point LastPoint;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
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

        private void close_but_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                textBox1.Text = "Описание: " + row.Cells[3].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tickets tic = new tickets();
            this.Hide();
            tic.ShowDialog();
            this.Show();
        }
    }
}
