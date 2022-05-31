namespace FormCartas
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
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.btnJugar = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cartaRival = new ExamenCartas.Carta();
            this.carta3 = new ExamenCartas.Carta();
            this.carta2 = new ExamenCartas.Carta();
            this.carta1 = new ExamenCartas.Carta();
            this.SuspendLayout();
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Checked = true;
            this.rb1.Location = new System.Drawing.Point(12, 168);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(17, 16);
            this.rb1.TabIndex = 3;
            this.rb1.TabStop = true;
            this.rb1.UseVisualStyleBackColor = true;
            this.rb1.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(168, 168);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(17, 16);
            this.rb2.TabIndex = 4;
            this.rb2.UseVisualStyleBackColor = true;
            this.rb2.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Location = new System.Drawing.Point(324, 168);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(17, 16);
            this.rb3.TabIndex = 5;
            this.rb3.UseVisualStyleBackColor = true;
            this.rb3.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // btnJugar
            // 
            this.btnJugar.ForeColor = System.Drawing.Color.Blue;
            this.btnJugar.Location = new System.Drawing.Point(505, 61);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(94, 38);
            this.btnJugar.TabIndex = 7;
            this.btnJugar.Text = "JUGAR";
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(522, 167);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 17);
            this.lblResult.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(12, 223);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 200);
            this.panel1.TabIndex = 9;
            // 
            // cartaRival
            // 
            this.cartaRival.Imagen = null;
            this.cartaRival.Location = new System.Drawing.Point(627, 12);
            this.cartaRival.Name = "cartaRival";
            this.cartaRival.Nivel = 1;
            this.cartaRival.Size = new System.Drawing.Size(150, 150);
            this.cartaRival.TabIndex = 6;
            this.cartaRival.Valor = 0;
            this.cartaRival.AlcanzaMax += new System.EventHandler(this.carta1_AlcanzaMax);
            // 
            // carta3
            // 
            this.carta3.Imagen = ((System.Drawing.Image)(resources.GetObject("carta3.Imagen")));
            this.carta3.Location = new System.Drawing.Point(324, 12);
            this.carta3.Name = "carta3";
            this.carta3.Nivel = 1;
            this.carta3.Size = new System.Drawing.Size(150, 150);
            this.carta3.TabIndex = 2;
            this.carta3.Valor = 0;
            this.carta3.AlcanzaMax += new System.EventHandler(this.carta1_AlcanzaMax);
            // 
            // carta2
            // 
            this.carta2.Imagen = ((System.Drawing.Image)(resources.GetObject("carta2.Imagen")));
            this.carta2.Location = new System.Drawing.Point(168, 12);
            this.carta2.Name = "carta2";
            this.carta2.Nivel = 1;
            this.carta2.Size = new System.Drawing.Size(150, 150);
            this.carta2.TabIndex = 1;
            this.carta2.Valor = 0;
            this.carta2.AlcanzaMax += new System.EventHandler(this.carta1_AlcanzaMax);
            // 
            // carta1
            // 
            this.carta1.Imagen = ((System.Drawing.Image)(resources.GetObject("carta1.Imagen")));
            this.carta1.Location = new System.Drawing.Point(12, 12);
            this.carta1.Name = "carta1";
            this.carta1.Nivel = 1;
            this.carta1.Size = new System.Drawing.Size(150, 150);
            this.carta1.TabIndex = 0;
            this.carta1.Valor = 0;
            this.carta1.AlcanzaMax += new System.EventHandler(this.carta1_AlcanzaMax);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 435);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.cartaRival);
            this.Controls.Add(this.rb3);
            this.Controls.Add(this.rb2);
            this.Controls.Add(this.rb1);
            this.Controls.Add(this.carta3);
            this.Controls.Add(this.carta2);
            this.Controls.Add(this.carta1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Piedra, Papel, Tijera cards";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ExamenCartas.Carta carta1;
        private ExamenCartas.Carta carta2;
        private ExamenCartas.Carta carta3;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb3;
        private ExamenCartas.Carta cartaRival;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Panel panel1;
    }
}

