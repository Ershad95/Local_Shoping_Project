using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Da;
using Oracle.ManagedDataAccess.Client;

namespace Presentation
{
    public partial class EditM : Form
    {
        public EditM(bool detect)
        {
            InitializeComponent();
            DataAccess.Connect();
            OracleCommand cmd = new OracleCommand()
            {
                CommandType = CommandType.Text,
                CommandText = "select * from moshtari",
                Connection = DataAccess.connection
            };
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cmbDeleteM.Items.Add(reader.GetInt32(0) + "---" + reader.GetString(1) + "---" + reader.GetString(2));
                cmbDeleteM.AutoCompleteCustomSource.Add(reader.GetInt32(0) + "---" + reader.GetString(1) + "---" + reader.GetString(2));
                cmbUpdateM.Items.Add(reader.GetInt32(0) + "---" + reader.GetString(1) + "---" + reader.GetString(2));
                cmbUpdateM.AutoCompleteCustomSource.Add(reader.GetInt32(0) + "---" + reader.GetString(1) + "---" + reader.GetString(2));
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtFamily.Clear();
            txtTel.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DataAccess.Disconnect();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataAccess.Connect();
            string[] s = cmbDeleteM.Text.Split('-');
            (new Delete()).Moshtari(Convert.ToInt32(s[0]),null,null,null);
            DataAccess.Disconnect();
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            DataAccess.Connect();
            (new Delete()).DeleteAll("moshtari");
            DataAccess.Disconnect();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataAccess.Connect();
            string[] s = cmbUpdateM.Text.Split('-');
            (new Update()).Moshtari(Convert.ToInt32(s[0]),txtName.Text,txtFamily.Text,txtTel.Text);
            DataAccess.Disconnect();
        }

        private void piCls_Click(object sender, EventArgs e)
        {
            btnExit_Click(null, null);
        }

        private void EditM_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataAccess.Disconnect();
        }

        private void cmbUpdateM_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] s = cmbUpdateM.Text.Split('-');
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = DataAccess.connection;
            cmd.CommandText = "select * from moshtari where id = :p";
            cmd.Parameters.Add("p", OracleDbType.Int32).Value = Convert.ToInt32(s[0]);
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtName.Text = reader.GetString(1);
                txtFamily.Text = reader.GetString(2);
                txtTel.Text = reader.GetString(3);
            }


        }
    }
}
