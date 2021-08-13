
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
            this.mnsMain = new System.Windows.Forms.MenuStrip();
            this.mnsHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxUsername
            // 
            this.tbxUsername.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUsername.ForeColor = System.Drawing.Color.Black;
            this.tbxUsername.Location = new System.Drawing.Point(145, 106);
            this.tbxUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.ShortcutsEnabled = false;
            this.tbxUsername.Size = new System.Drawing.Size(143, 27);
            this.tbxUsername.TabIndex = 2;
            this.tbxUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxUsername_KeyPress);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(148, 72);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(138, 19);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Enter Username : ";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUserId
            // 
            this.lblUserId.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserId.Location = new System.Drawing.Point(116, 24);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(223, 28);
            this.lblUserId.TabIndex = 0;
            this.lblUserId.Text = "Password Recovery";
            this.lblUserId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBlackLine
            // 
            this.lblBlackLine.BackColor = System.Drawing.Color.Black;
            this.lblBlackLine.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlackLine.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBlackLine.Location = new System.Drawing.Point(-44, 52);
            this.lblBlackLine.Name = "lblBlackLine";
            this.lblBlackLine.Size = new System.Drawing.Size(550, 2);
            this.lblBlackLine.TabIndex = 31;
            this.lblBlackLine.Text = "lblBlackLine";
            this.lblBlackLine.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(145, 198);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(143, 35);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbSQ
            // 
            this.cmbSQ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSQ.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cmbSQ.Location = new System.Drawing.Point(46, 288);
            this.cmbSQ.Name = "cmbSQ";
            this.cmbSQ.Size = new System.Drawing.Size(354, 24);
            this.cmbSQ.TabIndex = 6;
            this.cmbSQ.Visible = false;
            // 
            // lblSecurityText
            // 
            this.lblSecurityText.AutoSize = true;
            this.lblSecurityText.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecurityText.Location = new System.Drawing.Point(141, 266);
            this.lblSecurityText.Name = "lblSecurityText";
            this.lblSecurityText.Size = new System.Drawing.Size(147, 19);
            this.lblSecurityText.TabIndex = 5;
            this.lblSecurityText.Text = "Security Question 1";
            this.lblSecurityText.Visible = false;
            // 
            // lblSecurityAnswer
            // 
            this.lblSecurityAnswer.AutoSize = true;
            this.lblSecurityAnswer.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecurityAnswer.Location = new System.Drawing.Point(151, 330);
            this.lblSecurityAnswer.Name = "lblSecurityAnswer";
            this.lblSecurityAnswer.Size = new System.Drawing.Size(137, 19);
            this.lblSecurityAnswer.TabIndex = 7;
            this.lblSecurityAnswer.Text = "Security Answer 1";
            this.lblSecurityAnswer.Visible = false;
            // 
            // tbxSQA
            // 
            this.tbxSQA.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSQA.Location = new System.Drawing.Point(94, 352);
            this.tbxSQA.Name = "tbxSQA";
            this.tbxSQA.ShortcutsEnabled = false;
            this.tbxSQA.Size = new System.Drawing.Size(259, 27);
            this.tbxSQA.TabIndex = 8;
            this.tbxSQA.Visible = false;
            this.tbxSQA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxSQA_KeyPress);
            // 
            // btnSSearch
            // 
            this.btnSSearch.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSSearch.Location = new System.Drawing.Point(145, 414);
            this.btnSSearch.Name = "btnSSearch";
            this.btnSSearch.Size = new System.Drawing.Size(143, 35);
            this.btnSSearch.TabIndex = 9;
            this.btnSSearch.Text = "Search";
            this.btnSSearch.UseVisualStyleBackColor = true;
            this.btnSSearch.Visible = false;
            this.btnSSearch.Click += new System.EventHandler(this.btnSSearch_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(360, 458);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(81, 33);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblPasswordValid
            // 
            this.lblPasswordValid.AutoSize = true;
            this.lblPasswordValid.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordValid.ForeColor = System.Drawing.Color.Red;
            this.lblPasswordValid.Location = new System.Drawing.Point(52, 147);
            this.lblPasswordValid.Name = "lblPasswordValid";
            this.lblPasswordValid.Size = new System.Drawing.Size(344, 38);
            this.lblPasswordValid.TabIndex = 3;
            this.lblPasswordValid.Text = "Password Must Contain at least 8 letters , \r\n1 Capital , 1 lowercase , 1 Symbols " +
    ", 1 Number";
            this.lblPasswordValid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPasswordValid.Visible = false;
            // 
            // mnsMain
            // 
            this.mnsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsHelp});
            this.mnsMain.Location = new System.Drawing.Point(0, 0);
            this.mnsMain.Name = "mnsMain";
            this.mnsMain.Size = new System.Drawing.Size(453, 24);
            this.mnsMain.TabIndex = 32;
            this.mnsMain.Text = "menuStrip1";
            // 
            // mnsHelp
            // 
            this.mnsHelp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnsHelp.Name = "mnsHelp";
            this.mnsHelp.Size = new System.Drawing.Size(44, 20);
            this.mnsHelp.Text = "Help";
            this.mnsHelp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mnsHelp.Click += new System.EventHandler(this.mnsHelp_Click);
            // 
            // frmPasswordRecovery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 512);
            this.Controls.Add(this.mnsMain);
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
            this.Text = "Password Recovery";
            this.Load += new System.EventHandler(this.frmPasswordRecovery_Load);
            this.mnsMain.ResumeLayout(false);
            this.mnsMain.PerformLayout();
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
        private System.Windows.Forms.MenuStrip mnsMain;
        private System.Windows.Forms.ToolStripMenuItem mnsHelp;
    }
}