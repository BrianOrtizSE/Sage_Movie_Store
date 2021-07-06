
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblBlackLine = new System.Windows.Forms.Label();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.btnDiscountEnter = new System.Windows.Forms.Button();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.lblDiscountCode = new System.Windows.Forms.Label();
            this.tbxSCode = new System.Windows.Forms.TextBox();
            this.tbxDiscount = new System.Windows.Forms.TextBox();
            this.lblSecurityCode = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblValidDate = new System.Windows.Forms.Label();
            this.lbxCheckOutCart = new System.Windows.Forms.ListBox();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.tbxCardHolderName = new System.Windows.Forms.TextBox();
            this.tbxCardNumber = new System.Windows.Forms.TextBox();
            this.rdbMasterCard = new System.Windows.Forms.RadioButton();
            this.rdbVisa = new System.Windows.Forms.RadioButton();
            this.btnPay = new System.Windows.Forms.Button();
            this.lblCardName = new System.Windows.Forms.Label();
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
            this.pnlCheckout.Controls.Add(this.label1);
            this.pnlCheckout.Controls.Add(this.lblMonth);
            this.pnlCheckout.Controls.Add(this.lblBlackLine);
            this.pnlCheckout.Controls.Add(this.lblCheckOut);
            this.pnlCheckout.Controls.Add(this.cmbYear);
            this.pnlCheckout.Controls.Add(this.btnDiscountEnter);
            this.pnlCheckout.Controls.Add(this.cmbMonth);
            this.pnlCheckout.Controls.Add(this.lblDiscountCode);
            this.pnlCheckout.Controls.Add(this.tbxSCode);
            this.pnlCheckout.Controls.Add(this.tbxDiscount);
            this.pnlCheckout.Controls.Add(this.lblSecurityCode);
            this.pnlCheckout.Controls.Add(this.btnClose);
            this.pnlCheckout.Controls.Add(this.lblValidDate);
            this.pnlCheckout.Controls.Add(this.lbxCheckOutCart);
            this.pnlCheckout.Controls.Add(this.lblCardNumber);
            this.pnlCheckout.Controls.Add(this.tbxCardHolderName);
            this.pnlCheckout.Controls.Add(this.tbxCardNumber);
            this.pnlCheckout.Controls.Add(this.rdbMasterCard);
            this.pnlCheckout.Controls.Add(this.rdbVisa);
            this.pnlCheckout.Controls.Add(this.btnPay);
            this.pnlCheckout.Controls.Add(this.lblCardName);
            this.pnlCheckout.Location = new System.Drawing.Point(21, 12);
            this.pnlCheckout.Name = "pnlCheckout";
            this.pnlCheckout.Size = new System.Drawing.Size(632, 551);
            this.pnlCheckout.TabIndex = 34;
            this.pnlCheckout.Visible = false;
            this.pnlCheckout.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCheckout_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 83;
            this.label1.Text = "Year";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.Location = new System.Drawing.Point(10, 261);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(43, 16);
            this.lblMonth.TabIndex = 82;
            this.lblMonth.Text = "Month";
            // 
            // lblBlackLine
            // 
            this.lblBlackLine.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBlackLine.Location = new System.Drawing.Point(14, 61);
            this.lblBlackLine.Name = "lblBlackLine";
            this.lblBlackLine.Size = new System.Drawing.Size(350, 2);
            this.lblBlackLine.TabIndex = 81;
            this.lblBlackLine.Text = "0";
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckOut.Location = new System.Drawing.Point(23, 38);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(74, 19);
            this.lblCheckOut.TabIndex = 80;
            this.lblCheckOut.Text = "Checkout";
            // 
            // cmbYear
            // 
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Items.AddRange(new object[] {
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031"});
            this.cmbYear.Location = new System.Drawing.Point(103, 233);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(99, 24);
            this.cmbYear.TabIndex = 41;
            // 
            // btnDiscountEnter
            // 
            this.btnDiscountEnter.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscountEnter.Location = new System.Drawing.Point(259, 395);
            this.btnDiscountEnter.Name = "btnDiscountEnter";
            this.btnDiscountEnter.Size = new System.Drawing.Size(66, 26);
            this.btnDiscountEnter.TabIndex = 4;
            this.btnDiscountEnter.Text = "Enter";
            this.btnDiscountEnter.UseVisualStyleBackColor = true;
            this.btnDiscountEnter.Click += new System.EventHandler(this.btnDiscountEnter_Click);
            // 
            // cmbMonth
            // 
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August\t",
            "September",
            "October",
            "November",
            "December"});
            this.cmbMonth.Location = new System.Drawing.Point(6, 234);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(91, 24);
            this.cmbMonth.TabIndex = 39;
            // 
            // lblDiscountCode
            // 
            this.lblDiscountCode.AutoSize = true;
            this.lblDiscountCode.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountCode.Location = new System.Drawing.Point(29, 404);
            this.lblDiscountCode.Name = "lblDiscountCode";
            this.lblDiscountCode.Size = new System.Drawing.Size(102, 16);
            this.lblDiscountCode.TabIndex = 3;
            this.lblDiscountCode.Text = "Discount Code : ";
            // 
            // tbxSCode
            // 
            this.tbxSCode.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSCode.Location = new System.Drawing.Point(225, 234);
            this.tbxSCode.MaxLength = 3;
            this.tbxSCode.Name = "tbxSCode";
            this.tbxSCode.Size = new System.Drawing.Size(85, 23);
            this.tbxSCode.TabIndex = 42;
            this.tbxSCode.TextChanged += new System.EventHandler(this.tbxSCode_TextChanged);
            this.tbxSCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxSCode_KeyUp);
            // 
            // tbxDiscount
            // 
            this.tbxDiscount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDiscount.Location = new System.Drawing.Point(144, 397);
            this.tbxDiscount.Name = "tbxDiscount";
            this.tbxDiscount.Size = new System.Drawing.Size(100, 23);
            this.tbxDiscount.TabIndex = 2;
            this.tbxDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxDiscount_KeyPress);
            // 
            // lblSecurityCode
            // 
            this.lblSecurityCode.AutoSize = true;
            this.lblSecurityCode.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecurityCode.Location = new System.Drawing.Point(223, 212);
            this.lblSecurityCode.Name = "lblSecurityCode";
            this.lblSecurityCode.Size = new System.Drawing.Size(87, 16);
            this.lblSecurityCode.TabIndex = 49;
            this.lblSecurityCode.Text = "Security Code";
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
            // lblValidDate
            // 
            this.lblValidDate.AutoSize = true;
            this.lblValidDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidDate.Location = new System.Drawing.Point(3, 212);
            this.lblValidDate.Name = "lblValidDate";
            this.lblValidDate.Size = new System.Drawing.Size(66, 16);
            this.lblValidDate.TabIndex = 48;
            this.lblValidDate.Text = "Valid Date";
            // 
            // lbxCheckOutCart
            // 
            this.lbxCheckOutCart.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxCheckOutCart.FormattingEnabled = true;
            this.lbxCheckOutCart.ItemHeight = 15;
            this.lbxCheckOutCart.Location = new System.Drawing.Point(380, 10);
            this.lbxCheckOutCart.Name = "lbxCheckOutCart";
            this.lbxCheckOutCart.Size = new System.Drawing.Size(232, 484);
            this.lbxCheckOutCart.TabIndex = 0;
            this.lbxCheckOutCart.UseTabStops = false;
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardNumber.Location = new System.Drawing.Point(203, 141);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(84, 16);
            this.lblCardNumber.TabIndex = 47;
            this.lblCardNumber.Text = "Card Number";
            // 
            // tbxCardHolderName
            // 
            this.tbxCardHolderName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCardHolderName.Location = new System.Drawing.Point(17, 157);
            this.tbxCardHolderName.MaxLength = 20;
            this.tbxCardHolderName.Name = "tbxCardHolderName";
            this.tbxCardHolderName.Size = new System.Drawing.Size(170, 23);
            this.tbxCardHolderName.TabIndex = 36;
            this.tbxCardHolderName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxCardHolderName_KeyPress);
            // 
            // tbxCardNumber
            // 
            this.tbxCardNumber.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCardNumber.Location = new System.Drawing.Point(200, 157);
            this.tbxCardNumber.MaxLength = 12;
            this.tbxCardNumber.Name = "tbxCardNumber";
            this.tbxCardNumber.Size = new System.Drawing.Size(164, 23);
            this.tbxCardNumber.TabIndex = 37;
            this.tbxCardNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxCardNumber_KeyPress);
            // 
            // rdbMasterCard
            // 
            this.rdbMasterCard.AutoSize = true;
            this.rdbMasterCard.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMasterCard.Location = new System.Drawing.Point(195, 86);
            this.rdbMasterCard.Name = "rdbMasterCard";
            this.rdbMasterCard.Size = new System.Drawing.Size(92, 20);
            this.rdbMasterCard.TabIndex = 35;
            this.rdbMasterCard.Text = "MasterCard";
            this.rdbMasterCard.UseVisualStyleBackColor = true;
            // 
            // rdbVisa
            // 
            this.rdbVisa.AutoSize = true;
            this.rdbVisa.Checked = true;
            this.rdbVisa.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbVisa.Location = new System.Drawing.Point(71, 86);
            this.rdbVisa.Name = "rdbVisa";
            this.rdbVisa.Size = new System.Drawing.Size(50, 20);
            this.rdbVisa.TabIndex = 34;
            this.rdbVisa.TabStop = true;
            this.rdbVisa.Text = "Visa";
            this.rdbVisa.UseVisualStyleBackColor = true;
            // 
            // btnPay
            // 
            this.btnPay.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(56, 458);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(101, 36);
            this.btnPay.TabIndex = 45;
            this.btnPay.Text = "&Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // lblCardName
            // 
            this.lblCardName.AutoSize = true;
            this.lblCardName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardName.Location = new System.Drawing.Point(14, 141);
            this.lblCardName.Name = "lblCardName";
            this.lblCardName.Size = new System.Drawing.Size(117, 16);
            this.lblCardName.TabIndex = 43;
            this.lblCardName.Text = "Cardholder\'s Name";
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
            this.tbxQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxQuantity_KeyPress);
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
            this.lbxOrder.TabStop = false;
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
            this.dgvProducts.TabStop = false;
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
            this.tbxProductID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxProductID_KeyPress);
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
            this.pnlCart.Location = new System.Drawing.Point(21, 35);
            this.pnlCart.Name = "pnlCart";
            this.pnlCart.Size = new System.Drawing.Size(1124, 519);
            this.pnlCart.TabIndex = 33;
            // 
            // frmCreateInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 591);
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
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.TextBox tbxSCode;
        private System.Windows.Forms.Label lblSecurityCode;
        private System.Windows.Forms.Label lblValidDate;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.TextBox tbxCardHolderName;
        private System.Windows.Forms.TextBox tbxCardNumber;
        private System.Windows.Forms.RadioButton rdbMasterCard;
        private System.Windows.Forms.RadioButton rdbVisa;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label lblCardName;
        private System.Windows.Forms.Label lblBlackLine;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMonth;
    }
}