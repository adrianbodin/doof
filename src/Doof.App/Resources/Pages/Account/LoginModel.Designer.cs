﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Doof.App.Resources.Pages.Account {
    using System;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class LoginModel {
        
        private static System.Resources.ResourceManager resourceMan;
        
        private static System.Globalization.CultureInfo resourceCulture;
        
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal LoginModel() {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static System.Resources.ResourceManager ResourceManager {
            get {
                if (object.Equals(null, resourceMan)) {
                    System.Resources.ResourceManager temp = new System.Resources.ResourceManager("Doof.App.Resources.Pages.Account.LoginModel", typeof(LoginModel).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        internal static string invalid_login {
            get {
                return ResourceManager.GetString("invalid-login", resourceCulture);
            }
        }
        
        internal static string email_valid {
            get {
                return ResourceManager.GetString("email-valid", resourceCulture);
            }
        }
        
        internal static string email_required {
            get {
                return ResourceManager.GetString("email-required", resourceCulture);
            }
        }
        
        internal static string password_required {
            get {
                return ResourceManager.GetString("password-required", resourceCulture);
            }
        }
        
        internal static string password_valid {
            get {
                return ResourceManager.GetString("password-valid", resourceCulture);
            }
        }
    }
}