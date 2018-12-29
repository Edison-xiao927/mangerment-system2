using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AADAL
    {
        public DataTable Select()
        {
            string s = "select * from user";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable Select1123(string str)
        {
            string s = "select username from user where username ='"+ str +"'";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable Select1()
        {
            string s = "select * from resource where menuParent = 0";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable Select2(int a)
        {
            string s = "select * from resource where menuParent='" + a + "'";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public bool delete(int a)
        {
            string s2 = "delete from role_res where useId = '" + a + "'";
            int rows = DBhelper.ExecuteNonQuery(s2);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool insert(int a, int b)
        {
            string s = "insert into role_res values('" + a + "','" + b + "') ";

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
        public bool insert1(string str)
        {
            string s = "insert into users(uname) values('" + str + "')";

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
        public DataTable Select3(int a)
        {
            string s = "select resourceId from role_res where useId = '" + a + "'";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable Selectinfo(int a)
        {
            string s = "select * from resource where resourceId in (select resourceId from role_res where useId='" + a + "') and menuParent=0";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable Selectinfo2(int a, int b)
        {
            string s = "select * from resource where menuParent='" + a + "' and resourceId in (select resourceId from role_res where useId='" + b + "')";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public int select(string str)
        {
            string s = "select useId from user where username='" + str + "'";
            int a = Convert.ToInt32(DBhelper.ExecuteScalar(s));
            return a;
        }
        public DataTable Select4(string str)
        {
            string s = "select password from user where username='" + str + "'";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable Select5(string str)
        {
            string s = "SELECT zd FROM ziduan where zId IN (SELECT zd FROM zd where pId = '" + str + "' and zd >=1 AND zd<=10 )";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }       
        public bool insert110(string a, string b, string c, string d, string e, string f,string g)
        {
            string s = "insert into test(pId,zId,sx,parentId,parentId2,bh,lzId) values('" + a + "','" + b + "','" + c + "','" + d + "','" + e + "','" + f + "','" + g + "') ";

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
        public bool update(string a, string b, string c)
        {
            string s = "update test set " + a + " ='" + b + "' where 项目号 = '" + c + "' ";

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
        public DataTable Select6(string str)
        {
            string s = "SELECT zd FROM ziduan where zId IN (SELECT zd FROM zd where pId = '" + str + "' and zd >=11 AND zd<=18 )";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable Select222(string a,string b, string  c)
        {
            string s = "select zId from ziduan where zd='"+ a +"' and zId >='"+ b +"' and zId<='"+ c +"'";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable Select77(string str)
        {
            string s = "SELECT max(id) FROM test where pId='" + str + "' and zId ='3'";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable Select7(string str)
        {
            string s = "SELECT zd FROM ziduan where zId IN (SELECT zd FROM zd where pId = '" + str + "' and zd >=19 AND zd<=29 )";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable Select777(string str, string str2)
        {
            string s = "SELECT max(id) FROM test where pId='" + str + "' and parentId = '" + str2 + "' and zId = '12'";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public bool insert1122(string a, string b, string c, string d, string e,string f)
        {
            string s = "insert into test(pId,zId,sx,parentId2,bh,lzId) values('" + a + "','" + b + "','" + c + "','" + d + "','" + e + "','" + f + "') ";

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
        public DataTable Select444(string str)
        {
            string s = "select max(pc) from test ";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable Select1007(string str)
        {
            string s = "select max(lzId) from fileprocess where getId = '"+str+"' ";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable Select100701(string str,string str2)
        {
            string s = "select lzId from fileprocess where getId = '" + str + "' and bh = '"+str2+"' ";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable Select1010(string str, string str2)
        {
            string s = "select getId from fileprocess where lzId = '" + str + "'  ";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public bool insert444(string a, string b, string c, string d, string e)
        {
            string s = "insert into test(pId,zId,sx,parentId,parentId2) values('" + a + "','" + b + "','" + c + "','" + d + "','" + e + "') ";

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
        public DataTable Select8(string str)
        {
            string s = "select pId from test where sx ='" + str + "'";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable Select9(string str)
        {
            string s = "select sx from test where zId ='件号'and parentId2=(select parentId2 from test where sx ='" + str + "');";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable Select10(string str)
        {
            string s = "select sx from test where zId ='案卷号' and parentId2 =(select parentId2 from test where id=(select parentId from test where sx ='" + str + "'))";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable Select7777(string str, string str2)
        {
            string s = "SELECT max(id) FROM test where pId='" + str + "' and sx = '" + str2 + "' and zId = '12'";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable Select77777(string str, string str2)
        {
            string s = "SELECT max(id) FROM test where pId='" + str + "' and sx = '" + str2 + "' and zId = '3'";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable Select438(string str)
        {
            string s = "select str1,str2,str3,str4,str5 from project1 where pId = '" + str + "' ";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable Select7438(string str, string str2)
        {
            string s = "select year from fileget where dangId = '" + str + "' and bh = '" + str2 + "' ";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable Select101(string str,int str2)
        {
            string s = "select max(LID) from nprocessing where pId = '" + str + "' and LID<  "+str2+"  ";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable Select102(string str, int str2)
        {
            string s = "select min(LID) from nprocessing where pId = '" + str + "' and LID>  " + str2 + "  ";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable Select1004(string a)
        {
            string s = "SELECT DISTINCT Lname FROM jd WHERE LID in (SELECT LID from jd WHERE LID<= (SELECT DISTINCT LID from jd WHERE Lname = '"+a+"'))";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable Select10041(string a,string b)
        {
            string s = "SELECT Lname FROM jd WHERE LID =(SELECT up FROM jd WHERE pId = '"+a+"' and Lname = '"+b+"')";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable Select10042(string a, string b)
        {
            string s = "SELECT Lname FROM jd WHERE LID =(SELECT up FROM jd WHERE pId = '" + a + "' and Lname = '打码')";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable Select10042001(string a, string b)
        {
            string s = "SELECT Lname FROM jd WHERE LID =(SELECT up FROM jd WHERE pId = '" + a + "' and Lname = '打码')";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public bool update1014(string a, string b,string c)
        {
            string s = "update nprocessing2 set zrr ='"+c+"' where getId = '"+a+"' and bh ='"+b+"' and LID = '3' ";

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
        public DataTable Select1014(string a, string b)
        {
            string s = "select getId from fileprocess where lzId = '"+a+"' and bh = '"+ b+"'";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public bool update101501(string a, string b, string c)
        {
            string s = "update nprocessing2 set zrr ='" + c + "' where getId = '" + a + "' and bh ='" + b + "' and LID = '2' ";

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
        public bool update101502(string a, string b, string c)
        {
            string s = "update nprocessing2 set zrr ='" + c + "' where getId = '" + a + "' and bh ='" + b + "' and LID = '4' ";

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
        public bool update1225(string a, string b, string c)
        {
            string s = "update nprocessing2 set zrr ='" + c + "' where getId = '" + a + "' and bh ='" + b + "' and LID = '5' ";

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
        public bool update101503(string a, string b, string c)
        {
            string s = "update nprocessing2 set zrr ='" + c + "' where getId = '" + a + "' and bh ='" + b + "' and LID = '6' ";

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
        public bool update101504(string a, string b, string c)
        {
            string s = "update nprocessing2 set zrr ='" + c + "' where getId = '" + a + "' and bh ='" + b + "' and LID = '7' ";

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
        public bool update101505(string a, string b, string c)
        {
            string s = "update nprocessing2 set zrr ='" + c + "' where getId = '" + a + "' and bh ='" + b + "' and LID = '8' ";

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
        public bool update101506(string a, string b, string c)
        {
            string s = "update nprocessing2 set zrr ='" + c + "' where getId = '" + a + "' and bh ='" + b + "' and LID = '9' ";

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
        public bool update101507(string a, string b, string c)
        {
            string s = "update nprocessing2 set zrr ='" + c + "' where getId = '" + a + "' and bh ='" + b + "' and LID = '10' ";

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
        public bool update101508(string a, string b, string c)
        {
            string s = "update nprocessing2 set zrr ='" + c + "' where getId = '" + a + "' and bh ='" + b + "' and LID = '11' ";

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
        public DataTable Select1016(string a, string b)
        {
            string s = "select get from fileprocess where getId = '" + a + "' and bh = '" + b + "'";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable Select1018(string a)
        {
            string s = "SELECT  DISTINCT page from fileprocess where lzId = '"+a+"'";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable Select1121(string str)
        {
            string s = "select gdmethod,year from project1 where pId = '" + str + "'  ";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable Select10041127(string a)
        {
            string s = "select str1,str2,str3,str4,str5 FROM project1 WHERE  pId = '"+a+"'";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable Select1004112701(string a)
        {
            string s = "SELECT Lname FROM nprocessing WHERE pId = '"+a+"' ";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public bool update112703(string a)
        {
            string s = "delete from nprocessing2  where getId = '" + a + "'";

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
        public DataTable Select1128(string a,string b,string c)
        {
            string s = "SELECT getId 领取批次号,bh 编号,zrr 责任人,Lname 加工环节 FROM (SELECT LID,zrr,Lname,getId,bh from nprocessing2 WHERE getId LIKE '%"+a+"%' AND bh LIKE '%"+b+"%' and status != 0 and pId IN (SELECT pId from project1 WHERE year like '%"+c+"%') )a ";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public bool delete(string str)
        {
            string s = "DELETE from user WHERE useId='"+ str +"'";
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
        public DataTable Select1214()
        {
            string s = "SELECT lzId ,bh FROM zl WHERE iszl='1'";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable Select1226(string a)
        {
            string s = "SELECT * FROM zl WHERE lzId = '"+a+"'";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
    }
}
