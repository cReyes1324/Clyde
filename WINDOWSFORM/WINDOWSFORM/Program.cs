using System;
using System.Windows.Forms;

namespace YourNamespace
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Basic validation
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            // Check username and password (you would replace this with your actual authentication logic)
            if (username == "admin" && password == "password")
            {
                MessageBox.Show("Login successful!");
                // Open main application window or perform other actions
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

        private void linkSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Open sign-up form
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.ShowDialog();
        }
    }

    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Basic validation
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            // Perform sign-up logic (you would replace this with your actual sign-up logic)
            // For simplicity, let's just display the entered credentials
            MessageBox.Show($"Signed up with username: {username} and password: {password}");

            // Close the sign-up form
            this.Close();
        }
    }
}
