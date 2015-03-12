using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace dam2t_orm
{
    static class BdErrores
    {
         static public string Mensaje (SqlException ex)
        {
            string mensaje;

            switch (ex.Number)
            {
                case 547:
                    mensaje = "No se puede borrar, tiene datos relacionados";
                    break;
                case 2601:
                    mensaje = "Datos duplicados";
                    break;
                case 2627:
                    mensaje = "Datos duplicados";
                    break;
                default:
                    mensaje = ex.Number + " - " + ex.Message;
                    break;
            }
            return (mensaje);
        }
    }
}
