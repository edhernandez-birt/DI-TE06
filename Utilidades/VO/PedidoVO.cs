using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades.VO
{
    public class PedidoVO
    {
        private int idPedido;
        private string idCliente;
        private int idEmpleado;
        private DateTime fechaPedido;
        private DateTime fechaRequerida;
        private DateTime? fechaEnvio;
        private int via;
        private double flete;

        public PedidoVO()
        {

        }
        public PedidoVO(int idPedido, string idCliente, int idEmpleado, DateTime fechaPedido, DateTime fechaRequerida, DateTime fechaEnvio, int via, double precio)
        {
            this.idPedido = idPedido;
            this.idCliente = idCliente;
            this.idEmpleado = idEmpleado;
            this.fechaPedido = fechaPedido;
            this.fechaRequerida = fechaRequerida;
            this.fechaEnvio = fechaEnvio;
            this.via = via;
            this.flete = precio;
        }

        public int IdPedido { get => idPedido; set => idPedido = value; }
        public string IdCliente { get => idCliente; set => idCliente = value; }
        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        public DateTime FechaPedido { get => fechaPedido; set => fechaPedido = value; }
        public DateTime FechaRequerida { get => fechaRequerida; set => fechaRequerida = value; }
        public DateTime? FechaEnvio { get => fechaEnvio; set => fechaEnvio = value; }
        public int Via { get => via; set => via = value; }
        public double Flete { get => flete; set => flete = value; }

        public override string ToString()
        {
            return "Pedido: " + IdPedido + " " + IdEmpleado + " " + FechaPedido + " " + FechaRequerida + " " +
            FechaEnvio + " " + Via + " " + Flete;
        }
    }
}
