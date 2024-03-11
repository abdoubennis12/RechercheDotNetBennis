using Microsoft.AspNetCore.Mvc;
using BLL;

namespace Recherche.Controllers
{
    public class HistoriqueController : Controller
    {
        public IActionResult Index()
        {
            RechercheService rechercheService = new RechercheService();
            return View(rechercheService.ListVM());
        }
    }
}
