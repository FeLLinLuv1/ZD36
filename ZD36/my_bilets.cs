using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ZD36
{
    public partial class my_bilets : Form
    {
        database database = new database();
        DataTable table = new DataTable();
        SqlDataAdapter adapter = new SqlDataAdapter();

        int selectedRow;

        public my_bilets()
        {
            InitializeComponent();
        }

        private void table_bilets() //метод по постороению таблицы на второй вкладке
        {
           
            dataGridView1.Columns[0].HeaderText = "id";//0
            dataGridView1.Columns[1].HeaderText = "Код расписания";//1
            dataGridView1.Columns[2].HeaderText = "Код сеанса";//2
            dataGridView1.Columns[3].HeaderText = "Группа";//3
            dataGridView1.Columns[4].HeaderText = "Дата";//4
            dataGridView1.Columns[5].HeaderText = "Цена";//5
            dataGridView1.Columns[6].HeaderText = "Cостояние";//6
            dataGridView1.Columns[7].HeaderText = "4 цифры";//7
            dataGridView1.Columns[8].HeaderText = "Время начала";//8
        }

        private void kartinka()//создание qr_кода, помещенного в pictriurebox1
        {
           
        }

        private void my_bilets_Load(object sender, EventArgs e)
        {
            sostoy.Visible=false;//скрываем лабель состояния

            panel3.Visible = false;

            dataGridView1.ClearSelection();

            pictureBox2.Visible = false;    

            database.openConnection();

            string moi_bil = DataBank.Login_pols;

            string vivods = $"Select Bilets.id, Bilets.id_seans, Bilets.seans, Bilets.gruppa, Bilets.date_seans, Bilets.price, Bilets.sostoyanie, clientbil.card, seans.time_start from Bilets, clientbil, seans where (Bilets.id = clientbil.id and Bilets.seans = seans.number_seans) and (clientbil.loginn = '{moi_bil}' and sostoyanie = 'ожидает оплаты' or clientbil.loginn = '{moi_bil}' and sostoyanie = 'подтвержден');";

            SqlCommand command = new SqlCommand(vivods, database.getConnection());

            DataSet dataset = new DataSet();

            adapter.SelectCommand = command;
            adapter.Fill(dataset);
            dataGridView1.DataSource = dataset.Tables[0];
            
            database.closeConnection();

            table_bilets();
        }

        private void ClearRows(DataGridView dgw3)
        {
            dgw3.Rows.Clear();
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                textBox2.Text = $"bilet id: {row.Cells[0].Value.ToString()}";

                id_bilet.Text = $"{row.Cells[0].Value.ToString()}";
                id_raspis.Text = $"{row.Cells[1].Value.ToString()}";
                id_seansa.Text = $"{row.Cells[2].Value.ToString()}";
                gruppa.Text = $"{row.Cells[3].Value.ToString()}";
                data.Text = $"{row.Cells[4].Value.ToString()}";
                time.Text = $"{row.Cells[8].Value.ToString()}";
                price.Text = $"{row.Cells[5].Value.ToString()}";

                sostoy.Text = $"{row.Cells[6].Value.ToString()}";//заполняем лабель дл проверки состояния


                string text = data.Text; // получаем текущий текст из label
                if (!string.IsNullOrEmpty(text))
                {
                    text = text.Remove(text.Length - 8); // удаляем последние символ
                    data.Text = text; // обновляем текст в label
                }

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            kartinka();
        }

        public Bitmap screenshot()
        {
            // запоминаем размеры контрола
            Size szCurrent = panel3.Size;
            //ресайзим контрол до возможного максимума перед скриншотом
            panel3.AutoSize = true;

            //создаем картинку нужных размеров
            Bitmap bmp = new Bitmap(panel3.Width, panel3.Height);

            //копируем изображение нужного контрола в bmp
            panel3.DrawToBitmap(bmp, panel3.ClientRectangle);

            //возвращаем изначальные настройки контрола
            panel3.AutoSize = false;
            panel3.Size = szCurrent;

            /* return bmp;*/

            pictureBox2.Image = bmp;

            return bmp;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Сначала выберите билет!");
                return;
            }
            if (sostoy.Text != "подтвержден")
            {
                MessageBox.Show("Оплата билета должна быть подтверждена!");
                return;
            }

            screenshot();

            System.Windows.Forms.SaveFileDialog save = new System.Windows.Forms.SaveFileDialog(); // save будет запрашивать у пользователя, место, в которое он захочет сохранить файл. 
            save.Filter = "PNG|*.png"; //создаём фильтр, который определяет, в каких форматах мы сможем сохранить нашу информацию. В данном случае выбираем форматы изображений. Записывается так: "название_формата_в обозревателе|*.расширение_формата")
            if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK) //если пользователь нажимает в обозревателе кнопку "Сохранить".
            {
                // Проверка на окончание файла
                if (Path.GetExtension(save.FileName) != ".png")
                {
                    MessageBox.Show("Фото должно быть в формате PNG");
                }
                else
                {
                    // Загрузка фото
                    pictureBox2.Image.Save(save.FileName); //изображение из pictureBox'a сохраняется под именем, которое введёт пользователь
                    MessageBox.Show("Билет сохранен!");
                }
            }
        
        
          
            









            /* bilet mar = new bilet();
             this.Hide();
             mar.ShowDialog();
             this.Show();*/

        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_DataBindingComplete_1(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.sberbank.com/sms/pbpn?requisiteNumber=79102458285");
        }
    }
}
