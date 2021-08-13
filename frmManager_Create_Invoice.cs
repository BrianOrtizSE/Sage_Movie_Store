using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace SU21_Final_Project
{
    public partial class frmManager_Create_Invoice : Form
    {
        public frmManager_Create_Invoice()
        {
            InitializeComponent();
        }
        string strQuery;
        int intOrder = 0;
        int intQuantity = 0;
        int intInvoice = 0;
        decimal decOrderPrice = 0;
        bool blnInvoice = false;

        private void frmManager_Create_Invoice_Load(object sender, EventArgs e)
        {
            GrabProduct();
            GrabInvoice();
        }

        public void GrabProduct()
        {
            strQuery = "Select ProductID , ProductName , Quantity , ProductPrice , inStock from OrtizB21Su2332.Products Order By Quantity asc";
            ProgOps.GrabEmployee(dgvProduct, strQuery);

            if (ProgOps._blnFound == false)
            {

            }
            else
            {
                dgvProduct.Columns[0].HeaderText = "Product ID ";
                dgvProduct.Columns[1].HeaderText = "Product Name";
                dgvProduct.Columns[3].DefaultCellStyle.Format = "c2";
                dgvProduct.Columns[2].HeaderText = "Quantity";
                dgvProduct.Columns[3].HeaderText = "Price ";
                dgvProduct.Columns[4].HeaderText = "inStock";
            }
        }
        public void GrabInvoice()
        {
            try
            {
                strQuery = "Select InvoiceID , EmployeeID , Source , ProductID , OrderQuantity, ProductCost , isPayed from OrtizB21Su2332.Invoice";
                ProgOps.GrabProduct(dgvInvoice, strQuery);

                if (ProgOps._blnFound == false)
                {

                }
                else
                {
                    dgvInvoice.Columns[0].HeaderText = "Invoice ID ";
                    dgvInvoice.Columns[1].HeaderText = "Manager ID";

                    dgvInvoice.Columns[2].HeaderText = "Source";
                    dgvInvoice.Columns[3].HeaderText = "Product ID ";
                    dgvInvoice.Columns[4].HeaderText = "Order Quantity";
                    dgvInvoice.Columns[5].HeaderText = "Product Cost";
                    dgvInvoice.Columns[5].DefaultCellStyle.Format = "c2";
                    dgvInvoice.Columns[6].HeaderText = "Payed ? ";

                }
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void tbxProductID_TextChanged(object sender, EventArgs e)//Validation For ProdcutID
        {
            if (blnInvoice == false)
            {
                if (tbxProductID.Text == string.Empty || tbxProductID.Text.Length != 5)
                {
                    lblProductValid.Text = "X";
                    lblProductValid.ForeColor = Color.Red;
                }
                else
                {
                    strQuery = "Select ProductID from OrtizB21Su2332.Products where ProductID = " + tbxProductID.Text;
                    ProgOps.GrabProductID(strQuery);
                    if (ProgOps._blnFound == true)
                    {
                        lblProductValid.Text = "\u221A";
                        lblProductValid.ForeColor = Color.Green;

                    }
                    else
                    {

                        lblProductValid.Text = "X";
                        lblProductValid.ForeColor = Color.Red;
                    }
                }
            }

        }

        private void tbxQuantityToOrder_TextChanged(object sender, EventArgs e)//Validation for Quantity To Order
        {

            if (blnInvoice == false)
            {
                if (tbxQuantityToOrder.Text == string.Empty)
                {
                    intOrder = 0;
                    Total();
                    lblQuantityValid.Text = "X";
                    lblQuantityValid.ForeColor = Color.Red;
                }
                else
                {
                    if (!int.TryParse(tbxQuantityToOrder.Text, out intOrder))
                    {
                        MessageBox.Show("Error On Parsing Order Quantity", "Order Quanity Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (intOrder < 0 || intOrder > 1000)
                        {
                            lblQuantityValid.Text = "X";
                            lblQuantityValid.ForeColor = Color.Red;
                        }
                        else
                        {
                            lblQuantityValid.Text = "\u221A";
                            lblQuantityValid.ForeColor = Color.Green;
                            Total();
                        }

                    }
                }
            }

        }

        private void tbxProductOrderPrice_TextChanged(object sender, EventArgs e)//Validation for Order Price
        {
            if (blnInvoice == false)
            {
                string strPrice = tbxProductOrderPrice.Text;

                //Make sure its not empty and all things are good if not then display nothing and let user know hes wrong
                if (tbxProductOrderPrice.Text == string.Empty)
                {
                    decOrderPrice = 0;
                    Total();
                    lblPriceValid.Text = "X";
                    lblPriceValid.ForeColor = Color.Red;
                }
                else
                {
                    //Make sure item is good if not X
                    if (!decimal.TryParse(strPrice, NumberStyles.Currency, CultureInfo.InvariantCulture, out decOrderPrice))
                    {
                        lblPriceValid.Text = "X";
                        lblPriceValid.ForeColor = Color.Red;
                    }
                    else
                    {

                        if (decOrderPrice < 0 || decOrderPrice > 99.99m)
                        {
                            lblPriceValid.Text = "X";
                            lblPriceValid.ForeColor = Color.Red;
                        }
                        else
                        {
                            lblPriceValid.Text = "\u221A";
                            lblPriceValid.ForeColor = Color.Green;
                            Total();

                        }

                    }

                }
            }


        }

        private void btnCreateInvoice_Click(object sender, EventArgs e)//Create Invoice 
        {
            //Make sure all textboxes are good
            if (lblProductValid.Text == "X" || lblSourceValid.Text == "X" || lblQuantityValid.Text == "X" || lblProductOrderPrice.Text == "X")
            {
                MessageBox.Show("Please Fillout all required information!", "Invalid Invoice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //If all things are valid we will create a new invoice 
                strQuery = "Insert Into OrtizB21Su2332.Invoice(EmployeeID , Source , ProductID , OrderQuantity , ProductCost , isPayed)" +
                "Values (" + ProgOps._intEmployeeID + ",'" + cbxSource.Text + "'," + tbxProductID.Text + "," + intOrder + "," + decOrderPrice + ", 0)";
                ProgOps.CreateInvoice(strQuery);

                MessageBox.Show("Invoice Created!", "Valid Invoice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
            
            
        }

        void Total()//Calculates Total Invoice Price
        {
            
            //If empty do nothing
            if(tbxQuantityToOrder.Text == String.Empty|| tbxProductOrderPrice.Text == String.Empty)
            {

            }
            else
            {
                //If Price is invalid do nothing
                if(lblPriceValid.Text == "X")
                {
                   
                }
                else
                {
                    //Do all math to make it work if its all good
                    string strSub = tbxProductOrderPrice.Text;
                    strSub = strSub.Replace("$", "");

                    intOrder = int.Parse(tbxQuantityToOrder.Text);
                    decOrderPrice = decimal.Parse(strSub);

                    decimal decSub = 0;
                    decimal decTaxTotal = 0;
                    decimal decTotal = 0;
                    decSub = (intOrder * decOrderPrice);
                    lblSubTotal.Text = "Subtotal : " + decSub.ToString("c2");
                    decTaxTotal = (decSub * ProgOps._TAX);
                    lblTax.Text = "Tax : " + decTaxTotal.ToString("c2");
                    decTotal = decTaxTotal + decSub;
                    lblTotal.Text = "Total : " + decTotal.ToString("c2");
                }
                

            }
                    
        }

        private void cbxShowInvoice_CheckedChanged(object sender, EventArgs e)//Does a quick change to show information
        {
            if (cbxShowInvoice.Checked)
            {
                dgvInvoice.Visible = true;
                Clear();
                blnInvoice = true;
                GrabProduct();
                GrabInvoice();

                lblPriceValid.Visible = false;
                lblProductValid.Visible = false;
                lblSourceValid.Visible = false;
                lblQuantityValid.Visible = false;
                lblPriceValid.Text = "1";

            }
            else
            {
                lblPriceValid.Text = "X";
                lblPriceValid.Visible = true;
                lblProductValid.Visible = true;
                lblSourceValid.Visible = true;
                lblQuantityValid.Visible = true;

                dgvInvoice.Visible = false;
                Clear();
                blnInvoice = false;
                GrabInvoice();
                GrabProduct();
            }
        }

        public void Clear()//Clear All Labels and Texboxes
        {
            tbxProductID.Clear();
            tbxProductOrderPrice.Clear();
            cbxSource.SelectedIndex = -1;
            tbxQuantityToOrder.Clear();
            lblSubTotal.Text = "Subtotal : ";
            lblTax.Text = "Tax : ";
            lblTotal.Text = "Total : ";
        }
   
        private void dgvInvoice_CellClick(object sender, DataGridViewCellEventArgs e)//Granbs information from grid and does quick validation
        {
            if(blnInvoice == true)
            {
                try
                {
                    if (e.RowIndex < 0 || e.ColumnIndex < 0)
                    {

                    }
                    else if (dgvInvoice.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        dgvInvoice.CurrentRow.Selected = true;

                        intInvoice = Convert.ToInt32(dgvInvoice.Rows[e.RowIndex].Cells["InvoiceID"].Value);
                        tbxProductID.Text = dgvInvoice.Rows[e.RowIndex].Cells["ProductID"].Value.ToString();
                        cbxSource.Text = dgvInvoice.Rows[e.RowIndex].Cells["Source"].Value.ToString();
                        tbxQuantityToOrder.Text = dgvInvoice.Rows[e.RowIndex].Cells["OrderQuantity"].Value.ToString();

                        decOrderPrice = Convert.ToDecimal(dgvInvoice.Rows[e.RowIndex].Cells["ProductCost"].Value);
                        tbxProductOrderPrice.Text = decOrderPrice.ToString("c2");

                        cbxCompleted.Checked = Convert.ToBoolean(dgvInvoice.Rows[e.RowIndex].Cells["isPayed"].Value);

                        Total();
                        if (cbxCompleted.Checked)
                        {
                            btnPayInvoice.Enabled = false;
                        }
                        else
                        {
                            btnPayInvoice.Enabled = true;
                        }

                    }

                }
                catch (ArgumentOutOfRangeException)
                {

                }
            }
            
        }

        private void btnPayInvoice_Click(object sender, EventArgs e)//Pay for invoice and complete order
        {
            if(tbxProductID.Text == String.Empty)
            {
                MessageBox.Show("Error On Parsing Order Quantity", "Order Quanity Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                intOrder = int.Parse(tbxQuantityToOrder.Text);


                //Set Invoice Completed to true!
                strQuery = "Update OrtizB21Su2332.Invoice Set isPayed = 1 where InvoiceID = " + intInvoice;
                ProgOps.CreateInvoice(strQuery);

                //Update Quantity for Item created
                strQuery = "Select Quantity from OrtizB21Su2332.Products where ProductID = " + tbxProductID.Text;
                intQuantity = ProgOps._intQuantity + intOrder;

                strQuery = "Update OrtizB21Su2332.Products Set Quantity = " + intQuantity + " Where ProductID = " + tbxProductID.Text;
                ProgOps.UpdateQuantity(strQuery);
                //DONE
                MessageBox.Show("Invoice Completed", "Invoice Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void tbxProductID_KeyPress(object sender, KeyPressEventArgs e)//So Product Textbox can handle ONLY numbers
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57 ||       //ASCII Check for Numbers
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

        private void tbxQuantityToOrder_KeyPress(object sender, KeyPressEventArgs e)//So Quantity Textbox can handle ONLY numbers
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57 ||       //ASCII Check for Numbers
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

        private void tbxProductOrderPrice_KeyPress(object sender, KeyPressEventArgs e)//So ProductP rice Textbox can only be a price
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57 ||       //ASCII Check for Numbers
               e.KeyChar == 36 || e.KeyChar == 46 ||        //ASCII Check for Dollar Sign Or Period
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

        private void cbxSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxSource.Text == String.Empty)
            {
                lblSourceValid.Text = "X";
                lblSourceValid.ForeColor = Color.Red;
            }
            else
            {
                lblSourceValid.Text = "\u221A";
                lblSourceValid.ForeColor = Color.Green;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
