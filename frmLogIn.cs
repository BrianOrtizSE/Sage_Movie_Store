using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SU21_Final_Project
{
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {

        }
        private void rdCustomer_CheckedChanged(object sender, EventArgs e)
        {
            lblUSernameText.Text = "Username : ";
            lblErrorText.Visible = false;
        }

        private void rdEmployee_CheckedChanged(object sender, EventArgs e)
        {
            lblUSernameText.Text = "EmployeeID : ";
            lblErrorText.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool blnPass = true;

            if(rdbCustomer.Checked == false && rdbEmployee.Checked == false)
            {
               MessageBox.Show("Customer Or Employee Must Be Checked", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                blnPass = false;
            }

                ProgOps.LogOn(tbxUsername, tbxPassword, rdbCustomer, rdbEmployee, Text);
                frmProductView frmproductview = new frmProductView();
                frmproductview.ShowDialog();
            

        }
    }
}
