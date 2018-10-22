namespace RegistroCuentaReporte.UI.Consultas
{
    partial class ConsultaDeCuentas
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
            this.ImprimrButton = new System.Windows.Forms.Button();
            this.ConsultaVendedoresDataGridView = new System.Windows.Forms.DataGridView();
            this.ConsultaButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.CriterioTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FiltroComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.HastadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DesdedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaVendedoresDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // ImprimrButton
            // 
            this.ImprimrButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ImprimrButton.Location = new System.Drawing.Point(12, 370);
            this.ImprimrButton.Margin = new System.Windows.Forms.Padding(2);
            this.ImprimrButton.Name = "ImprimrButton";
            this.ImprimrButton.Size = new System.Drawing.Size(89, 34);
            this.ImprimrButton.TabIndex = 22;
            this.ImprimrButton.Text = "Imprimir";
            this.ImprimrButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ImprimrButton.UseVisualStyleBackColor = true;
            this.ImprimrButton.Click += new System.EventHandler(this.ImprimrButton_Click);
            // 
            // ConsultaVendedoresDataGridView
            // 
            this.ConsultaVendedoresDataGridView.ColumnHeadersHeight = 30;
            this.ConsultaVendedoresDataGridView.Location = new System.Drawing.Point(2, 99);
            this.ConsultaVendedoresDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.ConsultaVendedoresDataGridView.Name = "ConsultaVendedoresDataGridView";
            this.ConsultaVendedoresDataGridView.ReadOnly = true;
            this.ConsultaVendedoresDataGridView.RowTemplate.Height = 24;
            this.ConsultaVendedoresDataGridView.Size = new System.Drawing.Size(535, 264);
            this.ConsultaVendedoresDataGridView.TabIndex = 21;
            this.ConsultaVendedoresDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ConsultaVendedoresDataGridView_CellContentClick);
            // 
            // ConsultaButton
            // 
            this.ConsultaButton.Location = new System.Drawing.Point(305, 39);
            this.ConsultaButton.Margin = new System.Windows.Forms.Padding(2);
            this.ConsultaButton.Name = "ConsultaButton";
            this.ConsultaButton.Size = new System.Drawing.Size(89, 25);
            this.ConsultaButton.TabIndex = 20;
            this.ConsultaButton.Text = "Consulta";
            this.ConsultaButton.UseVisualStyleBackColor = true;
            this.ConsultaButton.Click += new System.EventHandler(this.ConsultaButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Criterio";
            // 
            // CriterioTextBox
            // 
            this.CriterioTextBox.Location = new System.Drawing.Point(134, 44);
            this.CriterioTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.CriterioTextBox.Name = "CriterioTextBox";
            this.CriterioTextBox.Size = new System.Drawing.Size(143, 20);
            this.CriterioTextBox.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Filtro";
            // 
            // FiltroComboBox
            // 
            this.FiltroComboBox.DisplayMember = "0";
            this.FiltroComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltroComboBox.FormattingEnabled = true;
            this.FiltroComboBox.Items.AddRange(new object[] {
            "Todos",
            "ID"});
            this.FiltroComboBox.Location = new System.Drawing.Point(23, 43);
            this.FiltroComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.FiltroComboBox.Name = "FiltroComboBox";
            this.FiltroComboBox.Size = new System.Drawing.Size(89, 21);
            this.FiltroComboBox.TabIndex = 16;
            this.FiltroComboBox.ValueMember = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Hasta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Desde";
            // 
            // HastadateTimePicker
            // 
            this.HastadateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.HastadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HastadateTimePicker.Location = new System.Drawing.Point(265, 72);
            this.HastadateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.HastadateTimePicker.Name = "HastadateTimePicker";
            this.HastadateTimePicker.Size = new System.Drawing.Size(89, 20);
            this.HastadateTimePicker.TabIndex = 13;
            this.HastadateTimePicker.ValueChanged += new System.EventHandler(this.HastadateTimePicker_ValueChanged);
            // 
            // DesdedateTimePicker
            // 
            this.DesdedateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.DesdedateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DesdedateTimePicker.Location = new System.Drawing.Point(62, 72);
            this.DesdedateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.DesdedateTimePicker.Name = "DesdedateTimePicker";
            this.DesdedateTimePicker.Size = new System.Drawing.Size(89, 20);
            this.DesdedateTimePicker.TabIndex = 12;
            this.DesdedateTimePicker.ValueChanged += new System.EventHandler(this.DesdedateTimePicker_ValueChanged);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // ConsultaDeCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 415);
            this.Controls.Add(this.ImprimrButton);
            this.Controls.Add(this.ConsultaVendedoresDataGridView);
            this.Controls.Add(this.ConsultaButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CriterioTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FiltroComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HastadateTimePicker);
            this.Controls.Add(this.DesdedateTimePicker);
            this.Name = "ConsultaDeCuentas";
            this.Text = "ConsultaDeCuentas";
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaVendedoresDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ImprimrButton;
        private System.Windows.Forms.DataGridView ConsultaVendedoresDataGridView;
        private System.Windows.Forms.Button ConsultaButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CriterioTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox FiltroComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker HastadateTimePicker;
        private System.Windows.Forms.DateTimePicker DesdedateTimePicker;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}