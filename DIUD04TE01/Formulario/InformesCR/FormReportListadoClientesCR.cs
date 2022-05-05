using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIUD05TE01.Formulario.InformesCR
{
    public partial class FormReportListadoClientesCR : Form
    {
        public FormReportListadoClientesCR(string cliente)
        {
            InitializeComponent();
            CrystalReportProductosVendidos reportProductosVendidos = new CrystalReportProductosVendidos();
            reportProductosVendidos.SetParameterValue("@CustomerID", cliente);
            crystalReportViewer1.ReportSource = reportProductosVendidos;
        }

    }
}
