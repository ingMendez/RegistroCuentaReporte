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

        //  [StringLength(100)]
        public string Descripcion { get; set; }
        //  [foreign]
        public float Monto { get; set; }

        public virtual List<DetallesPresupuestos> Detalle { get; set; }

        public Presupuesto()
        {
            PresupuestoId = 0;
            Fecha = DateTime.Now;
            Descripcion = string.Empty;
            Monto = 0;
        }

        /*   public Presupuesto()
           {
               this.Detalle = new List<DetallesPresupuestos>();
           }*/

        /* public void agregarDetalle(int id,int PresupuestoId,int CuentaId,int TipoCuentaId,float Valor)
         {
             this.Detalle.Add(new DetallesPresupuestos(id, PresupuestoId, CuentaId, TipoCuentaId, Valor));
         }*/
    }
}
