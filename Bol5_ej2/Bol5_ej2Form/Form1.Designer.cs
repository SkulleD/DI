
namespace Bol5_ej2Form
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
            this.etiquetaAviso1 = new Bol5_ej2.EtiquetaAviso();
            this.SuspendLayout();
            // 
            // etiquetaAviso1
            // 
            this.etiquetaAviso1.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.etiquetaAviso1.Color2 = System.Drawing.Color.Aqua;
            this.etiquetaAviso1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaAviso1.Gradiente = true;
            this.etiquetaAviso1.Imagen = global::Bol5_ej2Form.Properties.Resources.burgallina;
            this.etiquetaAviso1.Location = new System.Drawing.Point(44, 41);
            this.etiquetaAviso1.Marca = Bol5_ej2.eMarca.Imagen;
            this.etiquetaAviso1.Name = "etiquetaAviso1";
            this.etiquetaAviso1.Size = new System.Drawing.Size(433, 80);
            this.etiquetaAviso1.TabIndex = 0;
            this.etiquetaAviso1.Text = "Soy una etiqueta bonita";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 372);
            this.Controls.Add(this.etiquetaAviso1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Bol5_ej2";
            this.ResumeLayout(false);

        }

        #endregion

        private Bol5_ej2.EtiquetaAviso etiquetaAviso1;
    }
}

