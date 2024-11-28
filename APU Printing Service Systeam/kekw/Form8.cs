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
    public partial class ChangePassword : Form
    {
        private const string placeholderUsername = "Type your username";
        private const string placeholderVerify = "Type your password again";
        SqlConnection con = new SqlConnection(@"Data Source=Dell-PC\SQLEXPRESS;Initial Catalog=IOOP_Assignment;Integrated Security=True");
        private string username;
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void txtUsernameAndPw_Click(object sender, EventArgs e)
        {
            if (txtUsernameAndPw.Text == placeholderUsername)
            {
                txtUsernameAndPw.Clear();
                txtUsernameAndPw.ForeColor = Color.Black;
            }
        }

        private void txtVerify_Click(object sender, EventArgs e)
        {
            if (txtVerify.Text == placeholderVerify)
            {
                txtVerify.Clear();
                txtVerify.ForeColor = Color.Black;
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            username = txtUsernameAndPw.Text;
            User user = new User();
            if(!user.IsUsernameUnique(username))
            {
                btnContinue.Visible = false;
                btnContinue.Text = "RESET  PASSWORD";
                lblUsernameAndPw.Text = "New Password";
                txtUsernameAndPw.Clear();
                txtUsernameAndPw.Focus();
                txtVerify.Visible = true;
                lblVerify.Visible = true;
                btnReset.Visible = true;
            }
            else
            {
                MessageBox.Show("Username does not exist!");
                txtUsernameAndPw.Focus();
            }
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            if(txtUsernameAndPw.Text.Trim() == txtVerify.Text.Trim())
            {
                SqlCommand cmd = new SqlCommand("UPDATE [Users] SET [Password] = @Password where [Username] = @Username", con);
                con.Open();
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", txtUsernameAndPw.Text);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Your password has been updated!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Make sure the password and verify password is the same");
            }

        }
    }
}
