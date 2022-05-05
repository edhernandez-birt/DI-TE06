
namespace DIUD05TE01.ControlesUsuario.CUCrystalReports
{
    partial class AvisoInformeUC
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
            this.tlpAviso = new System.Windows.Forms.TableLayoutPanel();
            this.labelAviso = new System.Windows.Forms.Label();
            this.tlpAviso.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpAviso
            // 
            this.tlpAviso.ColumnCount = 1;
            this.tlpAviso.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAviso.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tlpAviso.Controls.Add(this.labelAviso, 0, 0);
            this.tlpAviso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAviso.Location = new System.Drawing.Point(0, 0);
            this.tlpAviso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tlpAviso.Name = "tlpAviso";
            this.tlpAviso.RowCount = 1;
            this.tlpAviso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAviso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpAviso.Size = new System.Drawing.Size(800, 440);
            this.tlpAviso.TabIndex = 0;
            // 
            // labelAviso
            // 
            this.labelAviso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAviso.Location = new System.Drawing.Point(2, 0);
            this.labelAviso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAviso.Name = "labelAviso";
            this.labelAviso.Size = new System.Drawing.Size(796, 440);
            this.labelAviso.TabIndex = 0;
            this.labelAviso.Text = "Selecciona informes con los botones inferiores";
            this.labelAviso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AvisoInformeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpAviso);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AvisoInformeUC";
            this.Size = new System.Drawing.Size(800, 440);
            this.tlpAviso.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpAviso;
        private System.Windows.Forms.Label labelAviso;
    }
}
