using MySqlX.XDevAPI.Relational;
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
    public partial class tickets : Form
    {
        database database = new database();
        DataTable table = new DataTable();
        SqlDataAdapter adapter = new SqlDataAdapter();

        int selectedRow;

        

        private void CreateColumns() //метод по постороению таблицы на первой вкладке
        {
            dataGridView2.Columns.Add("id", "id");//0
            dataGridView2.Columns.Add("id_seans", "Код расписания");//1
            dataGridView2.Columns.Add("seans", "Код сеанса");//2
            dataGridView2.Columns.Add("gruppa", "Группа");//3
            dataGridView2.Columns.Add("date_seans", "Дата");//4
            dataGridView2.Columns.Add("price", "Цена");//5
            dataGridView2.Columns.Add("sostoyanie", "Cостояние");//6
            dataGridView2.Columns.Add("time_start", "Время начала");//7
            this.dataGridView2.Columns[6].Visible = false;
            this.dataGridView2.Columns[2].Visible = false;
        }

        public tickets()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tickets_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gallery1.seans". При необходимости она может быть перемещена или удалена.
            this.seansTableAdapter.Fill(this.gallery1.seans);

            vibor_dati.MinDate = DateTime.Now;
            tabControl1.Visible = false;
            vibor_seansov.Visible = false;
            label1.Visible = false;
            button1 .Visible = false;

            zagruzka.Location = new Point(210, 45);

            skrit.Visible = false;
            pictureBox1.Visible = false;

            CreateColumns();// Постороение таблицы с билетами


            this.tabPage2.Parent = null;//отключает видимость второй вкладки

        }




        public Boolean est_li_data()
        {
            database database = new database();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            var dt = vibor_dati.Value.ToString();

            string poiskdata = $"SELECT * FROM raspis WHERE date = '{dt}'"; //поиск по дате

            SqlCommand command = new SqlCommand(poiskdata, database.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                MessageBox.Show("На такую дату сеансов нет! Просмотрите распсиание сеансов.");
                return true;
            }
              
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (est_li_data())
                return;

            zagruzka.Visible = false;
            tabControl1 .Visible = true;
            label1.Visible = true;
            button1.Visible = true;
        }

        private void pokazat_Click(object sender, EventArgs e)
        {

            vibor_seansov.Visible = true;
            pokazat.Visible = false;
            skrit.Visible = true;

            dataGridView1.ClearSelection();

        }

        private void skrit_Click(object sender, EventArgs e)
        {
            vibor_seansov.Visible = false;
            pokazat.Visible = true;
            skrit.Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                vibor_seansa.Text = row.Cells[0].Value.ToString();

            }
        }

        private void vibor_seansa_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void vibor_gruppi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ReadRows(DataGridView dgw, IDataRecord record)//Вывод для таблицы с билетами
        {
           
            dgw.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetInt32(2), record.GetInt32(3), record[4], record.GetString(5), record.GetString(6), record[7]);  //Предоставляет значение каждого столбца для строк в таблице
        
        }

        private void Search(DataGridView dgw) //Метод по поиску нужного рапсисания
        {
            var dt = vibor_dati.Value.ToString();
            dgw.Rows.Clear();
            var sn = vibor_seansa.Text;


            string vivod = $"Select Bilets.id, Bilets.id_seans, Bilets.seans, Bilets.gruppa, Bilets.date_seans, Bilets.price, Bilets.sostoyanie, seans.time_start from Bilets inner join seans on Bilets.seans = seans.number_seans where Bilets.seans = '{sn}' and Bilets.date_seans = '{dt}' and Bilets.sostoyanie = '0'";
           
            SqlCommand com = new SqlCommand(vivod, database.getConnection());

            database.openConnection();

            SqlDataReader read = com.ExecuteReader();

            while (read.Read())
            {
                ReadRows(dataGridView2, read);
            }

            read.Close();

            database.closeConnection();

        }

        private void ClearRows(DataGridView dgw3)
        {
            dgw3.Rows.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (vibor_seansa.Text == "")
            {
                MessageBox.Show("Выберите сеанс!");
                return;
            }
            ClearRows(dataGridView2);
            Search(dataGridView2);
            dataGridView2.ClearSelection();

            vibor_seansov.Visible = false;
            pokazat.Visible = true;
            skrit.Visible = false;

            clear_textboxs();

        }

        private void clear_textboxs()
        {
            id_bilet.Text = "";
            id_bilet2.Text = "";
            data_tb.Text = "";
            time_tb.Text = "";
            price_tb.Text = "";
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            
            try
            {
                if (e.RowIndex >= 0)
                {
                    clear_textboxs();//очищает все текстбоксы

                    DataGridViewRow row = dataGridView2.Rows[selectedRow];

                   
                    id_bilet.Text = row.Cells[0].Value.ToString();
                    id_bilet2.Text = row.Cells[0].Value.ToString();
                    data_tb.Text = row.Cells[4].Value.ToString();
                    time_tb.Text = row.Cells[7].Value.ToString();
                    price_tb.Text = row.Cells[5].Value.ToString();

                    string text = data_tb.Text; // получаем текущий текст из textbox
                    if (!string.IsNullOrEmpty(text))
                    {
                        text = text.Remove(text.Length - 8); // удаляем последний символ
                        data_tb.Text = text; // обновляем текст в textbox
                    }

                }
            }
            catch
            {
                MessageBox.Show("Выберите Билет!");
            }
           
        }



        private void button5_Click(object sender, EventArgs e)
        {
            if (id_bilet.Text == "")
            {
                MessageBox.Show("Выберите билет!");
                return;
            }



            this.tabPage2.Parent = tabControl1;
            if (tabControl1.SelectedIndex < tabControl1.TabPages.Count)
                tabControl1.SelectedIndex++;

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e) //Переход со второй вкладки на первую
        {
           
            if (tabControl1.SelectedIndex < tabControl1.TabPages.Count)
                tabControl1.SelectedIndex--;
            this.tabPage2.Parent = null;//отключает видимость второй вкладки
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void oplata_Click(object sender, EventArgs e)
        {
            if (card.Text == "" || card.Text.Length<4)//Проверка заполненности карты
            {
                MessageBox.Show("Введите последние 4 цифры номера Вашей карты!");
                return;
            }
            if (fio_pol.Text == "")
            {
                MessageBox.Show("Введите ФИО посетителя");
                return;
            }

            try
            {
                var f = fio_pol.Text;
                int id_bil = int.Parse(id_bilet2.Text);
                int crd = int.Parse(card.Text);

                string cell = $"insert into clientbil (id, loginn, FIO, card) values('{id_bil}', '{DataBank.Login_pols}', '{f}', '{crd}') ";
                string upd_bil = $"update Bilets set sostoyanie = 'ожидает оплаты' where id = '{id_bil}'";

                SqlCommand command1 = new SqlCommand(cell, database.getConnection());
                SqlCommand command2 = new SqlCommand(upd_bil, database.getConnection());

                database.openConnection();// открываем связь с бд

                if (command1.ExecuteNonQuery() == 1 && command2.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Билет забронирован. Ожидание оплаты.");
                    pictureBox1.Visible = true;//открываем QR-код

                }
                else
                {
                    MessageBox.Show("Ошибка");
                }

                database.closeConnection();// закрывай связь с бд

              

            }

            catch
            {
                MessageBox.Show("Ошибка. Catch");
               
            }



        }

        private void FIO_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsLetter(ch) && ch != 8 && ch != 32 && ch != 189 && ch != 16 && ch != 45)
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress_1(object sender, KeyPressEventArgs e)
        {

            char ch = e.KeyChar;



            if (!Char.IsLetter(ch) && ch != 8 && ch != 32 && ch != 189 && ch != 16 && ch != 45)
            {
                e.Handled = true;
            }

            if (e.KeyChar == '-' && fio_pol.Text.Contains("-"))
            {
                e.Handled = true; // Отменяем добавление символа в текстовое поле
                return;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.sberbank.com/sms/pbpn?requisiteNumber=79102458285");
        }
    }
}
