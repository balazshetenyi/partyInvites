#pragma checksum "/Users/Balazs/Desktop/software_dev/ASP.NET/PartyInvites/PartyInvites/Views/Home/RsvpForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5ab978387971f5545aa79a92c1f3c9945f66943"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_RsvpForm), @"mvc.1.0.view", @"/Views/Home/RsvpForm.cshtml")]
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
#line 1 "/Users/Balazs/Desktop/software_dev/ASP.NET/PartyInvites/PartyInvites/Views/_ViewImports.cshtml"
using PartyInvites;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/Balazs/Desktop/software_dev/ASP.NET/PartyInvites/PartyInvites/Views/_ViewImports.cshtml"
using PartyInvites.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5ab978387971f5545aa79a92c1f3c9945f66943", @"/Views/Home/RsvpForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d7a259bdcfe8a3ab85fd12fae1bbeaca619aa04", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_RsvpForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PartyInvites.Models.GuestResponse>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n\n<div>\n");
#nullable restore
#line 9 "/Users/Balazs/Desktop/software_dev/ASP.NET/PartyInvites/PartyInvites/Views/Home/RsvpForm.cshtml"
     using (Html.BeginForm())
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>Your name: ");
#nullable restore
#line 11 "/Users/Balazs/Desktop/software_dev/ASP.NET/PartyInvites/PartyInvites/Views/Home/RsvpForm.cshtml"
                         Write(Html.TextBoxFor(x => x.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                <p>Your email: ");
#nullable restore
#line 12 "/Users/Balazs/Desktop/software_dev/ASP.NET/PartyInvites/PartyInvites/Views/Home/RsvpForm.cshtml"
                          Write(Html.TextBoxFor(x => x.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                <p>Your phone: ");
#nullable restore
#line 13 "/Users/Balazs/Desktop/software_dev/ASP.NET/PartyInvites/PartyInvites/Views/Home/RsvpForm.cshtml"
                          Write(Html.TextBoxFor(x => x.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                <p>\n                    Will you attend?\n                    ");
#nullable restore
#line 16 "/Users/Balazs/Desktop/software_dev/ASP.NET/PartyInvites/PartyInvites/Views/Home/RsvpForm.cshtml"
               Write(Html.DropDownListFor(x => x.WillAttend, new[] {
                        new SelectListItem() {Text = "Yes, I'll be there", Value = bool.TrueString},
                        new SelectListItem() {Text = "No, I can't come", Value = bool.FalseString}
               }, "Choose an option"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </p>\n                <input type=\"submit\" value=\"Submit RSVP\" />\n");
#nullable restore
#line 22 "/Users/Balazs/Desktop/software_dev/ASP.NET/PartyInvites/PartyInvites/Views/Home/RsvpForm.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PartyInvites.Models.GuestResponse> Html { get; private set; }
    }
}
#pragma warning restore 1591
