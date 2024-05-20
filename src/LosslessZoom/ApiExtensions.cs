using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;
using Sunny.UI;

namespace X.Lucifer.LosslessZoom;

public static class ApiExtensions
{
    public static IAsyncResult BeginInvoke(this Action action)
    {
        return action.BeginInvoke(null, null);
    }

    public static IAsyncResult BeginInvoke(this Func<bool> func)
    {
        return func.BeginInvoke(null, null);
    }

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

    public static Font GetFonts()
    {
        var path = Path.Combine(AppContext.BaseDirectory, "fonts.ttf");
        using var pfc = new PrivateFontCollection();
        pfc.AddFontFile(path);
        var font = new Font(pfc.Families[0], 10.5F, FontStyle.Regular, GraphicsUnit.Point);
        return font;
    }

    public static void ChangeFonts(Control.ControlCollection controls)
    {
        var font = GetFonts();
        foreach (Control control in controls)
        {
            if (control.HasChildren)
            {
                ChangeFonts(control.Controls);
            }
            control.BeginInvoke((Action<Font>) (x =>
            {
                control.Font = x;
            }), font);
        }
    }
}