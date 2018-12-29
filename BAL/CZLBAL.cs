using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class CZLBAL
    {
        public DataTable Select2(string str, string c)
        {
            return new CZLDAL().Select2(str, c);
        }
        public DataTable Select112(string str, string c)
        {
            return new CZLDAL().select112(str, c);
        }
        public DataTable Select113(string str, string c)
        {
            return new CZLDAL().select113(str, c);
        }
        public DataTable Select4(string str)
        {
            return new CZLDAL().Select4(str);
        }
        public DataTable Select114(string a, string b)
        {
            return new CZLDAL().Select114(a, b);
        }
        public DataTable Select3(string str)
        {
            return new CZLDAL().Select3(str);
        }
        //案卷查询修改
        public DataTable Select77(string str)
        {
            return new CZLDAL().Select77(str);
        }
        public DataTable Select8(string str, string str2)
        {
            return new CZLDAL().Select8(str, str2);
        }
        public DataTable Select7777(string str, string str1)
        {
            return new CZLDAL().Select7777(str, str1);
        }
        //文件查询修改
        public DataTable Select777(string str, string str2)
        {
            return new CZLDAL().Select777(str, str2);
        }
        public DataTable Select77777(string str, string str1)
        {
            return new CZLDAL().Select77777(str, str1);
        }
        public DataTable Select115(string a, string b, string c)
        {
            return new CZLDAL().Select115(a, b, c);
        }
        //
        public DataTable Select5(string str, string a, string b, string c, string d, string e)
        {
            return new CZLDAL().Select5(str,a,b,c,d,e);
        }
        public DataTable Select6(string str, string a, string b, string c, string d, string e)
        {
            return new CZLDAL().Select6(str, a, b, c, d, e);
        }
        public DataTable Select1214()
        {
            return new CZLDAL().Select1214();
        }
        public bool insert1122(string a, string b, string c, string d, string e, string f)
        {
            return new CZLDAL().insert1122(a, b, c, d, e, f);
        }
        public bool insert110(string a, string b, string c, string d, string e, string f, string g)//
        {
            return new CZLDAL().insert110(a, b, c, d, e, f, g);
        }
        public bool insert(string a, string b, string c)
        {
            return new CZLDAL().insert(a, b, c);
        }
        public bool Update112(string a, string b, string c)
        {
            return new CZLDAL().update112(a, b, c);
        }
        public bool Delete(string a, string b, string c)
        {
            return new CZLDAL().delete(a, b, c);
        }
        public bool Delete2(string a, string b, string c, string d)
        {
            return new CZLDAL().delete2(a, b, c, d);
        }
        public bool Delete3(string a, string b, string c, string d)
        {
            return new CZLDAL().delete3(a, b, c, d);
        }
        public bool Delete4(string a)
        {
            return new CZLDAL().delete4(a);
        }
    }
}
