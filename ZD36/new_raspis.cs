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

        private void numb_train_TextChanged(object sender, EventArgs e)
        {

        }

        private void num_marsh_TextChanged(object sender, EventArgs e)
        {

        }

        private void init_st_TextChanged(object sender, EventArgs e)
        {

        }

        private void fin_st_TextChanged(object sender, EventArgs e)
        {

        }

        private void time_otpr_TextChanged(object sender, EventArgs e)
        {

        }

        private void time_prib_TextChanged(object sender, EventArgs e)
        {

        }

        private void insert_Click(object sender, EventArgs e)
        {
            if (numb_train.Text == "")
            {
                MessageBox.Show("Введите номер поезда");
                return;
            }
            if (num_marsh.Text == "")
            {
                MessageBox.Show("Введите номер маршрута");
                return;
            }
            if (init_st.Text == "")
            {
                MessageBox.Show("Введите станцию посадки");
                return;
            }
            if (fin_st.Text == "")
            {
                MessageBox.Show("Введите введите станцию высадки");
                return;
            }
            if (time_otpr.Text == "")
            {
                MessageBox.Show("Введите время отправления");
                return;
            }
            if (time_prib.Text == "")
            {
                MessageBox.Show("Введите время прибытия");
                return;
            }
            if (date.Text == "")
            {
                MessageBox.Show("Введите дату поездки");
                return;
            }
            if (vagons.Text == "")
            {
                MessageBox.Show("Введите число вагонов");
                return;
            }

            int train = int.Parse(numb_train.Text);
            int marsh = int.Parse(num_marsh.Text);
            var in_st = init_st.Text;
            var fn_st = fin_st.Text;
            var tm_otpr = time_otpr.Text;
            var tm_prib = time_prib.Text;
            var dt = date.Text;
            var price_tic = price.Text;
            
            int vag = int.Parse(vagons.Text); //преобразование количества билетов из теккстбокса в int
            int mesta = int.Parse(kol_mest.Text); //КОЛИЧЕСТВО МЕСТ В ОДНОМ ВАГОНЕ (берется из вкладки settings)
            
            try
            {
             

                database.openConnection();

               
                //int d = 0;//Переменная для подсчета вагонов

                for (int d = 1; d <= vag; d++)
                {               
                    for (int a = 1; a <= mesta; a++)
                    {
                        string new_bilets = $"insert into [Bilets] (Train, vagon, place, date_poezd, time_otpr, time_prib, sostoyanie, price) values ('{train}', '{d}', '{a}', '{dt}', '{tm_otpr}', '{tm_prib}', 0, '{price_tic}')";
                        SqlCommand command2 = new SqlCommand(new_bilets, database.getConnection());
                        command2.ExecuteNonQuery();

                        /*string new_raspis = $"INSERT INTO [raspis] (id_train, num_mursh, initial_station, final_station, time_otpr, time_prib, date) values('{train}', '{marsh}', '{in_st}', '{fn_st}', '{tm_otpr}', '{tm_prib}', '{dt}')";
                        SqlCommand command = new SqlCommand(new_raspis, database.getConnection());
                        command.ExecuteNonQuery();*/
                    }
                }

                string new_raspis = $"INSERT INTO [raspis] (id_train, num_mursh, initial_station, final_station, time_otpr, time_prib, date) values('{train}', '{marsh}', '{in_st}', '{fn_st}', '{tm_otpr}', '{tm_prib}', '{dt}')";
                SqlCommand command = new SqlCommand(new_raspis, database.getConnection());
                command.ExecuteNonQuery();


                database.closeConnection();
            }

            catch
            {
                MessageBox.Show("Ошибка, проверьте правильность заполнения");
            }

            
           
        }

        /*if (command2.ExecuteNonQuery() == 1)
  {
    MessageBox.Show("Билеты добавленны ");
  }

  else
  {
    MessageBox.Show("Ошибка");
  }*/

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void vibor_ud_TextChanged(object sender, EventArgs e)
        {

        }

        private void vibor_ras_TextChanged(object sender, EventArgs e)
        {

        }

        private void dellete_Click(object sender, EventArgs e)
        {
            if (vibor_ras.Text == "")
            {
                MessageBox.Show("Введите номер строки расписания");
                return;
            }
            var id_ras = vibor_ras.Text;


            string del_ras = $"DELETE FROM raspis where id = {id_ras}";
            SqlCommand command = new SqlCommand(del_ras, database.getConnection());

            database.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Строка успешно удалена");
            }
            else
            {
                MessageBox.Show("Ошибка");
            }
            database.closeConnection();
        }

        private void date_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bilets_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch !=8)
            {
                e.Handled = true;
            }
           
        }

        private void numb_train_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void num_marsh_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void kol_mest_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void label_mest_Click(object sender, EventArgs e)
        {

        }

        private void label_mest_TextChanged(object sender, EventArgs e)
        {

        }

        private void new_raspis_LocationChanged(object sender, EventArgs e)
        {

        }

        private void new_raspis_Load(object sender, EventArgs e)
        {


            
           
        }

        private void kol_biletov_Click(object sender, EventArgs e)
        {
            if (vagons.Text == "" || kol_mest.Text == "")
            {
                MessageBox.Show("Введите количество вагонов (Мест в вагоне)");
                return;
            }
            else
            {
                int vag = int.Parse(vagons.Text); //преобразование количества билетов из текстбокса в int
                int mesta = int.Parse(kol_mest.Text); //КОЛИЧЕСТВО МЕСТ В ОДНОМ ВАГОНЕ (берется из вкладки settings)

                int numb_sits = vag * mesta;

                label_mest.Text = numb_sits.ToString();
            }
        }
    }

}
