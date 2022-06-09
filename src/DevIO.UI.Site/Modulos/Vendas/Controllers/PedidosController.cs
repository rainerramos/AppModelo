using Microsoft.AspNetCore.Mvc;

namespace DevIO.UI.Site.Modulos.Vendas
{
    [Area("Vendas")]
    public class PedidosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
