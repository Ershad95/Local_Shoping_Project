using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Da
{
  public interface IData
  {
       void Moshtari(int id, string name, string family, string tel);
       void Kala(int id, string name, string brand, string type, int price);
       void Provider(int id, string com_name, string com_tel, string com_addr, string type);
       void FactorF(int no, int idm, int idk, int price, int count, string date);
       void FactorKH(int no, int idp, int idk, int price, int count, string date);
       void Users();
  }
}
