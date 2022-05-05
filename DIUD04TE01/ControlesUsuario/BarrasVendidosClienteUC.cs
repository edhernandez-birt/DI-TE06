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
using Utilidades.DTO;

namespace DIUD05TE01.ControlesUsuario
{
    public partial class BarrasVendidosClienteUC : UserControl
    {
        public BarrasVendidosClienteUC(string cliente, string orden)
        {
            InitializeComponent();
            List<ProductoVendidoPorVendedorDTO> datosProductosMasVendidos;

            datosProductosMasVendidos = GestionBLL.PideProductosVendidosPorVendedorCliente(cliente, orden);
            List<string> x1 = new List<string>();
            List<double> y1 = new List<double>();

            for (int i = 0; i < datosProductosMasVendidos.Count; i++)
            {
                x1.Add(datosProductosMasVendidos[i].NombreApellidoProducto);
                y1.Add(datosProductosMasVendidos[i].Ventas);
            }

            //Para que ponga todos los datos en el eje X
            chartMasVendidosCliente.ChartAreas[0].AxisX.Interval = 1;


            chartMasVendidosCliente.Series["Series1"].Points.DataBindXY(x1.ToArray(), y1.ToArray());
            string fraseEjeX;
            string titulo;
            if (orden == "DESC")
            {
                fraseEjeX = "Vendedor y su producto más vendido en " + cliente;
                titulo = "Productos con más facturación por vendedor en " + cliente;
            }else
            {
                fraseEjeX = "Vendedor y su producto menos vendido en " + cliente;
                titulo = "Productos con menos facturación por vendedor en " + cliente;
            }
            chartMasVendidosCliente.ChartAreas[0].AxisX.Title = fraseEjeX;
            chartMasVendidosCliente.ChartAreas[0].AxisY.Title = "Ventas Totales en $";

            chartMasVendidosCliente.ChartAreas[0].AxisX.LabelStyle.Angle = -45;

            chartMasVendidosCliente.Titles[0].Text = titulo; 
        }
    }
}
