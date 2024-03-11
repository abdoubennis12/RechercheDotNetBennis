using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entity;

namespace DAL.Repos
{
    public class RechercheRepos
    {
        static MyDbContext db = new MyDbContext();
        public List<Recherche> All()
        {
            return db.Recherches.ToList();
        }

        public void Create(Recherche recherche)
        {
            db.Recherches.Add(recherche);
            db.SaveChanges();
        }
    }
}
