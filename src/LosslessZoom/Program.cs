using NLog;
using System;
using System.Drawing.Text;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;
using Sunny.UI;

namespace X.Lucifer.LosslessZoom;

static class Program
{
    [DllImport("kernel32.dll", SetLastError = true)]
    private static extern int WriteProfileString(string lpsz_section, string lpsz_key_name, string lpsz_string);

    [DllImport("gdi32")]
    private static extern int AddFontResource(string lp_file_name);

    /// <summary>
    /// 应用程序的主入口点。
    /// </summary>
    [STAThread]
    static void Main()
    {
        try
        {
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException, true);
            Application.ThreadException += Application_ThreadException;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LogManager.Setup().RegisterWindowsForms();
            UIStyles.DPIScale = true;
            UIStyles.SetDPIScale();
            UIStyles.GlobalFont = true;
            var identity = WindowsIdentity.GetCurrent();
            var principal = new WindowsPrincipal(identity);
            var isadmin = principal.IsInRole(WindowsBuiltInRole.Administrator);
            if (isadmin)
            {
                var font = InstallFont();
                using var pfc = new PrivateFontCollection();
                pfc.AddFontFile(font);
                var font_name = pfc.Families[0].Name;
                UIStyles.GlobalFontName = font_name;
            }
            else
            {
                UIStyles.GlobalFontName = "微软雅黑";
            }

            Application.Run(new FormMain()
            {
                IsAdmin = isadmin
            });
        }
        catch (Exception e)
        {
            LogError(e);
            ShowError(e.Message);
        }
    }

    private static string InstallFont()
    {
        var sys_fontpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Windows), "fonts", Path.GetFileName(ApiExtensions.FontPath));
        if (File.Exists(sys_fontpath))
        {
            return sys_fontpath;
        }

        File.Copy(ApiExtensions.FontPath!, sys_fontpath);
        AddFontResource(sys_fontpath);
        WriteProfileString("fonts", Path.GetFileNameWithoutExtension(ApiExtensions.FontPath) + "(TrueType)", Path.GetFileName(ApiExtensions.FontPath));
        return sys_fontpath;
    }

    private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
    {
        LogError(e.Exception);
        ShowError(e.Exception.Message);
    }

    private static void ShowError(string msg)
    {
        var form = new FormError
        {
            Message = msg
        };
        form.ShowDialog();
    }

    private static void LogError(Exception e)
    {
        var log = LogManager.GetCurrentClassLogger();
        log.Error(e, $"source: {e.Source} , trace: {e.StackTrace}");
        if (e.InnerException != null)
        {
            log.Error(e.InnerException);
        }
    }
}