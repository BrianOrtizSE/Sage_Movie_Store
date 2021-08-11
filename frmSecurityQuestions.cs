using System;
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
        string strQuery;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Ignore Char For SQuestions
            tbxSQAnswer1.Text.ToLower();
            tbxSQAnswer2.Text.ToLower();
            tbxSQAnswer3.Text.ToLower();

            tbxSQAnswer1.Text.Trim();
            tbxSQAnswer2.Text.Trim();
            tbxSQAnswer3.Text.Trim();

            //Cheks Username to make sure it is unique
            strQuery = "Select * From OrtizB21Su2332.LogOn Where Username like '" + tbxUsername.Text + "'";
            ProgOps.CheckPassword(strQuery);

            if (ProgOps._blnFound == true)
            {
                MessageBox.Show("Username already taken!", "Username Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {   //make sure all information is clean and acceptable if it is Welcome them to the store if its not well let them know
                if (lblUsernameValid.Text == "X" || lblPasswordValid.Text == "X" || lblRetypePassword.Text == "X" || lblSQuestion1Valid.Text == "X" || lblSQAnswer1Valid.Text == "X" ||
                    lblSQuestion2Valid.Text == "X" || lblSAnswer2Valid.Text == "X" || lblSQuestion3Valid.Text == "X" || lblSAnswer3Valid.Text == "X")
                {
                    MessageBox.Show("Please Make Sure All Information Is Valid! ", "Incorrect Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
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

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHelp frmhelp = new frmHelp();
            ProgOps._PICTURE = 4;
            this.Hide();
            frmhelp.ShowDialog();
            this.Show();
        }

        private void cbxPassword1_CheckedChanged(object sender, EventArgs e)//Un Hide Password 1
        {
            if (cbxPassword1.Checked)
            {
                tbxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                tbxPassword.UseSystemPasswordChar = true;
            }
        }
        private void cbxPassword2_CheckedChanged(object sender, EventArgs e)//Un Hide Password 2
        {
            if (cbxPassword2.Checked)
            {
                tbxRetypePassword.UseSystemPasswordChar = false;
            }
            else
            {
                tbxRetypePassword.UseSystemPasswordChar = true;
            }
        }


        //ALL UNDER THIS IS VALIDATION FOR DIFFERENT THINGS
        private void tbxUsername_TextChanged(object sender, EventArgs e)//Validation For Username
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
                lblUsernameValid.Text = "X";
                lblUsernameValid.ForeColor = Color.Red;
                Console.WriteLine(symbolCtr + " Username");
                Console.WriteLine(hasNumber + " Username");
            }
            else
            {
                lblUsernameValid.Text = "\u221A";
                lblUsernameValid.ForeColor = Color.Green;
            }

        }
        private void tbxPassword_TextChanged(object sender, EventArgs e)//Validation For Password
        {
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

            if (tbxPassword.Text == String.Empty || tbxPassword.Text.Length < 8 || !hasNumber || symbolCtr < 1)
            {
                lblPasswordValid.Text = "X";
                lblPasswordValid.ForeColor = Color.Red;
                Console.WriteLine(symbolCtr + " Password");
                Console.WriteLine(hasNumber + " Password");
            }
            else
            {
                lblPasswordValid.Text = "\u221A";
                lblPasswordValid.ForeColor = Color.Green;
            }
            //In the case that user changes Password we will X out Retype Password
            if(tbxPassword.Text != tbxRetypePassword.Text)
            {
                lblRetypePasswordValid.Text = "X";
                lblRetypePasswordValid.ForeColor = Color.Red;
            }
            else
            {
                lblRetypePasswordValid.Text = "\u221A";
                lblRetypePasswordValid.ForeColor = Color.Green;
            }

        }
        private void tbxRetypePassword_TextChanged(object sender, EventArgs e)
        {
            if (tbxRetypePassword.Text == String.Empty || tbxRetypePassword.Text != tbxPassword.Text)
            {
                lblRetypePasswordValid.Text = "X";
                lblRetypePasswordValid.ForeColor = Color.Red;
            }
            else
            {
                lblRetypePasswordValid.Text = "\u221A";
                lblRetypePasswordValid.ForeColor = Color.Green;
            }
        }
        private void cmbSQuestion1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSQuestion1.Text == String.Empty || cmbSQuestion1.Text == cmbSQuestion2.Text || cmbSQuestion1.Text == cmbQuestion3.Text)
            {
                lblSQuestion1Valid.Text = "X";
                lblSQuestion1Valid.ForeColor = Color.Red;
            }
            else
            {
                lblSQuestion1Valid.Text = "\u221A";
                lblSQuestion1Valid.ForeColor = Color.Green;
            }
        }
        private void tbxSQAnswer1_TextChanged(object sender, EventArgs e)
        {
            if (tbxSQAnswer1.Text == String.Empty)
            {
                lblSQAnswer1Valid.Text = "X";
                lblSQAnswer1Valid.ForeColor = Color.Red;
            }
            else
            {
                lblSQAnswer1Valid.Text = "\u221A";
                lblSQAnswer1Valid.ForeColor = Color.Green;
            }
        }
        private void cmbSQuestion2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSQuestion2.Text == String.Empty || cmbSQuestion2.Text == cmbSQuestion1.Text || cmbSQuestion2.Text == cmbQuestion3.Text)
            {
                lblSQuestion2Valid.Text = "X";
                lblSQuestion2Valid.ForeColor = Color.Red;
            }
            else
            {
                lblSQuestion2Valid.Text = "\u221A";
                lblSQuestion2Valid.ForeColor = Color.Green;
            }
        }
        private void tbxSQAnswer2_TextChanged(object sender, EventArgs e)
        {
            if (tbxSQAnswer2.Text == String.Empty)
            {
                lblSAnswer2Valid.Text = "X";
                lblSAnswer2Valid.ForeColor = Color.Red;
            }
            else
            {
                lblSAnswer2Valid.Text = "\u221A";
                lblSAnswer2Valid.ForeColor = Color.Green;
            }
        }
        private void cmbQuestion3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbQuestion3.Text == String.Empty || cmbQuestion3.Text == cmbSQuestion1.Text || cmbQuestion3.Text == cmbSQuestion2.Text)
            {
                lblSQuestion3Valid.Text = "X";
                lblSQuestion3Valid.ForeColor = Color.Red;
            }
            else
            {
                lblSQuestion3Valid.Text = "\u221A";
                lblSQuestion3Valid.ForeColor = Color.Green;
            }
        }
        private void tbxSQAnswer3_TextChanged(object sender, EventArgs e)
        {
            if (tbxSQAnswer3.Text == String.Empty)
            {
                lblSAnswer3Valid.Text = "X";
                lblSAnswer3Valid.ForeColor = Color.Red;
            }
            else
            {
                lblSAnswer3Valid.Text = "\u221A";
                lblSAnswer3Valid.ForeColor = Color.Green;
            }
        }
        private void tbxSQAnswer1_KeyPress(object sender, KeyPressEventArgs e)
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
        private void tbxSQAnswer2_KeyPress(object sender, KeyPressEventArgs e)
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
        private void tbxSQAnswer3_KeyPress(object sender, KeyPressEventArgs e)
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
        private void tbxPassword_KeyPress(object sender, KeyPressEventArgs e)
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
        private void tbxRetypePassword_KeyPress(object sender, KeyPressEventArgs e)
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
}
