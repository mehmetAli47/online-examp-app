#pragma checksum "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Admin\Views\Test\SaveTest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d7b257f5d46c5d34ca1c24af766fc9b43333bbf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Test_SaveTest), @"mvc.1.0.view", @"/Areas/Admin/Views/Test/SaveTest.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d7b257f5d46c5d34ca1c24af766fc9b43333bbf", @"/Areas/Admin/Views/Test/SaveTest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Test_SaveTest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("GetTestContent"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Admin\Views\Test\SaveTest.cshtml"
  
    ViewData["Title"] = "GetTestContent";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayouth.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .container {
        margin-top: 20px;
    }

    .soru {
        background-color: azure;
        border-radius: 10px;
        margin-top: 30px;
    }

    #btnRemove {
        width: 100%;
        margin-left: 12px;
        border-radius: 10px;
    }

    #btnSbmit {
        border-radius: 10px;
    }

    #Submit {
        border-radius: 10px;
    }
</style>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d7b257f5d46c5d34ca1c24af766fc9b43333bbf4869", async() => {
                WriteLiteral("\r\n    <div class=\"container\">\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d7b257f5d46c5d34ca1c24af766fc9b43333bbf5168", async() => {
                    WriteLiteral(@"
            <div class=""form-group"">
                <label  class=""control-label"">Test Adı</label>
                <input class=""form-control"" name=""testName"" id=""testName"" type=""text"" />
            </div>
            <div class=""form-group"">
                <label class=""control-label"">Test Başlama tarihi</label>
                <input class=""form-control"" name=""startTime"" id=""startTime"" type=""datetime-local"" />
            </div>
            <div class=""form-group"">
                <label class=""control-label"">Soru Kategorisi</label>
                <select id=""selectTopicListType"" name=""selectTopicListType"" class=""form-control custom-select"" style=""border-radius:5px;padding:2px;"">
                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d7b257f5d46c5d34ca1c24af766fc9b43333bbf6195", async() => {
                        WriteLiteral("seçiniz");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
#nullable restore
#line 46 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Admin\Views\Test\SaveTest.cshtml"
                     foreach (SelectListItem topic in ViewBag.Topic)
                    {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d7b257f5d46c5d34ca1c24af766fc9b43333bbf8145", async() => {
#nullable restore
#line 48 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Admin\Views\Test\SaveTest.cshtml"
                                                Write(topic.Text);

#line default
#line hidden
#nullable disable
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Admin\Views\Test\SaveTest.cshtml"
                           WriteLiteral(topic.Value);

#line default
#line hidden
#nullable disable
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
#nullable restore
#line 49 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Admin\Views\Test\SaveTest.cshtml"
                    }

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"                </select>
                <span class=""text-danger""></span>
            </div>
            <div class=""row"" style=""margin-left:1px;"">
                <div class=""col-10"">
                    <div class=""form-group row"">
                        <label class=""control-label"">Sorular</label>
                        <select id=""selectQuestionListById"" name=""selectQuestionListById"" class=""form-control custom-select"" style=""border-radius:5px;padding:2px;"">
                            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d7b257f5d46c5d34ca1c24af766fc9b43333bbf10865", async() => {
                        WriteLiteral("seçiniz");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
#nullable restore
#line 59 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Admin\Views\Test\SaveTest.cshtml"
                             foreach (SelectListItem question in ViewBag.Question)
                            {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d7b257f5d46c5d34ca1c24af766fc9b43333bbf12846", async() => {
#nullable restore
#line 61 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Admin\Views\Test\SaveTest.cshtml"
                                                                                     Write(question.Text);

#line default
#line hidden
#nullable disable
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 61 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Admin\Views\Test\SaveTest.cshtml"
                                            Write(question.Value);

#line default
#line hidden
#nullable disable
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __tagHelperExecutionContext.AddHtmlAttribute("data-id", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 61 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Admin\Views\Test\SaveTest.cshtml"
                                                             WriteLiteral(question.Value);

#line default
#line hidden
#nullable disable
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
#nullable restore
#line 62 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Admin\Views\Test\SaveTest.cshtml"
                            }

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"                        </select>
                        <span class=""text-danger""></span>
                    </div>
                </div>
                <div class=""col-2"">
                    <input style="" width: 150px; "" id=""btnSbmit"" type=""button"" value=""Ekle"" class=""btn btn-primary"" />
                    <input style="" width: 150px; margin-top:20px; "" id=""Submit"" type=""button"" value=""gönder"" class=""btn btn-success"" />
                </div>
            </div>
            <div class=""questionIdList"">
            </div>
            <input name=""ExamId"" id=""ExamId"" type=""hidden""");
                    BeginWriteAttribute("value", " value=\"", 2984, "\"", 3007, 1);
#nullable restore
#line 74 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Admin\Views\Test\SaveTest.cshtml"
WriteAttributeValue("", 2992, ViewBag.ExamId, 2992, 15, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </div>\r\n");
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
          $(""#selectTopicListType"").change(function(){
              var selected=$(""#selectTopicListType"").val();
              GetQuestionListByTopicId(selected);

          });
          $("".questionIdList"").on(""click"",""#btnRemove"",function(){
             var parent=$(this).parents("".soru"");
             $(parent).remove();
          });
          $(""#Submit"").click(function(){
              var result=$("".questionIdList .soru"");
              var testName=$(""#testName"").val();
              var startTime=$(""#startTime"").val();
              var testObj=new Object();
              const questionIdList=[];
              for(var i=0;i<result.length;i++){
                      questionIdList.push(parseInt($(result).eq(i).attr(""data-id"")));
              }
              testObj.QuestionIdList=questionIdList;
              testObj.Name=testName;
              testObj.StartTime=startTime;
              testObj.ExamId=$(""#ExamId"").val();
      ");
            WriteLiteral(@"        $.ajax({
                  url:'/Admin/Test/SaveTest',
                  data:JSON.stringify(testObj),
                  contentType: ""application/json; charset=utf-8"",
                  type:'post',
                  success:function(testObj){
                      window.location.href=""/Admin/Test/Index"";
                  }
              });

          });

          $(""#btnSbmit"").click(function(){
              var selectedQuestion=$('#selectQuestionListById').find("":selected"");
              var text=$(selectedQuestion).text();
              var qId=$(selectedQuestion).val();
                    var answer1=$(selectedQuestion).attr(""data-answer1"");
                    var answer2=$(selectedQuestion).attr(""data-answer2"");
                    var answer3=$(selectedQuestion).attr(""data-answer3"");
                    var answer4=$(selectedQuestion).attr(""data-answer4"");
                    var questiontext=$("".questionIdList .soru"");
                    if(questiontext!=undefine");
            WriteLiteral(@"d){

                        var found=false;
                        for(var i=0;i<questiontext.length;i++){
                            if($(questiontext).eq(i).attr(""data-id"")==qId){
                                found=true;
                                 break;
                            }
                        }
                        if(!found){
                            $('.questionIdList').append(
                           '<div class=""soru row""  data-id=""'+qId+'"">'
                                +'<div class=""col-10"">'
                                 +text+'</br></br>'
                                 +'<div>A-)'+answer1+'</div>'
                                    +'<div>B-)'+answer2+'</div>'
                                    +'<div>C-)'+answer3+'</div>'
                                    +'<div>D-)'+answer4+'</div>'
                                +'</div>'
                                +'<div class=""col-2"">'
                                  +'<button class=""b");
            WriteLiteral(@"tn btn-danger"" type=""button"" id=""btnRemove""><i class=""fa fa-trash""></i></button>'
                                +'</div>'
                            +'</div>');
                        }
                        else
                            alert(""bu soru zaten ekli"");
                    }else{
                    $('.questionIdList').append(
                           '<div class=""soru"" data-id=""'+qId+'"">'
                               +'<button class=""btn btn-danger"" type=""button"" id=""btnRemove""><i class=""fa fa-trash""></i></button>'
                                +'<div>A-)'+answer1+'</div>'
                                +'<div>B-)'+answer2+'</div>'
                                +'<div>C-)'+answer3+'</div>'
                                +'<div>D-)'+answer4+'</div>'
                            +'</div>');
                       }
          });
           console.log(""liste geldi"");


    });
    function GetQuestion(topicListType){
        $(""#questionList tbody"").html(""""");
            WriteLiteral(@");
        $.ajax({
            url:'/Admin/Test/GetQuestion',
            data:{topicListTypeId:topicListType},
            type:'post',
            success:function(gridView){
                if(gridView== undefined)
                    return;

            for(var i=0; i < gridView.length; i++){
                $(""#questionList tbody"").html(
                  $(""#questionList tbody"").html()
                    + '<tr>'
                        + '<td>' + gridView[i].Id + '</td>'
                        + '<td>' + gridView[i].Name + '</td>'
                        + '<td>' + gridView[i].Answer1 + '</td>'
                        + '<td>' + gridView[i].Answer2 + '</td>'
                        + '<td>' + gridView[i].Answer3 + '</td>'
                        + '<td>' + gridView[i].Answer4 + '</td>'

                + '</tr>');
                }

            }
            ,error:function(){

            }
        });
    }
    function GetQuestionListByTopicId(topicListTypeId){
    ");
            WriteLiteral(@"    $.ajax({
                url:'/Admin/Test/GetQuestion',
                data:{topicListTypeId:topicListTypeId},
                type:'post',
                success:function(data){
                    $('#selectQuestionListById').empty();
                    for (var i = 0; i < data.length; i++) {
                        $('#selectQuestionListById').append(""<option value='"" + data[i].Id + ""' data-answer1='""+data[i].Answer1+""' data-answer2='""+data[i].Answer2+""' data-answer3='""+data[i].Answer3+""' data-answer4='""+data[i].Answer4+""'>"" + data[i].Name + ""</option>"");
                    }
                }
            });
    }
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
