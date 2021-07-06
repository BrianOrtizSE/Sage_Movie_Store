
namespace SU21_Final_Project
{
    partial class frmPasswordRecovery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPasswordRecovery));
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblUserId = new System.Windows.Forms.Label();
            this.lblBlackLine = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbSQ = new System.Windows.Forms.ComboBox();
            this.lblSecurityText = new System.Windows.Forms.Label();
            this.lblSecurityAnswer = new System.Windows.Forms.Label();
            this.tbxSQA = new System.Windows.Forms.TextBox();
            this.btnSSearch = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblPasswordValid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxUsername
            // 
            this.tbxUsername.ForeColor = System.Drawing.Color.Red;
            this.tbxUsername.Location = new System.Drawing.Point(109, 109);
            this.tbxUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(143, 23);
            this.tbxUsername.TabIndex = 0;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(126, 78);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(113, 16);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Enter Username : ";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUserId
            // 
            this.lblUserId.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserId.Location = new System.Drawing.Point(65, 11);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(223, 28);
            this.lblUserId.TabIndex = 32;
            this.lblUserId.Text = "Password Recovery";
            this.lblUserId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBlackLine
            // 
            this.lblBlackLine.BackColor = System.Drawing.Color.Black;
            this.lblBlackLine.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlackLine.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBlackLine.Location = new System.Drawing.Point(-2, 48);
            this.lblBlackLine.Name = "lblBlackLine";
            this.lblBlackLine.Size = new System.Drawing.Size(405, 2);
            this.lblBlackLine.TabIndex = 31;
            this.lblBlackLine.Text = "lblBlackLine";
            this.lblBlackLine.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(145, 171);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 33;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbSQ
            // 
            this.cmbSQ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSQ.FormattingEnabled = true;
            this.cmbSQ.Items.AddRange(new object[] {
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
            this.cmbSQ.Location = new System.Drawing.Point(12, 252);
            this.cmbSQ.Name = "cmbSQ";
            this.cmbSQ.Size = new System.Drawing.Size(354, 24);
            this.cmbSQ.TabIndex = 34;
            this.cmbSQ.Visible = false;
            // 
            // lblSecurityText
            // 
            this.lblSecurityText.AutoSize = true;
            this.lblSecurityText.Location = new System.Drawing.Point(133, 222);
            this.lblSecurityText.Name = "lblSecurityText";
            this.lblSecurityText.Size = new System.Drawing.Size(119, 16);
            this.lblSecurityText.TabIndex = 35;
            this.lblSecurityText.Text = "Security Question 1";
            this.lblSecurityText.Visible = false;
            // 
            // lblSecurityAnswer
            // 
            this.lblSecurityAnswer.AutoSize = true;
            this.lblSecurityAnswer.Location = new System.Drawing.Point(129, 297);
            this.lblSecurityAnswer.Name = "lblSecurityAnswer";
            this.lblSecurityAnswer.Size = new System.Drawing.Size(112, 16);
            this.lblSecurityAnswer.TabIndex = 36;
            this.lblSecurityAnswer.Text = "Security Answer 1";
            this.lblSecurityAnswer.Visible = false;
            // 
            // tbxSQA
            // 
            this.tbxSQA.Location = new System.Drawing.Point(59, 316);
            this.tbxSQA.Name = "tbxSQA";
            this.tbxSQA.Size = new System.Drawing.Size(259, 23);
            this.tbxSQA.TabIndex = 37;
            this.tbxSQA.Visible = false;
            // 
            // btnSSearch
            // 
            this.btnSSearch.Location = new System.Drawing.Point(145, 365);
            this.btnSSearch.Name = "btnSSearch";
            this.btnSSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSSearch.TabIndex = 38;
            this.btnSSearch.Text = "Search";
            this.btnSSearch.UseVisualStyleBackColor = true;
            this.btnSSearch.Visible = false;
            this.btnSSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(291, 413);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 39;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblPasswordValid
            // 
            this.lblPasswordValid.AutoSize = true;
            this.lblPasswordValid.ForeColor = System.Drawing.Color.Red;
            this.lblPasswordValid.Location = new System.Drawing.Point(56, 136);
            this.lblPasswordValid.Name = "lblPasswordValid";
            this.lblPasswordValid.Size = new System.Drawing.Size(278, 32);
            this.lblPasswordValid.TabIndex = 40;
            this.lblPasswordValid.Text = "Password Must Contain at least 8 letters , \r\n1 Capital , 1 lowercase , 2 Symbols " +
    ", 1 Number";
            this.lblPasswordValid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPasswordValid.Visible = false;
            // 
            // frmPasswordRecovery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 448);
            this.Controls.Add(this.lblPasswordValid);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSSearch);
            this.Controls.Add(this.tbxSQA);
            this.Controls.Add(this.lblSecurityAnswer);
            this.Controls.Add(this.lblSecurityText);
            this.Controls.Add(this.cmbSQ);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.lblBlackLine);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.tbxUsername);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmPasswordRecovery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmPasswordRecovery";
            this.Load += new System.EventHandler(this.frmPasswordRecovery_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Label lblBlackLine;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbSQ;
        private System.Windows.Forms.Label lblSecurityText;
        private System.Windows.Forms.Label lblSecurityAnswer;
        private System.Windows.Forms.TextBox tbxSQA;
        private System.Windows.Forms.Button btnSSearch;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblPasswordValid;
    }
}