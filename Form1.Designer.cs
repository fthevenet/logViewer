namespace FTH.Utils.LogViewer
{
    partial class LogViewerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogViewerForm));
            this.dataGridView1 = new BuffedDataGridView();
            this.logLineNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logTimeStampDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logThreadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logSeverityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logLoggerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logMessageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSet1 = new System.Data.DataSet();
            this.LogData = new System.Data.DataTable();
            this.LogLineNumber = new System.Data.DataColumn();
            this.LogTimeStamp = new System.Data.DataColumn();
            this.LogThread = new System.Data.DataColumn();
            this.LogSeverity = new System.Data.DataColumn();
            this.LogLoggerName = new System.Data.DataColumn();
            this.LogMessage = new System.Data.DataColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsLabelTotalLines = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsLabelVisibleLines = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsLabelSelectedLines = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsLabelLoading = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.CancelButton = new System.Windows.Forms.ToolStripSplitButton();
            this.LogViewContainer = new System.Windows.Forms.SplitContainer();
            this.txtDetailsMessage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDetailsTime = new System.Windows.Forms.TextBox();
            this.txtDetailsThread = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDetailsSeverity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDetailsLogger = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RibbonPanel = new System.Windows.Forms.Panel();
            this.settingsRibbonPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ShowColumnsMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.lineNumberToolStripMenuItem = new FTH.Utils.LogViewer.CheckStateBoundToolStripMenuItem();
            this.timeStamptoolStripMenuItem = new FTH.Utils.LogViewer.CheckStateBoundToolStripMenuItem();
            this.threadToolStripMenuItem = new FTH.Utils.LogViewer.CheckStateBoundToolStripMenuItem();
            this.severityToolStripMenuItem = new FTH.Utils.LogViewer.CheckStateBoundToolStripMenuItem();
            this.loggerToolStripMenuItem = new FTH.Utils.LogViewer.CheckStateBoundToolStripMenuItem();
            this.messageToolStripMenuItem = new FTH.Utils.LogViewer.CheckStateBoundToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.eventDetailsPaneToolStripMenuItem = new FTH.Utils.LogViewer.CheckStateBoundToolStripMenuItem();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.setDebugEventsColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setInfoEventsColorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.setWarnEventsColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setErrorEventsColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setFatalEventsColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.colorEventsBySeverityToolStripMenuItem = new FTH.Utils.LogViewer.CheckStateBoundToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnResetSettings = new System.Windows.Forms.ToolStripButton();
            this.btnUseSystemColorTable = new FTH.Utils.LogViewer.CheckStateBoundToolStripButton();
            this.fileRibbonPanel = new System.Windows.Forms.Panel();
            this.fileToolStrip = new System.Windows.Forms.ToolStrip();
            this.tsBtnOpen = new System.Windows.Forms.ToolStripSplitButton();
            this.recentFilesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBtnClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnReload = new System.Windows.Forms.ToolStripButton();
            this.tsBtnWatch = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnExit = new System.Windows.Forms.ToolStripButton();
            this.viewRibbonPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.timeToolStrip = new System.Windows.Forms.ToolStrip();
            this.tsBtnFilerDateMax = new FTH.Utils.LogViewer.CheckStateBoundToolStripButton();
            this.tsDateTimeMax = new FTH.Utils.LogViewer.ToolStripDateTimePicker();
            this.tsBtnFilerDateMin = new FTH.Utils.LogViewer.CheckStateBoundToolStripButton();
            this.tsDateTimeMin = new FTH.Utils.LogViewer.ToolStripDateTimePicker();
            this.messageToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.tsTxtFilterMessage = new System.Windows.Forms.ToolStripComboBox();
            this.tsBtnFilterMessage = new FTH.Utils.LogViewer.CheckStateBoundToolStripButton();
            this.threadToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.tsTxtFilterThread = new System.Windows.Forms.ToolStripComboBox();
            this.tsBtnFilterThread = new FTH.Utils.LogViewer.CheckStateBoundToolStripButton();
            this.loggerToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tsTxtFilterLogger = new System.Windows.Forms.ToolStripComboBox();
            this.tsBtnFilterLogger = new FTH.Utils.LogViewer.CheckStateBoundToolStripButton();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tsBtnDebug = new FTH.Utils.LogViewer.CheckStateBoundToolStripButton();
            this.tsBtnInfo = new FTH.Utils.LogViewer.CheckStateBoundToolStripButton();
            this.tsBtnWarning = new FTH.Utils.LogViewer.CheckStateBoundToolStripButton();
            this.tsBtnError = new FTH.Utils.LogViewer.CheckStateBoundToolStripButton();
            this.tsBtnFatal = new FTH.Utils.LogViewer.CheckStateBoundToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MenuTabsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.RibbonBtnFile = new System.Windows.Forms.PictureBox();
            this.RibbonBtnView = new System.Windows.Forms.PictureBox();
            this.RibbonBtnSettings = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.loadFileWorker = new System.ComponentModel.BackgroundWorker();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openRecentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.watchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fatalEventsToolStripMenuItem = new FTH.Utils.LogViewer.CheckStateBoundToolStripMenuItem();
            this.errorEventsToolStripMenuItem = new FTH.Utils.LogViewer.CheckStateBoundToolStripMenuItem();
            this.warningEventsToolStripMenuItem = new FTH.Utils.LogViewer.CheckStateBoundToolStripMenuItem();
            this.infoEventsToolStripMenuItem = new FTH.Utils.LogViewer.CheckStateBoundToolStripMenuItem();
            this.debugEventsToolStripMenuItem = new FTH.Utils.LogViewer.CheckStateBoundToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogData)).BeginInit();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.LogViewContainer.Panel1.SuspendLayout();
            this.LogViewContainer.Panel2.SuspendLayout();
            this.LogViewContainer.SuspendLayout();
            this.RibbonPanel.SuspendLayout();
            this.settingsRibbonPanel.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.fileRibbonPanel.SuspendLayout();
            this.fileToolStrip.SuspendLayout();
            this.viewRibbonPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.timeToolStrip.SuspendLayout();
            this.messageToolStrip.SuspendLayout();
            this.threadToolStrip.SuspendLayout();
            this.loggerToolStrip.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.MenuTabsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RibbonBtnFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RibbonBtnView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RibbonBtnSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.logLineNumberDataGridViewTextBoxColumn,
            this.logTimeStampDataGridViewTextBoxColumn,
            this.logThreadDataGridViewTextBoxColumn,
            this.logSeverityDataGridViewTextBoxColumn,
            this.logLoggerNameDataGridViewTextBoxColumn,
            this.logMessageDataGridViewTextBoxColumn});
            this.dataGridView1.DataMember = "LogData";
            this.dataGridView1.DataSource = this.dataSet1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 18;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1074, 140);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView1_RowPrePaint);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // logLineNumberDataGridViewTextBoxColumn
            // 
            this.logLineNumberDataGridViewTextBoxColumn.DataPropertyName = "LogLineNumber";
            this.logLineNumberDataGridViewTextBoxColumn.HeaderText = "#";
            this.logLineNumberDataGridViewTextBoxColumn.Name = "logLineNumberDataGridViewTextBoxColumn";
            this.logLineNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.logLineNumberDataGridViewTextBoxColumn.Width = 53;
            // 
            // logTimeStampDataGridViewTextBoxColumn
            // 
            this.logTimeStampDataGridViewTextBoxColumn.DataPropertyName = "LogTimeStamp";
            dataGridViewCellStyle2.Format = "dd/MM/yyyy HH:mm:ss.fff";
            dataGridViewCellStyle2.NullValue = null;
            this.logTimeStampDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.logTimeStampDataGridViewTextBoxColumn.HeaderText = "Time";
            this.logTimeStampDataGridViewTextBoxColumn.Name = "logTimeStampDataGridViewTextBoxColumn";
            this.logTimeStampDataGridViewTextBoxColumn.ReadOnly = true;
            this.logTimeStampDataGridViewTextBoxColumn.Width = 166;
            // 
            // logThreadDataGridViewTextBoxColumn
            // 
            this.logThreadDataGridViewTextBoxColumn.DataPropertyName = "LogThread";
            this.logThreadDataGridViewTextBoxColumn.HeaderText = "Thread";
            this.logThreadDataGridViewTextBoxColumn.Name = "logThreadDataGridViewTextBoxColumn";
            this.logThreadDataGridViewTextBoxColumn.ReadOnly = true;
            this.logThreadDataGridViewTextBoxColumn.Width = 107;
            // 
            // logSeverityDataGridViewTextBoxColumn
            // 
            this.logSeverityDataGridViewTextBoxColumn.DataPropertyName = "LogSeverity";
            this.logSeverityDataGridViewTextBoxColumn.HeaderText = "Severity";
            this.logSeverityDataGridViewTextBoxColumn.Name = "logSeverityDataGridViewTextBoxColumn";
            this.logSeverityDataGridViewTextBoxColumn.ReadOnly = true;
            this.logSeverityDataGridViewTextBoxColumn.Width = 70;
            // 
            // logLoggerNameDataGridViewTextBoxColumn
            // 
            this.logLoggerNameDataGridViewTextBoxColumn.DataPropertyName = "LogLoggerName";
            this.logLoggerNameDataGridViewTextBoxColumn.HeaderText = "Logger";
            this.logLoggerNameDataGridViewTextBoxColumn.Name = "logLoggerNameDataGridViewTextBoxColumn";
            this.logLoggerNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.logLoggerNameDataGridViewTextBoxColumn.Width = 194;
            // 
            // logMessageDataGridViewTextBoxColumn
            // 
            this.logMessageDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.logMessageDataGridViewTextBoxColumn.DataPropertyName = "LogMessage";
            this.logMessageDataGridViewTextBoxColumn.HeaderText = "Message";
            this.logMessageDataGridViewTextBoxColumn.Name = "logMessageDataGridViewTextBoxColumn";
            this.logMessageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Locale = new System.Globalization.CultureInfo("");
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.LogData});
            // 
            // LogData
            // 
            this.LogData.Columns.AddRange(new System.Data.DataColumn[] {
            this.LogLineNumber,
            this.LogTimeStamp,
            this.LogThread,
            this.LogSeverity,
            this.LogLoggerName,
            this.LogMessage});
            this.LogData.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "LogLineNumber"}, true)});
            this.LogData.PrimaryKey = new System.Data.DataColumn[] {
        this.LogLineNumber};
            this.LogData.TableName = "LogData";
            // 
            // LogLineNumber
            // 
            this.LogLineNumber.AllowDBNull = false;
            this.LogLineNumber.AutoIncrement = true;
            this.LogLineNumber.Caption = "#";
            this.LogLineNumber.ColumnName = "LogLineNumber";
            this.LogLineNumber.DataType = typeof(int);
            this.LogLineNumber.ReadOnly = true;
            // 
            // LogTimeStamp
            // 
            this.LogTimeStamp.Caption = "Time";
            this.LogTimeStamp.ColumnName = "LogTimeStamp";
            this.LogTimeStamp.DataType = typeof(System.DateTime);
            this.LogTimeStamp.ReadOnly = true;
            // 
            // LogThread
            // 
            this.LogThread.Caption = "Thread";
            this.LogThread.ColumnName = "LogThread";
            this.LogThread.ReadOnly = true;
            // 
            // LogSeverity
            // 
            this.LogSeverity.Caption = "Severity";
            this.LogSeverity.ColumnName = "LogSeverity";
            this.LogSeverity.ReadOnly = true;
            // 
            // LogLoggerName
            // 
            this.LogLoggerName.Caption = "Logger";
            this.LogLoggerName.ColumnName = "LogLoggerName";
            this.LogLoggerName.ReadOnly = true;
            // 
            // LogMessage
            // 
            this.LogMessage.Caption = "Message";
            this.LogMessage.ColumnName = "LogMessage";
            this.LogMessage.ReadOnly = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.statusStrip1);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.LogViewContainer);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.RibbonPanel);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.panel1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1074, 492);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(1074, 539);
            this.toolStripContainer1.TabIndex = 3;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLabelTotalLines,
            this.tsLabelVisibleLines,
            this.tsLabelSelectedLines,
            this.tsLabelLoading,
            this.toolStripProgressBar1,
            this.CancelButton});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip1.Size = new System.Drawing.Size(1074, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // tsLabelTotalLines
            // 
            this.tsLabelTotalLines.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tsLabelTotalLines.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.tsLabelTotalLines.Name = "tsLabelTotalLines";
            this.tsLabelTotalLines.Size = new System.Drawing.Size(76, 17);
            this.tsLabelTotalLines.Text = "0 event in file";
            // 
            // tsLabelVisibleLines
            // 
            this.tsLabelVisibleLines.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tsLabelVisibleLines.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.tsLabelVisibleLines.Name = "tsLabelVisibleLines";
            this.tsLabelVisibleLines.Size = new System.Drawing.Size(82, 17);
            this.tsLabelVisibleLines.Text = "0 event shown";
            // 
            // tsLabelSelectedLines
            // 
            this.tsLabelSelectedLines.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tsLabelSelectedLines.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.tsLabelSelectedLines.Name = "tsLabelSelectedLines";
            this.tsLabelSelectedLines.Size = new System.Drawing.Size(91, 17);
            this.tsLabelSelectedLines.Text = "0 event selected";
            // 
            // tsLabelLoading
            // 
            this.tsLabelLoading.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tsLabelLoading.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.tsLabelLoading.Name = "tsLabelLoading";
            this.tsLabelLoading.Size = new System.Drawing.Size(67, 17);
            this.tsLabelLoading.Text = "Loading {0}";
            this.tsLabelLoading.Visible = false;
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar1.Visible = false;
            // 
            // CancelButton
            // 
            this.CancelButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CancelButton.Image = ((System.Drawing.Image)(resources.GetObject("CancelButton.Image")));
            this.CancelButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(55, 20);
            this.CancelButton.Text = "Cancel";
            this.CancelButton.Visible = false;
            this.CancelButton.ButtonClick += new System.EventHandler(this.CancelButton_ButtonClick);
            // 
            // LogViewContainer
            // 
            this.LogViewContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogViewContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.LogViewContainer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LogViewContainer.Location = new System.Drawing.Point(0, 226);
            this.LogViewContainer.MinimumSize = new System.Drawing.Size(0, 250);
            this.LogViewContainer.Name = "LogViewContainer";
            this.LogViewContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // LogViewContainer.Panel1
            // 
            this.LogViewContainer.Panel1.Controls.Add(this.dataGridView1);
            // 
            // LogViewContainer.Panel2
            // 
            this.LogViewContainer.Panel2.Controls.Add(this.txtDetailsMessage);
            this.LogViewContainer.Panel2.Controls.Add(this.label2);
            this.LogViewContainer.Panel2.Controls.Add(this.txtDetailsTime);
            this.LogViewContainer.Panel2.Controls.Add(this.txtDetailsThread);
            this.LogViewContainer.Panel2.Controls.Add(this.label1);
            this.LogViewContainer.Panel2.Controls.Add(this.txtDetailsSeverity);
            this.LogViewContainer.Panel2.Controls.Add(this.label3);
            this.LogViewContainer.Panel2.Controls.Add(this.txtDetailsLogger);
            this.LogViewContainer.Panel2.Controls.Add(this.label4);
            this.LogViewContainer.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.LogViewContainer_Panel2_Paint);
            this.LogViewContainer.Size = new System.Drawing.Size(1074, 266);
            this.LogViewContainer.SplitterDistance = 140;
            this.LogViewContainer.SplitterWidth = 1;
            this.LogViewContainer.TabIndex = 5;
            // 
            // txtDetailsMessage
            // 
            this.txtDetailsMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDetailsMessage.Location = new System.Drawing.Point(322, 5);
            this.txtDetailsMessage.Multiline = true;
            this.txtDetailsMessage.Name = "txtDetailsMessage";
            this.txtDetailsMessage.ReadOnly = true;
            this.txtDetailsMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDetailsMessage.Size = new System.Drawing.Size(746, 115);
            this.txtDetailsMessage.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(5, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Time:";
            // 
            // txtDetailsTime
            // 
            this.txtDetailsTime.Location = new System.Drawing.Point(72, 5);
            this.txtDetailsTime.Name = "txtDetailsTime";
            this.txtDetailsTime.ReadOnly = true;
            this.txtDetailsTime.Size = new System.Drawing.Size(244, 20);
            this.txtDetailsTime.TabIndex = 1;
            // 
            // txtDetailsThread
            // 
            this.txtDetailsThread.Location = new System.Drawing.Point(72, 31);
            this.txtDetailsThread.Name = "txtDetailsThread";
            this.txtDetailsThread.ReadOnly = true;
            this.txtDetailsThread.Size = new System.Drawing.Size(244, 20);
            this.txtDetailsThread.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(5, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thread:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDetailsSeverity
            // 
            this.txtDetailsSeverity.Location = new System.Drawing.Point(72, 57);
            this.txtDetailsSeverity.Name = "txtDetailsSeverity";
            this.txtDetailsSeverity.ReadOnly = true;
            this.txtDetailsSeverity.Size = new System.Drawing.Size(244, 20);
            this.txtDetailsSeverity.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(5, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Severity:";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDetailsLogger
            // 
            this.txtDetailsLogger.Location = new System.Drawing.Point(72, 83);
            this.txtDetailsLogger.Name = "txtDetailsLogger";
            this.txtDetailsLogger.ReadOnly = true;
            this.txtDetailsLogger.Size = new System.Drawing.Size(244, 20);
            this.txtDetailsLogger.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(5, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Logger:";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // RibbonPanel
            // 
            this.RibbonPanel.Controls.Add(this.settingsRibbonPanel);
            this.RibbonPanel.Controls.Add(this.fileRibbonPanel);
            this.RibbonPanel.Controls.Add(this.viewRibbonPanel);
            this.RibbonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.RibbonPanel.Location = new System.Drawing.Point(0, 25);
            this.RibbonPanel.Margin = new System.Windows.Forms.Padding(0);
            this.RibbonPanel.Name = "RibbonPanel";
            this.RibbonPanel.Size = new System.Drawing.Size(1074, 201);
            this.RibbonPanel.TabIndex = 2;
            // 
            // settingsRibbonPanel
            // 
            this.settingsRibbonPanel.Controls.Add(this.tableLayoutPanel3);
            this.settingsRibbonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsRibbonPanel.Location = new System.Drawing.Point(0, 130);
            this.settingsRibbonPanel.Name = "settingsRibbonPanel";
            this.settingsRibbonPanel.Size = new System.Drawing.Size(1074, 65);
            this.settingsRibbonPanel.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.toolStrip2, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1074, 65);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator3,
            this.ShowColumnsMenu,
            this.toolStripDropDownButton1,
            this.toolStripSeparator5,
            this.btnResetSettings,
            this.btnUseSystemColorTable});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1074, 65);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(96, 62);
            this.toolStripButton1.Text = "Edit Parsing Rules";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 65);
            // 
            // ShowColumnsMenu
            // 
            this.ShowColumnsMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ShowColumnsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lineNumberToolStripMenuItem,
            this.timeStamptoolStripMenuItem,
            this.threadToolStripMenuItem,
            this.severityToolStripMenuItem,
            this.loggerToolStripMenuItem,
            this.messageToolStripMenuItem,
            this.toolStripSeparator4,
            this.eventDetailsPaneToolStripMenuItem});
            this.ShowColumnsMenu.Image = ((System.Drawing.Image)(resources.GetObject("ShowColumnsMenu.Image")));
            this.ShowColumnsMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ShowColumnsMenu.Name = "ShowColumnsMenu";
            this.ShowColumnsMenu.Size = new System.Drawing.Size(89, 62);
            this.ShowColumnsMenu.Text = "Show Columns";
            // 
            // lineNumberToolStripMenuItem
            // 
            this.lineNumberToolStripMenuItem.Checked = true;
            this.lineNumberToolStripMenuItem.CheckOnClick = true;
            this.lineNumberToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lineNumberToolStripMenuItem.DontChangeText = false;
            this.lineNumberToolStripMenuItem.Name = "lineNumberToolStripMenuItem";
            this.lineNumberToolStripMenuItem.PropertySource = null;
            this.lineNumberToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.lineNumberToolStripMenuItem.Text = "Line number";
            this.lineNumberToolStripMenuItem.Click += new System.EventHandler(this.lineNumberToolStripMenuItem_Click);
            // 
            // timeStamptoolStripMenuItem
            // 
            this.timeStamptoolStripMenuItem.Checked = true;
            this.timeStamptoolStripMenuItem.CheckOnClick = true;
            this.timeStamptoolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.timeStamptoolStripMenuItem.DontChangeText = false;
            this.timeStamptoolStripMenuItem.Name = "timeStamptoolStripMenuItem";
            this.timeStamptoolStripMenuItem.PropertySource = null;
            this.timeStamptoolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.timeStamptoolStripMenuItem.Text = "Time Stamp";
            this.timeStamptoolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // threadToolStripMenuItem
            // 
            this.threadToolStripMenuItem.Checked = true;
            this.threadToolStripMenuItem.CheckOnClick = true;
            this.threadToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.threadToolStripMenuItem.DontChangeText = false;
            this.threadToolStripMenuItem.Name = "threadToolStripMenuItem";
            this.threadToolStripMenuItem.PropertySource = null;
            this.threadToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.threadToolStripMenuItem.Text = "Thread";
            this.threadToolStripMenuItem.Click += new System.EventHandler(this.threadToolStripMenuItem_Click);
            // 
            // severityToolStripMenuItem
            // 
            this.severityToolStripMenuItem.Checked = true;
            this.severityToolStripMenuItem.CheckOnClick = true;
            this.severityToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.severityToolStripMenuItem.DontChangeText = false;
            this.severityToolStripMenuItem.Name = "severityToolStripMenuItem";
            this.severityToolStripMenuItem.PropertySource = null;
            this.severityToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.severityToolStripMenuItem.Text = "Severity";
            this.severityToolStripMenuItem.Click += new System.EventHandler(this.severityToolStripMenuItem_Click);
            // 
            // loggerToolStripMenuItem
            // 
            this.loggerToolStripMenuItem.Checked = true;
            this.loggerToolStripMenuItem.CheckOnClick = true;
            this.loggerToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.loggerToolStripMenuItem.DontChangeText = false;
            this.loggerToolStripMenuItem.Name = "loggerToolStripMenuItem";
            this.loggerToolStripMenuItem.PropertySource = null;
            this.loggerToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.loggerToolStripMenuItem.Text = "Logger";
            this.loggerToolStripMenuItem.Click += new System.EventHandler(this.loggerToolStripMenuItem_Click);
            // 
            // messageToolStripMenuItem
            // 
            this.messageToolStripMenuItem.Checked = true;
            this.messageToolStripMenuItem.CheckOnClick = true;
            this.messageToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.messageToolStripMenuItem.DontChangeText = false;
            this.messageToolStripMenuItem.Name = "messageToolStripMenuItem";
            this.messageToolStripMenuItem.PropertySource = null;
            this.messageToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.messageToolStripMenuItem.Text = "Message";
            this.messageToolStripMenuItem.Click += new System.EventHandler(this.messageToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(161, 6);
            // 
            // eventDetailsPaneToolStripMenuItem
            // 
            this.eventDetailsPaneToolStripMenuItem.CheckOnClick = true;
            this.eventDetailsPaneToolStripMenuItem.DontChangeText = false;
            this.eventDetailsPaneToolStripMenuItem.Name = "eventDetailsPaneToolStripMenuItem";
            this.eventDetailsPaneToolStripMenuItem.PropertySource = null;
            this.eventDetailsPaneToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.eventDetailsPaneToolStripMenuItem.Text = "Event Details Pane";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setDebugEventsColorToolStripMenuItem,
            this.setInfoEventsColorToolStripMenuItem1,
            this.setWarnEventsColorToolStripMenuItem,
            this.setErrorEventsColorToolStripMenuItem,
            this.setFatalEventsColorToolStripMenuItem,
            this.toolStripMenuItem5,
            this.colorEventsBySeverityToolStripMenuItem});
            this.toolStripDropDownButton1.Image = global::FTH.Utils.LogViewer.Properties.Resources.colorBySev;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(116, 62);
            this.toolStripDropDownButton1.Text = "Set Events Color";
            // 
            // setDebugEventsColorToolStripMenuItem
            // 
            this.setDebugEventsColorToolStripMenuItem.Name = "setDebugEventsColorToolStripMenuItem";
            this.setDebugEventsColorToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.setDebugEventsColorToolStripMenuItem.Text = "Set Debug events color";
            this.setDebugEventsColorToolStripMenuItem.Click += new System.EventHandler(this.eventColorButtons_Click);
            // 
            // setInfoEventsColorToolStripMenuItem1
            // 
            this.setInfoEventsColorToolStripMenuItem1.Name = "setInfoEventsColorToolStripMenuItem1";
            this.setInfoEventsColorToolStripMenuItem1.Size = new System.Drawing.Size(192, 22);
            this.setInfoEventsColorToolStripMenuItem1.Text = "Set Info events color";
            this.setInfoEventsColorToolStripMenuItem1.Click += new System.EventHandler(this.eventColorButtons_Click);
            // 
            // setWarnEventsColorToolStripMenuItem
            // 
            this.setWarnEventsColorToolStripMenuItem.Name = "setWarnEventsColorToolStripMenuItem";
            this.setWarnEventsColorToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.setWarnEventsColorToolStripMenuItem.Text = "Set Warn events color";
            this.setWarnEventsColorToolStripMenuItem.Click += new System.EventHandler(this.eventColorButtons_Click);
            // 
            // setErrorEventsColorToolStripMenuItem
            // 
            this.setErrorEventsColorToolStripMenuItem.Name = "setErrorEventsColorToolStripMenuItem";
            this.setErrorEventsColorToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.setErrorEventsColorToolStripMenuItem.Text = "Set Error events color";
            this.setErrorEventsColorToolStripMenuItem.Click += new System.EventHandler(this.eventColorButtons_Click);
            // 
            // setFatalEventsColorToolStripMenuItem
            // 
            this.setFatalEventsColorToolStripMenuItem.Name = "setFatalEventsColorToolStripMenuItem";
            this.setFatalEventsColorToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.setFatalEventsColorToolStripMenuItem.Text = "Set Fatal events color";
            this.setFatalEventsColorToolStripMenuItem.Click += new System.EventHandler(this.eventColorButtons_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(189, 6);
            // 
            // colorEventsBySeverityToolStripMenuItem
            // 
            this.colorEventsBySeverityToolStripMenuItem.Checked = true;
            this.colorEventsBySeverityToolStripMenuItem.CheckOnClick = true;
            this.colorEventsBySeverityToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.colorEventsBySeverityToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.colorEventsBySeverityToolStripMenuItem.DontChangeText = false;
            this.colorEventsBySeverityToolStripMenuItem.Image = global::FTH.Utils.LogViewer.Properties.Resources.colorBySev;
            this.colorEventsBySeverityToolStripMenuItem.Name = "colorEventsBySeverityToolStripMenuItem";
            this.colorEventsBySeverityToolStripMenuItem.PropertySource = null;
            this.colorEventsBySeverityToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.colorEventsBySeverityToolStripMenuItem.Text = "Color events by severity";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 65);
            // 
            // btnResetSettings
            // 
            this.btnResetSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnResetSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnResetSettings.Image")));
            this.btnResetSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnResetSettings.Name = "btnResetSettings";
            this.btnResetSettings.Size = new System.Drawing.Size(95, 62);
            this.btnResetSettings.Text = "Reset All Settings";
            this.btnResetSettings.Click += new System.EventHandler(this.btnResetSettings_Click);
            // 
            // btnUseSystemColorTable
            // 
            this.btnUseSystemColorTable.CheckOnClick = true;
            this.btnUseSystemColorTable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUseSystemColorTable.Image = ((System.Drawing.Image)(resources.GetObject("btnUseSystemColorTable.Image")));
            this.btnUseSystemColorTable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUseSystemColorTable.Name = "btnUseSystemColorTable";
            this.btnUseSystemColorTable.PropertySource = null;
            this.btnUseSystemColorTable.Size = new System.Drawing.Size(23, 62);
            this.btnUseSystemColorTable.Text = "btnUseSystemColorTable";
            // 
            // fileRibbonPanel
            // 
            this.fileRibbonPanel.Controls.Add(this.fileToolStrip);
            this.fileRibbonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.fileRibbonPanel.Location = new System.Drawing.Point(0, 65);
            this.fileRibbonPanel.Name = "fileRibbonPanel";
            this.fileRibbonPanel.Size = new System.Drawing.Size(1074, 65);
            this.fileRibbonPanel.TabIndex = 1;
            // 
            // fileToolStrip
            // 
            this.fileToolStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.fileToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnOpen,
            this.tsBtnClose,
            this.toolStripSeparator2,
            this.tsBtnReload,
            this.tsBtnWatch,
            this.toolStripSeparator1,
            this.tsBtnExit});
            this.fileToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.fileToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fileToolStrip.Name = "fileToolStrip";
            this.fileToolStrip.Padding = new System.Windows.Forms.Padding(10, 5, 1, 0);
            this.fileToolStrip.Size = new System.Drawing.Size(1074, 65);
            this.fileToolStrip.Stretch = true;
            this.fileToolStrip.TabIndex = 1;
            // 
            // tsBtnOpen
            // 
            this.tsBtnOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recentFilesToolStripMenuItem1});
            this.tsBtnOpen.Image = global::FTH.Utils.LogViewer.Properties.Resources.fileOpen;
            this.tsBtnOpen.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsBtnOpen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnOpen.Name = "tsBtnOpen";
            this.tsBtnOpen.Size = new System.Drawing.Size(49, 49);
            this.tsBtnOpen.Text = "Open";
            this.tsBtnOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtnOpen.ButtonClick += new System.EventHandler(this.tsBtnOpen_Click);
            // 
            // recentFilesToolStripMenuItem1
            // 
            this.recentFilesToolStripMenuItem1.Name = "recentFilesToolStripMenuItem1";
            this.recentFilesToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.recentFilesToolStripMenuItem1.Text = "Recent Files";
            // 
            // tsBtnClose
            // 
            this.tsBtnClose.AutoSize = false;
            this.tsBtnClose.Image = global::FTH.Utils.LogViewer.Properties.Resources.fileClose;
            this.tsBtnClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnClose.Name = "tsBtnClose";
            this.tsBtnClose.Size = new System.Drawing.Size(49, 49);
            this.tsBtnClose.Text = "Close";
            this.tsBtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtnClose.Click += new System.EventHandler(this.tsBtnClose_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.AutoSize = false;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 50);
            // 
            // tsBtnReload
            // 
            this.tsBtnReload.AutoSize = false;
            this.tsBtnReload.Image = global::FTH.Utils.LogViewer.Properties.Resources.refresh;
            this.tsBtnReload.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnReload.Name = "tsBtnReload";
            this.tsBtnReload.Size = new System.Drawing.Size(49, 49);
            this.tsBtnReload.Text = "Reload";
            this.tsBtnReload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtnReload.Click += new System.EventHandler(this.tsBtnReload_Click);
            // 
            // tsBtnWatch
            // 
            this.tsBtnWatch.AutoSize = false;
            this.tsBtnWatch.Image = global::FTH.Utils.LogViewer.Properties.Resources.watch;
            this.tsBtnWatch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnWatch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnWatch.Name = "tsBtnWatch";
            this.tsBtnWatch.Size = new System.Drawing.Size(49, 49);
            this.tsBtnWatch.Text = "Watch";
            this.tsBtnWatch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtnWatch.ToolTipText = "Watch";
            this.tsBtnWatch.Click += new System.EventHandler(this.tsBtnTail_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.AutoSize = false;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 50);
            // 
            // tsBtnExit
            // 
            this.tsBtnExit.AutoSize = false;
            this.tsBtnExit.Image = global::FTH.Utils.LogViewer.Properties.Resources.exit;
            this.tsBtnExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnExit.Name = "tsBtnExit";
            this.tsBtnExit.Size = new System.Drawing.Size(49, 49);
            this.tsBtnExit.Text = "Exit";
            this.tsBtnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtnExit.Click += new System.EventHandler(this.tsBtnExit_Click);
            // 
            // viewRibbonPanel
            // 
            this.viewRibbonPanel.BackColor = System.Drawing.SystemColors.Control;
            this.viewRibbonPanel.Controls.Add(this.tableLayoutPanel1);
            this.viewRibbonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.viewRibbonPanel.Location = new System.Drawing.Point(0, 0);
            this.viewRibbonPanel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.viewRibbonPanel.Name = "viewRibbonPanel";
            this.viewRibbonPanel.Size = new System.Drawing.Size(1074, 65);
            this.viewRibbonPanel.TabIndex = 3;
            this.viewRibbonPanel.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 195F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 230F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 134F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 230F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 230F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel1.Controls.Add(this.timeToolStrip, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.messageToolStrip, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.threadToolStrip, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.loggerToolStrip, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.toolStrip3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 5, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1074, 65);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // timeToolStrip
            // 
            this.timeToolStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnFilerDateMax,
            this.tsDateTimeMax,
            this.tsBtnFilerDateMin,
            this.tsDateTimeMin});
            this.timeToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.timeToolStrip.Location = new System.Drawing.Point(0, 0);
            this.timeToolStrip.Name = "timeToolStrip";
            this.timeToolStrip.Padding = new System.Windows.Forms.Padding(10, 5, 1, 0);
            this.timeToolStrip.Size = new System.Drawing.Size(195, 65);
            this.timeToolStrip.TabIndex = 7;
            this.timeToolStrip.Text = "toolStrip3";
            // 
            // tsBtnFilerDateMax
            // 
            this.tsBtnFilerDateMax.CheckOnClick = true;
            this.tsBtnFilerDateMax.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnFilerDateMax.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnFilerDateMax.Image")));
            this.tsBtnFilerDateMax.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnFilerDateMax.Name = "tsBtnFilerDateMax";
            this.tsBtnFilerDateMax.PropertySource = null;
            this.tsBtnFilerDateMax.Size = new System.Drawing.Size(23, 20);
            this.tsBtnFilerDateMax.Text = "Max date:";
            // 
            // tsDateTimeMax
            // 
            this.tsDateTimeMax.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.tsDateTimeMax.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tsDateTimeMax.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.tsDateTimeMax.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.tsDateTimeMax.Name = "tsDateTimeMax";
            this.tsDateTimeMax.Size = new System.Drawing.Size(140, 21);
            this.tsDateTimeMax.Text = "12/01/2011 00:00:00";
            this.tsDateTimeMax.Value = new System.DateTime(2011, 1, 12, 0, 0, 0, 0);
            // 
            // tsBtnFilerDateMin
            // 
            this.tsBtnFilerDateMin.CheckOnClick = true;
            this.tsBtnFilerDateMin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnFilerDateMin.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnFilerDateMin.Image")));
            this.tsBtnFilerDateMin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnFilerDateMin.Name = "tsBtnFilerDateMin";
            this.tsBtnFilerDateMin.PropertySource = null;
            this.tsBtnFilerDateMin.Size = new System.Drawing.Size(23, 20);
            this.tsBtnFilerDateMin.Text = "Min date:";
            // 
            // tsDateTimeMin
            // 
            this.tsDateTimeMin.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.tsDateTimeMin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tsDateTimeMin.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.tsDateTimeMin.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.tsDateTimeMin.Name = "tsDateTimeMin";
            this.tsDateTimeMin.Size = new System.Drawing.Size(140, 21);
            this.tsDateTimeMin.Text = "12/01/2011 18:03:53";
            this.tsDateTimeMin.Value = new System.DateTime(2011, 1, 12, 18, 3, 53, 671);
            // 
            // messageToolStrip
            // 
            this.messageToolStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel3,
            this.tsTxtFilterMessage,
            this.tsBtnFilterMessage});
            this.messageToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.messageToolStrip.Location = new System.Drawing.Point(789, 0);
            this.messageToolStrip.Name = "messageToolStrip";
            this.messageToolStrip.Padding = new System.Windows.Forms.Padding(10, 5, 1, 0);
            this.messageToolStrip.Size = new System.Drawing.Size(230, 65);
            this.messageToolStrip.TabIndex = 11;
            this.messageToolStrip.Text = "toolStrip3";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Margin = new System.Windows.Forms.Padding(0, 1, 0, 5);
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(99, 13);
            this.toolStripLabel3.Text = "Filter on \"Message\"";
            // 
            // tsTxtFilterMessage
            // 
            this.tsTxtFilterMessage.Name = "tsTxtFilterMessage";
            this.tsTxtFilterMessage.Size = new System.Drawing.Size(180, 21);
            // 
            // tsBtnFilterMessage
            // 
            this.tsBtnFilterMessage.CheckOnClick = true;
            this.tsBtnFilterMessage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnFilterMessage.Image = global::FTH.Utils.LogViewer.Properties.Resources.icoFilter;
            this.tsBtnFilterMessage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnFilterMessage.Name = "tsBtnFilterMessage";
            this.tsBtnFilterMessage.PropertySource = null;
            this.tsBtnFilterMessage.Size = new System.Drawing.Size(23, 20);
            this.tsBtnFilterMessage.Text = "Filter \"Message\":";
            // 
            // threadToolStrip
            // 
            this.threadToolStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.threadToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel4,
            this.tsTxtFilterThread,
            this.tsBtnFilterThread});
            this.threadToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.threadToolStrip.Location = new System.Drawing.Point(195, 0);
            this.threadToolStrip.Name = "threadToolStrip";
            this.threadToolStrip.Padding = new System.Windows.Forms.Padding(10, 5, 1, 0);
            this.threadToolStrip.Size = new System.Drawing.Size(230, 65);
            this.threadToolStrip.TabIndex = 9;
            this.threadToolStrip.Text = "toolStrip3";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Margin = new System.Windows.Forms.Padding(0, 1, 0, 5);
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(87, 13);
            this.toolStripLabel4.Text = "Filter on Thread:";
            // 
            // tsTxtFilterThread
            // 
            this.tsTxtFilterThread.Name = "tsTxtFilterThread";
            this.tsTxtFilterThread.Size = new System.Drawing.Size(180, 21);
            // 
            // tsBtnFilterThread
            // 
            this.tsBtnFilterThread.CheckOnClick = true;
            this.tsBtnFilterThread.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnFilterThread.Image = global::FTH.Utils.LogViewer.Properties.Resources.icoFilter;
            this.tsBtnFilterThread.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnFilterThread.Name = "tsBtnFilterThread";
            this.tsBtnFilterThread.PropertySource = null;
            this.tsBtnFilterThread.Size = new System.Drawing.Size(23, 20);
            this.tsBtnFilterThread.Text = "Filter \"Thread\":";
            // 
            // loggerToolStrip
            // 
            this.loggerToolStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loggerToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.loggerToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.tsTxtFilterLogger,
            this.tsBtnFilterLogger});
            this.loggerToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.loggerToolStrip.Location = new System.Drawing.Point(559, 0);
            this.loggerToolStrip.Name = "loggerToolStrip";
            this.loggerToolStrip.Padding = new System.Windows.Forms.Padding(10, 5, 1, 0);
            this.loggerToolStrip.Size = new System.Drawing.Size(230, 65);
            this.loggerToolStrip.TabIndex = 4;
            this.loggerToolStrip.Text = "toolStrip5";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Margin = new System.Windows.Forms.Padding(0, 1, 0, 5);
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(120, 13);
            this.toolStripLabel2.Text = "Filter on \"Logger Name\"";
            // 
            // tsTxtFilterLogger
            // 
            this.tsTxtFilterLogger.Name = "tsTxtFilterLogger";
            this.tsTxtFilterLogger.Size = new System.Drawing.Size(180, 21);
            // 
            // tsBtnFilterLogger
            // 
            this.tsBtnFilterLogger.CheckOnClick = true;
            this.tsBtnFilterLogger.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnFilterLogger.Image = global::FTH.Utils.LogViewer.Properties.Resources.icoFilter;
            this.tsBtnFilterLogger.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnFilterLogger.Name = "tsBtnFilterLogger";
            this.tsBtnFilterLogger.PropertySource = null;
            this.tsBtnFilterLogger.Size = new System.Drawing.Size(23, 20);
            this.tsBtnFilterLogger.Text = "Filter \"Logger\":";
            // 
            // toolStrip3
            // 
            this.toolStrip3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.tsBtnDebug,
            this.tsBtnInfo,
            this.tsBtnWarning,
            this.tsBtnError,
            this.tsBtnFatal});
            this.toolStrip3.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip3.Location = new System.Drawing.Point(425, 0);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Padding = new System.Windows.Forms.Padding(10, 5, 1, 0);
            this.toolStrip3.Size = new System.Drawing.Size(134, 65);
            this.toolStrip3.TabIndex = 12;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Margin = new System.Windows.Forms.Padding(0, 1, 0, 5);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(129, 13);
            this.toolStripLabel1.Text = "Filter on Severity:            ";
            // 
            // tsBtnDebug
            // 
            this.tsBtnDebug.Checked = true;
            this.tsBtnDebug.CheckOnClick = true;
            this.tsBtnDebug.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsBtnDebug.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnDebug.Image = global::FTH.Utils.LogViewer.Properties.Resources.SevDebug;
            this.tsBtnDebug.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.tsBtnDebug.Name = "tsBtnDebug";
            this.tsBtnDebug.PropertySource = null;
            this.tsBtnDebug.Size = new System.Drawing.Size(23, 20);
            this.tsBtnDebug.Text = "Debug";
            // 
            // tsBtnInfo
            // 
            this.tsBtnInfo.Checked = true;
            this.tsBtnInfo.CheckOnClick = true;
            this.tsBtnInfo.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.tsBtnInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnInfo.Image = global::FTH.Utils.LogViewer.Properties.Resources.SevInfo;
            this.tsBtnInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnInfo.Name = "tsBtnInfo";
            this.tsBtnInfo.PropertySource = null;
            this.tsBtnInfo.Size = new System.Drawing.Size(23, 20);
            this.tsBtnInfo.Text = "Info";
            // 
            // tsBtnWarning
            // 
            this.tsBtnWarning.Checked = true;
            this.tsBtnWarning.CheckOnClick = true;
            this.tsBtnWarning.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsBtnWarning.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnWarning.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnWarning.Image")));
            this.tsBtnWarning.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnWarning.Name = "tsBtnWarning";
            this.tsBtnWarning.PropertySource = null;
            this.tsBtnWarning.Size = new System.Drawing.Size(23, 20);
            this.tsBtnWarning.Text = "Warning";
            // 
            // tsBtnError
            // 
            this.tsBtnError.Checked = true;
            this.tsBtnError.CheckOnClick = true;
            this.tsBtnError.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsBtnError.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnError.Image = global::FTH.Utils.LogViewer.Properties.Resources.SevError;
            this.tsBtnError.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnError.Name = "tsBtnError";
            this.tsBtnError.PropertySource = null;
            this.tsBtnError.Size = new System.Drawing.Size(23, 20);
            this.tsBtnError.Text = "Error";
            // 
            // tsBtnFatal
            // 
            this.tsBtnFatal.Checked = true;
            this.tsBtnFatal.CheckOnClick = true;
            this.tsBtnFatal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsBtnFatal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnFatal.Image = global::FTH.Utils.LogViewer.Properties.Resources.SevFatal;
            this.tsBtnFatal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnFatal.Name = "tsBtnFatal";
            this.tsBtnFatal.PropertySource = null;
            this.tsBtnFatal.Size = new System.Drawing.Size(23, 20);
            this.tsBtnFatal.Text = "Fatal";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Location = new System.Drawing.Point(1019, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(63, 65);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.MenuTabsPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1074, 25);
            this.panel1.TabIndex = 3;
            // 
            // MenuTabsPanel
            // 
            this.MenuTabsPanel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.MenuTabsPanel.ColumnCount = 4;
            this.MenuTabsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.MenuTabsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.MenuTabsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.MenuTabsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MenuTabsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MenuTabsPanel.Controls.Add(this.RibbonBtnFile, 0, 0);
            this.MenuTabsPanel.Controls.Add(this.RibbonBtnView, 1, 0);
            this.MenuTabsPanel.Controls.Add(this.RibbonBtnSettings, 2, 0);
            this.MenuTabsPanel.Controls.Add(this.pictureBox4, 3, 0);
            this.MenuTabsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuTabsPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuTabsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MenuTabsPanel.Name = "MenuTabsPanel";
            this.MenuTabsPanel.RowCount = 1;
            this.MenuTabsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.MenuTabsPanel.Size = new System.Drawing.Size(1074, 25);
            this.MenuTabsPanel.TabIndex = 0;
            // 
            // RibbonBtnFile
            // 
            this.RibbonBtnFile.BackgroundImage = global::FTH.Utils.LogViewer.Properties.Resources.RibbonTabActive;
            this.RibbonBtnFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RibbonBtnFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RibbonBtnFile.Image = global::FTH.Utils.LogViewer.Properties.Resources.fileText;
            this.RibbonBtnFile.Location = new System.Drawing.Point(0, 0);
            this.RibbonBtnFile.Margin = new System.Windows.Forms.Padding(0);
            this.RibbonBtnFile.Name = "RibbonBtnFile";
            this.RibbonBtnFile.Size = new System.Drawing.Size(55, 25);
            this.RibbonBtnFile.TabIndex = 0;
            this.RibbonBtnFile.TabStop = false;
            this.RibbonBtnFile.Click += new System.EventHandler(this.RibbonBtn_Click);
            this.RibbonBtnFile.MouseEnter += new System.EventHandler(this.RibbonBtn_MouseEnter);
            this.RibbonBtnFile.MouseLeave += new System.EventHandler(this.RibbonBtn_MouseLeave);
            // 
            // RibbonBtnView
            // 
            this.RibbonBtnView.BackgroundImage = global::FTH.Utils.LogViewer.Properties.Resources.RibbonTabNone;
            this.RibbonBtnView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RibbonBtnView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RibbonBtnView.Image = global::FTH.Utils.LogViewer.Properties.Resources.viewText;
            this.RibbonBtnView.Location = new System.Drawing.Point(55, 0);
            this.RibbonBtnView.Margin = new System.Windows.Forms.Padding(0);
            this.RibbonBtnView.Name = "RibbonBtnView";
            this.RibbonBtnView.Size = new System.Drawing.Size(55, 25);
            this.RibbonBtnView.TabIndex = 0;
            this.RibbonBtnView.TabStop = false;
            this.RibbonBtnView.Click += new System.EventHandler(this.RibbonBtn_Click);
            this.RibbonBtnView.MouseEnter += new System.EventHandler(this.RibbonBtn_MouseEnter);
            this.RibbonBtnView.MouseLeave += new System.EventHandler(this.RibbonBtn_MouseLeave);
            // 
            // RibbonBtnSettings
            // 
            this.RibbonBtnSettings.BackgroundImage = global::FTH.Utils.LogViewer.Properties.Resources.RibbonTabNone;
            this.RibbonBtnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RibbonBtnSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RibbonBtnSettings.Image = global::FTH.Utils.LogViewer.Properties.Resources.settingsText;
            this.RibbonBtnSettings.Location = new System.Drawing.Point(110, 0);
            this.RibbonBtnSettings.Margin = new System.Windows.Forms.Padding(0);
            this.RibbonBtnSettings.Name = "RibbonBtnSettings";
            this.RibbonBtnSettings.Size = new System.Drawing.Size(55, 25);
            this.RibbonBtnSettings.TabIndex = 0;
            this.RibbonBtnSettings.TabStop = false;
            this.RibbonBtnSettings.Click += new System.EventHandler(this.RibbonBtn_Click);
            this.RibbonBtnSettings.MouseEnter += new System.EventHandler(this.RibbonBtn_MouseEnter);
            this.RibbonBtnSettings.MouseLeave += new System.EventHandler(this.RibbonBtn_MouseLeave);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::FTH.Utils.LogViewer.Properties.Resources.RibbonTabNone;
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox4.Location = new System.Drawing.Point(165, 0);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(909, 25);
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.DoubleClick += new System.EventHandler(this.pictureBox4_DoubleClick);
            // 
            // loadFileWorker
            // 
            this.loadFileWorker.WorkerReportsProgress = true;
            this.loadFileWorker.WorkerSupportsCancellation = true;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.NotifyFilter = System.IO.NotifyFilters.LastWrite;
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.openRecentToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.toolStripMenuItem1,
            this.refreshToolStripMenuItem,
            this.watchToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::FTH.Utils.LogViewer.Properties.Resources.icoOpen;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // openRecentToolStripMenuItem
            // 
            this.openRecentToolStripMenuItem.Name = "openRecentToolStripMenuItem";
            this.openRecentToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.openRecentToolStripMenuItem.Text = "Open Recent";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Image = global::FTH.Utils.LogViewer.Properties.Resources.icoClose;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(134, 6);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Image = global::FTH.Utils.LogViewer.Properties.Resources.icoRefresh;
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.refreshToolStripMenuItem.Text = "Reload";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // watchToolStripMenuItem
            // 
            this.watchToolStripMenuItem.Image = global::FTH.Utils.LogViewer.Properties.Resources.icoWatch;
            this.watchToolStripMenuItem.Name = "watchToolStripMenuItem";
            this.watchToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.watchToolStripMenuItem.Text = "Watch";
            this.watchToolStripMenuItem.Click += new System.EventHandler(this.tsBtnTail_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(134, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fatalEventsToolStripMenuItem,
            this.errorEventsToolStripMenuItem,
            this.warningEventsToolStripMenuItem,
            this.infoEventsToolStripMenuItem,
            this.debugEventsToolStripMenuItem,
            this.toolStripMenuItem3});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // fatalEventsToolStripMenuItem
            // 
            this.fatalEventsToolStripMenuItem.Checked = true;
            this.fatalEventsToolStripMenuItem.CheckOnClick = true;
            this.fatalEventsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fatalEventsToolStripMenuItem.DontChangeText = false;
            this.fatalEventsToolStripMenuItem.Image = global::FTH.Utils.LogViewer.Properties.Resources.SevFatal;
            this.fatalEventsToolStripMenuItem.Name = "fatalEventsToolStripMenuItem";
            this.fatalEventsToolStripMenuItem.PropertySource = null;
            this.fatalEventsToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.fatalEventsToolStripMenuItem.Text = "Show \"Fatal\" events";
            // 
            // errorEventsToolStripMenuItem
            // 
            this.errorEventsToolStripMenuItem.Checked = true;
            this.errorEventsToolStripMenuItem.CheckOnClick = true;
            this.errorEventsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.errorEventsToolStripMenuItem.DontChangeText = false;
            this.errorEventsToolStripMenuItem.Image = global::FTH.Utils.LogViewer.Properties.Resources.SevError;
            this.errorEventsToolStripMenuItem.Name = "errorEventsToolStripMenuItem";
            this.errorEventsToolStripMenuItem.PropertySource = null;
            this.errorEventsToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.errorEventsToolStripMenuItem.Text = "Show \"Error\" events";
            // 
            // warningEventsToolStripMenuItem
            // 
            this.warningEventsToolStripMenuItem.Checked = true;
            this.warningEventsToolStripMenuItem.CheckOnClick = true;
            this.warningEventsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.warningEventsToolStripMenuItem.DontChangeText = false;
            this.warningEventsToolStripMenuItem.Image = global::FTH.Utils.LogViewer.Properties.Resources.SevWarning;
            this.warningEventsToolStripMenuItem.Name = "warningEventsToolStripMenuItem";
            this.warningEventsToolStripMenuItem.PropertySource = null;
            this.warningEventsToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.warningEventsToolStripMenuItem.Text = "Show \"Warn\" events";
            // 
            // infoEventsToolStripMenuItem
            // 
            this.infoEventsToolStripMenuItem.Checked = true;
            this.infoEventsToolStripMenuItem.CheckOnClick = true;
            this.infoEventsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.infoEventsToolStripMenuItem.DontChangeText = false;
            this.infoEventsToolStripMenuItem.Image = global::FTH.Utils.LogViewer.Properties.Resources.SevInfo;
            this.infoEventsToolStripMenuItem.Name = "infoEventsToolStripMenuItem";
            this.infoEventsToolStripMenuItem.PropertySource = null;
            this.infoEventsToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.infoEventsToolStripMenuItem.Text = "Show \"Info\" events";
            // 
            // debugEventsToolStripMenuItem
            // 
            this.debugEventsToolStripMenuItem.Checked = true;
            this.debugEventsToolStripMenuItem.CheckOnClick = true;
            this.debugEventsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.debugEventsToolStripMenuItem.DontChangeText = false;
            this.debugEventsToolStripMenuItem.Image = global::FTH.Utils.LogViewer.Properties.Resources.SevDebug;
            this.debugEventsToolStripMenuItem.Name = "debugEventsToolStripMenuItem";
            this.debugEventsToolStripMenuItem.PropertySource = null;
            this.debugEventsToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.debugEventsToolStripMenuItem.Text = "Show \"Debug\" events";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(175, 6);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.CheckOnClick = true;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowDrop = true;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.toolStripMenuItem4});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1074, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Checked = true;
            this.toolStripMenuItem4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(113, 20);
            this.toolStripMenuItem4.Text = "toolStripMenuItem4";
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            this.colorDialog1.FullOpen = true;
            // 
            // LogViewerForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 539);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LogViewerForm";
            this.Text = "LogViewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LogViewerForm_FormClosing);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.LogViewerForm_DragDrop);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LogViewerForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogData)).EndInit();
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.LogViewContainer.Panel1.ResumeLayout(false);
            this.LogViewContainer.Panel2.ResumeLayout(false);
            this.LogViewContainer.Panel2.PerformLayout();
            this.LogViewContainer.ResumeLayout(false);
            this.RibbonPanel.ResumeLayout(false);
            this.settingsRibbonPanel.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.fileRibbonPanel.ResumeLayout(false);
            this.fileRibbonPanel.PerformLayout();
            this.fileToolStrip.ResumeLayout(false);
            this.fileToolStrip.PerformLayout();
            this.viewRibbonPanel.ResumeLayout(false);
            this.viewRibbonPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.timeToolStrip.ResumeLayout(false);
            this.timeToolStrip.PerformLayout();
            this.messageToolStrip.ResumeLayout(false);
            this.messageToolStrip.PerformLayout();
            this.threadToolStrip.ResumeLayout(false);
            this.threadToolStrip.PerformLayout();
            this.loggerToolStrip.ResumeLayout(false);
            this.loggerToolStrip.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.MenuTabsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RibbonBtnFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RibbonBtnView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RibbonBtnSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BuffedDataGridView dataGridView1;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Data.DataTable LogData;
        private System.Data.DataColumn LogLineNumber;
        private System.Data.DataColumn LogTimeStamp;
        private System.Data.DataColumn LogThread;
        private System.Data.DataColumn LogSeverity;
        private System.Data.DataColumn LogLoggerName;
        private System.Data.DataColumn LogMessage;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.ComponentModel.BackgroundWorker loadFileWorker;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.ToolStripStatusLabel tsLabelTotalLines;
        private System.Windows.Forms.ToolStripStatusLabel tsLabelVisibleLines;
        private System.Windows.Forms.ToolStripStatusLabel tsLabelSelectedLines;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripSplitButton CancelButton;
        private System.Windows.Forms.ToolStripStatusLabel tsLabelLoading;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip loggerToolStrip;
        private System.Windows.Forms.ToolStrip messageToolStrip;
        private System.Windows.Forms.ToolStrip threadToolStrip;
        private System.Windows.Forms.ToolStrip timeToolStrip;
        private CheckStateBoundToolStripButton tsBtnFilterMessage;
        private System.Windows.Forms.ToolStripComboBox tsTxtFilterMessage;
        private CheckStateBoundToolStripButton tsBtnFilterThread;
        private System.Windows.Forms.ToolStripComboBox tsTxtFilterThread;
        private CheckStateBoundToolStripButton tsBtnFilterLogger;
        private System.Windows.Forms.ToolStripComboBox tsTxtFilterLogger;
        private ToolStripDateTimePicker tsDateTimeMax;
        private CheckStateBoundToolStripButton tsBtnFilerDateMax;
        private ToolStripDateTimePicker tsDateTimeMin;
        private CheckStateBoundToolStripButton tsBtnFilerDateMin;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private CheckStateBoundToolStripButton tsBtnDebug;
        private CheckStateBoundToolStripButton tsBtnInfo;
        private CheckStateBoundToolStripButton tsBtnWarning;
        private CheckStateBoundToolStripButton tsBtnError;
        private CheckStateBoundToolStripButton tsBtnFatal;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openRecentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem watchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private CheckStateBoundToolStripMenuItem fatalEventsToolStripMenuItem;
        private CheckStateBoundToolStripMenuItem errorEventsToolStripMenuItem;
        private CheckStateBoundToolStripMenuItem warningEventsToolStripMenuItem;
        private CheckStateBoundToolStripMenuItem infoEventsToolStripMenuItem;
        private CheckStateBoundToolStripMenuItem debugEventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Panel viewRibbonPanel;
        private System.Windows.Forms.Panel RibbonPanel;
        private System.Windows.Forms.Panel fileRibbonPanel;
        private System.Windows.Forms.ToolStrip fileToolStrip;
        private System.Windows.Forms.ToolStripButton tsBtnClose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsBtnReload;
        private System.Windows.Forms.ToolStripButton tsBtnWatch;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSplitButton tsBtnOpen;
        private System.Windows.Forms.ToolStripMenuItem recentFilesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsBtnExit;
        private System.Windows.Forms.TableLayoutPanel MenuTabsPanel;
        private System.Windows.Forms.PictureBox RibbonBtnFile;
        private System.Windows.Forms.PictureBox RibbonBtnView;
        private System.Windows.Forms.PictureBox RibbonBtnSettings;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel settingsRibbonPanel;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripDropDownButton ShowColumnsMenu;
        private CheckStateBoundToolStripMenuItem lineNumberToolStripMenuItem;
        private CheckStateBoundToolStripMenuItem timeStamptoolStripMenuItem;
        private CheckStateBoundToolStripMenuItem threadToolStripMenuItem;
        private CheckStateBoundToolStripMenuItem severityToolStripMenuItem;
        private CheckStateBoundToolStripMenuItem loggerToolStripMenuItem;
        private CheckStateBoundToolStripMenuItem messageToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn logLineNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logTimeStampDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logThreadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logSeverityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logLoggerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logMessageDataGridViewTextBoxColumn;
        private System.Windows.Forms.SplitContainer LogViewContainer;
        private System.Windows.Forms.TextBox txtDetailsMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDetailsLogger;
        private System.Windows.Forms.TextBox txtDetailsSeverity;
        private System.Windows.Forms.TextBox txtDetailsThread;
        private System.Windows.Forms.TextBox txtDetailsTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private CheckStateBoundToolStripMenuItem eventDetailsPaneToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btnResetSettings;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem setDebugEventsColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setInfoEventsColorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem setWarnEventsColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setErrorEventsColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setFatalEventsColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private CheckStateBoundToolStripMenuItem colorEventsBySeverityToolStripMenuItem;
        private CheckStateBoundToolStripButton btnUseSystemColorTable;
        private System.Windows.Forms.Label label2;


    }
}

