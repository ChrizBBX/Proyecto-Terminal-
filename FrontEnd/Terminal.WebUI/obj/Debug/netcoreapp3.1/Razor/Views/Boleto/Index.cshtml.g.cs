#pragma checksum "C:\Users\selvin almendarez\Documents\GitHub\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Boleto\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b73ebf45ecd0d4dedaddc0e48b5b9f1ee68845df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Boleto_Index), @"mvc.1.0.view", @"/Views/Boleto/Index.cshtml")]
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
#line 1 "C:\Users\selvin almendarez\Documents\GitHub\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\_ViewImports.cshtml"
using Terminal.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\selvin almendarez\Documents\GitHub\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\_ViewImports.cshtml"
using Terminal.WebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b73ebf45ecd0d4dedaddc0e48b5b9f1ee68845df", @"/Views/Boleto/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acbe80c8ae054dc5357aa4687981182e4e6d61f2", @"/Views/_ViewImports.cshtml")]
    public class Views_Boleto_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Terminal.WebUI.Models.BoletosViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\selvin almendarez\Documents\GitHub\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Boleto\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""card"">
    <div class=""card-body"">
        <h1>Boletos</h1>
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""float-e-margins"">
                    <div class=""ibox-title"">
                        <div class=""ibox-tools"">
                            <div class=""row"">
                                <div class=""col-3"">
                                    <p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b73ebf45ecd0d4dedaddc0e48b5b9f1ee68845df5960", async() => {
                WriteLiteral("Nuevo Registro");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</p>
                                </div>
                            </div>
                        </div>
                    </div>
                    <br />
                    <div class=""table-responsive"">
                        <table class=""table text-nowrap table-striped table-hover dataTables-example"" id=""DataTable"">
                            <thead class=""bg-teal-400"">
                                <tr class=""text-dark"">
                                    <th class=""text-dark"">");
#nullable restore
#line 29 "C:\Users\selvin almendarez\Documents\GitHub\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Boleto\Index.cshtml"
                                                     Write(Html.DisplayNameFor(model => model.bole_ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    <th class=\"text-dark\">");
#nullable restore
#line 30 "C:\Users\selvin almendarez\Documents\GitHub\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Boleto\Index.cshtml"
                                                     Write(Html.DisplayNameFor(model => model.bole_clie_Nombre_Completo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    <th class=\"text-dark\">");
#nullable restore
#line 31 "C:\Users\selvin almendarez\Documents\GitHub\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Boleto\Index.cshtml"
                                                     Write(Html.DisplayNameFor(model => model.bole_hora_Origen_Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    <th class=\"text-dark\">");
#nullable restore
#line 32 "C:\Users\selvin almendarez\Documents\GitHub\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Boleto\Index.cshtml"
                                                     Write(Html.DisplayNameFor(model => model.bole_hora_Destino_Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    <th class=\"text-dark\">");
#nullable restore
#line 33 "C:\Users\selvin almendarez\Documents\GitHub\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Boleto\Index.cshtml"
                                                     Write(Html.DisplayNameFor(model => model.bole_Fecha));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    <th class=\"text-dark\">");
#nullable restore
#line 34 "C:\Users\selvin almendarez\Documents\GitHub\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Boleto\Index.cshtml"
                                                     Write(Html.DisplayNameFor(model => model.comp_Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    <th class=\"text-dark\">Acciones</th>\r\n                                </tr>\r\n                            </thead>\r\n                            <tbody class=\"text-dark\">\r\n");
#nullable restore
#line 39 "C:\Users\selvin almendarez\Documents\GitHub\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Boleto\Index.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr role=\"row\" data-id=\"");
#nullable restore
#line 41 "C:\Users\selvin almendarez\Documents\GitHub\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Boleto\Index.cshtml"
                                                       Write(item.bole_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"text-dark align-text-bottom\">\r\n                                        <td>");
#nullable restore
#line 42 "C:\Users\selvin almendarez\Documents\GitHub\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Boleto\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.bole_ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 43 "C:\Users\selvin almendarez\Documents\GitHub\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Boleto\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.bole_clie_Nombre_Completo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 44 "C:\Users\selvin almendarez\Documents\GitHub\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Boleto\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.bole_hora_Origen_Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 45 "C:\Users\selvin almendarez\Documents\GitHub\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Boleto\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.bole_hora_Destino_Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 46 "C:\Users\selvin almendarez\Documents\GitHub\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Boleto\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.bole_Fecha));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 47 "C:\Users\selvin almendarez\Documents\GitHub\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Boleto\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.comp_Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b73ebf45ecd0d4dedaddc0e48b5b9f1ee68845df13438", async() => {
                WriteLiteral("Editar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 49 "C:\Users\selvin almendarez\Documents\GitHub\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Boleto\Index.cshtml"
                                                                   WriteLiteral(item.bole_ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b73ebf45ecd0d4dedaddc0e48b5b9f1ee68845df15781", async() => {
                WriteLiteral("Detalles");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 50 "C:\Users\selvin almendarez\Documents\GitHub\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Boleto\Index.cshtml"
                                                                      WriteLiteral(item.bole_ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                                            <button class=\"btn btn-outline-danger\" id=\"btnEliminar\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3273, "\"", 3308, 3);
            WriteAttributeValue("", 3283, "eliminar(\'", 3283, 10, true);
#nullable restore
#line 51 "C:\Users\selvin almendarez\Documents\GitHub\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Boleto\Index.cshtml"
WriteAttributeValue("", 3293, item.bole_ID, 3293, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3306, "\')", 3306, 2, true);
            EndWriteAttribute();
            WriteLiteral(">Eliminar</button>\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 54 "C:\Users\selvin almendarez\Documents\GitHub\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Boleto\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n                            <tfoot class=\"bg-teal-400\">\r\n                                <tr class=\"text-dark\">\r\n                                    <th class=\"text-dark\">");
#nullable restore
#line 58 "C:\Users\selvin almendarez\Documents\GitHub\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Boleto\Index.cshtml"
                                                     Write(Html.DisplayNameFor(model => model.bole_ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    <th class=\"text-dark\">");
#nullable restore
#line 59 "C:\Users\selvin almendarez\Documents\GitHub\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Boleto\Index.cshtml"
                                                     Write(Html.DisplayNameFor(model => model.bole_clie_Nombre_Completo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    <th class=\"text-dark\">");
#nullable restore
#line 60 "C:\Users\selvin almendarez\Documents\GitHub\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Boleto\Index.cshtml"
                                                     Write(Html.DisplayNameFor(model => model.bole_hora_Origen_Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    <th class=\"text-dark\">");
#nullable restore
#line 61 "C:\Users\selvin almendarez\Documents\GitHub\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Boleto\Index.cshtml"
                                                     Write(Html.DisplayNameFor(model => model.bole_hora_Destino_Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    <th class=\"text-dark\">");
#nullable restore
#line 62 "C:\Users\selvin almendarez\Documents\GitHub\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Boleto\Index.cshtml"
                                                     Write(Html.DisplayNameFor(model => model.bole_Fecha));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    <th class=\"text-dark\">");
#nullable restore
#line 63 "C:\Users\selvin almendarez\Documents\GitHub\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Boleto\Index.cshtml"
                                                     Write(Html.DisplayNameFor(model => model.comp_Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</th>
                                    <th class=""text-dark"">Acciones</th>
                                </tr>
                            </tfoot>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

");
#nullable restore
#line 75 "C:\Users\selvin almendarez\Documents\GitHub\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Boleto\Index.cshtml"
Write(Html.Partial("_Modal_Delete", new Terminal.WebUI.Models.BoletosViewModel()));

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Terminal.WebUI.Models.BoletosViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
