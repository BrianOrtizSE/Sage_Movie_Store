
namespace SU21_Final_Project
{
    partial class frmManager_View_Sales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManager_View_Sales));
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.btnToday = new System.Windows.Forms.Button();
            this.btnWeekSales = new System.Windows.Forms.Button();
            this.btnMonthlySales = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPrintReport = new System.Windows.Forms.Button();
            this.btnViewInvoice = new System.Windows.Forms.Button();
            this.btnViewProduct = new System.Windows.Forms.Button();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.dgvInvoices = new System.Windows.Forms.DataGridView();
            this.btnViewSales = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSales
            // 
            this.dgvSales.AllowUserToAddRows = false;
            this.dgvSales.AllowUserToDeleteRows = false;
            this.dgvSales.AllowUserToOrderColumns = true;
            this.dgvSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSales.Location = new System.Drawing.Point(12, 23);
            this.dgvSales.MultiSelect = false;
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.ReadOnly = true;
            this.dgvSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSales.Size = new System.Drawing.Size(1100, 275);
            this.dgvSales.TabIndex = 8;
            this.dgvSales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSales_CellContentClick);
            this.dgvSales.DoubleClick += new System.EventHandler(this.dgvSales_DoubleClick);
            // 
            // btnToday
            // 
            this.btnToday.Location = new System.Drawing.Point(12, 321);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(92, 40);
            this.btnToday.TabIndex = 0;
            this.btnToday.Text = "Today Sales";
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // btnWeekSales
            // 
            this.btnWeekSales.Location = new System.Drawing.Point(110, 321);
            this.btnWeekSales.Name = "btnWeekSales";
            this.btnWeekSales.Size = new System.Drawing.Size(92, 40);
            this.btnWeekSales.TabIndex = 1;
            this.btnWeekSales.Text = "Week Sales";
            this.btnWeekSales.UseVisualStyleBackColor = true;
            this.btnWeekSales.Click += new System.EventHandler(this.btnWeekSales_Click);
            // 
            // btnMonthlySales
            // 
            this.btnMonthlySales.Location = new System.Drawing.Point(208, 321);
            this.btnMonthlySales.Name = "btnMonthlySales";
            this.btnMonthlySales.Size = new System.Drawing.Size(92, 40);
            this.btnMonthlySales.TabIndex = 2;
            this.btnMonthlySales.Text = "Monthly Sales";
            this.btnMonthlySales.UseVisualStyleBackColor = true;
            this.btnMonthlySales.Click += new System.EventHandler(this.btnMonthlySales_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1020, 321);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(92, 40);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPrintReport
            // 
            this.btnPrintReport.Location = new System.Drawing.Point(922, 321);
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.Size = new System.Drawing.Size(92, 40);
            this.btnPrintReport.TabIndex = 6;
            this.btnPrintReport.Text = "Print Report";
            this.btnPrintReport.UseVisualStyleBackColor = true;
            this.btnPrintReport.Click += new System.EventHandler(this.btnPrintReport_Click);
            // 
            // btnViewInvoice
            // 
            this.btnViewInvoice.Location = new System.Drawing.Point(506, 321);
            this.btnViewInvoice.Name = "btnViewInvoice";
            this.btnViewInvoice.Size = new System.Drawing.Size(92, 40);
            this.btnViewInvoice.TabIndex = 4;
            this.btnViewInvoice.Text = "View Invoices";
            this.btnViewInvoice.UseVisualStyleBackColor = true;
            this.btnViewInvoice.Click += new System.EventHandler(this.btnViewInvoice_Click);
            // 
            // btnViewProduct
            // 
            this.btnViewProduct.Location = new System.Drawing.Point(604, 321);
            this.btnViewProduct.Name = "btnViewProduct";
            this.btnViewProduct.Size = new System.Drawing.Size(92, 40);
            this.btnViewProduct.TabIndex = 5;
            this.btnViewProduct.Text = "View Product";
            this.btnViewProduct.UseVisualStyleBackColor = true;
            this.btnViewProduct.Click += new System.EventHandler(this.btnViewProduct_Click);
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToDeleteRows = false;
            this.dgvProduct.AllowUserToOrderColumns = true;
            this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(12, 23);
            this.dgvProduct.MultiSelect = false;
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(1100, 275);
            this.dgvProduct.TabIndex = 9;
            this.dgvProduct.TabStop = false;
            // 
            // dgvInvoices
            // 
            this.dgvInvoices.AllowUserToAddRows = false;
            this.dgvInvoices.AllowUserToDeleteRows = false;
            this.dgvInvoices.AllowUserToOrderColumns = true;
            this.dgvInvoices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoices.Location = new System.Drawing.Point(12, 23);
            this.dgvInvoices.MultiSelect = false;
            this.dgvInvoices.Name = "dgvInvoices";
            this.dgvInvoices.ReadOnly = true;
            this.dgvInvoices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvoices.Size = new System.Drawing.Size(1100, 275);
            this.dgvInvoices.TabIndex = 10;
            this.dgvInvoices.TabStop = false;
            this.dgvInvoices.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoices_CellContentClick);
            this.dgvInvoices.DoubleClick += new System.EventHandler(this.dgvInvoices_DoubleClick);
            // 
            // btnViewSales
            // 
            this.btnViewSales.Location = new System.Drawing.Point(408, 321);
            this.btnViewSales.Name = "btnViewSales";
            this.btnViewSales.Size = new System.Drawing.Size(92, 40);
            this.btnViewSales.TabIndex = 3;
            this.btnViewSales.Text = "View Sales";
            this.btnViewSales.UseVisualStyleBackColor = true;
            this.btnViewSales.Click += new System.EventHandler(this.btnViewSales_Click);
            // 
            // frmManager_View_Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 373);
            this.Controls.Add(this.btnViewSales);
            this.Controls.Add(this.dgvInvoices);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.btnViewProduct);
            this.Controls.Add(this.btnViewInvoice);
            this.Controls.Add(this.btnPrintReport);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMonthlySales);
            this.Controls.Add(this.btnWeekSales);
            this.Controls.Add(this.btnToday);
            this.Controls.Add(this.dgvSales);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmManager_View_Sales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales View";
            this.Load += new System.EventHandler(this.frmManager_View_Sales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.Button btnWeekSales;
        private System.Windows.Forms.Button btnMonthlySales;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPrintReport;
        private System.Windows.Forms.Button btnViewInvoice;
        private System.Windows.Forms.Button btnViewProduct;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.DataGridView dgvInvoices;
        private System.Windows.Forms.Button btnViewSales;
    }
}