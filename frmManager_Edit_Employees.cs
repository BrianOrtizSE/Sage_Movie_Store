﻿using System;
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
    public partial class frmManager_Edit_Employees : Form
    {
        public frmManager_Edit_Employees()
        {
            InitializeComponent();
        }
        string strQuery; // FOr Writing The Query
        bool blnEdit = false; //For Clicking Dat Grid View

        private void frmManger_View_Employees_Load(object sender, EventArgs e)
        {
            GrabEmployee();
            cmxPosition.Text = "Employee";
        }    

        private void btnAdd_Click(object sender, EventArgs e)//Check Validation then Add New Employee
        {
            bool blnValid = true;
            double dblWage = 0.0;
            string strWage = tbxWage.Text;
            //Make Sure Admin Dont pay less than minimum wage
            if (tbxPersonID.Text == String.Empty)
            {
                MessageBox.Show("Please Find Person ID", "Person ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
                blnValid = false;
            }
            if (lblWageTextValid.Text == "X")
            {
                blnValid = false;
            }
            else
            {
                strWage = strWage.Replace("$", "");

                dblWage = Double.Parse(strWage);
                if (dblWage < 7.25)
                {
                    MessageBox.Show("Federal Minimum Wage is 7.25$ please correct Wage to comply.", "Minimum Wage", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    blnValid = false;
                }

                if (cbxIsSalary.Checked == true && dblWage < 25000)
                {
                    MessageBox.Show("Company Minimum Salary is 25,000$ please correct Wage to comply.", "Minimum Salary", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    blnValid = false;
                }
            }
            if (cmxPosition.SelectedIndex == -1)
            {
                MessageBox.Show("Error While Setting Employee Position", "Employee Position Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                blnValid = false;
            }

            if (blnValid == true)
            {
                int isSalary = 0;
                int isAdmin = 0;
                if (cbxIsSalary.Checked)
                {
                    isSalary = 1;
                }
                if (cbxAdmin.Checked)
                {
                    isAdmin = 1;
                }


                strQuery = "Insert into OrtizB21Su2332.Employees(PersonID , Position , Wage , Hire_Date , isSalary  ,isAdmin) " +
                    " values(" + tbxPersonID.Text + ",'" + cmxPosition.Text + "'," + dblWage + ",GETDATE()," + isSalary + "," + isAdmin + ")";
                ProgOps.CreateDiscount(strQuery);

                MessageBox.Show("Employee Added", "Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GrabEmployee();

            }
        }        

        private void tbxDiscountPercent_TextChanged(object sender, EventArgs e)//Validation for Discount
        {

            if (tbxWage.Text == String.Empty)
            {
                lblWageTextValid.Text = "X";
                lblWageTextValid.ForeColor = Color.Red;
            }
            else
            {
                lblWageTextValid.ForeColor = Color.Green;
                lblWageTextValid.Text = "\u221A";
            }

        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)//Cell Click to make all information from data grid move to textboxes
        {
            double dblPrice;
            try
            {
                if (blnEdit == true)
                {
                    if (e.RowIndex < 0 || e.ColumnIndex < 0)
                    {

                    }
                    else if (dgvEmployee.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        dgvEmployee.CurrentRow.Selected = true;
                        tbxEmployee.Text = dgvEmployee.Rows[e.RowIndex].Cells["EmployeeID"].Value.ToString();
                        tbxPersonID.Text = dgvEmployee.Rows[e.RowIndex].Cells["PersonID"].Value.ToString();
                        cmxPosition.Text = dgvEmployee.Rows[e.RowIndex].Cells["Position"].Value.ToString();

                        dblPrice = Convert.ToDouble(dgvEmployee.Rows[e.RowIndex].Cells["Wage"].Value);
                        tbxWage.Text = dblPrice.ToString("c2");

                        tbxHireDate.Text = dgvEmployee.Rows[e.RowIndex].Cells["Hire_Date"].Value.ToString();
                        cbxIsSalary.Checked = Convert.ToBoolean(dgvEmployee.Rows[e.RowIndex].Cells["isSalary"].Value);
                        cbxAdmin.Checked = Convert.ToBoolean(dgvEmployee.Rows[e.RowIndex].Cells["isAdmin"].Value);
                    }
                }
            }
            catch (ArgumentOutOfRangeException)
            {

            }

        }

        private void btnEditEmployee_Click(object sender, EventArgs e)//Set View State To Edit
        {
            SetState("Edit");
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            Clear();
        }  
        private void btnCompleteEdit_Click(object sender, EventArgs e)//Validation To Make Sure User Check Is Okay
        {
            bool blnValid = true;
            double dblWage = 0.0;
            string strWage = tbxWage.Text;
            //Make Sure Admin Dont pay less than minimum wage
            if (lblWageTextValid.Text == "X")
            {
                blnValid = false;
            }
            else
            {
                strWage = strWage.Replace("$", "");

                dblWage = Double.Parse(strWage);
                if (dblWage < 7.25)
                {
                    MessageBox.Show("Federal Minimum Wage is 7.25$ please correct Wage to comply.", "Minimum Wage", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    blnValid = false;
                }

                if (cbxIsSalary.Checked == true && dblWage < 25000)
                {
                    MessageBox.Show("Company Minimum Salary is 25,000$ please correct Wage to comply.", "Minimum Salary", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    blnValid = false;
                }
            }
            if (cmxPosition.SelectedIndex == -1)
            {
                MessageBox.Show("Error While Setting Employee Position", "Employee Position Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                blnValid = false;
            }
            if (tbxEmployee.Text == String.Empty)
            {
                MessageBox.Show("Please Choose An Employee To Edit", "Employee Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                blnValid = false;
            }

            if (blnValid == true)
            {
                int isSalary = 0;
                int isAdmin = 0;
                if (cbxIsSalary.Checked)
                {
                    isSalary = 1;
                }
                if (cbxAdmin.Checked)
                {
                    isAdmin = 1;
                }


                strQuery = "Update OrtizB21Su2332.Employees " +
                    " Set Wage = " + dblWage + ", isSalary = " + isSalary + ", isAdmin = " + isAdmin +
                    " Where EmployeeID = " + tbxEmployee.Text;
                ProgOps.CreateDiscount(strQuery);

                MessageBox.Show("Employee Information Changed", "Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GrabEmployee();

            }

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFindPersonID_Click(object sender, EventArgs e)//Use Find User Form But Change it a bit so that it works for this form
        {
            ProgOps._FindUser = 1;
            this.Hide();
            frmFind_User frmFindUser = new frmFind_User();
            frmFindUser.ShowDialog();
            this.Show();
            tbxPersonID.Text = ProgOps._intPersonID.ToString();

            strQuery = "Select * from OrtizB21Su2332.Employees where PersonID = " + tbxPersonID.Text;
            ProgOps.GrabEmployeeID(strQuery);
            if(ProgOps._blnFound == true)
            {
                MessageBox.Show("User is already an Employee", "User Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxPersonID.Clear();
            }
        }

        private void btnGetDate_Click(object sender, EventArgs e)//Used to show Dte
        {
            tbxHireDate.Text = DateTime.Today.ToString();
        }

        private void btnDisable_Click(object sender, EventArgs e)//Disable User
        {

            if(tbxPersonID.Text == string.Empty)
            {
                MessageBox.Show("Please Choose An Employee To Disable", "Employee Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are You Sure You Want To Disable This Employee", "Conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                
               if(dialogResult == DialogResult.Yes)
               {
                    strQuery = "Update OrtizB21Su2332.Employees Set isActive = 0 Where PersonID = " + tbxPersonID.Text;
                    MessageBox.Show("Employee Has Been Disabled", "Employee Disabled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ProgOps.CreateDiscount(strQuery);
                    GrabEmployee();
               }     

            }
            
        }
        private void btnShowUnactive_Click(object sender, EventArgs e)//Show Inactive Employees
        {
            strQuery = "Select EmployeeID , PersonID , Position , Wage , Hire_Date , isSalary , isAdmin from OrtizB21Su2332.Employees where isActive = 0";
            ProgOps.GrabEmployee(dgvEmployee, strQuery);

            if (ProgOps._blnFound == false)
            {

            }
            else
            {

                dgvEmployee.Columns[0].HeaderText = "Employee ID ";
                dgvEmployee.Columns[1].HeaderText = "Person ID";
                dgvEmployee.Columns[2].HeaderText = "Position";
                dgvEmployee.Columns[3].DefaultCellStyle.Format = "c2";
                dgvEmployee.Columns[3].HeaderText = "Wage";
                dgvEmployee.Columns[4].HeaderText = "Hire Date";
                dgvEmployee.Columns[4].HeaderText = "Salary?";
                dgvEmployee.Columns[4].HeaderText = "Admin?";

                btnShowActive.Visible = true;
                btnShowUnactive.Visible = false;


                btnEnable.Visible = true;
                btnDisable.Visible = false;
            }


        }

        private void btnShowActive_Click(object sender, EventArgs e)
        {
            btnShowUnactive.Visible = true;
            btnShowActive.Visible = false;

            btnDisable.Visible = true;
            btnEnable.Visible = false;

            GrabEmployee();
        }

        private void EnableEmployee_Click(object sender, EventArgs e)
        {
            if (tbxPersonID.Text == string.Empty)
            {
                MessageBox.Show("Please Choose An Employee To Enable", "Employee Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are You Sure You Want To Enable This Employee", "Conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    strQuery = "Update OrtizB21Su2332.Employees Set isActive = 1 Where PersonID = " + tbxPersonID.Text;
                    MessageBox.Show("Employee Has Been Enabled", "Employee Enabled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ProgOps.CreateDiscount(strQuery);
                    GrabEmployee();
                }

            }
        }

        public void Clear()//Reset All Textboxes and set View Mode
        {
            SetState("View");
            tbxPersonID.Clear();
            tbxEmployee.Clear();
            cmxPosition.Text = "Employee";
            tbxWage.Clear();
            tbxHireDate.Clear();
            cbxIsSalary.Checked = false;
            cbxAdmin.Checked = false;
        }
        public void GrabEmployee()//Function Used For Employee Data Grid To Display To Data Grid 
        {
            strQuery = "Select EmployeeID , PersonID , Position , Wage , Hire_Date , isSalary , isAdmin from OrtizB21Su2332.Employees where isActive = 1";
            ProgOps.GrabEmployee(dgvEmployee, strQuery);

            dgvEmployee.Columns[0].HeaderText = "Employee ID ";
            dgvEmployee.Columns[1].HeaderText = "Person ID";
            dgvEmployee.Columns[2].HeaderText = "Position";
            dgvEmployee.Columns[3].DefaultCellStyle.Format = "c2";
            dgvEmployee.Columns[3].HeaderText = "Wage";
            dgvEmployee.Columns[4].HeaderText = "Hire Date";
            dgvEmployee.Columns[4].HeaderText = "Salary?";
            dgvEmployee.Columns[4].HeaderText = "Admin?";
        }
        private void SetState(string state)//Set State To Make It Easier For User
        {
            string myState = state;

            switch (state)
            {
                case "View":
                    //button
                    btnAdd.Enabled = true;
                    btnEditEmployee.Enabled = true;
                    btnCancelEdit.Enabled = false;
                    btnCompleteEdit.Enabled = false;

                    btnFindPersonID.Visible = true;
                    btnGetDate.Visible = true;

                    btnDisable.Enabled = false;
                    btnEnable.Enabled = false;

                    //labels
                    lblWageTextValid.Visible = true;

                    //textboxes
                    tbxEmployee.ReadOnly = false;

                    //Bool
                    blnEdit = false;
                    break;

                case "Edit":

                    //Button
                    btnFindPersonID.Visible = false;
                    btnGetDate.Visible = false;
                    btnEditEmployee.Enabled = false;
                    btnAdd.Enabled = false;
                    btnCompleteEdit.Enabled = true;
                    btnCancelEdit.Enabled = true;

                    btnDisable.Enabled = true;
                    btnEnable.Enabled = true;

                    //labels
                    //lblDiscountIDTextValid.Visible = false;

                    //Text boxes
                    tbxEmployee.ReadOnly = true;

                    blnEdit = true;
                    break;
                default:

                    break;
            }
        }


    }
}