using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class AttendanceBAL
    {
        public DataTable Select(int a, DateTime b)
        {
            return new AttendanceDAL().Select(a, b);
        }
        public bool Insert(int a, string b, DateTime c, DateTime d)
        {
            return new AttendanceDAL().insert(a, b, c, d);
        }
        public bool Insert2(int a, string b, DateTime c, DateTime d)
        {
            return new AttendanceDAL().insert2(a, b, c, d);
        }
        public bool Insert3(int a, string b, DateTime c, DateTime d)
        {
            return new AttendanceDAL().insert3(a, b, c, d);
        }
        public bool Insert4(int a, string b, DateTime c, DateTime d)
        {
            return new AttendanceDAL().insert4(a, b, c, d);
        }
        public bool Update(string a, DateTime b, int c, DateTime d)
        {
            return new AttendanceDAL().update(a, b, c, d);
        }
        public DataTable Select2(DateTime a, DateTime b)
        {
            return new AttendanceDAL().Select2(a, b);
        }
        public DataTable Select3(int a, DateTime b, string c)
        {
            return new AttendanceDAL().Select3(a, b, c);
        }
        public DataTable Select4(int a, DateTime b, string c)
        {
            return new AttendanceDAL().Select4(a, b, c);
        }
        public DataTable Select5(int a, DateTime b, string c)
        {
            return new AttendanceDAL().Select5(a, b, c);
        }
        public DataTable Select6(int a, DateTime b, string c)
        {
            return new AttendanceDAL().Select6(a, b, c);
        }

        public DataTable Select7()
        {
            return new AttendanceDAL().Select7();
        }
        public bool Insert5(DateTime b, DateTime c, DateTime d, DateTime e)
        {
            return new AttendanceDAL().insert5(b, c, d, e);
        }
        public DataTable Select8(DateTime a)
        {
            return new AttendanceDAL().Select8(a);
        }
        public bool Update3(string a, int b, int c)
        {
            return new AttendanceDAL().update3(a, b, c);
        }
        public bool Insert6(int a, int b, int c, int d)
        {
            return new AttendanceDAL().insert6(a, b, c, d);
        }
        public DataTable Select9()
        {
            return new AttendanceDAL().Select9();
        }
        public bool Update4(int a, int b, string c, int d, DateTime e)
        {
            return new AttendanceDAL().update4(a, b, c, d, e);
        }
        public DataTable Select10(DateTime a, DateTime b)
        {
            return new AttendanceDAL().Select10(a, b);
        }
        public DataTable Select11(DateTime a, DateTime b, string c)
        {
            return new AttendanceDAL().Select11(a, b, c);
        }
        public bool Update5(string a, string b, int c, DateTime d)
        {
            return new AttendanceDAL().update5(a, b, c, d);
        }
        public bool Delete(int a, DateTime b)
        {
            return new AttendanceDAL().delete(a, b);

        }
    }
}
