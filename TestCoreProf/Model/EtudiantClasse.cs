using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TestCoreProf.Model
{
    public class EtudiantClasse
    {
        [Key]
        public int IdEtudiantClasse { get; set; }

        public int IdClasse { get; set; }


        public string IdEtudiant { get; set; }

        [ForeignKey("IdEtudiant")]
        public Utilisateur utilisateur { get; set; }

        [ForeignKey("IdClasse")]
        public Classe classe { get; set; }
    }
}
