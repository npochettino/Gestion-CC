using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
   public class DetalleVentaDatos
    {
       static private String strCadenaDeConexion = ConfigurationManager.ConnectionStrings["GestionCC"].ConnectionString;




       public void AgregarItemDetalle(int intIdArticulo, int intCantidad,float fltPrecio)
       {
           try
           {
               SqlConnection conexion = new SqlConnection(strCadenaDeConexion);
               conexion.Open();

               SqlCommand sqlCommand = new SqlCommand();
               sqlCommand.Connection = new SqlConnection(strCadenaDeConexion);
               sqlCommand.Connection.Open();
               sqlCommand.CommandType = CommandType.StoredProcedure;
               sqlCommand.CommandText = "sp_ABMItemVenta";

               sqlCommand.Parameters.Add("@Id_Articulo", SqlDbType.Int).Value = intIdArticulo;
               sqlCommand.Parameters.Add("@Cantidad", SqlDbType.Int).Value = intCantidad;
               sqlCommand.Parameters.Add("@Precio", SqlDbType.Float).Value = fltPrecio;
               sqlCommand.Parameters.Add("@Estado", SqlDbType.VarChar).Value = 'A';

               
               sqlCommand.ExecuteNonQuery();


               conexion.Close();

               

           }
           catch (Exception Ex)
           {
               Exception excepcionManejada = new Exception("Error al dar de Alta un Cliente", Ex);
               throw excepcionManejada;
           }
           
       }
    }
}
