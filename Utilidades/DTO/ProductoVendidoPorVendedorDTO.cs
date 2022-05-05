using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades.DTO
{
    public class ProductoVendidoPorVendedorDTO
    { //Nombre //Apellido //Producto //Ventas
        string nombreApellidoProducto;
        double ventas;

        public ProductoVendidoPorVendedorDTO()
        {
        }

        public string NombreApellidoProducto { get => nombreApellidoProducto; set => nombreApellidoProducto = value; }
        public double Ventas { get => ventas; set => ventas = value; }
    }
}
