using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar.Validator;
using MessageBoxDll;
using Da;
using Oracle.ManagedDataAccess.Client;
namespace Presentation
{
    public partial class Report : Form
    {
        DataAccess d = new DataAccess();
        // private OracleConnection connection = DataAccess.connection;
        public Report()
        {
            InitializeComponent();
            d.cmdm.Connection = DataAccess.connection;
            DataAccess.Connect();
        }

        private void btnShowAllKala_Click(object sender, EventArgs e)
        {
           // OracleCommand command = new OracleCommand();
            
            OracleDataAdapter dataAdapter = new OracleDataAdapter();
            DataTable dataTable = new DataTable();
           // d.cmdm.Connection = connection;
            d.cmdm.CommandType = CommandType.Text;
            d.cmdm.CommandText = "Select * from Kala";
            dataAdapter.SelectCommand = d.cmdm;
            dataAdapter.Fill(dataTable);
            gridkala.DataSource = dataTable;

           // d.cmdm.Dispose();
            dataAdapter.Dispose();
            dataTable.Dispose();

           
        }

        private void btnOrderKala_Click(object sender, EventArgs e)
        {
            string order = string.Empty;
           // OracleCommand command = new OracleCommand();
            OracleDataAdapter dataAdapter = new OracleDataAdapter();
            DataTable dataTable = new DataTable();
            //command.Connection = connection; command.CommandType = CommandType.Text;

            if (radBrandKala.Checked == true)
                order = "Brand";
            else if (radIdKala.Checked == true)
                order = "Id";
            else if (radNamekala.Checked == true)
                order = "Name";
            else if (radTypekala.Checked == true)
                order = "Type";

            d.cmdm.CommandText = "select * from Kala order by " + order;
            dataAdapter.SelectCommand = d.cmdm;
            dataAdapter.Fill(dataTable);
            gridkala.DataSource = dataTable;

           // d.cmdm.Dispose();
            dataAdapter.Dispose();
            dataTable.Dispose();
        }

        private void btnSearchKala_Click(object sender, EventArgs e)
        {
          //  OracleCommand command = new OracleCommand();
            OracleDataAdapter dataAdapter = new OracleDataAdapter();
            DataTable dataTable = new DataTable();
          //  d.cmdm.Connection = connection;
            d.cmdm.CommandType = CommandType.Text;

            if (txtID_K.Text != string.Empty)
            {
                d.cmdm.CommandText = "Select * From Kala where ID = :p1 ";
                d.cmdm.Parameters.Add("p1", OracleDbType.Int32);
                d.cmdm.Parameters["p1"].Value = Convert.ToInt32(txtID_K.Text);
                dataAdapter.SelectCommand = d.cmdm;
                dataAdapter.Fill(dataTable);
                gridkala.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("فیلد مربوط به جستجو را پر کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

          //  d.cmdm.Dispose();
            dataAdapter.Dispose();
            dataTable.Dispose();
        }

        private void btnFilterKala_Click(object sender, EventArgs e)
        {
            string filter = string.Empty;
         //   OracleCommand command = new OracleCommand();
            OracleDataAdapter dataAdapter = new OracleDataAdapter();
            DataTable dataTable = new DataTable();
            // d.cmdm.Connection = connection; 
            d.cmdm.CommandType = CommandType.Text;

            if (radPriceKal.Checked == true)
                d.cmdm.CommandText = "select price from Kala";
            else if (radIdkal.Checked == true)
                d.cmdm.CommandText = "select id from Kala";
            else if (radNameKal.Checked == true)
                d.cmdm.CommandText = "select name from Kala";
            else if (radBrandkal.Checked == true)
                d.cmdm.CommandText = "select brand from Kala";


            //command.ExecuteNonQuery();
            dataAdapter.SelectCommand = d.cmdm;
            dataAdapter.Fill(dataTable);
            gridkala.DataSource = dataTable;

            //d.cmdm.Dispose();
            dataAdapter.Dispose();
            dataTable.Dispose();
        }

        private void btnPrintKala_Click(object sender, EventArgs e)
        {
            gridkala.ShowPreview();
        }
        //----------------------------------------------------------------------------------

        private void btnShowAllM_Click(object sender, EventArgs e)
        {
           // OracleCommand command = new OracleCommand();
            OracleDataAdapter dataAdapter = new OracleDataAdapter();
            DataTable dataTable = new DataTable();
            //  command.Connection = connection;
            d.cmdm.CommandType = CommandType.Text;
            d.cmdm.CommandText = "Select * from Moshtari";
            dataAdapter.SelectCommand = d.cmdm;
            dataAdapter.Fill(dataTable);
            gridMoshtari.DataSource = dataTable;

          //  d.cmdm.Dispose();
            dataAdapter.Dispose();
            dataTable.Dispose();
        }

        private void btnOrderM_Click(object sender, EventArgs e)
        {
            string order = string.Empty;
          //  OracleCommand command = new OracleCommand();
            OracleDataAdapter dataAdapter = new OracleDataAdapter();
            DataTable dataTable = new DataTable();
            // command.Connection = connection; 
            d.cmdm.CommandType = CommandType.Text;

            if (radOrderFamilyM.Checked == true)
                order = "Family";
            else if (radOrderIdM.Checked == true)
                order = "Id";
            else if (radOrderNameM.Checked == true)
                order = "Name";
            else if (radOrderTelM.Checked == true)
                order = "Tel";

            d.cmdm.CommandText = "select * from Moshtari order by " + order;
            dataAdapter.SelectCommand = d.cmdm;
            dataAdapter.Fill(dataTable);
            gridMoshtari.DataSource = dataTable;

          //  d.cmdm.Dispose();
            dataAdapter.Dispose();
            dataTable.Dispose();
        }

        private void btnFilterM_Click(object sender, EventArgs e)
        {
            string filter = string.Empty;
            //OracleCommand command = new OracleCommand();
            OracleDataAdapter dataAdapter = new OracleDataAdapter();
            DataTable dataTable = new DataTable();
          //  d.cmdm.Connection = connection;
            d.cmdm.CommandType = CommandType.Text;

            if (radFilterNameM.Checked == true)
                d.cmdm.CommandText = "select Name from Moshtari";
            else if (radFilterFamilyM.Checked == true)
                d.cmdm.CommandText = "select Family from Moshtari";
            else if (radFilterTelM.Checked == true)
                d.cmdm.CommandText = "select Tel from Moshtari";
            else if (radFilterIdM.Checked == true)
                d.cmdm.CommandText = "select Id from Moshtari";
            dataAdapter.SelectCommand = d.cmdm;
            dataAdapter.Fill(dataTable);
            gridMoshtari.DataSource = dataTable;

            //d.cmdm.Dispose();
            dataAdapter.Dispose();
            dataTable.Dispose();
        }

        private void btnPrintMo_Click(object sender, EventArgs e)
        {
            gridMoshtari.ShowPrintPreview();
        }

        private void bntSearchMo_Click(object sender, EventArgs e)
        {
           // OracleCommand command = new OracleCommand();
            OracleDataAdapter dataAdapter = new OracleDataAdapter();
            DataTable dataTable = new DataTable();
            //command.Connection = connection;
            d.cmdm.CommandType = CommandType.Text;

            if (txtSearchM.Text != string.Empty)
            {
                d.cmdm.CommandText = "Select * From Moshtari where ID = :p1 ";
                d.cmdm.Parameters.Add("p1", OracleDbType.Int32);
                d.cmdm.Parameters["p1"].Value = Convert.ToInt32(txtSearchM.Text);
                dataAdapter.SelectCommand = d.cmdm;
                dataAdapter.Fill(dataTable);
                gridMoshtari.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("فیلد مربوط به جستجو را پر کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

            //d.cmdm.Dispose();
            dataAdapter.Dispose();
            dataTable.Dispose();
        }
        //---------------------------------------------------------------------------------
        private void btnShowAllPro_Click(object sender, EventArgs e)
        {
           // OracleCommand command = new OracleCommand();
            OracleDataAdapter dataAdapter = new OracleDataAdapter();
            DataTable dataTable = new DataTable();
            // command.Connection = connection;
            d.cmdm.CommandType = CommandType.Text;
            d.cmdm.CommandText = "Select * from Provider";
            dataAdapter.SelectCommand = d.cmdm;
            dataAdapter.Fill(dataTable);
            gridProvider.DataSource = dataTable;

            //d.cmdm.Dispose();
            dataAdapter.Dispose();
            dataTable.Dispose();
        }

        private void btnPrintPro_Click(object sender, EventArgs e)
        {
            gridProvider.ShowPrintPreview();
        }

        private void btnOrderPro_Click(object sender, EventArgs e)
        {
            string order = string.Empty;
          //  OracleCommand command = new OracleCommand();
            OracleDataAdapter dataAdapter = new OracleDataAdapter();
            DataTable dataTable = new DataTable();
            //  command.Connection = connection; 
            d.cmdm.CommandType = CommandType.Text;

            if (radIdOrderPro.Checked == true)
                order = "ID";
            else if (radAddrOrderPro.Checked == true)
                order = "Com_Addr";
            else if (radNameOrderPro.Checked == true)
                order = "Com_Name";
            else if (radTelOrderPro.Checked == true)
                order = "Com_Tel";

            d.cmdm.CommandText = "select * from Provider order by " + order;
            dataAdapter.SelectCommand = d.cmdm;
            dataAdapter.Fill(dataTable);
            gridProvider.DataSource = dataTable;

           // d.cmdm.Dispose();
            dataAdapter.Dispose();
            dataTable.Dispose();
        }

        private void btnFilterPro_Click(object sender, EventArgs e)
        {
            string filter = string.Empty;
          //  OracleCommand command = new OracleCommand();
            OracleDataAdapter dataAdapter = new OracleDataAdapter();
            DataTable dataTable = new DataTable();
          //  d.cmdm.Connection = connection;
            d.cmdm.CommandType = CommandType.Text;

            if (radFilterAddrPro.Checked == true)
                d.cmdm.CommandText = "select Com_Addr from Provider";
            else if (radFilterIdPro.Checked == true)
                d.cmdm.CommandText = "select ID from Provider";
            else if (radFilterNamePro.Checked == true)
                d.cmdm.CommandText = "select Com_Name from Provider";
            else if (radFilterTelPro.Checked == true)
                d.cmdm.CommandText = "select Com_Tel from Provider";

            dataAdapter.SelectCommand = d.cmdm;
            dataAdapter.Fill(dataTable);
            gridProvider.DataSource = dataTable;

           // d.cmdm.Dispose();
            dataAdapter.Dispose();
            dataTable.Dispose();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            txtidm.Text = gridView1.GetRowCellDisplayText(e.FocusedRowHandle, "ID");
            txtNameM.Text = gridView1.GetRowCellDisplayText(e.FocusedRowHandle, "NAME");
            txtFamilyM.Text = gridView1.GetRowCellDisplayText(e.FocusedRowHandle, "FAMILY");
            txtTelM.Text = gridView1.GetRowCellDisplayText(e.FocusedRowHandle, "TEL");
        }

        private void piCls_Click(object sender, EventArgs e)
        {
            DataAccess.Disconnect();
            this.Close();
        }

        private void btnSearchPro_Click(object sender, EventArgs e)
        {
           // OracleCommand command = new OracleCommand();
            OracleDataAdapter dataAdapter = new OracleDataAdapter();
            DataTable dataTable = new DataTable();
           // d.cmdm.Connection = connection;
            d.cmdm.CommandType = CommandType.Text;

            if (txtId.Text != string.Empty)
            {
                d.cmdm.CommandText = "Select * From Provider where ID = :p1 ";
                d.cmdm.Parameters.Add("p1", OracleDbType.Int32);
                d.cmdm.Parameters["p1"].Value = Convert.ToInt32(txtId.Text);
                dataAdapter.SelectCommand = d.cmdm;
                dataAdapter.Fill(dataTable);
                gridProvider.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("فیلد مربوط به جستجو را پر کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

          //  d.cmdm.Dispose();
            dataAdapter.Dispose();
            dataTable.Dispose();
        }

        private void Select_Provider(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {

        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtID_K.Text = gridView2.GetRowCellDisplayText(e.FocusedRowHandle, "ID");
            txtName_k.Text = gridView2.GetRowCellDisplayText(e.FocusedRowHandle, "NAME");
            txtBrand_K.Text = gridView2.GetRowCellDisplayText(e.FocusedRowHandle, "BRAND");
            txtType_K.Text = gridView2.GetRowCellDisplayText(e.FocusedRowHandle, "TYPE");
            txtPrice_K.Text = gridView2.GetRowCellDisplayText(e.FocusedRowHandle, "PRICE");

        }

        private void SelectGrid3(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //txt.Text = gridView1.GetRowCellDisplayText(e.FocusedRowHandle, "ID");
            txtName_C.Text = gridView3.GetRowCellDisplayText(e.FocusedRowHandle, "COM_NAME");
            txtTel_c.Text = gridView3.GetRowCellDisplayText(e.FocusedRowHandle, "COM_TEL");
            txtAddr_C.Text = gridView3.GetRowCellDisplayText(e.FocusedRowHandle, "COM_ADDR");
            txtType_C.Text = gridView3.GetRowCellDisplayText(e.FocusedRowHandle, "COM_TYPE");
        }

        private void btnPrintFF_Click(object sender, EventArgs e)
        {
            gridFF.ShowPrintPreview();
        }

        private void btnShowALLFF_Click(object sender, EventArgs e)
        {
          //  OracleCommand command = new OracleCommand();
            OracleDataAdapter dataAdapter = new OracleDataAdapter();
            DataTable dataTable = new DataTable();
            //d.cmdm.Connection = connection;
            d.cmdm.CommandType = CommandType.Text;
            d.cmdm.CommandText = "Select * from FACTOR_FROOSH";
            dataAdapter.SelectCommand = d.cmdm;
            dataAdapter.Fill(dataTable);
            gridFF.DataSource = dataTable;

            //d.cmdm.Dispose();
            dataAdapter.Dispose();
            dataTable.Dispose();
        }

        private void btnSearchFF_Click(object sender, EventArgs e)
        {
            //OracleCommand command = new OracleCommand();
            OracleDataAdapter dataAdapter = new OracleDataAdapter();
            DataTable dataTable = new DataTable();
            //  command.Connection = connection;
            d.cmdm.CommandType = CommandType.Text;

            if (txtNOFF.Text != string.Empty)
            {
                d.cmdm.CommandText = "Select * From FACTOR_FROOSH where NO = :p1 ";
                d.cmdm.Parameters.Add("p1", OracleDbType.Int32);
                d.cmdm.Parameters["p1"].Value = Convert.ToInt32(txtNOFF.Text);
                dataAdapter.SelectCommand = d.cmdm;
                dataAdapter.Fill(dataTable);
                gridFF.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("فیلد مربوط به جستجو را پر کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

            //d.cmdm.Dispose();
            dataAdapter.Dispose();
            dataTable.Dispose();
        }

        private void btnFilterFF_Click(object sender, EventArgs e)
        {
            string filter = string.Empty;
           // OracleCommand command = new OracleCommand();
            OracleDataAdapter dataAdapter = new OracleDataAdapter();
            DataTable dataTable = new DataTable();
           // command.Connection = connection; command.CommandType = CommandType.Text;

            if (radCodeKFilterFF.Checked == true)
                d.cmdm.CommandText = "select IDKala from FACTOR_FROOSH";
            else if (radCodeMFilter_FF.Checked == true)
                d.cmdm.CommandText = "select IDMoshtari from FACTOR_FROOSH";
            else if (radPriceFilterFF.Checked == true)
                d.cmdm.CommandText = "select Price from FACTOR_FROOSH";
            else if (radNOFilterFF.Checked == true)
                d.cmdm.CommandText = "select NO No FACTOR_FROOSH";
            dataAdapter.SelectCommand = d.cmdm;
            dataAdapter.Fill(dataTable);
            gridFF.DataSource = dataTable;

           // d.cmdm.Dispose();
            dataAdapter.Dispose();
            dataTable.Dispose();
        }

        private void btnSortFF_Click(object sender, EventArgs e)
        {
            string order = string.Empty;
          //  OracleCommand command = new OracleCommand();
            OracleDataAdapter dataAdapter = new OracleDataAdapter();
            DataTable dataTable = new DataTable();
            //d.cmdm.Connection = connection;
            d.cmdm.CommandType = CommandType.Text;

            if (radCodeKSort_FF.Checked == true)
                order = "IDKALA";
            else if (radCodeMSort_FF.Checked == true)
                order = "IDMOSHTARI";
            else if (radNoSort_FF.Checked == true)
                order = "NO";
            else if (radPriceSort_FF.Checked == true)
                order = "PRICE";

            d.cmdm.CommandText = "select * from FACTOR_FROOSH order by " + order;
            dataAdapter.SelectCommand = d.cmdm;
            dataAdapter.Fill(dataTable);
            gridFF.DataSource = dataTable;

           // d.cmdm.Dispose();
            dataAdapter.Dispose();
            dataTable.Dispose();
        }

        private void gridView4_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtPrice_FF.Text = gridView4.GetRowCellDisplayText(e.FocusedRowHandle, "PRICE");
            txtCodeM_FF.Text = gridView4.GetRowCellDisplayText(e.FocusedRowHandle, "IDMOSHTARI");
            txtCodeK_FF.Text = gridView4.GetRowCellDisplayText(e.FocusedRowHandle, "IDKALA");
            txtDateFF.Text = gridView4.GetRowCellDisplayText(e.FocusedRowHandle, "FACTOR_DAY");
        }

        private void btnPrintFK_Click(object sender, EventArgs e)
        {
            FactorKH.ShowPrintPreview();
        }

        private void btnShowAllFK_Click(object sender, EventArgs e)
        {
           // OracleCommand command = new OracleCommand();
            OracleDataAdapter dataAdapter = new OracleDataAdapter();
            DataTable dataTable = new DataTable();
            //  command.Connection = connection;
            d.cmdm.CommandType = CommandType.Text;
            d.cmdm.CommandText = "Select * from FACTOR_KHARID";
            dataAdapter.SelectCommand = d.cmdm;
            dataAdapter.Fill(dataTable);
            FactorKH.DataSource = dataTable;

            //d.cmdm.Dispose();
            dataAdapter.Dispose();
            dataTable.Dispose();
        }

        private void btnFilterFK_Click(object sender, EventArgs e)
        {
            string filter = string.Empty;
           // OracleCommand command = new OracleCommand();
            OracleDataAdapter dataAdapter = new OracleDataAdapter();
            DataTable dataTable = new DataTable();
            // command.Connection = connection; 
            d.cmdm.CommandType = CommandType.Text;

            if (radIKalaFilterFK.Checked == true)
                d.cmdm.CommandText = "select IDKala from FACTOR_KHARID";
            else if (radFilterPROVIDERFK.Checked == true)
                d.cmdm.CommandText = "select IDPROVIDER from FACTOR_KHARID";
            else if (radPriceFilterFK.Checked == true)
                d.cmdm.CommandText = "select Price from FACTOR_KHARID";
            else if (radNOFilterFK.Checked == true)
                d.cmdm.CommandText = "select NO from FACTOR_KHARID";
            dataAdapter.SelectCommand = d.cmdm;
            dataAdapter.Fill(dataTable);
            FactorKH.DataSource = dataTable;

           // d.cmdm.Dispose();
            dataAdapter.Dispose();
            dataTable.Dispose();
        }

        private void btnSORTKH_Click(object sender, EventArgs e)
        {
            string order = string.Empty;
            //OracleCommand command = new OracleCommand();
            OracleDataAdapter dataAdapter = new OracleDataAdapter();
            DataTable dataTable = new DataTable();
            // command.Connection = connection;
            d.cmdm.CommandType = CommandType.Text;

            if (radSortIKALAFK.Checked == true)
                order = "IDKALA";
            else if (radSortPROVIDERFK.Checked == true)
                order = "IDPROVIDER";
            else if (radSortNoFK.Checked == true)
                order = "NO";
            else if (radSortPriceFk.Checked == true)
                order = "PRICE";

            d.cmdm.CommandText = "select * from FACTOR_KHARID order by " + order;
            dataAdapter.SelectCommand = d.cmdm;
            dataAdapter.Fill(dataTable);
            FactorKH.DataSource = dataTable;

            //d.cmdm.Dispose();
            dataAdapter.Dispose();
            dataTable.Dispose();
        }

        private void btnSearchFk_Click(object sender, EventArgs e)
        {
          //  OracleCommand command = new OracleCommand();
            OracleDataAdapter dataAdapter = new OracleDataAdapter();
            DataTable dataTable = new DataTable();
            // command.Connection = connection;
            d.cmdm.CommandType = CommandType.Text;

            if (txtNOFK.Text != string.Empty)
            {
                d.cmdm.CommandText = "Select * From FACTOR_KHARID where NO = :p1 ";
                d.cmdm.Parameters.Add("p1", OracleDbType.Int32);
                d.cmdm.Parameters["p1"].Value = Convert.ToInt32(txtNOFK.Text);
                dataAdapter.SelectCommand = d.cmdm;
                dataAdapter.Fill(dataTable);
                FactorKH.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("فیلد مربوط به جستجو را پر کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

           // d.cmdm.Dispose();
            dataAdapter.Dispose();
            dataTable.Dispose();
        }

        private void gridView5_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtPriceFK.Text = gridView5.GetRowCellDisplayText(e.FocusedRowHandle, "PRICE");
            txtIProvierFK.Text= gridView5.GetRowCellDisplayText(e.FocusedRowHandle, "IDPROVIDER");
            txtCodeMoshtariFK.Text = gridView5.GetRowCellDisplayText(e.FocusedRowHandle, "IDKALA");
            txtDateFk.Text = gridView5.GetRowCellDisplayText(e.FocusedRowHandle, "FACTOR_DAY");
        }
    }
}
