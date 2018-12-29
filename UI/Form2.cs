using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CSharpWin_JD.CaptureImage;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace UI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string dangId = "";
        //  string nowrole = "";
        string imagePath = "";
        private string empUpLoadPictureRealPos;
        private string empUpLoadPictureFormat;
        string pId = "";
        public Form2(string str1) : this()
        {
            this.imagePath = str1;
        }
        public Form2(string str1,string str2,string str3) : this()
        {
            this.imagePath = str1;
            this.dangId = str2;
            this.pId = str3;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            //上传相片

            try
            {
                OpenFileDialog openFileDialogEmpImage = new OpenFileDialog();
                openFileDialogEmpImage.Filter = "*.jpg|*.jpg|*.png|*.png|*.bmp|*.bmp|*.tiff|*.tiff";//图片格式
                if (openFileDialogEmpImage.ShowDialog() == DialogResult.OK)
                {
                    //           isUpLoadPicture = true;//记录是否上传了相片，用于后面保存操作使用：是一个成员变
                    try
                    {
                        empUpLoadPictureRealPos = openFileDialogEmpImage.FileName;//实际的文件路径+文件名
                        String[] empImageData = empUpLoadPictureRealPos.Split('.');
                        //empImageData[1]:是上传的图片的后缀名
                        empUpLoadPictureFormat = empImageData[1];
                        pictureBox1.Image = Image.FromFile(empUpLoadPictureRealPos);//将图片显示在pitureBox控件中
                        this.pictureBox1.ImageLocation = openFileDialogEmpImage.FileName;
                    }
                    catch
                    {
                        MessageBox.Show("您选择的图片不能被读取或文件类型不对！", "错误信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("上传相片出错: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string st = "";
            st = imagePath;
           if (pictureBox1.Image != null)
            {
                Bitmap map = new Bitmap(pictureBox1.Image);
                       /*       using (SaveFileDialog saveDlg = new SaveFileDialog())
                               {
                                   saveDlg.InitialDirectory = ".";
                                   saveDlg.Filter = "JPG File(*.jpg)|*.jpg|png|*.png|gif|*.gif";
                                   saveDlg.RestoreDirectory = true;
                                   //             saveDlg.FileName = "targetPic";


                                   if (saveDlg.ShowDialog() == DialogResult.OK)
                                   {
                                       //    map = KiCut(map, m_Rect.X * map.Width / pictureBox1.Width, m_Rect.Y * map.Height / pictureBox1.Height, map.Width * m_Rect.Width / pictureBox1.Width, map.Height * m_Rect.Height / pictureBox1.Height);  //通过比例换算裁剪图片保证裁剪结果的正确
                                       map.Save(saveDlg.FileName, ImageFormat.Png);
                                   }
                                   st = saveDlg.FileName;
                               }*/
                //   string st = pictureBox1.ImageLocation.Trim();
                //    int a = dataGridView1.CurrentRow.Index;
                //     string str = dataGridView1.Rows[a].Cells["档号"].Value.ToString();
   //             st = st.Replace("\\", "\\\\");
                map.Save(st, ImageFormat.Png);
                MessageBox.Show("保存成功");
            }
            else
            {
                MessageBox.Show("Please load a picture first！");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap a = new Bitmap(pictureBox1.Image);//得到图片框中的图片
                pictureBox1.Image = Rotate(a, Convert.ToInt32(textBox1.Text));
                //              pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                //               pictureBox1.Location = panel1.Location;
                pictureBox1.Refresh();//最后刷新图片框
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox1.Refresh();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CaptureImageTool capture = new CaptureImageTool();
            //capture.SelectCursor = new Cursor(Properties.Resources.Arrow_M.Handle); 
            if (capture.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Dispose();
                Image image = capture.Image;
                //       pictureBox1.Width = image.Width;
                //       pictureBox1.Height = image.Height;
                pictureBox1.Image = image;
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            HotKey.RegisterHotKey(Handle, 102, HotKey.KeyModifiers.Alt | HotKey.KeyModifiers.Ctrl, Keys.S);
        }

        private void Form1_Leave(object sender, EventArgs e)
        {
            HotKey.UnregisterHotKey(Handle, 102);
        }
        public Bitmap Rotate(Bitmap b, int angle)
        {
            angle = angle % 360;

            //弧度转换
            double radian = angle * Math.PI / 180.0;
            double cos = Math.Cos(radian);
            double sin = Math.Sin(radian);

            //原图的宽和高
            int w = b.Width;
            int h = b.Height;
            int W = (int)(Math.Max(Math.Abs(w * cos - h * sin), Math.Abs(w * cos + h * sin)));
            int H = (int)(Math.Max(Math.Abs(w * sin - h * cos), Math.Abs(w * sin + h * cos)));

            //目标位图
            Bitmap dsImage = new Bitmap(W, H);
            Graphics g = Graphics.FromImage(dsImage);

            g.InterpolationMode = InterpolationMode.Bilinear;

            g.SmoothingMode = SmoothingMode.HighQuality;

            //计算偏移量
            Point Offset = new Point((W - w) / 2, (H - h) / 2);

            //构造图像显示区域：让图像的中心与窗口的中心点一致
            Rectangle rect = new Rectangle(Offset.X, Offset.Y, w, h);
            Point center = new Point(rect.X + rect.Width / 2, rect.Y + rect.Height / 2);
            g.TranslateTransform(center.X, center.Y);
            g.RotateTransform(360 - angle);

            //恢复图像在水平和垂直方向的平移
            g.TranslateTransform(-center.X, -center.Y);
            g.DrawImage(b, rect);

            //重至绘图的所有变换
            g.ResetTransform();

            g.Save();
            g.Dispose();
            return dsImage;
        }
        protected override void WndProc(ref Message m)
        {
            const int WM_HOTKEY = 0x0312;//如果m.Msg的值为0x0312那么表示用户按下了热键
            //按快捷键 
            switch (m.Msg)
            {
                case WM_HOTKEY:
                    switch (m.WParam.ToInt32())
                    {
                        case 100:    //按下的是Shift+S
                            //此处填写快捷键响应代码         
                            break;
                        case 101:    //按下的是Ctrl+B
                            //此处填写快捷键响应代码
                            break;
                        case 102:    //按下的是Ctrl+Alt+S
                            CaptureImageTool capture = new CaptureImageTool();

                            if (capture.ShowDialog() == DialogResult.OK)
                            {
                                Image image = capture.Image;
                                pictureBox1.Width = image.Width;
                                pictureBox1.Height = image.Height;
                                pictureBox1.Image = image;
                            }
                            break;
                    }
                    break;
            }
            base.WndProc(ref m);
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(imagePath);
            bmp = RemoveBlackEdge(bmp);
            gmseDeskew sk = new gmseDeskew(bmp);
            double skewangle = sk.GetSkewAngle();
            Bitmap bmp11 = RotateImage(bmp, -skewangle);
            
            //新建第二个bitmap类型的bmp2变量，我这里是根据我的程序需要设置的。
            Bitmap bmp2 = new Bitmap(1120, 1435, PixelFormat.Format16bppRgb555);
            //将第一个bmp拷贝到bmp2中
            Graphics draw = Graphics.FromImage(bmp2);
            draw.DrawImage(bmp11, 0, 0);
   //          pictureBox1.Image = bmp2;//读取bmp2到picturebox
                                     //     name = openFileDialogEmpImage.FileName;
                                     //      openFileDialogEmpImage.Dispose();
            draw.Dispose();
            bmp.Dispose();//释放bmp文件资源
             //blackedge remove and return bmp
            pictureBox1.Image = null;         
            pictureBox1.Image = bmp2;
            pictureBox1.Refresh();
        }
        public static void AutoCutBlackEdge(string fileName)
        {
           
        }
        public Bitmap ATUO(Bitmap bmp)
        {
            Graphics g = null;
            Bitmap tmp1 = new Bitmap(bmp.Width, bmp.Height, PixelFormat.Format32bppRgb);
            return tmp1;
        }
        public Bitmap RotateImage(Bitmap bmp, double angle)
        {
            Graphics g = null;
            Bitmap tmp = new Bitmap(bmp.Width, bmp.Height, PixelFormat.Format32bppRgb);
            tmp.SetResolution(bmp.HorizontalResolution, bmp.VerticalResolution);
            g = Graphics.FromImage(tmp);
            try
            {
                g.FillRectangle(Brushes.White, 0, 0, bmp.Width, bmp.Height);
                g.RotateTransform((float)angle);
                g.DrawImage(bmp, 0, 0);
            }
            finally
            {
                g.Dispose();
            }
            return tmp;
        }
        private static byte[] rgbValues; // 目标数组内存

        /// <summary>
        /// 图像去黑边
        /// </summary>
        /// <param name="bmp"></param>
        /// <returns></returns>
        private static Bitmap RemoveBlackEdge(Bitmap bmp)
        {
            try
            {
                Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
                BitmapData bmpData = bmp.LockBits(rect, ImageLockMode.ReadWrite, bmp.PixelFormat);

                // 获取图像参数  
                int w = bmpData.Width;
                int h = bmpData.Height;
                int stride = bmpData.Stride;  // 扫描线的宽度 
                double picByteSize = GetPicByteSize(bmp.PixelFormat);
                int bWidth = (int)Math.Ceiling(picByteSize * w); //显示宽度
                int offset = stride - bWidth;  // 显示宽度与扫描线宽度的间隙  
                IntPtr ptr = bmpData.Scan0;   // 获取bmpData的内存起始位置  
                int scanBytes = stride * h + 1;  // 用stride宽度，表示这是内存区域的大小

                // 分别设置两个位置指针，指向源数组和目标数组  
                int posScan = 0;
                rgbValues = new byte[scanBytes];  // 为目标数组分配内存  
                Marshal.Copy(ptr, rgbValues, 0, scanBytes);  // 将图像数据拷贝到rgbValues中 

                bool isPass = true;
                int i = 0, j = 0;
                int cutW = (int)(bWidth * 0.02); //2%宽度（可修改）
                int cutH = (int)(h * 0.02);      //2%高度（可修改）
                int posLen = (int)(picByteSize * 4); //继续查找深度为8的倍数（可修改）
                                                     //左边
                for (i = 0; i < h; i++)
                {
                    for (j = 0; j < bWidth; j++)
                    {
                        isPass = true;
                        if (rgbValues[posScan] < 255) rgbValues[posScan] = 255;

                        if (rgbValues[posScan + 1] == 255)
                        {
                            for (int m = 1; m <= posLen; m++)
                            {
                                if (rgbValues[posScan + m] < 255) isPass = false;
                            }
                        }
                        if (rgbValues[posScan + 1] < 255 || bWidth / 2 < j) isPass = false;
                        recCheck(ref rgbValues, posScan, h, stride, true);

                        posScan++;
                        if (j >= cutW && isPass) break;
                    }
                    // 跳过图像数据每行未用空间的字节，length = stride - width * bytePerPixel  
                    if (j == bWidth) posScan += offset;
                    else posScan += (offset + bWidth - j - 1);
                }
                //右边
                posScan = scanBytes - 1;
                for (i = h - 1; i >= 0; i--)
                {
                    posScan -= offset;
                    for (j = bWidth - 1; j >= 0; j--)
                    {
                        isPass = true;
                        if (rgbValues[posScan] < 255) rgbValues[posScan] = 255;

                        if (rgbValues[posScan - 1] == 255)
                        {
                            for (int m = 1; m <= posLen; m++)
                            {
                                if (rgbValues[posScan - m] < 255) isPass = false;
                            }
                        }
                        if (rgbValues[posScan - 1] < 255 || bWidth / 2 > j) isPass = false;
                        recCheck(ref rgbValues, posScan, h, stride, false);

                        posScan--;
                        if (cutH < (h - i))
                            if (j < (bWidth - cutW) && isPass) break;
                    }
                    // 跳过图像数据每行未用空间的字节，length = stride - width * bytePerPixel
                    if (j != -1) posScan -= j;
                }

                // 内存解锁  
                Marshal.Copy(rgbValues, 0, ptr, scanBytes);
                bmp.UnlockBits(bmpData);  // 解锁内存区域 

                return bmp;
            }
            catch
            {
               return bmp;      
            }
       
        }
        private static double GetPicByteSize(PixelFormat bmpPixelFormat)
        {
            double picByteSize;
            if (bmpPixelFormat == PixelFormat.Format24bppRgb) picByteSize = 3;
            else if (bmpPixelFormat == PixelFormat.Format32bppArgb) picByteSize = 4;
            else if (bmpPixelFormat == PixelFormat.Format8bppIndexed) picByteSize = (double)3 / 24 * 8;
            else if (bmpPixelFormat == PixelFormat.Format1bppIndexed) picByteSize = (double)3 / 24;
            else if (bmpPixelFormat == PixelFormat.Format4bppIndexed) picByteSize = (double)3 / 24 * 4;
            else picByteSize = 3;

            return picByteSize;
        }
        /// <summary>
        /// 上下去除黑边时，临近黑点去除
        /// </summary>
        /// <param name="rgbValues"></param>
        /// <param name="posScan"></param>
        /// <param name="h"></param>
        /// <param name="stride"></param>
        /// <param name="islLeft"></param>
        private static void recCheck(ref byte[] rgbValues, int posScan, int h, int stride, bool islLeft)
        {
            int scanBytes = h * stride;
            int cutH = (int)(h * 0.01); //临近最大1%高度（可修改）
            for (int i = 1; i <= cutH; i++)
            {
                int befRow = 0;
                if (islLeft && (posScan - stride * i) > 0)
                {
                    befRow = posScan - stride * i;
                }
                else if (!islLeft && (posScan + stride * i) < scanBytes)
                {
                    befRow = posScan + stride * i;
                }
                if (rgbValues[befRow] < 255) rgbValues[befRow] = 255;
                else break;
            }
        }

        public class gmseDeskew
        {
            public class HougLine
            {
                // Count of points in the line.
                public int Count;
                // Index in Matrix.
                public int Index;
                // The line is represented as all x,y that solve y*cos(alpha)-x*sin(alpha)=d 
                public double Alpha;
                public double d;
            }
            Bitmap cBmp;
            double cAlphaStart = -20;
            double cAlphaStep = 0.2;
            int cSteps = 40 * 5;
            double[] cSinA;
            double[] cCosA;
            double cDMin;
            double cDStep = 1;
            int cDCount;
            // Count of points that fit in a line.
            int[] cHMatrix;
            public double GetSkewAngle()
            {
                gmseDeskew.HougLine[] hl = null;
                int i = 0;
                double sum = 0;
                int count = 0;
                // Hough Transformation 

                Calc();
                // Top 20 of the detected lines in the image.
                hl = GetTop(20);
                // Average angle of the lines
                for (i = 0; i <= 19; i++)
                {
                    sum += hl[i].Alpha;
                    count += 1;
                }
                return sum / count;
            }
            private HougLine[] GetTop(int Count)
            {
                HougLine[] hl = null;
                int i = 0;
                int j = 0;
                HougLine tmp = null;
                int AlphaIndex = 0;
                int dIndex = 0;
                hl = new HougLine[Count + 1];
                for (i = 0; i <= Count - 1; i++)
                {
                    hl[i] = new HougLine();
                }
                for (i = 0; i <= cHMatrix.Length - 1; i++)
                {
                    if (cHMatrix[i] > hl[Count - 1].Count)
                    {
                        hl[Count - 1].Count = cHMatrix[i];
                        hl[Count - 1].Index = i;
                        j = Count - 1;
                        while (j > 0 && hl[j].Count > hl[j - 1].Count)
                        {
                            tmp = hl[j];
                            hl[j] = hl[j - 1];
                            hl[j - 1] = tmp; j -= 1;
                        }
                    }
                }
                for (i = 0; i <= Count - 1; i++)
                {
                    dIndex = hl[i].Index / cSteps;
                    AlphaIndex = hl[i].Index - dIndex * cSteps;
                    hl[i].Alpha = GetAlpha(AlphaIndex);
                    hl[i].d = dIndex + cDMin;
                }
                return hl;
            }
            public gmseDeskew(Bitmap bmp)
            {
                cBmp = bmp;
            }
            private void Calc()
            {
                int x = 0;
                int y = 0;
                int hMin = cBmp.Height / 4;
                int hMax = cBmp.Height * 3 / 4;
                Init();
                for (y = hMin; y <= hMax; y++)
                {
                    for (x = 1; x <= cBmp.Width - 2; x++)
                    {    // Only lower edges are considered.
                        if (IsBlack(x, y))
                        {
                            if (!IsBlack(x, y + 1))
                            {
                                Calc(x, y);
                            }
                        }
                    }
                }
            }
            private void Calc(int x, int y)
            {
                int alpha = 0;
                double d = 0;
                int dIndex = 0;
                int Index = 0;
                for (alpha = 0; alpha <= cSteps - 1; alpha++)
                {
                    d = y * cCosA[alpha] - x * cSinA[alpha];
                    dIndex = (int)CalcDIndex(d);
                    Index = dIndex * cSteps + alpha;
                    try
                    {
                        cHMatrix[Index] += 1;
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.ToString());
                    }
                }
            }
            private double CalcDIndex(double d)
            {
                return Convert.ToInt32(d - cDMin);
            }
            private bool IsBlack(int x, int y)
            {
                Color c = default(Color);
                double luminance = 0;
                c = cBmp.GetPixel(x, y);
                luminance = (c.R * 0.299) + (c.G * 0.587) + (c.B * 0.114);
                return luminance < 140;
            }
            private void Init()
            {
                int i = 0;
                double angle = 0;
                // Precalculation of sin and cos. 
                cSinA = new double[cSteps];
                cCosA = new double[cSteps];
                for (i = 0; i <= cSteps - 1; i++)
                {
                    angle = GetAlpha(i) * Math.PI / 180.0;
                    cSinA[i] = Math.Sin(angle);
                    cCosA[i] = Math.Cos(angle);
                }  // Range of d: 
                cDMin = -cBmp.Width;
                cDCount = (int)(2 * (cBmp.Width + cBmp.Height) / cDStep);
                cHMatrix = new int[cDCount * cSteps + 1];
            }
            public double GetAlpha(int Index)
            {
                return cAlphaStart + Index * cAlphaStep;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //  pictureBox1.Image = Image.FromFile(imagePath);
            Bitmap bmp = new Bitmap(imagePath);
            //新建第二个bitmap类型的bmp2变量，我这里是根据我的程序需要设置的。
            Bitmap bmp2 = new Bitmap(1120,1435, PixelFormat.Format16bppRgb555);
            //将第一个bmp拷贝到bmp2中
            Graphics draw = Graphics.FromImage(bmp2);
            draw.DrawImage(bmp, 0, 0);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Image = bmp2;//读取bmp2到picturebox
                                     //     name = openFileDialogEmpImage.FileName;
                                     //      openFileDialogEmpImage.Dispose();
            draw.Dispose();
            bmp.Dispose();//释放bmp文件资源*/

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form3 form = new Form3(dangId,pId);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
