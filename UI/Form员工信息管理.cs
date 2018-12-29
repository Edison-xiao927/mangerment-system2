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
    public partial class Form员工信息管理 : Form
    {
        public Form员工信息管理()
        {
            InitializeComponent();
        }
        public Form员工信息管理(string str1) : this()
        {
        }
        int count = 0;//记录datagridview的行数

        private void button1_Click(object sender, EventArgs e)
        {
            string userId = textBox1.Text.Trim();
            string username = textBox2.Text.Trim();
            adapter = new MySqlDataAdapter("select useId ,username ,sex ,brithday ,Origin ,marriage ,employdate ,historyrole ,nowrole ,workdate, telephone, mail, wangdian, card from user where useId like '%" + userId + "%' and username like '%" + username + "%'", strConn);
            dSet = new DataSet();
            adapter.Fill(dSet);
            dataGridView1.DataSource = dSet.Tables[0];
            count = dataGridView1.Rows.Count;
        }

        private void button3_Click(object sender, EventArgs e)
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
                    //   dataGridView1.Rows.Remove(dataGridView1.Rows[i]);
                    //   i --;
                    string useId = dataGridView1.Rows[i].Cells[1].Value.ToString();//获取焦点触发行的第二个值
                    bool flag = new AABAL().Delete(useId);
                }
            }
            int s = 0;
            if (flag1 == true)
            {
                while (a[s] >= 0)
                {
                    dataGridView1.Rows.RemoveAt(a[s]);
                    for (int i = s + 1; i < 9999; i++)
                    {
                        a[i] = a[i] - 1;
                    }
                    s++;
                }
            }
            count = dataGridView1.Rows.Count;
        }
        /// <summary>
        /// 数据适配器
        /// </summary>
        MySqlDataAdapter adapter = null;
        /// <summary>
        /// 数据集对象
        /// </summary>
        DataSet dSet = null;

        /// <summary>
        /// 连接字符串
        /// </summary>
        //      private static string strConn = "server = localhost; database = test2; uid = root; pwd = root;Charset=utf8;SslMode = none;";
        string strConn = ConfigurationManager.ConnectionStrings["myconn"].ConnectionString;
        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form员工信息管理_Load(object sender, EventArgs e)
        {
            adapter = new MySqlDataAdapter("select useId ,username ,sex ,brithday ,Origin ,marriage ,employdate ,historyrole ,nowrole ,workdate, telephone, mail, wangdian, card from user", strConn);
            dSet = new DataSet();
            adapter.Fill(dSet);
            dataGridView1.DataSource = dSet.Tables[0];
            this.dataGridView1.Controls.Add(this.dateTimePicker1);
            count = dataGridView1.Rows.Count;
        }
        /// <summary>
        /// 更新按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            /* //创建命令重建对象
             MySqlCommandBuilder scb = new MySqlCommandBuilder(adapter);

             //更新数据
             try
             {
                 //这里是关键
                 adapter.Update(dSet);
                 MessageBox.Show("操作成功！");
             }
             catch (MySqlException ex)
             {
                 MessageBox.Show(ex.Message);
             }*/
            MessageBox.Show("更新成功！");
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            DataGridViewCell CurrnetCell = this.dataGridView1.CurrentCell;
            if (CurrnetCell != null && CurrnetCell.OwningColumn.HeaderText == "出生日期")
            {
                Rectangle TmpRect = this.dataGridView1.GetCellDisplayRectangle(CurrnetCell.ColumnIndex, CurrnetCell.RowIndex, true);
                if (CurrnetCell.Value != null)
                {
                    // this.dateTimePicker1.Value = Convert.ToDateTime(CurrnetCell.Value);
                    this.dataGridView1.CurrentCell.Value = this.dateTimePicker1.Text;
                }
                this.dateTimePicker1.Size = TmpRect.Size;
                this.dateTimePicker1.Top = TmpRect.Top;
                this.dateTimePicker1.Left = TmpRect.Left;
                this.dateTimePicker1.Visible = true;
            }
            else if (CurrnetCell != null && CurrnetCell.OwningColumn.HeaderText == "聘用日期")
            {
                Rectangle TmpRect = this.dataGridView1.GetCellDisplayRectangle(CurrnetCell.ColumnIndex, CurrnetCell.RowIndex, true);
                if (CurrnetCell.Value != null)
                {                   
                    this.dataGridView1.CurrentCell.Value = this.dateTimePicker1.Text;
                }
                this.dateTimePicker1.Size = TmpRect.Size;
                this.dateTimePicker1.Top = TmpRect.Top;
                this.dateTimePicker1.Left = TmpRect.Left;
                this.dateTimePicker1.Visible = true;
            }
            else if (CurrnetCell != null && CurrnetCell.OwningColumn.HeaderText == "工作日期")
            {
                Rectangle TmpRect = this.dataGridView1.GetCellDisplayRectangle(CurrnetCell.ColumnIndex, CurrnetCell.RowIndex, true);
                if (CurrnetCell.Value != null)
                {                   
                    this.dataGridView1.CurrentCell.Value = this.dateTimePicker1.Text;
                }
                this.dateTimePicker1.Size = TmpRect.Size;
                this.dateTimePicker1.Top = TmpRect.Top;
                this.dateTimePicker1.Left = TmpRect.Left;
                this.dateTimePicker1.Visible = true;
            }
            else
            {
                this.dateTimePicker1.Visible = false;
            }
        }

        private void dateTimePicker1_CloseUp(object sender, EventArgs e)
        {
            this.dataGridView1.CurrentCell.Value = this.dateTimePicker1.Value.ToString();
        }
        private int[] _uId = new int[100];

        private void button2_Click(object sender, EventArgs e)
        {
            int n = 0;
            _uId[0] = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells["cb_check"].Value) == true)
                {
                    _uId[n++] = Convert.ToInt32(dataGridView1.Rows[i].Cells["yuangong"].Value);
                }
            }
            if (_uId[0] != 0)
            {
                Form权限管理 form = new Form权限管理(_uId, n);
                //this.Hide();
                form.ShowDialog();
                // this.Close();
            }
            else
            {
                MessageBox.Show("请选择需要赋权的用户");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
           
            if (e.Control is ComboBox)
            {
               ((ComboBox)e.Control).SelectedValue = dataGridView1.CurrentCell.Value.ToString();
               ((ComboBox)e.Control).DropDownStyle = ComboBoxStyle.DropDown;
             }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
           if(dataGridView1.Rows[dataGridView1.Rows.Count-1].Cells[1].Selected)
            {
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1].Value = (int)dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[1].Value + 1;
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
                    string name = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();//获取焦点触发行的第san个值
                    string value = dataGridView1.CurrentCell.Value.ToString();
                    if (strcolumn == "brithday" || strcolumn == "employdate" || strcolumn == "workdate")
                    {
                        DateTime t = DateTime.Parse(value);
                        bool flag = new UserBAL().Update2(strcolumn, t, strrow,name);
                        cc++;

                    }
                    else
                    {
                        bool flag = new UserBAL().Update(strcolumn, value, strrow, name);
                        cc++;
                    }
                }
            }
            else
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int hs = dataGridView1.Rows.Count;
            if (hs > count)
            {
                for (int i = count - 1; i < hs - 1; i++)
                {
                    System.DateTime d1 = System.DateTime.Now;
                    System.DateTime d2 = System.DateTime.Now;
                    System.DateTime d3 = System.DateTime.Now;
                    int useId = Convert.ToInt32(this.dataGridView1.Rows[i].Cells[1].Value.ToString());//获取焦点触发行的第二个值
                    string name = dataGridView1.Rows[i].Cells["Column3"].Value.ToString();//获取焦点触发行的第san个值
                    string bday = dataGridView1.Rows[i].Cells["Column6"].Value.ToString();
                    try
                    {
                        d1 = DateTime.Parse(bday);
                    }
                    catch
                    {
                        d1 = System.DateTime.Now;
                    }

                    string sex = dataGridView1.Rows[i].Cells["Column1"].Value.ToString();
                    string ori = dataGridView1.Rows[i].Cells["Column7"].Value.ToString();
                    string mar = dataGridView1.Rows[i].Cells["Column8"].Value.ToString();
                    string emday = dataGridView1.Rows[i].Cells["Column9"].Value.ToString();
                    try
                    {
                        d2 = DateTime.Parse(emday);
                    }
                    catch
                    {
                        d2 = System.DateTime.Now;
                    }

                    string hrole = dataGridView1.Rows[i].Cells["Column10"].Value.ToString();
                    string nrow = dataGridView1.Rows[i].Cells["Column11"].Value.ToString();
                    string workday = dataGridView1.Rows[i].Cells["Column12"].Value.ToString();
                    try
                    {
                        d3 = DateTime.Parse(workday);
                    }
                    catch
                    {
                        d3 = System.DateTime.Now;
                    }

                    string tel = dataGridView1.Rows[i].Cells["Column2"].Value.ToString();
                    string mail = dataGridView1.Rows[i].Cells["Column5"].Value.ToString();
                    string wd = dataGridView1.Rows[i].Cells["Column13"].Value.ToString();
                    string card = dataGridView1.Rows[i].Cells["Column14"].Value.ToString();
                    bool flag = new UserBAL().Insert(useId, name, d1, sex, ori, mar, d2, hrole, nrow, d3, tel, mail, wd, card);
                    if (flag)
                    {
                        MessageBox.Show("添加成功！");
                    }
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
