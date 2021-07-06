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
    public partial class frmCreateInvoice : Form
    {
        public frmCreateInvoice()
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
            public ProdList(int intProductID , string strProdName, decimal dblProdPrice, int intProdQuan)
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
        public decimal decSubTotal= 0;
        public decimal decDiscountPercent = 0;

        bool blnDiscountDupe = false;
        bool blnDiscountUsed = false;


        List<ProdList> prodlist = new List<ProdList>();
        List<string> discountUsed = new List<string>();

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCreateInvoice_Load(object sender, EventArgs e)
        {
            //On Load We Display All Items
            strQuery = "Select ProductID , ProductName , Genre , ProductDescription , Quantity , ProductPrice From OrtizB21Su2332.Products Where Quantity > 0";

            ProgOps.GrabProduct(tbxProductID , dgvProducts , strQuery);

            //Setting Titles and such for Grids
            dgvProducts.Columns[0].HeaderText = "Product ID";
            dgvProducts.Columns[1].HeaderText = "Movie Title";
            dgvProducts.Columns[2].HeaderText = "Movie Genre";
            dgvProducts.Columns[3].HeaderText = "Movie Description";
            dgvProducts.Columns[4].HeaderText = "Quantity";

            dgvProducts.Columns[5].DefaultCellStyle.Format = "c";
            dgvProducts.Columns[5].HeaderText = "Movie Price";

            pnlCheckout.Visible = false;



        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            decimal dblPrice;
            int intQuantity = 0;

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

              

                strQuery = "Select ProductID , ProductName , Genre , ProductDescription , Quantity , ProductPrice From OrtizB21Su2332.Products Where Quantity > 0 and ProductID = " + tbxProductID.Text;
                ProgOps.GrabProduct(tbxProductID, dgvProducts, strQuery);

                if(dgvProducts.RowCount != 1)
                {
                    strQuery = "Select Quantity From OrtizB21Su2332.Products Where ProductID = " + tbxProductID.Text;
                    ProgOps.GrabAmount(strQuery);

                    if (int.Parse(tbxQuantity.Text) > ProgOps.intQuantity)
                    {
                        MessageBox.Show("Quanity Ordered Cannot Be Greater Than That Of Inventory", "Over Quantity", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        dblPrice = Convert.ToDecimal(dgvProducts.CurrentRow.Cells[5].Value);
                        prodlist.Add(new ProdList((int)dgvProducts.CurrentRow.Cells[0].Value, dgvProducts.CurrentRow.Cells[1].Value.ToString(), dblPrice, int.Parse(tbxQuantity.Text)));


                        //Write Items to ListBox / Cart
                        lbxOrder.Items.Clear();
                        for (int i = 0; i < prodlist.Count(); i++)
                        {
                            lbxOrder.Items.Add("Title: " + prodlist[i].strProdName + " | $" + prodlist[i].dblProdPrice + " | " + prodlist[i].intProdQuan);
                        }


                        //Update the total and its label
                        decTotal += dblPrice * decimal.Parse(tbxQuantity.Text);
                        lblToalPrice.Text = "Total : \t" + decTotal.ToString("c2");



                        //Reset User
                        tbxProductID.Clear();
                        tbxQuantity.Clear();
                        tbxProductID.Focus();
                    }
                    

                }
                else
                {
                    MessageBox.Show("The entered ID doesn't exist within our inventory.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //Reset Data Grid View
                strQuery = "Select ProductID , ProductName , Genre , ProductDescription , Quantity , ProductPrice From OrtizB21Su2332.Products Where Quantity > 0";
                ProgOps.GrabProduct(tbxProductID, dgvProducts, strQuery);
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int intSelected = 0;

            if (lbxOrder.SelectedIndex == -1)
            {              
                MessageBox.Show("Please Select Item From Cart That You Wish To Remove","Error" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                intSelected = lbxOrder.SelectedIndex;

                decTotal = decTotal - (prodlist[intSelected].dblProdPrice * prodlist[intSelected].intProdQuan);
                lblToalPrice.Text = "Total : \t" + decTotal.ToString("c2");

                prodlist.RemoveAt(intSelected);

                //reset listbox to look clean
                lbxOrder.Items.Clear();
                for (int i = 0; i < prodlist.Count(); i++)
                {
                    lbxOrder.Items.Add("Title: " + prodlist[i].strProdName + " | $" + prodlist[i].dblProdPrice + " | " + prodlist[i].intProdQuan);
                }
            }
            
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            

            if (prodlist.Count == 0)
            {
                MessageBox.Show("Please Add At Least 1 Item To The Cart.", "Shoppnig Cart Empty ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
            {
                //Switches between screens
                pnlCart.Visible = false;
                pnlCheckout.Visible = true;

                
                WriteToListBox(decSubTotal, decDiscountPercent, decTaxTotal, decTotal);
                this.Size = new Size(760, 630);
            }
            

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCloseShop_Click(object sender, EventArgs e)
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

        private void pnlCheckout_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDiscountEnter_Click(object sender, EventArgs e)
        {

            bool blnProductInCart = false;
            tbxDiscount.Text.Trim();

            for (int i = 0; i < discountUsed.Count(); i++)
            {
                if(tbxDiscount.Text == discountUsed[i])
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
                    ProgOps.GetDiscountID(tbxDiscount);
                    if (ProgOps.blnDiscountFound == true)
                    {
                        discountUsed.Add(tbxDiscount.Text);

                        //Type 0 discount code that applies to whole purchase
                        if (ProgOps.intProductID == 0)
                        {
                            decDiscountPercent = ProgOps.decDiscountPercent;
                            blnDiscountUsed = true;
                        }
                        else
                        {
                            //If not 0 then we check for specified item so that discount type 2 can be applied if applicable
                            for (int i = 0; i < prodlist.Count; i++)
                            {
                                if (ProgOps.intProductID == prodlist[i].intProductID)
                                {
                                    blnDiscountUsed = true;
                                    blnProductInCart = true;
                                }
                            }

                            if(blnProductInCart == true)
                            {
                                decDiscountPercent = ProgOps.decDiscountPercent;
                                blnProductInCart = false;
                            }
                            else
                            {
                                MessageBox.Show("Item associated with discount cannot be found in your cart and not applied.", "Product Missing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                blnDiscountUsed = false;
                            }
                            //reset productID
                            ProgOps.intProductID = 0;
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

        public void WriteToListBox(decimal decSubTotal , decimal decDiscountPercent, decimal decTaxTotal , decimal decTotal)
        {
            decimal decTotalHold = decTotal;

            
            //Get Totals For all things
            decSubTotal = decTotalHold;
            decDiscountPercent = decSubTotal * (decDiscountPercent * 0.01M);
            decTaxTotal = decSubTotal* ProgOps._TAX;
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

        private void tbxProductID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
               e.KeyChar >= 48 && e.KeyChar <= 57 ||       //ASCII Check for Numbers
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

        private void tbxQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
               e.KeyChar >= 48 && e.KeyChar <= 57 ||       //ASCII Check for Numbers
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

                for(int i = 0; i < prodlist.Count(); i++)
                {
                    strQuery = "Select Quantity From OrtizB21Su2332.Products " +
                    "Where ProductID = " + prodlist[i].intProductID;

                    ProgOps.GrabAmount(strQuery);
                    intQuanityHold = prodlist[i].intProdQuan;

                    ProgOps.intQuantity = ProgOps.intQuantity - intQuanityHold;

                    strQuery = "Update OrtizB21Su2332.Products Set Quantity = " + ProgOps.intQuantity + " where ProductID = + " + prodlist[i].intProductID;
                    ProgOps.UpdateQuantity(strQuery);
                }
                


                strQuery = "Insert into OrtizB21Su2332.Invoice(PersonID, TotalPrice , TransData)" +
                    "values(" + ProgOps.intPersonID + "," + decTotal + ",GETDATE()" + ")";
                ProgOps.CreateInvoice(strQuery);




                this.Close();
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
            //Only allow letters and backspace
            if (e.KeyChar == 32 ||                          //ASCII Check For Spacebar
                e.KeyChar >= 48 && e.KeyChar <= 57 ||       //ASCII Check for Numbers
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

        private void tbxSCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxSCode_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void tbxDiscount_KeyPress(object sender, KeyPressEventArgs e)
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


    }
}
