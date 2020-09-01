using System;
using System.Collections.Generic;
using System.Text;

namespace FTH.Utils.LogViewer.Providers
{
    public enum LogProviderStatus
    {
        Online,
        Offline,
        Error,
        Unknown
    }

    public interface ILogProvider
    {
        LogProviderStatus Status
        {
            get;
        }


    }
}
