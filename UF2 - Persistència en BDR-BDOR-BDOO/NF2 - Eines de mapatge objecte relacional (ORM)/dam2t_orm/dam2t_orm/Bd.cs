using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;

namespace dam2t_orm
{
    static class Bd
    {
        static hoteles_basicoEntities contexto = new hoteles_basicoEntities();

        public static List<hoteles> HotelesSelect()
        {
            List<hoteles> _hoteles =
                (from h in contexto.hoteles.Include("ciudades")
                 select h).ToList();

            return _hoteles;

        }
        public static List<ciudades> CiudadesSelect()
        {
            List<ciudades> _ciudades =
                (from c in contexto.ciudades
                 select c).ToList();

            return _ciudades;

        }
        public static ciudades CiudadesSelectPorId(int id_ciudad)
        {
            ciudades _ciudad =
                (from c in contexto.ciudades.Include("hoteles")
                 where c.id_ciudad == id_ciudad
                 select c).FirstOrDefault();
            
            return _ciudad;

        }

        public static string CiudadInsert(int id_ciudad, string nombre)
        {
            string mensaje = "";

            ciudades c = new ciudades();

            c.id_ciudad = id_ciudad;
            c.nombre = nombre;

            contexto.ciudades.Add(c);
            try
            {
                contexto.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                SqlException sqlEx = (SqlException) ex.InnerException.InnerException;
                mensaje = BdErrores.Mensaje(sqlEx);
            }



            return mensaje;

        }
        public static string CiudadDelete(int id_ciudad)
        {
            string mensaje = "";

            ciudades c = CiudadesSelectPorId(id_ciudad);

            contexto.ciudades.Remove(c);

            try
            {
                contexto.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                SqlException sqlEx = (SqlException)ex.InnerException.InnerException;
                mensaje = BdErrores.Mensaje(sqlEx);
            }



            return mensaje;

        }
        public static string CiudadUpdate(int id_ciudad, string nombre)
        {
            string mensaje = "";

            ciudades c = CiudadesSelectPorId(id_ciudad);

            c.nombre = nombre;

            try
            {
                contexto.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                SqlException sqlEx = (SqlException)ex.InnerException.InnerException;
                mensaje = BdErrores.Mensaje(sqlEx);
            }

            return mensaje;

        }


    }
}
