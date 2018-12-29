using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class GetJobDAL
    {
        public DataSet Select()
        {
            string s3 = "SELECT pId 项目号,projectunit 项目单位,filetype 档案类型 FROM project1 WHERE pId IN(SELECT pId FROM nprocessing WHERE LID = 1 and status = 0)";
            DataSet ds = DBhelper.Dataset(s3);
            return ds;
        }
        public DataSet Select2()
        {
            string s3 = " SELECT lzId 流转单号,status 状态,pId 项目号,bh 编号,projectunit 项目单位,filetype 档案类型  FROM ( SELECT status1 ,lzId ,bh ,projectunit ,filetype,getId FROM fileprocess WHERE (bh,getId) IN (SELECT bh,getId from (SELECT pId x,bh xx,getId,status from nprocessing2 WHERE (LID ='3' AND status = '0' and zrr is null)) a INNER JOIN (SELECT pId,bh from nprocessing2 WHERE ((pId,LID) IN (SELECT pId,up FROM jd where LID = '3') AND  status = '1'))b ON a.x=b.pId AND a.xx = b.bh)) a LEFT JOIN (SELECT bh xx,getId x,pId,status from (SELECT pId x,bh xx,getId,status from nprocessing2 WHERE (LID ='3' AND status = '0' and zrr is null)) a INNER JOIN (SELECT pId,bh from nprocessing2 WHERE ((pId,LID) IN (SELECT pId,up FROM jd where LID = '3') AND  status = '1'))b ON a.x=b.pId AND a.xx = b.bh) b on a.getId = b.x and a.bh = b.xx";
            DataSet ds = DBhelper.Dataset(s3);
            return ds;
        }
        public DataSet Select3()
        {
            string s3 = "SELECT lzId 流转单号,status 状态,pId 项目号,bh 编号,projectunit 项目单位,filetype 档案类型  FROM ( SELECT status1 ,lzId ,bh ,projectunit ,filetype,getId FROM fileprocess WHERE (bh,getId) IN (SELECT bh,getId from (SELECT pId x,bh xx,getId,status from nprocessing2 WHERE (LID ='4' AND status = '0' and zrr is null)) a INNER JOIN (SELECT pId,bh from nprocessing2 WHERE ((pId,LID) IN (SELECT pId,up FROM jd where LID = '4') AND  status = '1'))b ON a.x=b.pId AND a.xx = b.bh)) a LEFT JOIN (SELECT bh xx,getId x,pId,status from (SELECT pId x,bh xx,getId,status from nprocessing2 WHERE (LID ='4' AND status = '0' and zrr is null)) a INNER JOIN (SELECT pId,bh from nprocessing2 WHERE ((pId,LID) IN (SELECT pId,up FROM jd where LID = '4') AND  status = '1'))b ON a.x=b.pId AND a.xx = b.bh) b on a.getId = b.x and a.bh = b.xx";
            DataSet ds = DBhelper.Dataset(s3);
            return ds;
        }
        public DataSet Select4()
        {
            string s3 = "SELECT distinct getId 领取批次号,status 状态  ,pId 项目号,bh 编号,projectunit 项目单位,filetype 档案类型 from (SELECT status,pId,bh,getId from (SELECT pId x,bh xx,getId,status from nprocessing2 WHERE (LID ='2' AND status = '0' and zrr is null)) a INNER JOIN (SELECT pId,bh from nprocessing2 WHERE ((pId,LID) IN (SELECT pId,up FROM jd where LID = '2') AND  status = '1'))b ON a.x=b.pId AND a.xx = b.bh)a LEFT JOIN (SELECT pId xxx,projectunit ,filetype  FROM project1 WHERE pId IN(SELECT pId FROM nprocessing2 WHERE LID = '2' and status = 0)) b ON a.pId = b.xxx";
            DataSet ds = DBhelper.Dataset(s3);
            return ds;
        }
        public DataSet Select5()
        {
            string s3 = " SELECT lzId 流转单号,status 状态,pId 项目号,bh 编号,projectunit 项目单位,filetype 档案类型  FROM ( SELECT status1 ,lzId ,bh ,projectunit ,filetype,getId FROM fileprocess WHERE (bh,getId) IN (SELECT bh,getId from (SELECT pId x,bh xx,getId,status from nprocessing2 WHERE (LID ='6' AND status = '0' and zrr is null)) a INNER JOIN (SELECT pId,bh from nprocessing2 WHERE ((pId,LID) IN (SELECT pId,up FROM jd where LID = '6') AND  status = '1'))b ON a.x=b.pId AND a.xx = b.bh)) a LEFT JOIN (SELECT bh xx,getId x,pId,status from (SELECT pId x,bh xx,getId,status from nprocessing2 WHERE (LID ='6' AND status = '0' and zrr is null)) a INNER JOIN (SELECT pId,bh from nprocessing2 WHERE ((pId,LID) IN (SELECT pId,up FROM jd where LID = '6') AND  status = '1'))b ON a.x=b.pId AND a.xx = b.bh) b on a.getId = b.x and a.bh = b.xx";
            DataSet ds = DBhelper.Dataset(s3);
            return ds;
        }
        public DataSet Select6()
        {
            string s3 = " SELECT lzId 流转单号,status 状态,pId 项目号,bh 编号,projectunit 项目单位,filetype 档案类型  FROM ( SELECT status1 ,lzId ,bh ,projectunit ,filetype,getId FROM fileprocess WHERE (bh,getId) IN (SELECT bh,getId from (SELECT pId x,bh xx,getId,status from nprocessing2 WHERE (LID ='7' AND status = '0' and zrr is null)) a INNER JOIN (SELECT pId,bh from nprocessing2 WHERE ((pId,LID) IN (SELECT pId,up FROM jd where LID = '7') AND  status = '1'))b ON a.x=b.pId AND a.xx = b.bh)) a LEFT JOIN (SELECT bh xx,getId x,pId,status from (SELECT pId x,bh xx,getId,status from nprocessing2 WHERE (LID ='7' AND status = '0' and zrr is null)) a INNER JOIN (SELECT pId,bh from nprocessing2 WHERE ((pId,LID) IN (SELECT pId,up FROM jd where LID = '7') AND  status = '1'))b ON a.x=b.pId AND a.xx = b.bh) b on a.getId = b.x and a.bh = b.xx";
            DataSet ds = DBhelper.Dataset(s3);
            return ds;
        }
        public DataSet Select7()
        {
            string s3 = " SELECT lzId 流转单号,status 状态,pId 项目号,bh 编号,projectunit 项目单位,filetype 档案类型  FROM ( SELECT status1 ,lzId ,bh ,projectunit ,filetype,getId FROM fileprocess WHERE (bh,getId) IN (SELECT bh,getId from (SELECT pId x,bh xx,getId,status from nprocessing2 WHERE (LID ='8' AND status = '0' and zrr is null)) a INNER JOIN (SELECT pId,bh from nprocessing2 WHERE ((pId,LID) IN (SELECT pId,up FROM jd where LID = '8') AND  status = '1'))b ON a.x=b.pId AND a.xx = b.bh)) a LEFT JOIN (SELECT bh xx,getId x,pId,status from (SELECT pId x,bh xx,getId,status from nprocessing2 WHERE (LID ='8' AND status = '0' and zrr is null)) a INNER JOIN (SELECT pId,bh from nprocessing2 WHERE ((pId,LID) IN (SELECT pId,up FROM jd where LID = '8') AND  status = '1'))b ON a.x=b.pId AND a.xx = b.bh) b on a.getId = b.x and a.bh = b.xx";
            DataSet ds = DBhelper.Dataset(s3);
            return ds;
        }
        public DataSet Select8()
        {
            string s3 = " SELECT lzId 流转单号,status 状态,pId 项目号,bh 编号,projectunit 项目单位,filetype 档案类型  FROM ( SELECT status1 ,lzId ,bh ,projectunit ,filetype,getId FROM fileprocess WHERE (bh,getId) IN (SELECT bh,getId from (SELECT pId x,bh xx,getId,status from nprocessing2 WHERE (LID ='9' AND status = '0' and zrr is null)) a INNER JOIN (SELECT pId,bh from nprocessing2 WHERE ((pId,LID) IN (SELECT pId,up FROM jd where LID = '9') AND  status = '1'))b ON a.x=b.pId AND a.xx = b.bh)) a LEFT JOIN (SELECT bh xx,getId x,pId,status from (SELECT pId x,bh xx,getId,status from nprocessing2 WHERE (LID ='9' AND status = '0' and zrr is null)) a INNER JOIN (SELECT pId,bh from nprocessing2 WHERE ((pId,LID) IN (SELECT pId,up FROM jd where LID = '9') AND  status = '1'))b ON a.x=b.pId AND a.xx = b.bh) b on a.getId = b.x and a.bh = b.xx";
            DataSet ds = DBhelper.Dataset(s3);
            return ds;
        }
        public DataSet Select9()
        {
            string s3 = " SELECT lzId 流转单号,status 状态,pId 项目号,bh 编号,projectunit 项目单位,filetype 档案类型  FROM ( SELECT status1 ,lzId ,bh ,projectunit ,filetype,getId FROM fileprocess WHERE (bh,getId) IN (SELECT bh,getId from (SELECT pId x,bh xx,getId,status from nprocessing2 WHERE (LID ='10' AND status = '0' and zrr is null)) a INNER JOIN (SELECT pId,bh from nprocessing2 WHERE ((pId,LID) IN (SELECT pId,up FROM jd where LID = '10') AND  status = '1'))b ON a.x=b.pId AND a.xx = b.bh)) a LEFT JOIN (SELECT bh xx,getId x,pId,status from (SELECT pId x,bh xx,getId,status from nprocessing2 WHERE (LID ='10' AND status = '0' and zrr is null)) a INNER JOIN (SELECT pId,bh from nprocessing2 WHERE ((pId,LID) IN (SELECT pId,up FROM jd where LID = '10') AND  status = '1'))b ON a.x=b.pId AND a.xx = b.bh) b on a.getId = b.x and a.bh = b.xx";
            DataSet ds = DBhelper.Dataset(s3);
            return ds;
        }
        public DataSet Select10()
        {
            string s3 = " SELECT lzId 流转单号,status 状态,pId 项目号,bh 编号,projectunit 项目单位,filetype 档案类型  FROM ( SELECT status1 ,lzId ,bh ,projectunit ,filetype,getId FROM fileprocess WHERE (bh,getId) IN (SELECT bh,getId from (SELECT pId x,bh xx,getId,status from nprocessing2 WHERE (LID ='11' AND status = '0' and zrr is null)) a INNER JOIN (SELECT pId,bh from nprocessing2 WHERE ((pId,LID) IN (SELECT pId,up FROM jd where LID = '11') AND  status = '1'))b ON a.x=b.pId AND a.xx = b.bh)) a LEFT JOIN (SELECT bh xx,getId x,pId,status from (SELECT pId x,bh xx,getId,status from nprocessing2 WHERE (LID ='11' AND status = '0' and zrr is null)) a INNER JOIN (SELECT pId,bh from nprocessing2 WHERE ((pId,LID) IN (SELECT pId,up FROM jd where LID = '11') AND  status = '1'))b ON a.x=b.pId AND a.xx = b.bh) b on a.getId = b.x and a.bh = b.xx";
            DataSet ds = DBhelper.Dataset(s3);
            return ds;
        }
        public DataSet Select1015(string a)
        {
            string s3 = "SELECT lzId 流转单号,status 状态,pId 项目号,bh 编号,projectunit 项目单位,filetype 档案类型,problem 问题描述,page 页数 FROM ( SELECT status1 ,lzId ,bh ,projectunit ,filetype,getId FROM fileprocess WHERE (bh,getId) IN (SELECT bh,getId from (SELECT pId x,bh xx,getId,status from nprocessing2 WHERE (LID ='4' AND status = '0' and zrr = '" + a + "')) a INNER JOIN (SELECT pId,bh from nprocessing2 WHERE ((pId,LID) IN (SELECT pId,up FROM jd where LID = '4') AND  status = '1'))b ON a.x=b.pId AND a.xx = b.bh)) a LEFT JOIN (SELECT bh xx,getId x,pId,status,problem,page from (SELECT pId x,bh xx,getId,status,problem,page from nprocessing2 WHERE (LID ='4' AND status = '0' and zrr = '" + a + "')) a INNER JOIN (SELECT pId,bh from nprocessing2 WHERE ((pId,LID) IN (SELECT pId,up FROM jd where LID = '4') AND  status = '1'))b ON a.x=b.pId AND a.xx = b.bh) b on a.getId = b.x and a.bh = b.xx";
            DataSet ds = DBhelper.Dataset(s3);
            return ds;
        }
        public DataSet Select1225()
        {
            string s3 = "SELECT lzId 流转单号,status 状态,pId 项目号,bh 编号,projectunit 项目单位,filetype 档案类型  FROM ( SELECT status1 ,lzId ,bh ,projectunit ,filetype,getId FROM fileprocess WHERE (bh,getId) IN (SELECT bh,getId from (SELECT pId x,bh xx,getId,status from nprocessing2 WHERE (LID ='5' AND status = '0' and zrr is null)) a INNER JOIN (SELECT pId,bh from nprocessing2 WHERE ((pId,LID) IN (SELECT pId,up FROM jd where LID = '5') AND  status = '1'))b ON a.x=b.pId AND a.xx = b.bh)) a LEFT JOIN (SELECT bh xx,getId x,pId,status from (SELECT pId x,bh xx,getId,status from nprocessing2 WHERE (LID ='5' AND status = '0' and zrr is null)) a INNER JOIN (SELECT pId,bh from nprocessing2 WHERE ((pId,LID) IN (SELECT pId,up FROM jd where LID = '5') AND  status = '1'))b ON a.x=b.pId AND a.xx = b.bh) b on a.getId = b.x and a.bh = b.xx";
            DataSet ds = DBhelper.Dataset(s3);
            return ds;
        }
        public DataSet Select122501(string a)
        {
            string s3 = "SELECT lzId 流转单号,status 状态,pId 项目号,bh 编号,projectunit 项目单位,filetype 档案类型,problem 问题描述,page 页数 FROM ( SELECT status1 ,lzId ,bh ,projectunit ,filetype,getId FROM fileprocess WHERE (bh,getId) IN (SELECT bh,getId from (SELECT pId x,bh xx,getId,status from nprocessing2 WHERE (LID ='5' AND status = '0' and zrr = '" + a + "')) a INNER JOIN (SELECT pId,bh from nprocessing2 WHERE ((pId,LID) IN (SELECT pId,up FROM jd where LID = '5') AND  status = '1'))b ON a.x=b.pId AND a.xx = b.bh)) a LEFT JOIN (SELECT bh xx,getId x,pId,status,problem,page from (SELECT pId x,bh xx,getId,status,problem,page from nprocessing2 WHERE (LID ='5' AND status = '0' and zrr = '" + a + "')) a INNER JOIN (SELECT pId,bh from nprocessing2 WHERE ((pId,LID) IN (SELECT pId,up FROM jd where LID = '5') AND  status = '1'))b ON a.x=b.pId AND a.xx = b.bh) b on a.getId = b.x and a.bh = b.xx";
            DataSet ds = DBhelper.Dataset(s3);
            return ds;
        }
    }
}
