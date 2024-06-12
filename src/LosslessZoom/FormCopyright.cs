using System;
using System.Drawing;
using System.Threading.Tasks;
using Sunny.UI;

namespace X.Lucifer.LosslessZoom;

/// <summary>
/// 版权
/// </summary>
public partial class FormCopyright : UIForm
{
    private readonly ILangPack _pack;
    public FormCopyright(ILangPack pack)
    {
        _pack = pack;
        InitializeComponent();
    }

    ~FormCopyright()
    {
        Dispose();
        GC.SuppressFinalize(this);
    }

    private void FormCopyright_Load(object sender, EventArgs e)
    {
        Text = _pack.FormCopyright_Title;
        txtInfo.Text = _pack.FormCopyright_txtInfo;
    }
}