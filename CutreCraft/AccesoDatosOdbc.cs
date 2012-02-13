using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Data.SqlClient;
using System.Data.Odbc;

namespace CutreCraft
{
    class AccesoDatosOdbc
    {

        public static void pruebaAcceso()
        {
          string cadenaConexion;
        OdbcConnection conexion;
        OdbcCommand sentencia;
        OdbcDataReader resultset;
        bool existe = false;

        string consulta = "select * from PRODUCTOS";
        cadenaConexion = "DSN=superbasededatos;";

        // Creamos la instancia del objeto pasándole el string de conexion
        conexion = new OdbcConnection(cadenaConexion);

        // Abrimos la conexion
        conexion.Open();

        // Creamos la instancia del objeto para ejecutar comandos
        sentencia = new OdbcCommand(consulta, conexion);


        // Y la ejecutamos
        resultset = sentencia.ExecuteReader();

        while (resultset.Read())
        {
            Log.log(resultset.GetInt32(0) +"," + resultset.GetString(1));
        }

        // Cerramos la conexion con la BD
        conexion.Close();


        
    }
        }
    }

 
