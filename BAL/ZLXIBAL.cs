using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class ZLXIBAL
    {
        public DataTable Select1()
        {
            return new ZLXIDAL().Select1();
        }
        public DataTable Select2(string a,string b)
        {
            return new ZLXIDAL().Select2(a,b);
        }
        public DataTable Select3(string str)
        {
            return new ZLXIDAL().Select3(str);
        }
        public DataTable Select4(string str)
        {
            return new ZLXIDAL().Select4(str);
        }
        public DataTable Select5(string str)
        {
            return new ZLXIDAL().Select5(str);
        }
        public DataTable Select6(string str)
        {
            return new ZLXIDAL().Select6(str);
        }
        public DataTable Select7(string str)
        {
            return new ZLXIDAL().Select7(str);
        }
        public DataTable Select8(string str,string str2)
        {
            return new ZLXIDAL().Select8(str,str2);
        }
        public DataTable Select99(string str, string str2)
        {
            return new ZLXIDAL().Select99(str, str2);
        }
        public DataTable Select9(string str)
        {
            return new ZLXIDAL().Select9(str);
        }
        public bool Delete(string a,string b,string c)
        {
            return new ZLXIDAL().delete(a,b,c);
        }
        public bool Delete2(string a,string b,string c, string d)
        {
            return new ZLXIDAL().delete2(a,b,c,d);
        }
        public bool Delete3(string a,string b, string c, string d)
        {
            return new ZLXIDAL().delete3(a,b,c,d);
        }
        public bool Delete4(string a)
        {
            return new ZLXIDAL().delete4(a);
        }
        public DataTable Select1128(string str)
        {
            return new ZLXIDAL().Select1128(str);
        }
        public DataTable Select112801(string str)
        {
            return new ZLXIDAL().Select112801(str);
        }
    }
}
