using RegistroCuentaReporte.DAL;
using RegistroCuentaReporte.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace RegistroCuentaReporte.BLL
{
    public class PresupuestoBLL
    {
        public static bool Guardar(Presupuesto presupuesto)
        {
            bool paso = false;
            // creamos una instancia del contexto para poder con la base de datos
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Presupuestos.Add(presupuesto) != null)
                {
                    foreach (var item in presupuesto.Presupuestos)
                    {
                        contexto.Cuenta.Find(item.CuentaId).Monto -= item.Valor;
                    }
                    contexto.SaveChanges(); // gurdar los cambien la base de datos
                    paso = true;
                }
                contexto.Dispose(); //// para serrar la conexion
            }
            catch (Exception)
            {
                throw;
            }
            return paso;

        }
        /// <summary>
        /// Permite modificar una entidad en la base de datos
        /// </summary>
        /// <param name="cuenta"></param>
        /// <returns> retuna true si modifico y false si no </returns>
        public static bool Modificar(Presupuesto presupuesto)
        {
            bool paso = false;
            // creamos una instancia del contexto para poder con la base de datos

            Contexto contexto = new Contexto();
            try
            {
                var MontoAterior = PresupuestoBLL.Buscar(presupuesto.PresupuestoId);

                foreach (var item in MontoAterior.Presupuestos)
                {
                    if (!presupuesto.Presupuestos.Exists(d => d.PresupuestoId == item.PresupuestoId))
                        contexto.Entry(item).State = EntityState.Deleted;
                    contexto.Cuenta.Find(item.CuentaId).Monto -= item.Valor;
                }
                foreach (var item in presupuesto.Presupuestos)
                {
                    var estado = (item.PresupuestoId == 0) ? EntityState.Added : EntityState.Modified;
                    contexto.Entry(item).State = estado;
                }
                contexto.Entry(presupuesto).State = EntityState.Modified;
                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }

                // serrar la conexion.
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }
        /// <summary>
        /// permite eliminar una entidad en la base de datos
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool Eliminar(int id)
        {

            bool paso = false;

            Contexto contexto = new Contexto();
            try
            {
                Presupuesto presupuesto = contexto.Presupuestos.Find(id);

                foreach (var item in presupuesto.Presupuestos)
                {
                    var cuentas = contexto.Cuenta.Find(item.CuentaId);
                    cuentas.Monto -= item.Valor;

                }

                contexto.Presupuestos.Remove(presupuesto);
                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }
        /// <summary>
        /// permite buscar una cuenta en la entidad
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Presupuesto Buscar(int id)
        {

            Contexto contexto = new Contexto();
            Presupuesto presupuesto = new Presupuesto();
            try
            {
                presupuesto = contexto.Presupuestos.Find(id);
                presupuesto.Presupuestos.Count();
                /* if (presupuesto != null)
                 {
                     //Cargar la lista en este punto porque
                     //luego de hacer Dispose() el Contexto 
                     //no sera posible leer la lista
                     presupuesto.Presupuestos.Count();
                     //Cargar las Descripcion
                     //Cargar el Nombre Descripcion
                     foreach (var item in presupuesto.Detalle)
                     {
                         //forzando la Descripcion y Nombres a cargarse
                         string s = item.Cuentas.Descripcion;
                         string ss = item.TiposCuentas.Descripcion;
                     }
                 }*
                 contexto.Dispose();
             */
            }
            catch (Exception)
            {
                throw;
            }
            return presupuesto;
        }

        ///<summary>
        ///Permite extraer una lista de cuenta de la Base de Datos.
        ///</summary>
        ///<param name="expression">Expresión Lambda conteniendo los filtros de búsqueda</param>
        ///<returns>Retorna una lista de cuenta</returns>

        public static List<Presupuesto> GetList(Expression<Func<Presupuesto, bool>> expression)
        {
            List<Presupuesto> presupuestos = new List<Presupuesto>();
            Contexto contexto = new Contexto();
            try
            {
                presupuestos = contexto.Presupuestos.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return presupuestos;
        }

    }
}
