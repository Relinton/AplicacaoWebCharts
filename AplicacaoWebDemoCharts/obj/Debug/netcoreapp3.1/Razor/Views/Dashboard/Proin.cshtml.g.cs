#pragma checksum "D:\RelintonProjetos\AplicacaoWebCharts\AplicacaoWebDemoCharts\Views\Dashboard\Proin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8daa22ef3fab2731e7188e19b932223e669ab17a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Proin), @"mvc.1.0.view", @"/Views/Dashboard/Proin.cshtml")]
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
#line 1 "D:\RelintonProjetos\AplicacaoWebCharts\AplicacaoWebDemoCharts\Views\_ViewImports.cshtml"
using AplicacaoWebDemoCharts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\RelintonProjetos\AplicacaoWebCharts\AplicacaoWebDemoCharts\Views\_ViewImports.cshtml"
using AplicacaoWebDemoCharts.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8daa22ef3fab2731e7188e19b932223e669ab17a", @"/Views/Dashboard/Proin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d5219957b6d3669551cec5db9a9fea4ad5d7472", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Dashboard_Proin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_TabelaProin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/graficoproin.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/graficoproinbarra.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<h2 class=""text-center"">Mapa De Integridade</h2>

<h4 class=""text-center text-info"">Painel de Monitoramento de Adesão ao Programa Integridade Rondoniense</h4>
<br />

<h5 class=""text-center"">A Construção dos Planos de Integridade está Estruturada em 4 passos conforme Manual Técnico PROIN</h5>
<div class=""card-group"">
    <div class=""card text-white bg-primary"" style=""background-color: #0e447e!important"">
        <div class=""card-body"">
            <h2 class=""card-title text-center"">1º PASSO</h2>
            <div class=""card-footer"">
                <h4 class=""text-center"">Adesão e Designação</h4>
            </div>
            <p class=""card-text text-center"">1. Adesão ao PROIN</p>
            <p class=""card-text text-center"">2. Designação de equipe</p>
        </div>
    </div>
    <div class=""card text-white bg-success"" style=""background-color: #02701b!important"">
        <div class=""card-body"">
            <h2 class=""card-title text-center"">2º PASSO</h2>
            <div class=""card");
            WriteLiteral(@"-footer"">
                <h4 class=""text-center"">Elaboração e Validação</h4>
            </div>
            <p class=""card-text text-center"">1. Planejamento das ações estratégicas</p>
            <p class=""card-text text-center"">2. Levantamento do cenário atual</p>
            <p class=""card-text text-center"">3. Registro das Medidas de Integridade em Vigor</p>
            <p class=""card-text text-center"">4. Levantamento dos Riscos e medidas de controle</p>
            <p class=""card-text text-center"">5. Validação do Plano de Integridade</p>
        </div>
    </div>
    <div class=""card text-white bg-warning"" style=""background-color: #d5a107!important"">
        <div class=""card-body"">
            <h2 class=""card-title text-center"">3º PASSO</h2>
            <div class=""card-footer"">
                <h4 class=""text-center"">Gestão dos Riscos</h4>
            </div>
            <p class=""card-text text-center"">1. Identificação e priorização dos riscos</p>
            <p class=""card-text text-cen");
            WriteLiteral(@"ter"">2. Proposta de tratamento de riscos</p>
        </div>
    </div>
    <div class=""card text-white bg-danger"" style=""background-color: #9d1320!important"">
        <div class=""card-body"">
            <h2 class=""card-title text-center"">4º PASSO</h2>
            <div class=""card-footer"">
                <h4 class=""text-center"">Monitoramento</h4>
            </div>
            <p class=""card-text text-center"">1. Controle de Implementação PROIN</p>
            <p class=""card-text text-center"">2. Execução de Ações Gerenciais</p>
            <p class=""card-text text-center"">3. Redução de probabilidade de Riscos e Impactos</p>
        </div>
    </div>
</div>

<br /><Br /><Br />

<div id=""grafico-proin-barra""></div>

<br /><br /><br />

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8daa22ef3fab2731e7188e19b932223e669ab17a7318", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n<br />\r\n<br />\r\n\r\n<div id=\"grafico-proin\"></div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""https://code.jquery.com/jquery-3.1.1.min.js""></script>
    <script src=""https://code.highcharts.com/highcharts.js""></script>
    <script src=""https://code.highcharts.com/modules/exporting.js""></script>
    <script src=""https://code.highcharts.com/modules/export-data.js""></script>
    <script src=""https://code.highcharts.com/modules/accessibility.js""></script>

    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8daa22ef3fab2731e7188e19b932223e669ab17a8999", async() => {
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8daa22ef3fab2731e7188e19b932223e669ab17a10098", async() => {
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
                WriteLiteral("\r\n\r\n    <script>\r\n        var urlBase = \'https://\' + \'");
#nullable restore
#line 81 "D:\RelintonProjetos\AplicacaoWebCharts\AplicacaoWebDemoCharts\Views\Dashboard\Proin.cshtml"
                               Write(Context.Request.Host);

#line default
#line hidden
#nullable disable
                WriteLiteral("\' + \'");
#nullable restore
#line 81 "D:\RelintonProjetos\AplicacaoWebCharts\AplicacaoWebDemoCharts\Views\Dashboard\Proin.cshtml"
                                                         Write(Context.Request.Path);

#line default
#line hidden
#nullable disable
                WriteLiteral("\'\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
