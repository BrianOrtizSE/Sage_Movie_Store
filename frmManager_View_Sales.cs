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
    public partial class frmManager_View_Sales : Form
    {
        public frmManager_View_Sales()
        {
            InitializeComponent();
        }
        string strQuery;
        int Report;
        private void frmManager_View_Sales_Load(object sender, EventArgs e)
        {
            Report = 1;
            GrabProduct();
            ViewInvoices();
            ViewSales();
        }

        private void dgvSales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            //Grabs Sales For Today
            strQuery = "Select RecieptID , (TotalSales) AS 'Total Sales' , DateOfSale" + " From OrtizB21Su2332.Sales " + " Where DateOfSale = cast (GETDATE() as DATE)";
            ProgOps.GrabSales(dgvSales, strQuery);
            if (ProgOps._blnFound == false)
            {

            }
            else
            {
                Report = 3;
                dgvInvoices.Visible = false;
                dgvSales.Visible = true;
                dgvProduct.Visible = false;
                dgvSales.Columns[0].HeaderText = "Reciept ID";
                dgvSales.Columns[1].HeaderText = "Sale";
                dgvSales.Columns[1].DefaultCellStyle.Format = "c2";
                dgvSales.Columns[2].HeaderText = "Date";
            }
        }

        private void btnWeekSales_Click(object sender, EventArgs e)
        {
            //Grab Sales For The Week
            strQuery = "Select RecieptID , (TotalSales) AS 'Total Sales' , DateOfSale" + " From OrtizB21Su2332.Sales " + " Where DateOfSale > cast (GETDATE() - 7 as DATE) ";
            ProgOps.GrabSales(dgvSales, strQuery);
            if (ProgOps._blnFound == false)
            {

            }
            else
            {
                Report = 4;
                dgvInvoices.Visible = false;
                dgvSales.Visible = true;
                dgvProduct.Visible = false;
                dgvSales.Columns[0].HeaderText = "Reciept ID";
                dgvSales.Columns[1].HeaderText = "Sale";
                dgvSales.Columns[1].DefaultCellStyle.Format = "c2";
                dgvSales.Columns[2].HeaderText = "Date";
            }

        }

        private void btnMonthlySales_Click(object sender, EventArgs e)
        {
            //Grab Sales for the Last Month
            strQuery = "Select RecieptID , (TotalSales) AS 'Total Sales' , DateOfSale" + " From OrtizB21Su2332.Sales " + " Where DateOfSale > cast (GETDATE() - 30 as DATE) ";
            ProgOps.GrabSales(dgvSales, strQuery);
            if (ProgOps._blnFound == false)
            {

            }
            else
            {
                Report = 5;
                dgvInvoices.Visible = false;
                dgvSales.Visible = true;
                dgvProduct.Visible = false;
                dgvSales.Columns[0].HeaderText = "Reciept ID";
                dgvSales.Columns[1].HeaderText = "Sale";
                dgvSales.Columns[1].DefaultCellStyle.Format = "c2";
                dgvSales.Columns[2].HeaderText = "Date";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            SaveFileDialog svdReport = new SaveFileDialog();
            svdReport.FileName = "Report";

            ReportPrint(Reciept());
            
        }

        public StringBuilder Reciept()
        {
            decimal decPrice = 0;
            decimal decToatlPrice = 0;
            string strPrice;
            StringBuilder html = new StringBuilder();
            StringBuilder css = new StringBuilder();
            DateTime strDate;

            DateTime dtNow = DateTime.Today;
            switch (Report) {

                case 1:
                    css.Append("<style>");
                    css.Append("table {font-family: arial, sans-serif;border-collapse: collapse;width: 100%;}");
                    css.Append(".center {text-align: center;color: Orange;}");
                    css.Append(".Thank{text-align: center;color: LightBlue;}");
                    css.Append("p{font-family: arial, sans-serif;font-size: 18px}");
                    css.Append("td, th {border: 1px solid #dddddd;text-align: left;padding: 8px;}");
                    css.Append("</style>");


                    html.Append("<html>");
                    html.Append($"<head>{css}<title>Product Report</title></head>");

                    html.Append("<body>");
                    html.Append($"<h1 class=\"center\">Product Report</h1>");

                    html.Append("<p style=\"text - align:left; \">Report Date : " + (DateTime.Now) + "</p>");

                    html.Append("<table><tr><th>Product ID</th><th>Product Name</th><th>Quantity</th><th>Product Price</th><th>In Stock</th></tr>");


                    foreach (DataGridViewRow row in dgvProduct.Rows)
                    {
                        html.Append("<tr>");

                        html.Append($"<td>{row.Cells[0].Value.ToString()}</td>");
                        html.Append($"<td>{row.Cells[1].Value.ToString()}</td>");
                        html.Append($"<td>{row.Cells[2].Value.ToString()}</td>");

                        decPrice = Convert.ToDecimal(row.Cells[3].Value);
                        strPrice = decPrice.ToString("c2");

                        html.Append($"<td>{strPrice}</td>");
                        html.Append($"<td>{row.Cells[4].Value.ToString()}</td>");

                        html.Append("</tr>");
                    }

                    html.Append("</body>");
                    html.Append("</html>");
                    break;

                case 2:
                    css.Append("<style>");
                    css.Append("table {font-family: arial, sans-serif;border-collapse: collapse;width: 100%;}");
                    css.Append(".center {text-align: center;color: Orange;}");
                    css.Append(".Thank{text-align: center;color: LightBlue;}");
                    css.Append("p{font-family: arial, sans-serif;font-size: 18px}");
                    css.Append("td, th {border: 1px solid #dddddd;text-align: left;padding: 8px;}");
                    css.Append("</style>");


                    html.Append("<html>");
                    html.Append($"<head>{css}<title>Invoice Report</title></head>");

                    html.Append("<body>");
                    html.Append($"<h1 class=\"center\">Invoice Report</h1>");

                    html.Append("<p style=\"text - align:left; \">Report Date : " + (DateTime.Now) + "</p>");

                    html.Append("<table><tr><th>Invoice ID</th><th>Employee ID</th><th>Source</th><th>Product ID</th><th>Quantity Ordered</th><th>Product Cost</th><th>Invoice Payed</th></tr>");


                    foreach (DataGridViewRow row in dgvInvoices.Rows)
                    {
                        html.Append("<tr>");

                        html.Append($"<td>{row.Cells[0].Value.ToString()}</td>");
                        html.Append($"<td>{row.Cells[1].Value.ToString()}</td>");
                        html.Append($"<td>{row.Cells[2].Value.ToString()}</td>");
                        html.Append($"<td>{row.Cells[3].Value.ToString()}</td>");
                        html.Append($"<td>{row.Cells[4].Value.ToString()}</td>");

                        decPrice = Convert.ToDecimal(row.Cells[5].Value);
                        strPrice = decPrice.ToString("c2");

                        html.Append($"<td>{strPrice}</td>");

                        html.Append($"<td>{row.Cells[6].Value.ToString()}</td>");

                        html.Append("</tr>");
                    }

                    html.Append("</body>");
                    html.Append("</html>");
                    break;

                case 3:                 
                    css.Append("<style>");
                    css.Append("table {font-family: arial, sans-serif;border-collapse: collapse;width: 100%;}");
                    css.Append(".center {text-align: center;color: Orange;}");
                    css.Append(".centerp {text-align: center;}");
                    css.Append(".Thank{text-align: center;color: LightBlue;}");
                    css.Append("p{font-family: arial, sans-serif;font-size: 18px}");
                    css.Append("td, th {border: 1px solid #dddddd;text-align: left;padding: 8px;}");
                    css.Append("</style>");


                    html.Append("<html>");
                    html.Append($"<head>{css}<title>Invoice Report</title></head>");

                    html.Append("<body>");
                    html.Append($"<h1 class=\"center\">Invoice Report</h1>");

                    html.Append("<p style=\"text - align:left; \">Report Date : " + (DateTime.Now) + "</p>");

                    html.Append("<table><tr><th>Reciept ID</th><th>Total Sales</th><th>Date Of Sale</th></tr>");


                    foreach (DataGridViewRow row in dgvSales.Rows)
                    {
                        html.Append("<tr>");

                        html.Append($"<td>{row.Cells[0].Value.ToString()}</td>");

                        decPrice = Convert.ToDecimal(row.Cells[1].Value);
                        decToatlPrice += decPrice;

                        strPrice = decPrice.ToString("c2");
                        html.Append($"<td>{strPrice}</td>");

                        strDate = Convert.ToDateTime(row.Cells[2].Value);
                        strPrice = strDate.ToString("MM-dd-yyyy");
                        html.Append($"<td>{strPrice}</td>");

                        html.Append("</tr>");

                    }
                    html.Append("</table>");
                    html.Append("<p class=\"centerp\">Total Sales</p>");
                    html.Append("<p class=\"centerp\">" + decToatlPrice.ToString("c2") + "</p>");

                    html.Append("</body>");
                    html.Append("</html>");
                    break;

                case 4:

                    css.Append("<style>");
                    css.Append("table {font-family: arial, sans-serif;border-collapse: collapse;width: 100%;}");
                    css.Append(".center {text-align: center;color: Orange;}");
                    css.Append(".Thank{text-align: center;color: LightBlue;}");
                    css.Append("p{font-family: arial, sans-serif;font-size: 18px}");
                    css.Append("td, th {border: 1px solid #dddddd;text-align: left;padding: 8px;}");
                    css.Append("</style>");


                    html.Append("<html>");
                    html.Append($"<head>{css}<title>Invoice Report</title></head>");

                    html.Append("<body>");
                    html.Append($"<h1 class=\"center\">Invoice Report</h1>");
                    html.Append($"<h2 class=\"Thank\">Sales Of " + dtNow.ToString() + " Through " + dtNow.AddDays(-7).ToString() + "</h2>");

                    html.Append("<table><tr><th>Reciept ID</th><th>Total Sales</th><th>Date Of Sale</th></tr>");


                    foreach (DataGridViewRow row in dgvSales.Rows)
                    {
                        html.Append("<tr>");

                        html.Append($"<td>{row.Cells[0].Value.ToString()}</td>");

                        decPrice = Convert.ToDecimal(row.Cells[1].Value);
                        decToatlPrice += decPrice;

                        strPrice = decPrice.ToString("c2");
                        html.Append($"<td>{strPrice}</td>");

                        strDate = Convert.ToDateTime(row.Cells[2].Value);
                        strPrice = strDate.ToString("MM-dd-yyyy");
                        html.Append($"<td>{strPrice}</td>");

                        html.Append("</tr>");

                    }
                    html.Append("</table>");
                    html.Append("<p class=\"centerp\">Total Sales</p>");
                    html.Append("<p class=\"centerp\">" + decToatlPrice.ToString("c2") + "</p>");

                    html.Append("<p style=\"text - align:left; \">Report Date : " + (DateTime.Now) + "</p>");
                    html.Append("</body>");
                    html.Append("</html>");
                    break;



                case 5:

                    css.Append("<style>");
                    css.Append("table {font-family: arial, sans-serif;border-collapse: collapse;width: 100%;}");
                    css.Append(".center {text-align: center;color: Orange;}");
                    css.Append(".Thank{text-align: center;color: LightBlue;}");
                    css.Append("p{font-family: arial, sans-serif;font-size: 18px}");
                    css.Append("td, th {border: 1px solid #dddddd;text-align: left;padding: 8px;}");
                    css.Append("</style>");


                    html.Append("<html>");
                    html.Append($"<head>{css}<title>Invoice Report</title></head>");

                    html.Append("<body>");
                    html.Append($"<h1 class=\"center\">Invoice Report</h1>");
                    html.Append($"<h2 class=\"Thank\">Sales Of " + dtNow.ToString() + " Through " + dtNow.AddDays(-30).ToString() + "</h2>");
                    html.Append("<p style=\"text - align:left; \">Report Date : " + (DateTime.Now) + "</p>");

                    html.Append("<table><tr><th>Reciept ID</th><th>Total Sales</th><th>Date Of Sale</th></tr>");


                    foreach (DataGridViewRow row in dgvSales.Rows)
                    {
                        html.Append("<tr>");

                        html.Append($"<td>{row.Cells[0].Value.ToString()}</td>");

                        decPrice = Convert.ToDecimal(row.Cells[1].Value);
                        decToatlPrice += decPrice;

                        strPrice = decPrice.ToString("c2");
                        html.Append($"<td>{strPrice}</td>");

                        strDate = Convert.ToDateTime(row.Cells[2].Value);
                        strPrice = strDate.ToString("MM-dd-yyyy");
                        html.Append($"<td>{strPrice}</td>");

                        html.Append("</tr>");
                    }
                    html.Append("</table>");
                    html.Append("<p class=\"centerp\">Total Sales</p>");
                    html.Append("<p class=\"centerp\">" + decToatlPrice.ToString("c2") + "</p>");
                    html.Append("<p style=\"text - align:left; \">Report Date : " + (DateTime.Now) + "</p>");
                    html.Append("</body>");
                    html.Append("</html>");
                    break;

                case 6:
                    break;            
            }
           
            return html;
        }

        private void ReportPrint(StringBuilder html)
        {
            //write to hard drive using the name report.html
            try
            {
                Random random = new Random();
                int randomNumber = random.Next(0, 10000000);

                String strFile = string.Empty;
                strFile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                strFile = Path.Combine(strFile, " Report" + randomNumber.ToString() + ".html");

                using (StreamWriter wr = new StreamWriter(strFile))
                {
                    wr.WriteLine(html);
                }

                System.Diagnostics.Process.Start(@strFile);

            }
            catch (Exception ex)
            {
                MessageBox.Show("You don't have write permisions " + ex.ToString(), "Error System Permission", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ViewInvoices()
        {
            strQuery = "Select InvoiceID , EmployeeID , Source , ProductID , OrderQuantity, ProductCost , isPayed from OrtizB21Su2332.Invoice";
            ProgOps.GrabProduct(dgvInvoices, strQuery);

            if (ProgOps._blnFound == false)
            {

            }
            else
            {
                dgvInvoices.Columns[0].HeaderText = "Invoice ID ";
                dgvInvoices.Columns[1].HeaderText = "Manager ID";

                dgvInvoices.Columns[2].HeaderText = "Source";
                dgvInvoices.Columns[3].HeaderText = "Product ID ";
                dgvInvoices.Columns[4].HeaderText = "Order Quantity";
                dgvInvoices.Columns[5].HeaderText = "Product Cost";
                dgvInvoices.Columns[5].DefaultCellStyle.Format = "c2";
                dgvInvoices.Columns[6].HeaderText = "Payed ? ";

            }
        }
        public void GrabProduct()
        {
            strQuery = "Select ProductID , ProductName , Quantity , ProductPrice , inStock from OrtizB21Su2332.Products";
            ProgOps.GrabProduct(dgvProduct, strQuery);

            if (ProgOps._blnFound == false)
            {

            }
            else
            {
                //Setting Titles and such for Grids
                dgvProduct.Columns[0].HeaderText = "Product ID";
                dgvProduct.Columns[1].HeaderText = "Product Name";
                dgvProduct.Columns[2].HeaderText = "Quantity";
                dgvProduct.Columns[3].HeaderText = "Product Price";
                dgvProduct.Columns[3].DefaultCellStyle.Format = "c2";
                dgvProduct.Columns[4].HeaderText = "inStock";
            }


        }
        public void ViewSales()
        {
            if (ProgOps._blnFound == false)
            {

            }
            else
            {
                strQuery = "Select RecieptID,TotalSales,DateOfSale from OrtizB21Su2332.Sales";
                ProgOps.GrabProduct(dgvSales, strQuery);
                //Setting Titles and such for Grids
                dgvSales.Columns[0].HeaderText = "Reciept ID";
                dgvSales.Columns[1].HeaderText = "Sale";
                dgvSales.Columns[1].DefaultCellStyle.Format = "c2";
                dgvSales.Columns[2].HeaderText = "Date";
            }
            
        }
        private void btnViewProduct_Click(object sender, EventArgs e)
        {
            Report = 1;
            dgvProduct.Visible = true;
            dgvSales.Visible = false;
            dgvInvoices.Visible = false;

        }
        private void btnViewInvoice_Click(object sender, EventArgs e)
        {
            Report = 2;
            dgvInvoices.Visible = true;
            dgvSales.Visible = false;
            dgvProduct.Visible = false;

        }
        private void btnViewSales_Click(object sender, EventArgs e)
        {
            Report = 3;
            dgvInvoices.Visible = false;
            dgvSales.Visible = true;
            dgvProduct.Visible = false;
        }
        private void dgvInvoices_DoubleClick(object sender, EventArgs e)
        {
           
        }
        private void dgvSales_DoubleClick(object sender, EventArgs e)
        {
            string RecieptID = dgvSales.SelectedRows[0].Cells[0].Value.ToString();
            if(!int.TryParse(RecieptID, out ProgOps._intRecieptID))
            {

            }
            else
            {
                frmVIewRecieptReport frmVIewReciept = new frmVIewRecieptReport();
                frmVIewReciept.ShowDialog();
            }
        }
        private void dgvInvoices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
