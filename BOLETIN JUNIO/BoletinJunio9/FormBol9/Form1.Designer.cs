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
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.lbl_Info = new System.Windows.Forms.Label();
            this.btnUsarLetra = new System.Windows.Forms.Button();
            this.lblUsadas = new System.Windows.Forms.Label();
            this.dibujoAhorcado1 = new BoletinJunio9.DibujoAhorcado();
            this.SuspendLayout();
            // 
            // txtLetra
            // 
            this.txtLetra.Location = new System.Drawing.Point(10, 52);
            this.txtLetra.Name = "txtLetra";
            this.txtLetra.Size = new System.Drawing.Size(38, 20);
            this.txtLetra.TabIndex = 1;
            // 
            // lblPalabra
            // 
            this.lblPalabra.AutoSize = true;
            this.lblPalabra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalabra.Location = new System.Drawing.Point(7, 20);
            this.lblPalabra.Name = "lblPalabra";
            this.lblPalabra.Size = new System.Drawing.Size(0, 13);
            this.lblPalabra.TabIndex = 2;
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciar.ForeColor = System.Drawing.Color.Teal;
            this.btnReiniciar.Location = new System.Drawing.Point(9, 126);
            this.btnReiniciar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(98, 42);
            this.btnReiniciar.TabIndex = 4;
            this.btnReiniciar.Text = "REINICIAR";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // lbl_Info
            // 
            this.lbl_Info.AutoSize = true;
            this.lbl_Info.Location = new System.Drawing.Point(53, 56);
            this.lbl_Info.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Info.Name = "lbl_Info";
            this.lbl_Info.Size = new System.Drawing.Size(102, 13);
            this.lbl_Info.TabIndex = 5;
            this.lbl_Info.Text = "<-- Inserta letra aquí";
            // 
            // btnUsarLetra
            // 
            this.btnUsarLetra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUsarLetra.Location = new System.Drawing.Point(9, 76);
            this.btnUsarLetra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUsarLetra.Name = "btnUsarLetra";
            this.btnUsarLetra.Size = new System.Drawing.Size(67, 28);
            this.btnUsarLetra.TabIndex = 7;
            this.btnUsarLetra.Text = "Usar letra";
            this.btnUsarLetra.UseVisualStyleBackColor = true;
            this.btnUsarLetra.Click += new System.EventHandler(this.btnUsarLetra_Click);
            // 
            // lblUsadas
            // 
            this.lblUsadas.AutoSize = true;
            this.lblUsadas.Location = new System.Drawing.Point(7, 200);
            this.lblUsadas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsadas.Name = "lblUsadas";
            this.lblUsadas.Size = new System.Drawing.Size(79, 13);
            this.lblUsadas.TabIndex = 8;
            this.lblUsadas.Text = "Letras usadas: ";
            // 
            // dibujoAhorcado1
            // 
            this.dibujoAhorcado1.Errores = 0;
            this.dibujoAhorcado1.Location = new System.Drawing.Point(176, 20);
            this.dibujoAhorcado1.Margin = new System.Windows.Forms.Padding(2);
            this.dibujoAhorcado1.Name = "dibujoAhorcado1";
            this.dibujoAhorcado1.Size = new System.Drawing.Size(104, 149);
            this.dibujoAhorcado1.TabIndex = 6;
            this.dibujoAhorcado1.Text = "dibujoAhorcado1";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnUsarLetra;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 236);
            this.Controls.Add(this.lblUsadas);
            this.Controls.Add(this.btnUsarLetra);
            this.Controls.Add(this.dibujoAhorcado1);
            this.Controls.Add(this.lbl_Info);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.lblPalabra);
            this.Controls.Add(this.txtLetra);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "AHORCADO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtLetra;
        private System.Windows.Forms.Label lblPalabra;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Label lbl_Info;
        private BoletinJunio9.DibujoAhorcado dibujoAhorcado1;
        private System.Windows.Forms.Button btnUsarLetra;
        private System.Windows.Forms.Label lblUsadas;
    }
}

