using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaffInfoForm.UserInterface.Login
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
        }
        void login()
        {
            try
            {

                if (tbUserName.Text == "")
                {
                    MessageBox.Show("Please fill the user name");
                }
                 else if (tbPassword.Text == "")
                {
                    MessageBox.Show("Please fill your password");
                }
                else if (tbUserName.Text != "")
                {
                    Linq_MasterDataContext dc = new Linq_MasterDataContext();
                    User user = (from c in dc.Users where c.UserCode == tbUserName.Text select c).FirstOrDefault();
                    if(user == null)
                    {
                        MessageBox.Show("Wrong user name");
                    }
                    else if (user.Password != tbPassword.Text)
                    {
                        MessageBox.Show("Wrong Password!!");
                    }
                    else
                    {
                        this.Hide();
                        Main.frm_main the_form = new Main.frm_main();
                        the_form.WindowState = FormWindowState.Maximized;
                        the_form.ShowDialog();
                        this.Show();
                    }
                }
                

            }
            catch (  Exception e)
            {
                MessageBox.Show("Error!");
            }
        }
        
    }
}
