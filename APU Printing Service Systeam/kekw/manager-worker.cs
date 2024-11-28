using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace kekw
{
    public partial class AssignWorker : Form
    {
        private SqlConnection con; 

        public AssignWorker()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=DELL-PC\SQLEXPRESS;Initial Catalog=IOOP_Assignment;Integrated Security=True");
        }
        private void combobox()
        {
            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open();

                // Query the database to get the worker data that matches the criteria
                string query = "SELECT workerID, worker FROM worker WHERE workerID != 1";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                //Bind the data to the ComboBox
                    comboBox1.DataSource = dataTable;
                    comboBox1.ValueMember = "workerID";
                }
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
        private void datagridview()
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                // Query and populate dataGridView1
                string orderQuery = "SELECT * FROM OrderHistory WHERE workerID = @WorkerID";
                using (SqlCommand ordercmd = new SqlCommand(orderQuery, con))
                {
                    ordercmd.Parameters.AddWithValue("@WorkerID", 1);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(ordercmd))
                    {
                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet, "OrderHistory");
                        dataGridView1.DataSource = dataSet.Tables["OrderHistory"];
                    }
                }
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }


        private void manager_worker_Load(object sender, EventArgs e)
        {
                combobox();
                datagridview();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)//Check that rows are selected
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];//Get the data for the row selected by the user
                int newWorkerID = Convert.ToInt32(comboBox1.SelectedValue);//Get the data for the row selected by the user
                int Quantity = Convert.ToInt32(selectedRow.Cells[3].Value);
                int OrderID = Convert.ToInt32(selectedRow.Cells[0].Value);
                string username = selectedRow.Cells[1].Value.ToString();
                decimal price = Convert.ToDecimal(selectedRow.Cells[5].Value);
                string Service = selectedRow.Cells[2].Value.ToString();
                string newStatus = "Working In Progress";
                selectedRow.Cells[7].Value = newStatus;
                try
                {
                    if (con.State != ConnectionState.Open)
                        con.Open();
                    string CompletionMonth = DateTime.Now.ToString("MM");//Get the system month
                    string updateQuery = $"UPDATE OrderHistory SET workerID = @NewWorkerID, status = @NewStatus WHERE OrderID = @OrderID";
                    //Update the workerID and status in the database
                    using (SqlCommand updatecmd = new SqlCommand(updateQuery, con))
                    {
                        updatecmd.Parameters.AddWithValue("@NewWorkerID", newWorkerID);
                        updatecmd.Parameters.AddWithValue("@NewStatus", newStatus);
                        updatecmd.Parameters.AddWithValue("@OrderID", OrderID);

                        updatecmd.ExecuteNonQuery();
                    }
                    // Insert username, price, server, and CompletionMonth into the PaymentInfo table
                    string PaymentInfoQuery = "INSERT INTO PaymentInfo (Username, Quantity, Price, Service, CompletionMonth) VALUES (@Username,@Quantity,@Price, @Service, @CompletionMonth)";
                    using (SqlCommand PaymentInfocmd = new SqlCommand(PaymentInfoQuery, con))
                    {
                        PaymentInfocmd.Parameters.AddWithValue("@Username", username);
                        PaymentInfocmd.Parameters.AddWithValue("@Quantity", Quantity);
                        PaymentInfocmd.Parameters.AddWithValue("@Price", price);
                        PaymentInfocmd.Parameters.AddWithValue("@Service", Service);
                        PaymentInfocmd.Parameters.AddWithValue("@CompletionMonth", CompletionMonth);

                        PaymentInfocmd.ExecuteNonQuery();
                    }
                    //Refresh DataGridView，
                    datagridview();
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row in the DataGridView.");
            }
        }
    }
}
