
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
            this.lblDate = new System.Windows.Forms.Label();
            this.lblWelcomeUserText = new System.Windows.Forms.Label();
            this.lblBlackLine = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMerchandiseAdd
            // 
            this.btnMerchandiseAdd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMerchandiseAdd.Location = new System.Drawing.Point(82, 270);
            this.btnMerchandiseAdd.Name = "btnMerchandiseAdd";
            this.btnMerchandiseAdd.Size = new System.Drawing.Size(105, 45);
            this.btnMerchandiseAdd.TabIndex = 0;
            this.btnMerchandiseAdd.Text = "Add Merchandise";
            this.btnMerchandiseAdd.UseVisualStyleBackColor = true;
            this.btnMerchandiseAdd.Click += new System.EventHandler(this.btnMerchandiseAdd_Click);
            // 
            // btnViewSales
            // 
            this.btnViewSales.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewSales.Location = new System.Drawing.Point(82, 205);
            this.btnViewSales.Name = "btnViewSales";
            this.btnViewSales.Size = new System.Drawing.Size(105, 45);
            this.btnViewSales.TabIndex = 1;
            this.btnViewSales.Text = "View Sales";
            this.btnViewSales.UseVisualStyleBackColor = true;
            this.btnViewSales.Click += new System.EventHandler(this.btnViewSales_Click);
            // 
            // btnAddDiscount
            // 
            this.btnAddDiscount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDiscount.Location = new System.Drawing.Point(82, 130);
            this.btnAddDiscount.Name = "btnAddDiscount";
            this.btnAddDiscount.Size = new System.Drawing.Size(105, 45);
            this.btnAddDiscount.TabIndex = 2;
            this.btnAddDiscount.Text = "Edit/Add &Discount";
            this.btnAddDiscount.UseVisualStyleBackColor = true;
            this.btnAddDiscount.Click += new System.EventHandler(this.btnAddDiscount_Click);
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCustomer.Location = new System.Drawing.Point(193, 130);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(105, 45);
            this.btnEditCustomer.TabIndex = 3;
            this.btnEditCustomer.Text = "Edit/Add &Customer";
            this.btnEditCustomer.UseVisualStyleBackColor = true;
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditEmployee.Location = new System.Drawing.Point(193, 205);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new System.Drawing.Size(105, 45);
            this.btnEditEmployee.TabIndex = 4;
            this.btnEditEmployee.Text = "Edit / Add Emplpyee";
            this.btnEditEmployee.UseVisualStyleBackColor = true;
            this.btnEditEmployee.Click += new System.EventHandler(this.btnEditEmployee_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(193, 270);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 45);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Sign Out";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(283, 21);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(100, 23);
            this.lblDate.TabIndex = 37;
            this.lblDate.Text = "Date";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWelcomeUserText
            // 
            this.lblWelcomeUserText.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeUserText.Location = new System.Drawing.Point(106, 21);
            this.lblWelcomeUserText.Name = "lblWelcomeUserText";
            this.lblWelcomeUserText.Size = new System.Drawing.Size(173, 34);
            this.lblWelcomeUserText.TabIndex = 36;
            this.lblWelcomeUserText.Text = "Welcome";
            this.lblWelcomeUserText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBlackLine
            // 
            this.lblBlackLine.BackColor = System.Drawing.Color.Black;
            this.lblBlackLine.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlackLine.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBlackLine.Location = new System.Drawing.Point(-50, 59);
            this.lblBlackLine.Name = "lblBlackLine";
            this.lblBlackLine.Size = new System.Drawing.Size(476, 3);
            this.lblBlackLine.TabIndex = 35;
            this.lblBlackLine.Text = "lblBlackLine";
            this.lblBlackLine.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmManager_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 414);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblWelcomeUserText);
            this.Controls.Add(this.lblBlackLine);
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
            this.Load += new System.EventHandler(this.frmManager_Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMerchandiseAdd;
        private System.Windows.Forms.Button btnViewSales;
        private System.Windows.Forms.Button btnAddDiscount;
        private System.Windows.Forms.Button btnEditCustomer;
        private System.Windows.Forms.Button btnEditEmployee;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblWelcomeUserText;
        private System.Windows.Forms.Label lblBlackLine;
    }
}