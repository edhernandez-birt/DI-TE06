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
using Utilidades.VO;

namespace DIUD05TE01.ControlesUsuario
{
    public partial class ListadoPedidosUC : UserControl
    {
        public ListadoPedidosUC(string cliente)
        {
            InitializeComponent();

            List<PedidoVO> datosPedidos;
            datosPedidos = GestionBLL.PideListaPedidosCliente(cliente);
            dgvListaClientes.DataSource = datosPedidos;
        }
    }
}
