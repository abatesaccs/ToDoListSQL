#pragma checksum "/Users/Guest/Desktop/ToDoList.Solution/ToDoList/Views/Items/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e1b98997e4fcaccadb92a531d12709d383b94ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items_Index), @"mvc.1.0.view", @"/Views/Items/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Items/Index.cshtml", typeof(AspNetCore.Views_Items_Index))]
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
#line 1 "/Users/Guest/Desktop/ToDoList.Solution/ToDoList/Views/Items/Index.cshtml"
using ToDoList.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e1b98997e4fcaccadb92a531d12709d383b94ff", @"/Views/Items/Index.cshtml")]
    public class Views_Items_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(24, 21, true);
            WriteLiteral("\n<h1>To Do List</h1>\n");
            EndContext();
#line 4 "/Users/Guest/Desktop/ToDoList.Solution/ToDoList/Views/Items/Index.cshtml"
 if (Model.Count == 0)
{

#line default
#line hidden
            BeginContext(70, 41, true);
            WriteLiteral("  <p>There are no items in the list.</p>\n");
            EndContext();
#line 7 "/Users/Guest/Desktop/ToDoList.Solution/ToDoList/Views/Items/Index.cshtml"
}

#line default
#line hidden
            BeginContext(113, 5, true);
            WriteLiteral("<ul>\n");
            EndContext();
#line 9 "/Users/Guest/Desktop/ToDoList.Solution/ToDoList/Views/Items/Index.cshtml"
   foreach (Item item in Model)
  {

#line default
#line hidden
            BeginContext(154, 8, true);
            WriteLiteral("    <li>");
            EndContext();
            BeginContext(163, 16, false);
#line 11 "/Users/Guest/Desktop/ToDoList.Solution/ToDoList/Views/Items/Index.cshtml"
   Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(179, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 12 "/Users/Guest/Desktop/ToDoList.Solution/ToDoList/Views/Items/Index.cshtml"
  }

#line default
#line hidden
            BeginContext(189, 47, true);
            WriteLiteral("</ul>\n\n<a href=\"/items/new\">Add a new item.</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591