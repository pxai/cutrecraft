// TODO meter comentarios
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace CutreCraft
{
    class AccesoDatos
    {

        public static void pruebaAcceso()
        {
            SqlConnection miConexion = new SqlConnection("user id=odio;" +
                                           "password=dolorinfinito;server=localhost;" +
                                           "Trusted_Connection=yes;" +
                                           "database=sqlclase; " +
                                           "connection timeout=30");
            try
            {
                miConexion.Open();
                SqlCommand miComando = new SqlCommand("Select * from Ciudades", miConexion);
                SqlDataReader dataReader = miComando.ExecuteReader();
                while (dataReader.Read())
                {
                    Log.log(dataReader["Nombre"].ToString());
                    Log.log(dataReader["Población"].ToString());
                }
            }
            catch (Exception e)
            {
                Log.log(e.ToString());
            }
        }


        public static void pruebaModificacion()
        {
            SqlConnection miConexion = new SqlConnection("user id=odio;" +
                                           "password=dolorinfinito;server=localhost;" +
                                           "Trusted_Connection=yes;" +
                                           "database=sqlclase; " +
                                           "connection timeout=30");

            string sql = "update ciudades set Población=Población + 666";
            try
            {
                miConexion.Open();
                SqlCommand miComando = new SqlCommand(sql, miConexion);
                int filasAfectadas = miComando.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                Log.log(e.ToString());
            }
        }
    }

 
}
