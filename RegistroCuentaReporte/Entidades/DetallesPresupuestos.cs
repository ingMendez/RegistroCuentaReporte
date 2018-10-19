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
        public int Id { get; set; }

        public int PresupuestoId { get; set; }

        public int CuentaId { get; set; }

        public int TipoCuentaId { get; set; }

        public float Valor { get; set; }

        [ForeignKey("CuentaId")]
        public virtual Cuentas Cuentas { get; set; }

        [ForeignKey("PresupuestoId")]
        public virtual Presupuesto Presupuesto { get; set; }
        [ForeignKey("TipoCuentaId")]
        public virtual TiposCuentas TiposCuentas { get; set; }

        public DetallesPresupuestos()
        {
            this.Id = 0;
            this.PresupuestoId = 0;
            this.CuentaId = 0;
            this.TipoCuentaId = 0;
            this.Valor = 0;
        }
        public DetallesPresupuestos(int id, int presupuestoid, int cuentaid, int tipoCuentas, float valor)
        {
            Id = id;
            PresupuestoId = presupuestoid;
            CuentaId = cuentaid;
            TipoCuentaId = tipoCuentas;
            Valor = valor;
        }

        public override string ToString()
        {
            return "Cuenta:" + this.CuentaId.ToString() + ":Valor" + this.Valor;
        }


    }
}
