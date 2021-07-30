
namespace SU21_Final_Project
{
    partial class frmEmployee_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployee_Main));
            this.btnPOS = new System.Windows.Forms.Button();
            this.btnEditSelfInformation = new System.Windows.Forms.Button();
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.btnViewDiscounts = new System.Windows.Forms.Button();
            this.btnViewInventory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPOS
            // 
            this.btnPOS.Location = new System.Drawing.Point(301, 205);
            this.btnPOS.Name = "btnPOS";
            this.btnPOS.Size = new System.Drawing.Size(136, 55);
            this.btnPOS.TabIndex = 0;
            this.btnPOS.Text = "Point Of Sales Sytem";
            this.btnPOS.UseVisualStyleBackColor = true;
            this.btnPOS.Click += new System.EventHandler(this.btnPOS_Click);
            // 
            // btnEditSelfInformation
            // 
            this.btnEditSelfInformation.Location = new System.Drawing.Point(232, 327);
            this.btnEditSelfInformation.Name = "btnEditSelfInformation";
            this.btnEditSelfInformation.Size = new System.Drawing.Size(136, 55);
            this.btnEditSelfInformation.TabIndex = 1;
            this.btnEditSelfInformation.Text = "Edit Your Information";
            this.btnEditSelfInformation.UseVisualStyleBackColor = true;
            this.btnEditSelfInformation.Click += new System.EventHandler(this.btnEditSelfInformation_Click);
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.Location = new System.Drawing.Point(232, 266);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(136, 55);
            this.btnEditCustomer.TabIndex = 2;
            this.btnEditCustomer.Text = "Edit Customer Information";
            this.btnEditCustomer.UseVisualStyleBackColor = true;
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
            // 
            // btnViewDiscounts
            // 
            this.btnViewDiscounts.Location = new System.Drawing.Point(374, 266);
            this.btnViewDiscounts.Name = "btnViewDiscounts";
            this.btnViewDiscounts.Size = new System.Drawing.Size(136, 55);
            this.btnViewDiscounts.TabIndex = 3;
            this.btnViewDiscounts.Text = "View Store Discounts";
            this.btnViewDiscounts.UseVisualStyleBackColor = true;
            this.btnViewDiscounts.Click += new System.EventHandler(this.btnViewDiscounts_Click);
            // 
            // btnViewInventory
            // 
            this.btnViewInventory.Location = new System.Drawing.Point(374, 327);
            this.btnViewInventory.Name = "btnViewInventory";
            this.btnViewInventory.Size = new System.Drawing.Size(136, 55);
            this.btnViewInventory.TabIndex = 4;
            this.btnViewInventory.Text = "View Store Inventory";
            this.btnViewInventory.UseVisualStyleBackColor = true;
            this.btnViewInventory.Click += new System.EventHandler(this.btnViewInventory_Click);
            // 
            // frmEmployee_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnViewInventory);
            this.Controls.Add(this.btnViewDiscounts);
            this.Controls.Add(this.btnEditCustomer);
            this.Controls.Add(this.btnEditSelfInformation);
            this.Controls.Add(this.btnPOS);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmEmployee_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPOS;
        private System.Windows.Forms.Button btnEditSelfInformation;
        private System.Windows.Forms.Button btnEditCustomer;
        private System.Windows.Forms.Button btnViewDiscounts;
        private System.Windows.Forms.Button btnViewInventory;
    }
}