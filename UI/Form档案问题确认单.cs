using BAL;
using MODEL;
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
    public partial class Form档案问题确认单 : Form
    {
        public Form档案问题确认单()
        {
            InitializeComponent();
        }
        string nowrole = "";
        string username = "";
        public Form档案问题确认单(string a, string b, string c, string h):this()
        {
            textBoxXMDW.Text = a;
            textBoxDALX.Text = b;
            textBoxGDFS.Text = c;          
            this.nowrole = h;
       //     MessageBox.Show(nowrole);
        }
        public Form档案问题确认单(string a, string b, string c, string h, string e) : this()
        {
            textBoxXMDW.Text = a;
            textBoxDALX.Text = b;
            textBoxGDFS.Text = c;
  //          textBoxLQPCH.Text = e;
            textBoxNX.Text = h;
            this.nowrole = e;
            textBox.Text = a;
   //         MessageBox.Show(nowrole);
        }
        public Form档案问题确认单(string a, string b, string c, string h, string e,string l) : this()
        {
            textBoxXMDW.Text = a;
            textBoxDALX.Text = b;
            textBoxGDFS.Text = c;
            textBoxLQPCH.Text = e;
            textBoxNX.Text = l;
            this.nowrole = h;
            textBox.Text = a;
            //         MessageBox.Show(nowrole);
        }
        public Form档案问题确认单(string h, string s) : this()
        {
            this.nowrole = h;
            this.username = s;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.Rows.Count;
            int cnt = 0;
            for (int j = 0; j < i - 1; j++)
            {
                getfile g = new getfile();
                g.filetype = textBoxDALX.Text.Trim();
                g.gdmethod = textBoxGDFS.Text.Trim();
                g.getId = textBoxLQPCH.Text.Trim();
                g.gettime = dateTimePickerLQSJ.Value;
                g.processunit = textBoxJGDW.Text.Trim();
                g.projectunit = textBoxXMDW.Text.Trim();
                g.projetunit2 = textBox.Text.Trim();
                g.swapdate = dateTimePicker3.Value;
                g.swapdate2 = dateTimePicker4.Value;
                g.year = textBoxNX.Text.Trim();
                for (int s = 0; s < dataGridView1.ColumnCount; s++)
                {
                    if (this.dataGridView1.Rows[j].Cells[s].Value != null)
                    {
                        string str = this.dataGridView1.Rows[j].Cells[s].Value.ToString();
                        if (s == 0)
                        {
                            g.bh = str;
                        }
                        else if (s == 1)
                        {
                            g.question = str;
                        }
                        else
                        {
                            g.solve = str;
                        }
                    }
                }
                if (nowrole == "【领取】")
                {
                    bool flag = new WorkBAL().Insert3(g);
                    if (flag)
                    {
                        cnt++;
                      
                    }

                }
                else if (nowrole == "【拆分】")
                {
                    bool flag1 = new WorkBAL().Insert6(g);
                    if (flag1)
                    {
                        cnt++;         
                    }
                }
                else if (nowrole == "【著录】")
                {
                    bool flag1 = new WorkBAL().Insert7(g);
                    if (flag1)
                    {
                        cnt++;
                    }
                }
                else if (nowrole == "【编码】")
                {
                    bool flag1 = new WorkBAL().Insert9(g);
                    if (flag1)
                    {
                        cnt++;                     
                    }
                }
                else if (nowrole == "【还原】")
                {
                    bool flag1 = new WorkBAL().Insert11(g);
                    if (flag1)
                    {
                        cnt++;                     
                    }
                }
                else if (nowrole == "【扫描】")
                {
                    bool flag1 = new WorkBAL().Insert13(g);
                    if (flag1)
                    {
                        cnt++;                     
                    }

                }
                else if (nowrole == "【编目】")
                {
                    bool flag1 = new WorkBAL().Insert15(g);
                    if (flag1)
                    {
                        cnt++;
                    }
                }
                else if (nowrole == "【图处】")
                {
                    bool flag1 = new WorkBAL().Insert17(g);
                    if (flag1)
                    {
                        cnt++;                   
                    }
                }
                else if (nowrole == "【质检】")
                {
                    bool flag1 = new WorkBAL().Insert21(g);
                    if (flag1)
                    {
                        cnt++;
                    }

                }
                else if (nowrole == "【挂接】")
                {
                    bool flag1 = new WorkBAL().Insert22(g);
                    if (flag1)
                    {
                        cnt++;
                    }
                }
                else if (nowrole == "【归还】")
                {
                    bool flag1 = new WorkBAL().Insert22(g);
                    if (flag1)
                    {
                        cnt++;
                    }
                }
            }
            if (cnt == i - 1)
            {
                MessageBox.Show("提交成功！");
   //             Form待加工档案 f = new Form待加工档案(nowrole);
    //            f.Show();
     //           this.Hide();

            }
            else
            {
                MessageBox.Show("提交失败失败！");
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
           // object oTemplate = "C:\\Users\\IHCI\\Desktop\\档案领取确认单1.dot";
            //以模板为基础生成文档
            Microsoft.Office.Interop.Word._Document oDoc = oWord.Documents.Add(ref oTemplate, ref oMissing, ref oMissing, ref oMissing);
            //声明书签数组
            object[] oBookMark = new object[10];
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
            //赋值任意数据到书签的位置
            oDoc.Bookmarks.get_Item(ref oBookMark[0]).Range.Text = textBoxXMDW.Text.Trim();
            oDoc.Bookmarks.get_Item(ref oBookMark[1]).Range.Text = textBoxLQPCH.Text.Trim();
            oDoc.Bookmarks.get_Item(ref oBookMark[2]).Range.Text = dateTimePickerLQSJ.Value.ToString("yyyy-MM-dd");
            oDoc.Bookmarks.get_Item(ref oBookMark[3]).Range.Text = textBoxDALX.Text.Trim();
            oDoc.Bookmarks.get_Item(ref oBookMark[4]).Range.Text = textBoxGDFS.Text.Trim();
            oDoc.Bookmarks.get_Item(ref oBookMark[5]).Range.Text = textBoxNX.Text.Trim();
            oDoc.Bookmarks.get_Item(ref oBookMark[6]).Range.Text = textBox.Text.Trim();
            oDoc.Bookmarks.get_Item(ref oBookMark[7]).Range.Text = textBoxJGDW.Text.Trim();
            oDoc.Bookmarks.get_Item(ref oBookMark[8]).Range.Text = dateTimePicker3.Value.ToString("yyyy-MM-dd");
            oDoc.Bookmarks.get_Item(ref oBookMark[9]).Range.Text = dateTimePicker4.Value.ToString("yyyy-MM-dd");

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
