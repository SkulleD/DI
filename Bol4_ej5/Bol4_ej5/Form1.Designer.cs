
namespace Bol4_ej5
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
            this.btnMoveRight = new System.Windows.Forms.Button();
            this.btnMoveLeft = new System.Windows.Forms.Button();
            this.textIntro = new System.Windows.Forms.TextBox();
            this.lblinfo = new System.Windows.Forms.Label();
            this.lblinfoLeft = new System.Windows.Forms.Label();
            this.lblInfoRight = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(16, 37);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(173, 180);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(307, 37);
            this.listBox2.Margin = new System.Windows.Forms.Padding(4);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(173, 180);
            this.listBox2.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(91, 257);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(199, 64);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(100, 28);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "REMOVE";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnMoveRight
            // 
            this.btnMoveRight.Location = new System.Drawing.Point(199, 100);
            this.btnMoveRight.Margin = new System.Windows.Forms.Padding(4);
            this.btnMoveRight.Name = "btnMoveRight";
            this.btnMoveRight.Size = new System.Drawing.Size(100, 28);
            this.btnMoveRight.TabIndex = 2;
            this.btnMoveRight.Text = "MOVE -->";
            this.btnMoveRight.UseVisualStyleBackColor = true;
            this.btnMoveRight.Click += new System.EventHandler(this.btnMoveRight_Click);
            // 
            // btnMoveLeft
            // 
            this.btnMoveLeft.Location = new System.Drawing.Point(199, 135);
            this.btnMoveLeft.Margin = new System.Windows.Forms.Padding(4);
            this.btnMoveLeft.Name = "btnMoveLeft";
            this.btnMoveLeft.Size = new System.Drawing.Size(100, 28);
            this.btnMoveLeft.TabIndex = 3;
            this.btnMoveLeft.Text = "<-- MOVE";
            this.btnMoveLeft.UseVisualStyleBackColor = true;
            this.btnMoveLeft.Click += new System.EventHandler(this.btnMoveLeft_Click);
            // 
            // textIntro
            // 
            this.textIntro.Location = new System.Drawing.Point(16, 225);
            this.textIntro.Margin = new System.Windows.Forms.Padding(4);
            this.textIntro.Name = "textIntro";
            this.textIntro.Size = new System.Drawing.Size(173, 22);
            this.textIntro.TabIndex = 5;
            // 
            // lblinfo
            // 
            this.lblinfo.AutoSize = true;
            this.lblinfo.Location = new System.Drawing.Point(16, 263);
            this.lblinfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(74, 17);
            this.lblinfo.TabIndex = 9;
            this.lblinfo.Text = "Insert Text";
            // 
            // lblinfoLeft
            // 
            this.lblinfoLeft.AutoSize = true;
            this.lblinfoLeft.Location = new System.Drawing.Point(16, 11);
            this.lblinfoLeft.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblinfoLeft.Name = "lblinfoLeft";
            this.lblinfoLeft.Size = new System.Drawing.Size(104, 17);
            this.lblinfoLeft.TabIndex = 7;
            this.lblinfoLeft.Text = "Nº of elements:";
            // 
            // lblInfoRight
            // 
            this.lblInfoRight.AutoSize = true;
            this.lblInfoRight.Location = new System.Drawing.Point(143, 11);
            this.lblInfoRight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfoRight.Name = "lblInfoRight";
            this.lblInfoRight.Size = new System.Drawing.Size(104, 17);
            this.lblInfoRight.TabIndex = 8;
            this.lblInfoRight.Text = "Selected index:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 554);
            this.Controls.Add(this.lblInfoRight);
            this.Controls.Add(this.lblinfoLeft);
            this.Controls.Add(this.lblinfo);
            this.Controls.Add(this.textIntro);
            this.Controls.Add(this.btnMoveLeft);
            this.Controls.Add(this.btnMoveRight);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Bol4_ej5";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnMoveRight;
        private System.Windows.Forms.Button btnMoveLeft;
        private System.Windows.Forms.TextBox textIntro;
        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.Label lblinfoLeft;
        private System.Windows.Forms.Label lblInfoRight;
        private System.Windows.Forms.Timer timer1;
    }
}

