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
            this.txtLetra = new System.Windows.Forms.TextBox();
            this.lblPalabra = new System.Windows.Forms.Label();
            this.dibujoAhorcado2 = new BoletinJunio9.DibujoAhorcado();
            this.SuspendLayout();
            // 
            // txtLetra
            // 
            this.txtLetra.Location = new System.Drawing.Point(12, 46);
            this.txtLetra.Name = "txtLetra";
            this.txtLetra.Size = new System.Drawing.Size(100, 20);
            this.txtLetra.TabIndex = 1;
            // 
            // lblPalabra
            // 
            this.lblPalabra.AutoSize = true;
            this.lblPalabra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalabra.Location = new System.Drawing.Point(12, 94);
            this.lblPalabra.Name = "lblPalabra";
            this.lblPalabra.Size = new System.Drawing.Size(63, 13);
            this.lblPalabra.TabIndex = 2;
            this.lblPalabra.Text = "PALABRA";
            // 
            // dibujoAhorcado2
            // 
            this.dibujoAhorcado2.Errores = 0;
            this.dibujoAhorcado2.Location = new System.Drawing.Point(127, 12);
            this.dibujoAhorcado2.Name = "dibujoAhorcado2";
            this.dibujoAhorcado2.Size = new System.Drawing.Size(104, 160);
            this.dibujoAhorcado2.TabIndex = 3;
            this.dibujoAhorcado2.Text = "dibujoAhorcado2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 362);
            this.Controls.Add(this.dibujoAhorcado2);
            this.Controls.Add(this.lblPalabra);
            this.Controls.Add(this.txtLetra);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "AHORCADO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtLetra;
        private System.Windows.Forms.Label lblPalabra;
        private BoletinJunio9.DibujoAhorcado dibujoAhorcado2;
    }
}

