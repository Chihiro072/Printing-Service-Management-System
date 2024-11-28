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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace kekw
{
    public partial class ProfileForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DELL-PC\SQLEXPRESS;Initial Catalog=IOOP_Assignment;Integrated Security=True");
        private string username, role;
        User profile = new User(@"Data Source=DELL-PC\SQLEXPRESS;Initial Catalog=IOOP_Assignment;Integrated Security=True");

        public ProfileForm(string username, string role)
        {
            InitializeComponent();
            this.username = username;
            this.role = role;
            txtRole.Text = role;
            txtUsername.Text = username.ToLower();
            txtUsername.Focus();
            txtTotal.Text = profile.CalculateTotal(username).ToString();
            txtPending.Text = profile.CalculatePending(username).ToString();
            txtRole.Enabled = txtDOB.Enabled = txtGender.Enabled = txtTotal.Enabled = txtPending.Enabled = false;
            txtUsername.Focus();

            bool isStudent = (role == "student");
            lblTotal.Visible = lblPending.Visible = txtTotal.Visible = txtPending.Visible = btnViewTotal.Visible = btnViewPending.Visible = isStudent;


            SqlConnection con = new SqlConnection(@"Data Source=DELL-PC\SQLEXPRESS;Initial Catalog=IOOP_Assignment;Integrated Security=True");
            con.Open();

            SqlCommand dob = new SqlCommand("Select [DOB] from [Users] where [Username] = @Username", con);
            dob.Parameters.AddWithValue("@Username", username);
            object date = dob.ExecuteScalar();
            DateTime dateTime = (DateTime)date;
            txtDOB.Text = dateTime.ToString("yyyy-MM-dd");

            SqlCommand gender = new SqlCommand("Select [Gender] from [Users] where [Username] = @Username", con);
            gender.Parameters.AddWithValue("@Username", username);
            txtGender.Text = gender.ExecuteScalar().ToString();

            SqlCommand email = new SqlCommand("Select [Email] from [Users] where [Username] = @Username", con);
            email.Parameters.AddWithValue("@Username", username);
            txtEmail.Text = email.ExecuteScalar().ToString();

            SqlCommand address = new SqlCommand("Select [Address] from [Users] where [Username] = @Username", con);
            address.Parameters.AddWithValue("@Username", username);
            txtAddress.Text = address.ExecuteScalar().ToString();

            con.Close();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            string newUsername = txtUsername.Text;
            string email = txtEmail.Text;
            string address = txtAddress.Text;

            if (!profile.IsUsernameUnique(newUsername))
            {
                MessageBox.Show("Username already exists. Please choose a different username.");
                txtUsername.Focus();
            }
            else
            {
                profile.UpdateUsername(username, newUsername);
                profile.UpdateEmail(email, username);
                profile.UpdateAddress(address, username);
                Login loginAgain = new Login();
                loginAgain.ShowDialog();
            }
        }

        private void btnViewTotal_Click_1(object sender, EventArgs e)
        {
            this.orderHistoryTableAdapter3.Fill(this.iOOP_AssignmentDataSet11.OrderHistory);
            SqlConnection con = new SqlConnection(@"Data Source=DELL-PC\SQLEXPRESS;Initial Catalog=IOOP_Assignment;Integrated Security=True");
            con.Open();

            // Use a parameterized query to filter by the stored username
            SqlCommand cmd = new SqlCommand("SELECT * FROM [OrderHistory] WHERE [Username] = @Username", con);
            cmd.Parameters.AddWithValue("@Username", username); // Set the parameter value

            // Execute the query
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Bind the filtered data to the DataGridView
            orderData.DataSource = dt;

            con.Close();
        }

        private void btnViewPending_Click_1(object sender, EventArgs e)
        {
            this.orderHistoryTableAdapter3.Fill(this.iOOP_AssignmentDataSet11.OrderHistory);
            SqlConnection con = new SqlConnection(@"Data Source=DELL-PC\SQLEXPRESS;Initial Catalog=IOOP_Assignment;Integrated Security=True");
            con.Open();

            // Use a parameterized query to filter by the stored username
            SqlCommand cmd = new SqlCommand("SELECT * FROM [OrderHistory] WHERE [Username] = @Username and [Status] != @Status", con);
            cmd.Parameters.AddWithValue("@Username", username); // Set the parameter value
            cmd.Parameters.AddWithValue("@Status", "Completed");
            // Execute the query
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Bind the filtered data to the DataGridView
            orderData.DataSource = dt;

            con.Close();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
