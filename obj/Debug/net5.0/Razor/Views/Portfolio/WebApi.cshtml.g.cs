#pragma checksum "C:\VS_2019_portfolio_abel\PortfolioAbelCoreMvc\Views\Portfolio\WebApi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d537cecda459ef49d4ffdd553e12c5190d4064d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Portfolio_WebApi), @"mvc.1.0.view", @"/Views/Portfolio/WebApi.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d537cecda459ef49d4ffdd553e12c5190d4064d8", @"/Views/Portfolio/WebApi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f8212a5b785b2a0b4f2f5ec9da2f9ebbaa84347", @"/Views/_ViewImports.cshtml")]
    public class Views_Portfolio_WebApi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 6 "C:\VS_2019_portfolio_abel\PortfolioAbelCoreMvc\Views\Portfolio\WebApi.cshtml"
   ViewData["Title"] = "WebApi"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div>

    <textarea readonly class=""tituloAreaCodigo"">
       Web API / CORS
    </textarea>

    <br />
    <h4> Código c# - Classe Proprietário</h4>
    <textarea readonly class=""areaCodigo"">
namespace CRUDAPI.Models
{
    public class Proprietario {
        public short ProprietarioId { get; set; }
        public short Unidade_cond { get; set; }
        public DateTime Dt_ini_prop { get; set; }
        public DateTime Dt_fin_prop { get; set; }
        public string? Nome { get; set; }
        public string? Sobrenome { get; set; }
        public DateTime? Data_nasc { get; set; }
        public string? Profissao { get; set; }
        public long CPF { get; set; }
        public long RG { get; set; }
        public string? Unidade_alugada { get; set; }
        public string? Login { get; set; }
        public string Senha { get; set; }
    }
}
    </textarea>
    <br />
    <br />
    <h4> Código c# - Controller Proprietário</h4>
    <textarea readonly class=""areaCodigo"">
");
            WriteLiteral(@"
        using CRUDAPI.Models;
        using Microsoft.AspNetCore.Mvc;
        using System.Collections.Generic;
        using Microsoft.EntityFrameworkCore;
        using System.Threading.Tasks;
        using System.Text.Json;
        using Microsoft.AspNetCore.Cors;

        namespace CRUDAPI.Controllers
        {
        [ApiController]
        [Route(""api/[controller]"")]

        public class ProprietariosController: ControllerBase{

        private readonly Contexto _contexto;

        public ProprietariosController(Contexto contexto)
        {
        _contexto = contexto;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Proprietario>>> PegarTodosAsync(){
            return await _contexto.Proprietarios.ToListAsync();
        }

        [HttpGet(""{proprietarioId}"")]
        public async Task<ActionResult<Proprietario>> PegarProprietarioPeloIdAsync(short proprietarioId){
            Proprietario proprietario = await _contexto.Proprietarios.FindA");
            WriteLiteral(@"sync(proprietarioId);
            if (proprietario == null)
              return NotFound();

            return proprietario;
        }


        [HttpPost]
        public async Task<ActionResult<Proprietario>> SalvarProprietarioAsync(Proprietario proprietario){
            await _contexto.Proprietarios.AddAsync(proprietario);
            await _contexto.SaveChangesAsync();
            return Ok();
        }


        [HttpPut]  //enviado o objeto proprietario inteiro e não o id
        public async Task<ActionResult> SalvarAtualizarProprietarioAsync(Proprietario proprietario){
           _contexto.Proprietarios.Update(proprietario);
            await _contexto.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete(""{proprietarioId}"")]
        public async Task<ActionResult> ExcluirProprietarioAsync(short proprietarioId){
                Proprietario proprietario = await _contexto.Proprietarios.FindAsync(proprietarioId);
                _contexto.Remove(propriet");
            WriteLiteral(@"ario);
                await _contexto.SaveChangesAsync();
                return Ok();
        }
    }
}
        </textarea>
    <h4> Código c# - Configuração CORS - Cross-origin Resource Sharing <br />
         (Compartilhamento de Recursos de Origem Cruzada)</h4>
    <p class=""areaTexto"">
        No meu projeto de iniciante de Angular não tive problemas para renderizar no navegador local o projeto compilado mas quando
        fiz o deploy para o Host de hospedagem o navegador recusou a aplicação para evitar ataques maliciosos ao navegador.<br />
        É um mecanismo de segurança dos navegadores protegendo a aplicação. Os navegadores são capazes de identificar as
        origens envolvidas nas aplicação.
        Quando as origens são iguais (Política de mesma origem) o navegador entende como uma fonte segura.<br />
        Minha aplicação Angular utiliza os serviços de API que desenvolvi em Dot Net e no meu navegador local a
        execução ocorreu normalmente porque tanto o front-end e o");
            WriteLiteral(@" back-end estão no mesmo ambiente.<br />
        Para garntir a liberação de execução de forma segura no navegador quando fiz o deploy eu tive que
        configurar o recurso CORS para aceitação.<br />
        O CORS interpreta os Headers HTTP para informar ao navegador se o recurso pode ser liberado ou não.<br />
        <br />
        No program.cs da aplicação Back-end (Dot Net) fiz as devidas configurações para liberar o acesso.<br />
        <br />
    </p>
    <br />
    <h4> Código c# - Program.cs do Backend com as configurações CORS</h4>
    <p  class=""areaTexto"">
    using CRUDAPI.Models;<br />
    using Microsoft.EntityFrameworkCore;<br />
    using Microsoft.Net.Http;<br />
    <br />
    var builder = WebApplication.CreateBuilder(args);<br />
    <br />
    // Add services to the container.<br />
    <br />
    builder.Services.AddControllers();<br />
    <br />
    builder.Services.AddDbContext<Contexto>
    (x => x.UseSqlServer(builder.Configuration.GetConnectionString(""Co");
            WriteLiteral(@"nexaoBD"")));<br />
    <br />
    builder.Services.AddEndpointsApiExplorer();<br />
    builder.Services.AddSwaggerGen();<br />
    <br />
    <span style=""color:blue"">
        //Cors - permite a troca de requisições entre origens (cliente e servidor)<br />
        builder.Services.AddCors(options =><br />
        {
        options.AddPolicy(name: ""corsapp"",<br />
        builder =><br />
        {
        builder.WithOrigins(""http://localhost:4200"",<br />
        ""www.admisys.com.br/apiproprietario/api/proprietarios"",<br />
        ""www.admisys.com.br/apiproprietario/api/moradores"",<br />
        ""www.admisys.com.br/apiproprietario/api/usuarios"",<br />
        ""www.admisys.com.br/apiproprietario/api/sindicos"")<br />
        .WithMethods(""GET"", ""POST"", ""PUT"", ""DELETE"", ""OPTIONS"")<br />
        .AllowAnyHeader();<br />
        });<br />
        });
    </span><br />
    var app = builder.Build();<br />
    <br />
    // Configure the HTTP request pipeline.<br />
    <br />
    if (app");
            WriteLiteral(@".Environment.IsDevelopment())<br />
    {<br />
    app.UseSwagger();<br />
    app.UseSwaggerUI();<br />
    }<br />
    <br />
    app.UseHttpsRedirection();<br />
    <span style=""color:blue"">
        app.UseCors(""corsapp"");</span><br />
    app.UseAuthorization();<br />
    <br />
    app.MapControllers();<br />
    <br />
    app.Run();<br />
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
