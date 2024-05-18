using System;
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

    private void FormCopyright_Load(object sender, EventArgs e)
    {
        txtInfo.Text = """
                       本程序可供个人/企业/学校/政府机关等自由场合任意安装和使用。
                       * 注意事项
                        - 本程序受著作权法和软件保护法的保护，除保护法条款中允许或非限制的范围以外，任何人对本程序进行的逆向工程、反编译、重新组装都将被视为违法。
                        - 本程序未经著作权个人或公司许可绝对禁止用于商业用途。

                       * 版权信息
                        - 本程序使用的 Real-ESRGAN AI引擎是直接从 https://github.com/xinntao/Real-ESRGAN 下载的，并遵循 BSD 3-Clause License 公共许可协议。
                        - 本程序使用的 TG.INI 配置文件读取写插件是直接从 https://github.com/troygeiger/TG.INI 下载的，并遵循 GPL 3.0 License 公共许可协议。
                        - 本程序使用的 SunnyUI 开源控件库是直接从 https://github.com/yhuse/SunnyUI 下载的，并遵循 GPL 3.0 License 公共许可协议。
                        - 本程序著作权归 Lucifer (https://github.com/X-Lucifer) 所有。
                       """;
    }
}