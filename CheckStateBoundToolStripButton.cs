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


    class CheckStateBoundToolStripButton : ToolStripButton
    {

        private PropertyContainer<bool> propertySource;

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

        public CheckStateBoundToolStripButton()
            : base()            
        {
            this.Click += new EventHandler(CheckStateBoundToolStripButton_Click);
        }

     

        void CheckStateBoundToolStripButton_Click(object sender, EventArgs e)
        {
            if (this.propertySource != null)
                this.propertySource.Value = this.Checked;
        }

        void container_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            this.Checked = this.propertySource.Value;           
        }

    }
}
