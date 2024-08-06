using Microsoft.AspNetCore.Mvc;
using empresa.Models;

namespace empresa.Controllers
{
    public class EmpresaController : Controller
    {


        public IActionResult Index()
        {

            var empresas = new List<Empresa>{
                new Empresa {
                    Id = 1,
                    Nome = "Serviços de Limpeza Rápida",
                    Endereço = "Rua das Palmeiras, 350, Vila Nova, Curitiba - PR, 80000-000",
                    Desconto = "8%",
                    RegimeF = "Simples Nacional",
                    Cnpj = "22.334.455/0001-66"
}

                },
                new Empresa{
                    Id = 2,
                    Nome= "Gira Gira Aspas",
                    Endereço = "Avenida dos Melhores, 1200, São Paulo - SP",
                    Desconto = "10%",
                    RegimeF = "Lucro Real",
                    Cnpj = "78.801.254/0001-86"
                }
            };


            return View(empresas);
        }
    }
}
