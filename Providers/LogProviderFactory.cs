using System;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using System.Text;
using log4net;
using System.ComponentModel;


namespace FTH.Utils.LogViewer.Providers
{
    public class LogProviderFactory
    {
        static private  object syncRoot = new object();
        static private readonly LogProviderFactory instance = new LogProviderFactory();
        static private readonly ILog logger = LogManager.GetLogger(typeof(LogProviderFactory));

        static public LogProviderFactory Instance
        {
            get
            {
                return LogProviderFactory.instance;
            }
        }


        private LogProviderFactory()
        {
            RegisterProviders(Assembly.GetExecutingAssembly());
        }
        public List<Type> AvailableProviders { get; }


        public int RegisterProviders(string path)
        {
            if (!File.Exists(path))
                throw new ArgumentException(string.Format("File {0} doesn't exist", path), "asmFile");

            return RegisterProviders(Assembly.LoadFile(path));


        }

        public int RegisterProviders(Assembly myAsm)
        {
            lock (syncRoot)
            {
                int nb = 0;
                foreach (Type t in myAsm.GetTypes())
                {
                    if (t.GetInterface(" FTH.Utils.LogViewer.Providers.ILogProvider") != null)
                    {
                        if (AvailableProviders.Contains(t))
                        {
                            logger.WarnFormat("Log provider \"{0}\" is already registered", t.FullName);
                        }
                        else
                        {
                            AvailableProviders.Add(t);
                            nb++;
                        }

                    }
                }
                return nb;
            }
        }
        private BackgroundWorker worker;

        public void OpenAsync(Type providerType, string location, DoWorkEventHandler doWorkHandler, RunWorkerCompletedEventHandler workerCompletedEventHandler, ProgressChangedEventHandler progressChangedEventHandler)
        {

            this.worker.DoWork += doWorkHandler;
            this.worker.RunWorkerCompleted += workerCompletedEventHandler;
            this.worker.ProgressChanged += progressChangedEventHandler;
     
        }
        

        public ILogProvider CreateProvider(Type providerType)
	    {
            lock (syncRoot)
            {
                if (!AvailableProviders.Contains(providerType))
                    throw new UnknownProviderException();

                return (ILogProvider)providerType.Assembly.CreateInstance(providerType.FullName);
            }           
	    }

    }

    
}
