using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace RegistroCuentaReporte.Entidades
{
    public class Presupuesto
    {
        [Key]
        public int PresupuestoId { get; set; }

        public DateTime Fecha { get; set; }

        public Double Monto { get; set; }

        public String Descripcion { get; set; }

        public virtual List<DetallesPresupuestos> Presupuestos { get; set; }

        public Presupuesto()
        {
            PresupuestoId = 0;
            Fecha = DateTime.Now;
            Descripcion = string.Empty;
            Monto = 0;
            Presupuestos = new List<DetallesPresupuestos>();
        }
    }
}
