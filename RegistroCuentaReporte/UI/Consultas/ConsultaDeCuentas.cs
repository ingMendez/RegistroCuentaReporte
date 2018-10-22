using RegistroCuentaReporte.BLL;
using RegistroCuentaReporte.DAL;
using RegistroCuentaReporte.Entidades;
using RegistroCuentaReporte.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroCuentaReporte.UI.Consultas
{
    public partial class ConsultaDeCuentas : Form
    {
        public List<Presupuesto> lpresupuesto;
        public ConsultaDeCuentas()
        {
            InitializeComponent();
            FiltroComboBox.SelectedIndex = 0;
        }
        // codigo de la consulta
        private void Seleccion()
        {
            var repositorio = new RepositorioBase<Presupuesto>(new Contexto());
            var list = new List<Presupuesto>();
            errorProvider.Clear();
            if (CriterioTextBox.Text.Trim().Length >= 0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0:/// todo
                        list = repositorio.GetList(p => true);
                        break;
                    case 1:
                        if (!Validar())
                        {
                            return;
                        }
                        int id = Convert.ToInt32(CriterioTextBox.Text);
                        list = repositorio.GetList(p => p.PresupuestoId == id);
                        break;
                }

                list = list = list.Where(c => c.Fecha.Date >= DesdedateTimePicker.Value.Date && c.Fecha.Date <= HastadateTimePicker.Value.Date).ToList();

            }
            lpresupuesto = list;
            ConsultaVendedoresDataGridView.DataSource = lpresupuesto;
        }
        private void CriterioTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
                 {
                Seleccion();
                }
                if(FiltroComboBox.SelectedIndex == 1)
                 {
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                      if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
                       {
                        e.Handled = false;
                       }
                      else
                       {
                    //el resto de teclas pulsadas se desactivan
                         e.Handled = true;
                       }
                     return;
                }
            if (FiltroComboBox.SelectedIndex == 3 || FiltroComboBox.SelectedIndex == 4 || FiltroComboBox.SelectedIndex == 5)
            {
                String cadena = CriterioTextBox.Text;
                if (e.KeyChar == 8)
                {
                    e.Handled = false;
                    return;
                }
                bool IsDec = false;
                int nroDec = 0;

                for (int x = 0; x < CriterioTextBox.Text.Length; x++)
                {
                    if (CriterioTextBox.Text[x] == '.')
                    {
                        IsDec = true;
                    }
                    if (IsDec && nroDec++ >= 2)
                    {
                        e.Handled = true;
                        return;
                    }
                }
                if (e.KeyChar >= 48 && e.KeyChar <= 57)
                    e.Handled = false;
                else if (e.KeyChar == 46)
                    e.Handled = (IsDec) ? true : false;
                else
                    e.Handled = true;
            }
            else
            {
                //En caso que fuesemos a buscar por Nombres entonces si podremos Digitar Letras
                if (Char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }

            }
        }
      private bool Validar()
        {
            bool paso = true;

            if (CriterioTextBox.Text.FirstOrDefault() == '.')
            {
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(CriterioTextBox.Text))
            {
                errorProvider.SetError(CriterioTextBox, "digite un balor valido");
                paso = false;
            }

            return paso;

        }

        private void DesdedateTimePicker_ValueChanged(object sender, EventArgs e)
        {
           
                if (DesdedateTimePicker.Value.Date > HastadateTimePicker.Value.Date)
                    errorProvider.SetError(DesdedateTimePicker, "La Fecha del campo Hasta no puede ser menor que la del Campo Desde");
                else
                    errorProvider.Clear();
            
        }

        private void HastadateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (DesdedateTimePicker.Value.Date > HastadateTimePicker.Value.Date)
                errorProvider.SetError(HastadateTimePicker, "La Fecha del campo Desde no puede ser mayor que la del Campo Hasta");
            else
                errorProvider.Clear();
        }

        private void ConsultaButton_Click(object sender, EventArgs e)
        {
            Seleccion();
        }

        private void ConsultaVendedoresDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FiltroComboBox_TextChanged(object sender, EventArgs e)
        {
            CriterioTextBox.Text = "";
            ConsultaVendedoresDataGridView.DataSource = null;


        }

        private void ImprimrButton_Click(object sender, EventArgs e)
        {
            if ( lpresupuesto.Count == 0)
            {
                MessageBox.Show("No hay Datos para Imprimir");
                return;
            }

            ReporteViewer reporteViewer = new ReporteViewer(lpresupuesto);
            reporteViewer.ShowDialog();
        }
    }
}
