using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Text.RegularExpressions;


namespace FTH.Utils.LogViewer.Providers.LogFile
{

    public class ParsingExpression
    {       
        private string text;
        private string groupName;

        [XmlIgnore()]
        public string GroupName
        {
            get { return groupName; }
        }

        [XmlAttribute()]
        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        [XmlIgnore()]
        public string Expression
        {
            get 
            {
                if (string.IsNullOrEmpty(this.groupName))
                    return this.text;
                else
                    return string.Format("(?<{0}>{1})",groupName, text); 
            }
        }
        public ParsingExpression() : this(null) { }

        public ParsingExpression(string groupName) : this(groupName, string.Empty) { }
       
        public ParsingExpression(string groupName, string text)
        {
            this.text = text;
            this.groupName = groupName;
        }

    }
    
    public class ParsingExpressions
    {
        [XmlElement]
        public ParsingExpression TimeStamp = new ParsingExpression("timeStamp");
        [XmlElement]
        public ParsingExpression Thread = new ParsingExpression("thread");
        [XmlElement]
        public ParsingExpression Severity = new ParsingExpression("severity");
        [XmlElement]
        public ParsingExpression Logger = new ParsingExpression("logger");
        [XmlElement]
        public ParsingExpression Message = new ParsingExpression("message");
        [XmlElement]
        public ParsingExpression Line = new ParsingExpression();

        public ParsingExpressions()
        {

        }

        public ParsingExpressions(string time, string thread, string severity, string logger, string message, string line)
        {
            this.TimeStamp.Text = time;
            this.Thread.Text = thread;
            this.Severity.Text = severity;
            this.Logger.Text = logger;
            this.Message.Text = message;
            this.Line.Text = line;
        }

        [XmlIgnore]
        public Regex ParsingRegEx
        {
            get
            {
                string strRegExLine = Regex.Replace(this.Line.Expression, @"(?i)(\<time\>|\<thread\>|\<severity\>|\<logger\>|\<message\>)*", switchToken);
        
                //string strRegExLine = string.Format(
                //   this.Line.Expression,
                //   this.TimeStamp.Expression,
                //   this.Thread.Expression,
                //   this.Severity.Expression,
                //   this.Logger.Expression,
                //   this.Message.Expression);
               
                return new Regex(strRegExLine);
            }
        }
          

        private string switchToken(Match m)
        {           
            switch (m.Value.ToLower())
            {
                case "<time>":
                    return this.TimeStamp.Expression;

                case "<thread>":
                    return this.Thread.Expression;

                case "<severity>":
                    return this.Severity.Expression;

                case "<logger>":
                    return this.Logger.Expression;

                case "<message>":
                    return this.Message.Expression;               

                default:
                    return m.Value;                    
            }
        }

        public void LoadSettings()
        {
           this.TimeStamp.Text = Properties.Settings.Default.ParsingRegExTime;
           this.Thread.Text = Properties.Settings.Default.ParsingRegExThread;
           this.Severity.Text = Properties.Settings.Default.ParsingRegExSeverity;
           this.Logger.Text = Properties.Settings.Default.ParsingRegExLogger;
           this.Message.Text = Properties.Settings.Default.ParsingRegExMessage;
           this.Line.Text = Properties.Settings.Default.ParsingRegExLine;
        }

        public void SaveSettings()
        {
            Properties.Settings.Default.ParsingRegExTime = this.TimeStamp.Text;
            Properties.Settings.Default.ParsingRegExThread = this.Thread.Text;
            Properties.Settings.Default.ParsingRegExSeverity = this.Severity.Text;
            Properties.Settings.Default.ParsingRegExLogger = this.Logger.Text;
            Properties.Settings.Default.ParsingRegExMessage = this.Message.Text;
            Properties.Settings.Default.ParsingRegExLine = this.Line.Text;
        }

        public logEvent ParseLine(string line, int lineNumber)
        {
            logEvent l = new logEvent();
            l.LineNumber = lineNumber;

            Match m = this.ParsingRegEx.Match(line);

            if (!m.Groups["timeStamp"].Success || !DateTime.TryParse(m.Groups["timeStamp"].Value.Replace(',','.'), out l.TimeStamp))
                l.TimeStamp = DateTime.Today;

            if (m.Groups["thread"].Success)
                l.ThreadName = m.Groups["thread"].Value;
            else
                l.ThreadName = string.Empty;

            if (m.Groups["severity"].Success)
                l.Severity = m.Groups["severity"].Value.ToUpper();
            else
                l.Severity = "INFO";

            if (m.Groups["logger"].Success)
                l.LoggerName = m.Groups["logger"].Value;
            else
                l.LoggerName = string.Empty;

            if (m.Groups["message"].Success)
                l.Message = m.Groups["message"].Value;
            else
                l.Message = string.Empty;

            
            foreach (Group g in m.Groups)
                l.IsValid |= g.Success;


            return l;


        }

        public string Serialize()
        {           
            using (System.IO.StringWriter writer = new System.IO.StringWriter())
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ParsingExpressions));
                serializer.Serialize(writer, this);                

                return writer.ToString();
            }   

        }

        public static ParsingExpressions Deserialize(string xmlStr)
        {

            using (System.IO.TextReader reader = new System.IO.StringReader(xmlStr))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ParsingExpressions));
                return (ParsingExpressions)serializer.Deserialize(reader);
            }
        }

    }
}
