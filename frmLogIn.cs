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
            string strQuery;
            bool blnPass = true;

           if (tbxPassword.Text == String.Empty || tbxUsername.Text == String.Empty)
           {
               lblErrorText.Visible = true;
               blnPass = false; 
           }


            if (blnPass == false)
            {
                lblErrorText.Visible = true;
            }
            else
            {
                if (rdbCustomer.Checked)
                {
                    //Use Given Information to Try to log in as a customer 
                    strQuery = "Select * From OrtizB21Su2332.LogOn " + 
                    "Where Username = '" + tbxUsername.Text + "' " + "And Password = '" + tbxPassword.Text + "';";
                    ProgOps.LogOn(strQuery);


                    if (ProgOps.blnFound == true)
                    {
                        //if person found using same query Grab Their ID
                        strQuery = "Select PersonID From OrtizB21Su2332.LogOn " +
                        "Where Username = '" + tbxUsername.Text + "'";
                        ProgOps.GrabPersonID(strQuery);//====SWITCH TO STRING LATER TO GRAB TEHIR NAME INSTEAD OF ID======

                        frmCustomer_Main frmcustomermain = new frmCustomer_Main();
                        this.Hide();
                        frmcustomermain.ShowDialog();
                        this.Close();
                    }
                }
                else if (rdbEmployee.Checked)
                {
                    //User Given Information to Try to log in as a employee
                    strQuery = "Select * from OrtizB21Su2332.Employees e inner join OrtizB21Su2332.LogOn l on e.PersonID = l.PersonID " +
                    "Where EmployeeID = " + tbxUsername.Text + " " +  "and Password = '" + tbxPassword.Text + "';";
                    ProgOps.LogOn(strQuery);

                    if (ProgOps.blnFound == true)
                    {
                        strQuery = "Select e.PersonID from  OrtizB21Su2332.Employees e inner join OrtizB21Su2332.LogOn l on l.PersonID = e.PersonID " +
                        "Where EmployeeID = " + tbxUsername.Text;
                        ProgOps.GrabPersonID(strQuery);

                        if(ProgOps.GrabAdmin(ProgOps.intPersonID) == true)
                        {
                           frmManager_Main frmmanagermain = new frmManager_Main();
                            this.Hide();
                            frmmanagermain.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                         strQuery = "Select e.PersonID from  OrtizB21Su2332.Employees e inner join OrtizB21Su2332.LogOn l on l.PersonID = e.PersonID " +
                         "Where EmployeeID = " + tbxUsername.Text;
                            ProgOps.GrabPersonID(strQuery);

                            frmEmployee_Main frmemployeemain = new frmEmployee_Main();
                            this.Hide();
                            frmemployeemain.ShowDialog();
                            this.Close();
                        }                      
                    }
                }
                else
                {
                    lblErrorText.Visible = true;
                    MessageBox.Show("User Could Not Be Found", "Incorect Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }


            }

        }

        private void tbxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbxUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rdbEmployee.Checked)
            {
                if (e.KeyChar >= 48 && e.KeyChar <= 57 || //ASCII Check For Numbers
                e.KeyChar == 8)
                {
                    //Allow the key press
                    e.Handled = false;
                }
                else
                {
                    //Deny the key press
                    e.Handled = true;
                }
            }
        }

        private void lblMainText_Click(object sender, EventArgs e)
        {

        }

        private void tsmHelp_Click(object sender, EventArgs e)
        {
            ProgOps._PICTURE = 3;
            frmHelp frmhelp = new frmHelp();
            this.Hide();
            frmhelp.ShowDialog();
            this.Show();
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            frmPasswordRecovery frmpasswordrecover = new frmPasswordRecovery();
            this.Hide();
            frmpasswordrecover.ShowDialog();
            this.Show();
        }
    }
}
