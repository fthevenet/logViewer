﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FTH.Utils.LogViewer.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool showDebugEvents {
            get {
                return ((bool)(this["showDebugEvents"]));
            }
            set {
                this["showDebugEvents"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool showInfoEvents {
            get {
                return ((bool)(this["showInfoEvents"]));
            }
            set {
                this["showInfoEvents"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool showWarnEvents {
            get {
                return ((bool)(this["showWarnEvents"]));
            }
            set {
                this["showWarnEvents"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool showErrorEvents {
            get {
                return ((bool)(this["showErrorEvents"]));
            }
            set {
                this["showErrorEvents"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool showFatalEvents {
            get {
                return ((bool)(this["showFatalEvents"]));
            }
            set {
                this["showFatalEvents"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool applySeverityColors {
            get {
                return ((bool)(this["applySeverityColors"]));
            }
            set {
                this["applySeverityColors"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.StringCollection ThreadFilterHistory {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["ThreadFilterHistory"]));
            }
            set {
                this["ThreadFilterHistory"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.StringCollection LoggerFilterHistory {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["LoggerFilterHistory"]));
            }
            set {
                this["LoggerFilterHistory"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.StringCollection MessageFilterHistory {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["MessageFilterHistory"]));
            }
            set {
                this["MessageFilterHistory"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("234, 234, 234")]
        public global::System.Drawing.Color debugEventColor {
            get {
                return ((global::System.Drawing.Color)(this["debugEventColor"]));
            }
            set {
                this["debugEventColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("202, 255, 202")]
        public global::System.Drawing.Color infoEventColor {
            get {
                return ((global::System.Drawing.Color)(this["infoEventColor"]));
            }
            set {
                this["infoEventColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("253, 242, 170")]
        public global::System.Drawing.Color warnEventColor {
            get {
                return ((global::System.Drawing.Color)(this["warnEventColor"]));
            }
            set {
                this["warnEventColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("255, 128, 128")]
        public global::System.Drawing.Color errorEventColor {
            get {
                return ((global::System.Drawing.Color)(this["errorEventColor"]));
            }
            set {
                this["errorEventColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Red")]
        public global::System.Drawing.Color fatalEventColor {
            get {
                return ((global::System.Drawing.Color)(this["fatalEventColor"]));
            }
            set {
                this["fatalEventColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool useSystemColors {
            get {
                return ((bool)(this["useSystemColors"]));
            }
            set {
                this["useSystemColors"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("\\d{4}\\-\\d{2}\\-\\d{2}\\s\\d{2}:\\d{2}:\\d{2}[\\.,]\\d{3}")]
        public string ParsingRegExTime {
            get {
                return ((string)(this["ParsingRegExTime"]));
            }
            set {
                this["ParsingRegExTime"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("[\\w\\.-_]*")]
        public string ParsingRegExThread {
            get {
                return ((string)(this["ParsingRegExThread"]));
            }
            set {
                this["ParsingRegExThread"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("(?i)DEBUG|INFO|WARN|ERROR|FATAL")]
        public string ParsingRegExSeverity {
            get {
                return ((string)(this["ParsingRegExSeverity"]));
            }
            set {
                this["ParsingRegExSeverity"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("[\\w\\.-_]*")]
        public string ParsingRegExLogger {
            get {
                return ((string)(this["ParsingRegExLogger"]));
            }
            set {
                this["ParsingRegExLogger"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(".*")]
        public string ParsingRegExMessage {
            get {
                return ((string)(this["ParsingRegExMessage"]));
            }
            set {
                this["ParsingRegExMessage"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<time>\\s+\\[<thread>\\]\\s+<severity>\\s+<logger>\\s-\\s<message>")]
        public string ParsingRegExLine {
            get {
                return ((string)(this["ParsingRegExLine"]));
            }
            set {
                this["ParsingRegExLine"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool showLineColumn {
            get {
                return ((bool)(this["showLineColumn"]));
            }
            set {
                this["showLineColumn"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool showTimeColumn {
            get {
                return ((bool)(this["showTimeColumn"]));
            }
            set {
                this["showTimeColumn"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool showThreadColumn {
            get {
                return ((bool)(this["showThreadColumn"]));
            }
            set {
                this["showThreadColumn"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool showSeverityColumn {
            get {
                return ((bool)(this["showSeverityColumn"]));
            }
            set {
                this["showSeverityColumn"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool showLoggerColumn {
            get {
                return ((bool)(this["showLoggerColumn"]));
            }
            set {
                this["showLoggerColumn"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool showMessageColumn {
            get {
                return ((bool)(this["showMessageColumn"]));
            }
            set {
                this["showMessageColumn"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool showDetailsPane {
            get {
                return ((bool)(this["showDetailsPane"]));
            }
            set {
                this["showDetailsPane"] = value;
            }
        }
    }
}
