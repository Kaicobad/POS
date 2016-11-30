namespace IUBAT_Pharmacy.Presentation
{
    partial class frmPurchaseNew
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
            this.cmbProduct = new IUBAT_Pharmacy.Presentation.MyControls.ucCombo();
            this.dgvData = new IUBAT_Pharmacy.Presentation.MyControls.clsMyGrid();
            this.colProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dptDateTime = new System.Windows.Forms.DateTimePicker();
            this.cmbEmployee = new IUBAT_Pharmacy.Presentation.MyControls.ucCombo();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.txtQty = new IUBAT_Pharmacy.Presentation.MyControls.ucText();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.cmbDiscount = new IUBAT_Pharmacy.Presentation.MyControls.ucCombo();
            this.cmbRate = new IUBAT_Pharmacy.Presentation.MyControls.ucCombo();
            this.cmbVat = new IUBAT_Pharmacy.Presentation.MyControls.ucCombo();
            this.cmbCode = new IUBAT_Pharmacy.Presentation.MyControls.ucCombo();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(725, 531);
            this.btnExit.TabIndex = 14;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(13, 531);
            this.btnSave.TabIndex = 12;
            // 
            // cmbProduct
            // 
            this.cmbProduct.AutoSize = true;
            this.cmbProduct.Location = new System.Drawing.Point(12, 22);
            this.cmbProduct.MinimumSize = new System.Drawing.Size(200, 35);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(200, 35);
            this.cmbProduct.TabIndex = 0;
            this.cmbProduct.txtComboText = "";
            this.cmbProduct.txtRequired = true;
            this.cmbProduct.txtTextLabel = "Product";
            this.cmbProduct.txtTextValueInt = 0;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.BackgroundColor = System.Drawing.Color.White;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProduct,
            this.colQty,
            this.colNumber,
            this.colRate,
            this.colVat,
            this.colSubTotal});
            this.dgvData.Location = new System.Drawing.Point(8, 184);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.Size = new System.Drawing.Size(792, 259);
            this.dgvData.TabIndex = 16;
            this.dgvData.Click += new System.EventHandler(this.dgvData_Click);
            // 
            // colProduct
            // 
            this.colProduct.HeaderText = "Product";
            this.colProduct.Name = "colProduct";
            this.colProduct.ReadOnly = true;
            // 
            // colQty
            // 
            this.colQty.HeaderText = "Quantity";
            this.colQty.Name = "colQty";
            this.colQty.ReadOnly = true;
            // 
            // colNumber
            // 
            this.colNumber.HeaderText = "Code";
            this.colNumber.Name = "colNumber";
            this.colNumber.ReadOnly = true;
            // 
            // colRate
            // 
            this.colRate.HeaderText = "Rate";
            this.colRate.Name = "colRate";
            this.colRate.ReadOnly = true;
            // 
            // colVat
            // 
            this.colVat.HeaderText = "Vat";
            this.colVat.Name = "colVat";
            this.colVat.ReadOnly = true;
            // 
            // colSubTotal
            // 
            this.colSubTotal.HeaderText = "Sub-Total";
            this.colSubTotal.Name = "colSubTotal";
            this.colSubTotal.ReadOnly = true;
            // 
            // dptDateTime
            // 
            this.dptDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dptDateTime.CustomFormat = "dd/MM/yyyy";
            this.dptDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dptDateTime.Location = new System.Drawing.Point(598, 465);
            this.dptDateTime.Name = "dptDateTime";
            this.dptDateTime.Size = new System.Drawing.Size(202, 20);
            this.dptDateTime.TabIndex = 11;
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbEmployee.AutoSize = true;
            this.cmbEmployee.Location = new System.Drawing.Point(12, 455);
            this.cmbEmployee.MinimumSize = new System.Drawing.Size(200, 35);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(200, 35);
            this.cmbEmployee.TabIndex = 7;
            this.cmbEmployee.txtComboText = "";
            this.cmbEmployee.txtRequired = true;
            this.cmbEmployee.txtTextLabel = "Employee";
            this.cmbEmployee.txtTextValueInt = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(595, 449);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Date_Time";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(482, 471);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(0, 13);
            this.lblSubtotal.TabIndex = 10;
            // 
            // txtQty
            // 
            this.txtQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQty.AutoSize = true;
            this.txtQty.Location = new System.Drawing.Point(595, 22);
            this.txtQty.MinimumSize = new System.Drawing.Size(200, 35);
            this.txtQty.MultiLine = false;
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(200, 35);
            this.txtQty.TabIndex = 2;
            this.txtQty.txtDoubleValue = 0D;
            this.txtQty.txtFloatValue = 0F;
            this.txtQty.txtIntValue = 0;
            this.txtQty.txtRequired = true;
            this.txtQty.txtTextLabel = "Quantity";
            this.txtQty.txtTextValue = "";
            this.txtQty.TxtType = TextType.Integer;
            // 
            // btnPurchase
            // 
            this.btnPurchase.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPurchase.Location = new System.Drawing.Point(354, 531);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(75, 23);
            this.btnPurchase.TabIndex = 13;
            this.btnPurchase.Text = "&Purchase";
            this.btnPurchase.UseVisualStyleBackColor = true;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // cmbDiscount
            // 
            this.cmbDiscount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbDiscount.AutoSize = true;
            this.cmbDiscount.Location = new System.Drawing.Point(321, 22);
            this.cmbDiscount.MinimumSize = new System.Drawing.Size(200, 35);
            this.cmbDiscount.Name = "cmbDiscount";
            this.cmbDiscount.Size = new System.Drawing.Size(200, 35);
            this.cmbDiscount.TabIndex = 1;
            this.cmbDiscount.txtComboText = "";
            this.cmbDiscount.txtRequired = false;
            this.cmbDiscount.txtTextLabel = "Discount";
            this.cmbDiscount.txtTextValueInt = 0;
            // 
            // cmbRate
            // 
            this.cmbRate.AutoSize = true;
            this.cmbRate.Location = new System.Drawing.Point(13, 83);
            this.cmbRate.MinimumSize = new System.Drawing.Size(200, 35);
            this.cmbRate.Name = "cmbRate";
            this.cmbRate.Size = new System.Drawing.Size(200, 35);
            this.cmbRate.TabIndex = 3;
            this.cmbRate.txtComboText = "";
            this.cmbRate.txtRequired = true;
            this.cmbRate.txtTextLabel = "Rate";
            this.cmbRate.txtTextValueInt = 0;
            this.cmbRate.Load += new System.EventHandler(this.cmbRate_Load);
            // 
            // cmbVat
            // 
            this.cmbVat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbVat.AutoSize = true;
            this.cmbVat.Location = new System.Drawing.Point(321, 82);
            this.cmbVat.MinimumSize = new System.Drawing.Size(200, 35);
            this.cmbVat.Name = "cmbVat";
            this.cmbVat.Size = new System.Drawing.Size(200, 35);
            this.cmbVat.TabIndex = 4;
            this.cmbVat.txtComboText = "";
            this.cmbVat.txtRequired = true;
            this.cmbVat.txtTextLabel = "Vat(%)BDT";
            this.cmbVat.txtTextValueInt = 0;
            // 
            // cmbCode
            // 
            this.cmbCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCode.AutoSize = true;
            this.cmbCode.Location = new System.Drawing.Point(595, 83);
            this.cmbCode.MinimumSize = new System.Drawing.Size(200, 35);
            this.cmbCode.Name = "cmbCode";
            this.cmbCode.Size = new System.Drawing.Size(200, 35);
            this.cmbCode.TabIndex = 5;
            this.cmbCode.txtComboText = "";
            this.cmbCode.txtRequired = true;
            this.cmbCode.txtTextLabel = "Code Number";
            this.cmbCode.txtTextValueInt = 0;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(380, 503);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(37, 13);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "Total :";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdd.Location = new System.Drawing.Point(321, 145);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(200, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add to List";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 471);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "SubTotal (BDT) :";
            // 
            // frmPurchaseNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(812, 566);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.cmbCode);
            this.Controls.Add(this.cmbVat);
            this.Controls.Add(this.cmbRate);
            this.Controls.Add(this.cmbDiscount);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbEmployee);
            this.Controls.Add(this.dptDateTime);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.cmbProduct);
            this.Name = "frmPurchaseNew";
            this.Text = "New Purchase";
            this.Load += new System.EventHandler(this.frmPurchaseNew_Load);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnExit, 0);
            this.Controls.SetChildIndex(this.cmbProduct, 0);
            this.Controls.SetChildIndex(this.dgvData, 0);
            this.Controls.SetChildIndex(this.dptDateTime, 0);
            this.Controls.SetChildIndex(this.cmbEmployee, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblSubtotal, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtQty, 0);
            this.Controls.SetChildIndex(this.btnPurchase, 0);
            this.Controls.SetChildIndex(this.cmbDiscount, 0);
            this.Controls.SetChildIndex(this.cmbRate, 0);
            this.Controls.SetChildIndex(this.cmbVat, 0);
            this.Controls.SetChildIndex(this.cmbCode, 0);
            this.Controls.SetChildIndex(this.lblTotal, 0);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyControls.ucCombo cmbProduct;
        private MyControls.clsMyGrid dgvData;
        private System.Windows.Forms.DateTimePicker dptDateTime;
        private MyControls.ucCombo cmbEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSubtotal;
        private MyControls.ucText txtQty;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubTotal;
        private MyControls.ucCombo cmbDiscount;
        private MyControls.ucCombo cmbRate;
        private MyControls.ucCombo cmbVat;
        private MyControls.ucCombo cmbCode;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
    }
}
