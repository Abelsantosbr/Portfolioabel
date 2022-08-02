#pragma checksum "C:\VS_2019_portfolio_abel\PortfolioAbelCoreMvc\Views\Portfolio\ViewsBanco.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66c0193a9b2330812f3347dfef000a87908ecc54"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Portfolio_ViewsBanco), @"mvc.1.0.view", @"/Views/Portfolio/ViewsBanco.cshtml")]
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
#line 1 "C:\VS_2019_portfolio_abel\PortfolioAbelCoreMvc\Views\_ViewImports.cshtml"
using PortfolioAbelCoreMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\VS_2019_portfolio_abel\PortfolioAbelCoreMvc\Views\_ViewImports.cshtml"
using PortfolioAbelCoreMvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66c0193a9b2330812f3347dfef000a87908ecc54", @"/Views/Portfolio/ViewsBanco.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f8212a5b785b2a0b4f2f5ec9da2f9ebbaa84347", @"/Views/_ViewImports.cshtml")]
    public class Views_Portfolio_ViewsBanco : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\VS_2019_portfolio_abel\PortfolioAbelCoreMvc\Views\Portfolio\ViewsBanco.cshtml"
   ViewData["Title"] = "Views"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div>
    <textarea readonly class=""tituloAreaCodigo"">
       Banco de dados Sql Server - Views
    </textarea>

    <p readonly class=""areaTexto"">
        Uma View é uma Query que resulta uma tabela virtual à partir de uma ou mais tabelas reais, inclusive outras views.<br />
        Views não possuem dados, somente uma visão deles em formato de linhas e colunas.<br />
        Não ocupam espaço no banco de dados.<br />
        São úteis em consultas complexas para dimiuir o nível de complexidade e otimizar o trabalho do desenvolvedor.<br />

        No exemplo abaixo temos uma View que tem o simples objetivo de filtrar os títulos gerados na data atual até o momento atual
        usando a data do servidor como parametro de comparação.
        Embora simples ela pode ser muito utilizada se fizer parte das tarefas do usuário como apoio às decisões.
        Pode ser medido o volume de carteira de títulos para negócios com bancos, fornecedores, etc..<br />
        Eu mesmo nos meus projetos ao cli");
            WriteLiteral(@"entes sugeri diversos trabalhos com Views para a tomada de decisão e estatísticas.
        <br />
        <span style=""color:blue"">
            <br />
            USE PF_SGCR<br />
            GO<br />
            <br />
            CREATE VIEW TitulosHoje AS<br />
            select b.mnem_cond as Codigo, b.Bloco as Bloco, <br />
            b.unidade as Unidade, b.num_emissao as Emissao, b.nome_mor as Proprietario,<br />
            b.num2_titulo as Titulo, b.dt_vencimento as Vencimento, b.vl_titulo as Valor_principal<br />
            from boletos as b<br />
            where<br />
            dt_emissao = CONVERT(VARCHAR, sysdatetime(), 103)<br />
        </span>
        <br />
        Para invocar a a View  :<br />
        SELECT * FROM TitulosHoje
        <br />
        <br />



    </p>
</div>");
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
