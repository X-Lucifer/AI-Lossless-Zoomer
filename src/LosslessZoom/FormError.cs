using System;
using System.Drawing;
using Sunny.UI;

namespace X.Lucifer.LosslessZoom;

/// <summary>
/// 异常
/// </summary>
public partial class FormError : UIForm
{
    /// <summary>
    /// 错误消息
    /// </summary>
    public string Message { get; set; }

    public FormError()
    {
        InitializeComponent();
    }

    ~FormError()
    {
        Dispose();
        GC.SuppressFinalize(this);
    }

    private void FormError_Load(object sender, EventArgs e)
    {
        txtError.Text = Message ?? "";
        ApiExtensions.ChangeFonts(Controls);
    }
}