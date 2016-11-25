using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IUBAT_Pharmacy.Presentation
{
    public partial class frmGroup : IUBAT_Pharmacy.Presentation.Common.frmDisplay
    {
        public frmGroup()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DAL.clsGroup gr = new DAL.clsGroup();
            gr.Name = txtSearch.Text;
            dgvData.DataSource = gr.Select().Tables[0];
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new Presentation.frmGroupNew().ShowDialog();
            btnSearch.PerformClick();
        }
    }
}
