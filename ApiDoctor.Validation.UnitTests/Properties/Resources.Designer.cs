﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApiDoctor.Validation.UnitTests.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ApiDoctor.Validation.UnitTests.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to POST https://graph.microsoft.com/beta/accessReviews(&apos;2b83cc42-09db-46f6-8c6e-16fec466a82d&apos;)/reviewers
        ///Content-Type: application/json
        ///
        ///{
        ///    &quot;id&quot;:&quot;006111db-0810-4494-a6df-904d368bd81b&quot;
        ///}.
        /// </summary>
        internal static string ExampleRequest {
            get {
                return ResourceManager.GetString("ExampleRequest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ## Resource with ISO 8601 timestamp, URL, and enumerated values.
        ///
        ///&lt;!-- { &quot;blockType&quot;: &quot;resource&quot;, &quot;@odata.type&quot;: &quot;example.resource&quot; } --&gt;
        ///```json
        ///{
        ///	&quot;year&quot;: 1234,
        ///	&quot;downloadUrl&quot;: &quot;url&quot;,
        ///	&quot;createdDateTime&quot;: &quot;timestamp&quot;,
        ///	&quot;season&quot;: &quot;summer | fall | winter | spring&quot;,
        ///	&quot;ownerName&quot;: &quot;rgregg&quot;,
        ///	&quot;contentType&quot;: &quot;string&quot;
        ///}
        ///```
        ///
        ///### Properties
        ///
        ///| Name            | Type      | Description
        ///|:----------------|:----------|:--------------
        ///| year            | int       | the year
        ///| downloadUrl     | stri [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ExampleResources {
            get {
                return ResourceManager.GetString("ExampleResources", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;!-- { &quot;blockType&quot;: &quot;resource&quot;, &quot;@odata.type&quot;: &quot;test.simple&quot; } --&gt;
        ///```json
        ///{
        ///  &quot;prop1&quot;: &quot;testing&quot;,
        ///  &quot;prop2&quot;: &quot;simple&quot;,
        ///  &quot;prop3&quot;: &quot;waterbottle&quot;
        ///}
        ///```
        ///
        ///Here&apos;s an example where the server response should be verified against
        ///properties in the sample, even though we&apos;re truncating the results:
        ///
        ///&lt;!-- { &quot;blockType&quot;: &quot;request&quot;, &quot;name&quot;: &quot;simple-truncation-test&quot; } --&gt;
        ///```http
        ///GET /test_resource
        ///```
        ///
        ///Here&apos;s the expected response, as written in the documentation. No validation errors
        ///occur here becau [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ExampleValidateResponse {
            get {
                return ResourceManager.GetString("ExampleValidateResponse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;!-- { &quot;blockType&quot;: &quot;resource&quot;, &quot;@odata.type&quot;: &quot;oneDrive.item&quot; } --&gt;
        ///```json
        ///{
        ///	&quot;id&quot;: &quot;string&quot;,
        ///	&quot;lastModifiedDateTime&quot;: &quot;datetime&quot;,
        ///	&quot;name&quot;: &quot;string&quot;,
        ///	&quot;size&quot;: 218753122201,
        ///	&quot;webUrl&quot;: &quot;url&quot;,
        ///	&quot;children&quot;: [
        ///		{ &quot;@odata.type&quot;: &quot;oneDrive.item&quot; }
        ///	]
        ///}
        ///```
        ///
        ///&lt;!-- { &quot;blockType&quot;: &quot;request&quot;, &quot;name&quot;: &quot;drive-plus-children&quot; } --&gt;
        ///```http
        ///GET /drive/root?expand=children(select=id,name)
        ///```
        ///
        ///The request returns the collection items, with the children collection expanded.
        ///
        ///&lt;!-- { &quot;blockType&quot;: &quot;respo [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ExampleValidationSelectStatement {
            get {
                return ResourceManager.GetString("ExampleValidationSelectStatement", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;!-- { &quot;blockType&quot;: &quot;resource&quot;, &quot;@odata.type&quot;: &quot;oneDrive.item&quot; } --&gt;
        ///```json
        ///{
        ///	&quot;id&quot;: &quot;string&quot;,
        ///	&quot;lastModifiedDateTime&quot;: &quot;datetime&quot;,
        ///	&quot;name&quot;: &quot;string&quot;,
        ///	&quot;size&quot;: 218753122201,
        ///	&quot;webUrl&quot;: &quot;url&quot;,
        ///	&quot;children&quot;: [
        ///		{ &quot;@odata.type&quot;: &quot;oneDrive.item&quot; }
        ///	]
        ///}
        ///```
        ///
        ///&lt;!-- { &quot;blockType&quot;: &quot;request&quot;, &quot;name&quot;: &quot;drive-plus-children&quot; } --&gt;
        ///```http
        ///GET /drive/root?expand=children(select=id,name)
        ///```
        ///
        ///The request returns the collection items, with the children collection expanded.
        ///
        ///&lt;!-- { &quot;blockType&quot;: &quot;respo [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ExampleValidationSelectStatementFailure {
            get {
                return ResourceManager.GetString("ExampleValidationSelectStatementFailure", resourceCulture);
            }
        }
    }
}