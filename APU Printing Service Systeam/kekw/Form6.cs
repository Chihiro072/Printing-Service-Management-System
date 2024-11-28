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
    public partial class CheckoutForm : Form
    {
        private string username;
        List<Print> printingService;
        Print listService = new Print();
        public CheckoutForm(string username)
        {
            InitializeComponent();
            this.username = username;
            printingService = new List<Print>
            {
                new Print("Printing A4 - Black & White", 0.8),
                new Print("Printing A4 - Color", 2.5),
                new Print("Binding - Comb Binding", 5.0),
                new Print("Binding - Thick Cover", 15.0),
                new Print("Poster printing (A0 - A3)", 3.0),
                new Print("Banner", 10.0),
            };

            foreach (var serviceType in printingService)
            {
                cboService.Items.Add(serviceType);
            }
        }

        private void cboService_SelectedIndexChanged(object sender, EventArgs e)
        {
            Print selectedPrint = cboService.SelectedItem as Print;
            lblPrice.Text = "RM " + selectedPrint.Price.ToString() + " / unit";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int Quantity;
            if (int.TryParse(txtQuantity.Text, out int verifQuantity))
            {
                Quantity = verifQuantity;
            }
            else
            {
                MessageBox.Show("Please provide an integer value for the quantity field");
                txtQuantity.Focus();
                return;
            }

            if (cboService.SelectedItem == null)
            {
                MessageBox.Show("Please select a service type");
            }


            if ((int.Parse(txtQuantity.Text) > 0))
            {
                Print listPrice = cboService.SelectedItem as Print;
                listService.Service = cboService.Text;
                listService.Quantity = int.Parse(txtQuantity.Text);
                listService.Price = listPrice.Price;
                listService.Subtotal = listPrice.Price * listService.Quantity;
                listService.Total = listOrder.Items.Count == 0 ? 0 : listService.Total;
                listService.Total += listService.Subtotal;

                ListViewItem listItem = new ListViewItem(listService.Service);
                listItem.SubItems.Add(listService.Quantity.ToString());
                listItem.SubItems.Add(listService.Price.ToString());
                listItem.SubItems.Add(listService.Subtotal.ToString());
                listOrder.Items.Add(listItem);

                txtTotal.Text = listService.Total.ToString();
                txtQuantity.Clear();
                cboService.Text = "";
                lblPrice.Text = "Price/ unit";
            }
            else
            {
                MessageBox.Show("Please provide a positive integer value for quantity");
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            if (listOrder.SelectedItems.Count > 0)
            {
                string removeTotal = listOrder.SelectedItems[0].SubItems[3].Text;
                double total = double.Parse(txtTotal.Text);
                total -= double.Parse(removeTotal);
                txtTotal.Text = total.ToString();
                listOrder.Items.Remove(listOrder.SelectedItems[0]);
            }
        }

        private void chkUrgent_CheckedChanged(object sender, EventArgs e)
        {
            double total = double.Parse(txtTotal.Text);
            total *= chkUrgent.Checked ? 1.3 : 1 / 1.3;
            txtTotal.Text = total.ToString();
            foreach (ListViewItem item in listOrder.Items)
            {
                if (double.TryParse(item.SubItems[2].Text, out double value))
                {
                    // Multiply the value by 1.3 if the CheckBox is checked
                    value = chkUrgent.Checked ? value * 1.3 : value / 1.3;

                    item.SubItems[2].Text = value.ToString();

                    // Update the subtotal (SubItems[3]) accordingly
                    if (double.TryParse(item.SubItems[3].Text, out double subtotal))
                    {
                        // Modify the subtotal based on the same condition as above
                        subtotal = chkUrgent.Checked ? subtotal * 1.3 : subtotal / 1.3;
                        item.SubItems[3].Text = subtotal.ToString();
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DELL-PC\SQLEXPRESS;Initial Catalog=IOOP_Assignment;Integrated Security=True");
            DateTime currentDate = DateTime.Now.Date;
            con.Open();
            foreach (ListViewItem item in listOrder.Items)
            {
                string service = item.SubItems[0].Text;
                int quantity = int.Parse(item.SubItems[1].Text);
                double pricePerUnit = double.Parse(item.SubItems[2].Text);
                double subtotal = double.Parse(item.SubItems[3].Text);
                SqlCommand cmd = new SqlCommand(
                    "INSERT into [OrderHistory] " +
                    "([Username], [Service], [Quantity], [UnitPrice], [Subtotal], [RequestDate], [Urgent], [Status], [WorkerID]) " +
                    "VALUES (@Username, @Service, @Quantity, @UnitPrice, @Subtotal, @RequestDate, @Urgent, @Status, @WorkerID)", con);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Service", service);
                cmd.Parameters.AddWithValue("@Quantity", quantity);
                cmd.Parameters.AddWithValue("@UnitPrice", pricePerUnit);
                cmd.Parameters.AddWithValue("@Subtotal", subtotal);
                cmd.Parameters.AddWithValue("@RequestDate", currentDate);
                cmd.Parameters.AddWithValue("@Urgent", chkUrgent.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@Status", "Pending");
                cmd.Parameters.AddWithValue("@WorkerID", 1); 
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Your request has been sent.");
            listOrder.Items.Clear();
            txtTotal.Clear();
        }
    }
}
