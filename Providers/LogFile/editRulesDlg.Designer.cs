namespace FTH.Utils.LogViewer.Providers.LogFile
{
    partial class editRulesDlg
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
            this.regExTime = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.regExThread = new System.Windows.Forms.TextBox();
            this.regExSev = new System.Windows.Forms.TextBox();
            this.regExLogger = new System.Windows.Forms.TextBox();
            this.regExMsg = new System.Windows.Forms.TextBox();
            this.regExLine = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTestExLine = new System.Windows.Forms.Button();
            this.btnTestExMessage = new System.Windows.Forms.Button();
            this.btnTestExLogger = new System.Windows.Forms.Button();
            this.btnTestExSev = new System.Windows.Forms.Button();
            this.btnTestExThread = new System.Windows.Forms.Button();
            this.btnTestExTime = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.testTxtBox = new System.Windows.Forms.RichTextBox();
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // regExTime
            // 
            this.regExTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.regExTime.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regExTime.Location = new System.Drawing.Point(156, 19);
            this.regExTime.Name = "regExTime";
            this.regExTime.Size = new System.Drawing.Size(467, 23);
            this.regExTime.TabIndex = 0;
            this.regExTime.Text = "\\d{4}\\-\\d{2}\\-\\d{2}\\s\\d{2}:\\d{2}:\\d{2}[\\.,]\\d{3}";
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(560, 411);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(641, 411);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // regExThread
            // 
            this.regExThread.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.regExThread.Font = new System.Drawing.Font("Consolas", 10F);
            this.regExThread.Location = new System.Drawing.Point(156, 48);
            this.regExThread.Name = "regExThread";
            this.regExThread.Size = new System.Drawing.Size(467, 23);
            this.regExThread.TabIndex = 0;
            // 
            // regExSev
            // 
            this.regExSev.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.regExSev.Font = new System.Drawing.Font("Consolas", 10F);
            this.regExSev.Location = new System.Drawing.Point(156, 77);
            this.regExSev.Name = "regExSev";
            this.regExSev.Size = new System.Drawing.Size(467, 23);
            this.regExSev.TabIndex = 0;
            // 
            // regExLogger
            // 
            this.regExLogger.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.regExLogger.Font = new System.Drawing.Font("Consolas", 10F);
            this.regExLogger.Location = new System.Drawing.Point(156, 106);
            this.regExLogger.Name = "regExLogger";
            this.regExLogger.Size = new System.Drawing.Size(467, 23);
            this.regExLogger.TabIndex = 0;
            // 
            // regExMsg
            // 
            this.regExMsg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.regExMsg.Font = new System.Drawing.Font("Consolas", 10F);
            this.regExMsg.Location = new System.Drawing.Point(156, 135);
            this.regExMsg.Name = "regExMsg";
            this.regExMsg.Size = new System.Drawing.Size(467, 23);
            this.regExMsg.TabIndex = 0;
            // 
            // regExLine
            // 
            this.regExLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.regExLine.Font = new System.Drawing.Font("Consolas", 10F);
            this.regExLine.Location = new System.Drawing.Point(156, 164);
            this.regExLine.Name = "regExLine";
            this.regExLine.Size = new System.Drawing.Size(467, 23);
            this.regExLine.TabIndex = 0;
            this.regExLine.Text = "{0}:\\s{1}\\s{2}\\s{3}\\s-\\s{4}";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnTestExLine);
            this.groupBox1.Controls.Add(this.btnTestExMessage);
            this.groupBox1.Controls.Add(this.btnTestExLogger);
            this.groupBox1.Controls.Add(this.btnTestExSev);
            this.groupBox1.Controls.Add(this.btnTestExThread);
            this.groupBox1.Controls.Add(this.btnTestExTime);
            this.groupBox1.Controls.Add(this.regExTime);
            this.groupBox1.Controls.Add(this.regExThread);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.regExSev);
            this.groupBox1.Controls.Add(this.regExLogger);
            this.groupBox1.Controls.Add(this.regExMsg);
            this.groupBox1.Controls.Add(this.regExLine);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 202);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parsing Regular Expressions";
            // 
            // btnTestExLine
            // 
            this.btnTestExLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTestExLine.Location = new System.Drawing.Point(629, 164);
            this.btnTestExLine.Name = "btnTestExLine";
            this.btnTestExLine.Size = new System.Drawing.Size(54, 23);
            this.btnTestExLine.TabIndex = 3;
            this.btnTestExLine.Text = "Check";
            this.btnTestExLine.UseVisualStyleBackColor = true;
            this.btnTestExLine.Click += new System.EventHandler(this.btnTestExLine_Click);
            // 
            // btnTestExMessage
            // 
            this.btnTestExMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTestExMessage.Location = new System.Drawing.Point(629, 135);
            this.btnTestExMessage.Name = "btnTestExMessage";
            this.btnTestExMessage.Size = new System.Drawing.Size(54, 23);
            this.btnTestExMessage.TabIndex = 3;
            this.btnTestExMessage.Text = "Check";
            this.btnTestExMessage.UseVisualStyleBackColor = true;
            this.btnTestExMessage.Click += new System.EventHandler(this.btnTestExMessage_Click);
            // 
            // btnTestExLogger
            // 
            this.btnTestExLogger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTestExLogger.Location = new System.Drawing.Point(629, 106);
            this.btnTestExLogger.Name = "btnTestExLogger";
            this.btnTestExLogger.Size = new System.Drawing.Size(54, 23);
            this.btnTestExLogger.TabIndex = 3;
            this.btnTestExLogger.Text = "Check";
            this.btnTestExLogger.UseVisualStyleBackColor = true;
            this.btnTestExLogger.Click += new System.EventHandler(this.btnTestExLogger_Click);
            // 
            // btnTestExSev
            // 
            this.btnTestExSev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTestExSev.Location = new System.Drawing.Point(629, 77);
            this.btnTestExSev.Name = "btnTestExSev";
            this.btnTestExSev.Size = new System.Drawing.Size(54, 23);
            this.btnTestExSev.TabIndex = 3;
            this.btnTestExSev.Text = "Check";
            this.btnTestExSev.UseVisualStyleBackColor = true;
            this.btnTestExSev.Click += new System.EventHandler(this.btnTestExSev_Click);
            // 
            // btnTestExThread
            // 
            this.btnTestExThread.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTestExThread.Location = new System.Drawing.Point(629, 48);
            this.btnTestExThread.Name = "btnTestExThread";
            this.btnTestExThread.Size = new System.Drawing.Size(54, 23);
            this.btnTestExThread.TabIndex = 3;
            this.btnTestExThread.Text = "Check";
            this.btnTestExThread.UseVisualStyleBackColor = true;
            this.btnTestExThread.Click += new System.EventHandler(this.btnTestExThread_Click);
            // 
            // btnTestExTime
            // 
            this.btnTestExTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTestExTime.Location = new System.Drawing.Point(629, 19);
            this.btnTestExTime.Name = "btnTestExTime";
            this.btnTestExTime.Size = new System.Drawing.Size(54, 23);
            this.btnTestExTime.TabIndex = 3;
            this.btnTestExTime.Text = "Check";
            this.btnTestExTime.UseVisualStyleBackColor = true;
            this.btnTestExTime.Click += new System.EventHandler(this.btnTestExTime_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Message expression:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Logger name expression:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Severity expression:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Thread name expression:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Timestamp expression:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 168);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Whole line expression:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(19, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Time";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Tan;
            this.label10.Location = new System.Drawing.Point(199, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Message";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Thistle;
            this.label9.Location = new System.Drawing.Point(153, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Logger";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Turquoise;
            this.label8.Location = new System.Drawing.Point(102, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Severity";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Chartreuse;
            this.label2.Location = new System.Drawing.Point(55, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thread";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.testTxtBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(12, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(700, 179);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Test";
            // 
            // testTxtBox
            // 
            this.testTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.testTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.testTxtBox.Location = new System.Drawing.Point(13, 21);
            this.testTxtBox.Name = "testTxtBox";
            this.testTxtBox.Size = new System.Drawing.Size(674, 129);
            this.testTxtBox.TabIndex = 3;
            this.testTxtBox.Text = "";
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveAs.Location = new System.Drawing.Point(93, 411);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(75, 23);
            this.btnSaveAs.TabIndex = 5;
            this.btnSaveAs.Text = "Save As";
            this.btnSaveAs.UseVisualStyleBackColor = true;
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOpen.Location = new System.Drawing.Point(12, 411);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 5;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "xml";
            this.openFileDialog1.FileName = "ParsingRules.xml";
            this.openFileDialog1.Filter = "Parsing rules settings|*.xml|All files|*.*";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "ParsingRules.xml";
            this.saveFileDialog1.Filter = "Parsing rules settings|*.xml|All files|*.*";
            // 
            // editRulesDlg
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(724, 446);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnSaveAs);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.MinimumSize = new System.Drawing.Size(732, 480);
            this.Name = "editRulesDlg";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Parsing Rules";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox regExTime;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox regExThread;
        private System.Windows.Forms.TextBox regExSev;
        private System.Windows.Forms.TextBox regExLogger;
        private System.Windows.Forms.TextBox regExMsg;
        private System.Windows.Forms.TextBox regExLine;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnTestExLine;
        private System.Windows.Forms.Button btnTestExMessage;
        private System.Windows.Forms.Button btnTestExLogger;
        private System.Windows.Forms.Button btnTestExSev;
        private System.Windows.Forms.Button btnTestExThread;
        private System.Windows.Forms.Button btnTestExTime;
        private System.Windows.Forms.RichTextBox testTxtBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSaveAs;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}