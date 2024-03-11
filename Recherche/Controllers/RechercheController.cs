using Microsoft.AspNetCore.Mvc;
using Models;
using BLL;

namespace Recherche.Controllers
{
    public class RechercheController : Controller
    {


        public IActionResult Index()
        {
            RechercheService rechercheService = new RechercheService();
            RechercheVM vm = rechercheService.ListVM().Last();
            return View(vm);
        }



        public IActionResult Create()
        {
            RechercheVM vm = new RechercheVM();
            return View(vm);
        }

        [HttpPost]
        public IActionResult Create(RechercheVM model)
        {
            try
            {
                RechercheService rechercheService = new RechercheService();
                rechercheService.Ajouter(model);
                return RedirectToAction("Index", "Recherche");
            }
            catch
            {
                return RedirectToAction("Index", "Recherche");
            }
        }
    }
}
