namespace BoletinJunio5
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnToRight = new System.Windows.Forms.Button();
            this.btnToLeft = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblNumElementos = new System.Windows.Forms.Label();
            this.lblSeleccionados = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MenuList2 = new System.Windows.Forms.MenuStrip();
            this.MenuList1 = new System.Windows.Forms.MenuStrip();
            this.añadirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traspasarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traspasarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuList2.SuspendLayout();
            this.MenuList1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(13, 107);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(124, 196);
            this.listBox1.TabIndex = 2;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(377, 107);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(124, 196);
            this.listBox2.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(210, 107);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "AÑADIR";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(210, 161);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(103, 23);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.TabStop = false;
            this.btnRemove.Text = "ELIMINAR";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnToRight
            // 
            this.btnToRight.Location = new System.Drawing.Point(210, 222);
            this.btnToRight.Name = "btnToRight";
            this.btnToRight.Size = new System.Drawing.Size(103, 23);
            this.btnToRight.TabIndex = 5;
            this.btnToRight.Text = "------>";
            this.btnToRight.UseVisualStyleBackColor = true;
            this.btnToRight.Click += new System.EventHandler(this.btnToRight_Click);
            // 
            // btnToLeft
            // 
            this.btnToLeft.Location = new System.Drawing.Point(210, 280);
            this.btnToLeft.Name = "btnToLeft";
            this.btnToLeft.Size = new System.Drawing.Size(103, 23);
            this.btnToLeft.TabIndex = 6;
            this.btnToLeft.Text = "<------";
            this.btnToLeft.UseVisualStyleBackColor = true;
            this.btnToLeft.Click += new System.EventHandler(this.btnToLeft_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 309);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(124, 22);
            this.textBox1.TabIndex = 8;
            // 
            // lblNumElementos
            // 
            this.lblNumElementos.AutoSize = true;
            this.lblNumElementos.Location = new System.Drawing.Point(13, 62);
            this.lblNumElementos.Name = "lblNumElementos";
            this.lblNumElementos.Size = new System.Drawing.Size(101, 17);
            this.lblNumElementos.TabIndex = 0;
            this.lblNumElementos.Text = "Nº Elementos: ";
            // 
            // lblSeleccionados
            // 
            this.lblSeleccionados.AutoSize = true;
            this.lblSeleccionados.Location = new System.Drawing.Point(13, 87);
            this.lblSeleccionados.Name = "lblSeleccionados";
            this.lblSeleccionados.Size = new System.Drawing.Size(108, 17);
            this.lblSeleccionados.TabIndex = 1;
            this.lblSeleccionados.Text = "Seleccionados: ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MenuList2
            // 
            this.MenuList2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuList2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.traspasarToolStripMenuItem1});
            this.MenuList2.Location = new System.Drawing.Point(0, 28);
            this.MenuList2.Name = "MenuList2";
            this.MenuList2.Size = new System.Drawing.Size(513, 28);
            this.MenuList2.TabIndex = 9;
            this.MenuList2.Text = "menuStrip1";
            // 
            // MenuList1
            // 
            this.MenuList1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuList1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.traspasarToolStripMenuItem});
            this.MenuList1.Location = new System.Drawing.Point(0, 0);
            this.MenuList1.Name = "MenuList1";
            this.MenuList1.Size = new System.Drawing.Size(513, 28);
            this.MenuList1.TabIndex = 10;
            this.MenuList1.Text = "menuStrip1";
            // 
            // añadirToolStripMenuItem
            // 
            this.añadirToolStripMenuItem.Name = "añadirToolStripMenuItem";
            this.añadirToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.añadirToolStripMenuItem.Text = "Añadir";
            this.añadirToolStripMenuItem.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // traspasarToolStripMenuItem
            // 
            this.traspasarToolStripMenuItem.Name = "traspasarToolStripMenuItem";
            this.traspasarToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.traspasarToolStripMenuItem.Text = "Traspasar --->";
            this.traspasarToolStripMenuItem.Click += new System.EventHandler(this.btnToRight_Click);
            // 
            // traspasarToolStripMenuItem1
            // 
            this.traspasarToolStripMenuItem1.Name = "traspasarToolStripMenuItem1";
            this.traspasarToolStripMenuItem1.Size = new System.Drawing.Size(117, 24);
            this.traspasarToolStripMenuItem1.Text = "<--- Traspasar";
            this.traspasarToolStripMenuItem1.Click += new System.EventHandler(this.btnToLeft_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 450);
            this.Controls.Add(this.lblSeleccionados);
            this.Controls.Add(this.lblNumElementos);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnToLeft);
            this.Controls.Add(this.btnToRight);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.MenuList2);
            this.Controls.Add(this.MenuList1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuList2;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boletín Junio 5";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.MenuList2.ResumeLayout(false);
            this.MenuList2.PerformLayout();
            this.MenuList1.ResumeLayout(false);
            this.MenuList1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnToRight;
        private System.Windows.Forms.Button btnToLeft;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblNumElementos;
        private System.Windows.Forms.Label lblSeleccionados;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip MenuList2;
        private System.Windows.Forms.ToolStripMenuItem traspasarToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip MenuList1;
        private System.Windows.Forms.ToolStripMenuItem añadirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traspasarToolStripMenuItem;
    }
}

