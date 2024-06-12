namespace X.Lucifer.LosslessZoom;

public class LangPack : ILangPack
{
    /// <inheritdoc />
    public string FormAbout_Title => "关于";

    /// <inheritdoc />
    public string FormAbout_lblTitle => "AI无损放大工具";

    /// <inheritdoc />
    public string FormAbout_lblDesc => "功能说明:";

    /// <inheritdoc />
    public string FormAbout_lblVersion => "当前版本:";

    /// <inheritdoc />
    public string FormAbout_lblAuthor => "软件主页:";

    /// <inheritdoc />
    public string FormAbout_lblCopyright => "版权信息:";

    /// <inheritdoc />
    public string FormCopyright_Title => "版权信息";

    /// <inheritdoc />
    public string FormCopyright_txtInfo => """
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

    /// <inheritdoc />
    public string FormViewPic_Title => "预览";

    /// <inheritdoc />
    public string FormOption_Title => "选项";

    /// <inheritdoc />
    public string FormOption_lblAppendExt => "输出后缀:";

    /// <inheritdoc />
    public string FormOption_lblModule => "引擎模块:";

    /// <inheritdoc />
    public string FormOption_lblFormat => "输出格式:";

    /// <inheritdoc />
    public string FormOption_lblOutDir => "输出目录:";

    /// <inheritdoc />
    public string FormOption_rbDefault => "自动";

    /// <inheritdoc />
    public string FormOption_rbManual => "手动选择:";

    /// <inheritdoc />
    public string FormOption_btnBrowser => "选择文件输出目录";

    /// <inheritdoc />
    public string FormOption_ComboxItem_Default => "默认";

    /// <inheritdoc />
    public string FormMain_Title => "AI无损放大工具";

    /// <inheritdoc />
    public string FormMain_Init_Config => "初始化配置成功.";

    /// <inheritdoc />
    public string FormMain_OpenFile => "打开";

    /// <inheritdoc />
    public string FormMain_Options => "选项";

    /// <inheritdoc />
    public string FormMain_Exit => "退出";

    /// <inheritdoc />
    public string FormMain_About => "关于";

    /// <inheritdoc />
    public string FormMain_Copyright => "版权";

    /// <inheritdoc />
    public string FormMain_Init_Menu => "加载菜单成功.";

    /// <inheritdoc />
    public string FormMain_Init_Engine => "AI引擎加载成功.";

    /// <inheritdoc />
    public string FormMain_Engine_Fail => "AI引擎加载失败.";

    /// <inheritdoc />
    public string FormMain_Change_Lang => "当前界面语言已切换至中文.";

    /// <inheritdoc />
    public string FormMain_Change_Config => "配置更改成功.";

    /// <inheritdoc />
    public string FormMain_Log_Open_File => "打开文件:";

    /// <inheritdoc />
    public string FormMain_Log_Add_File_Error => "总任务数量不能超过100.";

    /// <inheritdoc />
    public string FormMain_Remove_Task => "移除任务:";

    /// <inheritdoc />
    public string FormMain_File_Name => "文件名";

    /// <inheritdoc />
    public string FormMain_Init_Hard_Info => "初始化硬件信息.";

    /// <inheritdoc />
    public string FormMain_Init_System_Info => "加载系统信息成功.";

    /// <inheritdoc />
    public string FormMain_Init_Cpu_Info => "加载处理器信息成功.";

    /// <inheritdoc />
    public string FormMain_Init_Graphics_Info => "加载显卡信息成功.";

    /// <inheritdoc />
    public string FormMain_Init_Others_Info => "加载其他信息成功.";

    /// <inheritdoc />
    public string FormMain_All_Task_Count => "总任务数量:";

    /// <inheritdoc />
    public string FormMain_Task => "任务:";

    /// <inheritdoc />
    public string FormMain_Wait_Execute_Task => ", 已添加, 等待执行.";

    /// <inheritdoc />
    public string FormMain_Start_Execute_Task => ", 已开始执行.";

    /// <inheritdoc />
    public string FormMain_Remain_Task_Count => "剩余数量:";

    /// <inheritdoc />
    public string FormMain_Finished_Task_Count => "完成数量:";

    /// <inheritdoc />
    public string FormMain_Exception => "异常信息:";

    /// <inheritdoc />
    public string FormMain_Task_Start => "任务开始.";

    /// <inheritdoc />
    public string FormMain_Task_Finished => "任务完成.";

    /// <inheritdoc />
    public string FormMain_Clear_Finished_Task => "清理已完成任务.";

    /// <inheritdoc />
    public string FormMain_Clear_Logs => "清空日志";

    /// <inheritdoc />
    public string FormMain_Clear_All_Task => "清空任务";

    /// <inheritdoc />
    public string FormMain_Has_Finished => "已完成.";

    /// <inheritdoc />
    public string FormMain_lblVideoname => "显卡名称:";

    /// <inheritdoc />
    public string FormMain_lblCpuLogic => "逻辑核心:";

    /// <inheritdoc />
    public string FormMain_lblCpu => "物理核心:";

    /// <inheritdoc />
    public string FormMain_lblProcessor => "处理器:";

    /// <inheritdoc />
    public string FormMain_lblBrand => "品牌名称:";

    /// <inheritdoc />
    public string FormMain_lblSysname => "系统名称:";

    /// <inheritdoc />
    public string FormMain_btnProcess => "开始任务";

    /// <inheritdoc />
    public string FormMain_btnClearlog => "清空日志";

    /// <inheritdoc />
    public string FormMain_btnCleartask => "清空任务";

    /// <inheritdoc />
    public string FormMain_lblTaskAll => "总任务:";

    /// <inheritdoc />
    public string FormMain_lblTaskRemain => "已完成:";

    /// <inheritdoc />
    public string FormMain_lblTotaltime => "任务耗时:";

    /// <inheritdoc />
    public string FormMain_lblStart => "任务开始:";

    /// <inheritdoc />
    public string RunAsAdmin => "请以管理员身份运行该程序";
}