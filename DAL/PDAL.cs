using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PDAL
    {
        public bool update(string a, string b, string c)
        {
            string s7 = "update project1 set " + a + "='" + b + "'where pId = '" + c+"'";
            int rows = DBhelper.ExecuteNonQuery(s7);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool update2(string a, string b, string c)
        {
            string s7 = "update processing set " + a + "='" + b + "'where pId = '" + c+"'";
            int rows = DBhelper.ExecuteNonQuery(s7);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool delete(string str)
        {
            string s5 = "delete from project1 where pId = '" + str+"'";
            int rows = DBhelper.ExecuteNonQuery(s5);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool delete2(string str)
        {
            string s5 = "delete from processing where pId = '" + str+"'";
            int rows = DBhelper.ExecuteNonQuery(s5);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
