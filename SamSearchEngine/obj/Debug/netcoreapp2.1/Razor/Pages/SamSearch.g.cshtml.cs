#pragma checksum "C:\Users\Saros0300\Work Folders\Documents\SamGit-Repo\GitHub\SamSearchEngine\SamSearchEngine\Pages\SamSearch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e70271bcb4a556807ccae2ae5a7e7a8eabfecd24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SamSearchEngine.Pages.Pages_SamSearch), @"mvc.1.0.razor-page", @"/Pages/SamSearch.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/SamSearch.cshtml", typeof(SamSearchEngine.Pages.Pages_SamSearch), null)]
namespace SamSearchEngine.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Saros0300\Work Folders\Documents\SamGit-Repo\GitHub\SamSearchEngine\SamSearchEngine\Pages\_ViewImports.cshtml"
using SamSearchEngine;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e70271bcb4a556807ccae2ae5a7e7a8eabfecd24", @"/Pages/SamSearch.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"496c538bf68f2bb9499ee179788a150581c0ce39", @"/Pages/_ViewImports.cshtml")]
    public class Pages_SamSearch : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Saros0300\Work Folders\Documents\SamGit-Repo\GitHub\SamSearchEngine\SamSearchEngine\Pages\SamSearch.cshtml"
  
    ViewData["Title"] = "Search";


#line default
#line hidden
            BeginContext(74, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(81, 17, false);
#line 8 "C:\Users\Saros0300\Work Folders\Documents\SamGit-Repo\GitHub\SamSearchEngine\SamSearchEngine\Pages\SamSearch.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(98, 446, true);
            WriteLiteral(@"</h2>

<script>
  (function() {
    var cx = '004623051103029271626:bvfbk3gamxc';
    var gcse = document.createElement('script');
    gcse.type = 'text/javascript';
    gcse.async = true;
    gcse.src = 'https://cse.google.com/cse.js?cx=' + cx;
    var s = document.getElementsByTagName('script')[0];
    s.parentNode.insertBefore(gcse, s);
  })();
</script>
<gcse:search enableAutoComplete=""true""></gcse:search>

        



");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SamSearchModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SamSearchModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SamSearchModel>)PageContext?.ViewData;
        public SamSearchModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
