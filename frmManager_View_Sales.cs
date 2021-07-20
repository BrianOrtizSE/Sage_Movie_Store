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

            dgvSales.Columns[0].HeaderText = "EmployeeID";
            dgvSales.Columns[1].HeaderText = "Total Sales";
            dgvSales.BackgroundColor = Color.White;
        }

        private void dgvSales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            strQuery = "Select EmployeeId, Sum(Sale) AS 'Total Sales' " + " From OrtizB21Su2332.Sales " + " Where DateOfSale = cast (GETDATE() as DATE) " + " Group by EmployeeID ";
            ProgOps.GrabSales(dgvSales, strQuery);
        }
    }
}
