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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.minBtn = new System.Windows.Forms.Button();
            this.resBtn = new System.Windows.Forms.Button();
            this.cloBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.navigationPane1 = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.navigationPage3 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationPage4 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.navigationPage5 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationPage6 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationPage7 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationPage8 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationPage9 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TSMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).BeginInit();
            this.navigationPane1.SuspendLayout();
            this.navigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            this.navigationPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            this.navigationPage4.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(51)))), ((int)(((byte)(81)))));
            this.panel1.Controls.Add(this.minBtn);
            this.panel1.Controls.Add(this.resBtn);
            this.panel1.Controls.Add(this.cloBtn);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 39);
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
            this.minBtn.Location = new System.Drawing.Point(207, 8);
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
            this.resBtn.Location = new System.Drawing.Point(236, 8);
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
            this.cloBtn.Location = new System.Drawing.Point(265, 8);
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
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.navigationPane1);
            this.panel2.Location = new System.Drawing.Point(0, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(301, 566);
            this.panel2.TabIndex = 3;
            // 
            // navigationPane1
            // 
            this.navigationPane1.BackgroundImage = global::SysForm.Properties.Resources.CATIA;
            this.navigationPane1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.navigationPane1.Controls.Add(this.navigationPage1);
            this.navigationPane1.Controls.Add(this.navigationPage2);
            this.navigationPane1.Controls.Add(this.navigationPage3);
            this.navigationPane1.Controls.Add(this.navigationPage4);
            this.navigationPane1.Controls.Add(this.navigationPage5);
            this.navigationPane1.Controls.Add(this.navigationPage6);
            this.navigationPane1.Controls.Add(this.navigationPage7);
            this.navigationPane1.Controls.Add(this.navigationPage8);
            this.navigationPane1.Controls.Add(this.navigationPage9);
            this.navigationPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPane1.Location = new System.Drawing.Point(0, 0);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage1,
            this.navigationPage2,
            this.navigationPage3,
            this.navigationPage4,
            this.navigationPage5,
            this.navigationPage6,
            this.navigationPage7,
            this.navigationPage8,
            this.navigationPage9});
            this.navigationPane1.RegularSize = new System.Drawing.Size(301, 566);
            this.navigationPane1.SelectedPage = this.navigationPage1;
            this.navigationPane1.Size = new System.Drawing.Size(301, 566);
            this.navigationPane1.TabIndex = 9;
            this.navigationPane1.Text = "navigationPane1";
            // 
            // navigationPage1
            // 
            this.navigationPage1.Caption = "我的任务";
            this.navigationPage1.Controls.Add(this.accordionControl1);
            this.navigationPage1.Image = ((System.Drawing.Image)(resources.GetObject("navigationPage1.Image")));
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Properties.ShowCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.navigationPage1.Properties.ShowExpandButton = DevExpress.Utils.DefaultBoolean.False;
            this.navigationPage1.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.Image;
            this.navigationPage1.Size = new System.Drawing.Size(219, 519);
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1,
            this.accordionControlElement2});
            this.accordionControl1.Location = new System.Drawing.Point(0, 0);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Auto;
            this.accordionControl1.Size = new System.Drawing.Size(219, 519);
            this.accordionControl1.TabIndex = 0;
            this.accordionControl1.Text = "accordionControl1";
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "初步结构设计";
            // 
            // accordionControlElement2
            // 
            this.accordionControlElement2.Name = "accordionControlElement2";
            this.accordionControlElement2.Text = "后续设计任务";
            // 
            // navigationPage2
            // 
            this.navigationPage2.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.navigationPage2.Appearance.Options.UseBackColor = true;
            this.navigationPage2.Caption = "我的消息";
            this.navigationPage2.Controls.Add(this.gridControl1);
            this.navigationPage2.Image = ((System.Drawing.Image)(resources.GetObject("navigationPage2.Image")));
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Properties.ShowCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.navigationPage2.Properties.ShowExpandButton = DevExpress.Utils.DefaultBoolean.False;
            this.navigationPage2.Size = new System.Drawing.Size(219, 519);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView2;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageComboBox1});
            this.gridControl1.Size = new System.Drawing.Size(219, 519);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn5,
            this.gridColumn6});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView2.OptionsView.ShowFooter = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "#";
            this.gridColumn5.ColumnEdit = this.repositoryItemImageComboBox1;
            this.gridColumn5.FieldName = "column0";
            this.gridColumn5.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 0;
            this.gridColumn5.Width = 30;
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", false, 0),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", true, 1)});
            this.repositoryItemImageComboBox1.LargeImages = this.imageList1;
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            this.repositoryItemImageComboBox1.ReadOnly = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "邮件.png");
            this.imageList1.Images.SetKeyName(1, "read.png");
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "消息主题";
            this.gridColumn6.FieldName = "column1";
            this.gridColumn6.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.OptionsColumn.AllowFocus = false;
            this.gridColumn6.OptionsColumn.ReadOnly = true;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
            this.gridColumn6.Width = 666;
            // 
            // navigationPage3
            // 
            this.navigationPage3.Caption = "专业模型库";
            this.navigationPage3.Image = ((System.Drawing.Image)(resources.GetObject("navigationPage3.Image")));
            this.navigationPage3.Name = "navigationPage3";
            this.navigationPage3.Properties.ShowCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.navigationPage3.Properties.ShowExpandButton = DevExpress.Utils.DefaultBoolean.False;
            this.navigationPage3.Size = new System.Drawing.Size(219, 519);
            // 
            // navigationPage4
            // 
            this.navigationPage4.Caption = "专业工具";
            this.navigationPage4.Controls.Add(this.simpleButton5);
            this.navigationPage4.Controls.Add(this.simpleButton4);
            this.navigationPage4.Controls.Add(this.simpleButton3);
            this.navigationPage4.Controls.Add(this.simpleButton2);
            this.navigationPage4.Controls.Add(this.simpleButton1);
            this.navigationPage4.Image = ((System.Drawing.Image)(resources.GetObject("navigationPage4.Image")));
            this.navigationPage4.Name = "navigationPage4";
            this.navigationPage4.Properties.ShowCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.navigationPage4.Properties.ShowExpandButton = DevExpress.Utils.DefaultBoolean.False;
            this.navigationPage4.Size = new System.Drawing.Size(219, 506);
            // 
            // simpleButton5
            // 
            this.simpleButton5.BackgroundImage = global::SysForm.Properties.Resources.AMESim;
            this.simpleButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.simpleButton5.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.simpleButton5.Image = global::SysForm.Properties.Resources.Flowmaster;
            this.simpleButton5.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton5.Location = new System.Drawing.Point(137, 101);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(49, 50);
            this.simpleButton5.TabIndex = 4;
            this.simpleButton5.Tag = "Flowmaster";
            this.simpleButton5.Text = "Flowmaster";
            this.simpleButton5.Click += new System.EventHandler(this.simpleBtn_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.BackgroundImage = global::SysForm.Properties.Resources.AMESim;
            this.simpleButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.simpleButton4.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.simpleButton4.Image = global::SysForm.Properties.Resources.patran;
            this.simpleButton4.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton4.Location = new System.Drawing.Point(33, 198);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(49, 50);
            this.simpleButton4.TabIndex = 3;
            this.simpleButton4.Tag = "Patran";
            this.simpleButton4.Text = "Patran";
            this.simpleButton4.Click += new System.EventHandler(this.simpleBtn_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.BackgroundImage = global::SysForm.Properties.Resources.AMESim;
            this.simpleButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.simpleButton3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.simpleButton3.Image = global::SysForm.Properties.Resources.CATIA;
            this.simpleButton3.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton3.Location = new System.Drawing.Point(33, 101);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(49, 50);
            this.simpleButton3.TabIndex = 2;
            this.simpleButton3.Tag = "CATIA";
            this.simpleButton3.Text = "CATIA";
            this.simpleButton3.Click += new System.EventHandler(this.simpleBtn_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.BackgroundImage = global::SysForm.Properties.Resources.AMESim;
            this.simpleButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.simpleButton2.Image = global::SysForm.Properties.Resources.Ansys;
            this.simpleButton2.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton2.Location = new System.Drawing.Point(134, 21);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(49, 50);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Tag = "Ansys";
            this.simpleButton2.Text = "Ansys";
            this.simpleButton2.Click += new System.EventHandler(this.simpleBtn_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.BackgroundImage = global::SysForm.Properties.Resources.AMESim;
            this.simpleButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.simpleButton1.Image = global::SysForm.Properties.Resources.AMESim;
            this.simpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton1.Location = new System.Drawing.Point(33, 21);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(49, 50);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Tag = "AMESim";
            this.simpleButton1.Text = "AMESim";
            this.simpleButton1.Click += new System.EventHandler(this.simpleBtn_Click);
            // 
            // navigationPage5
            // 
            this.navigationPage5.Caption = "AMESim";
            this.navigationPage5.Image = global::SysForm.Properties.Resources.AMESim;
            this.navigationPage5.Name = "navigationPage5";
            this.navigationPage5.Properties.ShowCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.navigationPage5.Properties.ShowExpandButton = DevExpress.Utils.DefaultBoolean.False;
            this.navigationPage5.Size = new System.Drawing.Size(219, 506);
            // 
            // navigationPage6
            // 
            this.navigationPage6.Caption = "Ansys";
            this.navigationPage6.Image = global::SysForm.Properties.Resources.Ansys;
            this.navigationPage6.Name = "navigationPage6";
            this.navigationPage6.Properties.ShowCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.navigationPage6.Properties.ShowExpandButton = DevExpress.Utils.DefaultBoolean.False;
            this.navigationPage6.Size = new System.Drawing.Size(219, 506);
            // 
            // navigationPage7
            // 
            this.navigationPage7.Caption = "CATIA";
            this.navigationPage7.Image = global::SysForm.Properties.Resources.CATIA;
            this.navigationPage7.Name = "navigationPage7";
            this.navigationPage7.Properties.ShowCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.navigationPage7.Properties.ShowExpandButton = DevExpress.Utils.DefaultBoolean.False;
            this.navigationPage7.Size = new System.Drawing.Size(219, 506);
            // 
            // navigationPage8
            // 
            this.navigationPage8.Caption = "Flowmaster";
            this.navigationPage8.Image = global::SysForm.Properties.Resources.Flowmaster;
            this.navigationPage8.Name = "navigationPage8";
            this.navigationPage8.Properties.ShowCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.navigationPage8.Properties.ShowExpandButton = DevExpress.Utils.DefaultBoolean.False;
            this.navigationPage8.Size = new System.Drawing.Size(219, 506);
            // 
            // navigationPage9
            // 
            this.navigationPage9.Caption = "Patran";
            this.navigationPage9.Image = global::SysForm.Properties.Resources.patran;
            this.navigationPage9.Name = "navigationPage9";
            this.navigationPage9.Properties.ShowCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.navigationPage9.Properties.ShowExpandButton = DevExpress.Utils.DefaultBoolean.False;
            this.navigationPage9.Size = new System.Drawing.Size(219, 506);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMenuItem1,
            this.TSMenuItem2,
            this.TSMenuItem3});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 70);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // TSMenuItem1
            // 
            this.TSMenuItem1.Name = "TSMenuItem1";
            this.TSMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.TSMenuItem1.Text = "接收";
            this.TSMenuItem1.Click += new System.EventHandler(this.接收ToolStripMenuItem_Click);
            // 
            // TSMenuItem2
            // 
            this.TSMenuItem2.Name = "TSMenuItem2";
            this.TSMenuItem2.Size = new System.Drawing.Size(100, 22);
            this.TSMenuItem2.Text = "提交";
            this.TSMenuItem2.Click += new System.EventHandler(this.提交ToolStripMenuItem_Click);
            // 
            // TSMenuItem3
            // 
            this.TSMenuItem3.Name = "TSMenuItem3";
            this.TSMenuItem3.Size = new System.Drawing.Size(100, 22);
            this.TSMenuItem3.Text = "详细";
            this.TSMenuItem3.Click += new System.EventHandler(this.详细ToolStripMenuItem_Click);
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "#";
            this.gridColumn3.FieldName = "column0";
            this.gridColumn3.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            this.gridColumn3.Width = 30;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "消息主题";
            this.gridColumn4.FieldName = "column1";
            this.gridColumn4.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            this.gridColumn4.Width = 666;
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(197)))), ((int)(((byte)(177)))));
            this.ClientSize = new System.Drawing.Size(300, 600);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MyForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MyForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            this.navigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            this.navigationPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            this.navigationPage4.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button minBtn;
        private System.Windows.Forms.Button resBtn;
        private System.Windows.Forms.Button cloBtn;
        private Timer timer1;
        private NotifyIcon notifyIcon1;
        private Panel panel2;
        private DevExpress.XtraBars.Navigation.NavigationPane navigationPane1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage2;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage3;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage4;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage5;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage6;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage7;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage8;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage9;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem TSMenuItem1;
        private ToolStripMenuItem TSMenuItem2;
        private ToolStripMenuItem TSMenuItem3;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private ImageList imageList1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;

    }
}

