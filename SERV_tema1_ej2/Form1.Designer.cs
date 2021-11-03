namespace SERV_tema1_ej2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnView = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnKill = new System.Windows.Forms.Button();
            this.btnStartsWith = new System.Windows.Forms.Button();
            this.btnRunApp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(20, 55);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(674, 287);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(20, 22);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(674, 20);
            this.textBox2.TabIndex = 0;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(710, 55);
            this.btnView.Margin = new System.Windows.Forms.Padding(2);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(67, 37);
            this.btnView.TabIndex = 2;
            this.btnView.Text = "View\r\nProcesses";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(710, 107);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(67, 37);
            this.btnInfo.TabIndex = 3;
            this.btnInfo.Text = "Process\r\nInfo";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(710, 158);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(67, 37);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close\r\nProcess";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnKill
            // 
            this.btnKill.Location = new System.Drawing.Point(710, 210);
            this.btnKill.Margin = new System.Windows.Forms.Padding(2);
            this.btnKill.Name = "btnKill";
            this.btnKill.Size = new System.Drawing.Size(67, 37);
            this.btnKill.TabIndex = 5;
            this.btnKill.Text = "Kill\r\nProcess";
            this.btnKill.UseVisualStyleBackColor = true;
            this.btnKill.Click += new System.EventHandler(this.btnKill_Click);
            // 
            // btnStartsWith
            // 
            this.btnStartsWith.Location = new System.Drawing.Point(710, 305);
            this.btnStartsWith.Margin = new System.Windows.Forms.Padding(2);
            this.btnStartsWith.Name = "btnStartsWith";
            this.btnStartsWith.Size = new System.Drawing.Size(67, 37);
            this.btnStartsWith.TabIndex = 7;
            this.btnStartsWith.Text = "Starts\r\nWith...";
            this.btnStartsWith.UseVisualStyleBackColor = true;
            this.btnStartsWith.Click += new System.EventHandler(this.btnStartsWith_Click);
            // 
            // btnRunApp
            // 
            this.btnRunApp.Location = new System.Drawing.Point(710, 260);
            this.btnRunApp.Margin = new System.Windows.Forms.Padding(2);
            this.btnRunApp.Name = "btnRunApp";
            this.btnRunApp.Size = new System.Drawing.Size(67, 37);
            this.btnRunApp.TabIndex = 6;
            this.btnRunApp.Text = "Run App";
            this.btnRunApp.UseVisualStyleBackColor = true;
            this.btnRunApp.Click += new System.EventHandler(this.btnRunApp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(409, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 377);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRunApp);
            this.Controls.Add(this.btnStartsWith);
            this.Controls.Add(this.btnKill);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnKill;
        private System.Windows.Forms.Button btnStartsWith;
        private System.Windows.Forms.Button btnRunApp;
        private System.Windows.Forms.Label label1;
    }
}

