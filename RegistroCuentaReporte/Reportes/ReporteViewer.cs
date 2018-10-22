using RegistroCuentaReporte.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RegistroCuentaReporte.Reportes
{
    public partial class ReporteViewer : Form
    {
        private List<Presupuesto> lpresupuesto;
        public ReporteViewer(List<Presupuesto> presupuesto)
        {
            InitializeComponent();
        }

        private void PresupuestoCrystalReview_Load(object sender, EventArgs e)
        {
            Reporte listado = new Reporte();
            listado.SetDataSource(lpresupuesto);

            PresupuestoCrystalReview.ReportSource = listado;
            PresupuestoCrystalReview.Refresh();
        }
    }
}
