using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaffInfoForm.UserInterface.CustomerInfo
{
    public partial class frm_customer_list : Form
    {
        public frm_customer_list()
        {
            InitializeComponent();
        }
        Linq_MasterDataContext dc = new Linq_MasterDataContext();
        public void load_list()
        {
            dgvCustomer.AutoGenerateColumns = false;
            List<CustomerView> data = (from c in dc.CustomerViews where c.Active == true
                                       &&((tbSearch.Text !="" &&
                                       c.CustomerName.Contains(tbSearch.Text)
                                       || c.PhoneNo.Contains(tbSearch.Text)
                                       ||c.Email.Contains(tbSearch.Text)
                                       )
                                       ||tbSearch.Text=="")
                                       orderby c.CreatedOn descending select c).ToList();
            //cusList.Text = "Customer List -"+data.Count().ToString();
            cusList.Text = "Customer List (" + data.Count().ToString()+")";
            dgvCustomer.DataSource = data;
        }
        private void frm_customer_list_Load(object sender, EventArgs e)
        {
            load_list();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

            this.Hide();
            CustomerInfo.frm_customer customer = new CustomerInfo.frm_customer();
            customer.WindowState = FormWindowState.Maximized;
            customer.ShowDialog();
            this.Show();
            load_list();
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                this.Hide();
                string record_id = dgvCustomer.Rows[e.RowIndex].Cells[0].Value.ToString();
                frm_customer form = new frm_customer();
                form.cusrecord_id = record_id;
                form.ShowDialog();
                this.Show();
                load_list();
            }
        }

        private void btnRefersh_Click(object sender, EventArgs e)
        {
            load_list();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            load_list();
        }

    }
}
