#pragma checksum "C:\Users\beyza\OneDrive\Masaüstü\BIA CINEMA TICKET DATABASE MANAGEMENT SYSTEM\BIA-Cinema-Ticket\BIA-Cinema-Ticket\Views\Ticket\ChooseSeat.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "564fbbe91d82db0e7f455919c1bbf70d8741b446"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ticket_ChooseSeat), @"mvc.1.0.view", @"/Views/Ticket/ChooseSeat.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"564fbbe91d82db0e7f455919c1bbf70d8741b446", @"/Views/Ticket/ChooseSeat.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ae34280c174cbec5a0a3988b56fd2bc0bd852ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Ticket_ChooseSeat : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\beyza\OneDrive\Masaüstü\BIA CINEMA TICKET DATABASE MANAGEMENT SYSTEM\BIA-Cinema-Ticket\BIA-Cinema-Ticket\Views\Ticket\ChooseSeat.cshtml"
  
    List<int> takenSeats = BIA_Cinema_Ticket.Controllers.TicketController.takenSeats;
    List<int> choosenSeats = BIA_Cinema_Ticket.Controllers.TicketController.choosenSeats;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div align=\"center\">\r\n    <div class=\"card mt-3\" style=\"width:70%\">\r\n        <div class=\"card-header\">\r\n            <h4 class=\"card-title\"><b>Buy Tickets</b></h4>\r\n        </div>\r\n        <p class=\"text-danger\">");
#nullable restore
#line 11 "C:\Users\beyza\OneDrive\Masaüstü\BIA CINEMA TICKET DATABASE MANAGEMENT SYSTEM\BIA-Cinema-Ticket\BIA-Cinema-Ticket\Views\Ticket\ChooseSeat.cshtml"
                          Write(ViewBag.errorMassage);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
        <div class=""card-body"">
            <div class=""row"">

                <div class=""col-9 mt-4"">

                    <div class=""seats"" style=""height: 410px;"">

                        <div class=""p-1"" align=""center"">The Scene</div>

");
#nullable restore
#line 21 "C:\Users\beyza\OneDrive\Masaüstü\BIA CINEMA TICKET DATABASE MANAGEMENT SYSTEM\BIA-Cinema-Ticket\BIA-Cinema-Ticket\Views\Ticket\ChooseSeat.cshtml"
                          
                            int id = 1;

                            for (int seatLetter = 65; seatLetter <= 72; seatLetter++)
                            {

                                char seat = Convert.ToChar(seatLetter);


#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"seat-order\">\r\n\r\n                                    <div class=\"seat-one\">");
#nullable restore
#line 31 "C:\Users\beyza\OneDrive\Masaüstü\BIA CINEMA TICKET DATABASE MANAGEMENT SYSTEM\BIA-Cinema-Ticket\BIA-Cinema-Ticket\Views\Ticket\ChooseSeat.cshtml"
                                                     Write(seat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
#nullable restore
#line 33 "C:\Users\beyza\OneDrive\Masaüstü\BIA CINEMA TICKET DATABASE MANAGEMENT SYSTEM\BIA-Cinema-Ticket\BIA-Cinema-Ticket\Views\Ticket\ChooseSeat.cshtml"
                                     for (var seatNo = 1; seatNo <= 15; seatNo++)
                                    {



                                        if (takenSeats.Contains(id))
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <button class=\"seat-one seat seat-taken\"");
            BeginWriteAttribute("value", " value=\"", 1400, "\"", 1411, 1);
#nullable restore
#line 40 "C:\Users\beyza\OneDrive\Masaüstü\BIA CINEMA TICKET DATABASE MANAGEMENT SYSTEM\BIA-Cinema-Ticket\BIA-Cinema-Ticket\Views\Ticket\ChooseSeat.cshtml"
WriteAttributeValue("", 1408, id, 1408, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 40 "C:\Users\beyza\OneDrive\Masaüstü\BIA CINEMA TICKET DATABASE MANAGEMENT SYSTEM\BIA-Cinema-Ticket\BIA-Cinema-Ticket\Views\Ticket\ChooseSeat.cshtml"
                                                                                            Write(seatNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n");
#nullable restore
#line 41 "C:\Users\beyza\OneDrive\Masaüstü\BIA CINEMA TICKET DATABASE MANAGEMENT SYSTEM\BIA-Cinema-Ticket\BIA-Cinema-Ticket\Views\Ticket\ChooseSeat.cshtml"
                                        }
                                        else
                                        {
                                            if (choosenSeats.Contains(id))
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1755, "\"", 1828, 5);
            WriteAttributeValue("", 1765, "location.href=\'", 1765, 15, true);
#nullable restore
#line 46 "C:\Users\beyza\OneDrive\Masaüstü\BIA CINEMA TICKET DATABASE MANAGEMENT SYSTEM\BIA-Cinema-Ticket\BIA-Cinema-Ticket\Views\Ticket\ChooseSeat.cshtml"
WriteAttributeValue("", 1780, Url.Action("deleteSeat", "Ticket"), 1780, 35, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1815, "?seat_ID=", 1815, 9, true);
#nullable restore
#line 46 "C:\Users\beyza\OneDrive\Masaüstü\BIA CINEMA TICKET DATABASE MANAGEMENT SYSTEM\BIA-Cinema-Ticket\BIA-Cinema-Ticket\Views\Ticket\ChooseSeat.cshtml"
WriteAttributeValue("", 1824, id, 1824, 3, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1827, "\'", 1827, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"seat-one seat-active\"");
            BeginWriteAttribute("value", " value=\"", 1858, "\"", 1869, 1);
#nullable restore
#line 46 "C:\Users\beyza\OneDrive\Masaüstü\BIA CINEMA TICKET DATABASE MANAGEMENT SYSTEM\BIA-Cinema-Ticket\BIA-Cinema-Ticket\Views\Ticket\ChooseSeat.cshtml"
WriteAttributeValue("", 1866, id, 1866, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 46 "C:\Users\beyza\OneDrive\Masaüstü\BIA CINEMA TICKET DATABASE MANAGEMENT SYSTEM\BIA-Cinema-Ticket\BIA-Cinema-Ticket\Views\Ticket\ChooseSeat.cshtml"
                                                                                                                                                                                    Write(seatNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n");
#nullable restore
#line 47 "C:\Users\beyza\OneDrive\Masaüstü\BIA CINEMA TICKET DATABASE MANAGEMENT SYSTEM\BIA-Cinema-Ticket\BIA-Cinema-Ticket\Views\Ticket\ChooseSeat.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2102, "\"", 2172, 5);
            WriteAttributeValue("", 2112, "location.href=\'", 2112, 15, true);
#nullable restore
#line 50 "C:\Users\beyza\OneDrive\Masaüstü\BIA CINEMA TICKET DATABASE MANAGEMENT SYSTEM\BIA-Cinema-Ticket\BIA-Cinema-Ticket\Views\Ticket\ChooseSeat.cshtml"
WriteAttributeValue("", 2127, Url.Action("addSeat", "Ticket"), 2127, 32, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2159, "?seat_ID=", 2159, 9, true);
#nullable restore
#line 50 "C:\Users\beyza\OneDrive\Masaüstü\BIA CINEMA TICKET DATABASE MANAGEMENT SYSTEM\BIA-Cinema-Ticket\BIA-Cinema-Ticket\Views\Ticket\ChooseSeat.cshtml"
WriteAttributeValue("", 2168, id, 2168, 3, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2171, "\'", 2171, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"seat-one seat\"");
            BeginWriteAttribute("value", " value=\"", 2195, "\"", 2206, 1);
#nullable restore
#line 50 "C:\Users\beyza\OneDrive\Masaüstü\BIA CINEMA TICKET DATABASE MANAGEMENT SYSTEM\BIA-Cinema-Ticket\BIA-Cinema-Ticket\Views\Ticket\ChooseSeat.cshtml"
WriteAttributeValue("", 2203, id, 2203, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 50 "C:\Users\beyza\OneDrive\Masaüstü\BIA CINEMA TICKET DATABASE MANAGEMENT SYSTEM\BIA-Cinema-Ticket\BIA-Cinema-Ticket\Views\Ticket\ChooseSeat.cshtml"
                                                                                                                                                                          Write(seatNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n");
#nullable restore
#line 51 "C:\Users\beyza\OneDrive\Masaüstü\BIA CINEMA TICKET DATABASE MANAGEMENT SYSTEM\BIA-Cinema-Ticket\BIA-Cinema-Ticket\Views\Ticket\ChooseSeat.cshtml"
                                            }
                                        }

                                        id++;

                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n");
#nullable restore
#line 58 "C:\Users\beyza\OneDrive\Masaüstü\BIA CINEMA TICKET DATABASE MANAGEMENT SYSTEM\BIA-Cinema-Ticket\BIA-Cinema-Ticket\Views\Ticket\ChooseSeat.cshtml"

                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                </div>

                <div class=""card mt-4"" style=""height:350px;"">
                    <div class=""card-header"">
                        <h5 class=""card-title"">Choosen Seats</h5>
                    </div>
                    <div class=""card-body"">
                        <ul>
");
#nullable restore
#line 70 "C:\Users\beyza\OneDrive\Masaüstü\BIA CINEMA TICKET DATABASE MANAGEMENT SYSTEM\BIA-Cinema-Ticket\BIA-Cinema-Ticket\Views\Ticket\ChooseSeat.cshtml"
                              
                                id = 1;

                                for (int seatLetter = 65; seatLetter <= 72; seatLetter++)
                                {

                                    char seat = Convert.ToChar(seatLetter);


                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "C:\Users\beyza\OneDrive\Masaüstü\BIA CINEMA TICKET DATABASE MANAGEMENT SYSTEM\BIA-Cinema-Ticket\BIA-Cinema-Ticket\Views\Ticket\ChooseSeat.cshtml"
                                     for (var seatNo = 1; seatNo <= 15; seatNo++)
                                    {

                                        if (choosenSeats.Contains(id))
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li>");
#nullable restore
#line 84 "C:\Users\beyza\OneDrive\Masaüstü\BIA CINEMA TICKET DATABASE MANAGEMENT SYSTEM\BIA-Cinema-Ticket\BIA-Cinema-Ticket\Views\Ticket\ChooseSeat.cshtml"
                                           Write(seat);

#line default
#line hidden
#nullable disable
#nullable restore
#line 84 "C:\Users\beyza\OneDrive\Masaüstü\BIA CINEMA TICKET DATABASE MANAGEMENT SYSTEM\BIA-Cinema-Ticket\BIA-Cinema-Ticket\Views\Ticket\ChooseSeat.cshtml"
                                                Write(seatNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 85 "C:\Users\beyza\OneDrive\Masaüstü\BIA CINEMA TICKET DATABASE MANAGEMENT SYSTEM\BIA-Cinema-Ticket\BIA-Cinema-Ticket\Views\Ticket\ChooseSeat.cshtml"
                                        }

                                        id++;

                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 89 "C:\Users\beyza\OneDrive\Masaüstü\BIA CINEMA TICKET DATABASE MANAGEMENT SYSTEM\BIA-Cinema-Ticket\BIA-Cinema-Ticket\Views\Ticket\ChooseSeat.cshtml"
                                     

                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                    </div>\r\n");
#nullable restore
#line 95 "C:\Users\beyza\OneDrive\Masaüstü\BIA CINEMA TICKET DATABASE MANAGEMENT SYSTEM\BIA-Cinema-Ticket\BIA-Cinema-Ticket\Views\Ticket\ChooseSeat.cshtml"
                      
                        int price = choosenSeats.Count() * 20;
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"card-body mt-4\">\r\n                        Price: ");
#nullable restore
#line 99 "C:\Users\beyza\OneDrive\Masaüstü\BIA CINEMA TICKET DATABASE MANAGEMENT SYSTEM\BIA-Cinema-Ticket\BIA-Cinema-Ticket\Views\Ticket\ChooseSeat.cshtml"
                          Write(price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" TL
                    </div>
                </div>
            </div>

            <div class=""btn btn-success"">
                <a href=""/ticket/paymentTicket"">
                    Continue
                </a>
            </div>

        </div>
    </div>
</div>
");
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