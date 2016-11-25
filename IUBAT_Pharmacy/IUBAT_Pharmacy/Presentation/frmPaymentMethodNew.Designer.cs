namespace IUBAT_Pharmacy.Presentation
{
    partial class frmPaymentMethodNew
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
            this.TxtName = new IUBAT_Pharmacy.Presentation.MyControls.ucText();
            this.txtCompany = new IUBAT_Pharmacy.Presentation.MyControls.ucText();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(201, 206);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(13, 206);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // TxtName
            // 
            this.TxtName.AutoSize = true;
            this.TxtName.Location = new System.Drawing.Point(13, 32);
            this.TxtName.MinimumSize = new System.Drawing.Size(200, 35);
            this.TxtName.MultiLine = false;
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(263, 35);
            this.TxtName.TabIndex = 2;
            this.TxtName.txtDoubleValue = 0D;
            this.TxtName.txtFloatValue = 0F;
            this.TxtName.txtIntValue = 0;
            this.TxtName.txtRequired = true;
            this.TxtName.txtTextLabel = "Name";
            this.TxtName.txtTextValue = "";
            this.TxtName.TxtType = TextType.Text;
            // 
            // txtCompany
            // 
            this.txtCompany.AutoSize = true;
            this.txtCompany.Location = new System.Drawing.Point(12, 73);
            this.txtCompany.MinimumSize = new System.Drawing.Size(200, 35);
            this.txtCompany.MultiLine = false;
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(264, 35);
            this.txtCompany.TabIndex = 3;
            this.txtCompany.txtDoubleValue = 0D;
            this.txtCompany.txtFloatValue = 0F;
            this.txtCompany.txtIntValue = 0;
            this.txtCompany.txtRequired = false;
            this.txtCompany.txtTextLabel = "Company";
            this.txtCompany.txtTextValue = "";
            this.txtCompany.TxtType = TextType.Text;
            // 
            // frmPaymentMethodNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(288, 241);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.TxtName);
            this.Name = "frmPaymentMethodNew";
            this.Text = "New Payment Method";
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnExit, 0);
            this.Controls.SetChildIndex(this.TxtName, 0);
            this.Controls.SetChildIndex(this.txtCompany, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyControls.ucText TxtName;
        private MyControls.ucText txtCompany;
    }
}
