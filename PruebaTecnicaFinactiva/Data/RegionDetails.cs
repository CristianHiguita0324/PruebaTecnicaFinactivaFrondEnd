using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaTecnicaFinactiva.Data
{
    public class RegionDetails : RegionDto
    {
        public List<MunicipioRegion> Municipios { get; set; }
    }
}
