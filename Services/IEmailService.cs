using Microsoft.AspNetCore.Http;
using PortfolioAbelCoreMvc.ViewModels;
using System.Threading.Tasks;

namespace PortfolioAbelCoreMvc.Services
{
    public interface IEmailService
    {
        Task Enviar(ContatoViewModel contato, string ip);
    }
}
