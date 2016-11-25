using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace IUBAT_Pharmacy.Presentation
{
    public partial class frmProduct : IUBAT_Pharmacy.Presentation.Common.frmDisplay
    {
        public frmProduct()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new Presentation.frmProductNew().ShowDialog();
            btnSearch.PerformClick();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DAL.clsProduct p = new DAL.clsProduct();
            dgvData.DataSource = p.Select().Tables[0];
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            LoadReport("rptProduct", "Product Report", (DataTable)dgvData.DataSource);
            
        }
    }
}
