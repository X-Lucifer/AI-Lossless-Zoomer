using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;
using Sunny.UI;

namespace X.Lucifer.LosslessZoom;

public static class ApiExtensions
{
    public static readonly string FontPath = Path.Combine(AppContext.BaseDirectory, "lovestruck.ttf");

    public static void SetLanguage(Language lang = Language.Chinese)
    {
        if (lang == Language.Chinese)
        {
            UILocalizeHelper.SetCH();
        }
        else
        {
            UILocalizeHelper.SetEN();
        }
    }
}