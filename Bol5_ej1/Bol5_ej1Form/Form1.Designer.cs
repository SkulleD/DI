
namespace Bol5_ej1Form
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
            this.labelTextbox1 = new Bol5_ej1.LabelTextbox();
            this.SuspendLayout();
            // 
            // labelTextbox1
            // 
            this.labelTextbox1.Location = new System.Drawing.Point(31, 29);
            this.labelTextbox1.Name = "labelTextbox1";
            this.labelTextbox1.Posicion = Bol5_ej1.ePosicion.IZQUIERDA;
            this.labelTextbox1.Separacion = 15;
            this.labelTextbox1.Size = new System.Drawing.Size(156, 20);
            this.labelTextbox1.TabIndex = 0;
            this.labelTextbox1.Text_Label = "label1";
            this.labelTextbox1.Text_TextBox = "";
            this.labelTextbox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.labelTextbox1_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTextbox1);
            this.Name = "Form1";
            this.Text = "Bol5_ej1";
            this.ResumeLayout(false);

        }

        #endregion

        private Bol5_ej1.LabelTextbox labelTextbox1;
    }
}

