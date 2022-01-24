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
namespace Presentation
{
    public partial class EditK : Form
    {
        public EditK(bool detect)
        {
            InitializeComponent();
            if (detect == true)
            {
                GroupUpdate.Enabled = true;
                GroupDelete.Enabled = false;
            }
            else
            {
                GroupUpdate.Enabled = false;
                GroupDelete.Enabled = true;
            }
        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            (new DataAccess()).Connect();
            (new Delete()).DeleteAll("Kala");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            (new DataAccess()).Connect();
            (new Delete()).Kala(Convert.ToInt32(txtID.Text),null,null,null,0);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            (new DataAccess()).Disconnect();
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtName.Clear();
            txtBrand.Clear();
            txtPrice.Clear();
            txttype.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            (new DataAccess()).Connect();
            (new Update()).Kala(Convert.ToInt32(txtID.Text),txtName.Text,txtBrand.Text,txttype.Text,Convert.ToInt32(txtPrice.Text));
        }

        private void piCls_Click(object sender, EventArgs e)
        {
            btnExit_Click(null, null);
        }
    }
}
