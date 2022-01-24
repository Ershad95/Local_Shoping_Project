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
    public partial class EditP : Form
    {
        public EditP(bool detect)
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

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            (new DataAccess()).Connect();
            (new Delete()).DeleteAll("Provider");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            (new DataAccess()).Connect();
            (new Delete()).Provider(Convert.ToInt32(txtDelete.Text), null, null, null, null);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            (new DataAccess()).Disconnect();
            this.Close();
        }

        private void piCls_Click(object sender, EventArgs e)
        {
            btnExit_Click(null, null);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtAddr.Clear();
            txtTel.Clear();
            txtID.Clear();
            txttype.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            (new DataAccess()).Connect();
            (new Update()).Provider(Convert.ToInt32(txtID),txtName.Text,txtTel.Text,txtAddr.Text,txttype.Text);
        }

        private void EditP_Load(object sender, EventArgs e)
        {

        }
    }
}
