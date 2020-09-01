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
using FTH.Utils.LogViewer.Providers;
using FTH.Utils.LogViewer.Providers.LogFile;
using Microsoft.Win32;
using System.Linq.Expressions;
using ColorExtensions;
using System.Drawing.Drawing2D;

namespace FTH.Utils.LogViewer
{
    public partial class LogViewerForm : Form
    {
        private static log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private DataView dataView;
        private LogFileProvider logs = LogFileProvider.Empty;
        private bool tailMode = false;       
        private MruStripMenu mruMenu;

        private StringHistory threadFilterHistory;
        private StringHistory loggerFilterHistory;
        private StringHistory messageFilterHistory;
        private PropertyContainer<bool> showRibbon = new PropertyContainer<bool>("showOrHideRibbon");
        private PropertyCollection guiProps = new PropertyCollection();

        public LogViewerForm() : this(null) { }
        

        public LogViewerForm(string[] args)
        {


            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.UserPaint, true);
          
            InitializeComponent();
            //if (Properties.Settings.Default.useSystemColors)
               
            this.initBckgWorkers();
            this.initMRU();
            this.initPropertyBoundItems();

            this.setProfessionalVisualStyle();
            this.tsDateTimeMax.Value = this.tsDateTimeMin.Value = DateTime.Now;
            this.setRibbon(RibbonMode.File);

            if ((args != null) && (args.Length > 0) && (File.Exists(args[0])))
                this.openLogFile(args[0]);


        }

       

        #region Form UI handling

        

        public enum RibbonMode
        {
            File,
            View,
            Help
        }

        private List<RibbonBtnState> RibbonButtons;
        private void setRibbon(RibbonMode mode)
        {

            RibbonBtnState fileRibbonBtn = new RibbonBtnState(this.RibbonBtnFile, this.fileRibbonPanel);
            RibbonBtnState viewRibbonBtn = new RibbonBtnState(this.RibbonBtnView, this.viewRibbonPanel);
            RibbonBtnState settingsRibbonBtn = new RibbonBtnState(this.RibbonBtnSettings, this.settingsRibbonPanel);

            RibbonButtons = new List<RibbonBtnState>() { fileRibbonBtn, viewRibbonBtn, settingsRibbonBtn };

            fileRibbonBtn.BtnChecked.Value = true;

            //guiProps.Add<bool>("showRibbon")
           
            this.showRibbon.PropertyChanged += new PropertyChangedEventHandler(showOrHideRibbon_PropertyChanged);
            this.showRibbon.Value = true;



            this.setDebugEventsColorToolStripMenuItem.Tag = guiProps.Get<Color>("debugEventColor");
            this.setInfoEventsColorToolStripMenuItem1.Tag = guiProps.Get<Color>("infoEventColor"); 
            this.setWarnEventsColorToolStripMenuItem.Tag = guiProps.Get<Color>("warnEventColor"); 
            this.setErrorEventsColorToolStripMenuItem.Tag = guiProps.Get<Color>("errorEventColor"); 
            this.setFatalEventsColorToolStripMenuItem.Tag = guiProps.Get<Color>("fatalEventColor");


            this.setDebugEventsColorToolStripMenuItem.BackColor = guiProps.Get<Color>("debugEventColor").Value;
            this.setInfoEventsColorToolStripMenuItem1.BackColor = guiProps.Get<Color>("infoEventColor").Value;
            this.setWarnEventsColorToolStripMenuItem.BackColor = guiProps.Get<Color>("warnEventColor").Value;
            this.setErrorEventsColorToolStripMenuItem.BackColor = guiProps.Get<Color>("errorEventColor").Value;
            this.setFatalEventsColorToolStripMenuItem.BackColor = guiProps.Get<Color>("fatalEventColor").Value;

        }

        void useSystemColors_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {

            this.setProfessionalVisualStyle();
            this.LogViewContainer.Panel2.Invalidate();
        }


        void eventColor_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            PropertyContainer<Color> c = sender as PropertyContainer<Color>;

            lineStyles.Debug.BackColor = c.Value;
        }

        void showOrHideRibbon_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (this.showRibbon.Value)
                this.RibbonPanel.Height = 65;
            else
                this.RibbonPanel.Height = 0;
        }

     


        private void setProfessionalVisualStyle()
        {
            ProfessionalColorTable t = new ProfessionalColorTable();
            t.UseSystemColors = guiProps.Get<bool>("useSystemColors").Value; 
            ToolStripManager.Renderer = new ToolStripProfessionalRenderer(t);

            MenuTabsPanel.BackColor = t.MenuStripGradientBegin;

            this.txtDetailsMessage.BackColor = t.MenuStripGradientEnd;
            this.txtDetailsLogger.BackColor = t.MenuStripGradientEnd;
            this.txtDetailsSeverity.BackColor = t.MenuStripGradientEnd;
            this.txtDetailsThread.BackColor = t.MenuStripGradientEnd;
            this.txtDetailsTime.BackColor = t.MenuStripGradientEnd;

        }

        private void initMRU()
        {           
            this.threadFilterHistory = new StringHistory(20, this.tsTxtFilterThread,Settings.Default.ThreadFilterHistory);
            this.loggerFilterHistory = new StringHistory(20, this.tsTxtFilterLogger, Settings.Default.LoggerFilterHistory);
            this.messageFilterHistory = new StringHistory(20, this.tsTxtFilterMessage, Settings.Default.MessageFilterHistory);

            //this.mruMenu = new MruStripMenu(this.recentFilesToolStripMenuItem,
            //                                    new MruStripMenu.ClickedHandler(OnMruFile),
            //                                    Resources.mruRegKey + "\\MRU", false);

            this.mruMenu = new MruStripMenuInline(this.tsBtnOpen, this.recentFilesToolStripMenuItem1,
                                               new MruStripMenu.ClickedHandler(OnMruFile),
                                               Resources.mruRegKey + "\\MRU", false);
            this.mruMenu.LoadFromRegistry();
        }

        private void OnMruFile(int number, String filename)
        {
            this.openLogFile(filename);           
        }

        private void initBckgWorkers()
        {
            this.loadFileWorker.DoWork += new DoWorkEventHandler(loadFileWorker_DoWork);
            this.loadFileWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(loadFileWorker_RunWorkerCompleted);
            this.loadFileWorker.ProgressChanged += new ProgressChangedEventHandler(loadFileWorker_ProgressChanged);
        }

        private void initPropertyBoundItems()
        {
            guiProps.Add<bool>("showFatalEvents", new PropertyChangedEventHandler(dataViewFilteringRequired), true);
            guiProps.Add<bool>("showErrorEvents", new PropertyChangedEventHandler(dataViewFilteringRequired), true);
            guiProps.Add<bool>("showWarnEvents", new PropertyChangedEventHandler(dataViewFilteringRequired), true);
            guiProps.Add<bool>("showInfoEvents", new PropertyChangedEventHandler(dataViewFilteringRequired), true);
            guiProps.Add<bool>("showDebugEvents", new PropertyChangedEventHandler(dataViewFilteringRequired), true);

            guiProps.Add<Color>("debugEventColor", new PropertyChangedEventHandler(eventColor_PropertyChanged), true);
            guiProps.Add<Color>("infoEventColor", new PropertyChangedEventHandler(eventColor_PropertyChanged), true);
            guiProps.Add<Color>("warnEventColor", new PropertyChangedEventHandler(eventColor_PropertyChanged), true);
            guiProps.Add<Color>("errorEventColor", new PropertyChangedEventHandler(eventColor_PropertyChanged), true);
            guiProps.Add<Color>("fatalEventColor", new PropertyChangedEventHandler(eventColor_PropertyChanged), true);

            guiProps.Add<bool>("applySeverityColors", new PropertyChangedEventHandler(applySeverityColors_PropertyChanged), true);

            guiProps.Add<bool>("filterOnThread", new PropertyChangedEventHandler(dataViewFilteringRequired));
            guiProps.Add<bool>("filterOnLogger", new PropertyChangedEventHandler(dataViewFilteringRequired));
            guiProps.Add<bool>("filterOnMessage", new PropertyChangedEventHandler(dataViewFilteringRequired));
            guiProps.Add<bool>("filterOnMinDate", new PropertyChangedEventHandler(dataViewFilteringRequired));
            guiProps.Add<bool>("filterOnMaxDate", new PropertyChangedEventHandler(dataViewFilteringRequired));

            guiProps.Add<bool>("showLineColumn", new PropertyChangedEventHandler(showColumns_PropertyChanged), true);
            guiProps.Add<bool>("showThreadColumn", new PropertyChangedEventHandler(showColumns_PropertyChanged), true);
            guiProps.Add<bool>("showTimeColumn", new PropertyChangedEventHandler(showColumns_PropertyChanged), true);
            guiProps.Add<bool>("showSeverityColumn", new PropertyChangedEventHandler(showColumns_PropertyChanged), true);
            guiProps.Add<bool>("showLoggerColumn", new PropertyChangedEventHandler(showColumns_PropertyChanged), true);
            guiProps.Add<bool>("showMessageColumn", new PropertyChangedEventHandler(showColumns_PropertyChanged), true);

            guiProps.Add<bool>("showDetailsPane", new PropertyChangedEventHandler(showDetailsPane_PropertyChanged), true);

            guiProps.Add<long>("totalEventsNbr", new PropertyChangedEventHandler(totalEventsNbr_PropertyChanged));
            guiProps.Add<long>("shownEventsNbr", new PropertyChangedEventHandler(shownEventsNbr_PropertyChanged));
            guiProps.Add<long>("selectedEventsNbr", new PropertyChangedEventHandler(selectedEventsNbr_PropertyChanged));


            guiProps.Add<bool>("useSystemColors", new PropertyChangedEventHandler(useSystemColors_PropertyChanged), true);

            this.debugEventsToolStripMenuItem.PropertySource = 
            this.tsBtnDebug.PropertySource = guiProps.Get<bool>("showDebugEvents"); 

            this.tsBtnInfo.PropertySource =
            this.infoEventsToolStripMenuItem.PropertySource = guiProps.Get<bool>("showInfoEvents");

            this.tsBtnWarning.PropertySource =
            this.warningEventsToolStripMenuItem.PropertySource = guiProps.Get<bool>("showWarnEvents"); 

            this.tsBtnError.PropertySource =
            this.errorEventsToolStripMenuItem.PropertySource = guiProps.Get<bool>("showErrorEvents"); 
            
            this.tsBtnFatal.PropertySource = 
            this.fatalEventsToolStripMenuItem.PropertySource = guiProps.Get<bool>("showFatalEvents");

            this.tsBtnFilterLogger.PropertySource = guiProps.Get<bool>("filterOnLogger");
            this.tsBtnFilterThread.PropertySource = guiProps.Get<bool>("filterOnThread");
            this.tsBtnFilterMessage.PropertySource = guiProps.Get<bool>("filterOnMessage");
            this.tsBtnFilerDateMin.PropertySource = guiProps.Get<bool>("filterOnMinDate");
            this.tsBtnFilerDateMax.PropertySource = guiProps.Get<bool>("filterOnMaxDate");
            
            this.colorEventsBySeverityToolStripMenuItem.DontChangeText = true;
            this.colorEventsBySeverityToolStripMenuItem.PropertySource = guiProps.Get<bool>("applySeverityColors");

            this.lineNumberToolStripMenuItem.PropertySource = guiProps.Get<bool>("showLineColumn");           
            this.timeStamptoolStripMenuItem.PropertySource = guiProps.Get<bool>("showTimeColumn");  
            this.threadToolStripMenuItem.PropertySource = guiProps.Get<bool>("showThreadColumn");         
            this.severityToolStripMenuItem.PropertySource = guiProps.Get<bool>("showSeverityColumn");
            this.loggerToolStripMenuItem.PropertySource = guiProps.Get<bool>("showLoggerColumn");
            this.messageToolStripMenuItem.PropertySource = guiProps.Get<bool>("showMessageColumn");
            this.eventDetailsPaneToolStripMenuItem.PropertySource = guiProps.Get<bool>("showDetailsPane");

            this.btnUseSystemColorTable.PropertySource = guiProps.Get<bool>("useSystemColors");

            guiProps.loadPersistable();
         
        }
        void showDetailsPane_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            PropertyContainer<bool> p = sender as PropertyContainer<bool>;
            this.LogViewContainer.Panel2Collapsed = !(p.Value);

        }
        void showColumns_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            PropertyContainer<bool> p = sender as PropertyContainer<bool>;
            int colIdx = -1;
            switch (e.PropertyName)
            {
                case "showLineColumn":
                    colIdx = 0;
                    break;

                case "showTimeColumn":
                    colIdx = 1;
                    break;

                case "showThreadColumn":
                    colIdx = 2;
                    break;

                case "showSeverityColumn":
                    colIdx = 3;
                    break;

                case "showLoggerColumn":
                    colIdx = 4;
                    break;

                case "showMessageColumn":
                    colIdx = 5;
                    break;   
            }

            if(colIdx > -1)
                this.dataGridView1.Columns[colIdx].Visible = p.Value;
        }

        void selectedEventsNbr_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            PropertyContainer<long> p = sender as PropertyContainer<long>;
            string template = "{0} event selected";
            if (p.Value > 1)
                template = "{0} events selected";
            this.tsLabelSelectedLines.Text = string.Format(template, p.Value);
           
        }

        void shownEventsNbr_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            PropertyContainer<long> p = sender as PropertyContainer<long>;
            string template = "{0} event shown";
            if (p.Value > 1)
                template = "{0} events shown";
            this.tsLabelVisibleLines.Text = string.Format(template, p.Value);
        }

        void totalEventsNbr_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            PropertyContainer<long> p = sender as PropertyContainer<long>;
            string template = "{0} event in file";
            if (p.Value > 1)
                template = "{0} events in file";
            this.tsLabelTotalLines.Text = string.Format(template, p.Value);
        }

     

        void applySeverityColors_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            this.dataGridView1.Invalidate();
        }

        private void loadToForm(LogFileProvider logs)
        {
            this.stopTail();
            this.logs = logs;
            this.dataView = new DataView(this.logs.DataSet.Tables["LogData"]);
            this.dataGridView1.DataSource = this.dataView;
            this.filterView();
           
            guiProps.Get<long>("totalEventsNbr").Value = this.logs.DataSet.Tables["LogData"].Rows.Count;

            if (logs.Status == LogProviderStatus.Online)
            {
                this.mruMenu.AddFile(this.logs.Location);
                this.mruMenu.SetFirstFile(this.mruMenu.FindFilenameNumber(this.logs.Location));
                this.Text = string.Format("LogViewer - {0}", this.logs.Location);
            }
            else
            {
                this.Text = "LogViewer";
            }
        }

        private void LogViewerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                this.mruMenu.SaveToRegistry();

                Settings.Default.LoggerFilterHistory = this.loggerFilterHistory.Save();
                Settings.Default.MessageFilterHistory = this.messageFilterHistory.Save();
                Settings.Default.ThreadFilterHistory = this.threadFilterHistory.Save();

                guiProps.SavePersistable();

                Settings.Default.Save();
            }
            catch  (Exception ex)
            { 
                logger.Error("Error saving MRU", ex);
            }
        }

        private void updateStatusStrip(bool isLoading)
        {
            this.toolStripProgressBar1.Visible = isLoading;
            this.CancelButton.Visible = isLoading;

            this.tsLabelLoading.Visible = isLoading;

            

            this.tsLabelSelectedLines.Visible = !isLoading;
            this.tsLabelTotalLines.Visible = !isLoading;
            this.tsLabelVisibleLines.Visible = !isLoading;

            this.toolStripProgressBar1.Value = 0;
        }

        void dataViewFilteringRequired(object sender, PropertyChangedEventArgs e)
        {
            this.filterView();
        }


        #endregion

        #region Log Provider handling

        private void closeLogFile()
        {
            this.logs.Close();
            this.loadToForm(LogFileProvider.Empty);
            GC.Collect();
        }   

        private void reloadFile()
        {
           // this.logs.Refresh();

            if (this.logs.Status == LogProviderStatus.Online)
                this.openLogFile(this.logs.Location);

        }

        private void openFileDlg()
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.openLogFile(this.openFileDialog1.FileName);
            }

        }

        private void openLogFile(string path)
        {
            try
            {
                this.tsLabelLoading.Text = string.Format("Loading {0}", path);
                this.updateStatusStrip(true);
                this.loadFileWorker.RunWorkerAsync(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Cannot open file {0}: {1}", path, ex.Message), "Error opening log file", MessageBoxButtons.OK, MessageBoxIcon.Error);              
                logger.Error(ex);
            }

        }

        private bool toggleTail()
        {
            if (!this.tailMode)
                this.startTail();
            else
                this.stopTail();

            return this.tailMode;
        }

        private void startTail()
        {
            try
            {
                if (this.logs.Status == LogProviderStatus.Online)
              //  if (this.logs.File != null)
                {
                    this.fileSystemWatcher1.Path = Path.GetDirectoryName(this.logs.Location);
                    this.fileSystemWatcher1.Filter = Path.GetFileName(this.logs.Location);
                    this.fileSystemWatcher1.EnableRaisingEvents = true;
                    this.tailMode = true;
                }
                else
                    this.tailMode = false;
            }
            catch (Exception ex)
            {
                logger.Error("Failed to start tail");
                logger.Error(ex);
                this.tailMode = false;
            }

            this.watchToolStripMenuItem.Checked =
            this.tsBtnWatch.Checked = this.tailMode;
        }

        private void stopTail()
        {
            this.fileSystemWatcher1.EnableRaisingEvents = false;
            this.tailMode = false;

            this.watchToolStripMenuItem.Checked =
            this.tsBtnWatch.Checked = this.tailMode;
        }

        private void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {
            try
            {
                this.logs.Watch();
                guiProps.Get<long>("shownEventsNbr").Value = this.dataView.Count;
                guiProps.Get<long>("totalEventsNbr").Value = this.logs.DataSet.Tables["LogData"].Rows.Count;
                this.focusOnLastEvent();
            }
            catch (System.IO.IOException ioex)
            {
                logger.WarnFormat("Error trying to tail file {0}", this.logs.Location);
                logger.Warn(ioex);

            }
            catch (Exception ex)
            {
                logger.Error("Error trying to tail file");
                logger.Error(ex);
                this.stopTail();
                MessageBox.Show(ex.ToString());
            }

        }

        void loadFileWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                if (e.Error != null)
                {

                    OpenLogFileException openEx = e.Error as OpenLogFileException;
                    logger.Error(openEx);
                    MessageBox.Show(String.Format("Cannot open file {0}: {1}", openEx.FileName, openEx.InnerException.Message), "Error opening log file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mruMenu.RemoveFile(openEx.FileName);
                }
                else
                {
                    if (!e.Cancelled)
                        this.loadToForm((LogFileProvider)e.Result);
                }
                this.updateStatusStrip(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                logger.Error(ex);
            }

        }

        void loadFileWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            LogFileProvider.Open((string)e.Argument, (BackgroundWorker)sender, e);
        }

        void loadFileWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.toolStripProgressBar1.Value = e.ProgressPercentage;
        }

        private void CancelButton_ButtonClick(object sender, EventArgs e)
        {
            this.loadFileWorker.CancelAsync();
        }

        #endregion

        #region DataGridView handling

        private class lineStyles
        {
            private static DataGridViewCellStyle none = new DataGridViewCellStyle();
            public static DataGridViewCellStyle None
            {
                get { return lineStyles.none; }
            }

            private static DataGridViewCellStyle debug = new DataGridViewCellStyle();
            public static DataGridViewCellStyle Debug
            {
                get { return lineStyles.debug; }
                set { lineStyles.debug = value; }
            }

            private static DataGridViewCellStyle info = new DataGridViewCellStyle();
            public static DataGridViewCellStyle Info
            {
                get { return lineStyles.info; }
            }

            private static DataGridViewCellStyle warn = new DataGridViewCellStyle();
            public static DataGridViewCellStyle Warn
            {
                get { return lineStyles.warn; }
            }

            private static DataGridViewCellStyle error = new DataGridViewCellStyle();
            public static DataGridViewCellStyle Error
            {
                get { return lineStyles.error; }
            }

            private static DataGridViewCellStyle fatal = new DataGridViewCellStyle();
            public static DataGridViewCellStyle Fatal
            {
                get { return lineStyles.fatal; }
            }

            static lineStyles()
            {
                fatal.BackColor = Color.Red;
                debug.BackColor = Color.LightGray;
                info.BackColor = Color.LightGreen;
                warn.BackColor = Color.Yellow;
                error.BackColor = Color.LightPink;
                none.BackColor = Color.White;
            }
        }
     
        private void filterView()
        {
            try
            {
                if (this.dataView != null)
                {
                    
                    string conditions = string.Empty;
                    conditions += guiProps.Get<bool>("showFatalEvents").Value ? "LogSeverity = 'FATAL' OR " : string.Empty;
                    conditions += guiProps.Get<bool>("showErrorEvents").Value ? "LogSeverity = 'ERROR' OR " : string.Empty;
                    conditions += guiProps.Get<bool>("showWarnEvents").Value ? "LogSeverity = 'WARN' OR " : string.Empty;
                    conditions += guiProps.Get<bool>("showInfoEvents").Value ? "LogSeverity = 'INFO' OR " : string.Empty;
                    conditions += guiProps.Get<bool>("showDebugEvents").Value ? "LogSeverity = 'DEBUG' OR " : string.Empty;

                    if (conditions.Length > 0)
                    {
                        
                        conditions = conditions.Substring(0, conditions.Length - 3);
                        conditions = string.Format("({0}) AND ", conditions);
                    }

                    conditions += guiProps.Get<bool>("filterOnThread").Value ? String.Format("LogThread LIKE '{0}' AND ", this.tsTxtFilterThread.Text) : string.Empty;
                    conditions += guiProps.Get<bool>("filterOnLogger").Value ? String.Format("LogLoggerName LIKE '{0}' AND ", this.tsTxtFilterLogger.Text) : string.Empty;
                    conditions += guiProps.Get<bool>("filterOnMessage").Value ? String.Format("LogMessage LIKE '{0}' AND ", this.tsTxtFilterMessage.Text) : string.Empty;

                    if (conditions.Length > 0)
                    {

                        conditions = conditions.Substring(0, conditions.Length - 4);
                        conditions = string.Format("({0}) AND ", conditions);
                    }

                    conditions += guiProps.Get<bool>("filterOnMinDate").Value ? String.Format("LogTimeStamp >= #{0}# AND ", this.tsDateTimeMin.Value.ToString("M/d/yyyy HH:mm:ss")) : string.Empty;
                    conditions += guiProps.Get<bool>("filterOnMaxDate").Value ? String.Format("LogTimeStamp <= #{0}# AND ", this.tsDateTimeMax.Value.ToString("M/d/yyyy HH:mm:ss")) : string.Empty;              

                    if (conditions.Length > 0)
                        conditions = conditions.Substring(0, conditions.Length - 4);
                    else
                        conditions = "LogSeverity = 'NONE'";

                    using (new PerfMonitor(string.Format("Filtering DataView with: {0}", conditions)))
                    {
                        this.dataView.RowFilter = conditions;
                    }

                    guiProps.Get<long>("shownEventsNbr").Value = this.dataView.Count;                                             
                
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                logger.Error("Error filtering dataview");
                logger.Error(ex);
            }

        }



        private void focusOnLastEvent()
        {
            using (new Tools.PerfMonitor("Set dataView sort order"))
            {
                this.dataView.Sort = "LogLineNumber";
            }

            int idx = this.dataView.Count-1;
            if (idx > -1)
                this.dataGridView1.FirstDisplayedScrollingRowIndex = idx;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            guiProps.Get<long>("selectedEventsNbr").Value = this.dataGridView1.SelectedRows.Count;
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow r = this.dataGridView1.SelectedRows[0];

                if (r.Cells[0].Value == null)
                    return;
             
                this.displayEventToDetailPane(new logEvent(
                            (int)r.Cells[0].Value,
                            (DateTime)r.Cells[1].Value,
                            (string)r.Cells[2].Value,
                            (string)r.Cells[3].Value,
                            (string)r.Cells[4].Value,
                            (string)r.Cells[5].Value
                            ));
            }
        }

        private void displayEventToDetailPane(logEvent evt)
        {
            this.txtDetailsTime.Text = evt.TimeStamp.ToString();
            this.txtDetailsThread.Text = evt.ThreadName;
            this.txtDetailsLogger.Text = evt.LoggerName;
            this.txtDetailsSeverity.Text = evt.Severity;
            this.txtDetailsMessage.Text = evt.Message;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow r = this.dataGridView1.SelectedRows[0];
                new EventDetails().ShowEventDetails(
                    new logEvent(
                        (int)r.Cells[0].Value,
                        (DateTime)r.Cells[1].Value,
                        (string)r.Cells[2].Value,
                        (string)r.Cells[3].Value,
                        (string)r.Cells[4].Value,
                        (string)r.Cells[5].Value
                        ));
            }
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            DataGridViewRow dvr = this.dataGridView1.Rows[e.RowIndex];

            if (guiProps.Get<bool>("applySeverityColors").Value)
            {
                string val = dvr.Cells[3].Value as string;      
                switch (val)
                {

                    case "DEBUG":
                        dvr.DefaultCellStyle.BackColor = guiProps.Get<Color>("debugEventColor").Value;

                        break;

                    case "INFO":
                        dvr.DefaultCellStyle.BackColor = guiProps.Get<Color>("infoEventColor").Value;

                        break;

                    case "WARN":
                        dvr.DefaultCellStyle.BackColor = guiProps.Get<Color>("warnEventColor").Value;

                        break;

                    case "ERROR":
                        dvr.DefaultCellStyle.BackColor = guiProps.Get<Color>("errorEventColor").Value;

                        break;

                    case "FATAL":
                        dvr.DefaultCellStyle.BackColor = guiProps.Get<Color>("fatalEventColor").Value;

                        break;
                }
            }
            else
            {
                dvr.DefaultCellStyle.BackColor = Color.White;// = lineStyles.None;
            }
        }

        #endregion

        #region ToolStrip and menu handlers

        #region File

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.openFileDlg();
        }

        private void tsBtnOpen_Click(object sender, EventArgs e)
        {
            this.openFileDlg();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.closeLogFile();
        }

        private void tsBtnClose_Click(object sender, EventArgs e)
        {
            this.closeLogFile();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.reloadFile();
        }

        private void tsBtnReload_Click(object sender, EventArgs e)
        {
            this.reloadFile();
        }

        private void tailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toggleTail();
        }

        private void tsBtnTail_Click(object sender, EventArgs e)
        {
            toggleTail();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region View     


        private void tsTxtFilterThread_TextChanged(object sender, EventArgs e)
        {
            guiProps.Get<bool>("filterOnThread").Value = false;
        }

        private void tsTxtFilterLogger_TextChanged(object sender, EventArgs e)
        {
            guiProps.Get<bool>("filterOnLogger").Value = false;
        }

        private void tsTxtFilterMessage_TextChanged(object sender, EventArgs e)
        {
            guiProps.Get<bool>("filterOnMessage").Value = false;
        }

        private void tsDateTimeMin_ValueChange(object sender, EventArgs e)
        {
            guiProps.Get<bool>("filterOnMinDate").Value = false;
        }

        private void tsDateTimeMax_ValueChange(object sender, EventArgs e)
        {
            guiProps.Get<bool>("filterOnMaxDate").Value = false;
        }

        #endregion

        private void LogViewerForm_DragDrop(object sender, DragEventArgs e)
        {
            MessageBox.Show(e.X.ToString());
        }

       

        #endregion

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

     
        





        public class RibbonBtnState
        {

            private Panel RibbonPanel;
            private PropertyContainer<bool> btnChecked = new PropertyContainer<bool>("btnChecked");

            public PropertyContainer<bool> BtnChecked
            {
                get { return btnChecked; }
           //     set { btnChecked = value; }
            }

            private PropertyContainer<bool> btnHilited = new PropertyContainer<bool>("btnHilited");

            public PropertyContainer<bool> BtnHilited
            {
                get { return btnHilited; }
            //    set { btnHilited = value; }
            }

          
            private PictureBox picture;

            public PictureBox Picture
            {
                get { return picture; }
               // set { picture = value; }
            }




            public RibbonBtnState(PictureBox p, Panel RibbonPanel)
            {
                this.RibbonPanel = RibbonPanel;
                this.picture = p;
                p.Tag = this;
                this.btnChecked.PropertyChanged += new PropertyChangedEventHandler(btnChecked_PropertyChanged);
                this.btnHilited.PropertyChanged += new PropertyChangedEventHandler(btnHilited_PropertyChanged);

            }

            void btnHilited_PropertyChanged(object sender, PropertyChangedEventArgs e)
            {
                if (!this.BtnChecked.Value)
                    if (!this.BtnHilited.Value)
                        Picture.BackgroundImage = Resources.RibbonTabNone;
                    else
                        Picture.BackgroundImage = Resources.RibbonTabHilite;
             
            }

            void btnChecked_PropertyChanged(object sender, PropertyChangedEventArgs e)
            {

                if (!this.BtnChecked.Value)
                    Picture.BackgroundImage = Resources.RibbonTabNone;
                else
                    Picture.BackgroundImage = Resources.RibbonTabActive;

                this.RibbonPanel.Visible = this.BtnChecked.Value;
            }
        }

        private void RibbonBtn_MouseEnter(object sender, EventArgs e)
        {
            PictureBox p = sender as PictureBox;
            RibbonBtnState s = p.Tag as RibbonBtnState;

            s.BtnHilited.Value = true;
           
        }

        private void RibbonBtn_MouseLeave(object sender, EventArgs e)
        {
            PictureBox p = sender as PictureBox;
            RibbonBtnState s = p.Tag as RibbonBtnState;
            s.BtnHilited.Value = false;
        }

        private void RibbonBtn_Click(object sender, EventArgs e)
        {
            PictureBox p = sender as PictureBox;
            RibbonBtnState s = p.Tag as RibbonBtnState;
            foreach(RibbonBtnState r in this.RibbonButtons)
                if (r.Equals(s))
                    r.BtnChecked.Value = true;
                else
                    r.BtnChecked.Value = false;
            
            s.BtnHilited.Value = false;
            this.showRibbon.Value = true;
           
        }



        private void pictureBox4_DoubleClick(object sender, EventArgs e)
        {
            this.showRibbon.Value = !this.showRibbon.Value;
        }

        private void tsBtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void eventColorButtons_Click(object sender, EventArgs e)
        {
            ToolStripDropDownItem b = sender as ToolStripDropDownItem;
            PropertyContainer<Color> c = b.Tag as PropertyContainer<Color>;
   
            this.colorDialog1.Color = c.Value;

            this.colorDialog1.CustomColors = new int[] { guiProps.Get<Color>("debugEventColor").Value.ToBgr(),
                                                         guiProps.Get<Color>("infoEventColor").Value.ToBgr(),
                                                         guiProps.Get<Color>("warnEventColor").Value.ToBgr(),
                                                         guiProps.Get<Color>("errorEventColor").Value.ToBgr(),
                                                         guiProps.Get<Color>("fatalEventColor").Value.ToBgr()
                                                       };
           
           
            if (this.colorDialog1.ShowDialog() == DialogResult.OK)
            {
                b.BackColor = this.colorDialog1.Color;
                c.Value = this.colorDialog1.Color;
            }
        }


        private void LogViewerForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                this.reloadFile();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.logs.EditParsingExpressions();
        }

        private void lineNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Columns[0].Visible = ((ToolStripMenuItem)sender).Checked;        
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Columns[1].Visible = ((ToolStripMenuItem)sender).Checked;
        }

        private void threadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Columns[2].Visible = ((ToolStripMenuItem)sender).Checked;
        }

        private void severityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Columns[3].Visible = ((ToolStripMenuItem)sender).Checked;
        }

        private void loggerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Columns[4].Visible = ((ToolStripMenuItem)sender).Checked;
        }

        private void messageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Columns[5].Visible = ((ToolStripMenuItem)sender).Checked;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnResetSettings_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This action will reset all settings to their default value.\nDo you want to continue?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                Properties.Settings.Default.Reset();
                bool b = Properties.Settings.Default.useSystemColors;
                guiProps.loadPersistable();

            }
        }


        //private void DetailsContainer_Panel1_Paint(object sender, PaintEventArgs e)
        //{

        //    ProfessionalColorTable t = new ProfessionalColorTable();
        //    t.UseSystemColors = guiProps.Get<bool>("useSystemColors").Value;

        //    ToolStripManager.Renderer = new ToolStripProfessionalRenderer(t);

        //    Graphics g = e.Graphics;

        //    if (e.ClipRectangle.Height > 0 && e.ClipRectangle.Width > 0)
        //    {
        //        LinearGradientBrush b = new LinearGradientBrush(e.ClipRectangle, t.MenuStripGradientEnd, t.MenuStripGradientBegin, LinearGradientMode.Vertical);
        //        LinearGradientBrush b = new LinearGradientBrush(Point.Empty, new Point(e.ClipRectangle.Width, 1), t.MenuStripGradientEnd, t.MenuStripGradientBegin);

        //        g.FillRectangle(b, e.ClipRectangle);
        //    }
        //}




        private void panel2_Paint(object sender, PaintEventArgs e)
        {

            Panel p = sender as Panel;
            if (p != null)
            {

                ProfessionalColorTable t = new ProfessionalColorTable();

                t.UseSystemColors = guiProps.Get<bool>("useSystemColors").Value;

                ToolStripManager.Renderer = new ToolStripProfessionalRenderer(t);

                 Rectangle rect = new Rectangle(Point.Empty, new Size(p.Width, p.Height));

                Graphics g = e.Graphics;

                //if (e.ClipRectangle.Height > 0 && e.ClipRectangle.Width > 0)
                //{
                LinearGradientBrush b = new LinearGradientBrush(rect, t.MenuStripGradientEnd, t.MenuStripGradientBegin, LinearGradientMode.Vertical);
                // LinearGradientBrush b = new LinearGradientBrush(rect, t.MenuStripGradientEnd, t.MenuStripGradientBegin, LinearGradientMode.Vertical);

                //   LinearGradientBrush b = new LinearGradientBrush(Point.Empty, new Point(e.ClipRectangle.Width, 1), t.MenuStripGradientEnd, t.MenuStripGradientBegin,);

                g.FillRectangle(b, e.ClipRectangle);
                //}
            }
        }

        private void LogViewContainer_Panel2_Paint(object sender, PaintEventArgs e)
        {

            Panel p = sender as Panel;
            if (p != null)
            {

                ProfessionalColorTable t = new ProfessionalColorTable();

                t.UseSystemColors = guiProps.Get<bool>("useSystemColors").Value;
                Rectangle r = new Rectangle(e.ClipRectangle.Location, e.ClipRectangle.Size);

          

                if (p.Width > 0 && p.Height > 0)
                {
                    LinearGradientBrush b = new LinearGradientBrush( new Rectangle(Point.Empty,
                                        new Size(p.Width, p.Height)),
                                        t.MenuStripGradientEnd,
                                        t.MenuStripGradientBegin, LinearGradientMode.Vertical);


                    // LinearGradientBrush b = new LinearGradientBrush(rect, t.MenuStripGradientEnd, t.MenuStripGradientBegin, LinearGradientMode.Vertical);

                    //   LinearGradientBrush b = new LinearGradientBrush(Point.Empty, new Point(e.ClipRectangle.Width, 1), t.MenuStripGradientEnd, t.MenuStripGradientBegin,);

                    e.Graphics.FillRectangle(b, r);
                }
                //}
            }
        }

        //private void pictureBox4_Paint(object sender, PaintEventArgs e)
        //{

        //    ProfessionalColorTable t = new ProfessionalColorTable();

        //    t.UseSystemColors = guiProps.Get<bool>("useSystemColors").Value;

        //    SolidBrush b = new SolidBrush(t.MenuStripGradientBegin);
        //    e.Graphics.FillRectangle(b, e.ClipRectangle);
        //}

       

        //private void tableLayoutPanel2_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        //{
        //    ProfessionalColorTable t = new ProfessionalColorTable();

        //    t.UseSystemColors = guiProps.Get<bool>("useSystemColors").Value;

        //    SolidBrush b = new SolidBrush(t.MenuStripGradientBegin);
        //    e.Graphics.FillRectangle(b, e.ClipRectangle);
        //}

        //private void pictureBox4_Paint(object sender, PaintEventArgs e)
        //{

        //    ProfessionalColorTable t = new ProfessionalColorTable();

        //    t.UseSystemColors = guiProps.Get<bool>("useSystemColors").Value;

        //    SolidBrush b = new SolidBrush(t.MenuStripGradientBegin);
        //    e.Graphics.FillRectangle(b, e.ClipRectangle);
        //}


        //private void panel2_Paint(object sender, PaintEventArgs e)
        //{

        //    Panel p = sender as Panel;
        //    if (p != null)
        //    {

        //        ProfessionalColorTable t = new ProfessionalColorTable();

        //        t.UseSystemColors = guiProps.Get<bool>("useSystemColors").Value;

        //        ToolStripManager.Renderer = new ToolStripProfessionalRenderer(t);

        //        Rectangle rect = new Rectangle(Point.Empty, new Size(p.Width, p.Height));

        //        Graphics g = e.Graphics;

        //        //if (e.ClipRectangle.Height > 0 && e.ClipRectangle.Width > 0)
        //        //{
        //        LinearGradientBrush b = new LinearGradientBrush(rect, t.MenuStripGradientEnd, t.MenuStripGradientBegin, LinearGradientMode.Vertical);
        //        // LinearGradientBrush b = new LinearGradientBrush(rect, t.MenuStripGradientEnd, t.MenuStripGradientBegin, LinearGradientMode.Vertical);

        //        //   LinearGradientBrush b = new LinearGradientBrush(Point.Empty, new Point(e.ClipRectangle.Width, 1), t.MenuStripGradientEnd, t.MenuStripGradientBegin,);

        //        g.FillRectangle(b, e.ClipRectangle);
        //        //}
        //    }
        //}
      
    }
}
