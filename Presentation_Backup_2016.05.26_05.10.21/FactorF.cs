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
        OracleConnection con = (new DataAccess()).connection;
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
            con.Open();
            OracleCommand cmd_Moshtari =new OracleCommand("select * from Moshtari",con);
            OracleCommand cmd_Kala = new OracleCommand("select * from Kala", con);
           

            OracleDataReader dataReader_kala =     cmd_Kala.ExecuteReader();
            OracleDataReader dataReader_Moshtari = cmd_Moshtari.ExecuteReader();


            while (dataReader_kala.Read())
            {
                cmbIDK.Items.Add(dataReader_kala.GetInt32(0));
            }
            while (dataReader_Moshtari.Read())
            {
                cmbIDM.Items.Add(dataReader_Moshtari.GetInt32(0));
                name[index] = dataReader_Moshtari.GetString(1);
                id[index2] = dataReader_Moshtari.GetInt32(0);
                ++index;
            }
        }

        private void btnComit_Click(object sender, EventArgs e)
        {
           
            (new Insert()).FactorF(Convert.ToInt32(txtNo.Text),Convert.ToInt32(cmbIDM.Text),Convert.ToInt32(cmbIDK.Text),Convert.ToInt32(txtPrice.Text),Convert.ToInt32(txtCount.Text),txtDate.Text);

             
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
            (new DataAccess()).Disconnect();
            this.Close();
            
        }

        private void piCls_Click(object sender, EventArgs e)
        {
            btnExit_Click(null,null);
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            string[] arr = new string[5];
            ListViewItem itm;

            arr[0] = txtDate.Text;
            arr[1] = cmbIDM.Text;
            arr[2] = cmbIDM.Text;
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
        }

        private void panelEx2_Click(object sender, EventArgs e)
        {

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
