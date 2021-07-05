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

            if (rdbCustomer.Checked == false && rdbEmployee.Checked == false)
            {
                MessageBox.Show("Customer Or Employee Must Be Checked", "Customer Or Employee", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                blnPass = false;
            }
            else
            {
                if (rdbEmployee.Checked && tbxUsername.Text == String.Empty)
                {
                    lblErrorText.Visible = true;
                    blnPass = false;
                }
            }


            if (blnPass == false)
            {
                MessageBox.Show("Please Fix All Incorrect Informatoion", "Incorect Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                ProgOps.LogOn(tbxUsername, tbxPassword, rdbCustomer, rdbEmployee, Text);
                if (ProgOps.blnFound == true)
                {
                    frmCustomer_Main frmcustomermain = new frmCustomer_Main();
                    this.Hide();
                    frmcustomermain.ShowDialog();
                    this.Close();
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
    }
}
