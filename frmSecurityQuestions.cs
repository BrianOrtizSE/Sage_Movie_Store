using System;
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
        string strQuery;
        private void btnAdd_Click(object sender, EventArgs e)
        {

            bool blnPass = true;
            tbxSQAnswer1.Text.ToLower();
            tbxSQAnswer2.Text.ToLower();
            tbxSQAnswer3.Text.ToLower();

            tbxSQAnswer1.Text.Trim();
            tbxSQAnswer2.Text.Trim();
            tbxSQAnswer3.Text.Trim();
           
            //We will add all the validation here later. 
            if (tbxUsername.Text == String.Empty || tbxUsername.Text.Length < 6 || tbxUsername.Text.Length > 20)
            {
                lblErrorUserName.Visible = true;
                blnPass = false;
            }
            else
            {
                lblErrorUserName.Visible = false;
            }


            //VALIDATION FOR PASSWORD
            //bool to tell if password has a number
            bool hasNumber = false;

            for (int i = 0; i < tbxPassword.Text.Length; i++)
            {
                if (Char.IsDigit(tbxPassword.Text[i]))
                {
                    hasNumber = true;
                    break;
                }
            }

            //int to track the number of symbols found in password
            int symbolCtr = 0;

            for (int i = 0; i < tbxPassword.Text.Length; i++)
            {
                //Check each character to see if it's a symbol
                //Note: Char.IsSymbol() did not actually work here
                if (!Char.IsLetter(tbxPassword.Text[i]) &&
                    !Char.IsDigit(tbxPassword.Text[i]))
                {
                    symbolCtr++;
                }
            }

            if (tbxPassword.Text == String.Empty || tbxPassword.Text.Length > 20 || tbxPassword.Text.Length < 8 || !hasNumber || symbolCtr < 2)
            {
                lblErrorPassword.Visible = true;
                blnPass = false;
                Console.WriteLine(symbolCtr);
                Console.WriteLine(hasNumber);
            }
            else
            {
                lblErrorPassword.Visible = false;
            }

            if (tbxRetypePassword.Text != tbxPassword.Text)
            {
                lblErrorRetype.Visible = true;
                blnPass = false;
            }
            else
            {
                lblErrorRetype.Visible = false;
            }

            if (tbxSQAnswer1.Text == String.Empty)
            {
                lblErrorSQA1.Visible = true;
                blnPass = false;
            }
            else
            {
                lblErrorSQA1.Visible = false;
            }


            if (tbxSQAnswer2.Text == String.Empty)
            {
                lblErrorSQA2.Visible = true;
                blnPass = false;
            }
            else
            {
                lblErrorSQA2.Visible = false;
            }

            if (tbxSQAnswer3.Text == String.Empty)
            {
                lblErrorSQA3.Visible = true;
                blnPass = false;
            }
            else
            {
                lblErrorSQA3.Visible = false;
            }


            if (cmbSQuestion1.Text == cmbSQuestion2.Text || cmbSQuestion2.Text == cmbQuestion3.Text || cmbSQuestion1.Text == cmbQuestion3.Text)
            {
                MessageBox.Show("Security Questions Cannot Be The Same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                blnPass = false;
            }



            strQuery = "Select * From OrtizB21Su2332.LogOn Where Username like '" + tbxUsername.Text + "'";
             ProgOps.CheckPassword(strQuery);

            if(ProgOps._blnFound == true)
            {
                MessageBox.Show("Username already taken!", "Username Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (blnPass == true)
                {                    

                    strQuery = "Insert into OrtizB21Su2332.LogOn(PersonID , UserName , Password , SQuestion1 , SQAnswer1 , SQuestion2 , SQAnswer2 , SQuestion3 , SQAnswer3) " +
                    "values(" + ProgOps._intPersonID + ",'" + tbxUsername.Text + "','" + tbxPassword.Text + "','" + cmbSQuestion1.Text + "','" + tbxSQAnswer1.Text + "','" + cmbSQuestion2.Text + "','" + tbxSQAnswer2.Text
                    + "','" + cmbQuestion3.Text + "','" + tbxSQAnswer3.Text + "');";
                    ProgOps.CreateLogIn(tbxUsername, tbxPassword, cmbSQuestion1, tbxSQAnswer1, cmbSQuestion2, tbxSQAnswer2, cmbQuestion3, tbxSQAnswer3, strQuery);

                    MessageBox.Show("Welcome To The Store! ", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                }
            }

            

        }

        private void frmSecurityQuestions_Load(object sender, EventArgs e)
        {
            ProgOps.GrabPersonNewID();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbxUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Only allow letters and backspace
            if (e.KeyChar >= 65 && e.KeyChar <= 90 ||       //ASCII Check for Capital Letters
               e.KeyChar >= 97 && e.KeyChar <= 122 ||       //ASCII Check for Lowercase Letters
                e.KeyChar >= 48 && e.KeyChar <= 57 ||       //ASCII Check For Numbers
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

        private void tbxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 32)
            {
                //Prevent spaces from being entered into the password textbox
                e.Handled = true;
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHelp frmhelp = new frmHelp();
            ProgOps._PICTURE = 4;
            this.Hide();
            frmhelp.ShowDialog();
            this.Show();
        }
    }
}
