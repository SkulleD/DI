
namespace Bol4_ej4
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.lblSigno = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.radioSuma = new System.Windows.Forms.RadioButton();
            this.radioResta = new System.Windows.Forms.RadioButton();
            this.radioMulti = new System.Windows.Forms.RadioButton();
            this.radioDivision = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(74, 53);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(71, 20);
            this.txtNumber1.TabIndex = 0;
            // 
            // txtNumber2
            // 
            this.txtNumber2.Location = new System.Drawing.Point(169, 53);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(71, 20);
            this.txtNumber2.TabIndex = 1;
            // 
            // lblSigno
            // 
            this.lblSigno.AutoSize = true;
            this.lblSigno.Location = new System.Drawing.Point(150, 56);
            this.lblSigno.Name = "lblSigno";
            this.lblSigno.Size = new System.Drawing.Size(13, 13);
            this.lblSigno.TabIndex = 2;
            this.lblSigno.Text = "+";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(246, 56);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(13, 13);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "=";
            // 
            // radioSuma
            // 
            this.radioSuma.AutoSize = true;
            this.radioSuma.Location = new System.Drawing.Point(90, 94);
            this.radioSuma.Name = "radioSuma";
            this.radioSuma.Size = new System.Drawing.Size(55, 17);
            this.radioSuma.TabIndex = 4;
            this.radioSuma.TabStop = true;
            this.radioSuma.Text = "Sumar";
            this.radioSuma.UseVisualStyleBackColor = true;
            // 
            // radioResta
            // 
            this.radioResta.AutoSize = true;
            this.radioResta.Location = new System.Drawing.Point(169, 94);
            this.radioResta.Name = "radioResta";
            this.radioResta.Size = new System.Drawing.Size(56, 17);
            this.radioResta.TabIndex = 5;
            this.radioResta.TabStop = true;
            this.radioResta.Text = "Restar";
            this.radioResta.UseVisualStyleBackColor = true;
            // 
            // radioMulti
            // 
            this.radioMulti.AutoSize = true;
            this.radioMulti.Location = new System.Drawing.Point(90, 117);
            this.radioMulti.Name = "radioMulti";
            this.radioMulti.Size = new System.Drawing.Size(72, 17);
            this.radioMulti.TabIndex = 6;
            this.radioMulti.TabStop = true;
            this.radioMulti.Text = "Multiplicar";
            this.radioMulti.UseVisualStyleBackColor = true;
            // 
            // radioDivision
            // 
            this.radioDivision.AutoSize = true;
            this.radioDivision.Location = new System.Drawing.Point(169, 117);
            this.radioDivision.Name = "radioDivision";
            this.radioDivision.Size = new System.Drawing.Size(54, 17);
            this.radioDivision.TabIndex = 7;
            this.radioDivision.TabStop = true;
            this.radioDivision.Text = "Dividir";
            this.radioDivision.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(121, 151);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 450);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.radioDivision);
            this.Controls.Add(this.radioMulti);
            this.Controls.Add(this.radioResta);
            this.Controls.Add(this.radioSuma);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblSigno);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.txtNumber1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.Label lblSigno;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.RadioButton radioSuma;
        private System.Windows.Forms.RadioButton radioResta;
        private System.Windows.Forms.RadioButton radioMulti;
        private System.Windows.Forms.RadioButton radioDivision;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Timer timer1;
    }
}

