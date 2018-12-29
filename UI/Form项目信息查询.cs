using BAL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Form项目信息查询 : Form
    {
        public Form项目信息查询()
        {
            InitializeComponent();
        }
        public Form项目信息查询(string str1) : this()
        {

        }
       
        MySqlDataAdapter adapter = null;
        
        DataSet dSet = null;

        //      private static string strConn = "server = localhost; database = test; uid = root; pwd = 123456;Charset=utf8;SslMode=none";
        string strConn = ConfigurationManager.ConnectionStrings["myconn"].ConnectionString;
        //        int cnt = 0;
        string pId;
        string filetype;
        string gdmethod;

        private void 查询_Click(object sender, EventArgs e)
        {
            pId = textBox1.Text.Trim();
            filetype = textBox4.Text.Trim();
            gdmethod = comboBox1.Text.Trim();

             //   DataSet ds = new projectBAL().Select(filetype, pId,gdmethod);
            adapter = new MySqlDataAdapter("SELECT pId ,projectunit  ,filetype ,gdmethod ,year,url,hz FROM project1 WHERE filetype like '%" + filetype + "%' and pId like '%" + pId + "%' and gdmethod like '%" + gdmethod + "%'", strConn);




            /*DataGridViewCheckBoxColumn columncb = new DataGridViewCheckBoxColumn();
            columncb.HeaderText = "选择";
            columncb.Name = "cb_check";
            columncb.TrueValue = true;
            columncb.FalseValue = false;
                //column9.DataPropertyName = "IsScienceNature";

            columncb.DataPropertyName = "IsChecked";
            if (cnt == 0)
            {
                dataGridView1.Columns.Add(columncb);
                cnt++;
            }*/
            //  dataGridView1.DataSource = ds.Tables[0];
            //          dSet = new DataSet();
            DataTable de = new DataTable();
            adapter.Fill(de);
            de.Columns.Add("编码规则", typeof(string));
            de.Columns.Add("项目流程定义", typeof(string));
            int i = 0;
            foreach (DataRow dr in de.Rows)
            {
                int j = 0;
                string bmgz = "";
                string xmdy = "";
                DataTable dt4 = new AABAL().Select10041127(de.Rows[i][0].ToString());
                while (j<5&&dt4.Rows[0][j].ToString() != "")
                {

                    if (j == 0)
                    {
                        bmgz = dt4.Rows[0][j].ToString();
                    }
                    else
                    {
                        bmgz = bmgz + "-" + dt4.Rows[0][j].ToString();
                    }
                    j++;
                }
                DataTable dt5 = new AABAL().Select1004112701(de.Rows[i++][0].ToString());
                for(int s =0;s<dt5.Rows.Count-1;s++)
                {
                    if (s == 0)
                    {
                        xmdy = dt5.Rows[s][0].ToString();
                    }
                    else
                    {
                        xmdy = xmdy + "-" + dt5.Rows[s][0].ToString();
                    }
                }
                dr["编码规则"] = bmgz;
                dr["项目流程定义"] = xmdy;
            }
            dataGridView1.DataSource = de;

            //InitDataSet();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("更新成功！");
        }
        int pageSize = 0; //每页显示行数
        int nMax = 0; //总记录数
        int pageCount = 0; //页数＝总记录数/每页显示行数
        int pageCurrent = 0; //当前页号
        int nCurrent = 0; //当前记录行
        private void InitDataSet()
        {
            pageSize = 10; //设置页面行数
            nMax = dataGridView1.Rows.Count;
            pageCount = (nMax / pageSize); //计算出总页数
            if ((nMax % pageSize) > 0)
            {
                pageCount++;
            }
            pageCurrent = 1; //当前页数从1开始
            nCurrent = 0; //当前记录数从0开始
            LoadData();
        }
        private void LoadData()
        {
            int nStartPos = 0; //当前页面开始记录行
            int nEndPos = 0; //当前页面结束记录行
            DataSet ds;
            ds = new projectBAL().Select(filetype, pId, gdmethod);
            
          
            DataTable dt = ds.Tables[0];
            System.Data.DataTable dtTemp = dt.Clone(); //克隆DataTable结构框架
            if (dtTemp != null || dtTemp.Rows.Count > 0)
            {
                if (pageCurrent == pageCount)
                {
                    nEndPos = nMax;
                }
                else
                {
                    nEndPos = pageSize * pageCurrent;
                }
                nStartPos = nCurrent;
                lblPageCount.Text = pageCount.ToString();//在bdnInfo中添加lable记录总页数
                txtCurrentPage.Text = Convert.ToString(pageCurrent); //在bdnInfo中添加Textbox记录当前页数
                                                                     //从元数据源复制记录行
                for (int i = nStartPos; i < nEndPos; i++)
                {
                    if (i < dt.Rows.Count)
                    {
                        dtTemp.ImportRow(dt.Rows[i]);
                        nCurrent++;
                    }
                }
                bdsInfo.DataSource = dtTemp;
                bdnInfo.BindingSource = bdsInfo;
                dataGridView1.DataSource = bdsInfo;
            }
            else
            {
                return;
            }
        }

        private void bdnInfo_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "上一页")
            {
                pageCurrent--;
                if (pageCurrent <= 0)
                {
                    MessageBox.Show("已经是第一页，请点击“下一页”查看！");
                    return;
                }
                else
                {
                    if (pageCurrent > pageSize)
                    {
                        pageCurrent = Convert.ToInt32(lblPageCount.Text);
                    }
                    else if (pageCurrent > Convert.ToInt32(lblPageCount.Text))
                    {
                        pageCurrent = Convert.ToInt32(lblPageCount.Text);
                    }
                    nCurrent = pageSize * (pageCurrent - 1);
                }
                LoadData();
            }
            if (e.ClickedItem.Text == "下一页")
            {
                if (pageCurrent <= 0)
                {
                    pageCurrent = 1;
                }
                pageCurrent++;
                if (pageCurrent > pageCount)
                {
                    MessageBox.Show("已经是最后一页，请点击“上一页”查看！");
                    return;
                }
                else
                {
                    nCurrent = pageSize * (pageCurrent - 1);
                    if (nCurrent <= 0)
                    {
                        return;
                    }
                }
                LoadData();
            }
        }

        
        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
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
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (Convert.ToBoolean(dataGridView1.Rows[i].Cells["cb_check"].Value) == true)
                    {
                            a[j++] = i;
                            //MessageBox.Show(dataGridView1.Rows[i].Cells[1].Value.ToString());
                            string pId = dataGridView1.Rows[i].Cells[1].Value.ToString();//获取焦点触发行的第二个值
                           bool flag = new PBAL().Delete(pId);
                   //         bool flag2 = new PBAL().Delete2(pId);
                    //        dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
                    
                    }
                }
                int s = 0;
                if(flag1 == true)
                {
                    while(a[s]>=0)
                    {
                      dataGridView1.Rows.RemoveAt(a[s]);
                      for(int i = s+1;i<9999;i++ )
                      {
                        a[i] = a[i] - 1;
                      }
                      s++;
                    }
                }
        }
        int cc = 0;
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
            string strcolumn = dataGridView1.Columns[e.ColumnIndex].DataPropertyName;//获取列datapropertyname
            if (e.RowIndex.ToString() != "-1")
            {
                     
                    if (Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[0].Value) == false)
                    {
                        string strrow = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();//获取焦点触发行的第二个值
                        string value = dataGridView1.CurrentCell.Value.ToString();
                        if (strcolumn == "pId" || strcolumn == "projectunit" || strcolumn == "filetype" || strcolumn == "gdmethod" || strcolumn == "year" || strcolumn == "url" || strcolumn == "hz")
                        {
                            bool flag = new PBAL().Update(strcolumn, value, strrow);
                            cc++;

                        }
                        else if(strcolumn == "lq" || strcolumn == "cf" || strcolumn == "zl" || strcolumn == "dm" || strcolumn == "gh")
                        {
                            bool flag = new PBAL().Update2(strcolumn, value, strrow);
                            cc++;
                        }
                    }
                    
                
            }
            else
            {

            }
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        /// <summary>
        /// 使DataGridView的列自适应宽度
        /// </summary>
        /// <param name="dgViewFiles"></param>
        private void AutoSizeColumn(DataGridView dgViewFiles)
        {
            int width = 0;
            //使列自使用宽度
            //对于DataGridView的每一个列都调整
            for (int i = 0; i < dgViewFiles.Columns.Count; i++)
            {
                //将每一列都调整为自动适应模式
                dgViewFiles.AutoResizeColumn(i, DataGridViewAutoSizeColumnMode.AllCells);
                //记录整个DataGridView的宽度
                width += dgViewFiles.Columns[i].Width;
            }
            //判断调整后的宽度与原来设定的宽度的关系，如果是调整后的宽度大于原来设定的宽度，
            //则将DataGridView的列自动调整模式设置为显示的列即可，
            //如果是小于原来设定的宽度，将模式改为填充。
            if (width > dgViewFiles.Size.Width)
            {
                dgViewFiles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }
            else
            {
                dgViewFiles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            //冻结某列 从左开始 0，1，2
            dgViewFiles.Columns[1].Frozen = true;
        }
        private void Form项目信息查询_Load(object sender, EventArgs e)
        {

            adapter = new MySqlDataAdapter("SELECT pId ,projectunit  ,filetype ,gdmethod ,year,url,hz FROM project1 WHERE filetype like '%%' and pId like '%%' and gdmethod like '%%'", strConn);




            /*DataGridViewCheckBoxColumn columncb = new DataGridViewCheckBoxColumn();
            columncb.HeaderText = "选择";
            columncb.Name = "cb_check";
            columncb.TrueValue = true;
            columncb.FalseValue = false;
                //column9.DataPropertyName = "IsScienceNature";

            columncb.DataPropertyName = "IsChecked";
            if (cnt == 0)
            {
                dataGridView1.Columns.Add(columncb);
                cnt++;
            }*/
            //  dataGridView1.DataSource = ds.Tables[0];
            //          dSet = new DataSet();
            DataTable de = new DataTable();
            adapter.Fill(de);
            de.Columns.Add("编码规则", typeof(string));
            de.Columns.Add("项目流程定义", typeof(string));
            int i = 0;
            foreach (DataRow dr in de.Rows)
            {
                int j = 0;
                string bmgz = "";
                string xmdy = "";
                DataTable dt4 = new AABAL().Select10041127(de.Rows[i][0].ToString());
                while (j < 5 && dt4.Rows[0][j].ToString() != "")
                {

                    if (j == 0)
                    {
                        bmgz = dt4.Rows[0][j].ToString();
                    }
                    else
                    {
                        bmgz = bmgz + "-" + dt4.Rows[0][j].ToString();
                    }
                    j++;
                }
                DataTable dt5 = new AABAL().Select1004112701(de.Rows[i++][0].ToString());
                for (int s = 0; s < dt5.Rows.Count - 1; s++)
                {
                    if (s == 0)
                    {
                        xmdy = dt5.Rows[s][0].ToString();
                    }
                    else
                    {
                        xmdy = xmdy + "-" + dt5.Rows[s][0].ToString();
                    }
                }
                dr["编码规则"] = bmgz;
                dr["项目流程定义"] = xmdy;
            }
            dataGridView1.DataSource = de;
            AutoSizeColumn(dataGridView1);
        }
    }
}
