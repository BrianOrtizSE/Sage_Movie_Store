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
        public decimal decTotal = 0.00m;
        public decimal decTaxTotal = 0.00m;
        public decimal decSubTotal = 0.00m;
        public decimal decDiscountPercent = 0.00m;

        bool blnDiscountDupe = false;
        bool blnDiscountUsed = false;
        int intDiscount = 0;
        public int intRecieptID;
        List<ProdList> prodlist = new List<ProdList>();
        List<string> discountUsed = new List<string>();

        private void btnPay_Click(object sender, EventArgs e)
        {
            int intQuanityHold;
            //Validation to make sure that all input fields are valid
            if (lblCardNumberValid.Text == "X" || lblSCValid.Text == "X" || lblCardHolderValid.Text == "X" || cmbYear.Text == string.Empty || tbxSCode.Text == string.Empty)
            {
                MessageBox.Show("Make Sure All Required Information Is Filled Out!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Validation to make sure card date is valid
                string strDate = (cmbMonth.Text + "/01/" + cmbYear.Text);
                var Date = DateTime.Parse(strDate).Date;
                var DateToday = DateTime.Today;
                if (Date < DateToday)
                {
                    MessageBox.Show("Invalid Card Date , Please Use Valid Card", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //Check to make sure none of this item has been purchased and will make stock below 0                   
                    bool blnEnough = true;
                    bool blnPass = true;
                    
                    if(blnEnough == true)
                    {
                        //First runs through and makes sure its all good
                        for (int i = 0; i < prodlist.Count(); i++)
                        {
                            strQuery = "Select Quantity From OrtizB21Su2332.Products " +
                            "Where ProductID = " + prodlist[i].intProductID;

                            ProgOps.GrabAmount(strQuery);
                            intQuanityHold = prodlist[i].intProdQuan;

                            ProgOps._intQuantity = ProgOps._intQuantity - intQuanityHold;

                            if (ProgOps._intQuantity < 0)
                            {
                                MessageBox.Show("Not Enough The Movie : " + prodlist[i].strProdName + " To Fufill Order", "Not enough inventory", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                blnEnough = false;
                                blnPass = false;
                                break;
                            }
                        }
                    }
                    if(blnPass == true)
                    {
                        for (int i = 0; i < prodlist.Count(); i++)
                        {
                            //Does The Quantity Changes
                            strQuery = "Select Quantity From OrtizB21Su2332.Products " +
                            "Where ProductID = " + prodlist[i].intProductID;

                            ProgOps.GrabAmount(strQuery);
                            intQuanityHold = prodlist[i].intProdQuan;

                            ProgOps._intQuantity = ProgOps._intQuantity - intQuanityHold;

                            strQuery = "Update OrtizB21Su2332.Products Set Quantity = " + ProgOps._intQuantity + " where ProductID = + " + prodlist[i].intProductID;
                            ProgOps.UpdateQuantity(strQuery);

                        }
                        

                        //Creates Reciept
                        strQuery = "Insert into OrtizB21Su2332.Reciept(PersonID ,  EmployeeID , TransData)" +
                            "values(" + ProgOps._intPersonID + "," + ProgOps._intEmployeeID + ", GETDATE()" + ")";
                        ProgOps.CreateInvoice(strQuery);

                        //Grab newest reciept
                        strQuery = "Select RecieptID from OrtizB21Su2332.Reciept order by RecieptID desc";
                        ProgOps.GrabRecieptID(strQuery);

                        intRecieptID = ProgOps._intRecieptID;
                        //Insert The List into the product list info
                        for (int i = 0; i < prodlist.Count(); i++)
                        {
                            strQuery = "Insert into OrtizB21Su2332.RecieptDetail(RecieptID , ProductID , Quantity , PriceOfProduct , Discount) " +
                                "Values( " + ProgOps._intRecieptID + "," + prodlist[i].intProductID + "," + prodlist[i].intProdQuan + "," + prodlist[i].dblProdPrice + "," + decDiscountPercent + ")";
                            ProgOps.CreateInvoice(strQuery);
                        }

                        //WILL GET TOTAL AND INSERT IT INTO SALES!!
                        strQuery = "Insert Into OrtizB21Su2332.Sales(RecieptID , TotalSales , DateOfSale)" +
                            "Values( " + ProgOps._intRecieptID + "," + decTotal.ToString("c2") + ",GETDATE())";
                        ProgOps.CreateInvoice(strQuery);

                        //SWITCH TO DIALOG BOX AND ASK THEM IF THEY WOULD LIKE ONE!!!!!
                        ReportPrint(Reciept(decSubTotal, decDiscountPercent, decTaxTotal, decTotal));

                        this.Close();
                    }

                    
                }

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
                                decSubTotal += dblPrice * decimal.Parse(tbxQuantity.Text);
                                lblToalPrice.Text = "Total : \t" + decSubTotal.ToString("c2");
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


                WriteToListBox(decSubTotal, ref decDiscountPercent, ref decTaxTotal, ref decTotal);
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
                                intDiscount = int.Parse(tbxDiscount.Text);
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
                                        intDiscount = int.Parse(tbxDiscount.Text);
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

                            WriteToListBox(decSubTotal, ref decDiscountPercent, ref decTaxTotal, ref decTotal);
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
            pnlShoppingCart.Visible = false;

            //resets Discount usability
            discountUsed.Clear();
            decDiscountPercent = 0.0m;
            blnDiscountUsed = false;

            //reset listox
            lbxCheckOutCart.Items.Clear();

            //Reset Data Grid
            GrabProducts();

            //TurnOfCheckbox
            cbxDisplayCart.Checked = false;

            this.Size = new Size(1320, 590);

        }  
        private void btnDiscountSearch_Click(object sender, EventArgs e)//Opens Discount View
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

        private void btnClear_Click(object sender, EventArgs e)//Clear All Listbox and labels
        {
            GrabProducts();
            prodlist.Clear();
            WriteToCart();
        }

        private StringBuilder Reciept(decimal decSubTotal, decimal decDiscountPercent, decimal decTaxTotal, decimal decTotal)
        {

            StringBuilder html = new StringBuilder();
            StringBuilder css = new StringBuilder();

            css.Append("<style>");
            css.Append("table {font-family: arial, sans-serif;border-collapse: collapse;width: 100%;}");
            css.Append(".center {text-align: center;color: Orange;}");
            css.Append(".Thank{text-align: center;color: LightBlue;}");
            css.Append("p{font-family: arial, sans-serif;font-size: 18px}");
            css.Append("td, th {border: 1px solid #dddddd;text-align: left;padding: 8px;}");
            css.Append("</style>");


            html.Append("<html>");
            html.Append($"<head>{css}<title>Movie Shop Reciept</title></head>");

            html.Append("<body>");
            html.Append($"<h1 class=\"center\">Sage's Movie Store</h1>");
            html.Append($"<h1 class=\"Thank\";>Welcome To Sages Movie Store!!</h1>");

            html.Append("<p style=\"text - align:left; \">Your Cashier : " + ProgOps._intEmployeeID.ToString() +" <span style=\"float:right; \">Customer ID : " + ProgOps._intPersonID.ToString() + "</span></p>");
            html.Append("<p style=\"text - align:left; \">Reciept ID : " + intRecieptID.ToString() + " <span style=\"float:right; \">Transaction Date : " + (DateTime.Now) + "</span></p>");

            html.Append("<table><tr><th>Movie Name</th><th>Cost</th><th>Quantity</th></tr>");
            for (int i = 0; i < prodlist.Count(); i++)
            {
                html.Append("<tr>");

                html.Append($"<td>{prodlist[i].strProdName}</td>");
                html.Append($"<td>{prodlist[i].dblProdPrice.ToString("c2")}</td>");
                html.Append($"<td>{prodlist[i].intProdQuan}</td>");

                html.Append("</tr>");
            }
            html.Append("</table>");
            html.Append("<table><tr><th>SubTotal</th><th>Discount Total</th><th>Tax Total</th><th>Total</th></tr>");
            html.Append("<tr><td>" + decSubTotal.ToString("c2") + "</td><td>" + decDiscountPercent.ToString("c2") + "</td><td>" + decTaxTotal.ToString("c2") + "</td><td>" + decTotal.ToString("c2") + "</td></tr>");
            html.Append("</tr></table>");

            html.Append("<p style=\"text - align:center\">Thank you for your patronege please come again</p>");
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
                Random random = new Random();
                int randomNumber = random.Next(0, 10000000);
                using (StreamWriter wr = new StreamWriter("Report" +randomNumber.ToString() + ".html" ))
                {
                    wr.WriteLine(html);
                }
                System.Diagnostics.Process.Start(@"Report" + randomNumber.ToString() + ".html");
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

        public void WriteToListBox(decimal decSubTotal,ref decimal decDiscountPercent, ref decimal decTaxTotal,ref decimal decTotal)
        {
            decimal decTotalHold = decSubTotal;


            //Get Totals For all things
            decSubTotal = decTotalHold;
            decDiscountPercent = decSubTotal * (decDiscountPercent * 0.01M);
            decTaxTotal = (decSubTotal - decDiscountPercent) * ProgOps._TAX;
            decTotalHold = (decSubTotal - decDiscountPercent) + decTaxTotal;


            //Write Items to ListBox / CheckOut
            lbxCheckOutCart.Items.Clear();
            lbxCheckOutCart.Items.Add("\tShopping Cart");
            for (int i = 0; i < prodlist.Count(); i++)
            {

                lbxCheckOutCart.Items.Add("Title: " + prodlist[i].strProdName + " | " + prodlist[i].dblProdPrice.ToString("c2") + " | " + prodlist[i].intProdQuan);

            }
            lbxCheckOutCart.Items.Add("");
            lbxCheckOutCart.Items.Add("");
            lbxCheckOutCart.Items.Add("");
            lbxCheckOutCart.Items.Add("Sub Total : " + decSubTotal.ToString("c2"));
            lbxCheckOutCart.Items.Add("Discount : " + decDiscountPercent.ToString("c2"));
            lbxCheckOutCart.Items.Add("Tax Total : " + decTaxTotal.ToString("c2"));
            lbxCheckOutCart.Items.Add("Total : " + (decTotalHold).ToString("c2"));

            decTotal = decTotalHold;
            MessageBox.Show(decDiscountPercent.ToString());
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

        //VALIDATION FOR CARD INFO
        private void cbxDisplayCart_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxDisplayCart.Checked)
            {
                pnlShoppingCart.Visible = true;
            }
            else
            {
                pnlShoppingCart.Visible = false;
            }
            
        }
        private void tbxCardHolderName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Only allow letters and backspace
            if (e.KeyChar >= 65 && e.KeyChar <= 90 ||       //ASCII Check for Capital Letters
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
        private void tbxCardNumber_KeyPress(object sender, KeyPressEventArgs e)
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
        private void tbxSCode_KeyPress(object sender, KeyPressEventArgs e)
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
        private void tbxCardHolderName_TextChanged(object sender, EventArgs e)
        {
            if(tbxCardHolderName.Text == string.Empty)
            {
                lblCardHolderValid.Text = "X";
                lblCardHolderValid.ForeColor = Color.Red;

            }
            else{

                lblCardHolderValid.Text = "\u221A";
                lblCardHolderValid.ForeColor = Color.Green;
                
            }
        }
        private void tbxSCode_TextChanged(object sender, EventArgs e)
        {
            if(tbxSCode.Text.Length != 3)
            {
                lblSCValid.Text = "X";
                lblSCValid.ForeColor = Color.Red;
            }
            else
            {
                lblSCValid.Text = "\u221A";
                lblSCValid.ForeColor = Color.Green;
            }
        }
        private void tbxCardNumber_TextChanged(object sender, EventArgs e)
        {
            if (tbxCardNumber.Text.Length != 12)
            {
                lblCardNumberValid.Text = "X";
                lblCardNumberValid.ForeColor = Color.Red;
            }
            else
            {
                lblCardNumberValid.Text = "\u221A";
                lblCardNumberValid.ForeColor = Color.Green;
            }
        }
        private void mnsHelp_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void tbxQuantity_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void tbxDiscount_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxDiscount_KeyPress(object sender, KeyPressEventArgs e)
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
