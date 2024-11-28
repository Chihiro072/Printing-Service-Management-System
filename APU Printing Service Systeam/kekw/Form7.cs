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
    public partial class Register : Form
    {
        private const string placeholderUsername = "Type your username";
        private const string placeholderPassword = "Type your password";
        private const string placeholderVerify = "Type your password again";
        private const string placeholderEmail = "Type your email";
        private const string placeholderAddress = "Type your address";
        User user = new User(@"Data Source=Dell-PC\SQLEXPRESS;Initial Catalog=IOOP_Assignment;Integrated Security=True");

        public Register()
        {
            InitializeComponent();
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
            if (txtPassword.Text == placeholderPassword)
            {
                txtPassword.PasswordChar = '*';
                txtPassword.Clear();
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void txtVerify_Click(object sender, EventArgs e)
        {
            if (txtVerify.Text == placeholderVerify)
            {
                txtVerify.PasswordChar = '*';
                txtVerify.Clear();
                txtVerify.ForeColor = Color.Black;
            }
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == placeholderEmail)
            {
                txtEmail.Text = " ";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtAddress_Click(object sender, EventArgs e)
        {
            if (txtAddress.Text == placeholderAddress)
            {
                txtAddress.Text = " ";
                txtAddress.ForeColor = Color.Black;
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.ToLower();
            string password = txtPassword.Text;
            string verify = txtVerify.Text;
            string role = cboRole.Text;
            string gender = null;
            if (rdoMale.Checked)
            {
                gender = "Male";
            }
            else if (rdoFemale.Checked)
            {
                gender = "Female";
            }
            else if (rdoHelicopter.Checked)
            {
                gender = "Helicopter";
            }
            else
            {
                MessageBox.Show("Please select a gender");
            }
            DateTime? selectedDate = datePicker.Value; // Assuming datePicker.Value is of type Nullable<DateTime> or DateTime?
            string DOB = null;
            if (selectedDate.HasValue)
            {
                DOB = selectedDate.Value.ToString("yyyy-MM-dd");
            }
            string email = txtEmail.Text;
            string address = txtAddress.Text;
            
            try
            {
                if (password != verify)
                {
                    MessageBox.Show("The password did not match with the verify password. Please make sure the passwords are the same.");
                    return;
                }

                if (user.IsUsernameUnique(username))
                {
                    user.Register(username, password, role, DOB, gender, email, address);
                }
                switch(role)
                {
                    case "worker":
                        user.InsertWorkerID(username); 
                        break;
                }
                this.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
