using System;
using System.Collections.Generic;
using System.Text;
using log4net;
using log4net.Core;
using log4net.Appender;
using log4net.Repository;
using log4net.Repository.Hierarchy;

namespace FTH.Utils.LogViewer.Tools
{
    public static class Log4netConfigTools
    {

        public static void SetRootLevel(Level level)
        {
            Hierarchy hierarchy = (Hierarchy)LogManager.GetRepository();
            hierarchy.Root.Level = level;
            hierarchy.RaiseConfigurationChanged(EventArgs.Empty);                   
        }

        public static void AddAppenderToRoot(log4net.Appender.IAppender appender)
        {
            Hierarchy hierarchy = (Hierarchy)LogManager.GetRepository();
            hierarchy.Root.AddAppender(appender);
        }

        public static void AddFileAppenderToRoot(string name)
        {
            log4net.Appender.FileAppender appender = new log4net.Appender.FileAppender();
            appender.Name = name;
            appender.LockingModel = new FileAppender.MinimalLock();
            Hierarchy hierarchy = (Hierarchy)LogManager.GetRepository();
            hierarchy.Root.AddAppender(appender);
        }

        // Set the level for a named logger
        public static void SetLevel(string loggerName, Level levelName)
        {
            log4net.ILog log = log4net.LogManager.GetLogger(loggerName);
            log4net.Repository.Hierarchy.Logger l = (log4net.Repository.Hierarchy.Logger)log.Logger;

            l.Level = levelName;
        }

        // Add an appender to a logger
        public static void AddAppender(string loggerName, log4net.Appender.IAppender appender)
        {
            log4net.ILog log = log4net.LogManager.GetLogger(loggerName);
            log4net.Repository.Hierarchy.Logger l = (log4net.Repository.Hierarchy.Logger)log.Logger;           
            l.AddAppender(appender);
        }

        // Find a named appender already attached to a logger
        public static log4net.Appender.IAppender FindAppender(string appenderName)
        {
            foreach (log4net.Appender.IAppender appender in log4net.LogManager.GetRepository().GetAppenders())
            {
                if (appender.Name == appenderName)
                {
                    return appender;
                }
            }
            return null;
        }

        //public static log4net.Appender.IAppender CreateImportModuleAppender(string name, Level threshold)
        //{            
        //    ImportModuleAppender appender = new ImportModuleAppender();
        //    appender.Name = name;                       
        //    appender.Threshold = threshold;

        //    log4net.Layout.PatternLayout layout = new log4net.Layout.PatternLayout();
        //    layout.ConversionPattern = "%message%newline";
        //    layout.ActivateOptions();

        //    appender.Layout = layout;
        //    appender.ActivateOptions();

        //    return appender;
        //}

        public static void SetupRootFileAppender(string name, string fileName, Level threshold)
        {
            IAppender appender = Log4netConfigTools.FindAppender(name);
            if (appender == null)
                Log4netConfigTools.AddFileAppenderToRoot(name);

            Log4netConfigTools.SetupFileAppender(name, fileName, threshold);
        }

        public static void SetupFileAppender( string name, string fileName, Level threshold)
        {
            FileAppender appender = (FileAppender)FindAppender(name);
            //appender.Name = name;
            appender.File = fileName;
            appender.AppendToFile = true;
            appender.Threshold = threshold;

            log4net.Layout.PatternLayout layout = new log4net.Layout.PatternLayout();
            layout.ConversionPattern = "%date [%thread] %-5level %logger - %message%newline";
            layout.ActivateOptions();

            appender.Layout = layout;
            appender.ActivateOptions();

        }

    }
}
