#pragma checksum "/mnt/d/trevor/business/timetracking/Views/TimeTrack/Report.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2d6b7c615de42b926cc28b1c96dcc98f3fe04b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TimeTrack_Report), @"mvc.1.0.view", @"/Views/TimeTrack/Report.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TimeTrack/Report.cshtml", typeof(AspNetCore.Views_TimeTrack_Report))]
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
#line 1 "/mnt/d/trevor/business/timetracking/Views/_ViewImports.cshtml"
using TimeTrack;

#line default
#line hidden
#line 2 "/mnt/d/trevor/business/timetracking/Views/_ViewImports.cshtml"
using TimeTrack.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2d6b7c615de42b926cc28b1c96dcc98f3fe04b4", @"/Views/TimeTrack/Report.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bea29cd0c158a29fc8d1d0648c2a67db747b8e1a", @"/Views/_ViewImports.cshtml")]
    public class Views_TimeTrack_Report : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TimeTrack.Models.ReportViewClass>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/mnt/d/trevor/business/timetracking/Views/TimeTrack/Report.cshtml"
  
    ViewData["Title"] = "Report";

#line default
#line hidden
            BeginContext(93, 271, true);
            WriteLiteral(@"
<h2>Report</h2>

<table class=""table"">
    <thead>
        <tr><th>
                Client
            </th>
            <th>
                Project
            </th>
            <th>
                Total Hours
            </th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 23 "/mnt/d/trevor/business/timetracking/Views/TimeTrack/Report.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(395, 46, true);
            WriteLiteral("        <tr>\n            <td>\n                ");
            EndContext();
            BeginContext(442, 4, false);
#line 26 "/mnt/d/trevor/business/timetracking/Views/TimeTrack/Report.cshtml"
           Write(item);

#line default
#line hidden
            EndContext();
            BeginContext(446, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(499, 4, false);
#line 29 "/mnt/d/trevor/business/timetracking/Views/TimeTrack/Report.cshtml"
           Write(item);

#line default
#line hidden
            EndContext();
            BeginContext(503, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(556, 34, false);
#line 32 "/mnt/d/trevor/business/timetracking/Views/TimeTrack/Report.cshtml"
           Write(Html.DisplayFor(modelItem => item));

#line default
#line hidden
            EndContext();
            BeginContext(590, 33, true);
            WriteLiteral("\n            </td>\n        </tr>\n");
            EndContext();
#line 35 "/mnt/d/trevor/business/timetracking/Views/TimeTrack/Report.cshtml"
}

#line default
#line hidden
            BeginContext(625, 23, true);
            WriteLiteral("\n    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TimeTrack.Models.ReportViewClass>> Html { get; private set; }
    }
}
#pragma warning restore 1591
