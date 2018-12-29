using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class ZLBAL
    {
        public DataTable Select(string a)
        {
            return new ZLDAL().Select(a);
        }
        public DataTable Select1(string str)
        {
            return new ZLDAL().Select1(str);
        }
        public DataTable Select2(string str,string c)
        {
            return new ZLDAL().Select2(str,c);
        }
        public DataTable Select112(string str,string c)
        {
            return new ZLDAL().select112(str,c);
        }
        public DataTable Select113(string str, string c)
        {
            return new ZLDAL().select113(str, c);
        }
        public DataTable Select1113(string str,string b)
        {
            return new ZLDAL().Select1113(str,b);
        }
        public DataTable Select3(string str)
        {
            return new ZLDAL().Select3(str);
        }
        public DataTable Select4(string str)
        {
            return new ZLDAL().Select4(str);
        }
        public DataTable Select5(string a, string b)
        {
            return new ZLDAL().Select5(a, b);
        }
        public bool Update(string a, string b)
        {
            return new ZLDAL().update(a, b);
        }
        public DataTable Select6(string a)
        {
            return new ZLDAL().Select6(a);
        }
        public DataTable Select7(string a, string b, string c)
        {
            return new ZLDAL().Select7(a, b, c);
        }
        public DataTable Select8(string a, string b)
        {
            return new ZLDAL().Select8(a, b);
        }
        public DataTable Select9(string a, string b,string c,string d)
        {
            return new ZLDAL().Select9(a, b, c, d);
        }
        public DataTable Select10(string a, string b,string c)
        {
            return new ZLDAL().Select10(a, b, c);
        }
        public DataTable Select11(string a, string b,string c)
        {
            return new ZLDAL().Select11(a, b, c);
        }
        public DataTable Select12(string a, string b)
        {
            return new ZLDAL().Select12(a, b);
        }
        public DataTable Select13(string a, string b)
        {
            return new ZLDAL().Select13(a, b);
        }
        public DataTable Select14(string a, string b)
        {
            return new ZLDAL().Select14(a, b);
        }
        public DataTable Select15(string a, string b, string c, string d, string e,string f,string g)
        {
            return new ZLDAL().Select15(a, b, c, d, e, f , g);
        }
        public DataTable Select16(string a, string b, string c, string d, string e, string f)
        {
            return new ZLDAL().Select16(a, b, c, d, e, f);
        }
        public DataTable Select17(string a, string b, string c, string d, string e, string f)
        {
            return new ZLDAL().Select17(a, b, c, d, e, f);
        }
        public bool Update2(string a, string b, string c, string d)
        {
            return new ZLDAL().update2(a, b, c, d);
        }
        public bool insert(string a, string b, string c)
        {
            return new ZLDAL().insert(a, b, c);
        }
        public DataTable Select114(string a, string b)
        {
            return new ZLDAL().Select114(a, b);
        }
        public bool Update112(string a, string b, string c)
        {
            return new ZLDAL().update112(a, b, c);
        }
        public DataTable Select115(string a, string b,string c)
        {
            return new ZLDAL().Select115(a, b, c);
        }
    }
}
