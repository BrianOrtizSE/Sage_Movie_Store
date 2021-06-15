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
            strCreate.Clear();
            bool blnPass = true;
            //Query To Add New Person To Database
            strCreate.Append("INSERT INTO OrtizB21Su2332.Person(Title , NameFirst , NameMiddle ,NameLast , Suffix , Address1 , Address2 , Address3 , City , Zipcode , State , Email , PhonePrimary , PhoneSecondary)" +
                "Values(");

            //Title
            if (tbxTitle.Text == "")
            {
                strCreate.Append("NULL,'");
            }
            else
            {
                strCreate.Append("'" + tbxTitle.Text + "','");
            }

            //First Name
            if(tbxFirstName.Text == "")
            {
                MessageBox.Show("First Name Must Not Be Empty");
                blnPass = false;
            }
            else
            {
                strCreate.Append(tbxFirstName.Text + "',");
            }
            

            //Middle Name
            if (tbxMiddleName.Text == "")
            {
                strCreate.Append("NULL,'");
            }
            else
            {
                strCreate.Append("'" + tbxMiddleName.Text + "','");
            }

            //Last Name
            if (tbxLastName.Text == "")
            {
                MessageBox.Show("Last Name Must Not Be Empty");
                blnPass = false;
            }
            else
            {
                strCreate.Append(tbxLastName.Text + "',");
            }

            //Suffix
            if (tbxSuffix.Text == "")
            {
                strCreate.Append("NULL,'");
            }
            else
            {
                strCreate.Append("'" + tbxSuffix.Text + "','");
            }

            //Address1
            if (tbxAddress1.Text == "")
            {
                MessageBox.Show("Adress1 Name Must Not Be Empty");
                blnPass = false;
            }
            else
            {
                strCreate.Append(tbxAddress1.Text + "',");
            }

            //Address 2
            if (tbxAddress2.Text == "")
            {
                strCreate.Append("NULL,'");
            }
            else
            {
                strCreate.Append("'" + tbxAddress2.Text + "',");
            }
            
            //Address 3
            if (tbxAddress3.Text == "")
            {
                strCreate.Append("NULL,'");
            }
            else
            {
                strCreate.Append("'" + tbxAddress3.Text + "','");
            }

            //City            
            if (tbxZipcode.Text == "")
            {
                MessageBox.Show("City Name Must Not Be Empty");
                blnPass = false;
            }
            else
            {
                strCreate.Append(tbxCity.Text + "','");
            }

            //Zipcode
            if (tbxZipcode.Text == "")
            {
                MessageBox.Show("Zipcode Name Must Not Be Empty");
                blnPass = false;
            }
            else
            {
                strCreate.Append(tbxZipcode.Text + "','"); ;
            }


            //State
            if (tbxState.Text == "")
            {
                MessageBox.Show("State Name Must Not Be Empty");
                blnPass = false;
            }
            else
            {
                strCreate.Append(tbxState.Text + "','"); ;
            }

            //Email
            if (tbxEmail.Text == "")
            {
                MessageBox.Show("Email Must Not Be Empty");
                blnPass = false;
            }
            else
            {
                strCreate.Append(tbxEmail.Text + "','"); ;
            }

            //Phone 1
            if (tbxPhonePrimary.Text == "")
            {
                MessageBox.Show("Phone Must Not Be Empty");
                blnPass = false;
            }
            else
            {
                strCreate.Append(tbxPhonePrimary.Text + "',"); ;
            }

            //Phone 2
            if (tbxPhoneSecond.Text == "")
            {
                strCreate.Append("NULL)");
            }
            else
            {
                strCreate.Append("'" + tbxPhoneSecond.Text + "')");
            }

            MessageBox.Show(strCreate.ToString());

            if (blnPass == true)
            {
                ProgOps.CreateNewUser(tbxTitle, tbxFirstName, tbxMiddleName, tbxLastName, tbxSuffix, tbxAddress1, tbxAddress2, tbxAddress3, tbxCity, tbxZipcode, tbxState, tbxEmail, tbxPhonePrimary, tbxPhoneSecond, strCreate.ToString());
                frmSecurityQuestions frmquesiton = new frmSecurityQuestions();
                frmquesiton.ShowDialog();
                this.Close();
            }

        }

        private void frmSignUp_Load(object sender, EventArgs e)
        {
            //Close Things To Do
        }
    }
}
