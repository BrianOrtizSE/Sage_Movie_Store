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
    public partial class frmFind_User : Form
    {
        public frmFind_User()
        {
            InitializeComponent();
        }

        private void frmFind_User_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String strQuery;

            switch (ProgOps._FindUser)
            {

                case 0:
                    //Searches for user using Username 
                    strQuery = "Select p.PersonID " +
                        " From OrtizB21Su2332.Person p inner join OrtizB21Su2332.LogOn l on p.PersonID = l.PersonID " +
                        " Where l.UserName = '" + tbxUsername.Text + "' ";

                    ProgOps.GrabPersonID(strQuery);

                    if (ProgOps._blnFound == true)
                    {
                        //If it is found we make sure that the user is not a Employee
                        strQuery = "Select e.EmployeeID " +
                        " From OrtizB21Su2332.Employees e inner join OrtizB21Su2332.LogOn l on e.PersonID = l.PersonID " +
                        " Where l.UserName = '" + tbxUsername.Text + "'";

                        ProgOps.CheckEmployeeID(strQuery);


                        if (ProgOps._blnFound == true)
                        {
                            //if they are an employee we let them know you cant edit information without manager
                            MessageBox.Show("Employees can not edit other Employee Information. Please Change infomration by yourself or ask for Mangaer for help", "Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tbxUsername.Clear();
                        }
                        else
                        {
                            //if not an employee we can let them edit the information
                            this.Hide();
                            frmEmployee_Edit_Customer frmEmpEditCus = new frmEmployee_Edit_Customer();
                            frmEmpEditCus.ShowDialog();
                            this.Close();
                        }

                    }
                    else
                    {
                        this.Close();
                    }
                    break;

                case 1:
                    //Searches for user using Username 
                    strQuery = "Select p.PersonID " +
                        " From OrtizB21Su2332.Person p inner join OrtizB21Su2332.LogOn l on p.PersonID = l.PersonID " +
                        " Where l.UserName = '" + tbxUsername.Text + "' ";

                    ProgOps.GrabPersonID(strQuery);
                    //If found let them through if not do nothing
                    if (ProgOps._blnFound == true)
                    {
                        this.Hide();
                        frmEmployee_POS frmEmpPos = new frmEmployee_POS();
                        frmEmpPos.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        //if not found let them know

                    }
                    break;
                case 2:
                    break;
                default:
                    break;

            }

        }
        private void tbxUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 34 || e.KeyChar == 39 || //ASCII Check For " and '
            e.KeyChar == 32)                          //ASCII FOR SpaceBar
            {
                //Deny the key press
                e.Handled = true;
            }
            else
            {
                //Allow the key press
                e.Handled = false;
            }
        }
    }
}
