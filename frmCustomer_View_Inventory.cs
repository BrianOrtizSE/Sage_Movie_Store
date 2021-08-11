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
    public partial class frmCustomer_View_Inventory : Form
    {
        public frmCustomer_View_Inventory()
        {
            InitializeComponent();
        }
        string strQuery;
        private void frmProductView_Load(object sender, EventArgs e)
        {
            GrabProducts();
        }
        public void GrabProducts()
        {

            //On Load We Display All Items
            strQuery = "Select ProductID , ProductName , Genre , ProductDescription , Quantity , ProductPrice From OrtizB21Su2332.Products Where Quantity > 0 and inStock = 1";

            ProgOps.GrabProduct(dgvProducts, strQuery);

            //Setting Titles and such for Grids
            dgvProducts.Columns[0].HeaderText = "Product ID";
            dgvProducts.Columns[1].HeaderText = "Movie Title";
            dgvProducts.Columns[2].HeaderText = "Movie Genre";
            dgvProducts.Columns[3].HeaderText = "Movie Description";
            dgvProducts.Columns[4].HeaderText = "Quantity";

            dgvProducts.Columns[5].DefaultCellStyle.Format = "c2";
            dgvProducts.Columns[5].HeaderText = "Movie Price";
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            double dblPrice;
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {

            }
            else if (dgvProducts.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                //Insert data from Data Grid To Labels
                dgvProducts.CurrentRow.Selected = true;
                lblProductID.Text = dgvProducts.Rows[e.RowIndex].Cells["ProductID"].Value.ToString();
                lblProductName.Text = dgvProducts.Rows[e.RowIndex].Cells["ProductName"].Value.ToString();
                lblGenre.Text = dgvProducts.Rows[e.RowIndex].Cells["Genre"].Value.ToString();
                lblQuantity.Text = dgvProducts.Rows[e.RowIndex].Cells["Quantity"].Value.ToString();

                dblPrice = Convert.ToDouble(dgvProducts.Rows[e.RowIndex].Cells["ProductPrice"].Value);
                lblProductPrice.Text = dblPrice.ToString("c2");

                lblProductDescription.Text = dgvProducts.Rows[e.RowIndex].Cells["ProductDescription"].Value.ToString();

                //Grab Picture associated with the ProductID
                strQuery = "Select Image from OrtizB21Su2332.Products where ProductID = " + lblProductID.Text;
                //MessageBox.Show(strQuery);
                ProgOps.CheckPicture(strQuery);
                if (ProgOps._blnFound == true)
                {
                    ProgOps.GrabPicture(pbxImage, strQuery);
                }
                else
                {
                    MessageBox.Show("No Picture For This Item", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
