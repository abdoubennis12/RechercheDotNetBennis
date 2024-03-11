using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entity;
using DAL.Repos;
using Models;

namespace BLL
{
    public class RechercheService
    {
        static RechercheRepos Repos = new RechercheRepos();
        public List<RechercheVM> ListVM()
        {
            List<RechercheVM> list = new List<RechercheVM>();
            foreach (var item in Repos.All())
            {
                RechercheVM vm = new RechercheVM();
                vm.Id = item.Id;
                vm.Value = item.Value;
                vm.DateRecherche = item.DateRecherche;
                list.Add(vm);
            }
            return list;

        }
        public void Ajouter(RechercheVM vm)
        {
            Recherche rech = new Recherche();
            rech.Id = vm.Id;
            rech.Value = vm.Value;
            rech.DateRecherche = vm.DateRecherche;
            Repos.Create(rech);
        }
    }

}
