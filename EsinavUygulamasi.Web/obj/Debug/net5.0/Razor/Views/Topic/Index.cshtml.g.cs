#pragma checksum "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Views\Topic\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b537516136df0a0d7deaa107ba6dc0284577290"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Topic_Index), @"mvc.1.0.view", @"/Views/Topic/Index.cshtml")]
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
#line 1 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Views\_ViewImports.cshtml"
using EsinavUygulaması;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Views\_ViewImports.cshtml"
using EsinavUygulaması.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b537516136df0a0d7deaa107ba6dc0284577290", @"/Views/Topic/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e9aa82fc6237a404bd367ecf8b6893723b7e273", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Topic_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EsinavUygulamasi.DAL.Models.Database.Topic>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Views\Topic\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class= ""container"">
            <br/>
            
            <div>
                <div class=""gridHeader "" style=""text-align:center""><h3> Konu Listesi</h3> </div>
                <table id=""example"" class=""table table-striped table-bordered table-hover"" >
                    <thead class=""thead-dark "">
                        <tr>
                            <th> id </th>
                            <th> Name </th>                                                                                                       
                        </tr>
                    </thead>

                    <tbody>
");
#nullable restore
#line 20 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Views\Topic\Index.cshtml"
                         foreach (var topic in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <th> ");
#nullable restore
#line 23 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Views\Topic\Index.cshtml"
                                Write(topic.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 985, "\"", 1022, 2);
            WriteAttributeValue("", 992, "/Topic/TopicQuestion/", 992, 21, true);
#nullable restore
#line 24 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Views\Topic\Index.cshtml"
WriteAttributeValue("", 1013, topic.Id, 1013, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-id=\"");
#nullable restore
#line 24 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Views\Topic\Index.cshtml"
                                                                                 Write(topic.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"style=\"color:black;font-size:20px;\" >");
#nullable restore
#line 24 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Views\Topic\Index.cshtml"
                                                                                                                                Write(topic.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> </td>\r\n                            </tr>\r\n");
#nullable restore
#line 26 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Views\Topic\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n\r\n                </table>\r\n              \r\n            </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EsinavUygulamasi.DAL.Models.Database.Topic>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
