namespace GISRD
{
    partial class FormMain
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.axMapCtrl = new DevExpress.XtraEditors.GroupControl();
            this.axLicenseControl1 = new ESRI.ArcGIS.Controls.AxLicenseControl();
            this.axMapControl1 = new ESRI.ArcGIS.Controls.AxMapControl();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.Lbl_XY = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.基本操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开地图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.港口信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.放大ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.缩小ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.拖拽ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全图显示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.前一视图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.后一视图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.地图刷新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.识别查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.比例尺ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.关于我们ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.生成船舶调度方案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于我们ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.axMapCtrl)).BeginInit();
            this.axMapCtrl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // axMapCtrl
            // 
            this.axMapCtrl.Controls.Add(this.axLicenseControl1);
            this.axMapCtrl.Controls.Add(this.axMapControl1);
            this.axMapCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axMapCtrl.Location = new System.Drawing.Point(0, 28);
            this.axMapCtrl.Name = "axMapCtrl";
            this.axMapCtrl.Size = new System.Drawing.Size(1182, 647);
            this.axMapCtrl.TabIndex = 0;
            // 
            // axLicenseControl1
            // 
            this.axLicenseControl1.Enabled = true;
            this.axLicenseControl1.Location = new System.Drawing.Point(186, 344);
            this.axLicenseControl1.Name = "axLicenseControl1";
            this.axLicenseControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axLicenseControl1.OcxState")));
            this.axLicenseControl1.Size = new System.Drawing.Size(32, 32);
            this.axLicenseControl1.TabIndex = 1;
            // 
            // axMapControl1
            // 
            this.axMapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axMapControl1.Location = new System.Drawing.Point(2, 26);
            this.axMapControl1.Name = "axMapControl1";
            this.axMapControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMapControl1.OcxState")));
            this.axMapControl1.Size = new System.Drawing.Size(1178, 619);
            this.axMapControl1.TabIndex = 0;
            this.axMapControl1.OnMouseMove += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseMoveEventHandler(this.axMapControl1_OnMouseMove);
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.MenuManager = this.barManager1;
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.DockManager = this.dockManager1;
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.Lbl_XY,
            this.barSubItem1});
            this.barManager1.MaxItemId = 2;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.Lbl_XY)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // Lbl_XY
            // 
            this.Lbl_XY.Caption = "Lbl_XY";
            this.Lbl_XY.Id = 0;
            this.Lbl_XY.Name = "Lbl_XY";
            this.Lbl_XY.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1182, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 675);
            this.barDockControlBottom.Size = new System.Drawing.Size(1182, 30);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 675);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1182, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 675);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Id = 1;
            this.barSubItem1.Name = "barSubItem1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.基本操作ToolStripMenuItem,
            this.港口信息ToolStripMenuItem,
            this.关于我们ToolStripMenuItem,
            this.ToolStripMenuItem,
            this.帮助ToolStripMenuItem,
            this.关于我们ToolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1182, 28);
            this.menuStrip2.TabIndex = 8;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // 基本操作ToolStripMenuItem
            // 
            this.基本操作ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开地图ToolStripMenuItem});
            this.基本操作ToolStripMenuItem.Name = "基本操作ToolStripMenuItem";
            this.基本操作ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.基本操作ToolStripMenuItem.Text = "文件";
            // 
            // 打开地图ToolStripMenuItem
            // 
            this.打开地图ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("打开地图ToolStripMenuItem.Image")));
            this.打开地图ToolStripMenuItem.Name = "打开地图ToolStripMenuItem";
            this.打开地图ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.打开地图ToolStripMenuItem.Text = "打开地图";
            this.打开地图ToolStripMenuItem.Click += new System.EventHandler(this.打开地图ToolStripMenuItem_Click);
            // 
            // 港口信息ToolStripMenuItem
            // 
            this.港口信息ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.放大ToolStripMenuItem,
            this.缩小ToolStripMenuItem,
            this.拖拽ToolStripMenuItem,
            this.全图显示ToolStripMenuItem,
            this.前一视图ToolStripMenuItem,
            this.后一视图ToolStripMenuItem,
            this.地图刷新ToolStripMenuItem,
            this.识别查询ToolStripMenuItem,
            this.比例尺ToolStripMenuItem1});
            this.港口信息ToolStripMenuItem.Name = "港口信息ToolStripMenuItem";
            this.港口信息ToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.港口信息ToolStripMenuItem.Text = "工具箱";
            // 
            // 放大ToolStripMenuItem
            // 
            this.放大ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("放大ToolStripMenuItem.Image")));
            this.放大ToolStripMenuItem.Name = "放大ToolStripMenuItem";
            this.放大ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.放大ToolStripMenuItem.Text = "放大";
            this.放大ToolStripMenuItem.Click += new System.EventHandler(this.放大ToolStripMenuItem_Click);
            // 
            // 缩小ToolStripMenuItem
            // 
            this.缩小ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("缩小ToolStripMenuItem.Image")));
            this.缩小ToolStripMenuItem.Name = "缩小ToolStripMenuItem";
            this.缩小ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.缩小ToolStripMenuItem.Text = "缩小";
            this.缩小ToolStripMenuItem.Click += new System.EventHandler(this.缩小ToolStripMenuItem_Click);
            // 
            // 拖拽ToolStripMenuItem
            // 
            this.拖拽ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("拖拽ToolStripMenuItem.Image")));
            this.拖拽ToolStripMenuItem.Name = "拖拽ToolStripMenuItem";
            this.拖拽ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.拖拽ToolStripMenuItem.Text = "拖拽";
            this.拖拽ToolStripMenuItem.Click += new System.EventHandler(this.拖拽ToolStripMenuItem_Click);
            // 
            // 全图显示ToolStripMenuItem
            // 
            this.全图显示ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("全图显示ToolStripMenuItem.Image")));
            this.全图显示ToolStripMenuItem.Name = "全图显示ToolStripMenuItem";
            this.全图显示ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.全图显示ToolStripMenuItem.Text = "全图显示";
            this.全图显示ToolStripMenuItem.Click += new System.EventHandler(this.全图显示ToolStripMenuItem_Click);
            // 
            // 前一视图ToolStripMenuItem
            // 
            this.前一视图ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("前一视图ToolStripMenuItem.Image")));
            this.前一视图ToolStripMenuItem.Name = "前一视图ToolStripMenuItem";
            this.前一视图ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.前一视图ToolStripMenuItem.Text = "前一视图";
            this.前一视图ToolStripMenuItem.Click += new System.EventHandler(this.前一视图ToolStripMenuItem_Click);
            // 
            // 后一视图ToolStripMenuItem
            // 
            this.后一视图ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("后一视图ToolStripMenuItem.Image")));
            this.后一视图ToolStripMenuItem.Name = "后一视图ToolStripMenuItem";
            this.后一视图ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.后一视图ToolStripMenuItem.Text = "后一视图";
            this.后一视图ToolStripMenuItem.Click += new System.EventHandler(this.后一视图ToolStripMenuItem_Click);
            // 
            // 地图刷新ToolStripMenuItem
            // 
            this.地图刷新ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("地图刷新ToolStripMenuItem.Image")));
            this.地图刷新ToolStripMenuItem.Name = "地图刷新ToolStripMenuItem";
            this.地图刷新ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.地图刷新ToolStripMenuItem.Text = "地图刷新";
            this.地图刷新ToolStripMenuItem.Click += new System.EventHandler(this.地图刷新ToolStripMenuItem_Click);
            // 
            // 识别查询ToolStripMenuItem
            // 
            this.识别查询ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("识别查询ToolStripMenuItem.Image")));
            this.识别查询ToolStripMenuItem.Name = "识别查询ToolStripMenuItem";
            this.识别查询ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.识别查询ToolStripMenuItem.Text = "识别查询";
            this.识别查询ToolStripMenuItem.Click += new System.EventHandler(this.识别查询ToolStripMenuItem_Click);
            // 
            // 比例尺ToolStripMenuItem1
            // 
            this.比例尺ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7});
            this.比例尺ToolStripMenuItem1.Name = "比例尺ToolStripMenuItem1";
            this.比例尺ToolStripMenuItem1.Size = new System.Drawing.Size(138, 24);
            this.比例尺ToolStripMenuItem1.Text = "比例尺";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(147, 24);
            this.toolStripMenuItem2.Text = "1：25000";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(147, 24);
            this.toolStripMenuItem3.Text = "1:50000";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(147, 24);
            this.toolStripMenuItem4.Text = "1:75000";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(147, 24);
            this.toolStripMenuItem5.Text = "1:100000";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(147, 24);
            this.toolStripMenuItem6.Text = "1:125000";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(147, 24);
            this.toolStripMenuItem7.Text = "1:150000";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // 关于我们ToolStripMenuItem
            // 
            this.关于我们ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.生成船舶调度方案ToolStripMenuItem});
            this.关于我们ToolStripMenuItem.Name = "关于我们ToolStripMenuItem";
            this.关于我们ToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.关于我们ToolStripMenuItem.Text = "避障路径规划";
            // 
            // 生成船舶调度方案ToolStripMenuItem
            // 
            this.生成船舶调度方案ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("生成船舶调度方案ToolStripMenuItem.Image")));
            this.生成船舶调度方案ToolStripMenuItem.Name = "生成船舶调度方案ToolStripMenuItem";
            this.生成船舶调度方案ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.生成船舶调度方案ToolStripMenuItem.Text = "生成方案";
            this.生成船舶调度方案ToolStripMenuItem.Click += new System.EventHandler(this.生成船舶调度方案ToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.ToolStripMenuItem.Text = "港口信息";
            this.ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.帮助ToolStripMenuItem.Text = "帮助";
            this.帮助ToolStripMenuItem.Click += new System.EventHandler(this.帮助ToolStripMenuItem_Click);
            // 
            // 关于我们ToolStripMenuItem1
            // 
            this.关于我们ToolStripMenuItem1.Name = "关于我们ToolStripMenuItem1";
            this.关于我们ToolStripMenuItem1.Size = new System.Drawing.Size(81, 24);
            this.关于我们ToolStripMenuItem1.Text = "关于我们";
            this.关于我们ToolStripMenuItem1.Click += new System.EventHandler(this.关于我们ToolStripMenuItem1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripButton7,
            this.toolStripButton8,
            this.toolStripButton9,
            this.toolStripButton10});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1182, 31);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 28);
            this.toolStripButton1.Text = "打开地图";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(24, 28);
            this.toolStripButton2.Text = "保存";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(24, 28);
            this.toolStripButton3.Text = "放大";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(24, 28);
            this.toolStripButton4.Text = "缩小";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(24, 28);
            this.toolStripButton5.Text = "拖拽";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(24, 28);
            this.toolStripButton6.Text = "全图显示";
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(24, 28);
            this.toolStripButton7.Text = "前一视图";
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(24, 28);
            this.toolStripButton8.Text = "后一视图";
            this.toolStripButton8.Click += new System.EventHandler(this.toolStripButton8_Click);
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.Size = new System.Drawing.Size(24, 28);
            this.toolStripButton9.Text = "地图刷新";
            this.toolStripButton9.Click += new System.EventHandler(this.toolStripButton9_Click);
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.Size = new System.Drawing.Size(24, 28);
            this.toolStripButton10.Text = "识别查询";
            this.toolStripButton10.Click += new System.EventHandler(this.toolStripButton10_Click);
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1182, 705);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.axMapCtrl);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "基于蚁群算法的船舶避障航路规划系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axMapCtrl)).EndInit();
            this.axMapCtrl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl axMapCtrl;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private ESRI.ArcGIS.Controls.AxMapControl axMapControl1;
        private ESRI.ArcGIS.Controls.AxLicenseControl axLicenseControl1;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarStaticItem Lbl_XY;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem 基本操作ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 港口信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于我们ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开地图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 放大ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 缩小ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 拖拽ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全图显示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 前一视图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 后一视图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 地图刷新ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 识别查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 生成船舶调度方案ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 比例尺ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于我们ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
    }
}

