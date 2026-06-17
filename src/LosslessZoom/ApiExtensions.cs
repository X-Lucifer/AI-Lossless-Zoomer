using Sunny.UI;

namespace X.Lucifer.LosslessZoom;

public static class ApiExtensions
{
    public static void SetLanguage(Language lang = Language.Chinese)
    {
        if (lang == Language.English)
        {
            UILocalizeHelper.SetEN();
        }
        else
        {
            UILocalizeHelper.SetCH();
        }
    }
}
