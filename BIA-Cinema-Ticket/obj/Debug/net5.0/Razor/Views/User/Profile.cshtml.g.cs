#pragma checksum "C:\Users\beyza\OneDrive\Masaüstü\BIA CINEMA TICKET DATABASE MANAGEMENT SYSTEM\BIA-Cinema-Ticket\BIA-Cinema-Ticket\Views\User\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb2ce7341ebf121f823b342086f4f150b150bd44"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Profile), @"mvc.1.0.view", @"/Views/User/Profile.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\beyza\OneDrive\Masaüstü\BIA CINEMA TICKET DATABASE MANAGEMENT SYSTEM\BIA-Cinema-Ticket\BIA-Cinema-Ticket\Views\_ViewImports.cshtml"
using BIA_Cinema_Ticket;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\beyza\OneDrive\Masaüstü\BIA CINEMA TICKET DATABASE MANAGEMENT SYSTEM\BIA-Cinema-Ticket\BIA-Cinema-Ticket\Views\_ViewImports.cshtml"
using BIA_Cinema_Ticket.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb2ce7341ebf121f823b342086f4f150b150bd44", @"/Views/User/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ae34280c174cbec5a0a3988b56fd2bc0bd852ee", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\beyza\OneDrive\Masaüstü\BIA CINEMA TICKET DATABASE MANAGEMENT SYSTEM\BIA-Cinema-Ticket\BIA-Cinema-Ticket\Views\User\Profile.cshtml"
  
    User user = BIA_Cinema_Ticket.Controllers.UserController.currentUser;

    Layout = "_User";

    DateTime date = user.birthday;
    string birthday = date.ToString("yyyy-MM-dd");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <div class=""row justify-content-center mt-5"">
        <div class=""col-xl-6"">
            <div class=""card mb-4"">
                <div class=""card-header"">
                    <i class=""far fa-address-card me-1""></i>
                    Profile
                </div>
                <div class=""card-body"">
                    <div class=""row"">
                        <div class=""col-6"">
                            <label><b>Name : </b></label>
                            <label>");
#nullable restore
#line 22 "C:\Users\beyza\OneDrive\Masaüstü\BIA CINEMA TICKET DATABASE MANAGEMENT SYSTEM\BIA-Cinema-Ticket\BIA-Cinema-Ticket\Views\User\Profile.cshtml"
                              Write(user.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        </div>\r\n                        <div class=\"col-6\">\r\n                            <label><b>Surname : </b></label>\r\n                            <label>");
#nullable restore
#line 26 "C:\Users\beyza\OneDrive\Masaüstü\BIA CINEMA TICKET DATABASE MANAGEMENT SYSTEM\BIA-Cinema-Ticket\BIA-Cinema-Ticket\Views\User\Profile.cshtml"
                              Write(user.surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        </div>\r\n                        <div class=\"col-6\">\r\n                            <label><b>Nickname : </b></label>\r\n                            <label>");
#nullable restore
#line 30 "C:\Users\beyza\OneDrive\Masaüstü\BIA CINEMA TICKET DATABASE MANAGEMENT SYSTEM\BIA-Cinema-Ticket\BIA-Cinema-Ticket\Views\User\Profile.cshtml"
                              Write(user.nickName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        </div>\r\n                        <div class=\"col-6\">\r\n                            <label><b>Gender : </b></label>\r\n");
#nullable restore
#line 34 "C:\Users\beyza\OneDrive\Masaüstü\BIA CINEMA TICKET DATABASE MANAGEMENT SYSTEM\BIA-Cinema-Ticket\BIA-Cinema-Ticket\Views\User\Profile.cshtml"
                             if (@user.gender == true)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <label>Male</label>\r\n");
#nullable restore
#line 37 "C:\Users\beyza\OneDrive\Masaüstü\BIA CINEMA TICKET DATABASE MANAGEMENT SYSTEM\BIA-Cinema-Ticket\BIA-Cinema-Ticket\Views\User\Profile.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <label>Female</label>\r\n");
#nullable restore
#line 41 "C:\Users\beyza\OneDrive\Masaüstü\BIA CINEMA TICKET DATABASE MANAGEMENT SYSTEM\BIA-Cinema-Ticket\BIA-Cinema-Ticket\Views\User\Profile.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                        <div class=\"col-6\">\r\n                            <label><b>Email : </b></label>\r\n                            <label>");
#nullable restore
#line 45 "C:\Users\beyza\OneDrive\Masaüstü\BIA CINEMA TICKET DATABASE MANAGEMENT SYSTEM\BIA-Cinema-Ticket\BIA-Cinema-Ticket\Views\User\Profile.cshtml"
                              Write(user.email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        </div>\r\n                        <div class=\"col-6\">\r\n                            <label><b>Phone : </b></label>\r\n                            <label>");
#nullable restore
#line 49 "C:\Users\beyza\OneDrive\Masaüstü\BIA CINEMA TICKET DATABASE MANAGEMENT SYSTEM\BIA-Cinema-Ticket\BIA-Cinema-Ticket\Views\User\Profile.cshtml"
                              Write(user.phoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        </div>\r\n                        <div class=\"col-6\">\r\n                            <label><b>Birthday : </b></label>\r\n                            <label>");
#nullable restore
#line 53 "C:\Users\beyza\OneDrive\Masaüstü\BIA CINEMA TICKET DATABASE MANAGEMENT SYSTEM\BIA-Cinema-Ticket\BIA-Cinema-Ticket\Views\User\Profile.cshtml"
                              Write(birthday);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
