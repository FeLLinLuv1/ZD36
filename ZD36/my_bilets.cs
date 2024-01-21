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
    public partial class my_bilets : Form
    {
        database database = new database();
        DataTable table = new DataTable();
        SqlDataAdapter adapter = new SqlDataAdapter();

        int selectedRow;

       /* private void CreateColumns() //метод по постороению таблицы
        {
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("Train", "Номер Поезда:");
            dataGridView1.Columns.Add("vagon", "Вагон:");
            dataGridView1.Columns.Add("place", "Место");
            dataGridView1.Columns.Add("data_poezd", "Дата");
            dataGridView1.Columns.Add("time_otpr", "Отправление");
            dataGridView1.Columns.Add("time_prib", "Прибытие");
            dataGridView1.Columns.Add("sostoyanie", "Состояние:");
            dataGridView1.Columns.Add("price", "Цена");
            dataGridView1.Columns.Add("number_reys", "Номер рейса");
            dataGridView1.Columns.Add("loginn", "login");
            this.dataGridView1.Columns[10].Visible = false;
        }

        private void ReadRowsBilets(DataGridView dgw, IDataRecord record)//Вывод для таблицы с билетами
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetInt32(2), record.GetInt32(3), record[4], record[5], record[6], record.GetInt32(7), record.GetString(8), record.GetInt32(9), record.GetString(10));  ///Предоставляет значение каждого столбца для строк в таблице
        }
        private void ClearRows(DataGridView dgw3)//Очистка таблицы
        {
            dgw3.Rows.Clear();
        }

        private void SearchBilets(DataGridView dgw2) //Метод по поиску билетов пользователя
        {
            string moi_bil = DataBank.Login_pols;
            string vivods = $"select Bilets.id, Bilets.vagon, Bilets.place, Bilets.date_poezd, Bilets.time_otpr, Bilets.time_prib, Bilets.sostoyanie, Bilets.price, Bilets.number_reys, clientbil.loginn from Bilets inner join clientbil on Bilets.id = clientbil.id where clientbil.loginn = '{moi_bil}'";

            SqlCommand com = new SqlCommand(vivods, database.getConnection());

            database.openConnection();

            SqlDataReader read = com.ExecuteReader();

            while (read.Read())
            {
                ReadRowsBilets(dataGridView1, read);
            }

            read.Close();

            database.closeConnection();

        }*/

        public my_bilets()
        {
            InitializeComponent();
        }

        private void my_bilets_Load(object sender, EventArgs e)
        {
           /* ClearRows(dataGridView1);
            CreateColumns();
            SearchBilets(dataGridView1);*/

            database.openConnection();

            string moi_bil = DataBank.Login_pols;

            string vivod = $"select Bilets.id, Bilets.vagon, Bilets.place, Bilets.date_poezd, Bilets.time_otpr, Bilets.time_prib, Bilets.sostoyanie, Bilets.price, Bilets.number_reys, clientbil.loginn from Bilets inner join clientbil on Bilets.id = clientbil.id where clientbil.loginn = '{moi_bil}'";

            SqlCommand command = new SqlCommand(vivod, database.getConnection());

            DataSet dataset = new DataSet();

            adapter.SelectCommand = command;
            adapter.Fill(dataset);

            dataGridView1.DataSource = dataset.Tables[0];
            

            database.closeConnection();



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

        private void close_but_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                textBox2.Text = $"bilet id: {row.Cells[0].Value.ToString()}, " +
                    $"vagon : {row.Cells[1].Value.ToString()}, " +
                    $"mesto: {row.Cells[1].Value.ToString()}, " +
                    $"data: {row.Cells[1].Value.ToString()},  " +
                    $"vrema: {row.Cells[1].Value.ToString()}, " +
                    $"sostoyanie: {row.Cells[1].Value.ToString()}, " +
                    $"nomer reysa: {row.Cells[1].Value.ToString()}";

                /*id_b.Text = row.Cells[0].Value.ToString();
                vagon_b.Text = row.Cells[1].Value.ToString();
                place_b.Text = row.Cells[2].Value.ToString();
                data_b.Text = row.Cells[3].Value.ToString();
                time_b.Text = row.Cells[4].Value.ToString();
                sost_b.Text = row.Cells[6].Value.ToString();
                number_reys_b.Text = row.Cells[8].Value.ToString();*/
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Выберите билет");
                return;
            }

            QRCoder.QRCodeGenerator bilet_qr = new QRCoder.QRCodeGenerator();
            var MyData = bilet_qr.CreateQrCode(textBox2.Text, QRCoder.QRCodeGenerator.ECCLevel.H);
            var code = new QRCoder.QRCode(MyData);
            pictureBox1.Image = code.GetGraphic(50);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox2.Text == "")
            {
                MessageBox.Show("Выберите билет");
                return;
            }

            SaveFileDialog save = new SaveFileDialog(); // save будет запрашивать у пользователя, место, в которое он захочет сохранить файл. 
            save.Filter = "PNG|*.png|JPEG|*.jpg|GIF|*.gif|BMP|*.bmp"; //создаём фильтр, который определяет, в каких форматах мы сможем сохранить нашу информацию. В данном случае выбираем форматы изображений. Записывается так: "название_формата_в обозревателе|*.расширение_формата")
            if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK) //если пользователь нажимает в обозревателе кнопку "Сохранить".
            {
                pictureBox1.Image.Save(save.FileName); //изображение из pictureBox'a сохраняется под именем, которое введёт пользователь
            }
        }
    }
}
