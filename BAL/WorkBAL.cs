using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using MODEL;
using System.Data;
using MySql.Data.MySqlClient;

namespace BAL
{
   public class WorkBAL
    {
        public DataSet Select(string a, string b)
        {
            return new WorkDAL().Select(a, b);
        }
        public DataSet Select2(string a, string b)
        {
            return new WorkDAL().Select2(a, b);
        }
        public DataSet Select3(string a, string b)
        {
            return new WorkDAL().Select3(a, b);
        }
        //添加修改工作流
        public bool Insert(workstatus w)
        {
            return new WorkDAL().Insert(w);
        }
        //档案领取交接单
        public bool Insert2(getfile g)
        {
            return new WorkDAL().Insert2(g);
        }
        //档案问题单
        public bool Insert3(getfile g)
        {
            return new WorkDAL().Insert3(g);
        }
        //修改档案状态
        public bool update(string a)
        {
            return new WorkDAL().update(a);
        }
        //获取需要生成加工流转单的档案信息
        public MySqlDataReader Selectinfo2(string str)
        {
            return new WorkDAL().Selectinfo2(str);
        }
        public MySqlDataReader Selectinfo3(string str)
        {
            return new WorkDAL().Selectinfo3(str);
        }
        //生成拆分加工流转单内容
        public bool Insert4(processfile p)
        {
            return new WorkDAL().Insert4(p);
        }
        public bool update2(string a, string b)
        {
            return new WorkDAL().update2(a, b);
        }
        //执行退回操作改变档案状态
        public bool update3(string a, string b)
        {
            return new WorkDAL().update3(a, b);
        }
        //生成著录加工流转单内容
        public bool Insert5(processfile p)
        {
            return new WorkDAL().Insert5(p);
        }
        //档案拆分问题单
        public bool Insert6(getfile g)
        {
            return new WorkDAL().Insert6(g);
        }
        //档案著录问题单
        public bool Insert7(getfile g)
        {
            return new WorkDAL().Insert7(g);
        }
        //生成打码加工流转单内容
        public bool Insert8(processfile p)
        {
            return new WorkDAL().Insert8(p);
        }
        //档案打码问题单
        public bool Insert9(getfile g)
        {
            return new WorkDAL().Insert9(g);
        }
        //生成还原加工流转单内容
        public bool Insert10(processfile p)
        {
            return new WorkDAL().Insert10(p);
        }
        //档案还原问题单
        public bool Insert11(getfile g)
        {
            return new WorkDAL().Insert11(g);
        }
        //生成扫描加工流转单内容
        public bool Insert12(processfile p)
        {
            return new WorkDAL().Insert12(p);
        }
        //档案扫描问题单
        public bool Insert13(getfile g)
        {
            return new WorkDAL().Insert13(g);
        }
        //生成编目加工流转单内容
        public bool Insert14(processfile p)
        {
            return new WorkDAL().Insert14(p);
        }
        //档案编目问题单
        public bool Insert15(getfile g)
        {
            return new WorkDAL().Insert15(g);
        }
        //生成图处加工流转单内容
        public bool Insert16(processfile p)
        {
            return new WorkDAL().Insert16(p);
        }
        //档案图处问题单
        public bool Insert17(getfile g)
        {
            return new WorkDAL().Insert17(g);
        }
        //生成质检加工流转单内容
        public bool Insert18(processfile p)
        {
            return new WorkDAL().Insert18(p);
        }
        //生成挂接加工流转单内容
        public bool Insert19(processfile p)
        {
            return new WorkDAL().Insert19(p);
        }
        //生成归还加工流转单内容
        public bool Insert20(processfile p)
        {
            return new WorkDAL().Insert20(p);
        }
        //档案质检问题单
        public bool Insert21(getfile g)
        {
            return new WorkDAL().Insert21(g);
        }
        //档案挂接问题单
        public bool Insert22(getfile g)
        {
            return new WorkDAL().Insert22(g);
        }
        //档案归还问题单
        public bool Insert23(getfile g)
        {
            return new WorkDAL().Insert23(g);
        }
        //提交归还单
        public bool Insert24(getfile g)
        {
            return new WorkDAL().Insert24(g);
        }
        //更改加工流转单状态
        //修改档案状态
        public bool update4(processfile p)
        {
            return new WorkDAL().update4(p);
        }
        public MySqlDataReader Selectinfo3(string str, string b)
        {
            return new WorkDAL().Selectinfo3(str, b);
        }
        public MySqlDataReader Selectinfo4(string str)
        {
            return new WorkDAL().Selectinfo4(str);
        }
        public bool Insert111(getfile g, int p)
        {
            return new WorkDAL().Insert111(g, p);
        }
        public MySqlDataReader Selectinfo111(string str)
        {
            return new WorkDAL().Selectinfo111(str);
        }
        public MySqlDataReader Selectinfo222(string str)
        {
            return new WorkDAL().Selectinfo222(str);
        }
        public bool Insert222(processfile g)
        {
            return new WorkDAL().Insert222(g);
        }
        public bool Insert123(getfile g)
        {
            return new WorkDAL().Insert123(g);
        }
        public MySqlDataReader Selectinfo123(string str)
        {
            return new WorkDAL().Selectinfo123(str);
        }
        public bool Insert456(workstatus g)
        {
            return new WorkDAL().Insert456(g);
        }
        public bool update13(string a, string b)
        {
            return new WorkDAL().update13(a, b);
        }
        public bool update14(string a, string b)
        {
            return new WorkDAL().update14(a, b);
        }
        public bool update15(string a, string b)
        {
            return new WorkDAL().update15(a, b);
        }
        public bool update16(string a, string b)
        {
            return new WorkDAL().update16(a, b);
        }
        public bool update17(string a, string b)
        {
            return new WorkDAL().update17(a, b);
        }
        public bool update18(string a, string b)
        {
            return new WorkDAL().update18(a, b);
        }
        public bool update19(string a, string b)
        {
            return new WorkDAL().update19(a, b);
        }
        public bool update20(string a, string b)
        {
            return new WorkDAL().update20(a, b);
        }
        public bool update22(string a, string b)
        {
            return new WorkDAL().update22(a, b);
        }
        public bool update24(string a, string b)
        {
            return new WorkDAL().update24(a, b);
        }
        public bool update25(string a, string b)
        {
            return new WorkDAL().update25(a, b);
        }
        public bool update26(string a, string b)
        {
            return new WorkDAL().update26(a, b);
        }
        public bool update27(string a, string b)
        {
            return new WorkDAL().update27(a, b);
        }
        public bool update28(string a, string b)
        {
            return new WorkDAL().update28(a, b);
        }
        public bool update29(string a, string b)
        {
            return new WorkDAL().update29(a, b);
        }
        public bool update30(string a, string b)
        {
            return new WorkDAL().update30(a, b);
        }
        public bool update101601(string a, string b,string c)
        {
            return new WorkDAL().update101601(a, b,c);
        }
        public bool update1028(string a, string b, string c)
        {
            return new WorkDAL().update1028(a, b, c);
        }
        public bool Insert1107(string a,int b,string c)
        {
            return new WorkDAL().Insert1107(a,b,c);
        }
        public bool update1225(string a, string b)
        {
            return new WorkDAL().update1225(a, b);
        }
        public bool update1225001(string a, string b)
        {
            return new WorkDAL().update1225001(a, b);
        }
    }

}
