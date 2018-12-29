using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MyWorkDAL
    {
        public DataSet Select(string a)
        {

            string s3 = "SELECT lzId 流转单号,status 状态,pId 项目号,bh 编号,projectunit 项目单位,filetype 档案类型,problem 问题描述,page 页数  FROM ( SELECT status1 ,lzId ,bh ,projectunit ,filetype,getId FROM fileprocess WHERE (bh,getId) IN (SELECT bh,getId from (SELECT pId x,bh xx,getId,status from nprocessing2 WHERE (LID ='3' AND status = '0' and zrr ='" + a+"')) a INNER JOIN (SELECT pId,bh from nprocessing2 WHERE ((pId,LID) IN (SELECT pId,up FROM jd where LID = '3') AND  status = '1'))b ON a.x=b.pId AND a.xx = b.bh)) a LEFT JOIN (SELECT bh xx,getId x,pId,status,problem,page  from (SELECT pId x,bh xx,getId,status,problem,page  from nprocessing2 WHERE (LID ='3' AND status = '0' and zrr = '"+a+"')) a INNER JOIN (SELECT pId,bh from nprocessing2 WHERE ((pId,LID) IN (SELECT pId,up FROM jd where LID = '3') AND  status = '1'))b ON a.x=b.pId AND a.xx = b.bh) b on a.getId = b.x and a.bh = b.xx";
            DataSet ds = DBhelper.Dataset(s3);
            return ds;
        }
        public DataSet Select1006()
        {

            string s3 = "SELECT pId 项目号,getId 领取批次号,bh 编号,projectunit 项目单位,filetype 档案类型  from (SELECT pId xxx,projectunit ,filetype  FROM project1 WHERE pId IN(SELECT pId FROM nprocessing2 WHERE LID = 4 and status = 0))a LEFT JOIN (SELECT pId,bh,getId, status FROM nprocessing2 WHERE LID = 4 and status = 0) b ON a.xxx = b.pId";
            DataSet ds = DBhelper.Dataset(s3);
            return ds;
        }
        public DataSet Select10061()
        {

            string s3 = "SELECT pId 项目号,getId 领取批次号,bh 编号,projectunit 项目单位,filetype 档案类型  from (SELECT pId xxx,projectunit ,filetype  FROM project1 WHERE pId IN(SELECT pId FROM nprocessing2 WHERE LID = 4 and status = 0))a LEFT JOIN (SELECT pId,bh,getId, status FROM nprocessing2 WHERE LID = 4 and status = 0) b ON a.xxx = b.pId";
            DataSet ds = DBhelper.Dataset(s3);
            return ds;
        }
        public DataSet Select2()
        {

            string s3 = " SELECT DISTINCT pId 项目号,bh 编号,getId 领取批次号,problem 问题描述,solve 解决方案 FROM  (SELECT DISTINCT pId ,bh ,getId  from pcprocessing where zl != 0 and zl = status1 +1) a left JOIN (SELECT bh xx,getId xxx,problem,solve from fileproblem ) b ON a.getId = b.xxx AND a.bh = b.xx";
            DataSet ds = DBhelper.Dataset(s3);
            return ds;
        }
        public DataSet Select3(string a)
        {

            string s3 = "SELECT getId 领取批次号,status 状态 ,pId 项目号,bh 编号,projectunit 项目单位,filetype 档案类型,page 页数,problem 问题描述 from (SELECT status,pId,bh,getId,problem,page from (SELECT pId x,bh xx,getId,status,problem,page from nprocessing2 WHERE (LID ='2' AND status = '0' and zrr = '" + a + "')) a INNER JOIN (SELECT pId,bh from nprocessing2 WHERE ((pId,LID) IN (SELECT pId,up FROM jd where LID = '2') AND  status = '1'))b ON a.x=b.pId AND a.xx = b.bh)a LEFT JOIN (SELECT pId xxx,projectunit ,filetype  FROM project1 WHERE pId IN(SELECT pId FROM nprocessing2 WHERE LID = '2' and status = 0)) b ON a.pId = b.xxx ;";
            DataSet ds = DBhelper.Dataset(s3);
            return ds;
        }
        public DataSet Select4()
        {

            string s3 = "SELECT pId 项目号,lzId 流转单号,bh 编号,page 页数,solve 解决方案,xxxx 领取批次号 FROM (SELECT pId,lzId ,bh,page,getId xxxx FROM (sELECT pId,getId xxx,bh FROM nprocessing2 WHERE LID = 9 and status = 0) a LEFT JOIN(SELECT getId,lzId,page FROM fileprocess WHERE getId in (SELECT DISTINCT getId FROM nprocessing2 WHERE LID = 9 and status = 0)) b ON a.xxx = b.getId) a LEFT JOIN (SELECT solve,bh xxx,getId from fileproblem WHERE bh IN (sELECT bh FROM nprocessing2 WHERE LID = 9 and status = 0) and getId IN(sELECT getId FROM nprocessing2 WHERE LID = 9 and status = 0)) b ON a.bh = b.xxx";
            DataSet ds = DBhelper.Dataset(s3);
            return ds;
        }
        public DataSet Select5()
        {

            string s3 = "SELECT DISTINCT pId 项目号,bh 编号,getId 领取批次号,problem 问题描述,solve 解决方案 FROM  (SELECT DISTINCT pId ,bh ,getId  from pcprocessing where gj != 0 and gj = status1 +1) a left JOIN (SELECT bh xx,getId xxx,problem,solve from fileproblem ) b ON a.getId = b.xxx AND a.bh = b.xx";
            DataSet ds = DBhelper.Dataset(s3);
            return ds;
        }
        public DataSet Select6()
        {

            string s3 = "SELECT DISTINCT pId 项目号,bh 编号,getId 领取批次号,problem 问题描述,solve 解决方案 FROM  (SELECT DISTINCT pId ,bh ,getId  from pcprocessing where sm != 0 and sm = status1 +1) a left JOIN (SELECT bh xx,getId xxx,problem,solve from fileproblem ) b ON a.getId = b.xxx AND a.bh = b.xx";
            DataSet ds = DBhelper.Dataset(s3);
            return ds;
        }
        public DataSet Select7()
        {

            string s3 = "SELECT DISTINCT pId 项目号,bh 编号,getId 领取批次号,problem 问题描述,solve 解决方案 FROM  (SELECT DISTINCT pId ,bh ,getId  from pcprocessing where bm != 0 and bm = status1 +1) a left JOIN (SELECT bh xx,getId xxx,problem,solve from fileproblem ) b ON a.getId = b.xxx AND a.bh = b.xx";
            DataSet ds = DBhelper.Dataset(s3);
            return ds;
        }
        public DataSet Select8()
        {

            string s3 = "SELECT DISTINCT pId 项目号,bh 编号,getId 领取批次号,problem 问题描述,solve 解决方案 FROM  (SELECT DISTINCT pId ,bh ,getId  from pcprocessing where tc != 0 and tc = status1 +1) a left JOIN (SELECT bh xx,getId xxx,problem,solve from fileproblem ) b ON a.getId = b.xxx AND a.bh = b.xx";
            DataSet ds = DBhelper.Dataset(s3);
            return ds;
        }
        public DataSet Select9()
        {

            string s3 = "SELECT DISTINCT pId 项目号,bh 编号,getId 领取批次号,problem 问题描述,solve 解决方案 FROM  (SELECT DISTINCT pId ,bh ,getId  from pcprocessing where zj != 0 and zj = status1 +1) a left JOIN (SELECT bh xx,getId xxx,problem,solve from fileproblem ) b ON a.getId = b.xxx AND a.bh = b.xx";
            DataSet ds = DBhelper.Dataset(s3);
            return ds;
        }
        public DataSet Select10()
        {

            string s3 = " SELECT DISTINCT pId 项目号,bh 编号,getId 领取批次号,problem 问题描述,solve 解决方案 FROM  (SELECT DISTINCT pId ,bh ,getId  from pcprocessing where gj != 0 and gj = status1 +1) a left JOIN (SELECT bh xx,getId xxx,problem,solve from fileproblem ) b ON a.getId = b.xxx AND a.bh = b.xx";
            DataSet ds = DBhelper.Dataset(s3);
            return ds;
        }
        public DataSet Select11()
        {

            string s3 = "SELECT DISTINCT pId 项目号,bh 编号,getId 领取批次号,problem 问题描述,solve 解决方案 FROM  (SELECT DISTINCT pId ,bh ,getId  from pcprocessing where gh != 0 and gh = status1 +1) a left JOIN (SELECT bh xx,getId xxx,problem,solve from fileproblem ) b ON a.getId = b.xxx AND a.bh = b.xx";
            DataSet ds = DBhelper.Dataset(s3);
            return ds;
        }

        public DataTable Selectinfo(string str)
        {
            string s = "select zId,pc from test where pId ='" + str + "'";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public bool update(string a)
        {
            string s = "UPDATE test SET test.zId = (SELECT zd FROM ziduan WHERE ziduan.zId = test.zId ) where pc = '" + a + "'";

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
        public DataSet Select1102(string a)
        {

            string s3 = " SELECT lzId 流转单号,status 状态,pId 项目号,bh 编号,projectunit 项目单位,filetype 档案类型,problem 问题描述,page 页数  FROM ( SELECT status1 ,lzId ,bh ,projectunit ,filetype,getId FROM fileprocess WHERE (bh,getId) IN (SELECT bh,getId from (SELECT pId x,bh xx,getId,status from nprocessing2 WHERE (LID ='6' AND status = '0' and zrr = '" + a+"')) a INNER JOIN (SELECT pId,bh from nprocessing2 WHERE ((pId,LID) IN (SELECT pId,up FROM jd where LID = '6') AND  status = '1'))b ON a.x=b.pId AND a.xx = b.bh)) a LEFT JOIN (SELECT bh xx,getId x,pId,status,problem,page from (SELECT pId x,bh xx,getId,status,problem,page from nprocessing2 WHERE (LID ='6' AND status = '0' and zrr = '"+a+"')) a INNER JOIN (SELECT pId,bh from nprocessing2 WHERE ((pId,LID) IN (SELECT pId,up FROM jd where LID = '6') AND  status = '1'))b ON a.x=b.pId AND a.xx = b.bh) b on a.getId = b.x and a.bh = b.xx";
            DataSet ds = DBhelper.Dataset(s3);
            return ds;
        }
        public DataSet Select110201(string a)
        {

            string s3 = " SELECT lzId 流转单号,status 状态,pId 项目号,bh 编号,projectunit 项目单位,filetype 档案类型,problem 问题描述,page 页数  FROM ( SELECT status1 ,lzId ,bh ,projectunit ,filetype,getId FROM fileprocess WHERE (bh,getId) IN (SELECT bh,getId from (SELECT pId x,bh xx,getId,status from nprocessing2 WHERE (LID ='7' AND status = '0' and zrr = '" + a+"')) a INNER JOIN (SELECT pId,bh from nprocessing2 WHERE ((pId,LID) IN (SELECT pId,up FROM jd where LID = '7') AND  status = '1'))b ON a.x=b.pId AND a.xx = b.bh)) a LEFT JOIN (SELECT bh xx,getId x,pId,status,problem,page from (SELECT pId x,bh xx,getId,status,problem,page from nprocessing2 WHERE (LID ='7' AND status = '0' and zrr = '"+a+"')) a INNER JOIN (SELECT pId,bh from nprocessing2 WHERE ((pId,LID) IN (SELECT pId,up FROM jd where LID = '7') AND  status = '1'))b ON a.x=b.pId AND a.xx = b.bh) b on a.getId = b.x and a.bh = b.xx";
            DataSet ds = DBhelper.Dataset(s3);
            return ds;
        }
        public DataSet Select112001(string a)
        {

            string s3 = "SELECT lzId 流转单号,status 状态,pId 项目号,bh 编号,projectunit 项目单位,filetype 档案类型,problem 问题描述  FROM ( SELECT status1 ,lzId ,bh ,projectunit ,filetype,getId FROM fileprocess WHERE (bh,getId) IN (SELECT bh,getId from (SELECT pId x,bh xx,getId,status from nprocessing2 WHERE (LID ='8' AND status = '0' and zrr = '" + a+"')) a INNER JOIN (SELECT pId,bh from nprocessing2 WHERE ((pId,LID) IN (SELECT pId,up FROM jd where LID = '8') AND  status = '1'))b ON a.x=b.pId AND a.xx = b.bh)) a LEFT JOIN (SELECT bh xx,getId x,pId,status,problem from (SELECT pId x,bh xx,getId,status,problem from nprocessing2 WHERE (LID ='8' AND status = '0' and zrr = '"+a+"')) a INNER JOIN (SELECT pId,bh from nprocessing2 WHERE ((pId,LID) IN (SELECT pId,up FROM jd where LID = '8') AND  status = '1'))b ON a.x=b.pId AND a.xx = b.bh) b on a.getId = b.x and a.bh = b.xx";
            DataSet ds = DBhelper.Dataset(s3);
            return ds;
        }
        public DataSet Select112002(string a)
        {

            string s3 = "SELECT lzId 流转单号,status 状态,pId 项目号,bh 编号,projectunit 项目单位,filetype 档案类型,problem 问题描述,page 页数  FROM ( SELECT status1 ,lzId ,bh ,projectunit ,filetype,getId FROM fileprocess WHERE (bh,getId) IN (SELECT bh,getId from (SELECT pId x,bh xx,getId,status from nprocessing2 WHERE (LID ='9' AND status = '0' and zrr = '" + a + "')) a INNER JOIN (SELECT pId,bh from nprocessing2 WHERE ((pId,LID) IN (SELECT pId,up FROM jd where LID = '9') AND  status = '1'))b ON a.x=b.pId AND a.xx = b.bh)) a LEFT JOIN (SELECT bh xx,getId x,pId,status,problem,page from (SELECT pId x,bh xx,getId,status,problem,page from nprocessing2 WHERE (LID ='9' AND status = '0' and zrr = '" + a + "')) a INNER JOIN (SELECT pId,bh from nprocessing2 WHERE ((pId,LID) IN (SELECT pId,up FROM jd where LID = '9') AND  status = '1'))b ON a.x=b.pId AND a.xx = b.bh) b on a.getId = b.x and a.bh = b.xx";
            DataSet ds = DBhelper.Dataset(s3);
            return ds;
        }
        public DataSet Select112003(string a)
        {

            string s3 = "SELECT lzId 流转单号,status 状态,pId 项目号,bh 编号,projectunit 项目单位,filetype 档案类型,problem 问题描述,page 页数  FROM ( SELECT status1 ,lzId ,bh ,projectunit ,filetype,getId FROM fileprocess WHERE (bh,getId) IN (SELECT bh,getId from (SELECT pId x,bh xx,getId,status from nprocessing2 WHERE (LID ='10' AND status = '0' and zrr = '" + a + "')) a INNER JOIN (SELECT pId,bh from nprocessing2 WHERE ((pId,LID) IN (SELECT pId,up FROM jd where LID = '10') AND  status = '1'))b ON a.x=b.pId AND a.xx = b.bh)) a LEFT JOIN (SELECT bh xx,getId x,pId,status,problem,page from (SELECT pId x,bh xx,getId,status,problem,page from nprocessing2 WHERE (LID ='10' AND status = '0' and zrr = '" + a + "')) a INNER JOIN (SELECT pId,bh from nprocessing2 WHERE ((pId,LID) IN (SELECT pId,up FROM jd where LID = '10') AND  status = '1'))b ON a.x=b.pId AND a.xx = b.bh) b on a.getId = b.x and a.bh = b.xx";
            DataSet ds = DBhelper.Dataset(s3);
            return ds;
        }
        public DataSet Select112004(string a)
        {

            string s3 = "SELECT lzId 流转单号,status 状态,pId 项目号,bh 编号,projectunit 项目单位,filetype 档案类型,problem 问题描述,page 页数  FROM ( SELECT status1 ,lzId ,bh ,projectunit ,filetype,getId FROM fileprocess WHERE (bh,getId) IN (SELECT bh,getId from (SELECT pId x,bh xx,getId,status from nprocessing2 WHERE (LID ='11' AND status = '0' and zrr = '" + a + "')) a INNER JOIN (SELECT pId,bh from nprocessing2 WHERE ((pId,LID) IN (SELECT pId,up FROM jd where LID = '11') AND  status = '1'))b ON a.x=b.pId AND a.xx = b.bh)) a LEFT JOIN (SELECT bh xx,getId x,pId,status,problem,page from (SELECT pId x,bh xx,getId,status,problem,page from nprocessing2 WHERE (LID ='11' AND status = '0' and zrr = '" + a + "')) a INNER JOIN (SELECT pId,bh from nprocessing2 WHERE ((pId,LID) IN (SELECT pId,up FROM jd where LID = '11') AND  status = '1'))b ON a.x=b.pId AND a.xx = b.bh) b on a.getId = b.x and a.bh = b.xx";
            DataSet ds = DBhelper.Dataset(s3);
            return ds;
        }
    }
}
