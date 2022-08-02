#pragma checksum "C:\VS_2019_portfolio_abel\PortfolioAbelCoreMvc\Views\Portfolio\BackupRestore.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05c9b1b9aad171f41bf3595c4930e7cf31972ca9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Portfolio_BackupRestore), @"mvc.1.0.view", @"/Views/Portfolio/BackupRestore.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05c9b1b9aad171f41bf3595c4930e7cf31972ca9", @"/Views/Portfolio/BackupRestore.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f8212a5b785b2a0b4f2f5ec9da2f9ebbaa84347", @"/Views/_ViewImports.cshtml")]
    public class Views_Portfolio_BackupRestore : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\VS_2019_portfolio_abel\PortfolioAbelCoreMvc\Views\Portfolio\BackupRestore.cshtml"
   ViewData["Title"] = "BackupRestore"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div>
    <textarea readonly class=""tituloAreaCodigo"">
       Banco de dados Sql Server - Backup / Restore
    </textarea>

    <p readonly class=""areaTexto"">
        Backup de dados é sem dúvida uma tarefa essencial de alta prioridade e alta segurança para a continuidade dos
        negócios de uma empresa.<br />
        Independendente da causa de um banco de dados corrompido a empresa precisa retomar as atividades o quanto antes
        possível para evitr maiores prejuízos ou nenhum (ideal)<br />
        Um plano de contingência bem definido utiliza o backup como ferramenta vital da empresa.<br />
        Backup de dados geralmente utiliza vários volumes, midias e unidades diferentes, também pontos geográficos diferentes <br />
        e estratégicos que venham garantir uma retomada crítica à partir da restauração de Backups.<br />

        Backup de dados também pode ser feito com algumas opções como compactado, midias diferentes, full (completo) e incremental.
        Uma das formas de ");
            WriteLiteral(@"realizar um backup é através de uma stored procedure que pode ser executada a qualquer momento pelo usuário.<br />
        veja abaixo um exemplo de stored procedure para backup completo em disco.<br />

        <br />
        <span style=""color:blue"">
            <br />
            <span style=""color:red"">ATENÇÂO !!! Substituir o caracter especial & por arroba (não pode usar no texto por ser carater reservado)</span>
            <br />

            USE [PF_SGCR]<br />
            GO<br />

            SET ANSI_NULLS ON<br />
            GO<br />
            SET QUOTED_IDENTIFIER ON<br />
            GO<br />
            CREATE PROCEDURE [dbo].[BACKUP_PF_SGCR_NO_C]<br />
            &DBORIGEM VARCHAR(500), /*Banco de dados de Origem*/<br />
            &DBDESTINO VARCHAR(500) /*Banco de dados de destino*/<br />
            AS<br />
            BEGIN<br />

            DECLARE &DEVICE VARCHAR(500) /*RECEBE O NOME DO BACKUP*/<br />
            DECLARE &PATH VARCHAR(500) /*RECEBE O CAMINHO");
            WriteLiteral(@" ONDE SERÁ SALVO O BACKUP*/<br />
            SET LANGUAGE 'Brazilian'<br />
            /*CONCATENA NOME DO BANCO DESTINO + DATA + EXTENSÃO DE BACKUP .BAK */<br />
            SET &DEVICE =    &DBDESTINO + replace(convert(char(10),getdate(),103),'/','')+<br />
            +'_'+replace(CONVERT(VARCHAR(10),GETDATE(),108),':','_')+'hs.BAK'<br />

            SET &PATH = 'C:\BACKUP_SQL_SERVER_C\' + &DEVICE<br />

            /*ADICIONA UM DISPOSITIVO DE BACKUP*/<br />
            EXEC sp_addumpdevice 'disk', &DEVICE ,&PATH<br />

            /*CRIA BACKUP NA PASTA LOCAl*/<br />
            BACKUP DATABASE &DBORIGEM TO DISK = &PATH<br />

            END<br />
            <br />
        </span>
        <br />
        Para executar a procedure BACKUP_PF_SGCR_NO_C :<br />
        --> Exec BACKUP_PF_SGCR_NO_C pf_sgrc, backup_pf_sgcr
        <br />

        <span style=""color:navy"">
            RESULTADO :<br />
            Processadas 3648 páginas para o banco de dados 'PF_SGCR', arquivo 'pf_");
            WriteLiteral(@"sgcr' no arquivo 1.<br />
            Processadas 6 páginas para o banco de dados 'PF_SGCR', arquivo 'pf_sgcr_log' no arquivo 1.<br />
            BACKUP DATABASE processou com êxito 3654 páginas em 2.193 segundos (13.015 MB/s).<br />
            <br />
            Horário de conclusão: 2022-07-25T23:24:23.8838647-03:00<br />

            AQRUIVO DE BACKUP GERADO :Backup_PF_SGCR_25072022_23_24_21hs.bak<br />
            <br />

            Em caso de necessidade de restaurar este backup utilizamos o RESTORE assim :<br />
            --> RESTORE DATABASE Backup_PF_SGCR_25072022_23_24_21hs.bak FROM DISK WITH REPLACE<br />
            <br />
        </span>
        <span style=""color:green"">
            Observação : Tanto o backup como o restore podem ser feitos de forma interativa através do<br />
            SMS (SQL Server Management Studio).<br />

            Utilizei ambas as formas (ssms e por script) e são seguras, consistentes.
            <br />

        </span>
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
