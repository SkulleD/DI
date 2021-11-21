
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
            this.txtNumber1.Location = new System.Drawing.Point(99, 65);
            this.txtNumber1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(93, 22);
            this.txtNumber1.TabIndex = 0;
            // 
            // txtNumber2
            // 
            this.txtNumber2.Location = new System.Drawing.Point(225, 65);
            this.txtNumber2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(93, 22);
            this.txtNumber2.TabIndex = 1;
            // 
            // lblSigno
            // 
            this.lblSigno.AutoSize = true;
            this.lblSigno.Location = new System.Drawing.Point(200, 69);
            this.lblSigno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSigno.Name = "lblSigno";
            this.lblSigno.Size = new System.Drawing.Size(16, 17);
            this.lblSigno.TabIndex = 2;
            this.lblSigno.Text = "+";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(328, 69);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(16, 17);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "=";
            // 
            // radioSuma
            // 
            this.radioSuma.AutoSize = true;
            this.radioSuma.Location = new System.Drawing.Point(120, 116);
            this.radioSuma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioSuma.Name = "radioSuma";
            this.radioSuma.Size = new System.Drawing.Size(70, 21);
            this.radioSuma.TabIndex = 4;
            this.radioSuma.TabStop = true;
            this.radioSuma.Text = "Sumar";
            this.radioSuma.UseVisualStyleBackColor = true;
            // 
            // radioResta
            // 
            this.radioResta.AutoSize = true;
            this.radioResta.Location = new System.Drawing.Point(225, 116);
            this.radioResta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioResta.Name = "radioResta";
            this.radioResta.Size = new System.Drawing.Size(71, 21);
            this.radioResta.TabIndex = 5;
            this.radioResta.TabStop = true;
            this.radioResta.Text = "Restar";
            this.radioResta.UseVisualStyleBackColor = true;
            // 
            // radioMulti
            // 
            this.radioMulti.AutoSize = true;
            this.radioMulti.Location = new System.Drawing.Point(120, 144);
            this.radioMulti.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioMulti.Name = "radioMulti";
            this.radioMulti.Size = new System.Drawing.Size(92, 21);
            this.radioMulti.TabIndex = 6;
            this.radioMulti.TabStop = true;
            this.radioMulti.Text = "Multiplicar";
            this.radioMulti.UseVisualStyleBackColor = true;
            // 
            // radioDivision
            // 
            this.radioDivision.AutoSize = true;
            this.radioDivision.Location = new System.Drawing.Point(225, 144);
            this.radioDivision.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioDivision.Name = "radioDivision";
            this.radioDivision.Size = new System.Drawing.Size(68, 21);
            this.radioDivision.TabIndex = 7;
            this.radioDivision.TabStop = true;
            this.radioDivision.Text = "Dividir";
            this.radioDivision.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(161, 186);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 28);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 554);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
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

