namespace FormBol10
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
            this.validateTextBox2 = new BoletinJunio10.ValidateTextBox();
            this.SuspendLayout();
            // 
            // validateTextBox2
            // 
            this.validateTextBox2.AutoSize = true;
            this.validateTextBox2.Location = new System.Drawing.Point(62, 91);
            this.validateTextBox2.Margin = new System.Windows.Forms.Padding(2);
            this.validateTextBox2.Name = "validateTextBox2";
            this.validateTextBox2.Size = new System.Drawing.Size(102, 36);
            this.validateTextBox2.TabIndex = 1;
            this.validateTextBox2.Texto = "5465";
            this.validateTextBox2.Tipo = BoletinJunio10.eTipo.Numérico;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 356);
            this.Controls.Add(this.validateTextBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Frikilove";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BoletinJunio10.ValidateTextBox validateTextBox2;
    }
}

