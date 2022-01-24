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
    public partial class Specification : Form
    {
        int st = -1;
        private int count=1;

        public Specification()
        {
            InitializeComponent();
        }

        private void Tim_Tick(object sender, EventArgs e)
        {
            
            if (count ==5)
            {
                int a = st;
                Properties.Settings.Default.Save();
                Specification.ActiveForm.Hide();
                Tim.Stop();
                Tim.Enabled = false;
                (new Authentication()).ShowDialog();
               
            }
           ++count;
        }

        private void picC_U_Click(object sender, EventArgs e)
        {

            if (st == -1)
            {
                picC_U.Image = Properties.Resources.c;
                Properties.Settings.Default.s = false;
               
            }
            else if (st == 1)
            {
                picC_U.Image = Properties.Resources.unc;
                Properties.Settings.Default.s = true;
                
            }

            st *= -1;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
