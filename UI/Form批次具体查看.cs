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
    public partial class Form批次具体查看 : Form
    {
        public Form批次具体查看()
        {
            InitializeComponent();
        }
        string pId = "";
        public Form批次具体查看(string str1) : this()
        {
            this.pId = str1;
            DataTable dt1 = new projectBAL().Select112701(pId);
            dataGridView1.DataSource = dt1;
            AutoSizeColumn(dataGridView1);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int n = 0;
            int l = 0;
            for (int j = 0; j < dataGridView1.RowCount; j++)
            {
                if ((bool)dataGridView1.Rows[j].Cells[0].EditedFormattedValue == true)
                {
                    n++;
                    string a = dataGridView1.Rows[j].Cells[1].Value.ToString();
                    bool flag = new AABAL().update112703(a);
                    if (flag == true) l++;
                }
            }
            if (n == l)
                MessageBox.Show("删除成功");
            DataTable dt1 = new projectBAL().Select112701(pId);
            dataGridView1.DataSource = dt1;
            dataGridView1.Refresh();
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
        private void Form批次具体查看_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form档案领取 f = new Form档案领取("【领取】");
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void Form批次具体查看_Load(object sender, EventArgs e)
        {

        }
    }
}
