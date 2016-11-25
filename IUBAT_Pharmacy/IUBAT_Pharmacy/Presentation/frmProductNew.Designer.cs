namespace IUBAT_Pharmacy.Presentation
{
    partial class frmProductNew
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
            this.txtName = new IUBAT_Pharmacy.Presentation.MyControls.ucText();
            this.txtCode = new IUBAT_Pharmacy.Presentation.MyControls.ucText();
            this.cmbPowerId = new IUBAT_Pharmacy.Presentation.MyControls.ucCombo();
            this.cmbCompanyId = new IUBAT_Pharmacy.Presentation.MyControls.ucCombo();
            this.cmbCategoryId = new IUBAT_Pharmacy.Presentation.MyControls.ucCombo();
            this.cmbUnitId = new IUBAT_Pharmacy.Presentation.MyControls.ucCombo();
            this.cmbDiscountId = new IUBAT_Pharmacy.Presentation.MyControls.ucCombo();
            this.cmbSaleStatusId = new IUBAT_Pharmacy.Presentation.MyControls.ucCombo();
            this.txtListPrice = new IUBAT_Pharmacy.Presentation.MyControls.ucText();
            this.txtVat = new IUBAT_Pharmacy.Presentation.MyControls.ucText();
            this.txtRemarks = new IUBAT_Pharmacy.Presentation.MyControls.ucText();
            this.cmbGroupId = new IUBAT_Pharmacy.Presentation.MyControls.ucCombo();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(265, 562);
            this.btnExit.TabIndex = 13;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 562);
            this.btnSave.TabIndex = 12;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.AutoSize = true;
            this.txtName.Location = new System.Drawing.Point(13, 0);
            this.txtName.MinimumSize = new System.Drawing.Size(200, 35);
            this.txtName.MultiLine = false;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(327, 35);
            this.txtName.TabIndex = 0;
            this.txtName.txtDoubleValue = 0D;
            this.txtName.txtFloatValue = 0F;
            this.txtName.txtIntValue = 0;
            this.txtName.txtRequired = true;
            this.txtName.txtTextLabel = "Product Name";
            this.txtName.txtTextValue = "";
            this.txtName.TxtType = TextType.Text;
            // 
            // txtCode
            // 
            this.txtCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCode.AutoSize = true;
            this.txtCode.Location = new System.Drawing.Point(13, 41);
            this.txtCode.MinimumSize = new System.Drawing.Size(200, 35);
            this.txtCode.MultiLine = false;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(327, 35);
            this.txtCode.TabIndex = 1;
            this.txtCode.txtDoubleValue = 0D;
            this.txtCode.txtFloatValue = 0F;
            this.txtCode.txtIntValue = 0;
            this.txtCode.txtRequired = true;
            this.txtCode.txtTextLabel = "Code";
            this.txtCode.txtTextValue = "";
            this.txtCode.TxtType = TextType.Text;
            // 
            // cmbPowerId
            // 
            this.cmbPowerId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPowerId.AutoSize = true;
            this.cmbPowerId.Location = new System.Drawing.Point(12, 137);
            this.cmbPowerId.MinimumSize = new System.Drawing.Size(200, 35);
            this.cmbPowerId.Name = "cmbPowerId";
            this.cmbPowerId.Size = new System.Drawing.Size(327, 35);
            this.cmbPowerId.TabIndex = 3;
            this.cmbPowerId.txtRequired = false;
            this.cmbPowerId.txtTextLabel = "Power";
            this.cmbPowerId.txtTextValueInt = 0;
            // 
            // cmbCompanyId
            // 
            this.cmbCompanyId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCompanyId.AutoSize = true;
            this.cmbCompanyId.Location = new System.Drawing.Point(12, 178);
            this.cmbCompanyId.MinimumSize = new System.Drawing.Size(200, 35);
            this.cmbCompanyId.Name = "cmbCompanyId";
            this.cmbCompanyId.Size = new System.Drawing.Size(327, 35);
            this.cmbCompanyId.TabIndex = 4;
            this.cmbCompanyId.txtRequired = true;
            this.cmbCompanyId.txtTextLabel = "Company";
            this.cmbCompanyId.txtTextValueInt = 0;
            // 
            // cmbCategoryId
            // 
            this.cmbCategoryId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCategoryId.AutoSize = true;
            this.cmbCategoryId.Location = new System.Drawing.Point(12, 219);
            this.cmbCategoryId.MinimumSize = new System.Drawing.Size(200, 35);
            this.cmbCategoryId.Name = "cmbCategoryId";
            this.cmbCategoryId.Size = new System.Drawing.Size(327, 35);
            this.cmbCategoryId.TabIndex = 5;
            this.cmbCategoryId.txtRequired = true;
            this.cmbCategoryId.txtTextLabel = "Category";
            this.cmbCategoryId.txtTextValueInt = 0;
            // 
            // cmbUnitId
            // 
            this.cmbUnitId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbUnitId.AutoSize = true;
            this.cmbUnitId.Location = new System.Drawing.Point(13, 260);
            this.cmbUnitId.MinimumSize = new System.Drawing.Size(200, 35);
            this.cmbUnitId.Name = "cmbUnitId";
            this.cmbUnitId.Size = new System.Drawing.Size(327, 35);
            this.cmbUnitId.TabIndex = 6;
            this.cmbUnitId.txtRequired = true;
            this.cmbUnitId.txtTextLabel = "Unit";
            this.cmbUnitId.txtTextValueInt = 0;
            // 
            // cmbDiscountId
            // 
            this.cmbDiscountId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDiscountId.AutoSize = true;
            this.cmbDiscountId.Location = new System.Drawing.Point(13, 319);
            this.cmbDiscountId.MinimumSize = new System.Drawing.Size(200, 35);
            this.cmbDiscountId.Name = "cmbDiscountId";
            this.cmbDiscountId.Size = new System.Drawing.Size(327, 35);
            this.cmbDiscountId.TabIndex = 7;
            this.cmbDiscountId.txtRequired = true;
            this.cmbDiscountId.txtTextLabel = "Discount";
            this.cmbDiscountId.txtTextValueInt = 0;
            // 
            // cmbSaleStatusId
            // 
            this.cmbSaleStatusId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSaleStatusId.AutoSize = true;
            this.cmbSaleStatusId.Location = new System.Drawing.Point(12, 360);
            this.cmbSaleStatusId.MinimumSize = new System.Drawing.Size(200, 35);
            this.cmbSaleStatusId.Name = "cmbSaleStatusId";
            this.cmbSaleStatusId.Size = new System.Drawing.Size(327, 35);
            this.cmbSaleStatusId.TabIndex = 8;
            this.cmbSaleStatusId.txtRequired = true;
            this.cmbSaleStatusId.txtTextLabel = "SaleStatus";
            this.cmbSaleStatusId.txtTextValueInt = 0;
            // 
            // txtListPrice
            // 
            this.txtListPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtListPrice.AutoSize = true;
            this.txtListPrice.Location = new System.Drawing.Point(13, 401);
            this.txtListPrice.MinimumSize = new System.Drawing.Size(200, 35);
            this.txtListPrice.MultiLine = false;
            this.txtListPrice.Name = "txtListPrice";
            this.txtListPrice.Size = new System.Drawing.Size(327, 35);
            this.txtListPrice.TabIndex = 9;
            this.txtListPrice.txtDoubleValue = 0D;
            this.txtListPrice.txtFloatValue = 0F;
            this.txtListPrice.txtIntValue = 0;
            this.txtListPrice.txtRequired = true;
            this.txtListPrice.txtTextLabel = "List Price";
            this.txtListPrice.txtTextValue = "";
            this.txtListPrice.TxtType = TextType.Text;
            // 
            // txtVat
            // 
            this.txtVat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVat.AutoSize = true;
            this.txtVat.Location = new System.Drawing.Point(13, 442);
            this.txtVat.MinimumSize = new System.Drawing.Size(200, 35);
            this.txtVat.MultiLine = false;
            this.txtVat.Name = "txtVat";
            this.txtVat.Size = new System.Drawing.Size(327, 35);
            this.txtVat.TabIndex = 10;
            this.txtVat.txtDoubleValue = 0D;
            this.txtVat.txtFloatValue = 0F;
            this.txtVat.txtIntValue = 0;
            this.txtVat.txtRequired = true;
            this.txtVat.txtTextLabel = "Vat";
            this.txtVat.txtTextValue = "";
            this.txtVat.TxtType = TextType.Text;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRemarks.AutoSize = true;
            this.txtRemarks.Location = new System.Drawing.Point(13, 483);
            this.txtRemarks.MinimumSize = new System.Drawing.Size(200, 35);
            this.txtRemarks.MultiLine = false;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(327, 35);
            this.txtRemarks.TabIndex = 11;
            this.txtRemarks.txtDoubleValue = 0D;
            this.txtRemarks.txtFloatValue = 0F;
            this.txtRemarks.txtIntValue = 0;
            this.txtRemarks.txtRequired = false;
            this.txtRemarks.txtTextLabel = "Remarks";
            this.txtRemarks.txtTextValue = "";
            this.txtRemarks.TxtType = TextType.Text;
            // 
            // cmbGroupId
            // 
            this.cmbGroupId.AutoSize = true;
            this.cmbGroupId.Location = new System.Drawing.Point(13, 96);
            this.cmbGroupId.MinimumSize = new System.Drawing.Size(200, 35);
            this.cmbGroupId.Name = "cmbGroupId";
            this.cmbGroupId.Size = new System.Drawing.Size(327, 35);
            this.cmbGroupId.TabIndex = 2;
            this.cmbGroupId.txtRequired = true;
            this.cmbGroupId.txtTextLabel = "Group";
            this.cmbGroupId.txtTextValueInt = 0;
            // 
            // frmProductNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(352, 597);
            this.Controls.Add(this.cmbGroupId);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.txtVat);
            this.Controls.Add(this.txtListPrice);
            this.Controls.Add(this.cmbSaleStatusId);
            this.Controls.Add(this.cmbDiscountId);
            this.Controls.Add(this.cmbUnitId);
            this.Controls.Add(this.cmbCategoryId);
            this.Controls.Add(this.cmbCompanyId);
            this.Controls.Add(this.cmbPowerId);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.txtName);
            this.Name = "frmProductNew";
            this.Text = "New Product";
            this.Load += new System.EventHandler(this.frmProductNew_Load);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnExit, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.txtCode, 0);
            this.Controls.SetChildIndex(this.cmbPowerId, 0);
            this.Controls.SetChildIndex(this.cmbCompanyId, 0);
            this.Controls.SetChildIndex(this.cmbCategoryId, 0);
            this.Controls.SetChildIndex(this.cmbUnitId, 0);
            this.Controls.SetChildIndex(this.cmbDiscountId, 0);
            this.Controls.SetChildIndex(this.cmbSaleStatusId, 0);
            this.Controls.SetChildIndex(this.txtListPrice, 0);
            this.Controls.SetChildIndex(this.txtVat, 0);
            this.Controls.SetChildIndex(this.txtRemarks, 0);
            this.Controls.SetChildIndex(this.cmbGroupId, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyControls.ucText txtName;
        private MyControls.ucText txtCode;
        private MyControls.ucCombo cmbPowerId;
        private MyControls.ucCombo cmbCompanyId;
        private MyControls.ucCombo cmbCategoryId;
        private MyControls.ucCombo cmbUnitId;
        private MyControls.ucCombo cmbDiscountId;
        private MyControls.ucCombo cmbSaleStatusId;
        private MyControls.ucText txtListPrice;
        private MyControls.ucText txtVat;
        private MyControls.ucText txtRemarks;
        private MyControls.ucCombo cmbGroupId;
    }
}

