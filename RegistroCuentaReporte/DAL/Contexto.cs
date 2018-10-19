using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using RegistroCuentaReporte.Entidades;

namespace RegistroCuentaReporte.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Cuentas> Cuenta { get; set; }

        public DbSet<Presupuesto> Presupuestos { get; set; }

        public DbSet<TiposCuentas> TiposCuentas { get; set; }

        public Contexto() : base("ConStr")
        {

        }

      
    }
}
