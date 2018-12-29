using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using NAPS2.DI.Modules;
using NAPS2.Logging;
using NAPS2.Util;
using NAPS2.WinForms;
using NAPS2.Worker;
using Ninject;


namespace winform_jump
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private static void RUN(string[] args)
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
        private static void UnhandledException(object sender, ThreadExceptionEventArgs threadExceptionEventArgs)
        {
            Log.FatalException("An error occurred that caused the application to close.", threadExceptionEventArgs.Exception);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] options = new string[2];

            options[0] = "C:\\Users\\jnu\\pictures\\微信图片_20181017171157.jpg";
            options[1] = "C:\\Users\\jnu\\pictures\\微信图片_20181017171157.jpg";
            RUN(options);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }
    }
}
