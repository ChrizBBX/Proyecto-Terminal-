#pragma checksum "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Cliente\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94287de35c26ad0a8c9b2a3a7f5fbc45d0f05f89"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_Details), @"mvc.1.0.view", @"/Views/Cliente/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94287de35c26ad0a8c9b2a3a7f5fbc45d0f05f89", @"/Views/Cliente/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acbe80c8ae054dc5357aa4687981182e4e6d61f2", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Terminal.WebUI.Models.ClientesModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Cliente\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div class=""card border-5"">
    <div class=""card-header"" style=""background-image: linear-gradient(to right, #A4F6FA,#9CB0D7 ,#4EBBC0 ) "">
        <div class=""row"">
            <div class=""col-5""></div>
            <div class=""col-3"">
                <h1 style=""font-family: Cooper;"" class=""text-black"">Detalles</h1>
            </div>
            <div class=""col-4""></div>

        </div>
    </div>
    <div class=""card-body align-content-xl-center"">
");
#nullable restore
#line 21 "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Cliente\Details.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row mt-1\">\r\n\r\n                <div class=\"col-1\"></div>\r\n                <div class=\"col-4\">\r\n                    <div class=\"form-group\">\r\n                        <h5>ID :</h5>\r\n                        <label class=\"text-dark\">");
#nullable restore
#line 29 "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Cliente\Details.cshtml"
                                            Write(Html.DisplayFor(modelItem => item.clie_ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"form-group col-3\">\r\n                    <h5>Nombre completo :</h5>\r\n                    <label class=\"text-dark\">");
#nullable restore
#line 35 "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Cliente\Details.cshtml"
                                        Write(Html.DisplayFor(modelItem => item.clie_NombreCompleto));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                </div>\r\n\r\n                <div class=\"form-group col-4\">\r\n                    <h5>DNI :</h5>\r\n                    <label class=\"text-dark\">");
#nullable restore
#line 40 "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Cliente\Details.cshtml"
                                        Write(Html.DisplayFor(modelItem => item.clie_DNI));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                </div>
            </div>
            <div class=""row mt-3"">

                <div class=""col-1""></div>

                <div class=""form-group col-4"">
                    <h5>Sexo :</h5>
                    <label class=""text-dark"">");
#nullable restore
#line 49 "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Cliente\Details.cshtml"
                                        Write(Html.DisplayFor(modelItem => item.clie_Sexo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                </div>\r\n\r\n                <div class=\"form-group col-3\">\r\n                    <h5>Teléfono :</h5>\r\n                    <label class=\"text-dark\">");
#nullable restore
#line 54 "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Cliente\Details.cshtml"
                                        Write(Html.DisplayFor(modelItem => item.clie_Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                </div>\r\n\r\n                <div class=\"form-group col-4\">\r\n                    <h5>Correo Electrónico :</h5>\r\n                    <label class=\"text-dark\">");
#nullable restore
#line 59 "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Cliente\Details.cshtml"
                                        Write(Html.DisplayFor(modelItem => item.clie_Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                </div>\r\n            </div>\r\n");
            WriteLiteral("            <div class=\"row mt-3\">\r\n                <div class=\"col-9 mt-3\"></div>\r\n                <div class=\"form-group col-3 mt-3\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94287de35c26ad0a8c9b2a3a7f5fbc45d0f05f899140", async() => {
                WriteLiteral("Editar");
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
#nullable restore
#line 66 "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Cliente\Details.cshtml"
                                           WriteLiteral(item.clie_ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94287de35c26ad0a8c9b2a3a7f5fbc45d0f05f8911440", async() => {
                WriteLiteral("Regresar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 70 "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Cliente\Details.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div style=""height:20px""></div>
        <div class=""card"">
            <div class=""card-header""><h2>Auditoría</h2></div>
            <table class=""table table-striped"">
                <thead>
                    <tr>
                        <th>Acción</th>
                        <th>Usuario</th>
                        <th>Fecha</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 84 "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Cliente\Details.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td><label>Creación</label></td>\r\n                            <td>");
#nullable restore
#line 88 "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Cliente\Details.cshtml"
                           Write(Html.DisplayFor(modelItem => item.clie_UsuarioCreador_Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 89 "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Cliente\Details.cshtml"
                           Write(Html.DisplayFor(modelItem => item.clie_FechaCreacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td><label>Modificación</label></td>\r\n                            <td>");
#nullable restore
#line 93 "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Cliente\Details.cshtml"
                           Write(Html.DisplayFor(modelItem => item.clie_UsuarioModificador_Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 94 "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Cliente\Details.cshtml"
                           Write(Html.DisplayFor(modelItem => item.clie_FechaModificacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 96 "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Cliente\Details.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tbody>
                <tfoot>
                    <tr>
                        <th></th>
                        <th></th>
                        <th></th>
                    </tr>
                </tfoot>
            </table>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Terminal.WebUI.Models.ClientesModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
