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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace kekw
{
    public partial class ProcessReq : Form
    {
        private SqlConnection con;
        private string username;
        public ProcessReq(string username)
        {
            InitializeComponent();
            this.username = username;
            con = new SqlConnection(@"Data Source=DELL-PC\SQLEXPRESS;Initial Catalog=IOOP_Assignment;Integrated Security=True");
        }

        private void LoaddataGridView()
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                // 使用参数化查询，查询 workerID
                string queryWorkerID = "SELECT workerID FROM worker WHERE worker = @Username";

                using (SqlCommand commandWorkerID = new SqlCommand(queryWorkerID, con))
                {
                    commandWorkerID.Parameters.AddWithValue("@Username", username);

                    // 执行查询并获取结果
                    object resultWorkerID = commandWorkerID.ExecuteScalar();

                    // 处理结果
                    if (resultWorkerID != null)
                    {
                        int workerID = Convert.ToInt32(resultWorkerID);

                        string queryOrderHistory = "SELECT * FROM OrderHistory WHERE workerID = @WorkerID";

                        using (SqlCommand commandOrderHistory = new SqlCommand(queryOrderHistory, con))
                        {
                            commandOrderHistory.Parameters.AddWithValue("@WorkerID", workerID);

                            using (SqlDataAdapter adapter = new SqlDataAdapter(commandOrderHistory))
                            {
                                DataSet dataSet = new DataSet();
                                adapter.Fill(dataSet, "OrderHistory");


                                dataGridView1.DataSource = dataSet.Tables["OrderHistory"];

                            }
                        }
                        label2.Text = username;
                    }
                    else
                    {
                        Console.WriteLine($"No record found for username: {username}");
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions here
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
        private void workerform_Load(object sender, EventArgs e)
        {
            LoaddataGridView();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                // Check if any row is selected
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                    // Get the OrderID from the selected row
                    int orderID = Convert.ToInt32(selectedRow.Cells[0].Value);
                    // Update the Status to 'Completed' in the SQL databas
                    string newStatus = "Completed";
                    selectedRow.Cells[4].Value = newStatus;
                    string updateQuery = $"UPDATE OrderHistory SET status = @NewStatus WHERE OrderID = @OrderID";
                    using (SqlCommand updatecmd = new SqlCommand(updateQuery, con))
                    {
                        updatecmd.Parameters.AddWithValue("@NewStatus", newStatus);
                        updatecmd.Parameters.AddWithValue("@OrderID", orderID);
                        updatecmd.ExecuteNonQuery();
                    }
                    // 刷新 DataGridView，以便反映数据库中的更改
                    LoaddataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating data: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}






