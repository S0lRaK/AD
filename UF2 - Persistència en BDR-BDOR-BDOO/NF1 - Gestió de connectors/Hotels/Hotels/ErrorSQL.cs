using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;    // Per a captar les excepcions que produeix SQL

namespace Hotels
{
    static class ErrorSQL
    {
        static public String mostrarMissatge(SqlException excepcio)
        {
            String missatge = "";

            /*
             * Cada excepció es identificada per un número concret
             * que es utilitzat per mostrar un missatge personalitzat
             */
            switch(excepcio.Number)
            {
                case 4060:
                    missatge = "Base de Dades no trobada.";
                    break;
                default:
                    missatge = excepcio.Number + ": " + excepcio.Message;
                    break;
            }

            return missatge;
        }
    }
}
