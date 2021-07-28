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
    public partial class frmEmployee_Edit_Customer : Form
    {
        public frmEmployee_Edit_Customer()
        {
            InitializeComponent();
        }
        CurrencyManager personManager;
        private void frmEmployee_Edit_Customer_Load(object sender, EventArgs e)
        {
            ProgOps.CustomerEdit(tbxTitle, tbxFirstName, tbxMiddleName, tbxLastName, tbxSuffix, tbxAddress1, tbxAddress2, tbxAddress3, tbxCity, tbxZipcode, cbxState, tbxEmail, mtbPhone1, mtbPhone2);
            personManager = (CurrencyManager)this.BindingContext[ProgOps.GetPersonTable];
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
