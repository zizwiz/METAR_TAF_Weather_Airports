﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Metar_Taf_Viewer.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Metar_Taf_Viewer.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot; ?&gt;
        ///&lt;uk_airports&gt;
        ///	&lt;airport_info&gt;
        ///		&lt;icao_code&gt;EG74&lt;/icao_code&gt;
        ///		&lt;airport_name&gt;Bruntingthorpe Aerodrome&lt;/airport_name&gt;
        ///		&lt;latitude_deg&gt;52°29&apos;28&quot;N&lt;/latitude_deg&gt;
        ///		&lt;latitude_dec&gt;52.49111&lt;/latitude_dec&gt;
        ///		&lt;longitude_deg&gt;1°7&apos;56&quot;W&lt;/longitude_deg&gt;
        ///		&lt;longitude_dec&gt;-1.13222&lt;/longitude_dec&gt;
        ///		&lt;elevation_m&gt;139&lt;/elevation_m&gt;
        ///		&lt;elevation_ft&gt;456&lt;/elevation_ft&gt;
        ///	&lt;/airport_info&gt;
        ///	&lt;airport_info&gt;
        ///		&lt;icao_code&gt;EGAA&lt;/icao_code&gt;
        ///		&lt;airport_name&gt;Belfast International Airport [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string airport_data {
            get {
                return ResourceManager.GetString("airport_data", resourceCulture);
            }
        }
    }
}
