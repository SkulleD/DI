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
            this.MenuList1 = new System.Windows.Forms.MenuStrip();
            this.btnAddMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRemoveMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traspasarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traspasarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuList1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(10, 70);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(94, 160);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(283, 70);
            this.listBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(94, 160);
            this.listBox2.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(158, 70);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(77, 19);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "AÑADIR";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(158, 114);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(77, 19);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.TabStop = false;
            this.btnRemove.Text = "ELIMINAR";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnToRight
            // 
            this.btnToRight.Location = new System.Drawing.Point(158, 163);
            this.btnToRight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnToRight.Name = "btnToRight";
            this.btnToRight.Size = new System.Drawing.Size(77, 19);
            this.btnToRight.TabIndex = 5;
            this.btnToRight.Text = "------>";
            this.btnToRight.UseVisualStyleBackColor = true;
            this.btnToRight.Click += new System.EventHandler(this.btnToRight_Click);
            // 
            // btnToLeft
            // 
            this.btnToLeft.Location = new System.Drawing.Point(158, 210);
            this.btnToLeft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnToLeft.Name = "btnToLeft";
            this.btnToLeft.Size = new System.Drawing.Size(77, 19);
            this.btnToLeft.TabIndex = 6;
            this.btnToLeft.Text = "<------";
            this.btnToLeft.UseVisualStyleBackColor = true;
            this.btnToLeft.Click += new System.EventHandler(this.btnToLeft_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 234);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(94, 20);
            this.textBox1.TabIndex = 8;
            // 
            // lblNumElementos
            // 
            this.lblNumElementos.AutoSize = true;
            this.lblNumElementos.Location = new System.Drawing.Point(10, 33);
            this.lblNumElementos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumElementos.Name = "lblNumElementos";
            this.lblNumElementos.Size = new System.Drawing.Size(77, 13);
            this.lblNumElementos.TabIndex = 0;
            this.lblNumElementos.Text = "Nº Elementos: ";
            // 
            // lblSeleccionados
            // 
            this.lblSeleccionados.AutoSize = true;
            this.lblSeleccionados.Location = new System.Drawing.Point(10, 54);
            this.lblSeleccionados.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSeleccionados.Name = "lblSeleccionados";
            this.lblSeleccionados.Size = new System.Drawing.Size(83, 13);
            this.lblSeleccionados.TabIndex = 1;
            this.lblSeleccionados.Text = "Seleccionados: ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MenuList1
            // 
            this.MenuList1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuList1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddMenu,
            this.btnRemoveMenu});
            this.MenuList1.Location = new System.Drawing.Point(0, 0);
            this.MenuList1.Name = "MenuList1";
            this.MenuList1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.MenuList1.Size = new System.Drawing.Size(385, 24);
            this.MenuList1.TabIndex = 10;
            this.MenuList1.Text = "menuStrip1";
            // 
            // btnAddMenu
            // 
            this.btnAddMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.traspasarToolStripMenuItem});
            this.btnAddMenu.Name = "btnAddMenu";
            this.btnAddMenu.Size = new System.Drawing.Size(52, 20);
            this.btnAddMenu.Text = "Lista &1";
            this.btnAddMenu.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemoveMenu
            // 
            this.btnRemoveMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.traspasarToolStripMenuItem1});
            this.btnRemoveMenu.Name = "btnRemoveMenu";
            this.btnRemoveMenu.Size = new System.Drawing.Size(52, 20);
            this.btnRemoveMenu.Text = "Lista &2";
            this.btnRemoveMenu.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // añadirToolStripMenuItem
            // 
            this.añadirToolStripMenuItem.Name = "añadirToolStripMenuItem";
            this.añadirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.añadirToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.añadirToolStripMenuItem.Text = "&Añadir";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.eliminarToolStripMenuItem.Text = "&Eliminar";
            // 
            // traspasarToolStripMenuItem
            // 
            this.traspasarToolStripMenuItem.Name = "traspasarToolStripMenuItem";
            this.traspasarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
            this.traspasarToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.traspasarToolStripMenuItem.Text = "Mover &Derecha -->";
            // 
            // traspasarToolStripMenuItem1
            // 
            this.traspasarToolStripMenuItem1.Name = "traspasarToolStripMenuItem1";
            this.traspasarToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.traspasarToolStripMenuItem1.Size = new System.Drawing.Size(213, 22);
            this.traspasarToolStripMenuItem1.Text = "<-- Mover &Izquierda";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 366);
            this.Controls.Add(this.lblSeleccionados);
            this.Controls.Add(this.lblNumElementos);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnToLeft);
            this.Controls.Add(this.btnToRight);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.MenuList1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Junio 5";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
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
        private System.Windows.Forms.MenuStrip MenuList1;
        private System.Windows.Forms.ToolStripMenuItem btnAddMenu;
        private System.Windows.Forms.ToolStripMenuItem btnRemoveMenu;
        private System.Windows.Forms.ToolStripMenuItem añadirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traspasarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traspasarToolStripMenuItem1;
    }
}

