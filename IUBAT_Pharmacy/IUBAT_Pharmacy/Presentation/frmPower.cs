using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IUBAT_Pharmacy.Presentation
{
    public partial class frmPower : IUBAT_Pharmacy.Presentation.Common.frmDisplay
    {
        public frmPower()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DAL.clsPower pr = new DAL.clsPower();
            pr.Name = txtSearch.Text;
            dgvData.DataSource = pr.Select().Tables[0];
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new Presentation.frmPowerNew().ShowDialog();
            btnSearch.PerformClick();
        }
    }
}
