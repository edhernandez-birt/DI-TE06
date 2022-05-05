
namespace DIUD05TE01.Formulario.PopUp
{
    partial class FormPopUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxVersion = new System.Windows.Forms.TextBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.buttonVersion = new System.Windows.Forms.Button();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.labelVersion = new System.Windows.Forms.Label();
            this.helpProviderVersion = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // textBoxVersion
            // 
            this.textBoxVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProviderVersion.SetHelpString(this.textBoxVersion, "Datos del creador del Dashboard");
            this.textBoxVersion.Location = new System.Drawing.Point(91, 103);
            this.textBoxVersion.Multiline = true;
            this.textBoxVersion.Name = "textBoxVersion";
            this.textBoxVersion.ReadOnly = true;
            this.helpProviderVersion.SetShowHelp(this.textBoxVersion, true);
            this.textBoxVersion.Size = new System.Drawing.Size(302, 66);
            this.textBoxVersion.TabIndex = 0;
            this.textBoxVersion.Text = "Creado por Eduardo Hernandez\r\nAlumno de Birt LH\r\nDAM Curso 2021-2022";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.Teal;
            this.labelTitulo.Location = new System.Drawing.Point(85, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(308, 32);
            this.labelTitulo.TabIndex = 1;
            this.labelTitulo.Text = "Dashboard Northwind";
            // 
            // buttonVersion
            // 
            this.buttonVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProviderVersion.SetHelpString(this.buttonVersion, "Muestra/Oculta versión del dashboard");
            this.buttonVersion.Location = new System.Drawing.Point(263, 190);
            this.buttonVersion.Name = "buttonVersion";
            this.helpProviderVersion.SetShowHelp(this.buttonVersion, true);
            this.buttonVersion.Size = new System.Drawing.Size(90, 28);
            this.buttonVersion.TabIndex = 2;
            this.buttonVersion.Text = "Versión";
            this.buttonVersion.UseVisualStyleBackColor = true;
            this.buttonVersion.Click += new System.EventHandler(this.buttonVersion_Click);
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProviderVersion.SetHelpString(this.buttonCerrar, "Cierra el PopUp");
            this.buttonCerrar.Location = new System.Drawing.Point(369, 190);
            this.buttonCerrar.Name = "buttonCerrar";
            this.helpProviderVersion.SetShowHelp(this.buttonCerrar, true);
            this.buttonCerrar.Size = new System.Drawing.Size(89, 28);
            this.buttonCerrar.TabIndex = 3;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVersion.ForeColor = System.Drawing.Color.Teal;
            this.labelVersion.Location = new System.Drawing.Point(85, 52);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(170, 32);
            this.labelVersion.TabIndex = 4;
            this.labelVersion.Text = "Versión 1.3";
            this.labelVersion.Visible = false;
            // 
            // FormPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 235);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.buttonVersion);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.textBoxVersion);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPopUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Version";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxVersion;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button buttonVersion;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.HelpProvider helpProviderVersion;
    }
}