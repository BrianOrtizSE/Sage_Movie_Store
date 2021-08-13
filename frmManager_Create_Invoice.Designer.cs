
namespace SU21_Final_Project
{
    partial class frmManager_Create_Invoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManager_Create_Invoice));
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.lblPriceValid = new System.Windows.Forms.Label();
            this.lblQuantityValid = new System.Windows.Forms.Label();
            this.lblSourceValid = new System.Windows.Forms.Label();
            this.tbxProductOrderPrice = new System.Windows.Forms.TextBox();
            this.lblProductOrderPrice = new System.Windows.Forms.Label();
            this.cbxSource = new System.Windows.Forms.ComboBox();
            this.tbxQuantityToOrder = new System.Windows.Forms.TextBox();
            this.lblQuanittyToOrder = new System.Windows.Forms.Label();
            this.lblSource = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            this.tbxProductID = new System.Windows.Forms.TextBox();
            this.btnCreateInvoice = new System.Windows.Forms.Button();
            this.lblProductValid = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnPayInvoice = new System.Windows.Forms.Button();
            this.dgvInvoice = new System.Windows.Forms.DataGridView();
            this.cbxShowInvoice = new System.Windows.Forms.CheckBox();
            this.cbxCompleted = new System.Windows.Forms.CheckBox();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToDeleteRows = false;
            this.dgvProduct.AllowUserToOrderColumns = true;
            this.dgvProduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvProduct.BackgroundColor = System.Drawing.Color.White;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(448, 21);
            this.dgvProduct.MultiSelect = false;
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(552, 408);
            this.dgvProduct.TabIndex = 57;
            // 
            // lblPriceValid
            // 
            this.lblPriceValid.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceValid.ForeColor = System.Drawing.Color.Red;
            this.lblPriceValid.Location = new System.Drawing.Point(204, 285);
            this.lblPriceValid.Name = "lblPriceValid";
            this.lblPriceValid.Size = new System.Drawing.Size(20, 21);
            this.lblPriceValid.TabIndex = 108;
            this.lblPriceValid.Text = "X";
            // 
            // lblQuantityValid
            // 
            this.lblQuantityValid.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantityValid.ForeColor = System.Drawing.Color.Red;
            this.lblQuantityValid.Location = new System.Drawing.Point(204, 207);
            this.lblQuantityValid.Name = "lblQuantityValid";
            this.lblQuantityValid.Size = new System.Drawing.Size(20, 21);
            this.lblQuantityValid.TabIndex = 107;
            this.lblQuantityValid.Text = "X";
            // 
            // lblSourceValid
            // 
            this.lblSourceValid.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSourceValid.ForeColor = System.Drawing.Color.Red;
            this.lblSourceValid.Location = new System.Drawing.Point(204, 125);
            this.lblSourceValid.Name = "lblSourceValid";
            this.lblSourceValid.Size = new System.Drawing.Size(20, 21);
            this.lblSourceValid.TabIndex = 106;
            this.lblSourceValid.Text = "X";
            // 
            // tbxProductOrderPrice
            // 
            this.tbxProductOrderPrice.BackColor = System.Drawing.SystemColors.Window;
            this.tbxProductOrderPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxProductOrderPrice.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxProductOrderPrice.Location = new System.Drawing.Point(12, 283);
            this.tbxProductOrderPrice.MaxLength = 12;
            this.tbxProductOrderPrice.Name = "tbxProductOrderPrice";
            this.tbxProductOrderPrice.ShortcutsEnabled = false;
            this.tbxProductOrderPrice.Size = new System.Drawing.Size(185, 23);
            this.tbxProductOrderPrice.TabIndex = 105;
            this.tbxProductOrderPrice.TextChanged += new System.EventHandler(this.tbxProductOrderPrice_TextChanged);
            this.tbxProductOrderPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxProductOrderPrice_KeyPress);
            // 
            // lblProductOrderPrice
            // 
            this.lblProductOrderPrice.AutoSize = true;
            this.lblProductOrderPrice.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductOrderPrice.Location = new System.Drawing.Point(10, 264);
            this.lblProductOrderPrice.Name = "lblProductOrderPrice";
            this.lblProductOrderPrice.Size = new System.Drawing.Size(86, 16);
            this.lblProductOrderPrice.TabIndex = 104;
            this.lblProductOrderPrice.Text = "Order Price : ";
            // 
            // cbxSource
            // 
            this.cbxSource.BackColor = System.Drawing.SystemColors.Menu;
            this.cbxSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSource.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSource.FormattingEnabled = true;
            this.cbxSource.Items.AddRange(new object[] {
            "Henry Movie Producer",
            "Wonder Bros Movies",
            "James Gun Co.",
            "Gary Page Book Corp",
            "David Clue Co."});
            this.cbxSource.Location = new System.Drawing.Point(12, 122);
            this.cbxSource.Name = "cbxSource";
            this.cbxSource.Size = new System.Drawing.Size(185, 24);
            this.cbxSource.TabIndex = 103;
            this.cbxSource.SelectedIndexChanged += new System.EventHandler(this.cbxSource_SelectedIndexChanged);
            // 
            // tbxQuantityToOrder
            // 
            this.tbxQuantityToOrder.BackColor = System.Drawing.SystemColors.Window;
            this.tbxQuantityToOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxQuantityToOrder.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxQuantityToOrder.Location = new System.Drawing.Point(12, 205);
            this.tbxQuantityToOrder.MaxLength = 12;
            this.tbxQuantityToOrder.Name = "tbxQuantityToOrder";
            this.tbxQuantityToOrder.ShortcutsEnabled = false;
            this.tbxQuantityToOrder.Size = new System.Drawing.Size(185, 23);
            this.tbxQuantityToOrder.TabIndex = 99;
            this.tbxQuantityToOrder.TextChanged += new System.EventHandler(this.tbxQuantityToOrder_TextChanged);
            this.tbxQuantityToOrder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxQuantityToOrder_KeyPress);
            // 
            // lblQuanittyToOrder
            // 
            this.lblQuanittyToOrder.AutoSize = true;
            this.lblQuanittyToOrder.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuanittyToOrder.Location = new System.Drawing.Point(9, 186);
            this.lblQuanittyToOrder.Name = "lblQuanittyToOrder";
            this.lblQuanittyToOrder.Size = new System.Drawing.Size(116, 16);
            this.lblQuanittyToOrder.TabIndex = 98;
            this.lblQuanittyToOrder.Text = "Quantity To Order:";
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSource.Location = new System.Drawing.Point(10, 103);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(121, 16);
            this.lblSource.TabIndex = 97;
            this.lblSource.Text = "Source Of Product: ";
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductID.Location = new System.Drawing.Point(9, 21);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(76, 16);
            this.lblProductID.TabIndex = 95;
            this.lblProductID.Text = "Product ID :";
            // 
            // tbxProductID
            // 
            this.tbxProductID.BackColor = System.Drawing.SystemColors.Window;
            this.tbxProductID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxProductID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxProductID.Location = new System.Drawing.Point(12, 40);
            this.tbxProductID.MaxLength = 12;
            this.tbxProductID.Name = "tbxProductID";
            this.tbxProductID.ShortcutsEnabled = false;
            this.tbxProductID.Size = new System.Drawing.Size(185, 23);
            this.tbxProductID.TabIndex = 109;
            this.tbxProductID.TextChanged += new System.EventHandler(this.tbxProductID_TextChanged);
            this.tbxProductID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxProductID_KeyPress);
            // 
            // btnCreateInvoice
            // 
            this.btnCreateInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateInvoice.Location = new System.Drawing.Point(12, 390);
            this.btnCreateInvoice.Name = "btnCreateInvoice";
            this.btnCreateInvoice.Size = new System.Drawing.Size(113, 39);
            this.btnCreateInvoice.TabIndex = 110;
            this.btnCreateInvoice.Text = "Create Invoice";
            this.btnCreateInvoice.UseVisualStyleBackColor = true;
            this.btnCreateInvoice.Click += new System.EventHandler(this.btnCreateInvoice_Click);
            // 
            // lblProductValid
            // 
            this.lblProductValid.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductValid.ForeColor = System.Drawing.Color.Red;
            this.lblProductValid.Location = new System.Drawing.Point(204, 42);
            this.lblProductValid.Name = "lblProductValid";
            this.lblProductValid.Size = new System.Drawing.Size(20, 21);
            this.lblProductValid.TabIndex = 111;
            this.lblProductValid.Text = "X";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSubTotal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(255, 115);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(162, 46);
            this.lblSubTotal.TabIndex = 112;
            this.lblSubTotal.Text = "SubTotal : 0.0";
            this.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTax
            // 
            this.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTax.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(255, 161);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(162, 46);
            this.lblTax.TabIndex = 113;
            this.lblTax.Text = "Tax : 0.0";
            this.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(255, 207);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(162, 46);
            this.lblTotal.TabIndex = 114;
            this.lblTotal.Text = "Total : 0.0";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnPayInvoice
            // 
            this.btnPayInvoice.Enabled = false;
            this.btnPayInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayInvoice.Location = new System.Drawing.Point(131, 390);
            this.btnPayInvoice.Name = "btnPayInvoice";
            this.btnPayInvoice.Size = new System.Drawing.Size(113, 39);
            this.btnPayInvoice.TabIndex = 115;
            this.btnPayInvoice.Text = "Pay Invoice";
            this.btnPayInvoice.UseVisualStyleBackColor = true;
            this.btnPayInvoice.Click += new System.EventHandler(this.btnPayInvoice_Click);
            // 
            // dgvInvoice
            // 
            this.dgvInvoice.AllowUserToAddRows = false;
            this.dgvInvoice.AllowUserToDeleteRows = false;
            this.dgvInvoice.AllowUserToOrderColumns = true;
            this.dgvInvoice.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvInvoice.BackgroundColor = System.Drawing.Color.White;
            this.dgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoice.Location = new System.Drawing.Point(448, 12);
            this.dgvInvoice.MultiSelect = false;
            this.dgvInvoice.Name = "dgvInvoice";
            this.dgvInvoice.ReadOnly = true;
            this.dgvInvoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvoice.Size = new System.Drawing.Size(552, 417);
            this.dgvInvoice.TabIndex = 116;
            this.dgvInvoice.Visible = false;
            this.dgvInvoice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoice_CellClick);
            // 
            // cbxShowInvoice
            // 
            this.cbxShowInvoice.AutoSize = true;
            this.cbxShowInvoice.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxShowInvoice.Location = new System.Drawing.Point(317, 367);
            this.cbxShowInvoice.Name = "cbxShowInvoice";
            this.cbxShowInvoice.Size = new System.Drawing.Size(128, 17);
            this.cbxShowInvoice.TabIndex = 117;
            this.cbxShowInvoice.Text = "Show Unpaid Invoice";
            this.cbxShowInvoice.UseVisualStyleBackColor = true;
            this.cbxShowInvoice.CheckedChanged += new System.EventHandler(this.cbxShowInvoice_CheckedChanged);
            // 
            // cbxCompleted
            // 
            this.cbxCompleted.AutoSize = true;
            this.cbxCompleted.Enabled = false;
            this.cbxCompleted.Location = new System.Drawing.Point(13, 332);
            this.cbxCompleted.Name = "cbxCompleted";
            this.cbxCompleted.Size = new System.Drawing.Size(62, 17);
            this.cbxCompleted.TabIndex = 118;
            this.cbxCompleted.Text = "Payed?";
            this.cbxCompleted.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Enabled = false;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(353, 390);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(92, 39);
            this.btnExit.TabIndex = 119;
            this.btnExit.Text = "Return";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmManager_Create_Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 446);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cbxCompleted);
            this.Controls.Add(this.cbxShowInvoice);
            this.Controls.Add(this.dgvInvoice);
            this.Controls.Add(this.btnPayInvoice);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.lblProductValid);
            this.Controls.Add(this.btnCreateInvoice);
            this.Controls.Add(this.tbxProductID);
            this.Controls.Add(this.lblPriceValid);
            this.Controls.Add(this.lblQuantityValid);
            this.Controls.Add(this.lblSourceValid);
            this.Controls.Add(this.tbxProductOrderPrice);
            this.Controls.Add(this.lblProductOrderPrice);
            this.Controls.Add(this.cbxSource);
            this.Controls.Add(this.tbxQuantityToOrder);
            this.Controls.Add(this.lblQuanittyToOrder);
            this.Controls.Add(this.lblSource);
            this.Controls.Add(this.lblProductID);
            this.Controls.Add(this.dgvProduct);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmManager_Create_Invoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Invoice Creation";
            this.Load += new System.EventHandler(this.frmManager_Create_Invoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Label lblPriceValid;
        private System.Windows.Forms.Label lblQuantityValid;
        private System.Windows.Forms.Label lblSourceValid;
        private System.Windows.Forms.TextBox tbxProductOrderPrice;
        private System.Windows.Forms.Label lblProductOrderPrice;
        private System.Windows.Forms.ComboBox cbxSource;
        private System.Windows.Forms.TextBox tbxQuantityToOrder;
        private System.Windows.Forms.Label lblQuanittyToOrder;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.TextBox tbxProductID;
        private System.Windows.Forms.Button btnCreateInvoice;
        private System.Windows.Forms.Label lblProductValid;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnPayInvoice;
        private System.Windows.Forms.DataGridView dgvInvoice;
        private System.Windows.Forms.CheckBox cbxShowInvoice;
        private System.Windows.Forms.CheckBox cbxCompleted;
        private System.Windows.Forms.Button btnExit;
    }
}