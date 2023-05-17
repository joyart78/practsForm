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
    public partial class maneForm : Form
    {
        private SqlConnection sqlConnection = null;
        private SqlCommandBuilder sqlBuilder = null;
        private SqlDataAdapter sqlDataAdapter = null;
        private DataSet dataSet = null;
        private bool newRowAdding = false;
        


        public maneForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadData()
        {
            try
            {
                sqlDataAdapter = new SqlDataAdapter("SELECT *, 'Delete' AS [Command] FROM WebPassword", sqlConnection);
                sqlBuilder = new SqlCommandBuilder(sqlDataAdapter);

                sqlBuilder.GetInsertCommand();
                sqlBuilder.GetUpdateCommand();
                sqlBuilder.GetDeleteCommand();

                dataSet = new DataSet();

                sqlDataAdapter.Fill(dataSet, "WebPassword");

                dataGridView1.DataSource = dataSet.Tables["WebPassword"];

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    dataGridView1[4, i] = linkCell;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ReloadData()
        {
            try
            {
                dataSet.Tables["WebPassword"].Clear();

                sqlDataAdapter.Fill(dataSet, "WebPassword");

                dataGridView1.DataSource = dataSet.Tables["WebPassword"];

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    dataGridView1[4, i] = linkCell;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void maneForm_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\practsForm\practsForm\Database1.mdf;Integrated Security=True");
            sqlConnection.Open();

            LoadData();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 4)
                {
                    string task = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

                    if (task == "Delete")
                    {
                        if (MessageBox.Show("Удалить эту строку?","Удаление",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            int rowIndex = e.RowIndex;

                            dataGridView1.Rows.RemoveAt(rowIndex);

                            dataSet.Tables["WebPassword"].Rows[rowIndex].Delete();

                            sqlDataAdapter.Update(dataSet, "WebPassword");
                        }
                    }
                    //if (task == "Insert")
                    //{


                    //    int rowIndex = dataGridView1.Rows.Count - 2;

                    //    DataRow row = dataSet.Tables["WebPassword"].NewRow();

                    //    row["webName"] = dataGridView1.Rows[rowIndex].Cells["webName"].Value;
                    //    row["login"] = dataGridView1.Rows[rowIndex].Cells["login"].Value;
                    //    row["password"] = dataGridView1.Rows[rowIndex].Cells["password"].Value;

                    //    dataSet.Tables["WebPassword"].Rows.Add(row);

                    //    dataSet.Tables["WebPassword"].Rows.RemoveAt(dataSet.Tables["WebPassword"].Rows.Count - 1);

                    //    dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count - 2);

                    //    dataGridView1.Rows[e.RowIndex].Cells[4].Value = "Delete";

                    //    sqlDataAdapter.Update(dataSet, "WebPassword");

                    //    newRowAdding = false;
                    //}
                    if (task == "Update")
                    {
                        int r = e.RowIndex;

                        dataSet.Tables["WebPassword"].Rows[r]["webName"] = dataGridView1.Rows[r].Cells["webName"].Value;
                        dataSet.Tables["WebPassword"].Rows[r]["login"] = dataGridView1.Rows[r].Cells["login"].Value;
                        dataSet.Tables["WebPassword"].Rows[r]["password"] = dataGridView1.Rows[r].Cells["password"].Value;

                        sqlDataAdapter.Update(dataSet, "WebPassword");

                        dataGridView1.Rows[e.RowIndex].Cells[4].Value = "Delete";
                    }
                    ReloadData();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        //{
        //    try
        //    {
        //        if (newRowAdding == false)
        //        {
        //            newRowAdding = true;

        //            int lastRow = dataGridView1.Rows.Count - 2;

        //            DataGridViewRow row = dataGridView1.Rows[lastRow];

        //            DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

        //            dataGridView1[4, lastRow] = linkCell;

        //            row.Cells["Command"].Value = "Insert";
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (newRowAdding == false)
                {
                    int rowIndex = dataGridView1.SelectedCells[0].RowIndex;

                    DataGridViewRow editingRow = dataGridView1.Rows[rowIndex];

                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    dataGridView1[4, rowIndex] = linkCell;

                    editingRow.Cells["Command"].Value = "Update";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"webName LIKE '%{textBox1.Text}%'";
        }

        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        public Boolean isUserExists()
        {

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            int rowIndex = dataGridView1.SelectedCells[0].RowIndex;


            SqlCommand command = new SqlCommand("SELECT * FROM `WebPassword` WHERE `webName` = @uN", sqlConnection);
            command.Parameters.Add("@uN", SqlDbType.VarChar).Value = dataGridView1[1, rowIndex].Value;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("такой логин уже зарегестрирован");
                return true;
            }
            else
                return false;
        }

        private void insertButton_Click(object sender, EventArgs e)
        {

            InsertForm insertForm = new InsertForm();


            insertForm.Show();

        }
    }
}
