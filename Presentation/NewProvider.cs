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
    public partial class NewProvider : Form
    {
        public NewProvider()
        {
            InitializeComponent();
        }

        private void btnComit_Click(object sender, EventArgs e)
        {
             DataAccess.Connect();
            (new Insert()).Provider(Convert.ToInt32(txtId.Text),txtName.Text,txtTel.Text,txtAddr.Text,txtType.Text);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DataAccess.Disconnect();
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtAddr.Clear();
            txtName.Clear();
            txtTel.Clear();
            txtType.Text = "";
        }

        private void piCls_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
