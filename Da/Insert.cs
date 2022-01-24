using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
namespace Da
{
    public class Insert : DataAccess, IData
    {
        DataAccess d = new DataAccess();
        public Insert()
        {
            d.cmdm.Connection = DataAccess.connection;
        }
        public void Moshtari(int id, string name, string family, string tel)
        {
            d.cmdm.CommandType = CommandType.StoredProcedure;
            d.cmdm.CommandText = "PROC_INSERT_M";
            d.cmdm.Parameters.Add("I", OracleDbType.Int32).Value = id;
            d.cmdm.Parameters.Add("N", OracleDbType.NVarchar2).Value = name;
            d.cmdm.Parameters.Add("F", OracleDbType.NVarchar2).Value = family;
            d.cmdm.Parameters.Add("T", OracleDbType.NVarchar2).Value = tel;
            d.cmdm.ExecuteNonQuery();
        }

        public void Kala(int id, string name, string brand, string type, int price)
        {
            d.cmdm.CommandType = CommandType.StoredProcedure;
            d.cmdm.CommandText = "PROC_INSERT_K";
            d.cmdm.Parameters.Add("I", OracleDbType.Int32).Value = id;
            d.cmdm.Parameters.Add("N", OracleDbType.NVarchar2).Value = name;
            d.cmdm.Parameters.Add("B", OracleDbType.NVarchar2).Value = brand;
            d.cmdm.Parameters.Add("T", OracleDbType.NVarchar2).Value = type;
            d.cmdm.Parameters.Add("P", OracleDbType.Double).Value = price;
            d.cmdm.ExecuteNonQuery();
        }

        public void Provider(int id, string com_name, string com_tel, string com_addr, string type)
        {
            d.cmdm.CommandType = CommandType.StoredProcedure;
            d.cmdm.CommandText = "PROC_INSERT_P";
            d.cmdm.Parameters.Add("I", OracleDbType.Int32).Value = id;
            d.cmdm.Parameters.Add("CN", OracleDbType.NVarchar2).Value = com_name;
            d.cmdm.Parameters.Add("CT", OracleDbType.NVarchar2).Value = com_tel;
            d.cmdm.Parameters.Add("CA", OracleDbType.NVarchar2).Value = com_addr;
            d.cmdm.Parameters.Add("CTYPE", OracleDbType.NVarchar2).Value = type;
            d.cmdm.ExecuteNonQuery();
        }

        public void FactorF(int no, int idm, int idk, int price, int count, string date)
        {
            d.cmdm.CommandType = CommandType.StoredProcedure;
            d.cmdm.CommandText = "PROC_INSERT_FF";
            d.cmdm.Parameters.Add("I", OracleDbType.Int32).Value = no;
            d.cmdm.Parameters.Add("IM", OracleDbType.Int32).Value = idm;
            d.cmdm.Parameters.Add("IK", OracleDbType.Int32).Value = idk;
            d.cmdm.Parameters.Add("P", OracleDbType.Double).Value = price;
            d.cmdm.Parameters.Add("C", OracleDbType.Int32).Value = count;
            d.cmdm.Parameters.Add("DaY", OracleDbType.NVarchar2).Value = date;
            d.cmdm.ExecuteNonQuery();
        }

        public void FactorKH(int no, int idp, int idk, int price, int count, string date)
        {
            
            d.cmdm.Connection = DataAccess.connection;
            d.cmdm.CommandType = CommandType.StoredProcedure;
            d.cmdm.CommandText = "PROC_INSERT_FK";
            d.cmdm.Parameters.Add("I", OracleDbType.Int32).Value = no;
            d.cmdm.Parameters.Add("IP", OracleDbType.Int32).Value = idp;
            d.cmdm.Parameters.Add("IK", OracleDbType.Int32).Value = idk;
            d.cmdm.Parameters.Add("P", OracleDbType.Double).Value = price;
            d.cmdm.Parameters.Add("C", OracleDbType.Int32).Value = count;
            d.cmdm.Parameters.Add("DAY", OracleDbType.Varchar2).Value = date;
            d.cmdm.ExecuteNonQuery();

        }

        public void Users()
        {
            
        }
    }
}
