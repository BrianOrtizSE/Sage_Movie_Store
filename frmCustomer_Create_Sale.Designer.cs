
namespace SU21_Final_Project
{
    partial class frmPos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPos));
            this.lbxCheckOutCart = new System.Windows.Forms.ListBox();
            this.cbxDisplayCart = new System.Windows.Forms.CheckBox();
            this.tbxCardHolderName = new System.Windows.Forms.TextBox();
            this.tbxCardNumber = new System.Windows.Forms.TextBox();
            this.rdbMasterCard = new System.Windows.Forms.RadioButton();
            this.rdbVisa = new System.Windows.Forms.RadioButton();
            this.btnPay = new System.Windows.Forms.Button();
            this.lblCardName = new System.Windows.Forms.Label();
            this.pnlCart = new System.Windows.Forms.Panel();
            this.pnlShoppingCart = new System.Windows.Forms.Panel();
            this.lblShoppingCart = new System.Windows.Forms.Label();
            this.lbxOrder = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblToalPrice = new System.Windows.Forms.Label();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.lblQuantityToAdd = new System.Windows.Forms.Label();
            this.tbxQuantity = new System.Windows.Forms.TextBox();
            this.pbxImage = new System.Windows.Forms.PictureBox();
            this.lblProductDescriptionText = new System.Windows.Forms.Label();
            this.lblProductPriceText = new System.Windows.Forms.Label();
            this.lblQuantityText = new System.Windows.Forms.Label();
            this.lblGenreText = new System.Windows.Forms.Label();
            this.lblProductNameText = new System.Windows.Forms.Label();
            this.lblProductIDText = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.lblProductDescription = new System.Windows.Forms.Label();
            this.btnCloseShop = new System.Windows.Forms.Button();
            this.lblProduct = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.btnAddToOrder = new System.Windows.Forms.Button();
            this.mnsHelp = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.pnlCheckout = new System.Windows.Forms.Panel();
            this.lblSCValid = new System.Windows.Forms.Label();
            this.lblCardNumberValid = new System.Windows.Forms.Label();
            this.lblCardHolderValid = new System.Windows.Forms.Label();
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
            this.pnlCart.SuspendLayout();
            this.pnlShoppingCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.mnsHelp.SuspendLayout();
            this.pnlCheckout.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxCheckOutCart
            // 
            this.lbxCheckOutCart.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxCheckOutCart.FormattingEnabled = true;
            this.lbxCheckOutCart.ItemHeight = 15;
            this.lbxCheckOutCart.Location = new System.Drawing.Point(408, 15);
            this.lbxCheckOutCart.Name = "lbxCheckOutCart";
            this.lbxCheckOutCart.Size = new System.Drawing.Size(232, 484);
            this.lbxCheckOutCart.TabIndex = 14;
            this.lbxCheckOutCart.UseTabStops = false;
            // 
            // cbxDisplayCart
            // 
            this.cbxDisplayCart.AutoSize = true;
            this.cbxDisplayCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDisplayCart.Location = new System.Drawing.Point(1109, 544);
            this.cbxDisplayCart.Name = "cbxDisplayCart";
            this.cbxDisplayCart.Size = new System.Drawing.Size(100, 20);
            this.cbxDisplayCart.TabIndex = 1;
            this.cbxDisplayCart.Text = "Display Cart";
            this.cbxDisplayCart.UseVisualStyleBackColor = true;
            this.cbxDisplayCart.CheckedChanged += new System.EventHandler(this.cbxDisplayCart_CheckedChanged);
            // 
            // tbxCardHolderName
            // 
            this.tbxCardHolderName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCardHolderName.Location = new System.Drawing.Point(6, 157);
            this.tbxCardHolderName.MaxLength = 20;
            this.tbxCardHolderName.Name = "tbxCardHolderName";
            this.tbxCardHolderName.ShortcutsEnabled = false;
            this.tbxCardHolderName.Size = new System.Drawing.Size(170, 23);
            this.tbxCardHolderName.TabIndex = 3;
            this.tbxCardHolderName.TextChanged += new System.EventHandler(this.tbxCardHolderName_TextChanged);
            this.tbxCardHolderName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxCardHolderName_KeyPress);
            // 
            // tbxCardNumber
            // 
            this.tbxCardNumber.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCardNumber.Location = new System.Drawing.Point(217, 157);
            this.tbxCardNumber.MaxLength = 12;
            this.tbxCardNumber.Name = "tbxCardNumber";
            this.tbxCardNumber.ShortcutsEnabled = false;
            this.tbxCardNumber.Size = new System.Drawing.Size(164, 23);
            this.tbxCardNumber.TabIndex = 4;
            this.tbxCardNumber.TextChanged += new System.EventHandler(this.tbxCardNumber_TextChanged);
            this.tbxCardNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxCardNumber_KeyPress);
            // 
            // rdbMasterCard
            // 
            this.rdbMasterCard.AutoSize = true;
            this.rdbMasterCard.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMasterCard.Location = new System.Drawing.Point(195, 86);
            this.rdbMasterCard.Name = "rdbMasterCard";
            this.rdbMasterCard.Size = new System.Drawing.Size(92, 20);
            this.rdbMasterCard.TabIndex = 2;
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
            this.rdbVisa.TabIndex = 1;
            this.rdbVisa.TabStop = true;
            this.rdbVisa.Text = "Visa";
            this.rdbVisa.UseVisualStyleBackColor = true;
            // 
            // btnPay
            // 
            this.btnPay.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(32, 458);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(101, 36);
            this.btnPay.TabIndex = 10;
            this.btnPay.Text = "&Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // lblCardName
            // 
            this.lblCardName.AutoSize = true;
            this.lblCardName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardName.Location = new System.Drawing.Point(9, 141);
            this.lblCardName.Name = "lblCardName";
            this.lblCardName.Size = new System.Drawing.Size(117, 16);
            this.lblCardName.TabIndex = 15;
            this.lblCardName.Text = "Cardholder\'s Name";
            // 
            // pnlCart
            // 
            this.pnlCart.Controls.Add(this.pnlShoppingCart);
            this.pnlCart.Controls.Add(this.lblQuantityToAdd);
            this.pnlCart.Controls.Add(this.tbxQuantity);
            this.pnlCart.Controls.Add(this.pbxImage);
            this.pnlCart.Controls.Add(this.lblProductDescriptionText);
            this.pnlCart.Controls.Add(this.lblProductPriceText);
            this.pnlCart.Controls.Add(this.lblQuantityText);
            this.pnlCart.Controls.Add(this.lblGenreText);
            this.pnlCart.Controls.Add(this.lblProductNameText);
            this.pnlCart.Controls.Add(this.lblProductIDText);
            this.pnlCart.Controls.Add(this.lblProductID);
            this.pnlCart.Controls.Add(this.lblProductName);
            this.pnlCart.Controls.Add(this.lblGenre);
            this.pnlCart.Controls.Add(this.lblQuantity);
            this.pnlCart.Controls.Add(this.lblProductPrice);
            this.pnlCart.Controls.Add(this.lblProductDescription);
            this.pnlCart.Controls.Add(this.btnCloseShop);
            this.pnlCart.Controls.Add(this.lblProduct);
            this.pnlCart.Controls.Add(this.dgvProducts);
            this.pnlCart.Controls.Add(this.btnAddToOrder);
            this.pnlCart.Location = new System.Drawing.Point(12, 40);
            this.pnlCart.Name = "pnlCart";
            this.pnlCart.Size = new System.Drawing.Size(1282, 498);
            this.pnlCart.TabIndex = 0;
            // 
            // pnlShoppingCart
            // 
            this.pnlShoppingCart.Controls.Add(this.lblShoppingCart);
            this.pnlShoppingCart.Controls.Add(this.lbxOrder);
            this.pnlShoppingCart.Controls.Add(this.btnRemove);
            this.pnlShoppingCart.Controls.Add(this.btnClear);
            this.pnlShoppingCart.Controls.Add(this.lblToalPrice);
            this.pnlShoppingCart.Controls.Add(this.btnCheckOut);
            this.pnlShoppingCart.Location = new System.Drawing.Point(686, 0);
            this.pnlShoppingCart.Name = "pnlShoppingCart";
            this.pnlShoppingCart.Size = new System.Drawing.Size(511, 498);
            this.pnlShoppingCart.TabIndex = 2;
            // 
            // lblShoppingCart
            // 
            this.lblShoppingCart.AutoSize = true;
            this.lblShoppingCart.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShoppingCart.Location = new System.Drawing.Point(155, 13);
            this.lblShoppingCart.Name = "lblShoppingCart";
            this.lblShoppingCart.Size = new System.Drawing.Size(160, 25);
            this.lblShoppingCart.TabIndex = 5;
            this.lblShoppingCart.Text = "Shopping Cart :";
            this.lblShoppingCart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbxOrder
            // 
            this.lbxOrder.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxOrder.FormattingEnabled = true;
            this.lbxOrder.HorizontalScrollbar = true;
            this.lbxOrder.ItemHeight = 16;
            this.lbxOrder.Location = new System.Drawing.Point(36, 41);
            this.lbxOrder.Name = "lbxOrder";
            this.lbxOrder.Size = new System.Drawing.Size(428, 388);
            this.lbxOrder.TabIndex = 1;
            this.lbxOrder.TabStop = false;
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(36, 435);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(114, 28);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "R&emove Item From Cart";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(36, 466);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(114, 28);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear Cart";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblToalPrice
            // 
            this.lblToalPrice.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToalPrice.Location = new System.Drawing.Point(156, 443);
            this.lblToalPrice.Name = "lblToalPrice";
            this.lblToalPrice.Size = new System.Drawing.Size(221, 40);
            this.lblToalPrice.TabIndex = 0;
            this.lblToalPrice.Text = "Sub Total: ";
            this.lblToalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.Location = new System.Drawing.Point(379, 441);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(114, 40);
            this.btnCheckOut.TabIndex = 4;
            this.btnCheckOut.Text = "&CheckOut";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // lblQuantityToAdd
            // 
            this.lblQuantityToAdd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantityToAdd.Location = new System.Drawing.Point(715, 440);
            this.lblQuantityToAdd.Name = "lblQuantityToAdd";
            this.lblQuantityToAdd.Size = new System.Drawing.Size(103, 45);
            this.lblQuantityToAdd.TabIndex = 16;
            this.lblQuantityToAdd.Text = "Quantity To Add To Cart : ";
            this.lblQuantityToAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxQuantity
            // 
            this.tbxQuantity.Location = new System.Drawing.Point(822, 451);
            this.tbxQuantity.Name = "tbxQuantity";
            this.tbxQuantity.ShortcutsEnabled = false;
            this.tbxQuantity.Size = new System.Drawing.Size(114, 20);
            this.tbxQuantity.TabIndex = 1;
            this.tbxQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxQuantity_KeyPress);
            // 
            // pbxImage
            // 
            this.pbxImage.Image = global::SU21_Final_Project.Properties.Resources.Logo_SMS;
            this.pbxImage.Location = new System.Drawing.Point(942, 26);
            this.pbxImage.Name = "pbxImage";
            this.pbxImage.Size = new System.Drawing.Size(242, 261);
            this.pbxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImage.TabIndex = 84;
            this.pbxImage.TabStop = false;
            // 
            // lblProductDescriptionText
            // 
            this.lblProductDescriptionText.AutoSize = true;
            this.lblProductDescriptionText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductDescriptionText.Location = new System.Drawing.Point(746, 287);
            this.lblProductDescriptionText.Name = "lblProductDescriptionText";
            this.lblProductDescriptionText.Size = new System.Drawing.Size(118, 16);
            this.lblProductDescriptionText.TabIndex = 14;
            this.lblProductDescriptionText.Text = "Product Description";
            // 
            // lblProductPriceText
            // 
            this.lblProductPriceText.AutoSize = true;
            this.lblProductPriceText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductPriceText.Location = new System.Drawing.Point(759, 185);
            this.lblProductPriceText.Name = "lblProductPriceText";
            this.lblProductPriceText.Size = new System.Drawing.Size(83, 16);
            this.lblProductPriceText.TabIndex = 10;
            this.lblProductPriceText.Text = "Product Price";
            // 
            // lblQuantityText
            // 
            this.lblQuantityText.AutoSize = true;
            this.lblQuantityText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantityText.Location = new System.Drawing.Point(771, 240);
            this.lblQuantityText.Name = "lblQuantityText";
            this.lblQuantityText.Size = new System.Drawing.Size(55, 16);
            this.lblQuantityText.TabIndex = 12;
            this.lblQuantityText.Text = "Quantity";
            // 
            // lblGenreText
            // 
            this.lblGenreText.AutoSize = true;
            this.lblGenreText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenreText.Location = new System.Drawing.Point(776, 128);
            this.lblGenreText.Name = "lblGenreText";
            this.lblGenreText.Size = new System.Drawing.Size(42, 16);
            this.lblGenreText.TabIndex = 8;
            this.lblGenreText.Text = "Genre";
            // 
            // lblProductNameText
            // 
            this.lblProductNameText.AutoSize = true;
            this.lblProductNameText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductNameText.Location = new System.Drawing.Point(757, 74);
            this.lblProductNameText.Name = "lblProductNameText";
            this.lblProductNameText.Size = new System.Drawing.Size(88, 16);
            this.lblProductNameText.TabIndex = 6;
            this.lblProductNameText.Text = "Product Name";
            // 
            // lblProductIDText
            // 
            this.lblProductIDText.AutoSize = true;
            this.lblProductIDText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductIDText.Location = new System.Drawing.Point(759, 25);
            this.lblProductIDText.Name = "lblProductIDText";
            this.lblProductIDText.Size = new System.Drawing.Size(67, 16);
            this.lblProductIDText.TabIndex = 4;
            this.lblProductIDText.Text = "Product ID";
            // 
            // lblProductID
            // 
            this.lblProductID.BackColor = System.Drawing.SystemColors.Control;
            this.lblProductID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProductID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductID.Location = new System.Drawing.Point(703, 41);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(199, 28);
            this.lblProductID.TabIndex = 5;
            this.lblProductID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductName
            // 
            this.lblProductName.BackColor = System.Drawing.SystemColors.Control;
            this.lblProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProductName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(703, 93);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(199, 28);
            this.lblProductName.TabIndex = 7;
            this.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGenre
            // 
            this.lblGenre.BackColor = System.Drawing.SystemColors.Control;
            this.lblGenre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGenre.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.Location = new System.Drawing.Point(703, 147);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(199, 28);
            this.lblGenre.TabIndex = 9;
            this.lblGenre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuantity
            // 
            this.lblQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.lblQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblQuantity.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(703, 259);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(199, 28);
            this.lblQuantity.TabIndex = 13;
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.BackColor = System.Drawing.SystemColors.Control;
            this.lblProductPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProductPrice.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductPrice.Location = new System.Drawing.Point(703, 204);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(199, 28);
            this.lblProductPrice.TabIndex = 11;
            this.lblProductPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductDescription
            // 
            this.lblProductDescription.BackColor = System.Drawing.SystemColors.Control;
            this.lblProductDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProductDescription.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductDescription.Location = new System.Drawing.Point(703, 303);
            this.lblProductDescription.Name = "lblProductDescription";
            this.lblProductDescription.Size = new System.Drawing.Size(481, 131);
            this.lblProductDescription.TabIndex = 15;
            this.lblProductDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCloseShop
            // 
            this.btnCloseShop.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseShop.Location = new System.Drawing.Point(14, 441);
            this.btnCloseShop.Name = "btnCloseShop";
            this.btnCloseShop.Size = new System.Drawing.Size(114, 40);
            this.btnCloseShop.TabIndex = 17;
            this.btnCloseShop.Text = "&Close";
            this.btnCloseShop.UseVisualStyleBackColor = true;
            this.btnCloseShop.Click += new System.EventHandler(this.btnCloseShop_Click);
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(483, -22);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(95, 25);
            this.lblProduct.TabIndex = 27;
            this.lblProduct.Text = "Movies : ";
            this.lblProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvProducts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProducts.Location = new System.Drawing.Point(14, 29);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(594, 405);
            this.dgvProducts.TabIndex = 3;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToOrder.Location = new System.Drawing.Point(942, 440);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(114, 40);
            this.btnAddToOrder.TabIndex = 2;
            this.btnAddToOrder.Text = "&Add Movie To Cart";
            this.btnAddToOrder.UseVisualStyleBackColor = true;
            this.btnAddToOrder.Click += new System.EventHandler(this.btnAddToOrder_Click);
            // 
            // mnsHelp
            // 
            this.mnsHelp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.mnsHelp.Location = new System.Drawing.Point(0, 0);
            this.mnsHelp.Name = "mnsHelp";
            this.mnsHelp.Size = new System.Drawing.Size(1310, 24);
            this.mnsHelp.TabIndex = 3;
            this.mnsHelp.Text = "menuStrip1";
            this.mnsHelp.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnsHelp_ItemClicked);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardNumber.Location = new System.Drawing.Point(220, 141);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(84, 16);
            this.lblCardNumber.TabIndex = 16;
            this.lblCardNumber.Text = "Card Number";
            // 
            // pnlCheckout
            // 
            this.pnlCheckout.Controls.Add(this.lblSCValid);
            this.pnlCheckout.Controls.Add(this.lblCardNumberValid);
            this.pnlCheckout.Controls.Add(this.lblCardHolderValid);
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
            this.pnlCheckout.Location = new System.Drawing.Point(12, 28);
            this.pnlCheckout.Name = "pnlCheckout";
            this.pnlCheckout.Size = new System.Drawing.Size(653, 526);
            this.pnlCheckout.TabIndex = 4;
            this.pnlCheckout.Visible = false;
            // 
            // lblSCValid
            // 
            this.lblSCValid.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSCValid.ForeColor = System.Drawing.Color.Red;
            this.lblSCValid.Location = new System.Drawing.Point(308, 236);
            this.lblSCValid.Name = "lblSCValid";
            this.lblSCValid.Size = new System.Drawing.Size(20, 21);
            this.lblSCValid.TabIndex = 23;
            this.lblSCValid.Text = "X";
            // 
            // lblCardNumberValid
            // 
            this.lblCardNumberValid.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardNumberValid.ForeColor = System.Drawing.Color.Red;
            this.lblCardNumberValid.Location = new System.Drawing.Point(387, 157);
            this.lblCardNumberValid.Name = "lblCardNumberValid";
            this.lblCardNumberValid.Size = new System.Drawing.Size(20, 21);
            this.lblCardNumberValid.TabIndex = 18;
            this.lblCardNumberValid.Text = "X";
            // 
            // lblCardHolderValid
            // 
            this.lblCardHolderValid.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardHolderValid.ForeColor = System.Drawing.Color.Red;
            this.lblCardHolderValid.Location = new System.Drawing.Point(182, 157);
            this.lblCardHolderValid.Name = "lblCardHolderValid";
            this.lblCardHolderValid.Size = new System.Drawing.Size(20, 21);
            this.lblCardHolderValid.TabIndex = 17;
            this.lblCardHolderValid.Text = "X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Year";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.Location = new System.Drawing.Point(10, 261);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(43, 16);
            this.lblMonth.TabIndex = 21;
            this.lblMonth.Text = "Month";
            // 
            // lblBlackLine
            // 
            this.lblBlackLine.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBlackLine.Location = new System.Drawing.Point(14, 61);
            this.lblBlackLine.Name = "lblBlackLine";
            this.lblBlackLine.Size = new System.Drawing.Size(350, 2);
            this.lblBlackLine.TabIndex = 13;
            this.lblBlackLine.Text = "0";
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckOut.Location = new System.Drawing.Point(23, 38);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(74, 19);
            this.lblCheckOut.TabIndex = 12;
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
            this.cmbYear.TabIndex = 6;
            // 
            // btnDiscountEnter
            // 
            this.btnDiscountEnter.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscountEnter.Location = new System.Drawing.Point(259, 400);
            this.btnDiscountEnter.Name = "btnDiscountEnter";
            this.btnDiscountEnter.Size = new System.Drawing.Size(66, 26);
            this.btnDiscountEnter.TabIndex = 9;
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
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cmbMonth.Location = new System.Drawing.Point(6, 234);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(91, 24);
            this.cmbMonth.TabIndex = 5;
            // 
            // lblDiscountCode
            // 
            this.lblDiscountCode.AutoSize = true;
            this.lblDiscountCode.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountCode.Location = new System.Drawing.Point(29, 404);
            this.lblDiscountCode.Name = "lblDiscountCode";
            this.lblDiscountCode.Size = new System.Drawing.Size(102, 16);
            this.lblDiscountCode.TabIndex = 0;
            this.lblDiscountCode.Text = "Discount Code : ";
            // 
            // tbxSCode
            // 
            this.tbxSCode.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSCode.Location = new System.Drawing.Point(217, 234);
            this.tbxSCode.MaxLength = 3;
            this.tbxSCode.Name = "tbxSCode";
            this.tbxSCode.ShortcutsEnabled = false;
            this.tbxSCode.Size = new System.Drawing.Size(85, 23);
            this.tbxSCode.TabIndex = 7;
            this.tbxSCode.TextChanged += new System.EventHandler(this.tbxSCode_TextChanged);
            this.tbxSCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxSCode_KeyPress);
            // 
            // tbxDiscount
            // 
            this.tbxDiscount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDiscount.Location = new System.Drawing.Point(133, 401);
            this.tbxDiscount.Name = "tbxDiscount";
            this.tbxDiscount.ShortcutsEnabled = false;
            this.tbxDiscount.Size = new System.Drawing.Size(120, 23);
            this.tbxDiscount.TabIndex = 8;
            this.tbxDiscount.TextChanged += new System.EventHandler(this.tbxDiscount_TextChanged);
            this.tbxDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxDiscount_KeyPress);
            // 
            // lblSecurityCode
            // 
            this.lblSecurityCode.AutoSize = true;
            this.lblSecurityCode.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecurityCode.Location = new System.Drawing.Point(215, 212);
            this.lblSecurityCode.Name = "lblSecurityCode";
            this.lblSecurityCode.Size = new System.Drawing.Size(87, 16);
            this.lblSecurityCode.TabIndex = 20;
            this.lblSecurityCode.Text = "Security Code";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(139, 457);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(101, 36);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "&Return To Cart";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblValidDate
            // 
            this.lblValidDate.AutoSize = true;
            this.lblValidDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidDate.Location = new System.Drawing.Point(3, 212);
            this.lblValidDate.Name = "lblValidDate";
            this.lblValidDate.Size = new System.Drawing.Size(66, 16);
            this.lblValidDate.TabIndex = 19;
            this.lblValidDate.Text = "Valid Date";
            // 
            // frmPos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 571);
            this.Controls.Add(this.cbxDisplayCart);
            this.Controls.Add(this.pnlCart);
            this.Controls.Add(this.mnsHelp);
            this.Controls.Add(this.pnlCheckout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Point Of Sales";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlCart.ResumeLayout(false);
            this.pnlCart.PerformLayout();
            this.pnlShoppingCart.ResumeLayout(false);
            this.pnlShoppingCart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.mnsHelp.ResumeLayout(false);
            this.mnsHelp.PerformLayout();
            this.pnlCheckout.ResumeLayout(false);
            this.pnlCheckout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxCheckOutCart;
        private System.Windows.Forms.CheckBox cbxDisplayCart;
        private System.Windows.Forms.TextBox tbxCardHolderName;
        private System.Windows.Forms.TextBox tbxCardNumber;
        private System.Windows.Forms.RadioButton rdbMasterCard;
        private System.Windows.Forms.RadioButton rdbVisa;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label lblCardName;
        private System.Windows.Forms.Panel pnlCart;
        private System.Windows.Forms.Label lblQuantityToAdd;
        private System.Windows.Forms.TextBox tbxQuantity;
        private System.Windows.Forms.PictureBox pbxImage;
        private System.Windows.Forms.Label lblProductDescriptionText;
        private System.Windows.Forms.Label lblProductPriceText;
        private System.Windows.Forms.Label lblQuantityText;
        private System.Windows.Forms.Label lblGenreText;
        private System.Windows.Forms.Label lblProductNameText;
        private System.Windows.Forms.Label lblProductIDText;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Label lblProductDescription;
        private System.Windows.Forms.Button btnCloseShop;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btnAddToOrder;
        private System.Windows.Forms.Panel pnlShoppingCart;
        private System.Windows.Forms.Label lblShoppingCart;
        private System.Windows.Forms.ListBox lbxOrder;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblToalPrice;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.MenuStrip mnsHelp;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.Panel pnlCheckout;
        private System.Windows.Forms.Label lblSCValid;
        private System.Windows.Forms.Label lblCardNumberValid;
        private System.Windows.Forms.Label lblCardHolderValid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblBlackLine;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Button btnDiscountEnter;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Label lblDiscountCode;
        private System.Windows.Forms.TextBox tbxSCode;
        private System.Windows.Forms.TextBox tbxDiscount;
        private System.Windows.Forms.Label lblSecurityCode;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblValidDate;
    }
}