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

        
        public string strQuery;
        public double Total = 0.0;

        public struct ProdList
        {
            //struct variables
            public string strProdName;
            public double dblProdPrice;
            public int intProdQuan;

            //constructor
            public ProdList(string strProdName, double dblProdPrice, int intProdQuan)
            {
                this.strProdName = strProdName;
                this.dblProdPrice = dblProdPrice;
                this.intProdQuan = intProdQuan;
            }
        }

        List<ProdList> prodlist = new List<ProdList>();

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

                strQuery = "Select ProductID , ProductName , Genre , ProductDescription , Quantity , ProductPrice From OrtizB21Su2332.Products Where Quantity > 0 and ProductID = " + tbxProductID.Text;
                ProgOps.GrabProduct(tbxProductID, dgvProducts, strQuery);

                if(dgvProducts.RowCount != 1)
                {
                    dblPrice = Convert.ToDouble(dgvProducts.CurrentRow.Cells[5].Value);
                    prodlist.Add(new ProdList(dgvProducts.CurrentRow.Cells[1].Value.ToString(), dblPrice, int.Parse(tbxQuantity.Text)));

                    //Write Items to ListBox / Cart
                    lbxOrder.Items.Clear();
                    for(int i = 0; i < prodlist.Count(); i++)
                    {
                        lbxOrder.Items.Add("Title: " + prodlist[i].strProdName + " | $" + prodlist[i].dblProdPrice + " | " + prodlist[i].intProdQuan);
                    } 
                    

                    //Update the total and its label
                    Total += dblPrice * double.Parse(tbxQuantity.Text);
                    lblToalPrice.Text = "Total : \t" + Total.ToString("c2");

                    //Reset User
                    tbxProductID.Clear();
                    tbxQuantity.Clear();
                    tbxProductID.Focus();

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

                Total = Total - (prodlist[intSelected].dblProdPrice * prodlist[intSelected].intProdQuan);
                lblToalPrice.Text = "Total : \t" + Total.ToString("c2");

                prodlist.RemoveAt(intSelected);
                lbxOrder.Items.Clear();
                for (int i = 0; i < prodlist.Count(); i++)
                {
                    lbxOrder.Items.Add("Title: " + prodlist[i].strProdName + " | $" + prodlist[i].dblProdPrice + " | " + prodlist[i].intProdQuan);
                }
            }
            
        }
    }
}
