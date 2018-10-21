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
        RepositorioBase<Presupuesto> repositorio;
        public List<DetallesPresupuestos>Detalle { get; set; }
        public RPresupuesto()
        {
            InitializeComponent();
            this.Detalle = new List<DetallesPresupuestos>();
            LlenarComboBox();
        }

        private void Limpiar()
        {
            PresupuestoId_numericUpDown.Value = 0;
            Fecha_dateTimePicker.Value = DateTime.Now;
            DescripciontextBox.Text =string.Empty;
            TipoCuentacomboBox.Text = string.Empty;
            Valor_numericUpDown.Value = 0;
            totalnumericUpDown.Value = 0 ;
            this.Detalle = new List<DetallesPresupuestos>();
            CargarGrid();
        }

        private void LlenaCampo(Presupuesto presupuesto)
        {
            //RepositorioBase<Presupuesto> repositorio = new RepositorioBase<Presupuesto>(new Contexto());
           PresupuestoId_numericUpDown.Value = presupuesto.PresupuestoId;
            DescripciontextBox.Text =presupuesto.Descripcion;
            Fecha_dateTimePicker.Value = presupuesto.Fecha;
             Valor_numericUpDown.Value =Convert.ToDecimal(presupuesto.Monto);

            this.Detalle = presupuesto.Presupuestos;
            CargarGrid();
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
                presupuesto.Descripcion = DescripciontextBox.Text; 
                presupuesto.Monto = Convert.ToDouble(Valor_numericUpDown.Value);
                presupuesto.Presupuestos = this.Detalle;
            return presupuesto;
            
        }

        private void Add_button_Click(object sender, EventArgs e)
       {
           // List<DetallesPresupuestos> detalle = new List<DetallesPresupuestos>();

            if (DetallePresupuestodataGridView.DataSource != null)
            {
               this.Detalle = (List<DetallesPresupuestos>)DetallePresupuestodataGridView.DataSource;
            }

            this.Detalle.Add(
                new DetallesPresupuestos(
                id: 0,
                presupuestoid: (int)PresupuestoId_numericUpDown.Value,
                Cuentaid: TipoCuentacomboBox.SelectedIndex,
                valor:Convert.ToDouble(Valor_numericUpDown.Value)
                ));
            SuperErrorProvider1.Clear();
            CargarGrid();
            ////DetallePresupuestodataGridView.DataSource = null;
           // DetallePresupuestodataGridView.DataSource = Detalle;
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
            LlenarComboBox();
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
            SuperErrorProvider1.Clear();
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
            if(string.IsNullOrWhiteSpace(DescripciontextBox.Text))
            {
                SuperErrorProvider1.SetError(DescripciontextBox, " debe llenar el campo");
                paso = false;
            }
            if (this.Detalle.Count == 0)
            {
                SuperErrorProvider1.SetError(DetallePresupuestodataGridView, "debe agregar algun presupuesto");
                paso = false;
            }
            return paso;
        }
        private void CargarGrid()
        {
            DetallePresupuestodataGridView.DataSource = null;
            DetallePresupuestodataGridView.DataSource =this.Detalle;

        }
        private void RemoverButton_Click(object sender, EventArgs e)
        {
            if (DetallePresupuestodataGridView.Rows.Count > 0 && DetallePresupuestodataGridView.CurrentRow != null)
            {
                Detalle.RemoveAt(DetallePresupuestodataGridView.CurrentRow.Index);
                CargarGrid();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            SuperErrorProvider1.Clear();
            int id;
            int.TryParse(PresupuestoId_numericUpDown.Text, out id);

            if (!ExisteEnBaseDeDatos())
            {
                SuperErrorProvider1.SetError(PresupuestoId_numericUpDown, "no se pudo eliminar una persona que no existen");
                return;
            }
            if (repositorio.Eliminar(id))
            {
                Limpiar();
                MessageBox.Show("Eliminado");
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            Presupuesto presupuesto = new Presupuesto();
            int.TryParse(PresupuestoId_numericUpDown.Text, out id);
            presupuesto = repositorio.Buscar(id);

            if (presupuesto != null)
            {
                MessageBox.Show("Persona Encontrada", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LlenaCampo(presupuesto);

            }
            else
            {
                MessageBox.Show("Persona no econtrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpiar();
            }
        }

        private void DescripciontextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RPresupuesto_Load(object sender, EventArgs e)
        {

        }
    }
}
