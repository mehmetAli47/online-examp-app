#pragma checksum "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Admin\Views\Test\UpdateTest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "addb376af7ec1c6bc3397ca94ba32d8318fc93e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Test_UpdateTest), @"mvc.1.0.view", @"/Areas/Admin/Views/Test/UpdateTest.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"addb376af7ec1c6bc3397ca94ba32d8318fc93e4", @"/Areas/Admin/Views/Test/UpdateTest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Test_UpdateTest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EsinavUygulamasi.Models.Response.TestVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("UpdateTest"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Admin\Views\Test\UpdateTest.cshtml"
  
    ViewData["Title"] = "UpdateTest";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayouth.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "addb376af7ec1c6bc3397ca94ba32d8318fc93e45364", async() => {
                WriteLiteral("\r\n    <div class=\"container p-5\">\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "addb376af7ec1c6bc3397ca94ba32d8318fc93e45667", async() => {
                    WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <input type=\"hidden\" name=\"testId\" id=\"testId\"");
                    BeginWriteAttribute("value", " value=\"", 706, "\"", 729, 1);
#nullable restore
#line 34 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Admin\Views\Test\UpdateTest.cshtml"
WriteAttributeValue("", 714, ViewBag.TestId, 714, 15, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n                <label>Testin Adı</label>\r\n                <input name=\"name\" id=\"name\" type=\"text\" class=\"form-control\"");
                    BeginWriteAttribute("value", " value=\"", 855, "\"", 874, 1);
#nullable restore
#line 36 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Admin\Views\Test\UpdateTest.cshtml"
WriteAttributeValue("", 863, Model.Name, 863, 11, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label>Testin  Başlama Tarihi</label>\r\n                <input name=\"startTime\" id=\"startTime\" type=\"datetime-local\" class=\"form-control\"");
                    BeginWriteAttribute("value", " value=\'", 1090, "\'", 1164, 1);
#nullable restore
#line 40 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Admin\Views\Test\UpdateTest.cshtml"
WriteAttributeValue("", 1098, Model.StartTime.ToString("yyyy-MM-dd HH:mm:ss")?.Replace(' ','T'), 1098, 66, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label>Soru Konusu</label>\r\n                <select id=\"selectTopicListType\" name=\"selectTopicListType\" class=\"form-control custom-select\">\r\n                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "addb376af7ec1c6bc3397ca94ba32d8318fc93e47922", async() => {
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
#line 46 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Admin\Views\Test\UpdateTest.cshtml"
                     foreach (SelectListItem item in ViewBag.Topic)
                    {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "addb376af7ec1c6bc3397ca94ba32d8318fc93e49873", async() => {
#nullable restore
#line 48 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Admin\Views\Test\UpdateTest.cshtml"
                                               Write(item.Text);

#line default
#line hidden
#nullable disable
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Admin\Views\Test\UpdateTest.cshtml"
                           WriteLiteral(item.Value);

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
#line 49 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Admin\Views\Test\UpdateTest.cshtml"
                    }

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"                </select>
            </div>
            <div class=""row"" style=""margin-left:1px;"">
                <div class=""col-10"">
                    <div class=""form-group row"">
                        <label class=""control-label"">Sorular</label>
                        <select id=""selectQuestionListById"" name=""selectQuestionListById"" class=""form-control custom-select"" style=""border-radius:5px;padding:2px;"">
                            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "addb376af7ec1c6bc3397ca94ba32d8318fc93e412543", async() => {
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
#line 58 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Admin\Views\Test\UpdateTest.cshtml"
                             foreach (SelectListItem question in ViewBag.Question)
                            {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "addb376af7ec1c6bc3397ca94ba32d8318fc93e414526", async() => {
#nullable restore
#line 60 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Admin\Views\Test\UpdateTest.cshtml"
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
#line 60 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Admin\Views\Test\UpdateTest.cshtml"
                                            Write(question.Value);

#line default
#line hidden
#nullable disable
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __tagHelperExecutionContext.AddHtmlAttribute("data-id", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 60 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Admin\Views\Test\UpdateTest.cshtml"
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
#line 61 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Admin\Views\Test\UpdateTest.cshtml"
                            }

#line default
#line hidden
#nullable disable
                    WriteLiteral("                        </select>\r\n                        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "addb376af7ec1c6bc3397ca94ba32d8318fc93e417450", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 63 "C:\Users\mehme\Documents\projects\EsinavUygulamasi\Areas\Admin\Views\Test\UpdateTest.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral(@"
                    </div>
                </div>
                <div class=""col-2"">
                    <input style="" width: 150px; "" id=""btnSbmit"" type=""button"" value=""Ekle"" class=""btn btn-primary"" />
                    <input style="" width: 150px; margin-top:20px; "" id=""Submit"" type=""button"" value=""Güncelle"" class=""btn btn-success"" />
                </div>
            </div>
                <div class=""questionIdList"">
                    
                </div>
        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
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
        var testId=$(""#testId"").val();
        GetTestQuestion(testId);  

          $(""#selectTopicListType"").change(function(){
              var selected=$(""#selectTopicListType"").val();
              GetQuestionListByTopicId(selected);
            

          });
          $("".questionIdList"").on(""click"",""#btnRemove"",function(){
              var parent=$(this).parents("".soru"");
              $(parent).remove();
          });
          $(""#btnSbmit"").click(function(){
              var selectedQuestion=$(""#selectQuestionListById"").find("":selected"");
              var text=$(selectedQuestion).text();
              var qId=$(selectedQuestion).val();
              //gelen içeriğinin okunması işlemi
                    var answer1=$(selectedQuestion).attr(""data-answer1"");
                    var answer2=$(selectedQuestion).attr(""data-answer2"");
                    var answer3=$(selectedQuestion).attr(""data-answer3"");
                    var a");
            WriteLiteral(@"nswer4=$(selectedQuestion).attr(""data-answer4"");
                    var questionText=$("".questionIdList .soru"");
                    if(questionText!=undefined){

                        var found=false;
                        for(var i=0;i<questionText.length;i++){
                            if($(questionText).eq(i).attr(""data-id"")==qId){
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
                                    +'<div>D-)'+answer4+");
            WriteLiteral(@"'</div>'
                                +'</div>'
                                +'<div class=""col-2"">'
                                  +'<button class=""btn btn-danger"" type=""button"" id=""btnRemove""><i class=""fa fa-trash""></i></button>'
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
               ");
            WriteLiteral(@"        }
          });
          $(""#Submit"").click(function(){
              var questions=$("".questionIdList .soru"");
              var testId=$(""#testId"").val();
              var testName=$(""#name"").val();
              var startTime=$(""#startTime"").val();
              var testObj=new Object();
              const questionIdList=[];
              for(var i=0;i<questions.length;i++){
                      questionIdList.push(parseInt($(questions).eq(i).attr(""data-id"")));
              }
              testObj.QuestionIdList=questionIdList;
              testObj.Name=testName;
              testObj.StartTime=startTime;
              testObj.Id=testId;
              testObj.NumberOfQuestion=questionIdList.length;
              $.ajax({
                  url:'/Admin/Test/UpdateTest',
                  data:JSON.stringify(testObj),
                  contentType: ""application/json; charset=utf-8"",
                  type:'post',
                  success:function(testObj){
               ");
            WriteLiteral(@"       window.location.href=""/Admin/Test/Index"";
                  }
              });

          });


    });
    function GetTestQuestion(testListTypeId){
        $.ajax({
            url:'/Admin/Test/GetQuestionListByTestId',
            data:{testListTypeId:testListTypeId},
            type:'post',
            success:function(data){
                for(var i=0;i<data.QuestionVM.length;i++){
                    $("".questionIdList"").append(""<div class='soru row' data-id='""+data.QuestionVM[i].Id+""'>""
                                                +""<div class='col-10'>""
                                                    +""<div>""+data.QuestionVM[i].Name+""</div>""
                                                    +""<div>A-)""+data.QuestionVM[i].Answer1+""</div>""
                                                    +""<div>B-)""+data.QuestionVM[i].Answer2+""</div>""
                                                    +""<div>C-)""+data.QuestionVM[i].Answer3+""</div>""
                            ");
            WriteLiteral(@"                        +""<div>D-)""+data.QuestionVM[i].Answer4+""</div>""
                                                +""</div>""
                                                +""<div class='col-2'>""
                                                    +'<button class=""btn btn-danger"" type=""button"" id=""btnRemove""><i class=""fa fa-trash""></i></button>'
                                                +""</div>""
                                                +""</div>""
                    
                    
                    
                    
                    
                                              );
                }
            }
        });
    }
    function GetQuestionListByTopicId(topicListTypeId){
        $.ajax({
                url:'/Admin/Test/GetQuestion',
                data:{topicListTypeId:topicListTypeId},
                type:'post',
                success:function(data){
                    $('#selectQuestionListById').empty();
                    for (");
            WriteLiteral(@"var i = 0; i < data.length; i++) {
                        $('#selectQuestionListById').append(""<option value='"" + data[i].Id + ""' data-answer1='""+data[i].Answer1+""' data-answer2='""+data[i].Answer2+""' data-answer3='""+data[i].Answer3+""' data-answer4='""+data[i].Answer4+""'>"" + data[i].Name + ""</option>"");
                    }
                }
            });
    }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EsinavUygulamasi.Models.Response.TestVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
