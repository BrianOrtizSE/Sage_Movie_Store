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
            //TODO : MAKE SURE ALL THINGS THAT CANT BE NULL CANNOT BE NULL
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
            strCreate.Append(tbxFirstName.Text + "',");

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
            strCreate.Append(tbxLastName.Text + "',");

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
            strCreate.Append(tbxAddress1.Text + "',");

            //Address 2
            if (tbxAddress2.Text == "")
            {
                strCreate.Append("NULL,");
            }
            else
            {
                strCreate.Append("'" + tbxAddress2.Text + "','");
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
            strCreate.Append(tbxCity.Text + "','");

            //Zipcode
            strCreate.Append(tbxZipcode.Text + "','");

            //State
            strCreate.Append(tbxState.Text + "','");

            //Email
            strCreate.Append(tbxEmail.Text + "','");

            //Phone 1
            strCreate.Append(tbxPhonePrimary.Text + "',");

            //Phone 2
            if (tbxPhoneSecond.Text == "")
            {
                strCreate.Append("NULL)");
            }
            else
            {
                strCreate.Append("'" + tbxAddress3.Text + "')");
            }
            ProgOps.CreateNewUser(tbxTitle, tbxFirstName, tbxMiddleName, tbxLastName, tbxSuffix, tbxAddress1, tbxAddress2, tbxAddress3, tbxCity, tbxZipcode, tbxState, tbxEmail, tbxPhonePrimary, tbxPhoneSecond, strCreate.ToString());
            //frmQuestions frmquesiton = new frmQuestions();
            //frmquesiton.ShowDialog();
        }

        private void frmSignUp_Load(object sender, EventArgs e)
        {
            //Close Things To Do
        }
    }
}
