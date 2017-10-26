using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysForm
{
    public partial class MyForm : Form
    {
        public MyForm()
        {
            InitializeComponent();
        }

        private void cloBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resBtn_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }

            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void minBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            System.Drawing.Point pp = new Point(Cursor.Position.X, Cursor.Position.Y);//获取鼠标在屏幕的坐标点
            Rectangle Rects = new Rectangle(this.Left, this.Top, this.Left + this.Width, this.Top + this.Height);//存储当前窗体在屏幕的所在区域
            if ((this.Top < 0) && Win32API.PtInRect(ref Rects, pp))//当鼠标在当前窗体内，并且窗体的Top属性小于0
            {
                this.Top = 0;//设置窗体的Top属性为0
            }
            else
            {
                //当窗体的上边框与屏幕的顶端的距离小于5时
                if (this.Top > -5 && this.Top < 5 && !(Win32API.PtInRect(ref Rects, pp)))
                {
                    this.Top = 1 - this.Height;//将窗体隐藏到屏幕的顶端,并且留下1px的边框
                }
            }
            if ((this.Left < 0) && Win32API.PtInRect(ref Rects, pp))
            {
                Win32API.AnimateWindow(this.Handle, 1000, Win32API.AW_BLEND);
                this.Left = 0;
            }
            int ScreenWidth = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width;
            if ((this.Right > ScreenWidth) && Win32API.PtInRect(ref Rects, pp))
            {
                this.Left = ScreenWidth - this.Width;
                Win32API.AnimateWindow(this.Handle, 1000, Win32API.AW_BLEND);
            }
        }

        class Win32API
        {

            public const Int32 AW_HOR_POSITIVE = 0x00000001; // 从左到右打开窗口  
            public const Int32 AW_HOR_NEGATIVE = 0x00000002; // 从右到左打开窗口  
            public const Int32 AW_VER_POSITIVE = 0x00000004; // 从上到下打开窗口  
            public const Int32 AW_VER_NEGATIVE = 0x00000008; // 从下到上打开窗口  
            public const Int32 AW_CENTER = 0x00000010; //若使用了AW_HIDE标志，则使窗口向内重叠；若未使用AW_HIDE标志，则使窗口向外扩展。  
            public const Int32 AW_HIDE = 0x00010000; //隐藏窗口，缺省则显示窗口。  
            public const Int32 AW_ACTIVATE = 0x00020000; //激活窗口。在使用了AW_HIDE标志后不要使用这个标志。  
            public const Int32 AW_SLIDE = 0x00040000; //使用滑动类型。缺省则为滚动动画类型。当使用AW_CENTER标志时，这个标志就被忽略。  
            public const Int32 AW_BLEND = 0x00080000; //使用淡出效果。只有当hWnd为顶层窗口的时候才可以使用此标志。  
           
            [DllImport("user32.dll", CharSet = CharSet.Auto)]
            public static extern bool AnimateWindow(
              IntPtr hwnd, // handle to window  
              int dwTime, // duration of animation  
              int dwFlags // animation type  
              );

            [DllImport("User32.dll")]
            public static extern bool PtInRect(ref Rectangle r, Point p);
        }
    }
}
