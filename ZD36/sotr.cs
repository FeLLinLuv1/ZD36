using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Data.SqlClient; 

namespace ZD36
{
    public partial class sotr : Form
    {

        database database = new database();

        DataTable table = new DataTable();

        SqlDataAdapter adapter = new SqlDataAdapter();

        public sotr()
        {
            InitializeComponent();
            this.pas_sotr.AutoSize = false;
            this.pas_sotr.Size = new Size(this.pas_sotr.Width, 38);/// пароль по высоте как логин
            this.log_sotr.AutoSize = false;
            this.log_sotr.Size = new Size(this.pas_sotr.Width, 38);/// пароль по высоте как пароль
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pas_sotr.UseSystemPasswordChar = false;// здесь прога отключает это свойство, чтобы пароль стал видимым
            pictureBox4.Visible = false;
            pictureBox5.Visible = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pas_sotr.UseSystemPasswordChar = true;// здесь прога включает это свойство, чтобы пароль снова стал зашифрован
            pictureBox4.Visible = true;
            pictureBox5.Visible = false;
        }

        private void sotr_Load(object sender, EventArgs e)
        {

        }

        private void pas_sotr_TextChanged(object sender, EventArgs e)
        {

        }

        private void log_sotr_TextChanged(object sender, EventArgs e)
        {

        }

        private void vhod_Click(object sender, EventArgs e)
        {
            var loginuser = log_sotr.Text; /// ПРЕОБРАЗОВАНИЕ ИЗ ДАННЫХ ТЕКСТБОКСА ЛОГИНА В ПЕРЕМЕННУЮ
            var passuser = pas_sotr.Text; /// ТОЖЕ САМОЕ С ПАРОЛЕМ

            string poiskuser = $"SELECT * FROM Employee WHERE loginn = '{loginuser}' AND passwordd = '{passuser}'"; /// ВЫБОРКА НЕОБХОДИМЫХ ПОЛЬЗОВАТЕЛЕЙ ИЗ ТАБЛИЦЫ employee 

            SqlCommand command = new SqlCommand(poiskuser, database.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Авторизация прошла успешно");
                glavn_sotr gl = new glavn_sotr();
                this.Hide();
                gl.ShowDialog();
                this.Show();
                this.Close();
            }
            else
                MessageBox.Show("Ошибка авторизации");
            
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void close_MouseEnter(object sender, EventArgs e)
        {
            close.ForeColor = Color.Red;
        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            close.ForeColor = Color.White;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        Point LastPoint;
        private void avtoriz_sotr_label_Click(object sender, EventArgs e)
        {

        }

        private void avtoriz_sotr_label_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }

        }

        private void avtoriz_sotr_label_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

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

        private void nazad_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            glavn_sotr gl = new glavn_sotr();
            this.Hide();
            gl.ShowDialog();
            this.Show();
            this.Close();
        }
    }
}
