using System.Data.SqlClient;

namespace LibraryManagementSystem
{
    public partial class FormLogin : Form
    {
        FormBooks formBooks;

        public FormLogin()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DBLibrary;Integrated Security=True;Encrypt=True; 
        Data Source=.\SQLEXPRESS;Initial Catalog=DBLibrary;Integrated Security=True;Encrypt=False");
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string Password = "";

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT Password FROM TableLibraryAdmins WHERE UserName = @p1", connection);
                command.Parameters.AddWithValue("@p1", textBoxUserName.Text);
                SqlDataReader reader = command.ExecuteReader();

                while(reader.Read())
                {
                    Password = reader[0].ToString(); 
                }

                //label3.Text = Password;

                if (Password == textBoxPassword.Text )
                {
                    formBooks = new FormBooks();
                    this.Hide();
                    formBooks.Show();
                }
                else
                {
                    MessageBox.Show("Username or Password is wrong...");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connectoin Error!" + "\n" + ex.Message);
            }
            finally 
            { 
                connection.Close(); 
            }
        }
    }
}
