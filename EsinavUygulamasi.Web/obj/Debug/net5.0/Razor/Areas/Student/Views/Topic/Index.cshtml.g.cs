#pragma checksum "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Student\Views\Topic\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dedb046ab6b9e0b0226ade6b5c3d96bfd63fe89e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Student_Views_Topic_Index), @"mvc.1.0.view", @"/Areas/Student/Views/Topic/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dedb046ab6b9e0b0226ade6b5c3d96bfd63fe89e", @"/Areas/Student/Views/Topic/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Areas/Student/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Student_Views_Topic_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EsinavUygulamasi.DAL.Models.Database.Topic>>
    #nullable disable
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Student\Views\Topic\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Student/Views/Shared/_StudentLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n    body a{\r\n        color:black;\r\n    }\r\n    .gridHeader{\r\n        text-align:center;\r\n    }\r\n</style>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dedb046ab6b9e0b0226ade6b5c3d96bfd63fe89e3279", async() => {
                WriteLiteral(@"
    <div class= ""container"">
            <br/>
            
            <div>
                <div class=""gridHeader p-4""><h3>Konu Listesi</h3></div>
                <table id=""example"" class=""table table-hover table-bordered table-light table-striped "" style=""color:black"" width=""100%""  cellspacing=""0"">
                    <thead class=""thead-dark "">
                        <tr>
                            <th> id </th>
                            <th> Name </th>                                                                                                       
                        </tr>
                    </thead>

                    <tbody>
");
#nullable restore
#line 29 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Student\Views\Topic\Index.cshtml"
                         foreach (var topic in Model)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr>\r\n                                <th> ");
#nullable restore
#line 32 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Student\Views\Topic\Index.cshtml"
                                Write(topic.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </th>\r\n                                <td><a");
                BeginWriteAttribute("href", " href=\"", 1169, "\"", 1209, 2);
                WriteAttributeValue("", 1176, "/Student/Question/Index/", 1176, 24, true);
#nullable restore
#line 33 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Student\Views\Topic\Index.cshtml"
WriteAttributeValue("", 1200, topic.Id, 1200, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" data-id=\"");
#nullable restore
#line 33 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Student\Views\Topic\Index.cshtml"
                                                                                    Write(topic.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("\">");
#nullable restore
#line 33 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Student\Views\Topic\Index.cshtml"
                                                                                               Write(topic.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a> </td>\r\n                            </tr>\r\n");
#nullable restore
#line 35 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Student\Views\Topic\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </tbody>\r\n\r\n                </table>\r\n              \r\n            </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
