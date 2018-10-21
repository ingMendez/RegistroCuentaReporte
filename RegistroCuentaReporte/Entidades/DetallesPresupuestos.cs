using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace RegistroCuentaReporte.Entidades
{
    public class DetallesPresupuestos
    {
        [Key]
        public int PresupuestoDetalleId { get; set; }

        public int PresupuestoId { get; set; }

        public int  CuentaId { get; set; }

        public Double Total { get; set; }

        public Double Valor { get; set; }

        /*[ForeignKey("CuentaId")]
        public virtual Cuentas Cuentas { get; set; }

        [ForeignKey("PresupuestoId")]
        public virtual Presupuesto Presupuesto { get; set; }
        [ForeignKey("TipoCuentaId")]
        public virtual TiposCuentas TiposCuentas { get; set; }
        */
        public DetallesPresupuestos()
        {
            PresupuestoDetalleId = 0;
            PresupuestoId = 0;
            CuentaId = 0;
            Valor = 0;
            Total = 0;
        }
        public DetallesPresupuestos(int id, int presupuestoid, int Cuentaid, Double valor)
        {
            this.PresupuestoDetalleId = id;
            this.PresupuestoId = presupuestoid;
            this.CuentaId =CuentaId;
            this.Valor = valor;
            //this.Total = total;
        }

       /* public override string ToString()
        {
            return "Cuenta:" + this.Descuento.ToString() + ":Valor" + this.Valor;
        }*/


    }
}
