using RegistroCuentaReporte.DAL;
using RegistroCuentaReporte.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace RegistroCuentaReporte.BLL
{
        public class PresupuestoRepositorio : RepositorioBase<Presupuesto>
        {
            public PresupuestoRepositorio(Contexto contexto) : base(contexto)
            {

            }

            /* public override bool Guardar(Presupuesto presupuesto)
             {
                 foreach (var item in presupuesto.Detalle)
                 {
                     this.Acumular(item.TipoId,item.Monto);
                 }
                 bool paso = base.Guardar(presupuesto);

                 return paso;
             }*/

            public override Presupuesto Buscar(int id)
            {
                Presupuesto presupuesto = new Presupuesto();
                try
                {
                    presupuesto = _contexto.Presupuestos.Find(id);
                    presupuesto.Detalle.Count();

                    foreach (var item in presupuesto.Detalle)
                    {
                        int pre = item.Cuentas.CuentaId;
                        double p = item.Presupuesto.Descuento;



                    }
                    _contexto.Dispose();

                }
                catch (Exception)
                {
                    throw;
                }

                return presupuesto;
            }

            public override bool Modificar(Presupuesto entity)
            {
                bool paso = false;

                try
                {
                    foreach (var item in entity.Detalle)
                    {
                        var estado = item.Id > 0 ? EntityState.Modified : EntityState.Added;
                        _contexto.Entry(item).State = estado;
                    }
                    ///indica que se ha medificado
                    _contexto.Entry(entity).State = EntityState.Modified;

                    if (_contexto.SaveChanges() > 0)
                    {
                        paso = true;
                    }
                    _contexto.Dispose();
                }
                catch (Exception)
                {
                    throw;
                }
                return paso;
            }
        }

    
}
