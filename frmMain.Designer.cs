
namespace SU21_Final_Project
{
    partial class frmMain
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
            this.mnsMain = new System.Windows.Forms.MenuStrip();
            this.tsOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSignUp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsLogIn = new System.Windows.Forms.ToolStripMenuItem();
            this.addMerchandiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.securityQuestionCheclToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.mnsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsMain
            // 
            this.mnsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsOptions});
            this.mnsMain.Location = new System.Drawing.Point(0, 0);
            this.mnsMain.Name = "mnsMain";
            this.mnsMain.Size = new System.Drawing.Size(800, 24);
            this.mnsMain.TabIndex = 0;
            this.mnsMain.Text = "menuStrip1";
            // 
            // tsOptions
            // 
            this.tsOptions.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSignUp,
            this.tsLogIn,
            this.addMerchandiseToolStripMenuItem,
            this.createInvoiceToolStripMenuItem,
            this.securityQuestionCheclToolStripMenuItem});
            this.tsOptions.Name = "tsOptions";
            this.tsOptions.Size = new System.Drawing.Size(52, 20);
            this.tsOptions.Text = "Log In";
            this.tsOptions.Click += new System.EventHandler(this.logInToolStripMenuItem_Click);
            // 
            // tsSignUp
            // 
            this.tsSignUp.Name = "tsSignUp";
            this.tsSignUp.Size = new System.Drawing.Size(203, 22);
            this.tsSignUp.Text = "Sign-Up";
            this.tsSignUp.Click += new System.EventHandler(this.tsSignUp_Click);
            // 
            // tsLogIn
            // 
            this.tsLogIn.Name = "tsLogIn";
            this.tsLogIn.Size = new System.Drawing.Size(203, 22);
            this.tsLogIn.Text = "Log In";
            this.tsLogIn.Click += new System.EventHandler(this.tsLogIn_Click);
            // 
            // addMerchandiseToolStripMenuItem
            // 
            this.addMerchandiseToolStripMenuItem.Name = "addMerchandiseToolStripMenuItem";
            this.addMerchandiseToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.addMerchandiseToolStripMenuItem.Text = "Add Merchandise";
            this.addMerchandiseToolStripMenuItem.Click += new System.EventHandler(this.addMerchandiseToolStripMenuItem_Click);
            // 
            // createInvoiceToolStripMenuItem
            // 
            this.createInvoiceToolStripMenuItem.Name = "createInvoiceToolStripMenuItem";
            this.createInvoiceToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.createInvoiceToolStripMenuItem.Text = "Create Invoice";
            this.createInvoiceToolStripMenuItem.Click += new System.EventHandler(this.createInvoiceToolStripMenuItem_Click);
            // 
            // securityQuestionCheclToolStripMenuItem
            // 
            this.securityQuestionCheclToolStripMenuItem.Name = "securityQuestionCheclToolStripMenuItem";
            this.securityQuestionCheclToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.securityQuestionCheclToolStripMenuItem.Text = "Security Question Check";
            this.securityQuestionCheclToolStripMenuItem.Click += new System.EventHandler(this.securityQuestionCheclToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mnsMain);
            this.MainMenuStrip = this.mnsMain;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "2021.05.02";
            this.Text = "Sages Movie Store";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnsMain.ResumeLayout(false);
            this.mnsMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsMain;
        private System.Windows.Forms.ToolStripMenuItem tsOptions;
        private System.Windows.Forms.ToolStripMenuItem tsSignUp;
        private System.Windows.Forms.ToolStripMenuItem tsLogIn;
        private System.Windows.Forms.ToolStripMenuItem addMerchandiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createInvoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem securityQuestionCheclToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

