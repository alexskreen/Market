#pragma checksum "/Users/alexskreen/Desktop/Market.Solution/Market/Views/Flavors/Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e2336700b3370625752181c7cefad27c4d19881"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Flavors_Delete), @"mvc.1.0.view", @"/Views/Flavors/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Flavors/Delete.cshtml", typeof(AspNetCore.Views_Flavors_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e2336700b3370625752181c7cefad27c4d19881", @"/Views/Flavors/Delete.cshtml")]
    public class Views_Flavors_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Market.Models.Flavor>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/alexskreen/Desktop/Market.Solution/Market/Views/Flavors/Delete.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(56, 49, true);
            WriteLiteral("\n<h2>Are you sure you want to delete this?</h2>\n\n");
            EndContext();
            BeginContext(106, 47, false);
#line 9 "/Users/alexskreen/Desktop/Market.Solution/Market/Views/Flavors/Delete.cshtml"
Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(153, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(156, 43, false);
#line 9 "/Users/alexskreen/Desktop/Market.Solution/Market/Views/Flavors/Delete.cshtml"
                                             Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(199, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 10 "/Users/alexskreen/Desktop/Market.Solution/Market/Views/Flavors/Delete.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(228, 43, true);
            WriteLiteral("    <input type=\"submit\" value=\"Delete\" />\n");
            EndContext();
#line 13 "/Users/alexskreen/Desktop/Market.Solution/Market/Views/Flavors/Delete.cshtml"
}

#line default
#line hidden
            BeginContext(274, 40, false);
#line 14 "/Users/alexskreen/Desktop/Market.Solution/Market/Views/Flavors/Delete.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Market.Models.Flavor> Html { get; private set; }
    }
}
#pragma warning restore 1591
