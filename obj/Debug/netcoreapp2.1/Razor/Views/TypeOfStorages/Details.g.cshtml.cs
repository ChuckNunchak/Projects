#pragma checksum "E:\Univer\Kursa4\WebApplication1\WebApplication1\Views\TypeOfStorages\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "276dbd11f0dca3fbe7a68dcb8db3850a15662a0c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TypeOfStorages_Details), @"mvc.1.0.view", @"/Views/TypeOfStorages/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TypeOfStorages/Details.cshtml", typeof(AspNetCore.Views_TypeOfStorages_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"276dbd11f0dca3fbe7a68dcb8db3850a15662a0c", @"/Views/TypeOfStorages/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_TypeOfStorages_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication1.Models.TypeOfStorage>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Univer\Kursa4\WebApplication1\WebApplication1\Views\TypeOfStorages\Details.cshtml"
  
    ViewData["Title"] = "Описание";

#line default
#line hidden
            BeginContext(91, 139, true);
            WriteLiteral("\r\n<h2>Описание</h2>\r\n\r\n<div>\r\n    <h4>Типы складских помещений</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(231, 56, false);
#line 14 "E:\Univer\Kursa4\WebApplication1\WebApplication1\Views\TypeOfStorages\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NameOfTypeOfStorages));

#line default
#line hidden
            EndContext();
            BeginContext(287, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(331, 52, false);
#line 17 "E:\Univer\Kursa4\WebApplication1\WebApplication1\Views\TypeOfStorages\Details.cshtml"
       Write(Html.DisplayFor(model => model.NameOfTypeOfStorages));

#line default
#line hidden
            EndContext();
            BeginContext(383, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(427, 64, false);
#line 20 "E:\Univer\Kursa4\WebApplication1\WebApplication1\Views\TypeOfStorages\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TypesOfRawMaterialsInStorage));

#line default
#line hidden
            EndContext();
            BeginContext(491, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(535, 60, false);
#line 23 "E:\Univer\Kursa4\WebApplication1\WebApplication1\Views\TypeOfStorages\Details.cshtml"
       Write(Html.DisplayFor(model => model.TypesOfRawMaterialsInStorage));

#line default
#line hidden
            EndContext();
            BeginContext(595, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(639, 50, false);
#line 26 "E:\Univer\Kursa4\WebApplication1\WebApplication1\Views\TypeOfStorages\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FireProtection));

#line default
#line hidden
            EndContext();
            BeginContext(689, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(733, 46, false);
#line 29 "E:\Univer\Kursa4\WebApplication1\WebApplication1\Views\TypeOfStorages\Details.cshtml"
       Write(Html.DisplayFor(model => model.FireProtection));

#line default
#line hidden
            EndContext();
            BeginContext(779, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(823, 52, false);
#line 32 "E:\Univer\Kursa4\WebApplication1\WebApplication1\Views\TypeOfStorages\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SpecialEquipment));

#line default
#line hidden
            EndContext();
            BeginContext(875, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(919, 48, false);
#line 35 "E:\Univer\Kursa4\WebApplication1\WebApplication1\Views\TypeOfStorages\Details.cshtml"
       Write(Html.DisplayFor(model => model.SpecialEquipment));

#line default
#line hidden
            EndContext();
            BeginContext(967, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1011, 44, false);
#line 38 "E:\Univer\Kursa4\WebApplication1\WebApplication1\Views\TypeOfStorages\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Humidity));

#line default
#line hidden
            EndContext();
            BeginContext(1055, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1099, 40, false);
#line 41 "E:\Univer\Kursa4\WebApplication1\WebApplication1\Views\TypeOfStorages\Details.cshtml"
       Write(Html.DisplayFor(model => model.Humidity));

#line default
#line hidden
            EndContext();
            BeginContext(1139, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1186, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f6c55d5dddf247abb74d08455db5c2a6", async() => {
                BeginContext(1246, 8, true);
                WriteLiteral("Изменить");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 46 "E:\Univer\Kursa4\WebApplication1\WebApplication1\Views\TypeOfStorages\Details.cshtml"
                           WriteLiteral(Model.TypeOfStoragesID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1258, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1266, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "250146237c41450585301f0729b16dd9", async() => {
                BeginContext(1288, 18, true);
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
            BeginContext(1310, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.Models.TypeOfStorage> Html { get; private set; }
    }
}
#pragma warning restore 1591
