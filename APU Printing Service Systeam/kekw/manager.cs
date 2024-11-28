using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kekw
{
    public partial class ViewReq : Form
    {
        private string username; //The username of the storage manager
        private SqlConnection con; // connect SQL
        private SqlDataAdapter dataAdapter; // Data adapter
        private DataTable dataTable; // Data table object
        public ViewReq(string username)
        {
            InitializeComponent();
            this.username = username;
        }
        private void refresh()// Method to refresh the DataGridView with data from the database
        {
            con = new SqlConnection(@"Data Source=DELL-PC\SQLEXPRESS;Initial Catalog=IOOP_Assignment;Integrated Security=True");
            con.Open();


            // SQL query to retrieve data from the OrderHistory table
            dataAdapter = new SqlDataAdapter("SELECT * FROM OrderHistory", con);
            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);// Fills the data table with the retrieved data
            dataGridView1.DataSource = dataTable;


            con.Close();
        }
        private void manager_Load(object sender, EventArgs e)
        {
            label2.Text = username;
            refresh();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
