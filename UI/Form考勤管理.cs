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
    public partial class Form考勤管理 : Form
    {
        public Form考勤管理()
        {
            InitializeComponent();
        }
        string username = "";
        public Form考勤管理(string str1) : this()
        {
            string[] s = str1.Split('-');
            username = s[1];
        }
       

        private void button3_Click_1(object sender, EventArgs e)
        {
            DateTime d1 = dp_smw.Value;
            DateTime d2 = dp_sme.Value;
            DateTime d3 = dp_saw.Value;
            DateTime d4 = dp_sae.Value;
            // string season = cb_sea.Text.Trim();
            bool flag = new AttendanceBAL().Insert5(d1, d2, d3, d4);
            if (flag)
            {
                MessageBox.Show("设置成功！");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int p1 = Convert.ToInt32(tb_1h.Text.Trim());
            int p2 = Convert.ToInt32(tb_3h.Text.Trim());
            int p3 = Convert.ToInt32(tb_b3h.Text.Trim());
            int punish = 0;
            int cb = Convert.ToInt32(tb_cb.Text.Trim());
            bool flag = new AttendanceBAL().Insert6(p1, p2, p3, cb);
            if (flag)
            {
                MessageBox.Show("设置成功！");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime t1 = dp_s1.Value.Date;
            DateTime t2 = dp_s2.Value.Date;
            string name = tb_name.Text.Trim();
            if (name == "")
            {
                DataTable dt = new AttendanceBAL().Select10(t1, t2);
                dataGridView1.DataSource = dt;
            }
            else
            {
                DataTable dt = new AttendanceBAL().Select11(t1, t2, name);
                dataGridView1.DataSource = dt;
            }
        }
        //修改考勤信息
        int cc = 0;
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string strcolumn = dataGridView1.Columns[e.ColumnIndex].DataPropertyName;//获取列datapropertyname
            if (e.RowIndex.ToString() != "-1")
            {
                if (Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[0].Value) == false)
                {
                    int strrow = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());//获取焦点触发行的第二个值
                    string d = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();//获取焦点触发行的日期
                    DateTime date = DateTime.Parse(d);
                    string value = dataGridView1.CurrentCell.Value.ToString();
                    bool flag = new AttendanceBAL().Update5(strcolumn, value, strrow, date);
                    cc++;

                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
        }

        private void button4_Click(object sender, EventArgs e)
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
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value) == true)
                {
                        a[j++] = i;
                     //   dataGridView1.Rows.Remove(dataGridView1.Rows[i]);
                        int strrow = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value.ToString());//获取焦点触发行的第二个值
                        string d = dataGridView1.Rows[i].Cells[3].Value.ToString();//获取焦点触发行的日期
                        DateTime date = DateTime.Parse(d);
                        bool flag = new AttendanceBAL().Delete(strrow, date); 
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
        }
    }
}
