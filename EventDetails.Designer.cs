namespace FTH.Utils.LogViewer
{
    partial class EventDetails
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
            this.btnOK = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtThread = new System.Windows.Forms.TextBox();
            this.txtlogger = new System.Windows.Forms.TextBox();
            this.txtSeverity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLineNb = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(535, 366);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // txtMessage
            // 
            this.txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessage.Location = new System.Drawing.Point(8, 100);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ReadOnly = true;
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessage.Size = new System.Drawing.Size(583, 218);
            this.txtMessage.TabIndex = 1;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(92, 12);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(146, 20);
            this.txtDate.TabIndex = 2;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(92, 38);
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = true;
            this.txtTime.Size = new System.Drawing.Size(146, 20);
            this.txtTime.TabIndex = 2;
            // 
            // txtThread
            // 
            this.txtThread.Location = new System.Drawing.Point(351, 12);
            this.txtThread.Name = "txtThread";
            this.txtThread.ReadOnly = true;
            this.txtThread.Size = new System.Drawing.Size(229, 20);
            this.txtThread.TabIndex = 2;
            // 
            // txtlogger
            // 
            this.txtlogger.Location = new System.Drawing.Point(351, 38);
            this.txtlogger.Name = "txtlogger";
            this.txtlogger.ReadOnly = true;
            this.txtlogger.Size = new System.Drawing.Size(229, 20);
            this.txtlogger.TabIndex = 2;
            // 
            // txtSeverity
            // 
            this.txtSeverity.Location = new System.Drawing.Point(92, 64);
            this.txtSeverity.Name = "txtSeverity";
            this.txtSeverity.ReadOnly = true;
            this.txtSeverity.Size = new System.Drawing.Size(146, 20);
            this.txtSeverity.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Severity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Thread:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(263, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Logger Name:";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(6, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(608, 354);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtDate);
            this.tabPage1.Controls.Add(this.txtMessage);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtTime);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtSeverity);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtThread);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtLineNb);
            this.tabPage1.Controls.Add(this.txtlogger);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(600, 328);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Event";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(263, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Line # in file:";
            // 
            // txtLineNb
            // 
            this.txtLineNb.Location = new System.Drawing.Point(351, 64);
            this.txtLineNb.Name = "txtLineNb";
            this.txtLineNb.ReadOnly = true;
            this.txtLineNb.Size = new System.Drawing.Size(229, 20);
            this.txtLineNb.TabIndex = 2;
            // 
            // EventDetails
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 396);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnOK);
            this.MinimumSize = new System.Drawing.Size(625, 422);
            this.Name = "EventDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Event Details";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtThread;
        private System.Windows.Forms.TextBox txtlogger;
        private System.Windows.Forms.TextBox txtSeverity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLineNb;
    }
}