#pragma checksum "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Student\Views\Test\TestContent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e312a27707a7a417bc3aff4576545a35e98d481d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Student_Views_Test_TestContent), @"mvc.1.0.view", @"/Areas/Student/Views/Test/TestContent.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e312a27707a7a417bc3aff4576545a35e98d481d", @"/Areas/Student/Views/Test/TestContent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Areas/Student/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Student_Views_Test_TestContent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EsinavUygulamasi.Models.Response.QuestionVM>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("Test p-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Student\Views\Test\TestContent.cshtml"
  
    ViewData["Title"] = "Test";
    Layout = "~/Areas/Student/Views/Shared/_StudentLayout.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e312a27707a7a417bc3aff4576545a35e98d481d4213", async() => {
                WriteLiteral("\r\n    <script src=\"//cdn.jsdelivr.net/npm/sweetalert2@11\"></script>\r\n");
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
            WriteLiteral(@"
<style>
    .time {
        margin-left: -257px;
        height: 0px;
        width: 225px;
        position: fixed;
        margin-top: -40px;
    }

    .Test {
        display: flex;
        flex-direction: row;
        justify-content: space-between;
    }

    .container {
        display: contents;
    }
</style>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e312a27707a7a417bc3aff4576545a35e98d481d5589", async() => {
                WriteLiteral("\r\n    <section");
                BeginWriteAttribute("class", " class=\"", 610, "\"", 618, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n        <div class=\"container\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e312a27707a7a417bc3aff4576545a35e98d481d6069", async() => {
                    WriteLiteral("\r\n                <div class=\"time p-5\"");
                    BeginWriteAttribute("name", " name=\"", 745, "\"", 752, 0);
                    EndWriteAttribute();
                    WriteLiteral(" id=\"00:30:00\" style=\"margin-left:90px;height: 130px;\">\r\n                    <h2 id=\"timecountdown\"></h2>\r\n                </div>\r\n                <div class=\"questionlist\" style=\"width: 55%;margin-left: 450px;\">\r\n");
#nullable restore
#line 37 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Student\Views\Test\TestContent.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                        <input class=\"questionListById\" type=\"hidden\"");
                    BeginWriteAttribute("value", " value=\"", 1109, "\"", 1125, 1);
#nullable restore
#line 39 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Student\Views\Test\TestContent.cshtml"
WriteAttributeValue("", 1117, item.Id, 1117, 8, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" />
                        <div class=""question"">
                            <div class=""name row"">
                                <div class=""name col-md-12 p-3 "" style=""background-color:burlywood"">
                                    <label for=""validationCustom01"">");
#nullable restore
#line 43 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Student\Views\Test\TestContent.cshtml"
                                                               Write(item.Name);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"</label>
                                </div>
                            </div>
                            <div class=""answer row"">

                                <div class=""col-md-12 p-3 "">
                                    <input class=""custom-radio""");
                    BeginWriteAttribute("name", " name=\"", 1678, "\"", 1693, 1);
#nullable restore
#line 49 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Student\Views\Test\TestContent.cshtml"
WriteAttributeValue("", 1685, item.Id, 1685, 8, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" type=\"radio\"");
                    BeginWriteAttribute("id", " id=\"", 1707, "\"", 1725, 1);
#nullable restore
#line 49 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Student\Views\Test\TestContent.cshtml"
WriteAttributeValue("", 1712, item.Answer1, 1712, 13, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    BeginWriteAttribute("value", " value=\"", 1726, "\"", 1747, 1);
#nullable restore
#line 49 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Student\Views\Test\TestContent.cshtml"
WriteAttributeValue("", 1734, item.Answer1, 1734, 13, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">\r\n                                    <label");
                    BeginWriteAttribute("for", " for=\"", 1793, "\"", 1812, 1);
#nullable restore
#line 50 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Student\Views\Test\TestContent.cshtml"
WriteAttributeValue("", 1799, item.Answer1, 1799, 13, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">");
#nullable restore
#line 50 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Student\Views\Test\TestContent.cshtml"
                                                          Write(item.Answer1);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</label>\r\n                                </div>\r\n                                <div class=\"col-md-12 p-3\">\r\n                                    <input class=\"custom-radio\"");
                    BeginWriteAttribute("name", " name=\"", 2001, "\"", 2016, 1);
#nullable restore
#line 53 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Student\Views\Test\TestContent.cshtml"
WriteAttributeValue("", 2008, item.Id, 2008, 8, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" type=\"radio\"");
                    BeginWriteAttribute("id", " id=\"", 2030, "\"", 2048, 1);
#nullable restore
#line 53 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Student\Views\Test\TestContent.cshtml"
WriteAttributeValue("", 2035, item.Answer2, 2035, 13, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    BeginWriteAttribute("value", " value=\"", 2049, "\"", 2070, 1);
#nullable restore
#line 53 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Student\Views\Test\TestContent.cshtml"
WriteAttributeValue("", 2057, item.Answer2, 2057, 13, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">\r\n                                    <label");
                    BeginWriteAttribute("for", " for=\"", 2116, "\"", 2135, 1);
#nullable restore
#line 54 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Student\Views\Test\TestContent.cshtml"
WriteAttributeValue("", 2122, item.Answer2, 2122, 13, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">");
#nullable restore
#line 54 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Student\Views\Test\TestContent.cshtml"
                                                          Write(item.Answer2);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</label>\r\n                                </div>\r\n                                <div class=\"col-md-12 p-3\">\r\n                                    <input class=\"custom-radio\"");
                    BeginWriteAttribute("name", " name=\"", 2324, "\"", 2339, 1);
#nullable restore
#line 57 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Student\Views\Test\TestContent.cshtml"
WriteAttributeValue("", 2331, item.Id, 2331, 8, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" type=\"radio\"");
                    BeginWriteAttribute("id", " id=\"", 2353, "\"", 2371, 1);
#nullable restore
#line 57 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Student\Views\Test\TestContent.cshtml"
WriteAttributeValue("", 2358, item.Answer3, 2358, 13, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    BeginWriteAttribute("value", " value=\"", 2372, "\"", 2393, 1);
#nullable restore
#line 57 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Student\Views\Test\TestContent.cshtml"
WriteAttributeValue("", 2380, item.Answer3, 2380, 13, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">\r\n                                    <label");
                    BeginWriteAttribute("for", " for=\"", 2439, "\"", 2458, 1);
#nullable restore
#line 58 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Student\Views\Test\TestContent.cshtml"
WriteAttributeValue("", 2445, item.Answer3, 2445, 13, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">");
#nullable restore
#line 58 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Student\Views\Test\TestContent.cshtml"
                                                          Write(item.Answer3);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</label>\r\n                                </div>\r\n                                <div class=\"col-md-12 p-3\">\r\n                                    <input class=\"custom-radio\"");
                    BeginWriteAttribute("name", " name=\"", 2647, "\"", 2662, 1);
#nullable restore
#line 61 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Student\Views\Test\TestContent.cshtml"
WriteAttributeValue("", 2654, item.Id, 2654, 8, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" type=\"radio\"");
                    BeginWriteAttribute("id", " id=\"", 2676, "\"", 2694, 1);
#nullable restore
#line 61 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Student\Views\Test\TestContent.cshtml"
WriteAttributeValue("", 2681, item.Answer4, 2681, 13, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    BeginWriteAttribute("value", " value=\"", 2695, "\"", 2716, 1);
#nullable restore
#line 61 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Student\Views\Test\TestContent.cshtml"
WriteAttributeValue("", 2703, item.Answer4, 2703, 13, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">\r\n                                    <label");
                    BeginWriteAttribute("for", " for=\"", 2762, "\"", 2781, 1);
#nullable restore
#line 62 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Student\Views\Test\TestContent.cshtml"
WriteAttributeValue("", 2768, item.Answer4, 2768, 13, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">");
#nullable restore
#line 62 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Student\Views\Test\TestContent.cshtml"
                                                          Write(item.Answer4);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</label>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 66 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Student\Views\Test\TestContent.cshtml"
                    }

#line default
#line hidden
#nullable disable
                    WriteLiteral("                </div>\r\n                <div class=\"veriler\"></div>\r\n                <input name=\"TestId\" id=\"TestId\" type=\"hidden\"");
                    BeginWriteAttribute("value", " value=\"", 3068, "\"", 3091, 1);
#nullable restore
#line 69 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Student\Views\Test\TestContent.cshtml"
WriteAttributeValue("", 3076, ViewBag.TestId, 3076, 15, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n                <input name=\"ExamId\" id=\"ExamId\" type=\"hidden\"");
                    BeginWriteAttribute("value", " value=\"", 3159, "\"", 3182, 1);
#nullable restore
#line 70 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Student\Views\Test\TestContent.cshtml"
WriteAttributeValue("", 3167, ViewBag.ExamId, 3167, 15, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            <div class=\"text-center\">\r\n");
                WriteLiteral("                <input style=\" width: 150px;\" id=\"btnSbmit\" type=\"button\" value=\"Testi Tamamla\" class=\"btn btn-primary\" />\r\n            </div>\r\n        </div>\r\n    </section>\r\n");
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
            WriteLiteral(@"
<script>
    $(document).ready(function(){
        var testResultObj=new Object();
             testResultObj.TestId=$(""#TestId"").val();
             testResultObj.ExamId=$(""#ExamId"").val();
          var timer2 = $("".time"").attr(""id"");
          var interval = setInterval(function() {
          var timer = timer2.split(':');
          var hours = parseInt(timer[0], 0);
          var minutes = parseInt(timer[1], 0);
          var seconds = parseInt(timer[2], 0);
          --seconds;
          minutes=(seconds<0)? --minutes:minutes;
          hours=(minutes<0)? --hours:hours;
          minutes=(minutes<0)? 59:minutes;
          seconds=(seconds<0)? 59:seconds;
            if(hours<0){
                testResultObj.QuestionAnswerList=[];
                var questions=$("".custom-radio:checked"");
                for(var i=0;i<$(questions).length;i++){
                    var question=$(questions).eq(i);
                    var answer=new Object();
                    answer.QuestionId=$(qu");
            WriteLiteral(@"estion).attr(""name"");
                    answer.QuestionAnswer=$(question).val();
                    testResultObj.QuestionAnswerList.push(answer);
                        }
                 clearInterval(interval);
                $.ajax({
                   url:""/Student/Test/TestContent"",
                   data:JSON.stringify(testResultObj),
                   contentType:""application/json; charset=utf-8"",
                   type:""post"",
                   success:function(data){
                       if(data.IsSuccess==true){
                           Swal.fire({
                                  title: 'Sınav Süreniz Bitmiştir.Sınavınız Sonlandırılacaktır!!',
                                  allowOutsideClick: false
                            }).then((result) => {
                                  window.location.href=""/Student/Test/TestResult/""+testResultObj.TestId;
                            })
                            }
                       else{}                  
   ");
            WriteLiteral(@"                     }
                            });
                }
          hours=(hours<10)? '0'+hours:hours;
          minutes=(minutes< 10)? '0'+minutes:minutes;
          seconds=(seconds<10)? '0'+seconds:seconds;

          $('#timecountdown').html(hours+':'+minutes + ':' + seconds);
          timer2 =hours+':'+minutes + ':' + seconds;
        }, 1000);

        $(""#btnSbmit"").click(function (){

            testResultObj.QuestionAnswerList=[];
            var questions=$("".custom-radio:checked"");
            for(var i=0;i<$(questions).length;i++){
                var question=$(questions).eq(i);
                var answer=new Object();
                answer.QuestionId=$(question).attr(""name"");
                answer.QuestionAnswer=$(question).val();
                testResultObj.QuestionAnswerList.push(answer);
            }


           $.ajax({
               url:""/Student/Test/TestContent"",
               data:JSON.stringify(testResultObj),
               contentTyp");
            WriteLiteral(@"e: ""application/json; charset=utf-8"",
               type:""post"",
               success:function(data){
                   if(data.IsSuccess==true){
                        window.location.href=""/Student/Test/TestResult/""+testResultObj.TestId;
                   }
                   else{
                       //haata
                   }

                  }
           });
          });
    });
</script>");
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