﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3082
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Nullstack.ClearCanvas.DevTools.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "8.0.0.0")]
    internal sealed partial class DebugToolConfigSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static DebugToolConfigSettings defaultInstance = ((DebugToolConfigSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new DebugToolConfigSettings())));
        
        public static DebugToolConfigSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string LogViewerAppPath {
            get {
                return ((string)(this["LogViewerAppPath"]));
            }
            set {
                this["LogViewerAppPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("4096")]
        public int LogWindowSize {
            get {
                return ((int)(this["LogWindowSize"]));
            }
            set {
                this["LogWindowSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5")]
        public int LogAdvanceLines {
            get {
                return ((int)(this["LogAdvanceLines"]));
            }
            set {
                this["LogAdvanceLines"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("4096")]
        public int LogTailSize {
            get {
                return ((int)(this["LogTailSize"]));
            }
            set {
                this["LogTailSize"] = value;
            }
        }
    }
}
