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
    public partial class EditP : Form
    {
        public EditP(bool detect)
        {
            InitializeComponent();
            DataAccess.Connect();
            OracleCommand cmd = new OracleCommand()
            {
                CommandType = CommandType.Text,
                CommandText = "select * from provider",
                Connection = DataAccess.connection
            };
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cmbDeleteP.Items.Add(reader.GetInt32(0) + "---" + reader.GetString(1) + "---" + reader.GetString(3));
                cmbDeleteP.AutoCompleteCustomSource.Add(reader.GetInt32(0) + "---" + reader.GetString(1) + "---" + reader.GetString(3));
                cmbUpdateP.AutoCompleteCustomSource.Add(reader.GetInt32(0) + "---" + reader.GetString(1) + "---" + reader.GetString(3));
                cmbUpdateP.Items.Add(reader.GetInt32(0) + "---" + reader.GetString(1) + "---" + reader.GetString(3));
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

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            DataAccess.Connect();
            (new Delete()).DeleteAll("Provider");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string[] s = cmbDeleteP.Text.Split('-');
            DataAccess.Connect();
            (new Delete()).Provider(Convert.ToInt32(s[0]), null, null, null, null);
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtAddr.Clear();
            txtTel.Clear();
            txttype.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataAccess.Connect();
            string[] s = cmbUpdateP.Text.Split('-');
            (new Update()).Provider(Convert.ToInt32(s[0]),txtName.Text,txtTel.Text,txtAddr.Text,txttype.Text);
            DataAccess.Disconnect();
        }

        private void EditP_Load(object sender, EventArgs e)
        {

        }

        private void cmbUpdateP_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] s = cmbUpdateP.Text.Split('-');
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = DataAccess.connection;
            cmd.CommandText = "select * from provider where id = :p";
            cmd.Parameters.Add("p", OracleDbType.Int32).Value = Convert.ToInt32(s[0]);
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtName.Text = reader.GetString(1);
                txtTel.Text = reader.GetString(2);
                txtAddr.Text = reader.GetString(3);
                txttype.Text = reader.GetString(4);
            }
        }
    }
}
