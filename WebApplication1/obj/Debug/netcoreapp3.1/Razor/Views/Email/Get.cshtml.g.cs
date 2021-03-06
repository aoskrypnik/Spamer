#pragma checksum "/Users/andrew/Documents/semestr6/dotnet/practice/WebApplication1/WebApplication1/Views/Email/Get.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5db3fb9957aa78c6e0034a5538a3d81cfd43a938"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Email_Get), @"mvc.1.0.view", @"/Views/Email/Get.cshtml")]
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
#line 1 "/Users/andrew/Documents/semestr6/dotnet/practice/WebApplication1/WebApplication1/Views/_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/andrew/Documents/semestr6/dotnet/practice/WebApplication1/WebApplication1/Views/_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5db3fb9957aa78c6e0034a5538a3d81cfd43a938", @"/Views/Email/Get.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"637209e7eeedf13d00f2cccd93a350b795d01eb6", @"/Views/_ViewImports.cshtml")]
    public class Views_Email_Get : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("sendChosen"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/send"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<script>
        $(document).ready(function () {
                $('#mailTable').on('click', '.send', function () {
                    let subject = $(this).data('subject');
                    let text = $(this).data('text');
                    $('#SendModal').modal('show');
                    $('.subjectHidden').val(subject);
                    $('.textHidden').val(text);
                    $('.radioHidden').val('null');
                });
                $('#anotherBtn').click(function() {
                    let subject = $('#subjectTextBox').val();
                    let text = $('#textTextBox').val();
                    let radio = $('input[name=radio]:checked').val();
                    $('#SendModal').modal('show');
                    $('.subjectHidden').val(subject);
                    $('.textHidden').val(text);
                    $('.radioHidden').val(radio);
                })
            });
</script>

<h4 class=""d-flex justify-content-center"">Оберіть існуючий лист</h4>
<table class=""");
            WriteLiteral("table table-striped\" id=\"mailTable\">\n    <thead>\n    <tr>\n        <th>Тема</th>\n        <th>Текст</th>\n        <th>Дія</th>\n    </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 33 "/Users/andrew/Documents/semestr6/dotnet/practice/WebApplication1/WebApplication1/Views/Email/Get.cshtml"
     foreach (var message in ViewBag.Messages)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>");
#nullable restore
#line 36 "/Users/andrew/Documents/semestr6/dotnet/practice/WebApplication1/WebApplication1/Views/Email/Get.cshtml"
           Write(message.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 37 "/Users/andrew/Documents/semestr6/dotnet/practice/WebApplication1/WebApplication1/Views/Email/Get.cshtml"
           Write(message.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>\n                <a href=\"javascript:void(0);\" class=\"btn btn-sm btn-danger send\"\n                   data-Subject=\"");
#nullable restore
#line 40 "/Users/andrew/Documents/semestr6/dotnet/practice/WebApplication1/WebApplication1/Views/Email/Get.cshtml"
                            Write(message.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\n                   data-Text=\"");
#nullable restore
#line 41 "/Users/andrew/Documents/semestr6/dotnet/practice/WebApplication1/WebApplication1/Views/Email/Get.cshtml"
                         Write(message.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\n                    Надіслати\n                </a>\n            </td>\n        </tr>\n");
#nullable restore
#line 46 "/Users/andrew/Documents/semestr6/dotnet/practice/WebApplication1/WebApplication1/Views/Email/Get.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>
<h4 class=""d-flex justify-content-center"">Введіть інший лист</h4>
<label for=""subjectTextBox"">Тема листа</label>
<input class=""form-control mb-1"" type=""text"" id=""subjectTextBox"">
<label for=""textTextBox"">Текст листа</label>
<textarea class=""form-control mb-1"" id=""textTextBox""></textarea>
<label>Зберегти зазначене повідомлення в базу?</label>
<div class=""form-check"">
    <label class=""form-check-label"">
        <input class=""form-check-input"" type=""radio"" name=""radio"" value=""yes"" checked>
        Так
    </label>
</div>
<div class=""form-check"">
    <label class=""form-check-label"">
        <input class=""form-check-input"" type=""radio"" name=""radio"" value=""no"">
        Ні
    </label>
</div>
<button id=""anotherBtn"" class=""btn btn-outline-primary btn-block mt-2 mb-1"" data-toggle=""modal"" data-target=""#SendModal"">
    Надіслати інший лист
</button>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5db3fb9957aa78c6e0034a5538a3d81cfd43a9388598", async() => {
                WriteLiteral(@"
    <div class=""modal fade"" id=""SendModal"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
        <div class=""modal-dialog"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"">Майже надіслано</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span
                            aria-hidden=""true"">
                            &times;
                        </span>
                    </button>
                </div>
                <div class=""modal-body"">
                    <p>В який відділ бажаєте надіслати?</p>
                    <div class=""form-group"">
                        <select id=""depOption"" name=""Department"" class=""form-control"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5db3fb9957aa78c6e0034a5538a3d81cfd43a9389721", async() => {
                    WriteLiteral("All departments");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
#nullable restore
#line 89 "/Users/andrew/Documents/semestr6/dotnet/practice/WebApplication1/WebApplication1/Views/Email/Get.cshtml"
                             foreach (var department in ViewBag.Departments)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5db3fb9957aa78c6e0034a5538a3d81cfd43a93811287", async() => {
#nullable restore
#line 91 "/Users/andrew/Documents/semestr6/dotnet/practice/WebApplication1/WebApplication1/Views/Email/Get.cshtml"
                                                          Write(department.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 91 "/Users/andrew/Documents/semestr6/dotnet/practice/WebApplication1/WebApplication1/Views/Email/Get.cshtml"
                                   WriteLiteral(department.Id);

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
                WriteLiteral("\n");
#nullable restore
#line 92 "/Users/andrew/Documents/semestr6/dotnet/practice/WebApplication1/WebApplication1/Views/Email/Get.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        </select>
                    </div>
                </div>
                <div class=""modal-footer"">
                    <input type=""hidden"" name=""Subject"" class=""form-control subjectHidden"" required>
                    <input type=""hidden"" name=""Text"" class=""form-control textHidden"" required>
                    <input type=""hidden"" name=""Radio"" class=""form-control radioHidden"" required>
                    <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Скасувати</button>
                    <button type=""submit"" class=""btn btn-primary"">Надіслати</button>
                </div>
            </div>
        </div>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
