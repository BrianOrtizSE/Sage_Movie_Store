
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
            this.label5 = new System.Windows.Forms.Label();
            this.lblSQAnwser2 = new System.Windows.Forms.Label();
            this.lblSQuestion3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbQuestion3 = new System.Windows.Forms.ComboBox();
            this.tbxSQAnswer3 = new System.Windows.Forms.TextBox();
            this.lblErrorUserName = new System.Windows.Forms.Label();
            this.lblPasswordText = new System.Windows.Forms.Label();
            this.lblErrorSQA1 = new System.Windows.Forms.Label();
            this.lblErrorSQA3 = new System.Windows.Forms.Label();
            this.lblErrorSQA2 = new System.Windows.Forms.Label();
            this.lblAttention = new System.Windows.Forms.Label();
            this.lblErrorPassword = new System.Windows.Forms.Label();
            this.lblErrorRetype = new System.Windows.Forms.Label();
            this.lblRetypePassword = new System.Windows.Forms.Label();
            this.tbxRetypePassword = new System.Windows.Forms.TextBox();
            this.TTError = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(517, 200);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "&Finish";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbSQuestion2
            // 
            this.cmbSQuestion2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSQuestion2.DropDownWidth = 300;
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
            this.cmbSQuestion2.Location = new System.Drawing.Point(192, 238);
            this.cmbSQuestion2.Name = "cmbSQuestion2";
            this.cmbSQuestion2.Size = new System.Drawing.Size(235, 21);
            this.cmbSQuestion2.TabIndex = 13;
            // 
            // cmbSQuestion1
            // 
            this.cmbSQuestion1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSQuestion1.DropDownWidth = 300;
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
            this.cmbSQuestion1.Location = new System.Drawing.Point(192, 165);
            this.cmbSQuestion1.Name = "cmbSQuestion1";
            this.cmbSQuestion1.Size = new System.Drawing.Size(235, 21);
            this.cmbSQuestion1.TabIndex = 12;
            // 
            // tbxSQAnswer2
            // 
            this.tbxSQAnswer2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSQAnswer2.Location = new System.Drawing.Point(192, 275);
            this.tbxSQAnswer2.Name = "tbxSQAnswer2";
            this.tbxSQAnswer2.Size = new System.Drawing.Size(233, 24);
            this.tbxSQAnswer2.TabIndex = 11;
            // 
            // tbxSQAnswer1
            // 
            this.tbxSQAnswer1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSQAnswer1.Location = new System.Drawing.Point(192, 202);
            this.tbxSQAnswer1.Name = "tbxSQAnswer1";
            this.tbxSQAnswer1.Size = new System.Drawing.Size(233, 24);
            this.tbxSQAnswer1.TabIndex = 10;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPassword.Location = new System.Drawing.Point(192, 82);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '*';
            this.tbxPassword.Size = new System.Drawing.Size(233, 24);
            this.tbxPassword.TabIndex = 9;
            this.tbxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPassword_KeyPress);
            // 
            // tbxUsername
            // 
            this.tbxUsername.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUsername.Location = new System.Drawing.Point(192, 45);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(233, 24);
            this.tbxUsername.TabIndex = 8;
            this.tbxUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxUsername_KeyPress);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(106, 53);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(78, 16);
            this.lblUsername.TabIndex = 15;
            this.lblUsername.Text = "Username : ";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(109, 94);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(75, 16);
            this.lblPassword.TabIndex = 16;
            this.lblPassword.Text = "Password : ";
            // 
            // lblSQuestion1
            // 
            this.lblSQuestion1.AutoSize = true;
            this.lblSQuestion1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSQuestion1.Location = new System.Drawing.Point(57, 173);
            this.lblSQuestion1.Name = "lblSQuestion1";
            this.lblSQuestion1.Size = new System.Drawing.Size(127, 16);
            this.lblSQuestion1.TabIndex = 18;
            this.lblSQuestion1.Text = "Security Question 1 :";
            // 
            // lblSQAnwser
            // 
            this.lblSQAnwser.AutoSize = true;
            this.lblSQAnwser.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSQAnwser.Location = new System.Drawing.Point(37, 207);
            this.lblSQAnwser.Name = "lblSQAnwser";
            this.lblSQAnwser.Size = new System.Drawing.Size(147, 16);
            this.lblSQAnwser.TabIndex = 17;
            this.lblSQAnwser.Text = "Answer To Question 1 : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Security Question 2 :";
            // 
            // lblSQAnwser2
            // 
            this.lblSQAnwser2.AutoSize = true;
            this.lblSQAnwser2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSQAnwser2.Location = new System.Drawing.Point(37, 280);
            this.lblSQAnwser2.Name = "lblSQAnwser2";
            this.lblSQAnwser2.Size = new System.Drawing.Size(147, 16);
            this.lblSQAnwser2.TabIndex = 19;
            this.lblSQAnwser2.Text = "Answer To Question 2 : ";
            // 
            // lblSQuestion3
            // 
            this.lblSQuestion3.AutoSize = true;
            this.lblSQuestion3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSQuestion3.Location = new System.Drawing.Point(57, 319);
            this.lblSQuestion3.Name = "lblSQuestion3";
            this.lblSQuestion3.Size = new System.Drawing.Size(127, 16);
            this.lblSQuestion3.TabIndex = 24;
            this.lblSQuestion3.Text = "Security Question 3 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Answer To Question 3 : ";
            // 
            // cmbQuestion3
            // 
            this.cmbQuestion3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuestion3.DropDownWidth = 300;
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
            this.cmbQuestion3.Location = new System.Drawing.Point(190, 314);
            this.cmbQuestion3.Name = "cmbQuestion3";
            this.cmbQuestion3.Size = new System.Drawing.Size(235, 21);
            this.cmbQuestion3.TabIndex = 22;
            // 
            // tbxSQAnswer3
            // 
            this.tbxSQAnswer3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSQAnswer3.Location = new System.Drawing.Point(192, 351);
            this.tbxSQAnswer3.Name = "tbxSQAnswer3";
            this.tbxSQAnswer3.Size = new System.Drawing.Size(233, 24);
            this.tbxSQAnswer3.TabIndex = 21;
            // 
            // lblErrorUserName
            // 
            this.lblErrorUserName.AutoSize = true;
            this.lblErrorUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorUserName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorUserName.ForeColor = System.Drawing.Color.Red;
            this.lblErrorUserName.Location = new System.Drawing.Point(441, 49);
            this.lblErrorUserName.Name = "lblErrorUserName";
            this.lblErrorUserName.Size = new System.Drawing.Size(45, 16);
            this.lblErrorUserName.TabIndex = 63;
            this.lblErrorUserName.Text = "*Error";
            this.TTError.SetToolTip(this.lblErrorUserName, "Username must not be under 6 letters\r\nUsername most not be greater than 20 letter" +
        "s");
            this.lblErrorUserName.Visible = false;
            // 
            // lblPasswordText
            // 
            this.lblPasswordText.AutoSize = true;
            this.lblPasswordText.BackColor = System.Drawing.Color.Transparent;
            this.lblPasswordText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordText.ForeColor = System.Drawing.Color.Red;
            this.lblPasswordText.Location = new System.Drawing.Point(77, 457);
            this.lblPasswordText.Name = "lblPasswordText";
            this.lblPasswordText.Size = new System.Drawing.Size(503, 16);
            this.lblPasswordText.TabIndex = 64;
            this.lblPasswordText.Text = "Password Must Have 1 Capital Letter , 1 Lower Case Letter , 2 symbols and 2 numbe" +
    "rs";
            // 
            // lblErrorSQA1
            // 
            this.lblErrorSQA1.AutoSize = true;
            this.lblErrorSQA1.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorSQA1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorSQA1.ForeColor = System.Drawing.Color.Red;
            this.lblErrorSQA1.Location = new System.Drawing.Point(441, 206);
            this.lblErrorSQA1.Name = "lblErrorSQA1";
            this.lblErrorSQA1.Size = new System.Drawing.Size(45, 16);
            this.lblErrorSQA1.TabIndex = 66;
            this.lblErrorSQA1.Text = "*Error";
            this.TTError.SetToolTip(this.lblErrorSQA1, "Security Answer Must Be Less Than 50 Letters");
            this.lblErrorSQA1.Visible = false;
            // 
            // lblErrorSQA3
            // 
            this.lblErrorSQA3.AutoSize = true;
            this.lblErrorSQA3.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorSQA3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorSQA3.ForeColor = System.Drawing.Color.Red;
            this.lblErrorSQA3.Location = new System.Drawing.Point(441, 353);
            this.lblErrorSQA3.Name = "lblErrorSQA3";
            this.lblErrorSQA3.Size = new System.Drawing.Size(45, 16);
            this.lblErrorSQA3.TabIndex = 70;
            this.lblErrorSQA3.Text = "*Error";
            this.TTError.SetToolTip(this.lblErrorSQA3, "Security Answer Must Be Less Than 50 Letters");
            this.lblErrorSQA3.Visible = false;
            // 
            // lblErrorSQA2
            // 
            this.lblErrorSQA2.AutoSize = true;
            this.lblErrorSQA2.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorSQA2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorSQA2.ForeColor = System.Drawing.Color.Red;
            this.lblErrorSQA2.Location = new System.Drawing.Point(441, 279);
            this.lblErrorSQA2.Name = "lblErrorSQA2";
            this.lblErrorSQA2.Size = new System.Drawing.Size(45, 16);
            this.lblErrorSQA2.TabIndex = 68;
            this.lblErrorSQA2.Text = "*Error";
            this.TTError.SetToolTip(this.lblErrorSQA2, "Security Answer Must Be Less Than 50 Letters");
            this.lblErrorSQA2.Visible = false;
            // 
            // lblAttention
            // 
            this.lblAttention.AutoSize = true;
            this.lblAttention.BackColor = System.Drawing.Color.Transparent;
            this.lblAttention.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttention.ForeColor = System.Drawing.Color.Red;
            this.lblAttention.Location = new System.Drawing.Point(204, 431);
            this.lblAttention.Name = "lblAttention";
            this.lblAttention.Size = new System.Drawing.Size(249, 16);
            this.lblAttention.TabIndex = 71;
            this.lblAttention.Text = "Security Questions Must Not Be The Same";
            // 
            // lblErrorPassword
            // 
            this.lblErrorPassword.AutoSize = true;
            this.lblErrorPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorPassword.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorPassword.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPassword.Location = new System.Drawing.Point(441, 90);
            this.lblErrorPassword.Name = "lblErrorPassword";
            this.lblErrorPassword.Size = new System.Drawing.Size(45, 16);
            this.lblErrorPassword.TabIndex = 72;
            this.lblErrorPassword.Text = "*Error";
            this.TTError.SetToolTip(this.lblErrorPassword, "Password Must Have 1 Capital Letter\r\nPassword Must Have 1 Lower Case Letter\r\nPass" +
        "word Must Have 2 Numbers\r\nPassword Must Have 2 Symbols");
            this.lblErrorPassword.Visible = false;
            // 
            // lblErrorRetype
            // 
            this.lblErrorRetype.AutoSize = true;
            this.lblErrorRetype.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorRetype.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorRetype.ForeColor = System.Drawing.Color.Red;
            this.lblErrorRetype.Location = new System.Drawing.Point(441, 131);
            this.lblErrorRetype.Name = "lblErrorRetype";
            this.lblErrorRetype.Size = new System.Drawing.Size(45, 16);
            this.lblErrorRetype.TabIndex = 75;
            this.lblErrorRetype.Text = "*Error";
            this.TTError.SetToolTip(this.lblErrorRetype, "Password\'s Must Match");
            this.lblErrorRetype.Visible = false;
            // 
            // lblRetypePassword
            // 
            this.lblRetypePassword.AutoSize = true;
            this.lblRetypePassword.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetypePassword.Location = new System.Drawing.Point(65, 129);
            this.lblRetypePassword.Name = "lblRetypePassword";
            this.lblRetypePassword.Size = new System.Drawing.Size(119, 16);
            this.lblRetypePassword.TabIndex = 74;
            this.lblRetypePassword.Text = "Retype Password : ";
            // 
            // tbxRetypePassword
            // 
            this.tbxRetypePassword.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxRetypePassword.Location = new System.Drawing.Point(190, 123);
            this.tbxRetypePassword.Name = "tbxRetypePassword";
            this.tbxRetypePassword.PasswordChar = '*';
            this.tbxRetypePassword.Size = new System.Drawing.Size(235, 24);
            this.tbxRetypePassword.TabIndex = 73;
            // 
            // TTError
            // 
            this.TTError.Tag = "lblErrorUserName";
            // 
            // frmSecurityQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 533);
            this.ControlBox = false;
            this.Controls.Add(this.lblErrorRetype);
            this.Controls.Add(this.lblRetypePassword);
            this.Controls.Add(this.tbxRetypePassword);
            this.Controls.Add(this.lblErrorPassword);
            this.Controls.Add(this.lblAttention);
            this.Controls.Add(this.lblErrorSQA3);
            this.Controls.Add(this.lblErrorSQA2);
            this.Controls.Add(this.lblErrorSQA1);
            this.Controls.Add(this.lblPasswordText);
            this.Controls.Add(this.lblErrorUserName);
            this.Controls.Add(this.lblSQuestion3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbQuestion3);
            this.Controls.Add(this.tbxSQAnswer3);
            this.Controls.Add(this.label5);
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
            this.Name = "frmSecurityQuestions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Security Questions";
            this.Load += new System.EventHandler(this.frmSecurityQuestions_Load);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSQAnwser2;
        private System.Windows.Forms.Label lblSQuestion3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbQuestion3;
        private System.Windows.Forms.TextBox tbxSQAnswer3;
        private System.Windows.Forms.Label lblErrorUserName;
        private System.Windows.Forms.Label lblPasswordText;
        private System.Windows.Forms.Label lblErrorSQA1;
        private System.Windows.Forms.Label lblErrorSQA3;
        private System.Windows.Forms.Label lblErrorSQA2;
        private System.Windows.Forms.Label lblAttention;
        private System.Windows.Forms.Label lblErrorPassword;
        private System.Windows.Forms.Label lblErrorRetype;
        private System.Windows.Forms.Label lblRetypePassword;
        private System.Windows.Forms.TextBox tbxRetypePassword;
        private System.Windows.Forms.ToolTip TTError;
    }
}