
namespace FormBol7
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
            this.labelTextBox1 = new BoletinJunio7.LabelTextBox();
            this.SuspendLayout();
            // 
            // labelTextBox1
            // 
            this.labelTextBox1.Location = new System.Drawing.Point(12, 12);
            this.labelTextBox1.Name = "labelTextBox1";
            this.labelTextBox1.Posicion = BoletinJunio7.ePosicion.DERECHA;
            this.labelTextBox1.Separacion = 30;
            this.labelTextBox1.Size = new System.Drawing.Size(166, 20);
            this.labelTextBox1.TabIndex = 0;
            this.labelTextBox1.TextLabel = "Etiqueta";
            this.labelTextBox1.TextTextBox = "AAAAA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 267);
            this.Controls.Add(this.labelTextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Boletín Junio 7";
            this.ResumeLayout(false);

        }

        #endregion

        private BoletinJunio7.LabelTextBox labelTextBox1;
    }
}

