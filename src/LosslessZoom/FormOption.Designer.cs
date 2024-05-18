
namespace X.Lucifer.LosslessZoom
{
    partial class FormOption
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOption));
            this.lblAppendExt = new Sunny.UI.UILabel();
            this.lblModule = new Sunny.UI.UILabel();
            this.lblFormat = new Sunny.UI.UILabel();
            this.lblOutDir = new Sunny.UI.UILabel();
            this.txtAppendExt = new Sunny.UI.UITextBox();
            this.cbxModule = new Sunny.UI.UIComboBox();
            this.rbDefault = new Sunny.UI.UIRadioButton();
            this.rbManual = new Sunny.UI.UIRadioButton();
            this.btnBrowser = new Sunny.UI.UISymbolButton();
            this.cbxFormat = new Sunny.UI.UIComboBox();
            this.txtOutDir = new Sunny.UI.UIRichTextBox();
            this.pnlBtm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBtm
            // 
            this.pnlBtm.Dock = System.Windows.Forms.DockStyle.None;
            this.pnlBtm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.pnlBtm.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.pnlBtm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.pnlBtm.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.pnlBtm.Location = new System.Drawing.Point(-1, 279);
            this.pnlBtm.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBtm.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.pnlBtm.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.pnlBtm.Size = new System.Drawing.Size(525, 71);
            this.pnlBtm.Style = Sunny.UI.UIStyle.Custom;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(394, 12);
            this.btnCancel.Style = Sunny.UI.UIStyle.Custom;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(279, 12);
            this.btnOK.Style = Sunny.UI.UIStyle.Custom;
            // 
            // lblAppendExt
            // 
            this.lblAppendExt.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lblAppendExt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.lblAppendExt.Location = new System.Drawing.Point(69, 52);
            this.lblAppendExt.Name = "lblAppendExt";
            this.lblAppendExt.Size = new System.Drawing.Size(100, 23);
            this.lblAppendExt.Style = Sunny.UI.UIStyle.Custom;
            this.lblAppendExt.TabIndex = 2;
            this.lblAppendExt.Text = "文件后缀:";
            this.lblAppendExt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblModule
            // 
            this.lblModule.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lblModule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.lblModule.Location = new System.Drawing.Point(69, 96);
            this.lblModule.Name = "lblModule";
            this.lblModule.Size = new System.Drawing.Size(100, 23);
            this.lblModule.Style = Sunny.UI.UIStyle.Custom;
            this.lblModule.TabIndex = 2;
            this.lblModule.Text = "引擎模块:";
            this.lblModule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFormat
            // 
            this.lblFormat.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lblFormat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.lblFormat.Location = new System.Drawing.Point(69, 140);
            this.lblFormat.Name = "lblFormat";
            this.lblFormat.Size = new System.Drawing.Size(100, 23);
            this.lblFormat.Style = Sunny.UI.UIStyle.Custom;
            this.lblFormat.TabIndex = 2;
            this.lblFormat.Text = "输出格式:";
            this.lblFormat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOutDir
            // 
            this.lblOutDir.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lblOutDir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.lblOutDir.Location = new System.Drawing.Point(69, 184);
            this.lblOutDir.Name = "lblOutDir";
            this.lblOutDir.Size = new System.Drawing.Size(100, 23);
            this.lblOutDir.Style = Sunny.UI.UIStyle.Custom;
            this.lblOutDir.TabIndex = 2;
            this.lblOutDir.Text = "输出目录:";
            this.lblOutDir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAppendExt
            // 
            this.txtAppendExt.ButtonSymbol = 61761;
            this.txtAppendExt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAppendExt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.txtAppendExt.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.txtAppendExt.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtAppendExt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txtAppendExt.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.txtAppendExt.Location = new System.Drawing.Point(176, 49);
            this.txtAppendExt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAppendExt.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtAppendExt.Name = "txtAppendExt";
            this.txtAppendExt.Padding = new System.Windows.Forms.Padding(5);
            this.txtAppendExt.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.txtAppendExt.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.txtAppendExt.ShowText = false;
            this.txtAppendExt.Size = new System.Drawing.Size(290, 29);
            this.txtAppendExt.Style = Sunny.UI.UIStyle.Custom;
            this.txtAppendExt.TabIndex = 3;
            this.txtAppendExt.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtAppendExt.Watermark = "";
            // 
            // cbxModule
            // 
            this.cbxModule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.cbxModule.DataSource = null;
            this.cbxModule.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbxModule.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.cbxModule.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.cbxModule.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cbxModule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.cbxModule.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.cbxModule.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbxModule.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbxModule.Location = new System.Drawing.Point(176, 93);
            this.cbxModule.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxModule.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbxModule.Name = "cbxModule";
            this.cbxModule.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbxModule.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.cbxModule.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.cbxModule.Size = new System.Drawing.Size(290, 29);
            this.cbxModule.Style = Sunny.UI.UIStyle.Custom;
            this.cbxModule.SymbolSize = 24;
            this.cbxModule.TabIndex = 4;
            this.cbxModule.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbxModule.Watermark = "";
            // 
            // rbDefault
            // 
            this.rbDefault.Checked = true;
            this.rbDefault.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbDefault.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.rbDefault.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.rbDefault.Location = new System.Drawing.Point(176, 180);
            this.rbDefault.MinimumSize = new System.Drawing.Size(1, 1);
            this.rbDefault.Name = "rbDefault";
            this.rbDefault.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.rbDefault.Size = new System.Drawing.Size(123, 30);
            this.rbDefault.Style = Sunny.UI.UIStyle.Custom;
            this.rbDefault.TabIndex = 6;
            this.rbDefault.Tag = "1";
            this.rbDefault.Text = "默认目录";
            // 
            // rbManual
            // 
            this.rbManual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbManual.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.rbManual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.rbManual.Location = new System.Drawing.Point(343, 180);
            this.rbManual.MinimumSize = new System.Drawing.Size(1, 1);
            this.rbManual.Name = "rbManual";
            this.rbManual.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.rbManual.Size = new System.Drawing.Size(123, 30);
            this.rbManual.Style = Sunny.UI.UIStyle.Custom;
            this.rbManual.TabIndex = 7;
            this.rbManual.Tag = "2";
            this.rbManual.Text = "指定目录";
            // 
            // btnBrowser
            // 
            this.btnBrowser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.btnBrowser.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnBrowser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btnBrowser.Location = new System.Drawing.Point(400, 229);
            this.btnBrowser.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.btnBrowser.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.btnBrowser.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.btnBrowser.Size = new System.Drawing.Size(66, 29);
            this.btnBrowser.Style = Sunny.UI.UIStyle.Custom;
            this.btnBrowser.StyleCustomMode = true;
            this.btnBrowser.Symbol = 61564;
            this.btnBrowser.TabIndex = 9;
            this.btnBrowser.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBrowser.Visible = false;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // cbxFormat
            // 
            this.cbxFormat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.cbxFormat.DataSource = null;
            this.cbxFormat.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbxFormat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.cbxFormat.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.cbxFormat.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cbxFormat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.cbxFormat.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.cbxFormat.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbxFormat.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbxFormat.Location = new System.Drawing.Point(176, 137);
            this.cbxFormat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxFormat.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbxFormat.Name = "cbxFormat";
            this.cbxFormat.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbxFormat.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.cbxFormat.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.cbxFormat.Size = new System.Drawing.Size(290, 29);
            this.cbxFormat.Style = Sunny.UI.UIStyle.Custom;
            this.cbxFormat.SymbolSize = 24;
            this.cbxFormat.TabIndex = 5;
            this.cbxFormat.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbxFormat.Watermark = "";
            // 
            // txtOutDir
            // 
            this.txtOutDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutDir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.txtOutDir.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.txtOutDir.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.txtOutDir.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtOutDir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txtOutDir.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.txtOutDir.Location = new System.Drawing.Point(69, 229);
            this.txtOutDir.Margin = new System.Windows.Forms.Padding(0);
            this.txtOutDir.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtOutDir.Multiline = false;
            this.txtOutDir.Name = "txtOutDir";
            this.txtOutDir.Padding = new System.Windows.Forms.Padding(2);
            this.txtOutDir.ReadOnly = true;
            this.txtOutDir.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.txtOutDir.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.txtOutDir.ScrollBarStyleInherited = false;
            this.txtOutDir.ShortcutsEnabled = false;
            this.txtOutDir.ShowText = false;
            this.txtOutDir.Size = new System.Drawing.Size(311, 29);
            this.txtOutDir.Style = Sunny.UI.UIStyle.Custom;
            this.txtOutDir.StyleCustomMode = true;
            this.txtOutDir.TabIndex = 8;
            this.txtOutDir.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormOption
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(524, 346);
            this.Controls.Add(this.txtOutDir);
            this.Controls.Add(this.cbxFormat);
            this.Controls.Add(this.btnBrowser);
            this.Controls.Add(this.rbManual);
            this.Controls.Add(this.rbDefault);
            this.Controls.Add(this.cbxModule);
            this.Controls.Add(this.txtAppendExt);
            this.Controls.Add(this.lblOutDir);
            this.Controls.Add(this.lblFormat);
            this.Controls.Add(this.lblModule);
            this.Controls.Add(this.lblAppendExt);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = true;
            this.Name = "FormOption";
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.ShowInTaskbar = true;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "选项";
            this.TextAlignment = System.Drawing.StringAlignment.Center;
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.Load += new System.EventHandler(this.FormOption_Load);
            this.Controls.SetChildIndex(this.pnlBtm, 0);
            this.Controls.SetChildIndex(this.lblAppendExt, 0);
            this.Controls.SetChildIndex(this.lblModule, 0);
            this.Controls.SetChildIndex(this.lblFormat, 0);
            this.Controls.SetChildIndex(this.lblOutDir, 0);
            this.Controls.SetChildIndex(this.txtAppendExt, 0);
            this.Controls.SetChildIndex(this.cbxModule, 0);
            this.Controls.SetChildIndex(this.rbDefault, 0);
            this.Controls.SetChildIndex(this.rbManual, 0);
            this.Controls.SetChildIndex(this.btnBrowser, 0);
            this.Controls.SetChildIndex(this.cbxFormat, 0);
            this.Controls.SetChildIndex(this.txtOutDir, 0);
            this.pnlBtm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UILabel lblAppendExt;
        private Sunny.UI.UILabel lblModule;
        private Sunny.UI.UILabel lblFormat;
        private Sunny.UI.UILabel lblOutDir;
        private Sunny.UI.UITextBox txtAppendExt;
        private Sunny.UI.UIComboBox cbxModule;
        private Sunny.UI.UIRadioButton rbDefault;
        private Sunny.UI.UIRadioButton rbManual;
        private Sunny.UI.UISymbolButton btnBrowser;
        private Sunny.UI.UIComboBox cbxFormat;
        private Sunny.UI.UIRichTextBox txtOutDir;
    }
}