using System;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Std_Job
{
    public partial class LoginPage : Form
    {
        // List to store users
        public static List<User> users = new List<User>();
        private User currentUser; // Store the current logged-in user

        public LoginPage()
        {
            InitializeComponent();
            passwordEntryArea.PasswordChar = '*';
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = nameEntryArea.Text.Trim();
            string password = passwordEntryArea.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Find matching user
            currentUser = users.Find(u => u.Username == username && u.Password == password);

            if (currentUser != null)
            {
                MessageBox.Show("Login successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Open role-specific page and pass the current user
                if (currentUser.Role == "Admin")
                {
                    AdminPage adminPage = new AdminPage(currentUser); // Pass current user to AdminPage
                    adminPage.Show();
                }
                else if (currentUser.Role == "Student")
                {
                    StudentPage studentPage = new StudentPage(currentUser); // Pass current user to StudentPage
                    studentPage.Show();
                }

                this.Hide(); // Hide login form
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            RegisterPage registerPage = new RegisterPage();
            registerPage.Show();
            this.Hide();
        }
    }
}


