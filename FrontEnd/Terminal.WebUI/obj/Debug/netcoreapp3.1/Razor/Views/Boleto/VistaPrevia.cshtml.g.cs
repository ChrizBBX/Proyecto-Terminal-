#pragma checksum "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Boleto\VistaPrevia.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54e3fd6fcb043a081f6498181b5f909fb2a64a81"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Boleto_VistaPrevia), @"mvc.1.0.view", @"/Views/Boleto/VistaPrevia.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54e3fd6fcb043a081f6498181b5f909fb2a64a81", @"/Views/Boleto/VistaPrevia.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acbe80c8ae054dc5357aa4687981182e4e6d61f2", @"/Views/_ViewImports.cshtml")]
    public class Views_Boleto_VistaPrevia : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Terminal.WebUI.Models.PreviaViewModelcs>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/examples/libs/jspdf.umd.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/examples/mitubachi-normal.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/examples/libs/faker.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/dist/jspdf.plugin.autotable.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Boleto\VistaPrevia.cshtml"
  
    ViewData["Title"] = "VistaPrevia";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "54e3fd6fcb043a081f6498181b5f909fb2a64a815038", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "54e3fd6fcb043a081f6498181b5f909fb2a64a816075", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "54e3fd6fcb043a081f6498181b5f909fb2a64a817112", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "54e3fd6fcb043a081f6498181b5f909fb2a64a818149", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<h1>VistaPrevia</h1>


 

    <div class=""card"">
        <div class=""card-body"">
            <h1>Boletos</h1>
            <div class=""row"">
                <div class=""col-lg-12"">
                    <div class=""float-e-margins"">
                        <div class=""ibox-title"">
                            <div class=""ibox-tools"">
                                <div class=""col-12"">

                                    <div class=""row"">

                                        <div class=""col-1""> </div>
                                        <div class=""col-10"" style=""text-align:center"">
                                            <div class=""col-10"" style=""text-align:center""> <button type=""button"" id=""btn_Exportar"" class=""btn btn-success""> Convertir en pdf </button> </div>
                                        </div>
                                        <div class=""col-1""> </div>
                                    </div>

                                </div>
                            </div>
     ");
            WriteLiteral(@"                   </div>
                        <br />
                        <iframe id=""pdf-preview"" width=""700px"" height=""600px""></iframe>

                        <div class=""table-responsive"">
                            <table class=""table text-nowrap table-striped table-hover dataTables-example"" id=""DataTable"" hidden=""hidden"">
                                <thead class=""bg-teal-400"">
                                    <tr class=""text-dark"">
                                        <th class=""text-dark"">");
#nullable restore
#line 46 "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Boleto\VistaPrevia.cshtml"
                                                         Write(Html.DisplayNameFor(model => model.bole_ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                                        <th class=\"text-dark\">");
#nullable restore
#line 47 "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Boleto\VistaPrevia.cshtml"
                                                         Write(Html.DisplayNameFor(model => model.bole_clie_Nombre_Completo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                                        <th class=\"text-dark\">");
#nullable restore
#line 48 "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Boleto\VistaPrevia.cshtml"
                                                         Write(Html.DisplayNameFor(model => model.bole_hora_Origen_Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                                        <th class=\"text-dark\">");
#nullable restore
#line 49 "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Boleto\VistaPrevia.cshtml"
                                                         Write(Html.DisplayNameFor(model => model.bole_hora_Destino_Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                                        <th class=\"text-dark\">");
#nullable restore
#line 50 "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Boleto\VistaPrevia.cshtml"
                                                         Write(Html.DisplayNameFor(model => model.bole_Fecha));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                                        <th class=\"text-dark\">");
#nullable restore
#line 51 "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Boleto\VistaPrevia.cshtml"
                                                         Write(Html.DisplayNameFor(model => model.comp_Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n\n                                    </tr>\n                                </thead>\n                                <tbody class=\"text-dark\">\n");
#nullable restore
#line 56 "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Boleto\VistaPrevia.cshtml"
                                     foreach (var item in Model)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr role=\"row\" data-id=\"");
#nullable restore
#line 58 "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Boleto\VistaPrevia.cshtml"
                                                           Write(item.bole_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"text-dark align-text-bottom\">\n                                            <td>");
#nullable restore
#line 59 "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Boleto\VistaPrevia.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.bole_ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td>");
#nullable restore
#line 60 "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Boleto\VistaPrevia.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.bole_clie_Nombre_Completo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td>");
#nullable restore
#line 61 "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Boleto\VistaPrevia.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.bole_hora_Origen_Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td>");
#nullable restore
#line 62 "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Boleto\VistaPrevia.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.bole_hora_Destino_Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td>");
#nullable restore
#line 63 "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Boleto\VistaPrevia.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.bole_Fecha));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td>");
#nullable restore
#line 64 "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Boleto\VistaPrevia.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.comp_Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n                                        </tr>\n");
#nullable restore
#line 67 "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Boleto\VistaPrevia.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tbody>\n                                <tfoot class=\"bg-teal-400\">\n                                    <tr class=\"text-dark\">\n                                        <th class=\"text-dark\">");
#nullable restore
#line 71 "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Boleto\VistaPrevia.cshtml"
                                                         Write(Html.DisplayNameFor(model => model.bole_ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                                        <th class=\"text-dark\">");
#nullable restore
#line 72 "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Boleto\VistaPrevia.cshtml"
                                                         Write(Html.DisplayNameFor(model => model.bole_clie_Nombre_Completo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                                        <th class=\"text-dark\">");
#nullable restore
#line 73 "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Boleto\VistaPrevia.cshtml"
                                                         Write(Html.DisplayNameFor(model => model.bole_hora_Origen_Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                                        <th class=\"text-dark\">");
#nullable restore
#line 74 "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Boleto\VistaPrevia.cshtml"
                                                         Write(Html.DisplayNameFor(model => model.bole_hora_Destino_Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                                        <th class=\"text-dark\">");
#nullable restore
#line 75 "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Boleto\VistaPrevia.cshtml"
                                                         Write(Html.DisplayNameFor(model => model.bole_Fecha));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                                        <th class=\"text-dark\">");
#nullable restore
#line 76 "C:\Users\LAB01\Documents\GitHub\Gen6Matutina\Proyecto-Terminal-\FrontEnd\Terminal.WebUI\Views\Boleto\VistaPrevia.cshtml"
                                                         Write(Html.DisplayNameFor(model => model.comp_Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</th>

                                    </tr>
                                </tfoot>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<img src=""./"" />
<script>
    if (!window.jsPDF) window.jsPDF = window.jspdf.jsPDF
</script>

");
            WriteLiteral(@"<iframe id=""pdf-preview"" width=""700px"" height=""600px""></iframe>

<script>
    //boton exporta
    $(document).ready(function () {
        // Obtener la tabla por su id
        var tabla = $('#DataTable');

        // Obtener los encabezados de la tabla
        var encabezados = tabla.find('th').map(function (index, element) {
            // Obtener solo las primeras 5 columnas
            if (index <= 5) {
                return $(element).text();
            }
        }).get();

        // Obtener los datos de la tabla
        var datos = tabla.find('tbody tr').map(function () {
            var fila = $(this);
            var celdas = fila.find('td').map(function () {
                return $(this).text();
            }).get();
            return [celdas]; // Se envuelve el arreglo de celdas dentro de otro arreglo
        }).get();

        // Crear el objeto de configuración para autoTable
        var config = {
            head: [encabezados],
            body: datos,
            startY: 70,
            di");
            WriteLiteral(@"dDrawPage: function (data) {
                // Establecer el margen superior de la tabla en cada página
                data.settings.margin.top = 70;

                ///reyeno
                var img = new Image();
                img.src = ""/img/EncabezadoReporteBoletosRecorte.png"";
                data.doc.addImage(img, 'PNG', null, 0, 220, 60);


                // Establecer la posición de inicio de la tabla en cada página
                data.startY = data.settings.margin.top + 50; // Altura de la imagen
            },
            didParseCell: function (data) {
                // Agregar la imagen en la primera celda de la primera fila
                if (data.section === 'head' && data.row.index === 0 && data.cell.index === 0) {
                    var img = new Image();
                    img.src = '/img/EncabezadoReporteBoletosRecorte.png';
                    var imgData = getBase64Image(img);
                    data.cell.styles.fillColor = '#FFFFFF';
                    data.cell.styles.textCo");
            WriteLiteral(@"lor = '#000000';
                    data.cell.styles.fontSize = 15;
                    data.cell.styles.cellPadding = 10;
                    data.cell.styles.overflow = 'linebreak';
                    data.cell.contentWidth = 190;
                    data.cell.text = '';
                    data.cell.raw = imgData;
                }
            }
        };

        // Crear el PDF con autoTable
        var pdf = new jsPDF();
        pdf.autoTable(config);

        // Obtener la URL del objeto Blob y establecerla como src del iframe
        var pdfBlob = pdf.output('blob');
        var pdfUrl = URL.createObjectURL(pdfBlob);
        $('#pdf-preview').attr('src', pdfUrl);

        $(""#btn_Exportar"").click(function () {
            pdf.save(""Reporte de Boletos"");

        })
    });

    // Función para convertir la imagen en base64
    function getBase64Image(img) {
        var canvas = document.createElement(""canvas"");
        canvas.width = img.width;
        canvas.height = img.height;
        var ctx = ");
            WriteLiteral("canvas.getContext(\"2d\");\n        ctx.drawImage(img, 0, 0);\n        var dataURL = canvas.toDataURL(\"image/jpeg\");\n        return dataURL.replace(/^data:image\\/(png|jpg);base64,/, \"\");\n    }\n\n\n</script>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Terminal.WebUI.Models.PreviaViewModelcs>> Html { get; private set; }
    }
}
#pragma warning restore 1591
