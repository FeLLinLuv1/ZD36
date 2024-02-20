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
    public partial class seans : Form
    {
        database database = new database();

        DataTable table = new DataTable();

        SqlDataAdapter adapter = new SqlDataAdapter();

        public seans()
        {
            InitializeComponent();
        }

        private void na_glavn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void close_but_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }



        private void marsh_Load(object sender, EventArgs e)
        {

            database.openConnection();

            string vivod = $"SELECT * FROM seans";

            SqlCommand command = new SqlCommand(vivod, database.getConnection());

            DataSet dataset = new DataSet();

            adapter.SelectCommand = command;
            adapter.Fill(dataset);

            dataGridView1.DataSource = dataset.Tables[0];

            database.closeConnection();

            dataGridView1.Columns[0].HeaderText = "Номер сеанса";
            dataGridView1.Columns[1].HeaderText = "Время начала";       
            dataGridView1.Columns[2].HeaderText = "Длительность (в минутах)";


            dataGridView1.ClearSelection();
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
    }
}
