using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FTH.Utils.LogViewer
{
    public partial class EventDetails : Form
    {
        private static log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public EventDetails()
        {
            InitializeComponent();
        }

        public void ShowEventDetails(logEvent e)
        {
            this.txtDate.Text = e.TimeStamp.ToShortDateString();
            this.txtTime.Text = e.TimeStamp.ToString("HH:mm:ss.fff");
            this.txtlogger.Text = e.LoggerName;
            this.txtThread.Text = e.ThreadName;
            this.txtSeverity.Text = e.Severity;
            this.txtMessage.Text = e.Message;
            this.txtLineNb.Text = e.LineNumber.ToString();

            this.ShowDialog();


        }
    }
}
