using BAL;
using NAPS2.DI.Modules;
using NAPS2.Util;
using NAPS2.WinForms;
using NAPS2.Worker;
using Ninject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Form图处管理 : Form
    {
        Process p;
        [DllImport("user32.dll")]
        private static extern int SetParent(IntPtr hWndChild, IntPtr hWndParent);

        [DllImport("user32.dll")]
        private static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool PostMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);

        [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
        private static extern bool SetWindowPos(IntPtr hWnd, int hWndInsertAfter,
                  int X, int Y, int cx, int cy, uint uFlags);

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        private static extern uint SetWindowLong(IntPtr hwnd, int nIndex, uint newLong);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        private static extern uint GetWindowLong(IntPtr hwnd, int nIndex);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern bool ShowWindow(IntPtr hWnd, short State);

        private const int HWND_TOP = 0x0;
        private const int WM_COMMAND = 0x0112;
        private const int WM_QT_PAINT = 0xC2DC;
        private const int WM_PAINT = 0x000F;
        private const int WM_SIZE = 0x0005;
        private const int SWP_FRAMECHANGED = 0x0020;
        public enum ShowWindowStyles : short
        {
            SW_SHOWNORMAL = 1,
            SW_NORMAL = 1,
            SW_SHOWMINIMIZED = 2,
            SW_SHOWMAXIMIZED = 3,
            SW_MAXIMIZE = 3,
            SW_SHOWNOACTIVATE = 4,
            SW_SHOW = 5,
            SW_MINIMIZE = 6,
            SW_SHOWMINNOACTIVE = 7,
            SW_SHOWNA = 8,
            SW_RESTORE = 9,
            SW_SHOWDEFAULT = 10,
            SW_FORCEMINIMIZE = 11,
            SW_MAX = 11
        }
        public Form图处管理()
        {
            InitializeComponent();
        }
        string lzId = "";
        string pId = "";
        string gdmethod = "";
        string bh = "";
        public Form图处管理(string str, string str2) : this()
        {
            this.lzId = str;
            this.bh = str2;
        }
        int ll = 0;//ll为项目的行数
        int la = 0;
        int lw = 0;

        private void Form图处管理_Load(object sender, EventArgs e)
        {
            DataTable dt11 = new ZLXIBAL().Select7(lzId);
            pId = dt11.Rows[0][0].ToString();
            DataTable dt = new ZLXIBAL().Select3(lzId);
            gdmethod = dt.Rows[0][0].ToString();
            if (gdmethod == "项目")
            {
                DataTable dt3 = new ZLXIBAL().Select2(pId,lzId);
                DataTable dt1 = new DataTable();
                DataTable dt2 = new ZLXIBAL().Select1();

                int i = 0;
                int cnt = 0;
                while (i < dt2.Rows.Count)
                {

                    dt1.Columns.Add(dt2.Rows[i][0].ToString(), typeof(string));
                    cnt++;
                    i++;
                }

                for (int ss = 0; ss < dt3.Rows.Count;)
                {

                    DataRow dr = dt1.NewRow();
                    for (int w = 0; w < cnt; w++)
                    {
                        dr[dt2.Rows[w][0].ToString()] = dt3.Rows[ss][0].ToString();
                        ss++;
                    }
                    ll++;
                    dt1.Rows.Add(dr);
                }
                dataGridView1.DataSource = dt1;
                

            }

            else if (gdmethod == "案卷")
            {
                dataGridView1.ReadOnly = true;
                DataTable dt12 = new ZLBAL().Select112(pId,lzId);
                DataTable dt111 = new DataTable();
                DataTable dt5 = new AABAL().Select6(pId);
                int m = 0;
                int cnt2 = 0;
                while (m < dt5.Rows.Count)
                {

                    dt111.Columns.Add(dt5.Rows[m][0].ToString(), typeof(string));
                    cnt2++;
                    m++;
                }
                for (int ss = 0; ss < dt12.Rows.Count;)
                {

                    DataRow dr = dt111.NewRow();
                    for (int w = 0; w < cnt2; w++)
                    {
                        dr[dt5.Rows[w][0].ToString()] = dt12.Rows[ss][1].ToString();
                        ss++;
                    }
                    ll++;
                    dt111.Rows.Add(dr);
                }
                dataGridView2.DataSource = dt111;
               
            }
            else
            {

                dataGridView1.ReadOnly = true;
                dataGridView2.ReadOnly = true;

                DataTable dt22 = new ZLBAL().Select1113(pId,lzId);

                DataTable dt1 = new DataTable();
                DataTable dt2 = new ZLXIBAL().Select6(pId);

                int j = 0;
                int cnt3 = 0;
                while (j < dt2.Rows.Count)
                {
                    dt1.Columns.Add(dt2.Rows[j][0].ToString(), typeof(string));
                    cnt3++;
                    j++;
                }

                for (int ss = 0; ss < dt22.Rows.Count;)
                {

                    DataRow dr = dt1.NewRow();
                    for (int w = 0; w < cnt3; w++)
                    {
                        dr[dt2.Rows[w][0].ToString()] = dt22.Rows[ss][1].ToString();
                        ss++;
                    }
                    lw++;
                    dt1.Rows.Add(dr);
                }
                dataGridView3.DataSource = dt1;

                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.Name = "btnck";
                btn.HeaderText = "查看";
                btn.DefaultCellStyle.NullValue = "查看";
                dataGridView3.Columns.Add(btn);

                DataGridViewButtonColumn btn2 = new DataGridViewButtonColumn();
                btn2.Name = "btntc";
                btn2.HeaderText = "图处";
                btn2.DefaultCellStyle.NullValue = "图处";
                dataGridView3.Columns.Add(btn2);
            }
        }
        int top1 = 0;
        string xmname = "";//获取选中的改行的项目题名

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridView1.Rows[e.RowIndex].Cells[0].EditedFormattedValue.ToString() == "True")
            {
                int st = e.RowIndex;
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {

                    if (i != st)
                    {
                        dataGridView1.Rows[i].Cells[0].Value = false;
                    }
                }

            }
            
            int count = dataGridView1.Rows.Count;
            for (int j = 0; j < count; j++)
            {
                if ((bool)dataGridView1.Rows[j].Cells[0].EditedFormattedValue == true)
                {
                    //string xmh = dataGridView1.Rows[j].Cells[1].Value.ToString();
                    xmname = dataGridView1.Rows[j].Cells["项目题名"].Value.ToString();
                    // DataTable dt5 = new ZLXIBAL().Select4(pId);
                    DataTable dt5 = new ZLXIBAL().Select99(pId, xmname);

                    DataTable dt6 = new DataTable();
                    DataTable dt7 = new ZLXIBAL().Select5(pId);

                    int k = 0;
                    int cnt2 = 0;
                    while (k < dt7.Rows.Count)
                    {

                        dt6.Columns.Add(dt7.Rows[k][0].ToString(), typeof(string));
                        cnt2++;
                        k++;
                    }

                    for (int ss = 0; ss < dt5.Rows.Count;)
                    {

                        DataRow dr = dt6.NewRow();
                        for (int w = 0; w < cnt2; w++)
                        {
                            dr[dt7.Rows[w][0].ToString()] = dt5.Rows[ss][0].ToString();
                            ss++;
                        }
                        la++;
                        dt6.Rows.Add(dr);
                    }
                    dataGridView2.AllowUserToAddRows = false;

                    while (this.dataGridView2.Rows.Count != 0)
                    {
                        this.dataGridView2.Rows.RemoveAt(0);
                    }
                    dataGridView2.DataSource = dt6;
                }
            }
            if (top1 == 0)
            {
                
            }
        }
        int n = 0;
        string ajname = "";

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridView2.Rows[e.RowIndex].Cells[0].EditedFormattedValue.ToString() == "True")
            {
                int st = e.RowIndex;
                for (int i = 0; i < dataGridView2.RowCount - 1; i++)
                {

                    if (i != st)
                    {
                        dataGridView2.Rows[i].Cells[0].Value = false;
                    }
                }

                
            }
            int count = dataGridView2.Rows.Count;
            for (int i = 0; i < count; i++)
            {
                if ((bool)dataGridView2.Rows[i].Cells[0].EditedFormattedValue == true)
                {
                    DataTable dt11 = new ZLXIBAL().Select7(lzId);
                    //string xmh = dt11.Rows[0][0].ToString();
                    ajname = dataGridView2.Rows[i].Cells["案卷题名"].Value.ToString();

                    DataTable dt = new ZLXIBAL().Select8(pId, ajname);

                    DataTable dt1 = new DataTable();
                    DataTable dt2 = new ZLXIBAL().Select6(pId);

                    int j = 0;
                    int cnt3 = 0;
                    while (j < dt2.Rows.Count)
                    {

                        dt1.Columns.Add(dt2.Rows[j][0].ToString(), typeof(string));
                        cnt3++;
                        j++;
                    }

                    for (int ss = 0; ss < dt.Rows.Count;)
                    {

                        DataRow dr = dt1.NewRow();
                        for (int w = 0; w < cnt3; w++)
                        {
                            dr[dt2.Rows[w][0].ToString()] = dt.Rows[ss][0].ToString();
                            ss++;
                        }
                        lw++;
                        dt1.Rows.Add(dr);
                    }
                    dataGridView3.AllowUserToAddRows = false;

                    while (this.dataGridView3.Rows.Count != 0)
                    {
                        this.dataGridView3.Rows.RemoveAt(0);
                    }
                    dataGridView3.DataSource = dt1;
                }
            }
            if (n == 0)
            {
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.Name = "btnck";
                btn.HeaderText = "查看";
                btn.DefaultCellStyle.NullValue = "查看";
                dataGridView3.Columns.Add(btn);

                DataGridViewButtonColumn btn2 = new DataGridViewButtonColumn();
                btn2.Name = "btntc";
                btn2.HeaderText = "图处";
                btn2.DefaultCellStyle.NullValue = "图处";
                dataGridView3.Columns.Add(btn2);
                n++;
            }
        }
        public void RUN(string[] args)
        {
            var kernel = new StandardKernel(new CommonModule(), new WinFormsModule());

            NAPS2.Paths.ClearTemp();

            // Parse the command-line arguments and see if we're doing something other than displaying the main form
            var lifecycle = kernel.Get<Lifecycle>();
            lifecycle.ParseArgs(args);
            lifecycle.ExitIfRedundant();

            // Start a pending worker process

            WorkerManager.Init();

            // Set up basic application configuration
            kernel.Get<CultureInitializer>().InitCulture(Thread.CurrentThread);
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.ThreadException += UnhandledException;

            // Show the main form
            var formFactory = kernel.Get<IFormFactory>();
            var desktop = formFactory.Create<FDesktop>();
            Invoker.Current = desktop;
            //Application.Run(desktop);
            desktop.setInitialPath(args);
            desktop.ShowDialog();
        }
        private int index = -1;
        string[] filescpoy;
        int cnt111 = 0;
        List<string> lstImgPath = new List<string>();
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView3.Columns[e.ColumnIndex].Name == "btnck" && e.RowIndex >= 0)
            {
                string str1 = dataGridView3.Rows[e.RowIndex].Cells[1].Value.ToString();
                Form4 form = new Form4(str1,pId);
                form.ShowDialog();
            }
            else if(dataGridView3.Columns[e.ColumnIndex].Name == "btntc" && e.RowIndex >= 0)
            {
                /*   p = new Process();
                   //需要启动的程序
                   p.StartInfo.FileName = @"D:\scan\NAPS2\NAPS2.exe";
                   //为了美观,启动的时候最小化程序
                   //         p.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
                   //启动
                   p.Start();*/

                string dangId = dataGridView3.Rows[e.RowIndex].Cells[1].Value.ToString();
                string mImagePath = "";
                index = -1;
                lstImgPath = new List<string>();
                DataTable dt = new ZLXIBAL().Select1128(pId);
                string aaaa = dt.Rows[0][0].ToString();
                aaaa = aaaa.Replace("\\", "\\\\");
                //        mImagePath = mRunPath + a + "\\";
                mImagePath = aaaa + "\\" + dangId;
                //    string[] files = Directory.GetFiles((System.IO.Directory.GetCurrentDirectory() + "\\" + dangId + ""));
                string[] files = Directory.GetFiles((mImagePath + ""));
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
                string[] options = new string[lstImgPath.Count];
                for (int i = 0; i < lstImgPath.Count; i++)
                {
                    options[i] = lstImgPath[i];
                }


            //    options[0] = "C:\\Users\\jnu\\pictures\\微信图片_20181017171157.jpg";
            //    options[1] = "C:\\Users\\jnu\\pictures\\微信图片_20181017171157.jpg";
                RUN(options);
            }
        }
    }
}
