
namespace SU21_Final_Project
{
    partial class frmManager_Edit_Employees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManager_Edit_Employees));
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnCancelEdit = new System.Windows.Forms.Button();
            this.btnCompleteEdit = new System.Windows.Forms.Button();
            this.btnEditEmployee = new System.Windows.Forms.Button();
            this.lblPositionTextValid = new System.Windows.Forms.Label();
            this.lblWageTextValid = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbxAdmin = new System.Windows.Forms.CheckBox();
            this.tbxWage = new System.Windows.Forms.TextBox();
            this.lblWage = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblPersonID = new System.Windows.Forms.Label();
            this.cmxPosition = new System.Windows.Forms.ComboBox();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.tbxEmployee = new System.Windows.Forms.TextBox();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.tbxPersonID = new System.Windows.Forms.TextBox();
            this.cbxIsSalary = new System.Windows.Forms.CheckBox();
            this.tbxHireDate = new System.Windows.Forms.TextBox();
            this.lblHireDate = new System.Windows.Forms.Label();
            this.btnFindPersonID = new System.Windows.Forms.Button();
            this.btnGetDate = new System.Windows.Forms.Button();
            this.btnDisable = new System.Windows.Forms.Button();
            this.btnShowUnactive = new System.Windows.Forms.Button();
            this.btnShowActive = new System.Windows.Forms.Button();
            this.btnEnable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(267, 504);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 50);
            this.btnReturn.TabIndex = 20;
            this.btnReturn.Text = "&Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnCancelEdit
            // 
            this.btnCancelEdit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelEdit.Location = new System.Drawing.Point(186, 504);
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.Size = new System.Drawing.Size(75, 50);
            this.btnCancelEdit.TabIndex = 19;
            this.btnCancelEdit.Text = "&Cancel Edit";
            this.btnCancelEdit.UseVisualStyleBackColor = true;
            this.btnCancelEdit.Click += new System.EventHandler(this.btnCancelEdit_Click);
            // 
            // btnCompleteEdit
            // 
            this.btnCompleteEdit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompleteEdit.Location = new System.Drawing.Point(185, 449);
            this.btnCompleteEdit.Name = "btnCompleteEdit";
            this.btnCompleteEdit.Size = new System.Drawing.Size(75, 50);
            this.btnCompleteEdit.TabIndex = 18;
            this.btnCompleteEdit.Text = "C&omplete Edit";
            this.btnCompleteEdit.UseVisualStyleBackColor = true;
            this.btnCompleteEdit.Click += new System.EventHandler(this.btnCompleteEdit_Click);
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditEmployee.Location = new System.Drawing.Point(106, 504);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new System.Drawing.Size(74, 50);
            this.btnEditEmployee.TabIndex = 17;
            this.btnEditEmployee.Text = "&Edit Employee";
            this.btnEditEmployee.UseVisualStyleBackColor = true;
            this.btnEditEmployee.Click += new System.EventHandler(this.btnEditEmployee_Click);
            // 
            // lblPositionTextValid
            // 
            this.lblPositionTextValid.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPositionTextValid.ForeColor = System.Drawing.Color.Red;
            this.lblPositionTextValid.Location = new System.Drawing.Point(141, 208);
            this.lblPositionTextValid.Name = "lblPositionTextValid";
            this.lblPositionTextValid.Size = new System.Drawing.Size(20, 21);
            this.lblPositionTextValid.TabIndex = 7;
            this.lblPositionTextValid.Text = "X";
            this.lblPositionTextValid.Visible = false;
            // 
            // lblWageTextValid
            // 
            this.lblWageTextValid.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWageTextValid.ForeColor = System.Drawing.Color.Red;
            this.lblWageTextValid.Location = new System.Drawing.Point(141, 280);
            this.lblWageTextValid.Name = "lblWageTextValid";
            this.lblWageTextValid.Size = new System.Drawing.Size(20, 21);
            this.lblWageTextValid.TabIndex = 10;
            this.lblWageTextValid.Text = "X";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(13, 504);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 50);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "&Add Employee";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbxAdmin
            // 
            this.cbxAdmin.AutoSize = true;
            this.cbxAdmin.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAdmin.Location = new System.Drawing.Point(19, 425);
            this.cbxAdmin.Name = "cbxAdmin";
            this.cbxAdmin.Size = new System.Drawing.Size(83, 20);
            this.cbxAdmin.TabIndex = 15;
            this.cbxAdmin.Text = "Manager?";
            this.cbxAdmin.UseVisualStyleBackColor = true;
            // 
            // tbxWage
            // 
            this.tbxWage.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxWage.Location = new System.Drawing.Point(19, 280);
            this.tbxWage.MaxLength = 7;
            this.tbxWage.Name = "tbxWage";
            this.tbxWage.ShortcutsEnabled = false;
            this.tbxWage.Size = new System.Drawing.Size(116, 23);
            this.tbxWage.TabIndex = 9;
            this.tbxWage.TextChanged += new System.EventHandler(this.tbxDiscountPercent_TextChanged);
            this.tbxWage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxWage_KeyPress);
            // 
            // lblWage
            // 
            this.lblWage.AutoSize = true;
            this.lblWage.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWage.Location = new System.Drawing.Point(17, 264);
            this.lblWage.Name = "lblWage";
            this.lblWage.Size = new System.Drawing.Size(50, 16);
            this.lblWage.TabIndex = 8;
            this.lblWage.Text = "Wage :";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(17, 192);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(65, 16);
            this.lblPosition.TabIndex = 5;
            this.lblPosition.Text = "Position : ";
            // 
            // lblPersonID
            // 
            this.lblPersonID.AutoSize = true;
            this.lblPersonID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonID.Location = new System.Drawing.Point(16, 118);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(72, 16);
            this.lblPersonID.TabIndex = 2;
            this.lblPersonID.Text = "Person ID :";
            // 
            // cmxPosition
            // 
            this.cmxPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmxPosition.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmxPosition.FormattingEnabled = true;
            this.cmxPosition.Items.AddRange(new object[] {
            "Employee"});
            this.cmxPosition.Location = new System.Drawing.Point(19, 208);
            this.cmxPosition.Name = "cmxPosition";
            this.cmxPosition.Size = new System.Drawing.Size(116, 24);
            this.cmxPosition.TabIndex = 6;
            this.cmxPosition.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmxPosition_KeyPress);
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeID.Location = new System.Drawing.Point(16, 37);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(84, 16);
            this.lblEmployeeID.TabIndex = 0;
            this.lblEmployeeID.Text = "Employee ID:";
            // 
            // tbxEmployee
            // 
            this.tbxEmployee.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEmployee.Location = new System.Drawing.Point(19, 56);
            this.tbxEmployee.MaxLength = 9;
            this.tbxEmployee.Name = "tbxEmployee";
            this.tbxEmployee.ReadOnly = true;
            this.tbxEmployee.ShortcutsEnabled = false;
            this.tbxEmployee.Size = new System.Drawing.Size(116, 23);
            this.tbxEmployee.TabIndex = 1;
            this.tbxEmployee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxEmployee_KeyPress);
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AllowUserToAddRows = false;
            this.dgvEmployee.AllowUserToDeleteRows = false;
            this.dgvEmployee.AllowUserToOrderColumns = true;
            this.dgvEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployee.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvEmployee.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Location = new System.Drawing.Point(456, 12);
            this.dgvEmployee.MultiSelect = false;
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.ReadOnly = true;
            this.dgvEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployee.Size = new System.Drawing.Size(519, 542);
            this.dgvEmployee.TabIndex = 23;
            this.dgvEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_CellClick);
            // 
            // tbxPersonID
            // 
            this.tbxPersonID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPersonID.Location = new System.Drawing.Point(19, 132);
            this.tbxPersonID.MaxLength = 9;
            this.tbxPersonID.Name = "tbxPersonID";
            this.tbxPersonID.ReadOnly = true;
            this.tbxPersonID.ShortcutsEnabled = false;
            this.tbxPersonID.Size = new System.Drawing.Size(116, 23);
            this.tbxPersonID.TabIndex = 3;
            this.tbxPersonID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPersonID_KeyPress);
            // 
            // cbxIsSalary
            // 
            this.cbxIsSalary.AutoSize = true;
            this.cbxIsSalary.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxIsSalary.Location = new System.Drawing.Point(19, 306);
            this.cbxIsSalary.Name = "cbxIsSalary";
            this.cbxIsSalary.Size = new System.Drawing.Size(162, 20);
            this.cbxIsSalary.TabIndex = 11;
            this.cbxIsSalary.Text = "Is Employee On Salary?";
            this.cbxIsSalary.UseVisualStyleBackColor = true;
            // 
            // tbxHireDate
            // 
            this.tbxHireDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxHireDate.Location = new System.Drawing.Point(20, 367);
            this.tbxHireDate.MaxLength = 9;
            this.tbxHireDate.Name = "tbxHireDate";
            this.tbxHireDate.ReadOnly = true;
            this.tbxHireDate.ShortcutsEnabled = false;
            this.tbxHireDate.Size = new System.Drawing.Size(137, 23);
            this.tbxHireDate.TabIndex = 13;
            // 
            // lblHireDate
            // 
            this.lblHireDate.AutoSize = true;
            this.lblHireDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHireDate.Location = new System.Drawing.Point(18, 351);
            this.lblHireDate.Name = "lblHireDate";
            this.lblHireDate.Size = new System.Drawing.Size(74, 16);
            this.lblHireDate.TabIndex = 12;
            this.lblHireDate.Text = "Hire Date : ";
            // 
            // btnFindPersonID
            // 
            this.btnFindPersonID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindPersonID.Location = new System.Drawing.Point(141, 132);
            this.btnFindPersonID.Name = "btnFindPersonID";
            this.btnFindPersonID.Size = new System.Drawing.Size(119, 23);
            this.btnFindPersonID.TabIndex = 4;
            this.btnFindPersonID.Text = "Find Person ID";
            this.btnFindPersonID.UseVisualStyleBackColor = true;
            this.btnFindPersonID.Click += new System.EventHandler(this.btnFindPersonID_Click);
            // 
            // btnGetDate
            // 
            this.btnGetDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetDate.Location = new System.Drawing.Point(163, 367);
            this.btnGetDate.Name = "btnGetDate";
            this.btnGetDate.Size = new System.Drawing.Size(97, 23);
            this.btnGetDate.TabIndex = 14;
            this.btnGetDate.Text = "Get Date";
            this.btnGetDate.UseVisualStyleBackColor = true;
            this.btnGetDate.Click += new System.EventHandler(this.btnGetDate_Click);
            // 
            // btnDisable
            // 
            this.btnDisable.Enabled = false;
            this.btnDisable.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisable.Location = new System.Drawing.Point(372, 449);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(78, 50);
            this.btnDisable.TabIndex = 24;
            this.btnDisable.Text = "&Disable Employee";
            this.btnDisable.UseVisualStyleBackColor = true;
            this.btnDisable.Click += new System.EventHandler(this.btnDisable_Click);
            // 
            // btnShowUnactive
            // 
            this.btnShowUnactive.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowUnactive.Location = new System.Drawing.Point(372, 504);
            this.btnShowUnactive.Name = "btnShowUnactive";
            this.btnShowUnactive.Size = new System.Drawing.Size(78, 50);
            this.btnShowUnactive.TabIndex = 25;
            this.btnShowUnactive.Text = "&Show Unactive ";
            this.btnShowUnactive.UseVisualStyleBackColor = true;
            this.btnShowUnactive.Click += new System.EventHandler(this.btnShowUnactive_Click);
            // 
            // btnShowActive
            // 
            this.btnShowActive.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowActive.Location = new System.Drawing.Point(372, 504);
            this.btnShowActive.Name = "btnShowActive";
            this.btnShowActive.Size = new System.Drawing.Size(78, 50);
            this.btnShowActive.TabIndex = 22;
            this.btnShowActive.Text = "&Show Active ";
            this.btnShowActive.UseVisualStyleBackColor = true;
            this.btnShowActive.Visible = false;
            this.btnShowActive.Click += new System.EventHandler(this.btnShowActive_Click);
            // 
            // btnEnable
            // 
            this.btnEnable.Enabled = false;
            this.btnEnable.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnable.Location = new System.Drawing.Point(372, 448);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(78, 50);
            this.btnEnable.TabIndex = 21;
            this.btnEnable.Text = "&Enable Employee";
            this.btnEnable.UseVisualStyleBackColor = true;
            this.btnEnable.Visible = false;
            this.btnEnable.Click += new System.EventHandler(this.EnableEmployee_Click);
            // 
            // frmManager_Edit_Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 573);
            this.Controls.Add(this.btnEnable);
            this.Controls.Add(this.btnShowActive);
            this.Controls.Add(this.btnShowUnactive);
            this.Controls.Add(this.btnDisable);
            this.Controls.Add(this.btnGetDate);
            this.Controls.Add(this.btnFindPersonID);
            this.Controls.Add(this.tbxHireDate);
            this.Controls.Add(this.lblHireDate);
            this.Controls.Add(this.cbxIsSalary);
            this.Controls.Add(this.tbxPersonID);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnCancelEdit);
            this.Controls.Add(this.btnCompleteEdit);
            this.Controls.Add(this.btnEditEmployee);
            this.Controls.Add(this.lblPositionTextValid);
            this.Controls.Add(this.lblWageTextValid);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbxAdmin);
            this.Controls.Add(this.tbxWage);
            this.Controls.Add(this.lblWage);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblPersonID);
            this.Controls.Add(this.cmxPosition);
            this.Controls.Add(this.lblEmployeeID);
            this.Controls.Add(this.tbxEmployee);
            this.Controls.Add(this.dgvEmployee);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmManager_Edit_Employees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Employee Mangaer";
            this.Load += new System.EventHandler(this.frmManger_View_Employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnCancelEdit;
        private System.Windows.Forms.Button btnCompleteEdit;
        private System.Windows.Forms.Button btnEditEmployee;
        private System.Windows.Forms.Label lblPositionTextValid;
        private System.Windows.Forms.Label lblWageTextValid;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckBox cbxAdmin;
        private System.Windows.Forms.TextBox tbxWage;
        private System.Windows.Forms.Label lblWage;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblPersonID;
        private System.Windows.Forms.ComboBox cmxPosition;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.TextBox tbxEmployee;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.TextBox tbxPersonID;
        private System.Windows.Forms.CheckBox cbxIsSalary;
        private System.Windows.Forms.TextBox tbxHireDate;
        private System.Windows.Forms.Label lblHireDate;
        private System.Windows.Forms.Button btnFindPersonID;
        private System.Windows.Forms.Button btnGetDate;
        private System.Windows.Forms.Button btnDisable;
        private System.Windows.Forms.Button btnShowUnactive;
        private System.Windows.Forms.Button btnShowActive;
        private System.Windows.Forms.Button btnEnable;
    }
}