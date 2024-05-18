using System;
using System.Threading;
using System.Windows.Forms;

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
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += Application_ThreadException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
        catch (Exception e)
        {
            ShowError(e.Message);
        }
    }

    private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
    {
        ShowError(e.ExceptionObject.ToString());
    }

    private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
    {
        ShowError(e.Exception.Message);
    }

    private static void ShowError(string msg)
    {
        using var form = new FormError
        {
            Message = msg
        };
        form.ShowDialog();
    }
}