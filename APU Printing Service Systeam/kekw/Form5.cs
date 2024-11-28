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
    public partial class ServiceInfo : Form
    {
        public ServiceInfo()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iOOP_AssignmentDataSet12.Services' table. You can move, or remove it, as needed.
            this.servicesTableAdapter.Fill(this.iOOP_AssignmentDataSet12.Services);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
