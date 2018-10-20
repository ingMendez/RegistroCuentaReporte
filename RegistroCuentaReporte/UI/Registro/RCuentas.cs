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
    public partial class RCuentas : Form
    {
        public static int pas = 0;
        private RepositorioBase<Cuentas> repositorio;
        public RCuentas()
        {
            InitializeComponent();
            if (pas == 1)
            {
                LlenarComboBox();
            }
        }
        private void LlenarComboBox()
        {
            RepositorioBase<TiposCuentas> rTipoCuentas = new RepositorioBase<TiposCuentas>(new Contexto());
            TipoComboBox.DataSource = rTipoCuentas.GetList(x => true);
            TipoComboBox.ValueMember = "TipoCuentaId";
            TipoComboBox.DisplayMember = "Descripcion";
        }
        private void Limpiar()
        {
            CuentaIdnumericUpDown.Value = 0;
            DescripciontextBox.Text = string.Empty;
            // TipoComboBox.Text = string.Empty;
            MontoNumericUpDown.Value = 0;

        }
        private Cuentas LlenaClase()
        {
            Cuentas cuenta = new Cuentas();

            cuenta.CuentaId = Convert.ToInt32(CuentaIdnumericUpDown.Value);
            cuenta.Descripcion = DescripciontextBox.Text;
            cuenta.TipoId = (int)TipoComboBox.SelectedValue;
            cuenta.Monto = Convert.ToDouble(MontoNumericUpDown.Value);
            return cuenta;
        }

        private void LlenarCampo(Cuentas cuenta)
        {
            CuentaIdnumericUpDown.Value = cuenta.CuentaId;
            DescripciontextBox.Text = cuenta.Descripcion;
            TipoComboBox.SelectedIndex = cuenta.TipoId;
            MontoNumericUpDown.Value = Convert.ToDecimal(cuenta.Monto);
        }
        private void Buscarbutton_Click_1(object sender, EventArgs e)
        {
            int id;
            //= Convert.ToInt32(CuentaIdnumericUpDown.Value);
            repositorio = new RepositorioBase<Cuentas>(new Contexto());
            Cuentas cuentas = new Cuentas();
            int.TryParse(CuentaIdnumericUpDown.Text, out id);
            if (cuentas != null)
            {
                MessageBox.Show("Cuenta Encontrada.!!", "Exito!!!", MessageBoxButtons.OK);
                LlenarCampo(cuentas);
                //  DescripciontextBox.Text = cuentas.Descripcion;
                //MontoNumericUpDown.Text = cuentas.Monto.ToString();
            }
            else
            {
                MessageBox.Show("Cuenta no Encontrada", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NuevoButton_Click_1(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            repositorio = new RepositorioBase<Cuentas>(new Contexto());

            Cuentas cuenta;

            bool paso = false;
            cuenta = LlenaClase();

            if (!GuardarValidar())
            {
                return;
                /* MessageBox.Show("Favor revisar todos los campos", "Validación",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);*/
            }

            // cuenta = LlenaClase();

            if (CuentaIdnumericUpDown.Value >= 0)
            {
                paso = repositorio.Guardar(cuenta);
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede Modificar una cuenta no Existente", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //paso = BLL.CuentaBLL.Modificar(LlenaClase());
                paso = repositorio.Modificar(cuenta);

            }
            if (paso)
            {
                MessageBox.Show("Guardado", "Exito",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
            {

                MessageBox.Show("No se pudo guardar", "Falló",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private bool ExisteEnLaBaseDeDatos()
        {
            repositorio = new RepositorioBase<Cuentas>(new Contexto());
            // repositorio = new RepositorioBase<Cuentas>();
            Cuentas cuenta = repositorio.Buscar((int)CuentaIdnumericUpDown.Value);

            return (cuenta != null);
        }
        private bool GuardarValidar()
        {
            bool paso = true;
            if (string.IsNullOrEmpty(DescripciontextBox.Text))
            {
                MyErrorProvider.SetError(DescripciontextBox, "El Campo Descripcion esta Vacio");
                paso = false;
            }
            if (MontoNumericUpDown.Value == 0)
            {
                MyErrorProvider.SetError(MontoNumericUpDown, "El Campo Monto esta en 0");
                paso = false;
            }
            return paso;
        }

        private void TipoCuentasButton_Click_1(object sender, EventArgs e)
        {
            TipoCuentas tipoCuenta = new TipoCuentas();
            tipoCuenta.ShowDialog();
        }



        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int id;
            repositorio = new RepositorioBase<Cuentas>(new Contexto());
            ///Cuentas cuenta;
         //   bool paso = false;
            //cuenta = LlenaClase();
            int.TryParse(CuentaIdnumericUpDown.Text, out id);


            // int id = Convert.ToInt32(CuentaIdnumericUpDown.Value);

            // if (BLL.CuentaBLL.Eliminar(id))
            if (!ExisteEnLaBaseDeDatos())
            {
                MyErrorProvider.SetError(CuentaIdnumericUpDown, " esta Cuenta no Existe");
                CuentaIdnumericUpDown.Focus();
                return;

            }
            if (repositorio.Eliminar(id))
            {
                MessageBox.Show("Eliminado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CuentaIdnumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

       




        /*  private bool HayErrorres()
{
bool HayErrores = false;
if (String.IsNullOrWhiteSpace(DescripciontextBox.Text))
{
MyErrorProvider.SetError(DescripciontextBox, "Debes escribir una descricion para la cuenta");
HayErrores = true;
}
if (String.IsNullOrWhiteSpace(TipoCuentatextBox.Text)){
MyErrorProvider.SetError(TipoCuentatextBox, "debes escribi el tipo de cuentas");
HayErrores = true;
}

if (String.IsNullOrWhiteSpace(MontoNumericUpDown.Text)){
// MyErrorProvider.SetError(TipoCuentatextBox, "debes escribi el monto");
HayErrores = true;
}
return HayErrores;

}*/
    }
}
