using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace RegistroCuentaReporte.Entidades
{
    public class TiposCuentas
    {
        [Key]
        public int TipoCuentaId { get; set; }
        public string Descripcion { get; set; }

        public TiposCuentas()
        {
            TipoCuentaId = 0;
            Descripcion = string.Empty;
        }
        /**  public TiposCuentas(int tipoCuenta,string descripcion)
          {
              TipoCuentaId = tipoCuenta;
              Descripcion = descripcion;
          }*/
    }
}
