
namespace DIUD05TE01.ControlesUsuario
{
    partial class BarrasVendidosClienteUC
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartMasVendidosCliente = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartMasVendidosCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // chartMasVendidosCliente
            // 
            chartArea1.Name = "ChartArea1";
            this.chartMasVendidosCliente.ChartAreas.Add(chartArea1);
            this.chartMasVendidosCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chartMasVendidosCliente.Legends.Add(legend1);
            this.chartMasVendidosCliente.Location = new System.Drawing.Point(0, 0);
            this.chartMasVendidosCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chartMasVendidosCliente.Name = "chartMasVendidosCliente";
            this.chartMasVendidosCliente.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartMasVendidosCliente.Series.Add(series1);
            this.chartMasVendidosCliente.Size = new System.Drawing.Size(750, 536);
            this.chartMasVendidosCliente.TabIndex = 0;
            this.chartMasVendidosCliente.Text = "chart1";
            title1.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Titulo vendidos";
            this.chartMasVendidosCliente.Titles.Add(title1);
            // 
            // BarrasVendidosClienteUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chartMasVendidosCliente);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BarrasVendidosClienteUC";
            this.Size = new System.Drawing.Size(750, 536);
            ((System.ComponentModel.ISupportInitialize)(this.chartMasVendidosCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartMasVendidosCliente;
    }
}
