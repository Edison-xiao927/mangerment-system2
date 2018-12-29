using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ZLXIDAL
    {
        public DataTable Select1()
        {
            string s = "SELECT zd from ziduan where zId in (SELECT zd from zd WHERE zd>=1 and zd<=10)";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable Select2(string a,string b)
        {
            string s = "SELECT sx from test  WHERE zId>=1 and zId <=10 and pId='"+ a+"'and lzId ='"+ b +"'";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable Select3(string str)
        {
            string s = "SELECT distinct gdmethod from fileprocess WHERE lzId='"+ str +"'";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable Select4(string str)
        {
            string s = "SELECT sx from test WHERE pId='"+ str +"'and zId >=4 and zId<=7";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable Select5(string str)
        {
            string s = "SELECT zd FROM ziduan where zId IN (SELECT zd FROM zd where pId = '" + str + "' and zd >=11 AND zd<=18 )";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable Select6(string str)
        {
            string s = "SELECT zd FROM ziduan where zId IN (SELECT zd FROM zd where pId = '" + str + "' and zd >=19 AND zd<=29 )";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable Select7(string str)
        {
            string s = "select distinct pId from nprocessing2 where getId =(select distinct getId from fileprocess where lzId='"+ str +"')";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable Select8(string str,string str2)
        {
            string s = "select sx from test where pId ='"+ str +"' and parentId2 in(select distinct parentId2 FROM test where parentId  =(select id from test where zId=12 and sx='"+ str2 +"' and pId='"+ str +"'))";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable Select99(string str, string str2)
        {
            string s = "select sx from test where pId ='" + str + "' and parentId2 in(select distinct parentId2 FROM test where parentId  =(select id from test where zId=3 and sx='" + str2 + "' and pId='" + str + "'))";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable Select9(string str)
        {
            string s = "select pId from test where sx='"+ str +"'";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public bool delete(string str,string str2,string str3)
        {
            string s = "delete from test WHERE parentId2 in (select * from ((select parentId2 from test where parentId in(select id from test where zId =12 and parentId=(select id from test where zId =3 and sx='"+ str +"'and pId ='"+ str2 +"' and bh='"+ str3 +"' )))a));";
            int rows = DBhelper.ExecuteNonQuery(s);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable Select10(string str)
        {
            string s = "select pId from test where sx='" + str + "'";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public bool delete2(string a,string str,string str2,string str3)
        {
            string s = "DELETE from test WHERE parentId2 IN(select * from((SELECT DISTINCT parentId2 FROM test WHERE parentId = (SELECT id FROM test where zId= '"+ a +"' and sx = '"+ str +"' AND pId ='"+ str2 + "' AND bh ='"+ str3 +"'))a))";
            int rows = DBhelper.ExecuteNonQuery(s);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool delete3(string str,string str2,string str3,string str4)
        {
            string s = "DELETE from test WHERE parentId2 = (select * from ((SELECT parentId2 FROM test where zId= '" + str + "' and sx = '" + str2 + "'and pId ='" + str3 + "' and bh='"+ str4 +"')a))";
            int rows = DBhelper.ExecuteNonQuery(s);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool delete4(string str)
        {
            string s = "DELETE from test WHERE parentId2 =  (SELECT * from ((SELECT parentId2 FROM test where zId= 9 and sx = '"+ str +"') a))";
            int rows = DBhelper.ExecuteNonQuery(s);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable Select1128(string str)
        {
            string s = "select url from project1 where pId ='" + str + "'";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable Select112801(string str)
        {
            string s = "select hz from project1 where pId ='" + str + "'";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
    }
}
