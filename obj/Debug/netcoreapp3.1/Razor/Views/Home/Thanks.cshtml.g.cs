#pragma checksum "/Users/Balazs/Desktop/software_dev/ASP.NET/PartyInvites/PartyInvites/Views/Home/Thanks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b421515a1ffe6111327fb541858bddc76adce7b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Thanks), @"mvc.1.0.view", @"/Views/Home/Thanks.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b421515a1ffe6111327fb541858bddc76adce7b", @"/Views/Home/Thanks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d7a259bdcfe8a3ab85fd12fae1bbeaca619aa04", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Thanks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PartyInvites.Models.GuestResponse>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n<div>\n    <h1>Thank you ");
#nullable restore
#line 7 "/Users/Balazs/Desktop/software_dev/ASP.NET/PartyInvites/PartyInvites/Views/Home/Thanks.cshtml"
             Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("!</h1>\n");
#nullable restore
#line 8 "/Users/Balazs/Desktop/software_dev/ASP.NET/PartyInvites/PartyInvites/Views/Home/Thanks.cshtml"
     if (Model.WillAttend == true)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            WriteLiteral("It\'s great that you\'re coming. The drinks are already in the fridge.\n");
#nullable restore
#line 11 "/Users/Balazs/Desktop/software_dev/ASP.NET/PartyInvites/PartyInvites/Views/Home/Thanks.cshtml"
            } else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            WriteLiteral("Sorry to hear that you can\'t make it, but thanks for letting us know.\n");
#nullable restore
#line 14 "/Users/Balazs/Desktop/software_dev/ASP.NET/PartyInvites/PartyInvites/Views/Home/Thanks.cshtml"
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