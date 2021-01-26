
namespace CMPP248_Workshop
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
            this.btnManagePkg = new System.Windows.Forms.Button();
            this.btnManageProdSupp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnManagePkg
            // 
            this.btnManagePkg.Location = new System.Drawing.Point(133, 217);
            this.btnManagePkg.Name = "btnManagePkg";
            this.btnManagePkg.Size = new System.Drawing.Size(171, 44);
            this.btnManagePkg.TabIndex = 0;
            this.btnManagePkg.Text = "Manage Packages";
            this.btnManagePkg.UseVisualStyleBackColor = true;
            this.btnManagePkg.Click += new System.EventHandler(this.btnManagePkg_Click);
            // 
            // btnManageProdSupp
            // 
            this.btnManageProdSupp.Location = new System.Drawing.Point(461, 217);
            this.btnManageProdSupp.Name = "btnManageProdSupp";
            this.btnManageProdSupp.Size = new System.Drawing.Size(247, 44);
            this.btnManageProdSupp.TabIndex = 1;
            this.btnManageProdSupp.Text = "Manage Product and Supplier";
            this.btnManageProdSupp.UseVisualStyleBackColor = true;
            this.btnManageProdSupp.Click += new System.EventHandler(this.btnManageProdSupp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(695, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome to Travel Experts Data Management!";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnManageProdSupp);
            this.Controls.Add(this.btnManagePkg);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnManagePkg;
        private System.Windows.Forms.Button btnManageProdSupp;
        private System.Windows.Forms.Label label1;
    }
}