#pragma checksum "/home/samuel/Desktop/AP_FinalProject-master/WebApp/Pages/groups.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a494a8639dc763121003801875d1b8e24b887a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_groups), @"mvc.1.0.razor-page", @"/Pages/groups.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a494a8639dc763121003801875d1b8e24b887a8", @"/Pages/groups.cshtml")]
    public class Pages_groups : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""row"">
  <h1 class=""display-2"">Groups</h1>
  <table class=""table"">
    <thead class=""thead-inverse"">
      <tr><th>School Groups</th></tr>
      <tr><td><a class=""btn btn-primary"" href=""subjects"">Create new</a></td></tr>
    </thead>
    <tbody>
");
#nullable restore
#line 13 "/home/samuel/Desktop/AP_FinalProject-master/WebApp/Pages/groups.cshtml"
     foreach(var group in Model.Groups)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("      <tr><td>");
#nullable restore
#line 15 "/home/samuel/Desktop/AP_FinalProject-master/WebApp/Pages/groups.cshtml"
         Write(group.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\n");
#nullable restore
#line 16 "/home/samuel/Desktop/AP_FinalProject-master/WebApp/Pages/groups.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n  </table>\n</div>\n<div class=\"row\">\n\n");
            WriteLiteral("\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApp.Pages.GroupsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApp.Pages.GroupsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApp.Pages.GroupsModel>)PageContext?.ViewData;
        public WebApp.Pages.GroupsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
