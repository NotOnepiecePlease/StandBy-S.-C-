﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PFC___StandBy_CSharp.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.5.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=localhost\\sqlexpress;Initial Catalog=standby;Integrated Security=True" +
            "")]
        public string comboboxConnectstring {
            get {
                return ((string)(this["comboboxConnectstring"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Silver")]
        public global::System.Drawing.Color notepad_CorFundo {
            get {
                return ((global::System.Drawing.Color)(this["notepad_CorFundo"]));
            }
            set {
                this["notepad_CorFundo"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Segoe UI Semibold, 12pt, style=Bold")]
        public global::System.Drawing.Font notepad_FonteStyle {
            get {
                return ((global::System.Drawing.Font)(this["notepad_FonteStyle"]));
            }
            set {
                this["notepad_FonteStyle"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Black")]
        public global::System.Drawing.Color notepad_FonteColor {
            get {
                return ((global::System.Drawing.Color)(this["notepad_FonteColor"]));
            }
            set {
                this["notepad_FonteColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(".\\Anotacoes")]
        public string diretorio_default_notepad {
            get {
                return ((string)(this["diretorio_default_notepad"]));
            }
            set {
                this["diretorio_default_notepad"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(".\\NotaWord\\Cupom fiscal.docx")]
        public string diretorio_default_word {
            get {
                return ((string)(this["diretorio_default_word"]));
            }
            set {
                this["diretorio_default_word"] = value;
            }
        }
    }
}
