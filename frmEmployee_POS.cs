using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SU21_Final_Project
{
    public partial class frmEmployee_POS : Form
    {
        public frmEmployee_POS()
        {
            InitializeComponent();
        }
        public class ProdList
        {
            //struct variables
            public int intProductID;
            public string strProdName;
            public decimal dblProdPrice;
            public int intMaxQuan;
            public int intProdQuan;


            //constructor
            public ProdList(int intProductID, string strProdName, decimal dblProdPrice, int intProdQuan)
            {
                this.intProductID = intProductID;
                this.strProdName = strProdName;
                this.dblProdPrice = dblProdPrice;
                this.intProdQuan = intProdQuan;
            }


        }

        public string strQuery;
        public decimal decTotal = 0;
        public decimal decTaxTotal = 0;
        public decimal decSubTotal = 0;
        public decimal decDiscountPercent = 0;

        bool blnDiscountDupe = false;
        bool blnDiscountUsed = false;


        List<ProdList> prodlist = new List<ProdList>();
        List<string> discountUsed = new List<string>();

        private void btnPay_Click(object sender, EventArgs e)
        {
            int intQuanityHold;

            if (tbxCardHolderName.Text == string.Empty || tbxCardNumber.Text == string.Empty || cmbMonth.Text == string.Empty || cmbYear.Text == string.Empty || tbxSCode.Text == string.Empty)
            {
                MessageBox.Show("Make Sure All Required Information Is Filled Out!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                ReportPrint(Reciept(decSubTotal, decDiscountPercent, decTaxTotal, decTotal));

                for (int i = 0; i < prodlist.Count(); i++)
                {
                    strQuery = "Select Quantity From OrtizB21Su2332.Products " +
                    "Where ProductID = " + prodlist[i].intProductID;

                    ProgOps.GrabAmount(strQuery);
                    intQuanityHold = prodlist[i].intProdQuan;

                    ProgOps._intQuantity = ProgOps._intQuantity - intQuanityHold;

                    strQuery = "Update OrtizB21Su2332.Products Set Quantity = " + ProgOps._intQuantity + " where ProductID = + " + prodlist[i].intProductID;
                    ProgOps.UpdateQuantity(strQuery);

                }

                //WILL USE GET EMPLOYEEID AT THE START OF THE LOGIN AND MAKE SURE THIS GUYS EMPLOYEEID IS SET ALL THE WAY THROUGH!!!

                strQuery = "Insert into OrtizB21Su2332.Reciept(PersonID ,  EmployeeID , TransData)" +
                    "values(" + ProgOps._intPersonID + ProgOps._intPersonID + ", GETDATE() ," + ")";
                ProgOps.CreateInvoice(strQuery);

                //WILL USE RECIEPT TO CREATE RECIEPT INFO


                //WILL GET TOTAL AND INSERT IT INTO SALES!!



                this.Close();
            }
        }

        public void GrabProducts()
        {
            //Reset Data Grid View
            strQuery = "Select ProductID , ProductName , Genre , ProductDescription , Quantity , ProductPrice From OrtizB21Su2332.Products Where Quantity > 0";
            ProgOps.GrabProduct(dgvProducts, strQuery);
        }

        private void frmEmployee_POS_Load(object sender, EventArgs e)
        {

            //On Load We Display All Items
            strQuery = "Select ProductID , ProductName , Genre , ProductDescription , Quantity , ProductPrice From OrtizB21Su2332.Products Where Quantity > 0";

            ProgOps.GrabProduct( dgvProducts, strQuery);

            //Setting Titles and such for Grids
            dgvProducts.Columns[0].HeaderText = "Product ID";
            dgvProducts.Columns[1].HeaderText = "Movie Title";
            dgvProducts.Columns[2].HeaderText = "Movie Genre";
            dgvProducts.Columns[3].HeaderText = "Movie Description";
            dgvProducts.Columns[4].HeaderText = "Quantity";

            dgvProducts.Columns[5].DefaultCellStyle.Format = "c2";
            dgvProducts.Columns[5].HeaderText = "Movie Price";

            pnlCheckout.Visible = false;
            pnlShoppingCart.Visible = false;


        }

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            decimal dblPrice;
            int intQuantity = 0;

            //Check to see if their looking at an item
            if (lblProductID.Text == String.Empty)
            {
                MessageBox.Show("Pleaes Choose an Item to add to cart", "No Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //small check for QuantityID
                if (tbxQuantity.Text == String.Empty)
                {
                    MessageBox.Show("Pleaes Choose a Valid Amount to add to cart", "No Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if(!int.TryParse(tbxQuantity.Text, out intQuantity))
                    {
                        MessageBox.Show("Error On Quantity Conversion", "Quantity Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        intQuantity = int.Parse(tbxQuantity.Text);
                    }
                    
                    if (intQuantity < 0)
                    {
                        MessageBox.Show("Pleaes Choose a Valid Amount to add to cart", "No Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {

                            int intdgvSelected = Convert.ToInt32(dgvProducts.CurrentCell.RowIndex);
                            int cellVal;
                            int newCellVal;

                            //This Changes The Information showing ofr the datagrid but not the internals of the database
                            cellVal = Convert.ToInt32(dgvProducts.SelectedRows[0].Cells["Quantity"].Value);
                            newCellVal = Convert.ToInt32(cellVal - intQuantity);
                            if(newCellVal < 0)
                            {
                                MessageBox.Show("Quanity Ordered Cannot Be Greater Than That Of Inventory", "Over Quantity", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {

                                dgvProducts.SelectedRows[0].Cells["Quantity"].Value = newCellVal;
                                dblPrice = Convert.ToDecimal(dgvProducts.CurrentRow.Cells[5].Value);
                                prodlist.Add(new ProdList((int)dgvProducts.CurrentRow.Cells[0].Value, dgvProducts.CurrentRow.Cells[1].Value.ToString(), dblPrice, int.Parse(tbxQuantity.Text)));


                            //Write Items to ListBox / Cart
                            WriteToCart();


                                //Update the total and its label
                                decTotal += dblPrice * decimal.Parse(tbxQuantity.Text);
                                lblToalPrice.Text = "Total : \t" + decTotal.ToString("c2");
                                lblQuantity.Text = newCellVal.ToString();
                               tbxQuantity.Clear();
                                //Reset Labels
                                lblProductID.Focus();


                            }

                        }                    
                }
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int intSelected = 0;
            

            if (lbxOrder.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select Item From Cart That You Wish To Remove", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Fixes Total On Display
                intSelected = lbxOrder.SelectedIndex;

                decTotal = decTotal - (prodlist[intSelected].dblProdPrice * prodlist[intSelected].intProdQuan);
                lblToalPrice.Text = "Total : \t" + decTotal.ToString("c2");

                
                
                //This Part changes the Data Grid View To Display Correct Information!
                int cellVal;
                int newCellVal;

                string searchValue = prodlist[intSelected].intProductID.ToString();
                int rowIndex = -1;
                foreach (DataGridViewRow row in dgvProducts.Rows)
                {
                    if (row.Cells[0].Value.ToString().Equals(searchValue))
                    {
                        rowIndex = row.Index;
                        break;
                    }
                }
                dgvProducts.Rows[rowIndex].Selected = true;

                int intQuan = prodlist[intSelected].intProdQuan;
                cellVal = Convert.ToInt32(dgvProducts.SelectedRows[0].Cells["Quantity"].Value);
                newCellVal = Convert.ToInt32(cellVal + intQuan);
                dgvProducts.SelectedRows[0].Cells["Quantity"].Value = newCellVal;


                //reset listbox to look clean
                prodlist.RemoveAt(intSelected);
                //GrabProducts();
                Reset();
                WriteToCart();

            }

        }
        private void btnCheckOut_Click(object sender, EventArgs e)
        {

            if (prodlist.Count == 0)
            {
                MessageBox.Show("Please Add At Least 1 Item To The Cart.", "Shoppnig Cart Empty ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Switches between screens
                pnlCart.Visible = false;
                pnlCheckout.Visible = true;


                WriteToListBox(decSubTotal, decDiscountPercent, decTaxTotal, decTotal);
                this.Size = new Size(760, 630);
            }


        }

        private void btnCloseShop_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnDiscountEnter_Click(object sender, EventArgs e)
        {

            bool blnProductInCart = false;
            tbxDiscount.Text.Trim();

            if (tbxDiscount.Text == string.Empty)
            {
                MessageBox.Show("Discount box can not be empty", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                for (int i = 0; i < discountUsed.Count(); i++)
                {
                    if (tbxDiscount.Text == discountUsed[i])
                    {
                        blnDiscountDupe = true;

                    }

                }

                //WILL TRY TO ADD MORE THAN 1 DISCOUNT LATER for now only 1 per transaction.          
                if (blnDiscountUsed == true)
                {
                    MessageBox.Show("Only 1 Coupon Per Transaction", "Discount Used", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbxDiscount.Text = "";
                    tbxDiscount.Focus();
                }
                else
                {
                    if (blnDiscountDupe == false)
                    {
                        ProgOps.GrabDiscountID(tbxDiscount);
                        if (ProgOps._blnDiscountFound == true)
                        {
                            discountUsed.Add(tbxDiscount.Text);

                            //Type 0 discount code that applies to whole purchase
                            if (ProgOps._intProductID == 0)
                            {
                                decDiscountPercent = ProgOps._decDiscountPercent;
                                blnDiscountUsed = true;
                            }
                            else
                            {
                                //If not 0 then we check for specified item so that discount type 2 can be applied if applicable
                                for (int i = 0; i < prodlist.Count; i++)
                                {
                                    if (ProgOps._intProductID == prodlist[i].intProductID)
                                    {
                                        blnDiscountUsed = true;
                                        blnProductInCart = true;
                                    }
                                }

                                if (blnProductInCart == true)
                                {
                                    decDiscountPercent = ProgOps._decDiscountPercent;
                                    blnProductInCart = false;
                                }
                                else
                                {
                                    MessageBox.Show("Item associated with discount cannot be found in your cart and not applied.", "Product Missing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    blnDiscountUsed = false;
                                }
                                //reset productID
                                ProgOps._intProductID = 0;
                            }

                            tbxDiscount.Text = "";
                            tbxDiscount.Focus();

                            WriteToListBox(decSubTotal, decDiscountPercent, decTaxTotal, decTotal);
                        }
                        else
                        {
                            MessageBox.Show("Discount Code Could Not Be Used!", "Discount Code Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tbxDiscount.Text = "";
                            tbxDiscount.Focus();
                        }
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //reset panels
            pnlCart.Visible = true;
            pnlCheckout.Visible = false;

            //resets Discount usability
            discountUsed.Clear();
            decDiscountPercent = 0.0m;
            blnDiscountUsed = false;

            //reset listox
            lbxCheckOutCart.Items.Clear();

            this.Size = new Size(1200, 630);

        }  
        private void btnDiscountSearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEmplpyee_View_Discount frmEmpDisView = new frmEmplpyee_View_Discount();
            frmEmpDisView.ShowDialog();
            this.Show();
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)//Grab Information from data grid and put it in the lsitboxes
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
                    ProgOps.GrabPicture(pbxImage , strQuery);
                }
                else
                {
                    MessageBox.Show("No Picture For This Item", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            GrabProducts();
            prodlist.Clear();
            WriteToCart();
        }

        private StringBuilder Reciept(decimal decSubTotal, decimal decDiscountPercent, decimal decTaxTotal, decimal decTotal)
        {
            decimal decTotalHold = decTotal;


            //Get Totals For all things
            decSubTotal = decTotalHold;
            decDiscountPercent = decSubTotal * (decDiscountPercent * 0.01M);
            decTaxTotal = decSubTotal * ProgOps._TAX;
            decTotalHold = (decSubTotal - decDiscountPercent) + decTaxTotal;

            StringBuilder html = new StringBuilder();
            StringBuilder css = new StringBuilder();
            css.Append("<style>");
            css.Append("td{padding:5px;text-align:center;font-weight:bold;text-align:center;}");
            css.Append("h1{color:Orange}");
            css.Append("h1{text-align: center}");
            css.Append("h2{color:Blue}");
            css.Append("h2{text-align: center}");
            css.Append("p{text-align: center}");
            css.Append("p{font-size: 18px}");
            css.Append("table.center{margin-left: auto;}");
            css.Append("table.center{margin-right: auto;}");
            css.Append("</style>");


            html.Append("<html>");
            html.Append($"<head>{css}<title>Movie Shop Reciept</title></head>");
            html.Append("<body>");
            html.Append($"<h1>{"Movie Shop Reciept"}</h1>");
            html.Append($"<h2>{"Thank You For Shopping Sage!"}</h2>");

            html.Append("<table class = \"center\">");
            html.Append("<tr><td colspan=3><hr/></td></tr>");
            html.Append("<tr>");
            html.Append("<th>Movie Name</th>");
            html.Append("<th>Movie Price</th>");
            html.Append("<th>Quantity</th>");
            html.Append("</tr>");
            html.Append("<tr>");

            for (int i = 0; i < prodlist.Count(); i++)
            {
                html.Append($"<td>{prodlist[i].strProdName}</td>");
                html.Append($"<td>{prodlist[i].dblProdPrice}</td>");
                html.Append($"<td>{prodlist[i].intProdQuan}</td>");

                html.Append("</tr>");
            }
            html.Append("<tr><td colspan=3><hr/></td></tr>");
            html.Append("</table");
            html.Append("<p>");
            html.Append("<p>");
            html.Append("Customer ID : " + ProgOps._intPersonID.ToString("c2"));
            html.Append("</p>");
            html.Append("<p>");
            html.Append("Subtotal : " + decSubTotal.ToString("c2"));
            html.Append("</p>");
            html.Append("<p>");
            html.Append("Discount : " + decDiscountPercent.ToString("c2"));
            html.Append("</p>");
            html.Append("<p>");
            html.Append("Tax : " + decTaxTotal.ToString("c2"));
            html.Append("</p>");
            html.Append("<p>");
            html.Append("Total : " + decTotal.ToString("c2"));
            html.Append("</p>");
            html.Append("<p>");
            html.Append("Cashier : " + ProgOps._intEmployeeID.ToString());
            html.Append("</p>");
            html.Append("<p>");
            html.Append(DateTime.Now);
            html.Append("</p>");
            html.Append("</body>");
            html.Append("</html>");
            return html;
        }

        private void ReportPrint(StringBuilder html)
        {
            //write to hard drive using the name report.html
            try
            {
                //using statement will automaticaly close a file after opening it
                using (StreamWriter wr = new StreamWriter("Report.html"))
                {
                    wr.WriteLine(html);
                }
                System.Diagnostics.Process.Start(@"Report.html");
            }
            catch (Exception)
            {
                MessageBox.Show("You don't have write permisions", "Error System Permission", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Reset()
        {
            lblProductID.Text = String.Empty;
            lblProductName.Text = String.Empty;
            lblGenre.Text = String.Empty;
            lblProductPrice.Text = String.Empty;
            lblQuantity.Text = String.Empty;
            lblProductDescription.Text = String.Empty;
            pbxImage.Image = Properties.Resources.Logo_SMS;
        }

        public void WriteToListBox(decimal decSubTotal, decimal decDiscountPercent, decimal decTaxTotal, decimal decTotal)
        {
            decimal decTotalHold = decTotal;


            //Get Totals For all things
            decSubTotal = decTotalHold;
            decDiscountPercent = decSubTotal * (decDiscountPercent * 0.01M);
            decTaxTotal = decSubTotal * ProgOps._TAX;
            decTotalHold = (decSubTotal - decDiscountPercent) + decTaxTotal;


            //Write Items to ListBox / CheckOut
            lbxCheckOutCart.Items.Clear();
            lbxCheckOutCart.Items.Add("\tShopping Cart");
            for (int i = 0; i < prodlist.Count(); i++)
            {

                lbxCheckOutCart.Items.Add("Title: " + prodlist[i].strProdName + " | $" + prodlist[i].dblProdPrice + " | " + prodlist[i].intProdQuan);

            }
            lbxCheckOutCart.Items.Add("");
            lbxCheckOutCart.Items.Add("");
            lbxCheckOutCart.Items.Add("");
            lbxCheckOutCart.Items.Add("Sub Total : " + decSubTotal.ToString("c"));
            lbxCheckOutCart.Items.Add("Discount : " + decDiscountPercent.ToString("c2"));
            lbxCheckOutCart.Items.Add("Tax Total : " + decTaxTotal.ToString("C"));
            lbxCheckOutCart.Items.Add("Total : " + (decTotalHold).ToString("C"));
        }

        public void WriteToCart()
        {
            char chPad = ' ';
            lbxOrder.Items.Clear();
            for (int i = 0; i < prodlist.Count(); i++)
            {
                lbxOrder.Items.Add("Movie Title : " + prodlist[i].strProdName.PadRight(10, chPad) + " | \nMovie Price : " + prodlist[i].dblProdPrice.ToString("C2").PadRight(10, chPad) + " | \nQuantity : " +  prodlist[i].intProdQuan.ToString().PadRight(10, chPad));
            }
        }

        private void cbxDisplayCart_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxDisplayCart.Checked)
            {
                pnlShoppingCart.Visible = true ;
                this.Size = new Size(1660, 580);
            }
            else
            {
                pnlShoppingCart.Visible = false;
                this.Size = new Size(1150, 580);
            }
            
        }
    }
}
