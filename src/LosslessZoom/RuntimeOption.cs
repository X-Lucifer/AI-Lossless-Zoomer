namespace X.Lucifer.LosslessZoom
{
    /// <summary>
    /// 运行时选项
    /// </summary>
    public class RuntimeOption
    {
        /// <summary>
        /// 模块
        /// </summary>
        public string Module { get; set; }

        /// <summary>
        /// 追加后缀
        /// </summary>
        public string AppendExt { get; set; }

        /// <summary>
        /// 输出格式
        /// </summary>
        public int OutFormat { get; set; }

        /// <summary>
        /// 输出目录
        /// </summary>
        public int OutDir { get; set; }

        /// <summary>
        /// 输出目录路径
        /// </summary>
        public string OutDirPath { get; set; }
    }
}