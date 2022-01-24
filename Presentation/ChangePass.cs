using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class ChangePass : Form
    {
        public ChangePass()
        {
            InitializeComponent();
        }

        private void ChangePass_Load(object sender, EventArgs e)
        {

        }

        private void btnChanges_Click(object sender, EventArgs e)
        {
           if(txtOldPass.Text==Properties.Settings.Default.Password && txtNewpass.Text!="" && txtNewpass.Text == txtRepeatPass.Text)
            {
                Properties.Settings.Default.Password = txtRepeatPass.Text;
                Properties.Settings.Default.Save();
                MessageBox.Show("رمز عبور شما عوض شد");
                ChangePass.ActiveForm.Hide();
                Authentication au = new Authentication();
                au.ShowDialog();

            }
            else
            {
                MessageBox.Show("لطفا اطلاعات را درست و با دقت وارد کنید");
            }
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNewpass.Clear();
            txtOldPass.Clear();
            txtRepeatPass.Clear();
        }

       
    }
}
