using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IUBAT_Pharmacy.Presentation
{
    public partial class frmEmployee : IUBAT_Pharmacy.Presentation.Common.frmDisplay
    {
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DAL.clsEmployee em = new DAL.clsEmployee();
            dgvData.DataSource = em.Select().Tables[0];
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new Presentation.frmEmployeeNew().ShowDialog();
            btnSearch.PerformClick();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            LoadReport("rptEmployee", "Employee Report", (DataTable)dgvData.DataSource);
        }
    }
}
