﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//TO DO : VALIDATION!!!!


namespace SU21_Final_Project
{
    public partial class frmSecurityQuestions : Form
    {
        public frmSecurityQuestions()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool blnPass = true;

            //We will add all the validation here later. 
            if(tbxUsername.Text == "")
            {
                MessageBox.Show("Username Cannot Be The Same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                blnPass = false;
            }
            if (tbxPassword.Text == "")
            {
                MessageBox.Show("Password Cannot Be The Same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                blnPass = false;
            }
            if (tbxSQAnswer1.Text == "")
            {
                MessageBox.Show("Security Question Answer 1 Cannot Be The Same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                blnPass = false;
            }
            if (tbxSQAnswer2.Text == "")
            {
                MessageBox.Show("Security Question Answer 2 Cannot Be The Same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                blnPass = false;
            }


            if (cmbSQuestion1.Text == cmbSQuestion2.Text)
            {
                MessageBox.Show("Security Questions Cannot Be The Same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                blnPass = false;
            }

            if(blnPass == true)
            {
                string query = "Insert into OrtizB21Su2332.LogOn(PersonID , UserName , Password , SQuestion1 , SQAnswer1 , SQuestion2 , SQAnswer2) " +
                "values(" + ProgOps.intPersonID + ",'" + tbxUsername.Text + "','" + tbxPassword.Text + "','" + cmbSQuestion1.Text + "','" + tbxSQAnswer1.Text + "','" + cmbSQuestion2.Text + "','" + tbxSQAnswer2.Text + "');";
                ProgOps.CreateLogIn(tbxUsername, tbxPassword, cmbSQuestion1, tbxSQAnswer1, cmbSQuestion2, tbxSQAnswer2, query);

                MessageBox.Show("Welcome To The Shop! ", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
           
        }

        private void frmSecurityQuestions_Load(object sender, EventArgs e)
        {
            ProgOps.GrabPersonID();
        }
    }
}
