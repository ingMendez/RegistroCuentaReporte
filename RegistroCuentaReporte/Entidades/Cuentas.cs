using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace RegistroCuentaReporte.Entidades
{
   public class Cuentas
    {
        [Key]
        public int CuentaId { get; set; }
        public string Descripcion { get; set; }
        public int TipoId;
        public double Monto;

        public Cuentas()
        {
            CuentaId = 0;
            TipoId = 0;
            Descripcion = string.Empty;
            Monto = 0;

        }
    }
}
