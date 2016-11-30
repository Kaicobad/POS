using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IUBAT_Pharmacy.Presentation
{
    public partial class frmPurchase : IUBAT_Pharmacy.Presentation.Common.frmDisplay
    {
        public frmPurchase()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs ex)
        {
            new Presentation.frmPurchaseNew().ShowDialog();
            btnSearch.PerformClick();
        }
    }
}
