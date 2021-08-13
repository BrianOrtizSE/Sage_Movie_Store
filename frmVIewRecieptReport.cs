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
    public partial class frmVIewRecieptReport : Form
    {
        public frmVIewRecieptReport()
        {
            InitializeComponent();
        }

        private void frmVIewRecieptReport_Load(object sender, EventArgs e)
        {
            string strQuery = "Select * from OrtizB21Su2332.RecieptDetail where RecieptID = " + ProgOps._intRecieptID;
            ProgOps.GrabProduct(dgvReciept, strQuery);
            dgvReciept.Columns[0].HeaderText = "Reciept ID";
            dgvReciept.Columns[1].HeaderText = "Product ID ";
            dgvReciept.Columns[2].HeaderText = "Quantity ";
            dgvReciept.Columns[3].HeaderText = "Price Of Product ";
            dgvReciept.Columns[4].HeaderText = "Discount ID ";
            dgvReciept.Columns[3].DefaultCellStyle.Format = "c2";

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            ReportPrint(Reciept());
        }
        public StringBuilder Reciept()
        {
            decimal decSub;
            decimal decSubTotal = 0;

            decimal decDiscount = 0;

            decimal decTotal;
            decimal decTax = 0;
            decimal decPrice;

            int intQuantity;
            int intDiscountID;

            string strPrice;
            
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
            html.Append($"<head>{css}<title>Product Report</title></head>");

            html.Append("<body>");
            html.Append($"<h1 class=\"center\">Product Report</h1>");

            html.Append("<p style=\"text - align:left; \">Report Date : " + (DateTime.Now) + "</p>");

            html.Append("<table><tr><th>Reciept ID</th><th>Product ID</th><th>Quantity</th><th>Product Price</th><th>Discount Amount</th></tr>");


            foreach (DataGridViewRow row in dgvReciept.Rows)
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

                intQuantity = Convert.ToInt32(row.Cells[2].Value);
                decPrice = Convert.ToDecimal(row.Cells[3].Value);

                decDiscount = Convert.ToDecimal(row.Cells[4].Value);

                decSub = intQuantity * decPrice;
                decSubTotal = decSubTotal + decSub;
            }

            html.Append("</table>");
            html.Append("<table><tr><th>SubTotal</th><th>Discount Total</th><th>Tax Total</th><th>Total</th></tr>");
            html.Append("<tr><td>" + decSubTotal.ToString("c2") + "</td><td>" + decDiscount.ToString("c2") + "</td>");
            decTax = (decSubTotal - decDiscount) * ProgOps._TAX;
            decTotal = decSubTotal + decTax;
            html.Append("<td>" + decTax.ToString("c2") + "</td><td>" + decTotal.ToString("c2") + "</td></tr>");
            html.Append("</tr></table>");

            html.Append("</body>");
            html.Append("</html>");
             

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
            catch (Exception)
            {
                MessageBox.Show("You don't have write permisions", "Error System Permission", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
