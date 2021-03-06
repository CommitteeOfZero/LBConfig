﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LBConfig.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("LBConfig.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        /// </summary>
        public static System.Drawing.Icon AppIcon {
            get {
                object obj = ResourceManager.GetObject("AppIcon", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to %LOCALAPPDATA%\Committee of Zero\SGHD\config.json.
        /// </summary>
        public static string ConfigJsonPath {
            get {
                return ResourceManager.GetString("ConfigJsonPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error while trying to read configuration. Regenerating..
        /// </summary>
        public static string ConfigurationReadError {
            get {
                return ResourceManager.GetString("ConfigurationReadError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error trying to save configuration..
        /// </summary>
        public static string ConfigurationSaveError {
            get {
                return ResourceManager.GetString("ConfigurationSaveError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your configuration file is for an incompatible version of LanguageBarrier..
        /// </summary>
        public static string ConfigurationSchemaMismatchError {
            get {
                return ResourceManager.GetString("ConfigurationSchemaMismatchError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Discard changes and Exit.
        /// </summary>
        public static string DiscardExitLabel {
            get {
                return ResourceManager.GetString("DiscardExitLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Discard changes (reload config).
        /// </summary>
        public static string DiscardLabel {
            get {
                return ResourceManager.GetString("DiscardLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to to use this..
        /// </summary>
        public static string EnableJpVideoSubsLabelAfterLink {
            get {
                return ResourceManager.GetString("EnableJpVideoSubsLabelAfterLink", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enable subtitles for Japanese videos. You need to.
        /// </summary>
        public static string EnableJpVideoSubsLabelBeforeLink {
            get {
                return ResourceManager.GetString("EnableJpVideoSubsLabelBeforeLink", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to manually copy over the originals.
        /// </summary>
        public static string EnableJpVideoSubsLinkLabel {
            get {
                return ResourceManager.GetString("EnableJpVideoSubsLinkLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Uri similar to http://sonome.dareno.me/projects/sghd.html#jpvideo.
        /// </summary>
        public static System.Uri EnableJpVideoSubsUri {
            get {
                object obj = ResourceManager.GetObject("EnableJpVideoSubsUri", resourceCulture);
                return ((System.Uri)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enable karaoke subtitles..
        /// </summary>
        public static string EnableKaraokeSubsLabel {
            get {
                return ResourceManager.GetString("EnableKaraokeSubsLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use simple effects (for slow machines)..
        /// </summary>
        public static string EnableLqKaraokeSubsLabel {
            get {
                return ResourceManager.GetString("EnableLqKaraokeSubsLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Work around issue where game hangs at black screen when exiting while in fullscreen mode..
        /// </summary>
        public static string ExitBlackScreenFixLabel {
            get {
                return ResourceManager.GetString("ExitBlackScreenFixLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Fix various mistranslations in system text (menus etc.) - the visual novel itself remains untouched..
        /// </summary>
        public static string FixTranslationLabel {
            get {
                return ResourceManager.GetString("FixTranslationLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Video options.
        /// </summary>
        public static string FmvHeader {
            get {
                return ResourceManager.GetString("FmvHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to General options.
        /// </summary>
        public static string GeneralHeader {
            get {
                return ResourceManager.GetString("GeneralHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Improve typography and word-wrap phone text..
        /// </summary>
        public static string ImproveTextDisplayLabel {
            get {
                return ResourceManager.GetString("ImproveTextDisplayLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Replace low-quality (more heavily upscaled/compressed) translated images with edits of the high-quality Japanese originals..
        /// </summary>
        public static string ReplaceCGsLabel {
            get {
                return ResourceManager.GetString("ReplaceCGsLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to steam://run/412830.
        /// </summary>
        public static string RunGameUri {
            get {
                return ResourceManager.GetString("RunGameUri", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Save/Exit/Run Launcher.
        /// </summary>
        public static string SaveExitLabel {
            get {
                return ResourceManager.GetString("SaveExitLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Save changes.
        /// </summary>
        public static string SaveLabel {
            get {
                return ResourceManager.GetString("SaveLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Force bilinear texture filtering. This greatly improves visual quality during zoom-ins and at sub-1080p resolutions..
        /// </summary>
        public static string TextureFilteringLabel {
            get {
                return ResourceManager.GetString("TextureFilteringLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to For videos with music, play high-quality BGM instead of the included low-quality audio tracks..
        /// </summary>
        public static string UseHqAudioLabel {
            get {
                return ResourceManager.GetString("UseHqAudioLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to LanguageBarrier for STEINS;GATE - Version 1.00.
        /// </summary>
        public static string VersionLabel {
            get {
                return ResourceManager.GetString("VersionLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to LanguageBarrier Config.
        /// </summary>
        public static string WindowTitle {
            get {
                return ResourceManager.GetString("WindowTitle", resourceCulture);
            }
        }
    }
}
