
namespace CMPP248_Workshop
{
    partial class frmSupplierModify
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
            this.btnModify = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.supplierIdTextBox = new System.Windows.Forms.TextBox();
            this.supplierNameTextBox = new System.Windows.Forms.TextBox();
            this.Header = new System.Windows.Forms.Panel();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnModify
            // 
            this.btnModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.Location = new System.Drawing.Point(16, 156);
            this.btnModify.Margin = new System.Windows.Forms.Padding(2);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(176, 37);
            this.btnModify.TabIndex = 0;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(293, 156);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(176, 37);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Supplier ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Supplier Name:";
            // 
            // supplierIdTextBox
            // 
            this.supplierIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.supplierIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierIdTextBox.Location = new System.Drawing.Point(115, 89);
            this.supplierIdTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.supplierIdTextBox.Name = "supplierIdTextBox";
            this.supplierIdTextBox.ReadOnly = true;
            this.supplierIdTextBox.Size = new System.Drawing.Size(87, 15);
            this.supplierIdTextBox.TabIndex = 4;
            // 
            // supplierNameTextBox
            // 
            this.supplierNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierNameTextBox.Location = new System.Drawing.Point(115, 120);
            this.supplierNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.supplierNameTextBox.Name = "supplierNameTextBox";
            this.supplierNameTextBox.Size = new System.Drawing.Size(354, 22);
            this.supplierNameTextBox.TabIndex = 5;
            // 
            // Header
            // 
            this.Header.Controls.Add(this.lblDesc);
            this.Header.Controls.Add(this.lblTitle);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(480, 75);
            this.Header.TabIndex = 21;
            // 
            // lblDesc
            // 
            this.lblDesc.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(0, 51);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblDesc.Size = new System.Drawing.Size(480, 21);
            this.lblDesc.TabIndex = 20;
            this.lblDesc.Text = "Modify supplier details.";
            this.lblDesc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(0, 10, 0, 5);
            this.lblTitle.Size = new System.Drawing.Size(480, 51);
            this.lblTitle.TabIndex = 19;
            this.lblTitle.Text = "Modify Supplier Name";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmSupplierModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 208);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.supplierNameTextBox);
            this.Controls.Add(this.supplierIdTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnModify);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmSupplierModify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modify Supplier";
            this.Load += new System.EventHandler(this.frmSupplierModify_Load);
            this.Header.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox supplierIdTextBox;
        private System.Windows.Forms.TextBox supplierNameTextBox;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblTitle;
    }
}