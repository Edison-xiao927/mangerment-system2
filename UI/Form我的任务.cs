using BAL;
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
    public partial class    Form我的任务 : Form
    {
        public Form我的任务()
        {
            InitializeComponent();
        }
        private void childfrm_raiseCallBackRefreshEvent()
        {
            Form我的任务_Load(null, null); //刷新主窗体
        }
        private void childfrm_raiseCallBackRefreshEvent2()
        {
            Form我的任务_Load(null, null); //刷新主窗体
        }
        string nowrole = "";
        string user = "";
        string process = "";
        int cnt = 0;
        public Form我的任务(string str1) : this()
        {
            this.nowrole = str1;
        }
        public Form我的任务(string str1, string str2) : this()
        {
            this.nowrole = str1;
            this.user = str2;
        }

        private void Form我的任务_Load(object sender, EventArgs e)
        {
            if(cnt != 0 && nowrole == "【著录】")
            {
                dataGridView1.Columns.Remove("btnzl");
                this.dataGridView1.Refresh();
                cnt++;
            }
            if (cnt != 0 && nowrole == "【再次著录】")
            {
                dataGridView1.Columns.Remove("btnczl");
                this.dataGridView1.Refresh();
                cnt++;
            }
            if (nowrole != "【编码】")
            {
                this.label1.Visible = false;
                this.label2.Visible = false;
                this.textBox1.Visible = false;
                this.textBox2.Visible = false;

            }
            else
            {
                this.button3.Visible = false;
                this.button2.Visible = true; 
            }
            if (nowrole == "【拆分】")
            {
                DataSet ds = new MyWorkBAL().Select(user);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    DataTable dt4 = new AABAL().Select10041(ds.Tables[0].Rows[i][2].ToString(), nowrole.Substring(1, nowrole.Length - 2));
                    string str = "已";
                    str = str + dt4.Rows[0][0];
                  //  ds.Tables[0].Rows[i]["状态"] = str;
                    ds.Tables[0].Rows[i]["状态"] = "拆分中";
                }
                dataGridView1.DataSource = ds.Tables[0];
                for (int i = 1; i <= 6; i++)
                {
                    dataGridView1.Columns[i].ReadOnly = true;
                }
                process = "拆分";
            }
            else if (nowrole == "【著录】")
            {
               // btn_zl.Visible = true;
                btn_sel_all.Visible = true;
                this.Text = "著录";
                DataSet ds = new GetJobBAL().Select1015(user);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    DataTable dt4 = new AABAL().Select10041(ds.Tables[0].Rows[i][2].ToString(), nowrole.Substring(1, nowrole.Length - 2));
                    string str = "已";
                    str = str + dt4.Rows[0][0];
                  //  ds.Tables[0].Rows[i]["状态"] = str;
                    ds.Tables[0].Rows[i]["状态"] = "著录中";
                }
                dataGridView1.DataSource = ds.Tables[0];
                for (int i = 1; i <= 6; i++)
                {
                    dataGridView1.Columns[i].ReadOnly = true;
                }
                process = "著录";
               // if(cnt == 0)
              //  {
                    DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                    btn.Name = "btnzl";
                    btn.HeaderText = "著录";
                    btn.DefaultCellStyle.NullValue = "著录";
                    dataGridView1.Columns.Add(btn);
                    cnt = 1;
            //    }           
                DataTable dt5 = new AABAL().Select1214();
                Color color = new Color();
                color = ColorTranslator.FromHtml("RED");
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    for(int j =0;j<dt5.Rows.Count;j++)
                    {
                        if (dataGridView1.Rows[i].Cells["流转单号"].Value.ToString() == dt5.Rows[j][0].ToString() && dataGridView1.Rows[i].Cells["编号"].Value.ToString() == dt5.Rows[j][1].ToString())
                        {
                            for(int x=0;x<ds.Tables[0].Columns.Count;x++)
                            {
                                dataGridView1.Rows[i].Cells[x].Style.ForeColor = color;
                            }
                        }
                    }      
                }
                }
            else if (nowrole == "【再次著录】")
            {
                // btn_zl.Visible = true;
                btn_sel_all.Visible = false;
                this.Text = "再次著录";
                DataSet ds = new GetJobBAL().Select122501(user);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    DataTable dt4 = new AABAL().Select10041(ds.Tables[0].Rows[i][2].ToString(), nowrole.Substring(1, nowrole.Length - 2));
                    string str = "已";
                    str = str + dt4.Rows[0][0];
                    //  ds.Tables[0].Rows[i]["状态"] = str;
                    ds.Tables[0].Rows[i]["状态"] = "著录中";
                }
                dataGridView1.DataSource = ds.Tables[0];
                for (int i = 1; i <= 6; i++)
                {
                    dataGridView1.Columns[i].ReadOnly = true;
                }
                process = "著录";
                // if(cnt == 0)
                //  {
                DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn();
                btn1.Name = "btnczl";
                btn1.HeaderText = "著录111";
                btn1.DefaultCellStyle.NullValue = "著录11";
                dataGridView1.Columns.Add(btn1);
                cnt = 1;
                //    }           
                DataTable dt5 = new CZLBAL().Select1214();
                Color color = new Color();
                color = ColorTranslator.FromHtml("RED");
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    for (int j = 0; j < dt5.Rows.Count; j++)
                    {
                        if (dataGridView1.Rows[i].Cells["流转单号"].Value.ToString() == dt5.Rows[j][0].ToString() && dataGridView1.Rows[i].Cells["编号"].Value.ToString() == dt5.Rows[j][1].ToString())
                        {
                            for (int x = 0; x < ds.Tables[0].Columns.Count; x++)
                            {
                                dataGridView1.Rows[i].Cells[x].Style.ForeColor = color;
                            }
                        }
                    }
                }


            }
            else if (nowrole == "【编码】")
            {
                DataSet ds = new MyWorkBAL().Select3(user);
               for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    DataTable dt4 = new AABAL().Select10042001(ds.Tables[0].Rows[i][2].ToString(), nowrole.Substring(1, nowrole.Length - 2));
                    string str = "已";
                    str = str + dt4.Rows[0][0];
                    //   ds.Tables[0].Rows[i]["状态"] = str;
                    ds.Tables[0].Rows[i]["状态"] = "编码中";
                }
                dataGridView1.DataSource = ds.Tables[0];
                for (int i = 1; i <= 6; i++)
                {
                    dataGridView1.Columns[i].ReadOnly = true;
                }
                process = "编码";
            }
            else if (nowrole == "【扫描】")
            {
                btn_sel_all.Visible = true;
                DataSet ds = new MyWorkBAL().Select1102(user);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    DataTable dt4 = new AABAL().Select10042(ds.Tables[0].Rows[i][2].ToString(), nowrole.Substring(1, nowrole.Length - 2));
                    string str = "已";
                    str = str + dt4.Rows[0][0];
                    // ds.Tables[0].Rows[i]["状态"] = str;
                    ds.Tables[0].Rows[i]["状态"] = "扫描中";
                }
                dataGridView1.DataSource = ds.Tables[0];
                for (int i = 1; i <= 6; i++)
                {
                    dataGridView1.Columns[i].ReadOnly = true;
                }
                process = "扫描";
            }
            else if (nowrole == "【图处】")
            {
                btn_sel_all.Visible = true;
                DataSet ds = new MyWorkBAL().Select110201(user);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    DataTable dt4 = new AABAL().Select10042(ds.Tables[0].Rows[i][2].ToString(), nowrole.Substring(1, nowrole.Length - 2));
                    string str = "已";
                    str = str + dt4.Rows[0][0];
                    //   ds.Tables[0].Rows[i]["状态"] = str;
                    ds.Tables[0].Rows[i]["状态"] = "图处中";
                }
                dataGridView1.DataSource = ds.Tables[0];
                for (int i = 1; i <= 6; i++)
                {
                    dataGridView1.Columns[i].ReadOnly = true;
                }
                process = "图处";
            }
            else if (nowrole == "【还原11】")
            {
                DataSet ds = new MyWorkBAL().Select4();
                dataGridView1.DataSource = ds.Tables[0];

            }
            else if (nowrole == "【质检】")
            {
                btn_sel_all.Visible = true;
                DataSet ds = new MyWorkBAL().Select112001(user);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    DataTable dt4 = new AABAL().Select10042(ds.Tables[0].Rows[i][2].ToString(), nowrole.Substring(1, nowrole.Length - 2));
                    string str = "已";
                    str = str + dt4.Rows[0][0];
                    //   ds.Tables[0].Rows[i]["状态"] = str;
                    ds.Tables[0].Rows[i]["状态"] = "质检中";
                }
                dataGridView1.DataSource = ds.Tables[0];
                for (int i = 1; i <= 6; i++)
                {
                    dataGridView1.Columns[i].ReadOnly = true;
                }
                process = "质检";
            }
            else if (nowrole == "【挂接】")
            {
                btn_sel_all.Visible = true;
                DataSet ds = new MyWorkBAL().Select112002(user);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    DataTable dt4 = new AABAL().Select10042(ds.Tables[0].Rows[i][2].ToString(), nowrole.Substring(1, nowrole.Length - 2));
                    string str = "已";
                    str = str + dt4.Rows[0][0];
                    //  ds.Tables[0].Rows[i]["状态"] = str;
                    ds.Tables[0].Rows[i]["状态"] = "挂接中";
                }
                dataGridView1.DataSource = ds.Tables[0];
                for (int i = 1; i <= 6; i++)
                {
                    dataGridView1.Columns[i].ReadOnly = true;
                }
                process = "质检";
            }
            else if (nowrole == "【还原】")
            {
         
                DataSet ds = new MyWorkBAL().Select112003(user);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    DataTable dt4 = new AABAL().Select10042(ds.Tables[0].Rows[i][2].ToString(), nowrole.Substring(1, nowrole.Length - 2));
                    string str = "已";
                    str = str + dt4.Rows[0][0];
                    //   ds.Tables[0].Rows[i]["状态"] = str;
                    ds.Tables[0].Rows[i]["状态"] = "还原中";
                }
                dataGridView1.DataSource = ds.Tables[0];
                for (int i = 1; i <= 6; i++)
                {
                    dataGridView1.Columns[i].ReadOnly = true;
                }
                process = "质检";
            }
            else if (nowrole == "【归还】")
            {
          
                button5.Visible = true;
                DataSet ds = new MyWorkBAL().Select112004(user);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    DataTable dt4 = new AABAL().Select10042(ds.Tables[0].Rows[i][2].ToString(), nowrole.Substring(1, nowrole.Length - 2));
                    string str = "已";
                    str = str + dt4.Rows[0][0];
                    //  ds.Tables[0].Rows[i]["状态"] = str;
                    ds.Tables[0].Rows[i]["状态"] = "归还中";
                }
                dataGridView1.DataSource = ds.Tables[0];
                for (int i = 1; i <= 6; i++)
                {
                    dataGridView1.Columns[i].ReadOnly = true;
                }
                process = "质检";
            }
            /*            else if (nowrole == "【扫描】")
                        {
                            Form我的任务2 form = new Form我的任务2();
                            this.Hide();
                            form.ShowDialog();
                            this.Close();
                        }
                        else if (nowrole == "【编目】")
                        {
                            DataSet ds = new MyWorkBAL().Select7();
                            dataGridView1.DataSource = ds.Tables[0];

                        }
                        else if (nowrole == "【图处】")
                        {
                            扫描 form = new 扫描();
                            this.Hide();
                            form.ShowDialog();
                            this.Close();
                        }
                        else if (nowrole == "【质检】")
                        {
                            Form我的任务4 form = new Form我的任务4();
                            this.Hide();
                            form.ShowDialog();
                            this.Close();
                        }
                        else if (nowrole == "【挂接】")
                        {
                            DataSet ds = new MyWorkBAL().Select10();
                            dataGridView1.DataSource = ds.Tables[0];
                        }
                        else if (nowrole == "【归还】")
                        {
                            Form我的任务5 form = new Form我的任务5();
                            this.Hide();
                            form.ShowDialog();
                            this.Close();
                        }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nowrole == "【拆分】")
            {
                int a = dataGridView1.CurrentRow.Index;
                string str = dataGridView1.Rows[a].Cells["项目号"].Value.ToString();
                string str2 = dataGridView1.Rows[a].Cells["流转单号"].Value.ToString();
                MySqlDataReader sdr = new WorkBAL().Selectinfo3(str);
                if (sdr.Read())
                {
                    string projectUnit = sdr.GetString(0).Trim();
                    string filetype = sdr.GetString(1).Trim();
                    string gdmethod = sdr.GetString(2).Trim();
                    string year = sdr.GetString(3).Trim();
                    sdr.Close();
                    Form档案问题确认单 form = new Form档案问题确认单(projectUnit, filetype, gdmethod, nowrole, str2, year);
                    this.Hide();
                    form.ShowDialog();
                    this.Close();
                }
            }
            else if (nowrole == "【著录】")
            {
                int a = dataGridView1.CurrentRow.Index;
                string str = dataGridView1.Rows[a].Cells["项目号"].Value.ToString();
                string str2 = dataGridView1.Rows[a].Cells["流转单号"].Value.ToString();
                MySqlDataReader sdr = new WorkBAL().Selectinfo3(str);
                if (sdr.Read())
                {
                    string projectUnit = sdr.GetString(0).Trim();
                    string filetype = sdr.GetString(1).Trim();
                    string gdmethod = sdr.GetString(2).Trim();
                    string year = sdr.GetString(3).Trim();
                    sdr.Close();
                    Form档案问题确认单 form = new Form档案问题确认单(projectUnit, filetype, gdmethod, nowrole, str2, year);
                    this.Hide();
                    form.ShowDialog();
                    this.Close();
                }
            }
            else if (nowrole == "【编码】")
            {
                int a = dataGridView1.CurrentRow.Index;
                string str = dataGridView1.Rows[a].Cells["项目号"].Value.ToString();
                string str2 = dataGridView1.Rows[a].Cells["领取批次号"].Value.ToString();
                MySqlDataReader sdr = new WorkBAL().Selectinfo3(str);
                if (sdr.Read())
                {
                    string projectUnit = sdr.GetString(0).Trim();
                    string filetype = sdr.GetString(1).Trim();
                    string gdmethod = sdr.GetString(2).Trim();
                    string year = sdr.GetString(3).Trim();
                    sdr.Close();
                    Form档案问题确认单 form = new Form档案问题确认单(projectUnit, filetype, gdmethod, nowrole, str2, year);
                    this.Hide();
                    form.ShowDialog();
                    this.Close();
                }
            }
            else if (nowrole == "【还原】")
            {
                int a = dataGridView1.CurrentRow.Index;
                string str = dataGridView1.Rows[a].Cells["项目号"].Value.ToString();
                string str2 = dataGridView1.Rows[a].Cells["流转单号"].Value.ToString();
                MySqlDataReader sdr = new WorkBAL().Selectinfo3(str);
                if (sdr.Read())
                {
                    string projectUnit = sdr.GetString(0).Trim();
                    string filetype = sdr.GetString(1).Trim();
                    string gdmethod = sdr.GetString(2).Trim();
                    string year = sdr.GetString(3).Trim();
                    sdr.Close();
                    Form档案问题确认单 form = new Form档案问题确认单(projectUnit, filetype, gdmethod, nowrole, str2, year);
                    this.Hide();
                    form.ShowDialog();
                    this.Close();
                }
            }
            else if (nowrole == "【归还】")
            {
                int a = dataGridView1.CurrentRow.Index;
                string str = dataGridView1.Rows[a].Cells["项目号"].Value.ToString();
                string str2 = dataGridView1.Rows[a].Cells["流转单号"].Value.ToString();
                MySqlDataReader sdr = new WorkBAL().Selectinfo2(str);
                if (sdr.Read())
                {
                    string projectUnit = sdr.GetString(0).Trim();
                    string filetype = sdr.GetString(1).Trim();
                    string gdmethod = sdr.GetString(2).Trim();
                    sdr.Close();
                    Form档案领取交接单 form = new Form档案领取交接单(projectUnit, filetype, gdmethod, nowrole, str2);
                    this.Hide();
                    form.ShowDialog();
                    this.Close();
                }
            }
            else if (nowrole == "【挂接】")
            {
                int a = dataGridView1.CurrentRow.Index;
                string str = dataGridView1.Rows[a].Cells["项目号"].Value.ToString();
                string str2 = dataGridView1.Rows[a].Cells["流转单号"].Value.ToString();
                MySqlDataReader sdr = new WorkBAL().Selectinfo3(str);
                if (sdr.Read())
                {
                    string projectUnit = sdr.GetString(0).Trim();
                    string filetype = sdr.GetString(1).Trim();
                    string gdmethod = sdr.GetString(2).Trim();
                    string year = sdr.GetString(3).Trim();
                    sdr.Close();
                    Form档案问题确认单 form = new Form档案问题确认单(projectUnit, filetype, gdmethod, nowrole, str2, year);
                    this.Hide();
                    form.ShowDialog();
                    this.Close();
                }
            }
           
            else if (nowrole == "【图处】")
            {
                int a = dataGridView1.CurrentRow.Index;
                string str = dataGridView1.Rows[a].Cells["项目号"].Value.ToString();
                string str2 = dataGridView1.Rows[a].Cells["流转单号"].Value.ToString();
                MySqlDataReader sdr = new WorkBAL().Selectinfo3(str);
                if (sdr.Read())
                {
                    string projectUnit = sdr.GetString(0).Trim();
                    string filetype = sdr.GetString(1).Trim();
                    string gdmethod = sdr.GetString(2).Trim();
                    string year = sdr.GetString(3).Trim();
                    sdr.Close();
                    Form档案问题确认单 form = new Form档案问题确认单(projectUnit, filetype, gdmethod, nowrole, str2, year);
                    this.Hide();
                    form.ShowDialog();
                    this.Close();
                }
            }
            else if (nowrole == "【质检】")
            {
                int a = dataGridView1.CurrentRow.Index;
                string str = dataGridView1.Rows[a].Cells["项目号"].Value.ToString();
                string str2 = dataGridView1.Rows[a].Cells["流转单号"].Value.ToString();
                MySqlDataReader sdr = new WorkBAL().Selectinfo3(str);
                if (sdr.Read())
                {
                    string projectUnit = sdr.GetString(0).Trim();
                    string filetype = sdr.GetString(1).Trim();
                    string gdmethod = sdr.GetString(2).Trim();
                    string year = sdr.GetString(3).Trim();
                    sdr.Close();
                    Form档案问题确认单 form = new Form档案问题确认单(projectUnit, filetype, gdmethod, nowrole, str2, year);
                    this.Hide();
                    form.ShowDialog();
                    this.Close();
                }
            }
            else if (nowrole == "【扫描】")
            {
                int a = dataGridView1.CurrentRow.Index;
                string str = dataGridView1.Rows[a].Cells["项目号"].Value.ToString();
                string str2 = dataGridView1.Rows[a].Cells["流转单号"].Value.ToString();
                MySqlDataReader sdr = new WorkBAL().Selectinfo3(str);
                if (sdr.Read())
                {
                    string projectUnit = sdr.GetString(0).Trim();
                    string filetype = sdr.GetString(1).Trim();
                    string gdmethod = sdr.GetString(2).Trim();
                    string year = sdr.GetString(3).Trim();
                    sdr.Close();
                    Form档案问题确认单 form = new Form档案问题确认单(projectUnit, filetype, gdmethod, nowrole, str2, year);
                    this.Hide();
                    form.ShowDialog();
                    this.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool flag123 = false;
            for (int j = 0; j < dataGridView1.RowCount; j++)
            {
                if ((bool)dataGridView1.Rows[j].Cells[0].EditedFormattedValue == true)
                {
                    flag123 = true;
                }
            }
            if(flag123 ==true)
            {
                if (nowrole == "【拆分】")
                {
                    if (textBox2.Text.ToString() == "")
                    {
                        int k = 0;
                        int p = 0;
                        bool flag1008 = true;
                        for (int j = 0; j < dataGridView1.RowCount; j++)
                        {

                            if ((bool)dataGridView1.Rows[j].Cells[0].EditedFormattedValue == true && k == 0)
                            {
                                p = j;
                                k++;
                            }
                            if ((bool)dataGridView1.Rows[j].Cells[0].EditedFormattedValue == true && k != 0)
                            {
                                if (dataGridView1.Rows[j].Cells["流转单号"].Value.ToString() != dataGridView1.Rows[p].Cells["流转单号"].Value.ToString())
                                {
                                    flag1008 = false;
                                }
                            }
                        }
                        if (flag1008 == true)
                        {
                            int cnt = 0;
                            for (int j = 0; j < dataGridView1.RowCount; j++)
                            {
                                if ((bool)dataGridView1.Rows[j].Cells[0].EditedFormattedValue == true)
                                {
                                    cnt++;
                                }
                            }
                            int ss = 0;
                            string[] bh = new string[cnt];
                            for (int j = 0; j < dataGridView1.RowCount; j++)
                            {
                                if ((bool)dataGridView1.Rows[j].Cells[0].EditedFormattedValue == true)
                                {
                                    bh[ss++] = dataGridView1.Rows[j].Cells["编号"].Value.ToString();
                                }
                            }
                            int a = dataGridView1.CurrentRow.Index;
                            string str = dataGridView1.Rows[a].Cells["项目号"].Value.ToString();
                            string str3 = dataGridView1.Rows[a].Cells["流转单号"].Value.ToString();
                            string str4 = dataGridView1.Rows[a].Cells["编号"].Value.ToString();
                            string str5 = dataGridView1.Rows[a].Cells["项目单位"].Value.ToString();
                            string str6 = dataGridView1.Rows[a].Cells["档案类型"].Value.ToString();
                            DataTable dt = new AABAL().Select1010(str3, str4);
                            //             DataTable dt = new AABAL().Select100701(str2, str4);
                            string str2 = dt.Rows[0][0].ToString();
                            MySqlDataReader sdr = new WorkBAL().Selectinfo2(str);
                            if (sdr.Read())
                            {
                                string nx = sdr.GetString(0).Trim();
                                string gdmethod = sdr.GetString(1).Trim();
                                sdr.Close();
                                Form加工流转单 form = new Form加工流转单(str5, str6, gdmethod, bh, str2, process, str3, nowrole, nx, str);
                                form.raiseCallBackRefreshEvent += new raiseCallBackRefreshDelegate(childfrm_raiseCallBackRefreshEvent); //注册回调事件，也即将子窗体抛出的事件接收，然后处理
                                form.ShowDialog();

                            }
                        }
                        else
                        {
                            MessageBox.Show("所选取的为不同流转单号下的档案，请重新选择");
                        }
                    }
                    else
                    {

                    }
                }
                else if (nowrole == "【著录】")
                {
                    int k = 0;
                    int p = 0;
                    bool flag1008 = true;
                    for (int j = 0; j < dataGridView1.RowCount; j++)
                    {

                        if ((bool)dataGridView1.Rows[j].Cells[0].EditedFormattedValue == true && k == 0)
                        {
                            p = j;
                            k++;
                        }
                        if ((bool)dataGridView1.Rows[j].Cells[0].EditedFormattedValue == true && k != 0)
                        {
                            if (dataGridView1.Rows[j].Cells["流转单号"].Value.ToString() != dataGridView1.Rows[p].Cells["流转单号"].Value.ToString())
                            {
                                flag1008 = false;
                            }
                        }
                    }
                    if (flag1008 == true)
                    {
                        int cnt = 0;
                        for (int j = 0; j < dataGridView1.RowCount; j++)
                        {
                            if ((bool)dataGridView1.Rows[j].Cells[0].EditedFormattedValue == true)
                            {
                                cnt++;
                            }
                        }
                        int ss = 0;
                        string[] bh = new string[cnt];
                        for (int j = 0; j < dataGridView1.RowCount; j++)
                        {
                            if ((bool)dataGridView1.Rows[j].Cells[0].EditedFormattedValue == true)
                            {
                                bh[ss++] = dataGridView1.Rows[j].Cells["编号"].Value.ToString();
                            }
                        }
                        int a = dataGridView1.CurrentRow.Index;
                        string str = dataGridView1.Rows[a].Cells["项目号"].Value.ToString();
                        string str3 = dataGridView1.Rows[a].Cells["流转单号"].Value.ToString();
                        string str4 = dataGridView1.Rows[a].Cells["编号"].Value.ToString();
                        string str5 = dataGridView1.Rows[a].Cells["项目单位"].Value.ToString();
                        string str6 = dataGridView1.Rows[a].Cells["档案类型"].Value.ToString();
                        DataTable dt = new AABAL().Select1010(str3, str4);
                        //             DataTable dt = new AABAL().Select100701(str2, str4);
                        string str2 = dt.Rows[0][0].ToString();
                        MySqlDataReader sdr = new WorkBAL().Selectinfo2(str);
                        if (sdr.Read())
                        {
                            string nx = sdr.GetString(0).Trim();
                            string gdmethod = sdr.GetString(1).Trim();
                            sdr.Close();
                            Form加工流转单 form = new Form加工流转单(str5, str6, gdmethod, bh, str2, process, str3, nowrole, nx, str);
                            form.raiseCallBackRefreshEvent += new raiseCallBackRefreshDelegate(childfrm_raiseCallBackRefreshEvent); //注册回调事件，也即将子窗体抛出的事件接收，然后处理
                            form.ShowDialog();

                        }
                    }
                    else
                    {
                        MessageBox.Show("所选取的为不同流转单号下的档案，请重新选择");
                    }
                }
                else if (nowrole == "【编码】")
                {
                    if (textBox2.Text.ToString() == "")
                    {
                        int k = 0;
                        int p = 0;
                        bool flag1008 = true;
                        for (int j = 0; j < dataGridView1.RowCount; j++)
                        {

                            if ((bool)dataGridView1.Rows[j].Cells[0].EditedFormattedValue == true && k == 0)
                            {
                                p = j;
                                k++;
                            }
                            if ((bool)dataGridView1.Rows[j].Cells[0].EditedFormattedValue == true && k != 0)
                            {
                                if (dataGridView1.Rows[j].Cells["领取批次号"].Value.ToString() != dataGridView1.Rows[p].Cells["领取批次号"].Value.ToString())
                                {
                                    flag1008 = false;
                                }
                            }
                        }
                        if (flag1008 == true)
                        {
                            int page = 0;
                            int cnt = 0;
                            for (int j = 0; j < dataGridView1.RowCount; j++)
                            {
                                if ((bool)dataGridView1.Rows[j].Cells[0].EditedFormattedValue == true)
                                {
                                    cnt++;
                                }
                            }
                            int ss = 0;
                            string[] bh = new string[cnt];
                            bool jx = true;
                            for (int j = 0; j < dataGridView1.RowCount; j++)
                            {
                                if ((bool)dataGridView1.Rows[j].Cells[0].EditedFormattedValue == true)
                                {
                                    if (dataGridView1.Rows[j].Cells["页数"].Value.ToString() != "")
                                    {
                                        bh[ss++] = dataGridView1.Rows[j].Cells["编号"].Value.ToString();
                                        page = page + Convert.ToInt32(dataGridView1.Rows[j].Cells["页数"].Value.ToString());
                                        string q = dataGridView1.Rows[j].Cells["编号"].Value.ToString();
                                        string w = dataGridView1.Rows[j].Cells["领取批次号"].Value.ToString();
                                        string r = dataGridView1.Rows[j].Cells["页数"].Value.ToString();
                                        bool flag22 = new WorkBAL().update1028(w, q, r);
                                    }
                                    else
                                    {
                                        jx = false;
                                    }
                                }
                            }
                            if (jx == true)
                            {
                                int a = dataGridView1.CurrentRow.Index;
                                string str = dataGridView1.Rows[a].Cells["项目号"].Value.ToString();
                                string str2 = dataGridView1.Rows[a].Cells["领取批次号"].Value.ToString();
                                string str4 = dataGridView1.Rows[a].Cells["编号"].Value.ToString();
                                string str5 = dataGridView1.Rows[a].Cells["项目单位"].Value.ToString();
                                string str6 = dataGridView1.Rows[a].Cells["档案类型"].Value.ToString();
                                string str3 = "";
                                DataTable dt = new AABAL().Select1007(str2);
                                if (dt.Rows[0][0].ToString() != "")
                                {
                                    string[] sArray = dt.Rows[0][0].ToString().Split('-');
                                    int i = Convert.ToInt32(sArray[2]);
                                    i = i + 1;
                                    string lz = i.ToString("000");
                                    lz = sArray[0] + "-" + sArray[1] + "-" + lz;
                                    str3 = lz;
                                }
                                else
                                {
                                    string str3333 = "001";
                                    string lz = str2 + "-" + str3333;
                                    str3 = lz;
                                }
                                MySqlDataReader sdr = new WorkBAL().Selectinfo2(str);
                                if (sdr.Read())
                                {
                                    string nx = sdr.GetString(0).Trim();
                                    //       string filetype = sdr.GetString(1).Trim();
                                    string gdmethod = sdr.GetString(1).Trim();
                                    sdr.Close();
                                    Form加工流转单 form = new Form加工流转单(str5, str6, gdmethod, bh, str2, process, str3, nowrole, nx, str, page, user);
                                    form.raiseCallBackRefreshEvent += new raiseCallBackRefreshDelegate(childfrm_raiseCallBackRefreshEvent); //注册回调事件，也即将子窗体抛出的事件接收，然后处理
                                    form.ShowDialog();

                                }
                            }
                            else
                            {
                                MessageBox.Show("页数不能为空");
                            }

                        }
                        else
                        {
                            MessageBox.Show("所选取的为不同批次下的档案，请重新选择");
                        }
                    }
                    else
                    {
                        int page = 0;
                        int begin = Convert.ToInt32(textBox1.Text.ToString());
                        int end = Convert.ToInt32(textBox2.Text.ToString());
                        int count = end - begin;
                        int cc = dataGridView1.CurrentCell.RowIndex;
                        string aa = dataGridView1.Rows[cc].Cells["领取批次号"].Value.ToString();
                        int bb = dataGridView1.Rows.Count;
                        for (int i = 0; i < bb - 1; i++)
                        {
                            if (dataGridView1.Rows[i].Cells["领取批次号"].Value.ToString() == aa && Convert.ToInt32(dataGridView1.Rows[i].Cells["编号"].Value.ToString()) >= begin && Convert.ToInt32(dataGridView1.Rows[i].Cells["编号"].Value.ToString()) <= end)
                            {
                                dataGridView1.Rows[i].Cells[0].Value = true;
                            }
                        }
                        bool jx = true;
                        for (int j = 0; j < dataGridView1.RowCount; j++)
                        {
                            if ((bool)dataGridView1.Rows[j].Cells[0].EditedFormattedValue == true)
                            {
                                if (dataGridView1.Rows[j].Cells["页数"].Value.ToString() != "")
                                {
                                    page = page + Convert.ToInt32(dataGridView1.Rows[j].Cells["页数"].Value.ToString());
                                    string q = dataGridView1.Rows[j].Cells["编号"].Value.ToString();
                                    string w = dataGridView1.Rows[j].Cells["领取批次号"].Value.ToString();
                                    string r = dataGridView1.Rows[j].Cells["页数"].Value.ToString();
                                    bool flag22 = new WorkBAL().update1028(w, q, r);
                                }
                                else
                                {
                                    jx = false;
                                }
                            }
                        }
                        if (jx == true)
                        {
                            string[] bh = new string[count + 1];
                            int ccc = 0;
                            for (int i = begin; i <= end; i++)
                            {
                                bh[ccc++] = i.ToString();
                            }
                            int a = dataGridView1.CurrentRow.Index;
                            string str = dataGridView1.Rows[a].Cells["项目号"].Value.ToString();
                            string str2 = dataGridView1.Rows[a].Cells["领取批次号"].Value.ToString();
                            string str4 = dataGridView1.Rows[a].Cells["编号"].Value.ToString();
                            string str5 = dataGridView1.Rows[a].Cells["项目单位"].Value.ToString();
                            string str6 = dataGridView1.Rows[a].Cells["档案类型"].Value.ToString();
                            string str3 = "";
                            DataTable dt = new AABAL().Select1007(str2);
                            if (dt.Rows[0][0].ToString() != "")
                            {
                                string[] sArray = dt.Rows[0][0].ToString().Split('-');
                                int i = Convert.ToInt32(sArray[2]);
                                i = i + 1;
                                string lz = i.ToString("000");
                                lz = sArray[0] + "-" + sArray[1] + "-" + lz;
                                str3 = lz;
                            }
                            else
                            {
                                string str3333 = "001";
                                string lz = str2 + "-" + str3333;
                                str3 = lz;
                            }
                            MySqlDataReader sdr = new WorkBAL().Selectinfo2(str);
                            if (sdr.Read())
                            {
                                string nx = sdr.GetString(0).Trim();
                                //       string filetype = sdr.GetString(1).Trim();
                                string gdmethod = sdr.GetString(1).Trim();
                                sdr.Close();
                                Form加工流转单 form = new Form加工流转单(str5, str6, gdmethod, bh, str2, process, str3, nowrole, nx, str, page, user);
                                form.raiseCallBackRefreshEvent += new raiseCallBackRefreshDelegate(childfrm_raiseCallBackRefreshEvent); //注册回调事件，也即将子窗体抛出的事件接收，然后处理
                                form.ShowDialog();

                            }
                        }
                        else
                        {
                            MessageBox.Show("页数不能为空");
                        }

                    }
                }
                else if (nowrole == "【还原】")
                {

                    int k = 0;
                    int p = 0;
                    bool flag1008 = true;
                    for (int j = 0; j < dataGridView1.RowCount; j++)
                    {

                        if ((bool)dataGridView1.Rows[j].Cells[0].EditedFormattedValue == true && k == 0)
                        {
                            p = j;
                            k++;
                        }
                        if ((bool)dataGridView1.Rows[j].Cells[0].EditedFormattedValue == true && k != 0)
                        {
                            if (dataGridView1.Rows[j].Cells["流转单号"].Value.ToString() != dataGridView1.Rows[p].Cells["流转单号"].Value.ToString())
                            {
                                flag1008 = false;
                            }
                        }
                    }
                    if (flag1008 == true)
                    {
                        int cnt = 0;
                        for (int j = 0; j < dataGridView1.RowCount; j++)
                        {
                            if ((bool)dataGridView1.Rows[j].Cells[0].EditedFormattedValue == true)
                            {
                                cnt++;
                            }
                        }
                        int ss = 0;
                        string[] bh = new string[cnt];
                        for (int j = 0; j < dataGridView1.RowCount; j++)
                        {
                            if ((bool)dataGridView1.Rows[j].Cells[0].EditedFormattedValue == true)
                            {
                                bh[ss++] = dataGridView1.Rows[j].Cells["编号"].Value.ToString();
                            }
                        }
                        int a = dataGridView1.CurrentRow.Index;
                        string str = dataGridView1.Rows[a].Cells["项目号"].Value.ToString();
                        string str3 = dataGridView1.Rows[a].Cells["流转单号"].Value.ToString();
                        string str4 = dataGridView1.Rows[a].Cells["编号"].Value.ToString();
                        string str5 = dataGridView1.Rows[a].Cells["项目单位"].Value.ToString();
                        string str6 = dataGridView1.Rows[a].Cells["档案类型"].Value.ToString();
                        DataTable dt = new AABAL().Select1010(str3, str4);
                        //             DataTable dt = new AABAL().Select100701(str2, str4);
                        string str2 = dt.Rows[0][0].ToString();
                        MySqlDataReader sdr = new WorkBAL().Selectinfo2(str);
                        if (sdr.Read())
                        {
                            string nx = sdr.GetString(0).Trim();
                            string gdmethod = sdr.GetString(1).Trim();
                            sdr.Close();
                            Form加工流转单 form = new Form加工流转单(str5, str6, gdmethod, bh, str2, process, str3, nowrole, nx, str);
                            form.raiseCallBackRefreshEvent += new raiseCallBackRefreshDelegate(childfrm_raiseCallBackRefreshEvent); //注册回调事件，也即将子窗体抛出的事件接收，然后处理
                            form.ShowDialog();

                        }
                    }
                    else
                    {
                        MessageBox.Show("所选取的为不同流转单号下的档案，请重新选择");
                    }
                }
                else if (nowrole == "【扫描】")
                {

                    int k = 0;
                    int p = 0;
                    bool flag1008 = true;
                    for (int j = 0; j < dataGridView1.RowCount; j++)
                    {

                        if ((bool)dataGridView1.Rows[j].Cells[0].EditedFormattedValue == true && k == 0)
                        {
                            p = j;
                            k++;
                        }
                        if ((bool)dataGridView1.Rows[j].Cells[0].EditedFormattedValue == true && k != 0)
                        {
                            if (dataGridView1.Rows[j].Cells["流转单号"].Value.ToString() != dataGridView1.Rows[p].Cells["流转单号"].Value.ToString())
                            {
                                flag1008 = false;
                            }
                        }
                    }
                    if (flag1008 == true)
                    {
                        int cnt = 0;
                        for (int j = 0; j < dataGridView1.RowCount; j++)
                        {
                            if ((bool)dataGridView1.Rows[j].Cells[0].EditedFormattedValue == true)
                            {
                                cnt++;
                            }
                        }
                        int ss = 0;
                        string[] bh = new string[cnt];
                        for (int j = 0; j < dataGridView1.RowCount; j++)
                        {
                            if ((bool)dataGridView1.Rows[j].Cells[0].EditedFormattedValue == true)
                            {
                                bh[ss++] = dataGridView1.Rows[j].Cells["编号"].Value.ToString();
                            }
                        }
                        int a = dataGridView1.CurrentRow.Index;
                        string str = dataGridView1.Rows[a].Cells["项目号"].Value.ToString();
                        string str3 = dataGridView1.Rows[a].Cells["流转单号"].Value.ToString();
                        string str4 = dataGridView1.Rows[a].Cells["编号"].Value.ToString();
                        string str5 = dataGridView1.Rows[a].Cells["项目单位"].Value.ToString();
                        string str6 = dataGridView1.Rows[a].Cells["档案类型"].Value.ToString();
                        DataTable dt = new AABAL().Select1010(str3, str4);
                        //             DataTable dt = new AABAL().Select100701(str2, str4);
                        string str2 = dt.Rows[0][0].ToString();
                        MySqlDataReader sdr = new WorkBAL().Selectinfo2(str);
                        if (sdr.Read())
                        {
                            string nx = sdr.GetString(0).Trim();
                            string gdmethod = sdr.GetString(1).Trim();
                            sdr.Close();
                            Form加工流转单 form = new Form加工流转单(str5, str6, gdmethod, bh, str2, process, str3, nowrole, nx, str);
                            form.raiseCallBackRefreshEvent += new raiseCallBackRefreshDelegate(childfrm_raiseCallBackRefreshEvent); //注册回调事件，也即将子窗体抛出的事件接收，然后处理
                            form.ShowDialog();

                        }
                    }
                    else
                    {
                        MessageBox.Show("所选取的为不同流转单号下的档案，请重新选择");
                    }
                }
                else if (nowrole == "【编目】")
                {

                    int a = dataGridView1.CurrentRow.Index;
                    string str = dataGridView1.Rows[a].Cells["项目号"].Value.ToString();
                    string str2 = dataGridView1.Rows[a].Cells["领取批次号"].Value.ToString();
                    string str4 = dataGridView1.Rows[a].Cells["编号"].Value.ToString();
                    string str5 = dataGridView1.Rows[a].Cells["项目单位"].Value.ToString();
                    string str6 = dataGridView1.Rows[a].Cells["档案类型"].Value.ToString();
                    DataTable dt = new AABAL().Select100701(str2, str4);
                    string str3 = dt.Rows[0][0].ToString();
                    MySqlDataReader sdr = new WorkBAL().Selectinfo2(str);
                    if (sdr.Read())
                    {
                        string nx = sdr.GetString(0).Trim();
                        //       string filetype = sdr.GetString(1).Trim();
                        string gdmethod = sdr.GetString(1).Trim();
                        sdr.Close();
                        //           Form加工流转单 form = new Form加工流转单(str5, str6, gdmethod, str4, str2, process, str3, nowrole, nx, str);
                        // this.Hide();
                        //         form.raiseCallBackRefreshEvent += new raiseCallBackRefreshDelegate(childfrm_raiseCallBackRefreshEvent); //注册回调事件，也即将子窗体抛出的事件接收，然后处理
                        //        form.ShowDialog();
                        // this.Close();
                    }
                }
                else if (nowrole == "【图处】")
                {

                    int k = 0;
                    int p = 0;
                    bool flag1008 = true;
                    for (int j = 0; j < dataGridView1.RowCount; j++)
                    {

                        if ((bool)dataGridView1.Rows[j].Cells[0].EditedFormattedValue == true && k == 0)
                        {
                            p = j;
                            k++;
                        }
                        if ((bool)dataGridView1.Rows[j].Cells[0].EditedFormattedValue == true && k != 0)
                        {
                            if (dataGridView1.Rows[j].Cells["流转单号"].Value.ToString() != dataGridView1.Rows[p].Cells["流转单号"].Value.ToString())
                            {
                                flag1008 = false;
                            }
                        }
                    }
                    if (flag1008 == true)
                    {
                        int cnt = 0;
                        for (int j = 0; j < dataGridView1.RowCount; j++)
                        {
                            if ((bool)dataGridView1.Rows[j].Cells[0].EditedFormattedValue == true)
                            {
                                cnt++;
                            }
                        }
                        int ss = 0;
                        string[] bh = new string[cnt];
                        for (int j = 0; j < dataGridView1.RowCount; j++)
                        {
                            if ((bool)dataGridView1.Rows[j].Cells[0].EditedFormattedValue == true)
                            {
                                bh[ss++] = dataGridView1.Rows[j].Cells["编号"].Value.ToString();
                            }
                        }
                        int a = dataGridView1.CurrentRow.Index;
                        string str = dataGridView1.Rows[a].Cells["项目号"].Value.ToString();
                        string str3 = dataGridView1.Rows[a].Cells["流转单号"].Value.ToString();
                        string str4 = dataGridView1.Rows[a].Cells["编号"].Value.ToString();
                        string str5 = dataGridView1.Rows[a].Cells["项目单位"].Value.ToString();
                        string str6 = dataGridView1.Rows[a].Cells["档案类型"].Value.ToString();
                        DataTable dt = new AABAL().Select1010(str3, str4);
                        //             DataTable dt = new AABAL().Select100701(str2, str4);
                        string str2 = dt.Rows[0][0].ToString();
                        MySqlDataReader sdr = new WorkBAL().Selectinfo2(str);
                        if (sdr.Read())
                        {
                            string nx = sdr.GetString(0).Trim();
                            string gdmethod = sdr.GetString(1).Trim();
                            sdr.Close();
                            Form加工流转单 form = new Form加工流转单(str5, str6, gdmethod, bh, str2, process, str3, nowrole, nx, str);
                            form.raiseCallBackRefreshEvent += new raiseCallBackRefreshDelegate(childfrm_raiseCallBackRefreshEvent); //注册回调事件，也即将子窗体抛出的事件接收，然后处理
                            form.ShowDialog();

                        }
                    }
                    else
                    {
                        MessageBox.Show("所选取的为不同流转单号下的档案，请重新选择");
                    }
                }
                else if (nowrole == "【质检】")
                {

                    int k = 0;
                    int p = 0;
                    bool flag1008 = true;
                    for (int j = 0; j < dataGridView1.RowCount; j++)
                    {

                        if ((bool)dataGridView1.Rows[j].Cells[0].EditedFormattedValue == true && k == 0)
                        {
                            p = j;
                            k++;
                        }
                        if ((bool)dataGridView1.Rows[j].Cells[0].EditedFormattedValue == true && k != 0)
                        {
                            if (dataGridView1.Rows[j].Cells["流转单号"].Value.ToString() != dataGridView1.Rows[p].Cells["流转单号"].Value.ToString())
                            {
                                flag1008 = false;
                            }
                        }
                    }
                    if (flag1008 == true)
                    {
                        int cnt = 0;
                        for (int j = 0; j < dataGridView1.RowCount; j++)
                        {
                            if ((bool)dataGridView1.Rows[j].Cells[0].EditedFormattedValue == true)
                            {
                                cnt++;
                            }
                        }
                        int ss = 0;
                        string[] bh = new string[cnt];
                        for (int j = 0; j < dataGridView1.RowCount; j++)
                        {
                            if ((bool)dataGridView1.Rows[j].Cells[0].EditedFormattedValue == true)
                            {
                                bh[ss++] = dataGridView1.Rows[j].Cells["编号"].Value.ToString();
                            }
                        }
                        int a = dataGridView1.CurrentRow.Index;
                        string str = dataGridView1.Rows[a].Cells["项目号"].Value.ToString();
                        string str3 = dataGridView1.Rows[a].Cells["流转单号"].Value.ToString();
                        string str4 = dataGridView1.Rows[a].Cells["编号"].Value.ToString();
                        string str5 = dataGridView1.Rows[a].Cells["项目单位"].Value.ToString();
                        string str6 = dataGridView1.Rows[a].Cells["档案类型"].Value.ToString();
                        DataTable dt = new AABAL().Select1010(str3, str4);
                        //             DataTable dt = new AABAL().Select100701(str2, str4);
                        string str2 = dt.Rows[0][0].ToString();
                        MySqlDataReader sdr = new WorkBAL().Selectinfo2(str);
                        if (sdr.Read())
                        {
                            string nx = sdr.GetString(0).Trim();
                            string gdmethod = sdr.GetString(1).Trim();
                            sdr.Close();
                            Form加工流转单 form = new Form加工流转单(str5, str6, gdmethod, bh, str2, process, str3, nowrole, nx, str);
                            form.raiseCallBackRefreshEvent += new raiseCallBackRefreshDelegate(childfrm_raiseCallBackRefreshEvent); //注册回调事件，也即将子窗体抛出的事件接收，然后处理
                            form.ShowDialog();

                        }
                    }
                    else
                    {
                        MessageBox.Show("所选取的为不同流转单号下的档案，请重新选择");
                    }
                }
                else if (nowrole == "【挂接】")
                {

                    int k = 0;
                    int p = 0;
                    bool flag1008 = true;
                    for (int j = 0; j < dataGridView1.RowCount; j++)
                    {

                        if ((bool)dataGridView1.Rows[j].Cells[0].EditedFormattedValue == true && k == 0)
                        {
                            p = j;
                            k++;
                        }
                        if ((bool)dataGridView1.Rows[j].Cells[0].EditedFormattedValue == true && k != 0)
                        {
                            if (dataGridView1.Rows[j].Cells["流转单号"].Value.ToString() != dataGridView1.Rows[p].Cells["流转单号"].Value.ToString())
                            {
                                flag1008 = false;
                            }
                        }
                    }
                    if (flag1008 == true)
                    {
                        int cnt = 0;
                        for (int j = 0; j < dataGridView1.RowCount; j++)
                        {
                            if ((bool)dataGridView1.Rows[j].Cells[0].EditedFormattedValue == true)
                            {
                                cnt++;
                            }
                        }
                        int ss = 0;
                        string[] bh = new string[cnt];
                        for (int j = 0; j < dataGridView1.RowCount; j++)
                        {
                            if ((bool)dataGridView1.Rows[j].Cells[0].EditedFormattedValue == true)
                            {
                                bh[ss++] = dataGridView1.Rows[j].Cells["编号"].Value.ToString();
                            }
                        }
                        int a = dataGridView1.CurrentRow.Index;
                        string str = dataGridView1.Rows[a].Cells["项目号"].Value.ToString();
                        string str3 = dataGridView1.Rows[a].Cells["流转单号"].Value.ToString();
                        string str4 = dataGridView1.Rows[a].Cells["编号"].Value.ToString();
                        string str5 = dataGridView1.Rows[a].Cells["项目单位"].Value.ToString();
                        string str6 = dataGridView1.Rows[a].Cells["档案类型"].Value.ToString();
                        DataTable dt = new AABAL().Select1010(str3, str4);
                        //             DataTable dt = new AABAL().Select100701(str2, str4);
                        string str2 = dt.Rows[0][0].ToString();
                        MySqlDataReader sdr = new WorkBAL().Selectinfo2(str);
                        if (sdr.Read())
                        {
                            string nx = sdr.GetString(0).Trim();
                            string gdmethod = sdr.GetString(1).Trim();
                            sdr.Close();
                            Form加工流转单 form = new Form加工流转单(str5, str6, gdmethod, bh, str2, process, str3, nowrole, nx, str);
                            form.raiseCallBackRefreshEvent += new raiseCallBackRefreshDelegate(childfrm_raiseCallBackRefreshEvent); //注册回调事件，也即将子窗体抛出的事件接收，然后处理
                            form.ShowDialog();

                        }
                    }
                    else
                    {
                        MessageBox.Show("所选取的为不同流转单号下的档案，请重新选择");
                    }
                }
                else if (nowrole == "【归还】")
                {

                    int k = 0;
                    int p = 0;
                    bool flag1008 = true;
                    for (int j = 0; j < dataGridView1.RowCount; j++)
                    {

                        if ((bool)dataGridView1.Rows[j].Cells[0].EditedFormattedValue == true && k == 0)
                        {
                            p = j;
                            k++;
                        }
                        if ((bool)dataGridView1.Rows[j].Cells[0].EditedFormattedValue == true && k != 0)
                        {
                            if (dataGridView1.Rows[j].Cells["流转单号"].Value.ToString() != dataGridView1.Rows[p].Cells["流转单号"].Value.ToString())
                            {
                                flag1008 = false;
                            }
                        }
                    }
                    if (flag1008 == true)
                    {
                        int cnt = 0;
                        for (int j = 0; j < dataGridView1.RowCount; j++)
                        {
                            if ((bool)dataGridView1.Rows[j].Cells[0].EditedFormattedValue == true)
                            {
                                cnt++;
                            }
                        }
                        int ss = 0;
                        string[] bh = new string[cnt];
                        for (int j = 0; j < dataGridView1.RowCount; j++)
                        {
                            if ((bool)dataGridView1.Rows[j].Cells[0].EditedFormattedValue == true)
                            {
                                bh[ss++] = dataGridView1.Rows[j].Cells["编号"].Value.ToString();
                            }
                        }
                        int a = dataGridView1.CurrentRow.Index;
                        string str = dataGridView1.Rows[a].Cells["项目号"].Value.ToString();
                        string str3 = dataGridView1.Rows[a].Cells["流转单号"].Value.ToString();
                        string str4 = dataGridView1.Rows[a].Cells["编号"].Value.ToString();
                        string str5 = dataGridView1.Rows[a].Cells["项目单位"].Value.ToString();
                        string str6 = dataGridView1.Rows[a].Cells["档案类型"].Value.ToString();
                        DataTable dt = new AABAL().Select1010(str3, str4);
                        //             DataTable dt = new AABAL().Select100701(str2, str4);
                        string str2 = dt.Rows[0][0].ToString();
                        MySqlDataReader sdr = new WorkBAL().Selectinfo2(str);
                        if (sdr.Read())
                        {
                            string nx = sdr.GetString(0).Trim();
                            string gdmethod = sdr.GetString(1).Trim();
                            sdr.Close();
                            Form加工流转单 form = new Form加工流转单(str5, str6, gdmethod, bh, str2, process, str3, nowrole, nx, str);
                            form.raiseCallBackRefreshEvent += new raiseCallBackRefreshDelegate(childfrm_raiseCallBackRefreshEvent); //注册回调事件，也即将子窗体抛出的事件接收，然后处理
                            form.ShowDialog();

                        }
                    }
                    else
                    {
                        MessageBox.Show("所选取的为不同流转单号下的档案，请重新选择");
                    }
                }
            }
            else
            {
                MessageBox.Show("请先选择档案");
            }
            
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
        /*    if (e.RowIndex >= 0 && e.RowIndex != -1 && !dataGridView1.Rows[e.RowIndex].IsNewRow )
            {
                if (e.ColumnIndex == 0 && nowrole == "【编码】")
                {
                    if ((bool)this.dataGridView1[e.ColumnIndex, e.RowIndex].Value == true)
                    {
                        textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["编号"].Value.ToString();
                    }
                    else
                    {

                    }
                }else
                {
                    this.dataGridView1.Rows[e.RowIndex].Cells["问题描述"].Value = this.dataGridView1.Rows[e.RowIndex].Cells["问题描述"].Value.ToString();
                }
            }*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int river = 0;
            int count = 0;
            int cnt = 0;
            for (int j = 0; j < dataGridView1.RowCount; j++)
            {
                if ((bool)dataGridView1.Rows[j].Cells[0].EditedFormattedValue == true)
                {
                    cnt++;
                    count++;
                    string str = "";
                    string str3 = "";
                    if (nowrole != "【编码】")
                    {
                        str = dataGridView1.Rows[j].Cells["流转单号"].Value.ToString();
                    }
                    string str2 = dataGridView1.Rows[j].Cells["编号"].Value.ToString();
                    DataTable dt = new AABAL().Select1014(str, str2);
                    if((dt.Rows.Count >0))
                    {
                        str3 = dt.Rows[0][0].ToString();//getId
                    }
                    string str5 = dataGridView1.Rows[j].Cells["问题描述"].Value.ToString();
                    if (nowrole == "【拆分】")
                    {
                        // 更改档案状态
                        bool flag2 = new WorkBAL().update2(str3, str2);
                        bool flag3 = new WorkBAL().update101601(str3, str2,str5);
                        if (flag2 == true && flag3 ==true)
                        {
                            river++;
                        }
                    }
                    else if (nowrole == "【著录】")
                    {
                        string str333 = dataGridView1.Rows[j].Cells["流转单号"].Value.ToString();   
                        DataTable dt4 = new AABAL().Select1226(str333);
                        int ss = dt4.Rows.Count;
                        int cntt = 0;
                        for(int i = 0;i<dataGridView1.Rows.Count-1;i++)
                        {
                            if (dataGridView1.Rows[i].Cells["流转单号"].Value.ToString() == str333)
                            {
                                cntt++;
                            }
                        }
                        if(cntt == ss)
                        {
                            // 更改档案状态
                            bool flag2 = new WorkBAL().update13(str3, str2);
                            if (flag2 == true)
                            {
                                river++;
                            }
                        }
                        
                    }
                    else if (nowrole == "【再次著录】")
                    {
                        // 更改档案状态
                        bool flag2 = new WorkBAL().update1225(str3, str2);
                        if (flag2 == true)
                        {
                            river++;
                        }
                    }
                    else if (nowrole == "【编码】")
                    {
                        // 更改档案状态
                        string str4 = dataGridView1.Rows[j].Cells["领取批次号"].Value.ToString();
                        bool flag2 = new WorkBAL().update14(str4, str2);
                        if (flag2 == true)
                        {
                            river++;
                        }
                    }
                    else if (nowrole == "【还原】")
                    {
                        // 更改档案状态
                        bool flag2 = new WorkBAL().update19(str3, str2);
                        if (flag2 == true)
                        {
                            river++;
                        }
                    }
                    else if (nowrole == "【扫描】")
                    {
                        // 更改档案状态
                        bool flag2 = new WorkBAL().update15(str3, str2);
                        if (flag2 == true)
                        {
                            river++;
                        }
                    }
                    else if (nowrole == "【编目】")
                    {
                        // 更改档案状态
                        bool flag2 = new WorkBAL().update2(str3, str2);
                        if (flag2 == true)
                        {
                            river++;
                        }
                    }
                    else if (nowrole == "【图处】")
                    {
                        // 更改档案状态
                        bool flag2 = new WorkBAL().update16(str3, str2);
                        if (flag2 == true)
                        {
                            river++;
                        }
                    }
                    else if (nowrole == "【质检】")
                    {
                        // 更改档案状态
                        bool flag2 = new WorkBAL().update17(str3, str2);
                        if (flag2 == true)
                        {
                            river++;
                        }
                    }
                    else if (nowrole == "【挂接】")
                    {
                        // 更改档案状态
                        bool flag2 = new WorkBAL().update18(str3, str2);
                        if (flag2 == true)
                        {
                            river++;
                        }
                    }
                    else if (nowrole == "【归还】")
                    {
                        // 更改档案状态
                        bool flag2 = new WorkBAL().update20(str3, str2);
                        if (flag2 == true)
                        {
                            river++;
                        }
                    }                
                }
            }
            if(cnt!=0)
            {
                if (river == count)
                {
                    MessageBox.Show("提交成功");
                    dataGridView1.AllowUserToAddRows = false;
                    while (this.dataGridView1.Rows.Count != 0)
                    {
                        this.dataGridView1.Rows.RemoveAt(0);
                    }
                    if (nowrole == "【拆分】")
                    {
                        DataSet ds = new MyWorkBAL().Select(user);
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            DataTable dt4 = new AABAL().Select10041(ds.Tables[0].Rows[i][2].ToString(), nowrole.Substring(1, nowrole.Length - 2));
                            string str = "已";
                            str = str + dt4.Rows[0][0];
                            //  ds.Tables[0].Rows[i]["状态"] = str;
                            ds.Tables[0].Rows[i]["状态"] = "拆分中";
                        }
                        dataGridView1.DataSource = ds.Tables[0];
                        for (int i = 1; i <= 6; i++)
                        {
                            dataGridView1.Columns[i].ReadOnly = true;
                        }
                        process = "拆分";
                    }
                    else if (nowrole == "【著录】")
                    {
                        // btn_zl.Visible = true;
                        btn_sel_all.Visible = true;
                        this.Text = "著录";
                        DataSet ds = new GetJobBAL().Select1015(user);
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            DataTable dt4 = new AABAL().Select10041(ds.Tables[0].Rows[i][2].ToString(), nowrole.Substring(1, nowrole.Length - 2));
                            string str = "已";
                            str = str + dt4.Rows[0][0];
                            //  ds.Tables[0].Rows[i]["状态"] = str;
                            ds.Tables[0].Rows[i]["状态"] = "著录中";
                        }
                        dataGridView1.DataSource = ds.Tables[0];
                        for (int i = 1; i <= 6; i++)
                        {
                            dataGridView1.Columns[i].ReadOnly = true;
                        }
                        process = "著录";
                        // if(cnt == 0)
                        //  {
                        DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                        btn.Name = "btnzl";
                        btn.HeaderText = "著录";
                        btn.DefaultCellStyle.NullValue = "著录";
                        dataGridView1.Columns.Add(btn);
                        cnt = 1;
                        //    }           
                        DataTable dt5 = new AABAL().Select1214();
                        Color color = new Color();
                        color = ColorTranslator.FromHtml("RED");
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            for (int j = 0; j < dt5.Rows.Count; j++)
                            {
                                if (dataGridView1.Rows[i].Cells["流转单号"].Value.ToString() == dt5.Rows[j][0].ToString() && dataGridView1.Rows[i].Cells["编号"].Value.ToString() == dt5.Rows[j][1].ToString())
                                {
                                    for (int x = 0; x < ds.Tables[0].Columns.Count; x++)
                                    {
                                        dataGridView1.Rows[i].Cells[x].Style.ForeColor = color;
                                    }
                                }
                            }
                        }
                    }
                    else if (nowrole == "【再次著录】")
                    {
                        // btn_zl.Visible = true;
                        btn_sel_all.Visible = true;
                        this.Text = "再次著录";
                        DataSet ds = new GetJobBAL().Select122501(user);
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            DataTable dt4 = new AABAL().Select10041(ds.Tables[0].Rows[i][2].ToString(), nowrole.Substring(1, nowrole.Length - 2));
                            string str = "已";
                            str = str + dt4.Rows[0][0];
                            //  ds.Tables[0].Rows[i]["状态"] = str;
                            ds.Tables[0].Rows[i]["状态"] = "著录中";
                        }
                        dataGridView1.DataSource = ds.Tables[0];
                        for (int i = 1; i <= 6; i++)
                        {
                            dataGridView1.Columns[i].ReadOnly = true;
                        }
                        process = "著录";
                        // if(cnt == 0)
                        //  {
                        DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                        btn.Name = "btnczl";
                        btn.HeaderText = "著录";
                        btn.DefaultCellStyle.NullValue = "著录";
                        dataGridView1.Columns.Add(btn);
                        cnt = 1;
                        //    }           
                        DataTable dt5 = new AABAL().Select1214();
                        Color color = new Color();
                        color = ColorTranslator.FromHtml("RED");
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            for (int j = 0; j < dt5.Rows.Count; j++)
                            {
                                if (dataGridView1.Rows[i].Cells["流转单号"].Value.ToString() == dt5.Rows[j][0].ToString() && dataGridView1.Rows[i].Cells["编号"].Value.ToString() == dt5.Rows[j][1].ToString())
                                {
                                    for (int x = 0; x < ds.Tables[0].Columns.Count; x++)
                                    {
                                        dataGridView1.Rows[i].Cells[x].Style.ForeColor = color;
                                    }
                                }
                            }
                        }


                    }
                    else if (nowrole == "【编码】")
                    {
                        DataSet ds = new MyWorkBAL().Select3(user);
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            DataTable dt4 = new AABAL().Select10042001(ds.Tables[0].Rows[i][2].ToString(), nowrole.Substring(1, nowrole.Length - 2));
                            string str = "已";
                            str = str + dt4.Rows[0][0];
                            //   ds.Tables[0].Rows[i]["状态"] = str;
                            ds.Tables[0].Rows[i]["状态"] = "编码中";
                        }
                        dataGridView1.DataSource = ds.Tables[0];
                        for (int i = 1; i <= 6; i++)
                        {
                            dataGridView1.Columns[i].ReadOnly = true;
                        }
                        process = "编码";
                    }
                    else if (nowrole == "【扫描】")
                    {
                        btn_sel_all.Visible = true;
                        DataSet ds = new MyWorkBAL().Select1102(user);
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            DataTable dt4 = new AABAL().Select10042(ds.Tables[0].Rows[i][2].ToString(), nowrole.Substring(1, nowrole.Length - 2));
                            string str = "已";
                            str = str + dt4.Rows[0][0];
                            // ds.Tables[0].Rows[i]["状态"] = str;
                            ds.Tables[0].Rows[i]["状态"] = "扫描中";
                        }
                        dataGridView1.DataSource = ds.Tables[0];
                        for (int i = 1; i <= 6; i++)
                        {
                            dataGridView1.Columns[i].ReadOnly = true;
                        }
                        process = "扫描";
                    }
                    else if (nowrole == "【图处】")
                    {
                        btn_sel_all.Visible = true;
                        DataSet ds = new MyWorkBAL().Select110201(user);
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            DataTable dt4 = new AABAL().Select10042(ds.Tables[0].Rows[i][2].ToString(), nowrole.Substring(1, nowrole.Length - 2));
                            string str = "已";
                            str = str + dt4.Rows[0][0];
                            //   ds.Tables[0].Rows[i]["状态"] = str;
                            ds.Tables[0].Rows[i]["状态"] = "图处中";
                        }
                        dataGridView1.DataSource = ds.Tables[0];
                        for (int i = 1; i <= 6; i++)
                        {
                            dataGridView1.Columns[i].ReadOnly = true;
                        }
                        process = "图处";
                    }
                    else if (nowrole == "【还原11】")
                    {
                        DataSet ds = new MyWorkBAL().Select4();
                        dataGridView1.DataSource = ds.Tables[0];

                    }
                    else if (nowrole == "【质检】")
                    {
                        btn_sel_all.Visible = true;
                        DataSet ds = new MyWorkBAL().Select112001(user);
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            DataTable dt4 = new AABAL().Select10042(ds.Tables[0].Rows[i][2].ToString(), nowrole.Substring(1, nowrole.Length - 2));
                            string str = "已";
                            str = str + dt4.Rows[0][0];
                            //   ds.Tables[0].Rows[i]["状态"] = str;
                            ds.Tables[0].Rows[i]["状态"] = "质检中";
                        }
                        dataGridView1.DataSource = ds.Tables[0];
                        for (int i = 1; i <= 6; i++)
                        {
                            dataGridView1.Columns[i].ReadOnly = true;
                        }
                        process = "质检";
                    }
                    else if (nowrole == "【挂接】")
                    {
                        btn_sel_all.Visible = true;
                        DataSet ds = new MyWorkBAL().Select112002(user);
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            DataTable dt4 = new AABAL().Select10042(ds.Tables[0].Rows[i][2].ToString(), nowrole.Substring(1, nowrole.Length - 2));
                            string str = "已";
                            str = str + dt4.Rows[0][0];
                            //  ds.Tables[0].Rows[i]["状态"] = str;
                            ds.Tables[0].Rows[i]["状态"] = "挂接中";
                        }
                        dataGridView1.DataSource = ds.Tables[0];
                        for (int i = 1; i <= 6; i++)
                        {
                            dataGridView1.Columns[i].ReadOnly = true;
                        }
                        process = "质检";
                    }
                    else if (nowrole == "【还原】")
                    {

                        DataSet ds = new MyWorkBAL().Select112003(user);
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            DataTable dt4 = new AABAL().Select10042(ds.Tables[0].Rows[i][2].ToString(), nowrole.Substring(1, nowrole.Length - 2));
                            string str = "已";
                            str = str + dt4.Rows[0][0];
                            //   ds.Tables[0].Rows[i]["状态"] = str;
                            ds.Tables[0].Rows[i]["状态"] = "还原中";
                        }
                        dataGridView1.DataSource = ds.Tables[0];
                        for (int i = 1; i <= 6; i++)
                        {
                            dataGridView1.Columns[i].ReadOnly = true;
                        }
                        process = "质检";
                    }
                    else if (nowrole == "【归还】")
                    {

                        button5.Visible = true;
                        DataSet ds = new MyWorkBAL().Select112004(user);
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            DataTable dt4 = new AABAL().Select10042(ds.Tables[0].Rows[i][2].ToString(), nowrole.Substring(1, nowrole.Length - 2));
                            string str = "已";
                            str = str + dt4.Rows[0][0];
                            //  ds.Tables[0].Rows[i]["状态"] = str;
                            ds.Tables[0].Rows[i]["状态"] = "归还中";
                        }
                        dataGridView1.DataSource = ds.Tables[0];
                        for (int i = 1; i <= 6; i++)
                        {
                            dataGridView1.Columns[i].ReadOnly = true;
                        }
                        process = "质检";
                    }
                }
                else
                {
                    MessageBox.Show("提交失败");
                }
            }
            else
            {
                MessageBox.Show("请选择要提交的任务");
            }
       
        }



        private void button4_Click(object sender, EventArgs e)
        {
            int river = 0;
            int count = 0;
            int cnt = 0;
            for (int j = 0; j < dataGridView1.RowCount; j++)
            {
                if ((bool)dataGridView1.Rows[j].Cells[0].EditedFormattedValue == true)
                {
                    cnt++;
                    count++;
                    string str = "";
                    if(nowrole != "【编码】")
                    {
                        str = dataGridView1.Rows[j].Cells["流转单号"].Value.ToString();
                    }
                    string str2 = dataGridView1.Rows[j].Cells["编号"].Value.ToString();
                    DataTable dt = new AABAL().Select1014(str, str2);
                    string str3 = dt.Rows[0][0].ToString();//getId
                    string str5 = dataGridView1.Rows[j].Cells["问题描述"].Value.ToString();
                    if (nowrole == "【拆分】")
                    {                     
                         bool flag2 = new WorkBAL().update3(str2, str3);
                         bool flag3 = new WorkBAL().update101601(str3, str2, str5);
                         if (flag2 == true && flag3 == true)
                         {
                            river++;
                         }
                    }
                    else if (nowrole == "【著录】")
                    {
                            bool flag2 = new WorkBAL().update24(str2, str3);
                        bool flag3 = new WorkBAL().update101601(str3, str2, str5);
                        if (flag2 == true && flag3 == true)
                        {
                            river++;
                        }
                    }
                    else if (nowrole == "【再次著录】")
                    {
                        bool flag2 = new WorkBAL().update1225001(str2, str3);
                        bool flag3 = new WorkBAL().update101601(str3, str2, str5);
                        if (flag2 == true && flag3 == true)
                        {
                            river++;
                        }
                    }
                    else if (nowrole == "【编码】")
                    {
                        string str4 = dataGridView1.Rows[j].Cells["领取批次号"].Value.ToString();
                        bool flag3 = new WorkBAL().update101601(str3, str2, str5);
                        river++;
                    }
                    else if (nowrole == "【还原】")
                    {
                            bool flag2 = new WorkBAL().update29(str2, str3);
                        bool flag3 = new WorkBAL().update101601(str3, str2, str5);
                        if (flag2 == true && flag3 == true)
                        {
                            river++;
                        }
                    }
                    else if (nowrole == "【扫描】")
                    {
                            bool flag2 = new WorkBAL().update25(str2, str3);
                        bool flag3 = new WorkBAL().update101601(str3, str2, str5);
                        if (flag2 == true && flag3 == true)
                        {
                            river++;
                        }
                    }
                    else if (nowrole == "【编目】")
                    {
                            bool flag2 = new WorkBAL().update3(str2, str3);
                        bool flag3 = new WorkBAL().update101601(str3, str2, str5);
                        if (flag2 == true && flag3 == true)
                        {
                            river++;
                        }
                    }
                    else if (nowrole == "【图处】")
                    {
                            bool flag2 = new WorkBAL().update26(str2, str3);
                        bool flag3 = new WorkBAL().update101601(str3, str2, str5);
                        if (flag2 == true && flag3 == true)
                        {
                            river++;
                        }
                    }
                    else if (nowrole == "【质检】")
                    {
                            bool flag2 = new WorkBAL().update27(str2, str3);
                        bool flag3 = new WorkBAL().update101601(str3, str2, str5);
                        if (flag2 == true && flag3 == true)
                        {
                            river++;
                        }
                    }
                    else if (nowrole == "【挂接】")
                    {
                            bool flag2 = new WorkBAL().update28(str2, str3);
                        bool flag3 = new WorkBAL().update101601(str3, str2, str5);
                        if (flag2 == true && flag3 == true)
                        {
                            river++;
                        }
                    }
                    else if (nowrole == "【归还】")
                    {
                            bool flag2 = new WorkBAL().update30(str2, str3);
                        bool flag3 = new WorkBAL().update101601(str3, str2, str5);
                        if (flag2 == true && flag3 == true)
                        {
                            river++;
                        }
                    }
                }
            }
            if(cnt!=0)
            {
                if (river == count)
                {
                    MessageBox.Show("退回成功");
                    dataGridView1.AllowUserToAddRows = false;
                    while (this.dataGridView1.Rows.Count != 0)
                    {
                        this.dataGridView1.Rows.RemoveAt(0);
                    }
                    if (nowrole == "【拆分】")
                    {
                        DataSet ds = new MyWorkBAL().Select(user);
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            DataTable dt4 = new AABAL().Select10041(ds.Tables[0].Rows[i][2].ToString(), nowrole.Substring(1, nowrole.Length - 2));
                            string str = "已";
                            str = str + dt4.Rows[0][0];
                            //  ds.Tables[0].Rows[i]["状态"] = str;
                            ds.Tables[0].Rows[i]["状态"] = "拆分中";
                        }
                        dataGridView1.DataSource = ds.Tables[0];
                        for (int i = 1; i <= 6; i++)
                        {
                            dataGridView1.Columns[i].ReadOnly = true;
                        }
                        process = "拆分";
                    }
                    else if (nowrole == "【著录】")
                    {
                        // btn_zl.Visible = true;
                        btn_sel_all.Visible = true;
                        this.Text = "著录";
                        DataSet ds = new GetJobBAL().Select1015(user);
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            DataTable dt4 = new AABAL().Select10041(ds.Tables[0].Rows[i][2].ToString(), nowrole.Substring(1, nowrole.Length - 2));
                            string str = "已";
                            str = str + dt4.Rows[0][0];
                            //  ds.Tables[0].Rows[i]["状态"] = str;
                            ds.Tables[0].Rows[i]["状态"] = "著录中";
                        }
                        dataGridView1.DataSource = ds.Tables[0];
                        for (int i = 1; i <= 6; i++)
                        {
                            dataGridView1.Columns[i].ReadOnly = true;
                        }
                        process = "著录";
                        // if(cnt == 0)
                        //  {
                        DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                        btn.Name = "btnzl";
                        btn.HeaderText = "著录";
                        btn.DefaultCellStyle.NullValue = "著录";
                        dataGridView1.Columns.Add(btn);
                        cnt = 1;
                        //    }           
                        DataTable dt5 = new AABAL().Select1214();
                        Color color = new Color();
                        color = ColorTranslator.FromHtml("RED");
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            for (int j = 0; j < dt5.Rows.Count; j++)
                            {
                                if (dataGridView1.Rows[i].Cells["流转单号"].Value.ToString() == dt5.Rows[j][0].ToString() && dataGridView1.Rows[i].Cells["编号"].Value.ToString() == dt5.Rows[j][1].ToString())
                                {
                                    for (int x = 0; x < ds.Tables[0].Columns.Count; x++)
                                    {
                                        dataGridView1.Rows[i].Cells[x].Style.ForeColor = color;
                                    }
                                }
                            }
                        }
                    }
                    else if (nowrole == "【再次著录】")
                    {
                        // btn_zl.Visible = true;
                        btn_sel_all.Visible = true;
                        this.Text = "再次著录";
                        DataSet ds = new GetJobBAL().Select122501(user);
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            DataTable dt4 = new AABAL().Select10041(ds.Tables[0].Rows[i][2].ToString(), nowrole.Substring(1, nowrole.Length - 2));
                            string str = "已";
                            str = str + dt4.Rows[0][0];
                            //  ds.Tables[0].Rows[i]["状态"] = str;
                            ds.Tables[0].Rows[i]["状态"] = "著录中";
                        }
                        dataGridView1.DataSource = ds.Tables[0];
                        for (int i = 1; i <= 6; i++)
                        {
                            dataGridView1.Columns[i].ReadOnly = true;
                        }
                        process = "著录";
                        // if(cnt == 0)
                        //  {
                        DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn();
                        btn1.Name = "btnczl";
                        btn1.HeaderText = "著录";
                        btn1.DefaultCellStyle.NullValue = "著录11";
                        dataGridView1.Columns.Add(btn1);
                        cnt = 1;
                        //    }           
                        DataTable dt5 = new CZLBAL().Select1214();
                        Color color = new Color();
                        color = ColorTranslator.FromHtml("RED");
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            for (int j = 0; j < dt5.Rows.Count; j++)
                            {
                                if (dataGridView1.Rows[i].Cells["流转单号"].Value.ToString() == dt5.Rows[j][0].ToString() && dataGridView1.Rows[i].Cells["编号"].Value.ToString() == dt5.Rows[j][1].ToString())
                                {
                                    for (int x = 0; x < ds.Tables[0].Columns.Count; x++)
                                    {
                                        dataGridView1.Rows[i].Cells[x].Style.ForeColor = color;
                                    }
                                }
                            }
                        }


                    }
                    else if (nowrole == "【编码】")
                    {
                        DataSet ds = new MyWorkBAL().Select3(user);
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            DataTable dt4 = new AABAL().Select10042001(ds.Tables[0].Rows[i][2].ToString(), nowrole.Substring(1, nowrole.Length - 2));
                            string str = "已";
                            str = str + dt4.Rows[0][0];
                            //   ds.Tables[0].Rows[i]["状态"] = str;
                            ds.Tables[0].Rows[i]["状态"] = "编码中";
                        }
                        dataGridView1.DataSource = ds.Tables[0];
                        for (int i = 1; i <= 6; i++)
                        {
                            dataGridView1.Columns[i].ReadOnly = true;
                        }
                        process = "编码";
                    }
                    else if (nowrole == "【扫描】")
                    {
                        btn_sel_all.Visible = true;
                        DataSet ds = new MyWorkBAL().Select1102(user);
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            DataTable dt4 = new AABAL().Select10042(ds.Tables[0].Rows[i][2].ToString(), nowrole.Substring(1, nowrole.Length - 2));
                            string str = "已";
                            str = str + dt4.Rows[0][0];
                            // ds.Tables[0].Rows[i]["状态"] = str;
                            ds.Tables[0].Rows[i]["状态"] = "扫描中";
                        }
                        dataGridView1.DataSource = ds.Tables[0];
                        for (int i = 1; i <= 6; i++)
                        {
                            dataGridView1.Columns[i].ReadOnly = true;
                        }
                        process = "扫描";
                    }
                    else if (nowrole == "【图处】")
                    {
                        btn_sel_all.Visible = true;
                        DataSet ds = new MyWorkBAL().Select110201(user);
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            DataTable dt4 = new AABAL().Select10042(ds.Tables[0].Rows[i][2].ToString(), nowrole.Substring(1, nowrole.Length - 2));
                            string str = "已";
                            str = str + dt4.Rows[0][0];
                            //   ds.Tables[0].Rows[i]["状态"] = str;
                            ds.Tables[0].Rows[i]["状态"] = "图处中";
                        }
                        dataGridView1.DataSource = ds.Tables[0];
                        for (int i = 1; i <= 6; i++)
                        {
                            dataGridView1.Columns[i].ReadOnly = true;
                        }
                        process = "图处";
                    }
                    else if (nowrole == "【还原11】")
                    {
                        DataSet ds = new MyWorkBAL().Select4();
                        dataGridView1.DataSource = ds.Tables[0];

                    }
                    else if (nowrole == "【质检】")
                    {
                        btn_sel_all.Visible = true;
                        DataSet ds = new MyWorkBAL().Select112001(user);
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            DataTable dt4 = new AABAL().Select10042(ds.Tables[0].Rows[i][2].ToString(), nowrole.Substring(1, nowrole.Length - 2));
                            string str = "已";
                            str = str + dt4.Rows[0][0];
                            //   ds.Tables[0].Rows[i]["状态"] = str;
                            ds.Tables[0].Rows[i]["状态"] = "质检中";
                        }
                        dataGridView1.DataSource = ds.Tables[0];
                        for (int i = 1; i <= 6; i++)
                        {
                            dataGridView1.Columns[i].ReadOnly = true;
                        }
                        process = "质检";
                    }
                    else if (nowrole == "【挂接】")
                    {
                        btn_sel_all.Visible = true;
                        DataSet ds = new MyWorkBAL().Select112002(user);
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            DataTable dt4 = new AABAL().Select10042(ds.Tables[0].Rows[i][2].ToString(), nowrole.Substring(1, nowrole.Length - 2));
                            string str = "已";
                            str = str + dt4.Rows[0][0];
                            //  ds.Tables[0].Rows[i]["状态"] = str;
                            ds.Tables[0].Rows[i]["状态"] = "挂接中";
                        }
                        dataGridView1.DataSource = ds.Tables[0];
                        for (int i = 1; i <= 6; i++)
                        {
                            dataGridView1.Columns[i].ReadOnly = true;
                        }
                        process = "质检";
                    }
                    else if (nowrole == "【还原】")
                    {

                        DataSet ds = new MyWorkBAL().Select112003(user);
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            DataTable dt4 = new AABAL().Select10042(ds.Tables[0].Rows[i][2].ToString(), nowrole.Substring(1, nowrole.Length - 2));
                            string str = "已";
                            str = str + dt4.Rows[0][0];
                            //   ds.Tables[0].Rows[i]["状态"] = str;
                            ds.Tables[0].Rows[i]["状态"] = "还原中";
                        }
                        dataGridView1.DataSource = ds.Tables[0];
                        for (int i = 1; i <= 6; i++)
                        {
                            dataGridView1.Columns[i].ReadOnly = true;
                        }
                        process = "还原";
                    }
                    else if (nowrole == "【归还】")
                    {

                        button5.Visible = true;
                        DataSet ds = new MyWorkBAL().Select112004(user);
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            DataTable dt4 = new AABAL().Select10042(ds.Tables[0].Rows[i][2].ToString(), nowrole.Substring(1, nowrole.Length - 2));
                            string str = "已";
                            str = str + dt4.Rows[0][0];
                            //  ds.Tables[0].Rows[i]["状态"] = str;
                            ds.Tables[0].Rows[i]["状态"] = "归还中";
                        }
                        dataGridView1.DataSource = ds.Tables[0];
                        for (int i = 1; i <= 6; i++)
                        {
                            dataGridView1.Columns[i].ReadOnly = true;
                        }
                        process = "归还";
                    }
                }
                else
                {
                    MessageBox.Show("退回失败");
                }
            }
            else
            {
                MessageBox.Show("请选择要退回的任务");
            }
         
        }

        private void btn_zl_Click(object sender, EventArgs e)
        {
            int count = dataGridView1.Rows.Count;
            for (int i = 0; i < count; i++)
            {
                if ((bool)dataGridView1.Rows[i].Cells[0].EditedFormattedValue == true)
                {
                    string str = dataGridView1.Rows[i].Cells["项目号"].Value.ToString();
                    string str2 = dataGridView1.Rows[i].Cells["编号"].Value.ToString();
                    string str3 = dataGridView1.Rows[i].Cells["流转单号"].Value.ToString();
                    Form著录3 f = new Form著录3(str, str2,str3);
                    this.Hide();
                    f.ShowDialog();
                    this.Close();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex != -1 && !dataGridView1.Rows[e.RowIndex].IsNewRow)
            {
                if (e.ColumnIndex == 0 && nowrole == "【编码】")
                {
                    if (this.dataGridView1.Rows[e.RowIndex].Cells[0].EditedFormattedValue.ToString() == "True")
                    {
                        textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["编号"].Value.ToString();
                    }
                    else
                    {

                    }
                }
                else
                {
                    this.dataGridView1.Rows[e.RowIndex].Cells["问题描述"].Value = this.dataGridView1.Rows[e.RowIndex].Cells["问题描述"].Value.ToString();
                }
                if (e.ColumnIndex == 0&& nowrole != "【编码】")
                {
                    if(this.dataGridView1.Rows[e.RowIndex].Cells[0].EditedFormattedValue.ToString() == "True")
                    {
                        string a = this.dataGridView1.Rows[e.RowIndex].Cells["流转单号"].Value.ToString();
                        for(int i=0;i<dataGridView1.RowCount-1;i++)
                        {

                            if(a == dataGridView1.Rows[i].Cells[1].Value.ToString())
                            {
                                dataGridView1.Rows[i].Cells[0].Value = true;
                            }             
                            else
                            {
                                dataGridView1.Rows[i].Cells[0].Value = false;
                            }
                        }
                    }
                    if (this.dataGridView1.Rows[e.RowIndex].Cells[0].EditedFormattedValue.ToString() == "False")
                    {
                        string a = this.dataGridView1.Rows[e.RowIndex].Cells["流转单号"].Value.ToString();
                        for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                        {

                            if (a == dataGridView1.Rows[i].Cells[1].Value.ToString())
                                dataGridView1.Rows[i].Cells[0].Value = false;
                        }
                    }
                }
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "btnzl" && e.RowIndex >= 0)
            {
                string str = dataGridView1.Rows[e.RowIndex].Cells["项目号"].Value.ToString();
                string str2 = dataGridView1.Rows[e.RowIndex].Cells["编号"].Value.ToString();
                string str3 = dataGridView1.Rows[e.RowIndex].Cells["流转单号"].Value.ToString();
                DataTable dt = new ZLBAL().Select114(str3,str2);
                if (dt.Rows.Count != 0)
                {
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        MessageBox.Show("已著录！");
                    }
                    else
                    {
                        Form著录3 f = new Form著录3(str, str2, str3);
                        f.raiseCallBackRefreshEvent2 += new raiseCallBackRefreshDelegate2(childfrm_raiseCallBackRefreshEvent2); //注册回调事件，也即将子窗体抛出的事件接收，然后处理
                        f.ShowDialog();
                    }
                }
                else
                {
                    Form著录3 f = new Form著录3(str, str2, str3);
                    f.raiseCallBackRefreshEvent2 += new raiseCallBackRefreshDelegate2(childfrm_raiseCallBackRefreshEvent2); //注册回调事件，也即将子窗体抛出的事件接收，然后处理
                    f.ShowDialog();
                }
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "btnczl" && e.RowIndex >= 0)
            {
                string str = dataGridView1.Rows[e.RowIndex].Cells["项目号"].Value.ToString();
                string str2 = dataGridView1.Rows[e.RowIndex].Cells["编号"].Value.ToString();
                string str3 = dataGridView1.Rows[e.RowIndex].Cells["流转单号"].Value.ToString();
                DataTable dt = new CZLBAL().Select114(str3, str2);
                if (dt.Rows.Count != 0)
                {
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        MessageBox.Show("已著录！");
                    }
                    else
                    {
                        Form再次著录 f = new Form再次著录(str, str2, str3);
                        f.raiseCallBackRefreshEvent3 += new raiseCallBackRefreshDelegate3(childfrm_raiseCallBackRefreshEvent2); //注册回调事件，也即将子窗体抛出的事件接收，然后处理
                        f.ShowDialog();
                    }
                }
                else
                {
                    Form再次著录 f = new Form再次著录(str, str2, str3);
                    f.raiseCallBackRefreshEvent3 += new raiseCallBackRefreshDelegate3(childfrm_raiseCallBackRefreshEvent2); //注册回调事件，也即将子窗体抛出的事件接收，然后处理
                    f.ShowDialog();
                }
            }

        }

        private void btn_sel_all_Click(object sender, EventArgs e)
        {
            int n = 0;
            int count = dataGridView1.Rows.Count;
            for (int i = 0; i < count; i++)
            {
                if ((bool)dataGridView1.Rows[i].Cells[0].EditedFormattedValue == true && n == 0)
                {
                    n++;
                    string str = dataGridView1.Rows[i].Cells["流转单号"].Value.ToString();
                    string str2 = dataGridView1.Rows[i].Cells["编号"].Value.ToString();
                    if (nowrole == "【著录】")
                    {
                        Form著录信息管理 f = new Form著录信息管理(str, str2);
                        this.Hide();
                        f.ShowDialog();
                        this.Close();
                    }
                    else if (nowrole == "【扫描】")
                    {
                        Form扫描管理 f = new Form扫描管理(str, str2);
                        this.Hide();
                        f.ShowDialog();
                        this.Close();
                    }
                    else if (nowrole == "【图处】")
                    {

                        Form图处管理 f = new Form图处管理(str, str2);
                        this.Hide();
                        f.ShowDialog();
                        this.Close();
                    }
                    else if (nowrole == "【质检】")
                    {

                        Form质检管理 f = new Form质检管理(str, str2);
                        this.Hide();
                        f.ShowDialog();
                        this.Close();
                    }
                    else if (nowrole == "【挂接】")
                    {

                        Form挂接管理 f = new Form挂接管理(str, str2);
                        this.Hide();
                        f.ShowDialog();
                        this.Close();
                    }
                }
            }
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

            if (e.ColumnIndex == 1 && e.RowIndex != -1)
            {
                Brush datagridBrush = new SolidBrush(dataGridView1.GridColor);
                SolidBrush groupLineBrush = new SolidBrush(e.CellStyle.BackColor);
                using (Pen datagridLinePen = new Pen(datagridBrush))
                {
                    // 清除单元格
                    e.Graphics.FillRectangle(groupLineBrush, e.CellBounds);
                    if (e.RowIndex < dataGridView1.Rows.Count - 1 && dataGridView1.Rows[e.RowIndex + 1].Cells[e.ColumnIndex].Value != null && dataGridView1.Rows[e.RowIndex + 1].Cells[e.ColumnIndex].Value.ToString() != e.Value.ToString())
                    {
                        //绘制底边线
                        e.Graphics.DrawLine(datagridLinePen, e.CellBounds.Left, e.CellBounds.Bottom - 1, e.CellBounds.Right, e.CellBounds.Bottom - 1);
                        // 画右边线
                        e.Graphics.DrawLine(datagridLinePen, e.CellBounds.Right - 1, e.CellBounds.Top, e.CellBounds.Right - 1, e.CellBounds.Bottom);
                    }
                    else
                    {
                        // 画右边线
                        e.Graphics.DrawLine(datagridLinePen, e.CellBounds.Right - 1, e.CellBounds.Top, e.CellBounds.Right - 1, e.CellBounds.Bottom);
                    }
                    //对最后一条记录只画底边线
                    if (e.RowIndex == dataGridView1.Rows.Count - 1)
                    {
                        //绘制底边线
                        e.Graphics.DrawLine(datagridLinePen, e.CellBounds.Left, e.CellBounds.Bottom - 1, e.CellBounds.Right, e.CellBounds.Bottom - 1);
                    }
                    // 填写单元格内容，相同的内容的单元格只填写第一个                        
                    if (e.Value != null)
                    {
                        if (!(e.RowIndex > 0 && dataGridView1.Rows[e.RowIndex - 1].Cells[e.ColumnIndex].Value.ToString() == e.Value.ToString()))
                        {
                            //绘制单元格内容
                            e.Graphics.DrawString(e.Value.ToString(), e.CellStyle.Font, Brushes.Black, e.CellBounds.X + 2, e.CellBounds.Y + 5, StringFormat.GenericDefault);
                        }
                    }
                    e.Handled = true;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a = dataGridView1.CurrentRow.Index;
            string str = dataGridView1.Rows[a].Cells["项目号"].Value.ToString();
            string str3 = dataGridView1.Rows[a].Cells["流转单号"].Value.ToString();
            string str4 = dataGridView1.Rows[a].Cells["编号"].Value.ToString();
            string str5 = dataGridView1.Rows[a].Cells["项目单位"].Value.ToString();
            string str6 = dataGridView1.Rows[a].Cells["档案类型"].Value.ToString();
            DataTable dt = new AABAL().Select1121(str);
            Form归还交接单 f = new Form归还交接单(str5, str6, dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(),str);
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
    }
}
