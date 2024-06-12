using System;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Threading.Tasks;
using Sunny.UI;

namespace X.Lucifer.LosslessZoom;

public partial class FormAbout : UIForm
{
    private readonly ILangPack _pack;
    public FormAbout(ILangPack pack)
    {
        _pack = pack;
        InitializeComponent();
    }

    ~FormAbout()
    {
        Dispose();
        GC.SuppressFinalize(this);
    }

    private void FormAbout_Load(object sender, System.EventArgs e)
    {
        Text = _pack.FormAbout_Title;
        lblxAuthor.Text = @"https://github.com/X-Lucifer";
        lblxDesc.Text = _pack.FormAbout_lblTitle;
        lblCopyright.Text = _pack.FormAbout_lblCopyright;
        lblAuthor.Text = _pack.FormAbout_lblAuthor;
        lblVersion.Text = _pack.FormAbout_lblVersion;
        lblDesc.Text = _pack.FormAbout_lblDesc;
        lblTitle.Text = _pack.FormAbout_lblTitle;
        lblxVersion.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();
        lblxCopyright.Text = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyCopyrightAttribute>().Copyright;
    }

    private void lblxAuthor_Click(object sender, System.EventArgs e)
    {
        Process.Start(lblxAuthor.Text);
    }
}