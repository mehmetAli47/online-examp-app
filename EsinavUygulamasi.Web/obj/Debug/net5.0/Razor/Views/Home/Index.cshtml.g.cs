#pragma checksum "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2f02eaa077ac04b41d61d70656e49bf6289307b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2f02eaa077ac04b41d61d70656e49bf6289307b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e9aa82fc6237a404bd367ecf8b6893723b7e273", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EsinavUygulamasi.DAL.Models.Database.Institution>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/web/images/1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2f02eaa077ac04b41d61d70656e49bf6289307b4753", async() => {
                WriteLiteral("\r\n  <title>Bootstrap 4 Website Example</title>\r\n  <meta charset=\"utf-8\">\r\n  <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\r\n\r\n  <style>\r\n  </style>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2f02eaa077ac04b41d61d70656e49bf6289307b5906", async() => {
                WriteLiteral(@"

<div class=""jumbotron text-center"" style=""margin-bottom:0"">
  <h1> Online sınavlarımıza hoşgeldiniz </h1>
  <p>Seçmek istediğiniz Kuruma tıklayarak  istediğiniz sınavları deneyebilirsiniz</p> 
</div>
<div style=""margin-bottom:0"">
<nav class=""navbar navbar-expand-sm bg-dark navbar-dark"" >
</nav>
</div>
    <sectin class=""main-content-w3layouts-agileits"">
    <div class=""container"">
        <h3 class=""tittle"">Kurumlar</h3>
        <div class=""inner-sec"">
            <!--left-->
            <div class=""left-blog-info-w3layouts-agileits text-left"">
                <div class=""row"">
");
#nullable restore
#line 32 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Views\Home\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"col-lg-4 card\">\r\n                            <a");
                BeginWriteAttribute("href", " href=\"", 1095, "\"", 1133, 2);
                WriteAttributeValue("", 1102, "/Home/InstitutionExams/", 1102, 23, true);
#nullable restore
#line 35 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Views\Home\Index.cshtml"
WriteAttributeValue("", 1125, item.Id, 1125, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" data-id=\"");
#nullable restore
#line 35 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Views\Home\Index.cshtml"
                                                                          Write(item.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("\">\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b2f02eaa077ac04b41d61d70656e49bf6289307b7924", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            </a>
                            <div class=""card-body"">
                                <ul class=""blog-icons my-4"">
                                    <li>
                                        <a href=""#"">
                                            <i class=""far fa-calendar-alt""></i> ");
#nullable restore
#line 42 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Views\Home\Index.cshtml"
                                                                            Write(((DateTime)item.CreateTime).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                        </a>
                                    </li>
                                    <li class=""mx-2"">
                                        <a href=""#"">
                                            <i class=""far fa-comment""></i> 0
                                        </a>
                                    </li>
                                    <li>
                                        <a");
                BeginWriteAttribute("href", " href=\"", 2088, "\"", 2126, 2);
                WriteAttributeValue("", 2095, "/Home/InstitutionExams/", 2095, 23, true);
#nullable restore
#line 51 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Views\Home\Index.cshtml"
WriteAttributeValue("", 2118, item.Id, 2118, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" data -");
                BeginWriteAttribute("id", " id=\"", 2134, "\"", 2147, 1);
#nullable restore
#line 51 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Views\Home\Index.cshtml"
WriteAttributeValue("", 2139, item.Id, 2139, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                            <i class=\"fas fa-eye\"></i> ");
#nullable restore
#line 52 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Views\Home\Index.cshtml"
                                                                  Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                        </a>
                                    </li>
                                    
                                </ul>
                                <h5 class=""card-title"">
                                    <a");
                BeginWriteAttribute("href", " href=\"", 2495, "\"", 2533, 2);
                WriteAttributeValue("", 2502, "/Home/InstitutionExams/", 2502, 23, true);
#nullable restore
#line 58 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Views\Home\Index.cshtml"
WriteAttributeValue("", 2525, item.Id, 2525, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" data -");
                BeginWriteAttribute("id", " id=\"", 2541, "\"", 2554, 1);
#nullable restore
#line 58 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Views\Home\Index.cshtml"
WriteAttributeValue("", 2546, item.Id, 2546, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 58 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Views\Home\Index.cshtml"
                                                                                              Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n                                </h5>\r\n                                <p class=\"card-text mb-3\">");
#nullable restore
#line 60 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Views\Home\Index.cshtml"
                                                      Write(item.InstitutionInformation.Length>130?item.InstitutionInformation.Substring(0,130):item.InstitutionInformation);

#line default
#line hidden
#nullable disable
                WriteLiteral("...</p>\r\n");
                WriteLiteral("                            </div>\r\n                        </div>\r\n                        <br />\r\n                        <br />\r\n");
#nullable restore
#line 66 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Views\Home\Index.cshtml"

                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\r\n                <!--//left-->\r\n            </div>\r\n        </div>\r\n    </div>\r\n</sectin>\r\n  \r\n");
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
            WriteLiteral("\r\n</html>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EsinavUygulamasi.DAL.Models.Database.Institution>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
