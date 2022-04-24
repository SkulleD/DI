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
            this.btnTraspasarMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnToRightMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnToLeftMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuList1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(13, 86);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(124, 196);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(377, 86);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(124, 196);
            this.listBox2.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(210, 86);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "AÑADIR";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(210, 140);
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
            this.btnToRight.Location = new System.Drawing.Point(210, 201);
            this.btnToRight.Name = "btnToRight";
            this.btnToRight.Size = new System.Drawing.Size(103, 23);
            this.btnToRight.TabIndex = 5;
            this.btnToRight.Text = "------>";
            this.btnToRight.UseVisualStyleBackColor = true;
            this.btnToRight.Click += new System.EventHandler(this.btnToRight_Click);
            // 
            // btnToLeft
            // 
            this.btnToLeft.Location = new System.Drawing.Point(210, 259);
            this.btnToLeft.Name = "btnToLeft";
            this.btnToLeft.Size = new System.Drawing.Size(103, 23);
            this.btnToLeft.TabIndex = 6;
            this.btnToLeft.Text = "<------";
            this.btnToLeft.UseVisualStyleBackColor = true;
            this.btnToLeft.Click += new System.EventHandler(this.btnToLeft_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 288);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(124, 22);
            this.textBox1.TabIndex = 8;
            // 
            // lblNumElementos
            // 
            this.lblNumElementos.AutoSize = true;
            this.lblNumElementos.Location = new System.Drawing.Point(13, 41);
            this.lblNumElementos.Name = "lblNumElementos";
            this.lblNumElementos.Size = new System.Drawing.Size(101, 17);
            this.lblNumElementos.TabIndex = 0;
            this.lblNumElementos.Text = "Nº Elementos: ";
            // 
            // lblSeleccionados
            // 
            this.lblSeleccionados.AutoSize = true;
            this.lblSeleccionados.Location = new System.Drawing.Point(13, 66);
            this.lblSeleccionados.Name = "lblSeleccionados";
            this.lblSeleccionados.Size = new System.Drawing.Size(108, 17);
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
            this.btnRemoveMenu,
            this.btnTraspasarMenu});
            this.MenuList1.Location = new System.Drawing.Point(0, 0);
            this.MenuList1.Name = "MenuList1";
            this.MenuList1.Size = new System.Drawing.Size(513, 28);
            this.MenuList1.TabIndex = 10;
            this.MenuList1.Text = "menuStrip1";
            // 
            // btnAddMenu
            // 
            this.btnAddMenu.Name = "btnAddMenu";
            this.btnAddMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.btnAddMenu.Size = new System.Drawing.Size(67, 24);
            this.btnAddMenu.Text = "&Añadir";
            this.btnAddMenu.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemoveMenu
            // 
            this.btnRemoveMenu.Name = "btnRemoveMenu";
            this.btnRemoveMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.btnRemoveMenu.Size = new System.Drawing.Size(77, 24);
            this.btnRemoveMenu.Text = "&Eliminar";
            this.btnRemoveMenu.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnTraspasarMenu
            // 
            this.btnTraspasarMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnToRightMenu,
            this.btnToLeftMenu});
            this.btnTraspasarMenu.Name = "btnTraspasarMenu";
            this.btnTraspasarMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
            this.btnTraspasarMenu.Size = new System.Drawing.Size(85, 24);
            this.btnTraspasarMenu.Text = "&Traspasar";
            // 
            // btnToRightMenu
            // 
            this.btnToRightMenu.Name = "btnToRightMenu";
            this.btnToRightMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
            this.btnToRightMenu.Size = new System.Drawing.Size(228, 26);
            this.btnToRightMenu.Text = "&Derecha --->";
            this.btnToRightMenu.Click += new System.EventHandler(this.btnToRight_Click);
            // 
            // btnToLeftMenu
            // 
            this.btnToLeftMenu.Name = "btnToLeftMenu";
            this.btnToLeftMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.btnToLeftMenu.Size = new System.Drawing.Size(228, 26);
            this.btnToLeftMenu.Text = "<--- &Izquierda";
            this.btnToLeftMenu.Click += new System.EventHandler(this.btnToLeft_Click);
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
            this.Controls.Add(this.MenuList1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.ToolStripMenuItem btnTraspasarMenu;
        private System.Windows.Forms.ToolStripMenuItem btnToRightMenu;
        private System.Windows.Forms.ToolStripMenuItem btnToLeftMenu;
    }
}

