using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using log4net;

namespace FTH.Utils.LogViewer.Tools
{
    public class ElapsedTime
    {
        private TimeSpan timeSpan;
        public TimeSpan TimeSpan
        {
            get { return timeSpan; }
            set { timeSpan = value; }
        }       
    }

    


    public class PerfMonitor : IDisposable
    {
  
        static private ILog logger = LogManager.GetLogger(typeof(PerfMonitor));
       

        private string message;
        private ElapsedTime elapsed;
        private Stopwatch sw;
        private bool logMode;
       

        public PerfMonitor(ElapsedTime elapsed)
        {
            if (logger.IsDebugEnabled)
            {
                this.logMode = false;
                this.elapsed = elapsed;
                this.sw = new Stopwatch();
                this.sw.Start();
            }
        }


        public PerfMonitor(string message)
        {
            if (logger.IsDebugEnabled)
            {
                this.logMode = true;

                this.message = message + ": {0} ms";
                this.sw = new Stopwatch();
                this.sw.Start();
            }
        }

        #region IDisposable Members

        public void Dispose()
        {
            if (logger.IsDebugEnabled)
            {
                this.sw.Stop();
                if (logMode)
                {

                    logger.DebugFormat(this.message, this.sw.ElapsedMilliseconds);
                }
                else
                    this.elapsed.TimeSpan = this.sw.Elapsed;
            }
        }

        #endregion
    }
}
