using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;

namespace FTH.Utils.LogViewer
{
   
    public struct logEvent
    {
        public int LineNumber;
        public DateTime TimeStamp;
        public string Severity;
        public string ThreadName;
        public string LoggerName;
        public string Message;
        public bool IsValid;
        private static log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public logEvent(int LineNumber, DateTime TimeStamp,string ThreadName, string Severity,  string LoggerName, string Message)
        {
            this.LineNumber = LineNumber;
            this.TimeStamp = TimeStamp;
            this.Severity = Severity;
            this.ThreadName = ThreadName;
            this.LoggerName = LoggerName;
            this.Message = Message;
            this.IsValid = true;
        }
      
    }
}
