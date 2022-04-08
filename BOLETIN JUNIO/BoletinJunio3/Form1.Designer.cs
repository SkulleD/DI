namespace BoletinJunio3
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
            this.txtRed = new System.Windows.Forms.TextBox();
            this.txtGreen = new System.Windows.Forms.TextBox();
            this.txtBlue = new System.Windows.Forms.TextBox();
            this.labelR = new System.Windows.Forms.Label();
            this.labelG = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnImage = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.labelBG = new System.Windows.Forms.Label();
            this.lblWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtRed
            // 
            this.txtRed.Location = new System.Drawing.Point(12, 56);
            this.txtRed.Name = "txtRed";
            this.txtRed.Size = new System.Drawing.Size(47, 19);
            this.txtRed.TabIndex = 0;
            this.txtRed.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.txtRed.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // txtGreen
            // 
            this.txtGreen.Location = new System.Drawing.Point(65, 56);
            this.txtGreen.Name = "txtGreen";
            this.txtGreen.Size = new System.Drawing.Size(47, 19);
            this.txtGreen.TabIndex = 1;
            this.txtGreen.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.txtGreen.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // txtBlue
            // 
            this.txtBlue.Location = new System.Drawing.Point(118, 56);
            this.txtBlue.Name = "txtBlue";
            this.txtBlue.Size = new System.Drawing.Size(47, 19);
            this.txtBlue.TabIndex = 2;
            this.txtBlue.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.txtBlue.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelR.ForeColor = System.Drawing.Color.Red;
            this.labelR.Location = new System.Drawing.Point(12, 36);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(16, 13);
            this.labelR.TabIndex = 7;
            this.labelR.Text = "R";
            this.labelR.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // labelG
            // 
            this.labelG.AutoSize = true;
            this.labelG.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelG.ForeColor = System.Drawing.Color.Lime;
            this.labelG.Location = new System.Drawing.Point(62, 36);
            this.labelG.Name = "labelG";
            this.labelG.Size = new System.Drawing.Size(16, 13);
            this.labelG.TabIndex = 8;
            this.labelG.Text = "G";
            this.labelG.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelB.ForeColor = System.Drawing.Color.Blue;
            this.labelB.Location = new System.Drawing.Point(115, 36);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(15, 13);
            this.labelB.TabIndex = 9;
            this.labelB.Text = "B";
            this.labelB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // btnColor
            // 
            this.btnColor.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnColor.Location = new System.Drawing.Point(200, 49);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(75, 37);
            this.btnColor.TabIndex = 3;
            this.btnColor.Text = "COLOR";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            this.btnColor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.btnColor.MouseEnter += new System.EventHandler(this.btnMouseEnter);
            this.btnColor.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            this.btnColor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // btnImage
            // 
            this.btnImage.Location = new System.Drawing.Point(296, 49);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(75, 37);
            this.btnImage.TabIndex = 4;
            this.btnImage.Text = "IMAGE";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            this.btnImage.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.btnImage.MouseEnter += new System.EventHandler(this.btnMouseEnter);
            this.btnImage.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            this.btnImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(12, 128);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(356, 19);
            this.txtPath.TabIndex = 6;
            this.txtPath.Text = "C:\\Users\\Alvaro\\source\\repos\\BOLETIN JUNIO\\BoletinJunio3\\perrito.jpg";
            this.txtPath.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.txtPath.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Image Path";
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(538, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(79, 41);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.btnExit.MouseEnter += new System.EventHandler(this.btnMouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            this.btnExit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // labelBG
            // 
            this.labelBG.AutoSize = true;
            this.labelBG.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBG.Location = new System.Drawing.Point(246, 33);
            this.labelBG.Name = "labelBG";
            this.labelBG.Size = new System.Drawing.Size(75, 13);
            this.labelBG.TabIndex = 10;
            this.labelBG.Text = "Background";
            this.labelBG.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.Location = new System.Drawing.Point(197, 99);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(0, 13);
            this.lblWarning.TabIndex = 12;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnColor;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 450);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.labelBG);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelG);
            this.Controls.Add(this.labelR);
            this.Controls.Add(this.txtBlue);
            this.Controls.Add(this.txtGreen);
            this.Controls.Add(this.txtRed);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colores e Imágenes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRed;
        private System.Windows.Forms.TextBox txtGreen;
        private System.Windows.Forms.TextBox txtBlue;
        private System.Windows.Forms.Label labelR;
        private System.Windows.Forms.Label labelG;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label labelBG;
        private System.Windows.Forms.Label lblWarning;
    }
}

