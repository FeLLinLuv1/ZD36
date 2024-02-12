using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ZD36
{
    public partial class new_raspis : Form
    {




        database database = new database();
        public new_raspis()
        {
            InitializeComponent();
        }

        DateTime nowdate = DateTime.Now; // сегодняшняя дата

        public Boolean est_li_mar()
        {
            database database = new database();

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            //var n_reys = numb_reys.Text; /// ПРЕОБРАЗОВАНИЕ ИЗ ДАННЫХ ТЕКСТБОКСА РЕЙСА В ПЕРЕМЕННУЮ


            //string poiskuser = $"SELECT * FROM raspis WHERE number_reys = '{n_reys}'"; /// ВЫБОРКА НЕОБХОДИМЫХ ПОЛЬЗОВАТЕЛЕЙ ИЗ ТАБЛИЦЫ Klients 

            //SqlCommand command = new SqlCommand(poiskuser, database.getConnection());

            //adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой номер рейса уже занят, выберите другой!");
                return true;
            }
            else
                return false;
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



        private void num_marsh_TextChanged(object sender, EventArgs e)
        {

        }


        private void new_raspis_LocationChanged(object sender, EventArgs e)
        {

        }

        private void new_raspis_Load(object sender, EventArgs e)
        {
            data_combobox.MinDate = DateTime.Now;

            del_panel.Visible = false;  





        }



        private void vagons_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void vibor_ras_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

       


        private Boolean otmechena_li_gruppa()
        {

            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                return false;
            }
            else
            {
                MessageBox.Show("Выберите (Поставить галочку) хотя бы одну группу!");
                return true;
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            

            // Делаем проверку по заполнению текстбоксов
            if (number_seans.Text == "")
            {
                MessageBox.Show("Введите код расписания");
                return;
            }
            if (chel_v_grupp.Text == "")
            {
                MessageBox.Show("Введите количество человек в группе (не более 20)");
                return;
            }
            if (chel_v_grupp.Text == "")
            {
                MessageBox.Show("Введите количество человек в группе (не более 20)");
                return;
            }
            if (data_combobox.Text == "")
            {
                MessageBox.Show("Введите дату сеанса");
                return;
            }

            // переменные для подсчета указанных групп
            int pervaia_gr = 0;
            int vt_gr = 0;
            int tret_gr = 0;
           


            if (otmechena_li_gruppa()) //ПРОВЕРКА НА СОСТОЯНИЕ ЧЕКБОКСОВ
                return;


            //ЗАПОЛНЕНИЕ ПЕРЕМЕННЫХ С ПРОВРЕКОЙ ЗАПОЛНЕННОСТЬЬЮ ЧЕКБОКСОВ
            if (checkBox1.Checked)
            {
                pervaia_gr = 1;

            }
            if (checkBox2.Checked)
            {
                vt_gr = 2;

            }
            if (checkBox3.Checked)
            {
                tret_gr = 3;

            }

            // Вносим в переменные данные из текстбоксов.

            int id_raspisan = int.Parse(number_seans.Text);
            int kol_seansov = int.Parse(comboBox1.Text);
            var dt = data_combobox.Text;
            var price = price_text.Text;
            int ch_grupp = int.Parse(chel_v_grupp.Text);
            

            // Проверка на количество человек в группе

            if (ch_grupp > 20 || ch_grupp == 0)
            {
                MessageBox.Show("Количество человек в группе не более 20 и не равное 0");
                return;
            }




            // цикл по добавлению строки расписания сеансов 

            double summa = Math.Pow(pervaia_gr, 2) + Math.Pow(vt_gr, 2) + Math.Pow(tret_gr, 2);//сумма квадратов трех перменных, требуется для того, чтобы узнать сколько чекбоксов задействованны
            int skolko_grupp = 0;// переменная для подсчета количества групп

            if (summa == 14)
            {
                skolko_grupp = 3;
            }
            if (summa == 5 || summa == 10 || summa == 13)
            {
                skolko_grupp = 2;
            }
            if (summa == 1 || summa == 4 || summa == 9)
            {
                skolko_grupp = 1;
            }

            try
            {

                database.openConnection();

                for (int a = 1; a <= kol_seansov; a++)
                {
                    string new_raspisan = $"insert into [raspis] (id_seans, number_seans, date, kol_grupp) values ('{id_raspisan}', '{a}', '{dt}', '{skolko_grupp}')";
                    SqlCommand command1 = new SqlCommand(new_raspisan, database.getConnection());
                    command1.ExecuteNonQuery();
                }

                //Цикл по созданию билетов

                for (int c = 1; c <= kol_seansov; c++)
                {
                    for (int b = 1; b <= skolko_grupp; b++)
                    {
                        for (int a = 1; a <= ch_grupp; a++)
                        {
                            string new_bilets = $"insert into [Bilets] (id_seans, seans, gruppa, date_seans, price, sostoyanie) values ('{id_raspisan}', '{c}', '{b}', '{dt}', '{price}', 0 )";
                            SqlCommand command2 = new SqlCommand(new_bilets, database.getConnection());
                            await command2.ExecuteNonQueryAsync();
                        }
                    }
                }

                database.closeConnection();

                MessageBox.Show("успешно");

            }
            catch
            {
                MessageBox.Show("Ошибка N1");
            }



        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e) // Запрещает вводить в comboBox не данные из списка
        {
            char ch = e.KeyChar;

            e.Handled = true;
        }

        private void number_seans_KeyPress(object sender, KeyPressEventArgs e) // ввод только чесел и бекспейса
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void price_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void chel_v_grupp_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (del_seans.Text == "")
            {
                MessageBox.Show("Введите код сеанса");
                return;
            }
            var del = del_seans.Text;


            string del_ras = $"DELETE FROM raspis where id_seans = {del}";
            string del_bil = $"DELETE FROM Bilets where id_seans = {del}";
            SqlCommand command3 = new SqlCommand(del_ras, database.getConnection());
            SqlCommand command4 = new SqlCommand(del_bil, database.getConnection());

            database.openConnection();
            if (command3.ExecuteNonQuery() == 1 | command4.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Строка успешно удалена");
                del_seans.Text = "";
            }
            else
            {
                MessageBox.Show("Такого сеанса нет");
            }
            database.closeConnection();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            del_panel.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            del_panel.Visible = true;
        }
    }
}
