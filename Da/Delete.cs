using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace Da
{
    public class Delete : DataAccess,IData
    {
        DataAccess d = new DataAccess();
        public Delete()
        {
            d.cmdm.Connection = DataAccess.connection;
        }
        public void Moshtari(int id, string name, string family, string tel)
        {
            d.cmdm.CommandType = CommandType.StoredProcedure;
            d.cmdm.CommandText = "PROC_DELETE_M";
            d.cmdm.Parameters.Add("iid", OracleDbType.Int32).Value = id;
            d.cmdm.ExecuteNonQuery();
        }

        public void Kala(int id, string name, string brand, string type, int price=0)
        {
            d.cmdm.CommandType = CommandType.StoredProcedure;
            d.cmdm.CommandText = "PROC_DELETE_K";
            d.cmdm.Parameters.Add("I", OracleDbType.Int32).Value = id;
            d.cmdm.ExecuteNonQuery();
        }

        public void Provider(int id, string com_name, string com_tel, string com_addr, string type)
        {
            d.cmdm.CommandType = CommandType.StoredProcedure;
            d.cmdm.CommandText = "PROC_DELETE_P";
            d.cmdm.Parameters.Add("I", OracleDbType.Int32).Value = id;
            d.cmdm.ExecuteNonQuery();
        }

        public void FactorF(int no, int idm, int idk, int price, int count, string date)
        {
            d.cmdm.CommandType = CommandType.StoredProcedure;
            d.cmdm.CommandText = "PROC_DELETE_FF";
            d.cmdm.Parameters.Add("NOOO", OracleDbType.Int32).Value = no;
            d.cmdm.ExecuteNonQuery();
        }

        public void FactorKH(int no, int idp, int idk, int price, int count, string date)
        {
            d.cmdm.CommandType = CommandType.StoredProcedure;
            d.cmdm.CommandText = "PROC_DELETE_fk";
            d.cmdm.Parameters.Add("NOOO", OracleDbType.Int32).Value = no;
            d.cmdm.ExecuteNonQuery();
        }


        public void Users()
        {
            
        }

        public void DeleteAll(string table)
        {
            d.cmdm.CommandType = CommandType.StoredProcedure;
            d.cmdm.CommandText = "PROC_DeleteAll";
            d.cmdm.Parameters.Add("tbl", OracleDbType.NVarchar2).Value = table;
            d.cmdm.ExecuteNonQuery();
        }
    }
}
