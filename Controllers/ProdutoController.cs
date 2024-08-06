using Microsoft.AspNetCore.Mvc;
using produto.Models;

namespace produto.Controllers
{
    public class ProdutoController : Controller
    {


        public IActionResult Index()
        {

            var produtos = new List<Produto>{
                new Produto{
                    Id = 1,
                    Nome = "Teclado Mecânico RGB",
                    Valor = 399.90m,
                    Cat = "Acessórios",
                    Desc = "Teclado mecânico com iluminação RGB e teclas programáveis, perfeito para gamers.",
                    Status = "Em estoque",
                    Data = "04/06/2024",
                    Responsavel = "Equipe de Acessórios"
                },
                new Produto{
                    Id = 2,
                    Nome = "Monitor Ultra HD 27\"",
                    Valor = 1499.00m,
                    Cat = "Tecnologia",
                    Desc = "Monitor com resolução Ultra HD e tempo de resposta ultra-rápido, ideal para gamers.",
                    Status = "Seu pedido está em processamento",
                    Data = "03/06/2024",
                    Responsavel = "Equipe de Monitores"
                }
            };


            return View(produtos);
        }
    }
}
