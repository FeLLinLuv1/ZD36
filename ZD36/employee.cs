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
    public partial class employee : Form
    {

        database database = new database();
        DataTable table = new DataTable();
        SqlDataAdapter adapter = new SqlDataAdapter();

        public employee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void employee_Load(object sender, EventArgs e)
        {
            database.openConnection();

            string vivod = $"select Employee.FIO, Employee.loginn, rabota.date_timee from Employee, rabota where Employee.loginn = rabota.loginn;";

            SqlCommand command = new SqlCommand(vivod, database.getConnection());

            DataSet dataset = new DataSet();

            adapter.SelectCommand = command;
            adapter.Fill(dataset);

            dataGridView1.DataSource = dataset.Tables[0];

            database.closeConnection();

            dataGridView1.Columns[0].HeaderText = "FIO";
            dataGridView1.Columns[1].HeaderText = "login";
            dataGridView1.Columns[2].HeaderText = "Время, когда заходил в аккаунт";
           



            dataGridView1.ClearSelection();
        }
    }
}
