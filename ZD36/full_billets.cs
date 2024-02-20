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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace ZD36
{
    public partial class full_billets : Form
    {
        public full_billets()
        {
            InitializeComponent();
        }

        database database = new database();

        DataTable table = new DataTable();

        SqlDataAdapter adapter = new SqlDataAdapter();
        int selectedRow;
       

        private void table_bilets() //метод по постороению таблицы на второй вкладке
        {
            dataGridView1.Columns.Add("id", "id");//0
            dataGridView1.Columns.Add("id_seans", "Код расписания");//1
            dataGridView1.Columns.Add("seans", "Код сеанса");//2
            dataGridView1.Columns.Add("gruppa", "Группа");//3
            dataGridView1.Columns.Add("date_seans", "Дата");//4
            dataGridView1.Columns.Add("price", "Цена");//5
            dataGridView1.Columns.Add("sostoyanie", "состояние");//6
            dataGridView1.Columns.Add("card", "4 цифры");//7
            
        }

        private void refresh() //метод по рефрешу таблицы
        {
            ClearRows(dataGridView1);
            SearchBilets(dataGridView1);
            dataGridView1.ClearSelection();
        }


        private void SearchBilets(DataGridView dgw2) //Метод по поиску билетов по состоянию
        {
            string vivods = $"Select Bilets.id, Bilets.id_seans, Bilets.seans, Bilets.gruppa, Bilets.date_seans, Bilets.price, Bilets.sostoyanie, clientbil.card from Bilets join clientbil on Bilets.id = clientbil.id where sostoyanie = 'ожидает оплаты' or sostoyanie = 'подтвержден'";

            SqlCommand com = new SqlCommand(vivods, database.getConnection());

            database.openConnection();

            SqlDataReader read =com.ExecuteReader();

            while (read.Read())
            {
                ReadRowsBilets(dataGridView1, read);
            }

            read.Close();

            database.closeConnection();

        }

        private void ReadRowsBilets(DataGridView dgw3, IDataRecord record)//Вывод для таблицы с билетами
        {
            dgw3.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetInt32(2), record.GetInt32(3), record[4], record.GetString(5), record.GetString(6), record.GetInt32(7));  //Предоставляет значение каждого столбца для строк в таблице

        }

        private void ClearRows(DataGridView dgw3)//Очистка таблицы
        {
            dgw3.Rows.Clear();
        }

        private void full_billets_Load(object sender, EventArgs e)
        {

       


            ClearRows(dataGridView1);
            table_bilets();
            SearchBilets(dataGridView1);
            dataGridView1.ClearSelection();

            textBox4.Visible = false;   
        }




        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        
        Point LastPoint;

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
     

        public void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                textBox1.Text = row.Cells[0].Value.ToString();

                textBox4.Text = row.Cells[4].Value.ToString();

            }
        }


       



        private void Serch(DataGridView dgw3)
        {
            dgw3.Rows.Clear();
            int id = int.Parse(textBox2.Text);
            string vivod = $"Select Bilets.id, Bilets.id_seans, Bilets.seans, Bilets.gruppa, Bilets.date_seans, Bilets.price, Bilets.sostoyanie, clientbil.card from Bilets inner join clientbil on Bilets.id = clientbil.id where Bilets.sostoyanie = 'ожидает оплаты' and Bilets.id = '{id}'or Bilets.sostoyanie = 'подтвержден' and Bilets.id = '{id}'";

            SqlCommand com = new SqlCommand(vivod, database.getConnection());
            database.openConnection();

            SqlDataReader reader = com.ExecuteReader(); 
            while (reader.Read())
            {
                ReadRowsBilets(dgw3, reader);
            }
            reader.Close();

            database.closeConnection();

        }


        private void button3_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void search_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                ClearRows(dataGridView1);
                SearchBilets(dataGridView1);
            }
            else
                Serch(dataGridView1);
            dataGridView1.ClearSelection();
        }


        public void cell_bil()
        {
            database.openConnection();
            int date_bil = int.Parse(textBox4.Text);

            string kolichestvo = $"SELECT kolichestvo FROM cell_bilets where date_raspis = '{date_bil}'";

            SqlCommand kolv = new SqlCommand(kolichestvo, database.getConnection());

            DataSet dataset = new DataSet();

            adapter.SelectCommand = kolv;
            adapter.Fill(dataset);

            dataGridView1.DataSource = dataset.Tables[0];


            database.closeConnection();
        }


        private void podtverd_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Выберите билет");
                return;
            }

            int id_bil = int.Parse(textBox1.Text);// переменная id

            string upd_bil = $"update Bilets set sostoyanie = 'подтвержден' where id = '{id_bil}'";

           

            SqlCommand command2 = new SqlCommand(upd_bil, database.getConnection());

            database.openConnection();// открываем связь с бд

            if (command2.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Билет подтвержден");

            }
            else
            {
                MessageBox.Show("Ошибка :-(");
            }

            database.closeConnection();// закрывай связь с бд

            refresh();
        }

        private void del_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Выберите билет");
                return;
            }

            int id_bil = int.Parse(textBox1.Text);// переменная id         

            string upd_bil_ud = $"update Bilets set sostoyanie = 0 where id = '{id_bil}'";
            string del_bil_ud = $"delete from clientbil where id = '{id_bil}'";

            SqlCommand command1 = new SqlCommand(upd_bil_ud, database.getConnection());
            SqlCommand command2 = new SqlCommand(del_bil_ud, database.getConnection());

            database.openConnection();// открываем связь с бд

            if (command1.ExecuteNonQuery() == 1 && command2.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Билет удален");

            }
            else
            {
                MessageBox.Show("Ошибка :-(");
            }

            database.closeConnection();// закрывай связь с бд
            refresh();
            textBox1.Text = "";
        }
    }
}