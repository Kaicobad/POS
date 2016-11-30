using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IUBAT_Pharmacy
{
    public partial class frmMain : Form
    {
        Presentation.frmGroup gr = new Presentation.frmGroup();
        Presentation.frmPower pr = new Presentation.frmPower();
        Presentation.frmCompany cp = new Presentation.frmCompany();
        Presentation.frmCategory ctg = new Presentation.frmCategory();
        Presentation.frmUnit u = new Presentation.frmUnit();
        Presentation.frmDiscount ds = new Presentation.frmDiscount();
        Presentation.frmSaleStatus st = new Presentation.frmSaleStatus();
        Presentation.frmProduct p = new Presentation.frmProduct();
        Presentation.frmRack rc = new Presentation.frmRack();
        Presentation.frmEmployee em = new Presentation.frmEmployee();
        Presentation.frmPaymentMethod pm = new Presentation.frmPaymentMethod();
        Presentation.frmPurchase prch = new Presentation.frmPurchase();

        public frmMain()
        {
            InitializeComponent();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Show();
            p.MdiParent = this;
            p.BringToFront();
            if (p.IsDisposed)
            {
                p = new Presentation.frmProduct();
            }
        }

        private void categoryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ctg.Show();
            ctg.MdiParent = this;
            ctg.BringToFront();
            if (ctg.IsDisposed)
            {
                ctg = new Presentation.frmCategory();
            }
        }

        private void tNowTime_Tick(object sender, EventArgs e)
        {
            lblWatch.Text = "Date and Time :    " + DateTime.Now.ToString() + "                                         © CopyRight Protected By @Kaicobad Hassan";
        }

        private void groupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gr.Show();
            gr.MdiParent = this;
            gr.BringToFront();
            if (gr.IsDisposed)
            {
                gr = new Presentation.frmGroup();
            }
        }

        private void exitToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void powerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pr.Show();
            pr.MdiParent = this;
            pr.BringToFront();
            if (pr.IsDisposed)
            {
                pr = new Presentation.frmPower();
            }
        }

        private void companyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cp.Show();
            cp.MdiParent = this;
            cp.BringToFront();
            if (cp.IsDisposed)
            {
                cp = new Presentation.frmCompany();
            }
        }

        private void unitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            u.Show();
            u.MdiParent = this;
            u.BringToFront();
            if (u.IsDisposed)
            {
                u = new Presentation.frmUnit();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ds.Show();
            ds.MdiParent = this;
            ds.BringToFront();
            if (ds.IsDisposed)
            {
                ds = new Presentation.frmDiscount();
            }
        }

        private void SaleStatus_toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            st.Show();
            st.MdiParent = this;
            st.BringToFront();
            if (st.IsDisposed)
            {
                st = new Presentation.frmSaleStatus();
            }
        }

        private void rackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rc.Show();
            rc.MdiParent = this;
            rc.BringToFront();
            if (rc.IsDisposed)
            {
                rc = new Presentation.frmRack();
            }
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            em.Show();
            em.MdiParent = this;
            em.BringToFront();
            if (em.IsDisposed)
            {
                em = new Presentation.frmEmployee();
            }
        }

        private void paymentMethodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pm.Show();
            pm.MdiParent = this;
            pm.BringToFront();
            if (pm.IsDisposed)
            {
                pm = new Presentation.frmPaymentMethod();
            }
        }

        private void purchaseToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            prch.Show();
            prch.MdiParent = this;
            prch.BringToFront();
            if (prch.IsDisposed)
            {
                prch = new Presentation.frmPurchase();
            }
        }
    }
}
