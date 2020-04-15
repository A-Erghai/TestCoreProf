using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestCoreProf.Model;

namespace TestCoreProf.Model
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        
        {

        }

        public DbSet<Utilisateur> Utilisateurs { get; set; }
        public DbSet<Classe> Classes { get; set; }
        public DbSet<Publication> Publications { get; set; }
        public DbSet<EtudiantClasse> EtudiantClasses { get; set; }


    }
}
