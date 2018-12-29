using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
using System.Reflection;

namespace UI
{
    public partial class Form主面 : Form
    {
        private string _userName;
        public string UserName
        {

            get { return _userName; }
            set { _userName = value; }
        }

        private int _uId;
        public int UId
        {
            get { return _uId; }
            set { _uId = value; }
        }
        public Form主面(string userName)
        {
            InitializeComponent();
            UserName = userName;
            UId = new AABAL().selcet(UserName);
            tsslUser.Text = "当前登陆用户：" + UserName;
        }

        private void Form主面_Load(object sender, EventArgs e)
        {
            LoadFirstMenuItem();
        }
        private void LoadFirstMenuItem()
        {

            DataTable dt = new AABAL().Selectinfo(UId);
            foreach (DataRow dr in dt.Rows)
            {
                ToolStripMenuItem item = new ToolStripMenuItem();
                item.Text = dr[2].ToString();
                item.Name = dr[0].ToString();
                item.Tag = dr[5];
                item.Click += new EventHandler(subItem_Click);
                LoadSubMenuItem(item);
                menuStrip1.Items.Add(item);
            }
        }

        private void LoadSubMenuItem(ToolStripMenuItem item)
        {
            int resourceId = Convert.ToInt32(item.Name);

            //根据父菜单项Id加载子菜单
            DataTable dt = new AABAL().Selectinfo2(resourceId, UId);
            foreach (DataRow dr in dt.Rows)
            {
                ToolStripMenuItem subItem = new ToolStripMenuItem();
                subItem.Tag = dr[5];
                subItem.Name = dr[0].ToString();
                subItem.Text = dr[2].ToString();

                subItem.Click += new EventHandler(subItem_Click);

                LoadSubMenuItem(subItem);

                item.DropDownItems.Add(subItem);
            }
        }

        void subItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            if (item.Tag != System.DBNull.Value)
            {
                string loadForm = item.Tag.ToString();
                object[] parameters = new object[1];
                parameters[0] = item.ToString()+"-"+ UserName;
   //             parameters[1] = this.UserName;
                Form f = (Form)Assembly.Load("UI").CreateInstance("UI." + loadForm, true, System.Reflection.BindingFlags.Default, null, parameters, null, null);
                this.IsMdiContainer = true;
                f.MdiParent = this;
                f.StartPosition = FormStartPosition.CenterScreen;
                f.Show();
            }
            //菜单项里面的“退出”操作
            if (item.Text == "【退出】")
            {
                this.Close();
            }
        }
        int sum = 0;
        int ih1 = 0;//上午上班打卡小时差
        int ih2 = 0;//上午下班打卡小时差
        int ih3 = 0;//下午上班打卡小时差
        int ih4 = 0;//下午下班打卡小时差
        int im1 = 0;//上午上班打卡分钟差
        int im2 = 0;//上午下班打卡分钟差
        int im3 = 0;//下午上班打卡分钟差
        int im4 = 0;//下午下班打卡分钟差

        private void 上班打卡ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.DateTime currentTime = System.DateTime.Now;
            DataTable dtt = new AttendanceBAL().Select7();
            int hour = currentTime.Hour;//取当前时
            int minute = currentTime.Minute;
            string strYMD = currentTime.ToString("d");//取当前年月日，格式为：2003-9-23 
            DateTime date = DateTime.Parse(strYMD);
            int month = currentTime.Month;
            if (hour >= 0 && hour <= 12)
            {
                DataTable d = new AttendanceBAL().Select3(UId, date, strYMD);
                if (d.Rows.Count == 0)
                {
                    bool flag = new AttendanceBAL().Insert(UId, UserName, date, currentTime);
                    if (flag == true)
                    {
                        MessageBox.Show("打卡成功！");
                    }
                }
                else
                {
                    MessageBox.Show("已打卡！");
                }


                DateTime t1 = DateTime.Parse(dtt.Rows[0][0].ToString());
                // DateTime t2 = DateTime.Parse(dt.Rows[0][2].ToString());
                // DateTime t3 = DateTime.Parse(dt.Rows[0][3].ToString());
                //  DateTime t4 = DateTime.Parse(dt.Rows[0][4].ToString());
                int h1 = t1.Hour;//取应打卡的时
                int m1 = t1.Minute;//取应打卡分

                ih1 = hour - h1;
                if (ih1 < 0)
                {
                    ih1 = 0;
                    im1 = 0;
                }
                else
                {
                    im1 = minute - m1;
                    if (im1 < 0)
                    {
                        im1 = 60 + im1;
                        ih1--;
                    }
                }



            }
            else
            {
                DataTable d = new AttendanceBAL().Select4(UId, date, strYMD);
                if (d.Rows.Count == 0)
                {
                    DataTable dt = new AttendanceBAL().Select(UId, date);
                    if (dt.Rows.Count == 0)
                    {
                        bool flag = new AttendanceBAL().Insert3(UId, UserName, date, currentTime);
                        if (flag == true)
                        {
                            MessageBox.Show("打卡成功！");
                        }
                    }
                    else
                    {
                        bool flag = new AttendanceBAL().Update("afternoonwork", currentTime, UId, date);
                        if (flag == true)
                        {
                            MessageBox.Show("打卡成功！");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("已打卡！");
                }

                DateTime t3 = DateTime.Parse(dtt.Rows[0][2].ToString());
                int h3 = t3.Hour;//取应打卡的时
                int m3 = t3.Minute;

                ih3 = hour - h3;
                if (ih3 < 0)
                {
                    ih3 = 0;
                    im3 = 0;
                }
                else
                {
                    im3 = minute - m3;
                    if (im3 < 0)
                    {
                        im3 = 60 + im3;
                        ih3--;
                    }
                }
            }
        }

        private void 下班打卡ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.DateTime currentTime = System.DateTime.Now;
            int hour = currentTime.Hour;//取当前时
            int minute = currentTime.Minute;
            int month = currentTime.Month;
            string strYMD = currentTime.ToString("d");//取当前年月日，格式为：2003-9-23 
            DateTime date = DateTime.Parse(strYMD);
            DataTable dtt = new AttendanceBAL().Select7();
            // DateTime date = DateTime.ParseExact(strYMD, "yyyy/MM/dd", CultureInfo.InvariantCulture);
            // string strT = currentTime.ToString("t");//取当前时分，格式为：14：24 
            if (hour >= 0 && hour <= 12)
            {
                DataTable d = new AttendanceBAL().Select5(UId, date, strYMD);
                if (d.Rows.Count == 0)
                {
                    DataTable dt = new AttendanceBAL().Select(UId, date);
                    if (dt.Rows.Count == 0)
                    {
                        bool flag = new AttendanceBAL().Insert2(UId, UserName, date, currentTime);
                        if (flag == true)
                        {
                            MessageBox.Show("打卡成功！");

                        }

                    }
                    else
                    {
                        bool flag = new AttendanceBAL().Update("morningend", currentTime, UId, date);
                        if (flag == true)
                        {

                            MessageBox.Show("打卡成功！");

                        }
                    }
                }
                else
                {
                    MessageBox.Show("已打卡！");
                }

                DateTime t2 = DateTime.Parse(dtt.Rows[0][1].ToString());
                int h2 = t2.Hour;//取应打卡的时
                int m2 = t2.Minute;

                ih2 = h2 - hour;
                if (ih2 < 0)
                {
                    ih2 = 0;
                    im2 = 0;
                }
                else
                {
                    im2 = m2 - minute;
                    if (im2 < 0)
                    {
                        im2 = 60 + im2;
                        ih2--;
                    }
                }
            }
            else
            {
                DataTable d = new AttendanceBAL().Select6(UId, date, strYMD);

                if (d.Rows.Count == 0)
                {
                    DataTable dt = new AttendanceBAL().Select(UId, date);
                    if (dt.Rows.Count == 0)
                    {
                        bool flag = new AttendanceBAL().Insert4(UId, UserName, date, currentTime);
                        if (flag == true)
                        {
                            MessageBox.Show("打卡成功！");
                        }
                    }
                    else
                    {
                        bool flag = new AttendanceBAL().Update("afternoonend", currentTime, UId, date);
                        if (flag == true)
                        {
                            MessageBox.Show("打卡成功！");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("已打卡！");
                }

                DateTime t4 = DateTime.Parse(dtt.Rows[0][3].ToString());
                int h4 = t4.Hour;//取应打卡的时
                int m4 = t4.Minute;

                ih4 = h4 - hour;
                if (ih4 < 0)
                {
                    ih4 = 0;
                    im4 = 0;
                }
                else
                {
                    im4 = m4 - minute;
                    if (im4 < 0)
                    {
                        im4 = 60 + im4;
                        ih4--;
                    }
                }

                DataTable dt2 = new AttendanceBAL().Select8(date);//查当前的记录
                int id = Convert.ToInt32(dt2.Rows[0][0].ToString());
                string dc = "";
                string allwork = "";
                DataTable dt11 = new AttendanceBAL().Select9();//查最新的扣罚金额设置记录
                int p1 = Convert.ToInt32(dt11.Rows[0][0].ToString());
                int p2 = Convert.ToInt32(dt11.Rows[0][1].ToString());
                int p3 = Convert.ToInt32(dt11.Rows[0][2].ToString());
                int cb = Convert.ToInt32(dt11.Rows[0][3].ToString());
                int punish = 0;
                if (dt2.Rows[0][3].ToString() != "" && dt2.Rows[0][4].ToString() != "" && dt2.Rows[0][5].ToString() != "" && dt2.Rows[0][6].ToString() != "")
                {
                    allwork = "否";
                    int zh = ih1 + ih2 + ih3 + ih4;//相差的总时
                    int zm = im1 + im2 + im3 + im4;//相差的总分
                    sum = zh * 60 + zm;//全分
                    if (sum > 0 && sum <= 10)
                    {
                        dc = "1";
                        bool flag = new AttendanceBAL().Update3(dc, id, UId);
                        punish = p1;
                        bool flg = new AttendanceBAL().Update4(cb, punish, allwork, UId, date);
                    }
                    else if (sum > 10 && sum <= 20)
                    {
                        dc = "2";
                        bool flag = new AttendanceBAL().Update3(dc, id, UId);
                        punish = p1 * 2;
                        bool flg = new AttendanceBAL().Update4(cb, punish, allwork, UId, date);
                    }
                    else if (sum > 20 && sum <= 30)
                    {
                        dc = "3";
                        bool flag = new AttendanceBAL().Update3(dc, id, UId);
                        punish = p1 * 3;
                        bool flg = new AttendanceBAL().Update4(cb, punish, allwork, UId, date);
                    }
                    else if (sum > 30 && sum <= 40)
                    {
                        dc = "4";
                        bool flag = new AttendanceBAL().Update3(dc, id, UId);
                        punish = p1 * 4;
                        bool flg = new AttendanceBAL().Update4(cb, punish, allwork, UId, date);
                    }
                    else if (sum > 40 && sum <= 50)
                    {
                        dc = "5";
                        bool flag = new AttendanceBAL().Update3(dc, id, UId);
                        punish = p1 * 5;
                        bool flg = new AttendanceBAL().Update4(cb, punish, allwork, UId, date);
                    }
                    else if (sum > 50 && sum <= 60)
                    {
                        dc = "6";
                        bool flag = new AttendanceBAL().Update3(dc, id, UId);
                        punish = p1 * 6;
                        bool flg = new AttendanceBAL().Update4(cb, punish, allwork, UId, date);
                    }
                    else if (sum > 60 && sum <= 90)
                    {
                        dc = "7";
                        bool flag = new AttendanceBAL().Update3(dc, id, UId);
                        punish = p1 * 6 + p2;
                        bool flg = new AttendanceBAL().Update4(cb, punish, allwork, UId, date);
                    }
                    else if (sum > 90 && sum <= 120)
                    {
                        dc = "8";
                        bool flag = new AttendanceBAL().Update3(dc, id, UId);
                        punish = p1 * 6 + p2 * 2;
                        bool flg = new AttendanceBAL().Update4(cb, punish, allwork, UId, date);
                    }
                    else if (sum > 120 && sum <= 150)
                    {
                        dc = "9";
                        bool flag = new AttendanceBAL().Update3(dc, id, UId);
                        punish = p1 * 6 + p2 * 3;
                        bool flg = new AttendanceBAL().Update4(cb, punish, allwork, UId, date);
                    }
                    else if (sum > 150 && sum <= 180)
                    {
                        dc = "10";
                        bool flag = new AttendanceBAL().Update3(dc, id, UId);
                        punish = p1 * 6 + p2 * 4;
                        bool flg = new AttendanceBAL().Update4(cb, punish, allwork, UId, date);
                    }
                    else if (sum > 180)
                    {
                        dc = "11";
                        bool flag = new AttendanceBAL().Update3(dc, id, UId);
                        punish = p3;
                        bool flg = new AttendanceBAL().Update4(cb, punish, allwork, UId, date);
                    }
                    else
                    {
                        dc = "0";
                        bool flag = new AttendanceBAL().Update3(dc, id, UId);
                        punish = 0;
                        bool flg = new AttendanceBAL().Update4(cb, punish, allwork, UId, date);
                    }
                }
                else
                {
                    dc = "11";
                    bool flag = new AttendanceBAL().Update3(dc, id, UId);
                    allwork = "是";
                    punish = p3;
                    bool flg = new AttendanceBAL().Update4(cb, punish, allwork, UId, date);
                }
            }
        }
    }
}
