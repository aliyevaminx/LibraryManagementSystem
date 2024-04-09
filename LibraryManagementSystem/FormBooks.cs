using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class FormBooks : Form
    {
        public FormBooks()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DBLibrary;Integrated Security=True;Encrypt=True; 
        Data Source=.\SQLEXPRESS;Initial Catalog=DBLibrary;Integrated Security=True;Encrypt=False");

        private void showDatas()
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM TableBooks";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error!" + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void FormBooks_Load(object sender, EventArgs e)
        {
            showDatas();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO TableBooks " +
                    "(BookName, WriterName, WriterSurname, ISBN, BookStatus, BookGenreCode)" +
                    "VALUES (@P1, @P2, @P3,@P4 ,@P5 ,@P6)", connection);

                sqlCommand.Parameters.AddWithValue("@P1", textBoxBookName.Text);
                sqlCommand.Parameters.AddWithValue("@P2", textBoxWriterName.Text);
                sqlCommand.Parameters.AddWithValue("@P3", textBoxWriterSur.Text);
                sqlCommand.Parameters.AddWithValue("@P4", textBoxISBN.Text);
                sqlCommand.Parameters.AddWithValue("@P5", "True");
                sqlCommand.Parameters.AddWithValue("@P6", textBoxGenreCode.Text);

                sqlCommand.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Errror!" + "\n" + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            showDatas();



        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            labelDelayFee.Text = "0";

            int selectedLine = dataGridView1.SelectedCells[0].RowIndex;
            labelID.Text = dataGridView1.Rows[selectedLine].Cells[0].Value.ToString();
            textBoxBookName.Text = dataGridView1.Rows[selectedLine].Cells[1].Value.ToString();
            textBoxWriterName.Text = dataGridView1.Rows[selectedLine].Cells[2].Value.ToString();
            textBoxWriterSur.Text = dataGridView1.Rows[selectedLine].Cells[3].Value.ToString();
            textBoxISBN.Text = dataGridView1.Rows[selectedLine].Cells[4].Value.ToString();
            textBoxGenreCode.Text = dataGridView1.Rows[selectedLine].Cells[8].Value.ToString();

            textBoxCustomer.Text = dataGridView1.Rows[selectedLine].Cells[6].Value.ToString();

            if (dataGridView1.Rows[selectedLine].Cells[7].Value != DBNull.Value)
                dateTimePicker1.Value = (DateTime)dataGridView1.Rows[selectedLine].Cells[7].Value;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("UPDATE TableBooks SET BookName = @P1, WriterName = @P2, WriterSurname = @P3, ISBN = @P4, BookGenreCode = @P5 WHERE ID = @P6", connection);

                sqlCommand.Parameters.AddWithValue("@P1", textBoxBookName.Text);
                sqlCommand.Parameters.AddWithValue("@P2", textBoxWriterName.Text);
                sqlCommand.Parameters.AddWithValue("@P3", textBoxWriterSur.Text);
                sqlCommand.Parameters.AddWithValue("@P4", textBoxISBN.Text);
                sqlCommand.Parameters.AddWithValue("@P5", textBoxGenreCode.Text);
                sqlCommand.Parameters.AddWithValue("@P6", labelID.Text);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error!" + "\n" + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            showDatas();
        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (labelID.Text != "-")
            {

                try
                {
                    connection.Open();
                    SqlCommand sqlCommand = new SqlCommand("UPDATE TableBooks SET BookStatus = @P1, Borrower = @P2, BorrowingTime = @P3 WHERE ID = @P4", connection);

                    sqlCommand.Parameters.AddWithValue("@P1", "False");
                    sqlCommand.Parameters.AddWithValue("@P2", textBoxCustomer.Text);
                    sqlCommand.Parameters.Add("@P3", SqlDbType.Date).Value = dateTimePicker1.Value.Date;
                    sqlCommand.Parameters.AddWithValue("@P4", labelID.Text);

                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection Error!" + "\n" + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
                showDatas();
            }
            else
            {
                MessageBox.Show("Choose a book from list!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                if (labelID.Text != "-")
                {
                    DateTime borrowTime = dateTimePicker1.Value;
                    DateTime returnTime = DateTime.Now;
                    int timeDifference = (int)(returnTime - borrowTime).TotalDays;

                    if (timeDifference > 10)
                    {
                        int delayFee = (int)(timeDifference * 0.5);
                        labelDelayFee.Text = delayFee + " " + "$";
                    }
                    else
                    {
                        labelDelayFee.Text = "No Delay Fee";
                    }

                }
                else
                {
                    MessageBox.Show("Please choose a book from list.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something is wrong!" + "\n" + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (labelID.Text != "-")
            {
                try
                {
                    connection.Open();
                    SqlCommand sqlCommand = new SqlCommand("UPDATE TableBooks SET BookStatus = @P1, Borrower = @P2, BorrowingTime = @P3 WHERE ID = @P4", connection);

                    sqlCommand.Parameters.AddWithValue("@P1", "True");
                    sqlCommand.Parameters.AddWithValue("@P2", " ");
                    sqlCommand.Parameters.Add("@P3", SqlDbType.Date).Value = DBNull.Value;
                    sqlCommand.Parameters.AddWithValue("@P4", labelID.Text);

                    sqlCommand.ExecuteNonQuery();
                    labelDelayFee.Text = "0";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection Error!" + "\n" + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
                showDatas();
            }
        }

        private void showSearchedBooks()
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM TableBooks WHERE BookName LIKE '" + textBoxBookName.Text + "%'"
                    + " AND WriterName LIKE '" + textBoxWriterName.Text + "%'"
                    + " AND WriterSurname LIKE '" + textBoxWriterSur.Text + "%'"
                    + " AND ISBN LIKE '" + textBoxISBN.Text + "%'"
                    + " AND Borrower LIKE '" + textBoxCustomer.Text + "%'"
                    + " AND BookGenreCode LIKE '" + textBoxGenreCode.Text + "%'";

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error!" + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            showSearchedBooks();
        }

        public void buttonClear_Click(object sender, EventArgs e)
        {
            clearText();
        }

        public void clearText()
        {
            labelID.Text = "-";
            textBoxBookName.Text = "";
            textBoxWriterName.Text = "";
            textBoxWriterSur.Text = "";
            textBoxISBN.Text = "";
            textBoxCustomer.Text = "";
            textBoxGenreCode.Text = "";
        }

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            showDatas();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (labelID.Text != "-")
            {
                try
                {
                    connection.Open();
                    SqlCommand sqlCommand = new SqlCommand("DELETE FROM TableBooks WHERE ID = @P1", connection);
                    sqlCommand.Parameters.AddWithValue("@P1", labelID.Text);

                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection Error!" + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
                showDatas();
                clearText();
            }

        }

        private void FormBooks_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
