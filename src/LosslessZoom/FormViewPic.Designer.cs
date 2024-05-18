
namespace X.Lucifer.LosslessZoom
{
    partial class FormViewPic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormViewPic));
            this.panelPic = new Sunny.UI.UIPanel();
            this.lblPicname = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // panelPic
            // 
            this.panelPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.panelPic.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.panelPic.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.panelPic.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.panelPic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.panelPic.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.panelPic.Location = new System.Drawing.Point(0, 60);
            this.panelPic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelPic.MinimumSize = new System.Drawing.Size(1, 1);
            this.panelPic.Name = "panelPic";
            this.panelPic.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.panelPic.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.panelPic.Size = new System.Drawing.Size(890, 560);
            this.panelPic.Style = Sunny.UI.UIStyle.Custom;
            this.panelPic.TabIndex = 0;
            this.panelPic.Text = null;
            this.panelPic.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPicname
            // 
            this.lblPicname.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPicname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.lblPicname.Location = new System.Drawing.Point(-4, 628);
            this.lblPicname.Name = "lblPicname";
            this.lblPicname.Size = new System.Drawing.Size(890, 30);
            this.lblPicname.Style = Sunny.UI.UIStyle.Custom;
            this.lblPicname.StyleCustomMode = true;
            this.lblPicname.TabIndex = 1;
            this.lblPicname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormViewPic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(890, 666);
            this.Controls.Add(this.lblPicname);
            this.Controls.Add(this.panelPic);
            this.EscClose = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormViewPic";
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.ShowIcon = true;
            this.ShowRadius = false;
            this.ShowShadow = true;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.TextAlignment = System.Drawing.StringAlignment.Center;
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.Load += new System.EventHandler(this.FormViewPic_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel panelPic;
        private Sunny.UI.UILabel lblPicname;
    }
}