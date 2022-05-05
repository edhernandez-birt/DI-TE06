
namespace DIUD05TE01.ControlesUsuario
{
    partial class BarrasMenosVendidosUC
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
            this.chartMenosVendidos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartMenosVendidos)).BeginInit();
            this.SuspendLayout();
            // 
            // chartMenosVendidos
            // 
            chartArea1.Name = "ChartArea1";
            this.chartMenosVendidos.ChartAreas.Add(chartArea1);
            this.chartMenosVendidos.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Enabled = false;
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chartMenosVendidos.Legends.Add(legend1);
            this.chartMenosVendidos.Location = new System.Drawing.Point(0, 0);
            this.chartMenosVendidos.Margin = new System.Windows.Forms.Padding(4);
            this.chartMenosVendidos.Name = "chartMenosVendidos";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.LegendText = "Dólares USA $";
            series1.Name = "Series1";
            this.chartMenosVendidos.Series.Add(series1);
            this.chartMenosVendidos.Size = new System.Drawing.Size(1067, 542);
            this.chartMenosVendidos.TabIndex = 0;
            this.chartMenosVendidos.Text = "chart1";
            title1.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Productos con menos facturación por vendedor";
            this.chartMenosVendidos.Titles.Add(title1);
            // 
            // BarrasMenosVendidosUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chartMenosVendidos);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BarrasMenosVendidosUC";
            this.Size = new System.Drawing.Size(1067, 542);
            ((System.ComponentModel.ISupportInitialize)(this.chartMenosVendidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartMenosVendidos;
    }
}
