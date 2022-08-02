using PortfolioAbelCoreMvc.Models;
using PortfolioAbelCoreMvc.Services;
using System.Collections.Generic;

namespace PortfolioAbelCoreMvc.Services { }

public class ProjetosService : IProjetosService
{
    public List<Projeto> GetProjetos()
    {
        return new List<Projeto>() {
                new Projeto
                {
                    Titulo = "Projeto Gestão de Administração de Condomínios",
                    Descricao = "Módulo para criação de rateios  ",
                    Link = "www.admisys.com.br",
                    ImagemURL = "/imagens/sgcr_criar_rateios.png"
                }
            };
    }
}

