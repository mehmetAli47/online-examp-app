#pragma checksum "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Admin\Views\User\UserDelete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac143d2009df85e1732fc0d88b83a85182e66443"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_User_UserDelete), @"mvc.1.0.view", @"/Areas/Admin/Views/User/UserDelete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac143d2009df85e1732fc0d88b83a85182e66443", @"/Areas/Admin/Views/User/UserDelete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_User_UserDelete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EsinavUygulamasi.DAL.Models.Database.User>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "/User/UserDelete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Admin\Views\User\UserDelete.cshtml"
  
    ViewData["Title"] = "UserDelete";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayouth.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container p-5\">\r\n");
#nullable restore
#line 8 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Admin\Views\User\UserDelete.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <dl class=\"row\">\r\n            <dt class=\"col-sm-2\">\r\n               <label>Kullanıcı Id:</label>\r\n               <label>");
#nullable restore
#line 13 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Admin\Views\User\UserDelete.cshtml"
                 Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                <label>Adı:</label>\r\n               <label>");
#nullable restore
#line 17 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Admin\Views\User\UserDelete.cshtml"
                 Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                <label>Soyadı:</label>\r\n               <label>");
#nullable restore
#line 21 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Admin\Views\User\UserDelete.cshtml"
                 Write(item.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                <label>Kullanıcı Adı:</label>\r\n               <label>");
#nullable restore
#line 25 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Admin\Views\User\UserDelete.cshtml"
                 Write(item.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                 <label>Şifre:</label>\r\n               <label>");
#nullable restore
#line 29 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Admin\Views\User\UserDelete.cshtml"
                 Write(item.Password);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                 <label>Kullanıcı email:</label>\r\n               <label>");
#nullable restore
#line 33 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Admin\Views\User\UserDelete.cshtml"
                 Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                <label>Kayıt Oluşturma Zamanı:</label>\r\n               <label>");
#nullable restore
#line 37 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Admin\Views\User\UserDelete.cshtml"
                 Write(item.CreateTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                 <label>En son Güncelleme zamanı:</label>\r\n               <label>");
#nullable restore
#line 41 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Admin\Views\User\UserDelete.cshtml"
                 Write(item.LastUpdateTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            </dd>\r\n        </dl>\r\n");
#nullable restore
#line 44 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Admin\Views\User\UserDelete.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac143d2009df85e1732fc0d88b83a85182e664437578", async() => {
                WriteLiteral("\r\n        <input type=\"hidden\"  />\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        <a href=\"/Admin/User/Index\">Back to List</a>\r\n    ");
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
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EsinavUygulamasi.DAL.Models.Database.User>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591