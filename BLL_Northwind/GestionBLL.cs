using DAL_Northwind;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades.DTO;
using Utilidades.VO;

namespace BLL_Northwind
{
    //Estas funciones sirven de puente entre UI y el DAL
    public class GestionBLL
    {
        public static ClienteVO PideInfoCliente(string cliente)
        {
            return ConsultasSQL.ConsultarInfoCliente(cliente);
        }

        public static double PideIngresosTotales()
        {
            return ConsultasSQL.IngresosTotales();
        }

        public static double PideVentasTotales()
        {
            return ConsultasSQL.VentasTotales();
        }

        public static double PideIngresosPorCliente(string cliente)
        {
            return ConsultasSQL.IngresosPorCliente(cliente);
        }

        public static int PideVentasPorCliente(string cliente)
        {
            return ConsultasSQL.VentasPorCliente(cliente);
        }

        public static List<ClienteVO> PideConsultaTodosClientes()
        {
            return ConsultasSQL.RealizarConsultaClientes();
        }

        public static List<ProductoVendidoPorVendedorDTO> PideProductosMasVendidosPorVendedor()
        {
            return ConsultasSQL.ProductosMasVendidosPorVendedor();
        }

        public static List<ProductoVendidoPorVendedorDTO> PideProductosMenosVendidosPorVendedor()
        {
            return ConsultasSQL.ProductosMenosVendidosPorVendedor();
        }

        public static List<ProductoVendidoPorVendedorDTO> PideProductosVendidosPorVendedorCliente(string cliente,string orden)
        {
            return ConsultasSQL.ProductosVendidosPorVendedorCliente(cliente, orden);
        }

        public static List<FacturacionRegionDTO> PideListaFacturacionRegiones()
        {
            return ConsultasSQL.ListaFacturacionRegiones();
        }

        public static List<PedidoVO> PideListaPedidosCliente(string cliente)
        {
            return ConsultasSQL.ListaPedidosCliente(cliente);
        }


    }
}
