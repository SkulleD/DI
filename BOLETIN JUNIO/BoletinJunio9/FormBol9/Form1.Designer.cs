namespace FormBol9
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
            this.dibujoAhorcado1 = new BoletinJunio9.DibujoAhorcado();
            this.SuspendLayout();
            // 
            // dibujoAhorcado1
            // 
            this.dibujoAhorcado1.Errores = 0;
            this.dibujoAhorcado1.Location = new System.Drawing.Point(12, 12);
            this.dibujoAhorcado1.Name = "dibujoAhorcado1";
            this.dibujoAhorcado1.Size = new System.Drawing.Size(75, 23);
            this.dibujoAhorcado1.TabIndex = 0;
            this.dibujoAhorcado1.Text = "dibujoAhorcado1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 362);
            this.Controls.Add(this.dibujoAhorcado1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Boletín Junio 9";
            this.ResumeLayout(false);

        }

        #endregion

        private BoletinJunio9.DibujoAhorcado dibujoAhorcado1;
    }
}

