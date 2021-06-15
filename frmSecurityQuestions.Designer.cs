
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
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(349, 154);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Finish";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbSQuestion2
            // 
            this.cmbSQuestion2.FormattingEnabled = true;
            this.cmbSQuestion2.Items.AddRange(new object[] {
            "What is the name of your First dog?",
            "What is the name of your first friend?",
            "What is the first country you visited?",
            "What primary school did you attend?",
            "In what town or city did your parents meet?"});
            this.cmbSQuestion2.Location = new System.Drawing.Point(181, 209);
            this.cmbSQuestion2.Name = "cmbSQuestion2";
            this.cmbSQuestion2.Size = new System.Drawing.Size(121, 21);
            this.cmbSQuestion2.TabIndex = 13;
            // 
            // cmbSQuestion1
            // 
            this.cmbSQuestion1.FormattingEnabled = true;
            this.cmbSQuestion1.Items.AddRange(new object[] {
            "What is the name of your First dog?",
            "What is the name of your first friend?",
            "What is the first country you visited?",
            "What primary school did you attend?",
            "In what town or city did your parents meet?"});
            this.cmbSQuestion1.Location = new System.Drawing.Point(181, 136);
            this.cmbSQuestion1.Name = "cmbSQuestion1";
            this.cmbSQuestion1.Size = new System.Drawing.Size(121, 21);
            this.cmbSQuestion1.TabIndex = 12;
            // 
            // tbxSQAnswer2
            // 
            this.tbxSQAnswer2.Location = new System.Drawing.Point(181, 246);
            this.tbxSQAnswer2.Name = "tbxSQAnswer2";
            this.tbxSQAnswer2.Size = new System.Drawing.Size(100, 20);
            this.tbxSQAnswer2.TabIndex = 11;
            // 
            // tbxSQAnswer1
            // 
            this.tbxSQAnswer1.Location = new System.Drawing.Point(181, 173);
            this.tbxSQAnswer1.Name = "tbxSQAnswer1";
            this.tbxSQAnswer1.Size = new System.Drawing.Size(100, 20);
            this.tbxSQAnswer1.TabIndex = 10;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(181, 98);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(100, 20);
            this.tbxPassword.TabIndex = 9;
            // 
            // tbxUsername
            // 
            this.tbxUsername.Location = new System.Drawing.Point(181, 54);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(100, 20);
            this.tbxUsername.TabIndex = 8;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(109, 57);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(64, 13);
            this.lblUsername.TabIndex = 15;
            this.lblUsername.Text = "Username : ";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(111, 105);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(62, 13);
            this.lblPassword.TabIndex = 16;
            this.lblPassword.Text = "Password : ";
            // 
            // lblSQuestion1
            // 
            this.lblSQuestion1.AutoSize = true;
            this.lblSQuestion1.Location = new System.Drawing.Point(68, 139);
            this.lblSQuestion1.Name = "lblSQuestion1";
            this.lblSQuestion1.Size = new System.Drawing.Size(105, 13);
            this.lblSQuestion1.TabIndex = 18;
            this.lblSQuestion1.Text = "Security Question 1 :";
            // 
            // lblSQAnwser
            // 
            this.lblSQAnwser.AutoSize = true;
            this.lblSQAnwser.Location = new System.Drawing.Point(52, 173);
            this.lblSQAnwser.Name = "lblSQAnwser";
            this.lblSQAnwser.Size = new System.Drawing.Size(121, 13);
            this.lblSQAnwser.TabIndex = 17;
            this.lblSQAnwser.Text = "Answer To Question 1 : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Security Question 2 :";
            // 
            // lblSQAnwser2
            // 
            this.lblSQAnwser2.AutoSize = true;
            this.lblSQAnwser2.Location = new System.Drawing.Point(52, 246);
            this.lblSQAnwser2.Name = "lblSQAnwser2";
            this.lblSQAnwser2.Size = new System.Drawing.Size(121, 13);
            this.lblSQAnwser2.TabIndex = 19;
            this.lblSQAnwser2.Text = "Answer To Question 2 : ";
            // 
            // frmSecurityQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 350);
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
            this.Text = "frmSecurityQuestions";
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
    }
}