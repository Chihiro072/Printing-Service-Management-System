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
    public partial class admin : Form
    {
        private string role;
        private string username;
        SqlConnection con = new SqlConnection(@"Data Source=DELL-PC\SQLEXPRESS;Initial Catalog=IOOP_Assignment;Integrated Security=True");
        Admin adminUser = new Admin(@"Data Source=DELL-PC\SQLEXPRESS;Initial Catalog=IOOP_Assignment;Integrated Security=True");
        public admin()
        {
            InitializeComponent();
        }

        private void cboMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            int month = cboMonth.SelectedIndex + 1;
            lblBlackWhite1.Text = adminUser.GetQuantity(month, "Printing A4 - Black & White").ToString();
            lblColor1.Text = adminUser.GetQuantity(month, "Printing A4 - Color").ToString();
            lblCombBind1.Text = adminUser.GetQuantity(month, "Binding - Comb Binding").ToString();
            lblThickComb1.Text = adminUser.GetQuantity(month, "Binding - Thick Cover").ToString();
            lblPoster1.Text = adminUser.GetQuantity(month, "Poster printing (A0 - A3)").ToString();
            lblBanner1.Text = adminUser.GetQuantity(month, "Banner").ToString();

            lblBlackWhite2.Text = adminUser.GetRevenue(month, "Printing A4 - Black & White").ToString();
            lblColor2.Text = adminUser.GetRevenue(month, "Printing A4 - Color").ToString();
            lblCombBind2.Text = adminUser.GetRevenue(month, "Binding - Comb Binding").ToString();
            lblThickComb2.Text = adminUser.GetRevenue(month, "Binding - Thick Cover").ToString();
            lblPoster2.Text = adminUser.GetRevenue(month, "Poster printing (A0 - A3)").ToString();
            lblBanner2.Text = adminUser.GetRevenue(month, "Banner").ToString();

            double total1 = double.Parse(lblBlackWhite1.Text) +
                double.Parse(lblColor1.Text) +
                double.Parse(lblCombBind1.Text) +
                double.Parse(lblThickComb1.Text) +
                double.Parse(lblPoster1.Text) +
                double.Parse(lblBanner1.Text);

            double total2 = double.Parse(lblBlackWhite2.Text) +
                double.Parse(lblColor2.Text) +
                double.Parse(lblCombBind2.Text) +
                double.Parse(lblThickComb2.Text) +
                double.Parse(lblPoster2.Text) +
                double.Parse(lblBanner2.Text);

            lblTotal1.Text = total1.ToString();
            lblTotal2.Text = total2.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
