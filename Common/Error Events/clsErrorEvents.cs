using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public static class clsErrorEvents
    {
        public static event Action<string> on_Error;

        public static void onError(string Msg)
        {
            on_Error?.Invoke(Msg);
        }

    }
}
