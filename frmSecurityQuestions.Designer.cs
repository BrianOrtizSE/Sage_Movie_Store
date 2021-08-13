
namespace SU21_Final_Project
{
    partial class frmSecurityQuestions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSecurityQuestions));
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbSQuestion2 = new System.Windows.Forms.ComboBox();
            this.cmbSQuestion1 = new System.Windows.Forms.ComboBox();
            this.tbxSQAnswer2 = new System.Windows.Forms.TextBox();
            this.tbxSQAnswer1 = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblSQuestion1 = new System.Windows.Forms.Label();
            this.lblSQAnwser = new System.Windows.Forms.Label();
            this.lblSQ2 = new System.Windows.Forms.Label();
            this.lblSQAnwser2 = new System.Windows.Forms.Label();
            this.lblSQuestion3 = new System.Windows.Forms.Label();
            this.lblSQA3 = new System.Windows.Forms.Label();
            this.cmbQuestion3 = new System.Windows.Forms.ComboBox();
            this.tbxSQAnswer3 = new System.Windows.Forms.TextBox();
            this.lblUsernameValid = new System.Windows.Forms.Label();
            this.lblPasswordText = new System.Windows.Forms.Label();
            this.lblSQAnswer1Valid = new System.Windows.Forms.Label();
            this.lblAttention = new System.Windows.Forms.Label();
            this.lblRetypePassword = new System.Windows.Forms.Label();
            this.tbxRetypePassword = new System.Windows.Forms.TextBox();
            this.TTError = new System.Windows.Forms.ToolTip(this.components);
            this.lblSQuestion1Valid = new System.Windows.Forms.Label();
            this.lblSQuestion2Valid = new System.Windows.Forms.Label();
            this.lblSAnswer2Valid = new System.Windows.Forms.Label();
            this.lblSQuestion3Valid = new System.Windows.Forms.Label();
            this.lblSAnswer3Valid = new System.Windows.Forms.Label();
            this.lblPasswordValid = new System.Windows.Forms.Label();
            this.lblRetypePasswordValid = new System.Windows.Forms.Label();
            this.mnsHelp = new System.Windows.Forms.MenuStrip();
            this.smnHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.cbxPassword1 = new System.Windows.Forms.CheckBox();
            this.cbxPassword2 = new System.Windows.Forms.CheckBox();
            this.mnsHelp.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(531, 226);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 32;
            this.btnAdd.Text = "&Finish";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbSQuestion2
            // 
            this.cmbSQuestion2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSQuestion2.DropDownWidth = 400;
            this.cmbSQuestion2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSQuestion2.FormattingEnabled = true;
            this.cmbSQuestion2.Items.AddRange(new object[] {
            "What was your childhood nickname?",
            "What is the name of your favorite childhood friend?",
            "In what city or town did your mother and father meet?",
            "What is the middle name of your oldest child?",
            "What is your favorite team?",
            "What is your favorite movie?",
            "What was your favorite sport in high school?",
            "What was your favorite food as a child?",
            "What is the first name of the boy or girl that you first kissed?",
            "What was the make and model of your first car?",
            "What was the name of the hospital where you were born?",
            "Who is your childhood sports hero?"});
            this.cmbSQuestion2.Location = new System.Drawing.Point(200, 291);
            this.cmbSQuestion2.MaxDropDownItems = 12;
            this.cmbSQuestion2.Name = "cmbSQuestion2";
            this.cmbSQuestion2.Size = new System.Drawing.Size(274, 24);
            this.cmbSQuestion2.TabIndex = 19;
            this.cmbSQuestion2.SelectedIndexChanged += new System.EventHandler(this.cmbSQuestion2_SelectedIndexChanged);
            // 
            // cmbSQuestion1
            // 
            this.cmbSQuestion1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSQuestion1.DropDownWidth = 400;
            this.cmbSQuestion1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSQuestion1.FormattingEnabled = true;
            this.cmbSQuestion1.Items.AddRange(new object[] {
            "What was your childhood nickname?",
            "What is the name of your favorite childhood friend?",
            "In what city or town did your mother and father meet?",
            "What is the middle name of your oldest child?",
            "What is your favorite team?",
            "What is your favorite movie?",
            "What was your favorite sport in high school?",
            "What was your favorite food as a child?",
            "What is the first name of the boy or girl that you first kissed?",
            "What was the make and model of your first car?",
            "What was the name of the hospital where you were born?",
            "Who is your childhood sports hero?"});
            this.cmbSQuestion1.Location = new System.Drawing.Point(200, 218);
            this.cmbSQuestion1.MaxDropDownItems = 12;
            this.cmbSQuestion1.Name = "cmbSQuestion1";
            this.cmbSQuestion1.Size = new System.Drawing.Size(274, 24);
            this.cmbSQuestion1.TabIndex = 13;
            this.cmbSQuestion1.SelectedIndexChanged += new System.EventHandler(this.cmbSQuestion1_SelectedIndexChanged);
            // 
            // tbxSQAnswer2
            // 
            this.tbxSQAnswer2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSQAnswer2.Location = new System.Drawing.Point(200, 328);
            this.tbxSQAnswer2.MaxLength = 75;
            this.tbxSQAnswer2.Name = "tbxSQAnswer2";
            this.tbxSQAnswer2.ShortcutsEnabled = false;
            this.tbxSQAnswer2.Size = new System.Drawing.Size(274, 23);
            this.tbxSQAnswer2.TabIndex = 22;
            this.tbxSQAnswer2.TextChanged += new System.EventHandler(this.tbxSQAnswer2_TextChanged);
            this.tbxSQAnswer2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxSQAnswer2_KeyPress);
            // 
            // tbxSQAnswer1
            // 
            this.tbxSQAnswer1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSQAnswer1.Location = new System.Drawing.Point(200, 255);
            this.tbxSQAnswer1.MaxLength = 75;
            this.tbxSQAnswer1.Name = "tbxSQAnswer1";
            this.tbxSQAnswer1.ShortcutsEnabled = false;
            this.tbxSQAnswer1.Size = new System.Drawing.Size(274, 23);
            this.tbxSQAnswer1.TabIndex = 16;
            this.tbxSQAnswer1.TextChanged += new System.EventHandler(this.tbxSQAnswer1_TextChanged);
            this.tbxSQAnswer1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxSQAnswer1_KeyPress);
            // 
            // tbxPassword
            // 
            this.tbxPassword.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPassword.Location = new System.Drawing.Point(200, 90);
            this.tbxPassword.MaxLength = 20;
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.ShortcutsEnabled = false;
            this.tbxPassword.Size = new System.Drawing.Size(274, 23);
            this.tbxPassword.TabIndex = 5;
            this.tbxPassword.UseSystemPasswordChar = true;
            this.tbxPassword.TextChanged += new System.EventHandler(this.tbxPassword_TextChanged);
            this.tbxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPassword_KeyPress);
            // 
            // tbxUsername
            // 
            this.tbxUsername.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUsername.Location = new System.Drawing.Point(200, 53);
            this.tbxUsername.MaxLength = 20;
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.ShortcutsEnabled = false;
            this.tbxUsername.Size = new System.Drawing.Size(274, 23);
            this.tbxUsername.TabIndex = 2;
            this.tbxUsername.TextChanged += new System.EventHandler(this.tbxUsername_TextChanged);
            this.tbxUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxUsername_KeyPress);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(116, 61);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(79, 16);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username : ";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(119, 102);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(76, 16);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password : ";
            // 
            // lblSQuestion1
            // 
            this.lblSQuestion1.AutoSize = true;
            this.lblSQuestion1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSQuestion1.Location = new System.Drawing.Point(67, 226);
            this.lblSQuestion1.Name = "lblSQuestion1";
            this.lblSQuestion1.Size = new System.Drawing.Size(128, 16);
            this.lblSQuestion1.TabIndex = 12;
            this.lblSQuestion1.Text = "Security Question 1 :";
            // 
            // lblSQAnwser
            // 
            this.lblSQAnwser.AutoSize = true;
            this.lblSQAnwser.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSQAnwser.Location = new System.Drawing.Point(47, 260);
            this.lblSQAnwser.Name = "lblSQAnwser";
            this.lblSQAnwser.Size = new System.Drawing.Size(148, 16);
            this.lblSQAnwser.TabIndex = 15;
            this.lblSQAnwser.Text = "Answer To Question 1 : ";
            // 
            // lblSQ2
            // 
            this.lblSQ2.AutoSize = true;
            this.lblSQ2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSQ2.Location = new System.Drawing.Point(67, 296);
            this.lblSQ2.Name = "lblSQ2";
            this.lblSQ2.Size = new System.Drawing.Size(128, 16);
            this.lblSQ2.TabIndex = 18;
            this.lblSQ2.Text = "Security Question 2 :";
            // 
            // lblSQAnwser2
            // 
            this.lblSQAnwser2.AutoSize = true;
            this.lblSQAnwser2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSQAnwser2.Location = new System.Drawing.Point(47, 333);
            this.lblSQAnwser2.Name = "lblSQAnwser2";
            this.lblSQAnwser2.Size = new System.Drawing.Size(148, 16);
            this.lblSQAnwser2.TabIndex = 21;
            this.lblSQAnwser2.Text = "Answer To Question 2 : ";
            // 
            // lblSQuestion3
            // 
            this.lblSQuestion3.AutoSize = true;
            this.lblSQuestion3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSQuestion3.Location = new System.Drawing.Point(67, 372);
            this.lblSQuestion3.Name = "lblSQuestion3";
            this.lblSQuestion3.Size = new System.Drawing.Size(128, 16);
            this.lblSQuestion3.TabIndex = 24;
            this.lblSQuestion3.Text = "Security Question 3 :";
            // 
            // lblSQA3
            // 
            this.lblSQA3.AutoSize = true;
            this.lblSQA3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSQA3.Location = new System.Drawing.Point(47, 409);
            this.lblSQA3.Name = "lblSQA3";
            this.lblSQA3.Size = new System.Drawing.Size(148, 16);
            this.lblSQA3.TabIndex = 27;
            this.lblSQA3.Text = "Answer To Question 3 : ";
            // 
            // cmbQuestion3
            // 
            this.cmbQuestion3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuestion3.DropDownWidth = 400;
            this.cmbQuestion3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbQuestion3.FormattingEnabled = true;
            this.cmbQuestion3.Items.AddRange(new object[] {
            "What was your childhood nickname?",
            "What is the name of your favorite childhood friend?",
            "In what city or town did your mother and father meet?",
            "What is the middle name of your oldest child?",
            "What is your favorite team?",
            "What is your favorite movie?",
            "What was your favorite sport in high school?",
            "What was your favorite food as a child?",
            "What is the first name of the boy or girl that you first kissed?",
            "What was the make and model of your first car?",
            "What was the name of the hospital where you were born?",
            "Who is your childhood sports hero?"});
            this.cmbQuestion3.Location = new System.Drawing.Point(200, 367);
            this.cmbQuestion3.MaxDropDownItems = 12;
            this.cmbQuestion3.Name = "cmbQuestion3";
            this.cmbQuestion3.Size = new System.Drawing.Size(274, 24);
            this.cmbQuestion3.TabIndex = 25;
            this.cmbQuestion3.SelectedIndexChanged += new System.EventHandler(this.cmbQuestion3_SelectedIndexChanged);
            // 
            // tbxSQAnswer3
            // 
            this.tbxSQAnswer3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSQAnswer3.Location = new System.Drawing.Point(200, 404);
            this.tbxSQAnswer3.MaxLength = 75;
            this.tbxSQAnswer3.Name = "tbxSQAnswer3";
            this.tbxSQAnswer3.ShortcutsEnabled = false;
            this.tbxSQAnswer3.Size = new System.Drawing.Size(274, 23);
            this.tbxSQAnswer3.TabIndex = 28;
            this.tbxSQAnswer3.TextChanged += new System.EventHandler(this.tbxSQAnswer3_TextChanged);
            this.tbxSQAnswer3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxSQAnswer3_KeyPress);
            // 
            // lblUsernameValid
            // 
            this.lblUsernameValid.AutoSize = true;
            this.lblUsernameValid.BackColor = System.Drawing.Color.Transparent;
            this.lblUsernameValid.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameValid.ForeColor = System.Drawing.Color.Red;
            this.lblUsernameValid.Location = new System.Drawing.Point(480, 56);
            this.lblUsernameValid.Name = "lblUsernameValid";
            this.lblUsernameValid.Size = new System.Drawing.Size(16, 16);
            this.lblUsernameValid.TabIndex = 3;
            this.lblUsernameValid.Text = "X";
            this.TTError.SetToolTip(this.lblUsernameValid, "Username must be longer than 8 letters\r\n1 Capital Letter\r\n1 Lower Case Letter\r\n1 " +
        "Symbol\r\n1 Number\r\n");
            // 
            // lblPasswordText
            // 
            this.lblPasswordText.AutoSize = true;
            this.lblPasswordText.BackColor = System.Drawing.Color.Transparent;
            this.lblPasswordText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordText.ForeColor = System.Drawing.Color.Red;
            this.lblPasswordText.Location = new System.Drawing.Point(119, 471);
            this.lblPasswordText.Name = "lblPasswordText";
            this.lblPasswordText.Size = new System.Drawing.Size(369, 48);
            this.lblPasswordText.TabIndex = 31;
            this.lblPasswordText.Text = "Username and Password Must Both Have At Least :\r\n1 Capital Letter , 1 Lower Case " +
    "Letter , 1 symbol and 1 number\r\n\r\n";
            this.lblPasswordText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSQAnswer1Valid
            // 
            this.lblSQAnswer1Valid.AutoSize = true;
            this.lblSQAnswer1Valid.BackColor = System.Drawing.Color.Transparent;
            this.lblSQAnswer1Valid.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSQAnswer1Valid.ForeColor = System.Drawing.Color.Red;
            this.lblSQAnswer1Valid.Location = new System.Drawing.Point(480, 258);
            this.lblSQAnswer1Valid.Name = "lblSQAnswer1Valid";
            this.lblSQAnswer1Valid.Size = new System.Drawing.Size(16, 16);
            this.lblSQAnswer1Valid.TabIndex = 17;
            this.lblSQAnswer1Valid.Text = "X";
            this.TTError.SetToolTip(this.lblSQAnswer1Valid, "Answer must not be empty");
            // 
            // lblAttention
            // 
            this.lblAttention.AutoSize = true;
            this.lblAttention.BackColor = System.Drawing.Color.Transparent;
            this.lblAttention.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttention.ForeColor = System.Drawing.Color.Red;
            this.lblAttention.Location = new System.Drawing.Point(174, 454);
            this.lblAttention.Name = "lblAttention";
            this.lblAttention.Size = new System.Drawing.Size(249, 16);
            this.lblAttention.TabIndex = 30;
            this.lblAttention.Text = "Security Questions Must Not Be The Same";
            // 
            // lblRetypePassword
            // 
            this.lblRetypePassword.AutoSize = true;
            this.lblRetypePassword.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetypePassword.Location = new System.Drawing.Point(75, 151);
            this.lblRetypePassword.Name = "lblRetypePassword";
            this.lblRetypePassword.Size = new System.Drawing.Size(119, 16);
            this.lblRetypePassword.TabIndex = 8;
            this.lblRetypePassword.Text = "Retype Password : ";
            // 
            // tbxRetypePassword
            // 
            this.tbxRetypePassword.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxRetypePassword.Location = new System.Drawing.Point(200, 145);
            this.tbxRetypePassword.MaxLength = 20;
            this.tbxRetypePassword.Name = "tbxRetypePassword";
            this.tbxRetypePassword.ShortcutsEnabled = false;
            this.tbxRetypePassword.Size = new System.Drawing.Size(274, 23);
            this.tbxRetypePassword.TabIndex = 9;
            this.tbxRetypePassword.UseSystemPasswordChar = true;
            this.tbxRetypePassword.TextChanged += new System.EventHandler(this.tbxRetypePassword_TextChanged);
            this.tbxRetypePassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxRetypePassword_KeyPress);
            // 
            // TTError
            // 
            this.TTError.Tag = "lblErrorUserName";
            // 
            // lblSQuestion1Valid
            // 
            this.lblSQuestion1Valid.AutoSize = true;
            this.lblSQuestion1Valid.BackColor = System.Drawing.Color.Transparent;
            this.lblSQuestion1Valid.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSQuestion1Valid.ForeColor = System.Drawing.Color.Red;
            this.lblSQuestion1Valid.Location = new System.Drawing.Point(480, 221);
            this.lblSQuestion1Valid.Name = "lblSQuestion1Valid";
            this.lblSQuestion1Valid.Size = new System.Drawing.Size(16, 16);
            this.lblSQuestion1Valid.TabIndex = 14;
            this.lblSQuestion1Valid.Text = "X";
            this.TTError.SetToolTip(this.lblSQuestion1Valid, "Security Questions Must Not Match");
            // 
            // lblSQuestion2Valid
            // 
            this.lblSQuestion2Valid.AutoSize = true;
            this.lblSQuestion2Valid.BackColor = System.Drawing.Color.Transparent;
            this.lblSQuestion2Valid.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSQuestion2Valid.ForeColor = System.Drawing.Color.Red;
            this.lblSQuestion2Valid.Location = new System.Drawing.Point(480, 296);
            this.lblSQuestion2Valid.Name = "lblSQuestion2Valid";
            this.lblSQuestion2Valid.Size = new System.Drawing.Size(16, 16);
            this.lblSQuestion2Valid.TabIndex = 20;
            this.lblSQuestion2Valid.Text = "X";
            this.TTError.SetToolTip(this.lblSQuestion2Valid, "Security Questions Must Not Match\r\n");
            // 
            // lblSAnswer2Valid
            // 
            this.lblSAnswer2Valid.AutoSize = true;
            this.lblSAnswer2Valid.BackColor = System.Drawing.Color.Transparent;
            this.lblSAnswer2Valid.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSAnswer2Valid.ForeColor = System.Drawing.Color.Red;
            this.lblSAnswer2Valid.Location = new System.Drawing.Point(480, 331);
            this.lblSAnswer2Valid.Name = "lblSAnswer2Valid";
            this.lblSAnswer2Valid.Size = new System.Drawing.Size(16, 16);
            this.lblSAnswer2Valid.TabIndex = 23;
            this.lblSAnswer2Valid.Text = "X";
            this.TTError.SetToolTip(this.lblSAnswer2Valid, "Answer must not be empty\r\n");
            // 
            // lblSQuestion3Valid
            // 
            this.lblSQuestion3Valid.AutoSize = true;
            this.lblSQuestion3Valid.BackColor = System.Drawing.Color.Transparent;
            this.lblSQuestion3Valid.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSQuestion3Valid.ForeColor = System.Drawing.Color.Red;
            this.lblSQuestion3Valid.Location = new System.Drawing.Point(480, 370);
            this.lblSQuestion3Valid.Name = "lblSQuestion3Valid";
            this.lblSQuestion3Valid.Size = new System.Drawing.Size(16, 16);
            this.lblSQuestion3Valid.TabIndex = 26;
            this.lblSQuestion3Valid.Text = "X";
            this.TTError.SetToolTip(this.lblSQuestion3Valid, "Security Questions Must Not Match\r\n");
            // 
            // lblSAnswer3Valid
            // 
            this.lblSAnswer3Valid.AutoSize = true;
            this.lblSAnswer3Valid.BackColor = System.Drawing.Color.Transparent;
            this.lblSAnswer3Valid.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSAnswer3Valid.ForeColor = System.Drawing.Color.Red;
            this.lblSAnswer3Valid.Location = new System.Drawing.Point(480, 407);
            this.lblSAnswer3Valid.Name = "lblSAnswer3Valid";
            this.lblSAnswer3Valid.Size = new System.Drawing.Size(16, 16);
            this.lblSAnswer3Valid.TabIndex = 29;
            this.lblSAnswer3Valid.Text = "X";
            this.TTError.SetToolTip(this.lblSAnswer3Valid, "Answer must not be empty\r\n");
            // 
            // lblPasswordValid
            // 
            this.lblPasswordValid.AutoSize = true;
            this.lblPasswordValid.BackColor = System.Drawing.Color.Transparent;
            this.lblPasswordValid.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordValid.ForeColor = System.Drawing.Color.Red;
            this.lblPasswordValid.Location = new System.Drawing.Point(480, 97);
            this.lblPasswordValid.Name = "lblPasswordValid";
            this.lblPasswordValid.Size = new System.Drawing.Size(16, 16);
            this.lblPasswordValid.TabIndex = 6;
            this.lblPasswordValid.Text = "X";
            this.TTError.SetToolTip(this.lblPasswordValid, "Password must be longer than 8 letters\r\n1 Capital Letter\r\n1 Lower Case Letter\r\n1 " +
        "Symbol\r\n1 Number\r\n\r\n");
            // 
            // lblRetypePasswordValid
            // 
            this.lblRetypePasswordValid.AutoSize = true;
            this.lblRetypePasswordValid.BackColor = System.Drawing.Color.Transparent;
            this.lblRetypePasswordValid.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetypePasswordValid.ForeColor = System.Drawing.Color.Red;
            this.lblRetypePasswordValid.Location = new System.Drawing.Point(480, 151);
            this.lblRetypePasswordValid.Name = "lblRetypePasswordValid";
            this.lblRetypePasswordValid.Size = new System.Drawing.Size(16, 16);
            this.lblRetypePasswordValid.TabIndex = 10;
            this.lblRetypePasswordValid.Text = "X";
            this.TTError.SetToolTip(this.lblRetypePasswordValid, "Retype Password Must Be Unique\r\n");
            // 
            // mnsHelp
            // 
            this.mnsHelp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smnHelp});
            this.mnsHelp.Location = new System.Drawing.Point(0, 0);
            this.mnsHelp.Name = "mnsHelp";
            this.mnsHelp.Size = new System.Drawing.Size(659, 24);
            this.mnsHelp.TabIndex = 0;
            this.mnsHelp.Text = "menuStrip1";
            // 
            // smnHelp
            // 
            this.smnHelp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.smnHelp.Name = "smnHelp";
            this.smnHelp.Size = new System.Drawing.Size(44, 20);
            this.smnHelp.Text = "Help";
            this.smnHelp.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // cbxPassword1
            // 
            this.cbxPassword1.AutoSize = true;
            this.cbxPassword1.Location = new System.Drawing.Point(200, 119);
            this.cbxPassword1.Name = "cbxPassword1";
            this.cbxPassword1.Size = new System.Drawing.Size(102, 17);
            this.cbxPassword1.TabIndex = 7;
            this.cbxPassword1.Text = "Show Password";
            this.cbxPassword1.UseVisualStyleBackColor = true;
            this.cbxPassword1.CheckedChanged += new System.EventHandler(this.cbxPassword1_CheckedChanged);
            // 
            // cbxPassword2
            // 
            this.cbxPassword2.AutoSize = true;
            this.cbxPassword2.Location = new System.Drawing.Point(200, 174);
            this.cbxPassword2.Name = "cbxPassword2";
            this.cbxPassword2.Size = new System.Drawing.Size(102, 17);
            this.cbxPassword2.TabIndex = 11;
            this.cbxPassword2.Text = "Show Password";
            this.cbxPassword2.UseVisualStyleBackColor = true;
            this.cbxPassword2.CheckedChanged += new System.EventHandler(this.cbxPassword2_CheckedChanged);
            // 
            // frmSecurityQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 533);
            this.Controls.Add(this.lblRetypePasswordValid);
            this.Controls.Add(this.lblPasswordValid);
            this.Controls.Add(this.lblSAnswer3Valid);
            this.Controls.Add(this.lblSQuestion3Valid);
            this.Controls.Add(this.lblSAnswer2Valid);
            this.Controls.Add(this.lblSQuestion2Valid);
            this.Controls.Add(this.lblSQuestion1Valid);
            this.Controls.Add(this.cbxPassword2);
            this.Controls.Add(this.cbxPassword1);
            this.Controls.Add(this.lblRetypePassword);
            this.Controls.Add(this.tbxRetypePassword);
            this.Controls.Add(this.lblAttention);
            this.Controls.Add(this.lblSQAnswer1Valid);
            this.Controls.Add(this.lblPasswordText);
            this.Controls.Add(this.lblUsernameValid);
            this.Controls.Add(this.lblSQuestion3);
            this.Controls.Add(this.lblSQA3);
            this.Controls.Add(this.cmbQuestion3);
            this.Controls.Add(this.tbxSQAnswer3);
            this.Controls.Add(this.lblSQ2);
            this.Controls.Add(this.lblSQAnwser2);
            this.Controls.Add(this.lblSQuestion1);
            this.Controls.Add(this.lblSQAnwser);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbSQuestion2);
            this.Controls.Add(this.cmbSQuestion1);
            this.Controls.Add(this.tbxSQAnswer2);
            this.Controls.Add(this.tbxSQAnswer1);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxUsername);
            this.Controls.Add(this.mnsHelp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnsHelp;
            this.MaximizeBox = false;
            this.Name = "frmSecurityQuestions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Security Questions";
            this.Load += new System.EventHandler(this.frmSecurityQuestions_Load);
            this.mnsHelp.ResumeLayout(false);
            this.mnsHelp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbSQuestion2;
        private System.Windows.Forms.ComboBox cmbSQuestion1;
        private System.Windows.Forms.TextBox tbxSQAnswer2;
        private System.Windows.Forms.TextBox tbxSQAnswer1;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblSQuestion1;
        private System.Windows.Forms.Label lblSQAnwser;
        private System.Windows.Forms.Label lblSQ2;
        private System.Windows.Forms.Label lblSQAnwser2;
        private System.Windows.Forms.Label lblSQuestion3;
        private System.Windows.Forms.Label lblSQA3;
        private System.Windows.Forms.ComboBox cmbQuestion3;
        private System.Windows.Forms.TextBox tbxSQAnswer3;
        private System.Windows.Forms.Label lblUsernameValid;
        private System.Windows.Forms.Label lblPasswordText;
        private System.Windows.Forms.Label lblSQAnswer1Valid;
        private System.Windows.Forms.Label lblAttention;
        private System.Windows.Forms.Label lblRetypePassword;
        private System.Windows.Forms.TextBox tbxRetypePassword;
        private System.Windows.Forms.ToolTip TTError;
        private System.Windows.Forms.MenuStrip mnsHelp;
        private System.Windows.Forms.ToolStripMenuItem smnHelp;
        private System.Windows.Forms.CheckBox cbxPassword1;
        private System.Windows.Forms.CheckBox cbxPassword2;
        private System.Windows.Forms.Label lblSQuestion1Valid;
        private System.Windows.Forms.Label lblSQuestion2Valid;
        private System.Windows.Forms.Label lblSAnswer2Valid;
        private System.Windows.Forms.Label lblSQuestion3Valid;
        private System.Windows.Forms.Label lblSAnswer3Valid;
        private System.Windows.Forms.Label lblPasswordValid;
        private System.Windows.Forms.Label lblRetypePasswordValid;
    }
}