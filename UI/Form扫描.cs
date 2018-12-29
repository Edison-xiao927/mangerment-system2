using BAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twain;

namespace UI
{
    public partial class Form扫描 : Form
    {
        List<string> lstImgPath = new List<string>();//当前文件夹所有的图片信息
        public Form扫描()
        {
            InitializeComponent();
        }
        public Form扫描(string str1) : this()
        {
          //  this.dangId = str1;
        }
        string a = "";
        string b = "";
        string c = "";
        string d = "";
        string e = "";
        string imagePath = "";
        public Form扫描(string str1,string str2, string str3, string str4, string str5) : this()
        {
            a = str1;
            b = str2;
            c = str3;
            d = str4;
            e = str5;
            DataTable dt1 = new DataTable();
            dt1.Columns.Add("档号", typeof(string));
            dt1.Columns.Add("件号", typeof(string));
            dt1.Columns.Add("文件题名", typeof(string));
            dt1.Columns.Add("页数", typeof(string));
            dt1.Columns.Add("保管期限", typeof(string));
            DataRow dr = dt1.NewRow();
            dr[0] = a;
            dr[1] = b;
            dr[2] = c;
            dr[3] = d;
            dr[4] = e;
            dt1.Rows.Add(dr);
            dataGridView1.DataSource = dt1;
        }
        int cnt = 0;
        int cnt111 = 0;
        string[] filescpoy;
        private int mImageIndex = 1;
        private string mRunPath = "";
        private string mImagePath = "";
        private Twain32 mTwain = new Twain32();
        private int index = -1;
        private void twEndXfer(object sender, Twain32.EndXferEventArgs e)
        {
            string filename = string.Empty;         
            filename = Guid.NewGuid().ToString();
            //        string FileNm = mImagePath + filename + ".png";
            string FileNm = mImagePath + a +"-"+ (++cnt).ToString("000") + ".png";
            e.Image.Save(FileNm, ImageFormat.Png);
            //mImageIndex++;
        }

        private void Form扫描_Load(object sender, EventArgs e)
        {
            mRunPath = System.IO.Directory.GetCurrentDirectory() + "\\";
            //         mImagePath = mRunPath + "Image\\";
            mImagePath = mRunPath + a+"\\";
            if (Directory.Exists(mImagePath) == false)
            {
                Directory.CreateDirectory(mImagePath);
            }

            mTwain.Language = TwLanguage.CHINESE_SINGAPORE;
            mTwain.IsTwain2Enable = false;
            mTwain.OpenDSM();
            List<string> srclst = new List<string>();
            for (int i = 0; i < mTwain.SourcesCount; i++)
            {
                srclst.Add(mTwain.GetSourceProductName(i));
            }
            combo_Dev.DataSource = srclst;
            mTwain.EndXfer += twEndXfer;
       
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您要删除之前的扫描文件吗？", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                #region 初始化删除所有文件
                foreach (Panel c in pnlImage.Controls)
                {
                    foreach (PictureBox pic in c.Controls)
                    {
                        pic.Image.Dispose();
                        pic.Image = null;
                    }
                }
                DirectoryInfo dir = new DirectoryInfo(mImagePath);
                FileInfo[] inf = dir.GetFiles();
                foreach (FileInfo finf in inf)
                {
                    finf.Delete();
                }
                #endregion
            }
            float val = 150;// Convert.ToSingle(combo_DPI.SelectedText);
            mTwain.Capabilities.XResolution.Set(val);
            mTwain.Capabilities.YResolution.Set(val);

            //if (rb_RGB.Checked)
            //{
            //    mTwain.Capabilities.PixelType.Set(TwPixelType.RGB);
            //}
            //if (rb_BW.Checked)
            //{
            mTwain.Capabilities.PixelType.Set(TwPixelType.BW);
            //}
            //if (rb_Gray.Checked)
            //{
            //    mTwain.Capabilities.PixelType.Set(TwPixelType.Gray);
            //}
            mTwain.ShowUI = true;//chk_ShowUI.Checked;
            mTwain.Acquire();
            aaa();
        }
        private void aaa()
        {
            AddFolderImages();
        }
        #region 显示扫描文件
        private bool ThumbnailCallback()
        {
            return false;
        }
        /// <summary>
        /// 添加图片到缩略图中
        /// </summary>
        /// <param name="path"></param>
        /// <param name="index"></param>

        private void AddFolderImages()
        {
            index = -1;
            lstImgPath = new List<string>();
            #region 加载所有图片
            //获取该目录下所有图片
            string[] files = Directory.GetFiles((System.IO.Directory.GetCurrentDirectory() + "\\"+a+""));
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
   //         MessageBox.Show(pic.ImageLocation.ToString());
        }

        void Mouse_Click(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
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
                Form2 form = new Form2(filescpoy[index].ToString());
     //           this.Hide();
                form.ShowDialog();
     //           this.Close();
            }
        }
        #endregion
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
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
            else
            {
                MessageBox.Show("请先选择要删除的扫描文件！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnSeach_Click(object sender, EventArgs e)
        {
            AddFolderImages();
        }

        private void combo_Dev_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                mTwain.SourceIndex = combo_Dev.SelectedIndex;
                mTwain.OpenDataSource();
                var _resolutions = mTwain.Capabilities.XResolution.Get();
                List<string> dpilst = new List<string>();
                for (var i = 0; i < _resolutions.Count; i++)
                {
                    dpilst.Add(_resolutions[i].ToString());
                }
                // combo_DPI.DataSource = dpilst;
            }
            catch
            {
            }
        }

        private void btnupload_Click(object sender, EventArgs e)
        {
 
            for(int i =0;i<cnt111;i++)
            {
                string st = filescpoy[i];
                st = st.Replace("\\", "\\\\");
                bool flag = new WorkBAL().Insert1107(a,i+1,st);
            }
            MessageBox.Show("成功");
        }

        private void pnlImage_MouseClick(object sender, MouseEventArgs e)
        {
         //   MessageBox.Show("11111111");
        }
    }
    public class CustomComparer : System.Collections.IComparer
    {
        public int Compare(object x, object y)
        {
            string s1 = (string)x;
            string s2 = (string)y;
            if (s1.Length > s2.Length) return 1;
            if (s1.Length < s2.Length) return -1;
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] > s2[i]) return 1;
                if (s1[i] < s2[i]) return -1;
            }
            return 0;
        }
    }
}
