
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateInvoice));
            this.pnlCheckout = new System.Windows.Forms.Panel();
            this.btnDiscountEnter = new System.Windows.Forms.Button();
            this.lblDiscountCode = new System.Windows.Forms.Label();
            this.tbxDiscount = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbxCheckOutCart = new System.Windows.Forms.ListBox();
            this.lblOrderDetails = new System.Windows.Forms.Label();
            this.lblLine = new System.Windows.Forms.Label();
            this.tbxQuantity = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.btnAddToOrder = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.lbxOrder = new System.Windows.Forms.ListBox();
            this.lbltextID = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.lblProdError = new System.Windows.Forms.Label();
            this.lblShoppingCart = new System.Windows.Forms.Label();
            this.tbxProductID = new System.Windows.Forms.TextBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblToalPrice = new System.Windows.Forms.Label();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnCloseShop = new System.Windows.Forms.Button();
            this.pnlCart = new System.Windows.Forms.Panel();
            this.pnlCheckout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.pnlCart.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCheckout
            // 
            this.pnlCheckout.Controls.Add(this.btnDiscountEnter);
            this.pnlCheckout.Controls.Add(this.lblDiscountCode);
            this.pnlCheckout.Controls.Add(this.tbxDiscount);
            this.pnlCheckout.Controls.Add(this.btnClose);
            this.pnlCheckout.Controls.Add(this.lbxCheckOutCart);
            this.pnlCheckout.Location = new System.Drawing.Point(12, 12);
            this.pnlCheckout.Name = "pnlCheckout";
            this.pnlCheckout.Size = new System.Drawing.Size(554, 521);
            this.pnlCheckout.TabIndex = 34;
            this.pnlCheckout.Visible = false;
            this.pnlCheckout.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCheckout_Paint);
            // 
            // btnDiscountEnter
            // 
            this.btnDiscountEnter.Location = new System.Drawing.Point(123, 31);
            this.btnDiscountEnter.Name = "btnDiscountEnter";
            this.btnDiscountEnter.Size = new System.Drawing.Size(50, 20);
            this.btnDiscountEnter.TabIndex = 4;
            this.btnDiscountEnter.Text = "Enter";
            this.btnDiscountEnter.UseVisualStyleBackColor = true;
            this.btnDiscountEnter.Click += new System.EventHandler(this.btnDiscountEnter_Click);
            // 
            // lblDiscountCode
            // 
            this.lblDiscountCode.AutoSize = true;
            this.lblDiscountCode.Location = new System.Drawing.Point(14, 7);
            this.lblDiscountCode.Name = "lblDiscountCode";
            this.lblDiscountCode.Size = new System.Drawing.Size(86, 13);
            this.lblDiscountCode.TabIndex = 3;
            this.lblDiscountCode.Text = "Discount Code : ";
            // 
            // tbxDiscount
            // 
            this.tbxDiscount.Location = new System.Drawing.Point(17, 31);
            this.tbxDiscount.Name = "tbxDiscount";
            this.tbxDiscount.Size = new System.Drawing.Size(100, 20);
            this.tbxDiscount.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(163, 458);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(101, 36);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "&Return To Cart";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnCloseShop_Click);
            // 
            // lbxCheckOutCart
            // 
            this.lbxCheckOutCart.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxCheckOutCart.FormattingEnabled = true;
            this.lbxCheckOutCart.ItemHeight = 15;
            this.lbxCheckOutCart.Location = new System.Drawing.Point(294, 10);
            this.lbxCheckOutCart.Name = "lbxCheckOutCart";
            this.lbxCheckOutCart.Size = new System.Drawing.Size(232, 484);
            this.lbxCheckOutCart.TabIndex = 0;
            // 
            // lblOrderDetails
            // 
            this.lblOrderDetails.AutoSize = true;
            this.lblOrderDetails.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderDetails.Location = new System.Drawing.Point(74, 22);
            this.lblOrderDetails.Name = "lblOrderDetails";
            this.lblOrderDetails.Size = new System.Drawing.Size(117, 25);
            this.lblOrderDetails.TabIndex = 25;
            this.lblOrderDetails.Text = "Shop Menu";
            this.lblOrderDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLine
            // 
            this.lblLine.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLine.Location = new System.Drawing.Point(3, 59);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(320, 3);
            this.lblLine.TabIndex = 26;
            // 
            // tbxQuantity
            // 
            this.tbxQuantity.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxQuantity.Location = new System.Drawing.Point(59, 167);
            this.tbxQuantity.Name = "tbxQuantity";
            this.tbxQuantity.Size = new System.Drawing.Size(132, 27);
            this.tbxQuantity.TabIndex = 17;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(91, 145);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(71, 19);
            this.lblAmount.TabIndex = 22;
            this.lblAmount.Text = "Amount ";
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToOrder.Location = new System.Drawing.Point(28, 336);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(114, 40);
            this.btnAddToOrder.TabIndex = 18;
            this.btnAddToOrder.Text = "&Add";
            this.btnAddToOrder.UseVisualStyleBackColor = true;
            this.btnAddToOrder.Click += new System.EventHandler(this.btnAddToOrder_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(194, 173);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(98, 16);
            this.lblError.TabIndex = 24;
            this.lblError.Text = "*Required Field";
            this.lblError.Visible = false;
            // 
            // lbxOrder
            // 
            this.lbxOrder.FormattingEnabled = true;
            this.lbxOrder.Location = new System.Drawing.Point(836, 59);
            this.lbxOrder.Name = "lbxOrder";
            this.lbxOrder.Size = new System.Drawing.Size(272, 394);
            this.lbxOrder.TabIndex = 30;
            // 
            // lbltextID
            // 
            this.lbltextID.AutoSize = true;
            this.lbltextID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltextID.Location = new System.Drawing.Point(91, 85);
            this.lbltextID.Name = "lbltextID";
            this.lbltextID.Size = new System.Drawing.Size(67, 19);
            this.lbltextID.TabIndex = 21;
            this.lbltextID.Text = "MovieID";
            // 
            // dgvProducts
            // 
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvProducts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(330, 59);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 72;
            this.dgvProducts.Size = new System.Drawing.Size(491, 394);
            this.dgvProducts.TabIndex = 28;
            this.dgvProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellContentClick);
            // 
            // lblProdError
            // 
            this.lblProdError.AutoSize = true;
            this.lblProdError.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdError.ForeColor = System.Drawing.Color.Red;
            this.lblProdError.Location = new System.Drawing.Point(197, 115);
            this.lblProdError.Name = "lblProdError";
            this.lblProdError.Size = new System.Drawing.Size(88, 16);
            this.lblProdError.TabIndex = 23;
            this.lblProdError.Text = "Numbers Only";
            this.lblProdError.Visible = false;
            // 
            // lblShoppingCart
            // 
            this.lblShoppingCart.AutoSize = true;
            this.lblShoppingCart.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShoppingCart.Location = new System.Drawing.Point(884, 8);
            this.lblShoppingCart.Name = "lblShoppingCart";
            this.lblShoppingCart.Size = new System.Drawing.Size(160, 25);
            this.lblShoppingCart.TabIndex = 29;
            this.lblShoppingCart.Text = "Shopping Cart :";
            this.lblShoppingCart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxProductID
            // 
            this.tbxProductID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxProductID.Location = new System.Drawing.Point(59, 110);
            this.tbxProductID.Name = "tbxProductID";
            this.tbxProductID.Size = new System.Drawing.Size(132, 27);
            this.tbxProductID.TabIndex = 16;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(505, 8);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(95, 25);
            this.lblProduct.TabIndex = 27;
            this.lblProduct.Text = "Movies : ";
            this.lblProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(148, 336);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(114, 40);
            this.btnRemove.TabIndex = 32;
            this.btnRemove.Text = "R&emove Item";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblToalPrice
            // 
            this.lblToalPrice.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToalPrice.Location = new System.Drawing.Point(836, 465);
            this.lblToalPrice.Name = "lblToalPrice";
            this.lblToalPrice.Size = new System.Drawing.Size(208, 40);
            this.lblToalPrice.TabIndex = 31;
            this.lblToalPrice.Text = "Total: ";
            this.lblToalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.Location = new System.Drawing.Point(28, 382);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(114, 40);
            this.btnCheckOut.TabIndex = 19;
            this.btnCheckOut.Text = "&CheckOut";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnCloseShop
            // 
            this.btnCloseShop.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseShop.Location = new System.Drawing.Point(148, 382);
            this.btnCloseShop.Name = "btnCloseShop";
            this.btnCloseShop.Size = new System.Drawing.Size(114, 40);
            this.btnCloseShop.TabIndex = 33;
            this.btnCloseShop.Text = "&Close";
            this.btnCloseShop.UseVisualStyleBackColor = true;
            this.btnCloseShop.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlCart
            // 
            this.pnlCart.Controls.Add(this.btnCloseShop);
            this.pnlCart.Controls.Add(this.btnCheckOut);
            this.pnlCart.Controls.Add(this.lblToalPrice);
            this.pnlCart.Controls.Add(this.btnRemove);
            this.pnlCart.Controls.Add(this.lblProduct);
            this.pnlCart.Controls.Add(this.tbxProductID);
            this.pnlCart.Controls.Add(this.lblShoppingCart);
            this.pnlCart.Controls.Add(this.lblProdError);
            this.pnlCart.Controls.Add(this.dgvProducts);
            this.pnlCart.Controls.Add(this.lbltextID);
            this.pnlCart.Controls.Add(this.lbxOrder);
            this.pnlCart.Controls.Add(this.lblError);
            this.pnlCart.Controls.Add(this.btnAddToOrder);
            this.pnlCart.Controls.Add(this.lblAmount);
            this.pnlCart.Controls.Add(this.tbxQuantity);
            this.pnlCart.Controls.Add(this.lblLine);
            this.pnlCart.Controls.Add(this.lblOrderDetails);
            this.pnlCart.Location = new System.Drawing.Point(672, 14);
            this.pnlCart.Name = "pnlCart";
            this.pnlCart.Size = new System.Drawing.Size(1124, 519);
            this.pnlCart.TabIndex = 33;
            // 
            // frmCreateInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1665, 680);
            this.ControlBox = false;
            this.Controls.Add(this.pnlCheckout);
            this.Controls.Add(this.pnlCart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCreateInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shopping Cart";
            this.Load += new System.EventHandler(this.frmCreateInvoice_Load);
            this.pnlCheckout.ResumeLayout(false);
            this.pnlCheckout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.pnlCart.ResumeLayout(false);
            this.pnlCart.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlCheckout;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox lbxCheckOutCart;
        private System.Windows.Forms.Label lblOrderDetails;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.TextBox tbxQuantity;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Button btnAddToOrder;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.ListBox lbxOrder;
        private System.Windows.Forms.Label lbltextID;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Label lblProdError;
        private System.Windows.Forms.Label lblShoppingCart;
        private System.Windows.Forms.TextBox tbxProductID;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblToalPrice;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnCloseShop;
        private System.Windows.Forms.Panel pnlCart;
        private System.Windows.Forms.Label lblDiscountCode;
        private System.Windows.Forms.TextBox tbxDiscount;
        private System.Windows.Forms.Button btnDiscountEnter;
    }
}