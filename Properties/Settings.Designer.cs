﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SharpBMI.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("localhost")]
        public string server {
            get {
                return ((string)(this["server"]));
            }
            set {
                this["server"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("db_sharpbmi")]
        public string database {
            get {
                return ((string)(this["database"]));
            }
            set {
                this["database"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("root")]
        public string uid {
            get {
                return ((string)(this["uid"]));
            }
            set {
                this["uid"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("INSERT INTO {0}({1}) VALUES({2})")]
        public string SQL_INSERT {
            get {
                return ((string)(this["SQL_INSERT"]));
            }
            set {
                this["SQL_INSERT"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("BMI")]
        public string TABLE_BMI {
            get {
                return ((string)(this["TABLE_BMI"]));
            }
            set {
                this["TABLE_BMI"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Record added successfully")]
        public string SUCCESS_ADDED {
            get {
                return ((string)(this["SUCCESS_ADDED"]));
            }
            set {
                this["SUCCESS_ADDED"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Failed to add record. Please try again or contact the developer.")]
        public string FAILURE_ADD {
            get {
                return ((string)(this["FAILURE_ADD"]));
            }
            set {
                this["FAILURE_ADD"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Successfully exported!")]
        public string SUCCESS_EXPORTED {
            get {
                return ((string)(this["SUCCESS_EXPORTED"]));
            }
            set {
                this["SUCCESS_EXPORTED"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Failed to export the document. Please try again.")]
        public string FAILURE_EXPORTED {
            get {
                return ((string)(this["FAILURE_EXPORTED"]));
            }
            set {
                this["FAILURE_EXPORTED"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("PDF Document File(*.pdf) | *.pdf")]
        public string PDF_FILE_FILTER {
            get {
                return ((string)(this["PDF_FILE_FILTER"]));
            }
            set {
                this["PDF_FILE_FILTER"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("XML Document File(*.xml) | *.xml")]
        public string XML_FILE_FILTER {
            get {
                return ((string)(this["XML_FILE_FILTER"]));
            }
            set {
                this["XML_FILE_FILTER"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(".pdf")]
        public string PDF_EXTENSION {
            get {
                return ((string)(this["PDF_EXTENSION"]));
            }
            set {
                this["PDF_EXTENSION"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(".xml")]
        public string XML_EXTENSION {
            get {
                return ((string)(this["XML_EXTENSION"]));
            }
            set {
                this["XML_EXTENSION"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Please fill your height.")]
        public string EMPTY_HEIGHT {
            get {
                return ((string)(this["EMPTY_HEIGHT"]));
            }
            set {
                this["EMPTY_HEIGHT"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Please fill your weight.")]
        public string EMPTY_WEIGHT {
            get {
                return ((string)(this["EMPTY_WEIGHT"]));
            }
            set {
                this["EMPTY_WEIGHT"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Are you sure that you want to exit?")]
        public string CONFIRM_CLOSE_APPLICATION {
            get {
                return ((string)(this["CONFIRM_CLOSE_APPLICATION"]));
            }
            set {
                this["CONFIRM_CLOSE_APPLICATION"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("The record already exists")]
        public string ALREADY_EXISTS {
            get {
                return ((string)(this["ALREADY_EXISTS"]));
            }
            set {
                this["ALREADY_EXISTS"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Successfully connected to the Database")]
        public string SUCCESS_DATABASE_CONNECTION {
            get {
                return ((string)(this["SUCCESS_DATABASE_CONNECTION"]));
            }
            set {
                this["SUCCESS_DATABASE_CONNECTION"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Failed to connect to the Database.")]
        public string ERROR_DATABASE_CONNECTION {
            get {
                return ((string)(this["ERROR_DATABASE_CONNECTION"]));
            }
            set {
                this["ERROR_DATABASE_CONNECTION"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("MySQL Service started successfully!")]
        public string SUCCESS_MYSQL_START {
            get {
                return ((string)(this["SUCCESS_MYSQL_START"]));
            }
            set {
                this["SUCCESS_MYSQL_START"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("MySQL Service failed to start.")]
        public string FAILURE_MYSQL_START {
            get {
                return ((string)(this["FAILURE_MYSQL_START"]));
            }
            set {
                this["FAILURE_MYSQL_START"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("MySQL Service is not installed.")]
        public string UNINSTALLED_MYSQL_SERVICE {
            get {
                return ((string)(this["UNINSTALLED_MYSQL_SERVICE"]));
            }
            set {
                this["UNINSTALLED_MYSQL_SERVICE"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("MySQL57")]
        public string MYSQL_SERVICE_NAME {
            get {
                return ((string)(this["MYSQL_SERVICE_NAME"]));
            }
            set {
                this["MYSQL_SERVICE_NAME"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("user id=root;password=;server=localhost;database=db_sharpbmi")]
        public string db_sharpbmiConnectionString {
            get {
                return ((string)(this["db_sharpbmiConnectionString"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string password {
            get {
                return ((string)(this["password"]));
            }
            set {
                this["password"] = value;
            }
        }
    }
}
