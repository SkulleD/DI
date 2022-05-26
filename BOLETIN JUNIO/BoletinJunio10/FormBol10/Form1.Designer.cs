namespace FormBol10
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
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBorrar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbldatoIncorrecto = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.lblListaClientes = new System.Windows.Forms.Label();
            this.lblParejasvalidas = new System.Windows.Forms.Label();
            this.picCliente = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 57);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(412, 180);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(443, 203);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(93, 34);
            this.btnBorrar.TabIndex = 3;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(443, 164);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(93, 34);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 243);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 295);
            this.panel1.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCliente,
            this.menuAcercaDe});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(979, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuCliente
            // 
            this.menuCliente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNuevo,
            this.menuBorrar,
            this.toolStripSeparator1,
            this.menuSalir});
            this.menuCliente.Name = "menuCliente";
            this.menuCliente.Size = new System.Drawing.Size(69, 24);
            this.menuCliente.Text = "&Cliente";
            // 
            // menuNuevo
            // 
            this.menuNuevo.Name = "menuNuevo";
            this.menuNuevo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuNuevo.Size = new System.Drawing.Size(188, 26);
            this.menuNuevo.Text = "&Nuevo";
            this.menuNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // menuBorrar
            // 
            this.menuBorrar.Name = "menuBorrar";
            this.menuBorrar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.menuBorrar.Size = new System.Drawing.Size(188, 26);
            this.menuBorrar.Text = "&Borrar";
            this.menuBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(185, 6);
            // 
            // menuSalir
            // 
            this.menuSalir.Name = "menuSalir";
            this.menuSalir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuSalir.Size = new System.Drawing.Size(188, 26);
            this.menuSalir.Text = "&Salir";
            this.menuSalir.Click += new System.EventHandler(this.menuSalir_Click);
            // 
            // menuAcercaDe
            // 
            this.menuAcercaDe.Name = "menuAcercaDe";
            this.menuAcercaDe.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.menuAcercaDe.Size = new System.Drawing.Size(89, 24);
            this.menuAcercaDe.Text = "&Acerca de";
            this.menuAcercaDe.Click += new System.EventHandler(this.menuAcercaDe_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbldatoIncorrecto
            // 
            this.lbldatoIncorrecto.AutoSize = true;
            this.lbldatoIncorrecto.ForeColor = System.Drawing.Color.Red;
            this.lbldatoIncorrecto.Location = new System.Drawing.Point(229, 37);
            this.lbldatoIncorrecto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldatoIncorrecto.Name = "lbldatoIncorrecto";
            this.lbldatoIncorrecto.Size = new System.Drawing.Size(0, 17);
            this.lbldatoIncorrecto.TabIndex = 7;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(556, 57);
            this.listBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(412, 180);
            this.listBox2.TabIndex = 4;
            // 
            // lblListaClientes
            // 
            this.lblListaClientes.AutoSize = true;
            this.lblListaClientes.Location = new System.Drawing.Point(11, 37);
            this.lblListaClientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblListaClientes.Name = "lblListaClientes";
            this.lblListaClientes.Size = new System.Drawing.Size(110, 17);
            this.lblListaClientes.TabIndex = 9;
            this.lblListaClientes.Text = "Lista de clientes";
            // 
            // lblParejasvalidas
            // 
            this.lblParejasvalidas.AutoSize = true;
            this.lblParejasvalidas.Location = new System.Drawing.Point(555, 37);
            this.lblParejasvalidas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblParejasvalidas.Name = "lblParejasvalidas";
            this.lblParejasvalidas.Size = new System.Drawing.Size(157, 17);
            this.lblParejasvalidas.TabIndex = 10;
            this.lblParejasvalidas.Text = "Lista de parejas válidas";
            // 
            // picCliente
            // 
            this.picCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picCliente.Location = new System.Drawing.Point(432, 33);
            this.picCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picCliente.Name = "picCliente";
            this.picCliente.Size = new System.Drawing.Size(115, 124);
            this.picCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCliente.TabIndex = 11;
            this.picCliente.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 543);
            this.Controls.Add(this.picCliente);
            this.Controls.Add(this.lblParejasvalidas);
            this.Controls.Add(this.lblListaClientes);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.lbldatoIncorrecto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrikiLove";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuCliente;
        private System.Windows.Forms.ToolStripMenuItem menuNuevo;
        private System.Windows.Forms.ToolStripMenuItem menuBorrar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuSalir;
        private System.Windows.Forms.ToolStripMenuItem menuAcercaDe;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbldatoIncorrecto;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label lblListaClientes;
        private System.Windows.Forms.Label lblParejasvalidas;
        private System.Windows.Forms.PictureBox picCliente;
    }
}

