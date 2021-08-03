
namespace SU21_Final_Project
{
    partial class frmManager_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManager_Main));
            this.btnMerchandiseAdd = new System.Windows.Forms.Button();
            this.btnViewSales = new System.Windows.Forms.Button();
            this.btnAddDiscount = new System.Windows.Forms.Button();
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.btnEditEmployee = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMerchandiseAdd
            // 
            this.btnMerchandiseAdd.Location = new System.Drawing.Point(274, 287);
            this.btnMerchandiseAdd.Name = "btnMerchandiseAdd";
            this.btnMerchandiseAdd.Size = new System.Drawing.Size(105, 45);
            this.btnMerchandiseAdd.TabIndex = 0;
            this.btnMerchandiseAdd.Text = "Add Merchandise";
            this.btnMerchandiseAdd.UseVisualStyleBackColor = true;
            this.btnMerchandiseAdd.Click += new System.EventHandler(this.btnMerchandiseAdd_Click);
            // 
            // btnViewSales
            // 
            this.btnViewSales.Location = new System.Drawing.Point(274, 222);
            this.btnViewSales.Name = "btnViewSales";
            this.btnViewSales.Size = new System.Drawing.Size(105, 45);
            this.btnViewSales.TabIndex = 1;
            this.btnViewSales.Text = "View Sales";
            this.btnViewSales.UseVisualStyleBackColor = true;
            this.btnViewSales.Click += new System.EventHandler(this.btnViewSales_Click);
            // 
            // btnAddDiscount
            // 
            this.btnAddDiscount.Location = new System.Drawing.Point(274, 147);
            this.btnAddDiscount.Name = "btnAddDiscount";
            this.btnAddDiscount.Size = new System.Drawing.Size(105, 45);
            this.btnAddDiscount.TabIndex = 2;
            this.btnAddDiscount.Text = "Edit/Add &Discount";
            this.btnAddDiscount.UseVisualStyleBackColor = true;
            this.btnAddDiscount.Click += new System.EventHandler(this.btnAddDiscount_Click);
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.Location = new System.Drawing.Point(385, 147);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(105, 45);
            this.btnEditCustomer.TabIndex = 3;
            this.btnEditCustomer.Text = "Edit/Add &Customer";
            this.btnEditCustomer.UseVisualStyleBackColor = true;
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.Location = new System.Drawing.Point(385, 222);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new System.Drawing.Size(105, 45);
            this.btnEditEmployee.TabIndex = 4;
            this.btnEditEmployee.Text = "Edit / Add Emplpyee";
            this.btnEditEmployee.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(385, 287);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 45);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Sign Out";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmManager_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnEditEmployee);
            this.Controls.Add(this.btnEditCustomer);
            this.Controls.Add(this.btnAddDiscount);
            this.Controls.Add(this.btnViewSales);
            this.Controls.Add(this.btnMerchandiseAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmManager_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manager MaIn Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMerchandiseAdd;
        private System.Windows.Forms.Button btnViewSales;
        private System.Windows.Forms.Button btnAddDiscount;
        private System.Windows.Forms.Button btnEditCustomer;
        private System.Windows.Forms.Button btnEditEmployee;
        private System.Windows.Forms.Button btnClose;
    }
}