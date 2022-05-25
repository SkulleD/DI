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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblAficion = new System.Windows.Forms.Label();
            this.rb2Mujer = new System.Windows.Forms.RadioButton();
            this.rb2Hombre = new System.Windows.Forms.RadioButton();
            this.lblGeneroBusco = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnFoto = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblWarning = new System.Windows.Forms.Label();
            this.lblGeneroSoy = new System.Windows.Forms.Label();
            this.rb1Mujer = new System.Windows.Forms.RadioButton();
            this.rb1Hombre = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.validateTextBoxEdad = new BoletinJunio10.ValidateTextBox();
            this.validateTextBoxNombre = new BoletinJunio10.ValidateTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(16, 34);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(16, 95);
            this.lblEdad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(32, 13);
            this.lblEdad.TabIndex = 3;
            this.lblEdad.Text = "Edad";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(165, 165);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // lblAficion
            // 
            this.lblAficion.AutoSize = true;
            this.lblAficion.Location = new System.Drawing.Point(162, 150);
            this.lblAficion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAficion.Name = "lblAficion";
            this.lblAficion.Size = new System.Drawing.Size(82, 13);
            this.lblAficion.TabIndex = 5;
            this.lblAficion.Text = "Afición Principal";
            // 
            // rb2Mujer
            // 
            this.rb2Mujer.AutoSize = true;
            this.rb2Mujer.Location = new System.Drawing.Point(82, 229);
            this.rb2Mujer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rb2Mujer.Name = "rb2Mujer";
            this.rb2Mujer.Size = new System.Drawing.Size(51, 17);
            this.rb2Mujer.TabIndex = 5;
            this.rb2Mujer.Text = "Mujer";
            this.rb2Mujer.UseVisualStyleBackColor = true;
            // 
            // rb2Hombre
            // 
            this.rb2Hombre.AutoSize = true;
            this.rb2Hombre.Checked = true;
            this.rb2Hombre.Location = new System.Drawing.Point(18, 229);
            this.rb2Hombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rb2Hombre.Name = "rb2Hombre";
            this.rb2Hombre.Size = new System.Drawing.Size(62, 17);
            this.rb2Hombre.TabIndex = 4;
            this.rb2Hombre.TabStop = true;
            this.rb2Hombre.Text = "Hombre";
            this.rb2Hombre.UseVisualStyleBackColor = true;
            // 
            // lblGeneroBusco
            // 
            this.lblGeneroBusco.AutoSize = true;
            this.lblGeneroBusco.Location = new System.Drawing.Point(11, 210);
            this.lblGeneroBusco.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGeneroBusco.Name = "lblGeneroBusco";
            this.lblGeneroBusco.Size = new System.Drawing.Size(46, 13);
            this.lblGeneroBusco.TabIndex = 11;
            this.lblGeneroBusco.Text = "Busco...";
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAceptar.Location = new System.Drawing.Point(37, 274);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(71, 30);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.ForeColor = System.Drawing.Color.Red;
            this.btnCancelar.Location = new System.Drawing.Point(173, 274);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(71, 30);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnFoto
            // 
            this.btnFoto.Location = new System.Drawing.Point(81, 11);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(48, 23);
            this.btnFoto.TabIndex = 0;
            this.btnFoto.Text = "Foto";
            this.btnFoto.UseVisualStyleBackColor = true;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(135, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(6, 259);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(0, 13);
            this.lblWarning.TabIndex = 16;
            // 
            // lblGeneroSoy
            // 
            this.lblGeneroSoy.AutoSize = true;
            this.lblGeneroSoy.Location = new System.Drawing.Point(-1, -1);
            this.lblGeneroSoy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGeneroSoy.Name = "lblGeneroSoy";
            this.lblGeneroSoy.Size = new System.Drawing.Size(34, 13);
            this.lblGeneroSoy.TabIndex = 10;
            this.lblGeneroSoy.Text = "Soy...";
            // 
            // rb1Mujer
            // 
            this.rb1Mujer.AutoSize = true;
            this.rb1Mujer.Location = new System.Drawing.Point(68, 16);
            this.rb1Mujer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rb1Mujer.Name = "rb1Mujer";
            this.rb1Mujer.Size = new System.Drawing.Size(51, 17);
            this.rb1Mujer.TabIndex = 1;
            this.rb1Mujer.Text = "Mujer";
            this.rb1Mujer.UseVisualStyleBackColor = true;
            // 
            // rb1Hombre
            // 
            this.rb1Hombre.AutoSize = true;
            this.rb1Hombre.Checked = true;
            this.rb1Hombre.Location = new System.Drawing.Point(4, 16);
            this.rb1Hombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rb1Hombre.Name = "rb1Hombre";
            this.rb1Hombre.Size = new System.Drawing.Size(62, 17);
            this.rb1Hombre.TabIndex = 0;
            this.rb1Hombre.TabStop = true;
            this.rb1Hombre.Text = "Hombre";
            this.rb1Hombre.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rb1Mujer);
            this.panel1.Controls.Add(this.rb1Hombre);
            this.panel1.Controls.Add(this.lblGeneroSoy);
            this.panel1.Location = new System.Drawing.Point(12, 166);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(121, 41);
            this.panel1.TabIndex = 3;
            // 
            // validateTextBoxEdad
            // 
            this.validateTextBoxEdad.AutoSize = true;
            this.validateTextBoxEdad.Location = new System.Drawing.Point(9, 110);
            this.validateTextBoxEdad.Margin = new System.Windows.Forms.Padding(2);
            this.validateTextBoxEdad.Name = "validateTextBoxEdad";
            this.validateTextBoxEdad.Size = new System.Drawing.Size(120, 35);
            this.validateTextBoxEdad.TabIndex = 2;
            this.validateTextBoxEdad.Texto = "";
            this.validateTextBoxEdad.Tipo = BoletinJunio10.eTipo.Numérico;
            // 
            // validateTextBoxNombre
            // 
            this.validateTextBoxNombre.AutoSize = true;
            this.validateTextBoxNombre.Location = new System.Drawing.Point(9, 49);
            this.validateTextBoxNombre.Margin = new System.Windows.Forms.Padding(2);
            this.validateTextBoxNombre.Name = "validateTextBoxNombre";
            this.validateTextBoxNombre.Size = new System.Drawing.Size(120, 35);
            this.validateTextBoxNombre.TabIndex = 1;
            this.validateTextBoxNombre.Texto = "X AE A-12";
            this.validateTextBoxNombre.Tipo = BoletinJunio10.eTipo.Textual;
            // 
            // Entrada
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(273, 318);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnFoto);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblGeneroBusco);
            this.Controls.Add(this.rb2Mujer);
            this.Controls.Add(this.rb2Hombre);
            this.Controls.Add(this.lblAficion);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.validateTextBoxEdad);
            this.Controls.Add(this.validateTextBoxNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Entrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblAficion;
        private System.Windows.Forms.Label lblGeneroBusco;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnFoto;
        public BoletinJunio10.ValidateTextBox validateTextBoxNombre;
        public BoletinJunio10.ValidateTextBox validateTextBoxEdad;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.RadioButton rb2Mujer;
        public System.Windows.Forms.RadioButton rb2Hombre;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Label lblGeneroSoy;
        public System.Windows.Forms.RadioButton rb1Mujer;
        public System.Windows.Forms.RadioButton rb1Hombre;
        private System.Windows.Forms.Panel panel1;
    }
}