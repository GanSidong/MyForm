using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
namespace SysForm
{
    partial class MyForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;

        private void gPanelTitleBack_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);//调用移动无窗体控件函数
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.minBtn = new System.Windows.Forms.Button();
            this.resBtn = new System.Windows.Forms.Button();
            this.cloBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.panel1.Controls.Add(this.minBtn);
            this.panel1.Controls.Add(this.resBtn);
            this.panel1.Controls.Add(this.cloBtn);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 30);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gPanelTitleBack_MouseDown);
            // 
            // minBtn
            // 
            this.minBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minBtn.BackgroundImage = global::SysForm.Properties.Resources.最小化;
            this.minBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minBtn.FlatAppearance.BorderSize = 0;
            this.minBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minBtn.Location = new System.Drawing.Point(207, 3);
            this.minBtn.Name = "minBtn";
            this.minBtn.Size = new System.Drawing.Size(23, 23);
            this.minBtn.TabIndex = 2;
            this.minBtn.Tag = "0";
            this.minBtn.UseVisualStyleBackColor = true;
            this.minBtn.Click += new System.EventHandler(this.minBtn_Click);
            // 
            // resBtn
            // 
            this.resBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.resBtn.BackgroundImage = global::SysForm.Properties.Resources.还原;
            this.resBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.resBtn.FlatAppearance.BorderSize = 0;
            this.resBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resBtn.Location = new System.Drawing.Point(236, 4);
            this.resBtn.Name = "resBtn";
            this.resBtn.Size = new System.Drawing.Size(23, 23);
            this.resBtn.TabIndex = 1;
            this.resBtn.Tag = "1";
            this.resBtn.UseVisualStyleBackColor = true;
            this.resBtn.Click += new System.EventHandler(this.resBtn_Click);
            // 
            // cloBtn
            // 
            this.cloBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cloBtn.BackgroundImage = global::SysForm.Properties.Resources.关闭;
            this.cloBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cloBtn.FlatAppearance.BorderSize = 0;
            this.cloBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cloBtn.Location = new System.Drawing.Point(265, 4);
            this.cloBtn.Name = "cloBtn";
            this.cloBtn.Size = new System.Drawing.Size(23, 23);
            this.cloBtn.TabIndex = 0;
            this.cloBtn.Tag = "2";
            this.cloBtn.UseVisualStyleBackColor = true;
            this.cloBtn.Click += new System.EventHandler(this.cloBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(300, 600);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MyForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button minBtn;
        private System.Windows.Forms.Button resBtn;
        private System.Windows.Forms.Button cloBtn;
        private Timer timer1;

    }
}

