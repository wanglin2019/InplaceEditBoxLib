﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExplorerLib.Local {
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
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ExplorerLib.Local.Strings", typeof(Strings).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot access file : {0}..
        /// </summary>
        internal static string CantAccessFile_Error_Text {
            get {
                return ResourceManager.GetString("CantAccessFile_Error_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to All Files (*.*)|*.*.
        /// </summary>
        internal static string STR_FileType_FileFilter_AllFiles {
            get {
                return ResourceManager.GetString("STR_FileType_FileFilter_AllFiles", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to String Resource Files (*.resx)|*.resx.
        /// </summary>
        internal static string STR_FileType_FileFilter_resx {
            get {
                return ResourceManager.GetString("STR_FileType_FileFilter_resx", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An unexpected problem has occurred while saving the file..
        /// </summary>
        internal static string STR_MSG_ErrorSavingFile {
            get {
                return ResourceManager.GetString("STR_MSG_ErrorSavingFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error &apos;{0}&apos;\nhas occurred while saving a file..
        /// </summary>
        internal static string STR_MSG_ErrorWhileSavingAFile {
            get {
                return ResourceManager.GetString("STR_MSG_ErrorWhileSavingAFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error &apos;{0}&apos;\nhas occurred while saving the file\n:&apos;{1}&apos;.
        /// </summary>
        internal static string STR_MSG_ErrorWhileSavingFileX {
            get {
                return ResourceManager.GetString("STR_MSG_ErrorWhileSavingFileX", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unhandled Error.
        /// </summary>
        internal static string STR_MSG_UnknownError_Caption {
            get {
                return ResourceManager.GetString("STR_MSG_UnknownError_Caption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error in shut-down process..
        /// </summary>
        internal static string STR_MSG_UnknownError_InShutDownProcess {
            get {
                return ResourceManager.GetString("STR_MSG_UnknownError_InShutDownProcess", resourceCulture);
            }
        }
    }
}