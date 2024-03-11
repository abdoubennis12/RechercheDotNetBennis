using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DAL.Entity;

namespace DAL
{
    public class MyDbContext:DbContext
    {
        public DbSet<Recherche> Recherches { get; set; }
        public DbSet<Utilisateur> Utilisateurs { get; set; }


        protected override void OnConfiguring
            (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer
                (@"Data Source=Localhost\SQLEXPRESS;Initial Catalog=RechercheDB;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True");
        }
    }

}

