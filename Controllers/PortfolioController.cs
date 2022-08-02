using Microsoft.AspNetCore.Mvc;
using PortfolioAbelCoreMvc.Services;
using PortfolioAbelCoreMvc.ViewModels;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace PortfolioAbelCoreMvc.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly IProjetosService _projetoService;
        private readonly IEmailService _emailService;

        public PortfolioController(IProjetosService projetoService, 
            IEmailService emailService)
        {
            _projetoService  = projetoService;
            _emailService = emailService;
        }


        public IActionResult Index()
        {
            var projetos = _projetoService.GetProjetos().ToList();

            var modelo = new PortfolioViewModel()
            {
                Projetos = projetos
            };
            return View(modelo);
        }
        public IActionResult Projetos()
        {
            
            var projetos = _projetoService.GetProjetos();
            return View(projetos);
        }

        [HttpGet]
        public IActionResult CodigoCSharp()
        {
            return View();
        }

        public IActionResult CodigoDelphi()
        {
            return View();
        }
        public IActionResult CodigoCss()
        {
            return View();
        }

        public IActionResult CodigoJS()
        {
            return View();
        }

        public IActionResult CodigoJQuery()
        {
            return View();
        }
        public IActionResult CodigoBootstrap()
        {
            return View();
        }
        public IActionResult CodigoLinq()
        {
            return View();
        }

        public IActionResult Mvc()
        {
            return View();
        }
        public IActionResult NetframeWork()
        {
            return View();
        }

        public IActionResult EntityFrameWork()
        {
            return View();
        }

        public IActionResult Swagger()
        {
            return View();
        }

        public IActionResult CriacaoBanco()
        {
            return View();
        }
        public IActionResult CriacaoTabela()
        {
            return View();
        }
        public IActionResult StoredProcedure()
        {
            return View();
        }
        public IActionResult Function()
        {
            return View();
        }
        public IActionResult Trigger()
        {
            return View();
        }

        public IActionResult ViewsBanco()
        {
            return View();
        }
        public IActionResult BackupRestore()
        {
            return View();
        }

        public IActionResult Angular()
        {
            return View();
        }
        public IActionResult WebApi()
        {
            return View();
        }
        public IActionResult WindowsForms()
        {
            return View();
        }
        public IActionResult WebForms()
        {
            return View();
        }
        public IActionResult Webservice()
        {
            return View();
        }

        public IActionResult Core()
        {
            return View();
        }
        public IActionResult Efcore()
        {
            return View();
        }
        public IActionResult Migration()
        {
            return View();
        }

        public IActionResult Cleancode()
        {
            return View();
        }
        public IActionResult Solid()
        {
            return View();
        }
        public IActionResult Microservicos()
        {
            return View();
        }

        public IActionResult Docker()
        {
            return View();
        }

        public IActionResult DevOps()
        {
            return View();
        }
        public IActionResult ScrumKanban()
        {
            return View();
        }
        public IActionResult Github()
        {
            return View();
        }
        public IActionResult Cloud()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Contato()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Contato(ContatoViewModel contatoViewModel)
        {
            await _emailService.Enviar(contatoViewModel, GetIP());
            return RedirectToAction("Obrigado");
        }

        public IActionResult Obrigado()
        {
            return View();
        }


        private string GetIP()
        {
            //string ip = base.Request.HttpContext.GetServerVariable("HTTP_X_FORWARDED_FOR");
            string ip = base.Request.HttpContext.Connection.RemoteIpAddress.ToString();
            if (!string.IsNullOrWhiteSpace(ip))
            {
                string[] ips = ip.Split(',');
                return ips.First();
            }
            return base.Request.HttpContext.GetServerVariable("REMOTE_ADDR");
        }

    }
}
