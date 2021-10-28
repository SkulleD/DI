
namespace Bol4_ej1
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
            this.btnIzquierdo = new System.Windows.Forms.Button();
            this.btnDerecho = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIzquierdo
            // 
            this.btnIzquierdo.Location = new System.Drawing.Point(117, 58);
            this.btnIzquierdo.Name = "btnIzquierdo";
            this.btnIzquierdo.Size = new System.Drawing.Size(75, 23);
            this.btnIzquierdo.TabIndex = 0;
            this.btnIzquierdo.Text = "Izquierdo";
            this.btnIzquierdo.UseVisualStyleBackColor = true;
            // 
            // btnDerecho
            // 
            this.btnDerecho.Location = new System.Drawing.Point(256, 58);
            this.btnDerecho.Name = "btnDerecho";
            this.btnDerecho.Size = new System.Drawing.Size(75, 23);
            this.btnDerecho.TabIndex = 1;
            this.btnDerecho.Text = "Derecho";
            this.btnDerecho.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 301);
            this.Controls.Add(this.btnDerecho);
            this.Controls.Add(this.btnIzquierdo);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Mouse Tester";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Components_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIzquierdo;
        private System.Windows.Forms.Button btnDerecho;
    }
}

