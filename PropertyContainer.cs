using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.ComponentModel;
using FTH.Utils.LogViewer.Properties;

namespace FTH.Utils.LogViewer
{
    public class PropertyContainer<T> : INotifyPropertyChanged
    {
        protected T value;
        protected string propertyName;
        protected object syncRoot = new object();
        private static log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public string PropertyName
        {
            get { return propertyName; }
            set { propertyName = value; }
        }
        public event PropertyChangedEventHandler PropertyChanged;


        public PropertyContainer(string name)        
        {
            this.PropertyName = name;
            
        }

        public void InitializeValue(T value)
        {
            lock (syncRoot)
            {              
                this.value = value;
                NotifyPropertyChanged(this.propertyName);
            }

        }



        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(this.propertyName));
            }
        }

        public T Value
        {
            get { return this.value; }
            set
            {
                lock (syncRoot)
                {
                    if (!this.value.Equals(value))
                    {
                        this.value = value;
                        NotifyPropertyChanged(this.propertyName);
                    }
                }
            }
        }

    }


    public class PersistablePropertyContainer<T> : PropertyContainer<T>, IPersistableProperty
    {
        private static log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public PersistablePropertyContainer(string name) : base(name) { }

        public void LoadFromSettings()
        {
            try
            {
                this.InitializeValue((T)Settings.Default.PropertyValues[this.PropertyName].PropertyValue);
            }
            catch (Exception ex)
            {
                logger.Warn("Error loading settings value for " + this.propertyName, ex);
            }

        }

        public void SaveToSettings()
        {           
            try
            {
                Settings.Default.PropertyValues[this.PropertyName].PropertyValue = this.Value;
            }
            catch (Exception ex)
            {
                logger.Warn("Error saving settings value for " + this.propertyName, ex);
            }
        }

    }


    public interface IPersistableProperty
    {
        void SaveToSettings();
        void LoadFromSettings();
    }

    public interface IPropertyContainer
    {

        string PropertyName { get; set; }
       // T Value { get; set; }
        event PropertyChangedEventHandler PropertyChanged;
       // void InitializeValue(T value);
        
        

    }
}
