using MODEL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class WorkDAL
    {
        public DataSet Select(string a, string b)
        {

            string s3 = "SELECT dangId 档号,filetype 档案类型,projectUnit 项目单位 FROM file1 WHERE filetype like '%" + a + "%' and projectUnit like '%" + b + "%'";

            DataSet ds = DBhelper.Dataset(s3);
            return ds;
        }
        public DataSet Select2(string a, string b)
        {

            string s3 = "SELECT dangId 档号,filetype 档案类型,projectUnit 项目单位 FROM file2 WHERE filetype like '%" + a + "%' and projectUnit like '%" + b + "%'";

            DataSet ds = DBhelper.Dataset(s3);
            return ds;
        }
        public DataSet Select3(string a, string b)
        {

            string s3 = "SELECT dangId 档号,filetype 档案类型,projectUnit 项目单位 FROM file3 WHERE filetype like '%" + a + "%' and projectUnit like '%" + b + "%'";

            DataSet ds = DBhelper.Dataset(s3);
            return ds;
        }
        //自定义工作流
        public bool Insert(workstatus w)
        {
            string s = "update processing set lq = '" + w.lq + "', cf = '" + w.cf + "', zl = '" + w.zl + "',dm = '" + w.dm + "', sm = '" + w.sm + "', bm = '" + w.bm + "', tc = '" + w.tc + "',zj = '" + w.zj + "',gj = '" + w.gj + "',hy = '" + w.hy + "', gh = '" + w.gh + "' ,flag = '" + w.flag + "' ,projectunit = '" + w.projectUnit + "' where pId = '" + w.dangId + "'";

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
        //领取档案单
        public bool Insert2(getfile w)
        {
            string s = "insert into fileget(bh,projectunit,getId,gettime,dangId,filetype,gdmethod,year,question,projectunit2,processunit,swapdate,swapdate2) values('" + w.bh + "','" + w.projectunit + "','" + w.getId + "','" + w.gettime + "','" + w.dangId + "','" + w.filetype + "','" + w.gdmethod + "','" + w.year + "','" + w.question + "','" + w.projetunit2 + "','" + w.processunit + "','" + w.swapdate + "','" + w.swapdate2 + "') ";

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
        //添加档案领取问题单
        public bool Insert3(getfile w)
        {
            string s = "insert into fileproblem(bh,projectunit,getId,gettime,dangtype,gdmethod,year,problem,projectunit2,processunit,swapdate,swapdate2,solve) values('" + w.bh + "','" + w.projectunit + "','" + w.getId + "','" + w.gettime + "','" + w.filetype + "','" + w.gdmethod + "','" + w.year + "','" + w.question + "','" + w.projetunit2 + "','" + w.processunit + "','" + w.swapdate + "','" + w.swapdate2 + "','" + w.solve + "') ";

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
        //修改工作状态
        public bool update(string a)
        {
            string s = "UPDATE processing set status1 = status1 + 1 WHERE dangId = '" + a + "'";

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
        //获取加工流转单
        public MySqlDataReader Selectinfo2(string str)
        {
            string s9 = "select year,gdmethod from project1 where pId = '" + str + "'";
            MySqlDataReader sdr = DBhelper.ExecuteReader(s9);
            return sdr;
        }
        public MySqlDataReader Selectinfo3(string str)
        {
            string s9 = "select projectunit,filetype,gdmethod,year from project1 where pId = '" + str + "'";
            MySqlDataReader sdr = DBhelper.ExecuteReader(s9);
            return sdr;
        }
        //添加拆分加工流转单
        public bool Insert4(processfile w)
        {
            string s = "insert into fileprocess(projectunit,getId,lzId,filetype,gdmethod,year,bh,process,processdate,responesible,page) values('" + w.projectunit + "','" + w.getId + "','" + w.lzId + "','" + w.filetype + "','" + w.gdmethod + "','" + w.year + "','" + w.bh + "','" + w.process + "','" + w.processdate + "','" + w.responseible + "','" + w.page + "') ";

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
        //拆分员修改工作状态
        public bool update2(string a, string b)
        {
            string s = "UPDATE nprocessing2 set status = 1 WHERE getId = '" + a + "' and bh = '" + b + "' and LID = 3";

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
        public bool update13(string a, string b)
        {
            string s = "UPDATE nprocessing2 set status = 1 WHERE getId = '" + a + "' and bh = '" + b + "' and LID = 4";

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
        public bool update1225(string a, string b)
        {
            string s = "UPDATE nprocessing2 set status = 1 WHERE getId = '" + a + "' and bh = '" + b + "' and LID = 5";

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
        public bool update14(string a, string b)
        {
            string s = "UPDATE nprocessing2 set status = 1 WHERE getId = '" + a + "' and bh = '" + b + "' and LID = 2";

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
        public bool update15(string a, string b)
        {
            string s = "UPDATE nprocessing2 set status = 1 WHERE getId = '" + a + "' and bh = '" + b + "' and LID = 6";

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
        public bool update16(string a, string b)
        {
            string s = "UPDATE nprocessing2 set status = 1 WHERE getId = '" + a + "' and bh = '" + b + "' and LID = 7";

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
        public bool update17(string a, string b)
        {
            string s = "UPDATE nprocessing2 set status = 1 WHERE getId = '" + a + "' and bh = '" + b + "' and LID = 8";

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
        public bool update18(string a, string b)
        {
            string s = "UPDATE nprocessing2 set status = 1 WHERE getId = '" + a + "' and bh = '" + b + "' and LID = 9";

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
        public bool update19(string a, string b)
        {
            string s = "UPDATE nprocessing2 set status = 1 WHERE getId = '" + a + "' and bh = '" + b + "' and LID = 10";

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
        public bool update20(string a, string b)
        {
            string s = "UPDATE nprocessing2 set status = 0 , zrr = null WHERE bh = '" + a + "' and getId = '" + b + "' and (LID = 1 OR LID = 2)";

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
        //执行退回操作改变档案状态
        public bool update3(string a, string b)
        {
            string s = "UPDATE nprocessing2 set status = 0 , zrr = null WHERE bh = '" + a + "' and getId = '" + b + "' and (LID = 2 OR LID = 3)";

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
        public bool update22(string a, string b)
        {
            string s = "UPDATE nprocessing2 set status = 0 , zrr = null WHERE bh = '" + a + "' and getId = '" + b + "' and (LID = 1 OR LID = 2)";

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
        public bool update24(string a, string b)
        {
            string s = "UPDATE nprocessing2 set status = 0 , zrr = null WHERE bh = '" + a + "' and getId = '" + b + "' and (LID = 4 OR LID = 3)";

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
        public bool update1225001(string a, string b)
        {
            string s = "UPDATE nprocessing2 set status = 0 , zrr = null WHERE bh = '" + a + "' and getId = '" + b + "' and (LID = 5 OR LID = 4)";

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
        public bool update25(string a, string b)
        {
            string s = "UPDATE nprocessing2 set status = 0 , zrr = null WHERE bh = '" + a + "' and getId = '" + b + "' and (LID = 6 OR LID = 5)";

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
        public bool update26(string a, string b)
        {
            string s = "UPDATE nprocessing2 set status = 0 , zrr = null WHERE bh = '" + a + "' and getId = '" + b + "' and (LID = 6 OR LID = 7)";

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
        public bool update27(string a, string b)
        {
            string s = "UPDATE nprocessing2 set status = 0 , zrr = null WHERE bh = '" + a + "' and getId = '" + b + "' and (LID = 7 OR LID = 8)";

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
        public bool update28(string a, string b)
        {
            string s = "UPDATE nprocessing2 set status = 0 , zrr = null WHERE bh = '" + a + "' and getId = '" + b + "' and (LID = 8 OR LID = 9)";

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
        public bool update29(string a, string b)
        {
            string s = "UPDATE nprocessing2 set status = 0 , zrr = null WHERE bh = '" + a + "' and getId = '" + b + "' and (LID = 9 OR LID = 10)";

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
        public bool update30(string a, string b)
        {
            string s = "UPDATE nprocessing2 set status = 0 , zrr = null WHERE bh = '" + a + "' and getId = '" + b + "' and (LID = 10 OR LID = 11)";

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
        //添加著录加工流转单
        public bool Insert5(processfile w)
        {
            string s = "insert into fileprocess2(projectunit,getId,lzId,filetype,gdmethod,year,dangId,process,processdate,responesible,page) values('" + w.projectunit + "','" + w.getId + "','" + w.lzId + "','" + w.filetype + "','" + w.gdmethod + "','" + w.year + "','" + w.bh + "','" + w.process + "','" + w.processdate + "','" + w.responseible + "','" + w.page + "') ";

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
        //添加拆分档案问题单
        public bool Insert6(getfile w)
        {
            string s = "insert into fileproblem3(bh,projectunit,getId,gettime,dangtype,gdmethod,year,problem,projectunit2,processunit,swapdate,swapdate2,solve) values('" + w.bh + "','" + w.projectunit + "','" + w.getId + "','" + w.gettime + "','" + w.filetype + "','" + w.gdmethod + "','" + w.year + "','" + w.question + "','" + w.projetunit2 + "','" + w.processunit + "','" + w.swapdate + "','" + w.swapdate2 + "','" + w.solve + "') ";

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
        //添加著录档案问题单
        public bool Insert7(getfile w)
        {
            string s = "insert into fileproblem4(bh,projectunit,getId,gettime,dangtype,gdmethod,year,problem,projectunit2,processunit,swapdate,swapdate2,solve) values('" + w.bh + "','" + w.projectunit + "','" + w.getId + "','" + w.gettime + "','" + w.filetype + "','" + w.gdmethod + "','" + w.year + "','" + w.question + "','" + w.projetunit2 + "','" + w.processunit + "','" + w.swapdate + "','" + w.swapdate2 + "','" + w.solve + "') ";

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
        public bool Insert8(processfile w)
        {
            string s = "insert into fileprocess3(projectunit,getId,lzId,filetype,gdmethod,year,dangId,process,processdate,responesible,page) values('" + w.projectunit + "','" + w.getId + "','" + w.lzId + "','" + w.filetype + "','" + w.gdmethod + "','" + w.year + "','" + w.bh + "','" + w.process + "','" + w.processdate + "','" + w.responseible + "','" + w.page + "') ";

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
        //添加打码档案问题单
        public bool Insert9(getfile w)
        {
            string s = "insert into fileproblem2(bh,projectunit,getId,gettime,dangtype,gdmethod,year,problem,projectunit2,processunit,swapdate,swapdate2,solve) values('" + w.bh + "','" + w.projectunit + "','" + w.getId + "','" + w.gettime + "','" + w.filetype + "','" + w.gdmethod + "','" + w.year + "','" + w.question + "','" + w.projetunit2 + "','" + w.processunit + "','" + w.swapdate + "','" + w.swapdate2 + "','" + w.solve + "') ";

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
        public bool Insert10(processfile w)
        {
            string s = "insert into fileprocess4(projectunit,getId,lzId,filetype,gdmethod,year,dangId,process,processdate,responesible,page) values('" + w.projectunit + "','" + w.getId + "','" + w.lzId + "','" + w.filetype + "','" + w.gdmethod + "','" + w.year + "','" + w.bh + "','" + w.process + "','" + w.processdate + "','" + w.responseible + "','" + w.page + "') ";

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
        //添加还原档案问题单
        public bool Insert11(getfile w)
        {
            string s = "insert into fileproblem9(bh,projectunit,getId,gettime,dangtype,gdmethod,year,problem,projectunit2,processunit,swapdate,swapdate2,solve) values('" + w.bh + "','" + w.projectunit + "','" + w.getId + "','" + w.gettime + "','" + w.filetype + "','" + w.gdmethod + "','" + w.year + "','" + w.question + "','" + w.projetunit2 + "','" + w.processunit + "','" + w.swapdate + "','" + w.swapdate2 + "','" + w.solve + "') ";

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
        public bool Insert12(processfile w)
        {
            string s = "insert into fileprocess5(projectunit,getId,lzId,filetype,gdmethod,year,dangId,process,processdate,responesible,page) values('" + w.projectunit + "','" + w.getId + "','" + w.lzId + "','" + w.filetype + "','" + w.gdmethod + "','" + w.year + "','" + w.bh + "','" + w.process + "','" + w.processdate + "','" + w.responseible + "','" + w.page + "') ";

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
        //添加扫描档案问题单
        public bool Insert13(getfile w)
        {
            string s = "insert into fileproblem5(bh,projectunit,getId,gettime,dangtype,gdmethod,year,problem,projectunit2,processunit,swapdate,swapdate2,solve) values('" + w.bh + "','" + w.projectunit + "','" + w.getId + "','" + w.gettime + "','" + w.filetype + "','" + w.gdmethod + "','" + w.year + "','" + w.question + "','" + w.projetunit2 + "','" + w.processunit + "','" + w.swapdate + "','" + w.swapdate2 + "','" + w.solve + "') ";

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
        public bool Insert14(processfile w)
        {
            string s = "insert into fileprocess6(projectunit,getId,lzId,filetype,gdmethod,year,dangId,process,processdate,responesible,page) values('" + w.projectunit + "','" + w.getId + "','" + w.lzId + "','" + w.filetype + "','" + w.gdmethod + "','" + w.year + "','" + w.bh + "','" + w.process + "','" + w.processdate + "','" + w.responseible + "','" + w.page + "') ";

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
        //添加编目档案问题单
        public bool Insert15(getfile w)
        {
            string s = "insert into fileproblem7(bh,projectunit,getId,gettime,dangtype,gdmethod,year,problem,projectunit2,processunit,swapdate,swapdate2,solve) values('" + w.bh + "','" + w.projectunit + "','" + w.getId + "','" + w.gettime + "','" + w.filetype + "','" + w.gdmethod + "','" + w.year + "','" + w.question + "','" + w.projetunit2 + "','" + w.processunit + "','" + w.swapdate + "','" + w.swapdate2 + "','" + w.solve + "') ";

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
        public bool Insert16(processfile w)
        {
            string s = "insert into fileprocess7(projectunit,getId,lzId,filetype,gdmethod,year,dangId,process,processdate,responesible,page) values('" + w.projectunit + "','" + w.getId + "','" + w.lzId + "','" + w.filetype + "','" + w.gdmethod + "','" + w.year + "','" + w.bh + "','" + w.process + "','" + w.processdate + "','" + w.responseible + "','" + w.page + "') ";

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
        //添加图处档案问题单
        public bool Insert17(getfile w)
        {
            string s = "insert into fileproblem6(bh,projectunit,getId,gettime,dangtype,gdmethod,year,problem,projectunit2,processunit,swapdate,swapdate2,solve) values('" + w.bh + "','" + w.projectunit + "','" + w.getId + "','" + w.gettime + "','" + w.filetype + "','" + w.gdmethod + "','" + w.year + "','" + w.question + "','" + w.projetunit2 + "','" + w.processunit + "','" + w.swapdate + "','" + w.swapdate2 + "','" + w.solve + "') ";

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
        public bool Insert18(processfile w)
        {
            string s = "insert into fileprocess8(projectunit,getId,lzId,filetype,gdmethod,year,dangId,process,processdate,responesible,page) values('" + w.projectunit + "','" + w.getId + "','" + w.lzId + "','" + w.filetype + "','" + w.gdmethod + "','" + w.year + "','" + w.bh + "','" + w.process + "','" + w.processdate + "','" + w.responseible + "','" + w.page + "') ";

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
        public bool Insert19(processfile w)
        {
            string s = "insert into fileprocess9(projectunit,getId,lzId,filetype,gdmethod,year,dangId,process,processdate,responesible,page) values('" + w.projectunit + "','" + w.getId + "','" + w.lzId + "','" + w.filetype + "','" + w.gdmethod + "','" + w.year + "','" + w.bh + "','" + w.process + "','" + w.processdate + "','" + w.responseible + "','" + w.page + "') ";

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
        public bool Insert20(processfile w)
        {
            string s = "insert into fileprocess10(projectunit,getId,lzId,filetype,gdmethod,year,dangId,process,processdate,responesible,page) values('" + w.projectunit + "','" + w.getId + "','" + w.lzId + "','" + w.filetype + "','" + w.gdmethod + "','" + w.year + "','" + w.bh + "','" + w.process + "','" + w.processdate + "','" + w.responseible + "','" + w.page + "') ";

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
        //添加质检档案问题单
        public bool Insert21(getfile w)
        {
            string s = "insert into fileproblem7(bh,projectunit,getId,gettime,dangtype,gdmethod,year,problem,projectunit2,processunit,swapdate,swapdate2,solve) values('" + w.bh + "','" + w.projectunit + "','" + w.getId + "','" + w.gettime + "','" + w.filetype + "','" + w.gdmethod + "','" + w.year + "','" + w.question + "','" + w.projetunit2 + "','" + w.processunit + "','" + w.swapdate + "','" + w.swapdate2 + "','" + w.solve + "') ";

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
        //添加挂接档案问题单
        public bool Insert22(getfile w)
        {
            string s = "insert into fileproblem10(bh,projectunit,getId,gettime,dangtype,gdmethod,year,problem,projectunit2,processunit,swapdate,swapdate2,solve) values('" + w.bh + "','" + w.projectunit + "','" + w.getId + "','" + w.gettime + "','" + w.filetype + "','" + w.gdmethod + "','" + w.year + "','" + w.question + "','" + w.projetunit2 + "','" + w.processunit + "','" + w.swapdate + "','" + w.swapdate2 + "','" + w.solve + "') ";

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
        //添加归还档案问题单
        public bool Insert23(getfile w)
        {
            string s = "insert into fileproblem11(bh,projectunit,getId,gettime,dangId,dangtype,gdmethod,year,problem,projectunit2,processunit,swapdate,swapdate2,solve) values('" + w.bh + "','" + w.projectunit + "','" + w.getId + "','" + w.gettime + "','" + w.dangId + "','" + w.filetype + "','" + w.gdmethod + "','" + w.year + "','" + w.question + "','" + w.projetunit2 + "','" + w.processunit + "','" + w.swapdate + "','" + w.swapdate2 + "','" + w.solve + "') ";

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
        //档案归还单
        public bool Insert24(getfile w)
        {
            string s = "insert into fileGH(projectunit,getId,gettime,dangId,filetype,gdmethod,year,question,projectunit2,processunit,swapdate,swapdate2) values('" + w.projectunit + "','" + w.getId + "','" + w.gettime + "','" + w.dangId + "','" + w.filetype + "','" + w.gdmethod + "','" + w.year + "','" + w.question + "','" + w.projetunit2 + "','" + w.processunit + "','" + w.swapdate + "','" + w.swapdate2 + "') ";

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
        //修改加工流转单状态
        public bool update4(processfile p)
        {
            string s = "UPDATE fileprocess set year = '" + p.year + "',page ='" + p.page + "',responesible='" + p.responseible + "',process = '" + p.process + "',processdate = '" + p.processdate + "' WHERE bh = '" + p.bh + "'";

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

        //查找是否存在档号一样的档案
        public MySqlDataReader Selectinfo3(string str, string b)
        {
            string s9 = "SELECT  * from fileprocess where bh = '" + str + "' and getId = '" + b + "'";
            MySqlDataReader sdr = DBhelper.ExecuteReader(s9);
            return sdr;
        }
        public MySqlDataReader Selectinfo4(string str)
        {
            string s9 = "SELECT * FROM fileprocess where process != '归还' and projectunit = '" + str + "'";
            MySqlDataReader sdr = DBhelper.ExecuteReader(s9);
            return sdr;
        }
        public bool Insert111(getfile w, int p)
        {
            string s = "INSERT INTO projecterror (projectunit,getId,page) VALUE ('" + w.processunit + "','" + w.getId + "','" + p + "')";

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
        public MySqlDataReader Selectinfo111(string str)
        {
            string s9 = "SELECT page FROM file1 WHERE dangId = '" + str + "' UNION SELECT page FROM file2 WHERE dangId = '" + str + "' UNION SELECT page FROM file3 WHERE dangId = '" + str + "'";
            MySqlDataReader sdr = DBhelper.ExecuteReader(s9);
            return sdr;
        }
        public MySqlDataReader Selectinfo222(string str)
        {
            string s9 = "SELECT * from fileprocess where getId = '" + str + "' and process != '归还'";
            MySqlDataReader sdr = DBhelper.ExecuteReader(s9);
            return sdr;
        }
        public bool Insert222(processfile w)
        {
            string s = "INSERT INTO projecterror (getId,backtime) VALUE ('" + w.getId + "','" + w.processdate + "')";

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
        public bool Insert123(getfile w)
        {
            string s = "insert into fileback(projectunit,getId,gettime,dangId,filetype,gdmethod,year,question,projectunit2,processunit,swapdate,swapdate2) values('" + w.projectunit + "','" + w.getId + "','" + w.gettime + "','" + w.dangId + "','" + w.filetype + "','" + w.gdmethod + "','" + w.year + "','" + w.question + "','" + w.projetunit2 + "','" + w.processunit + "','" + w.swapdate + "','" + w.swapdate2 + "') ";

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
        public MySqlDataReader Selectinfo123(string str)
        {
            string s9 = "select * from processing where pId = '" + str + "'";
            MySqlDataReader sdr = DBhelper.ExecuteReader(s9);
            return sdr;
        }
        public bool Insert456(workstatus w)
        {
            string s = "insert into processing(lq,cf,zl,dm,sm,bm,tc,zj,gj,hy,gh,pId,status1,flag,projectunit) values('" + w.lq + "','" + w.cf + "','" + w.zl + "','" + w.dm + "','" + w.sm + "','" + w.bm + "','" + w.tc + "','" + w.zj + "','" + w.gj + "','" + w.hy + "','" + w.gh + "','" + w.dangId + "','" + w.status + "','" + w.flag + "','" + w.projectUnit + "') ";

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
        public bool update101601(string a, string b,string c)
        {
            string s = "UPDATE nprocessing2 set problem = '"+c+"' WHERE getId = '" + a + "' and bh = '" + b + "' ";

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
        public bool update1028(string a, string b, string c)
        {
            string s = "UPDATE nprocessing2 set page = '" + c + "' WHERE getId = '" + a + "' and bh = '" + b + "' ";

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
        public bool Insert1107(string a ,int b,string c)
        {
            string s = " insert into photourl(dangId,flag,url) values('"+a+"','"+b+"','"+c+"')";

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
