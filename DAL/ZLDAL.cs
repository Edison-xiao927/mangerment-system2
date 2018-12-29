using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ZLDAL
    {
        public DataTable Select(string str)
        {
            string s = "select gdmethod from project1 where pId ='" + str + "'";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable Select1(string str)
        {
            string s = "SELECT zd from ziduan where zId in (SELECT zd from zd WHERE pId = '" + str + "' AND zd>=1 AND ZD<= 10)";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable Select2(string str,string c)
        {
            string s = "select id,sx,zId from test where pId = '" + str + "' and zId >= 1 and zId <= 10 and lzId = '"+c+"'";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable select112(string str,string c)
        {
            string s = "select id,sx,zId from test where pId = '" + str + "' and zId >= 11 and zId <= 18 and lzId='"+ c +"' ";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable select113(string str, string c)
        {
            string s = "select id,sx,zId from test where pId = '" + str + "' and zId >= 19 and zId <= 29 and lzId='" + c + "' ";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable Select1113(string str,string b)
        {
            string s = "select id,sx,zId from test where pId = '" + str + "'and lzId ='"+ b +"' and zId >= 19 and zId <= 29 ";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable Select3(string str)
        {
            string s = "SELECT sx from test WHERE parentId2 in ( SELECT parentId2 from test where parentId ='" + str + "')";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable Select4(string str)
        {
            string s = "SELECT id from test where pId ='" + str + "'and parentId = 0 ";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable Select5(string a, string b)
        {
            string s = "select id from test where pId ='" + a + "' and sx ='" + b + "'";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public bool update(string a, string b)
        {
            string s = "update test set sx ='" + a + "'where id ='" + b + "'";
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
        public DataTable Select6(string a)
        {
            string s = "select zId from ziduan where zd ='" + a + "'";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable Select7(string a, string b, string c)
        {
            string s = "select parentId2 from test where pId='" + a + "' and zId='" + b + "' and sx='" + c + "'";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable Select8(string a, string b)
        {
            string s = "SELECT distinct page from nprocessing2 WHERE getId = (SELECT DISTINCT getId FROM fileprocess WHERE lzId = '" + a +"') and bh = '"+ b +"'";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable Select9(string a, string b,string c,string d)
        {
            string s = "SELECT sx from test where parentId2 IN (select DISTINCT parentId2 from test where zId='"+ a +"' and sx+0>='"+ b +"'+0 and sx+0<='"+ c +"'+0 and pId='"+ d +"')";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable Select10(string a, string b,string c)
        {
            string s = "select sx from test where parentId2 IN (select DISTINCT parentId2 from test where zId='"+ a +"' and sx+0>='"+ b +"'+0 and pId='"+ c +"')";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable Select11(string a, string b,string c)
        {
            string s = "select sx from test where parentId2 IN (select DISTINCT parentId2 from test where zId='"+ a +"' and sx+0<='"+ b +"'+0 and pId='"+ c +"')";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable Select12(string a, string b)
        {
            string s = "select sx from test where parentId2=(select parentId2 from test where id =(select parentId from test where id=(select parentId from test where zId='21' and parentId2=(SELECT parentId2 from test where sx='"+ a +"' and pId='"+ b +"'))))";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable Select13(string a, string b)
        {
            string s = "select sx from test where parentId2=(select parentId2 from test where id=(select parentId from test where zId='21' and parentId2=(SELECT parentId2 from test where sx='"+ a +"' and pId='"+ b +"')))";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable Select14(string a, string b)
        {
            string s = "select sx from test where parentId2=(SELECT parentId2 from test where sx='"+ a +"' and pId='"+ b +"')";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable Select15(string a, string b,string c, string d, string e,string f,string g)
        {
            string s = "SELECT sx from test WHERE parentId2 in( SELECT parentId2 FROM (select sx,zId,parentId2 from test where parentId2 in (select parentId2 from test where parentId = (select id from test where sx='"+ a +"'and zId='"+ b +"' and pId='"+ c +"'and bh='"+ d +"')))a WHERE sx+0>='"+ e +"'and sx+0<='"+ f +"'+0 and zId ='"+ g +"')";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable Select16(string a, string b, string c, string d,string e, string f)
        {
            string s = "SELECT sx from test WHERE parentId2 in( SELECT parentId2 FROM (select sx,zId,parentId2 from test where parentId2 in (select parentId2 from test where parentId = (select id from test where sx='" + a + "'and zId='"+ b +"' and pId='" + c + "'and bh='" + d + "')))a WHERE sx+0>='" + e +"'+0 and zId ='"+ f +"')";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable Select17(string a, string b, string c, string d, string e, string f)
        {
            string s = "SELECT sx from test WHERE parentId2 in( SELECT parentId2 FROM (select sx,zId,parentId2 from test where parentId2 in (select parentId2 from test where parentId = (select id from test where sx='" + a + "'and zId='"+ b +"' and pId='" + c + "'and bh='" + d + "')))a WHERE sx+0<='" + e + "'+0 and zId ='"+ f +"')";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public bool update2(string a, string b, string c, string d)
        {
            string s = "update test set sx ='" + a + "'where pId='" + b + "' and zId ='" + c + "' and parentId2='" + d + "'";
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
        public bool insert(string str,string b,string c)
        {
            string s = "insert into zl(lzId,bh,iszl) values('" + str + "','" + b + "','" + c + "')";

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
        public DataTable Select114(string a, string b)
        {
            string s = "select iszl from zl where lzId='" + a + "'and bh='" + b + "'";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public bool update112(string a, string b, string c)
        {
            string s = "update zl set iszl ='" + a + "'where lzId='" + b + "' and bh ='" + c +"'";
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
        public DataTable Select115(string a, string b,string c)
        {
            string s = "select bh from test where lzId='" + a + "'and zId='" + b + "'and sx='"+ c +"'";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
    }
}
