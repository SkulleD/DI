namespace FormBol10
{
    partial class Entrada
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entrada));
            this.validateTextBox1 = new BoletinJunio10.ValidateTextBox();
            this.validateTextBox2 = new BoletinJunio10.ValidateTextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblAficion = new System.Windows.Forms.Label();
            this.rb1Hombre = new System.Windows.Forms.RadioButton();
            this.rb1Mujer = new System.Windows.Forms.RadioButton();
            this.rb2Mujer = new System.Windows.Forms.RadioButton();
            this.rb2Hombre = new System.Windows.Forms.RadioButton();
            this.lblGeneroSoy = new System.Windows.Forms.Label();
            this.lblGeneroBusco = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // validateTextBox1
            // 
            this.validateTextBox1.Location = new System.Drawing.Point(12, 48);
            this.validateTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.validateTextBox1.Name = "validateTextBox1";
            this.validateTextBox1.Size = new System.Drawing.Size(160, 42);
            this.validateTextBox1.TabIndex = 0;
            this.validateTextBox1.Texto = "";
            this.validateTextBox1.Tipo = BoletinJunio10.eTipo.Textual;
            // 
            // validateTextBox2
            // 
            this.validateTextBox2.Location = new System.Drawing.Point(12, 136);
            this.validateTextBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.validateTextBox2.Name = "validateTextBox2";
            this.validateTextBox2.Size = new System.Drawing.Size(160, 42);
            this.validateTextBox2.TabIndex = 1;
            this.validateTextBox2.Texto = "";
            this.validateTextBox2.Tipo = BoletinJunio10.eTipo.Numérico;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(21, 29);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 17);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(21, 117);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(41, 17);
            this.lblEdad.TabIndex = 3;
            this.lblEdad.Text = "Edad";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(221, 252);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // lblAficion
            // 
            this.lblAficion.AutoSize = true;
            this.lblAficion.Location = new System.Drawing.Point(218, 221);
            this.lblAficion.Name = "lblAficion";
            this.lblAficion.Size = new System.Drawing.Size(108, 17);
            this.lblAficion.TabIndex = 5;
            this.lblAficion.Text = "Afición Principal";
            // 
            // rb1Hombre
            // 
            this.rb1Hombre.AutoSize = true;
            this.rb1Hombre.Location = new System.Drawing.Point(23, 219);
            this.rb1Hombre.Name = "rb1Hombre";
            this.rb1Hombre.Size = new System.Drawing.Size(79, 21);
            this.rb1Hombre.TabIndex = 6;
            this.rb1Hombre.TabStop = true;
            this.rb1Hombre.Text = "Hombre";
            this.rb1Hombre.UseVisualStyleBackColor = true;
            // 
            // rb1Mujer
            // 
            this.rb1Mujer.AutoSize = true;
            this.rb1Mujer.Location = new System.Drawing.Point(108, 219);
            this.rb1Mujer.Name = "rb1Mujer";
            this.rb1Mujer.Size = new System.Drawing.Size(64, 21);
            this.rb1Mujer.TabIndex = 7;
            this.rb1Mujer.TabStop = true;
            this.rb1Mujer.Text = "Mujer";
            this.rb1Mujer.UseVisualStyleBackColor = true;
            // 
            // rb2Mujer
            // 
            this.rb2Mujer.AutoSize = true;
            this.rb2Mujer.Location = new System.Drawing.Point(109, 282);
            this.rb2Mujer.Name = "rb2Mujer";
            this.rb2Mujer.Size = new System.Drawing.Size(64, 21);
            this.rb2Mujer.TabIndex = 9;
            this.rb2Mujer.TabStop = true;
            this.rb2Mujer.Text = "Mujer";
            this.rb2Mujer.UseVisualStyleBackColor = true;
            // 
            // rb2Hombre
            // 
            this.rb2Hombre.AutoSize = true;
            this.rb2Hombre.Location = new System.Drawing.Point(24, 282);
            this.rb2Hombre.Name = "rb2Hombre";
            this.rb2Hombre.Size = new System.Drawing.Size(79, 21);
            this.rb2Hombre.TabIndex = 8;
            this.rb2Hombre.TabStop = true;
            this.rb2Hombre.Text = "Hombre";
            this.rb2Hombre.UseVisualStyleBackColor = true;
            // 
            // lblGeneroSoy
            // 
            this.lblGeneroSoy.AutoSize = true;
            this.lblGeneroSoy.Location = new System.Drawing.Point(21, 199);
            this.lblGeneroSoy.Name = "lblGeneroSoy";
            this.lblGeneroSoy.Size = new System.Drawing.Size(44, 17);
            this.lblGeneroSoy.TabIndex = 10;
            this.lblGeneroSoy.Text = "Soy...";
            // 
            // lblGeneroBusco
            // 
            this.lblGeneroBusco.AutoSize = true;
            this.lblGeneroBusco.Location = new System.Drawing.Point(23, 259);
            this.lblGeneroBusco.Name = "lblGeneroBusco";
            this.lblGeneroBusco.Size = new System.Drawing.Size(59, 17);
            this.lblGeneroBusco.TabIndex = 11;
            this.lblGeneroBusco.Text = "Busco...";
            // 
            // Entrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 328);
            this.Controls.Add(this.lblGeneroBusco);
            this.Controls.Add(this.lblGeneroSoy);
            this.Controls.Add(this.rb2Mujer);
            this.Controls.Add(this.rb2Hombre);
            this.Controls.Add(this.rb1Mujer);
            this.Controls.Add(this.rb1Hombre);
            this.Controls.Add(this.lblAficion);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.validateTextBox2);
            this.Controls.Add(this.validateTextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Entrada";
            this.Text = "Entrada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BoletinJunio10.ValidateTextBox validateTextBox1;
        private BoletinJunio10.ValidateTextBox validateTextBox2;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblAficion;
        private System.Windows.Forms.RadioButton rb1Hombre;
        private System.Windows.Forms.RadioButton rb1Mujer;
        private System.Windows.Forms.RadioButton rb2Mujer;
        private System.Windows.Forms.RadioButton rb2Hombre;
        private System.Windows.Forms.Label lblGeneroSoy;
        private System.Windows.Forms.Label lblGeneroBusco;
    }
}