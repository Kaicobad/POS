using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IUBAT_Pharmacy.Presentation
{
    public partial class frmCompany : IUBAT_Pharmacy.Presentation.Common.frmDisplay
    {
        public frmCompany()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new Presentation.frmCompanyNew().ShowDialog();
            btnSearch.PerformClick();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DAL.clsCompany cp = new DAL.clsCompany();
            cp.Name = txtSearch.Text;
            dgvData.DataSource = cp.Select().Tables[0];
        }
    }
}
