using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaffInfoForm.UserInterface.CustomerInfo
{
    public partial class frm_customer : Form
    {
        public frm_customer()
        {
            InitializeComponent();
        }
        Linq_MasterDataContext dc = new Linq_MasterDataContext();
        public string cusrecord_id = "";
        void clearData()
        {
            tbCusName.Text = "";
            tbCusEmail.Text = "";
            tbCusPhoneno.Text = "";
            tbCusAddress.Text = "";
        }
        private void frm_customer_Load(object sender, EventArgs e)
        {
            if (cusrecord_id == "")
            {
                clearData();
            }
            else
            {
                load_record();
            }
        }
        void load_record()
        {
            if (cusrecord_id != "")
            {
                Customer data = (from c in dc.Customers where c.CustomerID == cusrecord_id select c).FirstOrDefault();
                if (data != null)
                {
                    tbCusName.Text = data.CustomerName;
                    tbCusEmail.Text = data.Email;
                    tbCusPhoneno.Text = data.PhoneNo;
                    cbCusCity.Text = data.City;
                    tbCusAddress.Text = data.Address;

                }
            }
        }
        private void btnCusSave_Click(object sender, EventArgs e)
        {

            try
            {
                Customer cus_record = new Customer();
                if (cusrecord_id == "")
                {
                    cus_record.CustomerID = Guid.NewGuid().ToString();
                    cus_record.Active = true;
                    cus_record.CreatedOn = DateTime.Now;
                    dc.Customers.InsertOnSubmit(cus_record);
                }
                else
                {
                    cus_record = (from c in dc.Customers where c.CustomerID == cusrecord_id select c).FirstOrDefault();
                    if (cus_record == null)
                    {
                        MessageBox.Show("System cann't find the record !");
                    }
                }
                cus_record.CustomerName = tbCusName.Text;
                cus_record.Email = tbCusEmail.Text;
                cus_record.PhoneNo = tbCusPhoneno.Text;
                cus_record.City = cbCusCity.Text;
                cus_record.Address = tbCusAddress.Text;
                cus_record.Active = true;
                cus_record.CreatedOn = DateTime.Now;
                cus_record.ModifiedOn = DateTime.Now;
                dc.SubmitChanges();
                MessageBox.Show("Record have been saved.");
                clearData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Hide();
            CustomerInfo.frm_customer_list customer_list = new CustomerInfo.frm_customer_list();
            customer_list.WindowState = FormWindowState.Maximized;
            customer_list.ShowDialog();
            this.Show();

        }

        private void btnCusClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCusDelete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure want to delet", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Customer data = (from c in dc.Customers where c.CustomerID == cusrecord_id select c).FirstOrDefault();
                if (data != null)
                {
                    data.Active = false;
                    data.ModifiedOn = DateTime.Now;
                    dc.SubmitChanges();
                    MessageBox.Show("Deleted Succefully");
                    this.Close();
                    clearData();
                }
            }
        }
    }
}
