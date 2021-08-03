
namespace SU21_Final_Project
{
    partial class frmManager_Edit_Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManager_Edit_Customer));
            this.tbxPersonID = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.lblPersonID = new System.Windows.Forms.Label();
            this.dgvPerson = new System.Windows.Forms.DataGridView();
            this.tbxNameFirst = new System.Windows.Forms.TextBox();
            this.lblNameFirst = new System.Windows.Forms.Label();
            this.tbxNameLast = new System.Windows.Forms.TextBox();
            this.lblNameLast = new System.Windows.Forms.Label();
            this.tbxAddress1 = new System.Windows.Forms.TextBox();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.tbxCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbxState = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.tbxPhone = new System.Windows.Forms.TextBox();
            this.lblPhonePrimary = new System.Windows.Forms.Label();
            this.tbxZipcode = new System.Windows.Forms.TextBox();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.btnShowDIsabled = new System.Windows.Forms.Button();
            this.btnDisableCustomer = new System.Windows.Forms.Button();
            this.btnShowInactive = new System.Windows.Forms.Button();
            this.btnEnable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxPersonID
            // 
            this.tbxPersonID.BackColor = System.Drawing.SystemColors.Window;
            this.tbxPersonID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPersonID.Location = new System.Drawing.Point(16, 38);
            this.tbxPersonID.MaxLength = 9;
            this.tbxPersonID.Name = "tbxPersonID";
            this.tbxPersonID.ReadOnly = true;
            this.tbxPersonID.Size = new System.Drawing.Size(180, 23);
            this.tbxPersonID.TabIndex = 68;
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(100, 468);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 50);
            this.btnReturn.TabIndex = 67;
            this.btnReturn.Text = "&Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnEditUser
            // 
            this.btnEditUser.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditUser.Location = new System.Drawing.Point(7, 468);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(87, 50);
            this.btnEditUser.TabIndex = 61;
            this.btnEditUser.Text = "Edit &User";
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // lblPersonID
            // 
            this.lblPersonID.AutoSize = true;
            this.lblPersonID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonID.Location = new System.Drawing.Point(19, 20);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(72, 16);
            this.lblPersonID.TabIndex = 56;
            this.lblPersonID.Text = "Person ID :";
            // 
            // dgvPerson
            // 
            this.dgvPerson.AllowUserToAddRows = false;
            this.dgvPerson.AllowUserToDeleteRows = false;
            this.dgvPerson.AllowUserToOrderColumns = true;
            this.dgvPerson.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPerson.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvPerson.BackgroundColor = System.Drawing.Color.White;
            this.dgvPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerson.Location = new System.Drawing.Point(478, 12);
            this.dgvPerson.MultiSelect = false;
            this.dgvPerson.Name = "dgvPerson";
            this.dgvPerson.ReadOnly = true;
            this.dgvPerson.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPerson.Size = new System.Drawing.Size(764, 513);
            this.dgvPerson.TabIndex = 52;
            this.dgvPerson.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPerson_CellClick);
            // 
            // tbxNameFirst
            // 
            this.tbxNameFirst.BackColor = System.Drawing.SystemColors.Window;
            this.tbxNameFirst.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNameFirst.Location = new System.Drawing.Point(16, 108);
            this.tbxNameFirst.MaxLength = 9;
            this.tbxNameFirst.Name = "tbxNameFirst";
            this.tbxNameFirst.ReadOnly = true;
            this.tbxNameFirst.Size = new System.Drawing.Size(180, 23);
            this.tbxNameFirst.TabIndex = 74;
            // 
            // lblNameFirst
            // 
            this.lblNameFirst.AutoSize = true;
            this.lblNameFirst.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameFirst.Location = new System.Drawing.Point(19, 90);
            this.lblNameFirst.Name = "lblNameFirst";
            this.lblNameFirst.Size = new System.Drawing.Size(79, 16);
            this.lblNameFirst.TabIndex = 73;
            this.lblNameFirst.Text = "First Name :";
            // 
            // tbxNameLast
            // 
            this.tbxNameLast.BackColor = System.Drawing.SystemColors.Window;
            this.tbxNameLast.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNameLast.Location = new System.Drawing.Point(16, 178);
            this.tbxNameLast.MaxLength = 9;
            this.tbxNameLast.Name = "tbxNameLast";
            this.tbxNameLast.ReadOnly = true;
            this.tbxNameLast.Size = new System.Drawing.Size(180, 23);
            this.tbxNameLast.TabIndex = 76;
            // 
            // lblNameLast
            // 
            this.lblNameLast.AutoSize = true;
            this.lblNameLast.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameLast.Location = new System.Drawing.Point(19, 160);
            this.lblNameLast.Name = "lblNameLast";
            this.lblNameLast.Size = new System.Drawing.Size(77, 16);
            this.lblNameLast.TabIndex = 75;
            this.lblNameLast.Text = "Last Name :";
            // 
            // tbxAddress1
            // 
            this.tbxAddress1.BackColor = System.Drawing.SystemColors.Window;
            this.tbxAddress1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAddress1.Location = new System.Drawing.Point(16, 248);
            this.tbxAddress1.MaxLength = 9;
            this.tbxAddress1.Name = "tbxAddress1";
            this.tbxAddress1.ReadOnly = true;
            this.tbxAddress1.Size = new System.Drawing.Size(180, 23);
            this.tbxAddress1.TabIndex = 78;
            // 
            // lblAddress1
            // 
            this.lblAddress1.AutoSize = true;
            this.lblAddress1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress1.Location = new System.Drawing.Point(19, 229);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(67, 16);
            this.lblAddress1.TabIndex = 77;
            this.lblAddress1.Text = "Address : ";
            // 
            // tbxCity
            // 
            this.tbxCity.BackColor = System.Drawing.SystemColors.Window;
            this.tbxCity.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCity.Location = new System.Drawing.Point(16, 316);
            this.tbxCity.MaxLength = 9;
            this.tbxCity.Name = "tbxCity";
            this.tbxCity.ReadOnly = true;
            this.tbxCity.Size = new System.Drawing.Size(180, 23);
            this.tbxCity.TabIndex = 80;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(20, 297);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(42, 16);
            this.lblCity.TabIndex = 79;
            this.lblCity.Text = "City : ";
            // 
            // tbxEmail
            // 
            this.tbxEmail.BackColor = System.Drawing.SystemColors.Window;
            this.tbxEmail.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEmail.Location = new System.Drawing.Point(269, 179);
            this.tbxEmail.MaxLength = 9;
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.ReadOnly = true;
            this.tbxEmail.Size = new System.Drawing.Size(172, 23);
            this.tbxEmail.TabIndex = 84;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(268, 160);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 16);
            this.lblEmail.TabIndex = 83;
            this.lblEmail.Text = "Email : ";
            // 
            // tbxState
            // 
            this.tbxState.BackColor = System.Drawing.SystemColors.Window;
            this.tbxState.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxState.Location = new System.Drawing.Point(269, 109);
            this.tbxState.MaxLength = 9;
            this.tbxState.Name = "tbxState";
            this.tbxState.ReadOnly = true;
            this.tbxState.Size = new System.Drawing.Size(172, 23);
            this.tbxState.TabIndex = 82;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(268, 90);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(51, 16);
            this.lblState.TabIndex = 81;
            this.lblState.Text = "State : ";
            // 
            // tbxPhone
            // 
            this.tbxPhone.BackColor = System.Drawing.SystemColors.Window;
            this.tbxPhone.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPhone.Location = new System.Drawing.Point(269, 249);
            this.tbxPhone.MaxLength = 9;
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.ReadOnly = true;
            this.tbxPhone.Size = new System.Drawing.Size(172, 23);
            this.tbxPhone.TabIndex = 86;
            // 
            // lblPhonePrimary
            // 
            this.lblPhonePrimary.AutoSize = true;
            this.lblPhonePrimary.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhonePrimary.Location = new System.Drawing.Point(266, 230);
            this.lblPhonePrimary.Name = "lblPhonePrimary";
            this.lblPhonePrimary.Size = new System.Drawing.Size(56, 16);
            this.lblPhonePrimary.TabIndex = 85;
            this.lblPhonePrimary.Text = "Phone : ";
            // 
            // tbxZipcode
            // 
            this.tbxZipcode.BackColor = System.Drawing.SystemColors.Window;
            this.tbxZipcode.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxZipcode.Location = new System.Drawing.Point(269, 39);
            this.tbxZipcode.MaxLength = 9;
            this.tbxZipcode.Name = "tbxZipcode";
            this.tbxZipcode.ReadOnly = true;
            this.tbxZipcode.Size = new System.Drawing.Size(172, 23);
            this.tbxZipcode.TabIndex = 88;
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZipCode.Location = new System.Drawing.Point(268, 20);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(65, 16);
            this.lblZipCode.TabIndex = 87;
            this.lblZipCode.Text = "Zipcode : ";
            // 
            // btnShowDIsabled
            // 
            this.btnShowDIsabled.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowDIsabled.Location = new System.Drawing.Point(365, 475);
            this.btnShowDIsabled.Name = "btnShowDIsabled";
            this.btnShowDIsabled.Size = new System.Drawing.Size(107, 50);
            this.btnShowDIsabled.TabIndex = 89;
            this.btnShowDIsabled.Text = "&Show Inactive Customers";
            this.btnShowDIsabled.UseVisualStyleBackColor = true;
            this.btnShowDIsabled.Click += new System.EventHandler(this.btnShowDIsabled_Click);
            // 
            // btnDisableCustomer
            // 
            this.btnDisableCustomer.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisableCustomer.Location = new System.Drawing.Point(365, 412);
            this.btnDisableCustomer.Name = "btnDisableCustomer";
            this.btnDisableCustomer.Size = new System.Drawing.Size(107, 50);
            this.btnDisableCustomer.TabIndex = 90;
            this.btnDisableCustomer.Text = "&Disable Customer";
            this.btnDisableCustomer.UseVisualStyleBackColor = true;
            this.btnDisableCustomer.Click += new System.EventHandler(this.btnDisableCustomer_Click);
            // 
            // btnShowInactive
            // 
            this.btnShowInactive.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowInactive.Location = new System.Drawing.Point(365, 475);
            this.btnShowInactive.Name = "btnShowInactive";
            this.btnShowInactive.Size = new System.Drawing.Size(107, 50);
            this.btnShowInactive.TabIndex = 91;
            this.btnShowInactive.Text = "&Show Active Customers";
            this.btnShowInactive.UseVisualStyleBackColor = true;
            this.btnShowInactive.Visible = false;
            this.btnShowInactive.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEnable
            // 
            this.btnEnable.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnable.Location = new System.Drawing.Point(365, 412);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(107, 50);
            this.btnEnable.TabIndex = 92;
            this.btnEnable.Text = "&Enable Customers";
            this.btnEnable.UseVisualStyleBackColor = true;
            this.btnEnable.Visible = false;
            this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
            // 
            // frmManager_Edit_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 537);
            this.Controls.Add(this.btnEnable);
            this.Controls.Add(this.btnShowInactive);
            this.Controls.Add(this.btnDisableCustomer);
            this.Controls.Add(this.btnShowDIsabled);
            this.Controls.Add(this.tbxZipcode);
            this.Controls.Add(this.lblZipCode);
            this.Controls.Add(this.tbxPhone);
            this.Controls.Add(this.lblPhonePrimary);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.tbxState);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.tbxCity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.tbxAddress1);
            this.Controls.Add(this.lblAddress1);
            this.Controls.Add(this.tbxNameLast);
            this.Controls.Add(this.lblNameLast);
            this.Controls.Add(this.tbxNameFirst);
            this.Controls.Add(this.lblNameFirst);
            this.Controls.Add(this.tbxPersonID);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnEditUser);
            this.Controls.Add(this.lblPersonID);
            this.Controls.Add(this.dgvPerson);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmManager_Edit_Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Customer";
            this.Load += new System.EventHandler(this.frmManager_Edit_Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbxPersonID;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Label lblPersonID;
        private System.Windows.Forms.DataGridView dgvPerson;
        private System.Windows.Forms.TextBox tbxNameFirst;
        private System.Windows.Forms.Label lblNameFirst;
        private System.Windows.Forms.TextBox tbxNameLast;
        private System.Windows.Forms.Label lblNameLast;
        private System.Windows.Forms.TextBox tbxAddress1;
        private System.Windows.Forms.Label lblAddress1;
        private System.Windows.Forms.TextBox tbxCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbxState;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox tbxPhone;
        private System.Windows.Forms.Label lblPhonePrimary;
        private System.Windows.Forms.TextBox tbxZipcode;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.Button btnShowDIsabled;
        private System.Windows.Forms.Button btnDisableCustomer;
        private System.Windows.Forms.Button btnShowInactive;
        private System.Windows.Forms.Button btnEnable;
    }
}