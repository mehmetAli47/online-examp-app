#pragma checksum "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Views\Topic\TopicQuestion.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b62b626304430d7a48c7f45b49c48c2176b5bb9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Topic_TopicQuestion), @"mvc.1.0.view", @"/Views/Topic/TopicQuestion.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b62b626304430d7a48c7f45b49c48c2176b5bb9", @"/Views/Topic/TopicQuestion.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e9aa82fc6237a404bd367ecf8b6893723b7e273", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Topic_TopicQuestion : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EsinavUygulamasi.Models.Response.QuestionVM>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/style/Question.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Views\Topic\TopicQuestion.cshtml"
  
    ViewData["Title"] = "TopicQuestion";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b62b626304430d7a48c7f45b49c48c2176b5bb94508", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <!-- Latest compiled and minified CSS -->
    <link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap@3.3.7/dist/css/bootstrap.min.css"" integrity=""sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u"" crossorigin=""anonymous"">

    <!-- Optional theme -->
    <link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap@3.3.7/dist/css/bootstrap-theme.min.css"" integrity=""sha384-rHyoN1iRsVXV4nD0JutlnGaslCJuC7uwjduW9SVrLvRYooPp2bWYgmgJQIXwl/Sp"" crossorigin=""anonymous"">

    <!-- Latest compiled and minified JavaScript -->
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@3.3.7/dist/js/bootstrap.min.js"" integrity=""sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa"" crossorigin=""anonymous""></script>
  ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7b62b626304430d7a48c7f45b49c48c2176b5bb95676", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b62b626304430d7a48c7f45b49c48c2176b5bb97559", async() => {
                WriteLiteral("\r\n    <section");
                BeginWriteAttribute("class", " class=\"", 1164, "\"", 1172, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n        <div class=\"container\">\r\n\r\n            <div class=\"gridHeader\"><h3>");
#nullable restore
#line 26 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Views\Topic\TopicQuestion.cshtml"
                                   Write(ViewBag.TopicName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" Örnek  Soru Listesi</h3> </div>\r\n            <br />\r\n            <div class=\"question\">\r\n");
#nullable restore
#line 29 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Views\Topic\TopicQuestion.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"questionName row\">\r\n                        <div class=\"name col-md-12 p-3 \" style=\"background-color:burlywood\">\r\n                            <label for=\"validationCustom01\">");
#nullable restore
#line 33 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Views\Topic\TopicQuestion.cshtml"
                                                       Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"questionAnswer row\">\r\n                        <div class=\"col-md-12 p-3 \">\r\n                            <input class=\"custom-radio\"");
                BeginWriteAttribute("name", " name=\"", 1873, "\"", 1890, 1);
#nullable restore
#line 38 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Views\Topic\TopicQuestion.cshtml"
WriteAttributeValue("", 1880, item.Name, 1880, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"radio\"");
                BeginWriteAttribute("id", " id=\"", 1904, "\"", 1922, 1);
#nullable restore
#line 38 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Views\Topic\TopicQuestion.cshtml"
WriteAttributeValue("", 1909, item.Answer1, 1909, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" disabled>\r\n                            <label");
                BeginWriteAttribute("for", " for=\"", 1969, "\"", 1988, 1);
#nullable restore
#line 39 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Views\Topic\TopicQuestion.cshtml"
WriteAttributeValue("", 1975, item.Answer1, 1975, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 39 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Views\Topic\TopicQuestion.cshtml"
                                                  Write(item.Answer1);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                        </div>\r\n                        <div class=\"col-md-12 p-3\">\r\n                            <input class=\"custom-radio\"");
                BeginWriteAttribute("name", " name=\"", 2153, "\"", 2170, 1);
#nullable restore
#line 42 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Views\Topic\TopicQuestion.cshtml"
WriteAttributeValue("", 2160, item.Name, 2160, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"radio\"");
                BeginWriteAttribute("id", " id=\"", 2184, "\"", 2202, 1);
#nullable restore
#line 42 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Views\Topic\TopicQuestion.cshtml"
WriteAttributeValue("", 2189, item.Answer2, 2189, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("disabled>\r\n                            <label");
                BeginWriteAttribute("for", " for=\"", 2248, "\"", 2267, 1);
#nullable restore
#line 43 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Views\Topic\TopicQuestion.cshtml"
WriteAttributeValue("", 2254, item.Answer2, 2254, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 43 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Views\Topic\TopicQuestion.cshtml"
                                                  Write(item.Answer2);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                        </div>\r\n                        <div class=\"col-md-12 p-3\">\r\n                            <input class=\"custom-radio\"");
                BeginWriteAttribute("name", " name=\"", 2432, "\"", 2449, 1);
#nullable restore
#line 46 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Views\Topic\TopicQuestion.cshtml"
WriteAttributeValue("", 2439, item.Name, 2439, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"radio\"");
                BeginWriteAttribute("id", " id=\"", 2463, "\"", 2481, 1);
#nullable restore
#line 46 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Views\Topic\TopicQuestion.cshtml"
WriteAttributeValue("", 2468, item.Answer3, 2468, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("disabled>\r\n                            <label");
                BeginWriteAttribute("for", " for=\"", 2527, "\"", 2546, 1);
#nullable restore
#line 47 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Views\Topic\TopicQuestion.cshtml"
WriteAttributeValue("", 2533, item.Answer3, 2533, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 47 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Views\Topic\TopicQuestion.cshtml"
                                                  Write(item.Answer3);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                        </div>\r\n                        <div class=\"col-md-12 p-3\">\r\n                            <input class=\"custom-radio\"");
                BeginWriteAttribute("name", " name=\"", 2711, "\"", 2728, 1);
#nullable restore
#line 50 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Views\Topic\TopicQuestion.cshtml"
WriteAttributeValue("", 2718, item.Name, 2718, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"radio\"");
                BeginWriteAttribute("id", " id=\"", 2742, "\"", 2760, 1);
#nullable restore
#line 50 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Views\Topic\TopicQuestion.cshtml"
WriteAttributeValue("", 2747, item.Answer4, 2747, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("disabled>\r\n                            <label");
                BeginWriteAttribute("for", " for=\"", 2806, "\"", 2825, 1);
#nullable restore
#line 51 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Views\Topic\TopicQuestion.cshtml"
WriteAttributeValue("", 2812, item.Answer4, 2812, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 51 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Views\Topic\TopicQuestion.cshtml"
                                                  Write(item.Answer4);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                        </div>\r\n                    </div>\r\n");
                WriteLiteral("                    <br />\r\n                    <br />\r\n                    <br />\r\n");
#nullable restore
#line 58 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Views\Topic\TopicQuestion.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\r\n\r\n        </div>\r\n    </section>\r\n");
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
            WriteLiteral("\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EsinavUygulamasi.Models.Response.QuestionVM>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
