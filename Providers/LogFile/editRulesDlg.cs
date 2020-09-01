using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace FTH.Utils.LogViewer.Providers.LogFile
{
    public partial class editRulesDlg : Form
    {
        private int matchOccurence = 0;

        public editRulesDlg()
        {
            InitializeComponent();
           
        }

        private void loadParsingEx(ParsingExpressions expressions)
        {
            this.regExTime.Text = expressions.TimeStamp.Text;
            this.regExThread.Text = expressions.Thread.Text;
            this.regExSev.Text = expressions.Severity.Text;
            this.regExLogger.Text = expressions.Logger.Text;
            this.regExMsg.Text = expressions.Message.Text;
            this.regExLine.Text = expressions.Line.Text;
        }

        private ParsingExpressions saveParsingEx()
        {
            ParsingExpressions expressions = new ParsingExpressions(
                     this.regExTime.Text,
                     this.regExThread.Text,
                     this.regExSev.Text,
                     this.regExLogger.Text,
                     this.regExMsg.Text,
                     this.regExLine.Text);

            return expressions;
        }

        public bool RegExSetup(ref ParsingExpressions expressions)
        {
            this.loadParsingEx(expressions);

            if (this.ShowDialog() == DialogResult.OK)
            {
                expressions = this.saveParsingEx();
                return true;
            }

            return false;
        }


        private void hilite(Group g, Color c)
        {
            if (g.Success)
            {
                this.testTxtBox.Select(g.Index, g.Length);
                this.testTxtBox.SelectionBackColor = c;
            }

        }

        

        private void checkExpression(string regExStr)
        {
            try
            {
               checkExpression(new Regex(regExStr));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void checkExpression(Regex regEx)
        {
            this.testTxtBox.SelectAll();
            this.testTxtBox.SelectionBackColor = this.testTxtBox.BackColor;

            MatchCollection mc = regEx.Matches(testTxtBox.Text);

            if (mc.Count > 0)
            {
                if (matchOccurence > mc.Count-1)
                    matchOccurence = 0;
                    
                Match m = mc[matchOccurence];
                matchOccurence++;

                hilite(m.Groups["timeStamp"], Color.Gold);
                hilite(m.Groups["thread"], Color.Chartreuse);
                hilite(m.Groups["severity"], Color.Turquoise);
                hilite(m.Groups["logger"], Color.Thistle);
                hilite(m.Groups["message"], Color.Tan);
            }
        }

        private void btnTestExLine_Click(object sender, EventArgs e)
        {
            try
            {
                ParsingExpressions expressions = new ParsingExpressions(
                    this.regExTime.Text,
                    this.regExThread.Text,
                    this.regExSev.Text,
                    this.regExLogger.Text,
                    this.regExMsg.Text,
                    this.regExLine.Text);

                checkExpression(expressions.ParsingRegEx);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }


        private void btnTestExTime_Click(object sender, EventArgs e)
        {                    
            checkExpression(new ParsingExpression("timeStamp", this.regExTime.Text).Expression);
        }

        private void btnTestExThread_Click(object sender, EventArgs e)
        {
            checkExpression(new ParsingExpression("thread", this.regExThread.Text).Expression);
        }

        private void btnTestExSev_Click(object sender, EventArgs e)
        {
            checkExpression(new ParsingExpression("severity", this.regExSev.Text).Expression);
        }

        private void btnTestExLogger_Click(object sender, EventArgs e)
        {
            checkExpression(new ParsingExpression("logger", this.regExLogger.Text).Expression);
        }

        private void btnTestExMessage_Click(object sender, EventArgs e)
        {
            checkExpression(new ParsingExpression("message", this.regExMsg.Text).Expression);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = File.OpenText(this.openFileDialog1.FileName))
                {
                   this.loadParsingEx(ParsingExpressions.Deserialize(sr.ReadToEnd()));
                }
            }
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = File.CreateText(this.saveFileDialog1.FileName))
                {
                    sw.Write(this.saveParsingEx().Serialize());
                }
            }
        }


       

    }
}
