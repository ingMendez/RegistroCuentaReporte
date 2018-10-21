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
        public int TipoId { get; set; }
        public double Monto{get; set;}

        public Cuentas()
        {
            CuentaId = 0;
            Descripcion = string.Empty;
            TipoId = 0;
            Monto = 0;

        }
    }
}
