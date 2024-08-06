using Microsoft.AspNetCore.Mvc;
using cliente.Models;

namespace cliente.Controllers
{
    public class ClienteController : Controller
    {


        public IActionResult Index()
        {

            var clientes = new List<Cliente>{
                new Cliente{
                    Id = 1 ,
                    Nome = "Lucas Mendes",
                    Cpf = "65432109876",
                    Endereço = "Rua das Palmeiras, 88",
                    Telefone = "41934567890",
                    Email = "lucas.mendes@gmail.com"
                },
                new Cliente{
                    Id = 2,
                    Nome = "Ana Costa",
                    Cpf = "32165498700",
                    Endereço = "Alameda dos Anjos, 12",
                    Telefone = "41923456789",
                    Email = "ana.costa@gmail.com"
                }
            };


            return View(clientes);
        }
    }
}
