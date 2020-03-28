#pragma checksum "/Users/alexskreen/Desktop/Market.Solution/Market/Views/Treats/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0bcbb7220d206e0900a7da3399e060c877aca23"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Treats_Index), @"mvc.1.0.view", @"/Views/Treats/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Treats/Index.cshtml", typeof(AspNetCore.Views_Treats_Index))]
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
#line 5 "/Users/alexskreen/Desktop/Market.Solution/Market/Views/Treats/Index.cshtml"
using Market.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0bcbb7220d206e0900a7da3399e060c877aca23", @"/Views/Treats/Index.cshtml")]
    public class Views_Treats_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Market.Models.Treat>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/alexskreen/Desktop/Market.Solution/Market/Views/Treats/Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(84, 18, true);
            WriteLiteral("\n<h1>Treats</h1>\n\n");
            EndContext();
#line 10 "/Users/alexskreen/Desktop/Market.Solution/Market/Views/Treats/Index.cshtml"
 if (@Model.Count == 0)
{

#line default
#line hidden
            BeginContext(128, 42, true);
            WriteLiteral("  <h3>No treats have been added yet!</h3>\n");
            EndContext();
#line 13 "/Users/alexskreen/Desktop/Market.Solution/Market/Views/Treats/Index.cshtml"
} 

#line default
#line hidden
            BeginContext(173, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 15 "/Users/alexskreen/Desktop/Market.Solution/Market/Views/Treats/Index.cshtml"
 foreach (Treat treat in Model)
{

#line default
#line hidden
            BeginContext(208, 6, true);
            WriteLiteral("  <li>");
            EndContext();
            BeginContext(215, 71, false);
#line 17 "/Users/alexskreen/Desktop/Market.Solution/Market/Views/Treats/Index.cshtml"
 Write(Html.ActionLink($"{treat.Name}", "Details", new { id = treat.TreatId }));

#line default
#line hidden
            EndContext();
            BeginContext(286, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 18 "/Users/alexskreen/Desktop/Market.Solution/Market/Views/Treats/Index.cshtml"
}

#line default
#line hidden
            BeginContext(294, 4, true);
            WriteLiteral("\n<p>");
            EndContext();
            BeginContext(299, 42, false);
#line 20 "/Users/alexskreen/Desktop/Market.Solution/Market/Views/Treats/Index.cshtml"
Write(Html.ActionLink("Add new treat", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(341, 9, true);
            WriteLiteral("</p>\n\n<p>");
            EndContext();
            BeginContext(351, 40, false);
#line 22 "/Users/alexskreen/Desktop/Market.Solution/Market/Views/Treats/Index.cshtml"
Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(391, 4, true);
            WriteLiteral("</p>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Market.Models.Treat>> Html { get; private set; }
    }
}
#pragma warning restore 1591
