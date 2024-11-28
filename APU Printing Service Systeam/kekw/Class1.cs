using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kekw
{
    public class Print
    {
        private string service;
        private int quantity;
        private double price;
        private double subtotal;
        private double total;

        public Print(string service, double price)
        {
            this.service = service;
            this.quantity = 0;
            this.price = price;
            this.subtotal = price * quantity;
            this.total = subtotal;
        }
        public Print()
        {
            this.service = "NULL";
            this.quantity = 1;
            this.price = 0;
            this.subtotal = 0;
            this.total = subtotal;
        }
        public string Service
        {
            get { return service; }
            set { service = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public double Subtotal
        {
            get { return subtotal; }
            set { subtotal = value; }
        }

        public double Total
        {
            get { return total; }
            set { total = value; }
        }
        public override string ToString()
        {
            return $"{Service}";
        }
    }
    public class User
    {
        private SqlConnection con;
        private string connection;
        private string username;
        private string password;
        public User()
        {
            this.username = null;
            this.password = null;
        }
        public User(string connection)
        {
            this.connection = connection;
            con = new SqlConnection(connection);
        }

        public bool InputValidator(string input, string placeholder)
        {
            return string.IsNullOrEmpty(input) || input == placeholder;
        }

        public bool IsUsernameUnique(string checkUsername)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=Dell-PC\SQLEXPRESS;Initial Catalog=IOOP_Assignment;Integrated Security=True"))
            {
                con.Open();
                SqlCommand checkUsernameCmd = new SqlCommand("SELECT COUNT(*) FROM [Users] WHERE [Username] = @CheckUsername", con);
                checkUsernameCmd.Parameters.AddWithValue("@CheckUsername", checkUsername);
                int usernameCount = (int)checkUsernameCmd.ExecuteScalar();
                return usernameCount == 0;
            }
        }
        public string AuthenticateUser(string username, string password)
        {
            string role = null;

            try
            {
                SqlCommand cmd = new SqlCommand("SELECT Role FROM [Users] WHERE [Username] = @Username AND [Password] = @Password", con);

                con.Open();
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                var _role = cmd.ExecuteScalar();
                if (_role != null)
                {
                    role = _role.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return role;
        }

        public void UpdateUsername(string username, string newUsername)
        {
            SqlCommand updateQuery = new SqlCommand("UPDATE [Users] SET [Username] = @NewUsername WHERE [Username] = @CurrentUsername", con);
            con.Open();
            updateQuery.Parameters.AddWithValue("@NewUsername", newUsername);
            updateQuery.Parameters.AddWithValue("@CurrentUsername", username);
            updateQuery.ExecuteNonQuery();
            SqlCommand updateHistory = new SqlCommand("UPDATE [OrderHistory] SET [Username] = @NewUsername WHERE [Username] = @CurrentUsername", con);
            updateHistory.Parameters.AddWithValue("@NewUsername", newUsername);
            updateHistory.Parameters.AddWithValue("@CurrentUsername", username);
            updateHistory.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Username has been updated");
        }

        public void UpdateEmail(string email, string username)
        {
            SqlCommand updateQuery = new SqlCommand("UPDATE [Users] SET [Email] = @NewEmail WHERE [Username] = @CurrentUsername", con);
            con.Open();

            updateQuery.Parameters.AddWithValue("@NewEmail", email);
            updateQuery.Parameters.AddWithValue("@CurrentUsername", username);
            updateQuery.ExecuteNonQuery();
            con.Close();
        }

        public void UpdateAddress(string address, string username)
        {
            SqlCommand updateQuery = new SqlCommand("UPDATE [Users] SET [Address] = @NewAddress WHERE [Username] = @CurrentUsername", con);
            con.Open();

            updateQuery.Parameters.AddWithValue("@NewEmail", address);
            updateQuery.Parameters.AddWithValue("@CurrentUsername", username);
            updateQuery.ExecuteNonQuery();
            con.Close();
        }

        public int CalculateTotal(string username)
        {
            SqlCommand cmd = new SqlCommand("SELECT count(*) FROM [OrderHistory] where [Username] = @Username", con);
            con.Open();
            cmd.Parameters.AddWithValue("@Username", username);
            int TotalOrder = (int)cmd.ExecuteScalar();
            con.Close();
            return TotalOrder;
        }

        public int CalculatePending(string username)
        {
            SqlCommand cmd = new SqlCommand("SELECT count(*) FROM [OrderHistory] Where [Username] = @Username and [Status] != @Status", con);
            con.Open();
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Status", "Completed");
            int PendingOrder = (int)cmd.ExecuteScalar();
            con.Close();
            return PendingOrder;
        }

        public void Register(string username, string password, string role, string DOB, string gender, string email, string address)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Users (Username, Password, Role, DOB, Gender, Email, Address) " +
                              "VALUES (@Username, @Password, @Role, @DOB, @Gender, @Email, @Address)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.Parameters.AddWithValue("@Role", role);
            cmd.Parameters.AddWithValue("@DOB", DOB);
            cmd.Parameters.AddWithValue("@Gender", gender);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Address", address);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Sign-up successful");
        }

        public void InsertWorkerID(string username)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO [worker] (worker) VALUES (@Worker)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@Worker", username.ToLower());
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
    public class Admin
    {
        private SqlConnection con;
        private string connection;
        private int month;
        private string service;

        public Admin(string connection)
        {
            this.connection = connection;
            con = new SqlConnection(connection);
        }

        public int GetQuantity(int month, string service)
        {
            SqlCommand cmd = new SqlCommand("SELECT count(*) from [PaymentInfo] where [CompletionMonth] = @Month and [Service] = @Service", con);
            con.Open();
            cmd.Parameters.AddWithValue("@Month", month);
            cmd.Parameters.AddWithValue("@Service", service);
            int QuantitySold = (int)cmd.ExecuteScalar();
            con.Close();

            return QuantitySold;
        }

        public double GetRevenue(int month, string service)
        {
            double result = 0.0;

            SqlCommand cmd = new SqlCommand("SELECT SUM([Price]) FROM [PaymentInfo] WHERE [Service] = @Service AND [CompletionMonth] = @Month", con);
            con.Open();
            cmd.Parameters.AddWithValue("@Service", service);
            cmd.Parameters.AddWithValue("@Month", month);

            object price = cmd.ExecuteScalar();

            if (price != DBNull.Value && price != null)
            {
                if (double.TryParse(price.ToString(), out double parsedPrice))
                {
                    result = parsedPrice;
                }

            }
            con.Close();
            return result;
        }
    }

}