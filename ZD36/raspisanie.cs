﻿using System;
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
    public partial class raspisanie : Form
    {
        database database = new database();

        DataTable table = new DataTable();

        SqlDataAdapter adapter = new SqlDataAdapter();

        DateTime mindate = DateTime.Now;

        public raspisanie()
        {
            InitializeComponent();
        }

        private void raspisanie_Load(object sender, EventArgs e)
        {

            database.openConnection();
            string vivod = $"SELECT * FROM raspis where date >= '{mindate}'"; // Выборка всех строк расписания с датой, которая не наступила или сегодня (не показывает прошедшие даты)

            SqlCommand command = new SqlCommand(vivod, database.getConnection());

            DataSet dataset = new DataSet();

            adapter.SelectCommand = command;
            adapter.Fill(dataset);

            dataGridView1.DataSource = dataset.Tables[0];
            database.closeConnection();

            dataGridView1.ClearSelection();

            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "ID расписания";
            dataGridView1.Columns[2].HeaderText = "Код Сеанса";
            dataGridView1.Columns[3].HeaderText = "Дата";



            dataGridView1.Columns[0].Visible = false;

        }

       

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
