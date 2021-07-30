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
    public partial class frmManager_View_Sales : Form
    {
        public frmManager_View_Sales()
        {
            InitializeComponent();
        }
        string strQuery;
        private void frmManager_View_Sales_Load(object sender, EventArgs e)
        {
            strQuery = "Select EmployeeId, Sum(Sale) AS 'Total Sales' " + " From OrtizB21Su2332.Sales " + " Where DateOfSale = cast (GETDATE() as DATE) " + " Group by EmployeeID ";
            ProgOps.GrabSales(dgvSales , strQuery);

            lblDate.Text = "Sales For : " +  DateTime.Today.ToString("d");

            dgvSales.Columns[0].HeaderText = "EmployeeID";
            dgvSales.Columns[1].HeaderText = "Total Sales";
            dgvSales.BackgroundColor = Color.White;
        }

        private void dgvSales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            //Grabs Sales For Today
            strQuery = "Select EmployeeId, Sum(Sale) AS 'Total Sales' " + " From OrtizB21Su2332.Sales " + " Where DateOfSale = cast (GETDATE() as DATE) " + " Group by EmployeeID ";
            ProgOps.GrabSales(dgvSales, strQuery);
            lblDate.Text = "Sales For : " + DateTime.Today.ToString("d");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Grab Sales For The Week
            strQuery = "Select EmployeeId, Sum(Sale) AS 'Total Sales' " + " From OrtizB21Su2332.Sales " + " Where DateOfSale > cast (GETDATE() - 7 as DATE) " + " Group by EmployeeID ";
            ProgOps.GrabSales(dgvSales, strQuery);
            lblDate.Text = "Sales For : " + DateTime.Today.ToString("d") + " - " + DateTime.Today.AddDays(-7).ToString("d");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Grab Sales for the Last Month
            strQuery = "Select EmployeeId, Sum(Sale) AS 'Total Sales' " + " From OrtizB21Su2332.Sales " + " Where DateOfSale > cast (GETDATE() - 30 as DATE) " + " Group by EmployeeID ";
            ProgOps.GrabSales(dgvSales, strQuery);
            lblDate.Text = "Sales For : " + DateTime.Today.ToString("d") + " - " + DateTime.Today.AddDays(-30).ToString("d");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
