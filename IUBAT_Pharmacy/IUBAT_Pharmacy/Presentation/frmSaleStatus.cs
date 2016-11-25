using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IUBAT_Pharmacy.Presentation
{
    public partial class frmSaleStatus : IUBAT_Pharmacy.Presentation.Common.frmDisplay
    {
        public frmSaleStatus()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new Presentation.frmSaleStatusNew().ShowDialog();
            btnSearch.PerformClick();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DAL.clsSaleStatus st = new DAL.clsSaleStatus();
            dgvData.DataSource = st.Select().Tables[0];
        }
    }
}
