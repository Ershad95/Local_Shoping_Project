using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Da;
using DevExpress.Utils.FormShadow;

namespace Presentation
{
    public partial class NewKala : Form
    {
        public NewKala()
        {
            InitializeComponent();
        }

        private void btnComit_Click(object sender, EventArgs e)
        {
            DataAccess.Connect();
            (new Insert()).Kala(Convert.ToInt32(txtId.Text),txtName.Text,txtBrand.Text,txtType.Text,Convert.ToInt32(txtPrice.Text));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DataAccess.Disconnect();
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtBrand.Clear();
            txtName.Clear();
            txtPrice.Clear();
            txtType.Text = "";
            //txtCount.Clear();
        }

        private void piCls_Click(object sender, EventArgs e)
        {
            btnExit_Click(null, null);
        }
    }
}
