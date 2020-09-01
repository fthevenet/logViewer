using System;


namespace FTH.Utils.LogViewer.Providers
{
	
    public class UnknownProviderException : Exception
    {
       
        public UnknownProviderException(string msg, Exception innerEx)
            : base(msg, innerEx)
        {
           
        }

        public UnknownProviderException(string msg)
            : base(msg)
        {
           
        }

        public UnknownProviderException()
            : base()
        {

        }
 
    }

   
}

