using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Globalization;
using FTH.Utils.LogViewer.Properties;
using FTH.Utils.LogViewer.Tools;
using Microsoft.Win32;


namespace FTH.Utils.LogViewer
{


    class CheckStateBoundToolStripMenuItem : ToolStripMenuItem
    {

        private PropertyContainer<bool> propertySource;

        public bool DontChangeText { get; set; }

        public PropertyContainer<bool> PropertySource
        {
            get { return propertySource; }
            set
            {                
                propertySource = value;
                if (this.propertySource != null)
                    this.propertySource.PropertyChanged += new PropertyChangedEventHandler(container_PropertyChanged);
            }
        }



        public CheckStateBoundToolStripMenuItem()
            : base()
        {
             this.Click += new EventHandler(CheckStateBoundToolStripMenuItem_Click);
        }

        void CheckStateBoundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.propertySource != null)
                this.propertySource.Value = this.Checked;
        }

        void container_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            this.Checked = this.propertySource.Value;

            //if (!this.DontChangeText)
            //{
            //    if (this.propertySource.Value)
            //        this.Text = string.Format("Hide \"{0}\" events", e.PropertyName);
            //    else
            //        this.Text = string.Format("Show \"{0}\" events", e.PropertyName);
            //} 
        }

    }

  
}
