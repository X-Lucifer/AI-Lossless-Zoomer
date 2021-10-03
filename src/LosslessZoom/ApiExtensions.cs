using System;

namespace X.Lucifer.LosslessZoom
{
    public static class ApiExtensions
    {
        public static IAsyncResult BeginInvoke(this Action action)
        {
            return action.BeginInvoke(null, null);
        }

        public static IAsyncResult BeginInvoke(this Func<bool> func)
        {
            return func.BeginInvoke(null, null);
        }
    }
}