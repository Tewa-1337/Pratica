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

namespace mishaninprjc
{
    public partial class delAchForm : Form
    {
        public delAchForm()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            mainform mainform = new mainform();
            mainform.Show();
            Close();
        }
        public string host = "localhost"; // Имя хоста
        public string database = "mydb3"; // Имя базы данных
        public string user = "root"; // Имя пользователя
        public string password = "TryMi1640"; // Пароль пользователя
        private void delButton_Click(object sender, EventArgs e)
        {
            string Connect = "Database=" + database + ";Datasource=" + host + ";User=" + user + ";Password=" + password;
            MySqlConnection mysql_connection = new MySqlConnection(Connect);
            MySqlCommand mysql_query = mysql_connection.CreateCommand();
            mysql_query.CommandText = $"delete from `достижения` where Номер = @id;";
            mysql_query.Parameters.Add("@id", MySqlDbType.Int32).Value = numberToDelTB.Text;
            mysql_connection.Open();
            try
            {
                if (mysql_query.ExecuteNonQuery() == 1) MessageBox.Show("Ok");
                mysql_connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void numberToDelTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
