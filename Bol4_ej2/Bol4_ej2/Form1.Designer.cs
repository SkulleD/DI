
namespace Bol4_ej2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textRed = new System.Windows.Forms.TextBox();
            this.textGreen = new System.Windows.Forms.TextBox();
            this.textBlue = new System.Windows.Forms.TextBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.textImage = new System.Windows.Forms.TextBox();
            this.btnImage = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labelWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(69, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "RED";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(135, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "GREEN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(210, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "BLUE";
            // 
            // textRed
            // 
            this.textRed.AcceptsReturn = true;
            this.textRed.Location = new System.Drawing.Point(51, 55);
            this.textRed.Name = "textRed";
            this.textRed.Size = new System.Drawing.Size(67, 20);
            this.textRed.TabIndex = 0;
            // 
            // textGreen
            // 
            this.textGreen.AcceptsReturn = true;
            this.textGreen.Location = new System.Drawing.Point(123, 55);
            this.textGreen.Name = "textGreen";
            this.textGreen.Size = new System.Drawing.Size(67, 20);
            this.textGreen.TabIndex = 1;
            // 
            // textBlue
            // 
            this.textBlue.AcceptsReturn = true;
            this.textBlue.Location = new System.Drawing.Point(195, 55);
            this.textBlue.Name = "textBlue";
            this.textBlue.Size = new System.Drawing.Size(67, 20);
            this.textBlue.TabIndex = 2;
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(299, 38);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(75, 38);
            this.btnColor.TabIndex = 3;
            this.btnColor.Text = "COLOR";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            this.btnColor.MouseEnter += new System.EventHandler(this.Form1_MouseEnter);
            this.btnColor.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(438, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.Form1_MouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            // 
            // textImage
            // 
            this.textImage.AcceptsReturn = true;
            this.textImage.Location = new System.Drawing.Point(12, 126);
            this.textImage.Name = "textImage";
            this.textImage.Size = new System.Drawing.Size(267, 20);
            this.textImage.TabIndex = 4;
            this.textImage.Text = "C:\\Users\\AlvaroVila\\source\\repos\\Bol4_ej2\\Bol4_ej2\\bocatagarto.jpg";
            // 
            // btnImage
            // 
            this.btnImage.Location = new System.Drawing.Point(299, 116);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(75, 38);
            this.btnImage.TabIndex = 5;
            this.btnImage.Text = "IMAGE";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            this.btnImage.MouseEnter += new System.EventHandler(this.Form1_MouseEnter);
            this.btnImage.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(12, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "IMAGE PATH";
            // 
            // labelWarning
            // 
            this.labelWarning.AutoSize = true;
            this.labelWarning.Location = new System.Drawing.Point(416, 90);
            this.labelWarning.Name = "labelWarning";
            this.labelWarning.Size = new System.Drawing.Size(0, 13);
            this.labelWarning.TabIndex = 11;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnColor;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(521, 451);
            this.ControlBox = false;
            this.Controls.Add(this.labelWarning);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.textImage);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.textBlue);
            this.Controls.Add(this.textGreen);
            this.Controls.Add(this.textRed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colores e Imágenes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textRed;
        private System.Windows.Forms.TextBox textGreen;
        private System.Windows.Forms.TextBox textBlue;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox textImage;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelWarning;
    }
}

