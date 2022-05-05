using System.Windows.Forms;

namespace DIUD05TE01.Formulario
{
    partial class FormularioNW
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }



        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.tlpClientes = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSSRS = new System.Windows.Forms.Button();
            this.buttonFacturacion = new System.Windows.Forms.Button();
            this.buttonVendedores = new System.Windows.Forms.Button();
            this.labelOpcionesClientes = new System.Windows.Forms.Label();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.buttonReportCrystal = new System.Windows.Forms.Button();
            this.tlpFiltros = new System.Windows.Forms.TableLayoutPanel();
            this.labelBusqueda = new System.Windows.Forms.Label();
            this.labelListado = new System.Windows.Forms.Label();
            this.textBoxBusqueda = new System.Windows.Forms.TextBox();
            this.comboBoxClientes = new System.Windows.Forms.ComboBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonVersion = new System.Windows.Forms.Button();
            this.tlpResultados = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crystalReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sSRSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ttFormPrincipal = new System.Windows.Forms.ToolTip(this.components);
            this.tlpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.tlpClientes.SuspendLayout();
            this.tlpFiltros.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tlpPrincipal.ColumnCount = 2;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tlpPrincipal.Controls.Add(this.pictureBoxLogo, 0, 1);
            this.tlpPrincipal.Controls.Add(this.tlpClientes, 0, 2);
            this.tlpPrincipal.Controls.Add(this.tlpFiltros, 1, 1);
            this.tlpPrincipal.Controls.Add(this.tlpResultados, 1, 2);
            this.tlpPrincipal.Controls.Add(this.menuStrip1, 1, 0);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Margin = new System.Windows.Forms.Padding(4);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 3;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tlpPrincipal.Size = new System.Drawing.Size(1924, 1055);
            this.tlpPrincipal.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxLogo.Image = global::DIUD05TE01.Properties.Resources.logoNW;
            this.pictureBoxLogo.Location = new System.Drawing.Point(4, 35);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(280, 118);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // tlpClientes
            // 
            this.tlpClientes.ColumnCount = 1;
            this.tlpClientes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpClientes.Controls.Add(this.buttonSSRS, 0, 5);
            this.tlpClientes.Controls.Add(this.buttonFacturacion, 0, 3);
            this.tlpClientes.Controls.Add(this.buttonVendedores, 0, 2);
            this.tlpClientes.Controls.Add(this.labelOpcionesClientes, 0, 0);
            this.tlpClientes.Controls.Add(this.buttonInfo, 0, 1);
            this.tlpClientes.Controls.Add(this.buttonReportCrystal, 0, 4);
            this.tlpClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpClientes.Location = new System.Drawing.Point(4, 161);
            this.tlpClientes.Margin = new System.Windows.Forms.Padding(4);
            this.tlpClientes.Name = "tlpClientes";
            this.tlpClientes.RowCount = 6;
            this.tlpClientes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpClientes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tlpClientes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tlpClientes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tlpClientes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tlpClientes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tlpClientes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpClientes.Size = new System.Drawing.Size(280, 890);
            this.tlpClientes.TabIndex = 1;
            // 
            // buttonSSRS
            // 
            this.buttonSSRS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSSRS.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSSRS.ForeColor = System.Drawing.Color.Teal;
            this.buttonSSRS.Location = new System.Drawing.Point(3, 731);
            this.buttonSSRS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSSRS.Name = "buttonSSRS";
            this.buttonSSRS.Size = new System.Drawing.Size(274, 157);
            this.buttonSSRS.TabIndex = 6;
            this.buttonSSRS.Text = "Informes SSRS";
            this.buttonSSRS.UseVisualStyleBackColor = true;
            this.buttonSSRS.Click += new System.EventHandler(this.buttonSSRS_Click);
            // 
            // buttonFacturacion
            // 
            this.buttonFacturacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonFacturacion.Enabled = false;
            this.buttonFacturacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFacturacion.ForeColor = System.Drawing.Color.Teal;
            this.buttonFacturacion.Location = new System.Drawing.Point(4, 413);
            this.buttonFacturacion.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFacturacion.Name = "buttonFacturacion";
            this.buttonFacturacion.Size = new System.Drawing.Size(272, 152);
            this.buttonFacturacion.TabIndex = 3;
            this.buttonFacturacion.Text = "Facturación";
            this.buttonFacturacion.UseVisualStyleBackColor = true;
            this.buttonFacturacion.Click += new System.EventHandler(this.buttonFacturacion_Click);
            // 
            // buttonVendedores
            // 
            this.buttonVendedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonVendedores.Enabled = false;
            this.buttonVendedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVendedores.ForeColor = System.Drawing.Color.Teal;
            this.buttonVendedores.Location = new System.Drawing.Point(4, 253);
            this.buttonVendedores.Margin = new System.Windows.Forms.Padding(4);
            this.buttonVendedores.Name = "buttonVendedores";
            this.buttonVendedores.Size = new System.Drawing.Size(272, 152);
            this.buttonVendedores.TabIndex = 2;
            this.buttonVendedores.Text = "Vendedores / Productos";
            this.buttonVendedores.UseVisualStyleBackColor = true;
            this.buttonVendedores.Click += new System.EventHandler(this.buttonVendedores_Click);
            // 
            // labelOpcionesClientes
            // 
            this.labelOpcionesClientes.AutoSize = true;
            this.labelOpcionesClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelOpcionesClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOpcionesClientes.Location = new System.Drawing.Point(4, 0);
            this.labelOpcionesClientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOpcionesClientes.Name = "labelOpcionesClientes";
            this.labelOpcionesClientes.Size = new System.Drawing.Size(272, 89);
            this.labelOpcionesClientes.TabIndex = 0;
            this.labelOpcionesClientes.Text = "Elija una empresa\r\npara activar botones";
            this.labelOpcionesClientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonInfo
            // 
            this.buttonInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInfo.ForeColor = System.Drawing.Color.Teal;
            this.buttonInfo.Location = new System.Drawing.Point(3, 91);
            this.buttonInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(274, 156);
            this.buttonInfo.TabIndex = 4;
            this.buttonInfo.Text = "Información";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // buttonReportCrystal
            // 
            this.buttonReportCrystal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonReportCrystal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReportCrystal.ForeColor = System.Drawing.Color.Teal;
            this.buttonReportCrystal.Location = new System.Drawing.Point(3, 571);
            this.buttonReportCrystal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonReportCrystal.Name = "buttonReportCrystal";
            this.buttonReportCrystal.Size = new System.Drawing.Size(274, 156);
            this.buttonReportCrystal.TabIndex = 5;
            this.buttonReportCrystal.Text = "Informes Crystal";
            this.buttonReportCrystal.UseVisualStyleBackColor = true;
            this.buttonReportCrystal.Click += new System.EventHandler(this.buttonReportCrystal_Click);
            // 
            // tlpFiltros
            // 
            this.tlpFiltros.ColumnCount = 4;
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpFiltros.Controls.Add(this.labelBusqueda, 1, 0);
            this.tlpFiltros.Controls.Add(this.labelListado, 0, 0);
            this.tlpFiltros.Controls.Add(this.textBoxBusqueda, 1, 1);
            this.tlpFiltros.Controls.Add(this.comboBoxClientes, 0, 1);
            this.tlpFiltros.Controls.Add(this.buttonBuscar, 2, 1);
            this.tlpFiltros.Controls.Add(this.buttonVersion, 3, 0);
            this.tlpFiltros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFiltros.Location = new System.Drawing.Point(292, 35);
            this.tlpFiltros.Margin = new System.Windows.Forms.Padding(4);
            this.tlpFiltros.Name = "tlpFiltros";
            this.tlpFiltros.RowCount = 2;
            this.tlpFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFiltros.Size = new System.Drawing.Size(1628, 118);
            this.tlpFiltros.TabIndex = 2;
            // 
            // labelBusqueda
            // 
            this.labelBusqueda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelBusqueda.AutoSize = true;
            this.labelBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBusqueda.ForeColor = System.Drawing.Color.Teal;
            this.labelBusqueda.Location = new System.Drawing.Point(968, 10);
            this.labelBusqueda.Name = "labelBusqueda";
            this.labelBusqueda.Size = new System.Drawing.Size(179, 39);
            this.labelBusqueda.TabIndex = 1;
            this.labelBusqueda.Text = "Busqueda";
            // 
            // labelListado
            // 
            this.labelListado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelListado.AutoSize = true;
            this.labelListado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListado.ForeColor = System.Drawing.Color.Teal;
            this.labelListado.Location = new System.Drawing.Point(273, 10);
            this.labelListado.Name = "labelListado";
            this.labelListado.Size = new System.Drawing.Size(268, 39);
            this.labelListado.TabIndex = 0;
            this.labelListado.Text = "Listado clientes";
            // 
            // textBoxBusqueda
            // 
            this.textBoxBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBusqueda.Location = new System.Drawing.Point(817, 61);
            this.textBoxBusqueda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxBusqueda.Name = "textBoxBusqueda";
            this.textBoxBusqueda.Size = new System.Drawing.Size(482, 34);
            this.textBoxBusqueda.TabIndex = 2;
            this.textBoxBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // comboBoxClientes
            // 
            this.comboBoxClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxClientes.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxClientes.FormattingEnabled = true;
            this.comboBoxClientes.Location = new System.Drawing.Point(3, 61);
            this.comboBoxClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxClientes.Name = "comboBoxClientes";
            this.comboBoxClientes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxClientes.Size = new System.Drawing.Size(808, 37);
            this.comboBoxClientes.TabIndex = 3;
            this.comboBoxClientes.SelectionChangeCommitted += new System.EventHandler(this.comboBoxClientes_SelectionChangeCommitted);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.Location = new System.Drawing.Point(1305, 61);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(156, 38);
            this.buttonBuscar.TabIndex = 4;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // buttonVersion
            // 
            this.buttonVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVersion.Location = new System.Drawing.Point(1467, 3);
            this.buttonVersion.Name = "buttonVersion";
            this.buttonVersion.Size = new System.Drawing.Size(158, 53);
            this.buttonVersion.TabIndex = 5;
            this.buttonVersion.Text = "Versión";
            this.buttonVersion.UseVisualStyleBackColor = true;
            this.buttonVersion.Click += new System.EventHandler(this.buttonVersion_Click);
            // 
            // tlpResultados
            // 
            this.tlpResultados.ColumnCount = 2;
            this.tlpResultados.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpResultados.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpResultados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpResultados.Location = new System.Drawing.Point(292, 161);
            this.tlpResultados.Margin = new System.Windows.Forms.Padding(4);
            this.tlpResultados.Name = "tlpResultados";
            this.tlpResultados.RowCount = 2;
            this.tlpResultados.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpResultados.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpResultados.Size = new System.Drawing.Size(1628, 890);
            this.tlpResultados.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informesToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(288, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(1636, 31);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crystalReportToolStripMenuItem,
            this.sSRSToolStripMenuItem});
            this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            this.informesToolStripMenuItem.Size = new System.Drawing.Size(81, 27);
            this.informesToolStripMenuItem.Text = "Informes";
            // 
            // crystalReportToolStripMenuItem
            // 
            this.crystalReportToolStripMenuItem.Name = "crystalReportToolStripMenuItem";
            this.crystalReportToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.crystalReportToolStripMenuItem.Text = "Crystal Report";
            this.crystalReportToolStripMenuItem.Click += new System.EventHandler(this.crystalReportToolStripMenuItem_Click);
            // 
            // sSRSToolStripMenuItem
            // 
            this.sSRSToolStripMenuItem.Name = "sSRSToolStripMenuItem";
            this.sSRSToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.sSRSToolStripMenuItem.Text = "SSRS";
            this.sSRSToolStripMenuItem.Click += new System.EventHandler(this.sSRSToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualDeUsuarioToolStripMenuItem,
            this.versionToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.ShowShortcutKeys = false;
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(65, 27);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // manualDeUsuarioToolStripMenuItem
            // 
            this.manualDeUsuarioToolStripMenuItem.Name = "manualDeUsuarioToolStripMenuItem";
            this.manualDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.manualDeUsuarioToolStripMenuItem.Text = "Manual de usuario";
            this.manualDeUsuarioToolStripMenuItem.Click += new System.EventHandler(this.manualDeUsuarioToolStripMenuItem_Click);
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.versionToolStripMenuItem.Text = "Version";
            this.versionToolStripMenuItem.Click += new System.EventHandler(this.versionToolStripMenuItem_Click);
            // 
            // FormularioNW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.tlpPrincipal);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormularioNW";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Nortwinds";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tlpPrincipal.ResumeLayout(false);
            this.tlpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.tlpClientes.ResumeLayout(false);
            this.tlpClientes.PerformLayout();
            this.tlpFiltros.ResumeLayout(false);
            this.tlpFiltros.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.TableLayoutPanel tlpClientes;
        private System.Windows.Forms.TableLayoutPanel tlpFiltros;
        private System.Windows.Forms.Label labelOpcionesClientes;
        private System.Windows.Forms.Button buttonFacturacion;
        private System.Windows.Forms.Button buttonVendedores;
        private System.Windows.Forms.TableLayoutPanel tlpResultados;
        private Button buttonInfo;
        private Label labelBusqueda;
        private Label labelListado;
        private TextBox textBoxBusqueda;
        private ComboBox comboBoxClientes;
        private Button buttonBuscar;
        private Button buttonSSRS;
        private Button buttonReportCrystal;
        private ToolTip ttFormPrincipal;
        private Button buttonVersion;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem informesToolStripMenuItem;
        private ToolStripMenuItem crystalReportToolStripMenuItem;
        private ToolStripMenuItem sSRSToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem manualDeUsuarioToolStripMenuItem;
        private ToolStripMenuItem versionToolStripMenuItem;
    }
}

