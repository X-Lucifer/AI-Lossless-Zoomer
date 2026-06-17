using NLog;
using System;
using System.Threading;
using System.Windows.Forms;
using Sunny.UI;

namespace X.Lucifer.LosslessZoom;

static class Program
{
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
            UIStyles.GlobalFontName = "Microsoft YaHei UI";

            var identity = System.Security.Principal.WindowsIdentity.GetCurrent();
            var principal = new System.Security.Principal.WindowsPrincipal(identity);
            var isadmin = principal.IsInRole(System.Security.Principal.WindowsBuiltInRole.Administrator);

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
