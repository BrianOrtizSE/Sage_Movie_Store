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
    public partial class frmEmployee_View_Inventory : Form
    {
        public frmEmployee_View_Inventory()
        {
            InitializeComponent();
        }
        int intSearch = 1;
        string strQuery;
        private void btnSearch_Click(object sender, EventArgs e)//For Search Query
        {

            if (lblItemError.Text == "X")
            {
                MessageBox.Show("Please Fill Out Search Query", "Invalid Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {     
                //switch case to let the user choose for what he wants to look for
                
                

                switch (intSearch)
                {
                    case 1:
                        strQuery = "Select ProductID, ProductName , Genre , Quantity , ProductPrice , ProductDescription " +
                        "From OrtizB21Su2332.Products " +
                        "Where ProductID = " + tbxProductID.Text;
                        ProgOps.GrabProduct(dgvInventory, strQuery);
                        if (ProgOps._blnFound == false)
                        {
                            AttachInventory();
                        }
                        else
                        {
                            ProgOps.GrabProduct(dgvInventory, strQuery);
                        }
                        break;

                    case 2:                     
                        strQuery = "Select ProductID, ProductName , Genre , Quantity , ProductPrice , ProductDescription " +
                        "From OrtizB21Su2332.Products " +
                        "Where ProductName = '" + tbxProductID.Text + "'";
                        ProgOps.GrabProduct(dgvInventory, strQuery);
                        if (ProgOps._blnFound == false)
                        {
                            AttachInventory();
                        }
                        else
                        {
                            ProgOps.GrabProduct(dgvInventory, strQuery);
                        }
                        break;

                    case 3:

                        strQuery = "Select ProductID, ProductName , Genre , Quantity , ProductPrice , ProductDescription " +
                        "From OrtizB21Su2332.Products " +
                        "Where Genre = '" + cbxGenres.Text + "'";
                        ProgOps.GrabProduct(dgvInventory, strQuery);
                        if (ProgOps._blnFound == false)
                        {
                            AttachInventory();
                        }
                        else
                        {
                            ProgOps.GrabProduct(dgvInventory, strQuery);
                        }
                        break;
                    default:
                        break;
                }
            }

        }

        private void frmEmployee_Inventory_View_Load(object sender, EventArgs e)//On Load
        {
            AttachInventory();
            cbxSearch.Text = "Product ID";         
        }

        public void AttachInventory()//Function to Display defualt
        {
            
            strQuery = "Select ProductID, ProductName , Genre , Quantity , ProductPrice , ProductDescription " +
                   "From OrtizB21Su2332.Products" + 
                   " Where inStock = 1";
            ProgOps.GrabProduct(dgvInventory, strQuery);
            dgvInventory.Columns[0].HeaderText = "Product ID ";
            dgvInventory.Columns[1].HeaderText = "Product Name";
            dgvInventory.Columns[2].HeaderText = "Genre";
            dgvInventory.Columns[3].HeaderText = "Quantity";
            dgvInventory.Columns[4].DefaultCellStyle.Format = "c2";
            dgvInventory.Columns[4].HeaderText = "Product Description";
        }

        private void tbxProductID_TextChanged(object sender, EventArgs e)//Quick Check to make sure Product Textbox is not empty TODO MAYBE LOOK UP
        {
            
            if(tbxProductID.Text == string.Empty)
            {
                lblItemError.Text = "X";
                lblItemError.ForeColor = Color.Red;
            }
            else
            {
                lblItemError.Text = "\u221A";
                lblItemError.ForeColor = Color.Green;
            }
        }

        private void cbxSearch_SelectedIndexChanged(object sender, EventArgs e)//Set the intSearch to be used later
        {
            
            if (cbxSearch.Text == "Product ID")
            {
                intSearch = 1;
                tbxProductID.MaxLength = 5;
                SetSearch("Product");
            }
            else if (cbxSearch.Text == "Product Name")
            {
                intSearch = 2;
                tbxProductID.MaxLength = 25;
                SetSearch("Product");
            }
            else if (cbxSearch.Text == "Genre")
            {
                intSearch = 3;
                SetSearch("Genre");
                cbxGenres.Text = "Action";
            }
        }

        public void SetSearch(string Set)//Set What is Displayed
        {
            
            switch (Set)
            {
                case "Product":
                    //Resetting Error Text
                    lblItemError.Text = "X";
                    lblItemError.ForeColor = Color.Red;

                    //set Items to search visible or not
                    tbxProductID.Clear();
                    tbxProductID.Enabled = true;
                    tbxProductID.Visible = true;
                    cbxGenres.Visible = false;
                    cbxGenres.Visible = false;
                    lblItemError.Visible = true;

                    break;

                case "Genre":
                    //Seting Error To Good
                    lblItemError.Text = "\u221A";
                    lblItemError.ForeColor = Color.Green;

                    tbxProductID.Enabled = false;
                    tbxProductID.Visible = false;
                    cbxGenres.Visible = true;
                    cbxGenres.Enabled = true;
                    break;
            }
        }

        private void lblProductDescriptionText_Click(object sender, EventArgs e)
        {

        }

        private void dgvInventory_CellClick(object sender, DataGridViewCellEventArgs e)//Used to Throw information from data grid to the labels.
        {
            
            double dblPrice;
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {

            }
            else
            {
                if (dgvInventory.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvInventory.CurrentRow.Selected = true;
                    lblProductID.Text = dgvInventory.Rows[e.RowIndex].Cells["ProductID"].Value.ToString();
                    lblProductName.Text = dgvInventory.Rows[e.RowIndex].Cells["ProductName"].Value.ToString();
                    lblGenre.Text = dgvInventory.Rows[e.RowIndex].Cells["Genre"].Value.ToString();
                    lblQuantity.Text = dgvInventory.Rows[e.RowIndex].Cells["Quantity"].Value.ToString();
                    dblPrice = Convert.ToDouble(dgvInventory.Rows[e.RowIndex].Cells["ProductPrice"].Value);
                    lblProductPrice.Text = dblPrice.ToString("c2");
                    lblProductDescription.Text = dgvInventory.Rows[e.RowIndex].Cells["ProductDescription"].Value.ToString();

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
            
        }

        private void btnReset_Click(object sender, EventArgs e)//Reset All Fields
        {
            tbxProductID.Clear();
            cbxGenres.Text = "Product ID";
            SetSearch("Product");
            AttachInventory();
            lblProductID.Text = String.Empty;
            lblProductName.Text = String.Empty;
            lblQuantity.Text = String.Empty;
            lblProductPrice.Text = String.Empty;
            lblGenre.Text = String.Empty;
            lblProductDescription.Text = String.Empty;
            pbxImage.Image = Properties.Resources.Logo_SMS;

        }

        private void btnClose_Click(object sender, EventArgs e)//Close Form
        {
            this.Close();
        }

        private void tbxProductID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(intSearch == 1)
            {
                //Only allow letters and backspace
                if (e.KeyChar >= 48 && e.KeyChar <= 57 ||       //ASCII Check for Numbers
                    e.KeyChar == 8)                             //ASCII Check for Backspace
                {
                    //Accept the keystroke
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            else if(intSearch == 2)
            {
                //Only allow letters and backspace
                if (e.KeyChar >= 65 && e.KeyChar <= 90 ||       //ASCII Check for Capital Letters     
                    e.KeyChar >= 48 && e.KeyChar <= 57 ||       //ASCII Check for Numbers
                    e.KeyChar == 32 ||                          //ASCII Check For Spacebar
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
        }

        private void cbxGenres_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mnsHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Screen can be used to search up specific items, this screen also displays negative inventory to let the user \n know that the item will be restocked soon enough.", "Help File", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
