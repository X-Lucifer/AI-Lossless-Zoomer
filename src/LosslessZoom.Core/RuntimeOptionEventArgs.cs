using System;

namespace LosslessZoom.Core
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