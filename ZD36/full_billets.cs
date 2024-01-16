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
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("Train", "Номер Поезда:");
            dataGridView1.Columns.Add("vagon", "Вагон:");
            dataGridView1.Columns.Add("place", "Место");
            dataGridView1.Columns.Add("data_poezd", "Дата");
            dataGridView1.Columns.Add("time_otpr", "Отправление");
            dataGridView1.Columns.Add("time_prib", "Прибытие");
            dataGridView1.Columns.Add("sostoyanie", "Состояние:");
            dataGridView1.Columns.Add("price", "Цена");
            dataGridView1.Columns.Add("number_reys", "Номер рейса");
            dataGridView1.Columns.Add("IsNew", String.Empty);
        }

        private void SearchBilets(DataGridView dgw2) //Метод по поиску билетов по выбранному маршруту
        {
            string vivods = $"Select * from Bilets where sostoyanie = 1 or sostoyanie = 2";

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
            dgw3.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetInt32(2), record.GetInt32(3), record[4], record[5], record[6], record.GetInt32(7), record.GetString(8), record.GetInt32(9));  ///Предоставляет значение каждого столбца для строк в таблице
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


            /* database.openConnection();

             string vivod = $"SELECT * FROM Bilets";

             SqlCommand command = new SqlCommand(vivod, database.getConnection());

             DataSet dataset = new DataSet();

             adapter.SelectCommand = command;
             adapter.Fill(dataset);

             dataGridView1.DataSource = dataset.Tables[0];

             database.closeConnection();*/
        }




        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void na_glavn_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ClearRows(dataGridView1);
            SearchBilets(dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                textBox1.Text = row.Cells[0].Value.ToString();

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
            int id_bil = int.Parse(textBox1.Text);// переменная id

            string upd_bil = $"update Bilets set sostoyanie = 2 where id = '{id_bil}'";

            SqlCommand command2 = new SqlCommand(upd_bil, database.getConnection());

            database.openConnection();// открываем связь с бд

            if ( command2.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Билет подтвержден");
                
            }
            else
            {
                MessageBox.Show("Ошибка :-(");
            }

            database.closeConnection();// закрывай связь с бд

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            int id_bil = int.Parse(textBox1.Text);// переменная id         

            string upd_bil = $"update Bilets set sostoyanie = 0 where id = '{id_bil}'";
            string del_bil = $"delete from clientbil where id = '{id_bil}'";

            SqlCommand command1 = new SqlCommand(upd_bil, database.getConnection());
            SqlCommand command2 = new SqlCommand(del_bil, database.getConnection());

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
        }
    }
}