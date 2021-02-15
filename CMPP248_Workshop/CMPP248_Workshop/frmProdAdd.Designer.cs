
namespace CMPP248_Workshop
{
    partial class frmProdAdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.prodNameTextBox = new System.Windows.Forms.TextBox();
            this.btnSubmitProd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name";
            // 
            // prodNameTextBox
            // 
            this.prodNameTextBox.Location = new System.Drawing.Point(179, 143);
            this.prodNameTextBox.Name = "prodNameTextBox";
            this.prodNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.prodNameTextBox.TabIndex = 1;
            // 
            // btnSubmitProd
            // 
            this.btnSubmitProd.Location = new System.Drawing.Point(179, 208);
            this.btnSubmitProd.Name = "btnSubmitProd";
            this.btnSubmitProd.Size = new System.Drawing.Size(75, 35);
            this.btnSubmitProd.TabIndex = 2;
            this.btnSubmitProd.Text = "Submit";
            this.btnSubmitProd.UseVisualStyleBackColor = true;
            this.btnSubmitProd.Click += new System.EventHandler(this.btnSubmitProd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(300, 208);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 35);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmProdAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSubmitProd);
            this.Controls.Add(this.prodNameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "frmProdAdd";
            this.Text = "frmProdAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox prodNameTextBox;
        private System.Windows.Forms.Button btnSubmitProd;
        private System.Windows.Forms.Button btnClose;
    }
}