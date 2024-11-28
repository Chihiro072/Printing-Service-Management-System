using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kekw
{
    
    public partial class MainMenu : Form
    {
        private string username, role;
        public MainMenu(string username, string role)
        {
            InitializeComponent();
            this.username = username;
            this.role = role;

            if (role == "student")
            {
                btnService.Text = "View Service";
                btnRequest.Text = "Submit Request Order";
                btnRequest.Visible = true;
            }
            else if (role == "manager")
            {
                btnService.Text = "View New Request";
                btnRequest.Text = "Assign Worker";
                btnRequest.Visible = true;
            }
            else if (role == "worker")
            {
                btnService.Text = "Process Order";
                btnRequest.Visible = false;
            }
            else if (role == "admin")
            {
                btnService.Text = "View Monthly Report";
                btnRequest.Text = "Register New User";
                btnRequest.Visible = true;
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ProfileForm vProfile = new ProfileForm(username, role);
            vProfile.ShowDialog();
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            if (role == "student")
            {
                ServiceInfo vService = new ServiceInfo();
                vService.ShowDialog();
            }
            else if (role == "admin")
            {
                admin monthlyReport = new admin();
                monthlyReport.ShowDialog();
            }
            else if (role == "manager")
            {
                ViewReq viewreq = new ViewReq(username);
                viewreq.ShowDialog();
            }
            else if (role == "worker")
            {
                ProcessReq processreq = new ProcessReq(username);
                processreq.ShowDialog();
            }
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            if (role == "student")
            {
                CheckoutForm rOrder = new CheckoutForm(username);
                rOrder.ShowDialog();
            }
            else if (role == "admin")
            {
                Register register = new Register();
                register.ShowDialog();
            }
            else if (role == "manager")
            {
                AssignWorker assign = new AssignWorker();
                assign.ShowDialog();
            }

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
