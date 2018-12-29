using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserDAL
    {
        public bool update(string a, string b, string c, string d)
        {
            string s7 = "UPDATE user set "+ a +" ='"+ b +"'where useId='"+ c +"'and username='"+ d +"'";
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
        public bool update2(string a, DateTime b, string c, string d)
        {
            string s7 = "UPDATE user set " + a + " ='" + b + "'where useId='" + c + "'and username='" + d + "'";
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
        public bool insert(int a, string b, DateTime c, string d, string e, string f, DateTime g, string h, string i, DateTime j, string k, string l, string m, string n)
        {
            string s = "insert into user(useId,username,brithday,sex,Origin,marriage,employdate,historyrole,nowrole,workdate,telephone,mail,wangdian,card) values('" + a + "','" + b + "','" + c + "','" + d + "','" + e + "','" + f + "','" + g + "','" + h + "','" + i + "','" + j + "','" + k + "','" + l + "','" + m + "','" + n + "')";

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
