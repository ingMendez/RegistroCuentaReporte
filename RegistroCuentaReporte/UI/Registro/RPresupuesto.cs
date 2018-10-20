using RegistroCuentaReporte.BLL;
using RegistroCuentaReporte.DAL;
using RegistroCuentaReporte.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RegistroCuentaReporte.UI.Registro
{
    public partial class RPresupuesto : Form
    {
        public RPresupuesto()
        {
            InitializeComponent();
        }
        private void LlenarComboBox()
        {
            RepositorioBase<Cuentas> CuentaRepositorio = new RepositorioBase<Cuentas>(new Contexto());
            TipoCuentacomboBox.DataSource = CuentaRepositorio.GetList(c => true);
            TipoCuentacomboBox.ValueMember = "CuentaId";
            TipoCuentacomboBox.DisplayMember = "Descripcion";

        }

        private void Add_button_Click(object sender, EventArgs e)
       {
            List<DetallesPresupuestos> detalle = new List<DetallesPresupuestos>();

            if (DetallePresupuestodataGridView.DataSource != null)
            {
                detalle = (List<DetallesPresupuestos>)DetallePresupuestodataGridView.DataSource;
            }

            detalle.Add(new DetallesPresupuestos(
                id: 0,
                presupuestoid: (int)PresupuestoId_numericUpDown.Value,
                tipoCuentas: 10,//(int)TipoCuentacomboBox.SelectedValue,
                cuentaid: 10,//(int)CuentaidComboBox.SelectedValue,
                valor: (float)Convert.ToSingle(Valor_numericUpDown.Value)
                ));

            DetallePresupuestodataGridView.DataSource = null;
            DetallePresupuestodataGridView.DataSource = detalle;
            //  LlenarTotal();

        }

        private void TipoCuentacomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
          LlenarComboBox();
        }

        private void Ventana_button_Click(object sender, EventArgs e)
        {
            RCuentas rcuenta = new RCuentas();
            rcuenta.ShowDialog();
        }
    }
}
