using MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class projectDAL
    {
        public bool update(string a, string b, string c, string d)
        {
            string s = "UPDATE addproject set first1 = '" + a + "', sec = '" + b + "',tir = '" + c + "',four = '" + d + "'";

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
        public DataTable Select()
        {
            string s = "select * from addproject ";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public bool insert(string a, string b, string c, string d, string e)
        {
            string s = "insert into project1(dangId,projectunit,filetype,gdmethod,year) values('" + a + "','" + b + "','" + c + "','" + d + "','" + e + "')";

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
        public bool insert2(string a, string b, string c, string d, string e)
        {
            string s = "insert into project2(dangId,anname,filetype,gdmethod,year) values('" + a + "','" + b + "','" + c + "','" + d + "','" + e + "')";

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
        public bool insert3(string a, string b, string c, string d, string e)
        {
            string s = "insert into project3(dangId,filename,filetype,gdmethod,year) values('" + a + "','" + b + "','" + c + "','" + d + "','" + e + "')";

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
        public DataSet Select(string a, string b,string c)
        {

            string s3 = "SELECT pId 项目号,projectunit 项目单位 ,filetype 档案类型,gdmethod 归档类型,year 年限,lq 领取,cf 拆分,zl 著录,dm 打码,sm 扫描,tc 图处,zj 质检,gj 挂接,hy 还原,gh 归还 from (SELECT pId xxx,projectunit  ,filetype ,gdmethod ,year  FROM project1 WHERE filetype like '%"+ a +"%' and pId like '%"+ b +"%' and gdmethod like '%"+ c +"%') a left JOIN (select pId,lq,cf,zl,dm,sm,tc,zj,gj,hy,gh FROM processing WHERE pId like '%"+ b +"%') b ON a.xxx = b.pId";
           // string s3 = "SELECT pId 项目号,projectunit 项目单位 ,filetype 档案类型,gdmethod 归档类型,year 年限 from project1 where pId = '" + b + "'";
            DataSet ds = DBhelper.Dataset(s3);
            return ds;
        }
        public DataSet Select2(string a, string b,string c)
        {

            string s3 = "SELECT pId 项目号,projectunit 项目单位 ,filetype 档案类型,gdmethod 归档类型,year 年限 FROM project1 WHERE filetype like '%" + a + "%' and pId like '%" + b + "%'and gdmethod = '" + c + "'";

            DataSet ds = DBhelper.Dataset(s3);
            return ds;
        }
        public DataSet Select3(string a, string b,string c)
        {

            string s3 = "SELECT pId 项目号,projectunit 项目单位 ,filetype 档案类型,gdmethod 归档类型,year 年限 FROM project1 WHERE filetype like '%" + a + "%' and pId like '%" + b + "%'and gdmethod = '" + c + "'";

            DataSet ds = DBhelper.Dataset(s3);
            return ds;
        }
        public bool insert(string a, string b, string c)
        {
            string s = "INSERT INTO nprocessing2 (pId,LID,Lname,status,getId,bh)SELECT pId,LID,Lname,status,'" + b + "' as getId,'" + c + "' AS bh from nprocessing WHERE pId = '" + a + "'";

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
        public DataTable Select1(string a)
        {
            string s = "SELECT MAX(getId) FROM nprocessing2 where pId = '" + a + "' ";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable Select(string a)
        {
            string s = "SELECT projectunit,filetype,gdmethod,year,pId FROM project1 where pId = '" + a + "'  ";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public bool update(string a, string b)
        {
            string s = "UPDATE nprocessing2 set status = 1 WHERE getId = '" + a + "' and bh = '" + b + "' and LID = 1";

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
        public bool Insert456(project w)
        {
            string s = "insert into project1(pId,projectunit,filetype,gdmethod,year,str1,str2,str3,str4,str5,url,hz,pgz,pdfgz,pdf,ocr) values('" + w.pId + "','" + w.projectunit + "','" + w.filetype + "','" + w.gdmethod + "','" + w.year + "','" + w.str1 + "','" + w.str2 + "','" + w.str3 + "','" + w.str4 + "','"+w.str5+"','"+w.url+"','"+w.hz+ "','" + w.pgz + "','" + w.pdfgz + "','" + w.pdf + "','" + w.ocr + "') ";

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
        public bool Insert4444(string a, string b)
        {
            string s = "insert into zd(pId,zd) values('" + a + "','" + b + "') ";

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
        public bool Insert(string a, string b,string c)
        {
            string s = "insert into Nprocessing(pId,LID,Lname) values('" + a + "','" + b + "','"+c+"') ";

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
        public bool Insert101(string a, string b, string c,string d,string e)
        {
            string s = "insert into jd(pId,LID,Lname,up,down) values('" + a + "','" + b + "','" + c + "','"+d+"','"+e+"') ";

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
        public DataTable Select1112(string a)
        {
            string s = "SELECT url FROM photourl where dangId = '" + a + "'  ";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable Select1127()
        {
            string s = "SELECT pId 项目号,projectunit 项目单位,filetype 档案类型 FROM project1 WHERE pId IN(SELECT pId FROM nprocessing WHERE LID = 1 and status = 0)";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable Select112701(string a)
        {
            string s = "SELECT distinct getId 领取批次号 FROM nprocessing2 WHERE pId ='"+a+"'";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public bool Insert1128(string a, string b)
        {
            string s = "insert into project1(url,hz) values('" + a + "','" + b + "') ";

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
