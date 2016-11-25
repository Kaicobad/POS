using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IUBAT_Pharmacy.Presentation
{
    public partial class frmCategory : IUBAT_Pharmacy.Presentation.Common.frmDisplay
    {
        public frmCategory()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DAL.clsCategory ctg = new DAL.clsCategory();
            dgvData.DataSource = ctg.Select().Tables[0];
            
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new Presentation.frmCategoryNew().ShowDialog();
            btnSearch.PerformClick();
        }
    }
}
