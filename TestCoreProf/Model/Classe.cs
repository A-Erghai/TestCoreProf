using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TestCoreProf.Model
{
    public class Classe
    {
        [Key]
        public int IdClasse { get; set; }

        [Required]
        public string NomClasse { get; set; }

        [Required]
        public string Filiere { get; set; }

        [Required]
        public string Niveau { get; set; }

        [Required]
        public string IdProf { get; set; }

        [ForeignKey("IdProf")]
        public Utilisateur utilisateur { get; set; }
    }
}
