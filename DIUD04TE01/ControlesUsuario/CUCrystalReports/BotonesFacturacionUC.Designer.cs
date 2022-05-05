
namespace DIUD05TE01.ControlesUsuario.CUCrystalReports
{
    partial class BotonesFacturacionUC
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
            this.tlpFacturacion = new System.Windows.Forms.TableLayoutPanel();
            this.buttonMenosFacturaciónProductoVendedor = new System.Windows.Forms.Button();
            this.buttonClientesFactMin = new System.Windows.Forms.Button();
            this.buttonClientesFactMax = new System.Windows.Forms.Button();
            this.buttonMasFacturacionProductoVendedor = new System.Windows.Forms.Button();
            this.tlpFacturacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpFacturacion
            // 
            this.tlpFacturacion.ColumnCount = 2;
            this.tlpFacturacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFacturacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFacturacion.Controls.Add(this.buttonMenosFacturaciónProductoVendedor, 1, 1);
            this.tlpFacturacion.Controls.Add(this.buttonClientesFactMin, 0, 1);
            this.tlpFacturacion.Controls.Add(this.buttonClientesFactMax, 0, 0);
            this.tlpFacturacion.Controls.Add(this.buttonMasFacturacionProductoVendedor, 1, 0);
            this.tlpFacturacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFacturacion.Location = new System.Drawing.Point(0, 0);
            this.tlpFacturacion.Margin = new System.Windows.Forms.Padding(2);
            this.tlpFacturacion.Name = "tlpFacturacion";
            this.tlpFacturacion.RowCount = 2;
            this.tlpFacturacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFacturacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFacturacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpFacturacion.Size = new System.Drawing.Size(800, 440);
            this.tlpFacturacion.TabIndex = 0;
            // 
            // buttonMenosFacturaciónProductoVendedor
            // 
            this.buttonMenosFacturaciónProductoVendedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonMenosFacturaciónProductoVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenosFacturaciónProductoVendedor.ForeColor = System.Drawing.Color.Teal;
            this.buttonMenosFacturaciónProductoVendedor.Location = new System.Drawing.Point(402, 222);
            this.buttonMenosFacturaciónProductoVendedor.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMenosFacturaciónProductoVendedor.Name = "buttonMenosFacturaciónProductoVendedor";
            this.buttonMenosFacturaciónProductoVendedor.Size = new System.Drawing.Size(396, 216);
            this.buttonMenosFacturaciónProductoVendedor.TabIndex = 5;
            this.buttonMenosFacturaciónProductoVendedor.Text = "Productos con menos facturación por vendedor";
            this.buttonMenosFacturaciónProductoVendedor.UseVisualStyleBackColor = true;
            this.buttonMenosFacturaciónProductoVendedor.Click += new System.EventHandler(this.buttonMenosFacturaciónProductoVendedor_Click);
            // 
            // buttonClientesFactMin
            // 
            this.buttonClientesFactMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonClientesFactMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClientesFactMin.ForeColor = System.Drawing.Color.Teal;
            this.buttonClientesFactMin.Location = new System.Drawing.Point(2, 222);
            this.buttonClientesFactMin.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClientesFactMin.Name = "buttonClientesFactMin";
            this.buttonClientesFactMin.Size = new System.Drawing.Size(396, 216);
            this.buttonClientesFactMin.TabIndex = 4;
            this.buttonClientesFactMin.Text = "Listado peores clientes";
            this.buttonClientesFactMin.UseVisualStyleBackColor = true;
            this.buttonClientesFactMin.Click += new System.EventHandler(this.buttonClientesFactMin_Click);
            // 
            // buttonClientesFactMax
            // 
            this.buttonClientesFactMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonClientesFactMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClientesFactMax.ForeColor = System.Drawing.Color.Teal;
            this.buttonClientesFactMax.Location = new System.Drawing.Point(2, 2);
            this.buttonClientesFactMax.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClientesFactMax.Name = "buttonClientesFactMax";
            this.buttonClientesFactMax.Size = new System.Drawing.Size(396, 216);
            this.buttonClientesFactMax.TabIndex = 0;
            this.buttonClientesFactMax.Text = "Listado mejores clientes";
            this.buttonClientesFactMax.UseVisualStyleBackColor = true;
            this.buttonClientesFactMax.Click += new System.EventHandler(this.buttonClientesFactMax_Click);
            // 
            // buttonMasFacturacionProductoVendedor
            // 
            this.buttonMasFacturacionProductoVendedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonMasFacturacionProductoVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMasFacturacionProductoVendedor.ForeColor = System.Drawing.Color.Teal;
            this.buttonMasFacturacionProductoVendedor.Location = new System.Drawing.Point(402, 2);
            this.buttonMasFacturacionProductoVendedor.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMasFacturacionProductoVendedor.Name = "buttonMasFacturacionProductoVendedor";
            this.buttonMasFacturacionProductoVendedor.Size = new System.Drawing.Size(396, 216);
            this.buttonMasFacturacionProductoVendedor.TabIndex = 3;
            this.buttonMasFacturacionProductoVendedor.Text = "Productos con más facturación por vendedor";
            this.buttonMasFacturacionProductoVendedor.UseVisualStyleBackColor = true;
            this.buttonMasFacturacionProductoVendedor.Click += new System.EventHandler(this.buttonMasFacturacionProductoVendedor_Click);
            // 
            // BotonesFacturacionUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpFacturacion);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BotonesFacturacionUC";
            this.Size = new System.Drawing.Size(800, 440);
            this.tlpFacturacion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpFacturacion;
        private System.Windows.Forms.Button buttonClientesFactMax;
        private System.Windows.Forms.Button buttonClientesFactMin;
        private System.Windows.Forms.Button buttonMasFacturacionProductoVendedor;
        private System.Windows.Forms.Button buttonMenosFacturaciónProductoVendedor;
    }
}
