using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using segundaparte.Models;

namespace segundaparte.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cardapio()
        {
            return View();
        }
        
         public IActionResult Cadastro()
        {
            return View();
        }
            [HttpPost]
            public IActionResult Cadastro(ItemPedido itemPedido)
            {
                BancoDados.Incluir(itemPedido);
                ViewBag.total = itemPedido.quantidade*itemPedido.valor_unitario;
                return View("Concluido");
            }

             public IActionResult Listagem()
            {
                List<ItemPedido> itemPedido = BancoDados.Listar();
                return View(itemPedido);
            }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
