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
    public partial class Authentication : Form
    {
       
        public Authentication()
        {
            
            
            InitializeComponent();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
          if(txtCode.Text == "" || txtPass.Text == "" || txtUser.Text == "")
            {
                timer.Enabled = true;
                timer.Start();
                Epr.SetError(txtCode, "اطلاعات را پر کنید");
                Epr.SetError(txtPass, "اطلاعات را پر کنید");
                Epr.SetError(txtUser, "اطلاعات را پر کنید");
                
            }
          else
            {
                if(txtUser.Text == Properties.Settings.Default.User && txtPass.Text == Properties.Settings.Default.Password && txtCode.Text == Properties.Settings.Default.Code)
                {
                    Main frm = new Main();
                    this.Close();
                    frm.Show();
                   
                  
                }
                else
                {
                    timer.Enabled = true;
                    timer.Start();
                    Epr.SetError(txtCode, "اطلاعات درست وارد کنید");
                    Epr.SetError(txtPass, "اطلاعات درست وارد کنید");
                    Epr.SetError(txtUser, "اطلاعات درست وارد کنید");
                    //lblErro.Text = Epr.GetError(txtUser);
                }
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void Authentication_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCode.Clear();
            txtPass.Clear();
            txtUser.Clear();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
          
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            //lblErro.Text = "";
            timer.Enabled = false;
            timer.Stop();
            Epr.Dispose();
        }

        private void btnChngCode_Click(object sender, EventArgs e)
        {
            ChangePass ch = new ChangePass();
            ch.ShowDialog();
        }

        private void piCls_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();

        }

        private void panelEx1_Click(object sender, EventArgs e)
        {

        }

        private void piCls_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnChngCode_Click_1(object sender, EventArgs e)
        {
            Authentication.ActiveForm.Hide();
            ChangePass chp = new ChangePass();
            chp.ShowDialog();
            
        }
    }
}
