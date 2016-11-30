using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IUBAT_Pharmacy.Presentation
{
    public partial class frmPurchaseNew : IUBAT_Pharmacy.Presentation.Common.frmNew
    {
        public frmPurchaseNew()
        {
            InitializeComponent();


            //pd.Id = id;

            //if (pd.SelectById())
            //{
            //    cmbProduct.txtTextValueInt = Convert.ToInt32(pd.Name);
            //    cmbDiscount.txtTextValueInt = pd.DiscountId;
            //    cmbRate.txtTextValueInt = Convert.ToInt32(pd.ListPrice);
            //    cmbVat.txtTextValueInt = Convert.ToInt32(pd.Vat);
            //    cmbCode.txtTextValueInt = Convert.ToInt32(pd.Code);
            //}
            //else
            //{
            //    MessageBox.Show(pd.Error);
            //}


        }

        private void frmPurchaseNew_Load(object sender, EventArgs e)
        {
            DAL.clsProduct pd2 = new DAL.clsProduct();

            cmbProduct.setDataSource(pd2.Select());

            cmbProduct.cmbCombo.SelectedValueChanged += cmbCombo_SelectedValueChanged;

            
            //cmbDiscount.txtTextValueInt = pd.DiscountId;
            //cmbRate.txtTextValueInt = Convert.ToInt32(pd.ListPrice);
            //cmbVat.txtTextValueInt = Convert.ToInt32(pd.Vat);
            //cmbCode.txtTextValueInt = Convert.ToInt32(pd.Code);
            //cmbProduct.setDataSource(pd.Select());

            DAL.clsEmployee em = new DAL.clsEmployee();
            em.Id = cmbEmployee.txtTextValueInt;
            cmbEmployee.setDataSource(em.Select());
        }

        void cmbCombo_SelectedValueChanged(object sender, EventArgs e)
        {

            DAL.clsProduct pd2 = new DAL.clsProduct();

            pd2.DiscountId= cmbDiscount.txtTextValueInt;
            cmbDiscount.setDataSource(pd2.Select(), "discount");

            pd2.ListPrice = cmbRate.txtTextValueInt;
            cmbRate.setDataSource(pd2.Select(), "listPrice");

            pd2.Vat = cmbVat.txtTextValueInt;
            cmbVat.setDataSource(pd2.Select(), "vat");

            pd2.Code = cmbCode.txtTextValueInt.ToString();
            cmbCode.setDataSource(pd2.Select(), "code");
            



            //pd2.Name = cmbProduct.txtTextValueInt.ToString();
            //cmbProduct.setDataSource(pd2.Select());
        }

        private void dgvData_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            double total = 0;

            for (int i = 0; i < dgvData.Rows.Count; i++)
            {
                total += Convert.ToDouble(dgvData.Rows[i].Cells["colSubTotal"].Value);
            }
            lblTotal.Text = string.Format("Total (BDT/TAKA) : {0}", total);
          
        }

        private void cmbRate_Load(object sender, EventArgs e)
        {
            //double subTotal = 0;
            //cmbVat.txtTextValueInt = Convert.ToInt32(cmbRate.txtTextValueInt * Convert.ToUInt32(txtQty.txtTextValue));
            //txtSubTotal.txtTextValue = cmbVat.txtTextValueInt + Convert.ToInt32(cmbRate.txtTextValueInt * Convert.ToUInt32(txtQty.txtTextValue)).ToString();
            //subTotal = Convert.ToDouble(txtSubTotal.txtTextValue);
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrWhiteSpace(cmbRate.txtComboText) && !string.IsNullOrWhiteSpace(cmbVat.txtComboText) && !string.IsNullOrWhiteSpace(txtQty.txtTextValue))
            {
                //double subTotal = 0;

                lblSubtotal.Text = ((Convert.ToInt32(txtQty.txtTextValue) * Convert.ToInt32(cmbRate.txtComboText) * Convert.ToDouble(cmbVat.txtComboText)) + (Convert.ToInt32(txtQty.txtTextValue) * Convert.ToInt32(cmbRate.txtComboText))).ToString();
                //lblSubtotal.Text += string.Format("Sub-Total:{0}", ((Convert.ToInt32(txtQty.txtTextValue) * Convert.ToInt32(cmbRate.txtComboText) * Convert.ToDouble(cmbVat.txtComboText)) + (Convert.ToInt32(txtQty.txtTextValue) * Convert.ToInt32(cmbRate.txtComboText))).ToString());
            }
            

            if (colProduct.Index == 0 && colQty.Index == 1 && colNumber.Index == 2 && colRate.Index == 3 && colVat.Index == 4 && colSubTotal.Index == 5)
            {
                dgvData.Rows.Add(cmbProduct.txtComboText, txtQty.txtIntValue, cmbCode.txtComboText, cmbRate.txtComboText, cmbVat.txtComboText, lblSubtotal.Text);

            } 
        }
    }
}
