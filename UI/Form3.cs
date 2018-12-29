using BAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        string dangId;
        string pId;

        public Form3(string str1,string str2) : this()
        {
              this.dangId = str1;
            this.pId = str2;
        }
        private int index = -1;
        string[] filescpoy;
        int cnt111 = 0;
        private bool ThumbnailCallback()
        {
            return false;
        }
        List<string> lstImgPath = new List<string>();//当前文件夹所有的图片信息
        void pic_Click(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            Control control = pic.Parent;
            index = int.Parse(control.Tag.ToString());
            //选中的缩略图添加背景颜色
            foreach (Control c in pnlImage.Controls)
            {
                if (c.Tag.ToString() == control.Tag.ToString())
                    c.BackColor = Color.Blue;
                else
                    c.BackColor = SystemColors.Control;
            }
        }
        void Mouse_Click(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                PictureBox pic = sender as PictureBox;
                Control control = pic.Parent;
                index = int.Parse(control.Tag.ToString());

                foreach (Control c in pnlImage.Controls)
                {
                    if (c.Tag.ToString() == control.Tag.ToString())
                        c.BackColor = Color.Blue;
                    else
                        c.BackColor = SystemColors.Control;
                }
                contextMenuStrip1.Show(MousePosition.X, MousePosition.Y);
            }else if(e.Button == MouseButtons.Left)
            {
                PictureBox pic = sender as PictureBox;
                Control control = pic.Parent;
                index = int.Parse(control.Tag.ToString());

                foreach (Control c in pnlImage.Controls)
                {
                    if (c.Tag.ToString() == control.Tag.ToString())
                        c.BackColor = Color.Yellow;
                    else
                        c.BackColor = SystemColors.Control;
                }
                foreach (Panel c in pnlImage.Controls)
                {
                    foreach (PictureBox pic1 in c.Controls)
                    {
                        pic1.Image.Dispose();
                        //                   pic1.Image = null;
                    }
                }
                Form2 form = new Form2(filescpoy[index].ToString(),dangId,pId);
                          this.Hide();
                form.ShowDialog();
                          this.Close();
            }
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }
        private void AddFolderImages()
        {
            string mImagePath = "";
            index = -1;
            lstImgPath = new List<string>();
            #region 加载所有图片
            //获取该目录下所有图片
            DataTable dt = new ZLXIBAL().Select1128(pId);
            string aaaa = dt.Rows[0][0].ToString();
            aaaa = aaaa.Replace("\\", "\\\\");
            //        mImagePath = mRunPath + a + "\\";
            mImagePath = aaaa + "\\" + dangId ;
            //    string[] files = Directory.GetFiles((System.IO.Directory.GetCurrentDirectory() + "\\" + dangId + ""));
            string[] files = Directory.GetFiles((mImagePath+""));
            filescpoy = files;
            cnt111 = files.Length;
            for (int i = 0; i < files.Length; i++)
            {
                if (files[i].EndsWith(".png", true, null)
                    || files[i].EndsWith(".bmp", true, null)
                    || files[i].EndsWith(".jpg", true, null)
                    || files[i].EndsWith(".gif", true, null))
                {
                    lstImgPath.Add(files[i]);
                }
            }
            #endregion

            //ToolTip toolTip = null;
            //toolTip = new ToolTip();
            //toolTip.AutomaticDelay = 100;
            //toolTip.AutoPopDelay = 10000;
            //to+olTip.InitialDelay = 100;
            //toolTip.ReshowDelay = 100;

            pnlImage.Controls.Clear();
            Image.GetThumbnailImageAbort myCallback =
                new Image.GetThumbnailImageAbort(ThumbnailCallback);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < lstImgPath.Count; i++)
            {
                try
                {
                    Panel pnl = new Panel();
                    pnl.Size = new Size(pnlImage.Height, pnlImage.Height);
                    pnl.BackgroundImageLayout = ImageLayout.Zoom;
                    pnl.Tag = i;
                    pnl.Padding = new System.Windows.Forms.Padding(3);
                    pnl.Dock = DockStyle.Left;

                    PictureBox pic = new PictureBox();
                    pic.SizeMode = PictureBoxSizeMode.Zoom;
                    pic.Dock = DockStyle.Fill;
                    //pic.Click += pic_Click;
                    pic.MouseUp += Mouse_Click;
                    pnl.Controls.Add(pic);
                    pic.Image = Image.FromFile(lstImgPath[i]);//img.GetThumbnailImage(32, 32, 
                    pnlImage.Controls.Add(pnl);
                    //toolTip.SetToolTip(pic, lstImgPath[i]);
                    //Application.DoEvents();
                }
                catch (Exception ex)//
                {
                    sb.AppendLine(lstImgPath[i] + ex.Message);
                }
            }
            if (sb.ToString().Length > 0)
            {
                MessageBox.Show(sb.ToString());
            }

        }
        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                AddFolderImages();
            }
            catch
            {
                MessageBox.Show("请先扫描");
            }
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool flag = false;
            foreach (Control c in pnlImage.Controls)
            {
                if (c.BackColor == Color.Blue)
                {
                    flag = true;
                    break;
                }
                else
                {
                    flag = false;
                }
            }
            if (flag)
            {
                if (MessageBox.Show("确定要删除选中的扫描文件吗？", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    FileInfo fileInfo = new FileInfo(lstImgPath[index]);
                    try
                    {
                        foreach (Panel c in pnlImage.Controls)
                        {
                            foreach (PictureBox pic in c.Controls)
                            {
                                pic.Image.Dispose();
                                pic.Image = null;
                            }
                        }
                        fileInfo.Delete();
                        AddFolderImages();
                        MessageBox.Show("删除扫描文件成功", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("删除文件失败，请联系管理员", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
            }
            }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (Panel c in pnlImage.Controls)
            {
                foreach (PictureBox pic in c.Controls)
                {
                    pic.Image.Dispose();
                    pic.Image = null;
                }
            }
        }

        private void pnlImage_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
