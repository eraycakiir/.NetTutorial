#pragma checksum "D:\.NetMvc\.NetMvcTutorial\.NetTutorial\E-Ticket\e_ticket\e_ticket\Views\Movies\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24c8660659c6e7ef997f4affff49efc4961faab5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Index), @"mvc.1.0.view", @"/Views/Movies/Index.cshtml")]
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
#line 1 "D:\.NetMvc\.NetMvcTutorial\.NetTutorial\E-Ticket\e_ticket\e_ticket\Views\_ViewImports.cshtml"
using e_ticket;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\.NetMvc\.NetMvcTutorial\.NetTutorial\E-Ticket\e_ticket\e_ticket\Views\_ViewImports.cshtml"
using e_ticket.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24c8660659c6e7ef997f4affff49efc4961faab5", @"/Views/Movies/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3509633a69f931e3f6a3fd6212b45ea741f97949", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Movies_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Movie>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\.NetMvc\.NetMvcTutorial\.NetTutorial\E-Ticket\e_ticket\e_ticket\Views\Movies\Index.cshtml"
  
    ViewData["Title"] = "List of Movies";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-8 offset-md-2\">\r\n\r\n        <table class=\"table\">\r\n            <thead>\r\n                <tr class=\"text-center\">\r\n                    <th>");
#nullable restore
#line 13 "D:\.NetMvc\.NetMvcTutorial\.NetTutorial\E-Ticket\e_ticket\e_ticket\Views\Movies\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.ImageUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 14 "D:\.NetMvc\.NetMvcTutorial\.NetTutorial\E-Ticket\e_ticket\e_ticket\Views\Movies\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 15 "D:\.NetMvc\.NetMvcTutorial\.NetTutorial\E-Ticket\e_ticket\e_ticket\Views\Movies\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>Actions</th>\r\n\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 21 "D:\.NetMvc\.NetMvcTutorial\.NetTutorial\E-Ticket\e_ticket\e_ticket\Views\Movies\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td class=\"align-middle\">\r\n                            <img class=\"rounded-circle\"");
            BeginWriteAttribute("src", " src=\"", 766, "\"", 786, 1);
#nullable restore
#line 25 "D:\.NetMvc\.NetMvcTutorial\.NetTutorial\E-Ticket\e_ticket\e_ticket\Views\Movies\Index.cshtml"
WriteAttributeValue("", 772, item.ImageUrl, 772, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 787, "\"", 803, 1);
#nullable restore
#line 25 "D:\.NetMvc\.NetMvcTutorial\.NetTutorial\E-Ticket\e_ticket\e_ticket\Views\Movies\Index.cshtml"
WriteAttributeValue("", 793, item.Name, 793, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"max-width: 150px\" />\r\n                        </td>\r\n                        <td class=\"align-middle\">\r\n                            ");
#nullable restore
#line 28 "D:\.NetMvc\.NetMvcTutorial\.NetTutorial\E-Ticket\e_ticket\e_ticket\Views\Movies\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"align-middle\">\r\n                            ");
#nullable restore
#line 31 "D:\.NetMvc\.NetMvcTutorial\.NetTutorial\E-Ticket\e_ticket\e_ticket\Views\Movies\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 35 "D:\.NetMvc\.NetMvcTutorial\.NetTutorial\E-Ticket\e_ticket\e_ticket\Views\Movies\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n\r\n        </table>\r\n\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Movie>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
