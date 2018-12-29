using BAL;
using MODEL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Form项目信息定义 : Form
    {
        public Form项目信息定义()
        {
            InitializeComponent();
        }
        public Form项目信息定义(string str1) : this()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || comboBox5.Text == "" || textBox4.Text == "" || textBox8.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("输入信息不完全");
            }
            else
            {
                if (checkBox1.Checked == true && checkBox11.Checked == true)
                {
                    string url = textBox3.Text.Trim();
                    url = url.Replace("\\", "\\\\");
                    string hz = comboBox7.Text.Trim();
                    project p = new project();
                    p.pId = textBox8.Text.Trim();
                    p.projectunit = textBox1.Text.Trim();
                    p.filetype = textBox2.Text.Trim();
                    p.gdmethod = comboBox5.Text.Trim();
                    p.year = textBox4.Text.Trim();

                    p.str1 = comboBox1.Text.Trim();
                    p.str2 = comboBox2.Text.Trim();
                    p.str3 = comboBox3.Text.Trim();
                    p.str4 = comboBox4.Text.Trim();
                    p.str5 = comboBox5.Text.Trim();
                    p.pgz = comboBox8.Text.Trim();
                    p.pdf = comboBox11.Text.Trim();
                    p.pdfgz = comboBox9.Text.Trim();
                    p.ocr = comboBox10.Text.Trim();
                    p.url = url;
                    p.hz = hz;
                    bool flag = new projectBAL().Insert456(p);
                    /*     if (checkBox12.Checked == true)
                         {
                             string b = "2";
                             bool flag7 = new projectBAL().Insert4444(p.pId, b);
                         }*/
                    if (cb_xmh.Checked == true)
                    {
                        string b = "1";
                        bool flag7 = new projectBAL().Insert4444(p.pId, b);
                    }
                    if (cb_xmtm.Checked == true)
                    {
                        string b = "3";
                        bool flag7 = new projectBAL().Insert4444(p.pId, b);
                    }
                    if (cb_xmys.Checked == true)
                    {
                        string b = "2";
                        bool flag7 = new projectBAL().Insert4444(p.pId, b);
                    }
                    /*   if (checkBox19.Checked == true)
                       {
                           string b = "8";
                           bool flag7 = new projectBAL().Insert4444(p.pId, b);
                       }*/
                    if (cb_ajh.Checked == true)
                    {
                        string b = "11";
                        bool flag7 = new projectBAL().Insert4444(p.pId, b);
                    }
                    if (cb_ajtm.Checked == true)
                    {
                        string b = "12";
                        bool flag7 = new projectBAL().Insert4444(p.pId, b);
                    }
                    if (cb_ajys.Checked == true)
                    {
                        string b = "13";
                        bool flag7 = new projectBAL().Insert4444(p.pId, b);
                    }
                    if (cb_ajzrr.Checked == true)
                    {
                        string b = "18";
                        bool flag7 = new projectBAL().Insert4444(p.pId, b);
                    }
                    if (cb_wjdh.Checked == true)
                    {
                        string b = "19";
                        bool flag7 = new projectBAL().Insert4444(p.pId, b);
                    }
                    if (cb_wjjh.Checked == true)
                    {
                        string b = "20";
                        bool flag7 = new projectBAL().Insert4444(p.pId, b);
                    }
                    if (cb_wjtm.Checked == true)
                    {
                        string b = "21";
                        bool flag7 = new projectBAL().Insert4444(p.pId, b);
                    }
                    if (cb_wjys.Checked == true)
                    {
                        string b = "22";
                        bool flag7 = new projectBAL().Insert4444(p.pId, b);
                    }
                    if (cb_wjyh.Checked == true)
                    {
                        string b = "23  ";
                        bool flag7 = new projectBAL().Insert4444(p.pId, b);
                    }
                    if (cb_xmkssj.Checked == true)
                    {
                        string b = "4";
                        bool flag7 = new projectBAL().Insert4444(p.pId, b);
                    }
                    if (cb_xmjssj.Checked == true)
                    {
                        string b = "5";
                        bool flag7 = new projectBAL().Insert4444(p.pId, b);
                    }
                    if (cb_xmyzdw.Checked == true)
                    {
                        string b = "6";
                        bool flag7 = new projectBAL().Insert4444(p.pId, b);
                    }
                    if (cb_xmsjdw.Checked == true)
                    {
                        string b = "7";
                        bool flag7 = new projectBAL().Insert4444(p.pId, b);
                    }
                    if (cb_xmsgdw.Checked == true)
                    {
                        string b = "8";
                        bool flag7 = new projectBAL().Insert4444(p.pId, b);
                    }
                    if (cb_xmjldw.Checked == true)
                    {
                        string b = "9";
                        bool flag7 = new projectBAL().Insert4444(p.pId, b);
                    }
                    if (cb_xmflh.Checked == true)
                    {
                        string b = "10";
                        bool flag7 = new projectBAL().Insert4444(p.pId, b);
                    }
                    if (cb_ajqzrq.Checked == true)
                    {
                        string b = "14";
                        bool flag7 = new projectBAL().Insert4444(p.pId, b);
                    }
                    if (cb_ajbgqx.Checked == true)
                    {
                        string b = "15";
                        bool flag7 = new projectBAL().Insert4444(p.pId, b);
                    }
                    if (cb_ajflh.Checked == true)
                    {
                        string b = "16";
                        bool flag7 = new projectBAL().Insert4444(p.pId, b);
                    }
                    if (cb_ajmj.Checked == true)
                    {
                        string b = "17";
                        bool flag7 = new projectBAL().Insert4444(p.pId, b);
                    }
                    if (cb_wjzrr.Checked == true)
                    {
                        string b = "24";
                        bool flag7 = new projectBAL().Insert4444(p.pId, b);
                    }
                    if (cb_wjrq.Checked == true)
                    {
                        string b = "25";
                        bool flag7 = new projectBAL().Insert4444(p.pId, b);
                    }
                    if (cb_wjnd.Checked == true)
                    {
                        string b = "26";
                        bool flag7 = new projectBAL().Insert4444(p.pId, b);
                    }
                    if (cb_wjbgqx.Checked == true)
                    {
                        string b = "27";
                        bool flag7 = new projectBAL().Insert4444(p.pId, b);
                    }
                    if (cb_wjflh.Checked == true)
                    {
                        string b = "28";
                        bool flag7 = new projectBAL().Insert4444(p.pId, b);
                    }
                    if (cb_wjmj.Checked == true)
                    {
                        string b = "29";
                        bool flag7 = new projectBAL().Insert4444(p.pId, b);
                    }

                    //       bool flag11 = new projectBAL().Insert4444(z1,p.pId,p.projectunit);
                    //      bool flag22 = new projectBAL().Insert5555(z2, p.pId, p.projectunit);
                    //     bool flag33 = new projectBAL().Insert6666(z3, p.pId, p.projectunit);
                    int cnt = 0;
                    int cnt1 = 0;
                    workstatus w = new workstatus();
                    w.projectUnit = textBox1.Text.Trim();
                    if (checkBox1.Checked == true)
                    {
                        string a = "1";
                        string b = "领取";
                        bool flag7 = new projectBAL().Insert(p.pId, a, b);
                        DataTable str = new AABAL().Select101(p.pId, 1);
                        DataTable str2 = new AABAL().Select102(p.pId, 1);
                        cnt++;
                        bool flag101 = new projectBAL().Insert101(p.pId, a, b, str.Rows[0][0].ToString(), str2.Rows[0][0].ToString());
                        if (flag101 == true)
                        {
                            cnt1++;
                        }
                    }
                    if (checkBox2.Checked == true)
                    {
                        string a = "2";
                        string b = "打码";
                        bool flag7 = new projectBAL().Insert(p.pId, a, b);
                        DataTable str = new AABAL().Select101(p.pId, 2);
                        DataTable str2 = new AABAL().Select102(p.pId, 2);
                        cnt++;
                        bool flag101 = new projectBAL().Insert101(p.pId, a, b, str.Rows[0][0].ToString(), str2.Rows[0][0].ToString());
                        if (flag101 == true)
                        {
                            cnt1++;
                        }
                    }
                    if (checkBox3.Checked == true)
                    {
                        string a = "3";
                        string b = "拆分";
                        bool flag7 = new projectBAL().Insert(p.pId, a, b);
                        DataTable str = new AABAL().Select101(p.pId, 3);
                        DataTable str2 = new AABAL().Select102(p.pId, 3);
                        cnt++;
                        bool flag101 = new projectBAL().Insert101(p.pId, a, b, str.Rows[0][0].ToString(), str2.Rows[0][0].ToString());
                        if (flag101 == true)
                        {
                            cnt1++;
                        }

                    }
                    if (checkBox4.Checked == true)
                    {
                        string a = "4";
                        string b = "著录";
                        bool flag7 = new projectBAL().Insert(p.pId, a, b);
                        DataTable str = new AABAL().Select101(p.pId, 4);
                        DataTable str2 = new AABAL().Select102(p.pId, 4);
                        cnt++;
                        bool flag101 = new projectBAL().Insert101(p.pId, a, b, str.Rows[0][0].ToString(), str2.Rows[0][0].ToString());
                        if (flag101 == true)
                        {
                            cnt1++;
                        }

                    }
                    if (checkBox13.Checked == true)
                    {
                        string a = "5";
                        string b = "再次著录";
                        bool flag7 = new projectBAL().Insert(p.pId, a, b);
                        DataTable str = new AABAL().Select101(p.pId, 5);
                        DataTable str2 = new AABAL().Select102(p.pId, 5);
                        cnt++;
                        bool flag101 = new projectBAL().Insert101(p.pId, a, b, str.Rows[0][0].ToString(), str2.Rows[0][0].ToString());
                        if (flag101 == true)
                        {
                            cnt1++;
                        }

                    }
                    if (checkBox5.Checked == true)
                    {
                        string a = "6";
                        string b = "扫描";
                        bool flag7 = new projectBAL().Insert(p.pId, a, b);
                        DataTable str = new AABAL().Select101(p.pId, 6);
                        DataTable str2 = new AABAL().Select102(p.pId, 6);
                        cnt++;
                        bool flag101 = new projectBAL().Insert101(p.pId, a, b, str.Rows[0][0].ToString(), str2.Rows[0][0].ToString());
                        if (flag101 == true)
                        {
                            cnt1++;
                        }

                    }
                    /* if (checkBox6.Checked == true)
                     {
                         w.bm = ++cnt;
                     }*/
                    if (checkBox7.Checked == true)
                    {
                        string a = "7";
                        string b = "图处";
                        bool flag7 = new projectBAL().Insert(p.pId, a, b);
                        DataTable str = new AABAL().Select101(p.pId, 7);
                        DataTable str2 = new AABAL().Select102(p.pId, 7);
                        cnt++;
                        bool flag101 = new projectBAL().Insert101(p.pId, a, b, str.Rows[0][0].ToString(), str2.Rows[0][0].ToString());
                        if (flag101 == true)
                        {
                            cnt1++;
                        }
                    }
                    if (checkBox8.Checked == true)
                    {
                        string a = "8";
                        string b = "质检";
                        bool flag7 = new projectBAL().Insert(p.pId, a, b);
                        DataTable str = new AABAL().Select101(p.pId, 8);
                        DataTable str2 = new AABAL().Select102(p.pId, 8);
                        cnt++;
                        bool flag101 = new projectBAL().Insert101(p.pId, a, b, str.Rows[0][0].ToString(), str2.Rows[0][0].ToString());
                        if (flag101 == true)
                        {
                            cnt1++;
                        }
                    }
                    if (checkBox9.Checked == true)
                    {
                        string a = "9";
                        string b = "挂接";
                        bool flag7 = new projectBAL().Insert(p.pId, a, b);
                        DataTable str = new AABAL().Select101(p.pId, 9);
                        DataTable str2 = new AABAL().Select102(p.pId, 9);
                        cnt++;
                        bool flag101 = new projectBAL().Insert101(p.pId, a, b, str.Rows[0][0].ToString(), str2.Rows[0][0].ToString());
                        if (flag101 == true)
                        {
                            cnt1++;
                        }
                    }
                    if (checkBox10.Checked == true)
                    {
                        string a = "10";
                        string b = "还原";
                        bool flag7 = new projectBAL().Insert(p.pId, a, b);
                        DataTable str = new AABAL().Select101(p.pId, 10);
                        DataTable str2 = new AABAL().Select102(p.pId, 10);
                        cnt++;
                        bool flag101 = new projectBAL().Insert101(p.pId, a, b, str.Rows[0][0].ToString(), str2.Rows[0][0].ToString());
                        if (flag101 == true)
                        {
                            cnt1++;
                        }
                    }
                    if (checkBox11.Checked == true)
                    {
                        string a = "11";
                        string b = "归还";
                        bool flag7 = new projectBAL().Insert(p.pId, a, b);
                        DataTable str = new AABAL().Select101(p.pId, 11);
                        DataTable str2 = new AABAL().Select102(p.pId, 11);
                        cnt++;
                        bool flag101 = new projectBAL().Insert101(p.pId, a, b, str.Rows[0][0].ToString(), str2.Rows[0][0].ToString());
                        if (flag101 == true)
                        {
                            cnt1++;
                        }
                        if (cnt == cnt1)
                        {
                            MessageBox.Show("项目规则定义成功！");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("项目规则定义失败！");
                        }
                    }
                    w.flag = cnt;
                }
                else
                {
                    MessageBox.Show("第一个环节必须为领取，最后一个环节必须为归还");
                }
            }
            }
        
      /*      if (textBox1.Text == "" || textBox2.Text == "" || comboBox5.Text == "" || textBox4.Text == ""||textBox8.Text=="")
            {
                MessageBox.Show("输入信息不完全");
            }
            else
            {
                if (checkBox1.Checked == true && checkBox11.Checked == true)
                {
                    if(cnt==cnt1)
                    {
                        MessageBox.Show("添加工作流成功！");
                        this.Close();
                    }else
                    {
                        MessageBox.Show("添加工作流失败！");
                    }

                }
                else
                {
                    MessageBox.Show("第一个环节必须为领取，最后一个环节必须为归还");
                }
            }
        }*/

        private void comboBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comboBox1.Items.Add(comboBox1.Text);
                comboBox1.Text = "";
                comboBox1.DroppedDown = true;
            }
        }

        private void comboBox2_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                comboBox2.Items.Add(comboBox2.Text);
                comboBox2.Text = "";
                comboBox2.DroppedDown = true;
            }
        }

        private void comboBox3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comboBox3.Items.Add(comboBox3.Text);
                comboBox3.Text = "";
                comboBox3.DroppedDown = true;
            }
        }

        private void comboBox4_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comboBox4.Items.Add(comboBox4.Text);
                comboBox4.Text = "";
                comboBox4.DroppedDown = true;
            }
        }

        private void Form项目信息定义_Load(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox6.Checked == true)
            {
                cb_wjdh.Checked = true;
                cb_wjjh.Checked = true;
                cb_wjtm.Checked = true;
                cb_wjys.Checked = true;
                cb_wjbgqx.Checked = true;
                cb_wjyh.Checked = true;
                cb_wjzrr.Checked = true;
                cb_wjrq.Checked = true;
                cb_wjnd.Checked = true;
                cb_wjflh.Checked = true;
                cb_wjmj.Checked = true;
            }else
            {

                cb_wjdh.Checked = false;
                cb_wjjh.Checked = false;
                cb_wjtm.Checked = false;
                cb_wjys.Checked = false;
                cb_wjbgqx.Checked = false;
                cb_wjyh.Checked = false;
                cb_wjzrr.Checked = false;
                cb_wjrq.Checked = false;
                cb_wjnd.Checked = false;
                cb_wjflh.Checked = false;
                cb_wjmj.Checked = false;
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked == true)
            {
                checkBox1.Checked = true;
                checkBox2.Checked = true;
                checkBox3.Checked = true;
                checkBox4.Checked = true;
                checkBox5.Checked = true;
                checkBox7.Checked = true;
                checkBox8.Checked = true;
                checkBox9.Checked = true;
                checkBox10.Checked = true;
                checkBox11.Checked = true;
                checkBox13.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox7.Checked = false;
                checkBox8.Checked = false;
                checkBox9.Checked = false;
                checkBox10.Checked = false;
                checkBox11.Checked = false;
                checkBox13.Checked = false;
            }
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox16.Checked == true)
            {
                cb_ajh.Checked = true;
                cb_ajtm.Checked = true;
                cb_ajys.Checked = true;
                cb_ajzrr.Checked = true;
                cb_ajqzrq.Checked = true;
                cb_ajbgqx.Checked = true;
                cb_ajflh.Checked = true;
                cb_ajmj.Checked = true;
            }
            else
            {
                cb_ajh.Checked = false;
                cb_ajtm.Checked = false;
                cb_ajys.Checked = false;
                cb_ajzrr.Checked = false;
                cb_ajqzrq.Checked = false;
                cb_ajbgqx.Checked = false;
                cb_ajflh.Checked = false;
                cb_ajmj.Checked = false;
            }
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox17.Checked == true)
            {
                cb_xmh.Checked = true;
                cb_xmtm.Checked = true;
                cb_xmys.Checked = true;
                cb_xmkssj.Checked = true;
                cb_xmjssj.Checked = true;
                cb_xmyzdw.Checked = true;
                cb_xmsjdw.Checked = true;
                cb_xmsgdw.Checked = true;
                cb_xmjldw.Checked = true;
                cb_xmflh.Checked = true;
            }
            else
            {
                cb_xmh.Checked = false;
                cb_xmtm.Checked = false;
                cb_xmys.Checked = false;
                cb_xmkssj.Checked = false;
                cb_xmjssj.Checked = false;
                cb_xmyzdw.Checked = false;
                cb_xmsjdw.Checked = false;
                cb_xmsgdw.Checked = false;
                cb_xmjldw.Checked = false;
                cb_xmflh.Checked = false;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
