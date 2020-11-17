using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaTecnicaFinactiva.Data
{
    public class MunicipioRegion
    {
     
        public int IdMunicipio { get; set; }

        [Required]
        [Range(0, 1, ErrorMessage = "Parametro fuera de rango.")]
        [StringLength(1, ErrorMessage = "Parametro fuera de rango.")]
        public string EliminaAgrega { get; set; }

        public string Nombre { get; set; }
    }
}
