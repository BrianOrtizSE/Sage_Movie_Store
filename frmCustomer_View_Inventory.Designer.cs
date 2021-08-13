
namespace SU21_Final_Project
{
    partial class frmCustomer_View_Inventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomer_View_Inventory));
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
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxImage
            // 
            this.pbxImage.Image = global::SU21_Final_Project.Properties.Resources.Logo_SMS;
            this.pbxImage.Location = new System.Drawing.Point(870, 34);
            this.pbxImage.Name = "pbxImage";
            this.pbxImage.Size = new System.Drawing.Size(242, 261);
            this.pbxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImage.TabIndex = 98;
            this.pbxImage.TabStop = false;
            // 
            // lblProductDescriptionText
            // 
            this.lblProductDescriptionText.AutoSize = true;
            this.lblProductDescriptionText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductDescriptionText.Location = new System.Drawing.Point(674, 295);
            this.lblProductDescriptionText.Name = "lblProductDescriptionText";
            this.lblProductDescriptionText.Size = new System.Drawing.Size(118, 16);
            this.lblProductDescriptionText.TabIndex = 97;
            this.lblProductDescriptionText.Text = "Product Description";
            // 
            // lblProductPriceText
            // 
            this.lblProductPriceText.AutoSize = true;
            this.lblProductPriceText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductPriceText.Location = new System.Drawing.Point(687, 193);
            this.lblProductPriceText.Name = "lblProductPriceText";
            this.lblProductPriceText.Size = new System.Drawing.Size(83, 16);
            this.lblProductPriceText.TabIndex = 96;
            this.lblProductPriceText.Text = "Product Price";
            // 
            // lblQuantityText
            // 
            this.lblQuantityText.AutoSize = true;
            this.lblQuantityText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantityText.Location = new System.Drawing.Point(699, 248);
            this.lblQuantityText.Name = "lblQuantityText";
            this.lblQuantityText.Size = new System.Drawing.Size(55, 16);
            this.lblQuantityText.TabIndex = 95;
            this.lblQuantityText.Text = "Quantity";
            // 
            // lblGenreText
            // 
            this.lblGenreText.AutoSize = true;
            this.lblGenreText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenreText.Location = new System.Drawing.Point(704, 136);
            this.lblGenreText.Name = "lblGenreText";
            this.lblGenreText.Size = new System.Drawing.Size(42, 16);
            this.lblGenreText.TabIndex = 94;
            this.lblGenreText.Text = "Genre";
            // 
            // lblProductNameText
            // 
            this.lblProductNameText.AutoSize = true;
            this.lblProductNameText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductNameText.Location = new System.Drawing.Point(685, 82);
            this.lblProductNameText.Name = "lblProductNameText";
            this.lblProductNameText.Size = new System.Drawing.Size(88, 16);
            this.lblProductNameText.TabIndex = 93;
            this.lblProductNameText.Text = "Product Name";
            // 
            // lblProductIDText
            // 
            this.lblProductIDText.AutoSize = true;
            this.lblProductIDText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductIDText.Location = new System.Drawing.Point(687, 33);
            this.lblProductIDText.Name = "lblProductIDText";
            this.lblProductIDText.Size = new System.Drawing.Size(67, 16);
            this.lblProductIDText.TabIndex = 92;
            this.lblProductIDText.Text = "Product ID";
            // 
            // lblProductID
            // 
            this.lblProductID.BackColor = System.Drawing.SystemColors.Control;
            this.lblProductID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProductID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductID.Location = new System.Drawing.Point(631, 49);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(199, 28);
            this.lblProductID.TabIndex = 91;
            this.lblProductID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductName
            // 
            this.lblProductName.BackColor = System.Drawing.SystemColors.Control;
            this.lblProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProductName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(631, 101);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(199, 28);
            this.lblProductName.TabIndex = 90;
            this.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGenre
            // 
            this.lblGenre.BackColor = System.Drawing.SystemColors.Control;
            this.lblGenre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGenre.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.Location = new System.Drawing.Point(631, 155);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(199, 28);
            this.lblGenre.TabIndex = 89;
            this.lblGenre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuantity
            // 
            this.lblQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.lblQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblQuantity.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(631, 267);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(199, 28);
            this.lblQuantity.TabIndex = 88;
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.BackColor = System.Drawing.SystemColors.Control;
            this.lblProductPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProductPrice.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductPrice.Location = new System.Drawing.Point(631, 212);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(199, 28);
            this.lblProductPrice.TabIndex = 87;
            this.lblProductPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductDescription
            // 
            this.lblProductDescription.BackColor = System.Drawing.SystemColors.Control;
            this.lblProductDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProductDescription.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductDescription.Location = new System.Drawing.Point(631, 311);
            this.lblProductDescription.Name = "lblProductDescription";
            this.lblProductDescription.Size = new System.Drawing.Size(481, 131);
            this.lblProductDescription.TabIndex = 86;
            this.lblProductDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvProducts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProducts.Location = new System.Drawing.Point(17, 34);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(594, 405);
            this.dgvProducts.TabIndex = 85;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            this.dgvProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellContentClick);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1128, 204);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(101, 36);
            this.btnClose.TabIndex = 85;
            this.btnClose.Text = "&Return";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmCustomer_View_Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 472);
            this.Controls.Add(this.btnClose);
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
            this.Controls.Add(this.dgvProducts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCustomer_View_Inventory";
            this.Text = "Product View";
            this.Load += new System.EventHandler(this.frmProductView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btnClose;
    }
}