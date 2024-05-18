using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Sunny.UI;
using TG.INI.Serialization;

namespace X.Lucifer.LosslessZoom;

public partial class FormOption : UIEditForm
{
    /// <summary>
    /// 保存委托
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public delegate void SaveEventHandler(object sender, RuntimeOptionEventArgs e);

    /// <summary>
    /// 保存成功事件
    /// </summary>
    public event SaveEventHandler OnSaved;

    private readonly RuntimeOption _option;
    private readonly ILangPack _pack;

    public FormOption(RuntimeOption option, ILangPack pack)
    {
        _option = option;
        _pack = pack;
        InitializeComponent();
    }

    private void FormOption_Load(object sender, EventArgs e)
    {
        var list = new List<ComboxItem>
        {
            new()
            {
                Id = "1",
                Name = "realesrgan-x4plus"
            },
            new()
            {
                Id = "2",
                Name = "realesrgan-x4plus-anime"
            },
            new()
            {
                Id = "3",
                Name = "realesr-animevideov3-x2"
            },
            new()
            {
                Id = "4",
                Name = "realesr-animevideov3-x3"
            },
            new()
            {
                Id = "5",
                Name = "realesr-animevideov3-x4"
            }
        };
        cbxModule.DisplayMember = nameof(ComboxItem.Name);
        cbxModule.ValueMember = nameof(ComboxItem.Id);
        cbxModule.DataSource = list;
        cbxModule.SelectedIndex = list.FindIndex(x => x.Id == _option.Module);

        //绑定格式
        var flist = new List<ComboxItem>
        {
            new()
            {
                Id = "0",
                Name = _pack.FormOption_ComboxItem_Default
            },
            new()
            {
                Id = "1",
                Name = "JPG"
            },
            new()
            {
                Id = "2",
                Name = "PNG"
            },
            new()
            {
                Id = "3",
                Name = "WebP"
            }
        };
        Text = _pack.FormOption_Title;
        lblAppendExt.Text = _pack.FormOption_lblAppendExt;
        lblModule.Text = _pack.FormOption_lblModule;
        lblFormat.Text = _pack.FormOption_lblFormat;
        lblOutDir.Text = _pack.FormOption_lblOutDir;
        rbDefault.Text = _pack.FormOption_rbDefault;
        rbManual.Text = _pack.FormOption_rbManual;
        cbxFormat.DisplayMember = nameof(ComboxItem.Name);
        cbxFormat.ValueMember = nameof(ComboxItem.Id);
        cbxFormat.DataSource = flist;
        cbxFormat.SelectedIndex = flist.FindIndex(x => x.Id == _option.OutFormat.ToString());
        txtOutDir.Text = _option.OutDirPath;
        rbDefault.Checked = _option.OutDir == 1;
        rbManual.Checked = _option.OutDir == 2;
        btnBrowser.Visible = _option.OutDir == 2;
        txtOutDir.Visible = _option.OutDir == 2;
        txtAppendExt.Text = _option.AppendExt ?? "";
        rbDefault.CheckedChanged += RbDir_CheckedChanged;
        rbManual.CheckedChanged += RbDir_CheckedChanged;
        btnOK.Click += BtnOK_Click;
    }

    private void RbDir_CheckedChanged(object sender, EventArgs e)
    {
        var rbdir = (UIRadioButton)sender;
        if (rbdir.Tag.ToString() == "1")
        {
            btnBrowser.Visible = false;
            txtOutDir.Visible = false;
        }
        else
        {
            btnBrowser.Visible = true;
            txtOutDir.Visible = true;
            txtOutDir.BeginInvoke((Action<string>)(x => { txtOutDir.Text = x.ToString(); }), _option.OutDirPath);
        }
    }

    private void BtnOK_Click(object sender, EventArgs e)
    {
        var regex = new Regex(@"\W.*|\s.*");
        var ext = txtAppendExt.Text ?? "";
        var outdir = rbDefault.Checked
            ? AppContext.BaseDirectory + @"output\"
            : txtOutDir.Text
              ?? AppContext.BaseDirectory + @"output\";
        if (!outdir.EndsWith(@"\"))
        {
            outdir += @"\";
        }

        var config = new RuntimeOption
        {
            AppendExt = regex.Replace(ext, ""),
            Module = cbxModule.SelectedValue.ToString(),
            OutDir = rbDefault.Checked ? 1 : 2,
            OutDirPath = outdir,
            OutFormat = cbxFormat.SelectedIndex,
            Lang = _option.Lang
        };
        var file = AppContext.BaseDirectory + "config.ini";
        var doc = IniSerialization.SerializeObjectToNewDocument(config);
        if (File.Exists(file))
        {
            File.Delete(file);
        }

        doc.Write(file);
        if (OnSaved != null)
        {
            var roe = new RuntimeOptionEventArgs(config);
            OnSaved(this, roe);
        }

        Close();
    }

    private void btnBrowser_Click(object sender, EventArgs e)
    {
        var dialog = new FolderBrowserDialog();
        dialog.ShowNewFolderButton = true;
        dialog.Description = _pack.FormOption_btnBrowser;
        var result = dialog.ShowDialog(this);
        var path = result == DialogResult.OK ? dialog.SelectedPath : _option.OutDirPath;
        txtOutDir.BeginInvoke((Action<string>)(x => { txtOutDir.Text = x.ToString(); }), path);
    }
}