﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
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
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Pizza.Mvc;
    using Pizza.Mvc.HtmlHelpers;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_ErrorBox.cshtml")]
    public partial class _Views_Shared__ErrorBox_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared__ErrorBox_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div");

WriteLiteral(" id=\"errorDialog\"");

WriteLiteral(" class=\"modal fade\"");

WriteLiteral(" role=\"dialog\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"modal-dialog\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"modal-content panel-danger\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"modal-header panel-heading\"");

WriteLiteral(">\r\n                <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btnClose close\"");

WriteLiteral(" data-dismiss=\"modal\"");

WriteLiteral(">&times;</button>\r\n                <h4");

WriteLiteral(" class=\"modal-title\"");

WriteLiteral(">Application error</h4>\r\n            </div>\r\n            <div");

WriteLiteral(" id=\"errorText\"");

WriteLiteral(" class=\"modal-body fade in\"");

WriteLiteral(">\r\n                <p>Will be replaced by real error text.</p>\r\n            </div" +
">\r\n            <div");

WriteLiteral(" class=\"modal-footer\"");

WriteLiteral(">\r\n                <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btnClose btn btn-default\"");

WriteLiteral(">Close</button>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n\r\n<scr" +
"ipt");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">

    var showErrorWindow = function (text, reload) {

        $('#errorDialog').on('show.bs.modal', function () {
            var dialog = $('#errorDialog');

            dialog.find('#errorText').html(text);

            $('.btnClose').click(function () {
                if (reload) {
                    window.location.href = window.location.href;
                }

                dialog.modal('hide');
            });
        });

        $('#errorDialog').modal({ show: true });
    }

    $.ajaxSetup({
        error: function loadError(xhr, status, error) {
            showErrorWindow(xhr.responseText, true);
        }
    });

</script>

");

            
            #line 48 "..\..\Views\Shared\_ErrorBox.cshtml"
 if (TempData[ScriptKeys.Error] != null)
{

            
            #line default
            #line hidden
WriteLiteral("    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n        $(function () {\r\n            showErrorWindow(\"");

            
            #line 52 "..\..\Views\Shared\_ErrorBox.cshtml"
                         Write(TempData[ScriptKeys.Error]);

            
            #line default
            #line hidden
WriteLiteral("\", true);\r\n        });\r\n    </script>\r\n");

            
            #line 55 "..\..\Views\Shared\_ErrorBox.cshtml"
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
