
namespace DIUD05TE01.ControlesUsuario.CUCrystalReports
{
    partial class BotonesVariosUC
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpBotonesVarios = new System.Windows.Forms.TableLayoutPanel();
            this.buttonPedidosPendientes = new System.Windows.Forms.Button();
            this.buttonListadoPedidos = new System.Windows.Forms.Button();
            this.buttonFacturacionTipo = new System.Windows.Forms.Button();
            this.buttonFactPorVendedr = new System.Windows.Forms.Button();
            this.tlpBotonesVarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpBotonesVarios
            // 
            this.tlpBotonesVarios.ColumnCount = 2;
            this.tlpBotonesVarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotonesVarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotonesVarios.Controls.Add(this.buttonPedidosPendientes, 0, 1);
            this.tlpBotonesVarios.Controls.Add(this.buttonListadoPedidos, 0, 1);
            this.tlpBotonesVarios.Controls.Add(this.buttonFacturacionTipo, 1, 0);
            this.tlpBotonesVarios.Controls.Add(this.buttonFactPorVendedr, 0, 0);
            this.tlpBotonesVarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBotonesVarios.Location = new System.Drawing.Point(0, 0);
            this.tlpBotonesVarios.Margin = new System.Windows.Forms.Padding(2);
            this.tlpBotonesVarios.Name = "tlpBotonesVarios";
            this.tlpBotonesVarios.RowCount = 2;
            this.tlpBotonesVarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotonesVarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotonesVarios.Size = new System.Drawing.Size(800, 440);
            this.tlpBotonesVarios.TabIndex = 0;
            this.tlpBotonesVarios.Paint += new System.Windows.Forms.PaintEventHandler(this.tlpBotonesVarios_Paint);
            // 
            // buttonPedidosPendientes
            // 
            this.buttonPedidosPendientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPedidosPendientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPedidosPendientes.ForeColor = System.Drawing.Color.Teal;
            this.buttonPedidosPendientes.Location = new System.Drawing.Point(2, 222);
            this.buttonPedidosPendientes.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPedidosPendientes.Name = "buttonPedidosPendientes";
            this.buttonPedidosPendientes.Size = new System.Drawing.Size(396, 216);
            this.buttonPedidosPendientes.TabIndex = 3;
            this.buttonPedidosPendientes.Text = "Pedidos pendientes de envío";
            this.buttonPedidosPendientes.UseVisualStyleBackColor = true;
            this.buttonPedidosPendientes.Click += new System.EventHandler(this.buttonPedidosPendientes_Click);
            // 
            // buttonListadoPedidos
            // 
            this.buttonListadoPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonListadoPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListadoPedidos.ForeColor = System.Drawing.Color.Teal;
            this.buttonListadoPedidos.Location = new System.Drawing.Point(402, 222);
            this.buttonListadoPedidos.Margin = new System.Windows.Forms.Padding(2);
            this.buttonListadoPedidos.Name = "buttonListadoPedidos";
            this.buttonListadoPedidos.Size = new System.Drawing.Size(396, 216);
            this.buttonListadoPedidos.TabIndex = 2;
            this.buttonListadoPedidos.Text = "Cantidad de productos vendidos";
            this.buttonListadoPedidos.UseVisualStyleBackColor = true;
            this.buttonListadoPedidos.Click += new System.EventHandler(this.buttonListadoPedidos_Click);
            // 
            // buttonFacturacionTipo
            // 
            this.buttonFacturacionTipo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonFacturacionTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFacturacionTipo.ForeColor = System.Drawing.Color.Teal;
            this.buttonFacturacionTipo.Location = new System.Drawing.Point(402, 2);
            this.buttonFacturacionTipo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFacturacionTipo.Name = "buttonFacturacionTipo";
            this.buttonFacturacionTipo.Size = new System.Drawing.Size(396, 216);
            this.buttonFacturacionTipo.TabIndex = 1;
            this.buttonFacturacionTipo.Text = "Facturacion por tipo de producto";
            this.buttonFacturacionTipo.UseVisualStyleBackColor = true;
            this.buttonFacturacionTipo.Click += new System.EventHandler(this.buttonFacturacionTipo_Click);
            // 
            // buttonFactPorVendedr
            // 
            this.buttonFactPorVendedr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonFactPorVendedr.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFactPorVendedr.ForeColor = System.Drawing.Color.Teal;
            this.buttonFactPorVendedr.Location = new System.Drawing.Point(2, 2);
            this.buttonFactPorVendedr.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFactPorVendedr.Name = "buttonFactPorVendedr";
            this.buttonFactPorVendedr.Size = new System.Drawing.Size(396, 216);
            this.buttonFactPorVendedr.TabIndex = 0;
            this.buttonFactPorVendedr.Text = "Facturacion por vendedor";
            this.buttonFactPorVendedr.UseVisualStyleBackColor = true;
            this.buttonFactPorVendedr.Click += new System.EventHandler(this.buttonFactPorVendedr_Click);
            // 
            // BotonesVariosUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpBotonesVarios);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BotonesVariosUC";
            this.Size = new System.Drawing.Size(800, 440);
            this.tlpBotonesVarios.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpBotonesVarios;
        private System.Windows.Forms.Button buttonFacturacionTipo;
        private System.Windows.Forms.Button buttonFactPorVendedr;
        private System.Windows.Forms.Button buttonPedidosPendientes;
        private System.Windows.Forms.Button buttonListadoPedidos;
    }
}
