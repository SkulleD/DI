namespace Form1ej5
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
            this.validateTextBox2 = new RepasoRecu2evaEj5.ValidateTextBox();
            this.SuspendLayout();
            // 
            // validateTextBox2
            // 
            this.validateTextBox2.Location = new System.Drawing.Point(208, 70);
            this.validateTextBox2.Multiline = false;
            this.validateTextBox2.Name = "validateTextBox2";
            this.validateTextBox2.Size = new System.Drawing.Size(240, 42);
            this.validateTextBox2.TabIndex = 0;
            this.validateTextBox2.Texto = "";
            this.validateTextBox2.Tipo = RepasoRecu2evaEj5.eTipo.Numerico;
            this.validateTextBox2.TextoChanged += new System.EventHandler(this.validateTextBox1_TextoChanged);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(705, 404);
            this.Controls.Add(this.validateTextBox2);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private RepasoRecu2evaEj5.ValidateTextBox validateTextBox1;
        private RepasoRecu2evaEj5.ValidateTextBox validateTextBox2;
    }
}

