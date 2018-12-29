using BAL;
using MODEL;
using MySql.Data.MySqlClient;
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
    public delegate void raiseCallBackRefreshDelegate(); //全局委托申明
    public partial class Form加工流转单 : Form
    {
        public event raiseCallBackRefreshDelegate raiseCallBackRefreshEvent; //公开的事件
        string nowrole = "";
        public Form加工流转单()
        {
            InitializeComponent();
        }
        string pId = "";
        string pppp = "";
        public Form加工流转单(string a, string b, string c, string[] d, string e, string f, string g, string h,string l,string t):this()
        {
            textBoxNX.Text = l;
            textBoxXMDW.Text = a;
            textBoxDALX.Text = b;
            textBoxGDFS.Text = c;
            textBoxLQPCH.Text = e;
            textBoxJGLX.Text = f;
            textBoxLZDH.Text = g;
            this.nowrole = h;
            this.pId = t;
            this.pppp = f;
            foreach (string  str in d)
            {
                dataGridView1.Rows.Add(str);
            }
        }
        public Form加工流转单(string a, string b, string c, string[] d, string e, string f, string g, string h, string l, string t,int r) : this()
        {
            textBoxYS.Text = r.ToString();
            textBoxNX.Text = l;
            textBoxXMDW.Text = a;
            textBoxDALX.Text = b;
            textBoxGDFS.Text = c;
            textBoxLQPCH.Text = e;
            textBoxJGLX.Text = f;
            textBoxLZDH.Text = g;
            this.nowrole = h;
            this.pId = t;
            this.pppp = f;
            foreach (string str in d)
            {
                dataGridView1.Rows.Add(str);
            }
        }
        public Form加工流转单(string a, string b, string c, string[] d, string e, string f, string g, string h, string l, string t, int r,string user) : this()
        {
            textBoxZRR.Text = user;
            textBoxYS.Text = r.ToString();
            textBoxNX.Text = l;
            textBoxXMDW.Text = a;
            textBoxDALX.Text = b;
            textBoxGDFS.Text = c;
            textBoxLQPCH.Text = e;
            textBoxJGLX.Text = f;
            textBoxLZDH.Text = g;
            this.nowrole = h;
            this.pId = t;
            this.pppp = f;
            foreach (string str in d)
            {
                dataGridView1.Rows.Add(str);
            }
        }




        private void button1_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.Rows.Count;
            int river = 0;
            for (int j = 0; j < i - 1; j++)
            {
                processfile p = new processfile();
                //      p.bh = textBoxDH.Text.Trim();
                p.bh = this.dataGridView1.Rows[j].Cells[0].Value.ToString();
                p.filetype = textBoxDALX.Text.Trim();
                p.gdmethod = textBoxGDFS.Text.Trim();
                p.getId = textBoxLQPCH.Text.Trim();
                p.lzId = textBoxLZDH.Text.Trim();
                p.page = textBoxYS.Text.Trim();
                p.process = pppp;
                p.processdate = dateTimePicker1.Value;
                p.projectunit = textBoxXMDW.Text.Trim();
                p.responseible = textBoxZRR.Text.Trim();
                p.year = textBoxNX.Text.Trim();
                if (nowrole == "【拆分】")
                {
                    MySqlDataReader sdr = new WorkBAL().Selectinfo3(p.bh, p.getId);
                    if (sdr.Read())
                    {
                        sdr.Close();
                        bool flag11 = new WorkBAL().update4(p);
                    }
                    else
                    {
                        sdr.Close();
                        bool flag22 = new WorkBAL().Insert4(p);
                    }
                    river++;
                    
                    raiseCallBackRefreshEvent(); //将事件抛出去，在主窗体中接收，并作相应处理

                }
                else if (nowrole == "【著录】")
                {
                    MySqlDataReader sdr = new WorkBAL().Selectinfo3(p.bh, p.getId);
                    if (sdr.Read())
                    {
                        sdr.Close();
                        bool flag11 = new WorkBAL().update4(p);

                    }
                    else
                    {
                        sdr.Close();
                        bool flag22 = new WorkBAL().Insert4(p);
                    }
                    // 更改档案状态
                    river++;
                    raiseCallBackRefreshEvent(); //将事件抛出去，在主窗体中接收，并作相应处理
                }
                else if (nowrole == "【编码】")
                {
                    MySqlDataReader sdr = new WorkBAL().Selectinfo3(p.bh, p.getId);
                    if (sdr.Read())
                    {
                        sdr.Close();
                        bool flag11 = new WorkBAL().update4(p);

                    }
                    else
                    {
                        sdr.Close();
                        bool flag22 = new WorkBAL().Insert4(p);
                    }
                    // 更改档案状态
                    bool flag2 = new WorkBAL().update14(p.getId, p.bh);
                    if (flag2 == true)
                    {
                        river++;
                    }
                    this.Close();
                    raiseCallBackRefreshEvent(); //将事件抛出去，在主窗体中接收，并作相应处理
                }
                else if (nowrole == "【还原】")
                {
                    MySqlDataReader sdr = new WorkBAL().Selectinfo3(p.bh, p.getId);
                    if (sdr.Read())
                    {
                        sdr.Close();
                        bool flag11 = new WorkBAL().update4(p);

                    }
                    else
                    {
                        sdr.Close();
                        bool flag22 = new WorkBAL().Insert4(p);
                    }
                    // 更改档案状态
                    river++;
                    raiseCallBackRefreshEvent(); //将事件抛出去，在主窗体中接收，并作相应处理
                }
                else if (nowrole == "【扫描】")
                {
                    MySqlDataReader sdr = new WorkBAL().Selectinfo3(p.bh, p.getId);
                    if (sdr.Read())
                    {
                        sdr.Close();
                        bool flag11 = new WorkBAL().update4(p);

                    }
                    else
                    {
                        sdr.Close();
                        bool flag22 = new WorkBAL().Insert4(p);
                    }
                    river++;
                    raiseCallBackRefreshEvent(); //将事件抛出去，在主窗体中接收，并作相应处理
                }
                else if (nowrole == "【编目】")
                {
                    MySqlDataReader sdr = new WorkBAL().Selectinfo3(p.bh, p.getId);
                    if (sdr.Read())
                    {
                        sdr.Close();
                        bool flag11 = new WorkBAL().update4(p);

                    }
                    else
                    {
                        sdr.Close();
                        bool flag22 = new WorkBAL().Insert4(p);
                    }
                    river++;
                    raiseCallBackRefreshEvent(); //将事件抛出去，在主窗体中接收，并作相应处理
                }
                else if (nowrole == "【图处】")
                {
                    MySqlDataReader sdr = new WorkBAL().Selectinfo3(p.bh, p.getId);
                    if (sdr.Read())
                    {
                        sdr.Close();
                        bool flag11 = new WorkBAL().update4(p);

                    }
                    else
                    {
                        sdr.Close();
                        bool flag22 = new WorkBAL().Insert4(p);
                    }
                    // 更改档案状态
                    bool flag2 = new WorkBAL().update16(p.getId, p.bh);
                    river++;
                    raiseCallBackRefreshEvent(); //将事件抛出去，在主窗体中接收，并作相应处理
                }
                else if (nowrole == "【质检】")
                {
                    MySqlDataReader sdr = new WorkBAL().Selectinfo3(p.bh, p.getId);
                    if (sdr.Read())
                    {
                        sdr.Close();
                        bool flag11 = new WorkBAL().update4(p);

                    }
                    else
                    {
                        sdr.Close();
                        bool flag22 = new WorkBAL().Insert4(p);
                    }
                    river++;
                    raiseCallBackRefreshEvent(); //将事件抛出去，在主窗体中接收，并作相应处理
                }
                else if (nowrole == "【挂接】")
                {
                    MySqlDataReader sdr = new WorkBAL().Selectinfo3(p.bh, p.getId);
                    if (sdr.Read())
                    {
                        sdr.Close();
                        bool flag11 = new WorkBAL().update4(p);

                    }
                    else
                    {
                        sdr.Close();
                        bool flag22 = new WorkBAL().Insert4(p);
                    }
                    river++;
                    raiseCallBackRefreshEvent(); //将事件抛出去，在主窗体中接收，并作相应处理
                }
                else if (nowrole == "【归还】")
                {
                    MySqlDataReader sdr = new WorkBAL().Selectinfo3(p.bh, p.getId);
                    if (sdr.Read())
                    {
                        sdr.Close();
                        bool flag11 = new WorkBAL().update4(p);

                    }
                    else
                    {
                        sdr.Close();
                        bool flag22 = new WorkBAL().Insert4(p);
                    }
                    river++;
                    raiseCallBackRefreshEvent(); //将事件抛出去，在主窗体中接收，并作相应处理
                }
            }
            if(river == i-1)
            {
                MessageBox.Show("提交成功");
            }else
            {
                MessageBox.Show("提交失败");
            }
        }

        private void Form加工流转单_Load(object sender, EventArgs e)
        {
            textBoxYS.Enabled = false;
            if (nowrole != "【编码】")
            {
                DataTable dt555 = new AABAL().Select1018(textBoxLZDH.Text);
                textBoxYS.Text = dt555.Rows[0][0].ToString();
                textBoxYS.Enabled = false;
            }
            DataTable dt4 = new AABAL().Select1004(textBoxJGLX.Text);
     //       MessageBox.Show(dt4.Rows[0][0].ToString());
    //        MessageBox.Show(dt4.Rows[1][0].ToString());
            //      MessageBox.Show(dt4.Rows[2][0].ToString());
            int cnt = 0;
            int i = dt4.Rows.Count;
            if (cnt<i)
            {
                textBoxJGLX.Text = dt4. Rows[cnt][0].ToString();
                cnt++;
            }
            if (cnt < i)
            {
                textBox1.Text = dt4.Rows[cnt][0].ToString();
                cnt++;
            }
            if (cnt < i)
            {
                textBox2.Text = dt4.Rows[cnt][0].ToString();
                cnt++;
            }
            if (cnt < i)
            {
                textBox3.Text = dt4.Rows[cnt][0].ToString();
                cnt++;
            }
            if (cnt < i)
            {
                textBox4.Text = dt4.Rows[cnt][0].ToString();
                cnt++;
            }
            if (cnt < i)
            {
                textBox5.Text = dt4.Rows[cnt][0].ToString();
                cnt++;
            }
            if (cnt < i)
            {
                textBox6.Text = dt4.Rows[cnt][0].ToString();
                cnt++;
            }
            if (cnt < i)
            {
                textBox7.Text = dt4.Rows[cnt][0].ToString();
                cnt++;
            }
            if (cnt < i)
            {
                textBox8.Text = dt4.Rows[cnt][0].ToString();
                cnt++;
            }
            if (cnt < i)
            {
                textBox9.Text = dt4.Rows[cnt][0].ToString();
                cnt++;
            }
        }
        private string empUpLoadPictureRealPos;
        private string empUpLoadPictureFormat;
        private void button2_Click(object sender, EventArgs e)
        {
            object oTemplate = "";
            object oMissing = System.Reflection.Missing.Value;
            //创建一个Word应用程序实例
            Microsoft.Office.Interop.Word._Application oWord = new Microsoft.Office.Interop.Word.Application();
            //设置为不可见
            oWord.Visible = false;
            //模板文件地址，这里假设在X盘根目录
            try
            {
                OpenFileDialog openFileDialogEmpImage = new OpenFileDialog();
                //          openFileDialogEmpImage.Filter = "*.jpg|*.jpg|*.png|*.png|*.bmp|*.bmp|*.tiff|*.tiff";//图片格式
                if (openFileDialogEmpImage.ShowDialog() == DialogResult.OK)
                {
                    //           isUpLoadPicture = true;//记录是否上传了相片，用于后面保存操作使用：是一个成员变
                    try
                    {
                        empUpLoadPictureRealPos = openFileDialogEmpImage.FileName;//实际的文件路径+文件名
                        String[] empImageData = empUpLoadPictureRealPos.Split('.');
                        //empImageData[1]:是上传的图片的后缀名
                        empUpLoadPictureFormat = empImageData[1];
                        oTemplate = openFileDialogEmpImage.FileName;
                    }
                    catch
                    {
                        MessageBox.Show("您选择的文件不能被读取或文件类型不对！", "错误信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch
            {

            }
          //  object oTemplate = "C:\\Users\\IHCI\\Desktop\\档案加工流转单.dot";
            //以模板为基础生成文档
            Microsoft.Office.Interop.Word._Document oDoc = oWord.Documents.Add(ref oTemplate, ref oMissing, ref oMissing, ref oMissing);
            //声明书签数组
            object[] oBookMark = new object[21];
            //赋值书签名
            oBookMark[0] = "a1";
            oBookMark[1] = "a2";
            oBookMark[2] = "a3";
            oBookMark[3] = "a4";
            oBookMark[4] = "a5";
            oBookMark[5] = "a6";
            oBookMark[6] = "a7";
            oBookMark[7] = "a8";
            oBookMark[8] = "a9";
            oBookMark[9] = "a10";
            oBookMark[10] = "a11";
            oBookMark[11] = "a12";
            oBookMark[12] = "a13";
            oBookMark[13] = "a14";
            oBookMark[14] = "a15";
            oBookMark[15] = "a16";
            oBookMark[16] = "a17";
            oBookMark[17] = "a18";
            oBookMark[18] = "a19";
            oBookMark[19] = "a20";

            //赋值任意数据到书签的位置
            oDoc.Bookmarks.get_Item(ref oBookMark[0]).Range.Text = textBoxXMDW.Text.Trim();
            oDoc.Bookmarks.get_Item(ref oBookMark[1]).Range.Text = textBoxLQPCH.Text.Trim();
            oDoc.Bookmarks.get_Item(ref oBookMark[2]).Range.Text = textBoxLZDH.Text.Trim();
            oDoc.Bookmarks.get_Item(ref oBookMark[3]).Range.Text = textBoxDALX.Text.Trim();
            oDoc.Bookmarks.get_Item(ref oBookMark[4]).Range.Text = textBoxGDFS.Text.Trim();
            oDoc.Bookmarks.get_Item(ref oBookMark[5]).Range.Text = textBoxNX.Text.Trim();
            oDoc.Bookmarks.get_Item(ref oBookMark[6]).Range.Text = textBoxZRR.Text.Trim();
            oDoc.Bookmarks.get_Item(ref oBookMark[7]).Range.Text = textBoxYS.Text.Trim();
            oDoc.Bookmarks.get_Item(ref oBookMark[8]).Range.Text = textBoxJGLX.Text.Trim();
            oDoc.Bookmarks.get_Item(ref oBookMark[9]).Range.Text = textBox1.Text.Trim();
            oDoc.Bookmarks.get_Item(ref oBookMark[10]).Range.Text = textBox2.Text.Trim();
            oDoc.Bookmarks.get_Item(ref oBookMark[11]).Range.Text = textBox3.Text.Trim();
            oDoc.Bookmarks.get_Item(ref oBookMark[12]).Range.Text = textBox4.Text.Trim();
            oDoc.Bookmarks.get_Item(ref oBookMark[13]).Range.Text = textBox5.Text.Trim();
            oDoc.Bookmarks.get_Item(ref oBookMark[14]).Range.Text = textBox6.Text.Trim();
            oDoc.Bookmarks.get_Item(ref oBookMark[15]).Range.Text = textBox7.Text.Trim();
            oDoc.Bookmarks.get_Item(ref oBookMark[16]).Range.Text = textBox8.Text.Trim();
            oDoc.Bookmarks.get_Item(ref oBookMark[17]).Range.Text = textBox9.Text.Trim();
            oDoc.Bookmarks.get_Item(ref oBookMark[18]).Range.Text = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            oDoc.Bookmarks.get_Item(ref oBookMark[19]).Range.Text = dateTimePicker2.Value.ToString("yyyy-MM-dd");


            //弹出保存文件对话框，保存生成的Word
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Word Document(*.doc)|*.doc";
            sfd.DefaultExt = "Word Document(*.doc)|*.doc";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                object filename = sfd.FileName;

                oDoc.SaveAs(ref filename, ref oMissing, ref oMissing, ref oMissing,
                ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                ref oMissing, ref oMissing);
                oDoc.Close(ref oMissing, ref oMissing, ref oMissing);
                //关闭word
                oWord.Quit(ref oMissing, ref oMissing, ref oMissing);
            }

            ExportToExcel d = new ExportToExcel();
            d.OutputAsExcelFile(dataGridView1);
        }
    }
}
