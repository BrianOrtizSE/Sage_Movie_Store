
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
            this.SuspendLayout();
            // 
            // btnMerchandiseAdd
            // 
            this.btnMerchandiseAdd.Location = new System.Drawing.Point(320, 351);
            this.btnMerchandiseAdd.Name = "btnMerchandiseAdd";
            this.btnMerchandiseAdd.Size = new System.Drawing.Size(105, 45);
            this.btnMerchandiseAdd.TabIndex = 0;
            this.btnMerchandiseAdd.Text = "Add Merchandise";
            this.btnMerchandiseAdd.UseVisualStyleBackColor = true;
            this.btnMerchandiseAdd.Click += new System.EventHandler(this.btnMerchandiseAdd_Click);
            // 
            // btnViewSales
            // 
            this.btnViewSales.Location = new System.Drawing.Point(320, 264);
            this.btnViewSales.Name = "btnViewSales";
            this.btnViewSales.Size = new System.Drawing.Size(105, 45);
            this.btnViewSales.TabIndex = 1;
            this.btnViewSales.Text = "View Sales";
            this.btnViewSales.UseVisualStyleBackColor = true;
            this.btnViewSales.Click += new System.EventHandler(this.btnViewSales_Click);
            // 
            // btnAddDiscount
            // 
            this.btnAddDiscount.Location = new System.Drawing.Point(320, 189);
            this.btnAddDiscount.Name = "btnAddDiscount";
            this.btnAddDiscount.Size = new System.Drawing.Size(105, 45);
            this.btnAddDiscount.TabIndex = 2;
            this.btnAddDiscount.Text = "Edit/Add &Discount";
            this.btnAddDiscount.UseVisualStyleBackColor = true;
            this.btnAddDiscount.Click += new System.EventHandler(this.btnAddDiscount_Click);
            // 
            // frmManager_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddDiscount);
            this.Controls.Add(this.btnViewSales);
            this.Controls.Add(this.btnMerchandiseAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmManager_Main";
            this.Text = "Manager MaIn Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMerchandiseAdd;
        private System.Windows.Forms.Button btnViewSales;
        private System.Windows.Forms.Button btnAddDiscount;
    }
}