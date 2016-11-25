namespace IUBAT_Pharmacy.Presentation
{
    partial class frmEmployeeNew
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
            this.txtPhone = new IUBAT_Pharmacy.Presentation.MyControls.ucText();
            this.txtEmail = new IUBAT_Pharmacy.Presentation.MyControls.ucText();
            this.txtPassword = new IUBAT_Pharmacy.Presentation.MyControls.ucText();
            this.pbImage = new IUBAT_Pharmacy.Presentation.MyControls.ucImage();
            this.txtType = new IUBAT_Pharmacy.Presentation.MyControls.ucText();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(246, 251);
            this.btnExit.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(13, 251);
            this.btnSave.TabIndex = 6;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Location = new System.Drawing.Point(13, 12);
            this.txtName.MinimumSize = new System.Drawing.Size(200, 35);
            this.txtName.MultiLine = false;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(302, 35);
            this.txtName.TabIndex = 0;
            this.txtName.txtDoubleValue = 0D;
            this.txtName.txtFloatValue = 0F;
            this.txtName.txtIntValue = 0;
            this.txtName.txtRequired = true;
            this.txtName.txtTextLabel = "Name";
            this.txtName.txtTextValue = "";
            this.txtName.TxtType = TextType.Text;
            // 
            // txtPhone
            // 
            this.txtPhone.AutoSize = true;
            this.txtPhone.Location = new System.Drawing.Point(13, 63);
            this.txtPhone.MinimumSize = new System.Drawing.Size(200, 35);
            this.txtPhone.MultiLine = false;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(302, 35);
            this.txtPhone.TabIndex = 1;
            this.txtPhone.txtDoubleValue = 0D;
            this.txtPhone.txtFloatValue = 0F;
            this.txtPhone.txtIntValue = 0;
            this.txtPhone.txtRequired = true;
            this.txtPhone.txtTextLabel = "Phone";
            this.txtPhone.txtTextValue = "";
            this.txtPhone.TxtType = TextType.Text;
            // 
            // txtEmail
            // 
            this.txtEmail.AutoSize = true;
            this.txtEmail.Location = new System.Drawing.Point(13, 107);
            this.txtEmail.MinimumSize = new System.Drawing.Size(200, 35);
            this.txtEmail.MultiLine = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(302, 35);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.txtDoubleValue = 0D;
            this.txtEmail.txtFloatValue = 0F;
            this.txtEmail.txtIntValue = 0;
            this.txtEmail.txtRequired = false;
            this.txtEmail.txtTextLabel = "Email";
            this.txtEmail.txtTextValue = "";
            this.txtEmail.TxtType = TextType.Text;
            // 
            // txtPassword
            // 
            this.txtPassword.AutoSize = true;
            this.txtPassword.Location = new System.Drawing.Point(12, 201);
            this.txtPassword.MinimumSize = new System.Drawing.Size(200, 35);
            this.txtPassword.MultiLine = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(302, 35);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.txtDoubleValue = 0D;
            this.txtPassword.txtFloatValue = 0F;
            this.txtPassword.txtIntValue = 0;
            this.txtPassword.txtRequired = true;
            this.txtPassword.txtTextLabel = "Password";
            this.txtPassword.txtTextValue = "";
            this.txtPassword.TxtType = TextType.Text;
            // 
            // pbImage
            // 
            this.pbImage.BGImage = null;
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Location = new System.Drawing.Point(350, 12);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(278, 253);
            this.pbImage.TabIndex = 5;
            this.pbImage.txtLabel = "Insert Image Here";
            this.pbImage.txtRequired = true;
            // 
            // txtType
            // 
            this.txtType.AutoSize = true;
            this.txtType.Location = new System.Drawing.Point(13, 160);
            this.txtType.MinimumSize = new System.Drawing.Size(200, 35);
            this.txtType.MultiLine = false;
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(302, 35);
            this.txtType.TabIndex = 3;
            this.txtType.txtDoubleValue = 0D;
            this.txtType.txtFloatValue = 0F;
            this.txtType.txtIntValue = 0;
            this.txtType.txtRequired = true;
            this.txtType.txtTextLabel = "Type Of Employee";
            this.txtType.txtTextValue = "";
            this.txtType.TxtType = TextType.Text;
            // 
            // frmEmployeeNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(646, 290);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Name = "frmEmployeeNew";
            this.Text = "New Employee";
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnExit, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.txtPhone, 0);
            this.Controls.SetChildIndex(this.txtEmail, 0);
            this.Controls.SetChildIndex(this.txtPassword, 0);
            this.Controls.SetChildIndex(this.pbImage, 0);
            this.Controls.SetChildIndex(this.txtType, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyControls.ucText txtName;
        private MyControls.ucText txtPhone;
        private MyControls.ucText txtEmail;
        private MyControls.ucText txtPassword;
        private MyControls.ucImage pbImage;
        private MyControls.ucText txtType;
    }
}
