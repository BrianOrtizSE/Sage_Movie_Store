
namespace SU21_Final_Project
{
    partial class frmMerhandiseView
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
            this.lblProductID = new System.Windows.Forms.Label();
            this.tbxProductID = new System.Windows.Forms.TextBox();
            this.dgvView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(74, 51);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(86, 13);
            this.lblProductID.TabIndex = 5;
            this.lblProductID.Text = "Enter Product ID";
            // 
            // tbxProductID
            // 
            this.tbxProductID.Location = new System.Drawing.Point(77, 77);
            this.tbxProductID.Name = "tbxProductID";
            this.tbxProductID.Size = new System.Drawing.Size(100, 20);
            this.tbxProductID.TabIndex = 4;
            // 
            // dgvView
            // 
            this.dgvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvView.Location = new System.Drawing.Point(301, 39);
            this.dgvView.Name = "dgvView";
            this.dgvView.Size = new System.Drawing.Size(425, 373);
            this.dgvView.TabIndex = 3;
            // 
            // frmProductView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblProductID);
            this.Controls.Add(this.tbxProductID);
            this.Controls.Add(this.dgvView);
            this.Name = "frmProductView";
            this.Text = "frmProductView";
            this.Load += new System.EventHandler(this.frmProductView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.TextBox tbxProductID;
        private System.Windows.Forms.DataGridView dgvView;
    }
}