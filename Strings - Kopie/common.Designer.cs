﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kenedia.Modules.Characters.Strings {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class common {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal common() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Kenedia.Modules.Characters.Strings.common", typeof(common).Assembly);
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
        ///   Looks up a localized string similar to activated.
        /// </summary>
        internal static string Activated {
            get {
                return ResourceManager.GetString("Activated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to deactivated.
        /// </summary>
        internal static string Deactivated {
            get {
                return ResourceManager.GetString("Deactivated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} {1} !.
        /// </summary>
        internal static string RunStateChange {
            get {
                return ResourceManager.GetString("RunStateChange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Show Corner Icon.
        /// </summary>
        internal static string ShowCorner_Name {
            get {
                return ResourceManager.GetString("ShowCorner_Name", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Show / Hide the Corner Icon of {0}..
        /// </summary>
        internal static string ShowCorner_Tooltip {
            get {
                return ResourceManager.GetString("ShowCorner_Tooltip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Toggle {0}.
        /// </summary>
        internal static string Toggle {
            get {
                return ResourceManager.GetString("Toggle", resourceCulture);
            }
        }
    }
}
