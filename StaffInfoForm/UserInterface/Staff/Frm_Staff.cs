using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaffInfoForm
{
    public partial class Frm_Staff : Form
    {
        public Frm_Staff()
        {
            InitializeComponent();
        }
        public void clearData()
        {
            tbID.Text = "";
            tbStaffName.Text = "";
            tbNRCNo.Text = "";
            dateOfBirth.Text = "";
            tbAge.Text = "";
            cbCity.Text = "";
            tbAddress.Text = "";
            rbFemale.Checked = false;
            rbMale.Checked = true;
            cbHtml.Checked = false;
            cbCss.Checked = false;
            cbDotNet.Checked = false;
            cbJquery.Checked = false;
            record_id = "";
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            clearData();
        }
        Linq_MasterDataContext dc = new Linq_MasterDataContext();

        string record_id = "";
        public void load_list()
        {
            dgv_staff_info.AutoGenerateColumns = false;
            List<StaffView> data = (from c in dc.StaffViews where c.Active== true select c).ToList();
            dgv_staff_info.DataSource = data;
    
        }
        private void Frm_Staff_Load(object sender, EventArgs e)
        {
            load_list();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Staff the_record = new Staff();
                if (record_id=="")
                {
                    the_record.StaffID = Guid.NewGuid().ToString();
                    the_record.Active = true;
                    the_record.CreatedOn = DateTime.Now;
                    dc.Staffs.InsertOnSubmit(the_record);
                }
                else
                {
                    the_record= (from c in dc.Staffs where c.StaffID == record_id select c).FirstOrDefault();
                    if(the_record== null)
                    {
                        MessageBox.Show("System cann't find the record !");
                    }
                }
               
                the_record.StaffName = tbStaffName.Text;
                the_record.NRCNo = tbNRCNo.Text;
                the_record.DOB = dateOfBirth.Value;
                the_record.Age = Convert.ToInt16(tbAge.Text); 
                the_record.City = cbCity.Text;
                the_record.Address = tbAddress.Text;
                if (rbMale.Checked)
                {
                    the_record.Gender = "Male";
                }
                else
                {
                    the_record.Gender = "Female";
                }
                the_record.HTML = cbHtml.Checked ? true : false;
                the_record.CSS = cbCss.Checked ? true : false;
                the_record.JQuery = cbJquery.Checked ? true : false;
                the_record.DotNet = cbDotNet.Checked ? true : false;
                the_record.Active = true;
                the_record.CreatedOn = DateTime.Now;
                the_record.ModifiedOn = DateTime.Now;
                //dc.Staffs.InsertOnSubmit(the_record);
                dc.SubmitChanges();
                MessageBox.Show("Record have been saved.");
                load_list();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            clearData();
            
        }

        private void dgv_staff_info_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           if(e.RowIndex >= 0)
            {
                record_id = dgv_staff_info.Rows[e.RowIndex].Cells[0].Value.ToString();
                load_record();
            }
        }
        void load_record()
        {
            if(record_id != "")
            {
                Staff data = (from c in dc.Staffs where c.StaffID == record_id select c).FirstOrDefault();
                if(data != null)
                {
                    tbStaffName.Text = data.StaffName;
                    tbNRCNo.Text = data.NRCNo;
                    dateOfBirth.Value = data.DOB.Value;
                    tbAge.Text = data.Age.ToString();
                    cbCity.Text = data.City;
                    tbAddress.Text = data.Address;
                    if (data.Gender == "Male")
                    {
                        rbMale.Checked = true;
                    }
                    else
                    {
                        rbFemale.Checked = true;
                    }
                    cbHtml.Checked =data.HTML==true? true: false;
                    cbCss.Checked = data.CSS==true ? true : false;
                    cbDotNet.Checked = data.DotNet == true ? true : false;
                    cbJquery.Checked = data.JQuery == true ? true : false;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure want to delet", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Staff data = (from c in dc.Staffs where c.StaffID == record_id select c).FirstOrDefault();
                if(data != null)
                {
                    data.Active = false;
                    data.ModifiedOn = DateTime.Now;
                    dc.SubmitChanges();
                    MessageBox.Show("Deleted Succefully");
                    load_list();
                    clearData();
                }
            }
        }
    }
}
