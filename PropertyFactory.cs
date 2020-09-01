using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace FTH.Utils.LogViewer
{
    public class PropertyCollection
    {

        private List<IPersistableProperty> persistableProperties = new List<IPersistableProperty>();
        private Dictionary<string, object> properties;

        public PropertyCollection()
        {
            this.persistableProperties = new List<IPersistableProperty>();
            this.properties = new Dictionary<string, object>();
        }

        public void SavePersistable()
        {
            this.persistableProperties.ForEach(p => p.SaveToSettings());
        }

        public void loadPersistable()
        {
            this.persistableProperties.ForEach(p => p.LoadFromSettings());
        }

        public PropertyContainer<T> Get<T>(string name)
        {
            try
            {
                return (PropertyContainer<T>)this.properties[name];
            }
            catch (Exception ex)
            {
                throw new RetreivePropertyException(name, ex);
            }
        }


        public void Add<T>(string name)
        {
            this.Add<T>(name, null, default(T), false);
        }

        public void Add<T>(string name, bool persistable)
        {
            this.Add<T>(name, null, default(T), persistable);
        }

        public void Add<T>(string name, PropertyChangedEventHandler PropertyChanged, bool persistable)
        {
            this.Add<T>(name, PropertyChanged, default(T), persistable);
        }

        public void Add<T>(string name, PropertyChangedEventHandler PropertyChanged)
        {
            this.Add<T>(name, PropertyChanged, default(T), false);
        }

        public void Add<T>(string name, PropertyChangedEventHandler PropertyChanged, T defaultValue)
        {
            this.Add<T>(name, PropertyChanged, defaultValue, false);
        }

        public void Add<T>(string name, PropertyChangedEventHandler PropertyChanged, T defaultValue, bool persistable)
        {
            try
            {
                PropertyContainer<T> p;
                if (persistable)
                {
                    p = new PersistablePropertyContainer<T>(name);
                    this.persistableProperties.Add((PersistablePropertyContainer<T>)p);
                }
                else
                {
                    p = new PropertyContainer<T>(name);
                }
                if (PropertyChanged != null)
                    p.PropertyChanged += PropertyChanged;
                p.Value = defaultValue;
                this.properties.Add(name, p);
            }
            catch (Exception ex)
            {
                throw new AddPropertyException(name, ex);
            }
        }


    }

    public class RetreivePropertyException : Exception
    {
        public RetreivePropertyException(string propertyName) : this(propertyName, null) { }
        public RetreivePropertyException(string propertyName, Exception innerException) : base(string.Format("Failed to retreived property \"{0}\"", propertyName), innerException) { }

    }


    public class AddPropertyException : Exception
    {
        public AddPropertyException(string propertyName) : this(propertyName, null) { }
        public AddPropertyException(string propertyName, Exception innerException) : base(string.Format("Failed to add property \"{0}\"", propertyName), innerException) { }

    }
}
