using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class MyWorkBAL
    {
        public DataSet Select(string a)
        {
            return new MyWorkDAL().Select(a);
        }
        public DataSet Select1006()
        {
            return new MyWorkDAL().Select1006();
        }
        public DataSet Select10061()
        {
            return new MyWorkDAL().Select10061();
        }
        //拆分员获取工作任务
        public DataSet Select2()
        {
            return new MyWorkDAL().Select2();
        }
        //扫描员获取工作任务
        public DataSet Select3(string a)
        {
            return new MyWorkDAL().Select3(a);
        }
        //打码员员获取工作任务
        public DataSet Select4()
        {
            return new MyWorkDAL().Select4();
        }
        //挂接员获取工作任务
        public DataSet Select5()
        {
            return new MyWorkDAL().Select5();
        }
        //扫描员获取工作任务
        public DataSet Select6()
        {
            return new MyWorkDAL().Select6();
        }
        //编目员获取工作任务
        public DataSet Select7()
        {
            return new MyWorkDAL().Select7();
        }
        //图处员获取工作任务
        public DataSet Select8()
        {
            return new MyWorkDAL().Select8();
        }
        //质检员获取工作任务
        public DataSet Select9()
        {
            return new MyWorkDAL().Select9();
        }
        //挂接员获取工作任务
        //归还员获取工作任务
        public DataSet Select11()
        {
            return new MyWorkDAL().Select11();
        }

        public DataTable Selectinfo(string str)
        {
            return new MyWorkDAL().Selectinfo(str);
        }
        public bool update(string a)
        {
            return new MyWorkDAL().update(a);
        }
        public DataSet Select1102(string a)
        {
            return new MyWorkDAL().Select1102(a);
        }
        public DataSet Select110201(string a)
        {
            return new MyWorkDAL().Select110201(a);
        }
        public DataSet Select112001(string a)
        {
            return new MyWorkDAL().Select112001(a);
        }
        public DataSet Select112002(string a)
        {
            return new MyWorkDAL().Select112002(a);
        }
        public DataSet Select112003(string a)
        {
            return new MyWorkDAL().Select112003(a);
        }
        public DataSet Select112004(string a)
        {
            return new MyWorkDAL().Select112004(a);
        }
    }
}
