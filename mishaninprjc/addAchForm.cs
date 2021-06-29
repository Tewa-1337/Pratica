using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace mishaninprjc
{
    public partial class addAchForm : Form
    {
        public addAchForm()
        {
            InitializeComponent();
        }
        public string host = "localhost"; // Имя хоста
        public string database = "mydb3"; // Имя базы данных
        public string user = "root"; // Имя пользователя
        public string password = "TryMi1640"; // Пароль пользователя
        private void backButton_Click(object sender, EventArgs e)
        {
            mainform mainform = new mainform();
            mainform.Show();
            Close();
        }

        private void typeTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void descTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void pointTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string Connect = "Database=" + database + ";Datasource=" + host + ";User=" + user + ";Password=" + password;
            MySqlConnection mysql_connection = new MySqlConnection(Connect);
            MySqlCommand mysql_query = mysql_connection.CreateCommand();
            mysql_query.CommandText = $"insert into `достижения` (`Тип_достижения`,`Название`,`Описание`,`Очки`) values (@type, @name, @desc, @point);";
            mysql_query.Parameters.Add("@type", MySqlDbType.VarChar).Value = typeTB.Text;
            mysql_query.Parameters.Add("@name", MySqlDbType.VarChar).Value = nameTB.Text;
            mysql_query.Parameters.Add("@desc", MySqlDbType.VarChar).Value = descTB.Text;
            mysql_query.Parameters.Add("@point", MySqlDbType.VarChar).Value = pointTB.Text;
            try
            {
                if (mysql_query.ExecuteNonQuery() == 1) MessageBox.Show("Достижение добавлено");
                mysql_connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
