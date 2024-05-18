// ReSharper disable InconsistentNaming
namespace X.Lucifer.LosslessZoom;

public interface ILangPack
{
    #region FormAbout

    string FormAbout_Title { get; }

    string FormAbout_lblTitle { get; }

    string FormAbout_lblDesc { get; }

    string FormAbout_lblVersion { get; }

    string FormAbout_lblAuthor { get; }

    string FormAbout_lblCopyright { get; }

    #endregion

    #region FormCopyright

    string FormCopyright_Title { get; }

    string FormCopyright_txtInfo { get; }

    #endregion

    #region FormViewPic

    string FormViewPic_Title { get; }

    #endregion

    #region FormOption

    string FormOption_Title { get; }

    string FormOption_lblAppendExt { get; }

    string FormOption_lblModule { get; }

    string FormOption_lblFormat { get; }

    string FormOption_lblOutDir { get; }

    string FormOption_rbDefault { get; }

    string FormOption_rbManual { get; }

    string FormOption_btnBrowser { get; }

    string FormOption_ComboxItem_Default { get; }

    #endregion

    #region FormMain

    string FormMain_Title { get; }
    string FormMain_Init_Config { get; }
    string FormMain_OpenFile { get; }
    string FormMain_Options { get; }
    string FormMain_Exit { get; }
    string FormMain_About { get; }
    string FormMain_Copyright { get; }
    string FormMain_Init_Menu { get; }
    string FormMain_Init_Engine { get; }
    string FormMain_Engine_Fail { get; }
    string FormMain_Change_Lang { get; }
    string FormMain_Change_Config { get; }
    string FormMain_Log_Open_File { get;}
    string FormMain_Log_Add_File_Error { get;}
    string FormMain_Remove_Task { get; }
    string FormMain_File_Name { get;}
    string FormMain_Init_Hard_Info { get;}
    string FormMain_Init_System_Info { get; }
    string FormMain_Init_Cpu_Info { get; }
    string FormMain_Init_Graphics_Info { get; }
    string FormMain_Init_Others_Info { get;}
    string FormMain_All_Task_Count { get; }
    string FormMain_Task { get;}
    string FormMain_Wait_Execute_Task { get;}
    string FormMain_Start_Execute_Task { get;}
    string FormMain_Remain_Task_Count { get; }
    string FormMain_Finished_Task_Count { get; }
    string FormMain_Exception { get; }
    string FormMain_Task_Start { get;}
    string FormMain_Task_Finished { get; }
    string FormMain_Clear_Finished_Task { get; }
    string FormMain_Clear_Logs { get; }
    string FormMain_Clear_All_Task { get; }
    string FormMain_Has_Finished { get; }

    string FormMain_lblVideoname { get;}
    string FormMain_lblCpuLogic { get; }

    string FormMain_lblCpu { get;}
    string FormMain_lblProcessor { get;}
    string FormMain_lblBrand { get;}
    string FormMain_lblSysname { get; }
    string FormMain_btnProcess { get; }
    string FormMain_btnClearlog { get; }
    string FormMain_btnCleartask { get; }
    string FormMain_lblTaskAll { get; }
    string FormMain_lblTaskRemain { get; }
    string FormMain_lblTotaltime { get; }
    string FormMain_lblStart { get; }

    #endregion
}