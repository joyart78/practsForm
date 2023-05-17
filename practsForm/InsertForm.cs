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

namespace practsForm
{
    public partial class InsertForm : Form
    {

        private SqlConnection sqlConnection = null;

        public InsertForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonInsrt_Click(object sender, EventArgs e)
        {
            if (webName.Text == "")
            {
                MessageBox.Show("Введите название");
                return;
            }

            if (loginText.Text == "")
            {
                MessageBox.Show("Введите логин");
                return;
            }

            if (passName.Text == "")
            {
                MessageBox.Show("Введите пароль");
                return;
            }

            if (isUserExists())
            {
                return;
            }


            sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\practsForm\practsForm\Database1.mdf;Integrated Security=True");

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;

            command.CommandText = "INSERT INTO WebPassword (webName, login, password) VALUES (@name, @login, @pass)";


            command.Parameters.Add("@name", SqlDbType.VarChar).Value = nameText.Text;
            command.Parameters.Add("@login", SqlDbType.VarChar).Value = loginText.Text;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = passName.Text;

            command.Connection = sqlConnection;

            sqlConnection.Open();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("добавлен");
            else
                MessageBox.Show("не получилось добавить");

            sqlConnection.Close();

            this.Close();
        }

        public Boolean isUserExists()
        {
            sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\practsForm\practsForm\Database1.mdf;Integrated Security=True");


            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand("SELECT * FROM WebPassword WHERE webName = @uN", sqlConnection);
            command.Parameters.Add("@uN", SqlDbType.VarChar).Value = nameText.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("такое название уже существует");
                return true;
            }
            else
                return false;
        }
    }
}
