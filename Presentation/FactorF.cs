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
    public partial class FactorF : Form
    {
        OracleConnection con = DataAccess.connection;
        private string[] name = new string[1000];
        private int[] id = new int[1000];
        private int Tsum = 0;
        private int index = 0;
        private int index2 = 0;
       
       
        public FactorF()
        {
            InitializeComponent();


        }

        private void FactorF_Load(object sender, EventArgs e)
        {
            DataAccess.Connect();
            Refresh();
            txtPrice.BackColor = Color.White;
            txtPrice.ForeColor = Color.Black;
        }

        private void btnComit_Click(object sender, EventArgs e)
        {
            
          


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPrice.Clear();
            txtCount.Clear();
            txtDate.Clear();
            txtNo.Clear();
            cmbIDK.Text = "";
            cmbIDM.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DataAccess.Disconnect();
            this.Close();

        }

        private void piCls_Click(object sender, EventArgs e)
        {
            btnExit_Click(null, null);
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            string[] arr = new string[5];
            ListViewItem itm;
            string[] id = cmbIDM.Text.Split('+');
            string[] idk = cmbIDK.Text.Split('+');
            arr[0] = txtDate.Text;
            arr[1] = id[0];
            arr[2] = idk[0];
            arr[3] = txtCount.Text;
            arr[4] = txtPrice.Text;
            itm = new ListViewItem(arr);
            listView.Items.Add(itm);

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
            (new Insert()).FactorF(Convert.ToInt32(txtNo.Text), Convert.ToInt32(id[0]), Convert.ToInt32(idk[0]), Convert.ToInt32(tmp), Convert.ToInt32(txtCount.Text), txtDate.Text);
        }



        private void txtPrice_Leave(object sender, EventArgs e)
        {
            int amount = 0;
            if (int.TryParse(txtPrice.Text, NumberStyles.Currency, null, out amount))
            {
                txtPrice.Text = amount.ToString("N0");
            }
        }
        private void btnAd_Click(object sender, EventArgs e)
        {
            buttonX1_Click(null, null);
        }
        private void Refresh()
        {
            OracleCommand cmd_Moshtari = new OracleCommand("select * from Moshtari", con);
            OracleCommand cmd_Kala = new OracleCommand("select * from Kala", con);
            OracleDataReader dataReader_kala = cmd_Kala.ExecuteReader();
            OracleDataReader dataReader_Moshtari = cmd_Moshtari.ExecuteReader();
            cmbIDK.Items.Clear();
            cmbIDM.Items.Clear();
            while (dataReader_kala.Read())
            {
                cmbIDK.Items.Add(dataReader_kala.GetInt32(0) + "+" + dataReader_kala.GetString(1) + "+" + dataReader_kala.GetString(2));
                cmbIDK.AutoCompleteCustomSource.Add(dataReader_kala.GetInt32(0) + "+" + dataReader_kala.GetString(1) + "+" + dataReader_kala.GetString(2));
            }
            while (dataReader_Moshtari.Read())
            {

                cmbIDM.ValueMember = dataReader_Moshtari.GetInt32(0).ToString();
                cmbIDM.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cmbIDM.AutoCompleteSource = AutoCompleteSource.CustomSource;
                cmbIDM.Items.Add(dataReader_Moshtari.GetInt32(0) + "+" + dataReader_Moshtari.GetString(1) + "+" + dataReader_Moshtari.GetString(2));
                cmbIDM.AutoCompleteCustomSource.Add(dataReader_Moshtari.GetInt32(0) + "+" + dataReader_Moshtari.GetString(1) + "+" + dataReader_Moshtari.GetString(2));
            }
            cmd_Moshtari.Dispose();
            cmd_Kala.Dispose();
            dataReader_kala.Dispose();
            dataReader_Moshtari.Dispose();
        }

        private void EventRefresh(object sender, EventArgs e)
        {
            Refresh();
        }

        private void cmbIDK_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand cmd_kala = new OracleCommand("select price from kala where id = :p1", con);
            string[] str = cmbIDK.Text.Split('+');
            cmd_kala.Parameters.Add("p1", OracleDbType.NVarchar2).Value = str[0];
            string pstr = cmd_kala.ExecuteScalar().ToString();
            float x = Convert.ToInt32(pstr);
            double profit = x*(20.00 / 100.00);
            double price = profit + x;
            txtPrice.Text = price.ToString();
        }
    }
}
