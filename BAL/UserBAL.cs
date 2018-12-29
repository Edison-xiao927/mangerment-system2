using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class UserBAL
    {
        public bool Update(string a, string b, string c,string d)
        {
            return new UserDAL().update(a, b, c, d );
        }
        public bool Update2(string a, DateTime b, string c, string d)
        {
            return new UserDAL().update2(a, b, c, d);
        }
        public bool Insert(int a, string b, DateTime c, string d, string e, string f, DateTime g, string h, string i, DateTime j, string k, string l, string m, string n)
        {
            return new UserDAL().insert(a, b, c, d, e, f, g, h, i, j, k, l, m, n);
        }
    }
}
