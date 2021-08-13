
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
            this.lblDate = new System.Windows.Forms.Label();
            this.lblWelcomeUserText = new System.Windows.Forms.Label();
            this.lblBlackLine = new System.Windows.Forms.Label();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPOS
            // 
            this.btnPOS.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPOS.Location = new System.Drawing.Point(157, 118);
            this.btnPOS.Name = "btnPOS";
            this.btnPOS.Size = new System.Drawing.Size(136, 55);
            this.btnPOS.TabIndex = 0;
            this.btnPOS.Text = "Point Of Sales Sytem";
            this.btnPOS.UseVisualStyleBackColor = true;
            this.btnPOS.Click += new System.EventHandler(this.btnPOS_Click);
            // 
            // btnEditSelfInformation
            // 
            this.btnEditSelfInformation.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditSelfInformation.Location = new System.Drawing.Point(88, 240);
            this.btnEditSelfInformation.Name = "btnEditSelfInformation";
            this.btnEditSelfInformation.Size = new System.Drawing.Size(136, 55);
            this.btnEditSelfInformation.TabIndex = 3;
            this.btnEditSelfInformation.Text = "Edit Your Information";
            this.btnEditSelfInformation.UseVisualStyleBackColor = true;
            this.btnEditSelfInformation.Click += new System.EventHandler(this.btnEditSelfInformation_Click);
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCustomer.Location = new System.Drawing.Point(88, 179);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(136, 55);
            this.btnEditCustomer.TabIndex = 1;
            this.btnEditCustomer.Text = "Edit Customer Information";
            this.btnEditCustomer.UseVisualStyleBackColor = true;
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
            // 
            // btnViewDiscounts
            // 
            this.btnViewDiscounts.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDiscounts.Location = new System.Drawing.Point(230, 179);
            this.btnViewDiscounts.Name = "btnViewDiscounts";
            this.btnViewDiscounts.Size = new System.Drawing.Size(136, 55);
            this.btnViewDiscounts.TabIndex = 2;
            this.btnViewDiscounts.Text = "View Store Discounts";
            this.btnViewDiscounts.UseVisualStyleBackColor = true;
            this.btnViewDiscounts.Click += new System.EventHandler(this.btnViewDiscounts_Click);
            // 
            // btnViewInventory
            // 
            this.btnViewInventory.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewInventory.Location = new System.Drawing.Point(230, 240);
            this.btnViewInventory.Name = "btnViewInventory";
            this.btnViewInventory.Size = new System.Drawing.Size(136, 55);
            this.btnViewInventory.TabIndex = 4;
            this.btnViewInventory.Text = "View Store Inventory";
            this.btnViewInventory.UseVisualStyleBackColor = true;
            this.btnViewInventory.Click += new System.EventHandler(this.btnViewInventory_Click);
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(346, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(100, 23);
            this.lblDate.TabIndex = 34;
            this.lblDate.Text = "Date";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWelcomeUserText
            // 
            this.lblWelcomeUserText.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeUserText.Location = new System.Drawing.Point(137, 9);
            this.lblWelcomeUserText.Name = "lblWelcomeUserText";
            this.lblWelcomeUserText.Size = new System.Drawing.Size(173, 34);
            this.lblWelcomeUserText.TabIndex = 33;
            this.lblWelcomeUserText.Text = "Welcome";
            this.lblWelcomeUserText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBlackLine
            // 
            this.lblBlackLine.BackColor = System.Drawing.Color.Black;
            this.lblBlackLine.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlackLine.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBlackLine.Location = new System.Drawing.Point(11, 47);
            this.lblBlackLine.Name = "lblBlackLine";
            this.lblBlackLine.Size = new System.Drawing.Size(476, 3);
            this.lblBlackLine.TabIndex = 32;
            this.lblBlackLine.Text = "lblBlackLine";
            this.lblBlackLine.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSignOut
            // 
            this.btnSignOut.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.Location = new System.Drawing.Point(378, 357);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(88, 37);
            this.btnSignOut.TabIndex = 5;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // frmEmployee_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 406);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblWelcomeUserText);
            this.Controls.Add(this.lblBlackLine);
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
            this.Load += new System.EventHandler(this.frmEmployee_Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPOS;
        private System.Windows.Forms.Button btnEditSelfInformation;
        private System.Windows.Forms.Button btnEditCustomer;
        private System.Windows.Forms.Button btnViewDiscounts;
        private System.Windows.Forms.Button btnViewInventory;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblWelcomeUserText;
        private System.Windows.Forms.Label lblBlackLine;
        private System.Windows.Forms.Button btnSignOut;
    }
}