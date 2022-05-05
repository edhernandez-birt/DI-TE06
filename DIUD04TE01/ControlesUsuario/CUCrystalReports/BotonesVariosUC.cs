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
    public partial class BotonesVariosUC : UserControl
    {
        private string cliente = "ALL";
        public BotonesVariosUC(string cliente)
        {
            InitializeComponent();
            if (cliente == "ALL")
            {
                buttonListadoPedidos.Text = "Cantidad de productos vendidos";
            }else
            {
                buttonListadoPedidos.Text = "Cantidad de productos vendidos a " + cliente;
            }
            this.cliente = cliente;
        }

        private void tlpBotonesVarios_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonFacturacionTipo_Click(object sender, EventArgs e)
        {
            Formulario.InformesCR.FormReportVentasCategoriaCR rptVentasCategoriaCR = new Formulario.InformesCR.FormReportVentasCategoriaCR();
            rptVentasCategoriaCR.Show();
        }

        private void buttonFactPorVendedr_Click(object sender, EventArgs e)
        {
             Formulario.InformesCR.FormReportVendedores rptVendedores = new Formulario.InformesCR.FormReportVendedores();
             rptVendedores.Show();
        }

        private void buttonListadoPedidos_Click(object sender, EventArgs e)
        {
            Formulario.InformesCR.FormReportListadoClientesCR rptListadoClientes = new Formulario.InformesCR.FormReportListadoClientesCR(cliente);
            rptListadoClientes.Show();
        }

        private void buttonPedidosPendientes_Click(object sender, EventArgs e)
        {
            Formulario.InformesCR.FormReportPedidosPendientesCR rptPedidosPendientes = new Formulario.InformesCR.FormReportPedidosPendientesCR();
            rptPedidosPendientes.Show();
        }
    }
}
