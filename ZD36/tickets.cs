﻿using MySqlX.XDevAPI.Relational;
using Org.BouncyCastle.Asn1.Esf;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ZD36
{

    enum RowState
    {
        Existed,
        New,
        Modifided,
        ModifidedNew,
        Deleted


    }
    public partial class tickets : Form
    {
        database database = new database();
        DataTable table = new DataTable();
        SqlDataAdapter adapter = new SqlDataAdapter();

        int selectedRow;


       

        private void CreateColumns() ///метод по постороению таблицы на первой вкладке
        {
            dataGridView1.Columns.Add("number_reys", "Номер рейса");
            dataGridView1.Columns.Add("id_train", "Поезд");
            dataGridView1.Columns.Add("num_mursh", "Маршрут");
            dataGridView1.Columns.Add("initial_station", "Откуда:");
            dataGridView1.Columns.Add("final_station", "Куда:");
            dataGridView1.Columns.Add("time_otpr", "Отправление");
            dataGridView1.Columns.Add("time_prib", "Прибытие");
            dataGridView1.Columns.Add("date", "Дата");

        }

        private void table_bilets() ///метод по постороению таблицы на второй вкладке
        {
            dataGridView2.Columns.Add("id", "id");
            dataGridView2.Columns.Add("Train", "Номер Поезда:");
            dataGridView2.Columns.Add("vagon", "Вагон:");
            dataGridView2.Columns.Add("place", "Место");
            dataGridView2.Columns.Add("data_poezd", "Дата");
            dataGridView2.Columns.Add("time_otpr", "Отправление");
            dataGridView2.Columns.Add("time_prib", "Прибытие");
            dataGridView2.Columns.Add("sostoyanie", "Состояние:");
            dataGridView2.Columns.Add("price", "Цена");
            dataGridView2.Columns.Add("number_reys", "Номер рейса");
            dataGridView2.Columns.Add("IsNew", String.Empty);
            this.dataGridView2.Columns[4].Visible = false;
            this.dataGridView2.Columns[5].Visible = false;
            this.dataGridView2.Columns[6].Visible = false;
            this.dataGridView2.Columns[7].Visible = false;
            this.dataGridView2.Columns[10].Visible = false;
        }

        private void Search(DataGridView dgw) //Метод по поиску нужного рапсисания (НАЧАЛЬНАЯ И КОНЕЧНАЯ СТАНЦИЯ)
        {
            dgw.Rows.Clear();
            var dt = data_combobox.Text;
           

            string vivod = $"Select * from raspis where date >= '{dt}' and concat (initial_station, final_station) like '%" + st_otpr.Text + st_naznach.Text + "%'";

            SqlCommand com = new SqlCommand(vivod, database.getConnection());

            database.openConnection();

            SqlDataReader read = com.ExecuteReader();

            while (read.Read())
            {
                ReadRows(dataGridView1, read);
            }

            read.Close();
            
            database.closeConnection();

            


        }


        private void SearchBilets(DataGridView dgw2) //Метод по поиску билетов по выбранному маршруту
        {
            int n_reys;
            n_reys = int.Parse(textbox_vibor.Text);
            var date_poezd = data_combobox.Text;

            string vivods = $"Select * from Bilets where number_reys = '{n_reys}' and sostoyanie = 0 and date_poezd > '{date_poezd}' or number_reys = '{n_reys}' and sostoyanie = 4 and date_poezd > '{date_poezd}'";

            SqlCommand com = new SqlCommand(vivods, database.getConnection());

            database.openConnection();

            SqlDataReader read = com.ExecuteReader();

            while (read.Read())
            {
                ReadRowsBilets(dataGridView2, read);
            }

        

            read.Close();

           

            database.closeConnection();

        }


        private void Search_time(DataGridView dgw) ///метод по поиску нужного расписания основанный на ДАТЕ, НАЧАЛЬНОЙ и КОНЕЧНОЙ СТАНЦИИ
        {
            dgw.Rows.Clear();

            var st_otp = st_otpr.Text;
            var st_kon = st_naznach.Text;
            var date_poezd = data_combobox.Text;

            string vivod = $"Select * from raspis where initial_station = '{st_otp}' AND final_station = '{st_kon}' AND date = '{date_poezd}'";

            SqlCommand com = new SqlCommand(vivod, database.getConnection());

            database.openConnection();

            SqlDataReader read = com.ExecuteReader();

            while (read.Read())
            {  
                ReadRows(dataGridView1, read);       
            }
            read.Close();

            database.closeConnection();

        }

        private void ReadRowsBilets(DataGridView dgw3, IDataRecord record)//Вывод для таблицы с билетами
        {
            dgw3.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetInt32(2), record.GetInt32(3), record[4], record[5], record[6], record.GetInt32(7), record.GetString(8), record.GetInt32(9));  ///Предоставляет значение каждого столбца для строк в таблице
        }

        private void ReadRows(DataGridView dgw, IDataRecord record)//Вывод для таблицы с раписанием
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetInt32(2), record.GetString(3), record.GetString(4), record[5], record[6], record[7]);  ///Предоставляет значение каждого столбца для строк в таблице
        }

        private void RefreshDataGrid(DataGridView dgw)///метод по Выводу всего расписания
            ///Может не пригодиться
        {
            dgw.Rows.Clear();
            string queryString = $"select * from raspis";
            SqlCommand command = new SqlCommand(queryString, database.getConnection());
            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadRows(dgw, reader);
            }
            reader.Close();
            database.closeConnection();

        }

        private void ClearRows(DataGridView dgw3)
        {
            dgw3.Rows.Clear();
        }

        public void vibr_marshrut_Click(object sender, EventArgs e)
        {
  

            Search(dataGridView1);
            dataGridView1.ClearSelection();





        }


        // показывания времени начиная с сегодняшнего дня
        

        public tickets()
        {
            InitializeComponent();
            this.close.Visible = false;
            this.data_combobox.Visible = false;
            this.ukaz_vrem.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tickets_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zD36DataSet4.raspis". При необходимости она может быть перемещена или удалена.
            this.raspisTableAdapter6.Fill(this.zD36DataSet4.raspis);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kuda_dist1.raspis". При необходимости она может быть перемещена или удалена.
            this.raspisTableAdapter5.Fill(this.kuda_dist1.raspis);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kuda_dist1.raspis". При необходимости она может быть перемещена или удалена.
            this.raspisTableAdapter5.Fill(this.kuda_dist1.raspis);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kuda_dist1.raspis". При необходимости она может быть перемещена или удалена.
            this.raspisTableAdapter5.Fill(this.kuda_dist1.raspis);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kuda_dist.raspis". При необходимости она может быть перемещена или удалена.
            this.raspisTableAdapter5.Fill(this.kuda_dist.raspis);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zD36DataSet11.raspis". При необходимости она может быть перемещена или удалена.
           /* this.raspisTableAdapter4.Fill(this.zD36DataSet11.raspis);*/
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zD36DataSet21.raspis". При необходимости она может быть перемещена или удалена.
            this.raspisTableAdapter1.Fill(this.zD36DataSet21.raspis);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zD36DataSet21.raspis". При необходимости она может быть перемещена или удалена.
            this.raspisTableAdapter1.Fill(this.zD36DataSet21.raspis);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "raspis_distinct1.raspis". При необходимости она может быть перемещена или удалена.
            this.raspisTableAdapter3.Fill(this.raspis_distinct1.raspis);
            this.raspisTableAdapter2.Fill(this.zD36DataSet3.raspis);
            this.raspisTableAdapter.Fill(this.zD36DataSet1.raspis);
            this.raspisTableAdapter1.Fill(this.zD36DataSet2.raspis);
            this.raspisTableAdapter.Fill(this.zD36DataSet.raspis);

            data_combobox.MinDate = DateTime.Now;//минимальная дата

            CreateColumns(); ///создание столбцов в таблице
            table_bilets();

            

            posadka_label.Text = st_otpr.Text;
            visadka_label.Text = st_naznach.Text;

           

            this.tabPage2.Parent = null;
             this.tabPage3.Parent = null;

        }

        
        
        private void button1_Click(object sender, EventArgs e)
        {

            var date_poezd = data_combobox.Text;
            ClearRows(dataGridView2);//очистка таблицы из 2 вкладки
            
            try
            {
                
                if (textbox_vibor.Text == "")
                {
                    MessageBox.Show("Выберите номер рейса");
                    return;
                }

                int number = 0;
                number = int.Parse(textbox_vibor.Text);
                
                string poiskmarsh = $"SELECT * FROM raspis WHERE number_reys = '{number}'";

                SqlCommand command = new SqlCommand(poiskmarsh, database.getConnection());

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count == 1)
                {
                    
                    table.Clear();
                    label2.Text = "";
                    label3.Text = "";
                    label4.Text = "";
                    label5.Text = "";
                    label6.Text = "";
                    label12.Text = "";
                    label_id.Text = "";


                    this.tabPage2.Parent = tabControl1;
                    

                    if (tabControl1.SelectedIndex < tabControl1.TabPages.Count)
                        tabControl1.SelectedIndex++;
                }


                

                else
                {
                    MessageBox.Show("Такого рейса нет 1 ");
                }

               

            }
          
            catch { MessageBox.Show("Такого рейса нет 2"); }
            
            SearchBilets(dataGridView2);

            dataGridView2.ClearSelection();

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void knopka_Opening(object sender, CancelEventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            close.Visible = false;
            data_combobox.Visible = false;
            ukaz_vrem.Visible = false;
            label17.Visible = true;

        }

        private void time_Click(object sender, EventArgs e)
        {
            close.Visible = true;
            data_combobox.Visible = true;
            ukaz_vrem.Visible = true;
          
        }

        private void ukaz_vrem_Click(object sender, EventArgs e)
        {
            Search_time(dataGridView1);

            dataGridView1.ClearSelection();
        }

        private void data_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void st_otpr_SelectedIndexChanged(object sender, EventArgs e)
        {
            posadka_label.Text = st_otpr.Text;
        }


        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.raspisTableAdapter.FillBy1(this.zD36DataSet.raspis);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.raspisTableAdapter1.FillBy(this.zD36DataSet2.raspis);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void st_otpr_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void st_otpr_Click(object sender, EventArgs e)
        {

        }

        private void posadka_label_Click(object sender, EventArgs e)
        {

        }

        private void visadka_label_Click(object sender, EventArgs e)
        {

        }

        private void st_naznach_SelectedIndexChanged(object sender, EventArgs e)
        {
            visadka_label.Text = st_naznach.Text;
        }


        private void posadka_label_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void visadka_label_TextChanged(object sender, EventArgs e)
        {
          
            
        }

        private void fillBy1ToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.raspisTableAdapter.FillBy1(this.zD36DataSet.raspis);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void initial_st_distinctToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.raspisTableAdapter.initial_st_distinct(this.zD36DataSet.raspis);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void initial_st_distinctToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.raspisTableAdapter3.FillBy(this.raspis_distinct1.raspis);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.raspisTableAdapter5.FillBy(this.kuda_dist.raspis);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                this.raspisTableAdapter5.FillBy(this.kuda_dist1.raspis);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fillByToolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                this.raspisTableAdapter6.FillBy(this.zD36DataSet4.raspis);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void tabPage1_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void na_oplatu_Click(object sender, EventArgs e)
        {
            try
            {

                if (label2.Text == "" || label3.Text == "" || label4.Text == "" || label5.Text == "" || label6.Text == "")
                {
                    MessageBox.Show("Выберите билет");
                    return;
                }

                    table.Clear();
                    this.tabPage3.Parent = tabControl1;//включение видимости на след вкладке

                    if (tabControl1.SelectedIndex < tabControl1.TabPages.Count)//переключение
                        tabControl1.SelectedIndex++;
                    if (tabControl1.SelectedIndex < tabControl1.TabPages.Count)//переключение
                        tabControl1.SelectedIndex++;

            }

            catch { MessageBox.Show("Ошибка"); }


            
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void otpr_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "-")
            {
                MessageBox.Show("Нельзя ввести только -");
                return;
            }
            if (textBox3.TextLength < 4)
            {
                MessageBox.Show("Введите 4 (!!!) последние цифры номера карты");
                return;
            }
            try
            {

                if (label_id.Text == "")
                {
                    MessageBox.Show("Выберите билет, хватит тыкать");
                    return;
                }

                if (textBox1.Text == "")
                {
                    MessageBox.Show("Введите ФИО пассажира");
                    return;
                }

               

                if (textBox3.Text == "")
                {
                    MessageBox.Show("Введите последние 4 цифры номера карты");
                    return;
                }

                var FIO = textBox1.Text;
                int id_bil = int.Parse(label_id.Text);
                int crd = int.Parse(textBox3.Text);

                string del = $"delete from clientbil where id = '{id_bil}'";
                string cell = $"insert into clientbil (id, loginn, FIO, card) values('{id_bil}', '{DataBank.Login_pols}', '{FIO}', '{crd}') ";
                string upd_bil = $"update Bilets set sostoyanie = 1 where id = '{id_bil}'";


                SqlCommand command0 = new SqlCommand(del, database.getConnection());
                SqlCommand command1 = new SqlCommand(cell, database.getConnection());
                SqlCommand command2 = new SqlCommand(upd_bil, database.getConnection());

                database.openConnection();/// открываем связь с бд

                command0.ExecuteNonQuery();

                if (command1.ExecuteNonQuery() == 1 && command2.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Билет забронирован. Переход на оплату.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ошибка :-(");
                }

                database.closeConnection();/// закрывай связь с бд


                System.Diagnostics.Process.Start("https://vk.com/lermontv?z=moneysend392510961");

            }
            catch
            {
                MessageBox.Show("Ошибка(");
            }
        }

        private void textbox_vibor_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void dataGridView2_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[selectedRow];

                label2.Text = row.Cells[1].Value.ToString();
                label3.Text = row.Cells[2].Value.ToString();
                label4.Text = row.Cells[3].Value.ToString();
                label5.Text = row.Cells[8].Value.ToString();
                label6.Text = row.Cells[9].Value.ToString();
                label12.Text = row.Cells[0].Value.ToString();
                label_id.Text = row.Cells[0].Value.ToString();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsLetter(ch) && ch != 8 && ch !=32 && ch != 189 && ch != 16 && ch!=45)
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar == '-' && textBox1.Text.Contains("-"))
            {
                e.Handled = true; // Отменяем добавление символа в текстовое поле
                return;
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                textbox_vibor.Text = row.Cells[0].Value.ToString();
               
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void data_combobox_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            close.Visible = true;
            data_combobox.Visible = true;
            ukaz_vrem.Visible = true;
           label17.Visible = false;
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
