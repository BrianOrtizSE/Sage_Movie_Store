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
            string strQuery;

            //While Creating New Password Do This: 
            if (lblUsername.Text == "Enter New Password: ")
            {
                lblPasswordValid.Visible = true;
                if (ProgOps._blnFound == true)
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
                        //Note: Char.IsSymbol() did not actually work here
                        if (!Char.IsLetter(tbxUsername.Text[i]) &&
                            !Char.IsDigit(tbxUsername.Text[i]))
                        {
                            symbolCtr++;
                        }
                    }

                    if (tbxUsername.Text == String.Empty || tbxUsername.Text.Length < 8 || !hasNumber || symbolCtr < 1)
                    {
                        MessageBox.Show("Please Create A New Valid Password", "Password Invalid ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        strQuery = "Update OrtizB21Su2332.LogOn SET Password = '" + tbxUsername.Text + "' WHERE PersonID = " + ProgOps._intPersonID;
                        ProgOps.UpdatePassword(strQuery);
                        MessageBox.Show("Password Changed", "Password Change", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.Close();
                    }

                    cmbSQ.Visible = false;
                    tbxSQA.Visible = false;
                    btnSSearch.Visible = false;
                }
            }
            else
            {
                //Check to see if entered username is real , if it is continue if not let em know.
                strQuery = "Select Username From OrtizB21Su2332.LogOn " +
                     "Where Username = '" + tbxUsername.Text + "'";
                ProgOps.GrabPassword(strQuery);

                if (ProgOps._blnFound == false)
                {
                    MessageBox.Show("Username not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    strQuery = "Select PersonID From OrtizB21Su2332.LogOn " +
                        "Where Username = '" + tbxUsername.Text + "'";
                    ProgOps.GrabPersonID(strQuery);

                    //Low Tier Set View
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


        private void btnSSearch_Click(object sender, EventArgs e)
        {
            intSearch++;
            //Call Find Password To Beggin Search For User
            FindPassword();
        }

        public void FindPassword()
        {

            ProgOps._blnFound = false;
            string strQuery;

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
                        if (ProgOps._blnFound == true)
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
                    cmbSQ.SelectedIndex = -1;
                    tbxSQA.Clear();
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
                        if (ProgOps._blnFound == true)
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
                    cmbSQ.SelectedIndex = -1;
                    tbxSQA.Clear();
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
                        if (ProgOps._blnFound == true)
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
                    cmbSQ.SelectedIndex = -1;
                    tbxSQA.Clear();
                    break;

                default:
                    MessageBox.Show("Error On intSearch", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

            }

            if(ProgOps._blnFound == true)
            {
                lblUsername.Text = "Enter New Password: ";
                lblPasswordValid.Visible = true;
                btnSearch.Text = "Update";

                tbxUsername.Enabled = true;
                tbxUsername.Clear();
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

        //Below key press so that user cannot type in wrong information
        private void tbxUsername_KeyPress(object sender, KeyPressEventArgs e)
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
        private void tbxSQA_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Only allow letters and backspace
            if (e.KeyChar >= 65 && e.KeyChar <= 90 ||       //ASCII Check for Capital Letters
               e.KeyChar >= 97 && e.KeyChar <= 122 ||       //ASCII Check for Lowercase Letters
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

        private void mnsHelp_Click(object sender, EventArgs e)
        {
            ProgOps._PICTURE = 9;
            frmHelp frmhelp = new frmHelp();
            frmhelp.ShowDialog();
            
        }
    }
}