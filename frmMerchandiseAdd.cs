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
    public partial class frmMerchandiseAdd : Form
    {
        public frmMerchandiseAdd()
        {
            InitializeComponent();
        }

        //Set up merchandise CurrencyManager
        CurrencyManager prodManager;

        //Future variables for state and bookmark
        string myState = "";
        //int myBookmark = 0;

        private void frmMerchandiseAdd_Load(object sender, EventArgs e)
        {
            try
            {
                //Load in the Products table from the database
                ProgOps.MerchandiseAdd(tbxProductID, tbxProductName, tbxGenre, tbxQuantity, tbxPrice, tbxDescription , cmbInStock);

                //Fill the currency manager
                prodManager = (CurrencyManager)this.BindingContext[ProgOps.GetProductTable];

                //Start in view state
                //SetState("View");

                //lblUserId.Text = ProgOps.userFirstName;

                //DateTime localDate = DateTime.Now;
                //lblDate.Text = localDate.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error : Products Table ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
