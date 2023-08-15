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

using System.Runtime.InteropServices;//添加命名空间
namespace route
{
    public partial class Form1 : Form
    {
        public int originPoint;
        public int finalPoint;
        public string MIN;//最优路径长度
        IntPtr handle;
        public static int count = 0;

        public Form1()
        {
            InitializeComponent();
            this.dataGridView1.Rows.Clear();
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
           
            try
            {
                handle = IntPtr.Zero;
                originPoint = int.Parse(textBox1.Text);
                finalPoint = int.Parse(textBox2.Text);



                MatlabR mr = new MatlabR();

                MWArray[] agrsOut = new MWArray[1];
                MWArray[] agrsIn = new MWArray[] { (MWNumericArray)originPoint, (MWNumericArray)finalPoint };

                mr.RobotRun3(1, ref agrsOut, agrsIn);

                MWNumericArray x1 = agrsOut[0] as MWNumericArray;//MIN
                textBox3.Text = x1.ToString();
                //
                System.Threading.Thread.Sleep(100);
                handle = FindWindow("SunAwtFrame", "Figure 1");
                SetParent(handle, this.panel1.Handle);
                long temp = GetWindowLong(handle, GWL_STYLE);
                SetWindowLong(handle, GWL_STYLE, temp & (~WS_CAPTION) | WS_MAXIMIZE);
                MoveWindow(handle, 0, 0, this.panel1.Width, this.panel1.Height, true);
                //
                pictureBox1.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("输入坐标点不合适！！！");
            }
           
            


        }
        public float X;
        public float Y;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Resize += new EventHandler(Form1_Resize);//窗体调整大小时引发事件



            X = this.Width;//获取窗体的宽度

            Y = this.Height;//获取窗体的高度

            setTag(this);//调用方法

            this.WindowState = FormWindowState.Maximized;
        }
        private void setTag(Control cons)
        {

            //遍历窗体中的控件

            foreach (Control con in cons.Controls)
            {

                con.Tag = con.Width + ":" + con.Height + ":" + con.Left + ":" + con.Top + ":" + con.Font.Size;

                if (con.Controls.Count > 0)

                    setTag(con);

            }

        }

        private void setControls(float newx, float newy, Control cons)
        {

            //遍历窗体中的控件，重新设置控件的值

            foreach (Control con in cons.Controls)
            {

                string[] mytag = con.Tag.ToString().Split(new char[] { ':' });//获取控件的Tag属性值，并分割后存储字符串数组

                float a = Convert.ToSingle(mytag[0]) * newx;//根据窗体缩放比例确定控件的值，宽度

                con.Width = (int)a;//宽度

                a = Convert.ToSingle(mytag[1]) * newy;//高度

                con.Height = (int)(a);

                a = Convert.ToSingle(mytag[2]) * newx;//左边距离

                con.Left = (int)(a);

                a = Convert.ToSingle(mytag[3]) * newy;//上边缘距离

                con.Top = (int)(a);

                Single currentSize = Convert.ToSingle(mytag[4]) * newy;//字体大小

                con.Font = new Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit);

                if (con.Controls.Count > 0)
                {

                    setControls(newx, newy, con);

                }

            }

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            float newx = (this.Width) / X; 

            float newy = this.Height / Y;

            setControls(newx, newy, this);

            this.Text = this.Width.ToString() + " " + this.Height.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            
            int index = this.dataGridView1.Rows.Add();
            this.dataGridView1.Rows[count].Cells[0].Value = textBox1.Text;
            this.dataGridView1.Rows[count].Cells[1].Value = textBox2.Text;
            this.dataGridView1.Rows[count].Cells[2].Value = textBox3.Text;

            count = index + 1;
            
           
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            this.panel1.Controls.Clear();
            
        }


    }
}
