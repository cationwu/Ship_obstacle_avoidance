using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.SystemUI;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Display;
using System.Diagnostics;

namespace GISRD
{
    public partial class FormMain : Form
    {
        //申明窗体层全局变量
        ILayer pMoveLayer;
        int toIndex;

        //构造函数
        public FormMain()
        {
            //ArcGIS运行时绑定开发和桌面端
            ESRI.ArcGIS.RuntimeManager.Bind(ESRI.ArcGIS.ProductCode.EngineOrDesktop);

            //初始化窗体
            InitializeComponent();
        }

        //窗体层变量
        IFeatureLayer pFeaLyr;

        //窗体加载函数
        private void Form1_Load(object sender, EventArgs e)
        {
            //加载地图
            axMapControl1.LoadMxFile(Application.StartupPath + "\\港口图\\大连港\\大连港.mxd");

            //为地图赋初始比例尺
            axMapControl1.MapScale = 80000;

        }

        #region 工具栏

        //放大按钮
        private void Btn_Zoomin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ICommand cmd = new ControlsMapZoomInTool();
            cmd.OnCreate(this.axMapControl1.Object);
            axMapControl1.CurrentTool = cmd as ITool;
        }

        //缩小按钮
        private void Btn_Zoomout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ICommand cmd = new ControlsMapZoomOutTool();
            cmd.OnCreate(this.axMapControl1.Object);
            axMapControl1.CurrentTool = cmd as ITool;
        }

        //漫游按钮
        private void Btn_drag_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ICommand cmd = new ControlsMapPanTool();
            cmd.OnCreate(this.axMapControl1.Object);
            axMapControl1.CurrentTool = cmd as ITool;
        }

        //前一视图
        private void Btn_viewforward_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ICommand Cmd = new ControlsMapZoomToLastExtentBackCommand();
            Cmd.OnCreate(this.axMapControl1.Object);
            Cmd.OnClick();
        }

        //后一视图
        private void Btn_viewback_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ICommand Cmd = new ControlsMapZoomToLastExtentForwardCommand();
            Cmd.OnCreate(this.axMapControl1.Object);
            Cmd.OnClick();
        }

        //全图显示
        private void Btn_viewentire_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ICommand Full = new ControlsMapFullExtentCommand();
            Full.OnCreate(axMapControl1.Object);
            Full.OnClick();
        }

        //地图刷新
        private void Btn_maprefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            axMapControl1.Refresh();
        }

        //打开地图
        private void Btn_mapopen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = true;
            openFileDialog.Title = "打开地图文档";
            openFileDialog.Filter = "地图文档（*.mxd）|*.Mxd|地图模板（*.mxt）|*.Mxt";
            openFileDialog.Multiselect = false;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string sFileName = openFileDialog.FileName;
                axMapControl1.LoadMxFile(sFileName);
            }
        }

        //识别查询
        private void Btn_Identify_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ICommand cmd = new ControlsMapIdentifyTool();
            cmd.OnCreate(this.axMapControl1.Object);
            axMapControl1.CurrentTool = cmd as ITool;

        }
        #endregion

 

        //地图鼠标移动事件
        private void axMapControl1_OnMouseMove(object sender, IMapControlEvents2_OnMouseMoveEvent e)
        {
            double MapX = e.mapX;
            double MapXMin = 60 * (MapX - Math.Floor(MapX));
            double MapXSec = 60 * (MapXMin - Math.Floor(MapXMin));
            double MapY = e.mapY;
            double MapYMin = 60 * (MapY - Math.Floor(MapY));
            double MapYSec = 60 * (MapYMin - Math.Floor(MapYMin));
            Lbl_XY.Caption = "鼠标当前经度：" + MapX.ToString("0") + "°" + MapXMin.ToString("0") + "'" + MapXSec.ToString
            ("0.##") + "'',纬度：" + MapY.ToString("0") + "°" + MapYMin.ToString("0") + "'" + MapYSec.ToString
            ("0.##") + "'";
        }
        #region 菜单栏
        private void 打开地图ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = true;
            openFileDialog.Title = "打开地图文档";
            openFileDialog.Filter = "地图文档（*.mxd）|*.Mxd|地图模板（*.mxt）|*.Mxt";
            openFileDialog.Multiselect = false;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string sFileName = openFileDialog.FileName;
                axMapControl1.LoadMxFile(sFileName);
            }
        }

        private void 放大ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ICommand cmd = new ControlsMapZoomInTool();
            cmd.OnCreate(this.axMapControl1.Object);
            axMapControl1.CurrentTool = cmd as ITool;
        }

        private void 缩小ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ICommand cmd = new ControlsMapZoomOutTool();
            cmd.OnCreate(this.axMapControl1.Object);
            axMapControl1.CurrentTool = cmd as ITool;
        }

        private void 拖拽ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ICommand cmd = new ControlsMapPanTool();
            cmd.OnCreate(this.axMapControl1.Object);
            axMapControl1.CurrentTool = cmd as ITool;
        }

        private void 全图显示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ICommand Full = new ControlsMapFullExtentCommand();
            Full.OnCreate(axMapControl1.Object);
            Full.OnClick();
        }

        private void 前一视图ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ICommand Cmd = new ControlsMapZoomToLastExtentBackCommand();
            Cmd.OnCreate(this.axMapControl1.Object);
            Cmd.OnClick();
        }

        private void 后一视图ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ICommand Cmd = new ControlsMapZoomToLastExtentForwardCommand();
            Cmd.OnCreate(this.axMapControl1.Object);
            Cmd.OnClick();
        }

        private void 地图刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axMapControl1.Refresh();
        }

        private void 识别查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ICommand cmd = new ControlsMapIdentifyTool();
            cmd.OnCreate(this.axMapControl1.Object);
            axMapControl1.CurrentTool = cmd as ITool;
        }
#endregion
        #region 快捷键
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = true;
            openFileDialog.Title = "打开地图文档";
            openFileDialog.Filter = "地图文档（*.mxd）|*.Mxd|地图模板（*.mxt）|*.Mxt";
            openFileDialog.Multiselect = false;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string sFileName = openFileDialog.FileName;
                axMapControl1.LoadMxFile(sFileName);
            }
        }
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            ICommand cmd = new ControlsMapZoomInTool();
            cmd.OnCreate(this.axMapControl1.Object);
            axMapControl1.CurrentTool = cmd as ITool;
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            ICommand cmd = new ControlsMapZoomOutTool();
            cmd.OnCreate(this.axMapControl1.Object);
            axMapControl1.CurrentTool = cmd as ITool;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            ICommand cmd = new ControlsMapPanTool();
            cmd.OnCreate(this.axMapControl1.Object);
            axMapControl1.CurrentTool = cmd as ITool;
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            ICommand Full = new ControlsMapFullExtentCommand();
            Full.OnCreate(axMapControl1.Object);
            Full.OnClick();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            ICommand Cmd = new ControlsMapZoomToLastExtentBackCommand();
            Cmd.OnCreate(this.axMapControl1.Object);
            Cmd.OnClick();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            ICommand Cmd = new ControlsMapZoomToLastExtentForwardCommand();
            Cmd.OnCreate(this.axMapControl1.Object);
            Cmd.OnClick();
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            axMapControl1.Refresh();
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            ICommand cmd = new ControlsMapIdentifyTool();
            cmd.OnCreate(this.axMapControl1.Object);
            axMapControl1.CurrentTool = cmd as ITool;
        }
        #endregion

        private void toolStripButton11_Click(object sender, EventArgs e)
        {

        }

        private void 生成船舶调度方案ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo("D:大三下\\港口GIS\\大作业\\route\\route\\bin\\Debug\\route.exe");
            process.StartInfo = startInfo;
            process.Start();
}

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            axMapControl1.MapScale = 25000;
            axMapControl1.Refresh();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            axMapControl1.MapScale = 50000;
            axMapControl1.Refresh();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            axMapControl1.MapScale = 75000;
            axMapControl1.Refresh();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            axMapControl1.MapScale = 100000;
            axMapControl1.Refresh();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            axMapControl1.MapScale = 125000;
            axMapControl1.Refresh();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            axMapControl1.MapScale = 150000;
            axMapControl1.Refresh();
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"http://www.chinaports.com/ports/8e3495ae-387c-4209-8bd8-cdb525ba6f1a");
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = @"D:\大三下\港口GIS\大作业\港口GIS\基于蚁群算法的船舶避障航路规划系统说明.docx";
            System.Diagnostics.Process.Start(path); 
        }

        private void 关于我们ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string path = @"D:\大三下\港口GIS\大作业\港口GIS\关于我们.doc";
            System.Diagnostics.Process.Start(path); 
        }

      

        }

    }
