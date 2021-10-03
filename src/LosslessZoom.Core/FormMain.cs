using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;
using TG.INI;
using TG.INI.Serialization;
using XTimer = System.Timers.Timer;

namespace LosslessZoom.Core
{
    public partial class FormMain : UIForm
    {
        private readonly string _outdir = AppContext.BaseDirectory + @"output\";
        private readonly List<string> _formats = new()
        {
            ".jpg",
            ".jpeg",
            ".png"
        };
        private readonly List<FileInfo> _files;
        private int _picid;
        private RuntimeOption _option;
        private bool _isai;
        private readonly List<int> _processlist;
        private bool _isrun;

        public FormMain()
        {
            _processlist = new List<int>();
            _option = new RuntimeOption();
            _files = new List<FileInfo>();
            InitializeComponent();
            Load += async (_, _) => await FormMain_Load();
        }

        /// <summary>
        /// 加载
        /// </summary>
        private async Task FormMain_Load()
        {
            FormClosed += async (_, _) => await FormMain_FormClosed();
            panelInfo.DragDrop += async (_, x) => await panelInfo_DragDrop(x);
            timer.Tick += Timer_Tick;
            timer.Start();
            _isai = await Task.FromResult(CheckEngine());
            await Task.Run(LoadConfig);
            await Task.Run(LoadMenu);
            await Task.Run(LoadHardInfo);
            if (_isai)
            {
                btnProcess.Click += async (_, _) => await btnProcess_Click();
            }
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
                    Application.Exit();
                }
                else
                {
                    try
                    {
                        foreach (var item in _processlist)
                        {
                            using var process = Process.GetProcessById(item);
                            process.Kill();
                        }
                    }
                    catch (Exception)
                    {
                        Application.Exit();
                    }
                    finally
                    {
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
            lblTime.Text = $@"{DateTime.Now:G}";
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
                using var doc = IniSerialization.SerializeObjectToNewDocument(_option);
                doc.Write(file);
            }

            using var xdoc = new IniDocument(file);
            _option = IniSerialization.DeserializeDocument<RuntimeOption>(xdoc);

            WriteLog("初始化配置成功.");
        }

        /// <summary>
        /// 加载菜单
        /// </summary>
        private void LoadMenu()
        {
            navbarMenu.Nodes.AddRange(new[]
            {
                new TreeNode("文件(F)",new[]
                {
                    new TreeNode("打开(O)"),
                    new TreeNode("选项(S)"),
                    new TreeNode("退出(X)")
                }),
                new TreeNode("帮助(H)",new[]
                {
                    new TreeNode("关于(A)"),
                    new TreeNode("版权(C)")
                })
            });
            foreach (TreeNode item in navbarMenu.Nodes)
            {
                foreach (TreeNode xitem in item.Nodes)
                {
                    navbarMenu.SetNodeItem(xitem, new NavMenuItem(xitem.Text, xitem.Index));
                }
            }

            navbarMenu.MenuItemClick += async (_, x, y) => await NavbarMenu_MenuItemClick(x, y);
            WriteLog("加载菜单成功.");
        }

        /// <summary>
        /// 菜单事件处理
        /// </summary>
        /// <param name="index">索引</param>
        /// <param name="page">页码</param>
        private async Task NavbarMenu_MenuItemClick(int index, int page)
        {
            switch (index)
            {
                case 0:
                    switch (page)
                    {
                        case 0:
                            await OpenFiles();
                            break;
                        case 1:
                            if (_isai)
                            {
                                ShowOption();
                            }
                            else
                            {
                                ShowErrorTip("AI引擎加载失败");
                            }
                            break;
                        case 2:
                            await Exit();
                            break;
                    }
                    break;
                case 1:
                    switch (page)
                    {
                        case 0:
                            ShowAbout();
                            break;
                        case 1:
                            ShowCopyright();
                            break;
                    }
                    break;
            }
        }

        /// <summary>
        /// 版权
        /// </summary>
        private void ShowCopyright()
        {
            var form = new FormCopyright();
            form.ShowDialog(this);
        }

        /// <summary>
        /// 关于
        /// </summary>
        private void ShowAbout()
        {
            var form = new FormAbout();
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

            var form = new FormOption(_option);
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
            WriteLog("配置更改成功.");
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
            var result = open.ShowDialog();
            if (result != DialogResult.OK || open.FileNames.Length <= 0)
            {
                return;
            }
            await AddFiles(open.FileNames);
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

            var btnclose = (UISymbolButton) sender;
            var pic = (PictureBox) btnclose.Parent;
            var file = (FileInfo) pic.Tag;
            WriteLog($"移除任务: {file.Name}");
            _files.Remove(file);
            panelInfo.Panel.Controls.Remove(pic);
            UpdateProgress();
            UpdateTaskCount(0, _files.Count);
            GC.Collect();
        }

        /// <summary>
        /// 显示名称
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Pic_MouseHover(object sender, EventArgs e)
        {
            var pic = (PictureBox)sender;
            tooltipPic.SetToolTip(pic, pic.Text, "文件名", 61530, 32, UIColor.Green);
        }

        /// <summary>
        /// 预览图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Pic_DoubleClick(object sender, EventArgs e)
        {
            var pic = (PictureBox)sender;
            var form = new FormViewPic(pic);
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
                var ainame = @"realesrgan\realesrgan-ncnn-vulkan.exe";
                var sinfo = new ProcessStartInfo(ainame)
                {
                    CreateNoWindow = true,
                    UseShellExecute = false,
                    RedirectStandardError = true,
                    RedirectStandardOutput = true,
                    RedirectStandardInput = true,
                    Verb = "runas",
                    Arguments = "-h",
                    WorkingDirectory = AppContext.BaseDirectory
                };
                using var process = new Process { StartInfo = sinfo, EnableRaisingEvents = true };
                var status = process.Start();

                WriteLog(status ? "AI引擎加载成功." : "AI引擎加载失败.");
                return status;
            }
            catch (Exception e)
            {
                WriteLog($"AI引擎加载失败: {e.Message}");
                return false;
            }
        }

        /// <summary>
        /// 加载硬件信息
        /// </summary>
        private void LoadHardInfo()
        {
            WriteLog("初始化硬件信息.");
            LoadHardInfo("Win32_ComputerSystem", WmiType.WIN32_COMPUTER_SYSTEM, out var system);
            WriteLog("加载系统信息成功.");
            LoadHardInfo("Win32_Processor", WmiType.WIN32_PROCESSOR, out var processor);
            WriteLog("加载处理器信息成功.");
            LoadHardInfo("Win32_VideoController", WmiType.WIN32_VIDEO_CONTROLLER, out var video);
            WriteLog("加载显卡信息成功.");
            LoadHardInfo("Win32_OperatingSystem", WmiType.WIN32_OPERATING_SYSTEM, out var os);
            WriteLog("加载其他信息成功.");

            //更新系统名称
            lblxsysname.BeginInvoke((Action<string>)(x =>
            {
                lblxsysname.Text = x;
            }), os["Caption"]?.ToString());

            //更新处理器
            lblxprocessor.BeginInvoke((Action<string>)(x =>
            {
                lblxprocessor.Text = x;
            }), processor["Name"]?.ToString());

            //更新物理核心
            lblxcpu.BeginInvoke((Action<string>)(x =>
            {
                lblxcpu.Text = x;
            }), processor["NumberOfCores"]?.ToString());

            //更新逻辑核心
            lblxcpulogic.BeginInvoke((Action<string>)(x =>
            {
                lblxcpulogic.Text = x;
            }), processor["NumberOfLogicalProcessors"]?.ToString());

            //更新显卡
            lblxvideo.BeginInvoke((Action<string>)(x =>
            {
                lblxvideo.Text = x;
            }), video["Caption"]?.ToString());

            //更新品牌
            var sysfam = system["SystemFamily"]?.ToString();
            var manufac = system["Manufacturer"]?.ToString();
            var brand =
                string.IsNullOrEmpty(sysfam) || sysfam.Equals("Default string", StringComparison.OrdinalIgnoreCase)
                    ? !string.IsNullOrEmpty(manufac) ? manufac : @"-"
                    : sysfam;
            lblxbrand.BeginInvoke((Action<string>)(x =>
            {
                lblxbrand.Text = x;
            }), brand);
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
                info = new Hashtable();
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

                txtLog.AppendText($"{DateTime.Now:G}| {x}{Environment.NewLine}");
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
            lblxFinished.BeginInvoke((Action<int>)(x =>
            {
                lblxFinished.Text = x.ToString();
            }), current);
            lblxTotal.BeginInvoke((Action<int>)(x =>
            {
                lblxTotal.Text = x.ToString();
            }), total);
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
            ledStarttime.BeginInvoke((Action<string>)(x =>
            {
                ledStarttime.Text = x.ToString();
            }), time);
        }

        /// <summary>
        /// 更新任务总耗时
        /// </summary>
        /// <param name="time"></param>
        private void UpdateTotalTime(string time = "00:00")
        {
            ledTotaltime.BeginInvoke((Action<string>)(x =>
            {
                ledTotaltime.Text = x.ToString();
            }), time);
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
                btnProcess.BeginInvoke((Action)(() =>
                {
                    btnProcess.Symbol = 61516;
                    btnProcess.Enabled = false;
                }));

                btnCleartask.BeginInvoke((Action)(() =>
                {
                    btnCleartask.Enabled = false;
                }));

                const string ainame = @"realesrgan\realesrgan-ncnn-vulkan.exe";
                var tasks = new List<Task>();
                var semaphore = new SemaphoreSlim(0, 2);
                WriteLog($"总任务数量: {_files.Count}");
                var remain = _files.Count;
                UpdateTaskCount(0, remain);
                UpdateProgress();
                var module = _option.Module switch
                {
                    "1" => "realesrnet-x4plus",
                    "2" => "realesrgan-x4plus-anime",
                    _ => "realesrgan-x4plus"
                };
                foreach (var item in _files)
                {
                    var xitem = item;
                    tasks.Add(Task.Run(async () =>
                    {
                        WriteLog($"任务: {xitem.Name}, 已添加, 等待执行.");
                        await semaphore.WaitAsync();
                        WriteLog($"任务: {xitem.Name}, 已开始执行.");
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
                                $" -i \"{xitem.FullName}\" -o \"{_option.OutDirPath}{xname}{format}\" -n {module} -f {format.Replace(".", "")} -s 4 -g auto -j 2:2:2 -v ";
                            var sinfo = new ProcessStartInfo(ainame, cmd)
                            {
                                CreateNoWindow = true,
                                UseShellExecute = false,
                                RedirectStandardError = true,
                                RedirectStandardOutput = true,
                                RedirectStandardInput = true,
                                WorkingDirectory = AppContext.BaseDirectory
                            };
                            using var process = new Process
                            {
                                StartInfo = sinfo,
                                EnableRaisingEvents = true
                            };
                            process.OutputDataReceived += Process_OutputDataReceived;
                            process.Exited += Process_Exited;
                            var isstart = process.Start();
                            if (!isstart)
                            {
                                return;
                            }

                            _processlist.Add(process.Id);
                            await process.WaitForExitAsync();
                            await Task.Delay(200);
                        }
                        catch (Exception ex)
                        {
                            WriteLog($"任务: {xitem.Name}, 异常消息: {ex.Message}");
                        }
                        finally
                        {
                            WriteLog($"任务: {xitem.Name}, 已完成.");
                            if (remain > 0)
                            {
                                remain--;
                            }

                            WriteLog($"总任务数量: {_files.Count}, 剩余数量: {remain}");
                            var current = _files.Count - remain;
                            UpdateTaskCount(current, _files.Count);
                            UpdateProgress(current, _files.Count);
                            semaphore.Release();
                        }
                    }));
                }

                do
                {
                    await Task.Delay(500);
                } while (tasks.Count < _files.Count);

                WriteLog("任务开始.");
                semaphore.Release(2);
                await Task.WhenAll(tasks);
                if (tasks.TrueForAll(x => x.IsCompleted || x.IsCanceled || x.IsFaulted))
                {
                    BeginInvoke((Action)(() =>
                    {
                        btnProcess.Symbol = 361515;
                        btnProcess.Enabled = true;
                    }));

                    BeginInvoke((Action)(() =>
                    {
                        btnCleartask.Enabled = true;
                    }));

                    _isrun = false;
                    WriteLog("任务完成");
                    _picid = 0;
                    var total = _files.Count;
                    _processlist.Clear();
                    _files.Clear();
                    BeginInvoke((Action)(() =>
                    {
                        panelInfo.Panel.Controls.Clear();
                    }));
                    GC.Collect();
                    UpdateProgress(total, total);
                    UpdateTaskCount(total, total);
                    totaltimer.Stop();
                    totaltimer.Dispose();
                    WriteLog("清理已完成任务");
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
                        using var process = new Process
                        {
                            StartInfo = sinfo,
                            EnableRaisingEvents = true
                        };
                        process.Start();
                    });
                }
            });
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
            WriteLog("清空日志", true);
            GC.Collect();
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
            panelInfo.BeginInvoke((Action)(() =>
            {
                panelInfo.Panel.Controls.Clear();
            }));
            GC.Collect();
            WriteLog("清空任务");
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
                ShowInfoTip("总任务数量不能超过100");
                return;
            }

            BeginInvoke((Action)(() =>
            {
                btnProcess.Symbol = 361515;
                btnProcess.Enabled = true;
            }));
            BeginInvoke((Action)(() =>
            {
                btnCleartask.Enabled = true;
            }));
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
                WriteLog($"打开文件: {file.Name}");
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
                    Location = new Point(pic.Location.X + 80, pic.Location.Y)
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
}
