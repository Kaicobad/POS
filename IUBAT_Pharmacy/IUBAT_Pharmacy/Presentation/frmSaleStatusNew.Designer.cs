﻿namespace IUBAT_Pharmacy.Presentation
{
    partial class frmSaleStatusNew
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
            this.txtDescription = new IUBAT_Pharmacy.Presentation.MyControls.ucText();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(244, 165);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(13, 165);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.AutoSize = true;
            this.txtName.Location = new System.Drawing.Point(13, 27);
            this.txtName.MinimumSize = new System.Drawing.Size(200, 35);
            this.txtName.MultiLine = false;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(306, 35);
            this.txtName.TabIndex = 2;
            this.txtName.txtDoubleValue = 0D;
            this.txtName.txtFloatValue = 0F;
            this.txtName.txtIntValue = 0;
            this.txtName.txtRequired = true;
            this.txtName.txtTextLabel = "Name";
            this.txtName.txtTextValue = "";
            this.txtName.TxtType = TextType.Text;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.AutoSize = true;
            this.txtDescription.Location = new System.Drawing.Point(13, 68);
            this.txtDescription.MinimumSize = new System.Drawing.Size(200, 35);
            this.txtDescription.MultiLine = false;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(306, 35);
            this.txtDescription.TabIndex = 3;
            this.txtDescription.txtDoubleValue = 0D;
            this.txtDescription.txtFloatValue = 0F;
            this.txtDescription.txtIntValue = 0;
            this.txtDescription.txtRequired = false;
            this.txtDescription.txtTextLabel = "Description";
            this.txtDescription.txtTextValue = "";
            this.txtDescription.TxtType = TextType.Text;
            // 
            // frmSaleStatusNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(331, 200);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtName);
            this.Name = "frmSaleStatusNew";
            this.Text = "New Sale Status";
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnExit, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.txtDescription, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyControls.ucText txtName;
        private MyControls.ucText txtDescription;
    }
}
