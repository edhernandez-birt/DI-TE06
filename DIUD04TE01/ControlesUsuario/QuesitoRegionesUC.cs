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
using System.Windows.Forms.DataVisualization.Charting;
using Utilidades.DTO;

namespace DIUD05TE01.ControlesUsuario
{
    public partial class QuesitoRegionesUC : UserControl
    {
        public QuesitoRegionesUC()
        {
            InitializeComponent();
            //https://help.syncfusion.com/windowsforms/chart/overview

            List<FacturacionRegionDTO> datosRegiones;
            datosRegiones = GestionBLL.PideListaFacturacionRegiones();

            chartRegiones.Series["Series1"].IsValueShownAsLabel = true;
            for (int i = 0; i < datosRegiones.Count; i++)
            {
                chartRegiones.Series["Series1"].Points.AddXY(datosRegiones[i].RegionNombre,
                    datosRegiones[i].RegionFacturacion);
            }

            //https://stackoverflow.com/questions/20204007/change-an-asp-net-chart-label-to-value-and-then-format-only-chart-not-legend
            foreach (Series b in chartRegiones.Series)
            {

                b.Label = "#VALY{#,##0$}";
                b.LegendText = "#VALX";
            }
        }
    }
}
