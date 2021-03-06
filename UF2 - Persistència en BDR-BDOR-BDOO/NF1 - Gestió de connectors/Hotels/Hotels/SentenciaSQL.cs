﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;    // Per a les connexions amb la Base de Dades
using System.Data;              // Per a els tipus de dades DataTable
using System.Windows.Forms;     // Per a els MessageBox (mostrar errors)

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

            try
            {
                // S'obre una connexió a la BDD
                connexio.Open();

                // Executa la sentencia SQL passant-la a la BDD abans definida i retorna un DataReader
                dades = sentencia.ExecuteReader();

                // Omple el DataTable amb les dades obtingudes de la BDD
                taula.Load(dades);
            
                // Es tanquen les connexions obertes a la BDD
                dades.Close();
                connexio.Close();
            }
            catch(SqlException excepcio)
            {
                String missatge = ErrorSQL.mostrarMissatge(excepcio);
                MessageBox.Show(missatge);
            }

            return taula;
        }

        /**
         *  Permet obtenir els hotels corresponents a una ciutat concreta,
         *  que serà l'indicada a ComboBoxCiutat per SelectedValue
         */
        static public DataTable obtenirHotelsDeCiutat(int idCiutat)
        {
            SqlCommand sentencia = new SqlCommand();
            SqlDataReader dades;

            DataTable taula = new DataTable();
            //string missatge = "";

            sentencia.Connection = connexio;
            sentencia.CommandText = "SELECT id_ciudad AS 'ID Ciutat'," +
                                            "nombre AS Nom," +
                                            "categoria AS Categoria," +
                                            "direccion AS Adreça," +
                                            "telefono AS Telèfon," +
                                            "tipo AS Tipus," +
                                            "cif AS CIF " +
                                    "FROM hoteles " +
                                    "WHERE id_ciudad = @id";

            // Es neteja qualsevol paràmetre previ i s'afegeix el que relaciona les dues taules
            sentencia.Parameters.Clear();
            sentencia.Parameters.AddWithValue("@id", idCiutat);
            
            try
            {
                connexio.Open();
                dades = sentencia.ExecuteReader();

                taula.Load(dades);

                connexio.Close();
            }
            catch (SqlException excepcio)
            {
                String missatge = ErrorSQL.mostrarMissatge(excepcio);
                MessageBox.Show(missatge);
            }

            return taula;
        }

        /**
         * Busca referencies d'un registre a altres taules de la BDD
         * retornant 'true' si n'ha trobat
         */
        //static public Boolean buscarRegistreRelacionat()
        //{

        //}
    }
}
