#pragma checksum "C:\VS_2019_portfolio_abel\PortfolioAbelCoreMvc\Views\Portfolio\Efcore.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b953a4447bb49bf510da31fdfe8a10a499ab350f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Portfolio_Efcore), @"mvc.1.0.view", @"/Views/Portfolio/Efcore.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b953a4447bb49bf510da31fdfe8a10a499ab350f", @"/Views/Portfolio/Efcore.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f8212a5b785b2a0b4f2f5ec9da2f9ebbaa84347", @"/Views/_ViewImports.cshtml")]
    public class Views_Portfolio_Efcore : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\VS_2019_portfolio_abel\PortfolioAbelCoreMvc\Views\Portfolio\Efcore.cshtml"
   ViewData["Title"] = "Efcore"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div>
    <textarea readonly class=""tituloAreaCodigo"">
       EntityFrameWork Core
    </textarea>
    <p class=""areaTexto"">
        Falando de Core, seu ORM é o EntityFrameWork Core ou EFCore, desenvolvido do zero pela equipe da Microsoft
        melhorando sua performance nos recursos.<br />
        <br />
        O EfCore é um recurso para aplicações Multiplataforma.<br />
        <br />
        O EntityFramWork pode ser usado de forma performática considerando alguns cuidados como manter uma só instancia do contexto,
        evitar campos desnecessários nas consultas e sobre o uso do método Tracking e AsNoTracking, principalmente em consultas de alta escala.<br />
        Para os desenvolvedores que se preocupam com a otimização
        de respostas sobre o banco de dados usado em alta escala podem otimizar em consultas readonly
        desabilitando a rastreabilidade de objetos em memória utilizando o método AsNoTracking<br />
        Desabilitar este método quando possível otimiza os pr");
            WriteLiteral(@"ocessos e alivia os recursos de servidor.<br />
        <br />
        Já vi vários comentários e sugestões de uso ou não destes métodos. Sugiro cada desenvolvedor estudar os
        mecanismos de ação destes métodos para tomar decisões assertivas.<br />
    </p>
    <br />
        <h4> Código C# - exemplo de classe com método AsNoTraccking</h4>
        <textarea readonly class=""areaCodigo"">
                
         public List<Boletos> List()
             {
               _context = new SystemContext();   
               return _context.Boletos.ToList();
             }


         public List<Boletos> ListNoTracking()
             {
              _context = new SystemContext();  
              return _context.Boletos.AsNoTracking.ToList();
             }

        </textarea>
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
