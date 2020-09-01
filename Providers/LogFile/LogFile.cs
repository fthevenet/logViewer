using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.IO;
using System.Text.RegularExpressions;
using System.ComponentModel;

namespace FTH.Utils.LogViewer.Providers.LogFile
{

   

    public class LogFileProvider : IDisposable
    {
     //   private FileInfo file = null;
        private string location = string.Empty;
        private DataTable LogData;
        private DataColumn LogLineNumber;
        private DataColumn LogTimeStamp;
        private DataColumn LogThread;
        private DataColumn LogSeverity;
        private DataColumn LogLoggerName;
        private DataColumn LogMessage;
        private DataSet dataSet;
        private long lastPosition = 0;
        private int lastLine = 1;
        private bool isValid = false;
        private LogProviderStatus status = LogProviderStatus.Offline;
        private static ParsingExpressions parsingRules = new ParsingExpressions();

        public LogProviderStatus Status
        {
            get { return status; }
        }

        public bool IsValid
        {
            get { return isValid; }
        }

        public int LastLine
        {
            get { return lastLine; }
        }

        private static log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


        private LogFileProvider()
        {
            parsingRules.LoadSettings();
            this.BuildDataSet();
        }

        public string Location
        {
            get { return this.location; }
        }

        public DataSet DataSet
        {
            get { return dataSet; }
        }



        public static LogFileProvider Open(string filePath)
        {            
            return LogFileProvider.Open(filePath, null, null);
        }

        public static LogFileProvider Empty
        {
            get { return new LogFileProvider(); }
        }


        private static bool read(LogFileProvider logs, BackgroundWorker worker, DoWorkEventArgs e)
        {
            DataTable t = logs.dataSet.Tables["LogData"];
            using (StreamReader rd = new StreamReader(new FileStream(logs.Location, FileMode.Open, FileAccess.Read, FileShare.Delete)))
            {
                long fileSize = rd.BaseStream.Length;
                using (new Tools.PerfMonitor(string.Format("Time taken to load {0} ({1} kb)", logs.Location, fileSize / 1024)))
                {
                    
                    if (logs.lastPosition > fileSize)
                        return false;

                    rd.BaseStream.Position = logs.lastPosition;
                    int i = logs.LastLine;
                    double charRead = 0;
                    logEvent l = new logEvent();
                    while (!rd.EndOfStream)
                    {
                        
                        string lStr = rd.ReadLine();
                        logEvent nl = parsingRules.ParseLine(lStr, i++);
                        if (nl.IsValid)
                        {
                            addRow(t, l);
                            l = nl;
                        }
                        else
                        {
                            l.Message += ("\r\n" + lStr);
                        }

                        charRead += lStr.Length;

                        int progress = (int)Math.Truncate((charRead / fileSize) * 100);

                        if (worker != null)
                        {
                            worker.ReportProgress(progress);
                            if (worker.CancellationPending)
                            {
                                t.RejectChanges();
                                e.Cancel = true;
                                return false;
                            }
                        }
                    }

                    addRow(t, l);
                    t.AcceptChanges();

                    if (e != null)
                        e.Result = logs;
                    logs.lastPosition = rd.BaseStream.Position;
                    logs.lastLine = i;
                }

                logs.isValid = true;
                logs.status = LogProviderStatus.Online;
            }
            return true;

        }

        public static LogFileProvider Open(string filePath, BackgroundWorker worker, DoWorkEventArgs e)
        {
            try
            {
                logger.DebugFormat("Parsing log events from file {0}", filePath);
                LogFileProvider logs = new LogFileProvider();
                logs.location = filePath;

                LogFileProvider.read(logs, worker, e);

                return logs;
            }
            catch (Exception ex)
            {
                
                throw new OpenLogFileException(filePath, ex);
            }
            
        }

        public void Watch()
        {

            this.Watch(null, null);
        }

        public void Watch(BackgroundWorker worker, DoWorkEventArgs e)
        {
            logger.DebugFormat("Tailing file {0}", this.Location);
            LogFileProvider.read(this, worker, e);

        }

        private static void addRow(DataTable t, logEvent l)
        {
            if (l.IsValid)
            {
                DataRow row = t.NewRow();
                row.ItemArray = new object[6] { 
                                    l.LineNumber,
                                    l.TimeStamp, 
                                    l.ThreadName,
                                    l.Severity,
                                    l.LoggerName,
                                    l.Message,
                                };
                t.Rows.Add(row);

            }

        }


        private void saveParsingRules()
        {



        }

        private void BuildDataSet()
        {

            dataSet = new System.Data.DataSet();
            LogData = new System.Data.DataTable();
            LogLineNumber = new System.Data.DataColumn();
            LogTimeStamp = new System.Data.DataColumn();
            LogThread = new System.Data.DataColumn();
            LogSeverity = new System.Data.DataColumn();
            LogLoggerName = new System.Data.DataColumn();
            LogMessage = new System.Data.DataColumn();

            ((System.ComponentModel.ISupportInitialize)(dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(LogData)).BeginInit();


            // 
            // dataSet1
            // 
            dataSet.DataSetName = "NewDataSet";
            dataSet.Locale = new System.Globalization.CultureInfo("");
            dataSet.Tables.AddRange(new System.Data.DataTable[] {
            LogData});
            // 
            // LogData
            // 
            LogData.Columns.AddRange(new System.Data.DataColumn[] {
                LogLineNumber,
                LogTimeStamp,
                LogThread,
                LogSeverity,
                LogLoggerName,
                LogMessage});

            LogData.Constraints.AddRange(new System.Data.Constraint[] { new System.Data.UniqueConstraint("Constraint1", new string[] { "LogLineNumber" }, true) });
            LogData.PrimaryKey = new System.Data.DataColumn[] { LogLineNumber };
            LogData.TableName = "LogData";
            // 
            // LogLineNumber
            // 
            LogLineNumber.AllowDBNull = false;
            LogLineNumber.AutoIncrement = true;
            LogLineNumber.Caption = "#";
            LogLineNumber.ColumnName = "LogLineNumber";
            LogLineNumber.DataType = typeof(int);
            LogLineNumber.ReadOnly = true;
            // 
            // LogTimeStamp
            // 
            LogTimeStamp.Caption = "Time";
            LogTimeStamp.ColumnName = "LogTimeStamp";
            LogTimeStamp.DataType = typeof(System.DateTime);
            LogTimeStamp.ReadOnly = true;
            // 
            // LogThread
            // 
            LogThread.Caption = "Thread";
            LogThread.ColumnName = "LogThread";
            LogThread.ReadOnly = true;
            // 
            // LogSeverity
            // 
            LogSeverity.Caption = "Severity";
            LogSeverity.ColumnName = "LogSeverity";
            LogSeverity.ReadOnly = true;
            // 
            // LogLoggerName
            // 
            LogLoggerName.Caption = "Logger";
            LogLoggerName.ColumnName = "LogLoggerName";
            LogLoggerName.ReadOnly = true;
            // 
            // LogMessage
            // 
            LogMessage.Caption = "Message";
            LogMessage.ColumnName = "LogMessage";
            LogMessage.ReadOnly = true;

            ((System.ComponentModel.ISupportInitialize)(dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(LogData)).EndInit();

        }

        public void Close()
        {
            this.location = string.Empty;
            this.status = LogProviderStatus.Offline;
            this.dataSet.Dispose();
            this.dataSet = null;
        }

        public void EditParsingExpressions()
        {
            if (new editRulesDlg().RegExSetup(ref parsingRules))
                parsingRules.SaveSettings();


        }

       #region Membres de IDisposable

		private bool disposed;
		
		public void Dispose()
		{
			Dispose(true);	
			GC.SuppressFinalize(this);
		}

		protected virtual void Dispose(bool disposing)
		{
			if(!this.disposed)
			{

				if(disposing)
				{
					// Dispose managed resources.
                    this.Close();

				}
				// Release unmanaged resources. If disposing is false, 				
					

			}
			disposed = true;         
		}

		~LogFileProvider()
        {
			Dispose(false);
		}


		#endregion
    }
}
