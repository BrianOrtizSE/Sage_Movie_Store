﻿
namespace SU21_Final_Project
{
    partial class frmSignUp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSignUp));
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblPhoneSecondary = new System.Windows.Forms.Label();
            this.lblPhonePrimary = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxZipcode = new System.Windows.Forms.TextBox();
            this.tbxCity = new System.Windows.Forms.TextBox();
            this.lblSuffix = new System.Windows.Forms.Label();
            this.lblAdress1 = new System.Windows.Forms.Label();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.lblAddress3 = new System.Windows.Forms.Label();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbxAddress3 = new System.Windows.Forms.TextBox();
            this.tbxAddress2 = new System.Windows.Forms.TextBox();
            this.tbxAddress1 = new System.Windows.Forms.TextBox();
            this.tbxSuffix = new System.Windows.Forms.TextBox();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.tbxMiddleName = new System.Windows.Forms.TextBox();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.tbxTitle = new System.Windows.Forms.TextBox();
            this.mtbPhone1 = new System.Windows.Forms.MaskedTextBox();
            this.mtbPhone2 = new System.Windows.Forms.MaskedTextBox();
            this.lblErrorTitle = new System.Windows.Forms.Label();
            this.ttError = new System.Windows.Forms.ToolTip(this.components);
            this.lblErrorFirstName = new System.Windows.Forms.Label();
            this.lblErrorLastName = new System.Windows.Forms.Label();
            this.lblErrorMiddleName = new System.Windows.Forms.Label();
            this.lblErrorAddress3 = new System.Windows.Forms.Label();
            this.lblErrorAddress2 = new System.Windows.Forms.Label();
            this.lblErrorAddress1 = new System.Windows.Forms.Label();
            this.lblErrorSuffix = new System.Windows.Forms.Label();
            this.lblErrorPhoneSecondary = new System.Windows.Forms.Label();
            this.lblErrorPhonePrimary = new System.Windows.Forms.Label();
            this.lblErrorEmail = new System.Windows.Forms.Label();
            this.lblErrorState = new System.Windows.Forms.Label();
            this.lblErrorZipcode = new System.Windows.Forms.Label();
            this.lblErrorCity = new System.Windows.Forms.Label();
            this.cbxState = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblBlackLine = new System.Windows.Forms.Label();
            this.lblMainText = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnsHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRequriemtsn = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(278, 321);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 30);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "&Create User";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblPhoneSecondary
            // 
            this.lblPhoneSecondary.AutoSize = true;
            this.lblPhoneSecondary.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneSecondary.Location = new System.Drawing.Point(532, 192);
            this.lblPhoneSecondary.Name = "lblPhoneSecondary";
            this.lblPhoneSecondary.Size = new System.Drawing.Size(107, 16);
            this.lblPhoneSecondary.TabIndex = 61;
            this.lblPhoneSecondary.Text = "Phone Secondary";
            // 
            // lblPhonePrimary
            // 
            this.lblPhonePrimary.AutoSize = true;
            this.lblPhonePrimary.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhonePrimary.Location = new System.Drawing.Point(540, 157);
            this.lblPhonePrimary.Name = "lblPhonePrimary";
            this.lblPhonePrimary.Size = new System.Drawing.Size(99, 16);
            this.lblPhonePrimary.TabIndex = 60;
            this.lblPhonePrimary.Text = "Phone Primary*";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(593, 84);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(46, 16);
            this.lblState.TabIndex = 56;
            this.lblState.Text = "State*";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(592, 117);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(47, 16);
            this.lblEmail.TabIndex = 55;
            this.lblEmail.Text = "Email*";
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZipCode.Location = new System.Drawing.Point(292, 240);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(60, 16);
            this.lblZipCode.TabIndex = 54;
            this.lblZipCode.Text = "Zipcode*";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(307, 200);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(45, 16);
            this.lblCity.TabIndex = 53;
            this.lblCity.Text = "*City*";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEmail.Location = new System.Drawing.Point(645, 115);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(120, 23);
            this.tbxEmail.TabIndex = 11;
            // 
            // tbxZipcode
            // 
            this.tbxZipcode.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxZipcode.Location = new System.Drawing.Point(358, 237);
            this.tbxZipcode.MaxLength = 9;
            this.tbxZipcode.Name = "tbxZipcode";
            this.tbxZipcode.Size = new System.Drawing.Size(119, 23);
            this.tbxZipcode.TabIndex = 9;
            this.ttError.SetToolTip(this.tbxZipcode, "ZipCode Must Not Be Empty\r\nZIpCode Must Be At Least Longer Than 5 Numbers\r\nZipCod" +
        "e Cannot Be Greater Than 9 Numbers\r\n");
            this.tbxZipcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxZipcode_KeyPress);
            // 
            // tbxCity
            // 
            this.tbxCity.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCity.Location = new System.Drawing.Point(358, 201);
            this.tbxCity.Name = "tbxCity";
            this.tbxCity.Size = new System.Drawing.Size(119, 23);
            this.tbxCity.TabIndex = 8;
            this.tbxCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxCity_KeyPress);
            // 
            // lblSuffix
            // 
            this.lblSuffix.AutoSize = true;
            this.lblSuffix.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuffix.Location = new System.Drawing.Point(48, 237);
            this.lblSuffix.Name = "lblSuffix";
            this.lblSuffix.Size = new System.Drawing.Size(40, 16);
            this.lblSuffix.TabIndex = 48;
            this.lblSuffix.Text = "Suffix";
            // 
            // lblAdress1
            // 
            this.lblAdress1.AutoSize = true;
            this.lblAdress1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdress1.Location = new System.Drawing.Point(279, 79);
            this.lblAdress1.Name = "lblAdress1";
            this.lblAdress1.Size = new System.Drawing.Size(73, 16);
            this.lblAdress1.TabIndex = 47;
            this.lblAdress1.Text = "Address 1*";
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress2.Location = new System.Drawing.Point(287, 120);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(65, 16);
            this.lblAddress2.TabIndex = 46;
            this.lblAddress2.Text = "Address 2";
            // 
            // lblAddress3
            // 
            this.lblAddress3.AutoSize = true;
            this.lblAddress3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress3.Location = new System.Drawing.Point(287, 159);
            this.lblAddress3.Name = "lblAddress3";
            this.lblAddress3.Size = new System.Drawing.Size(65, 16);
            this.lblAddress3.TabIndex = 45;
            this.lblAddress3.Text = "Address 3";
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiddleName.Location = new System.Drawing.Point(5, 158);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(83, 16);
            this.lblMiddleName.TabIndex = 44;
            this.lblMiddleName.Text = "MIddle Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(12, 191);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(76, 16);
            this.lblLastName.TabIndex = 43;
            this.lblLastName.Text = "Last Name*";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(10, 118);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(78, 16);
            this.lblFirstName.TabIndex = 42;
            this.lblFirstName.Text = "First Name*";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(55, 78);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(33, 16);
            this.lblTitle.TabIndex = 41;
            this.lblTitle.Text = "Title";
            // 
            // tbxAddress3
            // 
            this.tbxAddress3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAddress3.Location = new System.Drawing.Point(358, 159);
            this.tbxAddress3.Name = "tbxAddress3";
            this.tbxAddress3.Size = new System.Drawing.Size(119, 23);
            this.tbxAddress3.TabIndex = 7;
            this.tbxAddress3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxAddress3_KeyPress);
            // 
            // tbxAddress2
            // 
            this.tbxAddress2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAddress2.Location = new System.Drawing.Point(358, 123);
            this.tbxAddress2.Name = "tbxAddress2";
            this.tbxAddress2.Size = new System.Drawing.Size(119, 23);
            this.tbxAddress2.TabIndex = 6;
            this.tbxAddress2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxAddress2_KeyPress);
            // 
            // tbxAddress1
            // 
            this.tbxAddress1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAddress1.Location = new System.Drawing.Point(358, 79);
            this.tbxAddress1.Name = "tbxAddress1";
            this.tbxAddress1.Size = new System.Drawing.Size(119, 23);
            this.tbxAddress1.TabIndex = 5;
            this.tbxAddress1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxAddress1_KeyPress);
            // 
            // tbxSuffix
            // 
            this.tbxSuffix.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSuffix.Location = new System.Drawing.Point(94, 236);
            this.tbxSuffix.Name = "tbxSuffix";
            this.tbxSuffix.Size = new System.Drawing.Size(114, 23);
            this.tbxSuffix.TabIndex = 4;
            this.tbxSuffix.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxSuffix_KeyPress);
            // 
            // tbxLastName
            // 
            this.tbxLastName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLastName.Location = new System.Drawing.Point(94, 193);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(114, 23);
            this.tbxLastName.TabIndex = 3;
            this.tbxLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxLastName_KeyPress);
            // 
            // tbxMiddleName
            // 
            this.tbxMiddleName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMiddleName.Location = new System.Drawing.Point(94, 157);
            this.tbxMiddleName.Name = "tbxMiddleName";
            this.tbxMiddleName.Size = new System.Drawing.Size(114, 23);
            this.tbxMiddleName.TabIndex = 2;
            this.tbxMiddleName.TextChanged += new System.EventHandler(this.tbxMiddleName_TextChanged);
            this.tbxMiddleName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxMiddleName_KeyPress);
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFirstName.Location = new System.Drawing.Point(94, 113);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(114, 23);
            this.tbxFirstName.TabIndex = 1;
            this.tbxFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxFirstName_KeyPress);
            // 
            // tbxTitle
            // 
            this.tbxTitle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTitle.Location = new System.Drawing.Point(94, 77);
            this.tbxTitle.Name = "tbxTitle";
            this.tbxTitle.Size = new System.Drawing.Size(114, 23);
            this.tbxTitle.TabIndex = 0;
            this.tbxTitle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxTitle_KeyPress);
            // 
            // mtbPhone1
            // 
            this.mtbPhone1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbPhone1.Location = new System.Drawing.Point(645, 155);
            this.mtbPhone1.Mask = "(999) 000-0000";
            this.mtbPhone1.Name = "mtbPhone1";
            this.mtbPhone1.Size = new System.Drawing.Size(120, 23);
            this.mtbPhone1.TabIndex = 12;
            this.mtbPhone1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbPhone1_KeyPress);
            // 
            // mtbPhone2
            // 
            this.mtbPhone2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbPhone2.Location = new System.Drawing.Point(645, 187);
            this.mtbPhone2.Mask = "(999) 000-0000";
            this.mtbPhone2.Name = "mtbPhone2";
            this.mtbPhone2.Size = new System.Drawing.Size(120, 23);
            this.mtbPhone2.TabIndex = 13;
            this.mtbPhone2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbPhone2_KeyPress);
            // 
            // lblErrorTitle
            // 
            this.lblErrorTitle.AutoSize = true;
            this.lblErrorTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorTitle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorTitle.ForeColor = System.Drawing.Color.Red;
            this.lblErrorTitle.Location = new System.Drawing.Point(214, 81);
            this.lblErrorTitle.Name = "lblErrorTitle";
            this.lblErrorTitle.Size = new System.Drawing.Size(45, 16);
            this.lblErrorTitle.TabIndex = 62;
            this.lblErrorTitle.Text = "*Error";
            this.ttError.SetToolTip(this.lblErrorTitle, "Title Cannot Be Longer Than 15 Letters");
            this.lblErrorTitle.Visible = false;
            // 
            // lblErrorFirstName
            // 
            this.lblErrorFirstName.AutoSize = true;
            this.lblErrorFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorFirstName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorFirstName.ForeColor = System.Drawing.Color.Red;
            this.lblErrorFirstName.Location = new System.Drawing.Point(214, 116);
            this.lblErrorFirstName.Name = "lblErrorFirstName";
            this.lblErrorFirstName.Size = new System.Drawing.Size(45, 16);
            this.lblErrorFirstName.TabIndex = 63;
            this.lblErrorFirstName.Text = "*Error";
            this.ttError.SetToolTip(this.lblErrorFirstName, "First Name Cannot Be Empty\r\nFirst Name Cannot Be Longer Than 20 Letters");
            this.lblErrorFirstName.Visible = false;
            // 
            // lblErrorLastName
            // 
            this.lblErrorLastName.AutoSize = true;
            this.lblErrorLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorLastName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorLastName.ForeColor = System.Drawing.Color.Red;
            this.lblErrorLastName.Location = new System.Drawing.Point(214, 199);
            this.lblErrorLastName.Name = "lblErrorLastName";
            this.lblErrorLastName.Size = new System.Drawing.Size(45, 16);
            this.lblErrorLastName.TabIndex = 65;
            this.lblErrorLastName.Text = "*Error";
            this.ttError.SetToolTip(this.lblErrorLastName, "Last Name Cannot Be Empty\r\nLast Name Cannot Be Greater Than 20  Letters\r\n\r\n\r\n");
            this.lblErrorLastName.Visible = false;
            // 
            // lblErrorMiddleName
            // 
            this.lblErrorMiddleName.AutoSize = true;
            this.lblErrorMiddleName.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorMiddleName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMiddleName.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMiddleName.Location = new System.Drawing.Point(214, 164);
            this.lblErrorMiddleName.Name = "lblErrorMiddleName";
            this.lblErrorMiddleName.Size = new System.Drawing.Size(45, 16);
            this.lblErrorMiddleName.TabIndex = 64;
            this.lblErrorMiddleName.Text = "*Error";
            this.ttError.SetToolTip(this.lblErrorMiddleName, "Middle Name Cannot Be Longer Than 20 Letters");
            this.lblErrorMiddleName.Visible = false;
            // 
            // lblErrorAddress3
            // 
            this.lblErrorAddress3.AutoSize = true;
            this.lblErrorAddress3.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorAddress3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorAddress3.ForeColor = System.Drawing.Color.Red;
            this.lblErrorAddress3.Location = new System.Drawing.Point(483, 168);
            this.lblErrorAddress3.Name = "lblErrorAddress3";
            this.lblErrorAddress3.Size = new System.Drawing.Size(45, 16);
            this.lblErrorAddress3.TabIndex = 69;
            this.lblErrorAddress3.Text = "*Error";
            this.ttError.SetToolTip(this.lblErrorAddress3, "Address 3 Cannot Be Longer Than 30 Charectors");
            this.lblErrorAddress3.Visible = false;
            // 
            // lblErrorAddress2
            // 
            this.lblErrorAddress2.AutoSize = true;
            this.lblErrorAddress2.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorAddress2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorAddress2.ForeColor = System.Drawing.Color.Red;
            this.lblErrorAddress2.Location = new System.Drawing.Point(483, 133);
            this.lblErrorAddress2.Name = "lblErrorAddress2";
            this.lblErrorAddress2.Size = new System.Drawing.Size(45, 16);
            this.lblErrorAddress2.TabIndex = 68;
            this.lblErrorAddress2.Text = "*Error";
            this.ttError.SetToolTip(this.lblErrorAddress2, "Address 2 Cannot Be Longer Than 30 Letters");
            this.lblErrorAddress2.Visible = false;
            // 
            // lblErrorAddress1
            // 
            this.lblErrorAddress1.AutoSize = true;
            this.lblErrorAddress1.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorAddress1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorAddress1.ForeColor = System.Drawing.Color.Red;
            this.lblErrorAddress1.Location = new System.Drawing.Point(483, 85);
            this.lblErrorAddress1.Name = "lblErrorAddress1";
            this.lblErrorAddress1.Size = new System.Drawing.Size(45, 16);
            this.lblErrorAddress1.TabIndex = 67;
            this.lblErrorAddress1.Text = "*Error";
            this.ttError.SetToolTip(this.lblErrorAddress1, "Address 1 Cannot Be Empty\r\nAddress 1 Must Not Be Longer than 30 Letters Or Number" +
        "s");
            this.lblErrorAddress1.Visible = false;
            // 
            // lblErrorSuffix
            // 
            this.lblErrorSuffix.AutoSize = true;
            this.lblErrorSuffix.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorSuffix.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorSuffix.ForeColor = System.Drawing.Color.Red;
            this.lblErrorSuffix.Location = new System.Drawing.Point(214, 239);
            this.lblErrorSuffix.Name = "lblErrorSuffix";
            this.lblErrorSuffix.Size = new System.Drawing.Size(45, 16);
            this.lblErrorSuffix.TabIndex = 66;
            this.lblErrorSuffix.Text = "*Error";
            this.ttError.SetToolTip(this.lblErrorSuffix, "Suffix Cannot Be Longer Than 20 Letters");
            this.lblErrorSuffix.Visible = false;
            // 
            // lblErrorPhoneSecondary
            // 
            this.lblErrorPhoneSecondary.AutoSize = true;
            this.lblErrorPhoneSecondary.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorPhoneSecondary.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorPhoneSecondary.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPhoneSecondary.Location = new System.Drawing.Point(771, 199);
            this.lblErrorPhoneSecondary.Name = "lblErrorPhoneSecondary";
            this.lblErrorPhoneSecondary.Size = new System.Drawing.Size(45, 16);
            this.lblErrorPhoneSecondary.TabIndex = 75;
            this.lblErrorPhoneSecondary.Text = "*Error";
            this.ttError.SetToolTip(this.lblErrorPhoneSecondary, "Secondary Phone Must Be Less Than 20 Digits");
            this.lblErrorPhoneSecondary.Visible = false;
            // 
            // lblErrorPhonePrimary
            // 
            this.lblErrorPhonePrimary.AutoSize = true;
            this.lblErrorPhonePrimary.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorPhonePrimary.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorPhonePrimary.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPhonePrimary.Location = new System.Drawing.Point(771, 164);
            this.lblErrorPhonePrimary.Name = "lblErrorPhonePrimary";
            this.lblErrorPhonePrimary.Size = new System.Drawing.Size(45, 16);
            this.lblErrorPhonePrimary.TabIndex = 74;
            this.lblErrorPhonePrimary.Text = "*Error";
            this.ttError.SetToolTip(this.lblErrorPhonePrimary, "Primary Phone Must Not Be Empty\r\nPrimary Phone Must Be Filled Out");
            this.lblErrorPhonePrimary.Visible = false;
            // 
            // lblErrorEmail
            // 
            this.lblErrorEmail.AutoSize = true;
            this.lblErrorEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorEmail.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorEmail.ForeColor = System.Drawing.Color.Red;
            this.lblErrorEmail.Location = new System.Drawing.Point(771, 124);
            this.lblErrorEmail.Name = "lblErrorEmail";
            this.lblErrorEmail.Size = new System.Drawing.Size(45, 16);
            this.lblErrorEmail.TabIndex = 73;
            this.lblErrorEmail.Text = "*Error";
            this.ttError.SetToolTip(this.lblErrorEmail, "Email Cannot Be Empty\r\nEmail Cannot Be Longer Than 40 Letters");
            this.lblErrorEmail.Visible = false;
            // 
            // lblErrorState
            // 
            this.lblErrorState.AutoSize = true;
            this.lblErrorState.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorState.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorState.ForeColor = System.Drawing.Color.Red;
            this.lblErrorState.Location = new System.Drawing.Point(771, 89);
            this.lblErrorState.Name = "lblErrorState";
            this.lblErrorState.Size = new System.Drawing.Size(45, 16);
            this.lblErrorState.TabIndex = 72;
            this.lblErrorState.Text = "*Error";
            this.ttError.SetToolTip(this.lblErrorState, "State Cannot Be Empty\r\nState Cannot Be Longer Than 2 Letters");
            this.lblErrorState.Visible = false;
            // 
            // lblErrorZipcode
            // 
            this.lblErrorZipcode.AutoSize = true;
            this.lblErrorZipcode.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorZipcode.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorZipcode.ForeColor = System.Drawing.Color.Red;
            this.lblErrorZipcode.Location = new System.Drawing.Point(483, 241);
            this.lblErrorZipcode.Name = "lblErrorZipcode";
            this.lblErrorZipcode.Size = new System.Drawing.Size(45, 16);
            this.lblErrorZipcode.TabIndex = 71;
            this.lblErrorZipcode.Text = "*Error";
            this.ttError.SetToolTip(this.lblErrorZipcode, "ZipCode Must Not Be Empty\r\nZipCode Must At Least Be 5 Digits\r\n");
            this.lblErrorZipcode.Visible = false;
            // 
            // lblErrorCity
            // 
            this.lblErrorCity.AutoSize = true;
            this.lblErrorCity.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorCity.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorCity.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCity.Location = new System.Drawing.Point(483, 206);
            this.lblErrorCity.Name = "lblErrorCity";
            this.lblErrorCity.Size = new System.Drawing.Size(45, 16);
            this.lblErrorCity.TabIndex = 70;
            this.lblErrorCity.Text = "*Error";
            this.ttError.SetToolTip(this.lblErrorCity, "City Cannot Be Empty\r\nCity Cannot Be Longer Than 30 Letters");
            this.lblErrorCity.Visible = false;
            // 
            // cbxState
            // 
            this.cbxState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxState.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxState.FormattingEnabled = true;
            this.cbxState.Items.AddRange(new object[] {
            "AL",
            "AK",
            "AS",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "DC",
            "FL",
            "GA",
            "GU",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "KY",
            "LA",
            "ME",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "MP",
            "OH",
            "OK",
            "OR",
            "PA",
            "PR",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "VI",
            "WA",
            "WV",
            "WI",
            "WY"});
            this.cbxState.Location = new System.Drawing.Point(645, 80);
            this.cbxState.MaxLength = 2;
            this.cbxState.Name = "cbxState";
            this.cbxState.Size = new System.Drawing.Size(120, 24);
            this.cbxState.TabIndex = 10;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(475, 321);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(109, 30);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "&Return";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblBlackLine
            // 
            this.lblBlackLine.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBlackLine.Location = new System.Drawing.Point(16, 43);
            this.lblBlackLine.Name = "lblBlackLine";
            this.lblBlackLine.Size = new System.Drawing.Size(800, 2);
            this.lblBlackLine.TabIndex = 76;
            this.lblBlackLine.Text = "0";
            // 
            // lblMainText
            // 
            this.lblMainText.AutoSize = true;
            this.lblMainText.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainText.Location = new System.Drawing.Point(363, 13);
            this.lblMainText.Name = "lblMainText";
            this.lblMainText.Size = new System.Drawing.Size(104, 19);
            this.lblMainText.TabIndex = 77;
            this.lblMainText.Text = "Sign Up Page";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(829, 24);
            this.menuStrip1.TabIndex = 78;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnsHelp
            // 
            this.mnsHelp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnsHelp.Name = "mnsHelp";
            this.mnsHelp.Size = new System.Drawing.Size(44, 20);
            this.mnsHelp.Text = "Help";
            this.mnsHelp.Click += new System.EventHandler(this.mnsHelp_Click);
            // 
            // lblRequriemtsn
            // 
            this.lblRequriemtsn.AutoSize = true;
            this.lblRequriemtsn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequriemtsn.ForeColor = System.Drawing.Color.Red;
            this.lblRequriemtsn.Location = new System.Drawing.Point(578, 236);
            this.lblRequriemtsn.Name = "lblRequriemtsn";
            this.lblRequriemtsn.Size = new System.Drawing.Size(206, 16);
            this.lblRequriemtsn.TabIndex = 79;
            this.lblRequriemtsn.Text = "All Boxes with * Must Be Filled Out";
            // 
            // frmSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 395);
            this.Controls.Add(this.lblRequriemtsn);
            this.Controls.Add(this.lblMainText);
            this.Controls.Add(this.lblBlackLine);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cbxState);
            this.Controls.Add(this.lblErrorPhoneSecondary);
            this.Controls.Add(this.lblErrorPhonePrimary);
            this.Controls.Add(this.lblErrorEmail);
            this.Controls.Add(this.lblErrorState);
            this.Controls.Add(this.lblErrorZipcode);
            this.Controls.Add(this.lblErrorCity);
            this.Controls.Add(this.lblErrorAddress3);
            this.Controls.Add(this.lblErrorAddress2);
            this.Controls.Add(this.lblErrorAddress1);
            this.Controls.Add(this.lblErrorSuffix);
            this.Controls.Add(this.lblErrorLastName);
            this.Controls.Add(this.lblErrorMiddleName);
            this.Controls.Add(this.lblErrorFirstName);
            this.Controls.Add(this.lblErrorTitle);
            this.Controls.Add(this.mtbPhone2);
            this.Controls.Add(this.mtbPhone1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblPhoneSecondary);
            this.Controls.Add(this.lblPhonePrimary);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblZipCode);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.tbxZipcode);
            this.Controls.Add(this.tbxCity);
            this.Controls.Add(this.lblSuffix);
            this.Controls.Add(this.lblAdress1);
            this.Controls.Add(this.lblAddress2);
            this.Controls.Add(this.lblAddress3);
            this.Controls.Add(this.lblMiddleName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tbxAddress3);
            this.Controls.Add(this.tbxAddress2);
            this.Controls.Add(this.tbxAddress1);
            this.Controls.Add(this.tbxSuffix);
            this.Controls.Add(this.tbxLastName);
            this.Controls.Add(this.tbxMiddleName);
            this.Controls.Add(this.tbxFirstName);
            this.Controls.Add(this.tbxTitle);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmSignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sign Up Page";
            this.Load += new System.EventHandler(this.frmSignUp_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblPhoneSecondary;
        private System.Windows.Forms.Label lblPhonePrimary;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxZipcode;
        private System.Windows.Forms.TextBox tbxCity;
        private System.Windows.Forms.Label lblSuffix;
        private System.Windows.Forms.Label lblAdress1;
        private System.Windows.Forms.Label lblAddress2;
        private System.Windows.Forms.Label lblAddress3;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tbxAddress3;
        private System.Windows.Forms.TextBox tbxAddress2;
        private System.Windows.Forms.TextBox tbxAddress1;
        private System.Windows.Forms.TextBox tbxSuffix;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.TextBox tbxMiddleName;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.TextBox tbxTitle;
        private System.Windows.Forms.MaskedTextBox mtbPhone1;
        private System.Windows.Forms.MaskedTextBox mtbPhone2;
        private System.Windows.Forms.Label lblErrorTitle;
        private System.Windows.Forms.ToolTip ttError;
        private System.Windows.Forms.Label lblErrorFirstName;
        private System.Windows.Forms.Label lblErrorLastName;
        private System.Windows.Forms.Label lblErrorMiddleName;
        private System.Windows.Forms.Label lblErrorAddress3;
        private System.Windows.Forms.Label lblErrorAddress2;
        private System.Windows.Forms.Label lblErrorAddress1;
        private System.Windows.Forms.Label lblErrorSuffix;
        private System.Windows.Forms.Label lblErrorPhoneSecondary;
        private System.Windows.Forms.Label lblErrorPhonePrimary;
        private System.Windows.Forms.Label lblErrorEmail;
        private System.Windows.Forms.Label lblErrorState;
        private System.Windows.Forms.Label lblErrorZipcode;
        private System.Windows.Forms.Label lblErrorCity;
        private System.Windows.Forms.ComboBox cbxState;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblBlackLine;
        private System.Windows.Forms.Label lblMainText;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnsHelp;
        private System.Windows.Forms.Label lblRequriemtsn;
    }
}