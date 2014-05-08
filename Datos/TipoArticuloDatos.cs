using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
   public class TipoArticuloDatos
    {

       static private String strCadenaDeConexion = ConfigurationManager.ConnectionStrings["GestionCC"].ConnectionString;
       
       
       public void AgregarTipoArticulo(string DescripcionTipoArticulo)
        {
            int Id_TipoArticulo = 0;

            try
            {
                SqlConnection conexion = new SqlConnection(strCadenaDeConexion);
                conexion.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = new SqlConnection(strCadenaDeConexion);
                sqlCommand.Connection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_ABMTipoArticulos";

                sqlCommand.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = DescripcionTipoArticulo;
                sqlCommand.Parameters.Add("@Id_TipoArticulo", SqlDbType.VarChar).Value = Id_TipoArticulo;
                sqlCommand.Parameters.Add("@Estado", SqlDbType.VarChar).Value = 'A';
                sqlCommand.ExecuteNonQuery();
                

                conexion.Close();

                // MessageBox.Show("Se actualizaron los saldos correctamente", "Inicializar Saldos", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception Ex)
            {
                Exception excepcionManejada = new Exception("Error al dar de Alta un Cliente", Ex);
                throw excepcionManejada;
            }
                
                
        }

       public void ModificarTipoArticulo(string DescripcionTipoArticulo, int Id_TipoArticulo)
       {
           

           try
           {
               SqlConnection conexion = new SqlConnection(strCadenaDeConexion);
               conexion.Open();

               SqlCommand sqlCommand = new SqlCommand();
               sqlCommand.Connection = new SqlConnection(strCadenaDeConexion);
               sqlCommand.Connection.Open();
               sqlCommand.CommandType = CommandType.StoredProcedure;
               sqlCommand.CommandText = "sp_ABMTipoArticulos";

               sqlCommand.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = DescripcionTipoArticulo;
               sqlCommand.Parameters.Add("@Id_TipoArticulo", SqlDbType.VarChar).Value = Id_TipoArticulo;
               sqlCommand.Parameters.Add("@Estado", SqlDbType.VarChar).Value = 'M';
               sqlCommand.ExecuteNonQuery();


               conexion.Close();

               // MessageBox.Show("Se actualizaron los saldos correctamente", "Inicializar Saldos", MessageBoxButtons.OK, MessageBoxIcon.Information);

           }
           catch (Exception Ex)
           {
               Exception excepcionManejada = new Exception("Error al modificar un Tipo de articulo", Ex);
               throw excepcionManejada;
           }
                
       }

       public void EliminarTipoArticulo(string intIdTipoArticulo)
       {

           string DescripcionTipoArticulo = ""; 

           try
           {
               SqlConnection conexion = new SqlConnection(strCadenaDeConexion);
               conexion.Open();

               SqlCommand sqlCommand = new SqlCommand();
               sqlCommand.Connection = new SqlConnection(strCadenaDeConexion);
               sqlCommand.Connection.Open();
               sqlCommand.CommandType = CommandType.StoredProcedure;
               sqlCommand.CommandText = "sp_ABMTipoArticulos";

               sqlCommand.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = DescripcionTipoArticulo;
               sqlCommand.Parameters.Add("@Id_TipoArticulo", SqlDbType.VarChar).Value = intIdTipoArticulo;
               sqlCommand.Parameters.Add("@Estado", SqlDbType.VarChar).Value = 'B';
               sqlCommand.ExecuteNonQuery();


               conexion.Close();

              
           }
           catch (Exception Ex)
           {
               Exception excepcionManejada = new Exception("Error al eliminar el Tipo de articulo", Ex);
               throw excepcionManejada;
           }
       }
    }
}
