#pragma checksum "E:\Univer\Kursa4\WebApplication1\WebApplication1\Views\AcceptedRawMaterials\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a50bc6dab5133efd28ed57bd8710949e94adf7e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AcceptedRawMaterials_Delete), @"mvc.1.0.view", @"/Views/AcceptedRawMaterials/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AcceptedRawMaterials/Delete.cshtml", typeof(AspNetCore.Views_AcceptedRawMaterials_Delete))]
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
#line 1 "E:\Univer\Kursa4\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#line 2 "E:\Univer\Kursa4\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a50bc6dab5133efd28ed57bd8710949e94adf7e", @"/Views/AcceptedRawMaterials/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_AcceptedRawMaterials_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication1.Models.AcceptedRawMaterial>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Univer\Kursa4\WebApplication1\WebApplication1\Views\AcceptedRawMaterials\Delete.cshtml"
  
    ViewData["Title"] = "Удаление";

#line default
#line hidden
            BeginContext(97, 179, true);
            WriteLiteral("\r\n<h2>Удаление</h2>\r\n\r\n<h3>Вы уверены, что хотите удалить это?</h3>\r\n<div>\r\n    <h4>Принятое вторсырье</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(277, 54, false);
#line 15 "E:\Univer\Kursa4\WebApplication1\WebApplication1\Views\AcceptedRawMaterials\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TypeOfRawMaterials));

#line default
#line hidden
            EndContext();
            BeginContext(331, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(375, 50, false);
#line 18 "E:\Univer\Kursa4\WebApplication1\WebApplication1\Views\AcceptedRawMaterials\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TypeOfRawMaterials));

#line default
#line hidden
            EndContext();
            BeginContext(425, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(469, 44, false);
#line 21 "E:\Univer\Kursa4\WebApplication1\WebApplication1\Views\AcceptedRawMaterials\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NumberKG));

#line default
#line hidden
            EndContext();
            BeginContext(513, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(557, 40, false);
#line 24 "E:\Univer\Kursa4\WebApplication1\WebApplication1\Views\AcceptedRawMaterials\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NumberKG));

#line default
#line hidden
            EndContext();
            BeginContext(597, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(641, 44, false);
#line 27 "E:\Univer\Kursa4\WebApplication1\WebApplication1\Views\AcceptedRawMaterials\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee));

#line default
#line hidden
            EndContext();
            BeginContext(685, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(729, 40, false);
#line 30 "E:\Univer\Kursa4\WebApplication1\WebApplication1\Views\AcceptedRawMaterials\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Employee));

#line default
#line hidden
            EndContext();
            BeginContext(769, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(813, 49, false);
#line 33 "E:\Univer\Kursa4\WebApplication1\WebApplication1\Views\AcceptedRawMaterials\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.RoomOfStorage));

#line default
#line hidden
            EndContext();
            BeginContext(862, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(906, 45, false);
#line 36 "E:\Univer\Kursa4\WebApplication1\WebApplication1\Views\AcceptedRawMaterials\Delete.cshtml"
       Write(Html.DisplayFor(model => model.RoomOfStorage));

#line default
#line hidden
            EndContext();
            BeginContext(951, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(995, 47, false);
#line 39 "E:\Univer\Kursa4\WebApplication1\WebApplication1\Views\AcceptedRawMaterials\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DateAndTime));

#line default
#line hidden
            EndContext();
            BeginContext(1042, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1086, 43, false);
#line 42 "E:\Univer\Kursa4\WebApplication1\WebApplication1\Views\AcceptedRawMaterials\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DateAndTime));

#line default
#line hidden
            EndContext();
            BeginContext(1129, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1173, 40, false);
#line 45 "E:\Univer\Kursa4\WebApplication1\WebApplication1\Views\AcceptedRawMaterials\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Cost));

#line default
#line hidden
            EndContext();
            BeginContext(1213, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1257, 36, false);
#line 48 "E:\Univer\Kursa4\WebApplication1\WebApplication1\Views\AcceptedRawMaterials\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Cost));

#line default
#line hidden
            EndContext();
            BeginContext(1293, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1337, 46, false);
#line 51 "E:\Univer\Kursa4\WebApplication1\WebApplication1\Views\AcceptedRawMaterials\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.StoragesID));

#line default
#line hidden
            EndContext();
            BeginContext(1383, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1427, 42, false);
#line 54 "E:\Univer\Kursa4\WebApplication1\WebApplication1\Views\AcceptedRawMaterials\Delete.cshtml"
       Write(Html.DisplayFor(model => model.StoragesID));

#line default
#line hidden
            EndContext();
            BeginContext(1469, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1513, 47, false);
#line 57 "E:\Univer\Kursa4\WebApplication1\WebApplication1\Views\AcceptedRawMaterials\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.RawMaterial));

#line default
#line hidden
            EndContext();
            BeginContext(1560, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1604, 58, false);
#line 60 "E:\Univer\Kursa4\WebApplication1\WebApplication1\Views\AcceptedRawMaterials\Delete.cshtml"
       Write(Html.DisplayFor(model => model.RawMaterial.RawMaterialsID));

#line default
#line hidden
            EndContext();
            BeginContext(1662, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1706, 59, false);
#line 63 "E:\Univer\Kursa4\WebApplication1\WebApplication1\Views\AcceptedRawMaterials\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.HumanResourceDepartment));

#line default
#line hidden
            EndContext();
            BeginContext(1765, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1809, 82, false);
#line 66 "E:\Univer\Kursa4\WebApplication1\WebApplication1\Views\AcceptedRawMaterials\Delete.cshtml"
       Write(Html.DisplayFor(model => model.HumanResourceDepartment.HumanResourcesDepartmentID));

#line default
#line hidden
            EndContext();
            BeginContext(1891, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1929, 233, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02d2a4c75cf84f11b2a6f1ba515ef08c", async() => {
                BeginContext(1955, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1965, 56, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "62e20cacf36246d795d26e38b257c0d4", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 71 "E:\Univer\Kursa4\WebApplication1\WebApplication1\Views\AcceptedRawMaterials\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.AcceptedRawMaterialsID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2021, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(2105, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "736b6de7f96c47eaa851c3a8436ea8ed", async() => {
                    BeginContext(2127, 18, true);
                    WriteLiteral("Вернуться к списку");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2149, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2162, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.Models.AcceptedRawMaterial> Html { get; private set; }
    }
}
#pragma warning restore 1591
