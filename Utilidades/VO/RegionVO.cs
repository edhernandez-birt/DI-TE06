using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades.VO
{
    public class RegionVO
    {
        private int idRegion;
        private string nombreRegion;

        public RegionVO()
        {
        }

        public int IdRegion { get => idRegion; set => idRegion = value; }
        public string NombreRegion { get => nombreRegion; set => nombreRegion = value; }
    }
}
