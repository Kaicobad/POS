namespace IUBAT_Pharmacy.Presentation
{
    partial class frmDiscountNew
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
            this.txtDiscount = new IUBAT_Pharmacy.Presentation.MyControls.ucText();
            this.txtPersentage = new IUBAT_Pharmacy.Presentation.MyControls.ucText();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(244, 183);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(13, 183);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtDiscount
            // 
            this.txtDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiscount.AutoSize = true;
            this.txtDiscount.Location = new System.Drawing.Point(13, 12);
            this.txtDiscount.MinimumSize = new System.Drawing.Size(200, 35);
            this.txtDiscount.MultiLine = false;
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(306, 35);
            this.txtDiscount.TabIndex = 2;
            this.txtDiscount.txtDoubleValue = 0D;
            this.txtDiscount.txtFloatValue = 0F;
            this.txtDiscount.txtIntValue = 0;
            this.txtDiscount.txtRequired = true;
            this.txtDiscount.txtTextLabel = "Discount Status";
            this.txtDiscount.txtTextValue = "";
            this.txtDiscount.TxtType = TextType.Text;
            // 
            // txtPersentage
            // 
            this.txtPersentage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPersentage.AutoSize = true;
            this.txtPersentage.Location = new System.Drawing.Point(12, 66);
            this.txtPersentage.MinimumSize = new System.Drawing.Size(200, 35);
            this.txtPersentage.MultiLine = false;
            this.txtPersentage.Name = "txtPersentage";
            this.txtPersentage.Size = new System.Drawing.Size(306, 35);
            this.txtPersentage.TabIndex = 3;
            this.txtPersentage.txtDoubleValue = 0D;
            this.txtPersentage.txtFloatValue = 0F;
            this.txtPersentage.txtIntValue = 0;
            this.txtPersentage.txtRequired = false;
            this.txtPersentage.txtTextLabel = "Persentage";
            this.txtPersentage.txtTextValue = "";
            this.txtPersentage.TxtType = TextType.Float;
            // 
            // frmDiscountNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(331, 218);
            this.Controls.Add(this.txtPersentage);
            this.Controls.Add(this.txtDiscount);
            this.Name = "frmDiscountNew";
            this.Text = "New Discount Entry";
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnExit, 0);
            this.Controls.SetChildIndex(this.txtDiscount, 0);
            this.Controls.SetChildIndex(this.txtPersentage, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyControls.ucText txtDiscount;
        private MyControls.ucText txtPersentage;
    }
}
