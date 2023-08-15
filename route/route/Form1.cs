using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RobotRun3;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;
//using figclose;
using RobotRunC;
using System.Runtime.InteropServices;//添加命名空间
namespace route
{
    public partial class Form1 : Form
    {
        public int originPoint;//起点
        public int finalPoint;//终点
        IntPtr handle;
        public int []st=new int[2];//停泊点
        public double [] best = new double[2];//最优路径长度
        public Form1()
        {
            InitializeComponent();
          
            st[0] = 35;
            st[1] = 98;
        }
        #region 加入引用,实现figure图嵌入
        [DllImport("user32.dll", EntryPoint = "FindWindow")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32.dll", EntryPoint = "SetParent")]
        public static extern int SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
        [DllImport("user32.dll", EntryPoint = "MoveWindow")]
        public static extern int MoveWindow(IntPtr hWnd, int x, int y, int nWidth, int nHeight, bool BRePaint);
        private const int GWL_STYLE = (-16);
        private const long WS_CAPTION = 0xC00000;
        private const long WS_MAXIMIZE = 0x01000000L;
        private const long WS_THICKFRAME = 0x00040000L;
        private const int SW_HIDE = 0;
        private const int SW_SHOW = 0;
        [DllImport("user32.dll", EntryPoint = "SetWindowLong")]
        private static extern long SetWindowLong(IntPtr hwnd, int nIndex, long newLong);
        [DllImport("user32.dll", EntryPoint = "GetWindowLong")]
        public static extern long GetWindowLong(IntPtr hWnd, int nlndex);
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
           
                for (int i = 0; i < st.Length; i++)
                {
                    //originPoint = int.Parse(textBox1.Text);
                    if (textBox1.Text == "A")
                        originPoint = 203;
                    if (textBox1.Text == "B")
                        originPoint = 250;
                    if (textBox1.Text == "C")
                        originPoint = 123;
                    finalPoint = st[i];
                    MatlabR mr = new MatlabR();

                    MWArray[] agrsOut = new MWArray[1];
                    MWArray[] agrsIn = new MWArray[] { (MWNumericArray)originPoint, (MWNumericArray)finalPoint };

                    mr.RobotRun3(1, ref agrsOut, agrsIn);
                    //MatlabC mc = new MatlabC();
                    //mc.figclose();

                    MWNumericArray x1 = agrsOut[0] as MWNumericArray;//MIN
                    string tem_p = x1.ToString();
                    best[i] = double.Parse(tem_p);
                
                }
                
                double temp1 = 1000000;
                int index = 0;

                for (int i = 0; i < best.Length; i++)
                {
                    if (temp1 > best[i])    
                    {
                        temp1 = best[i];
                        index = i;
                    }
                }
                textBox2.Text = st[index].ToString();
           
                //
                handle = IntPtr.Zero;
                if (st[index] == 35)
                    textBox2.Text = "1";
                if (st[index] == 98)
                    textBox2.Text = "2";
                if (textBox2.Text == "1" && textBox1.Text == "C")
                {
                    textBox3.Text = "7 n mile";
                    textBox4.Text="C-1航线";
                }
                if (textBox2.Text == "1" && textBox1.Text == "A")
                {
                    textBox3.Text = "7.53 n mile";
                    textBox4.Text = "A-1航线";
                }
                if (textBox2.Text == "2" && textBox1.Text == "B")
                {
                    textBox3.Text = "6 n mile";
                    textBox4.Text = "B-2航线";
                }

                finalPoint = st[index];

                MatlabRC mr1 = new MatlabRC();

                MWArray[] agrsOut1 = new MWArray[1];
                MWArray[] agrsIn1 = new MWArray[] { (MWNumericArray)originPoint, (MWNumericArray)finalPoint };

                mr1.RobotRunC (1, ref agrsOut1, agrsIn1);
                //pictureBox1.Visible = false;
                MWNumericArray x = agrsOut1[0] as MWNumericArray;//MIN
                double  value = double.Parse(x.ToString());
                //
                System.Threading.Thread.Sleep(100);
                handle = FindWindow("SunAwtFrame", "Figure 1");
                //SetParent(handle, this.panel1.Handle);
                //long temp11 = GetWindowLong(handle, GWL_STYLE);
                //SetWindowLong(handle, GWL_STYLE, temp11 & (~WS_CAPTION) | WS_MAXIMIZE);
                //MoveWindow(handle, 0, 0, this.panel1.Width, this.panel1.Height, true);
                
        }
        public float X;
        public float Y;
        private void Form1_Load(object sender, EventArgs e)
        {
        //    this.Resize += new EventHandler(Form1_Resize);//窗体调整大小时引发事件



        //    X = this.Width;//获取窗体的宽度

        //    Y = this.Height;//获取窗体的高度

        //    setTag(this);//调用方法

        //    this.WindowState = FormWindowState.Maximized;
        //}
        //private void setTag(Control cons)//获取控件的width、height、left、top、字体大小的值
        //{

        //    //遍历窗体中的控件

        //    foreach (Control con in cons.Controls)
        //    {

        //        con.Tag = con.Width + ":" + con.Height + ":" + con.Left + ":" + con.Top + ":" + con.Font.Size;

        //        if (con.Controls.Count > 0)

        //            setTag(con);

        //    }

        }

        //根据窗体大小调整控件大小
        private void setControls(float newx, float newy, Control cons)
        {
            //遍历窗体中的控件，重新设置控件的值
            //foreach (Control con in cons.Controls)
            //{

            //    string[] mytag = con.Tag.ToString().Split(new char[] { ':' });//获取控件的Tag属性值，并分割后存储字符串数组
            //    float a = Convert.ToSingle(mytag[0]) * newx;//根据窗体缩放比例确定控件的值，宽度
            //    con.Width = (int)a;//宽度
            //    a = Convert.ToSingle(mytag[1]) * newy;//高度
            //    con.Height = (int)(a);
            //    a = Convert.ToSingle(mytag[2]) * newx;//左边距离
            //    con.Left = (int)(a);
            //    a = Convert.ToSingle(mytag[3]) * newy;//上边缘距离
            //    con.Top = (int)(a);
            //    Single currentSize = Convert.ToSingle(mytag[4]) * newy;//字体大小
            //    con.Font = new Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit);
            //    if (con.Controls.Count > 0)
            //    {
            //        setControls(newx, newy, con);
            //    }
            //}

        }

        void Form1_Resize(object sender, EventArgs e)
        {

            //float newx = (this.Width) / X; //窗体宽度缩放比例

            //float newy = this.Height / Y;//窗体高度缩放比例

            //setControls(newx, newy, this);//随窗体改变控件大小

            //this.Text = this.Width.ToString() + " " + this.Height.ToString();//窗体标题栏文本

        }

  


        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;     
            textBox3.Text = null;
            textBox4.Text = null;
            //this.panel1.Controls.Clear();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
       }

        private void label1_Click(object sender, EventArgs e)
        {

        }




    }
}
