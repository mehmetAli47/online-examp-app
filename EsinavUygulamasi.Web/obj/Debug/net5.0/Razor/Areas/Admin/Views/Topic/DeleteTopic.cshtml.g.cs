#pragma checksum "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Admin\Views\Topic\DeleteTopic.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c11033eba45cec0d97dd2e21ddd553b943ee6c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Topic_DeleteTopic), @"mvc.1.0.view", @"/Areas/Admin/Views/Topic/DeleteTopic.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c11033eba45cec0d97dd2e21ddd553b943ee6c4", @"/Areas/Admin/Views/Topic/DeleteTopic.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Topic_DeleteTopic : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EsinavUygulamasi.DAL.Models.Database.Topic>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "/Institution/DeleteInstitution", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Admin\Views\Topic\DeleteTopic.cshtml"
  
    ViewData["Title"] = "DeleteTopic";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayouth.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container p-5\">\r\n");
#nullable restore
#line 7 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Admin\Views\Topic\DeleteTopic.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <dl class=\"row borde\">\r\n            <dt class=\"col-2\">\r\n                <label>Konu Id:</label>\r\n            </dt>\r\n            <dd class=\"col-10\">\r\n\r\n                <label>");
#nullable restore
#line 15 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Admin\Views\Topic\DeleteTopic.cshtml"
                  Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            </dd>\r\n            <dt class=\"col-2\">\r\n                <label>Konu Başlığı:</label>\r\n            </dt>\r\n            <dd class=\"col-10\">\r\n\r\n                <label>");
#nullable restore
#line 22 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Admin\Views\Topic\DeleteTopic.cshtml"
                  Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            </dd>\r\n            <dt class=\"col-2\">\r\n                <label>Kayıt Oluşturma Zamanı:</label>\r\n            </dt>\r\n            <dd class=\"col-10\">\r\n\r\n                <label>");
#nullable restore
#line 29 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Admin\Views\Topic\DeleteTopic.cshtml"
                  Write(item.CreateTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            </dd>\r\n            <dt class=\"col-2\">\r\n                <label>En son Güncelleme zamanı:</label>\r\n            </dt>\r\n            <dd class=\"col-10\">\r\n\r\n                <label>");
#nullable restore
#line 36 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Admin\Views\Topic\DeleteTopic.cshtml"
                  Write(item.LastUpdateTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            </dd>\r\n        </dl>\r\n");
#nullable restore
#line 39 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Admin\Views\Topic\DeleteTopic.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c11033eba45cec0d97dd2e21ddd553b943ee6c46300", async() => {
                WriteLiteral("\r\n        <input type=\"hidden\"  />\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        <a href=\"/Admin/Topic/Index\">Back to List</a>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n\r\n");
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
