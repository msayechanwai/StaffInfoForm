using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StaffInfoForm
{
    public partial class Form1 : Form
    {   
        public void clearData()
        {
            tbStaffID.Text = "";
            tbStaffName.Text = "";
            tbNRCNo.Text = "";
            dateOfBirth.Text = "";
            tbAge.Text = "";
            cbCity.Text = "";
            tbAddress.Text = "";
            rbFemale.Checked = false;
            rbMale.Checked = false;
            cbHtml.Checked = false;
            cbCss.Checked = false;
            cbDotNet.Checked = false;
            cbJquery.Checked = false;
        }
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbCity.SelectedIndex = 0;
        }

        private void dgv_staff_info_Click(object sender, EventArgs e)
        {
            tbStaffID.Text = dgv_staff_info.SelectedRows[0].Cells[0].Value.ToString();
            tbStaffName.Text = dgv_staff_info.SelectedRows[0].Cells[1].Value.ToString();
            tbNRCNo.Text = dgv_staff_info.SelectedRows[0].Cells[2].Value.ToString();
            dateOfBirth.Text = dgv_staff_info.SelectedRows[0].Cells[3].Value.ToString();
            tbAge.Text = dgv_staff_info.SelectedRows[0].Cells[4].Value.ToString();
            cbCity.Text = dgv_staff_info.SelectedRows[0].Cells[5].Value.ToString();
            tbAddress.Text = dgv_staff_info.SelectedRows[0].Cells[6].Value.ToString();
            if (dgv_staff_info.SelectedRows[0].Cells[7].Value.ToString().Equals("Male"))
            {
                rbMale.Checked = true;
            }
            if (dgv_staff_info.SelectedRows[0].Cells[7].Value.ToString().Equals("Female"))
            {
                rbFemale.Checked = true;
            }
            if (dgv_staff_info.SelectedRows[0].Cells[8].Value.ToString().Equals("Yes"))
            {
                cbHtml.Checked = true;
            }
            if (dgv_staff_info.SelectedRows[0].Cells[9].Value.ToString().Equals("Yes"))
            {
                cbCss.Checked = true;
            }
            if (dgv_staff_info.SelectedRows[0].Cells[10].Value.ToString().Equals("Yes"))
            {
                cbDotNet.Checked = true;
            }
            if (dgv_staff_info.SelectedRows[0].Cells[11].Value.ToString().Equals("Yes"))
            {
                cbJquery.Checked = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string gender = "";
            if (rbMale.Checked)
            {
                gender = "Male";
            }
            if (rbFemale.Checked)
            {
                gender = "Female";
            }
            string html = "";
            string css = "";
            string dotnet = "";
            string jquery = "";
            if (cbHtml.Checked)
            {
                html = "Yes";
            }
            else
            {
                html = "No";
            }
            if (cbCss.Checked)
            {
                css = "Yes";
            }
            else
            {
                css = "No";
            }
            if (cbDotNet.Checked)
            {
                dotnet = "Yes";
            }
            else
            {
                dotnet = "No";
            }
            if (cbJquery.Checked)
            {
                jquery = "Yes";
            }
            else
            {
                jquery = "No";
            }
            dgv_staff_info.Rows.Add(tbStaffID.Text, tbStaffName.Text, tbNRCNo.Text, dateOfBirth.Text, tbAge.Text, cbCity.Text, tbAddress.Text, gender,html, css, dotnet, jquery);
            clearData();
        }
    }
}
