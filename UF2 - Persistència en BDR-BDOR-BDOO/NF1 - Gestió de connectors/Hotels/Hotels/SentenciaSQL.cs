using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;    // Per a les connexions amb la Base de Dades
using System.Data;              // Per a els tipus de dades DataTable

namespace Hotels
{
    static class SentenciaSQL
    {
        static SqlConnection connexio = new SqlConnection("Data Source=(local)\\sqlexpress2014;Initial Catalog=hoteles_basico;Persist Security Info=True;User ID=sa;Password=sqlserver");

        /**
         *  Permet obtenir els registres d'una taula passant com a paràmetre el nom d'aquesta
         */
        static public DataTable obtenirTaula(string nomTaula)
        {
            SqlCommand sentencia = new SqlCommand();
            SqlDataReader dades;

            DataTable taula = new DataTable();

            // Les dades de connexió a BDD que utilitzará la comanda SQL
            sentencia.Connection = connexio;
            sentencia.CommandText = "select * from " + nomTaula;

            // S'obre una connexió a la BDD
            connexio.Open();

            // Executa la sentencia SQL passant-la a la BDD abans definida i retorna un DataReader
            dades = sentencia.ExecuteReader();

            // Omple el DataTable amb les dades obtingudes de la BDD
            taula.Load(dades);
            
            // Es tanquen les connexions obertes a la BDD
            dades.Close();
            connexio.Close();

            return taula;
        }
    }
}
