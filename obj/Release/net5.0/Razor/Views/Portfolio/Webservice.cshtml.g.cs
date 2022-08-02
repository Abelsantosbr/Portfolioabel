#pragma checksum "C:\VS_2019_portfolio_abel\PortfolioAbelCoreMvc\Views\Portfolio\Webservice.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25a9e9991b55dbd3423f08e5aa8626e7ff714e8c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Portfolio_Webservice), @"mvc.1.0.view", @"/Views/Portfolio/Webservice.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25a9e9991b55dbd3423f08e5aa8626e7ff714e8c", @"/Views/Portfolio/Webservice.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f8212a5b785b2a0b4f2f5ec9da2f9ebbaa84347", @"/Views/_ViewImports.cshtml")]
    public class Views_Portfolio_Webservice : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/imagens/WebService_cep.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 4 "C:\VS_2019_portfolio_abel\PortfolioAbelCoreMvc\Views\Portfolio\Webservice.cshtml"
   ViewData["Title"] = "Webservice"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div>
    <textarea readonly class=""tituloAreaCodigo"">
       Web Service - Serviço Web
    </textarea>
    <br />
    <p class=""areaTexto"">
        Um Web service é um serviço especializado em transferir dados entre softwares através de protocolos de comunicação para diferentes plataformas,
        independentemente de linguagens de programação. Os Web services funcionam com qualquer sistema operacional, plataforma de hardware ou linguagem
        de programação de suporte Web.</>

        Os Web services não suportam páginas web, apenas tranportam mensagens entre pontos através de protocolo de mensagem como o SOAP ou REST e o protocolo 
        de transporte HTTP.<br />

        Web service é uma API que fornece diversos beneficios como integração de dados e sistemas, reutilização de código, segurança e custo menor que as API´s REST.<br />

        Abaixo um exemplo de um serviço Web que realiza a pesquisa de um cep retornando os dados e imprimindo em console.<br />

    </p>
    <div>
");
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25a9e9991b55dbd3423f08e5aa8626e7ff714e8c4767", async() => {
                WriteLiteral("Foto Janela desktop com resultado de cep pesquisado ");
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
            WriteLiteral(@"
        <br />
    </div>
    <br />
    <h4> Código C# - Pesquisa de Cep</h4>
    <textarea readonly class=""areaCodigo"">
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebServiceCEP.CepService;

namespace WebServiceCEP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(""Informe o CEP ?....."");
            var cep = Console.ReadLine();
           

            if (! string.IsNullOrEmpty(cep))
                {
                ConsultarCEP(cep);
            }
        }

        public static void ConsultarCEP(string cep)
        {
            using (var ws = new AtendeClienteClient())
            {
                var resposta = ws.consultaCEP(cep);

                Console.Clear();
                Console.WriteLine(string.Format(""Endereço : {0}"", resposta.end));
                Console.WriteLine(string.Format(""Bairro : {0}"", resposta.bairro));");
            WriteLiteral(@"
                Console.WriteLine(string.Format(""Cidade : {0}"", resposta.cidade));
                Console.WriteLine(string.Format(""U.F : {0}"", resposta.uf));
                Console.WriteLine(string.Format(""CEP : {0}"", resposta.cep));
                Console.WriteLine("""");
                Console.WriteLine(""Pressione qualquer tecla para continuar..."");
                Console.ReadKey();

            }


        }
    }
}
    </textarea>
    <br />
    <h4> Código C# - App.config - Configurações do serviço</h4>
    <textarea readonly class=""areaCodigo"">
<?xml version=""1.0"" encoding=""utf-8"" ?>
<configuration>
    <startup> 
    <supportedRuntime version=""v4.0"" sku="".NETFramework,Version=v4.7.2"" />
    </startup>
    <system.serviceModel>
    <bindings>
    <basicHttpBinding>
    <binding name=""AtendeClienteServiceSoapBinding"">
    <security mode=""Transport"" />
                </binding>
    <binding name=""AtendeClienteServiceSoapBinding1"" />
            </basicHttpBinding>
      ");
            WriteLiteral(@"  </bindings>
    <client>
    <endpoint address=""https://apps.correios.com.br/SigepMasterJPA/AtendeClienteService/AtendeCliente""
              binding=""basicHttpBinding"" bindingConfiguration=""AtendeClienteServiceSoapBinding""
              contract=""CepService.AtendeCliente"" name=""AtendeClientePort"" />
        </client>
    </system.serviceModel>
</configuration>
    </textarea>
    <br />

</div>}
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
