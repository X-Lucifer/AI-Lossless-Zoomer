using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;
using TG.INI;
using TG.INI.Serialization;
using static X.Lucifer.LosslessZoom.ApiExtensions;
using XTimer = System.Timers.Timer;

namespace X.Lucifer.LosslessZoom;

public partial class FormMain : UIForm
{
    private readonly string _outdir = AppContext.BaseDirectory + @"output\";

    private readonly List<string> _formats =
    [
        ".jpg",
        ".jpeg",
        ".png"
    ];

    private readonly List<FileInfo> _files;
    private int _picid;
    private RuntimeOption _option;
    private readonly List<int> _processlist;
    private bool _isai;
    private bool _isrun;
    private ILangPack _pack = new LangPack();
    public FormMain()
    {
        _processlist = [];
        _option = new RuntimeOption();
        _files = [];
        InitializeComponent();
        Load += async (_, _) => await FormMain_Load();
    }

    ~FormMain()
    {
        Dispose();
        GC.SuppressFinalize(this);
    }

    /// <summary>
    /// 加载
    /// </summary>
    private async Task FormMain_Load()
    {
        this.ShowProcessForm();
        await Task.Run(LoadConfig);
        FormClosed += async (_, _) => await FormMain_FormClosed();
        panelInfo.DragDrop += async (_, x) => await panelInfo_DragDrop(x);
        timer.Tick += Timer_Tick;
        timer.Start();
        _isai = await Task.FromResult(CheckEngine());
        await Task.Run(LoadMenu);
        if (_isai)
        {
            btnProcess.Click += async (_, _) => await btnProcess_Click();
        }

        Text = _pack.FormMain_Title;
        await Task.Run(LoadHardInfo);
        this.HideProcessForm();
    }

    /// <summary>
    /// 关闭窗体
    /// </summary>
    private async Task FormMain_FormClosed()
    {
        await Exit();
    }

    /// <summary>
    /// 退出
    /// </summary>
    private async Task Exit()
    {
        await Task.Run(() =>
        {
            if (!_isrun)
            {
                GC.Collect();
                Application.Exit();
            }
            else
            {
                try
                {
                    foreach (var item in _processlist)
                    {
                        using var process = Process.GetProcessById(item);
                        process.Close();
                        process.Kill();
                    }
                }
                catch (Exception)
                {
                    Application.Exit();
                }
                finally
                {
                    GC.Collect();
                    Application.Exit();
                }
            }
        });
    }

    /// <summary>
    /// 计时器
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Timer_Tick(object sender, EventArgs e)
    {
        lblTime.BeginInvoke((Action<string>)(x => { lblTime.Text = x.ToString(); }), $@"{DateTime.Now:G}");
    }

    /// <summary>
    /// 加载配置
    /// </summary>
    private void LoadConfig()
    {
        var file = AppContext.BaseDirectory + "config.ini";
        if (!File.Exists(file))
        {
            _option.OutDir = 1;
            _option.OutDirPath = _outdir;
            _option.AppendExt = "";
            _option.OutFormat = 1;
            _option.Module = "0";
            _option.Lang = Language.Chinese;
            using var doc = IniSerialization.SerializeObjectToNewDocument(_option);
            doc.Write(file);
        }

        using var xdoc = new IniDocument(file);
        _option = IniSerialization.DeserializeDocument<RuntimeOption>(xdoc);
        if (_option.Lang == Language.Chinese)
        {
            _pack = new LangPack();
        }
        else
        {
            _pack = new LangPackEnglish();
        }
        SetLanguage(_option.Lang);
        LoadUiLang(_pack);
        WriteLog(_pack.FormMain_Init_Config);
    }

    /// <summary>
    /// 加载菜单
    /// </summary>
    private void LoadMenu()
    {
        navbarMenu.Nodes.AddRange
        (
            [
                new TreeNode
                (
                    "", [
                        new TreeNode(_pack.FormMain_OpenFile),
                        new TreeNode(_pack.FormMain_Options),
                        new TreeNode(_pack.FormMain_Exit)
                    ]
                ),
                new TreeNode("", [
                    new TreeNode("Chinese"),
                    new TreeNode("English")
                ]),
                new TreeNode
                (
                    "", [
                        new TreeNode(_pack.FormMain_About),
                        new TreeNode(_pack.FormMain_Copyright)
                    ]
                )
            ]
        );
        var topindex = 1;
        var navindex = 1;
        foreach (TreeNode item in navbarMenu.Nodes)
        {
            switch (topindex)
            {
                case 1:
                    navbarMenu.SetNodeSymbol(item, 561534, 35);
                    break;
                case 2:
                    navbarMenu.SetNodeSymbol(item, 559540, 35);
                    break;
                case 3:
                    navbarMenu.SetNodeSymbol(item, 559527, 35);
                    break;
            }

            foreach (TreeNode xitem in item.Nodes)
            {
                xitem.ForeColor = Color.FromArgb(40, 44, 52);
                xitem.BackColor = Color.FromArgb(40, 44, 52);
                navbarMenu.SetNodePageIndex(xitem, navindex);
                navbarMenu.Nodes.Add(xitem);
                navindex++;
            }

            topindex++;
        }
        navbarMenu.ResetFont();
        navbarMenu.DropMenuFont = GetFonts();
        navbarMenu.Font = GetFonts();
        navbarMenu.MenuItemClick += async (_, _, index) => await NavbarMenu_MenuItemClick(index);
        WriteLog(_pack.FormMain_Init_Menu);
    }

    /// <summary>
    /// 菜单事件处理
    /// </summary>
    /// <param name="index">索引</param>
    private async Task NavbarMenu_MenuItemClick(int index)
    {
        switch (index)
        {
            case 1:
                await OpenFiles();
                break;
            case 2:
                if (_isai)
                {
                    ShowOption();
                }
                else
                {
                    this.ShowErrorTip(_pack.FormMain_Engine_Fail);
                }

                break;
            case 3:
                await Exit();
                break;
            case 4:
                ChangeLang();
                break;
            case 5:
                ChangeLang(Language.English);
                break;
            case 6:
                ShowAbout();
                break;
            case 7:
                ShowCopyright();
                break;
        }
    }

    private void ChangeLang(Language lang = Language.Chinese)
    {
        if (lang == Language.Chinese)
        {
            _pack = new LangPack();
            this.ShowInfoTip(_pack.FormMain_Change_Lang, 2000);
        }
        else
        {
            _pack = new LangPackEnglish();
            this.ShowInfoTip(_pack.FormMain_Change_Lang, 2000);
        }

        _option.Lang = lang;
        using var doc = IniSerialization.SerializeObjectToNewDocument(_option);
        var file = AppContext.BaseDirectory + "config.ini";
        doc.Write(file);
        Application.Restart();
    }

    private void LoadUiLang(ILangPack lang)
    {
        ChangeFonts(Controls);
        BeginInvoke((Action<string>) (x =>
        {
            Text = x;
        }), lang.FormMain_Title);
        lblVideoname.BeginInvoke((Action<string>) (x =>
        {
            lblVideoname.Text = x;
        }), lang.FormMain_lblVideoname);

        lblCpuLogic.BeginInvoke((Action<string>) (x =>
        {
            lblCpuLogic.Text = x;
        }), lang.FormMain_lblCpuLogic);

        lblCpu.BeginInvoke((Action<string>) (x =>
        {
            lblCpu.Text = x;
        }), lang.FormMain_lblCpu);

        lblProcessor.BeginInvoke((Action<string>) (x =>
        {
            lblProcessor.Text = x;
        }), lang.FormMain_lblProcessor);

        lblBrand.BeginInvoke((Action<string>) (x =>
        {
            lblBrand.Text = x;
        }), lang.FormMain_lblBrand);

        lblSysname.BeginInvoke((Action<string>) (x =>
        {
            lblSysname.Text = x;
        }), lang.FormMain_lblSysname);

        btnProcess.BeginInvoke((Action<string>) (x =>
        {
            btnProcess.Text = x;
        }), lang.FormMain_btnProcess);

        btnClearlog.BeginInvoke((Action<string>) (x =>
        {
            btnClearlog.Text = x;
        }), lang.FormMain_btnClearlog);

        btnCleartask.BeginInvoke((Action<string>) (x =>
        {
            btnCleartask.Text = x;
        }), lang.FormMain_btnCleartask);

        lblTaskAll.BeginInvoke((Action<string>) (x =>
        {
            lblTaskAll.Text = x;
        }), lang.FormMain_lblTaskAll);

        lblTaskRemain.BeginInvoke((Action<string>) (x =>
        {
            lblTaskRemain.Text = x;
        }), lang.FormMain_lblTaskRemain);

        lblTotaltime.BeginInvoke((Action<string>) (x =>
        {
            lblTotaltime.Text = x;
        }), lang.FormMain_lblTotaltime);

        lblStart.BeginInvoke((Action<string>) (x =>
        {
            lblStart.Text = x;
        }), lang.FormMain_lblStart);
    }

    /// <summary>
    /// 版权
    /// </summary>
    private void ShowCopyright()
    {
        var form = new FormCopyright(_pack);
        form.ShowDialog(this);
    }

    /// <summary>
    /// 关于
    /// </summary>
    private void ShowAbout()
    {
        var form = new FormAbout(_pack);
        form.ShowDialog(this);
    }

    /// <summary>
    /// 选项
    /// </summary>
    private void ShowOption()
    {
        if (_isrun)
        {
            return;
        }

        using var form = new FormOption(_option, _pack);
        form.OnSaved += FormOption_OnSaved;
        form.ShowDialog(this);
    }

    /// <summary>
    /// 保存事件
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void FormOption_OnSaved(object sender, RuntimeOptionEventArgs e)
    {
        var xoption = e.Option;
        _option.OutDir = xoption.OutDir;
        _option.AppendExt = xoption.AppendExt;
        _option.Module = xoption.Module;
        _option.OutFormat = xoption.OutFormat;
        _option.OutDirPath = xoption.OutDirPath;
        WriteLog(_pack.FormMain_Change_Config);
    }

    /// <summary>
    /// 打开文件
    /// </summary>
    private async Task OpenFiles()
    {
        if (_isrun)
        {
            return;
        }

        var open = new OpenFileDialog
        {
            CheckFileExists = true,
            Multiselect = true,
            AddExtension = true,
            AutoUpgradeEnabled = true,
            Filter = @"jpg|*.jpg|jpeg|*.jpeg|png|*.png",
        };
        var result = open.ShowDialog(this);
        if (result != DialogResult.OK || open.FileNames.Length <= 0)
        {
            return;
        }

        await AddFiles(open.FileNames);
    }

    /// <summary>
    /// 添加文件
    /// </summary>
    /// <param name="files"></param>
    /// <returns></returns>
    private async Task AddFiles(IReadOnlyCollection<string> files)
    {
        var ctotal = _files.Count;
        var ftotal = ctotal + files.Count;
        if (files.Count > 100 || ftotal > 100)
        {
            this.ShowInfoTip(_pack.FormMain_Log_Add_File_Error);
            return;
        }

        btnProcess.BeginInvoke(() =>
        {
            btnProcess.Symbol = 361515;
            btnProcess.Enabled = true;
        });
        btnCleartask.BeginInvoke(() => { btnCleartask.Enabled = true; });
        var current = _files.Count;
        foreach (var item in files)
        {
            if (_files.Any(x =>
                    x.FullName.Equals(item, StringComparison.OrdinalIgnoreCase) ||
                    !_formats.Any(z => z.Equals(x.Extension, StringComparison.OrdinalIgnoreCase))))
            {
                continue;
            }

            var file = new FileInfo(item);
            WriteLog($"{_pack.FormMain_Log_Open_File} {file.Name}");
            _files.Add(file);
            //动态加载图片
            var pic = new PictureBox
            {
                Text = file.Name,
                Name = $"pic_{_picid}",
                Image = Image.FromFile(file.FullName),
                Size = new Size(110, 110),
                BackgroundImageLayout = ImageLayout.Stretch,
                SizeMode = PictureBoxSizeMode.StretchImage,
                WaitOnLoad = false,
                Tag = file
            };
            //动态创建移除按钮
            var btnclose = new UISymbolButton
            {
                Cursor = Cursors.Hand,
                FillColor = Color.FromArgb(230, 80, 80),
                BackColor = Color.Transparent,
                FillHoverColor = Color.FromArgb(232, 127, 128),
                FillPressColor = Color.FromArgb(202, 87, 89),
                FillSelectedColor = Color.FromArgb(202, 87, 89),
                Font = new Font("微软雅黑", 12F),
                IsCircle = true,
                MinimumSize = new Size(1, 1),
                Name = $"rem_{_picid}",
                Padding = new Padding(4, 7, 4, 4),
                RectColor = Color.FromArgb(230, 80, 80),
                RectHoverColor = Color.FromArgb(232, 127, 128),
                RectPressColor = Color.FromArgb(202, 87, 89),
                RectSelectedColor = Color.FromArgb(202, 87, 89),
                Size = new Size(30, 35),
                Style = UIStyle.Custom,
                StyleCustomMode = true,
                Symbol = 61453,
                Location = pic.Location with { X = pic.Location.X + 80 }
            };

            btnclose.Click += Btnclose_Click;
            pic.Controls.Add(btnclose);
            pic.MouseHover += Pic_MouseHover;
            pic.DoubleClick += Pic_DoubleClick;
            panelInfo.Add(pic);
            await Task.Delay(5);
            current++;
            UpdateTaskCount(0, current);
            _picid++;
        }

        UpdateTaskCount(0, _files.Count);
    }

    /// <summary>
    /// 移除图片
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Btnclose_Click(object sender, EventArgs e)
    {
        if (_isrun)
        {
            return;
        }

        var btnclose = (UISymbolButton)sender;
        var pic = (PictureBox)btnclose.Parent;
        var file = (FileInfo)pic.Tag;
        WriteLog($"{_pack.FormMain_Remove_Task} {file.Name}");
        _files.Remove(file);
        panelInfo.Panel.Controls.Remove(pic);
        UpdateProgress();
        UpdateTaskCount(0, _files.Count);
    }

    /// <summary>
    /// 显示名称
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Pic_MouseHover(object sender, EventArgs e)
    {
        var pic = (PictureBox)sender;
        tooltipPic.SetToolTip(pic, pic.Text, _pack.FormMain_File_Name, 61530, 32, UIColor.Green);
    }

    /// <summary>
    /// 预览图片
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Pic_DoubleClick(object sender, EventArgs e)
    {
        var pic = (PictureBox)sender;
        var form = new FormViewPic(pic, _pack);
        form.ShowDialog(this);
    }

    /// <summary>
    /// 检测引擎
    /// </summary>
    /// <returns></returns>
    private bool CheckEngine()
    {
        try
        {
            const string ainame = @"realesrgan\realesrgan-ncnn-vulkan.exe";
            var sinfo = new ProcessStartInfo(ainame)
            {
                CreateNoWindow = true,
                UseShellExecute = false,
                RedirectStandardError = true,
                RedirectStandardOutput = true,
                RedirectStandardInput = true,
                StandardOutputEncoding = Encoding.GetEncoding("GB2312"),
                StandardErrorEncoding = Encoding.GetEncoding("GB2312"),
                Verb = "runas",
                Arguments = "-h",
                WorkingDirectory = AppContext.BaseDirectory
            };
            using var process = new Process();
            process.StartInfo = sinfo;
            process.EnableRaisingEvents = true;
            var status = process.Start();

            WriteLog(status ? _pack.FormMain_Init_Engine : _pack.FormMain_Engine_Fail);
            return status;
        }
        catch (Exception e)
        {
            WriteLog($"{_pack.FormMain_Engine_Fail} {e.Message}");
            return false;
        }
    }

    /// <summary>
    /// 加载硬件信息
    /// </summary>
    private void LoadHardInfo()
    {
        WriteLog(_pack.FormMain_Init_Hard_Info);
        LoadHardInfo("Win32_ComputerSystem", WmiType.WIN32_COMPUTER_SYSTEM, out var system);
        WriteLog(_pack.FormMain_Init_System_Info);
        LoadHardInfo("Win32_Processor", WmiType.WIN32_PROCESSOR, out var processor);
        WriteLog(_pack.FormMain_Init_Cpu_Info);
        LoadHardInfo("Win32_VideoController", WmiType.WIN32_VIDEO_CONTROLLER, out var video);
        WriteLog(_pack.FormMain_Init_Graphics_Info);
        LoadHardInfo("Win32_OperatingSystem", WmiType.WIN32_OPERATING_SYSTEM, out var os);
        WriteLog(_pack.FormMain_Init_Others_Info);

        //更新系统名称
        lblxsysname.BeginInvoke((Action<string>)(x => { lblxsysname.Text = x; }), os["Caption"]?.ToString());

        //更新处理器
        lblxprocessor.BeginInvoke((Action<string>)(x => { lblxprocessor.Text = x; }), processor["Name"]?.ToString());

        //更新物理核心
        lblxcpu.BeginInvoke((Action<string>)(x => { lblxcpu.Text = x; }), processor["NumberOfCores"]?.ToString());

        //更新逻辑核心
        lblxcpulogic.BeginInvoke((Action<string>)(x => { lblxcpulogic.Text = x; }),
            processor["NumberOfLogicalProcessors"]?.ToString());

        //更新显卡
        lblxvideo.BeginInvoke((Action<string>)(x => { lblxvideo.Text = x; }), video["Caption"]?.ToString());

        //更新品牌
        var sysfam = system["SystemFamily"]?.ToString();
        var manufac = system["Manufacturer"]?.ToString();
        var brand =
            string.IsNullOrEmpty(sysfam) || sysfam.Equals("Default string", StringComparison.OrdinalIgnoreCase)
                ? !string.IsNullOrEmpty(manufac) ? manufac : @"-"
                : sysfam;
        lblxbrand.BeginInvoke((Action<string>)(x => { lblxbrand.Text = x; }), brand);
    }

    /// <summary>
    /// 根据wmi接口获取硬件
    /// </summary>
    /// <param name="wmi">wmi</param>
    /// <param name="type"></param>
    /// <param name="info"></param>
    private void LoadHardInfo(string wmi, WmiType type, out Hashtable info)
    {
        try
        {
            var wql = $"SELECT * FROM {wmi}";
            using var searcher = new ManagementObjectSearcher("root\\CIMV2", wql);
            using var moc = searcher.Get();
            var table = new Hashtable();
            foreach (var item in moc)
            {
                switch (type)
                {
                    case WmiType.WIN32_OPERATING_SYSTEM:
                    case WmiType.WIN32_VIDEO_CONTROLLER:
                        table["Caption"] = item.GetPropertyValue("Caption")?.ToString();
                        break;
                    case WmiType.WIN32_COMPUTER_SYSTEM:
                        table["SystemFamily"] = item.GetPropertyValue("SystemFamily")?.ToString();
                        table["Manufacturer"] = item.GetPropertyValue("Manufacturer")?.ToString();
                        break;
                    case WmiType.WIN32_PROCESSOR:
                        table["NumberOfCores"] = item.GetPropertyValue("NumberOfCores")?.ToString();
                        table["NumberOfLogicalProcessors"] =
                            item.GetPropertyValue("NumberOfLogicalProcessors")?.ToString();
                        table["Name"] = item.GetPropertyValue("Name")?.ToString();
                        break;
                }

                break;
            }

            info = table;
        }
        catch (Exception)
        {
            info = new();
        }
    }

    /// <summary>
    /// 输出日志
    /// </summary>
    /// <param name="txt">日志内容</param>
    /// <param name="isclear">是否清理</param>
    private void WriteLog(string txt, bool isclear = false)
    {
        txtLog.BeginInvoke((Action<string, bool>)((x, y) =>
        {
            if (y)
            {
                txtLog.Text = string.Empty;
            }

            txtLog.Font = GetFonts();
            txtLog.AppendText($"[{DateTime.Now:G}] | {x}{Environment.NewLine}");
            txtLog.ScrollToCaret();
        }), txt, isclear);
    }

    /// <summary>
    /// 更新任务数量
    /// </summary>
    /// <param name="current"></param>
    /// <param name="total"></param>
    private void UpdateTaskCount(int current = 0, int total = 0)
    {
        lblxFinished.BeginInvoke((Action<int>)(x => { lblxFinished.Text = x.ToString(); }), current);
        lblxTotal.BeginInvoke((Action<int>)(x => { lblxTotal.Text = x.ToString(); }), total);
    }

    /// <summary>
    /// 更新进度条
    /// </summary>
    /// <param name="current"></param>
    /// <param name="total"></param>
    private void UpdateProgress(int current = 0, int total = 0)
    {
        progressInfo.BeginInvoke((Action<int, int>)((x, y) =>
        {
            if (x <= 0 || y <= 0)
            {
                progressInfo.Value = 0;
                progressInfo.Text = @"0.0%";
            }
            else
            {
                var result = Convert.ToDecimal(x) / Convert.ToDecimal(y);
                var percent = result.ToString("P2");
                progressInfo.Value = Convert.ToInt32(result * 100);
                progressInfo.Text = percent;
            }
        }), current, total);
    }

    /// <summary>
    /// 更新任务开始时间
    /// </summary>
    /// <param name="time"></param>
    private void UpdateStartTime(string time = "00:00")
    {
        ledStarttime.BeginInvoke((Action<string>)(x => { ledStarttime.Text = x.ToString(); }), time);
    }

    /// <summary>
    /// 更新任务总耗时
    /// </summary>
    /// <param name="time"></param>
    private void UpdateTotalTime(string time = "00:00")
    {
        ledTotaltime.BeginInvoke((Action<string>)(x => { ledTotaltime.Text = x.ToString(); }), time);
    }


    /// <summary>
    /// 开始处理
    /// </summary>
    private async Task btnProcess_Click()
    {
        await Task.Run(async () =>
        {
            if (_files.Count <= 0 || !_isai)
            {
                return;
            }

            var now = DateTime.Now;
            UpdateTotalTime();
            UpdateStartTime($"{now:HH:mm:ss}");
            var totaltimer = new XTimer
            {
                Interval = 1000
            };
            totaltimer.Elapsed += (_, y) =>
            {
                var span = y.SignalTime - now;
                UpdateTotalTime($"{span.Hours:00}:{span.Minutes:00}:{span.Seconds:00}");
            };
            totaltimer.Start();
            _isrun = true;
            btnProcess.BeginInvoke(() =>
            {
                btnProcess.Symbol = 61516;
                btnProcess.Enabled = false;
            });

            btnCleartask.BeginInvoke(() => { btnCleartask.Enabled = false; });

            const string ainame = @"realesrgan\realesrgan-ncnn-vulkan.exe";
            var cpus = Convert.ToInt32(Environment.ProcessorCount / 2);
            if (cpus <= 2)
            {
                cpus = 2;
            }

            var thread = "1:2:2";
            if (cpus >= 6)
            {
                thread = GetThread(cpus);
            }

            var semaphore = new SemaphoreSlim(0, cpus);
            WriteLog($"{_pack.FormMain_All_Task_Count} {_files.Count}");
            var remain = _files.Count;
            UpdateTaskCount(0, remain);
            UpdateProgress(0, remain);
            var module = _option.Module switch
            {
                "1" => "realesrgan-x4plus",
                "2" => "realesrgan-x4plus-anime",
                "3" => "realesr-animevideov3-x2",
                "4" => "realesr-animevideov3-x3",
                "5" => "realesr-animevideov3-x4",
                _ => "realesrgan-x4plus"
            };
            var tasks = _files.Select(xitem => Task.Run(async () =>
                {
                    WriteLog($"{_pack.FormMain_Task} {xitem.Name}{_pack.FormMain_Wait_Execute_Task}");
                    await semaphore.WaitAsync();
                    WriteLog($"{_pack.FormMain_Task} {xitem.Name}{_pack.FormMain_Start_Execute_Task}");
                    try
                    {
                        var xname = xitem.NameWithoutExt();
                        if (!string.IsNullOrEmpty(_option.AppendExt))
                        {
                            xname += _option.AppendExt;
                        }

                        var format = _option.OutFormat switch
                        {
                            2 => ".png",
                            3 => ".webp",
                            _ => ".jpg"
                        };
                        var cmd =
                            $" -i \"{xitem.FullName}\" -o \"{_option.OutDirPath}{xname}{format}\" -n {module} -f {format.Replace(".", "")} -s 4 -g auto -j {thread} -v ";
                        var sinfo = new ProcessStartInfo(ainame, cmd)
                        {
                            CreateNoWindow = true,
                            UseShellExecute = false,
                            RedirectStandardError = true,
                            RedirectStandardOutput = true,
                            RedirectStandardInput = true,
                            WorkingDirectory = AppContext.BaseDirectory
                        };
                        using var process = new Process();
                        process.StartInfo = sinfo;
                        process.EnableRaisingEvents = true;
                        process.OutputDataReceived += Process_OutputDataReceived;
                        process.Exited += Process_Exited;
                        var isstart = process.Start();
                        if (!isstart)
                        {
                            return;
                        }

                        _processlist.Add(process.Id);
                        process.WaitForExit();
                        await Task.Delay(200);
                    }
                    catch (Exception ex)
                    {
                        WriteLog($"{_pack.FormMain_Task} {xitem.Name}, {_pack.FormMain_Exception} {ex.Message}");
                    }
                    finally
                    {
                        WriteLog($"{_pack.FormMain_Task} {xitem.Name}, {_pack.FormMain_Has_Finished}");
                        if (remain > 0)
                        {
                            remain--;
                        }

                        WriteLog(
                            $"{_pack.FormMain_All_Task_Count} {_files.Count}, {_pack.FormMain_Remain_Task_Count} {remain}");
                        var current = _files.Count - remain;
                        UpdateTaskCount(current, _files.Count);
                        UpdateProgress(current, _files.Count);
                        semaphore.Release(1);
                    }
                }))
                .ToList();

            do
            {
                await Task.Delay(500);
            } while (tasks.Count < _files.Count);

            WriteLog(_pack.FormMain_Task_Start);
            semaphore.Release(cpus);

            await Task.WhenAll(tasks);
            if (tasks.TrueForAll(x => x.IsCompleted || x.IsCanceled || x.IsFaulted))
            {
                btnProcess.BeginInvoke(() =>
                {
                    btnProcess.Symbol = 361515;
                    btnProcess.Enabled = true;
                });
                btnCleartask.BeginInvoke(() => { btnCleartask.Enabled = true; });

                _isrun = false;
                WriteLog(_pack.FormMain_Task_Finished);
                _picid = 0;
                var total = _files.Count;
                _processlist.Clear();
                _files.Clear();
                panelInfo.BeginInvoke(() => { panelInfo.Panel.Controls.Clear(); });
                UpdateProgress(total, total);
                UpdateTaskCount(total, total);
                totaltimer.Stop();
                totaltimer.Dispose();
                WriteLog(_pack.FormMain_Clear_Finished_Task);
                await Task.Run(() =>
                {
                    var sinfo = new ProcessStartInfo
                    {
                        FileName = "explorer.exe",
                        CreateNoWindow = true,
                        UseShellExecute = false,
                        RedirectStandardError = true,
                        RedirectStandardOutput = true,
                        RedirectStandardInput = true,
                        Arguments = _option.OutDirPath,
                        Verb = "runas"
                    };
                    using var process = new Process();
                    process.StartInfo = sinfo;
                    process.EnableRaisingEvents = true;
                    process.Start();
                });
            }
        });
    }

    private static string GetThread(int cpus)
    {
        string result;
        if (cpus % 3 == 0)
        {
            var avg = cpus / 3;
            result = $"{avg}:{avg}:{avg}";
        }
        else
        {
            var rec = 1;
            var remain = cpus - 2;
            do
            {
                if (remain <= 2)
                {
                    break;
                }

                var xremain = remain % 3;
                if (xremain % 2 == 0)
                {
                    rec++;
                }

                remain = xremain;
            } while (remain > 0);

            var first = rec * 2;
            var avg = (cpus - first) / 2;
            result = $"{first}:{avg}:{avg}";
        }

        return result;
    }

    private void Process_Exited(object sender, EventArgs e)
    {
        var process = (Process)sender;
        _processlist.Remove(process.Id);
    }

    /// <summary>
    /// 输出日志
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Process_OutputDataReceived(object sender, DataReceivedEventArgs e)
    {
        if (string.IsNullOrEmpty(e.Data))
        {
            return;
        }

        WriteLog(e.Data);
    }

    /// <summary>
    /// 清空日志
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnClearlog_Click(object sender, EventArgs e)
    {
        WriteLog(_pack.FormMain_Clear_Logs, true);
    }

    /// <summary>
    /// 清空任务
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnCleartask_Click(object sender, EventArgs e)
    {
        if (_files.Count <= 0)
        {
            return;
        }

        _processlist.Clear();
        _picid = 0;
        _files.Clear();
        UpdateTaskCount();
        UpdateProgress();
        panelInfo.BeginInvoke(() => { panelInfo.Panel.Controls.Clear(); });
        WriteLog(_pack.FormMain_Clear_All_Task);
    }

    /// <summary>
    /// 拖放文件
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void panelInfo_DragEnter(object sender, DragEventArgs e)
    {
        if (_isrun)
        {
            return;
        }

        if (e.Data.GetDataPresent(DataFormats.FileDrop))
        {
            e.Effect = DragDropEffects.Copy;
        }
    }

    /// <summary>
    /// 拖放文件
    /// </summary>
    /// <param name="e"></param>
    private async Task panelInfo_DragDrop(DragEventArgs e)
    {
        if (_isrun)
        {
            return;
        }

        var files = (string[])e.Data.GetData(DataFormats.FileDrop);
        var list = (from file in files
            let ext = Path.GetExtension(file)
            where _formats.Any(x => x.Equals(ext, StringComparison.OrdinalIgnoreCase))
            select file).ToList();
        await AddFiles(list);
    }
}