
namespace SU21_Final_Project
{
    partial class frmCreateInvoice
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
            this.lblProdError = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblShoppingCart = new System.Windows.Forms.Label();
            this.lblLine = new System.Windows.Forms.Label();
            this.lblOrderDetails = new System.Windows.Forms.Label();
            this.tbxQuantity = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddToOrder = new System.Windows.Forms.Button();
            this.lbltextID = new System.Windows.Forms.Label();
            this.lbxOrder = new System.Windows.Forms.ListBox();
            this.tbxProductID = new System.Windows.Forms.TextBox();
            this.lblToalPrice = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProdError
            // 
            this.lblProdError.AutoSize = true;
            this.lblProdError.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdError.ForeColor = System.Drawing.Color.Red;
            this.lblProdError.Location = new System.Drawing.Point(213, 121);
            this.lblProdError.Name = "lblProdError";
            this.lblProdError.Size = new System.Drawing.Size(88, 16);
            this.lblProdError.TabIndex = 23;
            this.lblProdError.Text = "Numbers Only";
            this.lblProdError.Visible = false;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(210, 179);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(98, 16);
            this.lblError.TabIndex = 24;
            this.lblError.Text = "*Required Field";
            this.lblError.Visible = false;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(522, 14);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(95, 25);
            this.lblProduct.TabIndex = 27;
            this.lblProduct.Text = "Movies : ";
            this.lblProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblShoppingCart
            // 
            this.lblShoppingCart.AutoSize = true;
            this.lblShoppingCart.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShoppingCart.Location = new System.Drawing.Point(869, 14);
            this.lblShoppingCart.Name = "lblShoppingCart";
            this.lblShoppingCart.Size = new System.Drawing.Size(160, 25);
            this.lblShoppingCart.TabIndex = 29;
            this.lblShoppingCart.Text = "Shopping Cart :";
            this.lblShoppingCart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLine
            // 
            this.lblLine.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLine.Location = new System.Drawing.Point(19, 51);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(320, 3);
            this.lblLine.TabIndex = 26;
            // 
            // lblOrderDetails
            // 
            this.lblOrderDetails.AutoSize = true;
            this.lblOrderDetails.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderDetails.Location = new System.Drawing.Point(70, 14);
            this.lblOrderDetails.Name = "lblOrderDetails";
            this.lblOrderDetails.Size = new System.Drawing.Size(117, 25);
            this.lblOrderDetails.TabIndex = 25;
            this.lblOrderDetails.Text = "Shop Menu";
            this.lblOrderDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxQuantity
            // 
            this.tbxQuantity.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxQuantity.Location = new System.Drawing.Point(75, 173);
            this.tbxQuantity.Name = "tbxQuantity";
            this.tbxQuantity.Size = new System.Drawing.Size(132, 27);
            this.tbxQuantity.TabIndex = 17;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(107, 151);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(71, 19);
            this.lblAmount.TabIndex = 22;
            this.lblAmount.Text = "Amount ";
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.Location = new System.Drawing.Point(169, 385);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(107, 40);
            this.btnCheckOut.TabIndex = 19;
            this.btnCheckOut.Text = "&CheckOut";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvProducts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(345, 51);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 72;
            this.dgvProducts.Size = new System.Drawing.Size(491, 370);
            this.dgvProducts.TabIndex = 28;
            this.dgvProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellContentClick);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(169, 431);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(107, 40);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "&Return";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToOrder.Location = new System.Drawing.Point(49, 385);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(114, 40);
            this.btnAddToOrder.TabIndex = 18;
            this.btnAddToOrder.Text = "&Add";
            this.btnAddToOrder.UseVisualStyleBackColor = true;
            this.btnAddToOrder.Click += new System.EventHandler(this.btnAddToOrder_Click);
            // 
            // lbltextID
            // 
            this.lbltextID.AutoSize = true;
            this.lbltextID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltextID.Location = new System.Drawing.Point(107, 91);
            this.lbltextID.Name = "lbltextID";
            this.lbltextID.Size = new System.Drawing.Size(67, 19);
            this.lbltextID.TabIndex = 21;
            this.lbltextID.Text = "MovieID";
            // 
            // lbxOrder
            // 
            this.lbxOrder.FormattingEnabled = true;
            this.lbxOrder.Location = new System.Drawing.Point(853, 51);
            this.lbxOrder.Name = "lbxOrder";
            this.lbxOrder.Size = new System.Drawing.Size(272, 368);
            this.lbxOrder.TabIndex = 30;
            // 
            // tbxProductID
            // 
            this.tbxProductID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxProductID.Location = new System.Drawing.Point(75, 116);
            this.tbxProductID.Name = "tbxProductID";
            this.tbxProductID.Size = new System.Drawing.Size(132, 27);
            this.tbxProductID.TabIndex = 16;
            // 
            // lblToalPrice
            // 
            this.lblToalPrice.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToalPrice.Location = new System.Drawing.Point(853, 431);
            this.lblToalPrice.Name = "lblToalPrice";
            this.lblToalPrice.Size = new System.Drawing.Size(208, 40);
            this.lblToalPrice.TabIndex = 31;
            this.lblToalPrice.Text = "Total: ";
            this.lblToalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(49, 431);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(114, 40);
            this.btnRemove.TabIndex = 32;
            this.btnRemove.Text = "R&emove Item";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // frmCreateInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 491);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblProdError);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblToalPrice);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.lblShoppingCart);
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.lblOrderDetails);
            this.Controls.Add(this.tbxQuantity);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddToOrder);
            this.Controls.Add(this.lbltextID);
            this.Controls.Add(this.lbxOrder);
            this.Controls.Add(this.tbxProductID);
            this.Name = "frmCreateInvoice";
            this.Text = "frmCreateInvoice";
            this.Load += new System.EventHandler(this.frmCreateInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProdError;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblShoppingCart;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Label lblOrderDetails;
        private System.Windows.Forms.TextBox tbxQuantity;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddToOrder;
        private System.Windows.Forms.Label lbltextID;
        private System.Windows.Forms.ListBox lbxOrder;
        private System.Windows.Forms.TextBox tbxProductID;
        private System.Windows.Forms.Label lblToalPrice;
        private System.Windows.Forms.Button btnRemove;
    }
}