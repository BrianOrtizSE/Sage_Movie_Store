using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SU21_Final_Project
{
    public partial class frmManager_Edit_Inventory : Form
    {
        public frmManager_Edit_Inventory()
        {
            InitializeComponent();
        }
        string strQuery;
        string imgLoc;
        bool blnEdit;
        bool blnAdd;
        bool blnAddPic;
        bool blnPictureAdd = false;
        private void frmMerchandiseAdd_Load(object sender, EventArgs e)
        {
            try
            {
                GrabProduct();
                //Start in view state
                SetState("View");
                Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error : Products Table ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }    

        private void SetState(string state)
        {
            switch (state)
            {
                case "View":
                    //Bool Variable;
                    blnEdit = true;
                    blnAdd = false;
                    blnAddPic = false;

                    //Buttons
                    btnEditMerchandise.Enabled = true;
                    btnCompleteEdit.Enabled = false;
                    btnCancel.Enabled = false;
                    btnCreateInvoice.Enabled = true;
                    btnAdd.Enabled = true;
                    btnComplete.Enabled = false;
                    btnUploadImage.Enabled = false;
                    btnSaveImage.Enabled = false;
                    
                    //Textbox
                    tbxProductID.ReadOnly = true;
                    tbxProductID.BackColor = Color.LightGray;
                    tbxProductName.ReadOnly = true;
                    tbxProductName.BackColor = Color.LightGray;
                    tbxQuantity.ReadOnly = true;
                    tbxQuantity.BackColor = Color.LightGray;
                    tbxProductPrice.ReadOnly = true;
                    tbxProductPrice.BackColor = Color.LightGray;
                    tbxProductDescription.ReadOnly = true;
                    tbxProductDescription.BackColor = Color.LightGray;
                    //ComboBox and Checkbox
                    cbxGenres.Enabled = false;
                    cbxInStock.Enabled = false;
                    //label
                    lblProductNameValid.Visible = false;
                    lblGenreValid.Visible = false;
                    lblPriceValid.Visible = false;
                    lblProductDescriptionValid.Visible = false;
                    lblQuantityValid.Visible = false;
                    break;
                case "Add":
                    //Bool Variable

                    blnEdit = false;
                    blnAdd = false;
                    blnAddPic = false;

                    //Buttons
                    btnEditMerchandise.Enabled = false;
                    btnCompleteEdit.Enabled = false;
                    btnCancel.Enabled = true;
                    btnCreateInvoice.Enabled = false;
                    btnAdd.Enabled = false;
                    btnComplete.Enabled = true;
                    btnUploadImage.Enabled = true;
                    btnSaveImage.Enabled = false;
                    
                    //Textbox

                    tbxProductID.ReadOnly = true;
                    tbxProductID.BackColor = Color.LightGray;
                    tbxProductName.ReadOnly = false;
                    tbxProductName.BackColor = Color.White;
                    tbxQuantity.ReadOnly = false;
                    tbxQuantity.BackColor = Color.White;
                    tbxProductPrice.ReadOnly = false;
                    tbxProductPrice.BackColor = Color.White;
                    tbxProductDescription.ReadOnly = false;
                    tbxProductDescription.BackColor = Color.White;

                    //ComboBox and Checkbox
                    cbxGenres.Enabled = true;
                    cbxInStock.Enabled = true;
                    //label
                    lblProductNameValid.Visible = true;
                    lblGenreValid.Visible = true;
                    lblPriceValid.Visible = true;
                    lblProductDescriptionValid.Visible = true;
                    lblQuantityValid.Visible = true;

                    break;
                case "Edit":
                    //Bool Variable

                    blnEdit = false;
                    blnAdd = true;
                    blnAddPic = true;
                    //Buttons
                    btnEditMerchandise.Enabled = false;
                    btnCompleteEdit.Enabled = true;
                    btnCancel.Enabled = true;
                    btnCreateInvoice.Enabled = false;
                    btnAdd.Enabled = false;
                    btnComplete.Enabled = false;
                    btnUploadImage.Enabled = true;
                    btnSaveImage.Enabled = false;

                    //Textbox

                    tbxProductID.ReadOnly = true;
                    tbxProductID.BackColor = Color.LightGray;
                    tbxProductName.ReadOnly = false;
                    tbxProductName.BackColor = Color.White;
                    tbxQuantity.ReadOnly = false;
                    tbxQuantity.BackColor = Color.White;
                    tbxProductPrice.ReadOnly = false;
                    tbxProductPrice.BackColor = Color.White;
                    tbxProductDescription.ReadOnly = false;
                    tbxProductDescription.BackColor = Color.White;

                    //ComboBox and Checkbox
                    cbxGenres.Enabled = true;
                    cbxInStock.Enabled = true;
                    //label
                    lblProductNameValid.Visible = true;
                    lblGenreValid.Visible = true;
                    lblPriceValid.Visible = true;
                    lblProductDescriptionValid.Visible = true;
                    lblQuantityValid.Visible = true;


                    break;
                default:
                    //Buttons
                   
                    break;
            }
            
        }

        public void GrabProduct()
        {
            strQuery = "Select ProductID , ProductName , Genre , Quantity , ProductPrice , ProductDescription , inStock from OrtizB21Su2332.Products";
            ProgOps.GrabEmployee(dgvInventory, strQuery);

            if(ProgOps._blnFound == false)
            {

            }
            else
            {
                dgvInventory.Columns[0].HeaderText = "Product ID ";
                dgvInventory.Columns[1].HeaderText = "Product Name";
                //dgvPerson.Columns[3].DefaultCellStyle.Format = "c2";
                dgvInventory.Columns[2].HeaderText = "Genre";
                dgvInventory.Columns[3].HeaderText = "Quantity";
                dgvInventory.Columns[4].HeaderText = "Price ";
                dgvInventory.Columns[5].HeaderText = "Description ";
                dgvInventory.Columns[6].HeaderText = "inStock";
            }
        }
        private void frmMerchandiseInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void dgvInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            double dblPrice;
            try
            {
                if(blnEdit == true)
                {
                    if (e.RowIndex < 0 || e.ColumnIndex < 0)
                    {

                    }
                    else if (dgvInventory.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        dgvInventory.CurrentRow.Selected = true;
                        tbxProductID.Text = dgvInventory.Rows[e.RowIndex].Cells["ProductID"].Value.ToString();
                        tbxProductName.Text = dgvInventory.Rows[e.RowIndex].Cells["ProductName"].Value.ToString();
                        cbxGenres.Text = dgvInventory.Rows[e.RowIndex].Cells["Genre"].Value.ToString();
                        tbxQuantity.Text = dgvInventory.Rows[e.RowIndex].Cells["Quantity"].Value.ToString();

                        dblPrice = Convert.ToDouble(dgvInventory.Rows[e.RowIndex].Cells["ProductPrice"].Value);
                        tbxProductPrice.Text = dblPrice.ToString("c2");

                        tbxProductDescription.Text = dgvInventory.Rows[e.RowIndex].Cells["ProductDescription"].Value.ToString();
                        cbxInStock.Checked = Convert.ToBoolean(dgvInventory.Rows[e.RowIndex].Cells["inStock"].Value);

                    }
                }
                
            }
            catch (ArgumentOutOfRangeException)
            {

            }
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {           
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JPG FIles (*.jpg)|*.jpg| GIF Files (*.gif)|*.gif| All Files (*.*)|*.*";
            dialog.Title = "Select Employee Picture";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLoc = dialog.FileName.ToString();
                pbxImage.ImageLocation = imgLoc;
                if(blnAddPic == true)
                {
                    btnSaveImage.Enabled = false;
                }
                else
                {
                    btnSaveImage.Enabled = true;
                }
                
            }
        }

        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            if(tbxProductID.Text == String.Empty)
            {
                MessageBox.Show("Please Have The Product ID Selected or Created.", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                strQuery = "Update OrtizB21Su2332.Products Set Image = " + "@img where ProductID = " + tbxProductID.Text;
                ProgOps.UploadPicture(imgLoc, strQuery);
                MessageBox.Show("Imaged Saved.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            
        }

        private void tbxProductID_TextChanged(object sender, EventArgs e)
        {
            if(blnEdit == true) { 

                strQuery = "Select Image from OrtizB21Su2332.Products where ProductID = " + tbxProductID.Text;
                ProgOps.CheckPicture(strQuery);
                if(ProgOps._blnFound == true)
                {
                    ProgOps.GrabPicture(pbxImage, strQuery);
                }
                else
                {
                    MessageBox.Show("No Picture For This Item", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                

            }
        }
        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            if(tbxProductID.Text == String.Empty)
            {
                MessageBox.Show("Please Have The Product ID Selected or Created.", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SetState("Edit");
            }
            
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            SetState("Add");
            Clear();
            //This Grab ProductID so that if the user uploads a picture the picture is uploaded to that ProductID
            strQuery = "Select ProductID from OrtizB21Su2332.Products Order By productID desc";
            ProgOps.GrabProductID(strQuery);

            tbxProductID.Text = (ProgOps._intProductID + 1).ToString();
        }
        public void Clear()
        {
            tbxProductID.Clear();
            tbxProductName.Clear();
            tbxQuantity.Clear();
            tbxProductPrice.Clear();
            tbxProductDescription.Clear();
            cbxInStock.Checked = false;
            cbxGenres.SelectedIndex = -1;
            pbxImage.Image = Properties.Resources.Logo_SMS;
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Validation For When Adding New Item
        private void tbxProductName_TextChanged(object sender, EventArgs e)//Product Name Textbox Validation
        {

                if (tbxProductName.Text == string.Empty)
                {
                    lblProductNameValid.Text = "X";
                    lblProductNameValid.ForeColor = Color.Red;
                }
                else
                {
                    lblProductNameValid.Text = "\u221A";
                    lblProductNameValid.ForeColor = Color.Green;
                }
        }
        private void cbxGenres_SelectedIndexChanged(object sender, EventArgs e)//Genre ComboBox Validation
        {

                if(cbxGenres.SelectedIndex == -1)
                {
                    lblGenreValid.Text = "X";
                    lblGenreValid.ForeColor = Color.Red;
                }
                else
                {
                    lblGenreValid.Text = "\u221A";
                    lblGenreValid.ForeColor = Color.Green;
                }
            
        }
        private void tbxQuantity_TextChanged(object sender, EventArgs e)//Quantity Validation
        {

                if (tbxQuantity.Text == string.Empty)
                {
                    lblQuantityValid.Text = "X";
                    lblQuantityValid.ForeColor = Color.Red;
                }
                else
                {
                    lblQuantityValid.Text = "\u221A";
                    lblQuantityValid.ForeColor = Color.Green;
                }
            
        }
        private void tbxProductPrice_TextChanged(object sender, EventArgs e)//Price Validation (For Text Only)
        {

                if(tbxProductPrice.Text == string.Empty)
                {
                    lblPriceValid.Text = "X";
                    lblPriceValid.ForeColor = Color.Red;
                }
                else
                {
                    lblPriceValid.Text = "\u221A";
                    lblPriceValid.ForeColor = Color.Green;
                }
            
        }
        private void tbxProductDescription_TextChanged(object sender, EventArgs e)
        {

                if (tbxProductDescription.Text == string.Empty)
                {
                    lblProductDescriptionValid.Text = "X";
                    lblProductDescriptionValid.ForeColor = Color.Red;
                }
                else
                {
                    lblProductDescriptionValid.Text = "\u221A";
                    lblProductDescriptionValid.ForeColor = Color.Green;
                }
            
        }


        private void btnComplete_Click(object sender, EventArgs e)//Adding Data To Database
        {
            double dblPrice;
            int intInStock = 0;

            if (lblProductNameValid.Text == "X" || lblGenreValid.Text == "X" || lblQuantityValid.Text == "X" || lblProductDescriptionValid.Text  == "X" || lblPriceValid.Text == "X")
            {
                MessageBox.Show("Please Fill Out All Required Information : Product Name , Genre , Quantity , Price , Description", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if(cbxInStock.Checked == true)
                {
                    intInStock = 1;
                }

                //This makes it so any single qutoes are changed to double quotes
                tbxProductName.Text = tbxProductName.Text.Replace("'" , "\''");
                tbxProductDescription.Text = tbxProductDescription.Text.Replace("'", "\''");
                tbxProductPrice.Text = tbxProductPrice.Text.Replace("$", "");

                
                if (!double.TryParse(tbxProductPrice.Text, out dblPrice))
                {
                    MessageBox.Show("Error On Product Price", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //FIX LATER SO THAT QUANTITY IS AN INTERGER THAT HAS BEEN TRY PARSED
                    if (blnPictureAdd == false)
                    {
                       
                        strQuery = "Insert into OrtizB21Su2332.Products(ProductName,Genre,Quantity,ProductPrice,ProductDescription,inStock)" +
                            "values('" + tbxProductName.Text + "','" + cbxGenres.Text + "'," + tbxQuantity.Text + "," + dblPrice + ",'" + tbxProductDescription.Text + "'," + intInStock + ")";
                       
                        MessageBox.Show(strQuery);

                        MessageBox.Show("Item Succefully Added", "Valid Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        //Adding Item Then Picture
                        strQuery = "Insert into OrtizB21Su2332.Products(ProductName,Genre,Quantity,ProductPrice,ProductDescription,inStock)" +
                            "values('" + tbxProductName.Text + "','" + cbxGenres.Text + "'," + tbxQuantity.Text + "," + dblPrice + ",'" + tbxProductDescription.Text + "'," + intInStock + ")";
                        ProgOps.CreateProduct(strQuery);
                        MessageBox.Show("Item Succefully Added", "Valid Data", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        strQuery = "Update OrtizB21Su2332.Products Set Image = " + "@img where ProductID = " + tbxProductID.Text;
                        ProgOps.UploadPicture(imgLoc, strQuery);
                        MessageBox.Show("Picture Succefully Added", "Valid Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        blnPictureAdd = false;
                    }
                    Clear();
                    SetState("View");                 
                    GrabProduct();
                    
                }

                


            }
        }

        private void pbxImage_LoadProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if(blnAdd == true)
            {
                blnPictureAdd = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
            SetState("View");
        }

        private void btnCompleteEdit_Click(object sender, EventArgs e)//While in edit more this button upades the database so it equalls the new information
        {
            double dblPrice;
            int intInStock = 0;

            if (lblProductNameValid.Text == "X" || lblGenreValid.Text == "X" || lblQuantityValid.Text == "X" || lblProductDescriptionValid.Text == "X" || lblPriceValid.Text == "X")
            {
                MessageBox.Show("Please Fill Out All Required Information : Product Name , Genre , Quantity , Price , Description", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (cbxInStock.Checked == true)
                {
                    intInStock = 1;
                }

                //This makes it so any single qutoes are changed to double quotes
                tbxProductName.Text = tbxProductName.Text.Replace("'", "\''");
                tbxProductDescription.Text = tbxProductDescription.Text.Replace("'", "\''");
                tbxProductPrice.Text = tbxProductPrice.Text.Replace("$", "");

                if (!double.TryParse(tbxProductPrice.Text, out dblPrice))
                {
                    MessageBox.Show("Error On Product Price", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //FIX LATER SO THAT QUANTITY IS AN INTERGER THAT HAS BEEN TRY PARSED

                    strQuery = "Update OrtizB21Su2332.Products " +
                        "Set ProductName = '" + tbxProductName.Text + "', Genre = '" + cbxGenres.Text + "', Quantity = " + tbxQuantity.Text + ", ProductPrice = " + dblPrice + ", ProductDescription = '" + tbxProductDescription.Text + "', inStock = " + intInStock +
                        " Where ProductID = " + tbxProductID.Text;
                    ProgOps.UpdateProduct(strQuery);


                    MessageBox.Show("Item Succefully Updated", "Valid Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    SetState("View");
                    GrabProduct();

                }
            }
        }

        private void btnCreateInvoice_Click(object sender, EventArgs e)
        {

        }
    }
}
