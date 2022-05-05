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
    public partial class InfoClienteUC : UserControl
    {
        public InfoClienteUC(string cliente)
        {
            InitializeComponent();
            ClienteVO clienteVO = GestionBLL.PideInfoCliente(cliente);
            labelCompany.Text = clienteVO.NombreEmpresa;
            labelDireccion.Text = clienteVO.Direccion + " CP: " + clienteVO.CodigoPostal;
            labelCiudadPais.Text = clienteVO.Ciudad + ", " + clienteVO.Pais;
            labelPersonaContacto.Text = clienteVO.NombreContacto;
            labelTelefono.Text = clienteVO.Telefono;
        }

    }
}
