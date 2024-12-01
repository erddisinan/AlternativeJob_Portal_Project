using System;
using System.Windows.Forms;

namespace Std_Job
{
    public partial class RegisterPage : Form
    {
        public RegisterPage()
        {
            InitializeComponent();
            passwordRegisterArea.PasswordChar = '*';
            confirmPasswordArea.PasswordChar = '*';
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void RegistirationButton_Click(object sender, EventArgs e)
        {
            // Get user inputs
            string username = idEntryArea.Text.Trim();
            string password = passwordRegisterArea.Text.Trim();
            string confirmPassword = confirmPasswordArea.Text.Trim();

            // Validation
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("All fields are required.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if username already exists
            if (LoginPage.users.Exists(u => u.Username == username))
            {
                MessageBox.Show("Username already exists.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Determine user role based on username length(like our school) ternany operator
            string role = username.Length == 8 ? "Admin" : "Student";

            // Add user to list
            if (role == "Admin")
            {
                LoginPage.users.Add(new Admin(username, password));
            }
            else if (role == "Student")
            {
                LoginPage.users.Add(new Student(username, password));
            }

            MessageBox.Show("Registration successful! You can now log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Navigate back to LoginPage
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Hide();
        }

        private void idEntryArea_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
