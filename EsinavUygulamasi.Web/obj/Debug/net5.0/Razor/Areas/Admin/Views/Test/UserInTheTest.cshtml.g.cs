#pragma checksum "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Admin\Views\Test\UserInTheTest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "570e9e6aefdb999849d3d0b851ad0617b53ec986"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Test_UserInTheTest), @"mvc.1.0.view", @"/Areas/Admin/Views/Test/UserInTheTest.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"570e9e6aefdb999849d3d0b851ad0617b53ec986", @"/Areas/Admin/Views/Test/UserInTheTest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Test_UserInTheTest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EsinavUygulamasi.DAL.Models.Database.UserInTheTest>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Admin\Views\Test\UserInTheTest.cshtml"
  
    ViewData["Title"] = "UserInTheTest";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayouth.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container p-3 text-center"">
    <h2>Kullanıcıların Testlere Dağılım listesi</h2>
    <table class=""table table-striped table-hover p-4"" style=""margin-top:30px;"">
        <thead class=""thead-light"">
            <tr>
                <th> test id</th>
                <th> test Name</th>
                <th> Teste giren Kullanıcı sayısı</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 17 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Admin\Views\Test\UserInTheTest.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td style=\"background-color:beige;\">");
#nullable restore
#line 20 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Admin\Views\Test\UserInTheTest.cshtml"
                                                   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td style=\"background-color:beige; text-align:start\"><a class=\"btn\"");
            BeginWriteAttribute("href", " href=\"", 830, "\"", 877, 2);
            WriteAttributeValue("", 837, "/Admin/Test/UserTestInformation/", 837, 32, true);
#nullable restore
#line 21 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Admin\Views\Test\UserInTheTest.cshtml"
WriteAttributeValue("", 869, item.Id, 869, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-id=\"");
#nullable restore
#line 21 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Admin\Views\Test\UserInTheTest.cshtml"
                                                                                                                                            Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 21 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Admin\Views\Test\UserInTheTest.cshtml"
                                                                                                                                                      Write(item.TestName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                    <td style=\"background-color:beige;\">");
#nullable restore
#line 22 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Admin\Views\Test\UserInTheTest.cshtml"
                                                   Write(item.NumberOfUser);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 24 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Admin\Views\Test\UserInTheTest.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EsinavUygulamasi.DAL.Models.Database.UserInTheTest>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591