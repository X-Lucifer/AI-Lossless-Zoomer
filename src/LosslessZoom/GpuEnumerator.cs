using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Text.RegularExpressions;

namespace X.Lucifer.LosslessZoom;

/// <summary>
/// Enumerates Vulkan GPU devices for realesrgan-ncnn-vulkan.
/// </summary>
public static class GpuEnumerator
{
    private static readonly Regex GpuLineRegex = new(@"^\[(\d+)\s+(.+?)\]\s+queueC=", RegexOptions.Compiled);

    private static List<ComboxItem> _cached;

    public static List<ComboxItem> GetGpuList(ILangPack pack)
    {
        if (_cached != null)
        {
            return _cached;
        }

        var list = new List<ComboxItem>
        {
            new()
            {
                Id = "auto",
                Name = pack.FormOption_ComboxItem_AutoGpu
            }
        };

        var engineGpus = EnumerateFromEngine();
        if (engineGpus.Count > 0)
        {
            list.AddRange(engineGpus);
        }
        else
        {
            list.AddRange(EnumerateFromWmi());
        }

        _cached = list;
        return list;
    }

    public static string GetDisplayName(ILangPack pack, string gpuId)
    {
        if (string.IsNullOrWhiteSpace(gpuId) || gpuId.Equals("auto", StringComparison.OrdinalIgnoreCase))
        {
            return pack.FormOption_ComboxItem_AutoGpu;
        }

        var gpu = GetGpuList(pack).Find(x => x.Id == gpuId);
        return gpu?.Name ?? gpuId;
    }

    private static List<ComboxItem> EnumerateFromEngine()
    {
        var result = new List<ComboxItem>();
        var enginePath = Path.Combine(AppContext.BaseDirectory, @"realesrgan\realesrgan-ncnn-vulkan.exe");
        if (!File.Exists(enginePath))
        {
            return result;
        }

        var tempDir = Path.Combine(Path.GetTempPath(), "LosslessZoom");
        Directory.CreateDirectory(tempDir);
        var inputPath = Path.Combine(tempDir, "gpu_probe.png");
        var outputPath = Path.Combine(tempDir, "gpu_probe_out.png");
        File.WriteAllBytes(inputPath, MinimalPng);

        try
        {
            var psi = new ProcessStartInfo(enginePath,
                $"-i \"{inputPath}\" -o \"{outputPath}\" -n realesrgan-x4plus -s 2 -g -1 -v")
            {
                CreateNoWindow = true,
                UseShellExecute = false,
                RedirectStandardError = true,
                RedirectStandardOutput = true,
                WorkingDirectory = Path.Combine(AppContext.BaseDirectory, "realesrgan")
            };

            using var process = Process.Start(psi);
            if (process == null)
            {
                return result;
            }

            var output = process.StandardError.ReadToEnd();
            if (string.IsNullOrEmpty(output))
            {
                output = process.StandardOutput.ReadToEnd();
            }

            process.WaitForExit(15000);

            var seen = new HashSet<string>();
            foreach (var line in output.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries))
            {
                var match = GpuLineRegex.Match(line);
                if (!match.Success || !seen.Add(match.Groups[1].Value))
                {
                    continue;
                }

                result.Add(new ComboxItem
                {
                    Id = match.Groups[1].Value,
                    Name = $"[{match.Groups[1].Value}] {match.Groups[2].Value}"
                });
            }
        }
        catch (Exception)
        {
            result.Clear();
        }
        finally
        {
            TryDelete(inputPath);
            TryDelete(outputPath);
        }

        return result;
    }

    private static List<ComboxItem> EnumerateFromWmi()
    {
        var result = new List<ComboxItem>();
        try
        {
            using var searcher = new ManagementObjectSearcher("root\\CIMV2",
                "SELECT Name FROM Win32_VideoController WHERE Name IS NOT NULL");
            using var collection = searcher.Get();
            var index = 0;
            foreach (var item in collection)
            {
                var name = item.GetPropertyValue("Name")?.ToString();
                if (string.IsNullOrWhiteSpace(name))
                {
                    continue;
                }

                result.Add(new ComboxItem
                {
                    Id = index.ToString(),
                    Name = $"[{index}] {name}"
                });
                index++;
            }
        }
        catch (Exception)
        {
            // ignored
        }

        return result;
    }

    private static void TryDelete(string path)
    {
        try
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }
        catch (Exception)
        {
            // ignored
        }
    }

    private static readonly byte[] MinimalPng =
    {
        0x89, 0x50, 0x4E, 0x47, 0x0D, 0x0A, 0x1A, 0x0A, 0x00, 0x00, 0x00, 0x0D, 0x49, 0x48, 0x44, 0x52,
        0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x01, 0x08, 0x02, 0x00, 0x00, 0x00, 0x90, 0x77, 0x53,
        0xDE, 0x00, 0x00, 0x00, 0x0C, 0x49, 0x44, 0x41, 0x54, 0x08, 0xD7, 0x63, 0xF8, 0xCF, 0xC0, 0x00,
        0x00, 0x00, 0x02, 0x00, 0x01, 0xE2, 0x21, 0xBC, 0x33, 0x00, 0x00, 0x00, 0x00, 0x49, 0x45, 0x4E,
        0x44, 0xAE, 0x42, 0x60, 0x82
    };
}
