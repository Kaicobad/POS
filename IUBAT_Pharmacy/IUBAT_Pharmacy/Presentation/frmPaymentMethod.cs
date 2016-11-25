using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IUBAT_Pharmacy.Presentation
{
    public partial class frmPaymentMethod : IUBAT_Pharmacy.Presentation.Common.frmDisplay
    {
        public frmPaymentMethod()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DAL.clsPaymentMethod pm = new DAL.clsPaymentMethod();
            dgvData.DataSource = pm.Select().Tables[0];
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new Presentation.frmPaymentMethodNew().ShowDialog();
            btnSearch.PerformClick();
        }
    }
}
