using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIUD05TE01.ControlesUsuario.CUCrystalReports
{
    public partial class BotonesFacturacionUC : UserControl
    {
        public BotonesFacturacionUC()
        {
            InitializeComponent();
            ToolTip ttFacturacionCR = new ToolTip();
            ttFacturacionCR.SetToolTip(buttonClientesFactMax,"Clientes con mayor facturación" );
            ttFacturacionCR.SetToolTip(buttonClientesFactMin, "Clientes con menor facturación");
        }

        private void buttonClientesFactMax_Click(object sender, EventArgs e)
        {
            Formulario.InformesCR.FormReportMejoresClientes rptMejoresClientes = new Formulario.InformesCR.FormReportMejoresClientes();
            rptMejoresClientes.Show();
        }

        private void buttonClientesFactMin_Click(object sender, EventArgs e)
        {
            Formulario.InformesCR.FormReportPeoresClientes rptPeoresClientes = new Formulario.InformesCR.FormReportPeoresClientes();
            rptPeoresClientes.Show();
        }

        private void buttonMasFacturacionProductoVendedor_Click(object sender, EventArgs e)
        {
            Formulario.InformesCR.FormReportFacturacionMaxProductosVendedor rptFacturacionMaxProductoVendedor = new Formulario.InformesCR.FormReportFacturacionMaxProductosVendedor();
            rptFacturacionMaxProductoVendedor.Show();
        }

        private void buttonMenosFacturaciónProductoVendedor_Click(object sender, EventArgs e)
        {
            Formulario.InformesCR.FormReportFacturacionMinProductosVendedor rptFacturacionMinProductoVendedor = new Formulario.InformesCR.FormReportFacturacionMinProductosVendedor();
            rptFacturacionMinProductoVendedor.Show();
        }
    }
}
