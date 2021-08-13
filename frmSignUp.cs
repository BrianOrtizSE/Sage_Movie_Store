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
    public partial class frmSignUp : Form
    {
        StringBuilder strCreate = new StringBuilder();
        public frmSignUp()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool blnValid = true;
            strCreate.Clear();

            //Query To Add New Person To Database
            strCreate.Append("INSERT INTO OrtizB21Su2332.Person(Title , NameFirst , NameMiddle ,NameLast , Suffix , Address1 , Address2 , Address3 , City , Zipcode , State , Email , PhonePrimary , PhoneSecondary)" +
                "Values(");


            if (tbxTitle.Text.Length > 15)
            {
                blnValid = false;
                lblErrorTitle.Visible = true;
            }
            else {
                lblErrorTitle.Visible = false;
                //Title
                if (tbxTitle.Text == String.Empty)
                {
                    strCreate.Append("NULL,'");
                }
                else
                {
                    strCreate.Append("'" + tbxTitle.Text + "','");
                }
            }

            //First Name
            if (tbxFirstName.Text == String.Empty || tbxFirstName.Text.Length > 20)
            {
                blnValid = false;
                lblErrorFirstName.Visible = true;
            }
            else
            {
                lblErrorFirstName.Visible = false;
                strCreate.Append(tbxFirstName.Text + "',");
            }


            //Middle Name
            if (tbxMiddleName.Text.Length > 20)
            {
                blnValid = false;
                lblErrorMiddleName.Visible = true;
            }
            else
            {
                lblErrorMiddleName.Visible = false;
                if (tbxMiddleName.Text == String.Empty)
                {
                    strCreate.Append("NULL,'");
                }
                else
                {
                    strCreate.Append("'" + tbxMiddleName.Text + "','");
                }
            }


            //Last Name
            if (tbxLastName.Text == String.Empty || tbxLastName.Text.Length > 20)
            {
                lblErrorLastName.Visible = true;
                blnValid = false;
            }
            else
            {
                lblErrorLastName.Visible = false;
                strCreate.Append(tbxLastName.Text + "',");
            }

            //Suffix
            if (tbxSuffix.Text.Length > 20)
            {
                lblErrorSuffix.Visible = true;
            }
            else
            {
                lblErrorSuffix.Visible = false;
                if (tbxSuffix.Text == String.Empty)
                {
                    strCreate.Append("NULL,'");
                }
                else
                {
                    strCreate.Append("'" + tbxSuffix.Text + "','");
                }

            }


            //Address1
            if (CheckAddress(tbxAddress1) == false)
            {
                blnValid = false;
                lblErrorAddress1.Visible = true;
            }
            else
            {
                lblErrorAddress1.Visible = false;
                strCreate.Append(tbxAddress1.Text + "',");
            }


            //Address 2
            if (tbxAddress2.Text.Length > 30)
            {
                lblErrorAddress2.Visible = true;
                blnValid = false;
            }
            else
            {
                lblErrorAddress2.Visible = false;
                if (tbxAddress2.Text == String.Empty)
                {
                    strCreate.Append("NULL,");
                }
                else
                {
                    strCreate.Append("'" + tbxAddress2.Text + "',");
                }
            }


            //Address 3
            if (tbxAddress3.Text.Length > 30)
            {
                lblErrorAddress3.Visible = true;
                blnValid = false;
            }
            else
            {
                lblErrorAddress3.Visible = false;
                if (tbxAddress3.Text == String.Empty)
                {
                    strCreate.Append("NULL,'");
                }
                else
                {
                    strCreate.Append("'" + tbxAddress3.Text + "','");
                }
            }


            //City   
            if (tbxCity.Text == String.Empty || tbxCity.Text.Length < 3|| tbxCity.Text.Length > 30)
            {
                lblErrorCity.Visible = true;
                blnValid = false;
            }
            else
            {
                lblErrorCity.Visible = false;
                strCreate.Append(tbxCity.Text + "','");
            }

            //Zipcode
            if (tbxZipcode.Text == String.Empty || tbxZipcode.Text.Length > 10 || tbxZipcode.Text.Length < 5)
            {
                lblErrorZipcode.Visible = true;
                blnValid = false;
            }
            else
            {
                lblErrorZipcode.Visible = false;
                strCreate.Append(tbxZipcode.Text + "','"); ;
            }


            //State
            if (cbxState.Text == String.Empty || cbxState.Text.Length > 2)
            {
                blnValid = false;
                lblErrorState.Visible = true;
            }
            else
            {
                lblErrorState.Visible = false;
                strCreate.Append(cbxState.Text + "','"); ;
            }

            //Email
            if (CheckEmail(tbxEmail) == false)
            {
                blnValid = false;
                lblErrorEmail.Visible = true;
            }
            else
            {
                lblErrorEmail.Visible = false;
                strCreate.Append(tbxEmail.Text + "','"); ;
            }

            //Phone 1
            if (mtbPhone1.MaskCompleted != true || mtbPhone1.Text.Length > 20)
            {
                lblErrorPhonePrimary.Visible = true;
                blnValid = false;
            }
            else
            {
                lblErrorPhonePrimary.Visible = false;
                strCreate.Append(mtbPhone1.Text + "',"); ;
            }


            //Phone 2
            if (mtbPhone2.Text.Length > 20)
            {
                lblErrorPhoneSecondary.Visible = true;
                
                blnValid = false;
            }
            else
            {
                if(mtbPhone2.MaskCompleted != true)
                {
                    mtbPhone2.Text = "";
                    strCreate.Append("NULL)");

                }
                else
                {
                    lblErrorPhoneSecondary.Visible = false;
                    strCreate.Append("'" + mtbPhone2.Text + "')");
                }
            }

            if (blnValid == true)
            {
                ProgOps.CreateNewUser(tbxTitle, tbxFirstName, tbxMiddleName, tbxLastName, tbxSuffix, tbxAddress1, tbxAddress2, tbxAddress3, tbxCity, tbxZipcode, cbxState, tbxEmail, mtbPhone1, mtbPhone2, strCreate.ToString());
                frmSecurityQuestions frmquesiton = new frmSecurityQuestions();
                frmquesiton.ShowDialog();
                this.Close();
            }

        }

        private void frmSignUp_Load(object sender, EventArgs e)
        {
            //Close Things To Do
        }


        //KEY PRESS EVENTS SO THAT PEOPLE CANT TYPE IN INCORRECT INFORMATION

        private void tbxTitle_KeyPress(object sender, KeyPressEventArgs e)
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
        private void tbxFirstName_KeyPress(object sender, KeyPressEventArgs e)
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
        private void tbxMiddleName_TextChanged(object sender, EventArgs e)
        {

        }
        private void tbxMiddleName_KeyPress(object sender, KeyPressEventArgs e)
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
        private void tbxLastName_KeyPress(object sender, KeyPressEventArgs e)
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
        private void tbxSuffix_KeyPress(object sender, KeyPressEventArgs e)
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
        private void tbxAddress1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Only allow letters and backspace
            if (e.KeyChar >= 65 && e.KeyChar <= 90 ||       //ASCII Check for Capital Letters
                e.KeyChar == 32 ||                          //ASCII Check For Spacebar
                e.KeyChar >= 48 && e.KeyChar <= 57 ||       //ASCII Check for Numbers
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
        private void tbxAddress2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Only allow letters and backspace
            if (e.KeyChar >= 65 && e.KeyChar <= 90 ||       //ASCII Check for Capital Letters
                e.KeyChar == 32 ||                          //ASCII Check For Spacebar
                e.KeyChar >= 48 && e.KeyChar <= 57 ||       //ASCII Check for Numbers
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
        private void tbxAddress3_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Only allow letters and backspace
            if (e.KeyChar >= 65 && e.KeyChar <= 90 ||       //ASCII Check for Capital Letters
                e.KeyChar == 32 ||                          //ASCII Check For Spacebar
                e.KeyChar >= 48 && e.KeyChar <= 57 ||       //ASCII Check for Numbers
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
        private void tbxCity_KeyPress(object sender, KeyPressEventArgs e)
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
        private void tbxZipcode_KeyPress(object sender, KeyPressEventArgs e)
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
        private void tbxState_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Only allow Captital Letters
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
        private void mtbPhone1_KeyPress(object sender, KeyPressEventArgs e)
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
        private void mtbPhone2_KeyPress(object sender, KeyPressEventArgs e)
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
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnsHelp_Click(object sender, EventArgs e)
        {
            frmHelp frmhelp = new frmHelp();
            ProgOps._PICTURE = 2;
            this.Hide();
            frmhelp.ShowDialog();
            this.Show();
        }

        private void tbxEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 39 || e.KeyChar == 34)    //ASCII Check For colon and semicolon

            {
                //Allow the key press
                e.Handled = true;
            }
            else
            {
                //Deny the key press
                e.Handled = false;
            }
        }
        private void mtbPhone1_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                mtbPhone1.Select(0, 0);
            });
        }
        private void mtbPhone2_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                mtbPhone2.Select(0, 0);
            });
        }
        private void tbxAddress1_TextChanged(object sender, EventArgs e)
        {

        }
        bool CheckAddress(TextBox tbxtext)
        {
            //VALIDATION FOR PASSWORD
            //bool to tell if password has a number
            bool hasNumber = false;
            for (int i = 0; i < tbxtext.Text.Length; i++)
            {
                if (Char.IsDigit(tbxtext.Text[i]))
                {
                    hasNumber = true;
                    break;
                }
            }

            if (tbxtext.Text == String.Empty || tbxtext.Text.Length < 8 || !hasNumber )
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        bool CheckEmail(TextBox tbxText)
        {
            if (tbxText.Text == String.Empty || !tbxText.Text.Contains("@") || tbxText.Text.Length < 6)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
