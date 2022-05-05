using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades.DTO
{
    public class FacturacionRegionDTO
    {
        int regionId;
        string regionNombre;
        double regionFacturacion;

        public FacturacionRegionDTO()
        {
        }
        public int RegionId { get => regionId; set => regionId = value; }
        public double RegionFacturacion { get => regionFacturacion; set => regionFacturacion = value; }
        public string RegionNombre { get => regionNombre; set => regionNombre = value; }
    }
}
