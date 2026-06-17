namespace X.Lucifer.LosslessZoom;

public static class LangPackFactory
{
    public static ILangPack Create(Language lang)
    {
        return lang switch
        {
            Language.English => new LangPackEnglish(),
            Language.TraditionalChinese => new LangPackTraditionalChinese(),
            _ => new LangPack()
        };
    }
}
