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
    public partial class frmCreateInvoice : Form
    {
        public frmCreateInvoice()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCreateInvoice_Load(object sender, EventArgs e)
        {
            ProgOps.GrabProduct(tbxProductID , dgvProducts);

            //Setting Titles and such for Grids
            dgvProducts.Columns[0].HeaderText = "Product ID";
            dgvProducts.Columns[1].HeaderText = "Movie Title";
            dgvProducts.Columns[2].HeaderText = "Movie Genre";
            dgvProducts.Columns[3].HeaderText = "Movie Description";
            dgvProducts.Columns[4].HeaderText = "Quantity";

            dgvProducts.Columns[5].DefaultCellStyle.Format = "c";
            dgvProducts.Columns[5].HeaderText = "Movie Price";



        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            double dblPrice;
            int intQuantity; 



            //small check for ProdID
            if(tbxProductID.Text == "")
            {
                lblProdError.Visible = true;
            }
            else{
                lblProdError.Visible = false;
            }

            //small check for QuantityID
            if (tbxQuantity.Text == "")
            {
                lblError.Visible = true;
            }
            else
            {
                intQuantity = int.Parse(tbxQuantity.Text);
                if(intQuantity < 0)
                {
                    lblError.Visible = true;
                }
                else
                {
                    lblError.Visible = false;
                }
            }

            if(lblError.Visible == false && lblProdError.Visible == false)
            {
                MessageBox.Show("Okay it working");
            }

        }
    }
}
