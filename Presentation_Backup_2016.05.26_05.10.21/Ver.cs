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
    public partial class Ver : Form
    {
        public Ver()
        {
            InitializeComponent();
        }

        private void piCls_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChanges_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
