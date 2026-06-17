namespace X.Lucifer.LosslessZoom;

public class LangPackTraditionalChinese : ILangPack
{
    /// <inheritdoc />
    public string FormAbout_Title => "關於";

    /// <inheritdoc />
    public string FormAbout_lblTitle => "AI無損放大工具";

    /// <inheritdoc />
    public string FormAbout_lblDesc => "功能說明:";

    /// <inheritdoc />
    public string FormAbout_lblVersion => "目前版本:";

    /// <inheritdoc />
    public string FormAbout_lblAuthor => "軟體主頁:";

    /// <inheritdoc />
    public string FormAbout_lblCopyright => "版權資訊:";

    /// <inheritdoc />
    public string FormCopyright_Title => "版權資訊";

    /// <inheritdoc />
    public string FormCopyright_txtInfo => """
                                           本程式可供個人/企業/學校/政府機關等自由場合任意安裝和使用。
                                           * 注意事項
                                            - 本程式受著作權法和軟體保護法的保護，除保護法條款中允許或非限制的範圍以外，任何人對本程式進行的逆向工程、反編譯、重新組裝都將被視為違法。
                                            - 本程式未經著作權個人或公司許可絕對禁止用於商業用途。

                                           * 版權資訊
                                            - 本程式使用的 Real-ESRGAN AI引擎是直接從 https://github.com/xinntao/Real-ESRGAN 下載的，並遵循 BSD 3-Clause License 公共許可協議。
                                            - 本程式使用的 TG.INI 設定檔讀寫外掛是直接從 https://github.com/troygeiger/TG.INI 下載的，並遵循 GPL 3.0 License 公共許可協議。
                                            - 本程式使用的 SunnyUI 開源控制項庫是直接從 https://github.com/yhuse/SunnyUI 下載的，並遵循 GPL 3.0 License 公共許可協議。
                                            - 本程式著作權歸 Lucifer (https://github.com/X-Lucifer) 所有。
                                           """;

    /// <inheritdoc />
    public string FormViewPic_Title => "預覽";

    /// <inheritdoc />
    public string FormOption_Title => "選項";

    /// <inheritdoc />
    public string FormOption_lblAppendExt => "輸出後綴:";

    /// <inheritdoc />
    public string FormOption_lblModule => "引擎模組:";

    /// <inheritdoc />
    public string FormOption_lblFormat => "輸出格式:";

    /// <inheritdoc />
    public string FormOption_lblOutDir => "輸出目錄:";

    /// <inheritdoc />
    public string FormOption_rbDefault => "自動";

    /// <inheritdoc />
    public string FormOption_rbManual => "手動選擇:";

    /// <inheritdoc />
    public string FormOption_btnBrowser => "選擇檔案輸出目錄";

    /// <inheritdoc />
    public string FormOption_ComboxItem_Default => "預設";

    /// <inheritdoc />
    public string FormOption_lblGpu => "GPU裝置:";

    /// <inheritdoc />
    public string FormOption_ComboxItem_AutoGpu => "自動";

    /// <inheritdoc />
    public string FormMain_Title => "AI無損放大工具";

    /// <inheritdoc />
    public string FormMain_Init_Config => "初始化設定成功.";

    /// <inheritdoc />
    public string FormMain_OpenFile => "開啟";

    /// <inheritdoc />
    public string FormMain_Options => "選項";

    /// <inheritdoc />
    public string FormMain_Exit => "退出";

    /// <inheritdoc />
    public string FormMain_About => "關於";

    /// <inheritdoc />
    public string FormMain_Copyright => "版權";

    /// <inheritdoc />
    public string FormMain_Init_Menu => "載入選單成功.";

    /// <inheritdoc />
    public string FormMain_Init_Engine => "AI引擎載入成功.";

    /// <inheritdoc />
    public string FormMain_Engine_Fail => "AI引擎載入失敗.";

    /// <inheritdoc />
    public string FormMain_Change_Lang => "目前介面語言已切換至繁體中文.";

    /// <inheritdoc />
    public string FormMain_Change_Config => "設定變更成功.";

    /// <inheritdoc />
    public string FormMain_Log_Open_File => "開啟檔案:";

    /// <inheritdoc />
    public string FormMain_Log_Add_File_Error => "總任務數量不能超過100.";

    /// <inheritdoc />
    public string FormMain_Remove_Task => "移除任務:";

    /// <inheritdoc />
    public string FormMain_File_Name => "檔案名稱";

    /// <inheritdoc />
    public string FormMain_Init_Hard_Info => "初始化硬體資訊.";

    /// <inheritdoc />
    public string FormMain_Init_System_Info => "載入系統資訊成功.";

    /// <inheritdoc />
    public string FormMain_Init_Cpu_Info => "載入處理器資訊成功.";

    /// <inheritdoc />
    public string FormMain_Init_Graphics_Info => "載入顯示卡資訊成功.";

    /// <inheritdoc />
    public string FormMain_Init_Others_Info => "載入其他資訊成功.";

    /// <inheritdoc />
    public string FormMain_All_Task_Count => "總任務數量:";

    /// <inheritdoc />
    public string FormMain_Task => "任務:";

    /// <inheritdoc />
    public string FormMain_Wait_Execute_Task => ", 已新增, 等待執行.";

    /// <inheritdoc />
    public string FormMain_Start_Execute_Task => ", 已開始執行.";

    /// <inheritdoc />
    public string FormMain_Remain_Task_Count => "剩餘數量:";

    /// <inheritdoc />
    public string FormMain_Finished_Task_Count => "完成數量:";

    /// <inheritdoc />
    public string FormMain_Exception => "例外資訊:";

    /// <inheritdoc />
    public string FormMain_Task_Start => "任務開始.";

    /// <inheritdoc />
    public string FormMain_Task_Finished => "任務完成.";

    /// <inheritdoc />
    public string FormMain_Clear_Finished_Task => "清理已完成任務.";

    /// <inheritdoc />
    public string FormMain_Clear_Logs => "清空日誌";

    /// <inheritdoc />
    public string FormMain_Clear_All_Task => "清空任務";

    /// <inheritdoc />
    public string FormMain_Has_Finished => "已完成.";

    /// <inheritdoc />
    public string FormMain_lblVideoname => "顯示卡名稱:";

    /// <inheritdoc />
    public string FormMain_lblCpuLogic => "邏輯核心:";

    /// <inheritdoc />
    public string FormMain_lblCpu => "實體核心:";

    /// <inheritdoc />
    public string FormMain_lblProcessor => "處理器:";

    /// <inheritdoc />
    public string FormMain_lblBrand => "品牌名稱:";

    /// <inheritdoc />
    public string FormMain_lblSysname => "系統名稱:";

    /// <inheritdoc />
    public string FormMain_btnProcess => "開始任務";

    /// <inheritdoc />
    public string FormMain_btnClearlog => "清空日誌";

    /// <inheritdoc />
    public string FormMain_btnCleartask => "清空任務";

    /// <inheritdoc />
    public string FormMain_lblTaskAll => "總任務:";

    /// <inheritdoc />
    public string FormMain_lblTaskRemain => "已完成:";

    /// <inheritdoc />
    public string FormMain_lblTotaltime => "任務耗時:";

    /// <inheritdoc />
    public string FormMain_lblStart => "任務開始:";

    /// <inheritdoc />
    public string RunAsAdmin => "請以系統管理員身分執行該程式";
}
