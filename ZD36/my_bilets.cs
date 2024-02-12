﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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

        public my_bilets()
        {
            InitializeComponent();
        }

        private void table_bilets() //метод по постороению таблицы на второй вкладке
        {
           
            dataGridView1.Columns[0].HeaderText = "id";//0
            dataGridView1.Columns[1].HeaderText = "Код расписания";//1
            dataGridView1.Columns[2].HeaderText = "Код сеанса";//2
            dataGridView1.Columns[3].HeaderText = "Группа";//3
            dataGridView1.Columns[4].HeaderText = "Дата";//4
            dataGridView1.Columns[5].HeaderText = "Цена";//5
            dataGridView1.Columns[6].HeaderText = "Cостояние";//6
            dataGridView1.Columns[7].HeaderText = "4 цифры";//7
            dataGridView1.Columns[8].HeaderText = "Время начала";//8
        }

        private void kartinka()//создание qr_кода, помещенного в pictriurebox1
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

        private void my_bilets_Load(object sender, EventArgs e)
        {

            dataGridView1.ClearSelection();


            database.openConnection();

            string moi_bil = DataBank.Login_pols;

            string vivods = $"Select Bilets.id, Bilets.id_seans, Bilets.seans, Bilets.gruppa, Bilets.date_seans, Bilets.price, Bilets.sostoyanie, clientbil.card, seans.time_start from Bilets, clientbil, seans where (Bilets.id = clientbil.id and Bilets.seans = seans.number_seans) and (clientbil.loginn = 'qw' and sostoyanie = 'ожидает оплаты' or clientbil.loginn = '{moi_bil}' and sostoyanie = 'подтвержден');";

            SqlCommand command = new SqlCommand(vivods, database.getConnection());

            DataSet dataset = new DataSet();

            adapter.SelectCommand = command;
            adapter.Fill(dataset);
            dataGridView1.DataSource = dataset.Tables[0];
            
            database.closeConnection();

            table_bilets();
        }

        private void ClearRows(DataGridView dgw3)
        {
            dgw3.Rows.Clear();
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

                textBox2.Text = $"bilet id: {row.Cells[0].Value.ToString()}, vagon : {row.Cells[1].Value.ToString()}, mesto: {row.Cells[2].Value.ToString()}, data: {row.Cells[3].Value.ToString()},  " +
                    $"vrema: {row.Cells[4].Value.ToString()}, " +
                    $"sostoyanie: {row.Cells[6].Value.ToString()}, " +
                    $"nomer reysa: {row.Cells[8].Value.ToString()}, " +
                    $"log: {row.Cells[9].Value.ToString()}";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            kartinka();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kartinka();

            if (textBox2.Text == "")
            {
                return;
            }
            else
            {
                System.Windows.Forms.SaveFileDialog save = new System.Windows.Forms.SaveFileDialog(); // save будет запрашивать у пользователя, место, в которое он захочет сохранить файл. 
                save.Filter = "PNG|*.png"; //создаём фильтр, который определяет, в каких форматах мы сможем сохранить нашу информацию. В данном случае выбираем форматы изображений. Записывается так: "название_формата_в обозревателе|*.расширение_формата")
                if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK) //если пользователь нажимает в обозревателе кнопку "Сохранить".
                {
                    // Проверка на окончание файла
                    if (Path.GetExtension(save.FileName) != ".png")
                    {
                        MessageBox.Show("Фото должно быть в формате PNG");
                    }
                    else
                    {
                        // Загрузка фото
                        pictureBox1.Image.Save(save.FileName); //изображение из pictureBox'a сохраняется под именем, которое введёт пользователь
                        MessageBox.Show("Билет сохранен!");
                    }
                }
            }
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_DataBindingComplete_1(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
        }
    }
}
