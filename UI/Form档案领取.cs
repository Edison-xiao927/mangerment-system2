using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
using NAPS2.DI;
using NAPS2.DI.Modules;
using NAPS2.Util;
using NAPS2.WinForms;
using NAPS2.Worker;
using Ninject;

namespace UI
{
    public partial class Form档案领取 : Form
    {
        public Form档案领取()
        {
            InitializeComponent();
        }
        string nowrole = "";
  //      string username = "";
        public Form档案领取(string str1) : this()
        {
            this.nowrole = str1;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int a = dataGridView1.CurrentRow.Index;
            string str = dataGridView1.Rows[a].Cells["项目号"].Value.ToString();
            DataTable dt = new projectBAL().Select(str);
            string s = "";
            string ss = "";
            string sss = "";
            string ssss = "";
            string sssss = "";
            if (dt != null && dt.Rows.Count > 0)
            {
                s = dt.Rows[0][0].ToString();
                ss = dt.Rows[0][1].ToString();
                sss = dt.Rows[0][2].ToString();
                ssss = dt.Rows[0][3].ToString();
                sssss = dt.Rows[0][4].ToString();
            }
            Form档案领取交接单 form = new Form档案领取交接单(s, ss, sss, ssss, sssss);
            // this.Hide();
            form.raiseCallBackRefreshEvent += new fileDelegate(childfrm_raiseCallBackRefreshEvent); //注册回调事件，也即将子窗体抛出的事件接收，然后处理
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = dataGridView1.CurrentRow.Index;
            string str = dataGridView1.Rows[a].Cells["项目号"].Value.ToString();
            DataTable dt = new projectBAL().Select(str);
            string s = "";
            string ss = "";
            string sss = "";
            string ssss = "";
            string sssss = "";
            if (dt != null && dt.Rows.Count > 0)
            {
                s = dt.Rows[0][0].ToString();
                ss = dt.Rows[0][1].ToString();
                sss = dt.Rows[0][2].ToString();
                ssss = dt.Rows[0][3].ToString();
                sssss = dt.Rows[0][4].ToString();
            }
            Form档案问题确认单 form = new Form档案问题确认单(s, ss, sss,ssss, nowrole);
            // this.Hide();

            form.ShowDialog();
        }

        private void Form档案领取_Load(object sender, EventArgs e)
        {
            DataSet ds = new GetJobBAL().Select();
            DataTable dt = new projectBAL().Select1127();
            dt.Columns.Add("已领取批次数", typeof(string));
            int i = 0;
            foreach (DataRow dr in dt.Rows)
            {
                DataTable dt1 = new projectBAL().Select112701(dt.Rows[i++][0].ToString());
                dr["已领取批次数"] = dt1.Rows.Count;
            }
            dataGridView1.DataSource = dt;
        }
        private void childfrm_raiseCallBackRefreshEvent()
        {
            Form档案领取_Load(null, null); //刷新主窗体
        }



        private void button3_Click_1(object sender, EventArgs e)
        {
            int a = dataGridView1.CurrentRow.Index;
            string pId = dataGridView1.Rows[a].Cells["项目号"].Value.ToString();
            Form批次具体查看 f = new Form批次具体查看(pId);
            this.Hide();
            f.ShowDialog();
            this.Close();
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
        private void button4_Click(object sender, EventArgs e)
        {
              string[] options = new string[2];

            options[0] = "C:\\Users\\jnu\\pictures\\微信图片_20181017171157.jpg";
            options[1] = "C:\\Users\\jnu\\pictures\\微信图片_20181017171157.jpg";
            RUN(options);
        }
    }
}
