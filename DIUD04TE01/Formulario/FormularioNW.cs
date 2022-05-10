using BLL_Northwind;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilidades.VO;

namespace DIUD05TE01.Formulario
{
    public partial class FormularioNW : Form
    {
        #region Atributos
        private TableLayoutPanel tlpGrande;
        private UserControl ventasTotales;
        private UserControl ventasCliente;
        private UserControl quesitoRegiones;
        private UserControl productosMasVendidos;
        private UserControl productosMenosVendidos;
        private UserControl productosMasVendidosCliente;
        private UserControl productosMenosVendidosCliente;
        private UserControl infoCliente;
        private UserControl pedidosCliente;
        private UserControl facturacionCrystal;
        private UserControl variosCrystal;
        private UserControl avisoInforme;
        private UserControl logoCrystal;
        private UserControl facturacionSsrs;
     // private UserControl variosSsrs;
        private UserControl logoSsrs;

        private string cliente;
        #endregion

        #region Constructor
        public FormularioNW()
        {
            InitializeComponent();

            //Inicialización de zona central con datos generales
            cliente = "ALL";
            tlpGrande = tlpResultados;

            quesitoRegiones = new ControlesUsuario.QuesitoRegionesUC();
            ventasTotales = new ControlesUsuario.LabelVentasTotalesUC(cliente);
            productosMasVendidos = new ControlesUsuario.BarrasMasVendidosUC();
            productosMenosVendidos = new ControlesUsuario.BarrasMenosVendidosUC();

            tlpGrande.Controls.Add(ventasTotales, 0, 0);
            tlpGrande.Controls.Add(quesitoRegiones, 1, 0);
            tlpGrande.Controls.Add(productosMasVendidos, 0, 1);
            tlpGrande.Controls.Add(productosMenosVendidos, 1, 1);
           
            //Desactivar botones laterales al inicio
            DesactivaBotones();

            //Cargamos el combobox con los nombres de los clientes
            CargarComboBox();

            //TootTips del formulario principal

            this.ttFormPrincipal.SetToolTip(this.comboBoxClientes, "Elige un cliente del ComboBox para activar botones");

            this.ttFormPrincipal.SetToolTip(this.labelListado, "Elige un cliente del ComboBox inferior");
            this.ttFormPrincipal.SetToolTip(this.labelBusqueda, "Funcionalidad sin implementar");

            this.ttFormPrincipal.SetToolTip(this.buttonInfo, "Muestra información general del cliente");
            this.ttFormPrincipal.SetToolTip(this.buttonFacturacion, "Detalles sobre facturación");
            this.ttFormPrincipal.SetToolTip(this.buttonVendedores, "Productos con más y menos facturación por vendedor");
            this.ttFormPrincipal.SetToolTip(this.buttonReportCrystal, "Informes Crystal Report");
            this.ttFormPrincipal.SetToolTip(this.buttonSSRS, "Informes SSRS");
            this.ttFormPrincipal.SetToolTip(this.buttonVersion, "Abre Pop-Up de ayuda");


        }

        #endregion

        #region Eventos

        /// <summary>
        /// Evento cuando cambia el ComboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxClientes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string valorComboBox = comboBoxClientes.SelectedValue.ToString();

            if (valorComboBox == "ALL")
            {
                cliente = "ALL";
                labelOpcionesClientes.Text = "Elija una empresa para activar botones";
                tlpGrande.Controls.Clear();
                
                //Lo reinstanciamos aquí porque depende del cliente
                ventasTotales = new ControlesUsuario.LabelVentasTotalesUC(cliente);
                
                //Mostrar graficos generales
                tlpGrande.Controls.Add(ventasTotales, 0, 0);
                tlpGrande.Controls.Add(quesitoRegiones, 1, 0);
                tlpGrande.Controls.Add(productosMasVendidos, 0, 1);
                tlpGrande.Controls.Add(productosMenosVendidos, 1, 1);

                //Desactivar botones laterales
                DesactivaBotones();
            }
            else //Va a ser un CustomerId
            {
                cliente = comboBoxClientes.SelectedValue.ToString();
                labelOpcionesClientes.Text = cliente;

                //Mostrar info del cliente

                //Limpiar el tlp
                tlpGrande.Controls.Clear();

                infoCliente = new ControlesUsuario.InfoClienteUC(cliente);
                pedidosCliente = new ControlesUsuario.ListadoPedidosUC(cliente);
                ventasCliente = new ControlesUsuario.LabelVentasTotalesUC(cliente);

                tlpGrande.Controls.Add(infoCliente, 0, 0);
                tlpGrande.Controls.Add(pedidosCliente, 0, 1);
                tlpGrande.Controls.Add(ventasCliente, 1, 0);
                tlpGrande.Controls.Add(quesitoRegiones, 1, 1);  //Para rellenar (sería mejor crear alguno personalizado)

                //Activar botones
                ActivaBotones();
            }
        }

        #endregion

        /// <summary>
        /// Evento cuando hacemos click a Informacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonInfo_Click(object sender, EventArgs e)
        {
            //infoCliente = new ControlesUsuario.InfoClienteUC(cliente);
            tlpGrande.Controls.Clear();
            tlpGrande.Controls.Add(infoCliente, 0, 0);
            tlpGrande.Controls.Add(pedidosCliente, 0, 1);
            tlpGrande.Controls.Add(ventasCliente, 1, 0);
            tlpGrande.Controls.Add(quesitoRegiones, 1, 1);
        }

        /// <summary>
        /// Evento cuando hacemos click a Vendedores / Producto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonVendedores_Click(object sender, EventArgs e)
        {
            productosMasVendidosCliente = new ControlesUsuario.BarrasVendidosClienteUC(cliente,"DESC");
            productosMenosVendidosCliente = new ControlesUsuario.BarrasVendidosClienteUC(cliente, "ASC");

            tlpGrande.Controls.Clear();
            tlpGrande.Controls.Add(productosMasVendidosCliente, 0, 0);
            tlpGrande.Controls.Add(productosMenosVendidosCliente, 1, 0);
            tlpGrande.Controls.Add(productosMasVendidos, 0, 1);
            tlpGrande.Controls.Add(productosMenosVendidos, 1, 1);
        }

        /// <summary>
        /// Evento cuando hacemos click a Facturación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFacturacion_Click(object sender, EventArgs e)
        {
            ventasCliente = new ControlesUsuario.LabelVentasTotalesUC(cliente);
            tlpGrande.Controls.Clear();
            tlpGrande.Controls.Add(ventasCliente, 0, 0);
            tlpGrande.Controls.Add(pedidosCliente, 0, 1);
            tlpGrande.Controls.Add(ventasTotales, 1, 0);
            tlpGrande.Controls.Add(quesitoRegiones, 1, 1);
        }

        #region Métodos auxiliares

        /// <summary>
        /// Método para cargar los nombres y valores de los clientes en el combobox del filtro superior
        /// </summary>
        private void CargarComboBox()
        {
            List<ClienteVO> datosClientes;
            datosClientes = GestionBLL.PideConsultaTodosClientes();

            //Invento un cliente "ALL" para mostrar informacion general en la primera posicion del ComboBox
            ClienteVO clienteAll = new ClienteVO();
            clienteAll.IdCliente = "ALL";
            clienteAll.NombreEmpresa = "TODOS (ALL)";
            datosClientes.Insert(0, clienteAll);

            comboBoxClientes.DataSource = datosClientes;
            comboBoxClientes.DisplayMember = "NombreEmpresa";
            comboBoxClientes.ValueMember = "IdCliente";
        }

        /// <summary>
        /// Activa los botones laterales
        /// </summary>
        private void ActivaBotones()
        {
            buttonInfo.Enabled = true;
            buttonVendedores.Enabled = true;
            buttonFacturacion.Enabled = true;
        }

        /// <summary>
        /// Desactiva los botones laterales
        /// </summary>
        private void DesactivaBotones()
        {
            buttonInfo.Enabled = false;
            buttonVendedores.Enabled = false;
            buttonFacturacion.Enabled = false;
            //De momento desactivamos también búsqueda
            buttonBuscar.Enabled = false;
            textBoxBusqueda.Enabled = false;
        }

        private void mostrarZonaCrystalReport()
        {
            facturacionCrystal = new ControlesUsuario.CUCrystalReports.BotonesFacturacionUC();
            variosCrystal = new ControlesUsuario.CUCrystalReports.BotonesVariosUC(cliente);
            avisoInforme = new ControlesUsuario.CUCrystalReports.AvisoInformeUC();
            logoCrystal = new ControlesUsuario.CUCrystalReports.LogoCrystalUC();
            tlpGrande.Controls.Clear();
            tlpGrande.Controls.Add(facturacionCrystal, 0, 1);
            tlpGrande.Controls.Add(variosCrystal, 1, 1);
            tlpGrande.Controls.Add(avisoInforme, 0, 0);
            tlpGrande.Controls.Add(logoCrystal, 1, 0);
        }

        private void mostrarZonaSsrs()
        {
            avisoInforme = new ControlesUsuario.CUCrystalReports.AvisoInformeUC();
            logoSsrs = new ControlesUsuario.CUSsrs.LogoSsrsUC();
            facturacionSsrs = new ControlesUsuario.CUSsrs.BotonesFacturacionSsrsUC();
            tlpGrande.Controls.Clear();
            tlpGrande.Controls.Add(avisoInforme, 0, 0);
            tlpGrande.Controls.Add(logoSsrs, 1, 0);
            tlpGrande.Controls.Add(facturacionSsrs, 0, 1);
        }

        private void mostrarVersionPopUp()
        {
            PopUp.FormPopUp popUp = new PopUp.FormPopUp();
            popUp.Show();
        }



        #endregion

        private void buttonReportCrystal_Click(object sender, EventArgs e)
        {
            mostrarZonaCrystalReport();
        }

        private void buttonSSRS_Click(object sender, EventArgs e)
        {
            mostrarZonaSsrs();
        }

        private void buttonVersion_Click(object sender, EventArgs e)
        {
            mostrarVersionPopUp();
        }

        private void crystalReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarZonaCrystalReport();
        }

        private void sSRSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarZonaSsrs();
        }

        private void manualDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Ruta relativa
            Help.ShowHelp(this, @"..\..\Resources\AyudaDashboard.chm");

            //Ayuda encontrada:
            //https://docs.microsoft.com/en-us/answers/questions/241652/c-relative-absolute-path.html?msclkid=4d43b433d08111ec9214c55917b8b0bc
            //string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            //string sFile = System.IO.Path.Combine(sCurrentDirectory, @"..\..\Resources\AyudaDashboard.chm");
            //string sFilePath = Path.GetFullPath(sFile);
            // Help.ShowHelp(this, sFilePath);

            //Con ruta absoluta:
            //Help.ShowHelp(this, "file:D:\\GIT\\DI06TE01\\DI-TE06\\DIUD04TE01\\Resources\\AyudaDashboard.chm");
        }   

        private void versionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarVersionPopUp();
        }


    }
}
