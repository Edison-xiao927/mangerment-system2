﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MODEL;
using BAL;
using System.Collections;

namespace UI
{
    public delegate void fileDelegate();
    public partial class Form档案领取交接单 : Form
    {
        public Form档案领取交接单()
        {
            InitializeComponent();
        }
        public event fileDelegate raiseCallBackRefreshEvent;
        string projectunit = "";
        string filetype = "";
        string gdmethod = "";
        string year = "";
        string pId = "";
        string getId = "";
        public Form档案领取交接单(string str1, string str2, string str3, string str4, string str5) : this()
        {
            this.projectunit = str1;
            this.filetype = str2;
            this.gdmethod = str3;
            this.year = str4;
            this.pId = str5;
        }
        int ss = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if(ss == 0)
            {
                int i = dataGridView1.Rows.Count;
                int cnt = 0;
                for (int j = 0; j < i - 1; j++)
                {
                    getfile g = new getfile();
                    g.dangId = textBoxDH.Text.Trim();
                    g.filetype = textBoxDALX.Text.Trim();
                    g.gdmethod = textBoxGDFS.Text.Trim();
                    g.getId = textBoxLQPCH.Text.Trim();
                    g.gettime = dateTimePickerlLQSJ.Value;
                    g.processunit = textBoxJGDW.Text.Trim();
                    g.projectunit = textBoxXMDW.Text.Trim();
                    g.projetunit2 = textBox.Text.Trim();
                    g.swapdate = dateTimePickerRQ1.Value;
                    g.swapdate2 = dateTimePickerRQ2.Value;
                    g.year = textBoxNX.Text.Trim();
                    //            g.page = textBoxYS.Text.Trim();
                    getId = g.getId;
                    for (int s = 0; s < dataGridView1.ColumnCount; s++)
                    {

                        if (this.dataGridView1.Rows[j].Cells[s].Value != null)
                        {
                            string str = this.dataGridView1.Rows[j].Cells[s].Value.ToString();
                            if (s == 0)
                            {
                                g.bh = str;
                            }
                            else
                            {
                                g.question = str;
                            }
                        }
                        else
                        {
                            if (s == 0)
                            {
                                g.bh = "";
                            }
                            else
                            {
                                g.question = "";
                            }
                        }
                    }
                    bool flag = new WorkBAL().Insert2(g);
                    if (flag)
                    {
                        cnt++;

                        // 更改档案状态
                        bool flag3 = new projectBAL().insert(pId, getId, g.bh);
                        bool flag2 = new projectBAL().update(getId, g.bh);
                        raiseCallBackRefreshEvent(); //将事件抛出去，在主窗体中接收，并作相应处理    
                                                     //      this.Close();
                    }
                    else
                    {
                        //                   MessageBox.Show("提交失败失败！");
                    }
                }
                if (cnt == i - 1)
                {
                    MessageBox.Show("提交成功！");
                }
                else
                {
                    MessageBox.Show("提交失败失败！");
                }
                ss++;
            }else
            {
                MessageBox.Show("请勿重复提交");
            }
           
        }

        private void Form档案领取交接单_Load(object sender, EventArgs e)
        {
            textBoxDH.Text = pId;
            textBoxDALX.Text = filetype;
            textBoxGDFS.Text = gdmethod;
            textBoxNX.Text = year;
            textBoxXMDW.Text = projectunit;
            textBox.Text = projectunit;
            DataTable dt = new projectBAL().Select1(pId);
            if (dt != null && dt.Rows.Count > 0)
            {
                if (dt.Rows[0][0].ToString() != "")
                {
                    string[] sArray = dt.Rows[0][0].ToString().Split('-');
                    int i = Convert.ToInt32(sArray[1]);
                    i = i + 1;
                    string str = i.ToString("000");
                    str = pId + "-" + str;
                    textBoxLQPCH.Text = str;
                }
                else
                {
                    string str = "001";
                    str = pId + "-" + str;
                    textBoxLQPCH.Text = str;
                }
            }
        }
        private string empUpLoadPictureRealPos;
        private string empUpLoadPictureFormat;
        private void button2_Click_1(object sender, EventArgs e)
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
            //       object oTemplate = "C:\\Users\\IHCI\\Desktop\\档案领取交接单.dot";
            //以模板为基础生成文档
            Microsoft.Office.Interop.Word._Document oDoc = oWord.Documents.Add(ref oTemplate, ref oMissing, ref oMissing, ref oMissing);
            //声明书签数组
            object[] oBookMark = new object[11];
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
            //赋值任意数据到书签的位置
            oDoc.Bookmarks.get_Item(ref oBookMark[0]).Range.Text = textBoxXMDW.Text.Trim();
            oDoc.Bookmarks.get_Item(ref oBookMark[1]).Range.Text = textBoxLQPCH.Text.Trim();
            oDoc.Bookmarks.get_Item(ref oBookMark[2]).Range.Text = dateTimePickerlLQSJ.Value.ToString("yyyy-MM-dd");
            oDoc.Bookmarks.get_Item(ref oBookMark[3]).Range.Text = textBoxDALX.Text.Trim();
            oDoc.Bookmarks.get_Item(ref oBookMark[4]).Range.Text = textBoxGDFS.Text.Trim();
            oDoc.Bookmarks.get_Item(ref oBookMark[5]).Range.Text = textBoxNX.Text.Trim();
            oDoc.Bookmarks.get_Item(ref oBookMark[6]).Range.Text = textBox.Text.Trim();
            oDoc.Bookmarks.get_Item(ref oBookMark[7]).Range.Text = textBoxJGDW.Text.Trim();
            oDoc.Bookmarks.get_Item(ref oBookMark[8]).Range.Text = dateTimePickerRQ1.Value.ToString("yyyy-MM-dd");
            oDoc.Bookmarks.get_Item(ref oBookMark[9]).Range.Text = dateTimePickerRQ2.Value.ToString("yyyy-MM-dd");
            oDoc.Bookmarks.get_Item(ref oBookMark[10]).Range.Text = textBoxDH.Text.Trim();

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
    public class ExportToExcel
    {
        public Microsoft.Office.Interop.Excel.Application m_xlApp = null;

        public void OutputAsExcelFile(DataGridView dataGridView)
        {
            if (dataGridView.Rows.Count <= 0)
            {
                MessageBox.Show("无数据！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            string filePath = "";
            SaveFileDialog s = new SaveFileDialog();
            s.Title = "保存Excel文件";
            s.Filter = "Excel文件(*.xls)|*.xls";
            s.FilterIndex = 1;
            if (s.ShowDialog() == DialogResult.OK)
                filePath = s.FileName;
            else
                return;

            //第一步：将dataGridView转化为dataTable,这样可以过滤掉dataGridView中的隐藏列

            DataTable tmpDataTable = new DataTable("tmpDataTable");
            DataTable modelTable = new DataTable("ModelTable");
            for (int column = 0; column < dataGridView.Columns.Count; column++)
            {
                if (dataGridView.Columns[column].Visible == true)
                {
                    DataColumn tempColumn = new DataColumn(dataGridView.Columns[column].HeaderText, typeof(string));
                    tmpDataTable.Columns.Add(tempColumn);
                    DataColumn modelColumn = new DataColumn(dataGridView.Columns[column].Name, typeof(string));
                    modelTable.Columns.Add(modelColumn);
                }
            }
            for (int row = 0; row < dataGridView.Rows.Count; row++)
            {
                if (dataGridView.Rows[row].Visible == false)
                    continue;
                DataRow tempRow = tmpDataTable.NewRow();
                for (int i = 0; i < tmpDataTable.Columns.Count; i++)
                    tempRow[i] = dataGridView.Rows[row].Cells[modelTable.Columns[i].ColumnName].Value;
                tmpDataTable.Rows.Add(tempRow);
            }
            if (tmpDataTable == null)
            {
                return;
            }

            //第二步：导出dataTable到Excel
            long rowNum = tmpDataTable.Rows.Count;//行数
            int columnNum = tmpDataTable.Columns.Count;//列数
            Microsoft.Office.Interop.Excel.Application m_xlApp = new Microsoft.Office.Interop.Excel.Application();
            m_xlApp.DisplayAlerts = false;//不显示更改提示
            m_xlApp.Visible = false;

            Microsoft.Office.Interop.Excel.Workbooks workbooks = m_xlApp.Workbooks;
            Microsoft.Office.Interop.Excel.Workbook workbook = workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];//取得sheet1

            try
            {
                string[,] datas = new string[rowNum + 1, columnNum];
                for (int i = 0; i < columnNum; i++) //写入字段
                    datas[0, i] = tmpDataTable.Columns[i].Caption;
                //Excel.Range range = worksheet.get_Range(worksheet.Cells[1, 1], worksheet.Cells[1, columnNum]);
                Microsoft.Office.Interop.Excel.Range range = m_xlApp.Range[worksheet.Cells[1, 1], worksheet.Cells[1, columnNum]];
                range.Interior.ColorIndex = 15;//15代表灰色
                range.Font.Bold = true;
                range.Font.Size = 10;

                int r = 0;
                for (r = 0; r < rowNum; r++)
                {
                    for (int i = 0; i < columnNum; i++)
                    {
                        object obj = tmpDataTable.Rows[r][tmpDataTable.Columns[i].ToString()];
                        datas[r + 1, i] = obj == null ? "" : "'" + obj.ToString().Trim();//在obj.ToString()前加单引号是为了防止自动转化格式
                    }
                    System.Windows.Forms.Application.DoEvents();
                    //添加进度条
                }
                //Excel.Range fchR = worksheet.get_Range(worksheet.Cells[1, 1], worksheet.Cells[rowNum + 1, columnNum]);
                Microsoft.Office.Interop.Excel.Range fchR = m_xlApp.Range[worksheet.Cells[1, 1], worksheet.Cells[rowNum + 1, columnNum]];
                fchR.Value2 = datas;

                worksheet.Columns.EntireColumn.AutoFit();//列宽自适应。
                                                         //worksheet.Name = "dd";

                //m_xlApp.WindowState = Excel.XlWindowState.xlMaximized;
                m_xlApp.Visible = false;

                // = worksheet.get_Range(worksheet.Cells[1, 1], worksheet.Cells[rowNum + 1, columnNum]);
                range = m_xlApp.Range[worksheet.Cells[1, 1], worksheet.Cells[rowNum + 1, columnNum]];

                //range.Interior.ColorIndex = 15;//15代表灰色
                range.Font.Size = 9;
                range.RowHeight = 14.25;
                range.Borders.LineStyle = 1;
                range.HorizontalAlignment = 1;
                workbook.Saved = true;
                workbook.SaveCopyAs(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("导出异常：" + ex.Message, "导出异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                EndReport();
            }

            m_xlApp.Workbooks.Close();
            m_xlApp.Workbooks.Application.Quit();
            m_xlApp.Application.Quit();
            m_xlApp.Quit();
            MessageBox.Show("导出成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void EndReport()
        {
            object missing = System.Reflection.Missing.Value;
            try
            {
                //m_xlApp.Workbooks.Close();
                //m_xlApp.Workbooks.Application.Quit();
                //m_xlApp.Application.Quit();
                //m_xlApp.Quit();
            }
            catch { }
            finally
            {
                try
                {
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(m_xlApp.Workbooks);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(m_xlApp.Application);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(m_xlApp);
                    m_xlApp = null;
                }
                catch { }
                try
                {
                    //清理垃圾进程
                    this.killProcessThread();
                }
                catch { }
                GC.Collect();
            }
        }

        private void killProcessThread()
        {
            ArrayList myProcess = new ArrayList();
            for (int i = 0; i < myProcess.Count; i++)
            {
                try
                {
                    System.Diagnostics.Process.GetProcessById(int.Parse((string)myProcess[i])).Kill();
                }
                catch { }
            }
        }
        
    }
}
