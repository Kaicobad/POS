using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IUBAT_Pharmacy.Presentation.MyControls
{
    public partial class ucCombo : UserControl
    {

        public bool txtRequired { get; set; }


        public string txtTextLabel
        {
            get
            {
                return lblLabel.Text;
            }
            set
            {
                lblLabel.Text = value;
            }
        }

        public int txtTextValueInt
        {
            get
            {
                int i = 0;
                try
                {
                    i = Convert.ToInt32(cmbCombo.SelectedValue);
                }
                catch
                { }
                return i;
            }
            set
            {
                cmbCombo.SelectedValue = value;
            }
        }

        public int txtValidate()
        {
            lblError.Text = "";
            if(txtRequired && (cmbCombo.SelectedValue == null || cmbCombo.SelectedValue.ToString() == ""))
            {
                lblError.Text = "Required";
                return 1;
            }
            return 0;
        }

        public void setDataSource(DataSet ds, string display = "name", string value = "id")
        {
            cmbCombo.DataSource = ds.Tables[0];
            cmbCombo.DisplayMember = display;
            cmbCombo.ValueMember = value;
            cmbCombo.SelectedValue = -1;
        }


        public ucCombo()
        {
            InitializeComponent();
        }
    }
}
