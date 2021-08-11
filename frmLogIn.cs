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
        private void rdCustomer_CheckedChanged(object sender, EventArgs e)//Sets LogIn To Customer
        {
            lblUSernameText.Text = "Username : ";
            lblErrorText.Visible = false;
        }
        private void rdEmployee_CheckedChanged(object sender, EventArgs e)//Sets LogIn To Employee
        {
            lblUSernameText.Text = "EmployeeID : ";
            tbxUsername.Clear();
            lblErrorText.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string strQuery;

           if (tbxPassword.Text == String.Empty || tbxUsername.Text == String.Empty)
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

                    if (ProgOps._blnFound == true)
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
                    else
                    {
                        lblErrorText.Visible = true;
                    }
                }
                else if (rdbEmployee.Checked)
                {
                    //User Given Information to Try to log in as a employee
                    strQuery = "Select * from OrtizB21Su2332.Employees e inner join OrtizB21Su2332.LogOn l on e.PersonID = l.PersonID " +
                    "Where EmployeeID = " + tbxUsername.Text + " " +  "and Password = '" + tbxPassword.Text + "';";
                    ProgOps.LogOn(strQuery);

                    if (ProgOps._blnFound == true)
                    {
                        //If Found we set EmployeeID 
                        strQuery = "Select e.PersonID from  OrtizB21Su2332.Employees e inner join OrtizB21Su2332.LogOn l on l.PersonID = e.PersonID " +
                        "Where EmployeeID = " + tbxUsername.Text;
                        ProgOps.GrabEmployeeID(strQuery);

                        //Checks To see employee is admin if they are show them manager screen if not use employee
                        if(ProgOps.GrabAdmin(ProgOps._intEmployeeID) == true)
                        {
                           frmManager_Main frmmanagermain = new frmManager_Main();
                            this.Hide();
                            frmmanagermain.ShowDialog();
                            this.Close();
                        }
                        else 
                        {
                         strQuery = "Select e.EmployeeID from  OrtizB21Su2332.Employees e inner join OrtizB21Su2332.LogOn l on l.PersonID = e.PersonID " +
                         "Where EmployeeID = " + tbxUsername.Text;
                         ProgOps.GrabEmployeeID(strQuery);

                            frmEmployee_Main frmemployeemain = new frmEmployee_Main();
                            this.Hide();
                            frmemployeemain.ShowDialog();
                            this.Close();
                        }
                    }
                    else
                    {
                        lblErrorText.Visible = true;
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
        private void cbxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxShowPassword.Checked)
            {
                tbxPassword.UseSystemPasswordChar = false;
            }
            else{
                tbxPassword.UseSystemPasswordChar = true;
            }
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
            else
            {
                //Only allow letters and backspace
                if (e.KeyChar >= 65 && e.KeyChar <= 90 ||       //ASCII Check for Capital Letters
                   e.KeyChar >= 97 && e.KeyChar <= 122 ||       //ASCII Check for Lowercase Letters
                    e.KeyChar >= 40 && e.KeyChar <= 64 ||       //ASCII Check For Numbers
                    e.KeyChar == 33 ||
                    e.KeyChar >= 35 && e.KeyChar <= 38 ||       //ASCII for specific charectors
                   e.KeyChar == 8)                              //ASCII Check for Backspace
                {
                    //Accept the keystroke
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }
        private void tbxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 65 && e.KeyChar <= 90 ||       //ASCII Check for Capital Letters
               e.KeyChar >= 97 && e.KeyChar <= 122 ||       //ASCII Check for Lowercase Letters
                e.KeyChar >= 40 && e.KeyChar <= 64 ||       //ASCII Check For Numbers
                e.KeyChar == 33 ||
                e.KeyChar >= 35 && e.KeyChar <= 38 ||       //ASCII for specific charectors
               e.KeyChar == 8)                              //ASCII Check for Backspace
            {
                //Accept the keystroke
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
