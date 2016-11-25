using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IUBAT_Pharmacy.Presentation
{
    public partial class frmUnit : IUBAT_Pharmacy.Presentation.Common.frmDisplay
    {
        public frmUnit()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new Presentation.frmUnitNew().ShowDialog();
            btnSearch.PerformClick();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DAL.clsUnit u = new DAL.clsUnit();
            dgvData.DataSource = u.Select().Tables[0];
        }
    }
}
