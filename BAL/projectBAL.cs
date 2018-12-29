using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;

namespace BAL
{
    public class projectBAL
    {
        public bool update(string a, string b, string c, string d)
        {
            return new projectDAL().update(a, b, c, d);
        }
        public DataTable Select()
        {
            return new projectDAL().Select();
        }
        public bool insert(string a, string b, string c, string d, string e)
        {
            return new projectDAL().insert(a, b, c, d, e);
        }
        public bool insert2(string a, string b, string c, string d, string e)
        {
            return new projectDAL().insert2(a, b, c, d, e);
        }
        public bool insert3(string a, string b, string c, string d, string e)
        {
            return new projectDAL().insert3(a, b, c, d, e);
        }
        public DataSet Select(string a, string b,string c)
        {
            return new projectDAL().Select(a, b,c);
        }
        public DataSet Select2(string a, string b,string c)
        {
            return new projectDAL().Select2(a, b,c);
        }
        public DataSet Select3(string a, string b,string c)
        {
            return new projectDAL().Select3(a, b,c);
        }
        public bool insert(string a, string b, string c)
        {
            return new projectDAL().insert(a, b, c);
        }
        public DataTable Select1(string a)
        {
            return new projectDAL().Select1(a);
        }
        public DataTable Select(string a)
        {
            return new projectDAL().Select(a);
        }
        public bool update(string a, string b)
        {
            return new projectDAL().update(a, b);
        }
        public bool Insert456(project g)
        {
            return new projectDAL().Insert456(g);
        }
        public bool Insert4444(string a, string b)
        {
            return new projectDAL().Insert4444(a, b);
        }
        public bool Insert(string a, string b,string c)
        {
            return new projectDAL().Insert(a, b,c);
        }
        public bool Insert101(string a, string b, string c,string d,string e)
        {
            return new projectDAL().Insert101(a, b, c,d,e);
        }
        public DataTable Select1112(string a)
        {
            return new projectDAL().Select1112(a);
        }
        public DataTable Select1127()
        {
            return new projectDAL().Select1127();
        }
        public DataTable Select112701(string a)
        {
            return new projectDAL().Select112701(a);
        }
        public bool Insert1128(string a, string b)
        {
            return new projectDAL().Insert1128(a, b);
        }
    }
}
