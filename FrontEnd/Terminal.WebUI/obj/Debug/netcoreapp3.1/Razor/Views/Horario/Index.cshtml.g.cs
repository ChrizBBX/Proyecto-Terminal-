#pragma checksum "C:\Users\selvin almendarez\Desktop\adsfadfad\Proyecto-Terminal--Selvin\FrontEnd\Terminal.WebUI\Views\Horario\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "574ceb5688e151ecddb6723d282c2f20db608b64"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Horario_Index), @"mvc.1.0.view", @"/Views/Horario/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"574ceb5688e151ecddb6723d282c2f20db608b64", @"/Views/Horario/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acb4614d0f46ac8f6c0a01df623759886fc0ba6b", @"/Views/_ViewImports.cshtml")]
    public class Views_Horario_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Terminal.WebUI.Models.HorariosViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\selvin almendarez\Desktop\adsfadfad\Proyecto-Terminal--Selvin\FrontEnd\Terminal.WebUI\Views\Horario\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""card"">
        <div class=""card-body"">
            <h1>Horarios</h1>
            <div class=""row"">
                <div class=""col-lg-12"">
                    <div class=""float-e-margins"">
                        <div class=""ibox-title"">
                            <div class=""ibox-tools"">
                                <div class=""row"">
                                    <div class=""col-3"">
                                        <p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "574ceb5688e151ecddb6723d282c2f20db608b646689", async() => {
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
                                        <th class=""text-dark-200""><strong>");
#nullable restore
#line 28 "C:\Users\selvin almendarez\Desktop\adsfadfad\Proyecto-Terminal--Selvin\FrontEnd\Terminal.WebUI\Views\Horario\Index.cshtml"
                                                                     Write(Html.DisplayNameFor(model => model.hora_FechaSalida));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></th>\n                                        <th class=\"text-dark\">");
#nullable restore
#line 29 "C:\Users\selvin almendarez\Desktop\adsfadfad\Proyecto-Terminal--Selvin\FrontEnd\Terminal.WebUI\Views\Horario\Index.cshtml"
                                                         Write(Html.DisplayNameFor(model => model.hora_FechaLlegada));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                                        <th class=\"text-dark\">");
#nullable restore
#line 30 "C:\Users\selvin almendarez\Desktop\adsfadfad\Proyecto-Terminal--Selvin\FrontEnd\Terminal.WebUI\Views\Horario\Index.cshtml"
                                                         Write(Html.DisplayNameFor(model => model.hora_Origen_DeptoNombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                                        <th class=\"text-dark\">");
#nullable restore
#line 31 "C:\Users\selvin almendarez\Desktop\adsfadfad\Proyecto-Terminal--Selvin\FrontEnd\Terminal.WebUI\Views\Horario\Index.cshtml"
                                                         Write(Html.DisplayNameFor(model => model.hora_Destino_DeptoNombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                                        <th class=\"text-dark\">");
#nullable restore
#line 32 "C:\Users\selvin almendarez\Desktop\adsfadfad\Proyecto-Terminal--Selvin\FrontEnd\Terminal.WebUI\Views\Horario\Index.cshtml"
                                                         Write(Html.DisplayNameFor(model => model.hora_CantidadPasajeros));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                                        <th class=\"text-dark\">");
#nullable restore
#line 33 "C:\Users\selvin almendarez\Desktop\adsfadfad\Proyecto-Terminal--Selvin\FrontEnd\Terminal.WebUI\Views\Horario\Index.cshtml"
                                                         Write(Html.DisplayNameFor(model => model.hora_Precio));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                                        <th class=\"text-dark\">Acciones</th>\n                                    </tr>\n                                </thead>\n                                <tbody class=\"text-dark\">\n");
#nullable restore
#line 38 "C:\Users\selvin almendarez\Desktop\adsfadfad\Proyecto-Terminal--Selvin\FrontEnd\Terminal.WebUI\Views\Horario\Index.cshtml"
                                     foreach (var item in Model)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr role=\"row\" data-id=\"");
#nullable restore
#line 40 "C:\Users\selvin almendarez\Desktop\adsfadfad\Proyecto-Terminal--Selvin\FrontEnd\Terminal.WebUI\Views\Horario\Index.cshtml"
                                                           Write(item.hora_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"text-dark align-text-bottom\">\n                                            <td class=\"text-dark odd\">");
#nullable restore
#line 41 "C:\Users\selvin almendarez\Desktop\adsfadfad\Proyecto-Terminal--Selvin\FrontEnd\Terminal.WebUI\Views\Horario\Index.cshtml"
                                                                 Write(Html.DisplayFor(modelItem => item.hora_FechaSalida));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td class=\"text-dark even\">");
#nullable restore
#line 42 "C:\Users\selvin almendarez\Desktop\adsfadfad\Proyecto-Terminal--Selvin\FrontEnd\Terminal.WebUI\Views\Horario\Index.cshtml"
                                                                  Write(Html.DisplayFor(modelItem => item.hora_FechaLlegada));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td class=\"text-dark odd\">");
#nullable restore
#line 43 "C:\Users\selvin almendarez\Desktop\adsfadfad\Proyecto-Terminal--Selvin\FrontEnd\Terminal.WebUI\Views\Horario\Index.cshtml"
                                                                 Write(Html.DisplayFor(modelItem => item.hora_Origen_DeptoNombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td class=\"text-dark even\">");
#nullable restore
#line 44 "C:\Users\selvin almendarez\Desktop\adsfadfad\Proyecto-Terminal--Selvin\FrontEnd\Terminal.WebUI\Views\Horario\Index.cshtml"
                                                                  Write(Html.DisplayFor(modelItem => item.hora_Destino_DeptoNombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td class=\"text-dark odd\">");
#nullable restore
#line 45 "C:\Users\selvin almendarez\Desktop\adsfadfad\Proyecto-Terminal--Selvin\FrontEnd\Terminal.WebUI\Views\Horario\Index.cshtml"
                                                                 Write(Html.DisplayFor(modelItem => item.hora_CantidadPasajeros));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td class=\"text-dark even\">");
#nullable restore
#line 46 "C:\Users\selvin almendarez\Desktop\adsfadfad\Proyecto-Terminal--Selvin\FrontEnd\Terminal.WebUI\Views\Horario\Index.cshtml"
                                                                  Write(Html.DisplayFor(modelItem => item.hora_Precio));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td class=\"text-dark\">\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "574ceb5688e151ecddb6723d282c2f20db608b6414778", async() => {
                WriteLiteral("Detalle");
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
#line 48 "C:\Users\selvin almendarez\Desktop\adsfadfad\Proyecto-Terminal--Selvin\FrontEnd\Terminal.WebUI\Views\Horario\Index.cshtml"
                                                                          WriteLiteral(item.hora_ID);

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
            WriteLiteral(" |\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "574ceb5688e151ecddb6723d282c2f20db608b6417142", async() => {
                WriteLiteral("Editar");
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
#line 49 "C:\Users\selvin almendarez\Desktop\adsfadfad\Proyecto-Terminal--Selvin\FrontEnd\Terminal.WebUI\Views\Horario\Index.cshtml"
                                                                       WriteLiteral(item.hora_ID);

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
            WriteLiteral(" |\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "574ceb5688e151ecddb6723d282c2f20db608b6419502", async() => {
                WriteLiteral("Eliminar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 50 "C:\Users\selvin almendarez\Desktop\adsfadfad\Proyecto-Terminal--Selvin\FrontEnd\Terminal.WebUI\Views\Horario\Index.cshtml"
                                                                         WriteLiteral(item.hora_ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                            </td>\n                                        </tr>\n");
#nullable restore
#line 53 "C:\Users\selvin almendarez\Desktop\adsfadfad\Proyecto-Terminal--Selvin\FrontEnd\Terminal.WebUI\Views\Horario\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tbody>\n                                <tfoot class=\"bg-teal-400\">\n                                    <tr class=\"text-dark\">\n                                        <th class=\"text-dark\">");
#nullable restore
#line 57 "C:\Users\selvin almendarez\Desktop\adsfadfad\Proyecto-Terminal--Selvin\FrontEnd\Terminal.WebUI\Views\Horario\Index.cshtml"
                                                         Write(Html.DisplayNameFor(model => model.hora_FechaSalida));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                                        <th class=\"text-dark\">");
#nullable restore
#line 58 "C:\Users\selvin almendarez\Desktop\adsfadfad\Proyecto-Terminal--Selvin\FrontEnd\Terminal.WebUI\Views\Horario\Index.cshtml"
                                                         Write(Html.DisplayNameFor(model => model.hora_FechaLlegada));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                                        <th class=\"text-dark\">");
#nullable restore
#line 59 "C:\Users\selvin almendarez\Desktop\adsfadfad\Proyecto-Terminal--Selvin\FrontEnd\Terminal.WebUI\Views\Horario\Index.cshtml"
                                                         Write(Html.DisplayNameFor(model => model.hora_Origen_DeptoNombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                                        <th class=\"text-dark\">");
#nullable restore
#line 60 "C:\Users\selvin almendarez\Desktop\adsfadfad\Proyecto-Terminal--Selvin\FrontEnd\Terminal.WebUI\Views\Horario\Index.cshtml"
                                                         Write(Html.DisplayNameFor(model => model.hora_Destino_DeptoNombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                                        <th class=\"text-dark\">");
#nullable restore
#line 61 "C:\Users\selvin almendarez\Desktop\adsfadfad\Proyecto-Terminal--Selvin\FrontEnd\Terminal.WebUI\Views\Horario\Index.cshtml"
                                                         Write(Html.DisplayNameFor(model => model.hora_CantidadPasajeros));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                                        <th class=\"text-dark\">");
#nullable restore
#line 62 "C:\Users\selvin almendarez\Desktop\adsfadfad\Proyecto-Terminal--Selvin\FrontEnd\Terminal.WebUI\Views\Horario\Index.cshtml"
                                                         Write(Html.DisplayNameFor(model => model.hora_Precio));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Terminal.WebUI.Models.HorariosViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
