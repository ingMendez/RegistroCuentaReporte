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
        private RepositorioBase<Presupuesto> repositorio;
        public List<DetallesPresupuestos>Detalle { get; set; }
        public RPresupuesto()
        {
            InitializeComponent();
            this.Detalle = new List<DetallesPresupuestos>();
        }
        private void Limpiar()
        {
            PresupuestoId_numericUpDown.Value = 0;
            Fecha_dateTimePicker.Value = DateTime.Now;
            Descuento_numericUpDown.Value = 0;
            TipoCuentacomboBox.Text = " ";
            Valor_numericUpDown.Value = 0;
            totalnumericUpDown.Value = 0 ;

        }
        private void LlenarComboBox()
        {
            RepositorioBase<Cuentas> CuentaRepositorio = new RepositorioBase<Cuentas>(new Contexto());
            TipoCuentacomboBox.DataSource = CuentaRepositorio.GetList(c => true);
            TipoCuentacomboBox.ValueMember = "CuentaId";
            TipoCuentacomboBox.DisplayMember = "Descripcion";

        }
        private Presupuesto LlenaClase()
        {
            Presupuesto presupuesto = new Presupuesto();
                presupuesto.PresupuestoId = Convert.ToInt32(PresupuestoId_numericUpDown.Value);
                presupuesto.Fecha = Fecha_dateTimePicker.Value;
                presupuesto.Descuento = Convert.ToInt32(Descuento_numericUpDown.Value);
                presupuesto.TiposCuentas = (int)TipoCuentacomboBox.SelectedValue;
                presupuesto.valor = Convert.ToInt32(Valor_numericUpDown.Value);
                presupuesto.Monto = Convert.ToInt32(totalnumericUpDown.Value);
                return presupuesto;
            
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

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            repositorio = new RepositorioBase<Presupuesto>(new Contexto());
            Presupuesto presupuesto;
            bool paso = false;
            presupuesto = LlenaClase();
            if (!GuardarValidar())
            {
                return;
            }
            if(PresupuestoId_numericUpDown.Value == 0)
            {
                paso = repositorio.Guardar(presupuesto);
            }
            else
            {
                if (!ExisteEnBaseDeDatos())
                {
                    MessageBox.Show("no se puede modificar una cuenta que no existe", "fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                       return;
                }
                paso = repositorio.Modificar(presupuesto);
            }
            if (paso)
            {
                MessageBox.Show("Guardado", "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
            {
                MessageBox.Show("no se puede guardar", "fallO",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
        private bool ExisteEnBaseDeDatos()
        {
            repositorio = new RepositorioBase<Presupuesto>(new Contexto());
            Presupuesto presupuesto = repositorio.Buscar((int)PresupuestoId_numericUpDown.Value);
            return (presupuesto != null);
        }
        private bool GuardarValidar()
        {
            bool paso = true;
            if(Valor_numericUpDown.Value == 0)
            {
                SuperErrorProvider1.SetError(Valor_numericUpDown, "el campo esta vacio");
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(TipoCuentacomboBox.SelectedIndex.ToString()))
            {
                SuperErrorProvider1.SetError(TipoCuentacomboBox, "debe elegir uno");
                paso = false;
            }
            if(Descuento_numericUpDown.Value ==0)
            {
                SuperErrorProvider1.SetError(Descuento_numericUpDown, " debe llenar el campo");
                paso = false;
            }
            if (Fecha_dateTimePicker.Value < DateTime.Now || Fecha_dateTimePicker.Value > DateTime.Now) 
            {
                SuperErrorProvider1.SetError(Fecha_dateTimePicker, "digite una valida");
                paso = false;
            }
            if (this.Detalle.Count == 0)
            {
                SuperErrorProvider1.SetError(DetallePresupuestodataGridView, "dee agregar algun presupuesto");
                paso = false;
            }
            return paso;
        }

    }
}
