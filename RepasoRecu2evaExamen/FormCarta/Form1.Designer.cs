namespace FormCarta
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
            this.cartaPiedra = new RepasoRecu2evaExamen.Carta();
            this.cartaPapel = new RepasoRecu2evaExamen.Carta();
            this.cartaTijera = new RepasoRecu2evaExamen.Carta();
            this.cartaCPU = new RepasoRecu2evaExamen.Carta();
            this.rbPiedra = new System.Windows.Forms.RadioButton();
            this.rbPapel = new System.Windows.Forms.RadioButton();
            this.rbTijera = new System.Windows.Forms.RadioButton();
            this.btnJugar = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // cartaPiedra
            // 
            this.cartaPiedra.Imagen = ((System.Drawing.Image)(resources.GetObject("cartaPiedra.Imagen")));
            this.cartaPiedra.Location = new System.Drawing.Point(2, 2);
            this.cartaPiedra.Name = "cartaPiedra";
            this.cartaPiedra.Nivel = 1;
            this.cartaPiedra.Size = new System.Drawing.Size(111, 127);
            this.cartaPiedra.TabIndex = 0;
            this.cartaPiedra.Valor = 0;
            this.cartaPiedra.AlcanzaMax += new System.EventHandler(this.Carta_AlcanzaMax);
            // 
            // cartaPapel
            // 
            this.cartaPapel.Imagen = null;
            this.cartaPapel.Location = new System.Drawing.Point(119, 2);
            this.cartaPapel.Name = "cartaPapel";
            this.cartaPapel.Nivel = 1;
            this.cartaPapel.Size = new System.Drawing.Size(111, 127);
            this.cartaPapel.TabIndex = 1;
            this.cartaPapel.Valor = 0;
            this.cartaPapel.AlcanzaMax += new System.EventHandler(this.Carta_AlcanzaMax);
            // 
            // cartaTijera
            // 
            this.cartaTijera.Imagen = null;
            this.cartaTijera.Location = new System.Drawing.Point(236, 2);
            this.cartaTijera.Name = "cartaTijera";
            this.cartaTijera.Nivel = 1;
            this.cartaTijera.Size = new System.Drawing.Size(111, 127);
            this.cartaTijera.TabIndex = 2;
            this.cartaTijera.Valor = 0;
            this.cartaTijera.AlcanzaMax += new System.EventHandler(this.Carta_AlcanzaMax);
            // 
            // cartaCPU
            // 
            this.cartaCPU.Imagen = null;
            this.cartaCPU.Location = new System.Drawing.Point(530, 2);
            this.cartaCPU.Name = "cartaCPU";
            this.cartaCPU.Nivel = 1;
            this.cartaCPU.Size = new System.Drawing.Size(111, 127);
            this.cartaCPU.TabIndex = 3;
            this.cartaCPU.Valor = 0;
            // 
            // rbPiedra
            // 
            this.rbPiedra.AutoSize = true;
            this.rbPiedra.Checked = true;
            this.rbPiedra.Location = new System.Drawing.Point(47, 156);
            this.rbPiedra.Name = "rbPiedra";
            this.rbPiedra.Size = new System.Drawing.Size(17, 16);
            this.rbPiedra.TabIndex = 4;
            this.rbPiedra.TabStop = true;
            this.rbPiedra.UseVisualStyleBackColor = true;
            this.rbPiedra.CheckedChanged += new System.EventHandler(this.Rb_CheckedChanged);
            // 
            // rbPapel
            // 
            this.rbPapel.AutoSize = true;
            this.rbPapel.Location = new System.Drawing.Point(167, 156);
            this.rbPapel.Name = "rbPapel";
            this.rbPapel.Size = new System.Drawing.Size(17, 16);
            this.rbPapel.TabIndex = 5;
            this.rbPapel.UseVisualStyleBackColor = true;
            this.rbPapel.CheckedChanged += new System.EventHandler(this.Rb_CheckedChanged);
            // 
            // rbTijera
            // 
            this.rbTijera.AutoSize = true;
            this.rbTijera.Location = new System.Drawing.Point(279, 156);
            this.rbTijera.Name = "rbTijera";
            this.rbTijera.Size = new System.Drawing.Size(17, 16);
            this.rbTijera.TabIndex = 6;
            this.rbTijera.UseVisualStyleBackColor = true;
            this.rbTijera.CheckedChanged += new System.EventHandler(this.Rb_CheckedChanged);
            // 
            // btnJugar
            // 
            this.btnJugar.Location = new System.Drawing.Point(396, 45);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(87, 36);
            this.btnJugar.TabIndex = 7;
            this.btnJugar.Text = "JUGAR";
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(410, 135);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(72, 17);
            this.lblResult.TabIndex = 8;
            this.lblResult.Text = "Resultado";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(2, 297);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 200);
            this.panel1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.rbTijera);
            this.Controls.Add(this.rbPapel);
            this.Controls.Add(this.rbPiedra);
            this.Controls.Add(this.cartaCPU);
            this.Controls.Add(this.cartaTijera);
            this.Controls.Add(this.cartaPapel);
            this.Controls.Add(this.cartaPiedra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RepasoRecu2evaExamen.Carta cartaPiedra;
        private RepasoRecu2evaExamen.Carta cartaPapel;
        private RepasoRecu2evaExamen.Carta cartaTijera;
        private RepasoRecu2evaExamen.Carta cartaCPU;
        private System.Windows.Forms.RadioButton rbPiedra;
        private System.Windows.Forms.RadioButton rbPapel;
        private System.Windows.Forms.RadioButton rbTijera;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Panel panel1;
    }
}

