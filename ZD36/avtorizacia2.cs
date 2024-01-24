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
    public partial class avtorizacia2 : Form
    {
        database database = new database();

        DataTable table = new DataTable();

        SqlDataAdapter adapter = new SqlDataAdapter();

        Point LastPoint;

        public avtorizacia2()
        {
            InitializeComponent();

            this.vvod_logina.AutoSize = false;
            this.vvod_logina.Size = new Size(this.vvod_parola.Width, 58);
            this.vvod_parola.AutoSize = false;
            this.vvod_parola.Size = new Size(this.vvod_parola.Width, 58);
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void label1_MouseDown_1(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void label1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            vvod_parola.UseSystemPasswordChar = false;/// здесь прога отключает это свойство, чтобы пароль стал видимым
            pictureBox3.Visible = false;
            pictureBox4.Visible = true;
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            vvod_parola.UseSystemPasswordChar = true;/// здесь прога включает это свойство, чтобы пароль снова стал зашифрован
            pictureBox3.Visible = true;
            pictureBox4.Visible = false;
        }

        private void voiti_Click(object sender, EventArgs e)
        {
            var loginn = vvod_logina.Text; /// ПРЕОБРАЗОВАНИЕ ИЗ ДАННЫХ ТЕКСТБОКСА ЛОГИНА В ПЕРЕМЕННУЮ
            var passwordd = vvod_parola.Text; /// ТОЖЕ САМОЕ С ПАРОЛЕМ
            DataBank.Login_pols = vvod_parola.Text;// заполнение глобальной переменной логином

            string poiskuser = $"SELECT * FROM clients WHERE loginn = '{loginn}' AND passwordd = '{passwordd}'"; /// ВЫБОРКА НЕОБХОДИМЫХ ПОЛЬЗОВАТЕЛЕЙ ИЗ ТАБЛИЦЫ Klients 

            SqlCommand command = new SqlCommand(poiskuser, database.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Авторизация прошла успешно");
                Glavnaya glv = new Glavnaya();
                this.Hide();
                glv.ShowDialog();
                this.Show();
                this.Close();
            }
            else
                MessageBox.Show("Ошибка авторизации");
        }

        private void Sotrud_Click_1(object sender, EventArgs e)
        {
            sotr vhod_sotr = new sotr();
            this.Hide();
            vhod_sotr.ShowDialog();
            this.Show();
        }

        private void new_akk_Click(object sender, EventArgs e)
        {
            register reg = new register();
            this.Hide();
            reg.ShowDialog();
            this.Show();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            Glavnaya glv = new Glavnaya();
            this.Hide();
            glv.ShowDialog();
            this.Show();
            this.Close();
        }

        private void avtorizacia2_Load(object sender, EventArgs e)
        {
            string lg = "";
            DataBank.Login_pols = lg;
        }
    }
}
