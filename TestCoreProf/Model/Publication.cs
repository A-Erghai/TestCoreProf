using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TestCoreProf.Model
{
    public class Publication
    {
        [Key]
        public int IdPublication { get; set; }

        [Required]
        public string Contenu { get; set; }

        [DataType(DataType.Date)]
        public string DatePublication { get; set; }

        [Required]
        public int IdClasse { get; set; }

        [ForeignKey("IdClasse")]
        public Classe classe { get; set; }
    }
}
