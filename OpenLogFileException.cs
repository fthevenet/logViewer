using System;
using System.Collections.Generic;
using System.Text;

namespace FTH.Utils.LogViewer
{
   
    class OpenLogFileException : Exception
    {
      
        private string fileName;

        public string FileName
        {
            get { return fileName; }
        }

        public OpenLogFileException(string fileName, Exception innerEx)
            : base("Failed to open log file", innerEx)
        {
            this.fileName = fileName;
        }
    }
}
