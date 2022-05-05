
namespace DIUD05TE01.ControlesUsuario
{
    partial class BarrasMasVendidosUC
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
            this.chartBarrasMasVendidos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartBarrasMasVendidos)).BeginInit();
            this.SuspendLayout();
            // 
            // chartBarrasMasVendidos
            // 
            chartArea1.Name = "ChartArea1";
            this.chartBarrasMasVendidos.ChartAreas.Add(chartArea1);
            this.chartBarrasMasVendidos.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Enabled = false;
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chartBarrasMasVendidos.Legends.Add(legend1);
            this.chartBarrasMasVendidos.Location = new System.Drawing.Point(0, 0);
            this.chartBarrasMasVendidos.Name = "chartBarrasMasVendidos";
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.LegendText = "Dólares USA $";
            series1.Name = "Series1";
            this.chartBarrasMasVendidos.Series.Add(series1);
            this.chartBarrasMasVendidos.Size = new System.Drawing.Size(800, 440);
            this.chartBarrasMasVendidos.TabIndex = 0;
            this.chartBarrasMasVendidos.Text = "chart1";
            title1.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Productos con más facturación por vendedor";
            this.chartBarrasMasVendidos.Titles.Add(title1);
            // 
            // BarrasMasVendidosUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chartBarrasMasVendidos);
            this.Name = "BarrasMasVendidosUC";
            this.Size = new System.Drawing.Size(800, 440);
            ((System.ComponentModel.ISupportInitialize)(this.chartBarrasMasVendidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartBarrasMasVendidos;
    }
}
