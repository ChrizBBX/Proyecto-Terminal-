#pragma checksum "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Cliente\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3ad0f6733008ae3b1b86afcca422c815985db2b"
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
#line 1 "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\_ViewImports.cshtml"
using Terminal.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\_ViewImports.cshtml"
using Terminal.WebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3ad0f6733008ae3b1b86afcca422c815985db2b", @"/Views/Cliente/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acbe80c8ae054dc5357aa4687981182e4e6d61f2", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Terminal.WebUI.Models.ClientesModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("New"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn bg-purple-700 text-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-secondary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Cliente\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div class=""card border-5"">
    <div class=""card-body"">

        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""float-e-margins"">
                    <div class=""ibox-title"">
                        <div class=""ibox-tools  align-items-center"">
                            <div class=""row"">
                                <div class=""col-5""></div>
                                <div class=""col-4"">
                                    <strong><span style=""font-family: Cooper; color: indigo; font-size: xx-large;"">Clientes</span></strong>
                                </div>
                                <div class=""col-3""></div>
                            </div>
                            <div class=""row"">
                                <div class=""col-5""></div>
                                <div class=""col-4"">
                                    <p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3ad0f6733008ae3b1b86afcca422c815985db2b6847", async() => {
                WriteLiteral("Nuevo cliente");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</p>
                                </div>
                                <div class=""col-3""></div>
                            </div>
                        </div>
                    </div>
                    <br />
                    <div class=""table-responsive-xxl"">
                        <table class=""table text-nowrap table-striped table-hover dataTables-example"" id=""DataTable"">
                            <thead");
            BeginWriteAttribute("class", " class=\"", 1597, "\"", 1605, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <tr class=\"text-dark\">\r\n                                    <th class=\"text-dark\">");
#nullable restore
#line 39 "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Cliente\Index.cshtml"
                                                     Write(Html.DisplayNameFor(model => model.clie_ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    <th class=\"text-dark\">");
#nullable restore
#line 40 "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Cliente\Index.cshtml"
                                                     Write(Html.DisplayNameFor(model => model.clie_Nombres));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    <th class=\"text-dark\">");
#nullable restore
#line 41 "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Cliente\Index.cshtml"
                                                     Write(Html.DisplayNameFor(model => model.clie_Apellidos));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    <th class=\"text-dark\">");
#nullable restore
#line 42 "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Cliente\Index.cshtml"
                                                     Write(Html.DisplayNameFor(model => model.clie_DNI));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    <th class=\"text-dark\">");
#nullable restore
#line 43 "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Cliente\Index.cshtml"
                                                     Write(Html.DisplayNameFor(model => model.clie_Sexo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    <th class=\"text-dark\">");
#nullable restore
#line 44 "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Cliente\Index.cshtml"
                                                     Write(Html.DisplayNameFor(model => model.clie_Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    <th class=\"text-dark\">");
#nullable restore
#line 45 "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Cliente\Index.cshtml"
                                                     Write(Html.DisplayNameFor(model => model.clie_Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    <th class=\"text-dark\">Acciones</th>\r\n                                </tr>\r\n                            </thead>\r\n                            <tbody>\r\n");
#nullable restore
#line 50 "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Cliente\Index.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr role=\"row\" data-id=\"");
#nullable restore
#line 52 "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Cliente\Index.cshtml"
                                                       Write(item.clie_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"text-dark align-text-bottom even\">\r\n                                        <td>");
#nullable restore
#line 53 "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Cliente\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.clie_ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 54 "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Cliente\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.clie_Nombres));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 55 "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Cliente\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.clie_Apellidos));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 56 "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Cliente\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.clie_DNI));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 57 "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Cliente\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.clie_Sexo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 58 "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Cliente\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.clie_Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 59 "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Cliente\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.clie_Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3ad0f6733008ae3b1b86afcca422c815985db2b15314", async() => {
                WriteLiteral("Editar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 61 "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Cliente\Index.cshtml"
                                                                   WriteLiteral(item.clie_ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3ad0f6733008ae3b1b86afcca422c815985db2b17661", async() => {
                WriteLiteral("Detalle");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 62 "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Cliente\Index.cshtml"
                                                                      WriteLiteral(item.clie_ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                                            <button class=\"btn btn-outline-danger btn-sm\" id=\"btnEliminar\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3988, "\"", 4023, 3);
            WriteAttributeValue("", 3998, "eliminar(\'", 3998, 10, true);
#nullable restore
#line 63 "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Cliente\Index.cshtml"
WriteAttributeValue("", 4008, item.clie_ID, 4008, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4021, "\')", 4021, 2, true);
            EndWriteAttribute();
            WriteLiteral(">Eliminar</button>\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 66 "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Cliente\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n                            <tfoot");
            BeginWriteAttribute("class", " class=\"", 4241, "\"", 4249, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <tr class=\"text-dark\">\r\n                                    <th class=\"text-dark\">");
#nullable restore
#line 70 "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Cliente\Index.cshtml"
                                                     Write(Html.DisplayNameFor(model => model.clie_ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    <th class=\"text-dark\">");
#nullable restore
#line 71 "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Cliente\Index.cshtml"
                                                     Write(Html.DisplayNameFor(model => model.clie_Nombres));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    <th class=\"text-dark\">");
#nullable restore
#line 72 "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Cliente\Index.cshtml"
                                                     Write(Html.DisplayNameFor(model => model.clie_Apellidos));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    <th class=\"text-dark\">");
#nullable restore
#line 73 "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Cliente\Index.cshtml"
                                                     Write(Html.DisplayNameFor(model => model.clie_DNI));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    <th class=\"text-dark\">");
#nullable restore
#line 74 "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Cliente\Index.cshtml"
                                                     Write(Html.DisplayNameFor(model => model.clie_Sexo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    <th class=\"text-dark\">");
#nullable restore
#line 75 "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Cliente\Index.cshtml"
                                                     Write(Html.DisplayNameFor(model => model.clie_Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    <th class=\"text-dark\">");
#nullable restore
#line 76 "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Cliente\Index.cshtml"
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

<script>
    $(document).ready(function () {
        $(""#menuTerminal"").addClass('show');
        $(""#SubMenuTerminal"").addClass('active');
    });
</script>
");
#nullable restore
#line 94 "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Cliente\Index.cshtml"
 if (ViewBag.Script != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script>\r\n        $(document).ready(function () {\r\n            ");
#nullable restore
#line 98 "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Cliente\Index.cshtml"
       Write(Html.Raw(ViewBag.Script));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        })\r\n    </script>\r\n");
#nullable restore
#line 101 "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Cliente\Index.cshtml"

    ViewBag.Script = null;
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 104 "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Cliente\Index.cshtml"
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
