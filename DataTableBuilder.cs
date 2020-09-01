using System;
using System.Collections.Generic;
using System.Text;
using System.Data;


namespace LogViewer
{
    class DataSetBuilder
    {

        public static DataSet CreateDataSet()
        {
            System.Data.DataSet dataSet1;
            System.Data.DataTable LogData;
            System.Data.DataColumn LogLineNumber;
            System.Data.DataColumn LogTimeStamp;
            System.Data.DataColumn LogThread;
            System.Data.DataColumn LogSeverity;
            System.Data.DataColumn LogLoggerName;
            System.Data.DataColumn LogMessage;

            dataSet1 = new System.Data.DataSet();
            LogData = new System.Data.DataTable();
            LogLineNumber = new System.Data.DataColumn();
            LogTimeStamp = new System.Data.DataColumn();
            LogThread = new System.Data.DataColumn();
            LogSeverity = new System.Data.DataColumn();
            LogLoggerName = new System.Data.DataColumn();
            LogMessage = new System.Data.DataColumn();
          
            ((System.ComponentModel.ISupportInitialize)(dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(LogData)).BeginInit();


            // 
            // dataSet1
            // 
            dataSet1.DataSetName = "NewDataSet";
            dataSet1.Locale = new System.Globalization.CultureInfo("");
            dataSet1.Tables.AddRange(new System.Data.DataTable[] {
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

            LogData.Constraints.AddRange(new System.Data.Constraint[] { new System.Data.UniqueConstraint("Constraint1", new string[] { "LogLineNumber"}, true)});
            LogData.PrimaryKey = new System.Data.DataColumn[] { LogLineNumber};
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

            ((System.ComponentModel.ISupportInitialize)(dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(LogData)).EndInit();

            return dataSet1;
        }

        
    }
}
