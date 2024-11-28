using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kekw
{
    public partial class Login : Form
    {
        private const string placeholderUsername = "Type your username";
        private const string placeholderPassword = "Type your password";
        public Login()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = new User();

            string username = txtUsername.Text.ToLower();
            string password = txtPassword.Text;

            if(user.InputValidator(txtUsername.Text, placeholderUsername))
            {
                MessageBox.Show("Username is required. Please enter your username");
                txtUsername.Focus();
            }
            else if (user.InputValidator(txtPassword.Text, placeholderPassword))
            {
                MessageBox.Show("Password is required. Please enter your password");
                txtPassword.Focus();
            }
            else
            {
                User Authenticate = new User(@"Data Source=DELL-PC\SQLEXPRESS;Initial Catalog=IOOP_Assignment;Integrated Security=True");
                string role = Authenticate.AuthenticateUser(username, password);
                if (role != null)
                {
                    MainMenu menu = new MainMenu(username, role);
                    menu.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid username and/or password entered");
                }
            }
        }
        private void txtUsername_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == placeholderUsername)
            {
                txtUsername.Text = " ";
                txtUsername.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            if(txtPassword.Text == placeholderPassword)
            {
                txtPassword.PasswordChar = '*';
                txtPassword.Clear();
                txtPassword.ForeColor = Color.Black;
            }
            
        }

        private void lblForgot_Click(object sender, EventArgs e)
        {
            ChangePassword fPassword = new ChangePassword();
            fPassword.ShowDialog();
        }

        private void lblForgot_MouseEnter(object sender, EventArgs e)
        {
            lblForgot.Font = new Font(lblForgot.Font.Name, lblForgot.Font.SizeInPoints, FontStyle.Underline);
        }

        private void lblForgot_MouseLeave(object sender, EventArgs e)
        {
            lblForgot.Font = new Font(lblForgot.Font.Name, lblForgot.Font.SizeInPoints, FontStyle.Regular);
        }

        private void lblSignUp_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.ShowDialog();
        }

        private void uncensorIcon_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = (txtPassword.Text != "Type your password") ? '*' : '\0';
            censorIcon.Visible = true;
        }

        private void censorIcon_Click(object sender, EventArgs e)
        {

            txtPassword.PasswordChar = '\0';
            censorIcon.Visible = false;
        }
    }
}
