using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IUBAT_Pharmacy.Presentation
{
    public partial class frmDiscount : IUBAT_Pharmacy.Presentation.Common.frmDisplay
    {
        public frmDiscount()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new Presentation.frmDiscountNew().ShowDialog();
            btnSearch.PerformClick();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DAL.clsDiscount ds = new DAL.clsDiscount();
            dgvData.DataSource = ds.Select().Tables[0];
        }
    }
}
