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
    public partial class BarrasMenosVendidosUC : UserControl
    {
        public BarrasMenosVendidosUC()
        {
            InitializeComponent();

            List<ProductoVendidoPorVendedorDTO> datosProductosMenosVendidos;

            datosProductosMenosVendidos = GestionBLL.PideProductosMenosVendidosPorVendedor();
            List<string> x1 = new List<string>();
            List<double> y1 = new List<double>();

            for (int i = 0; i < datosProductosMenosVendidos.Count; i++)
            {
                x1.Add(datosProductosMenosVendidos[i].NombreApellidoProducto);
                y1.Add(datosProductosMenosVendidos[i].Ventas);
            }

            //Para que ponga todos los datos en el eje X
            chartMenosVendidos.ChartAreas[0].AxisX.Interval = 1;


            chartMenosVendidos.Series["Series1"].Points.DataBindXY(x1.ToArray(), y1.ToArray());

            chartMenosVendidos.ChartAreas[0].AxisX.Title = "Vendedor y producto";
            chartMenosVendidos.ChartAreas[0].AxisY.Title = "Ventas Totales en $";

            chartMenosVendidos.ChartAreas[0].AxisX.LabelStyle.Angle = -45;

        }

    }
}
