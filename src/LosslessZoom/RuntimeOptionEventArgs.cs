using System;

namespace X.Lucifer.LosslessZoom
{
    public class RuntimeOptionEventArgs(RuntimeOption option) : EventArgs
    {
        public RuntimeOption Option { get;} = option;
    }
}