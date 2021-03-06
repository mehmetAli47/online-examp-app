#pragma checksum "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Admin\Views\Analysis\UsersTestStat.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "862cde71ed116b8cfae83a80c2445511f2e3271c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Analysis_UsersTestStat), @"mvc.1.0.view", @"/Areas/Admin/Views/Analysis/UsersTestStat.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"862cde71ed116b8cfae83a80c2445511f2e3271c", @"/Areas/Admin/Views/Analysis/UsersTestStat.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Analysis_UsersTestStat : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EsinavUygulamasi.DAL.Models.Database.UsersTestStatV>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Admin\Views\Analysis\UsersTestStat.cshtml"
  
    ViewData["Title"] = "GetUsersTestStat";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayouth.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <table class=""table tabletable-striped"">
        <thead>
            <tr>
                <th>test ID</th>
                <th>Test Adı</th>
                <th>Kullanıcı Adı</th>
                <th>Doğru Cevap sayısı</th>
                <th>Yanlış Cevap Sayısı</th>
                <th>Teste içersindeki soru sayısı</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 20 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Admin\Views\Analysis\UsersTestStat.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <th>");
#nullable restore
#line 23 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Admin\Views\Analysis\UsersTestStat.cshtml"
                   Write(item.TestId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 24 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Admin\Views\Analysis\UsersTestStat.cshtml"
                   Write(item.TestName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 25 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Admin\Views\Analysis\UsersTestStat.cshtml"
                   Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 26 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Admin\Views\Analysis\UsersTestStat.cshtml"
                   Write(item.NumberOfCorrect);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 27 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Admin\Views\Analysis\UsersTestStat.cshtml"
                   Write(item.NumberOfWrong);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 28 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Admin\Views\Analysis\UsersTestStat.cshtml"
                   Write(item.numberOfUserAnswer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                </tr>\r\n");
#nullable restore
#line 30 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Admin\Views\Analysis\UsersTestStat.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EsinavUygulamasi.DAL.Models.Database.UsersTestStatV>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
