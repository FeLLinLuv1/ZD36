using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Input;
using System.Security.Cryptography.X509Certificates;

namespace ZD36
{
    public partial class register : Form
    {

        database database = new database();


        public register()
        {
            InitializeComponent();
          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void register_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
         
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            vvod_parola.UseSystemPasswordChar = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            vvod_parola.UseSystemPasswordChar = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
        }


        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void vvod_logina_TextChanged(object sender, EventArgs e)
        {

        }

        private void vvod_parola_TextChanged(object sender, EventArgs e)
        {

        }

        private void voiti_Click(object sender, EventArgs e)
        {
            if (FIO.Text == "-")
            {
                MessageBox.Show("Нельзя ввести только -");
                return;
            }

            if (FIO.Text == "")
            {
                MessageBox.Show("Введите Ваше ФИО");
                return;
            }
            if (vvod_logina.Text == "")
            {
                MessageBox.Show("Введите Ваш Логин");
                return;
            }
            if (vvod_parola.Text == "")
            {
                MessageBox.Show("Введите Ваш Пароль");
                return;
            }
            if (est_li_pols())
                return;

            var loginuser = vvod_logina.Text; /// ПРЕОБРАЗОВАНИЕ ИЗ ДАННЫХ ТЕКСТБОКСА ЛОГИНА В ПЕРЕМЕННУЮ
            var passuser = vvod_parola.Text; /// ТОЖЕ САМОЕ С ПАРОЛЕМ
            var fiouser = FIO.Text;

            string newpols = $"insert into clients (FIO, loginn, passwordd) values('{fiouser}', '{loginuser}', '{passuser}') ";

            SqlCommand command = new SqlCommand(newpols, database.getConnection());

            database.openConnection();/// открываем связь с бд

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт успешно создан");
                this.Close();
            }
            else
            {
                MessageBox.Show("Аккаунт не создан");
            }

            database.closeConnection();/// закрывай связь с бд
        }
            public Boolean est_li_pols()
            {
            database database = new database();

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            var loginn = vvod_logina.Text; /// ПРЕОБРАЗОВАНИЕ ИЗ ДАННЫХ ТЕКСТБОКСА ЛОГИНА В ПЕРЕМЕННУЮ
            var passwordd = vvod_parola.Text; /// ТОЖЕ САМОЕ С ПАРОЛЕМ

            string poiskuser = $"SELECT * FROM clients WHERE loginn = '{loginn}'"; /// ВЫБОРКА НЕОБХОДИМЫХ ПОЛЬЗОВАТЕЛЕЙ ИЗ ТАБЛИЦЫ Klients 

            SqlCommand command = new SqlCommand(poiskuser, database.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count >0)
            {
                MessageBox.Show("Такой логин уже занят, введите другой");
                return true;
            }
            else
                return false;
            }
        



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void close_button_MouseLeave(object sender, EventArgs e)
        {
            close_button.ForeColor = Color.White;
        }

        private void close_button_MouseEnter(object sender, EventArgs e)
        {
            close_button.ForeColor = Color.Red;
        }

        private void nazad_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FIO_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            

            if (!Char.IsLetter(ch) && ch != 8 && ch != 32 && ch != 189 && ch != 16 && ch != 45)
            {
                e.Handled = true;
            }

            if (e.KeyChar == '-' && FIO.Text.Contains("-"))
            {
                e.Handled = true; // Отменяем добавление символа в текстовое поле
                return;
            }

            if (ch == 13)
            {
                vvod_logina.Focus();
            }

           
        }

        private void vvod_logina_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 13)
            {
                vvod_parola.Focus();
            }
        }

        private void vvod_parola_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 13)
            {
                if (FIO.Text == "")
                {
                    MessageBox.Show("Введите Ваше ФИО");
                    return;
                }
                if (vvod_logina.Text == "")
                {
                    MessageBox.Show("Введите Ваш Логин");
                    return;
                }
                if (vvod_parola.Text == "")
                {
                    MessageBox.Show("Введите Ваш Пароль");
                    return;
                }
                if (est_li_pols())
                    return;

                var loginuser = vvod_logina.Text; /// ПРЕОБРАЗОВАНИЕ ИЗ ДАННЫХ ТЕКСТБОКСА ЛОГИНА В ПЕРЕМЕННУЮ
                var passuser = vvod_parola.Text; /// ТОЖЕ САМОЕ С ПАРОЛЕМ
                var fiouser = FIO.Text;

                string newpols = $"insert into clients (FIO, loginn, passwordd) values('{fiouser}', '{loginuser}', '{passuser}') ";

                SqlCommand command = new SqlCommand(newpols, database.getConnection());

                database.openConnection();/// открываем связь с бд

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Аккаунт успешно создан");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Аккаунт не создан");
                }

                database.closeConnection();/// закрывай связь с бд
            }
        }
    }
}
