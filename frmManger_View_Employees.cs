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
    public partial class frmManger_View_Employees : Form
    {
        public frmManger_View_Employees()
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

        public void GrabEmployee()//Used For Employee Data Grid To Display To Data Grid 
        {
            strQuery = "Select * from OrtizB21Su2332.Employees";
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

                    //labels
                    lblWageTextValid.Visible = true;

                    //textboxes
                    tbxEmployee.Enabled = true;

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

                    //labels
                    //lblDiscountIDTextValid.Visible = false;

                    //Text boxes
                    tbxEmployee.Enabled = false;

                    blnEdit = true;
                    break;
                default:

                    break;
            }
        }

        private void tbxDiscountPercent_TextChanged(object sender, EventArgs e)
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

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
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
        }

        private void btnGetDate_Click(object sender, EventArgs e)
        {
            tbxHireDate.Text = DateTime.Today.ToString();
        }

    }
}