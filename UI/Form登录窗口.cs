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

namespace UI
{
    public partial class Form登录窗口 : Form
    {
        public Form登录窗口()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            this.skinEngine1.SkinFile = Application.StartupPath + "//Wave.ssk";
            Sunisoft.IrisSkin.SkinEngine se = null;
            se = new Sunisoft.IrisSkin.SkinEngine();
            se.SkinAllForm = true;
        }
        private bool Check()
        {
            string s = textBox1.Text.Trim();
            DataTable dt = new AABAL().Select4(s);
            DataTable dt2 = new AABAL().Select1123(s);
            if (dt2.Rows.Count == 0)
            {
                MessageBox.Show("用户名输入错误！");
            }
            else
            {
                if (string.IsNullOrEmpty(textBox2.Text))
                {
                    MessageBox.Show("请输入密码！");
                    textBox2.Focus();
                    return false;
                }
                else if (dt.Rows[0][0].ToString() != textBox2.Text)
                {
                    MessageBox.Show("密码不正确！");
                }
            }
           
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text.Trim();
            if (Check())
            {
                DataTable dt = new AABAL().Select4(s);
                if (dt != null && dt.Rows.Count > 0)
                {
                    if (textBox2.Text == dt.Rows[0][0].ToString())
                    {
                        Form主面 f = new Form主面(s);
                        f.Show();
                        this.Hide();
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
