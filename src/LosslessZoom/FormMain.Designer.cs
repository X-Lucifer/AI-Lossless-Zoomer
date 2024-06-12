
using System.Windows.Forms;

namespace X.Lucifer.LosslessZoom
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.navbarMenu = new Sunny.UI.UINavBar();
            this.lblTime = new Sunny.UI.UILedDisplay();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lineBottom = new Sunny.UI.UILine();
            this.lineHeader = new Sunny.UI.UILine();
            this.lineCenter = new Sunny.UI.UILine();
            this.uiLine10 = new Sunny.UI.UILine();
            this.txtLog = new Sunny.UI.UIRichTextBox();
            this.lblVideoname = new Sunny.UI.UILabel();
            this.lblCpuLogic = new Sunny.UI.UILabel();
            this.lblCpu = new Sunny.UI.UILabel();
            this.lblProcessor = new Sunny.UI.UILabel();
            this.lblBrand = new Sunny.UI.UILabel();
            this.lblSysname = new Sunny.UI.UILabel();
            this.lblxsysname = new Sunny.UI.UILabel();
            this.lblxbrand = new Sunny.UI.UILabel();
            this.lblxprocessor = new Sunny.UI.UILabel();
            this.lblxcpu = new Sunny.UI.UILabel();
            this.lblxcpulogic = new Sunny.UI.UILabel();
            this.lblxvideo = new Sunny.UI.UILabel();
            this.panelInfo = new Sunny.UI.UIFlowLayoutPanel();
            this.uiLine1 = new Sunny.UI.UILine();
            this.btnProcess = new Sunny.UI.UISymbolButton();
            this.btnClearlog = new Sunny.UI.UISymbolButton();
            this.btnCleartask = new Sunny.UI.UISymbolButton();
            this.tooltipPic = new Sunny.UI.UIToolTip(this.components);
            this.progressInfo = new Sunny.UI.UIRoundProcess();
            this.lblTaskAll = new Sunny.UI.UILabel();
            this.lblTaskRemain = new Sunny.UI.UILabel();
            this.lblTotaltime = new Sunny.UI.UILabel();
            this.lblStart = new Sunny.UI.UILabel();
            this.ledTotaltime = new Sunny.UI.UILedStopwatch();
            this.ledStarttime = new Sunny.UI.UILedStopwatch();
            this.lblxTotal = new Sunny.UI.UILedLabel();
            this.lblxFinished = new Sunny.UI.UILedLabel();
            this.SuspendLayout();
            // 
            // navbarMenu
            // 
            this.navbarMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.navbarMenu.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (40)))), ((int) (((byte) (44)))), ((int) (((byte) (52)))));
            this.navbarMenu.DropDownItemAutoHeight = true;
            this.navbarMenu.DropMenuFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.navbarMenu.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.navbarMenu.Location = new System.Drawing.Point(0, 6);
            this.navbarMenu.Margin = new System.Windows.Forms.Padding(5);
            this.navbarMenu.MenuSelectedColorUsed = true;
            this.navbarMenu.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.navbarMenu.Name = "navbarMenu";
            this.navbarMenu.NodeAlignment = System.Drawing.StringAlignment.Near;
            this.navbarMenu.NodeInterval = 0;
            this.navbarMenu.NodeSize = new System.Drawing.Size(50, 40);
            this.navbarMenu.Radius = 3;
            this.navbarMenu.SelectedHighColorSize = 2;
            this.navbarMenu.ShowItemsArrow = false;
            this.navbarMenu.Size = new System.Drawing.Size(150, 35);
            this.navbarMenu.Style = Sunny.UI.UIStyle.Custom;
            this.navbarMenu.StyleCustomMode = true;
            this.navbarMenu.TabIndex = 0;
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (37)))), ((int) (((byte) (43)))));
            this.lblTime.BorderColor = System.Drawing.Color.Transparent;
            this.lblTime.BorderInColor = System.Drawing.Color.Transparent;
            this.lblTime.CharCount = 18;
            this.lblTime.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.lblTime.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblTime.Location = new System.Drawing.Point(25, 622);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(334, 34);
            this.lblTime.TabIndex = 2;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            // 
            // lineBottom
            // 
            this.lineBottom.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (40)))), ((int) (((byte) (44)))), ((int) (((byte) (52)))));
            this.lineBottom.FillColor = System.Drawing.Color.FromArgb(((int) (((byte) (40)))), ((int) (((byte) (44)))), ((int) (((byte) (52)))));
            this.lineBottom.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.lineBottom.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (37)))), ((int) (((byte) (43)))));
            this.lineBottom.LineColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (37)))), ((int) (((byte) (43)))));
            this.lineBottom.Location = new System.Drawing.Point(18, 594);
            this.lineBottom.Margin = new System.Windows.Forms.Padding(0);
            this.lineBottom.MinimumSize = new System.Drawing.Size(1, 1);
            this.lineBottom.Name = "lineBottom";
            this.lineBottom.Radius = 0;
            this.lineBottom.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.lineBottom.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.lineBottom.Size = new System.Drawing.Size(908, 10);
            this.lineBottom.Style = Sunny.UI.UIStyle.Custom;
            this.lineBottom.StyleCustomMode = true;
            this.lineBottom.TabIndex = 3;
            this.lineBottom.TextInterval = 0;
            // 
            // lineHeader
            // 
            this.lineHeader.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (40)))), ((int) (((byte) (44)))), ((int) (((byte) (52)))));
            this.lineHeader.FillColor = System.Drawing.Color.FromArgb(((int) (((byte) (40)))), ((int) (((byte) (44)))), ((int) (((byte) (52)))));
            this.lineHeader.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.lineHeader.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (37)))), ((int) (((byte) (43)))));
            this.lineHeader.LineColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (37)))), ((int) (((byte) (43)))));
            this.lineHeader.Location = new System.Drawing.Point(18, 50);
            this.lineHeader.Margin = new System.Windows.Forms.Padding(0);
            this.lineHeader.MinimumSize = new System.Drawing.Size(1, 1);
            this.lineHeader.Name = "lineHeader";
            this.lineHeader.Radius = 0;
            this.lineHeader.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.lineHeader.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.lineHeader.Size = new System.Drawing.Size(908, 10);
            this.lineHeader.Style = Sunny.UI.UIStyle.Custom;
            this.lineHeader.StyleCustomMode = true;
            this.lineHeader.TabIndex = 4;
            this.lineHeader.TextInterval = 0;
            // 
            // lineCenter
            // 
            this.lineCenter.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (40)))), ((int) (((byte) (44)))), ((int) (((byte) (52)))));
            this.lineCenter.FillColor = System.Drawing.Color.FromArgb(((int) (((byte) (40)))), ((int) (((byte) (44)))), ((int) (((byte) (52)))));
            this.lineCenter.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.lineCenter.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (37)))), ((int) (((byte) (43)))));
            this.lineCenter.LineColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (37)))), ((int) (((byte) (43)))));
            this.lineCenter.Location = new System.Drawing.Point(18, 329);
            this.lineCenter.Margin = new System.Windows.Forms.Padding(0);
            this.lineCenter.MinimumSize = new System.Drawing.Size(1, 1);
            this.lineCenter.Name = "lineCenter";
            this.lineCenter.Radius = 0;
            this.lineCenter.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.lineCenter.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.lineCenter.Size = new System.Drawing.Size(908, 10);
            this.lineCenter.Style = Sunny.UI.UIStyle.Custom;
            this.lineCenter.StyleCustomMode = true;
            this.lineCenter.TabIndex = 5;
            this.lineCenter.TextInterval = 0;
            // 
            // uiLine10
            // 
            this.uiLine10.BackColor = System.Drawing.Color.Transparent;
            this.uiLine10.Direction = Sunny.UI.UILine.LineDirection.Vertical;
            this.uiLine10.FillColor = System.Drawing.Color.FromArgb(((int) (((byte) (40)))), ((int) (((byte) (44)))), ((int) (((byte) (52)))));
            this.uiLine10.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.uiLine10.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (37)))), ((int) (((byte) (43)))));
            this.uiLine10.LineColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (37)))), ((int) (((byte) (43)))));
            this.uiLine10.Location = new System.Drawing.Point(467, 342);
            this.uiLine10.Margin = new System.Windows.Forms.Padding(0);
            this.uiLine10.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine10.Name = "uiLine10";
            this.uiLine10.Radius = 0;
            this.uiLine10.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiLine10.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiLine10.Size = new System.Drawing.Size(10, 249);
            this.uiLine10.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine10.TabIndex = 23;
            this.uiLine10.Text = "uiLine10";
            this.uiLine10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (40)))), ((int) (((byte) (44)))), ((int) (((byte) (52)))));
            this.txtLog.FillColor = System.Drawing.Color.FromArgb(((int) (((byte) (40)))), ((int) (((byte) (44)))), ((int) (((byte) (52)))));
            this.txtLog.FillDisableColor = System.Drawing.Color.FromArgb(((int) (((byte) (40)))), ((int) (((byte) (44)))), ((int) (((byte) (52)))));
            this.txtLog.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.txtLog.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (244)))), ((int) (((byte) (244)))), ((int) (((byte) (244)))));
            this.txtLog.ForeDisableColor = System.Drawing.Color.FromArgb(((int) (((byte) (40)))), ((int) (((byte) (44)))), ((int) (((byte) (52)))));
            this.txtLog.HideSelection = false;
            this.txtLog.Location = new System.Drawing.Point(485, 345);
            this.txtLog.Margin = new System.Windows.Forms.Padding(0);
            this.txtLog.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtLog.Name = "txtLog";
            this.txtLog.Padding = new System.Windows.Forms.Padding(2);
            this.txtLog.ReadOnly = true;
            this.txtLog.RectColor = System.Drawing.Color.FromArgb(((int) (((byte) (40)))), ((int) (((byte) (44)))), ((int) (((byte) (52)))));
            this.txtLog.RectDisableColor = System.Drawing.Color.FromArgb(((int) (((byte) (40)))), ((int) (((byte) (44)))), ((int) (((byte) (52)))));
            this.txtLog.ScrollBarStyleInherited = false;
            this.txtLog.ShortcutsEnabled = false;
            this.txtLog.ShowText = false;
            this.txtLog.Size = new System.Drawing.Size(460, 239);
            this.txtLog.Style = Sunny.UI.UIStyle.Custom;
            this.txtLog.StyleCustomMode = true;
            this.txtLog.TabIndex = 1;
            this.txtLog.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVideoname
            // 
            this.lblVideoname.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.lblVideoname.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (244)))), ((int) (((byte) (244)))), ((int) (((byte) (244)))));
            this.lblVideoname.Location = new System.Drawing.Point(23, 561);
            this.lblVideoname.Name = "lblVideoname";
            this.lblVideoname.Size = new System.Drawing.Size(82, 23);
            this.lblVideoname.Style = Sunny.UI.UIStyle.Custom;
            this.lblVideoname.StyleCustomMode = true;
            this.lblVideoname.TabIndex = 25;
            this.lblVideoname.Text = "显卡名称:";
            this.lblVideoname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCpuLogic
            // 
            this.lblCpuLogic.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.lblCpuLogic.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (244)))), ((int) (((byte) (244)))), ((int) (((byte) (244)))));
            this.lblCpuLogic.Location = new System.Drawing.Point(23, 519);
            this.lblCpuLogic.Name = "lblCpuLogic";
            this.lblCpuLogic.Size = new System.Drawing.Size(82, 23);
            this.lblCpuLogic.Style = Sunny.UI.UIStyle.Custom;
            this.lblCpuLogic.StyleCustomMode = true;
            this.lblCpuLogic.TabIndex = 25;
            this.lblCpuLogic.Text = "逻辑核心:";
            this.lblCpuLogic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCpu
            // 
            this.lblCpu.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.lblCpu.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (244)))), ((int) (((byte) (244)))), ((int) (((byte) (244)))));
            this.lblCpu.Location = new System.Drawing.Point(23, 477);
            this.lblCpu.Name = "lblCpu";
            this.lblCpu.Size = new System.Drawing.Size(82, 23);
            this.lblCpu.Style = Sunny.UI.UIStyle.Custom;
            this.lblCpu.StyleCustomMode = true;
            this.lblCpu.TabIndex = 25;
            this.lblCpu.Text = "物理核心:";
            this.lblCpu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProcessor
            // 
            this.lblProcessor.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.lblProcessor.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (244)))), ((int) (((byte) (244)))), ((int) (((byte) (244)))));
            this.lblProcessor.Location = new System.Drawing.Point(23, 435);
            this.lblProcessor.Name = "lblProcessor";
            this.lblProcessor.Size = new System.Drawing.Size(82, 23);
            this.lblProcessor.Style = Sunny.UI.UIStyle.Custom;
            this.lblProcessor.StyleCustomMode = true;
            this.lblProcessor.TabIndex = 25;
            this.lblProcessor.Text = "处理器:";
            this.lblProcessor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBrand
            // 
            this.lblBrand.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.lblBrand.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (244)))), ((int) (((byte) (244)))), ((int) (((byte) (244)))));
            this.lblBrand.Location = new System.Drawing.Point(23, 393);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(82, 23);
            this.lblBrand.Style = Sunny.UI.UIStyle.Custom;
            this.lblBrand.StyleCustomMode = true;
            this.lblBrand.TabIndex = 25;
            this.lblBrand.Text = "品牌名称:";
            this.lblBrand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSysname
            // 
            this.lblSysname.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.lblSysname.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (244)))), ((int) (((byte) (244)))), ((int) (((byte) (244)))));
            this.lblSysname.Location = new System.Drawing.Point(23, 351);
            this.lblSysname.Name = "lblSysname";
            this.lblSysname.Size = new System.Drawing.Size(82, 23);
            this.lblSysname.Style = Sunny.UI.UIStyle.Custom;
            this.lblSysname.StyleCustomMode = true;
            this.lblSysname.TabIndex = 25;
            this.lblSysname.Text = "系统名称:";
            this.lblSysname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblxsysname
            // 
            this.lblxsysname.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.lblxsysname.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (244)))), ((int) (((byte) (244)))), ((int) (((byte) (244)))));
            this.lblxsysname.Location = new System.Drawing.Point(113, 351);
            this.lblxsysname.Name = "lblxsysname";
            this.lblxsysname.Size = new System.Drawing.Size(334, 23);
            this.lblxsysname.Style = Sunny.UI.UIStyle.Custom;
            this.lblxsysname.StyleCustomMode = true;
            this.lblxsysname.TabIndex = 26;
            this.lblxsysname.Text = "-";
            this.lblxsysname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblxbrand
            // 
            this.lblxbrand.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.lblxbrand.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (244)))), ((int) (((byte) (244)))), ((int) (((byte) (244)))));
            this.lblxbrand.Location = new System.Drawing.Point(113, 393);
            this.lblxbrand.Name = "lblxbrand";
            this.lblxbrand.Size = new System.Drawing.Size(334, 23);
            this.lblxbrand.Style = Sunny.UI.UIStyle.Custom;
            this.lblxbrand.StyleCustomMode = true;
            this.lblxbrand.TabIndex = 27;
            this.lblxbrand.Text = "-";
            this.lblxbrand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblxprocessor
            // 
            this.lblxprocessor.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.lblxprocessor.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (244)))), ((int) (((byte) (244)))), ((int) (((byte) (244)))));
            this.lblxprocessor.Location = new System.Drawing.Point(113, 435);
            this.lblxprocessor.Name = "lblxprocessor";
            this.lblxprocessor.Size = new System.Drawing.Size(334, 23);
            this.lblxprocessor.Style = Sunny.UI.UIStyle.Custom;
            this.lblxprocessor.StyleCustomMode = true;
            this.lblxprocessor.TabIndex = 28;
            this.lblxprocessor.Text = "-";
            this.lblxprocessor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblxcpu
            // 
            this.lblxcpu.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.lblxcpu.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (244)))), ((int) (((byte) (244)))), ((int) (((byte) (244)))));
            this.lblxcpu.Location = new System.Drawing.Point(113, 477);
            this.lblxcpu.Name = "lblxcpu";
            this.lblxcpu.Size = new System.Drawing.Size(334, 23);
            this.lblxcpu.Style = Sunny.UI.UIStyle.Custom;
            this.lblxcpu.StyleCustomMode = true;
            this.lblxcpu.TabIndex = 29;
            this.lblxcpu.Text = "-";
            this.lblxcpu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblxcpulogic
            // 
            this.lblxcpulogic.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.lblxcpulogic.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (244)))), ((int) (((byte) (244)))), ((int) (((byte) (244)))));
            this.lblxcpulogic.Location = new System.Drawing.Point(113, 519);
            this.lblxcpulogic.Name = "lblxcpulogic";
            this.lblxcpulogic.Size = new System.Drawing.Size(334, 23);
            this.lblxcpulogic.Style = Sunny.UI.UIStyle.Custom;
            this.lblxcpulogic.StyleCustomMode = true;
            this.lblxcpulogic.TabIndex = 30;
            this.lblxcpulogic.Text = "-";
            this.lblxcpulogic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblxvideo
            // 
            this.lblxvideo.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.lblxvideo.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (244)))), ((int) (((byte) (244)))), ((int) (((byte) (244)))));
            this.lblxvideo.Location = new System.Drawing.Point(113, 561);
            this.lblxvideo.Name = "lblxvideo";
            this.lblxvideo.Size = new System.Drawing.Size(334, 23);
            this.lblxvideo.Style = Sunny.UI.UIStyle.Custom;
            this.lblxvideo.StyleCustomMode = true;
            this.lblxvideo.TabIndex = 31;
            this.lblxvideo.Text = "-";
            this.lblxvideo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelInfo
            // 
            this.panelInfo.AllowDrop = true;
            this.panelInfo.FillColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (37)))), ((int) (((byte) (43)))));
            this.panelInfo.FillDisableColor = System.Drawing.Color.FromArgb(((int) (((byte) (40)))), ((int) (((byte) (44)))), ((int) (((byte) (52)))));
            this.panelInfo.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.panelInfo.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (244)))), ((int) (((byte) (244)))), ((int) (((byte) (244)))));
            this.panelInfo.ForeDisableColor = System.Drawing.Color.FromArgb(((int) (((byte) (40)))), ((int) (((byte) (44)))), ((int) (((byte) (52)))));
            this.panelInfo.Location = new System.Drawing.Point(25, 64);
            this.panelInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelInfo.MinimumSize = new System.Drawing.Size(1, 1);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Padding = new System.Windows.Forms.Padding(2);
            this.panelInfo.RectColor = System.Drawing.Color.FromArgb(((int) (((byte) (40)))), ((int) (((byte) (44)))), ((int) (((byte) (52)))));
            this.panelInfo.RectDisableColor = System.Drawing.Color.FromArgb(((int) (((byte) (40)))), ((int) (((byte) (44)))), ((int) (((byte) (52)))));
            this.panelInfo.RectSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides) (((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.panelInfo.ScrollBarColor = System.Drawing.Color.FromArgb(((int) (((byte) (40)))), ((int) (((byte) (44)))), ((int) (((byte) (52)))));
            this.panelInfo.ScrollBarStyleInherited = false;
            this.panelInfo.ShowText = false;
            this.panelInfo.Size = new System.Drawing.Size(752, 260);
            this.panelInfo.Style = Sunny.UI.UIStyle.Custom;
            this.panelInfo.StyleCustomMode = true;
            this.panelInfo.TabIndex = 0;
            this.panelInfo.Text = null;
            this.panelInfo.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.panelInfo.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelInfo_DragEnter);
            // 
            // uiLine1
            // 
            this.uiLine1.BackColor = System.Drawing.Color.Transparent;
            this.uiLine1.Direction = Sunny.UI.UILine.LineDirection.Vertical;
            this.uiLine1.FillColor = System.Drawing.Color.FromArgb(((int) (((byte) (40)))), ((int) (((byte) (44)))), ((int) (((byte) (52)))));
            this.uiLine1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.uiLine1.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (37)))), ((int) (((byte) (43)))));
            this.uiLine1.LineColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (37)))), ((int) (((byte) (43)))));
            this.uiLine1.Location = new System.Drawing.Point(785, 70);
            this.uiLine1.Margin = new System.Windows.Forms.Padding(0);
            this.uiLine1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Radius = 0;
            this.uiLine1.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiLine1.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiLine1.Size = new System.Drawing.Size(10, 249);
            this.uiLine1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine1.TabIndex = 32;
            this.uiLine1.Text = "uiLine1";
            this.uiLine1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnProcess
            // 
            this.btnProcess.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (37)))), ((int) (((byte) (43)))));
            this.btnProcess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProcess.FillColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (37)))), ((int) (((byte) (43)))));
            this.btnProcess.FillDisableColor = System.Drawing.Color.FromArgb(((int) (((byte) (73)))), ((int) (((byte) (216)))), ((int) (((byte) (64)))));
            this.btnProcess.FillHoverColor = System.Drawing.Color.FromArgb(((int) (((byte) (73)))), ((int) (((byte) (216)))), ((int) (((byte) (64)))));
            this.btnProcess.FillPressColor = System.Drawing.Color.FromArgb(((int) (((byte) (73)))), ((int) (((byte) (216)))), ((int) (((byte) (64)))));
            this.btnProcess.FillSelectedColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (37)))), ((int) (((byte) (43)))));
            this.btnProcess.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnProcess.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (73)))), ((int) (((byte) (216)))), ((int) (((byte) (64)))));
            this.btnProcess.ForeDisableColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (37)))), ((int) (((byte) (43)))));
            this.btnProcess.ForeHoverColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (37)))), ((int) (((byte) (43)))));
            this.btnProcess.ForePressColor = System.Drawing.Color.FromArgb(((int) (((byte) (73)))), ((int) (((byte) (216)))), ((int) (((byte) (64)))));
            this.btnProcess.ForeSelectedColor = System.Drawing.Color.FromArgb(((int) (((byte) (73)))), ((int) (((byte) (216)))), ((int) (((byte) (64)))));
            this.btnProcess.Location = new System.Drawing.Point(807, 246);
            this.btnProcess.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.RectColor = System.Drawing.Color.FromArgb(((int) (((byte) (40)))), ((int) (((byte) (44)))), ((int) (((byte) (52)))));
            this.btnProcess.RectDisableColor = System.Drawing.Color.FromArgb(((int) (((byte) (73)))), ((int) (((byte) (216)))), ((int) (((byte) (64)))));
            this.btnProcess.RectHoverColor = System.Drawing.Color.FromArgb(((int) (((byte) (73)))), ((int) (((byte) (216)))), ((int) (((byte) (64)))));
            this.btnProcess.RectPressColor = System.Drawing.Color.FromArgb(((int) (((byte) (73)))), ((int) (((byte) (216)))), ((int) (((byte) (64)))));
            this.btnProcess.RectSelectedColor = System.Drawing.Color.FromArgb(((int) (((byte) (73)))), ((int) (((byte) (216)))), ((int) (((byte) (64)))));
            this.btnProcess.Size = new System.Drawing.Size(112, 51);
            this.btnProcess.Style = Sunny.UI.UIStyle.Custom;
            this.btnProcess.StyleCustomMode = true;
            this.btnProcess.Symbol = 361515;
            this.btnProcess.TabIndex = 33;
            this.btnProcess.Text = "开始任务";
            this.btnProcess.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            // 
            // btnClearlog
            // 
            this.btnClearlog.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (37)))), ((int) (((byte) (43)))));
            this.btnClearlog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearlog.FillColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (37)))), ((int) (((byte) (43)))));
            this.btnClearlog.FillDisableColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (128)))), ((int) (((byte) (0)))));
            this.btnClearlog.FillHoverColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (128)))), ((int) (((byte) (0)))));
            this.btnClearlog.FillPressColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (128)))), ((int) (((byte) (0)))));
            this.btnClearlog.FillSelectedColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (37)))), ((int) (((byte) (43)))));
            this.btnClearlog.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnClearlog.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (128)))), ((int) (((byte) (0)))));
            this.btnClearlog.ForeDisableColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (37)))), ((int) (((byte) (43)))));
            this.btnClearlog.ForeHoverColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (37)))), ((int) (((byte) (43)))));
            this.btnClearlog.ForePressColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (128)))), ((int) (((byte) (0)))));
            this.btnClearlog.ForeSelectedColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (128)))), ((int) (((byte) (0)))));
            this.btnClearlog.Location = new System.Drawing.Point(807, 170);
            this.btnClearlog.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnClearlog.Name = "btnClearlog";
            this.btnClearlog.RectColor = System.Drawing.Color.FromArgb(((int) (((byte) (40)))), ((int) (((byte) (44)))), ((int) (((byte) (52)))));
            this.btnClearlog.RectDisableColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (128)))), ((int) (((byte) (0)))));
            this.btnClearlog.RectHoverColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (128)))), ((int) (((byte) (0)))));
            this.btnClearlog.RectPressColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (128)))), ((int) (((byte) (0)))));
            this.btnClearlog.RectSelectedColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (128)))), ((int) (((byte) (0)))));
            this.btnClearlog.Size = new System.Drawing.Size(112, 51);
            this.btnClearlog.Style = Sunny.UI.UIStyle.Custom;
            this.btnClearlog.StyleCustomMode = true;
            this.btnClearlog.Symbol = 361741;
            this.btnClearlog.TabIndex = 33;
            this.btnClearlog.Text = "清空日志";
            this.btnClearlog.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.btnClearlog.Click += new System.EventHandler(this.btnClearlog_Click);
            // 
            // btnCleartask
            // 
            this.btnCleartask.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (37)))), ((int) (((byte) (43)))));
            this.btnCleartask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCleartask.FillColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (37)))), ((int) (((byte) (43)))));
            this.btnCleartask.FillDisableColor = System.Drawing.Color.FromArgb(((int) (((byte) (252)))), ((int) (((byte) (1)))), ((int) (((byte) (26)))));
            this.btnCleartask.FillHoverColor = System.Drawing.Color.FromArgb(((int) (((byte) (252)))), ((int) (((byte) (1)))), ((int) (((byte) (26)))));
            this.btnCleartask.FillPressColor = System.Drawing.Color.FromArgb(((int) (((byte) (252)))), ((int) (((byte) (1)))), ((int) (((byte) (26)))));
            this.btnCleartask.FillSelectedColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (37)))), ((int) (((byte) (43)))));
            this.btnCleartask.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnCleartask.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (252)))), ((int) (((byte) (1)))), ((int) (((byte) (26)))));
            this.btnCleartask.ForeDisableColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (37)))), ((int) (((byte) (43)))));
            this.btnCleartask.ForeHoverColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (37)))), ((int) (((byte) (43)))));
            this.btnCleartask.ForePressColor = System.Drawing.Color.FromArgb(((int) (((byte) (252)))), ((int) (((byte) (1)))), ((int) (((byte) (26)))));
            this.btnCleartask.ForeSelectedColor = System.Drawing.Color.FromArgb(((int) (((byte) (252)))), ((int) (((byte) (1)))), ((int) (((byte) (26)))));
            this.btnCleartask.Location = new System.Drawing.Point(807, 94);
            this.btnCleartask.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCleartask.Name = "btnCleartask";
            this.btnCleartask.RectColor = System.Drawing.Color.FromArgb(((int) (((byte) (40)))), ((int) (((byte) (44)))), ((int) (((byte) (52)))));
            this.btnCleartask.RectDisableColor = System.Drawing.Color.FromArgb(((int) (((byte) (252)))), ((int) (((byte) (1)))), ((int) (((byte) (26)))));
            this.btnCleartask.RectHoverColor = System.Drawing.Color.FromArgb(((int) (((byte) (252)))), ((int) (((byte) (1)))), ((int) (((byte) (26)))));
            this.btnCleartask.RectPressColor = System.Drawing.Color.FromArgb(((int) (((byte) (252)))), ((int) (((byte) (1)))), ((int) (((byte) (26)))));
            this.btnCleartask.RectSelectedColor = System.Drawing.Color.FromArgb(((int) (((byte) (252)))), ((int) (((byte) (1)))), ((int) (((byte) (26)))));
            this.btnCleartask.Size = new System.Drawing.Size(112, 51);
            this.btnCleartask.Style = Sunny.UI.UIStyle.Custom;
            this.btnCleartask.StyleCustomMode = true;
            this.btnCleartask.Symbol = 361944;
            this.btnCleartask.TabIndex = 33;
            this.btnCleartask.Text = "清空任务";
            this.btnCleartask.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.btnCleartask.Click += new System.EventHandler(this.btnCleartask_Click);
            // 
            // tooltipPic
            // 
            this.tooltipPic.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (54)))), ((int) (((byte) (54)))), ((int) (((byte) (54)))));
            this.tooltipPic.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.tooltipPic.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (244)))), ((int) (((byte) (244)))), ((int) (((byte) (244)))));
            this.tooltipPic.OwnerDraw = true;
            this.tooltipPic.RectColor = System.Drawing.Color.FromArgb(((int) (((byte) (54)))), ((int) (((byte) (54)))), ((int) (((byte) (54)))));
            // 
            // progressInfo
            // 
            this.progressInfo.BackColor = System.Drawing.Color.Transparent;
            this.progressInfo.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.progressInfo.ForeColor = System.Drawing.Color.White;
            this.progressInfo.ForeColor2 = System.Drawing.Color.Black;
            this.progressInfo.Inner = 0;
            this.progressInfo.Location = new System.Drawing.Point(850, 601);
            this.progressInfo.Margin = new System.Windows.Forms.Padding(0);
            this.progressInfo.MinimumSize = new System.Drawing.Size(1, 1);
            this.progressInfo.Name = "progressInfo";
            this.progressInfo.Outer = 36;
            this.progressInfo.ProcessBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (37)))), ((int) (((byte) (43)))));
            this.progressInfo.Radius = 0;
            this.progressInfo.ShowFocusColor = true;
            this.progressInfo.ShowProcess = true;
            this.progressInfo.Size = new System.Drawing.Size(76, 76);
            this.progressInfo.Style = Sunny.UI.UIStyle.Custom;
            this.progressInfo.StyleCustomMode = true;
            this.progressInfo.TabIndex = 10;
            this.progressInfo.Text = "0.0%";
            // 
            // lblTaskAll
            // 
            this.lblTaskAll.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.lblTaskAll.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (244)))), ((int) (((byte) (244)))), ((int) (((byte) (244)))));
            this.lblTaskAll.Location = new System.Drawing.Point(664, 611);
            this.lblTaskAll.Name = "lblTaskAll";
            this.lblTaskAll.Size = new System.Drawing.Size(74, 23);
            this.lblTaskAll.Style = Sunny.UI.UIStyle.Custom;
            this.lblTaskAll.StyleCustomMode = true;
            this.lblTaskAll.TabIndex = 34;
            this.lblTaskAll.Text = "总任务:";
            this.lblTaskAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTaskRemain
            // 
            this.lblTaskRemain.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.lblTaskRemain.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (244)))), ((int) (((byte) (244)))), ((int) (((byte) (244)))));
            this.lblTaskRemain.Location = new System.Drawing.Point(664, 646);
            this.lblTaskRemain.Name = "lblTaskRemain";
            this.lblTaskRemain.Size = new System.Drawing.Size(74, 23);
            this.lblTaskRemain.Style = Sunny.UI.UIStyle.Custom;
            this.lblTaskRemain.StyleCustomMode = true;
            this.lblTaskRemain.TabIndex = 34;
            this.lblTaskRemain.Text = "已完成:";
            this.lblTaskRemain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotaltime
            // 
            this.lblTotaltime.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.lblTotaltime.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (244)))), ((int) (((byte) (244)))), ((int) (((byte) (244)))));
            this.lblTotaltime.Location = new System.Drawing.Point(385, 647);
            this.lblTotaltime.Name = "lblTotaltime";
            this.lblTotaltime.Size = new System.Drawing.Size(81, 23);
            this.lblTotaltime.Style = Sunny.UI.UIStyle.Custom;
            this.lblTotaltime.StyleCustomMode = true;
            this.lblTotaltime.TabIndex = 36;
            this.lblTotaltime.Text = "任务耗时:";
            this.lblTotaltime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStart
            // 
            this.lblStart.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.lblStart.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (244)))), ((int) (((byte) (244)))), ((int) (((byte) (244)))));
            this.lblStart.Location = new System.Drawing.Point(385, 612);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(81, 23);
            this.lblStart.Style = Sunny.UI.UIStyle.Custom;
            this.lblStart.StyleCustomMode = true;
            this.lblStart.TabIndex = 38;
            this.lblStart.Text = "任务开始:";
            this.lblStart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ledTotaltime
            // 
            this.ledTotaltime.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (37)))), ((int) (((byte) (43)))));
            this.ledTotaltime.BorderColor = System.Drawing.Color.Transparent;
            this.ledTotaltime.BorderInColor = System.Drawing.Color.Transparent;
            this.ledTotaltime.CharCount = 8;
            this.ledTotaltime.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.ledTotaltime.ForeColor = System.Drawing.Color.LimeGreen;
            this.ledTotaltime.IntervalV = 3;
            this.ledTotaltime.Location = new System.Drawing.Point(474, 643);
            this.ledTotaltime.Name = "ledTotaltime";
            this.ledTotaltime.ShowType = Sunny.UI.UILedStopwatch.TimeShowType.hhmmss;
            this.ledTotaltime.Size = new System.Drawing.Size(154, 30);
            this.ledTotaltime.TabIndex = 39;
            this.ledTotaltime.TabStop = false;
            this.ledTotaltime.Text = "00:00";
            // 
            // ledStarttime
            // 
            this.ledStarttime.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (37)))), ((int) (((byte) (43)))));
            this.ledStarttime.BorderColor = System.Drawing.Color.Transparent;
            this.ledStarttime.BorderInColor = System.Drawing.Color.Transparent;
            this.ledStarttime.CharCount = 8;
            this.ledStarttime.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.ledStarttime.ForeColor = System.Drawing.Color.LimeGreen;
            this.ledStarttime.IntervalV = 3;
            this.ledStarttime.Location = new System.Drawing.Point(474, 608);
            this.ledStarttime.Name = "ledStarttime";
            this.ledStarttime.ShowType = Sunny.UI.UILedStopwatch.TimeShowType.hhmmss;
            this.ledStarttime.Size = new System.Drawing.Size(154, 30);
            this.ledStarttime.TabIndex = 40;
            this.ledStarttime.TabStop = false;
            this.ledStarttime.Text = "00:00";
            // 
            // lblxTotal
            // 
            this.lblxTotal.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.lblxTotal.Location = new System.Drawing.Point(746, 606);
            this.lblxTotal.MinimumSize = new System.Drawing.Size(1, 1);
            this.lblxTotal.Name = "lblxTotal";
            this.lblxTotal.Size = new System.Drawing.Size(58, 32);
            this.lblxTotal.Style = Sunny.UI.UIStyle.Custom;
            this.lblxTotal.TabIndex = 41;
            this.lblxTotal.TabStop = false;
            this.lblxTotal.Text = "-";
            // 
            // lblxFinished
            // 
            this.lblxFinished.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.lblxFinished.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblxFinished.Location = new System.Drawing.Point(746, 641);
            this.lblxFinished.MinimumSize = new System.Drawing.Size(1, 1);
            this.lblxFinished.Name = "lblxFinished";
            this.lblxFinished.Size = new System.Drawing.Size(58, 32);
            this.lblxFinished.Style = Sunny.UI.UIStyle.Custom;
            this.lblxFinished.TabIndex = 3;
            this.lblxFinished.TabStop = false;
            this.lblxFinished.Text = "-";
            // 
            // FormMain
            // 
            this.AllowAddControlOnTitle = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (40)))), ((int) (((byte) (44)))), ((int) (((byte) (52)))));
            this.ClientSize = new System.Drawing.Size(945, 694);
            this.CloseAskString = "";
            this.Controls.Add(this.lblxFinished);
            this.Controls.Add(this.lblxTotal);
            this.Controls.Add(this.ledStarttime);
            this.Controls.Add(this.ledTotaltime);
            this.Controls.Add(this.lblTotaltime);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.lblTaskRemain);
            this.Controls.Add(this.lblTaskAll);
            this.Controls.Add(this.progressInfo);
            this.Controls.Add(this.btnCleartask);
            this.Controls.Add(this.btnClearlog);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.uiLine1);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.lblxsysname);
            this.Controls.Add(this.lblxbrand);
            this.Controls.Add(this.lblxprocessor);
            this.Controls.Add(this.lblxcpu);
            this.Controls.Add(this.lblxcpulogic);
            this.Controls.Add(this.lblxvideo);
            this.Controls.Add(this.lblSysname);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lblProcessor);
            this.Controls.Add(this.lblCpu);
            this.Controls.Add(this.lblCpuLogic);
            this.Controls.Add(this.lblVideoname);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.uiLine10);
            this.Controls.Add(this.lineCenter);
            this.Controls.Add(this.lineHeader);
            this.Controls.Add(this.lineBottom);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.navbarMenu);
            this.ForeColor = System.Drawing.Color.White;
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.RectColor = System.Drawing.Color.FromArgb(((int) (((byte) (40)))), ((int) (((byte) (44)))), ((int) (((byte) (52)))));
            this.Style = Sunny.UI.UIStyle.Custom;
            this.TextAlignment = System.Drawing.StringAlignment.Center;
            this.TitleColor = System.Drawing.Color.FromArgb(((int) (((byte) (40)))), ((int) (((byte) (44)))), ((int) (((byte) (52)))));
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 944, 679);
            this.ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UINavBar navbarMenu;
        private Sunny.UI.UILedDisplay lblTime;
        private System.Windows.Forms.Timer timer;
        private Sunny.UI.UILine lineBottom;
        private Sunny.UI.UILine lineHeader;
        private Sunny.UI.UILine lineCenter;
        private Sunny.UI.UILine uiLine10;
        private Sunny.UI.UIRichTextBox txtLog;
        private Sunny.UI.UILabel lblVideoname;
        private Sunny.UI.UILabel lblCpuLogic;
        private Sunny.UI.UILabel lblCpu;
        private Sunny.UI.UILabel lblProcessor;
        private Sunny.UI.UILabel lblBrand;
        private Sunny.UI.UILabel lblSysname;
        private Sunny.UI.UILabel lblxsysname;
        private Sunny.UI.UILabel lblxbrand;
        private Sunny.UI.UILabel lblxprocessor;
        private Sunny.UI.UILabel lblxcpu;
        private Sunny.UI.UILabel lblxcpulogic;
        private Sunny.UI.UILabel lblxvideo;
        private Sunny.UI.UIFlowLayoutPanel panelInfo;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UISymbolButton btnProcess;
        private Sunny.UI.UISymbolButton btnClearlog;
        private Sunny.UI.UISymbolButton btnCleartask;
        private Sunny.UI.UIToolTip tooltipPic;
        private Sunny.UI.UIRoundProcess progressInfo;
        private Sunny.UI.UILabel lblTaskAll;
        private Sunny.UI.UILabel lblTaskRemain;
        private Sunny.UI.UILabel lblTotaltime;
        private Sunny.UI.UILabel lblStart;
        private Sunny.UI.UILedStopwatch ledTotaltime;
        private Sunny.UI.UILedStopwatch ledStarttime;
        private Sunny.UI.UILedLabel lblxTotal;
        private Sunny.UI.UILedLabel lblxFinished;
    }
}

