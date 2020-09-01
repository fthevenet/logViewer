using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms;


namespace FTH.Utils.LogViewer
{
  

    //Declare a class that inherits from ToolStripControlHost.
    public class ToolStripDateTimePicker : ToolStripControlHost
    {

       
        // Call the base constructor passing in a DateTimePicker instance.
        public ToolStripDateTimePicker()
            : base(new DateTimePicker()) 
        {
         //   this.DateTimePickerControl.Value = this.DateTimePickerControl.MinDate;
        }

        public DateTimePicker DateTimePickerControl
        {
            get
            {
                return Control as DateTimePicker;
            }
        }

        public string CustomFormat
        {
            get { return DateTimePickerControl.CustomFormat; }
            set { DateTimePickerControl.CustomFormat = value; }
        }

        public DateTimePickerFormat Format
        {
            get { return DateTimePickerControl.Format; }
            set { DateTimePickerControl.Format = value; }
        }

        public DateTime MinDate
        {
            get
            {
                return DateTimePickerControl.MinDate;
            }
            set
            {
                DateTimePickerControl.MinDate = value;
            }
        }

        public DateTime MaxDate
        {
            get
            {
                return DateTimePickerControl.MaxDate;
            }
            set
            {
                DateTimePickerControl.MaxDate = value;
            }
        }

        public DateTime Value
        {
            get
            {
                return DateTimePickerControl.Value;
            }
            set 
            {
                DateTimePickerControl.Value = value; 
            }
        }

        // Expose the AddBoldedDate method.
        //public void AddBoldedDate(DateTime dateToBold)
        //{
        //    DateTimePickerControl.AddBoldedDate(dateToBold);
        //}

        // Subscribe and unsubscribe the control events you wish to expose.
        protected override void OnSubscribeControlEvents(Control c)
        {
            // Call the base so the base events are connected.
            base.OnSubscribeControlEvents(c);

 
            DateTimePicker dateTimePickerControl = (DateTimePicker)c;

            // Add the event.
            dateTimePickerControl.ValueChanged += new EventHandler(dateTimePickerControl_ValueChanged);
               
        }

        void dateTimePickerControl_ValueChanged(object sender, EventArgs e)
        {
            if (ValueChange != null)
            {
                ValueChange(this, e);
            }
        }

        protected override void OnUnsubscribeControlEvents(Control c)
        {
            // Call the base method so the basic events are unsubscribed.
            base.OnUnsubscribeControlEvents(c);

            DateTimePicker dateTimePickerControl = (DateTimePicker)c;

            // Add the event.
            dateTimePickerControl.ValueChanged -= new EventHandler(dateTimePickerControl_ValueChanged);
        }

        // Declare the DateChanged event.
        //public event DateRangeEventHandler DateChanged;
        public event EventHandler ValueChange;

    }



}
