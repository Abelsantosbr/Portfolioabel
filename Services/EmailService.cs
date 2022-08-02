using Microsoft.Extensions.Configuration;
//using SendGrid;
//using SendGrid.Helpers.Mail;
using System.Net;
using System.Net.Mail;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Web;

using HTTPRequest;

using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Http;

namespace PortfolioAbelCoreMvc.Services
{
    public class EmailService : IEmailService
    {
        private readonly IConfiguration? _configuration;
        public  EmailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task Enviar(ContatoViewModel contato, string ip)
        {
            if (contato.Nome == null)
            {
                contato.Nome = "Desconhecido";
                contato.Email = "abelsantos_br@yahoo.com.br";
                contato.Mensagem = "Envio automático ao entrar no portfolio";
            };

            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("postmaster@admisys.com.br");
            mail.Subject = $"O cliente {contato.Email} quer entrar em contato"+"IP=";
            //mail.To.Add("admisys@admisys.com.br");
            mail.To.Add("abelsantos_br@yahoo.com.br");
            // mail.To.Add(_objModelMail.departamento);
            string Body = (mail.Body = "<br/>Enviado por : "
                + contato.Nome + "<br/>" + contato.Email + "<br/><br/>" + "Portfolio Abel" +"IP = "+ip+"<br/>"
                + contato.Mensagem);
            mail.BodyEncoding = Encoding.UTF8;
            mail.BodyEncoding = Encoding.GetEncoding("ISO-8859-1");
            mail.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("mail.admisys.com.br");
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("postmaster@admisys.com.br", "adm1990!1990");
            smtp.EnableSsl = false;
            await smtp.SendMailAsync(mail);

        }
     }
}
