﻿// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard.Common
// Author           : David McCarter
// Created          : 07-30-2020
//
// Last Modified By : David McCarter
// Last Modified On : 09-19-2020
// ***********************************************************************
// <copyright file="Resources.Designer.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace dotNetTips.Utility.Standard.Common
{


    /// <summary>
    /// A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;

        /// <summary>
        /// Initializes a new instance of the <see cref="Resources"/> class.
        /// </summary>
        /// TODO Edit XML Comment Template for #ctor
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }

        /// <summary>
        /// Returns the cached ResourceManager instance used by this class.
        /// </summary>
        /// <value>The resource manager.</value>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("dotNetTips.Utility.Standard.Common.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }

        /// <summary>
        /// Overrides the current thread's CurrentUICulture property for all
        /// resource lookups using this strongly typed resource class.
        /// </summary>
        /// <value>The culture.</value>
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
        /// Looks up a localized string similar to Argument is out of the given range..
        /// </summary>
        /// <value>The ex argument out of range.</value>
        internal static string ExArgumentOutOfRange {
            get {
                return ResourceManager.GetString("ExArgumentOutOfRange", resourceCulture);
            }
        }

        /// <summary>
        /// Looks up a localized string similar to Argument cannot be null..
        /// </summary>
        /// <value>The ex message argument null.</value>
        internal static string ExMessageArgumentNull {
            get {
                return ResourceManager.GetString("ExMessageArgumentNull", resourceCulture);
            }
        }

        /// <summary>
        /// Looks up a localized string similar to The specified directory was not found..
        /// </summary>
        /// <value>The ex message directory not found.</value>
        internal static string ExMessageDirectoryNotFound {
            get {
                return ResourceManager.GetString("ExMessageDirectoryNotFound", resourceCulture);
            }
        }

        /// <summary>
        /// Looks up a localized string similar to Invalid argument..
        /// </summary>
        /// <value>The ex message invalid argument.</value>
        internal static string ExMessageInvalidArgument {
            get {
                return ResourceManager.GetString("ExMessageInvalidArgument", resourceCulture);
            }
        }

        /// <summary>
        /// Looks up a localized string similar to Invalid operation..
        /// </summary>
        /// <value>The ex message invalid operation.</value>
        internal static string ExMessageInvalidOperation {
            get {
                return ResourceManager.GetString("ExMessageInvalidOperation", resourceCulture);
            }
        }

        /// <summary>
        /// Looks up a localized string similar to Exception cannot be null..
        /// </summary>
        /// <value>The ex message null exception.</value>
        internal static string ExMessageNullException {
            get {
                return ResourceManager.GetString("ExMessageNullException", resourceCulture);
            }
        }

        /// <summary>
        /// Looks up a localized string similar to Collection cannot be read-only..
        /// </summary>
        /// <value>The ex message readonly collection.</value>
        internal static string ExMessageReadonlyCollection {
            get {
                return ResourceManager.GetString("ExMessageReadonlyCollection", resourceCulture);
            }
        }

        /// <summary>
        /// Looks up a localized string similar to Go to dotNetTips.com for help..
        /// </summary>
        /// <value>The go to dot net tips COM for help.</value>
        internal static string GoToDotNetTipsComForHelp {
            get {
                return ResourceManager.GetString("GoToDotNetTipsComForHelp", resourceCulture);
            }
        }
    }
}
