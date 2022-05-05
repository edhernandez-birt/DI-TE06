using BLL_Northwind;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIUD05TE01.ControlesUsuario
{
    public partial class LabelVentasTotalesUC : UserControl
    {
        public LabelVentasTotalesUC(string cliente)
        {
            double media = 0.0; ;
            double pedidos;
            double facturacion;
            InitializeComponent();
            if (cliente == "ALL")
            {
                labelTextoIngresos.Text = "Facturación total :";
                labelTextoVentas.Text = "Pedidos totales :";

                facturacion = GestionBLL.PideIngresosTotales();
                pedidos = GestionBLL.PideVentasTotales();
                if (pedidos > 0)
                {
                    media = facturacion / pedidos;
                }
                
                labelNumeroVentas.Text = pedidos.ToString();
                labelDolaresVentas.Text = string.Format("{0:#,0.####}", Math.Round(facturacion,0));
                labelMediaCalculada.Text = string.Format("{0:#,0.####}", Math.Round(media, 1)); 
            }
            else
            {
                labelTextoIngresos.Text = "Facturación " + cliente+" :";
                labelTextoVentas.Text = "Pedidos " + cliente+" :";

                facturacion = GestionBLL.PideIngresosPorCliente(cliente);
                pedidos = GestionBLL.PideVentasPorCliente(cliente);
                if (pedidos > 0)
                {
                    media = facturacion / pedidos;
                }

                labelDolaresVentas.Text = string.Format("{0:#,0.####}", Math.Round(facturacion, 0));
                labelNumeroVentas.Text = pedidos.ToString();
                labelMediaCalculada.Text = string.Format("{0:#,0.####}", Math.Round(media, 1));
            }
        }

    }
}
