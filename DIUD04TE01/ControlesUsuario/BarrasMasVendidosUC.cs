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
    public partial class BarrasMasVendidosUC : UserControl
    {
        public BarrasMasVendidosUC()
        {
            InitializeComponent();

            List<ProductoVendidoPorVendedorDTO> datosProductosMasVendidos;

            datosProductosMasVendidos = GestionBLL.PideProductosMasVendidosPorVendedor();
            List<string> x1 = new List<string>();
            List<double> y1 = new List<double>();

            for (int i = 0; i < datosProductosMasVendidos.Count; i++)
            {
                x1.Add(datosProductosMasVendidos[i].NombreApellidoProducto);
                y1.Add(datosProductosMasVendidos[i].Ventas);
            }

            //Para que ponga todos los datos en el eje X
            chartBarrasMasVendidos.ChartAreas[0].AxisX.Interval = 1;
            

            chartBarrasMasVendidos.Series["Series1"].Points.DataBindXY(x1.ToArray(), y1.ToArray());

            chartBarrasMasVendidos.ChartAreas[0].AxisX.Title = "Vendedor y producto";
            chartBarrasMasVendidos.ChartAreas[0].AxisY.Title = "Ventas Totales en $";

            chartBarrasMasVendidos.ChartAreas[0].AxisX.LabelStyle.Angle = -45;

        }

    }
}
