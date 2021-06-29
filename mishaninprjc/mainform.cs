using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace mishaninprjc
{
   
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
            string Connect = "Database=" + database + ";Datasource=" + host + ";User=" + user + ";Password=" + password;
            MySqlConnection mysql_connection = new MySqlConnection(Connect);
            MySqlCommand mysql_query = mysql_connection.CreateCommand();
            mysql_query.CommandText = "select * from `достижения`";
            mysql_connection.Open();
            MySqlDataReader mySqlDataReader = mysql_query.ExecuteReader();
            try
            {
                while (mySqlDataReader.Read())
                {
                    dataGridView1.Rows.Add(mySqlDataReader["Тип_достижения"].ToString(),
                                           mySqlDataReader["Название"].ToString(),
                                           mySqlDataReader["Описание"].ToString(),
                                           mySqlDataReader["Очки"].ToString(), 
                                           mySqlDataReader["Номер"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка");
            }
            finally
            {
                mysql_connection.Close();
            }
        }
        public string host = "localhost"; // Имя хоста
        public string database = "mydb3"; // Имя базы данных
        public string user = "root"; // Имя пользователя
        public string password = "TryMi1640"; // Пароль пользователя
        private void delachButton_Click(object sender, EventArgs e)
        {
            delAchForm delAchForm = new delAchForm();
            delAchForm.Show();
            Hide();
        }

        private void addachButton_Click(object sender, EventArgs e)
        {
            addAchForm addAchForm = new addAchForm();
            addAchForm.Show();
            Hide();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form1 authform = new Form1();
            authform.Show();
            Close();      
         }

        private void statButton_Click(object sender, EventArgs e)
        {
            statForm statForm = new statForm();
            statForm.Show();
            Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
    public class Log
    {
        public static void Logger(string text)
        {
            string path = "C:\\log.txt";
            File.AppendAllText(path, text + " " + DateTime.Now + "\n");

        }
    }
}
