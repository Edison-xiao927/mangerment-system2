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
    public partial class Form权限管理 : Form
    {
        private int[] _uId;
        private int i;
        public Form权限管理()
        {
            InitializeComponent();
            treeView1.CheckBoxes = true;
        }
        public Form权限管理(string str1) : this()
        {

        }
        public Form权限管理(int[] _uId,int n) : this()
        {
            this._uId = _uId;
            this.i = n;
        }
        /// <summary>
        /// 初始化窗体：
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form权限管理_Load(object sender, EventArgs e)
        {
            //初始化树及树的节点
            InitialFirstNode();
            treeView1.ExpandAll();
            GetResourceIdByRoleId(_uId);
        }
        #region 构造树节点

        /// <summary>
        /// 构造树的一级节点
        /// </summary>
        private void InitialFirstNode()
        {
            DataTable dt = new AABAL().Select1();
            // MessageBox.Show(dt.Rows.Count.ToString());
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TreeNode node = new TreeNode();
                node.Name = dt.Rows[i]["resourceId"].ToString();
                node.Text = dt.Rows[i]["menuText"].ToString();
                //加载子节点
                InitialSubNodeList(node);
                treeView1.Nodes.Add(node);
            }
        }

        /// <summary>
        /// 构造树的子节点
        /// </summary>
        /// <param name="node"></param>
        private void InitialSubNodeList(TreeNode node)
        {
            int parentId = Convert.ToInt32(node.Name);
            DataTable dt = new AABAL().Select2(parentId);
            foreach (DataRow dr in dt.Rows)
            {
                TreeNode subNode = new TreeNode();
                subNode.Name = dr[0].ToString();
                subNode.Text = dr[2].ToString();
                InitialSubNodeList(subNode);

                node.Nodes.Add(subNode);
            }
        }
        #endregion
        #region 设置角色的权限

        /// <summary>
        /// 将角色所具有的权限进行保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            //将角色原有的资源权限删除
            for (int a = 0; a < i; a++)
            {
                bool flag = new AABAL().delete(_uId[a]);
            }

            //角色拥有的一级节点写入数据库
            foreach (TreeNode node in treeView1.Nodes)
            {
                for (int a = 0; a < i; a++)
                {
                    if (node.Checked)
                    {
                        bool flag1 = new AABAL().insert(_uId[a], Convert.ToInt32(node.Name));
                        //将一级节点的子节点写入数据库
                        GetSubNodeRole(node);
                    }
                }

            }
            MessageBox.Show("成功！");
            this.Close();
        }
        /// <summary>
        /// 递归调用遍历子节点，如果角色对子节点有权限则将其存入“角色-资源表”
        /// </summary>
        /// <param name="node"></param>
        private void GetSubNodeRole(TreeNode node)
        {
            for (int a = 0; a < i; a++)
            {
                foreach (TreeNode subNode in node.Nodes)
                {
                    if (subNode.Checked)
                    {
                        bool flag = new AABAL().insert(_uId[a], Convert.ToInt32(subNode.Name));
                    }
                    GetSubNodeRole(subNode);
                }
            }
        }

        #endregion
        #region 设置树节点的复选框（角色所具有的权限）

        /// <summary>
        /// 点击下拉列表框中的项时发生
        /// 点击下拉列表框中的角色时显示改角色所具有的资源权限
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            //切换角色时刷新树节点
            treeView1.Nodes.Clear();
            InitialFirstNode();
            treeView1.ExpandAll();

            // _uId = Convert.ToInt32(listBox1.SelectedValue);
            GetResourceIdByRoleId(_uId);
        }
        /// <summary>
        /// 根据用户的角色得到用户所具有的资源编号
        /// </summary>
        /// <param name="useId"></param>
        private void GetResourceIdByRoleId(int[] uId)
        {
            for (int a = 0; a < i; a++)
            {
                DataTable dt = new AABAL().Select3(uId[a]);
                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        SearchFirstNode(dr[0].ToString());
                    }
                }
            }
        }

        /// <summary>
        /// 检查所选择角色是否对一级节点具有权限
        /// </summary>
        /// <param name="name"></param>
        private void SearchFirstNode(string name)
        {
            foreach (TreeNode node in treeView1.Nodes)
            {
                if (node.Name == name)
                {
                    node.Checked = true;
                    break;
                }
                else
                {
                    SearchSubNode(name, node);
                }
            }
        }

        /// <summary>
        /// 递归检查用户对子节点是否具有权限
        /// </summary>
        /// <param name="name"></param>
        /// <param name="node"></param>
        private void SearchSubNode(string name, TreeNode node)
        {
            if (node.Nodes != null && node.Nodes.Count > 0)
            {
                foreach (TreeNode subNode in node.Nodes)
                {
                    if (subNode.Name == name)
                    {
                        subNode.Checked = true;
                        break;
                    }
                    else
                    {
                        SearchSubNode(name, subNode);
                    }
                }
            }
        }

        #endregion

        /// <summary>
        /// 1、当选择某个子节点时默认情况下将其父节点也选中
        /// 2、当选择某个父节点时默认情况下将其所有子节点也选中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            bool b = e.Node.Checked;
            if (e.Node.Nodes != null && e.Node.Nodes.Count > 0)
            {
                //具有局限性：最好采用递归调用
                foreach (TreeNode node in e.Node.Nodes)
                {
                    node.Checked = b;
                }
            }

            //子节点被选中时，选中其父节点；子节点被取消时不取消父节点的选择
            if (e.Node.Parent != null && b)
            {
                //最后采用方法递归调用
                e.Node.Parent.Checked = b;
            }
        }

       
    }
}
