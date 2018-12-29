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
    public partial class Form待加工档案 : Form
    {
        public Form待加工档案()
        {
            InitializeComponent();
        }
        string process = "";
        string nowrole = "";
        string user = "";
        public Form待加工档案(string str1) : this()
        {
            string[] sp = str1.Split('-');
            this.nowrole = sp[0];
            this.user = sp[1];
        }

        private void Form待加工档案_Load(object sender, EventArgs e)
        {
            if (nowrole != "【编码】")
            {
                this.label1.Visible = false;
                this.label2.Visible = false;
                this.textBox1.Visible = false;
                this.textBox2.Visible = false;
                this.button4.Text = "刷新流转单";
            }
            if (nowrole == "【拆分】")
            {
                this.Text = "拆分";
                DataSet ds = new GetJobBAL().Select2();
               for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    DataTable dt4 = new AABAL().Select10041(ds.Tables[0].Rows[i][2].ToString(), nowrole.Substring(1, nowrole.Length - 2)); 
                    string str = "已";
                    str = str + dt4.Rows[0][0];
                    ds.Tables[0].Rows[i]["状态"] = str;     
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
                this.Text = "著录";
                DataSet ds = new GetJobBAL().Select3();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    DataTable dt4 = new AABAL().Select10041(ds.Tables[0].Rows[i][2].ToString(), nowrole.Substring(1, nowrole.Length - 2));
                    string str = "已";
                    str = str + dt4.Rows[0][0];
                    ds.Tables[0].Rows[i]["状态"] = str;
                }
                dataGridView1.DataSource = ds.Tables[0];
                for (int i = 1; i <= 6; i++)
                {
                    dataGridView1.Columns[i].ReadOnly = true;
                }
                process = "著录";
            }
            else if (nowrole == "【再次著录】")
            {
                this.Text = "再次著录";
                DataSet ds = new GetJobBAL().Select1225();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    DataTable dt4 = new AABAL().Select10041(ds.Tables[0].Rows[i][2].ToString(), nowrole.Substring(1, nowrole.Length - 2));
                    string str = "已";
                    str = str + dt4.Rows[0][0];
                    ds.Tables[0].Rows[i]["状态"] = str;
                }
                dataGridView1.DataSource = ds.Tables[0];
                for (int i = 1; i <= 6; i++)
                {
                    dataGridView1.Columns[i].ReadOnly = true;
                }
                process = "著录";
            }
            else if (nowrole == "【编码】")
            {
                this.Text = "编码";
                DataSet ds = new GetJobBAL().Select4();

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    DataTable dt4 = new AABAL().Select10042(ds.Tables[0].Rows[i][2].ToString(), nowrole.Substring(1, nowrole.Length - 2));
                    string str = "已";
                    str = str + dt4.Rows[0][0];
                    ds.Tables[0].Rows[i]["状态"] = str;
                }
                dataGridView1.DataSource = ds.Tables[0];
                for (int i = 1; i <= 6; i++)
                {
                    dataGridView1.Columns[i].ReadOnly = true;
                }
                process = "打码";
            }
            else if (nowrole == "【还原】")
            {
                this.Text = "还原";
                DataSet ds = new GetJobBAL().Select9();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    DataTable dt4 = new AABAL().Select10041(ds.Tables[0].Rows[i][2].ToString(), nowrole.Substring(1, nowrole.Length - 2));
                    string str = "已";
                    str = str + dt4.Rows[0][0];
                    ds.Tables[0].Rows[i]["状态"] = str;
                }
                dataGridView1.DataSource = ds.Tables[0];
                for (int i = 1; i <= 6; i++)
                {
                    dataGridView1.Columns[i].ReadOnly = true;
                }
                process = "还原";
            }
            else if (nowrole == "【扫描】")
            {
                this.Text = "扫描";
                DataSet ds = new GetJobBAL().Select5();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    DataTable dt4 = new AABAL().Select10041(ds.Tables[0].Rows[i][2].ToString(), nowrole.Substring(1, nowrole.Length - 2));
                    string str = "已";
                    str = str + dt4.Rows[0][0];
                    ds.Tables[0].Rows[i]["状态"] = str;
                }
                dataGridView1.DataSource = ds.Tables[0];
                for (int i = 1; i <= 6; i++)
                {
                    dataGridView1.Columns[i].ReadOnly = true;
                }
                process = "扫描";
            }
            else if (nowrole == "【编目】")
            {
                this.Text = "编目";
                DataSet ds = new GetJobBAL().Select7();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    DataTable dt4 = new AABAL().Select10041(ds.Tables[0].Rows[i][2].ToString(), nowrole.Substring(1, nowrole.Length - 2));
                    string str = "已";
                    str = str + dt4.Rows[0][0];
                    ds.Tables[0].Rows[i]["状态"] = str;
                }
                dataGridView1.DataSource = ds.Tables[0];
                for (int i = 1; i <= 6; i++)
                {
                    dataGridView1.Columns[i].ReadOnly = true;
                }
                process = "编目";
            }
            else if (nowrole == "【图处】")
            {
                this.Text = "图处";
                DataSet ds = new GetJobBAL().Select6();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    DataTable dt4 = new AABAL().Select10041(ds.Tables[0].Rows[i][2].ToString(), nowrole.Substring(1, nowrole.Length - 2));
                    string str = "已";
                    str = str + dt4.Rows[0][0];
                    ds.Tables[0].Rows[i]["状态"] = str;
                }
                dataGridView1.DataSource = ds.Tables[0];
                for (int i = 1; i <= 6; i++)
                {
                    dataGridView1.Columns[i].ReadOnly = true;
                }
                process = "图处";
            }
            else if (nowrole == "【质检】")
            {
                this.Text = "质检";
                DataSet ds = new GetJobBAL().Select7();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    DataTable dt4 = new AABAL().Select10041(ds.Tables[0].Rows[i][2].ToString(), nowrole.Substring(1, nowrole.Length - 2));
                    string str = "已";
                    str = str + dt4.Rows[0][0];
                    ds.Tables[0].Rows[i]["状态"] = str;
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
                this.Text = "挂接";
                DataSet ds = new GetJobBAL().Select8();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    DataTable dt4 = new AABAL().Select10041(ds.Tables[0].Rows[i][2].ToString(), nowrole.Substring(1, nowrole.Length - 2));
                    string str = "已";
                    str = str + dt4.Rows[0][0];
                    ds.Tables[0].Rows[i]["状态"] = str;
                }
                dataGridView1.DataSource = ds.Tables[0];
                for (int i = 1; i <= 6; i++)
                {
                    dataGridView1.Columns[i].ReadOnly = true;
                }
                process = "挂接";
            }
            else if (nowrole == "【归还】")
            {
                this.Text = "归还";
                DataSet ds = new GetJobBAL().Select10();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    DataTable dt4 = new AABAL().Select10041(ds.Tables[0].Rows[i][2].ToString(), nowrole.Substring(1, nowrole.Length - 2));
                    string str = "已";
                    str = str + dt4.Rows[0][0];
                    ds.Tables[0].Rows[i]["状态"] = str;
                }
                dataGridView1.DataSource = ds.Tables[0];
                for (int i = 1; i <= 6; i++)
                {
                    dataGridView1.Columns[i].ReadOnly = true;
                }
                process = "归还";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (nowrole == "【拆分】")
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
                }else
                {
                    MessageBox.Show("所选取的为不同流转单号下的档案，请重新选择");
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
                            Form加工流转单 form = new Form加工流转单(str5, str6, gdmethod, bh, str2, process, str3, nowrole, nx, str);
                            form.raiseCallBackRefreshEvent += new raiseCallBackRefreshDelegate(childfrm_raiseCallBackRefreshEvent); //注册回调事件，也即将子窗体抛出的事件接收，然后处理
                            form.ShowDialog();

                        }
                    }
                    else
                    {
                        MessageBox.Show("所选取的为不同批次下的档案，请重新选择");
                    }
                }
                else
                {
                    int begin = Convert.ToInt32(textBox1.Text.ToString());
                    int end = Convert.ToInt32(textBox2.Text.ToString());
                    int count =  end - begin;
                    string[] bh =new string[count+1];
                    int ccc = 0;
                    for(int i = begin; i<=end; i++)
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
                        Form加工流转单 form = new Form加工流转单(str5, str6, gdmethod, bh, str2, process, str3, nowrole, nx, str);
                        form.raiseCallBackRefreshEvent += new raiseCallBackRefreshDelegate(childfrm_raiseCallBackRefreshEvent); //注册回调事件，也即将子窗体抛出的事件接收，然后处理
                        form.ShowDialog();

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
        private void childfrm_raiseCallBackRefreshEvent()
        {
            Form待加工档案_Load(null, null); //刷新主窗体
        }

       private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
                
                if (e.ColumnIndex == 3 && e.RowIndex != -1)
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
          
                }
                if (e.ColumnIndex == 0 && nowrole != "【编码】")
                {
                    if (this.dataGridView1.Rows[e.RowIndex].Cells[0].EditedFormattedValue.ToString() == "True")
                    {
                        string a = this.dataGridView1.Rows[e.RowIndex].Cells["流转单号"].Value.ToString();
                        for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                        {

                            if (a == dataGridView1.Rows[i].Cells[1].Value.ToString())
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
            }

        private void button1_Click(object sender, EventArgs e)
        {
            Form我的任务 form = new Form我的任务(nowrole,user);
            //this.Hide();
            form.ShowDialog();
            //this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (nowrole != "【编码】")
            {
                int cnt1 = 0;
                int cnt2 = 0;
                int cnt3 = 0;
                for (int j = 0; j < dataGridView1.RowCount; j++)
                {
                    if ((bool)dataGridView1.Rows[j].Cells[0].EditedFormattedValue == true)
                    {
                        cnt3++;
                        cnt1++;
                        string str = dataGridView1.Rows[j].Cells["流转单号"].Value.ToString();
                        string str2 = dataGridView1.Rows[j].Cells["编号"].Value.ToString();
                        DataTable dt = new AABAL().Select1014(str, str2);
                        string str3 = dt.Rows[0][0].ToString();
                        if (nowrole == "【拆分】")
                        {
                            bool flag = new AABAL().update1014(str3, str2, user);
                            if (flag == true) cnt2++;
                        }
                        else if (nowrole == "【编码】")
                        {
                            bool flag = new AABAL().update101501(str3, str2, user);
                            if (flag == true) cnt2++;
                        }
                        else if (nowrole == "【著录】")
                        {
                            bool flag = new AABAL().update101502(str3, str2, user);
                            if (flag == true) cnt2++;
                        }
                        else if (nowrole == "【再次著录】")
                        {
                            bool flag = new AABAL().update1225(str3, str2, user);
                            if (flag == true) cnt2++;
                        }
                        else if (nowrole == "【归还】")
                        {
                            bool flag = new AABAL().update101508(str3, str2, user);
                            if (flag == true) cnt2++;
                        }
                        else if (nowrole == "【还原】")
                        {
                            bool flag = new AABAL().update101507(str3, str2, user);
                            if (flag == true) cnt2++;
                        }
                        else if (nowrole == "【扫描】")
                        {
                            bool flag = new AABAL().update101503(str3, str2, user);
                            if (flag == true) cnt2++;
                        }
                        else if (nowrole == "【图处】")
                        {
                            bool flag = new AABAL().update101504(str3, str2, user);
                            if (flag == true) cnt2++;
                        }
                        else if (nowrole == "【质检】")
                        {
                            bool flag = new AABAL().update101505(str3, str2, user);
                            if (flag == true) cnt2++;
                        }
                        else if (nowrole == "【挂接】")
                        {
                            bool flag = new AABAL().update101506(str3, str2, user);
                            if (flag == true) cnt2++;
                        }
                    }
                }
                if(cnt3!= 0)
                {
                    if (cnt1 == cnt2)
                    {
                        MessageBox.Show("领取成功");
                        dataGridView1.AllowUserToAddRows = false;

                        while (this.dataGridView1.Rows.Count != 0)
                        {
                            this.dataGridView1.Rows.RemoveAt(0);
                        }
                        if (nowrole != "【编码】")
                        {
                            this.label1.Visible = false;
                            this.label2.Visible = false;
                            this.textBox1.Visible = false;
                            this.textBox2.Visible = false;
                            this.button4.Text = "刷新流转单";
                        }
                        if (nowrole == "【拆分】")
                        {
                            this.Text = "拆分";
                            DataSet ds = new GetJobBAL().Select2();
                            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                            {
                                DataTable dt4 = new AABAL().Select10041(ds.Tables[0].Rows[i][2].ToString(), nowrole.Substring(1, nowrole.Length - 2));
                                string str = "已";
                                str = str + dt4.Rows[0][0];
                                ds.Tables[0].Rows[i]["状态"] = str;
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
                            this.Text = "著录";
                            DataSet ds = new GetJobBAL().Select3();
                            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                            {
                                DataTable dt4 = new AABAL().Select10041(ds.Tables[0].Rows[i][2].ToString(), nowrole.Substring(1, nowrole.Length - 2));
                                string str = "已";
                                str = str + dt4.Rows[0][0];
                                ds.Tables[0].Rows[i]["状态"] = str;
                            }
                            dataGridView1.DataSource = ds.Tables[0];
                            for (int i = 1; i <= 6; i++)
                            {
                                dataGridView1.Columns[i].ReadOnly = true;
                            }
                            process = "著录";
                        }
                        else if (nowrole == "【再次著录】")
                        {
                            this.Text = "著录";
                            DataSet ds = new GetJobBAL().Select1225();
                            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                            {
                                DataTable dt4 = new AABAL().Select10041(ds.Tables[0].Rows[i][2].ToString(), nowrole.Substring(1, nowrole.Length - 2));
                                string str = "已";
                                str = str + dt4.Rows[0][0];
                                ds.Tables[0].Rows[i]["状态"] = str;
                            }
                            dataGridView1.DataSource = ds.Tables[0];
                            for (int i = 1; i <= 6; i++)
                            {
                                dataGridView1.Columns[i].ReadOnly = true;
                            }
                            process = "著录";
                        }
                        else if (nowrole == "【编码】")
                        {
                            this.Text = "编码";
                            DataSet ds = new GetJobBAL().Select4();

                            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                            {
                                DataTable dt4 = new AABAL().Select10042(ds.Tables[0].Rows[i][2].ToString(), nowrole.Substring(1, nowrole.Length - 2));
                                string str = "已";
                                str = str + dt4.Rows[0][0];
                                ds.Tables[0].Rows[i]["状态"] = str;
                            }
                            dataGridView1.DataSource = ds.Tables[0];
                            for (int i = 1; i <= 6; i++)
                            {
                                dataGridView1.Columns[i].ReadOnly = true;
                            }
                            process = "打码";
                        }
                        else if (nowrole == "【还原】")
                        {
                            this.Text = "还原";
                            DataSet ds = new GetJobBAL().Select9();
                            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                            {
                                DataTable dt4 = new AABAL().Select10041(ds.Tables[0].Rows[i][2].ToString(), nowrole.Substring(1, nowrole.Length - 2));
                                string str = "已";
                                str = str + dt4.Rows[0][0];
                                ds.Tables[0].Rows[i]["状态"] = str;
                            }
                            dataGridView1.DataSource = ds.Tables[0];
                            for (int i = 1; i <= 6; i++)
                            {
                                dataGridView1.Columns[i].ReadOnly = true;
                            }
                            process = "还原";
                        }
                        else if (nowrole == "【扫描】")
                        {
                            this.Text = "扫描";
                            DataSet ds = new GetJobBAL().Select5();
                            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                            {
                                DataTable dt4 = new AABAL().Select10041(ds.Tables[0].Rows[i][2].ToString(), nowrole.Substring(1, nowrole.Length - 2));
                                string str = "已";
                                str = str + dt4.Rows[0][0];
                                ds.Tables[0].Rows[i]["状态"] = str;
                            }
                            dataGridView1.DataSource = ds.Tables[0];
                            for (int i = 1; i <= 6; i++)
                            {
                                dataGridView1.Columns[i].ReadOnly = true;
                            }
                            process = "扫描";
                        }
                        else if (nowrole == "【编目】")
                        {
                            this.Text = "编目";
                            DataSet ds = new GetJobBAL().Select7();
                            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                            {
                                DataTable dt4 = new AABAL().Select10041(ds.Tables[0].Rows[i][2].ToString(), nowrole.Substring(1, nowrole.Length - 2));
                                string str = "已";
                                str = str + dt4.Rows[0][0];
                                ds.Tables[0].Rows[i]["状态"] = str;
                            }
                            dataGridView1.DataSource = ds.Tables[0];
                            for (int i = 1; i <= 6; i++)
                            {
                                dataGridView1.Columns[i].ReadOnly = true;
                            }
                            process = "编目";
                        }
                        else if (nowrole == "【图处】")
                        {
                            this.Text = "图处";
                            DataSet ds = new GetJobBAL().Select6();
                            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                            {
                                DataTable dt4 = new AABAL().Select10041(ds.Tables[0].Rows[i][2].ToString(), nowrole.Substring(1, nowrole.Length - 2));
                                string str = "已";
                                str = str + dt4.Rows[0][0];
                                ds.Tables[0].Rows[i]["状态"] = str;
                            }
                            dataGridView1.DataSource = ds.Tables[0];
                            for (int i = 1; i <= 6; i++)
                            {
                                dataGridView1.Columns[i].ReadOnly = true;
                            }
                            process = "图处";
                        }
                        else if (nowrole == "【质检】")
                        {
                            this.Text = "质检";
                            DataSet ds = new GetJobBAL().Select7();
                            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                            {
                                DataTable dt4 = new AABAL().Select10041(ds.Tables[0].Rows[i][2].ToString(), nowrole.Substring(1, nowrole.Length - 2));
                                string str = "已";
                                str = str + dt4.Rows[0][0];
                                ds.Tables[0].Rows[i]["状态"] = str;
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
                            this.Text = "挂接";
                            DataSet ds = new GetJobBAL().Select8();
                            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                            {
                                DataTable dt4 = new AABAL().Select10041(ds.Tables[0].Rows[i][2].ToString(), nowrole.Substring(1, nowrole.Length - 2));
                                string str = "已";
                                str = str + dt4.Rows[0][0];
                                ds.Tables[0].Rows[i]["状态"] = str;
                            }
                            dataGridView1.DataSource = ds.Tables[0];
                            for (int i = 1; i <= 6; i++)
                            {
                                dataGridView1.Columns[i].ReadOnly = true;
                            }
                            process = "挂接";
                        }
                        else if (nowrole == "【归还】")
                        {
                            this.Text = "归还";
                            DataSet ds = new GetJobBAL().Select10();
                            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                            {
                                DataTable dt4 = new AABAL().Select10041(ds.Tables[0].Rows[i][2].ToString(), nowrole.Substring(1, nowrole.Length - 2));
                                string str = "已";
                                str = str + dt4.Rows[0][0];
                                ds.Tables[0].Rows[i]["状态"] = str;
                            }
                            dataGridView1.DataSource = ds.Tables[0];
                            for (int i = 1; i <= 6; i++)
                            {
                                dataGridView1.Columns[i].ReadOnly = true;
                            }
                            process = "归还";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("请先选择任务");
                }
         
            }
            else
            {
                if(textBox2.Text.ToString()=="")
                {
                    int cnt1 = 0;
                    int cnt2 = 0;
                    int cnt3 = 0;
                    for (int j = 0; j < dataGridView1.RowCount; j++)
                    {
                        if ((bool)dataGridView1.Rows[j].Cells[0].EditedFormattedValue == true)
                        {
                            cnt3++;
                            cnt1++;
                            string str = dataGridView1.Rows[j].Cells["领取批次号"].Value.ToString();
                            string str2 = dataGridView1.Rows[j].Cells["编号"].Value.ToString();
                            //        DataTable dt = new AABAL().Select1014(str, str2);
                            //        string str3 = dt.Rows[0][0].ToString();
                            bool flag = new AABAL().update101501(str, str2, user);
                            if (flag == true) cnt2++;
                        }
                    }
                    if(cnt3!=0)
                    {
                        if (cnt1 == cnt2)
                        {
                            MessageBox.Show("领取成功");
                            dataGridView1.AllowUserToAddRows = false;

                            while (this.dataGridView1.Rows.Count != 0)
                            {
                                this.dataGridView1.Rows.RemoveAt(0);
                            }
                            this.Text = "编码";
                            DataSet ds = new GetJobBAL().Select4();

                            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                            {
                                DataTable dt4 = new AABAL().Select10042(ds.Tables[0].Rows[i][2].ToString(), nowrole.Substring(1, nowrole.Length - 2));
                                string str = "已";
                                str = str + dt4.Rows[0][0];
                                ds.Tables[0].Rows[i]["状态"] = str;
                                for (int si = 1; si <= 6; si++)
                                {
                                    dataGridView1.Columns[si].ReadOnly = true;
                                }
                            }
                            dataGridView1.DataSource = ds.Tables[0];
                            process = "打码";
                        }
                    }
                    else
                    {
                        MessageBox.Show("请先选择任务");
                    }
              
                }else
                {
                    int cnt1 = 0;
                    int cnt2 = 0;
                    int begin = Convert.ToInt32(textBox1.Text.ToString());
                    int end = Convert.ToInt32(textBox2.Text.ToString());
                    int c = dataGridView1.CurrentCell.RowIndex;
                    string a = dataGridView1.Rows[c].Cells["领取批次号"].Value.ToString();
                    int b = dataGridView1.Rows.Count;
                    for(int i=0;i<b-1;i++)
                    {
                        if(dataGridView1.Rows[i].Cells["领取批次号"].Value.ToString()== a && Convert.ToInt32(dataGridView1.Rows[i].Cells["编号"].Value.ToString()) >=begin && Convert.ToInt32(dataGridView1.Rows[i].Cells["编号"].Value.ToString()) <= end)
                        {
                            dataGridView1.Rows[i].Cells[0].Value = true;
                        }
                    }
                    for (int j = 0; j < dataGridView1.RowCount; j++)
                    {
                        if ((bool)dataGridView1.Rows[j].Cells[0].EditedFormattedValue == true)
                        {
                            cnt1++;
                            string str = dataGridView1.Rows[j].Cells["领取批次号"].Value.ToString();
                            string str2 = dataGridView1.Rows[j].Cells["编号"].Value.ToString();
                            //        DataTable dt = new AABAL().Select1014(str, str2);
                            //        string str3 = dt.Rows[0][0].ToString();
                            bool flag = new AABAL().update101501(str, str2, user);
                            if (flag == true) cnt2++;
                        }
                    }
                    if (cnt1 == cnt2)
                    {
                        MessageBox.Show("领取成功");
                        dataGridView1.AllowUserToAddRows = false;

                        while (this.dataGridView1.Rows.Count != 0)
                        {
                            this.dataGridView1.Rows.RemoveAt(0);
                        }
                        this.Text = "编码";
                        DataSet ds = new GetJobBAL().Select4();

                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            DataTable dt4 = new AABAL().Select10042(ds.Tables[0].Rows[i][2].ToString(), nowrole.Substring(1, nowrole.Length - 2));
                            string str = "已";
                            str = str + dt4.Rows[0][0];
                            ds.Tables[0].Rows[i]["状态"] = str;
                        }
                        dataGridView1.DataSource = ds.Tables[0];
                        for (int i = 1; i <= 6; i++)
                        {
                            dataGridView1.Columns[i].ReadOnly = true;
                        }
                        process = "打码";
                    }
                }
            }
            
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
      /*      if (e.RowIndex >= 0 && e.RowIndex != -1 && !dataGridView1.Rows[e.RowIndex].IsNewRow)
            {
                if (e.ColumnIndex == 0)
                {
                    if ((bool)this.dataGridView1[e.ColumnIndex, e.RowIndex].Value == true)
                    {
                        textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["编号"].Value.ToString();
                    }
                    else
                    {
                      
                    }
                }
            }*/
        }

        private void dataGridView1_CellPainting_1(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            if (nowrole != "【编码】")
            {
                this.label1.Visible = false;
                this.label2.Visible = false;
                this.textBox1.Visible = false;
                this.textBox2.Visible = false;
            }
            if (nowrole == "【拆分】")
            {
                this.Text = "拆分";
                DataSet ds = new GetJobBAL().Select2();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    DataTable dt4 = new AABAL().Select10041(ds.Tables[0].Rows[i][2].ToString(), nowrole.Substring(1, nowrole.Length - 2));
                    string str = "已";
                    str = str + dt4.Rows[0][0];
                    ds.Tables[0].Rows[i]["状态"] = str;
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
                this.Text = "著录";
                DataSet ds = new GetJobBAL().Select3();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    DataTable dt4 = new AABAL().Select10041(ds.Tables[0].Rows[i][2].ToString(), nowrole.Substring(1, nowrole.Length - 2));
                    string str = "已";
                    str = str + dt4.Rows[0][0];
                    ds.Tables[0].Rows[i]["状态"] = str;
                }
                dataGridView1.DataSource = ds.Tables[0];
                for (int i = 1; i <= 6; i++)
                {
                    dataGridView1.Columns[i].ReadOnly = true;
                }
                process = "著录";
            }
            else if (nowrole == "【再次著录】")
            {
                this.Text = "著录";
                DataSet ds = new GetJobBAL().Select1225();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    DataTable dt4 = new AABAL().Select10041(ds.Tables[0].Rows[i][2].ToString(), nowrole.Substring(1, nowrole.Length - 2));
                    string str = "已";
                    str = str + dt4.Rows[0][0];
                    ds.Tables[0].Rows[i]["状态"] = str;
                }
                dataGridView1.DataSource = ds.Tables[0];
                for (int i = 1; i <= 6; i++)
                {
                    dataGridView1.Columns[i].ReadOnly = true;
                }
                process = "著录";
            }
            else if (nowrole == "【编码】")
            {
                this.Text = "编码";
                DataSet ds = new GetJobBAL().Select4();

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    DataTable dt4 = new AABAL().Select10042(ds.Tables[0].Rows[i][2].ToString(), nowrole.Substring(1, nowrole.Length - 2));
                    string str = "已";
                    str = str + dt4.Rows[0][0];
                    ds.Tables[0].Rows[i]["状态"] = str;
                }
                dataGridView1.DataSource = ds.Tables[0];
                for (int i = 1; i <= 6; i++)
                {
                    dataGridView1.Columns[i].ReadOnly = true;
                }
                process = "打码";
            }
            else if (nowrole == "【还原】")
            {
                this.Text = "还原";
                DataSet ds = new GetJobBAL().Select9();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    DataTable dt4 = new AABAL().Select10041(ds.Tables[0].Rows[i][2].ToString(), nowrole.Substring(1, nowrole.Length - 2));
                    string str = "已";
                    str = str + dt4.Rows[0][0];
                    ds.Tables[0].Rows[i]["状态"] = str;
                }
                dataGridView1.DataSource = ds.Tables[0];
                for (int i = 1; i <= 6; i++)
                {
                    dataGridView1.Columns[i].ReadOnly = true;
                }
                process = "还原";
            }
            else if (nowrole == "【扫描】")
            {
                this.Text = "扫描";
                DataSet ds = new GetJobBAL().Select5();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    DataTable dt4 = new AABAL().Select10041(ds.Tables[0].Rows[i][2].ToString(), nowrole.Substring(1, nowrole.Length - 2));
                    string str = "已";
                    str = str + dt4.Rows[0][0];
                    ds.Tables[0].Rows[i]["状态"] = str;
                }
                dataGridView1.DataSource = ds.Tables[0];
                for (int i = 1; i <= 6; i++)
                {
                    dataGridView1.Columns[i].ReadOnly = true;
                }
                process = "扫描";
            }
            else if (nowrole == "【编目】")
            {
                this.Text = "编目";
                DataSet ds = new GetJobBAL().Select7();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    DataTable dt4 = new AABAL().Select10041(ds.Tables[0].Rows[i][2].ToString(), nowrole.Substring(1, nowrole.Length - 2));
                    string str = "已";
                    str = str + dt4.Rows[0][0];
                    ds.Tables[0].Rows[i]["状态"] = str;
                }
                dataGridView1.DataSource = ds.Tables[0];
                for (int i = 1; i <= 6; i++)
                {
                    dataGridView1.Columns[i].ReadOnly = true;
                }
                process = "编目";
            }
            else if (nowrole == "【图处】")
            {
                this.Text = "图处";
                DataSet ds = new GetJobBAL().Select6();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    DataTable dt4 = new AABAL().Select10041(ds.Tables[0].Rows[i][2].ToString(), nowrole.Substring(1, nowrole.Length - 2));
                    string str = "已";
                    str = str + dt4.Rows[0][0];
                    ds.Tables[0].Rows[i]["状态"] = str;
                }
                dataGridView1.DataSource = ds.Tables[0];
                for (int i = 1; i <= 6; i++)
                {
                    dataGridView1.Columns[i].ReadOnly = true;
                }
                process = "图处";
            }
            else if (nowrole == "【质检】")
            {
                this.Text = "质检";
                DataSet ds = new GetJobBAL().Select7();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    DataTable dt4 = new AABAL().Select10041(ds.Tables[0].Rows[i][2].ToString(), nowrole.Substring(1, nowrole.Length - 2));
                    string str = "已";
                    str = str + dt4.Rows[0][0];
                    ds.Tables[0].Rows[i]["状态"] = str;
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
                this.Text = "挂接";
                DataSet ds = new GetJobBAL().Select8();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    DataTable dt4 = new AABAL().Select10041(ds.Tables[0].Rows[i][2].ToString(), nowrole.Substring(1, nowrole.Length - 2));
                    string str = "已";
                    str = str + dt4.Rows[0][0];
                    ds.Tables[0].Rows[i]["状态"] = str;
                }
                dataGridView1.DataSource = ds.Tables[0];
                for (int i = 1; i <= 6; i++)
                {
                    dataGridView1.Columns[i].ReadOnly = true;
                }
                process = "挂接";
            }
            else if (nowrole == "【归还】")
            {
                this.Text = "归还";
                DataSet ds = new GetJobBAL().Select10();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    DataTable dt4 = new AABAL().Select10041(ds.Tables[0].Rows[i][2].ToString(), nowrole.Substring(1, nowrole.Length - 2));
                    string str = "已";
                    str = str + dt4.Rows[0][0];
                    ds.Tables[0].Rows[i]["状态"] = str;
                }
                dataGridView1.DataSource = ds.Tables[0];
                for (int i = 1; i <= 6; i++)
                {
                    dataGridView1.Columns[i].ReadOnly = true;
                }
                process = "归还";
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form档案状态查询 f = new Form档案状态查询();
            f.ShowDialog();
        }
    }
    
}
