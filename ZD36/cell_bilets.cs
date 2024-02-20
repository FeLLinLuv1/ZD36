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
    public partial class cell_bilets : Form
    {
        database database = new database();
        DataTable table = new DataTable();
        SqlDataAdapter adapter = new SqlDataAdapter();

        public cell_bilets()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void cell_bilets_Load(object sender, EventArgs e)
        {
            database.openConnection();

            string vivod = $"SELECT * FROM cell_bilets";

            SqlCommand command = new SqlCommand(vivod, database.getConnection());

            DataSet dataset = new DataSet();

            adapter.SelectCommand = command;
            adapter.Fill(dataset);

            dataGridView1.DataSource = dataset.Tables[0];

            database.closeConnection();

            dataGridView1.Columns[0].HeaderText = "id";
            dataGridView1.Columns[1].HeaderText = "Дата";
            dataGridView1.Columns[2].HeaderText = "Количество купленных Билетов";
            dataGridView1.Columns[3].HeaderText = "ID расписания";



            dataGridView1.ClearSelection();
        }
    }
}
