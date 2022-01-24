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
    public partial class EditK : Form
    {
        
        public EditK(bool detect)
        {
            InitializeComponent();

            DataAccess.Connect();
            OracleCommand cmd = new OracleCommand()
            {
                CommandType = CommandType.Text,
                CommandText = "select * from kala",
                Connection = DataAccess.connection
            };
            OracleDataReader  reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cmbDeleteK.Items.Add(reader.GetInt32(0) + "---" + reader.GetString(1) + "---" + reader.GetString(2));
                cmbUpdateK.Items.Add(reader.GetInt32(0) + "---" + reader.GetString(1) + "---" + reader.GetString(2));
                cmbDeleteK.AutoCompleteCustomSource.Add(reader.GetInt32(0) + "---" + reader.GetString(1) + "---" + reader.GetString(2));
                cmbUpdateK.AutoCompleteCustomSource.Add(reader.GetInt32(0) + "---" + reader.GetString(1) + "---" + reader.GetString(2));
            }


            if (detect == true)
            {
                GroupUpdate.Enabled = true;
                GroupDelete.Enabled = false;
            }
            else
            {
                GroupUpdate.Enabled = false;
                GroupDelete.Enabled = true;
            }
        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            DataAccess.Connect();
            (new Delete()).DeleteAll("Kala");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string[] s = cmbDeleteK.Text.Split('-');
            DataAccess.Connect();
            (new Delete()).Kala(Convert.ToInt32(s[0]), null, null, null, 0);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DataAccess.Disconnect();
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            txtName.Clear();
            txtBrand.Clear();
            txtPrice.Clear();
            txttype.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataAccess.Connect();
            string[] s = cmbUpdateK.Text.Split('-');
            (new Update()).Kala(Convert.ToInt32(s[0]), txtName.Text, txtBrand.Text, txttype.Text, Convert.ToInt32(txtPrice.Text));
        }

        private void piCls_Click(object sender, EventArgs e)
        {
            btnExit_Click(null, null);
        }

        private void cmbUpdateK_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] s = cmbUpdateK.Text.Split('-');
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = DataAccess.connection;
            cmd.CommandText = "select * from kala where id = :p";
            cmd.Parameters.Add("p", OracleDbType.Int32).Value = Convert.ToInt32(s[0]);
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtName.Text = reader.GetString(1);
                txtBrand.Text = reader.GetString(2);
                txttype.Text = reader.GetString(3);
                txtPrice.Text = Convert.ToString(reader.GetInt32(4));
            }

        }
    }
}
