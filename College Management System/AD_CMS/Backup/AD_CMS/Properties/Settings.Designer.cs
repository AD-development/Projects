﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.8662
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AD_CMS.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
    public sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\MasterDatabase.mdf;Inte" +
            "grated Security=True;User Instance=True")]
        public string MasterDatabaseConnectionString {
            get {
                return ((string)(this["MasterDatabaseConnectionString"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("AD_CMS Softwares")]
        public string CollegeName {
            get {
                return ((string)(this["CollegeName"]));
            }
            set {
                this["CollegeName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("..\\..\\Resources\\small_logo.png")]
        public string CollegeIcon {
            get {
                return ((string)(this["CollegeIcon"]));
            }
            set {
                this["CollegeIcon"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Do The Best,Get The Best")]
        public string CollegeTagLine {
            get {
                return ((string)(this["CollegeTagLine"]));
            }
            set {
                this["CollegeTagLine"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string DeleteIconPath {
            get {
                return ((string)(this["DeleteIconPath"]));
            }
            set {
                this["DeleteIconPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("SeaShell")]
        public global::System.Drawing.Color MainFormBack {
            get {
                return ((global::System.Drawing.Color)(this["MainFormBack"]));
            }
            set {
                this["MainFormBack"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("White")]
        public global::System.Drawing.Color TemplateBack {
            get {
                return ((global::System.Drawing.Color)(this["TemplateBack"]));
            }
            set {
                this["TemplateBack"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("SeaShell")]
        public global::System.Drawing.Color d_MainFormBack {
            get {
                return ((global::System.Drawing.Color)(this["d_MainFormBack"]));
            }
            set {
                this["d_MainFormBack"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("White")]
        public global::System.Drawing.Color d_TemplateBack {
            get {
                return ((global::System.Drawing.Color)(this["d_TemplateBack"]));
            }
            set {
                this["d_TemplateBack"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("SkyBlue")]
        public global::System.Drawing.Color d_TemplateHeader {
            get {
                return ((global::System.Drawing.Color)(this["d_TemplateHeader"]));
            }
            set {
                this["d_TemplateHeader"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("SkyBlue")]
        public global::System.Drawing.Color TemplateHeaderBack {
            get {
                return ((global::System.Drawing.Color)(this["TemplateHeaderBack"]));
            }
            set {
                this["TemplateHeaderBack"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("..\\..\\Attendance\\")]
        public string AttendancePath {
            get {
                return ((string)(this["AttendancePath"]));
            }
            set {
                this["AttendancePath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int TotalClasses {
            get {
                return ((int)(this["TotalClasses"]));
            }
            set {
                this["TotalClasses"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int TotalLabs {
            get {
                return ((int)(this["TotalLabs"]));
            }
            set {
                this["TotalLabs"] = value;
            }
        }
    }
}