﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CreateSizedFile.Properties {
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CreateSizedFile.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to &quot;{0}&quot; already exists. Do you want to overwrite?.
        /// </summary>
        internal static string ALREADY_EXISTS_DO_YOU_WANT_TO_OVERRIDE {
            get {
                return ResourceManager.GetString("ALREADY_EXISTS_DO_YOU_WANT_TO_OVERRIDE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you want to create a file with {0} bytes?.
        /// </summary>
        internal static string ARE_YOU_GOING_TO_CREATE {
            get {
                return ResourceManager.GetString("ARE_YOU_GOING_TO_CREATE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File size must not be minus..
        /// </summary>
        internal static string FILESIZE_NOTBE_MINUS {
            get {
                return ResourceManager.GetString("FILESIZE_NOTBE_MINUS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &quot;{0}&quot; does not exist..
        /// </summary>
        internal static string FOLDER_NOT_EXIST {
            get {
                return ResourceManager.GetString("FOLDER_NOT_EXIST", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No arguments..
        /// </summary>
        internal static string NO_ARGUMENTS {
            get {
                return ResourceManager.GetString("NO_ARGUMENTS", resourceCulture);
            }
        }
    }
}
