using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaffInfoForm.UserInterface.Main
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Staff staff = new Frm_Staff();
            staff.WindowState = FormWindowState.Maximized;
            staff.ShowDialog();
            this.Show();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerInfo.frm_customer_list customer_list = new CustomerInfo.frm_customer_list();
            customer_list.WindowState = FormWindowState.Maximized;
            customer_list.ShowDialog();
            this.Show();

        }
    }
}
