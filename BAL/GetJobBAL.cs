using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BAL
{
    public class GetJobBAL
    {
        //领取员获取工作任务
        public DataSet Select()
        {
            return new GetJobDAL().Select();
        }
        public DataSet Select2()
        {
            return new GetJobDAL().Select2();
        }
        public DataSet Select3()
        {
            return new GetJobDAL().Select3();
        }
        public DataSet Select4()
        {
            return new GetJobDAL().Select4();
        }
        public DataSet Select5()
        {
            return new GetJobDAL().Select5();
        }
        public DataSet Select6()
        {
            return new GetJobDAL().Select6();
        }
        public DataSet Select7()
        {
            return new GetJobDAL().Select7();
        }
        public DataSet Select8()
        {
            return new GetJobDAL().Select8();
        }
        public DataSet Select9()
        {
            return new GetJobDAL().Select9();
        }
        public DataSet Select10()
        {
            return new GetJobDAL().Select10();
        }
        public DataSet Select1015(string a)
        {
            return new GetJobDAL().Select1015(a);
        }
        public DataSet Select1225()
        {
            return new GetJobDAL().Select1225();
        }
        public DataSet Select122501(string a)
        {
            return new GetJobDAL().Select122501(a);
        }
    }
}
