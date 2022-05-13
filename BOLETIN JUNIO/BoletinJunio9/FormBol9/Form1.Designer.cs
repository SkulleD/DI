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
            this.lblResult = new System.Windows.Forms.Label();
            this.lblFallos = new System.Windows.Forms.Label();
            this.dibujoAhorcado1 = new BoletinJunio9.DibujoAhorcado();
            this.lblPalabraAdivinar = new System.Windows.Forms.Label();
            this.txtAdivinar = new System.Windows.Forms.TextBox();
            this.btnJugar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLetra
            // 
            this.txtLetra.Location = new System.Drawing.Point(15, 97);
            this.txtLetra.Name = "txtLetra";
            this.txtLetra.Size = new System.Drawing.Size(38, 20);
            this.txtLetra.TabIndex = 4;
            // 
            // lblPalabra
            // 
            this.lblPalabra.AutoSize = true;
            this.lblPalabra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalabra.Location = new System.Drawing.Point(12, 65);
            this.lblPalabra.Name = "lblPalabra";
            this.lblPalabra.Size = new System.Drawing.Size(0, 13);
            this.lblPalabra.TabIndex = 3;
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciar.ForeColor = System.Drawing.Color.Teal;
            this.btnReiniciar.Location = new System.Drawing.Point(14, 171);
            this.btnReiniciar.Margin = new System.Windows.Forms.Padding(2);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(98, 42);
            this.btnReiniciar.TabIndex = 7;
            this.btnReiniciar.Text = "REINICIAR";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // lbl_Info
            // 
            this.lbl_Info.AutoSize = true;
            this.lbl_Info.Location = new System.Drawing.Point(58, 101);
            this.lbl_Info.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Info.Name = "lbl_Info";
            this.lbl_Info.Size = new System.Drawing.Size(102, 13);
            this.lbl_Info.TabIndex = 5;
            this.lbl_Info.Text = "<-- Inserta letra aquí";
            // 
            // btnUsarLetra
            // 
            this.btnUsarLetra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUsarLetra.Location = new System.Drawing.Point(14, 121);
            this.btnUsarLetra.Margin = new System.Windows.Forms.Padding(2);
            this.btnUsarLetra.Name = "btnUsarLetra";
            this.btnUsarLetra.Size = new System.Drawing.Size(67, 28);
            this.btnUsarLetra.TabIndex = 6;
            this.btnUsarLetra.Text = "Usar letra";
            this.btnUsarLetra.UseVisualStyleBackColor = true;
            this.btnUsarLetra.Click += new System.EventHandler(this.btnUsarLetra_Click);
            // 
            // lblUsadas
            // 
            this.lblUsadas.AutoSize = true;
            this.lblUsadas.Location = new System.Drawing.Point(12, 245);
            this.lblUsadas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsadas.Name = "lblUsadas";
            this.lblUsadas.Size = new System.Drawing.Size(123, 13);
            this.lblUsadas.TabIndex = 9;
            this.lblUsadas.Text = "Letras erróneas usadas: ";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(219, 215);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 11;
            // 
            // lblFallos
            // 
            this.lblFallos.AutoSize = true;
            this.lblFallos.Location = new System.Drawing.Point(12, 232);
            this.lblFallos.Name = "lblFallos";
            this.lblFallos.Size = new System.Drawing.Size(40, 13);
            this.lblFallos.TabIndex = 8;
            this.lblFallos.Text = "Fallos: ";
            // 
            // dibujoAhorcado1
            // 
            this.dibujoAhorcado1.Errores = 0;
            this.dibujoAhorcado1.Location = new System.Drawing.Point(192, 11);
            this.dibujoAhorcado1.Margin = new System.Windows.Forms.Padding(2);
            this.dibujoAhorcado1.Name = "dibujoAhorcado1";
            this.dibujoAhorcado1.Size = new System.Drawing.Size(122, 202);
            this.dibujoAhorcado1.TabIndex = 10;
            this.dibujoAhorcado1.Text = "dibujoAhorcado1";
            this.dibujoAhorcado1.CambiaError += new System.EventHandler(this.dibujoAhorcado1_CambiaError);
            this.dibujoAhorcado1.Ahorcado += new System.EventHandler(this.dibujoAhorcado1_Ahorcado);
            // 
            // lblPalabraAdivinar
            // 
            this.lblPalabraAdivinar.AutoSize = true;
            this.lblPalabraAdivinar.Location = new System.Drawing.Point(9, 11);
            this.lblPalabraAdivinar.Name = "lblPalabraAdivinar";
            this.lblPalabraAdivinar.Size = new System.Drawing.Size(92, 13);
            this.lblPalabraAdivinar.TabIndex = 0;
            this.lblPalabraAdivinar.Text = "Palabra a adivinar";
            // 
            // txtAdivinar
            // 
            this.txtAdivinar.Location = new System.Drawing.Point(12, 27);
            this.txtAdivinar.Name = "txtAdivinar";
            this.txtAdivinar.Size = new System.Drawing.Size(100, 20);
            this.txtAdivinar.TabIndex = 1;
            this.txtAdivinar.Text = "PROGRAM";
            // 
            // btnJugar
            // 
            this.btnJugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJugar.ForeColor = System.Drawing.Color.Green;
            this.btnJugar.Location = new System.Drawing.Point(118, 24);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(69, 23);
            this.btnJugar.TabIndex = 2;
            this.btnJugar.Text = "JUGAR";
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnUsarLetra;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 288);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.txtAdivinar);
            this.Controls.Add(this.lblPalabraAdivinar);
            this.Controls.Add(this.lblFallos);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblUsadas);
            this.Controls.Add(this.btnUsarLetra);
            this.Controls.Add(this.dibujoAhorcado1);
            this.Controls.Add(this.lbl_Info);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.lblPalabra);
            this.Controls.Add(this.txtLetra);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AHORCADO";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
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
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblFallos;
        private System.Windows.Forms.Label lblPalabraAdivinar;
        private System.Windows.Forms.TextBox txtAdivinar;
        private System.Windows.Forms.Button btnJugar;
    }
}

