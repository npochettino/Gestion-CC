using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{

    
    
    public class MarcaDatos
    {
        static private String strCadenaDeConexion = ConfigurationManager.ConnectionStrings["GestionCC"].ConnectionString;



        public void AgregarMarca(string strDescripcionMarca)
        {
            int Id_Marca = 0;

            try
            {
                SqlConnection conexion = new SqlConnection(strCadenaDeConexion);
                conexion.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = new SqlConnection(strCadenaDeConexion);
                sqlCommand.Connection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_ABMMarcas";

                sqlCommand.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = strDescripcionMarca;
                sqlCommand.Parameters.Add("@Id_Marca", SqlDbType.VarChar).Value = Id_Marca;
                sqlCommand.Parameters.Add("@Estado", SqlDbType.VarChar).Value = 'A';
                sqlCommand.ExecuteNonQuery();


                conexion.Close();

                

            }
            catch (Exception Ex)
            {
                Exception excepcionManejada = new Exception("Error al dar de Alta una Marca", Ex);
                throw excepcionManejada;
            }
                
        }

        public void ModificarMarca(string strDescripcionMarca, int Id_Marca)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(strCadenaDeConexion);
                conexion.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = new SqlConnection(strCadenaDeConexion);
                sqlCommand.Connection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_ABMMarcas";

                sqlCommand.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = strDescripcionMarca;
                sqlCommand.Parameters.Add("@Id_Marca", SqlDbType.VarChar).Value = Id_Marca;
                sqlCommand.Parameters.Add("@Estado", SqlDbType.VarChar).Value = 'M';
                sqlCommand.ExecuteNonQuery();


                conexion.Close();



            }
            catch (Exception Ex)
            {
                Exception excepcionManejada = new Exception("Error al dar de Alta una Marca", Ex);
                throw excepcionManejada;
            }
        }

        public void EliminarMarca(string strMarca, string strIdMarca)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(strCadenaDeConexion);
                conexion.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = new SqlConnection(strCadenaDeConexion);
                sqlCommand.Connection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_ABMMarcas";

                sqlCommand.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = strMarca;
                sqlCommand.Parameters.Add("@Id_Marca", SqlDbType.VarChar).Value = strIdMarca;
                sqlCommand.Parameters.Add("@Estado", SqlDbType.VarChar).Value = 'B';
                sqlCommand.ExecuteNonQuery();


                conexion.Close();



            }
            catch (Exception Ex)
            {
                Exception excepcionManejada = new Exception("Error al dar de Alta una Marca", Ex);
                throw excepcionManejada;
            }
        }
    }
}
