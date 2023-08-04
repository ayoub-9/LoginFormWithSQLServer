using System.Data.SqlClient;

namespace LoginForm
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            // Disable automatic focus on usernameText + passwordText
            usernameText.TabStop = false;
            passwordText.TabStop = false;

        }

        private void Login_Load(object sender, EventArgs e)
        {


        }
     

        private void button1_Click(object sender, EventArgs e)
        {
            string username = usernameText.Text;
            string password = passwordText.Text;

            bool isMatch = CheckCredentials(username, password);

            if (isMatch)
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Home thehome = new Home();
                thehome.Show();
                

            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        static bool CheckCredentials(string username, string password)
        {
            // Replace with your actual connection string
            string connectionString = "Data Source=DESKTOP-UUBPBQN;Initial Catalog=users;User ID=admin;Password=admin;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Prepare the SQL query
                    string query = "SELECT COUNT(*) FROM [users].[dbo].[user] WHERE username = @Username AND password = @Password;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Replace "Users" with the actual name of the table where user credentials are stored
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        int count = (int)command.ExecuteScalar();

                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions if any occur during the process
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}