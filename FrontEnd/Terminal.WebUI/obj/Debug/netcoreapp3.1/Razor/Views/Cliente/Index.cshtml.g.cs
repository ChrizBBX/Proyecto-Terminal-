#pragma checksum "C:\Users\selvin almendarez\Desktop\adsfadfad\Proyecto-Terminal--Selvin\FrontEnd\Terminal.WebUI\Views\Cliente\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e30f01498e7d1b32093c6a01cb8ed67bee4c9c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_Index), @"mvc.1.0.view", @"/Views/Cliente/Index.cshtml")]
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
#line 1 "C:\Users\selvin almendarez\Desktop\adsfadfad\Proyecto-Terminal--Selvin\FrontEnd\Terminal.WebUI\Views\_ViewImports.cshtml"
using Terminal.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\selvin almendarez\Desktop\adsfadfad\Proyecto-Terminal--Selvin\FrontEnd\Terminal.WebUI\Views\_ViewImports.cshtml"
using Terminal.WebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e30f01498e7d1b32093c6a01cb8ed67bee4c9c8", @"/Views/Cliente/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acb4614d0f46ac8f6c0a01df623759886fc0ba6b", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Terminal.WebUI.Models.ClientesModel>>
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
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\selvin almendarez\Desktop\adsfadfad\Proyecto-Terminal--Selvin\FrontEnd\Terminal.WebUI\Views\Cliente\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div class=""card"">
    <div class=""card-body"">
        <h1>Clientes</h1>
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""float-e-margins"">
                    <div class=""ibox-title"">
                        <div class=""ibox-tools"">
                            <div class=""row"">
                                <div class=""col-3"">
                                    <p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e30f01498e7d1b32093c6a01cb8ed67bee4c9c85980", async() => {
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
#line 30 "C:\Users\selvin almendarez\Desktop\adsfadfad\Proyecto-Terminal--Selvin\FrontEnd\Terminal.WebUI\Views\Cliente\Index.cshtml"
                                                     Write(Html.DisplayNameFor(model => model.clie_ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                                    <th class=\"text-dark\">");
#nullable restore
#line 31 "C:\Users\selvin almendarez\Desktop\adsfadfad\Proyecto-Terminal--Selvin\FrontEnd\Terminal.WebUI\Views\Cliente\Index.cshtml"
                                                     Write(Html.DisplayNameFor(model => model.clie_Nombres));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                                    <th class=\"text-dark\">");
#nullable restore
#line 32 "C:\Users\selvin almendarez\Desktop\adsfadfad\Proyecto-Terminal--Selvin\FrontEnd\Terminal.WebUI\Views\Cliente\Index.cshtml"
                                                     Write(Html.DisplayNameFor(model => model.clie_Apellidos));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                                    <th class=\"text-dark\">");
#nullable restore
#line 33 "C:\Users\selvin almendarez\Desktop\adsfadfad\Proyecto-Terminal--Selvin\FrontEnd\Terminal.WebUI\Views\Cliente\Index.cshtml"
                                                     Write(Html.DisplayNameFor(model => model.clie_DNI));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                                    <th class=\"text-dark\">");
#nullable restore
#line 34 "C:\Users\selvin almendarez\Desktop\adsfadfad\Proyecto-Terminal--Selvin\FrontEnd\Terminal.WebUI\Views\Cliente\Index.cshtml"
                                                     Write(Html.DisplayNameFor(model => model.clie_Sexo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                                    <th class=\"text-dark\">");
#nullable restore
#line 35 "C:\Users\selvin almendarez\Desktop\adsfadfad\Proyecto-Terminal--Selvin\FrontEnd\Terminal.WebUI\Views\Cliente\Index.cshtml"
                                                     Write(Html.DisplayNameFor(model => model.clie_Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                                    <th class=\"text-dark\">");
#nullable restore
#line 36 "C:\Users\selvin almendarez\Desktop\adsfadfad\Proyecto-Terminal--Selvin\FrontEnd\Terminal.WebUI\Views\Cliente\Index.cshtml"
                                                     Write(Html.DisplayNameFor(model => model.clie_Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                                    <th class=\"text-dark\">Acciones</th>\n                                </tr>\n                            </thead>\n                            <tbody>\n");
#nullable restore
#line 41 "C:\Users\selvin almendarez\Desktop\adsfadfad\Proyecto-Terminal--Selvin\FrontEnd\Terminal.WebUI\Views\Cliente\Index.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr role=\"row\" data-id=\"");
#nullable restore
#line 43 "C:\Users\selvin almendarez\Desktop\adsfadfad\Proyecto-Terminal--Selvin\FrontEnd\Terminal.WebUI\Views\Cliente\Index.cshtml"
                                                       Write(item.clie_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"text-dark align-text-bottom\">\n                                        <td>");
#nullable restore
#line 44 "C:\Users\selvin almendarez\Desktop\adsfadfad\Proyecto-Terminal--Selvin\FrontEnd\Terminal.WebUI\Views\Cliente\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.clie_ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        <td>");
#nullable restore
#line 45 "C:\Users\selvin almendarez\Desktop\adsfadfad\Proyecto-Terminal--Selvin\FrontEnd\Terminal.WebUI\Views\Cliente\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.clie_Nombres));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        <td>");
#nullable restore
#line 46 "C:\Users\selvin almendarez\Desktop\adsfadfad\Proyecto-Terminal--Selvin\FrontEnd\Terminal.WebUI\Views\Cliente\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.clie_Apellidos));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        <td>");
#nullable restore
#line 47 "C:\Users\selvin almendarez\Desktop\adsfadfad\Proyecto-Terminal--Selvin\FrontEnd\Terminal.WebUI\Views\Cliente\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.clie_DNI));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        <td>");
#nullable restore
#line 48 "C:\Users\selvin almendarez\Desktop\adsfadfad\Proyecto-Terminal--Selvin\FrontEnd\Terminal.WebUI\Views\Cliente\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.clie_Sexo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        <td>");
#nullable restore
#line 49 "C:\Users\selvin almendarez\Desktop\adsfadfad\Proyecto-Terminal--Selvin\FrontEnd\Terminal.WebUI\Views\Cliente\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.clie_Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        <td>");
#nullable restore
#line 50 "C:\Users\selvin almendarez\Desktop\adsfadfad\Proyecto-Terminal--Selvin\FrontEnd\Terminal.WebUI\Views\Cliente\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.clie_Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        <td>\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e30f01498e7d1b32093c6a01cb8ed67bee4c9c814231", async() => {
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
#line 52 "C:\Users\selvin almendarez\Desktop\adsfadfad\Proyecto-Terminal--Selvin\FrontEnd\Terminal.WebUI\Views\Cliente\Index.cshtml"
                                                                   WriteLiteral(item.clie_ID);

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
            WriteLiteral("\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e30f01498e7d1b32093c6a01cb8ed67bee4c9c816581", async() => {
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
#line 53 "C:\Users\selvin almendarez\Desktop\adsfadfad\Proyecto-Terminal--Selvin\FrontEnd\Terminal.WebUI\Views\Cliente\Index.cshtml"
                                                                      WriteLiteral(item.clie_ID);

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
            WriteLiteral(" |\n                                            <button class=\"btn btn-outline-danger\" id=\"btnEliminar\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3337, "\"", 3372, 3);
            WriteAttributeValue("", 3347, "eliminar(\'", 3347, 10, true);
#nullable restore
#line 54 "C:\Users\selvin almendarez\Desktop\adsfadfad\Proyecto-Terminal--Selvin\FrontEnd\Terminal.WebUI\Views\Cliente\Index.cshtml"
WriteAttributeValue("", 3357, item.clie_ID, 3357, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3370, "\')", 3370, 2, true);
            EndWriteAttribute();
            WriteLiteral(">Eliminar</button>\n                                        </td>\n                                    </tr>\n");
#nullable restore
#line 57 "C:\Users\selvin almendarez\Desktop\adsfadfad\Proyecto-Terminal--Selvin\FrontEnd\Terminal.WebUI\Views\Cliente\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\n                            <tfoot class=\"bg-teal-400\">\n                                <tr class=\"text-dark\">\n                                    <th class=\"text-dark\">");
#nullable restore
#line 61 "C:\Users\selvin almendarez\Desktop\adsfadfad\Proyecto-Terminal--Selvin\FrontEnd\Terminal.WebUI\Views\Cliente\Index.cshtml"
                                                     Write(Html.DisplayNameFor(model => model.clie_ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                                    <th class=\"text-dark\">");
#nullable restore
#line 62 "C:\Users\selvin almendarez\Desktop\adsfadfad\Proyecto-Terminal--Selvin\FrontEnd\Terminal.WebUI\Views\Cliente\Index.cshtml"
                                                     Write(Html.DisplayNameFor(model => model.clie_Nombres));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                                    <th class=\"text-dark\">");
#nullable restore
#line 63 "C:\Users\selvin almendarez\Desktop\adsfadfad\Proyecto-Terminal--Selvin\FrontEnd\Terminal.WebUI\Views\Cliente\Index.cshtml"
                                                     Write(Html.DisplayNameFor(model => model.clie_Apellidos));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                                    <th class=\"text-dark\">");
#nullable restore
#line 64 "C:\Users\selvin almendarez\Desktop\adsfadfad\Proyecto-Terminal--Selvin\FrontEnd\Terminal.WebUI\Views\Cliente\Index.cshtml"
                                                     Write(Html.DisplayNameFor(model => model.clie_DNI));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                                    <th class=\"text-dark\">");
#nullable restore
#line 65 "C:\Users\selvin almendarez\Desktop\adsfadfad\Proyecto-Terminal--Selvin\FrontEnd\Terminal.WebUI\Views\Cliente\Index.cshtml"
                                                     Write(Html.DisplayNameFor(model => model.clie_Sexo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                                    <th class=\"text-dark\">");
#nullable restore
#line 66 "C:\Users\selvin almendarez\Desktop\adsfadfad\Proyecto-Terminal--Selvin\FrontEnd\Terminal.WebUI\Views\Cliente\Index.cshtml"
                                                     Write(Html.DisplayNameFor(model => model.clie_Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                                    <th class=\"text-dark\">");
#nullable restore
#line 67 "C:\Users\selvin almendarez\Desktop\adsfadfad\Proyecto-Terminal--Selvin\FrontEnd\Terminal.WebUI\Views\Cliente\Index.cshtml"
                                                     Write(Html.DisplayNameFor(model => model.clie_Email));

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
#line 79 "C:\Users\selvin almendarez\Desktop\adsfadfad\Proyecto-Terminal--Selvin\FrontEnd\Terminal.WebUI\Views\Cliente\Index.cshtml"
Write(Html.Partial("_Modal_Delete", new Terminal.WebUI.Models.ClientesModel()));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Terminal.WebUI.Models.ClientesModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
