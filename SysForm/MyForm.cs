using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SysForm
{
    public partial class MyForm : Form
    {
        /// <summary>
        /// 服务器套接字的字符串形式，从登录窗体得到
        /// </summary>
        private string _svrskt = null;
        /// <summary>
        /// 用于接受和发送的网络流，从登录窗体得到
        /// </summary>
        private NetworkStream _nws = null;
        /// <summary>
        /// 数据缓冲区大小
        /// </summary>
        private int _maxPacket = 2048;//2K的缓冲区
        /// <summary>
        /// 用于接受消息的线程
        /// </summary>
        private Thread _receiveThread = null;

        private Label _ParentLabel = null;
        public MyForm()
        {
            InitializeComponent();
        }

        private void MyForm_Load(object sender, EventArgs e)
        {
            //login();
            initView();
            _receiveThread = new Thread(new ThreadStart(ReceiveMsg));
            _receiveThread.Start();
        }

        #region 关闭，最小化，最大化按钮事件
        private void cloBtn_Click(object sender, EventArgs e)
        {
            DialogResult ret;
            ret = MessageBox.Show("是否最小化程序到托盘？",
                                  "退出",
                                  MessageBoxButtons.OKCancel,
                                  MessageBoxIcon.Question,
                                  MessageBoxDefaultButton.Button2);

            if (ret != DialogResult.OK)
            {
                if (_nws !=null)
                {
                    //向服务器发送离线请求
                    _nws.Write(new byte[] { 0, 1 }, 0, 2);
                    _nws.Close();
                }
                if (_receiveThread != null)
                {
                    _receiveThread.Abort();
                }
                this.Close();
            }
            else
            {
                this.WindowState = FormWindowState.Minimized;    //使关闭时窗口向右下角缩小的效果
                this.notifyIcon1.Visible = true;
                this.Hide();
            }
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
        #endregion

        #region timer控件，监视窗口位置，贴边隐藏
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
        #endregion

        /// <summary>
        /// 接受消息的线程执行体
        /// </summary>
        private void ReceiveMsg()
        {
            if (_nws != null)
            {
                while (true)
                {
                    byte[] packet = new byte[_maxPacket];
                    _nws.Read(packet, 0, packet.Length);
                    string _cmd = DecodingBytes(packet);
                    string displaytxt = Encoding.Unicode.GetString(packet);
                    PopMsgForm pop = new PopMsgForm(_svrskt, displaytxt);
                    pop.Show();
                }
            }
        }

        /// <summary>
        /// 提取命令
        /// </summary>
        /// <param name="s">要解析的包含命令的byte数组，只提取前两个字节</param>
        /// <returns>拼接成的命令</returns>
        private string DecodingBytes(byte[] s)
        {
            return string.Concat(s[0].ToString(), s[1].ToString());
        }
       
        private void login()
        {
            //向服务器发出连接请求
            TCPConnection conn = new TCPConnection(IPAddress.Parse("172.17.7.1"), 8886);
            TcpClient _tcpc = conn.Connect();
            if (_tcpc == null)
            {
                MessageBox.Show("无法连接到服务器，请重试！",
                                "错误",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else
            {
                NetworkStream netstream = _tcpc.GetStream();//提供用于访问网络的基本数据流
                //向服务器发送用户名以确认身份
                string name = Guid.NewGuid().ToString();
                netstream.Write(Encoding.Unicode.GetBytes(name), 0, Encoding.Unicode.GetBytes(name).Length);
                //得到登录结果
                byte[] buffer = new byte[50];
                netstream.Read(buffer, 0, buffer.Length);//该方法将数据读入 buffer 参数并返回成功读取的字节数。如果没有可以读取的数据，则 Read 方法返回 0。
                string connResult = Encoding.Unicode.GetString(buffer).TrimEnd('\0');
                if (connResult.Equals("cmd::Failed"))
                {
                    MessageBox.Show("您的用户名已经被使用，请尝试其他用户名!",
                                    "提示",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    byte[] packet = new byte[_maxPacket];
                    _nws.Read(packet, 0, packet.Length);
                    string displaytxt = Encoding.Unicode.GetString(packet);
                    PopMsgForm pop = new PopMsgForm(_svrskt, displaytxt);
                    pop.Show();
                }
            }
        }

        private void initView()
        {
            this.navigationPage5.PageVisible = false;
            this.navigationPage6.PageVisible = false;
            this.navigationPage7.PageVisible = false;
            this.navigationPage8.PageVisible = false;
            this.navigationPage9.PageVisible = false;

            string[] A2 = { "任务属性", "输入数据", "输出数据", "标准规范", "故障案例", "科技文献", "技术文件", "工具模块", "工作笔记" };
          
            AccordionControlElement acEle1 = accordionControl1.Elements[0];


            foreach (var i in accordionControl1.Elements)
            {
                getHeaderLabel(i);
                foreach (string A2Ele in A2)
                {
                    AccordionControlElement ace = new AccordionControlElement();
                    ace.Text = A2Ele;
                    i.Elements.Add(ace);
                }
            }
            this.gridControl1.DataSource = getData();
        }

        /// <summary>
        /// 获取label工厂方法
        /// </summary>
        /// <param name="type">标题名称</param>
        /// <returns></returns>
        public Label getHeaderLabel(AccordionControlElement ace)
        {
            Label label = new Label();
            label.BackColor = Color.Transparent;
            label.Text = ace.Text;
            label.ContextMenuStrip = this.contextMenuStrip1;
            //必须将label的tag设置为element,右键菜单时通过label获取headerControl就是通过tag
            label.Tag = ace;
            ace.HeaderControl = label;
            ace.Text = "";
            return label;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            WindowState = FormWindowState.Normal;
            this.Focus();
        }

        private void simpleBtn_Click(object sender, EventArgs e)
        {
            string btnTag = ((SimpleButton)sender).Tag.ToString();
            if (btnTag == "CATIA")
            {
                this.navigationPage7.PageVisible = !this.navigationPage7.PageVisible;
            }
            else if (btnTag == "AMESim")
            {
                this.navigationPage5.PageVisible = !this.navigationPage5.PageVisible;
            }
            else if (btnTag == "Ansys")
            {
                this.navigationPage6.PageVisible = !this.navigationPage6.PageVisible;
            }
            else if (btnTag == "Flowmaster")
            {
                this.navigationPage8.PageVisible = !this.navigationPage8.PageVisible;
            }
            else if (btnTag == "Patran")
            {
                this.navigationPage9.PageVisible = !this.navigationPage9.PageVisible;
            }
            
        }

        private void 接收ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccordionControlElement ace = this._ParentLabel.Tag as AccordionControlElement;
            MessageBox.Show(ace.Name);
        }

        private void 提交ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccordionControlElement ace = this._ParentLabel.Tag as AccordionControlElement;
        }

        private void 详细ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccordionControlElement ace = this._ParentLabel.Tag as AccordionControlElement;
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _ParentLabel = (sender as ContextMenuStrip).SourceControl as Label;
        }

        private DataTable getData()
        {

            Random ran = new Random();
            int RandKey = ran.Next(5, 20);
            DataTable dt = new DataTable("testData");
            dt.Columns.Add("column0", typeof(Boolean));
            dt.Columns.Add("column1", typeof(String));
            for (int i = 0; i < RandKey; i++)
            {
                dt.Rows.Add((i % 3 == 0), Guid.NewGuid().ToString());
            }
            return dt;
        }

    }
}
