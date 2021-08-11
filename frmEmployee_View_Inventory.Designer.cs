
namespace SU21_Final_Project
{
    partial class frmEmployee_View_Inventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployee_View_Inventory));
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tbxProductID = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnsHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.cbxSearch = new System.Windows.Forms.ComboBox();
            this.cbxGenres = new System.Windows.Forms.ComboBox();
            this.lblItemError = new System.Windows.Forms.Label();
            this.lblProductDescription = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            this.lblProductIDText = new System.Windows.Forms.Label();
            this.lblProductNameText = new System.Windows.Forms.Label();
            this.lblGenreText = new System.Windows.Forms.Label();
            this.lblQuantityText = new System.Windows.Forms.Label();
            this.lblProductPriceText = new System.Windows.Forms.Label();
            this.lblProductDescriptionText = new System.Windows.Forms.Label();
            this.pbxImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(1242, 206);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(116, 38);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(1242, 162);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(116, 38);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(1222, 45);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(149, 16);
            this.lblSearch.TabIndex = 7;
            this.lblSearch.Text = "Search For Specific Item";
            // 
            // tbxProductID
            // 
            this.tbxProductID.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxProductID.Location = new System.Drawing.Point(1200, 112);
            this.tbxProductID.MaxLength = 5;
            this.tbxProductID.Name = "tbxProductID";
            this.tbxProductID.ShortcutsEnabled = false;
            this.tbxProductID.Size = new System.Drawing.Size(195, 26);
            this.tbxProductID.TabIndex = 8;
            this.tbxProductID.TextChanged += new System.EventHandler(this.tbxProductID_TextChanged);
            this.tbxProductID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxProductID_KeyPress);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1242, 412);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(116, 38);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;
            this.dgvInventory.AllowUserToOrderColumns = true;
            this.dgvInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Location = new System.Drawing.Point(12, 14);
            this.dgvInventory.MultiSelect = false;
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.ReadOnly = true;
            this.dgvInventory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventory.Size = new System.Drawing.Size(672, 436);
            this.dgvInventory.TabIndex = 12;
            this.dgvInventory.TabStop = false;
            this.dgvInventory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventory_CellClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1422, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnsHelp
            // 
            this.mnsHelp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnsHelp.Name = "mnsHelp";
            this.mnsHelp.Size = new System.Drawing.Size(44, 20);
            this.mnsHelp.Text = "Help";
            // 
            // cbxSearch
            // 
            this.cbxSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSearch.FormattingEnabled = true;
            this.cbxSearch.Items.AddRange(new object[] {
            "Product ID",
            "Product Name",
            "Genre"});
            this.cbxSearch.Location = new System.Drawing.Point(1242, 80);
            this.cbxSearch.Name = "cbxSearch";
            this.cbxSearch.Size = new System.Drawing.Size(116, 21);
            this.cbxSearch.TabIndex = 14;
            this.cbxSearch.SelectedIndexChanged += new System.EventHandler(this.cbxSearch_SelectedIndexChanged);
            // 
            // cbxGenres
            // 
            this.cbxGenres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGenres.Enabled = false;
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
            "Realistic Fiction"});
            this.cbxGenres.Location = new System.Drawing.Point(1225, 115);
            this.cbxGenres.Name = "cbxGenres";
            this.cbxGenres.Size = new System.Drawing.Size(146, 21);
            this.cbxGenres.TabIndex = 15;
            this.cbxGenres.Visible = false;
            this.cbxGenres.SelectedIndexChanged += new System.EventHandler(this.cbxGenres_SelectedIndexChanged);
            // 
            // lblItemError
            // 
            this.lblItemError.AutoSize = true;
            this.lblItemError.ForeColor = System.Drawing.Color.Red;
            this.lblItemError.Location = new System.Drawing.Point(1126, 119);
            this.lblItemError.Name = "lblItemError";
            this.lblItemError.Size = new System.Drawing.Size(14, 13);
            this.lblItemError.TabIndex = 16;
            this.lblItemError.Text = "X";
            // 
            // lblProductDescription
            // 
            this.lblProductDescription.BackColor = System.Drawing.SystemColors.Control;
            this.lblProductDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProductDescription.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductDescription.Location = new System.Drawing.Point(716, 319);
            this.lblProductDescription.Name = "lblProductDescription";
            this.lblProductDescription.Size = new System.Drawing.Size(460, 131);
            this.lblProductDescription.TabIndex = 23;
            this.lblProductDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.BackColor = System.Drawing.SystemColors.Control;
            this.lblProductPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProductPrice.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductPrice.Location = new System.Drawing.Point(719, 260);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(199, 28);
            this.lblProductPrice.TabIndex = 24;
            this.lblProductPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuantity
            // 
            this.lblQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.lblQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblQuantity.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(719, 206);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(199, 28);
            this.lblQuantity.TabIndex = 25;
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGenre
            // 
            this.lblGenre.BackColor = System.Drawing.SystemColors.Control;
            this.lblGenre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGenre.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.Location = new System.Drawing.Point(719, 157);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(199, 28);
            this.lblGenre.TabIndex = 26;
            this.lblGenre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductName
            // 
            this.lblProductName.BackColor = System.Drawing.SystemColors.Control;
            this.lblProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProductName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(719, 103);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(199, 28);
            this.lblProductName.TabIndex = 27;
            this.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductID
            // 
            this.lblProductID.BackColor = System.Drawing.SystemColors.Control;
            this.lblProductID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProductID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductID.Location = new System.Drawing.Point(719, 51);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(199, 28);
            this.lblProductID.TabIndex = 28;
            this.lblProductID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductIDText
            // 
            this.lblProductIDText.AutoSize = true;
            this.lblProductIDText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductIDText.Location = new System.Drawing.Point(781, 30);
            this.lblProductIDText.Name = "lblProductIDText";
            this.lblProductIDText.Size = new System.Drawing.Size(67, 16);
            this.lblProductIDText.TabIndex = 29;
            this.lblProductIDText.Text = "Product ID";
            // 
            // lblProductNameText
            // 
            this.lblProductNameText.AutoSize = true;
            this.lblProductNameText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductNameText.Location = new System.Drawing.Point(773, 84);
            this.lblProductNameText.Name = "lblProductNameText";
            this.lblProductNameText.Size = new System.Drawing.Size(88, 16);
            this.lblProductNameText.TabIndex = 30;
            this.lblProductNameText.Text = "Product Name";
            // 
            // lblGenreText
            // 
            this.lblGenreText.AutoSize = true;
            this.lblGenreText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenreText.Location = new System.Drawing.Point(792, 138);
            this.lblGenreText.Name = "lblGenreText";
            this.lblGenreText.Size = new System.Drawing.Size(42, 16);
            this.lblGenreText.TabIndex = 31;
            this.lblGenreText.Text = "Genre";
            // 
            // lblQuantityText
            // 
            this.lblQuantityText.AutoSize = true;
            this.lblQuantityText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantityText.Location = new System.Drawing.Point(787, 187);
            this.lblQuantityText.Name = "lblQuantityText";
            this.lblQuantityText.Size = new System.Drawing.Size(55, 16);
            this.lblQuantityText.TabIndex = 32;
            this.lblQuantityText.Text = "Quantity";
            // 
            // lblProductPriceText
            // 
            this.lblProductPriceText.AutoSize = true;
            this.lblProductPriceText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductPriceText.Location = new System.Drawing.Point(775, 241);
            this.lblProductPriceText.Name = "lblProductPriceText";
            this.lblProductPriceText.Size = new System.Drawing.Size(83, 16);
            this.lblProductPriceText.TabIndex = 33;
            this.lblProductPriceText.Text = "Product Price";
            // 
            // lblProductDescriptionText
            // 
            this.lblProductDescriptionText.AutoSize = true;
            this.lblProductDescriptionText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductDescriptionText.Location = new System.Drawing.Point(800, 297);
            this.lblProductDescriptionText.Name = "lblProductDescriptionText";
            this.lblProductDescriptionText.Size = new System.Drawing.Size(118, 16);
            this.lblProductDescriptionText.TabIndex = 34;
            this.lblProductDescriptionText.Text = "Product Description";
            this.lblProductDescriptionText.Click += new System.EventHandler(this.lblProductDescriptionText_Click);
            // 
            // pbxImage
            // 
            this.pbxImage.Image = global::SU21_Final_Project.Properties.Resources.Logo_SMS;
            this.pbxImage.Location = new System.Drawing.Point(934, 30);
            this.pbxImage.Name = "pbxImage";
            this.pbxImage.Size = new System.Drawing.Size(242, 261);
            this.pbxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImage.TabIndex = 99;
            this.pbxImage.TabStop = false;
            // 
            // frmEmployee_View_Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 472);
            this.Controls.Add(this.pbxImage);
            this.Controls.Add(this.lblProductDescriptionText);
            this.Controls.Add(this.lblProductPriceText);
            this.Controls.Add(this.lblQuantityText);
            this.Controls.Add(this.lblGenreText);
            this.Controls.Add(this.lblProductNameText);
            this.Controls.Add(this.lblProductIDText);
            this.Controls.Add(this.lblProductID);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblProductPrice);
            this.Controls.Add(this.lblProductDescription);
            this.Controls.Add(this.lblItemError);
            this.Controls.Add(this.cbxGenres);
            this.Controls.Add(this.cbxSearch);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.tbxProductID);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEmployee_View_Inventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Inventory View";
            this.Load += new System.EventHandler(this.frmEmployee_Inventory_View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox tbxProductID;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnsHelp;
        private System.Windows.Forms.ComboBox cbxSearch;
        private System.Windows.Forms.ComboBox cbxGenres;
        private System.Windows.Forms.Label lblItemError;
        private System.Windows.Forms.Label lblProductDescription;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Label lblProductIDText;
        private System.Windows.Forms.Label lblProductNameText;
        private System.Windows.Forms.Label lblGenreText;
        private System.Windows.Forms.Label lblQuantityText;
        private System.Windows.Forms.Label lblProductPriceText;
        private System.Windows.Forms.Label lblProductDescriptionText;
        private System.Windows.Forms.PictureBox pbxImage;
    }
}