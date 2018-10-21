namespace RegistroCuentaReporte.UI.Registro
{
    partial class RPresupuesto
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
            this.components = new System.ComponentModel.Container();
            this.TipoCuentacomboBox = new System.Windows.Forms.ComboBox();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.RemoverButton = new System.Windows.Forms.Button();
            this.DetallePresupuestodataGridView = new System.Windows.Forms.DataGridView();
            this.Ventana_button = new System.Windows.Forms.Button();
            this.Valor_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Add_button = new System.Windows.Forms.Button();
            this.Fecha_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.PresupuestoId_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.totalnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SuperErrorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.EliminarButton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.DescripciontextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DetallePresupuestodataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Valor_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PresupuestoId_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuperErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // TipoCuentacomboBox
            // 
            this.TipoCuentacomboBox.FormattingEnabled = true;
            this.TipoCuentacomboBox.Location = new System.Drawing.Point(11, 157);
            this.TipoCuentacomboBox.Name = "TipoCuentacomboBox";
            this.TipoCuentacomboBox.Size = new System.Drawing.Size(94, 21);
            this.TipoCuentacomboBox.TabIndex = 82;
            this.TipoCuentacomboBox.SelectedIndexChanged += new System.EventHandler(this.TipoCuentacomboBox_SelectedIndexChanged);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(151, 389);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 33);
            this.Guardarbutton.TabIndex = 80;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Location = new System.Drawing.Point(23, 389);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(75, 33);
            this.NuevoButton.TabIndex = 79;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // RemoverButton
            // 
            this.RemoverButton.BackColor = System.Drawing.Color.White;
            this.RemoverButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RemoverButton.ForeColor = System.Drawing.Color.Red;
            this.RemoverButton.Location = new System.Drawing.Point(11, 335);
            this.RemoverButton.Name = "RemoverButton";
            this.RemoverButton.Size = new System.Drawing.Size(75, 23);
            this.RemoverButton.TabIndex = 77;
            this.RemoverButton.Text = "Remover";
            this.RemoverButton.UseVisualStyleBackColor = false;
            this.RemoverButton.Click += new System.EventHandler(this.RemoverButton_Click);
            // 
            // DetallePresupuestodataGridView
            // 
            this.DetallePresupuestodataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetallePresupuestodataGridView.Location = new System.Drawing.Point(12, 184);
            this.DetallePresupuestodataGridView.Name = "DetallePresupuestodataGridView";
            this.DetallePresupuestodataGridView.Size = new System.Drawing.Size(330, 150);
            this.DetallePresupuestodataGridView.TabIndex = 76;
            // 
            // Ventana_button
            // 
            this.Ventana_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Ventana_button.Location = new System.Drawing.Point(111, 156);
            this.Ventana_button.Name = "Ventana_button";
            this.Ventana_button.Size = new System.Drawing.Size(32, 26);
            this.Ventana_button.TabIndex = 75;
            this.Ventana_button.Text = "+";
            this.Ventana_button.UseVisualStyleBackColor = true;
            this.Ventana_button.Click += new System.EventHandler(this.Ventana_button_Click);
            // 
            // Valor_numericUpDown
            // 
            this.Valor_numericUpDown.DecimalPlaces = 2;
            this.Valor_numericUpDown.Location = new System.Drawing.Point(151, 160);
            this.Valor_numericUpDown.Name = "Valor_numericUpDown";
            this.Valor_numericUpDown.Size = new System.Drawing.Size(131, 20);
            this.Valor_numericUpDown.TabIndex = 73;
            // 
            // Add_button
            // 
            this.Add_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Add_button.Location = new System.Drawing.Point(297, 150);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(45, 32);
            this.Add_button.TabIndex = 72;
            this.Add_button.Text = "Add";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // Fecha_dateTimePicker
            // 
            this.Fecha_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Fecha_dateTimePicker.Location = new System.Drawing.Point(247, 8);
            this.Fecha_dateTimePicker.Name = "Fecha_dateTimePicker";
            this.Fecha_dateTimePicker.Size = new System.Drawing.Size(95, 20);
            this.Fecha_dateTimePicker.TabIndex = 70;
            // 
            // PresupuestoId_numericUpDown
            // 
            this.PresupuestoId_numericUpDown.Location = new System.Drawing.Point(43, 8);
            this.PresupuestoId_numericUpDown.Name = "PresupuestoId_numericUpDown";
            this.PresupuestoId_numericUpDown.Size = new System.Drawing.Size(62, 20);
            this.PresupuestoId_numericUpDown.TabIndex = 69;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(195, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 68;
            this.label6.Text = "Valor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 67;
            this.label5.Text = "Cuenta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 66;
            this.label4.Text = "Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 64;
            this.label2.Text = "Fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 63;
            this.label1.Text = "Id";
            // 
            // totalnumericUpDown
            // 
            this.totalnumericUpDown.DecimalPlaces = 2;
            this.totalnumericUpDown.Location = new System.Drawing.Point(247, 345);
            this.totalnumericUpDown.Name = "totalnumericUpDown";
            this.totalnumericUpDown.Size = new System.Drawing.Size(106, 20);
            this.totalnumericUpDown.TabIndex = 83;
            // 
            // SuperErrorProvider1
            // 
            this.SuperErrorProvider1.ContainerControl = this;
            // 
            // EliminarButton
            // 
            this.EliminarButton.Location = new System.Drawing.Point(257, 389);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(75, 33);
            this.EliminarButton.TabIndex = 84;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Location = new System.Drawing.Point(247, 55);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(57, 35);
            this.Buscarbutton.TabIndex = 85;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // DescripciontextBox
            // 
            this.DescripciontextBox.Location = new System.Drawing.Point(24, 93);
            this.DescripciontextBox.Name = "DescripciontextBox";
            this.DescripciontextBox.Size = new System.Drawing.Size(175, 20);
            this.DescripciontextBox.TabIndex = 86;
            this.DescripciontextBox.TextChanged += new System.EventHandler(this.DescripciontextBox_TextChanged);
            // 
            // RPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 427);
            this.Controls.Add(this.DescripciontextBox);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.totalnumericUpDown);
            this.Controls.Add(this.TipoCuentacomboBox);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.RemoverButton);
            this.Controls.Add(this.DetallePresupuestodataGridView);
            this.Controls.Add(this.Ventana_button);
            this.Controls.Add(this.Valor_numericUpDown);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.Fecha_dateTimePicker);
            this.Controls.Add(this.PresupuestoId_numericUpDown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RPresupuesto";
            this.Text = "RPresupuesto";
            this.Load += new System.EventHandler(this.RPresupuesto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DetallePresupuestodataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Valor_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PresupuestoId_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuperErrorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TipoCuentacomboBox;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button RemoverButton;
        private System.Windows.Forms.DataGridView DetallePresupuestodataGridView;
        private System.Windows.Forms.Button Ventana_button;
        private System.Windows.Forms.NumericUpDown Valor_numericUpDown;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.DateTimePicker Fecha_dateTimePicker;
        private System.Windows.Forms.NumericUpDown PresupuestoId_numericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown totalnumericUpDown;
        private System.Windows.Forms.ErrorProvider SuperErrorProvider1;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.TextBox DescripciontextBox;
    }
}