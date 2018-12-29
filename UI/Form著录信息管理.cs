using BAL;
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
    public partial class Form著录信息管理 : Form
    {
        public Form著录信息管理()
        {
            InitializeComponent();
        }
        string lzId = "";
        string pId = "";
        string gdmethod = "";
        string bh = "";
        public Form著录信息管理(string str,string str2) : this()
        {
            this.lzId = str;
            this.bh = str2;
        }
        
       
        int ll = 0;//ll为项目的行数
        int la = 0;
        int lw = 0;
        private void Form著录信息管理_Load(object sender, EventArgs e)
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
            DataTable dt = new ZLXIBAL().Select3(lzId);
            gdmethod = dt.Rows[0][0].ToString();
            if (gdmethod == "项目")
            {
                DataTable dt3 = new ZLXIBAL().Select2(pId,lzId);
                DataTable dt1 = new DataTable();
                DataTable dt2 = new ZLXIBAL().Select1();

                int i = 0;
                int cnt = 0;
                while (i < dt2.Rows.Count)
                {

                    dt1.Columns.Add(dt2.Rows[i][0].ToString(), typeof(string));
                    cnt++;
                    i++;
                }

                for (int ss = 0; ss < dt3.Rows.Count;)
                {

                    DataRow dr = dt1.NewRow();
                    for (int w = 0; w < cnt; w++)
                    { 
                        dr[dt2.Rows[w][0].ToString()] = dt3.Rows[ss][0].ToString();
                        ss++;
                    }
                    ll++;
                    dt1.Rows.Add(dr);
                }
                dataGridView1.DataSource = dt1;
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.Name = "btnsc";
                btn.HeaderText = "删除";
                btn.DefaultCellStyle.NullValue = "删除";
                dataGridView1.Columns.Add(btn);

            }

            else if (gdmethod == "案卷")
            {
                dataGridView1.ReadOnly = true;
                DataTable dt12 = new ZLBAL().Select112(pId,lzId);
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
                for (int ss = 0; ss < dt12.Rows.Count;)
                {

                    DataRow dr = dt111.NewRow();
                    for (int w = 0; w < cnt2; w++)
                    {
                        dr[dt5.Rows[w][0].ToString()] = dt12.Rows[ss][1].ToString();
                        ss++;
                    }
                    ll++;
                    dt111.Rows.Add(dr);
                }
                dataGridView2.DataSource = dt111;
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.Name = "btnsc";
                btn.HeaderText = "删除";
                btn.DefaultCellStyle.NullValue = "删除";
                dataGridView2.Columns.Add(btn);
            }
            else
            {

                dataGridView1.ReadOnly = true;
                dataGridView2.ReadOnly = true;

                DataTable dt22 = new ZLBAL().Select1113(pId,lzId);

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
                        dr[dt2.Rows[w][0].ToString()] = dt22.Rows[ss][1].ToString();
                        ss++;
                    }
                    lw++;
                    dt1.Rows.Add(dr);
                }
                dataGridView3.DataSource = dt1;

                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.Name = "btnsc";
                btn.HeaderText = "删除";
                btn.DefaultCellStyle.NullValue = "删除";
                dataGridView3.Columns.Add(btn);
            }
        }
        int top1 = 0;
        string xmname = "";//获取选中的改行的项目题名
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
            if (dataGridView1.Columns[e.ColumnIndex].Name == "btnsc" && e.RowIndex >= 0)
            {
                DialogResult button = MessageBox.Show("确定要删除本条信息?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

                if (button == DialogResult.Yes)
                {
                    string xmname = dataGridView1.Rows[e.RowIndex].Cells["项目题名"].Value.ToString();
                    string xId = dataGridView1.Rows[e.RowIndex].Cells["项目号"].Value.ToString();
                    DataTable dt = new ZLBAL().Select115(lzId, "1", xId);
                    string bh2 = dt.Rows[0][0].ToString();
                    bool f = new ZLBAL().Update112("0", lzId, bh2);
                    bool flag = new ZLXIBAL().Delete(xmname, pId, bh);//删文件
                    bool flag2 = new ZLXIBAL().Delete2("3",xmname,pId,bh);//删案 卷
                    bool flag3 = new ZLXIBAL().Delete3("3",xmname,pId,bh);//删项目
                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
                    if (dataGridView2.Rows.Count != 0)
                    {
                        DataTable dtt = (DataTable)dataGridView2.DataSource;
                        dtt.Rows.Clear();
                        dataGridView2.DataSource = dtt;
                    }
                    if (dataGridView3.Rows.Count != 0)
                    {
                        DataTable tt = (DataTable)dataGridView3.DataSource;
                        tt.Rows.Clear();
                        dataGridView3.DataSource = tt;
                    }
                    
                }
            }
            int count = dataGridView1.Rows.Count;
            for (int j = 0; j < count; j++)
            {
                if ((bool)dataGridView1.Rows[j].Cells[0].EditedFormattedValue == true)
                {
                    //string xmh = dataGridView1.Rows[j].Cells[1].Value.ToString();
                     xmname = dataGridView1.Rows[j].Cells["项目题名"].Value.ToString();
                    // DataTable dt5 = new ZLXIBAL().Select4(pId);
                    DataTable dt5 = new ZLXIBAL().Select99(pId,xmname);

                    DataTable dt6 = new DataTable();
                    DataTable dt7 = new ZLXIBAL().Select5(pId);

                    int k = 0;
                    int cnt2 = 0;
                    while (k < dt7.Rows.Count)
                    {

                        dt6.Columns.Add(dt7.Rows[k][0].ToString(), typeof(string));
                        cnt2++;
                        k++;
                    }

                    for (int ss = 0; ss < dt5.Rows.Count;)
                    {

                        DataRow dr = dt6.NewRow();
                        for (int w = 0; w < cnt2; w++)  
                        {
                            dr[dt7.Rows[w][0].ToString()] = dt5.Rows[ss][0].ToString();
                            ss++;
                        }
                        la++;
                        dt6.Rows.Add(dr);
                    }
                    dataGridView2.AllowUserToAddRows = false;

                    while (this.dataGridView2.Rows.Count != 0)
                    {
                        this.dataGridView2.Rows.RemoveAt(0);
                    }
                    dataGridView2.DataSource = dt6;
                }
            }
            if (top1 == 0)
            {
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.Name = "btnsc";
                btn.HeaderText = "删除";
                btn.DefaultCellStyle.NullValue = "删除";
                dataGridView2.Columns.Add(btn);
                top1++;
            }
            
        }
        int n = 0;
        string ajname = "";
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
            if (dataGridView2.Columns[e.ColumnIndex].Name == "btnsc" && e.RowIndex >= 0)
            {
                DialogResult button = MessageBox.Show("确定要删除本条信息?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (button == DialogResult.Yes)
                {
                    string aname = dataGridView2.Rows[e.RowIndex].Cells["案卷题名"].Value.ToString();
                    string aId = dataGridView2.Rows[e.RowIndex].Cells["案卷号"].Value.ToString();
                    DataTable dt = new ZLBAL().Select115(lzId, "11", aId);
                    string bh2 = dt.Rows[0][0].ToString();
                    bool f = new ZLBAL().Update112("0", lzId, bh2);
                    bool flag = new ZLXIBAL().Delete2("12", aname, pId, bh);
                    bool flag2 = new ZLXIBAL().Delete3("12", aname, pId, bh);
                    dataGridView2.Rows.RemoveAt(dataGridView2.CurrentCell.RowIndex);
                    if (dataGridView3.Rows.Count != 0)
                    {
                        DataTable tt = (DataTable)dataGridView3.DataSource;
                        tt.Rows.Clear();
                        dataGridView3.DataSource = tt;
                    }
                }
            }
            int count = dataGridView2.Rows.Count;
            for (int i = 0; i < count; i++)
            {
                if ((bool)dataGridView2.Rows[i].Cells[0].EditedFormattedValue == true)
                {
                    DataTable dt11 = new ZLXIBAL().Select7(lzId);
                    //string xmh = dt11.Rows[0][0].ToString();
                    ajname = dataGridView2.Rows[i].Cells["案卷题名"].Value.ToString();
                    DataTable dt = new ZLXIBAL().Select8(pId, ajname);

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

                    for (int ss = 0; ss < dt.Rows.Count;)
                    {

                        DataRow dr = dt1.NewRow();
                        for (int w = 0; w < cnt3; w++)
                        {
                            dr[dt2.Rows[w][0].ToString()] = dt.Rows[ss][0].ToString();
                            ss++;
                        }
                        lw++;
                        dt1.Rows.Add(dr);
                    }
                    dataGridView3.AllowUserToAddRows = false;

                    while (this.dataGridView3.Rows.Count != 0)
                    {
                        this.dataGridView3.Rows.RemoveAt(0);
                    }
                    dataGridView3.DataSource = dt1;
                }
            }
            if (n == 0)
            {
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.Name = "btnsc";
                btn.HeaderText = "删除";
                btn.DefaultCellStyle.NullValue = "删除";
                dataGridView3.Columns.Add(btn);
                n++;
            }
            
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView3.Columns[e.ColumnIndex].Name == "btnsc" && e.RowIndex >= 0)
            {
                DialogResult button = MessageBox.Show("确定要删除本条信息?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (button == DialogResult.Yes)
                {
                    //             MessageBox.Show(e.RowIndex.ToString());
                    string dId = dataGridView3.Rows[e.RowIndex].Cells["档号3"].Value.ToString();
                    DataTable dt = new ZLBAL().Select115(lzId,"19",dId);
                    string bh2 = dt.Rows[0][0].ToString();
                    bool f = new ZLBAL().Update112("0", lzId, bh2);
                    dataGridView3.Rows.RemoveAt(dataGridView3.CurrentCell.RowIndex);
                    bool flag = new ZLXIBAL().Delete4(dId);
                }
            }
        }
        #region
        //修改项目
        string Org = "";//单元格触发前的值
   //     string xmh = "";//该sx下的项目号
        string xid = "";//该sx对应的id.

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {
               // xmh = dataGridView1.Rows[e.RowIndex].Cells["项目号"].Value.ToString();//获取项目号
                Org = dataGridView1.CurrentCell.Value.ToString();
                DataTable dt = new ZLBAL().Select5(pId, Org);
                xid = dt.Rows[0][0].ToString();

            }
            catch
            {

            }
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

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string value = dataGridView1.CurrentCell.Value.ToString();
                bool flag = new ZLBAL().Update(value, xid);
            }
            catch
            {

            }
        }
        #endregion
        #region
        //修改案卷
        string Org2 = "";
    //    string xmh2 = "";
        string ajh = "";
        string aid = "";
        string parentId2 = "";

        private void dataGridView2_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
          /*  int count = dataGridView1.Rows.Count;
            for (int n = 0; n < count; n++)
            {
                if ((bool)dataGridView1.Rows[n].Cells[0].EditedFormattedValue == true)
                {
                    xmh2 = dataGridView1.Rows[n].Cells[1].Value.ToString();//获取项目号

                }
            }*/

            try
            {
                ajh = dataGridView2.Rows[e.RowIndex].Cells["案卷号"].Value.ToString();//获取案卷号                                                             
                //MessageBox.Show(ajh);
                DataTable dt1 = new ZLBAL().Select7(pId, "11", ajh);
                parentId2 = dt1.Rows[0][0].ToString();//获取parentId2

                string strcolumn = this.dataGridView2.Columns[this.dataGridView2.CurrentCell.ColumnIndex].HeaderText;
                // MessageBox.Show(strcolumn);
                DataTable dt = new ZLBAL().Select6(strcolumn);
                aid = dt.Rows[0][0].ToString();
                Org2 = dataGridView2.CurrentCell.Value.ToString();
                // MessageBox.Show(Org2);
            }
            catch
            {

            }
            try
            {
                if (this.dataGridView2.CurrentCell.ColumnIndex.ToString() == "4" )//在此指定和哪一列绑定
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

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string value = dataGridView2.CurrentCell.Value.ToString();
                bool flag = new ZLBAL().Update2(value, pId, aid, parentId2);
            }
            catch
            {

            }
        }
        #endregion
        #region
        //修改文件
        string Org3 = "";
        string xmh3 = "";
        string dId = "";
        string wid = "";
        string parentId22 = "";

        private void dataGridView3_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {
                dId = dataGridView3.Rows[e.RowIndex].Cells[1].Value.ToString();//获取档号                                                             
                DataTable dt11 = new ZLXIBAL().Select9(dId);
                xmh3 = dt11.Rows[0][0].ToString();

                DataTable dt1 = new ZLBAL().Select7(xmh3, "19", dId);
                parentId22 = dt1.Rows[0][0].ToString();//获取parentId2

                string strcolumn = this.dataGridView3.Columns[this.dataGridView3.CurrentCell.ColumnIndex].HeaderText;
                // MessageBox.Show(strcolumn);
                DataTable dt = new ZLBAL().Select6(strcolumn);
                wid = dt.Rows[0][0].ToString();
                Org3 = dataGridView3.CurrentCell.Value.ToString();
                // MessageBox.Show(Org2);
            }
            catch
            {

            }
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

        private void dataGridView3_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string value = dataGridView3.CurrentCell.Value.ToString();
                bool flag = new ZLBAL().Update2(value, xmh3, wid, parentId22);
            }
            catch
            {

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

        private void btn_xm_select_Click(object sender, EventArgs e)
        {
            string xmh1 = textBox1.Text.Trim();
            string xmh22 = textBox2.Text.Trim();
            string dangId = textBox3.Text.Trim();
            DataTable dtt = (DataTable)dataGridView1.DataSource;
            dtt.Rows.Clear();
            dataGridView1.DataSource = dtt;

            MessageBox.Show(dangId);
            if (xmh1 != "" && xmh22 == "")
            {
                DataTable dt = new ZLBAL().Select10("1",xmh1, pId);
                DataTable dt1 = new DataTable();
                DataTable dt2 = new ZLXIBAL().Select1();

                int i = 0;
                int cnt = 0;
                while (i < dt2.Rows.Count)
                {

                    dt1.Columns.Add(dt2.Rows[i][0].ToString(), typeof(string));
                    cnt++;
                    i++;
                }

                for (int ss = 0; ss < dt.Rows.Count;)
                {

                    DataRow dr = dt1.NewRow();
                    for (int w = 0; w < cnt; w++)
                    {
                        dr[dt2.Rows[w][0].ToString()] = dt.Rows[ss][0].ToString();
                        ss++;
                    }
                    ll++;
                    dt1.Rows.Add(dr);
                }
                dataGridView1.DataSource = dt1;
              
            }
            else if (xmh1 == "" && xmh22 != "")
            {
                DataTable dt = new ZLBAL().Select11("1",xmh22, pId);
                DataTable dt1 = new DataTable();
                DataTable dt2 = new ZLXIBAL().Select1();

                int i = 0;
                int cnt = 0;
                while (i < dt2.Rows.Count)
                {

                    dt1.Columns.Add(dt2.Rows[i][0].ToString(), typeof(string));
                    cnt++;
                    i++;
                }

                for (int ss = 0; ss < dt.Rows.Count;)
                {

                    DataRow dr = dt1.NewRow();
                    for (int w = 0; w < cnt; w++)
                    {
                        dr[dt2.Rows[w][0].ToString()] = dt.Rows[ss][0].ToString();
                        ss++;
                    }
                    ll++;
                    dt1.Rows.Add(dr);
                }
                
            }
            else if(xmh1!=""&&xmh22!="")
            {
                DataTable dt = new ZLBAL().Select9("1",xmh1,xmh22,pId);
                DataTable dt1 = new DataTable();
                DataTable dt2 = new ZLXIBAL().Select1();

                int i = 0;
                int cnt = 0;
                while (i < dt2.Rows.Count)
                {

                    dt1.Columns.Add(dt2.Rows[i][0].ToString(), typeof(string));
                    cnt++;
                    i++;
                }

                for (int ss = 0; ss < dt.Rows.Count;)
                {

                    DataRow dr = dt1.NewRow();
                    for (int w = 0; w < cnt; w++)
                    {
                        dr[dt2.Rows[w][0].ToString()] = dt.Rows[ss][0].ToString();
                        ss++;
                    }
                    ll++;
                    dt1.Rows.Add(dr);
                }
                dataGridView1.DataSource = dt1;
               
            }
            if (dangId != "")
            {
                DataTable tt = new ZLBAL().Select12(dangId, pId);
                DataTable dt1 = new DataTable();
                DataTable dt2 = new ZLXIBAL().Select1();

                int i = 0;
                int cnt = 0;
                while (i < dt2.Rows.Count)
                {

                    dt1.Columns.Add(dt2.Rows[i][0].ToString(), typeof(string));
                    cnt++;
                    i++;
                }

                for (int ss = 0; ss < tt.Rows.Count;)
                {

                    DataRow dr = dt1.NewRow();
                    for (int w = 0; w < cnt; w++)
                    {
                        dr[dt2.Rows[w][0].ToString()] = tt.Rows[ss][0].ToString();
                        ss++;
                    }
                    ll++;
                    dt1.Rows.Add(dr);
                }
                dataGridView1.DataSource = dt1;
            }

        }

        private void btn_aj_select_Click(object sender, EventArgs e)
        {
            string anId1 = textBox6.Text.Trim();
            string anId2 = textBox5.Text.Trim();
            string dangId = textBox4.Text.Trim();
            DataTable dtt = (DataTable)dataGridView2.DataSource;
            dtt.Rows.Clear();
            dataGridView2.DataSource = dtt;
            if (gdmethod == "项目")
            {
                if (anId1 != "" && anId2 == "")
                {
                    DataTable dt = new ZLBAL().Select16(xmname,"3", pId, bh, anId1,"11");
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
                    for (int ss = 0; ss < dt.Rows.Count;)
                    {

                        DataRow dr = dt111.NewRow();
                        for (int w = 0; w < cnt2; w++)
                        {
                            dr[dt5.Rows[w][0].ToString()] = dt.Rows[ss][0].ToString();
                            ss++;
                        }
                        ll++;
                        dt111.Rows.Add(dr);
                    }
                    dataGridView2.DataSource = dt111;

                }
                else if (anId1 == "" && anId2 != "")
                {
                    DataTable dt = new ZLBAL().Select17(xmname,"3", pId, bh, anId2,"11");
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
                    for (int ss = 0; ss < dt.Rows.Count;)
                    {

                        DataRow dr = dt111.NewRow();
                        for (int w = 0; w < cnt2; w++)
                        {
                            dr[dt5.Rows[w][0].ToString()] = dt.Rows[ss][0].ToString();
                            ss++;
                        }
                        ll++;
                        dt111.Rows.Add(dr);
                    }
                    dataGridView2.DataSource = dt111;

                }
                else if (anId1 != "" && anId2 != "")
                {
                    DataTable dt = new ZLBAL().Select15(xmname,"3", pId, bh, anId1, anId2,"11");
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
                    for (int ss = 0; ss < dt.Rows.Count;)
                    {

                        DataRow dr = dt111.NewRow();
                        for (int w = 0; w < cnt2; w++)
                        {
                            dr[dt5.Rows[w][0].ToString()] = dt.Rows[ss][0].ToString();
                            ss++;
                        }
                        ll++;
                        dt111.Rows.Add(dr);
                    }
                    dataGridView2.DataSource = dt111;

                }
            }
            else
            {
                if (anId1 != "" && anId2 == "")
                {
                    DataTable dt = new ZLBAL().Select10("11", anId1, pId);
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
                    for (int ss = 0; ss < dt.Rows.Count;)
                    {

                        DataRow dr = dt111.NewRow();
                        for (int w = 0; w < cnt2; w++)
                        {
                            dr[dt5.Rows[w][0].ToString()] = dt.Rows[ss][0].ToString();
                            ss++;
                        }
                        ll++;
                        dt111.Rows.Add(dr);
                    }
                    dataGridView2.DataSource = dt111;

                }
                else if (anId1 == "" && anId2 != "")
                {
                    DataTable dt = new ZLBAL().Select11("11", anId2, pId);
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
                    for (int ss = 0; ss < dt.Rows.Count;)
                    {

                        DataRow dr = dt111.NewRow();
                        for (int w = 0; w < cnt2; w++)
                        {
                            dr[dt5.Rows[w][0].ToString()] = dt.Rows[ss][0].ToString();
                            ss++;
                        }
                        ll++;
                        dt111.Rows.Add(dr);
                    }
                    dataGridView2.DataSource = dt111;

                }
                else if (anId1 != "" && anId2 != "")
                {
                    DataTable dt = new ZLBAL().Select9("11", anId1, anId2, pId);
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
                    for (int ss = 0; ss < dt.Rows.Count;)
                    {

                        DataRow dr = dt111.NewRow();
                        for (int w = 0; w < cnt2; w++)
                        {
                            dr[dt5.Rows[w][0].ToString()] = dt.Rows[ss][0].ToString();
                            ss++;
                        }
                        ll++;
                        dt111.Rows.Add(dr);
                    }
                    dataGridView2.DataSource = dt111;

                }
            }
            
            if (dangId != "")
            {
                DataTable tt = new ZLBAL().Select13(dangId, pId);
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
                for (int ss = 0; ss < tt.Rows.Count;)
                {

                    DataRow dr = dt111.NewRow();
                    for (int w = 0; w < cnt2; w++)
                    {
                        dr[dt5.Rows[w][0].ToString()] = tt.Rows[ss][0].ToString();
                        ss++;
                    }
                    ll++;
                    dt111.Rows.Add(dr);
                }
                dataGridView2.DataSource = dt111;
                
            }
        }

        private void btn_wj_select_Click(object sender, EventArgs e)
        {
            string wjId = textBox7.Text.Trim();
            string wjId2 = textBox8.Text.Trim();
            string dangId = textBox9.Text.Trim();

            DataTable dtt = (DataTable)dataGridView3.DataSource;
            dtt.Rows.Clear();
            dataGridView3.DataSource = dtt;

            if (gdmethod == "项目" || gdmethod == "案卷")
            {
                if (wjId != "" && wjId2 == "")
                {
                    DataTable dt = new ZLBAL().Select16(ajname,"12",pId, bh, wjId, "20");
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

                    for (int ss = 0; ss < dt.Rows.Count;)
                    {

                        DataRow dr = dt1.NewRow();
                        for (int w = 0; w < cnt3; w++)
                        {
                            dr[dt2.Rows[w][0].ToString()] = dt.Rows[ss][0].ToString();
                            ss++;
                        }
                        lw++;
                        dt1.Rows.Add(dr);
                    }
                    dataGridView3.DataSource = dt1;

                    DataGridViewButtonColumn btn = new DataGridViewButtonColumn();

                }
                else if (wjId == "" && wjId2 != "")
                {
                    DataTable dt = new ZLBAL().Select17(ajname,"12", pId, bh, wjId2, "20");
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

                    for (int ss = 0; ss < dt.Rows.Count;)
                    {

                        DataRow dr = dt1.NewRow();
                        for (int w = 0; w < cnt3; w++)
                        {
                            dr[dt2.Rows[w][0].ToString()] = dt.Rows[ss][0].ToString();
                            ss++;
                        }
                        lw++;
                        dt1.Rows.Add(dr);
                    }
                    dataGridView3.DataSource = dt1;


                }
                else if (wjId != "" && wjId2 != "")
                {
                    DataTable dt = new ZLBAL().Select15(ajname,"12",pId, bh, wjId, wjId2, "20");
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

                    for (int ss = 0; ss < dt.Rows.Count;)
                    {

                        DataRow dr = dt1.NewRow();
                        for (int w = 0; w < cnt3; w++)
                        {
                            dr[dt2.Rows[w][0].ToString()] = dt.Rows[ss][0].ToString();
                            ss++;
                        }
                        lw++;
                        dt1.Rows.Add(dr);
                    }
                    dataGridView3.DataSource = dt1;

                }
            }
            else
            {
                if (wjId != "" && wjId2 == "")
                {
                    DataTable dt = new ZLBAL().Select10("20", wjId, pId);
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

                    for (int ss = 0; ss < dt.Rows.Count;)
                    {

                        DataRow dr = dt1.NewRow();
                        for (int w = 0; w < cnt3; w++)
                        {
                            dr[dt2.Rows[w][0].ToString()] = dt.Rows[ss][0].ToString();
                            ss++;
                        }
                        lw++;
                        dt1.Rows.Add(dr);
                    }
                    dataGridView3.DataSource = dt1;

                    DataGridViewButtonColumn btn = new DataGridViewButtonColumn();

                }
                else if (wjId == "" && wjId2 != "")
                {
                    DataTable dt = new ZLBAL().Select11("20", wjId2, pId);
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

                    for (int ss = 0; ss < dt.Rows.Count;)
                    {

                        DataRow dr = dt1.NewRow();
                        for (int w = 0; w < cnt3; w++)
                        {
                            dr[dt2.Rows[w][0].ToString()] = dt.Rows[ss][0].ToString();
                            ss++;
                        }
                        lw++;
                        dt1.Rows.Add(dr);
                    }
                    dataGridView3.DataSource = dt1;


                }
                else if (wjId != "" && wjId2 != "")
                {
                    DataTable dt = new ZLBAL().Select9("20", wjId, wjId2, pId);
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

                    for (int ss = 0; ss < dt.Rows.Count;)
                    {

                        DataRow dr = dt1.NewRow();
                        for (int w = 0; w < cnt3; w++)
                        {
                            dr[dt2.Rows[w][0].ToString()] = dt.Rows[ss][0].ToString();
                            ss++;
                        }
                        lw++;
                        dt1.Rows.Add(dr);
                    }
                    dataGridView3.DataSource = dt1;

                }
            }
           
            if (dangId != "")
            {
                DataTable tt = new ZLBAL().Select14(dangId,pId);
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

                for (int ss = 0; ss < tt.Rows.Count;)
                {

                    DataRow dr = dt1.NewRow();
                    for (int w = 0; w < cnt3; w++)
                    {
                        dr[dt2.Rows[w][0].ToString()] = tt.Rows[ss][0].ToString();
                        ss++;
                    }
                    lw++;
                    dt1.Rows.Add(dr);
                }
                dataGridView3.DataSource = dt1;

            }
        }

    }
}
