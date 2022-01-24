using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MSG_CS;
namespace Presentation
{
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
        }

        private void piCls_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
            txtID.Clear();
            txtPass.Clear();
            txtUser.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            Msg m =new Msg();
            m.Msge("شما در حال ذخیره هستید","هشدار",Msg.BtnType.OK, Msg.IcnHeader.Warning, Color.Gold);
            m.Show();
        }
    }
}
