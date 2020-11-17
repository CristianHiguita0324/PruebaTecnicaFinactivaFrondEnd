using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaTecnicaFinactiva.Data
{
    public class MunicipioDetails: Municipio
    {
        public List<RegionDto> Regions { get; set; }
    }
}
