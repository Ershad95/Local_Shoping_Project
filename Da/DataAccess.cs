using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;

namespace Da
{
    public class DataAccess
    {
        //     Local = "DATA SOURCE=localhost:1521/xe;User Id=ershad;Password=13741374;"
        //     Server = "DATA SOURCE=192.168.0.76:1521/orcl;User Id=ershad;Password=13741374;"
        public static OracleConnection connection = new OracleConnection("DATA SOURCE=localhost:1521/xe;User Id=ershad;Password=13741374;");
        // public static OracleCommand command =new OracleCommand();
        public OracleCommand cmdm = new OracleCommand();
        //------------------------------------------

        public static bool Connect()
        {

            if (connection.State != ConnectionState.Open)
            {
                // command.Connection = connection;
                connection.Open();
                MessageBox.Show("Connect...");
                Debug.Write("Connect to DB");
                return true;
            }
            return false;
        }
        public static bool Disconnect()
        {
            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
                MessageBox.Show("Disconnect...");
                Debug.Write("DisConnect From DB");
                return true;
            }
            return false;
        }



        //--------------------------------Insert Operation------------------------------------------

        //--------------------------------Update Operation-----------------------------------------

        //--------------------------------Delete Operation-----------------------------------

    }
}
