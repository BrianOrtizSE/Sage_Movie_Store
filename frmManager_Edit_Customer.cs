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
    public partial class frmManager_Edit_Customer : Form
    {
        public frmManager_Edit_Customer()
        {
            InitializeComponent();
        }
        string strQuery;
        private void frmManager_Edit_Customer_Load(object sender, EventArgs e)
        {
            GrabPersson();
        }

        public void GrabPersson()
        {
            strQuery = "Select PersonID , NameFirst , NameLast , Address1 , City , Zipcode , State , Email , PhonePrimary From OrtizB21Su2332.Person Where isActive = 1";
            ProgOps.GrabEmployee(dgvPerson, strQuery); // CHANGE TO A DIFFERENT FUNCITION LATER


            dgvPerson.Columns[0].HeaderText = "Person ID ";
            dgvPerson.Columns[1].HeaderText = "First Name";
            //dgvPerson.Columns[3].DefaultCellStyle.Format = "c2";
            dgvPerson.Columns[2].HeaderText = "Last Name";
            dgvPerson.Columns[3].HeaderText = "Address 1";
            dgvPerson.Columns[4].HeaderText = "City";
            dgvPerson.Columns[5].HeaderText = "Zpcode";
            dgvPerson.Columns[6].HeaderText = "State";
            dgvPerson.Columns[7].HeaderText = "Email";
            dgvPerson.Columns[8].HeaderText = "Primary Phone";
        }

        private void dgvPerson_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {

            }
            else if (dgvPerson.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvPerson.CurrentRow.Selected = true;
                tbxPersonID.Text = dgvPerson.Rows[e.RowIndex].Cells["PersonID"].Value.ToString();
                tbxNameFirst.Text = dgvPerson.Rows[e.RowIndex].Cells["NameFirst"].Value.ToString();
                tbxNameLast.Text = dgvPerson.Rows[e.RowIndex].Cells["NameLast"].Value.ToString();
                tbxAddress1.Text = dgvPerson.Rows[e.RowIndex].Cells["Address1"].Value.ToString();
                tbxCity.Text = dgvPerson.Rows[e.RowIndex].Cells["City"].Value.ToString();
                tbxZipcode.Text = dgvPerson.Rows[e.RowIndex].Cells["Zipcode"].Value.ToString();
                tbxState.Text = dgvPerson.Rows[e.RowIndex].Cells["State"].Value.ToString();
                tbxEmail.Text = dgvPerson.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                tbxPhone.Text = dgvPerson.Rows[e.RowIndex].Cells["PhonePrimary"].Value.ToString();
            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)//Brings up edit form
        {
            if(tbxPersonID.Text == string.Empty)
            {
                MessageBox.Show("Please Choose A Customer To Edit", "Employee Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ProgOps._intPersonID = int.Parse(tbxPersonID.Text);
                this.Hide();
                frmEmployee_Edit_Customer frmEmpEditCus = new frmEmployee_Edit_Customer();
                frmEmpEditCus.ShowDialog();
                this.Show();
                GrabPersson();
                Clear();
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)//close this form
        {
            this.Close();
        }

        private void btnShowDIsabled_Click(object sender, EventArgs e)//Display Inactive Customers
        {
            strQuery = "Select PersonID , NameFirst , NameLast , Address1 , City , Zipcode , State , Email , PhonePrimary From OrtizB21Su2332.Person Where isActive = 0";
            ProgOps.GrabEmployee(dgvPerson, strQuery); // CHANGE TO A DIFFERENT FUNCITION LATER

            if(ProgOps._blnFound == false)
            {

            }
            else
            {
                dgvPerson.Columns[0].HeaderText = "Person ID ";
                dgvPerson.Columns[1].HeaderText = "First Name";
                //dgvPerson.Columns[3].DefaultCellStyle.Format = "c2";
                dgvPerson.Columns[2].HeaderText = "Last Name";
                dgvPerson.Columns[3].HeaderText = "Address 1";
                dgvPerson.Columns[4].HeaderText = "City";
                dgvPerson.Columns[5].HeaderText = "Zpcode";
                dgvPerson.Columns[6].HeaderText = "State";
                dgvPerson.Columns[7].HeaderText = "Email";
                dgvPerson.Columns[8].HeaderText = "Primary Phone";

                btnDisableCustomer.Visible = false;
                btnShowDIsabled.Visible = false;

                btnEnable.Visible = true;
                btnShowActive.Visible = true;
                Clear();
            }


        }

        private void btnDisableCustomer_Click(object sender, EventArgs e)//Disable Customer
        {
            if (tbxPersonID.Text == string.Empty)
            {
                MessageBox.Show("Please Choose A Customer To Disable", "Customer Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are You Sure You Want To Disable This Customer", "Conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    strQuery = "Update OrtizB21Su2332.Person Set isActive = 0 Where PersonID = " + tbxPersonID.Text;
                    MessageBox.Show("Customer Has Been Disabled", "Employee Disable", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ProgOps.CreateDiscount(strQuery);
                    GrabPersson();
                    Clear();
                }

            }
        }

        private void btnShowActive_Click(object sender, EventArgs e)//Display Active Customers
        {
            GrabPersson();
            btnDisableCustomer.Visible = true;
            btnShowDIsabled.Visible = true;

            btnEnable.Visible = false;
            btnShowActive.Visible = false;
            Clear();
        }

        private void btnEnable_Click(object sender, EventArgs e)//Enable Customer
        {
            if (tbxPersonID.Text == string.Empty)
            {
                MessageBox.Show("Please Choose A Customer To Activate", "Customer Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are You Sure You Want To Activate This Customer", "Conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    strQuery = "Update OrtizB21Su2332.Person Set isActive = 1 Where PersonID = " + tbxPersonID.Text;
                    MessageBox.Show("Customer Has Been Activated", "Employee Active", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ProgOps.CreateDiscount(strQuery);
                    GrabPersson();
                    Clear();
                    btnShowActive.Visible = false;
                    btnEnable.Visible = false;
                    btnDisableCustomer.Visible = true;
                    btnShowDIsabled.Visible = true;
                }

            }
        }

        public void Clear()
        {
            tbxNameFirst.Clear();
            tbxNameLast.Clear();
            tbxPersonID.Clear();
            tbxZipcode.Clear();
            tbxPhone.Clear();
            tbxState.Clear();
            tbxAddress1.Clear();
            tbxEmail.Clear();
            tbxCity.Clear();
            tbxEmail.Clear();
        }
    }
}
