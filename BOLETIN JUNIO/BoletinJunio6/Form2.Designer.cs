namespace BoletinJunio6
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.txtPIN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTries = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPIN
            // 
            this.txtPIN.Location = new System.Drawing.Point(80, 70);
            this.txtPIN.Margin = new System.Windows.Forms.Padding(2);
            this.txtPIN.Name = "txtPIN";
            this.txtPIN.Size = new System.Drawing.Size(76, 20);
            this.txtPIN.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Introduzca el pin correcto. 4 números.\r\n         Tecla Enter para aceptar.";
            // 
            // lblTries
            // 
            this.lblTries.AutoSize = true;
            this.lblTries.Location = new System.Drawing.Point(67, 101);
            this.lblTries.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTries.Name = "lblTries";
            this.lblTries.Size = new System.Drawing.Size(103, 13);
            this.lblTries.TabIndex = 2;
            this.lblTries.Text = "Intentos restantes: 3";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(92, 37);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(1, 1);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "button1";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // Form2
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 219);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblTries);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPIN);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Entrada";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPIN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTries;
        private System.Windows.Forms.Button btnAceptar;
    }
}