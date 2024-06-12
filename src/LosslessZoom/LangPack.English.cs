namespace X.Lucifer.LosslessZoom;

public class LangPackEnglish : ILangPack
{
    /// <inheritdoc />
    public string FormAbout_Title => "About";

    /// <inheritdoc />
    public string FormAbout_lblTitle => "AI Lossless Zoomer";

    /// <inheritdoc />
    public string FormAbout_lblDesc => "Summary:";

    /// <inheritdoc />
    public string FormAbout_lblVersion => "Version:";

    /// <inheritdoc />
    public string FormAbout_lblAuthor => "Author:";

    /// <inheritdoc />
    public string FormAbout_lblCopyright => "Copyright:";

    /// <inheritdoc />
    public string FormCopyright_Title => "Copyright";

    /// <inheritdoc />
    public string FormCopyright_txtInfo => """
                                           This program can be freely installed and used by individuals/enterprises/schools/government agencies and other free occasions.
                                           * Precautions
                                               - The program is protected by copyright law and Software Protection Law, except as permitted or unrestricted by the provisions of the protection law, any reverse engineering, decompiling, reassembly of the Program will be considered illegal.
                                               - This program is absolutely prohibited for commercial use without the permission of the copyright individual or company.

                                           * Copyright Information
                                               - this program USES Real - ESRGAN AI engine is directly downloaded from https://github.com/xinntao/Real-ESRGAN, and follow the BSD 3 - Clause License public License agreement.
                                               - this program using TG. INI configuration file read write plug-ins are directly downloaded from https://github.com/troygeiger/TG.INI, and follow the GPL License 3.0 public License agreement.
                                               - this program USES SunnyUI open source control repository is directly downloaded from https://github.com/yhuse/SunnyUI, and follow the GPL License 3.0 public License agreement.
                                               - This program is copyrighted by Lucifer (https://github.com/X-Lucifer).
                                           """;

    /// <inheritdoc />
    public string FormViewPic_Title => "Preview";

    /// <inheritdoc />
    public string FormOption_Title => "Options";

    /// <inheritdoc />
    public string FormOption_lblAppendExt => "Suffix:";

    /// <inheritdoc />
    public string FormOption_lblModule => "AI Engine:";

    /// <inheritdoc />
    public string FormOption_lblFormat => "File Format:";

    /// <inheritdoc />
    public string FormOption_lblOutDir => "Output Dir:";

    /// <inheritdoc />
    public string FormOption_rbDefault => "Default";

    /// <inheritdoc />
    public string FormOption_rbManual => "Manual";

    /// <inheritdoc />
    public string FormOption_btnBrowser => "Select Output Directory";

    /// <inheritdoc />
    public string FormOption_ComboxItem_Default => "Default";

    /// <inheritdoc />
    public string FormMain_Title => "AI Lossless Zoomer";

    /// <inheritdoc />
    public string FormMain_Init_Config => "Load config success.";

    /// <inheritdoc />
    public string FormMain_OpenFile => "Open";

    /// <inheritdoc />
    public string FormMain_Options => "Options";

    /// <inheritdoc />
    public string FormMain_Exit => "Exit";

    /// <inheritdoc />
    public string FormMain_About => "About";

    /// <inheritdoc />
    public string FormMain_Copyright => "Copyright";

    /// <inheritdoc />
    public string FormMain_Init_Menu => "Loading menu succeeded.";

    /// <inheritdoc />
    public string FormMain_Init_Engine => "The AI engine is loaded successfully.";

    /// <inheritdoc />
    public string FormMain_Engine_Fail => "The AI engine failed to load.";

    /// <inheritdoc />
    public string FormMain_Change_Lang => "The current UI language has been switched to English.";

    /// <inheritdoc />
    public string FormMain_Change_Config => "Configuration changes succeeded.";

    /// <inheritdoc />
    public string FormMain_Log_Open_File => "Open file:";

    /// <inheritdoc />
    public string FormMain_Log_Add_File_Error => "The total number of tasks cannot exceed 100.";

    /// <inheritdoc />
    public string FormMain_Remove_Task => "Remove task:";

    /// <inheritdoc />
    public string FormMain_File_Name => "Filename";

    /// <inheritdoc />
    public string FormMain_Init_Hard_Info => "Initialize hardware information.";

    /// <inheritdoc />
    public string FormMain_Init_System_Info => "Loading system information succeeded.";

    /// <inheritdoc />
    public string FormMain_Init_Cpu_Info => "Loading the processor information succeeded.";

    /// <inheritdoc />
    public string FormMain_Init_Graphics_Info => "The graphics card information is loaded successfully. ";

    /// <inheritdoc />
    public string FormMain_Init_Others_Info => "Loading other information succeeded.";

    /// <inheritdoc />
    public string FormMain_All_Task_Count => "Total number of tasks:";

    /// <inheritdoc />
    public string FormMain_Task => "Tasks:";

    /// <inheritdoc />
    public string FormMain_Wait_Execute_Task => ", has been added and is waiting to be executed.";

    /// <inheritdoc />
    public string FormMain_Start_Execute_Task => ", the task has started.";

    /// <inheritdoc />
    public string FormMain_Remain_Task_Count => "Remain:";

    /// <inheritdoc />
    public string FormMain_Finished_Task_Count => "Completed:";

    /// <inheritdoc />
    public string FormMain_Exception => "Exception message:";

    /// <inheritdoc />
    public string FormMain_Task_Start => "The mission begins.";

    /// <inheritdoc />
    public string FormMain_Task_Finished => "Mission complete.";

    /// <inheritdoc />
    public string FormMain_Clear_Finished_Task => "Clean up completed tasks.";

    /// <inheritdoc />
    public string FormMain_Clear_Logs => "Clear log";

    /// <inheritdoc />
    public string FormMain_Clear_All_Task => "Clear task";

    /// <inheritdoc />
    public string FormMain_Has_Finished => "It's already done.";

    /// <inheritdoc />
    public string FormMain_lblVideoname => "Graphics:";

    /// <inheritdoc />
    public string FormMain_lblCpuLogic => "Logic CPU:";

    /// <inheritdoc />
    public string FormMain_lblCpu => "CPU Count:";

    /// <inheritdoc />
    public string FormMain_lblProcessor => "CPU:";

    /// <inheritdoc />
    public string FormMain_lblBrand => "Brand:";

    /// <inheritdoc />
    public string FormMain_lblSysname => "System:";

    /// <inheritdoc />
    public string FormMain_btnProcess => "Start";

    /// <inheritdoc />
    public string FormMain_btnClearlog => "DEL Logs";

    /// <inheritdoc />
    public string FormMain_btnCleartask => "DEL Tasks";

    /// <inheritdoc />
    public string FormMain_lblTaskAll => "Total:";

    /// <inheritdoc />
    public string FormMain_lblTaskRemain => "Finished:";

    /// <inheritdoc />
    public string FormMain_lblTotaltime => "Spend:";

    /// <inheritdoc />
    public string FormMain_lblStart => "Start:";

    /// <inheritdoc />
    public string RunAsAdmin => "Please run the program as an administrator";
}