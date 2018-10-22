namespace RegistroCuentaReporte
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroPresupuestoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeCuentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposCuentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.presupuestoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fiToolStripMenuItem,
            this.registrosToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.salirToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(577, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fiToolStripMenuItem
            // 
            this.fiToolStripMenuItem.Name = "fiToolStripMenuItem";
            this.fiToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fiToolStripMenuItem.Text = "File";
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroPresupuestoToolStripMenuItem,
            this.registroDeCuentasToolStripMenuItem,
            this.tiposCuentasToolStripMenuItem});
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.registrosToolStripMenuItem.Text = "Registros";
            // 
            // registroPresupuestoToolStripMenuItem
            // 
            this.registroPresupuestoToolStripMenuItem.Name = "registroPresupuestoToolStripMenuItem";
            this.registroPresupuestoToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.registroPresupuestoToolStripMenuItem.Text = "Registro Presupuesto";
            this.registroPresupuestoToolStripMenuItem.Click += new System.EventHandler(this.registroPresupuestoToolStripMenuItem_Click);
            // 
            // registroDeCuentasToolStripMenuItem
            // 
            this.registroDeCuentasToolStripMenuItem.Name = "registroDeCuentasToolStripMenuItem";
            this.registroDeCuentasToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.registroDeCuentasToolStripMenuItem.Text = "Registro De Cuentas";
            this.registroDeCuentasToolStripMenuItem.Click += new System.EventHandler(this.registroDeCuentasToolStripMenuItem_Click);
            // 
            // tiposCuentasToolStripMenuItem
            // 
            this.tiposCuentasToolStripMenuItem.Name = "tiposCuentasToolStripMenuItem";
            this.tiposCuentasToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.tiposCuentasToolStripMenuItem.Text = "Tipos Cuentas";
            this.tiposCuentasToolStripMenuItem.Click += new System.EventHandler(this.tiposCuentasToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.presupuestoToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // presupuestoToolStripMenuItem
            // 
            this.presupuestoToolStripMenuItem.Name = "presupuestoToolStripMenuItem";
            this.presupuestoToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.presupuestoToolStripMenuItem.Text = "Reporte Presupuesto";
            this.presupuestoToolStripMenuItem.Click += new System.EventHandler(this.presupuestoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(577, 431);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.White;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(593, 470);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroPresupuestoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeCuentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposCuentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem presupuestoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
    }
}

