using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CZLDAL
    {
        public DataTable Select2(string str, string c)
        {
            string s = "select id,sx,zId from test2 where pId = '" + str + "' and zId >= 1 and zId <= 10 and lzId = '" + c + "'";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable select112(string str, string c)
        {
            string s = "select id,sx,zId from test2 where pId = '" + str + "' and zId >= 11 and zId <= 18 and lzId='" + c + "' ";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable select113(string str, string c)
        {
            string s = "select id,sx,zId from test2 where pId = '" + str + "' and zId >= 19 and zId <= 29 and lzId='" + c + "' ";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable Select4(string str)
        {
            string s = "SELECT id from test2 where pId ='" + str + "'and parentId = 0 ";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable Select114(string a, string b)
        {
            string s = "select iszl from zl2 where lzId='" + a + "'and bh='" + b + "'";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable Select3(string str)
        {
            string s = "SELECT sx from test2 WHERE parentId2 in ( SELECT parentId2 from test where parentId ='" + str + "')";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        //案卷查询修改
        public DataTable Select77(string str)
        {
            string s = "SELECT max(id) FROM test2 where pId='" + str + "' and zId ='3'";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable Select8(string str, string str2)
        {
            string s = "select sx from test2 where pId ='" + str + "' and parentId2 in(select distinct parentId2 FROM test2 where parentId  =(select id from test2 where zId=12 and sx='" + str2 + "' and pId='" + str + "'))";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable Select7777(string str, string str2)
        {
            string s = "SELECT max(id) FROM test2 where pId='" + str + "' and sx = '" + str2 + "' and zId = '12'";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        //文件查询修改
        public DataTable Select777(string str, string str2)
        {
            string s = "SELECT max(id) FROM test2 where pId='" + str + "' and parentId = '" + str2 + "' and zId = '12'";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable Select77777(string str, string str2)
        {
            string s = "SELECT max(id) FROM test2 where pId='" + str + "' and sx = '" + str2 + "' and zId = '3'";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;

        }
        public DataTable Select115(string a, string b, string c)
        {
            string s = "select bh from test2 where lzId='" + a + "'and zId='" + b + "'and sx='" + c + "'";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        //
        public DataTable Select5(string str,string a,string b, string c,string d,string e)
        {
            string s = "select sx from test where parentId2=(select parentId2 from test where sx='"+ str +"'and zId='"+ a +"'and pId='"+ b +"' and lzId='"+ c +"') and pId='"+ b +"'and lzId='"+ c +"'and zId>='"+ d +"' and zId<='"+  e +"'";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable Select6(string str, string a, string b, string c, string d, string e)
        {
            string s = "select sx from test2 where parentId2=(select parentId2 from test2 where sx='" + str + "'and zId='" + a + "'and pId='" + b + "' and lzId='" + c + "') and pId='" + b + "'and lzId='" + c + "'and zId>='" + d + "' and zId<='" + e + "'";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }

        public DataTable Select1214()
        {
            string s = "SELECT lzId ,bh FROM zl2 WHERE iszl='1'";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public bool insert1122(string a, string b, string c, string d, string e, string f)
        {
            string s = "insert into test2(pId,zId,sx,parentId2,bh,lzId) values('" + a + "','" + b + "','" + c + "','" + d + "','" + e + "','" + f + "') ";

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
        public bool insert110(string a, string b, string c, string d, string e, string f, string g)
        {
            string s = "insert into test2(pId,zId,sx,parentId,parentId2,bh,lzId) values('" + a + "','" + b + "','" + c + "','" + d + "','" + e + "','" + f + "','" + g + "') ";

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
        public bool insert(string str, string b, string c)
        {
            string s = "insert into zl2(lzId,bh,iszl) values('" + str + "','" + b + "','" + c + "')";

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
        public bool update112(string a, string b, string c)
        {
            string s = "update zl2 set iszl ='" + a + "'where lzId='" + b + "' and bh ='" + c + "'";
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
        public bool delete(string str, string str2, string str3)
        {
            string s = "delete from test2 WHERE parentId2 in (select * from ((select parentId2 from test2 where parentId in(select id from test2 where zId =12 and parentId=(select id from test2 where zId =3 and sx='" + str + "'and pId ='" + str2 + "' and bh='" + str3 + "' )))a));";
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
        public bool delete2(string a, string str, string str2, string str3)
        {
            string s = "DELETE from test2 WHERE parentId2 IN(select * from((SELECT DISTINCT parentId2 FROM test2 WHERE parentId = (SELECT id FROM test2 where zId= '" + a + "' and sx = '" + str + "' AND pId ='" + str2 + "' AND bh ='" + str3 + "'))a))";
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
        public bool delete3(string str, string str2, string str3, string str4)
        {
            string s = "DELETE from test2 WHERE parentId2 = (select * from ((SELECT parentId2 FROM test2 where zId= '" + str + "' and sx = '" + str2 + "'and pId ='" + str3 + "' and bh='" + str4 + "')a))";
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
            string s = "DELETE from test2 WHERE parentId2 =  (SELECT * from ((SELECT parentId2 FROM test2 where zId= 9 and sx = '" + str + "') a))";
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
    }
}
