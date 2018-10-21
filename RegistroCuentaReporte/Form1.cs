using RegistroCuentaReporte.Entidades;
using RegistroCuentaReporte.UI.Registro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RegistroCuentaReporte
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void registroPresupuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RPresupuesto rp = new RPresupuesto();
             rp.Show();
            
        }

        private void registroDeCuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RCuentas rc = new RCuentas();
            rc.Show();
        }

        private void tiposCuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipoCuentas tc = new TipoCuentas();
            tc.Show();
        }
    }
}
