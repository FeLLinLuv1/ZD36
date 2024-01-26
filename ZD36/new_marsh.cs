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
    public partial class new_marsh : Form
    {
        database database = new database();
        public new_marsh()
        {
            InitializeComponent();
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

        private void na_glavn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void close_but_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void prib_TextChanged(object sender, EventArgs e)
        {

        }

        private void otpr_TextChanged(object sender, EventArgs e)
        {

        }

        private void insert_Click(object sender, EventArgs e)
        {

            if (numb_marsh.Text == "")
            {
                MessageBox.Show("Введите номер маршрута");
                return;
            }
            if (otpr.Text == "")
            {
                MessageBox.Show("Введите станцию отправления");
                return;
            }
            if (prib.Text == "")
            {
                MessageBox.Show("Введите конечную станцию");
                return;
            }
            if (est_li_pols())
                return;

            var otprav = otpr.Text;
            var pribit = prib.Text;
            var numb = numb_marsh.Text;


            string new_marsh = $"INSERT INTO [Ways] (Station_departure, Station_arrival, num_marsh) values('{otprav}', '{pribit}', '{numb}')";
            SqlCommand command = new SqlCommand(new_marsh, database.getConnection());

            database.openConnection();

            if(command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Маршрут успешно добавлен"); 
            }

            else
            {
                MessageBox.Show("Ошибка");
            }
            database.closeConnection();
        }

        ///Проверка на наличие маршрута
       
        public Boolean est_li_pols()
        {
            database database = new database();

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            var number = numb_marsh.Text; /// ПРЕОБРАЗОВАНИЕ ИЗ ДАННЫХ ТЕКСТБОКСА В ПЕРЕМЕННУЮ
            
            string poiskmarsh = $"SELECT * FROM Ways WHERE num_marsh = '{number}'";
            SqlCommand command = new SqlCommand(poiskmarsh, database.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);
            
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой маршрут уже существует");
                return true;
            }
            else
                return false;
        }

        private void numb_marsh_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (vibor_ud.Text == "")
            {
                MessageBox.Show("Введите номер маршрута");
                return;
            }
            var mr = vibor_ud.Text;


            string del_mr = $"DELETE FROM Ways where num_marsh = {mr}";
            SqlCommand command = new SqlCommand(del_mr, database.getConnection());

            database.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Маршрут успешно удален");
            }
            else
            {
                MessageBox.Show("Ошибка");
            }
            database.closeConnection();
        }

        private void vibor_ud_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
