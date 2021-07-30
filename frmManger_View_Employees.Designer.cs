
namespace SU21_Final_Project
{
    partial class frmManger_View_Employees
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.btnCancelEdit = new System.Windows.Forms.Button();
            this.btnCompleteEdit = new System.Windows.Forms.Button();
            this.btnEditDiscount = new System.Windows.Forms.Button();
            this.lblProductIDValid = new System.Windows.Forms.Label();
            this.lblDiscountPercentValid = new System.Windows.Forms.Label();
            this.lblDiscountIDTextValid = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnShowDiscount = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.cbxIsValid = new System.Windows.Forms.CheckBox();
            this.lblIsValid = new System.Windows.Forms.Label();
            this.tbxDiscountPercent = new System.Windows.Forms.TextBox();
            this.lblDiscountPercent = new System.Windows.Forms.Label();
            this.tbxProductID = new System.Windows.Forms.TextBox();
            this.lblProductID = new System.Windows.Forms.Label();
            this.lblDiscountType = new System.Windows.Forms.Label();
            this.cmxDiscountType = new System.Windows.Forms.ComboBox();
            this.lblDiscountID = new System.Windows.Forms.Label();
            this.tbxDiscount = new System.Windows.Forms.TextBox();
            this.dgvDiscount = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(273, 454);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 50);
            this.btnReturn.TabIndex = 44;
            this.btnReturn.Text = "&Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToDeleteRows = false;
            this.dgvProduct.AllowUserToOrderColumns = true;
            this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvProduct.BackgroundColor = System.Drawing.Color.White;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(516, 12);
            this.dgvProduct.MultiSelect = false;
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(456, 492);
            this.dgvProduct.TabIndex = 43;
            // 
            // btnCancelEdit
            // 
            this.btnCancelEdit.Location = new System.Drawing.Point(192, 454);
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.Size = new System.Drawing.Size(75, 50);
            this.btnCancelEdit.TabIndex = 42;
            this.btnCancelEdit.Text = "&Cancel Edit";
            this.btnCancelEdit.UseVisualStyleBackColor = true;
            // 
            // btnCompleteEdit
            // 
            this.btnCompleteEdit.Location = new System.Drawing.Point(192, 398);
            this.btnCompleteEdit.Name = "btnCompleteEdit";
            this.btnCompleteEdit.Size = new System.Drawing.Size(75, 50);
            this.btnCompleteEdit.TabIndex = 41;
            this.btnCompleteEdit.Text = "C&omplete Edit";
            this.btnCompleteEdit.UseVisualStyleBackColor = true;
            // 
            // btnEditDiscount
            // 
            this.btnEditDiscount.Location = new System.Drawing.Point(112, 454);
            this.btnEditDiscount.Name = "btnEditDiscount";
            this.btnEditDiscount.Size = new System.Drawing.Size(74, 50);
            this.btnEditDiscount.TabIndex = 40;
            this.btnEditDiscount.Text = "&Edit Discount";
            this.btnEditDiscount.UseVisualStyleBackColor = true;
            // 
            // lblProductIDValid
            // 
            this.lblProductIDValid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductIDValid.ForeColor = System.Drawing.Color.Red;
            this.lblProductIDValid.Location = new System.Drawing.Point(141, 221);
            this.lblProductIDValid.Name = "lblProductIDValid";
            this.lblProductIDValid.Size = new System.Drawing.Size(20, 21);
            this.lblProductIDValid.TabIndex = 39;
            this.lblProductIDValid.Text = "X";
            this.lblProductIDValid.Visible = false;
            // 
            // lblDiscountPercentValid
            // 
            this.lblDiscountPercentValid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountPercentValid.ForeColor = System.Drawing.Color.Red;
            this.lblDiscountPercentValid.Location = new System.Drawing.Point(141, 301);
            this.lblDiscountPercentValid.Name = "lblDiscountPercentValid";
            this.lblDiscountPercentValid.Size = new System.Drawing.Size(20, 21);
            this.lblDiscountPercentValid.TabIndex = 38;
            this.lblDiscountPercentValid.Text = "X";
            // 
            // lblDiscountIDTextValid
            // 
            this.lblDiscountIDTextValid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountIDTextValid.ForeColor = System.Drawing.Color.Red;
            this.lblDiscountIDTextValid.Location = new System.Drawing.Point(143, 56);
            this.lblDiscountIDTextValid.Name = "lblDiscountIDTextValid";
            this.lblDiscountIDTextValid.Size = new System.Drawing.Size(18, 21);
            this.lblDiscountIDTextValid.TabIndex = 37;
            this.lblDiscountIDTextValid.Text = "X";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(19, 454);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 50);
            this.btnAdd.TabIndex = 36;
            this.btnAdd.Text = "&Add Discount";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnShowDiscount
            // 
            this.btnShowDiscount.Location = new System.Drawing.Point(440, 461);
            this.btnShowDiscount.Name = "btnShowDiscount";
            this.btnShowDiscount.Size = new System.Drawing.Size(70, 43);
            this.btnShowDiscount.TabIndex = 35;
            this.btnShowDiscount.Text = "Show &Discount";
            this.btnShowDiscount.UseVisualStyleBackColor = true;
            // 
            // btnProduct
            // 
            this.btnProduct.Location = new System.Drawing.Point(440, 405);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(70, 43);
            this.btnProduct.TabIndex = 34;
            this.btnProduct.Text = "Show &Product";
            this.btnProduct.UseVisualStyleBackColor = true;
            // 
            // cbxIsValid
            // 
            this.cbxIsValid.AutoSize = true;
            this.cbxIsValid.Location = new System.Drawing.Point(19, 379);
            this.cbxIsValid.Name = "cbxIsValid";
            this.cbxIsValid.Size = new System.Drawing.Size(15, 14);
            this.cbxIsValid.TabIndex = 33;
            this.cbxIsValid.UseVisualStyleBackColor = true;
            // 
            // lblIsValid
            // 
            this.lblIsValid.AutoSize = true;
            this.lblIsValid.Location = new System.Drawing.Point(16, 361);
            this.lblIsValid.Name = "lblIsValid";
            this.lblIsValid.Size = new System.Drawing.Size(41, 13);
            this.lblIsValid.TabIndex = 32;
            this.lblIsValid.Text = "Is Valid";
            // 
            // tbxDiscountPercent
            // 
            this.tbxDiscountPercent.Location = new System.Drawing.Point(19, 301);
            this.tbxDiscountPercent.MaxLength = 2;
            this.tbxDiscountPercent.Name = "tbxDiscountPercent";
            this.tbxDiscountPercent.Size = new System.Drawing.Size(116, 20);
            this.tbxDiscountPercent.TabIndex = 31;
            // 
            // lblDiscountPercent
            // 
            this.lblDiscountPercent.AutoSize = true;
            this.lblDiscountPercent.Location = new System.Drawing.Point(16, 281);
            this.lblDiscountPercent.Name = "lblDiscountPercent";
            this.lblDiscountPercent.Size = new System.Drawing.Size(98, 13);
            this.lblDiscountPercent.TabIndex = 30;
            this.lblDiscountPercent.Text = "Discount Percent : ";
            // 
            // tbxProductID
            // 
            this.tbxProductID.Enabled = false;
            this.tbxProductID.Location = new System.Drawing.Point(19, 221);
            this.tbxProductID.MaxLength = 5;
            this.tbxProductID.Name = "tbxProductID";
            this.tbxProductID.Size = new System.Drawing.Size(116, 20);
            this.tbxProductID.TabIndex = 29;
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(16, 199);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(55, 13);
            this.lblProductID.TabIndex = 28;
            this.lblProductID.Text = "ProductID";
            // 
            // lblDiscountType
            // 
            this.lblDiscountType.AutoSize = true;
            this.lblDiscountType.Location = new System.Drawing.Point(16, 118);
            this.lblDiscountType.Name = "lblDiscountType";
            this.lblDiscountType.Size = new System.Drawing.Size(82, 13);
            this.lblDiscountType.TabIndex = 27;
            this.lblDiscountType.Text = "Discount Type :";
            // 
            // cmxDiscountType
            // 
            this.cmxDiscountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmxDiscountType.FormattingEnabled = true;
            this.cmxDiscountType.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmxDiscountType.Location = new System.Drawing.Point(19, 137);
            this.cmxDiscountType.Name = "cmxDiscountType";
            this.cmxDiscountType.Size = new System.Drawing.Size(116, 21);
            this.cmxDiscountType.TabIndex = 26;
            // 
            // lblDiscountID
            // 
            this.lblDiscountID.AutoSize = true;
            this.lblDiscountID.Location = new System.Drawing.Point(16, 37);
            this.lblDiscountID.Name = "lblDiscountID";
            this.lblDiscountID.Size = new System.Drawing.Size(69, 13);
            this.lblDiscountID.TabIndex = 25;
            this.lblDiscountID.Text = "Discount ID :";
            // 
            // tbxDiscount
            // 
            this.tbxDiscount.Location = new System.Drawing.Point(19, 56);
            this.tbxDiscount.MaxLength = 9;
            this.tbxDiscount.Name = "tbxDiscount";
            this.tbxDiscount.Size = new System.Drawing.Size(116, 20);
            this.tbxDiscount.TabIndex = 24;
            // 
            // dgvDiscount
            // 
            this.dgvDiscount.AllowUserToAddRows = false;
            this.dgvDiscount.AllowUserToDeleteRows = false;
            this.dgvDiscount.AllowUserToOrderColumns = true;
            this.dgvDiscount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDiscount.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvDiscount.BackgroundColor = System.Drawing.Color.White;
            this.dgvDiscount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiscount.Location = new System.Drawing.Point(516, 12);
            this.dgvDiscount.MultiSelect = false;
            this.dgvDiscount.Name = "dgvDiscount";
            this.dgvDiscount.ReadOnly = true;
            this.dgvDiscount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiscount.Size = new System.Drawing.Size(456, 492);
            this.dgvDiscount.TabIndex = 23;
            // 
            // frmManger_View_Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 520);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.btnCancelEdit);
            this.Controls.Add(this.btnCompleteEdit);
            this.Controls.Add(this.btnEditDiscount);
            this.Controls.Add(this.lblProductIDValid);
            this.Controls.Add(this.lblDiscountPercentValid);
            this.Controls.Add(this.lblDiscountIDTextValid);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnShowDiscount);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.cbxIsValid);
            this.Controls.Add(this.lblIsValid);
            this.Controls.Add(this.tbxDiscountPercent);
            this.Controls.Add(this.lblDiscountPercent);
            this.Controls.Add(this.tbxProductID);
            this.Controls.Add(this.lblProductID);
            this.Controls.Add(this.lblDiscountType);
            this.Controls.Add(this.cmxDiscountType);
            this.Controls.Add(this.lblDiscountID);
            this.Controls.Add(this.tbxDiscount);
            this.Controls.Add(this.dgvDiscount);
            this.Name = "frmManger_View_Employees";
            this.Text = "frmManger_View_Employees";
            this.Load += new System.EventHandler(this.frmManger_View_Employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Button btnCancelEdit;
        private System.Windows.Forms.Button btnCompleteEdit;
        private System.Windows.Forms.Button btnEditDiscount;
        private System.Windows.Forms.Label lblProductIDValid;
        private System.Windows.Forms.Label lblDiscountPercentValid;
        private System.Windows.Forms.Label lblDiscountIDTextValid;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnShowDiscount;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.CheckBox cbxIsValid;
        private System.Windows.Forms.Label lblIsValid;
        private System.Windows.Forms.TextBox tbxDiscountPercent;
        private System.Windows.Forms.Label lblDiscountPercent;
        private System.Windows.Forms.TextBox tbxProductID;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Label lblDiscountType;
        private System.Windows.Forms.ComboBox cmxDiscountType;
        private System.Windows.Forms.Label lblDiscountID;
        private System.Windows.Forms.TextBox tbxDiscount;
        private System.Windows.Forms.DataGridView dgvDiscount;
    }
}