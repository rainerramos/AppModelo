using Microsoft.AspNetCore.Mvc;

namespace DevIO.UI.Site.Modulos.Vendas
{
    [Area("Vendas")]
    [Route("Pedidos")]
    public class PedidosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
