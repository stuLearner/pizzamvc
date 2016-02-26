﻿using Pizza.Contracts.Security.ViewModels;

#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Pizza.Mvc;

    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Account/Login.cshtml")]
    public partial class _Views_Account_Login_cshtml : System.Web.Mvc.WebViewPage<LoginViewModel>
    {
        public _Views_Account_Login_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Account\Login.cshtml"
  
    ViewBag.Title = "Log in";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<h2>");

            
            #line 6 "..\..\Views\Account\Login.cshtml"
Write(ViewBag.Title);

            
            #line default
            #line hidden
WriteLiteral(".</h2>\r\n<div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"col-md-8\"");

WriteLiteral(">\r\n        <section");

WriteLiteral(" id=\"loginForm\"");

WriteLiteral(">\r\n");

            
            #line 10 "..\..\Views\Account\Login.cshtml"
            
            
            #line default
            #line hidden
            
            #line 10 "..\..\Views\Account\Login.cshtml"
             using (Html.BeginForm("Login", "Account", new { ReturnUrl = Request.QueryString["ReturnUrl"] }, FormMethod.Post, new { @class = "form-horizontal", role = "form" }))
            {
                
            
            #line default
            #line hidden
            
            #line 12 "..\..\Views\Account\Login.cshtml"
           Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 12 "..\..\Views\Account\Login.cshtml"
                                        

            
            #line default
            #line hidden
WriteLiteral("                <h4>Use a local account to log in.</h4>\r\n");

WriteLiteral("                <hr />\r\n");

            
            #line 15 "..\..\Views\Account\Login.cshtml"
                
            
            #line default
            #line hidden
            
            #line 15 "..\..\Views\Account\Login.cshtml"
           Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
            
            #line 15 "..\..\Views\Account\Login.cshtml"
                                                                                 

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 17 "..\..\Views\Account\Login.cshtml"
               Write(Html.LabelFor(m => m.UserName, new { @class = "col-md-2 control-label" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"col-md-10\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 19 "..\..\Views\Account\Login.cshtml"
                   Write(Html.TextBoxFor(m => m.UserName, new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                        ");

            
            #line 20 "..\..\Views\Account\Login.cshtml"
                   Write(Html.ValidationMessageFor(m => m.UserName, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");

WriteLiteral("                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 24 "..\..\Views\Account\Login.cshtml"
               Write(Html.LabelFor(m => m.Password, new { @class = "col-md-2 control-label" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"col-md-10\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 26 "..\..\Views\Account\Login.cshtml"
                   Write(Html.PasswordFor(m => m.Password, new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                        ");

            
            #line 27 "..\..\Views\Account\Login.cshtml"
                   Write(Html.ValidationMessageFor(m => m.Password, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");

WriteLiteral("                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"col-md-offset-2 col-md-10\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"checkbox\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 33 "..\..\Views\Account\Login.cshtml"
                       Write(Html.CheckBoxFor(m => m.RememberMe));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                            ");

            
            #line 34 "..\..\Views\Account\Login.cshtml"
                       Write(Html.LabelFor(m => m.RememberMe));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </d" +
"iv>\r\n");

WriteLiteral("                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"col-md-offset-2 col-md-10\"");

WriteLiteral(">\r\n                        <input");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" value=\"Log in\"");

WriteLiteral(" class=\"btn btn-default\"");

WriteLiteral(" />\r\n                    </div>\r\n                </div>\r\n");

WriteLiteral("                <p>\r\n");

WriteLiteral("                    ");

            
            #line 44 "..\..\Views\Account\Login.cshtml"
               Write(Html.ActionLink("Register as a new user", "Register"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </p>\r\n");

            
            #line 46 "..\..\Views\Account\Login.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </section>\r\n    </div>\r\n</div>\r\n\r\n");

DefineSection("Scripts", () => {

WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 52 "..\..\Views\Account\Login.cshtml"
Write(Scripts.Render("~/bundles/jqueryval"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

});

        }
    }
}
#pragma warning restore 1591
