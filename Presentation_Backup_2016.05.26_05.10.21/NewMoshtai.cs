using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Da;

namespace Presentation
{
    public partial class NewMoshtai : Form
    {
        public NewMoshtai()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtTel.Clear();
            txtFamily.Clear();
            txtId.Clear();
        }

        private void btnComitM_Click(object sender, EventArgs e)
        {
           (new Insert()).Moshtari(Convert.ToInt32(txtId.Text), txtName.Text, txtFamily.Text, txtTel.Text);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewMoshtai_Load(object sender, EventArgs e)
        {

        }
    }
}