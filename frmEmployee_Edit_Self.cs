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
    public partial class frmEmployee_Edit_Self : Form
    {
        public frmEmployee_Edit_Self()
        {
            InitializeComponent();
        }
        StringBuilder strCreate = new StringBuilder();
        CurrencyManager personManager;
        private void frmEmployee_Edit_Self_Load(object sender, EventArgs e)
        {
            ProgOps.CustomerEdit(tbxTitle, tbxFirstName, tbxMiddleName, tbxLastName, tbxSuffix, tbxAddress1, tbxAddress2, tbxAddress3, tbxCity, tbxZipcode, cbxState, tbxEmail, mtbPhone1, mtbPhone2);
            personManager = (CurrencyManager)this.BindingContext[ProgOps.GetPersonTable];
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            bool blnValid = true;
            strCreate.Clear();

            //Query To Add New Person To Database
            strCreate.Append("Update OrtizB21Su2332.Person" +
                " Set ");

            //Title
            if (tbxTitle.Text != string.Empty)
            {
                strCreate.Append("Title = '" + tbxTitle.Text + "',");
            }
            else
            {
                strCreate.Append("Title = NULL ,");
            }

            //First Name
            if (tbxFirstName.Text == String.Empty)
            {
                blnValid = false;
                lblErrorFirstName.Visible = true;
            }
            else
            {
                lblErrorFirstName.Visible = false;
                strCreate.Append("NameFirst = '" + tbxFirstName.Text + "',");
            }


            //Middle Name
            if (tbxMiddleName.Text != string.Empty)
            {
                strCreate.Append("NameMiddle = '" + tbxMiddleName.Text + "',");
            }
            else
            {
                strCreate.Append("NameMiddle = NULL ,");
            }


            //Last Name
            if (tbxLastName.Text == String.Empty)
            {
                blnValid = false;
                lblErrorLastName.Visible = true;
            }
            else
            {
                lblErrorLastName.Visible = false;
                strCreate.Append("NameLast = '" + tbxLastName.Text + "',");
            }

            //Suffix
            if (tbxSuffix.Text != string.Empty)
            {
                strCreate.Append("Suffix = '" + tbxSuffix.Text + "',");
            }
            else
            {
                strCreate.Append("Suffix = NULL ,");
            }



            //Address1
            if (tbxAddress1.Text == String.Empty)
            {
                blnValid = false;
                lblErrorAddress1.Visible = true;
            }
            else
            {
                lblErrorAddress1.Visible = false;
                strCreate.Append("Address1 = '" + tbxAddress1.Text + "',");
            }


            //Address 2
            if (tbxAddress2.Text != string.Empty)
            {
                strCreate.Append("Address2 = '" + tbxAddress2.Text + "',");
            }
            else
            {
                strCreate.Append("Address2 = NULL ,");
            }


            //Address 3
            if (tbxAddress3.Text != string.Empty)
            {
                strCreate.Append("Address3 = '" + tbxAddress3.Text + "',");
            }
            else
            {
                strCreate.Append("Address3 = NULL ,");
            }

            //City   
            if (tbxCity.Text == String.Empty)
            {
                blnValid = false;
                lblErrorCity.Visible = true;
            }
            else
            {
                lblErrorCity.Visible = false;
                strCreate.Append("City = '" + tbxCity.Text + "',");
            }

            //Zipcode
            if (tbxZipcode.Text == String.Empty || tbxZipcode.Text.Length < 5)
            {
                lblErrorZipcode.Visible = true;
                blnValid = false;
            }
            else
            {
                lblErrorZipcode.Visible = false;
                strCreate.Append("Zipcode = '" + tbxZipcode.Text + "',");
            }


            //State
            if (cbxState.Text == String.Empty)
            {
                blnValid = false;
                lblErrorState.Visible = true;
            }
            else
            {
                lblErrorState.Visible = false;
                strCreate.Append("State = '" + cbxState.Text + "',");
            }

            //Email
            if (tbxEmail.Text == String.Empty)
            {
                blnValid = false;
                lblErrorEmail.Visible = true;
            }
            else
            {
                lblErrorEmail.Visible = false;
                strCreate.Append("Email = '" + tbxEmail.Text + "',");
            }

            //Phone 1
            if (mtbPhone1.MaskCompleted != true)
            {
                lblErrorPhonePrimary.Visible = true;
                blnValid = false;
            }
            else
            {
                lblErrorPhonePrimary.Visible = false;
                strCreate.Append("PhonePrimary = '" + mtbPhone1.Text + "',");
            }


            //Phone 2
            if (mtbPhone2.MaskCompleted != true)
            {
                mtbPhone2.Text = string.Empty;
                strCreate.Append(" PhoneSecondary = NULL ");

            }
            else
            {
                lblErrorPhoneSecondary.Visible = false;
                strCreate.Append("PhoneSecondary = '" + mtbPhone2.Text + "'");
            }

            MessageBox.Show(strCreate.ToString());
            if (blnValid == true)
            {
                strCreate.Append(" Where PersonID = " + ProgOps._intPersonID);
                ProgOps.CreateNewUser(tbxTitle, tbxFirstName, tbxMiddleName, tbxLastName, tbxSuffix, tbxAddress1, tbxAddress2, tbxAddress3, tbxCity, tbxZipcode, cbxState, tbxEmail, mtbPhone1, mtbPhone2, strCreate.ToString());
                MessageBox.Show("Information Edited! ", "Edited", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
