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
    public partial class TipoCuentas : Form
    {      
       private RepositorioBase<TiposCuentas> repositorio;
        public TipoCuentas()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            errorProviderTipo.Clear();
            TipoIDnumericUpDown.Value = 0;
            DescripciontextBox.Text = string.Empty;
        }

        private TiposCuentas LlenaClase()
        {
            TiposCuentas tipoCuentas = new TiposCuentas()
            {
                TipoCuentaId = Convert.ToInt32(TipoIDnumericUpDown.Value),
                Descripcion = DescripciontextBox.Text
            };
            return tipoCuentas;
        }

        private void LlenaCampo(TiposCuentas tipoCuentas)
        {
            TipoIDnumericUpDown.Value = tipoCuentas.TipoCuentaId;
            DescripciontextBox.Text = tipoCuentas.Descripcion;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            repositorio = new RepositorioBase<TiposCuentas>(new Contexto());
            TiposCuentas tipoCuentas = repositorio.Buscar((int)TipoIDnumericUpDown.Value);
            return (tipoCuentas != null);
        }

        private bool GuardarValidar()
        {
            bool paso = true;
            if (string.IsNullOrEmpty(DescripciontextBox.Text))
            {
                errorProviderTipo.SetError(DescripciontextBox, "El Campo Descripcion No puede Estar Vacio!");
                DescripciontextBox.Focus();
                paso = false;
            }
            return paso;
        }

        private void GuardarButton_Click_1(object sender, EventArgs e)
        {
            repositorio = new RepositorioBase<TiposCuentas>(new Contexto());
            TiposCuentas tipoCuentas;
            bool paso = false;
            tipoCuentas = LlenaClase();
            if (!GuardarValidar())
                return;
            if (TipoIDnumericUpDown.Value == 0)
                paso = repositorio.Guardar(tipoCuentas);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede Modificar un Tipo de cuenta no Existente", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = repositorio.Modificar(tipoCuentas);
            }
            if (paso)
            {
                MessageBox.Show("Guardado!!", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RCuentas.pas = 1;
                Limpiar();
            }
            else
                MessageBox.Show("No se Guardo el Tipo De Cuenta!!", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id;
            repositorio = new RepositorioBase<TiposCuentas>(new Contexto());
            int.TryParse(TipoIDnumericUpDown.Text, out id);
            TiposCuentas tipoCuentas = new TiposCuentas();
            tipoCuentas = repositorio.Buscar(id);

            if (tipoCuentas != null)
            {
                MessageBox.Show("Tipo de Cuenta Encontrada.!!", "Exito!!!", MessageBoxButtons.OK);
                LlenaCampo(tipoCuentas);
            }
            else
                MessageBox.Show("Tipo de Cuenta no Encontrada", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            int id;
            repositorio = new RepositorioBase<TiposCuentas>(new Contexto());
            int.TryParse(TipoIDnumericUpDown.Text, out id);
            if (!ExisteEnLaBaseDeDatos())
            {
                errorProviderTipo.SetError(TipoIDnumericUpDown, "Esta Cuenta No Existe");
                TipoIDnumericUpDown.Focus();
                return;
            }
            if (repositorio.Eliminar(id))
            {
                MessageBox.Show("Tipo De Cuenta Eliminada!!", "Exitoso!!!", MessageBoxButtons.OK);
                Limpiar();
            }
            else
                MessageBox.Show("No se pudo eliminar El Tipo De Cuenta!!", "Fallo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void DescripciontextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
