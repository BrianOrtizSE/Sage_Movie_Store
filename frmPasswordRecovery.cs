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
    public partial class frmPasswordRecovery : Form
    {
        public frmPasswordRecovery()
        {
            InitializeComponent();
        }
        int intSearch = 0;
        string strQuestion;
        string strAnwser;
       
        private void btnSearch_Click(object sender, EventArgs e)
        {
            String strQuery;
            bool blnValid = true;

            if (lblUsername.Text == "Enter New Password: ")
            {
                lblPasswordValid.Visible = true;
                if (ProgOps.blnFound == true)
                {   

                    //VALIDATION FOR PASSWORD
                    //bool to tell if password has a number
                    bool hasNumber = false;

                    for (int i = 0; i < tbxUsername.Text.Length; i++)
                    {
                        if (Char.IsDigit(tbxUsername.Text[i]))
                        {
                            hasNumber = true;
                            break;
                        }
                    }

                    //int to track the number of symbols found in password
                    int symbolCtr = 0;

                    for (int i = 0; i < tbxUsername.Text.Length; i++)
                    {
                        //Check each character to see if it's a symbol
                        if (!Char.IsLetter(tbxUsername.Text[i]) &&
                            !Char.IsDigit(tbxUsername.Text[i]))
                        {
                            symbolCtr++;
                        }
                    }

                    if (tbxUsername.Text == String.Empty || tbxUsername.Text.Length > 20 || tbxUsername.Text.Length < 8 || !hasNumber || symbolCtr < 2)
                    {
                        //lblErrorPassword.Visible = true;
                        blnValid = false;
                        Console.WriteLine(symbolCtr);
                        Console.WriteLine(hasNumber);
                    }
                    else
                    {
                        
                    }

                    if(blnValid == true)
                    {
                        strQuery = "Update OrtizB21Su2332.LogOn SET Password = '" + tbxUsername.Text + "' WHERE PersonID = " + ProgOps.intPersonID;
                        ProgOps.UpdatePassword(strQuery);
                        MessageBox.Show("Password Changed", "Password Change" ,MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Password Must Contain at least 8 letters , 1 Capital , 1 lowercase , 2 Symbols , 1 Number", "Password Invalid ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    

                    cmbSQ.Visible = false;
                    tbxSQA.Visible = false;
                    btnSSearch.Visible = false;
                }
            }
            else
            {
                strQuery = "Select Username From OrtizB21Su2332.LogOn " +
                     "Where Username = '" + tbxUsername.Text + "'";


                ProgOps.GrabPassword(strQuery);

                if (ProgOps.blnFound == false)
                {
                    MessageBox.Show("Username not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    strQuery = "Select PersonID From OrtizB21Su2332.LogOn " +
                        "Where Username = '" + tbxUsername.Text + "'";
                    ProgOps.GrabPersonID(strQuery);

                    btnSearch.Enabled = false;
                    tbxUsername.Enabled = false;

                    lblSecurityText.Visible = true;
                    lblSecurityAnswer.Visible = true;
                    cmbSQ.Visible = true;
                    tbxSQA.Visible = true;
                    btnSSearch.Visible = true;
                }
            }

        }

        private void frmPasswordRecovery_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            intSearch++;
            //Call Find Password To Beggin Search For User
            FindPassword();
        }

        public void FindPassword()
        {

            ProgOps.blnFound = false;
            String strQuery;


            switch (intSearch)
            {

                case 1:
                    
                    //Quick Check To Make Sure SQuestion are not Empty
                    if (cmbSQ.Text == string.Empty || tbxSQA.Text == string.Empty)
                    {
                        MessageBox.Show("Security Question and Security Awnser can not be Empty", "Empty Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        intSearch--;
                    }
                    else
                    {
                        //Search For PersonID using Username , SQ's and SQAnswers
                        strQuery = "Select PersonID From OrtizB21Su2332.LogOn " +
                     "Where SQuestion1 = '" + cmbSQ.Text + "' and SQAnswer1 = '" + tbxSQA.Text + "' and Username = '" + tbxUsername.Text + "'";


                        ProgOps.GrabPassword(strQuery);

                    //If a person is found we set the SQuestions and SQAnswer
                        if (ProgOps.blnFound == true)
                        {
                            strQuestion = "SQuestion1";
                            strAnwser = "SQanswer1";
                            break;
                        }
                        else
                        {
                    //Could Not Find User so we are moving on to the Next question
                            MessageBox.Show("Was unable to confirm Identity continuing to next question.", "Wrong Awnser", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            lblSecurityText.Text = "Security Question 2";
                            lblSecurityAnswer.Text = "Security Answer 2";
                        }
                    }
                    break;

                case 2:

                    if (cmbSQ.Text == string.Empty || tbxSQA.Text == string.Empty)
                    {
                        MessageBox.Show("Security Question and Security Awnser can not be Empty", "Empty Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        intSearch--;
                    }
                    else
                    {
                        strQuery = "Select PersonID From OrtizB21Su2332.LogOn " +
                     "Where SQuestion2 = '" + cmbSQ.Text + "' and SQAnswer2 = '" + tbxSQA.Text + "'and Username = '" + tbxUsername.Text + "'" ;

                        ProgOps.GrabPassword(strQuery);
                        if (ProgOps.blnFound == true)
                        {
                            strQuestion = "SQuestion2";
                            strAnwser = "SQanswer2";
                            break;
                        }
                        else
                        {
                            MessageBox.Show("Was unable to confirm Identity continuing to next question.", "Wrong Awnser", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            lblSecurityText.Text = "Security Question 3";
                            lblSecurityAnswer.Text = "Security Answer 3";
                        }
                    }
                    break;

                case 3:

                    if (cmbSQ.Text == string.Empty || tbxSQA.Text == string.Empty)
                    {
                        MessageBox.Show("Security Question and Security Awnser can not be Empty", "Empty Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        intSearch--;
                    }
                    else
                    {
                        strQuery = "Select PersonID From OrtizB21Su2332.LogOn " +
                     "Where SQuestion3 = '" + cmbSQ.Text + "' and SQAnswer3 = '" + tbxSQA.Text + "'and Username = '" + tbxUsername.Text + "'";

                        ProgOps.GrabPassword(strQuery);
                        if (ProgOps.blnFound == true)
                        {
                            strQuestion = "SQuestion3";
                            strAnwser = "SQanswer3";
                            break;
                        }
                        else
                        {
                            MessageBox.Show("Was unable to confirm Identity closing out of Page.", "Wrong Awnser", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                    break;

                default:
                    MessageBox.Show("Error On intSearch", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

            }

            if(ProgOps.blnFound == true)
            {
                lblUsername.Text = "Enter New Password: ";
                btnSearch.Text = "Update";
                tbxUsername.Enabled = true;
                btnSearch.Enabled = true;
                cmbSQ.Visible = false;
                tbxSQA.Visible = false;
                lblSecurityText.Visible = false;
                lblSecurityAnswer.Visible = false;
                btnSSearch.Visible = false;
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}