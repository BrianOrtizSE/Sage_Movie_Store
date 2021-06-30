
namespace SU21_Final_Project
{
    partial class frmMerchandiseAdd
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.tbxQuantity = new System.Windows.Forms.TextBox();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.tbxGenre = new System.Windows.Forms.TextBox();
            this.tbxProductID = new System.Windows.Forms.TextBox();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.lblPriceText = new System.Windows.Forms.Label();
            this.lblInStockText = new System.Windows.Forms.Label();
            this.lblProductNametxt = new System.Windows.Forms.Label();
            this.lblQuantityText = new System.Windows.Forms.Label();
            this.lblGenreText = new System.Windows.Forms.Label();
            this.lblProductIDText = new System.Windows.Forms.Label();
            this.cbxInStock = new System.Windows.Forms.CheckBox();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.lblDesriptionText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(211, 592);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(101, 37);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "C&lose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(371, 550);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 37);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(264, 550);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 37);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(157, 550);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(101, 37);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Location = new System.Drawing.Point(50, 550);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(101, 37);
            this.btnAddNew.TabIndex = 10;
            this.btnAddNew.Text = "&Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // tbxPrice
            // 
            this.tbxPrice.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPrice.Location = new System.Drawing.Point(138, 300);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.ReadOnly = true;
            this.tbxPrice.Size = new System.Drawing.Size(246, 27);
            this.tbxPrice.TabIndex = 4;
            // 
            // tbxQuantity
            // 
            this.tbxQuantity.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxQuantity.Location = new System.Drawing.Point(138, 238);
            this.tbxQuantity.Name = "tbxQuantity";
            this.tbxQuantity.ReadOnly = true;
            this.tbxQuantity.Size = new System.Drawing.Size(246, 27);
            this.tbxQuantity.TabIndex = 3;
            // 
            // tbxProductName
            // 
            this.tbxProductName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxProductName.Location = new System.Drawing.Point(138, 109);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.ReadOnly = true;
            this.tbxProductName.Size = new System.Drawing.Size(246, 27);
            this.tbxProductName.TabIndex = 1;
            // 
            // tbxGenre
            // 
            this.tbxGenre.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxGenre.Location = new System.Drawing.Point(138, 176);
            this.tbxGenre.Name = "tbxGenre";
            this.tbxGenre.ReadOnly = true;
            this.tbxGenre.Size = new System.Drawing.Size(246, 27);
            this.tbxGenre.TabIndex = 2;
            // 
            // tbxProductID
            // 
            this.tbxProductID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxProductID.Location = new System.Drawing.Point(138, 48);
            this.tbxProductID.Name = "tbxProductID";
            this.tbxProductID.ReadOnly = true;
            this.tbxProductID.Size = new System.Drawing.Size(246, 27);
            this.tbxProductID.TabIndex = 0;
            // 
            // btnLast
            // 
            this.btnLast.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.Location = new System.Drawing.Point(371, 509);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(101, 37);
            this.btnLast.TabIndex = 9;
            this.btnLast.Text = "Last";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.Location = new System.Drawing.Point(264, 509);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(101, 37);
            this.btnFirst.TabIndex = 8;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(157, 509);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(101, 37);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(50, 509);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(101, 37);
            this.btnPrevious.TabIndex = 6;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // lblPriceText
            // 
            this.lblPriceText.AutoSize = true;
            this.lblPriceText.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceText.Location = new System.Drawing.Point(239, 276);
            this.lblPriceText.Name = "lblPriceText";
            this.lblPriceText.Size = new System.Drawing.Size(48, 19);
            this.lblPriceText.TabIndex = 19;
            this.lblPriceText.Text = "Price ";
            this.lblPriceText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInStockText
            // 
            this.lblInStockText.AutoSize = true;
            this.lblInStockText.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInStockText.Location = new System.Drawing.Point(216, 473);
            this.lblInStockText.Name = "lblInStockText";
            this.lblInStockText.Size = new System.Drawing.Size(67, 19);
            this.lblInStockText.TabIndex = 21;
            this.lblInStockText.Text = "In Stock";
            this.lblInStockText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductNametxt
            // 
            this.lblProductNametxt.AutoSize = true;
            this.lblProductNametxt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductNametxt.Location = new System.Drawing.Point(203, 83);
            this.lblProductNametxt.Name = "lblProductNametxt";
            this.lblProductNametxt.Size = new System.Drawing.Size(114, 19);
            this.lblProductNametxt.TabIndex = 16;
            this.lblProductNametxt.Text = "Product Name ";
            this.lblProductNametxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuantityText
            // 
            this.lblQuantityText.AutoSize = true;
            this.lblQuantityText.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantityText.Location = new System.Drawing.Point(223, 216);
            this.lblQuantityText.Name = "lblQuantityText";
            this.lblQuantityText.Size = new System.Drawing.Size(74, 19);
            this.lblQuantityText.TabIndex = 18;
            this.lblQuantityText.Text = "Quantity ";
            this.lblQuantityText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGenreText
            // 
            this.lblGenreText.AutoSize = true;
            this.lblGenreText.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenreText.Location = new System.Drawing.Point(230, 152);
            this.lblGenreText.Name = "lblGenreText";
            this.lblGenreText.Size = new System.Drawing.Size(51, 19);
            this.lblGenreText.TabIndex = 17;
            this.lblGenreText.Text = "Genre";
            this.lblGenreText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductIDText
            // 
            this.lblProductIDText.AutoSize = true;
            this.lblProductIDText.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductIDText.Location = new System.Drawing.Point(212, 21);
            this.lblProductIDText.Name = "lblProductIDText";
            this.lblProductIDText.Size = new System.Drawing.Size(85, 19);
            this.lblProductIDText.TabIndex = 15;
            this.lblProductIDText.Text = "Product ID";
            this.lblProductIDText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxInStock
            // 
            this.cbxInStock.AutoSize = true;
            this.cbxInStock.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxInStock.Location = new System.Drawing.Point(289, 478);
            this.cbxInStock.Name = "cbxInStock";
            this.cbxInStock.Size = new System.Drawing.Size(15, 14);
            this.cbxInStock.TabIndex = 22;
            this.cbxInStock.UseVisualStyleBackColor = true;
            // 
            // tbxDescription
            // 
            this.tbxDescription.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDescription.Location = new System.Drawing.Point(67, 363);
            this.tbxDescription.Multiline = true;
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.ReadOnly = true;
            this.tbxDescription.Size = new System.Drawing.Size(384, 107);
            this.tbxDescription.TabIndex = 5;
            // 
            // lblDesriptionText
            // 
            this.lblDesriptionText.AutoSize = true;
            this.lblDesriptionText.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesriptionText.Location = new System.Drawing.Point(186, 337);
            this.lblDesriptionText.Name = "lblDesriptionText";
            this.lblDesriptionText.Size = new System.Drawing.Size(143, 19);
            this.lblDesriptionText.TabIndex = 20;
            this.lblDesriptionText.Text = "Product Descrption";
            this.lblDesriptionText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMerchandiseAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 644);
            this.Controls.Add(this.tbxDescription);
            this.Controls.Add(this.lblDesriptionText);
            this.Controls.Add(this.cbxInStock);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.tbxPrice);
            this.Controls.Add(this.tbxQuantity);
            this.Controls.Add(this.tbxProductName);
            this.Controls.Add(this.tbxGenre);
            this.Controls.Add(this.tbxProductID);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.lblPriceText);
            this.Controls.Add(this.lblInStockText);
            this.Controls.Add(this.lblProductNametxt);
            this.Controls.Add(this.lblQuantityText);
            this.Controls.Add(this.lblGenreText);
            this.Controls.Add(this.lblProductIDText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmMerchandiseAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddMerchandise";
            this.Load += new System.EventHandler(this.frmMerchandiseAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.TextBox tbxQuantity;
        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.TextBox tbxGenre;
        private System.Windows.Forms.TextBox tbxProductID;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label lblPriceText;
        private System.Windows.Forms.Label lblInStockText;
        private System.Windows.Forms.Label lblProductNametxt;
        private System.Windows.Forms.Label lblQuantityText;
        private System.Windows.Forms.Label lblGenreText;
        private System.Windows.Forms.Label lblProductIDText;
        private System.Windows.Forms.CheckBox cbxInStock;
        private System.Windows.Forms.TextBox tbxDescription;
        private System.Windows.Forms.Label lblDesriptionText;
    }
}