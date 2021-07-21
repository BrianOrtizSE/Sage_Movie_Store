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
    public partial class frmManager_Discount_Add : Form
    {
        public frmManager_Discount_Add()
        {
            InitializeComponent();
        }
        string strQuery;
        bool allValid = true;

        private void frmManager_Discount_Add_Load(object sender, EventArgs e)
        {
            DisplayDiscount();
            cmxDiscountType.Text = "1";
        }

        private void btnShowDiscount_Click(object sender, EventArgs e)
        {
            DisplayDiscount();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            strQuery = "Select ProductID , ProductName , Quantity , ProductPrice from OrtizB21Su2332.Products";
            ProgOps.GrabDiscounts(dgvDiscount, strQuery);

            dgvDiscount.Columns[0].HeaderText = "Product ID ";
            dgvDiscount.Columns[1].HeaderText = "Product Name";
            dgvDiscount.Columns[2].HeaderText = "Quantity";
            //dgvDiscount.Columns[3].DefaultCellStyle.Format = "c2";
            dgvDiscount.Columns[3].HeaderText = "Product Price";
        }

        public void DisplayDiscount()
        {
            strQuery = "Select * from OrtizB21Su2332.Discount";
            ProgOps.GrabDiscounts(dgvDiscount, strQuery);
            //dgvDiscount.AutoResizeColumn();

            dgvDiscount.Columns[0].HeaderText = "Discount ID ";
            dgvDiscount.Columns[1].HeaderText = "Discount Type";
            dgvDiscount.Columns[2].HeaderText = "Product ID";
            dgvDiscount.Columns[3].HeaderText = "Discount Percent";
            dgvDiscount.Columns[4].HeaderText = "Is Valid";
        }

        private void cmxDiscountType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmxDiscountType.Text == "2")
            {
                tbxProductID.Enabled = true;
            }
            else
            {
                tbxProductID.Enabled = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {




            if (allValid == true)
            {
                if(cmxDiscountType.Text == "1")
                {
                    strQuery = "Insert Into OrtizB21Su2332.Discount(DiscountID , DiscountType , ProductID , DiscountPercent , isValid) " +
                    "values( " + tbxDiscount.Text + "," + cmxDiscountType.Text + ", NULL ," + tbxDiscountPercent.Text + "," + cbxIsValid.Checked;
                }
                else
                {
                    strQuery = "Insert Into OrtizB21Su2332.Discount(DiscountID , DiscountType , ProductID , DiscountPercent , isValid) " +
                    "values( " + tbxDiscount.Text + "," + cmxDiscountType.Text + "," + tbxProductID.Text + "," + tbxDiscountPercent.Text + "," + cbxIsValid.Checked;
                }
                
            }
          
        }

        private void tbxDiscount_TextChanged(object sender, EventArgs e)
        {
            
            if (tbxDiscount.Text.Length != 9)
            {
                allValid = false;
                lblDiscountIDText.Text = "X";
                lblDiscountIDText.ForeColor = Color.Red;               
            }
            if(tbxDiscount.Text.Length == 9)
            {
                allValid = true;
                lblDiscountIDText.ForeColor = Color.Green;
                lblDiscountIDText.Text = "\u221A";
            }
        }

        private void tbxDiscountPercent_TextChanged(object sender, EventArgs e)
        {
            int intDiscountTest = 0;
            if (tbxDiscountPercent.Text == String.Empty)
            {

            }
            else
            {
                intDiscountTest = int.Parse(tbxDiscountPercent.Text);
            }

            

            if (tbxDiscountPercent.Text == String.Empty || intDiscountTest > 95)
            {
                allValid = false;
                lblDiscountPercentValid.Text = "X";
                lblDiscountPercentValid.ForeColor = Color.Red;
            }
            else
            {
                allValid = true;
                lblDiscountPercentValid.ForeColor = Color.Green;
                lblDiscountPercentValid.Text = "\u221A";
            }
        }

        private void tbxDiscountPercent_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
