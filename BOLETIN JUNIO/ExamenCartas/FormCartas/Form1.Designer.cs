namespace FormCartas
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
            this.carta1 = new ExamenCartas.Carta();
            this.SuspendLayout();
            // 
            // carta1
            // 
            this.carta1.Imagen = null;
            this.carta1.Location = new System.Drawing.Point(260, 79);
            this.carta1.Name = "carta1";
            this.carta1.Nivel = 0;
            this.carta1.Size = new System.Drawing.Size(150, 150);
            this.carta1.TabIndex = 0;
            this.carta1.Valor = 44;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 435);
            this.Controls.Add(this.carta1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Piedra, Papel, Tijera cards";
            this.ResumeLayout(false);

        }

        #endregion

        private ExamenCartas.Carta carta1;
    }
}

