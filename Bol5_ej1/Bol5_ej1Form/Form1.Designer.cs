
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnPos = new System.Windows.Forms.Button();
            this.btnSeparaDer = new System.Windows.Forms.Button();
            this.btnSeparaIzq = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelTextbox1 = new Bol5_ej1.LabelTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPos
            // 
            this.btnPos.Location = new System.Drawing.Point(71, 75);
            this.btnPos.Name = "btnPos";
            this.btnPos.Size = new System.Drawing.Size(75, 23);
            this.btnPos.TabIndex = 1;
            this.btnPos.Text = "Posición";
            this.btnPos.UseVisualStyleBackColor = true;
            this.btnPos.Click += new System.EventHandler(this.btnPos_Click);
            // 
            // btnSeparaDer
            // 
            this.btnSeparaDer.Location = new System.Drawing.Point(31, 102);
            this.btnSeparaDer.Name = "btnSeparaDer";
            this.btnSeparaDer.Size = new System.Drawing.Size(75, 23);
            this.btnSeparaDer.TabIndex = 2;
            this.btnSeparaDer.Text = "Derecha";
            this.btnSeparaDer.UseVisualStyleBackColor = true;
            this.btnSeparaDer.Click += new System.EventHandler(this.btnSeparaDer_Click);
            // 
            // btnSeparaIzq
            // 
            this.btnSeparaIzq.Location = new System.Drawing.Point(112, 102);
            this.btnSeparaIzq.Name = "btnSeparaIzq";
            this.btnSeparaIzq.Size = new System.Drawing.Size(75, 23);
            this.btnSeparaIzq.TabIndex = 3;
            this.btnSeparaIzq.Text = "Izquierda";
            this.btnSeparaIzq.UseVisualStyleBackColor = true;
            this.btnSeparaIzq.Click += new System.EventHandler(this.btnSeparaIzq_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(240, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 170);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(240, 188);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(302, 174);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // labelTextbox1
            // 
            this.labelTextbox1.Location = new System.Drawing.Point(31, 29);
            this.labelTextbox1.Name = "labelTextbox1";
            this.labelTextbox1.Posicion = Bol5_ej1.ePosicion.IZQUIERDA;
            this.labelTextbox1.Separacion = 0;
            this.labelTextbox1.Size = new System.Drawing.Size(156, 20);
            this.labelTextbox1.TabIndex = 0;
            this.labelTextbox1.Text_Label = "label1";
            this.labelTextbox1.Text_TextBox = "";
            this.labelTextbox1.CambiaPosicion += new System.EventHandler(this.labelTextbox1_CambiaPosicion);
            this.labelTextbox1.TxtChanged += new System.EventHandler(this.labelTextbox1_TxtChanged);
            this.labelTextbox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.labelTextbox1_KeyPress);
            this.labelTextbox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.labelTextbox1_KeyUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 374);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSeparaIzq);
            this.Controls.Add(this.btnSeparaDer);
            this.Controls.Add(this.btnPos);
            this.Controls.Add(this.labelTextbox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Bol5_ej1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bol5_ej1.LabelTextbox labelTextbox1;
        private System.Windows.Forms.Button btnPos;
        private System.Windows.Forms.Button btnSeparaDer;
        private System.Windows.Forms.Button btnSeparaIzq;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

