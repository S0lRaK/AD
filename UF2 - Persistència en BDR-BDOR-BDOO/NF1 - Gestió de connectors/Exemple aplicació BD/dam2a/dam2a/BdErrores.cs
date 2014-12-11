using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace dam2a
{
    static class BdErrores
    {
        static public string MensajeError (SqlException ex)
        {
            string mensaje = "";

            switch (ex.Number)
            {
                case 53:
                    mensaje = "No se puede conectar con el servidor";
                    break;
                case 2627:
                    mensaje = "Registro duplicado";
                    break;
                case 4060:
                    mensaje = "BD incorrecta";
                    break;
                case 18456:
                    mensaje = "Usuario o contraseña incorrecta";
                    break;
                default:
                    mensaje = ex.Number + " - " + ex.Message;
                    break;
            }

            return mensaje;
        }
    }
}
