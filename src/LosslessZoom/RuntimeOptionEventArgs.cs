using System;

namespace X.Lucifer.LosslessZoom
{
    public class RuntimeOptionEventArgs : EventArgs
    {
        public RuntimeOption Option { get;}
        public RuntimeOptionEventArgs(RuntimeOption option)
        {
            Option = option;
        }
    }
}