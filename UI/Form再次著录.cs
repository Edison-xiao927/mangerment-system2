using BAL;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    public delegate void raiseCallBackRefreshDelegate3(); //全局委托申明
    public partial class Form再次著录 : Form
    {
        public event raiseCallBackRefreshDelegate3 raiseCallBackRefreshEvent3; //公开的事件
        public Form再次著录()
        {
            InitializeComponent();
        }
        int qwer = 0;//判断项目是否重复提交。
        int cc2 = 0;//判断案卷是否重复提交
        int cc3 = 0;//判断文件是否重复提交
        string pId = "";
        string bh = "";
        string lzId = "";

        public Form再次著录(string str, string str2, string str3) : this()
        {
            //this.pId = str;
            this.bh = str2;
            this.lzId = str3;
        }
        #region
        //项目著录
        int copy = 0;//复制cnt,全局变量复制局部变量。
        int copy3 = 0;//复制cnt2
        int copy2 = 0;//复制cnt3
        int lx = 0;//获取已著录的项目的行数
        int copylx = 0;
        int ll = 0;//获取已著录的案卷的行数
        int copyll = 0;
        int lw = 0;//获取已著录的文件的行数
        int copylw = 0;
        string parentId = "";
        bool flag = true;
        string gdmethod = "";
        private void Form再次著录_Load(object sender, EventArgs e)
        {
            dtp1.Value = System.DateTime.Now;
            this.dataGridView1.Controls.Add(dtp1);
            dtp1.Visible = false;
            dtp2.Value = System.DateTime.Now;
            this.dataGridView2.Controls.Add(dtp2);
            dtp2.Visible = false;
            dtp3.Value = System.DateTime.Now;
            this.dataGridView3.Controls.Add(dtp3);
            dtp3.Visible = false;

            DataTable dt11 = new ZLXIBAL().Select7(lzId);
            pId = dt11.Rows[0][0].ToString();
            DataTable dt = new ZLBAL().Select(pId);
            gdmethod = dt.Rows[0][0].ToString();
            if (gdmethod == "项目")
            {
                DataTable dt3 = new CZLBAL().Select2(pId, lzId);
                if (dt3 == null || dt3.Rows.Count == 0)
                {
                    int cnt = 0;
                    DataTable dt1 = new DataTable();
                    DataTable dt2 = new ZLBAL().Select1(pId);
                    int i = 0;

                    while (i < dt2.Rows.Count)
                    {

                        dt1.Columns.Add(dt2.Rows[i][0].ToString(), typeof(string));
                        cnt++;
                        i++;
                    }
                    copy = cnt;
                    DataRow dr = dt1.NewRow();
                    dt1.Rows.Add(dr);
                    dataGridView1.DataSource = dt1;
                    copylx = lx;

                }
                else
                {
                    int cnt = 0;
                    parentId = dt3.Rows[1][0].ToString();
                    DataTable dt1 = new DataTable();
                    DataTable dt2 = new ZLBAL().Select1(pId);
                    int i = 0;

                    while (i < dt2.Rows.Count)
                    {

                        dt1.Columns.Add(dt2.Rows[i][0].ToString(), typeof(string));
                        cnt++;
                        i++;
                    }

                    copy = cnt;//cnt是列数
                               // MessageBox.Show(copy.ToString());
                    for (int ss = 0; ss < dt3.Rows.Count;)
                    {
                        DataRow dr = dt1.NewRow();
                        for (int m = 0; m < cnt; m++)
                        {
                            dr[dt2.Rows[m][0].ToString()] = dt3.Rows[ss][1].ToString();
                            ss++;
                        }
                        lx++;
                        copylx = lx;
                        dt1.Rows.Add(dr);
                    }
                    dataGridView1.DataSource = dt1;
                }

            }
            else if (gdmethod == "案卷")
            {
                dataGridView1.ReadOnly = true;
                DataTable dt12 = new CZLBAL().Select112(pId, lzId);//找sx
                if (dt12 == null || dt12.Rows.Count == 0)
                {
                    DataTable dt111 = new DataTable();
                    DataTable dt5 = new AABAL().Select6(pId);
                    int m = 0;
                    int cnt2 = 0;
                    while (m < dt5.Rows.Count)
                    {

                        dt111.Columns.Add(dt5.Rows[m][0].ToString(), typeof(string));
                        cnt2++;
                        m++;
                    }
                    copy2 = cnt2;
                    dataGridView2.DataSource = dt111;
                    copyll = ll;
                }
                else
                {
                    DataTable dt111 = new DataTable();
                    DataTable dt5 = new AABAL().Select6(pId);
                    int m = 0;
                    int cnt2 = 0;
                    while (m < dt5.Rows.Count)
                    {

                        dt111.Columns.Add(dt5.Rows[m][0].ToString(), typeof(string));
                        cnt2++;
                        m++;
                    }
                    copy2 = cnt2;
                    for (int ss = 0; ss < dt12.Rows.Count;)
                    {

                        DataRow dr = dt111.NewRow();
                        for (int w = 0; w < cnt2; w++)
                        {
                            dr[dt5.Rows[w][0].ToString()] = dt12.Rows[ss][1].ToString();
                            ss++;
                        }
                        ll++;
                        copyll = ll;
                        dt111.Rows.Add(dr);
                    }
                    dataGridView2.DataSource = dt111;
                }
            }
            else
            {
                dataGridView1.ReadOnly = true;
                dataGridView2.ReadOnly = true;

                DataTable dt13 = new CZLBAL().Select113(pId, lzId);//找sx

                if (dt13 == null || dt13.Rows.Count == 0)
                {
                    int cnt3 = 0;
                    DataTable dt1 = new DataTable();
                    DataTable dt2 = new ZLXIBAL().Select6(pId);
                    int j = 0;
                    while (j < dt2.Rows.Count)
                    {

                        dt1.Columns.Add(dt2.Rows[j][0].ToString(), typeof(string));
                        cnt3++;
                        j++;
                    }
                    copy3 = cnt3;
                    dataGridView3.DataSource = dt1;
                    copylw = lw;
                }
                else
                {
                    DataTable dt1 = new DataTable();
                    DataTable dt2 = new ZLXIBAL().Select6(pId);

                    int j = 0;
                    int cnt3 = 0;
                    while (j < dt2.Rows.Count)
                    {
                        dt1.Columns.Add(dt2.Rows[j][0].ToString(), typeof(string));
                        cnt3++;
                        j++;
                    }
                    copy3 = cnt3;
                    for (int ss = 0; ss < dt13.Rows.Count;)
                    {

                        DataRow dr = dt1.NewRow();
                        for (int w = 0; w < cnt3; w++)
                        {
                            dr[dt2.Rows[w][0].ToString()] = dt13.Rows[ss][1].ToString();
                            ss++;
                        }
                        lw++;
                        copylw = lw;
                        dt1.Rows.Add(dr);
                    }
                    dataGridView3.DataSource = dt1;
                }
            }
        }

        private void btn_项目_Click(object sender, EventArgs e)
        {
            if (qwer < dataGridView1.Rows.Count)
            {
                qwer = dataGridView1.Rows.Count;
                int l = dataGridView1.Rows.Count;
                bool fafa = true;//判断是否提交成功，如果提交成功就是false
                var cco = 0;//用来复制count2,判断是否有重复，没有重复则提交 （下面案卷，文件都一样）
                foreach (DataGridViewRow v in dataGridView1.Rows)
                {
                    if (v.Cells["项目号"].Value != null)
                    {
                        var count2 = 0;
                        foreach (DataGridViewRow v2 in dataGridView1.Rows)
                        {
                            if (v2.Cells["项目号"].Value != null)
                            {
                                if (v.Cells["项目号"].Value.ToString().Equals(v2.Cells["项目号"].Value.ToString()))
                                {
                                    count2++;
                                    cco = count2;
                                }

                            }
                        }
                        if (count2 > 1)
                        {
                            MessageBox.Show("项目号【" + v.Cells["项目号"].Value + "】重复");
                            qwer = 0;
                            return;
                        }
                    }
                }
                if (cco == 1)
                {
                    for (int jq = lx; jq < l - 1; jq++)
                    {
                        int bnt = 0;

                        string[] str1 = new string[copy];
                        string[] str2 = new string[copy];
                        int s = 0;
                        DataTable dt3 = new AABAL().Select5(pId);
                        int i = 0;
                        while (i < dt3.Rows.Count)
                        {
                            if (dt3.Rows[i][0].ToString() != "")
                            {
                                DataTable dt4 = new AABAL().Select222(dt3.Rows[i][0].ToString(), "1", "10");
                                if (dt3.Rows[i][0].ToString() == "项目题名")
                                    bnt = i;
                                str1[s] = dt4.Rows[0][0].ToString();
                                ++s;
                            }
                            i++;
                        }
                        DataTable dt1 = new AABAL().Select5(pId);

                        //MessageBox.Show(copy.ToString());
                        for (int j = 1; j <= copy; j++)
                        {
                            str2[j - 1] = dataGridView1.Rows[jq].Cells[j].Value.ToString();
                        }

                        Random rd = new Random();
                        string str788 = rd.Next(1, 99999999).ToString();
                        if (flag == true)
                        {
                            DataTable tt = new ZLBAL().Select8(lzId, bh);
                            int page = Convert.ToInt32(tt.Rows[0][0].ToString());
                            int sum = 0;
                            int count = dataGridView1.Rows.Count;
                            //MessageBox.Show(copylx.ToString());
                            for (int k = copylx; k < count - 1; k++)
                            {
                                sum += Convert.ToInt32(dataGridView1.Rows[k].Cells["总页数"].Value.ToString());
                            }
                            if (sum == page)
                            {
                                
                                fafa = false;
                                for (int j = 0; j < copy; j++)
                                {
                                    if (j == 0)
                                    {
                                        bool flag = new CZLBAL().insert1122(pId, str1[j], str2[j], str788, bh, lzId);//pId,zId,sx,parentId2,pc
                                    }
                                    else if (j == bnt)
                                    {
                                        // DataTable dt444 = new AABAL().Select444(pId);
                                        bool flag = new CZLBAL().insert110(pId, str1[j], str2[j], "0", str788, bh, lzId);//pId,zId,sx,parentId,parentId2,pc
                                        DataTable dt111 = new CZLBAL().Select4(pId);
                                        parentId = dt111.Rows[0][0].ToString();
                                    }
                                    else
                                    {
                                      
                                        bool flag = new CZLBAL().insert1122(pId, str1[j], str2[j], str788, bh, lzId);
                                    }
                                }
                                //查询zl表，判断是否之前著录过删掉的，如果没著录过就插入，如果著录过后又删掉了，就更新iszl=0
                                DataTable dt112 = new CZLBAL().Select114(lzId, bh);
                                if (dt112.Rows.Count == 0)
                                {
                                    bool flag2 = new CZLBAL().insert(lzId, bh, "1");
                                }
                                else
                                {
                                    bool ff = new CZLBAL().Update112("1", lzId, bh);
                                }
                            }
                        }
                    }

                    if (fafa == false)
                    {
                        MessageBox.Show("提交成功！");
                    }
                    else
                    {
                        MessageBox.Show("页数不匹配！");
                        qwer = 0;
                    }
                    //比较，如果有不同的显示红色。
                    int count2 = dataGridView1.Rows.Count;
                    string xm = "";//项目名
                    for (int n = 0; n < count2 - 1; n++)
                    {
                        xm = dataGridView1.Rows[n].Cells[2].Value.ToString();
                        DataTable dt = new CZLBAL().Select5(xm, "3", pId, lzId, "2", "10");//查test表
                        DataTable dt2 = new CZLBAL().Select6(xm, "3", pId, lzId, "2", "10");//查test2表
                        if (dt.Rows.Count == 0)
                        {
                            dataGridView1.Rows[n].DefaultCellStyle.ForeColor = Color.Red;
                        }
                        else
                        {
                            for (int m = 0; m < dt.Rows.Count; m++)
                            {
                                if (dt.Rows[m][0].ToString() != dt2.Rows[m][0].ToString())
                                {
                                    dataGridView1.Rows[n].Cells[m + 2].Style.ForeColor = Color.Red;
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("请勿重复提交");

            }
        }

        private void btn_xmnext_Click(object sender, EventArgs e)
        {
            cc2 = 0;
            DataTable dt12 = new CZLBAL().Select3(f11);//找sx
            if (dt12 == null || dt12.Rows.Count == 0)
            {
                DataTable dt11 = new DataTable();
                DataTable dt5 = new AABAL().Select6(pId);
                int m = 0;
                int cnt2 = 0;
                while (m < dt5.Rows.Count)
                {

                    dt11.Columns.Add(dt5.Rows[m][0].ToString(), typeof(string));
                    cnt2++;
                    m++;
                }
                copy2 = cnt2;
                dataGridView2.DataSource = dt11;
                copyll = ll;
            }
            else
            {
                DataTable dt11 = new DataTable();
                DataTable dt5 = new AABAL().Select6(pId);
                int m = 0;
                int cnt2 = 0;
                while (m < dt5.Rows.Count)
                {

                    dt11.Columns.Add(dt5.Rows[m][0].ToString(), typeof(string));
                    cnt2++;
                    m++;
                }
                copy2 = cnt2;
                for (int ss = 0; ss < dt12.Rows.Count;)
                {

                    DataRow dr = dt11.NewRow();
                    for (int w = 0; w < cnt2; w++)
                    {
                        dr[dt5.Rows[w][0].ToString()] = dt12.Rows[ss][0].ToString();
                        ss++;
                    }
                    ll++;
                    copyll = ll;
                    dt11.Rows.Add(dr);
                }
                dataGridView2.DataSource = dt11;
            }
        }
        #endregion
        #region
        //案卷著录
        string str7 = "";
        string anId = "";
        string s11 = "";
        private void btn_aj_Click(object sender, EventArgs e)
        {
            if (cc2 < dataGridView2.Rows.Count)
            {
                cc2 = dataGridView2.Rows.Count;
                int l = dataGridView2.Rows.Count;
                bool fafa = true;
                var cco = 0;
                foreach (DataGridViewRow v in dataGridView2.Rows)
                {
                    if (v.Cells["案卷号"].Value != null)
                    {
                        var count2 = 0;
                        foreach (DataGridViewRow v2 in dataGridView2.Rows)
                        {
                            if (v2.Cells["案卷号"].Value != null)
                            {
                                if (v.Cells["案卷号"].Value.ToString().Equals(v2.Cells["案卷号"].Value.ToString()))
                                {
                                    count2++;
                                    cco = count2;
                                }

                            }
                        }
                        if (count2 > 1)
                        {
                            MessageBox.Show("案卷号【" + v.Cells["案卷号"].Value + "】重复");
                            cc2 = 0;
                            return;
                        }
                    }
                }
                if (cco == 1)
                {
                    for (int jq = ll; jq < l - 1; jq++)
                    {
                        string[] str1 = new string[copy2];
                        string[] str2 = new string[copy2];
                        int s = 0;
                        DataTable dt3 = new AABAL().Select6(pId);
                        int i = 0;
                        int bnt = 0;
                        while (i < dt3.Rows.Count)
                        {
                            if (dt3.Rows[i][0].ToString() != "")
                            {
                                DataTable dt4 = new AABAL().Select222(dt3.Rows[i][0].ToString(), "11", "18");
                                if (dt3.Rows[i][0].ToString() == "案卷题名")
                                    bnt = i;
                                str1[s] = dt4.Rows[0][0].ToString();
                                ++s;
                            }
                            i++;
                        }

                        Random rd = new Random();
                        string str788 = (rd.Next(1, 99999999) * 1000).ToString();
                        DataTable dt1 = new AABAL().Select5(pId);
                        for (int j = 1; j <= copy2; j++)
                        {
                            str2[j - 1] = dataGridView2.Rows[jq].Cells[j].Value.ToString();
                        }
                        DataTable f = new CZLBAL().Select77(pId);
                        if (gdmethod == "项目")
                        {
                            int sum = 0;
                            int c = Convert.ToInt32(dataGridView1.CurrentRow.Cells["总页数"].Value.ToString());
                            //MessageBox.Show(dataGridView2.Rows[0].Cells[3].Value.ToString());
                            int count = dataGridView2.Rows.Count;
                            for (int k = copyll; k < count - 1; k++)
                            {
                                sum += Convert.ToInt32(dataGridView2.Rows[k].Cells[3].Value.ToString());
                            }
                            if (sum == c)
                            {
                                fafa = false;
                                for (int j = 0; j < copy2; j++)
                                {

                                    if (j == bnt)
                                    {
                                        //   DataTable dt444 = new AABAL().Select444(pId);
                                        bool flag = new CZLBAL().insert110(pId, str1[j], str2[j], f11, str788, bh, lzId);//pId,zId,sx,parentId,parentId2,pc
                                    }
                                    else
                                    {
                                        //   DataTable dt444 = new AABAL().Select444(pId);
                                        bool flag = new CZLBAL().insert1122(pId, str1[j], str2[j], str788, bh, lzId);//pId,zId,sx,parentId2,pc
                                    }

                                }
                                //查询zl表，判断是否之前著录过删掉的，如果没著录过就插入，如果著录过后又删掉了，就更新iszl=0
                                DataTable dt111 = new CZLBAL().Select114(lzId, bh);
                                if (dt111.Rows.Count == 0)
                                {
                                    bool flag2 = new CZLBAL().insert(lzId, bh, "1");
                                }
                                else
                                {
                                    bool ff = new CZLBAL().Update112("1", lzId, bh);
                                }
                            }


                        }
                        else
                        {
                            DataTable tt = new ZLBAL().Select8(lzId, bh);
                            int page = Convert.ToInt32(tt.Rows[0][0].ToString());
                            int sum = 0;
                            int count = dataGridView2.Rows.Count;
                            // MessageBox.Show(ll.ToString());
                            for (int k = copyll; k < count - 1; k++)
                            {
                                sum += Convert.ToInt32(dataGridView2.Rows[k].Cells["页数"].Value.ToString());
                            }
                            if (sum == page)
                            {
                                fafa = false;
                                for (int j = 0; j < copy2; j++)
                                {

                                    if (j == bnt)
                                    {
                                        // DataTable dt444 = new AABAL().Select444(pId);
                                        bool flag = new CZLBAL().insert110(pId, str1[j], str2[j], "0", str788, bh, lzId);//pId,zId,sx,parentId,parentId2,pc
                                    }
                                    else
                                    {
                                        //  DataTable dt444 = new AABAL().Select444(pId);
                                        bool flag = new CZLBAL().insert1122(pId, str1[j], str2[j], str788, bh, lzId);//pId,zId,sx,parentId2,pc
                                    }

                                }
                                //查询zl表，判断是否之前著录过删掉的，如果没著录过就插入，如果著录过后又删掉了，就更新iszl=0
                                DataTable dt111 = new CZLBAL().Select114(lzId, bh);
                                if (dt111.Rows.Count == 0)
                                {
                                    bool flag2 = new CZLBAL().insert(lzId, bh, "1");
                                }
                                else
                                {
                                    bool ff = new CZLBAL().Update112("1", lzId, bh);
                                }
                            }
                        }
                        str7 = f.Rows[0][0].ToString();
                    }
                    if (fafa == false)
                    {
                        MessageBox.Show("提交成功！");
                    }
                    else
                    {
                        MessageBox.Show("页数不匹配！");
                        cc2 = 0;
                    }
                    //比较，如果有不同的显示红色。
                    int count2 = dataGridView2.Rows.Count;
                    string aj = "";//案卷名
                    for (int n = 0; n < count2 - 1; n++)
                    {
                        aj = dataGridView2.Rows[n].Cells[2].Value.ToString();
                        DataTable dt = new CZLBAL().Select5(aj, "12", pId, lzId, "12", "18");//查test表
                        DataTable dt2 = new CZLBAL().Select6(aj, "12", pId, lzId, "21", "18");//查test2表
                        if (dt.Rows.Count == 0)
                        {
                            dataGridView2.Rows[n].DefaultCellStyle.ForeColor = Color.Red;
                        }
                        else
                        {
                            for (int m = 0; m < dt.Rows.Count; m++)
                            {
                                if (dt.Rows[m][0].ToString() != dt2.Rows[m][0].ToString())
                                {
                                    dataGridView2.Rows[n].Cells[m + 2].Style.ForeColor = Color.Red;
                                }
                            }
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("请勿重复提交！");
            }

        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            cc3 = 0;
            string str99 = "";
            int count = dataGridView2.Rows.Count;
            for (int n = 0; n < count; n++)
            {
                if ((bool)dataGridView2.Rows[n].Cells[0].EditedFormattedValue == true)
                {
                    str99 = dataGridView2.Rows[n].Cells["案卷题名"].Value.ToString();
                    anId = dataGridView2.Rows[n].Cells["案卷号"].Value.ToString();
                    DataTable dt22 = new CZLBAL().Select8(pId, str99);
                    if (dt22 == null || dt22.Rows.Count == 0)
                    {
                        int cnt3 = 0;
                        DataTable dt = new DataTable();
                        DataTable dt11 = new AABAL().Select7(pId);
                        int k = 0;
                        while (k < dt11.Rows.Count)
                        {

                            dt.Columns.Add(dt11.Rows[k][0].ToString(), typeof(string));
                            cnt3++;
                            k++;
                        }
                        copy3 = cnt3;
                        dataGridView3.DataSource = dt;
                        copylw = lw;
                    }
                    else
                    {
                        DataTable dt1 = new DataTable();
                        DataTable dt2 = new ZLXIBAL().Select6(pId);

                        int j = 0;
                        int cnt3 = 0;
                        while (j < dt2.Rows.Count)
                        {

                            dt1.Columns.Add(dt2.Rows[j][0].ToString(), typeof(string));
                            cnt3++;
                            j++;
                        }

                        for (int ss = 0; ss < dt22.Rows.Count;)
                        {

                            DataRow dr = dt1.NewRow();
                            for (int w = 0; w < cnt3; w++)
                            {
                                dr[dt2.Rows[w][0].ToString()] = dt22.Rows[ss][0].ToString();
                                ss++;
                            }
                            lw++;
                            copylw = lw;
                            dt1.Rows.Add(dr);
                        }
                        dataGridView3.DataSource = dt1;
                    }
                }
            }

            DataTable fff = new CZLBAL().Select7777(pId, str99);
            s11 = fff.Rows[0][0].ToString();
        }
        #endregion
        #region
        //文件著录
        private void btn_wj_Click(object sender, EventArgs e)
        {
            if (cc3 < dataGridView3.Rows.Count)
            {
                cc3 = dataGridView3.Rows.Count;
                int l = dataGridView3.Rows.Count;
                int bnt = 0;
                bool cnt1 = true;
                var cco = 0;
                foreach (DataGridViewRow v in dataGridView3.Rows)
                {
                    if (v.Cells["件号"].Value != null)
                    {
                        var count2 = 0;
                        foreach (DataGridViewRow v2 in dataGridView3.Rows)
                        {
                            if (v2.Cells["件号"].Value != null)
                            {
                                if (v.Cells["件号"].Value.ToString().Equals(v2.Cells["件号"].Value.ToString()))
                                {
                                    count2++;
                                    cco = count2;
                                }

                            }
                        }
                        if (count2 > 1)
                        {
                            MessageBox.Show("件号【" + v.Cells["件号"].Value + "】重复");
                            cc3 = 0;
                            return;
                        }
                    }
                }
                if (cco == 1)
                {
                    for (int jq = lw; jq < l - 1; jq++)
                    {
                        Random rd = new Random();
                        string str788 = (rd.Next(1, 99999) * (jq + 1)).ToString();
                        string[] str1 = new string[20];
                        string[] str2 = new string[copy3];
                        int s = 0;
                        DataTable dt3 = new AABAL().Select7(pId);
                        int i = 0;
                        while (i < dt3.Rows.Count)
                        {
                            if (dt3.Rows[i][0].ToString() != "")
                            {
                                DataTable dt4 = new AABAL().Select222(dt3.Rows[i][0].ToString(), "19", "29");
                                if (dt3.Rows[i][0].ToString() == "文件题名")
                                    bnt = i;
                                str1[s] = dt4.Rows[0][0].ToString();
                                ++s;
                            }
                            i++;
                        }
                        //如果页数匹配能够插入再生成档号！
                        string[] ss = new string[5];
                        DataTable str438 = new AABAL().Select438(pId);
                        for (int b = 0; b < 5; b++)
                        {
                            if (str438.Rows[0][b].ToString() == "年度")
                            {
                                DataTable str7438 = new AABAL().Select7438(pId, bh);
                                ss[b] = str7438.Rows[0][0].ToString();
                            }
                            else if (str438.Rows[0][b].ToString() == "项目号")
                            {
                                ss[b] = pId;
                            }
                            else if (str438.Rows[0][b].ToString() == "案卷号")
                            {
                                ss[b] = anId;
                            }
                            else if (str438.Rows[0][b].ToString() == "文件号")
                            {
                                ss[b] = dataGridView3.Rows[jq].Cells["件号"].Value.ToString();
                            }
                            else if (str438.Rows[0][b].ToString() == "保管期限")
                            {
                                ss[b] = dataGridView3.Rows[jq].Cells["保管期限"].Value.ToString();
                            }
                            else
                            {
                                ss[b] = "";
                            }
                        }
                        int sbgege = 0;
                        string dangId = "";
                        for (int sb = 0; sb < 5; sb++)
                        {
                            if (ss[sb] != "" && sbgege == 0)
                            {
                                sbgege = 1;
                                dangId = ss[sb];
                                sb++;
                            }
                            if (ss[sb] != "" && sbgege != 0)
                            {
                                dangId = dangId + "-" + ss[sb];
                            }
                        }
                        dataGridView3.Rows[jq].Cells["档号3"].Value = dangId;

                        int a = dataGridView3.CurrentRow.Index;
                        for (int j = 1; j <= copy3; j++)
                        {
                            str2[j - 1] = dataGridView3.Rows[jq].Cells[j].Value.ToString();
                        }
                        DataTable f = new CZLBAL().Select777(pId, s11);

                        if (gdmethod == "项目" || gdmethod == "案卷")
                        {
                            int sum = 0;
                            int c = Convert.ToInt32(dataGridView2.CurrentRow.Cells["页数"].Value.ToString());
                            // MessageBox.Show(c.ToString());
                            int count = dataGridView3.Rows.Count;
                            for (int k = copylw; k < count - 1; k++)
                            {
                                sum += Convert.ToInt32(dataGridView3.Rows[k].Cells["页数"].Value.ToString());
                            }
                            if (sum == c)
                            {
                                cnt1 = false;
                                for (int j = 0; j < copy3; j++)
                                {

                                    if (j == bnt)
                                    {

                                        bool flag = new CZLBAL().insert110(pId, str1[j], str2[j], s11, str788, bh, lzId);//pId,zId,sx,parentId,parentId2,bh,lzId
                                    }
                                    else
                                    {

                                        bool flag = new CZLBAL().insert1122(pId, str1[j], str2[j], str788, bh, lzId);//pId,zId,sx,parentId2,pc,bh,lzId
                                    }
                                }
                                
                                //查询zl表，判断是否之前著录过删掉的，如果没著录过就插入，如果著录过后又删掉了，就更新iszl=0
                                DataTable dt111 = new CZLBAL().Select114(lzId, bh);
                                if (dt111.Rows.Count == 0)
                                {
                                    bool flag2 = new CZLBAL().insert(lzId, bh, "1");
                                }
                                else
                                {
                                    bool ff = new CZLBAL().Update112("1", lzId, bh);
                                }
                            }
                        }
                        else
                        {
                            DataTable tt = new ZLBAL().Select8(lzId, bh);
                            int page = Convert.ToInt32(tt.Rows[0][0].ToString());
                            int sum = 0;
                            int count = dataGridView3.Rows.Count;
                            for (int k = copylw; k < count - 1; k++)
                            {
                                sum += Convert.ToInt32(dataGridView3.Rows[k].Cells["页数"].Value.ToString());
                            }
                            if (sum == page)
                            {
                                cnt1 = false;
                                for (int j = 0; j < copy3; j++)
                                {
                                    if (j == bnt)
                                    {
                                        // DataTable dt444 = new AABAL().Select444(pId);
                                        bool flag = new CZLBAL().insert110(pId, str1[j], str2[j], "0", str788, bh, lzId);//pId,zId,sx,parentId,parentId2,pc
                                    }
                                    else
                                    {
                                        // DataTable dt444 = new AABAL().Select444(pId);
                                        bool flag = new CZLBAL().insert1122(pId, str1[j], str2[j], str788, bh, lzId);//pId,zId,sx,parentId2,pc
                                    }
                                }
                               
                                //查询zl表，判断是否之前著录过删掉的，如果没著录过就插入，如果著录过后又删掉了，就更新iszl=0
                                DataTable dt111 = new CZLBAL().Select114(lzId, bh);
                                if (dt111.Rows.Count == 0)
                                {
                                    bool flag2 = new CZLBAL().insert(lzId, bh, "1");
                                }
                                else
                                {
                                    bool ff = new CZLBAL().Update112("1", lzId, bh);
                                }
                            }
                            
                        }
                    }
                    if (cnt1 == false)
                    {
                        MessageBox.Show("提交成功！");
                        raiseCallBackRefreshEvent3();
                    }
                    else
                    {
                        MessageBox.Show("页数不匹配！");
                        cc3 = 0;
                    }
                    //比较，如果有不同的显示红色。
                    int count2 = dataGridView3.Rows.Count;
                    string wj = "";//存所有的项目名
                    for (int n = 0; n < count2 - 1; n++)
                    {
                        wj = dataGridView3.Rows[n].Cells[3].Value.ToString();
                        DataTable dt = new CZLBAL().Select5(wj, "21", pId, lzId, "21", "29");//查test表
                        DataTable dt2 = new CZLBAL().Select6(wj, "21", pId, lzId, "21", "29");//查test2表
                        if (dt.Rows.Count==0)
                        {
                            dataGridView3.Rows[n].DefaultCellStyle.ForeColor = Color.Red;
                        }
                        else
                        {
                            for (int m = 0; m < dt.Rows.Count; m++)
                            {
                                if (dt.Rows[m][0].ToString() != dt2.Rows[m][0].ToString())
                                {
                                    dataGridView3.Rows[n].Cells[m+3].Style.ForeColor = Color.Red;
                                }
                            }
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("请勿重复提交！");
            }
        }
        #endregion

       
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dataGridView3.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
        }
        string f11 = "";
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridView1.Rows[e.RowIndex].Cells[0].EditedFormattedValue.ToString() == "True")
            {
                int st = e.RowIndex;
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {

                    if (i != st)
                    {
                        dataGridView1.Rows[i].Cells[0].Value = false;
                    }
                }

            }
            string xmh = "";
            string xmname = "";
            int count = dataGridView1.Rows.Count;
            for (int n = 0; n < count; n++)
            {
                if ((bool)dataGridView1.Rows[n].Cells[0].EditedFormattedValue == true)
                {
                    xmname = dataGridView1.Rows[n].Cells["项目题名"].Value.ToString();
                    xmh = dataGridView1.Rows[n].Cells["项目号"].Value.ToString();
                }
            }
            DataTable dt = new CZLBAL().Select77777(pId, xmname);
            f11 = dt.Rows[0][0].ToString();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridView2.Rows[e.RowIndex].Cells[0].EditedFormattedValue.ToString() == "True")
            {
                int st = e.RowIndex;
                for (int i = 0; i < dataGridView2.RowCount - 1; i++)
                {

                    if (i != st)
                    {
                        dataGridView2.Rows[i].Cells[0].Value = false;
                    }
                }
            }
            string str99 = "";
            int count = dataGridView2.Rows.Count;
            for (int n = 0; n < count; n++)
            {
                if ((bool)dataGridView2.Rows[n].Cells[0].EditedFormattedValue == true)
                {
                    str99 = dataGridView2.Rows[n].Cells["案卷题名"].Value.ToString();
                    anId = dataGridView2.Rows[n].Cells["案卷号"].Value.ToString();
                }
            }
            DataTable fff = new CZLBAL().Select7777(pId, str99);
            s11 = fff.Rows[0][0].ToString();
        }

        private void btn_scxm_Click(object sender, EventArgs e)
        {
            int[] a = new int[10000];
            for (int i = 0; i < 9999; i++)
                a[i] = 0;
            int j = 0;
            bool flag1 = false;
            DialogResult button = MessageBox.Show("确定要删除本条信息?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            if (button == DialogResult.Yes)
            {
                flag1 = true;
            }
            if (flag1 == true)
            {
                int count = dataGridView1.Rows.Count;
                for (int i = 0; i < count - 1; i++)
                {
                    if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value) == true)
                    {
                        a[j++] = i;
                        string xmname = dataGridView1.Rows[i].Cells["项目题名"].Value.ToString();
                        string xId = dataGridView1.Rows[i].Cells["项目号"].Value.ToString();
                        DataTable dt = new CZLBAL().Select115(lzId, "1", xId);
                        string bh2 = dt.Rows[0][0].ToString();
                        bool f = new CZLBAL().Update112("0", lzId, bh2);
                        bool flag = new CZLBAL().Delete(xmname, pId, bh);//删文件
                        bool flag2 = new CZLBAL().Delete2("3", xmname, pId, bh);//删案 卷
                        bool flag3 = new CZLBAL().Delete3("3", xmname, pId, bh);//删项目

                        //  MessageBox.Show(dataGridView2.Rows.Count.ToString());
                        //    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
                        if (dataGridView2.ColumnCount > 1)
                        {
                            DataTable dtt = (DataTable)dataGridView2.DataSource;
                            dtt.Rows.Clear();
                            dataGridView2.DataSource = dtt;
                        }
                        if (dataGridView3.ColumnCount > 1)
                        {
                            DataTable tt = (DataTable)dataGridView3.DataSource;
                            tt.Rows.Clear();
                            dataGridView3.DataSource = tt;
                        }
                        qwer = 0;


                    }
                }
                int s = 0;
                while (a[s] >= 0)
                {
                    dataGridView1.Rows.RemoveAt(a[s]);
                    for (int i = s + 1; i < 9999; i++)
                    {
                        a[i] = a[i] - 1;
                    }
                    s++;
                }
                // copylx = lx;
                // MessageBox.Show(dataGridView1.Rows.Count.ToString());
                lx = dataGridView1.Rows.Count - 1;
            }
        }

        private void btn_scaj_Click(object sender, EventArgs e)
        {
            int[] a = new int[10000];
            for (int i = 0; i < 9999; i++)
                a[i] = 0;
            int j = 0;
            bool flag1 = false;
            DialogResult button = MessageBox.Show("确定要删除本条信息?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            if (button == DialogResult.Yes)
            {
                flag1 = true;
            }
            if (flag1 == true)
            {
                int count = dataGridView2.Rows.Count;
                for (int i = 0; i < count - 1; i++)
                {
                    if (Convert.ToBoolean(dataGridView2.Rows[i].Cells[0].Value) == true)
                    {
                        a[j++] = i;
                        string aname = dataGridView2.Rows[i].Cells["案卷题名"].Value.ToString();
                        string aId = dataGridView2.Rows[i].Cells["案卷号"].Value.ToString();
                        DataTable dt = new CZLBAL().Select115(lzId, "11", aId);
                        string bh2 = dt.Rows[0][0].ToString();
                        bool f = new CZLBAL().Update112("0", lzId, bh2);
                        bool flag = new CZLBAL().Delete2("12", aname, pId, bh);
                        bool flag2 = new CZLBAL().Delete3("12", aname, pId, bh);
                        //dataGridView2.Rows.RemoveAt(dataGridView2.CurrentCell.RowIndex);
                        if (dataGridView3.ColumnCount > 1)
                        {
                            DataTable tt = (DataTable)dataGridView3.DataSource;
                            tt.Rows.Clear();
                            dataGridView3.DataSource = tt;
                        }
                        cc2 = 0;
                    }
                }
                int s = 0;
                while (a[s] >= 0)
                {
                    dataGridView2.Rows.RemoveAt(a[s]);
                    for (int i = s + 1; i < 9999; i++)
                    {
                        a[i] = a[i] - 1;
                    }
                    s++;
                }
                copyll = ll;
                ll = dataGridView2.Rows.Count - 1;
            }
        }

        private void btn_scwj_Click(object sender, EventArgs e)
        {
            int[] a = new int[10000];
            for (int i = 0; i < 9999; i++)
                a[i] = 0;
            int j = 0;
            bool flag1 = false;
            DialogResult button = MessageBox.Show("确定要删除本条信息?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            if (button == DialogResult.Yes)
            {
                flag1 = true;
            }
            if (flag1 == true)
            {
                int count = dataGridView3.Rows.Count;
                for (int i = 0; i < count - 1; i++)
                {
                    if (Convert.ToBoolean(dataGridView3.Rows[i].Cells[0].Value) == true)
                    {
                        a[j++] = i;
                        if (button == DialogResult.Yes)
                        { //             MessageBox.Show(e.RowIndex.ToString());
                            string dId = dataGridView3.Rows[i].Cells["档号3"].Value.ToString();
                            DataTable dt = new CZLBAL().Select115(lzId, "19", dId);
                            string bh2 = dt.Rows[0][0].ToString();
                            bool f = new CZLBAL().Update112("0", lzId, bh2);
                            // dataGridView3.Rows.RemoveAt(dataGridView3.CurrentCell.RowIndex);
                            bool flag = new CZLBAL().Delete4(dId);
                        }
                        cc3 = 0;
                    }
                }
                int s = 0;
                while (a[s] >= 0)
                {
                    dataGridView3.Rows.RemoveAt(a[s]);
                    for (int i = s + 1; i < 9999; i++)
                    {
                        a[i] = a[i] - 1;
                    }
                    s++;
                }
                copylw = lw;
                lw = dataGridView3.Rows.Count - 1;
            }
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {
                if (this.dataGridView1.CurrentCell.ColumnIndex.ToString() == "4" || this.dataGridView1.CurrentCell.ColumnIndex.ToString() == "5")//在此指定和哪一列绑定
                {
                    System.Drawing.Rectangle rect = dataGridView1.GetCellDisplayRectangle(dataGridView1.CurrentCell.ColumnIndex, dataGridView1.CurrentCell.RowIndex, false);
                    dtp1.Left = rect.Left;
                    dtp1.Top = rect.Top;
                    dtp1.Width = rect.Width;
                    dtp1.Height = rect.Height;
                    dtp1.Visible = true;
                    // i = this.dataGridView1.CurrentRow.Index;
                    // j = this.dataGridView1.CurrentCell.ColumnIndex;
                    dataGridView1.CurrentCell.Value = dtp1.Value;
                }
                else
                {
                    dtp1.Visible = false;
                }

            }
            catch
            {
            }
        }

        private void dataGridView2_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {
                if (this.dataGridView2.CurrentCell.ColumnIndex.ToString() == "5")//在此指定和哪一列绑定
                {
                    System.Drawing.Rectangle rect = dataGridView2.GetCellDisplayRectangle(dataGridView2.CurrentCell.ColumnIndex, dataGridView2.CurrentCell.RowIndex, false);
                    dtp2.Left = rect.Left;
                    dtp2.Top = rect.Top;
                    dtp2.Width = rect.Width;
                    dtp2.Height = rect.Height;
                    dtp2.Visible = true;
                    // i = this.dataGridView1.CurrentRow.Index;
                    // j = this.dataGridView1.CurrentCell.ColumnIndex;
                    dataGridView2.CurrentCell.Value = dtp2.Value;
                }
                else
                {
                    dtp2.Visible = false;
                }

            }
            catch
            {
            }
        }

        private void dataGridView3_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {
                if (this.dataGridView3.CurrentCell.ColumnIndex.ToString() == "7")//在此指定和哪一列绑定
                {
                    System.Drawing.Rectangle rect = dataGridView3.GetCellDisplayRectangle(dataGridView3.CurrentCell.ColumnIndex, dataGridView3.CurrentCell.RowIndex, false);
                    dtp3.Left = rect.Left;
                    dtp3.Top = rect.Top;
                    dtp3.Width = rect.Width;
                    dtp3.Height = rect.Height;
                    dtp3.Visible = true;
                    // i = this.dataGridView1.CurrentRow.Index;
                    // j = this.dataGridView1.CurrentCell.ColumnIndex;
                    dataGridView3.CurrentCell.Value = dtp3.Value;
                }
                else
                {
                    dtp3.Visible = false;
                }

            }
            catch
            {
            }
        }
    }
}
