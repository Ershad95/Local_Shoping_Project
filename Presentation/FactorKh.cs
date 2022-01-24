using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Da;
using Oracle.ManagedDataAccess.Client;

namespace Presentation
{
    public partial class FactorKh : Form
    {
        
        private int Tsum = 0;
        public FactorKh()
        {
            InitializeComponent();
        }

        private void btnComit_Click(object sender, EventArgs e)
        {
            (new Insert()).FactorKH((Convert.ToInt32(txtNo.Text)),Convert.ToInt32(cmbIDP.Text),Convert.ToInt32(cmbIDK.Text),Convert.ToInt32(txtPrice.Text),Convert.ToInt32(txtCount.Text),txtDate.Text);
        }

        private void FactorKh_Load(object sender, EventArgs e)
        {
            DataAccess.Connect();
            OracleCommand cmd_Provider = new OracleCommand("select * from Provider", DataAccess.connection);
            OracleCommand cmd_Kala = new OracleCommand("select * from Kala", DataAccess.connection);



            OracleDataReader dataReader_kala = cmd_Kala.ExecuteReader();
            OracleDataReader dataReader_Provider = cmd_Provider.ExecuteReader();

            while (dataReader_kala.Read())
            {
                cmbIDK.Items.Add(dataReader_kala.GetInt32(0)+"+"+dataReader_kala.GetString(1)+"+"+dataReader_kala.GetString(2));
            }
            while (dataReader_Provider.Read())
            {
                cmbIDP.Items.Add(dataReader_Provider.GetInt32(0) + "+" + dataReader_Provider.GetString(1) + "+" + dataReader_Provider.GetString(3));
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPrice.Clear();
            txtCount.Clear();
            txtDate.Clear();
            txtNo.Clear();
            cmbIDK.Text = "";
            cmbIDP.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DataAccess.Disconnect();
            this.Close();
        }

        private void piCls_Click(object sender, EventArgs e)
        {
            btnExit_Click(null,null);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string[] arr = new string[5];
            ListViewItem itm;
            string[] idp = cmbIDP.Text.Split('+');
            string[] idk = cmbIDK.Text.Split('+');
            arr[0] = txtDate.Text;
            arr[1] = idk[0];
            arr[2] = idp[0];
            arr[3] = txtCount.Text;
            arr[4] = txtPrice.Text;
            itm = new ListViewItem(arr);
            listView1.Items.Add(itm);

            string tmp = null;
            string[] strings = txtPrice.Text.Split(',');
            for (int i = 0; i < strings.Length; i++)
            {

                tmp += strings[i];
            }
            int price = Convert.ToInt32(tmp);
            int count = Convert.ToInt32(txtCount.Text);
            int result = price * count;
            Tsum += result;
            txtTsum.Text = Tsum.ToString();
            (new Insert()).FactorKH(Convert.ToInt32(txtNo.Text), Convert.ToInt32(idp[0]), Convert.ToInt32(idk[0]), Convert.ToInt32(tmp), Convert.ToInt32(txtCount.Text), txtDate.Text);
        }

     
        private void txtPrice_Leave(object sender, EventArgs e)
        {
            int amount = 0;
            if (int.TryParse(txtPrice.Text, NumberStyles.Currency, null, out amount))
            {
                txtPrice.Text = amount.ToString("N0");
            }
        }
    }
}
