using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AttendanceDAL
    {
        public DataTable Select(int a, DateTime b)
        {
            string s = "select * from attendance where useId='" + a + "'and date='" + b + "'";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        #region
        //四次打卡插入
        public bool insert(int a, string b, DateTime c, DateTime d)
        {
            string s = "insert into attendance(useId,username,date,morningwork) values('" + a + "','" + b + "','" + c + "','" + d + "')";

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
        public bool insert2(int a, string b, DateTime c, DateTime d)
        {
            string s = "insert into attendance(useId,username,date,morningend) values('" + a + "','" + b + "','" + c + "','" + d + "')";

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
        public bool insert3(int a, string b, DateTime c, DateTime d)
        {
            string s = "insert into attendance(useId,username,date,afternoonwork) values('" + a + "','" + b + "','" + c + "','" + d + "')";

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
        public bool insert4(int a, string b, DateTime c, DateTime d)
        {
            string s = "insert into attendance(useId,username,date,afternoonend)values('" + a + "','" + b + "','" + c + "','" + d + "')";

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
        #endregion
        //若已经存在一次打卡，其余的打卡就直接更新进去
        public bool update(string a, DateTime b, int c, DateTime d)
        {
            string s = "update attendance set " + a + " ='" + b + "' where useId = '" + c + "' and date='" + d + "'";

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
        public DataTable Select2(DateTime a, DateTime b)
        {
            string s = "select * from attendance where date between'" + a + "'and '" + b + "'";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        #region
        //下面四条判断是否已经打卡
        public DataTable Select3(int a, DateTime b, string c)
        {
            string s = "select * from attendance where useId='" + a + "'and date='" + b + "'and morningwork BETWEEN '" + c + " 05:00:00' and '" + c + " 12:00:00'";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable Select4(int a, DateTime b, string c)
        {
            string s = "select * from attendance where useId='" + a + "'and date='" + b + "'and afternoonwork BETWEEN '" + c + " 13:00:00' and '" + c + " 23:00:00'";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable Select5(int a, DateTime b, string c)
        {
            string s = "select * from attendance where useId='" + a + "'and date='" + b + "'and morningend BETWEEN '" + c + " 05:00:00' and '" + c + " 12:00:00'";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable Select6(int a, DateTime b, string c)
        {
            string s = "select * from attendance where useId='" + a + "'and date='" + b + "'and afternoonend BETWEEN '" + c + " 13:00:00' and '" + c + " 23:00:00'";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        #endregion
        #region
        //对应打卡时间进行设置
        public DataTable Select7()
        {
            string s = "select  smw,sme,saw,sae  from aspunch WHERE id = (select  max(id) from aspunch)";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public bool insert5(DateTime b, DateTime c, DateTime d, DateTime e)
        {
            string s = "insert into aspunch(smw, sme,saw,sae) values('" + b + "','" + c + "','" + d + "','" + e + "')";

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
        #endregion
        #region
        //查出当前打卡用户的id
        public DataTable Select8(DateTime a)
        {
            string s = "select * from attendance where date='" + a + "'";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        //更新档次
        public bool update3(string a, int b, int c)
        {
            string s = "UPDATE attendance set dc ='" + a + "' where id ='" + b + "' and useId = '" + c + "'";

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
        #endregion
        #region
        //设置罚款进行罚款处理
        public bool insert6(int a, int b, int c, int d)
        {
            string s = "insert into apmoney(p1,p2,p3,cb)values('" + a + "','" + b + "','" + c + "','" + d + "')";

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
        public DataTable Select9()
        {
            string s = "select  p1,p2,p3,cb  from apmoney WHERE id = (select  max(id) from apmoney)";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public bool update4(int a, int b, string c, int d, DateTime e)
        {
            string s = "UPDATE attendance set mealsupport = '" + a + "',punish='" + b + "',allwork='" + c + "'WHERE useId='" + d + "' and date='" + e + "'";

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
        #endregion
        #region 
        //查询
        public DataTable Select10(DateTime a, DateTime b)
        {
            string s = "select useId ,username ,date  ,morningwork ,morningend ,afternoonwork ,afternoonend ,mealsupport ,punish ,allwork  from attendance where date >= '" + a + "' and date <= '" + b + "'";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        public DataTable Select11(DateTime a, DateTime b, string c)
        {
            string s = "select useId ,username ,date ,morningwork ,morningend ,afternoonwork ,afternoonend ,mealsupport ,punish ,allwork  from attendance where date >= '" + a + "' and date <= '" + b + "'and username like'%" + c + "%'";
            DataTable dt = DBhelper.GetTableBySql(s);
            return dt;
        }
        #endregion
        public bool update5(string a, string b, int c, DateTime d)
        {
            string s7 = "update attendance set " + a + "='" + b + "'where useId = '" + c + "'and date='" + d + "'";
            int rows = DBhelper.ExecuteNonQuery(s7);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool delete(int a, DateTime b)
        {
            string s2 = "delete from attendance where useId='" + a + "' and date='" + b + "'";
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
    }
}
