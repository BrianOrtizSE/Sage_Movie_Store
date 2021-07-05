
namespace SU21_Final_Project
{
    partial class frmLogIn
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
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.rdbCustomer = new System.Windows.Forms.RadioButton();
            this.rdbEmployee = new System.Windows.Forms.RadioButton();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblUSernameText = new System.Windows.Forms.Label();
            this.lblPasswordText = new System.Windows.Forms.Label();
            this.lblErrorText = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxUsername
            // 
            this.tbxUsername.Location = new System.Drawing.Point(165, 168);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(142, 20);
            this.tbxUsername.TabIndex = 0;
            this.tbxUsername.TextChanged += new System.EventHandler(this.tbxUsername_TextChanged);
            this.tbxUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxUsername_KeyPress);
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(165, 226);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(142, 20);
            this.tbxPassword.TabIndex = 1;
            this.tbxPassword.UseSystemPasswordChar = true;
            // 
            // rdbCustomer
            // 
            this.rdbCustomer.AutoSize = true;
            this.rdbCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCustomer.Location = new System.Drawing.Point(74, 103);
            this.rdbCustomer.Name = "rdbCustomer";
            this.rdbCustomer.Size = new System.Drawing.Size(112, 19);
            this.rdbCustomer.TabIndex = 2;
            this.rdbCustomer.TabStop = true;
            this.rdbCustomer.Text = "Customer Login";
            this.rdbCustomer.UseVisualStyleBackColor = true;
            this.rdbCustomer.CheckedChanged += new System.EventHandler(this.rdCustomer_CheckedChanged);
            // 
            // rdbEmployee
            // 
            this.rdbEmployee.AutoSize = true;
            this.rdbEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEmployee.Location = new System.Drawing.Point(262, 103);
            this.rdbEmployee.Name = "rdbEmployee";
            this.rdbEmployee.Size = new System.Drawing.Size(114, 19);
            this.rdbEmployee.TabIndex = 3;
            this.rdbEmployee.TabStop = true;
            this.rdbEmployee.Text = "Employee Login";
            this.rdbEmployee.UseVisualStyleBackColor = true;
            this.rdbEmployee.CheckedChanged += new System.EventHandler(this.rdEmployee_CheckedChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(136, 282);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(88, 28);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "&Log In";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblUSernameText
            // 
            this.lblUSernameText.AutoSize = true;
            this.lblUSernameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUSernameText.Location = new System.Drawing.Point(71, 168);
            this.lblUSernameText.Name = "lblUSernameText";
            this.lblUSernameText.Size = new System.Drawing.Size(74, 15);
            this.lblUSernameText.TabIndex = 5;
            this.lblUSernameText.Text = "Username : ";
            // 
            // lblPasswordText
            // 
            this.lblPasswordText.AutoSize = true;
            this.lblPasswordText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordText.Location = new System.Drawing.Point(71, 226);
            this.lblPasswordText.Name = "lblPasswordText";
            this.lblPasswordText.Size = new System.Drawing.Size(70, 15);
            this.lblPasswordText.TabIndex = 6;
            this.lblPasswordText.Text = "Password : ";
            // 
            // lblErrorText
            // 
            this.lblErrorText.AutoSize = true;
            this.lblErrorText.ForeColor = System.Drawing.Color.Red;
            this.lblErrorText.Location = new System.Drawing.Point(84, 56);
            this.lblErrorText.Name = "lblErrorText";
            this.lblErrorText.Size = new System.Drawing.Size(267, 13);
            this.lblErrorText.TabIndex = 7;
            this.lblErrorText.Text = "ERROR : USERNAME OR PASSWORD INCORRECT";
            this.lblErrorText.Visible = false;
            // 
            // lblClose
            // 
            this.lblClose.Location = new System.Drawing.Point(230, 282);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(88, 28);
            this.lblClose.TabIndex = 8;
            this.lblClose.Text = "&Return";
            this.lblClose.UseVisualStyleBackColor = true;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // frmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 379);
            this.ControlBox = false;
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.lblErrorText);
            this.Controls.Add(this.lblPasswordText);
            this.Controls.Add(this.lblUSernameText);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.rdbEmployee);
            this.Controls.Add(this.rdbCustomer);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxUsername);
            this.Name = "frmLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Log In Form";
            this.Load += new System.EventHandler(this.frmLogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.RadioButton rdbCustomer;
        private System.Windows.Forms.RadioButton rdbEmployee;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblUSernameText;
        private System.Windows.Forms.Label lblPasswordText;
        private System.Windows.Forms.Label lblErrorText;
        private System.Windows.Forms.Button lblClose;
    }
}