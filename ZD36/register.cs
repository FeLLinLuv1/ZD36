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

namespace ZD36
{
    public partial class register : Form
    {

        database database = new database();


        public register()
        {
            InitializeComponent();
            this.vvod_parola.AutoSize = false;
            this.vvod_parola.Size = new Size(this.vvod_parola.Width, 38);/// пароль по высоте как логин
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

        private Boolean checkuser()
        {
            var loginuser = vvod_logina.Text;
            var passworduser = vvod_parola.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string newpols = $"select * from users where login = {loginuser} and password = {passworduser}";

            SqlCommand command = new SqlCommand(newpols, database.getConnection()); 
            
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count > 0 ) 
            {
                MessageBox.Show("Пользователь уже существует");
                return true;
            }

            else
            {
                return false;
            }
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
            var loginuser = vvod_logina.Text; /// ПРЕОБРАЗОВАНИЕ ИЗ ДАННЫХ ТЕКСТБОКСА ЛОГИНА В ПЕРЕМЕННУЮ
            var passuser = vvod_parola.Text; /// ТОЖЕ САМОЕ С ПАРОЛЕМ

            string newpols = $"insert into users (login, password) values('{loginuser}', '{passuser}') ";

            SqlCommand command = new SqlCommand(newpols, database.getConnection());

            database.openConnection();/// открываем связь с бд

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт успешно создан");
                Glavnaya glv = new Glavnaya();
                this.Hide();
                glv.ShowDialog();
            }
            else
            {
                MessageBox.Show("Аккаунт не создан");
            }
            database.closeConnection();/// закрывай связь с бд

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

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }
    }
}
