
namespace FormBol8
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.etiquetaAviso2 = new BoletinJunio8.EtiquetaAviso();
            this.SuspendLayout();
            // 
            // etiquetaAviso2
            // 
            this.etiquetaAviso2.Color1 = System.Drawing.Color.Yellow;
            this.etiquetaAviso2.Color2 = System.Drawing.Color.Fuchsia;
            this.etiquetaAviso2.Gradiente = true;
            this.etiquetaAviso2.Imagen = global::FormBol8.Properties.Resources.perrito;
            this.etiquetaAviso2.Location = new System.Drawing.Point(12, 12);
            this.etiquetaAviso2.Marca = BoletinJunio8.eMarca.Circulo;
            this.etiquetaAviso2.Name = "etiquetaAviso2";
            this.etiquetaAviso2.Size = new System.Drawing.Size(141, 63);
            this.etiquetaAviso2.TabIndex = 1;
            this.etiquetaAviso2.Text = "etiquetaAviso2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 368);
            this.Controls.Add(this.etiquetaAviso2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boletín Junio 8";
            this.ResumeLayout(false);

        }

        #endregion

        private BoletinJunio8.EtiquetaAviso etiquetaAviso2;
    }
}

