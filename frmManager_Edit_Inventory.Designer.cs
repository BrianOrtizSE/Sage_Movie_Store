
namespace SU21_Final_Project
{
    partial class frmManager_Edit_Inventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManager_Edit_Inventory));
            this.tbxProductDescription = new System.Windows.Forms.TextBox();
            this.lblHireDate = new System.Windows.Forms.Label();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCompleteEdit = new System.Windows.Forms.Button();
            this.btnEditMerchandise = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbxInStock = new System.Windows.Forms.CheckBox();
            this.tbxQuantity = new System.Windows.Forms.TextBox();
            this.lblQuanitty = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            this.tbxProductID = new System.Windows.Forms.TextBox();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.pbxImage = new System.Windows.Forms.PictureBox();
            this.btnSaveImage = new System.Windows.Forms.Button();
            this.btnUploadImage = new System.Windows.Forms.Button();
            this.btnCreateInvoice = new System.Windows.Forms.Button();
            this.tbxProductPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnComplete = new System.Windows.Forms.Button();
            this.cbxGenres = new System.Windows.Forms.ComboBox();
            this.lblProductNameValid = new System.Windows.Forms.Label();
            this.lblGenreValid = new System.Windows.Forms.Label();
            this.lblQuantityValid = new System.Windows.Forms.Label();
            this.lblPriceValid = new System.Windows.Forms.Label();
            this.lblProductDescriptionValid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxProductDescription
            // 
            this.tbxProductDescription.BackColor = System.Drawing.SystemColors.Window;
            this.tbxProductDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxProductDescription.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxProductDescription.Location = new System.Drawing.Point(15, 387);
            this.tbxProductDescription.MaxLength = 250;
            this.tbxProductDescription.Multiline = true;
            this.tbxProductDescription.Name = "tbxProductDescription";
            this.tbxProductDescription.ReadOnly = true;
            this.tbxProductDescription.Size = new System.Drawing.Size(461, 141);
            this.tbxProductDescription.TabIndex = 75;
            this.tbxProductDescription.TextChanged += new System.EventHandler(this.tbxProductDescription_TextChanged);
            this.tbxProductDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxProductDescription_KeyPress);
            // 
            // lblHireDate
            // 
            this.lblHireDate.AutoSize = true;
            this.lblHireDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHireDate.Location = new System.Drawing.Point(13, 368);
            this.lblHireDate.Name = "lblHireDate";
            this.lblHireDate.Size = new System.Drawing.Size(131, 16);
            this.lblHireDate.TabIndex = 74;
            this.lblHireDate.Text = "Product Description : ";
            // 
            // tbxProductName
            // 
            this.tbxProductName.BackColor = System.Drawing.SystemColors.Window;
            this.tbxProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxProductName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxProductName.Location = new System.Drawing.Point(15, 107);
            this.tbxProductName.MaxLength = 50;
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.ReadOnly = true;
            this.tbxProductName.ShortcutsEnabled = false;
            this.tbxProductName.Size = new System.Drawing.Size(186, 23);
            this.tbxProductName.TabIndex = 72;
            this.tbxProductName.TextChanged += new System.EventHandler(this.tbxProductName_TextChanged);
            this.tbxProductName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxProductName_KeyPress);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(454, 610);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 50);
            this.btnReturn.TabIndex = 71;
            this.btnReturn.Text = "&Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(210, 610);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 50);
            this.btnCancel.TabIndex = 70;
            this.btnCancel.Text = "&Cancel Edit/Add";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCompleteEdit
            // 
            this.btnCompleteEdit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompleteEdit.Location = new System.Drawing.Point(90, 615);
            this.btnCompleteEdit.Name = "btnCompleteEdit";
            this.btnCompleteEdit.Size = new System.Drawing.Size(75, 50);
            this.btnCompleteEdit.TabIndex = 69;
            this.btnCompleteEdit.Text = "C&omplete Edit";
            this.btnCompleteEdit.UseVisualStyleBackColor = true;
            this.btnCompleteEdit.Click += new System.EventHandler(this.btnCompleteEdit_Click);
            // 
            // btnEditMerchandise
            // 
            this.btnEditMerchandise.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditMerchandise.Location = new System.Drawing.Point(91, 559);
            this.btnEditMerchandise.Name = "btnEditMerchandise";
            this.btnEditMerchandise.Size = new System.Drawing.Size(74, 50);
            this.btnEditMerchandise.TabIndex = 68;
            this.btnEditMerchandise.Text = "&Edit Merchandise";
            this.btnEditMerchandise.UseVisualStyleBackColor = true;
            this.btnEditMerchandise.Click += new System.EventHandler(this.btnEditEmployee_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(10, 559);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(74, 50);
            this.btnAdd.TabIndex = 65;
            this.btnAdd.Text = "&Add Merchandise";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbxInStock
            // 
            this.cbxInStock.AutoSize = true;
            this.cbxInStock.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxInStock.Location = new System.Drawing.Point(15, 284);
            this.cbxInStock.Name = "cbxInStock";
            this.cbxInStock.Size = new System.Drawing.Size(79, 20);
            this.cbxInStock.TabIndex = 64;
            this.cbxInStock.Text = "In Stock?";
            this.cbxInStock.UseVisualStyleBackColor = true;
            // 
            // tbxQuantity
            // 
            this.tbxQuantity.BackColor = System.Drawing.SystemColors.Window;
            this.tbxQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxQuantity.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxQuantity.Location = new System.Drawing.Point(15, 255);
            this.tbxQuantity.MaxLength = 12;
            this.tbxQuantity.Name = "tbxQuantity";
            this.tbxQuantity.ReadOnly = true;
            this.tbxQuantity.Size = new System.Drawing.Size(185, 23);
            this.tbxQuantity.TabIndex = 63;
            this.tbxQuantity.TextChanged += new System.EventHandler(this.tbxQuantity_TextChanged);
            this.tbxQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxQuantity_KeyPress);
            // 
            // lblQuanitty
            // 
            this.lblQuanitty.AutoSize = true;
            this.lblQuanitty.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuanitty.Location = new System.Drawing.Point(13, 236);
            this.lblQuanitty.Name = "lblQuanitty";
            this.lblQuanitty.Size = new System.Drawing.Size(64, 16);
            this.lblQuanitty.TabIndex = 62;
            this.lblQuanitty.Text = "Quantity :";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.Location = new System.Drawing.Point(13, 167);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(55, 16);
            this.lblGenre.TabIndex = 61;
            this.lblGenre.Text = "Genre : ";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(18, 89);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(97, 16);
            this.lblProductName.TabIndex = 60;
            this.lblProductName.Text = "Product Name :";
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductID.Location = new System.Drawing.Point(12, 12);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(76, 16);
            this.lblProductID.TabIndex = 58;
            this.lblProductID.Text = "Product ID :";
            // 
            // tbxProductID
            // 
            this.tbxProductID.BackColor = System.Drawing.Color.LightGray;
            this.tbxProductID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxProductID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxProductID.Location = new System.Drawing.Point(15, 31);
            this.tbxProductID.MaxLength = 9;
            this.tbxProductID.Name = "tbxProductID";
            this.tbxProductID.ReadOnly = true;
            this.tbxProductID.ShortcutsEnabled = false;
            this.tbxProductID.Size = new System.Drawing.Size(186, 23);
            this.tbxProductID.TabIndex = 57;
            this.tbxProductID.TextChanged += new System.EventHandler(this.tbxProductID_TextChanged);
            this.tbxProductID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxProductID_KeyPress);
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;
            this.dgvInventory.AllowUserToOrderColumns = true;
            this.dgvInventory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvInventory.BackgroundColor = System.Drawing.Color.White;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Location = new System.Drawing.Point(535, 12);
            this.dgvInventory.MultiSelect = false;
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.ReadOnly = true;
            this.dgvInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventory.Size = new System.Drawing.Size(519, 648);
            this.dgvInventory.TabIndex = 56;
            this.dgvInventory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventory_CellClick);
            // 
            // pbxImage
            // 
            this.pbxImage.Image = global::SU21_Final_Project.Properties.Resources.Logo_SMS;
            this.pbxImage.Location = new System.Drawing.Point(264, 31);
            this.pbxImage.Name = "pbxImage";
            this.pbxImage.Size = new System.Drawing.Size(212, 273);
            this.pbxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImage.TabIndex = 83;
            this.pbxImage.TabStop = false;
            this.pbxImage.LoadProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.pbxImage_LoadProgressChanged);
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.Enabled = false;
            this.btnSaveImage.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveImage.Location = new System.Drawing.Point(264, 310);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(85, 44);
            this.btnSaveImage.TabIndex = 85;
            this.btnSaveImage.Text = "Save &Image";
            this.btnSaveImage.UseVisualStyleBackColor = true;
            this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImage.Location = new System.Drawing.Point(391, 310);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(85, 44);
            this.btnUploadImage.TabIndex = 86;
            this.btnUploadImage.Text = "&Upload Image";
            this.btnUploadImage.UseVisualStyleBackColor = true;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // btnCreateInvoice
            // 
            this.btnCreateInvoice.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateInvoice.Location = new System.Drawing.Point(291, 559);
            this.btnCreateInvoice.Name = "btnCreateInvoice";
            this.btnCreateInvoice.Size = new System.Drawing.Size(75, 50);
            this.btnCreateInvoice.TabIndex = 87;
            this.btnCreateInvoice.Text = "Create &Order";
            this.btnCreateInvoice.UseVisualStyleBackColor = true;
            this.btnCreateInvoice.Click += new System.EventHandler(this.btnCreateInvoice_Click);
            // 
            // tbxProductPrice
            // 
            this.tbxProductPrice.BackColor = System.Drawing.SystemColors.Window;
            this.tbxProductPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxProductPrice.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxProductPrice.Location = new System.Drawing.Point(15, 331);
            this.tbxProductPrice.MaxLength = 12;
            this.tbxProductPrice.Name = "tbxProductPrice";
            this.tbxProductPrice.ReadOnly = true;
            this.tbxProductPrice.Size = new System.Drawing.Size(185, 23);
            this.tbxProductPrice.TabIndex = 89;
            this.tbxProductPrice.TextChanged += new System.EventHandler(this.tbxProductPrice_TextChanged);
            this.tbxProductPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxProductPrice_KeyPress);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(13, 312);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(96, 16);
            this.lblPrice.TabIndex = 88;
            this.lblPrice.Text = "Product Price : ";
            // 
            // btnComplete
            // 
            this.btnComplete.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComplete.Location = new System.Drawing.Point(10, 615);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(74, 50);
            this.btnComplete.TabIndex = 90;
            this.btnComplete.Text = "&Complete";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // cbxGenres
            // 
            this.cbxGenres.BackColor = System.Drawing.SystemColors.Menu;
            this.cbxGenres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGenres.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGenres.FormattingEnabled = true;
            this.cbxGenres.Items.AddRange(new object[] {
            "Action",
            "Comedy",
            "Comedy Action",
            "Adventure Comedy",
            "Thriller",
            "Horror",
            "Fantasy",
            "Romance",
            "Based On True Events",
            "Realistic Fiction",
            "True Story",
            "Rom-Com"});
            this.cbxGenres.Location = new System.Drawing.Point(15, 186);
            this.cbxGenres.Name = "cbxGenres";
            this.cbxGenres.Size = new System.Drawing.Size(185, 24);
            this.cbxGenres.TabIndex = 82;
            this.cbxGenres.SelectedIndexChanged += new System.EventHandler(this.cbxGenres_SelectedIndexChanged);
            this.cbxGenres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxGenres_KeyPress);
            // 
            // lblProductNameValid
            // 
            this.lblProductNameValid.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductNameValid.ForeColor = System.Drawing.Color.Red;
            this.lblProductNameValid.Location = new System.Drawing.Point(207, 107);
            this.lblProductNameValid.Name = "lblProductNameValid";
            this.lblProductNameValid.Size = new System.Drawing.Size(20, 21);
            this.lblProductNameValid.TabIndex = 66;
            this.lblProductNameValid.Text = "X";
            // 
            // lblGenreValid
            // 
            this.lblGenreValid.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenreValid.ForeColor = System.Drawing.Color.Red;
            this.lblGenreValid.Location = new System.Drawing.Point(207, 189);
            this.lblGenreValid.Name = "lblGenreValid";
            this.lblGenreValid.Size = new System.Drawing.Size(20, 21);
            this.lblGenreValid.TabIndex = 91;
            this.lblGenreValid.Text = "X";
            // 
            // lblQuantityValid
            // 
            this.lblQuantityValid.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantityValid.ForeColor = System.Drawing.Color.Red;
            this.lblQuantityValid.Location = new System.Drawing.Point(207, 257);
            this.lblQuantityValid.Name = "lblQuantityValid";
            this.lblQuantityValid.Size = new System.Drawing.Size(20, 21);
            this.lblQuantityValid.TabIndex = 92;
            this.lblQuantityValid.Text = "X";
            // 
            // lblPriceValid
            // 
            this.lblPriceValid.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceValid.ForeColor = System.Drawing.Color.Red;
            this.lblPriceValid.Location = new System.Drawing.Point(207, 333);
            this.lblPriceValid.Name = "lblPriceValid";
            this.lblPriceValid.Size = new System.Drawing.Size(20, 21);
            this.lblPriceValid.TabIndex = 93;
            this.lblPriceValid.Text = "X";
            // 
            // lblProductDescriptionValid
            // 
            this.lblProductDescriptionValid.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductDescriptionValid.ForeColor = System.Drawing.Color.Red;
            this.lblProductDescriptionValid.Location = new System.Drawing.Point(482, 449);
            this.lblProductDescriptionValid.Name = "lblProductDescriptionValid";
            this.lblProductDescriptionValid.Size = new System.Drawing.Size(20, 21);
            this.lblProductDescriptionValid.TabIndex = 94;
            this.lblProductDescriptionValid.Text = "X";
            // 
            // frmManager_Edit_Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 672);
            this.Controls.Add(this.lblProductDescriptionValid);
            this.Controls.Add(this.lblPriceValid);
            this.Controls.Add(this.lblQuantityValid);
            this.Controls.Add(this.lblGenreValid);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.tbxProductPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.btnCreateInvoice);
            this.Controls.Add(this.btnUploadImage);
            this.Controls.Add(this.btnSaveImage);
            this.Controls.Add(this.pbxImage);
            this.Controls.Add(this.cbxGenres);
            this.Controls.Add(this.tbxProductDescription);
            this.Controls.Add(this.lblHireDate);
            this.Controls.Add(this.tbxProductName);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCompleteEdit);
            this.Controls.Add(this.btnEditMerchandise);
            this.Controls.Add(this.lblProductNameValid);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbxInStock);
            this.Controls.Add(this.tbxQuantity);
            this.Controls.Add(this.lblQuanitty);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblProductID);
            this.Controls.Add(this.tbxProductID);
            this.Controls.Add(this.dgvInventory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmManager_Edit_Inventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Merchandise";
            this.Load += new System.EventHandler(this.frmMerchandiseAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbxProductDescription;
        private System.Windows.Forms.Label lblHireDate;
        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCompleteEdit;
        private System.Windows.Forms.Button btnEditMerchandise;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckBox cbxInStock;
        private System.Windows.Forms.TextBox tbxQuantity;
        private System.Windows.Forms.Label lblQuanitty;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.TextBox tbxProductID;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.PictureBox pbxImage;
        private System.Windows.Forms.Button btnSaveImage;
        private System.Windows.Forms.Button btnUploadImage;
        private System.Windows.Forms.Button btnCreateInvoice;
        private System.Windows.Forms.TextBox tbxProductPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.ComboBox cbxGenres;
        private System.Windows.Forms.Label lblProductNameValid;
        private System.Windows.Forms.Label lblGenreValid;
        private System.Windows.Forms.Label lblQuantityValid;
        private System.Windows.Forms.Label lblPriceValid;
        private System.Windows.Forms.Label lblProductDescriptionValid;
    }
}