using System;
using System.Windows.Forms;
using Sunny.UI;

namespace X.Lucifer.LosslessZoom;

/// <summary>
/// 版权
/// </summary>
public partial class FormViewPic : UIForm
{
    private readonly ILangPack _pack;
    private readonly PictureBox _pic;
    public FormViewPic(PictureBox pic, ILangPack pack)
    {
        _pic = pic;
        _pack = pack;
        InitializeComponent();
    }

    ~ FormViewPic()
    {
        Dispose();
        GC.SuppressFinalize(this);
    }

    private void FormViewPic_Load(object sender, EventArgs e)
    {
        Text = _pack.FormViewPic_Title;
        var pic = new PictureBox
        {
            Image = _pic.Image,
            Dock = DockStyle.Fill,
            SizeMode = PictureBoxSizeMode.Zoom
        };
        panelPic.Controls.Add(pic);
        lblPicname.Text = _pic.Text;
        ApiExtensions.ChangeFonts(Controls);
    }
}