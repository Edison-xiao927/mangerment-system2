using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class Users
    {
        public string UseId { get; set; }               //用户编号          
        public string Username { get; set; }                //用户姓名
        public string Password { get; set; }              //密码        	
        public string Sex { get; set; }                //性别        	
        public DateTime Brithday { get; set; }          //出生年月        	
        public string Origin { get; set; }              //籍贯    	
        public string Marriage { get; set; }             //婚育
        public string Historyrole { get; set; }              //历史角色
        public string Nowrole { get; set; }              //现在岗位
        public DateTime Workdate { get; set; }                //上岗时间
        public DateTime Employdate { get; set; }                //聘用时间    
        public string Workflowdefine { get; set; }               //档案信息监管
        public string Usermanage { get; set; }             //用户管理
        public string Attendancemanage { get; set; }    //考勤管理
        public string Filemanage { get; set; }         //档案管理
        public string Monitoranalysis { get; set; }        //监控分析
        public string Limitmanage { get; set; }  //权限管理
    }
}
