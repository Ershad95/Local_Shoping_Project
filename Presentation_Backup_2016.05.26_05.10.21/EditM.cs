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
    public partial class EditM : Form
    {
        public EditM(bool detect)
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtFamily.Clear();
            txtID.Clear();
            txtTel.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            (new DataAccess()).Connect();
            (new Delete()).Moshtari(Convert.ToInt32(txtDelete.Text),null,null,null);
            (new DataAccess()).Disconnect();
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            (new DataAccess()).Connect();
            (new Delete()).DeleteAll("moshtari");
            (new DataAccess()).Disconnect();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            (new DataAccess()).Connect();
            (new Update()).Moshtari(Convert.ToInt32(txtID.Text),txtName.Text,txtFamily.Text,txtTel.Text);
            (new DataAccess()).Disconnect();
        }

        private void piCls_Click(object sender, EventArgs e)
        {
            btnExit_Click(null, null);
        }
    }
}
