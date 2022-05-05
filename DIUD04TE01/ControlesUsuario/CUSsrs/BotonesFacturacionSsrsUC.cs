using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIUD05TE01.ControlesUsuario.CUSsrs
{
    public partial class BotonesFacturacionSsrsUC : UserControl
    {
        public BotonesFacturacionSsrsUC()
        {
            InitializeComponent();
        }

        private void buttonMejoresClientes_Click(object sender, EventArgs e)
        {
            Formulario.InformesSSRS.FormReportMejoresClientesSSRS rptMejoresClientesSsrs = new Formulario.InformesSSRS.FormReportMejoresClientesSSRS();
            rptMejoresClientesSsrs.Show();
        }

        private void buttonPeoresClientes_Click(object sender, EventArgs e)
        {
            Formulario.InformesSSRS.FormReportPeoresClientesSSRS rptPeoresClientesSsrs = new Formulario.InformesSSRS.FormReportPeoresClientesSSRS();
            rptPeoresClientesSsrs.Show();
        }

        private void buttonFacturacionVendedores_Click(object sender, EventArgs e)
        {
            Formulario.InformesSSRS.FormReportVendedoresSSRS rptVendedoresSSRS = new Formulario.InformesSSRS.FormReportVendedoresSSRS();
            rptVendedoresSSRS.Show();
        }

        private void buttonFacturacionPorTipoProducto_Click(object sender, EventArgs e)
        {
            Formulario.InformesSSRS.FormReportFacturacionTipoSSRS rptFacturacionTipoSSRS = new Formulario.InformesSSRS.FormReportFacturacionTipoSSRS();
            rptFacturacionTipoSSRS.Show();
        }
    }
}
