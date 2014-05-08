using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
   public class CajaDiariaDatos
    {

       static private String strCadenaDeConexion = ConfigurationManager.ConnectionStrings["GestionCC"].ConnectionString;
       
       
       
       
       public void AgregarIngreso(DateTime FechaOperacion, string DescOperacion, float ImporteOperacion)
        {

            float CajaInicial = 0;
            DateTime FechaPos = DateTime.Now;

            try
            {
                SqlConnection conexion = new SqlConnection(strCadenaDeConexion);
                conexion.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = new SqlConnection(strCadenaDeConexion);
                sqlCommand.Connection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_IECajaDiaria";

                sqlCommand.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = DescOperacion;
                sqlCommand.Parameters.Add("@Ingreso", SqlDbType.Float).Value = ImporteOperacion;
                sqlCommand.Parameters.Add("@Egreso", SqlDbType.Float).Value = ImporteOperacion;
                sqlCommand.Parameters.Add("@FechaOperacion", SqlDbType.DateTime).Value = FechaOperacion;
                sqlCommand.Parameters.Add("@FechaPos", SqlDbType.DateTime).Value = FechaPos;
                sqlCommand.Parameters.Add("@Estado", SqlDbType.VarChar).Value = 'I';
                sqlCommand.Parameters.Add("@CajaInicial", SqlDbType.Float).Value = CajaInicial;
                sqlCommand.ExecuteNonQuery();

                conexion.Close();
            }
            catch (Exception Ex)
            {
                Exception excepcionManejada = new Exception("Error al dar de Alta un Ingreso", Ex);
                throw excepcionManejada;
            }
        }

       public void AgregarEgreso(DateTime FechaOperacion, string DescOperacion, float ImporteOperacion)
       {
           float CajaInicial = 0;
           DateTime FechaPos = DateTime.Now;

           try
           {
               SqlConnection conexion = new SqlConnection(strCadenaDeConexion);
               conexion.Open();

               SqlCommand sqlCommand = new SqlCommand();
               sqlCommand.Connection = new SqlConnection(strCadenaDeConexion);
               sqlCommand.Connection.Open();
               sqlCommand.CommandType = CommandType.StoredProcedure;
               sqlCommand.CommandText = "sp_IECajaDiaria";

               sqlCommand.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = DescOperacion;
               sqlCommand.Parameters.Add("@Ingreso", SqlDbType.Float).Value = ImporteOperacion;
               sqlCommand.Parameters.Add("@Egreso", SqlDbType.Float).Value = ImporteOperacion;
               sqlCommand.Parameters.Add("@FechaOperacion", SqlDbType.DateTime).Value = FechaOperacion;
               sqlCommand.Parameters.Add("@FechaPos", SqlDbType.DateTime).Value = FechaPos;
               sqlCommand.Parameters.Add("@Estado", SqlDbType.VarChar).Value = 'E';
               sqlCommand.Parameters.Add("@CajaInicial", SqlDbType.Float).Value = CajaInicial;
               sqlCommand.ExecuteNonQuery();

               conexion.Close();
           }
           catch (Exception Ex)
           {
               Exception excepcionManejada = new Exception("Error al dar de Alta un Ingreso", Ex);
               throw excepcionManejada;
           }
       }

       public void CerrarCaja(DateTime FechaOperacion,DateTime FechaPos)
       {
           float  ImporteOperacion=0;
           string DescOperacion = "";
           float CajaInicial = 0;
          

           try
           {
               SqlConnection conexion = new SqlConnection(strCadenaDeConexion);
               conexion.Open();

               SqlCommand sqlCommand = new SqlCommand();
               sqlCommand.Connection = new SqlConnection(strCadenaDeConexion);
               sqlCommand.Connection.Open();
               sqlCommand.CommandType = CommandType.StoredProcedure;
               sqlCommand.CommandText = "sp_IECajaDiaria";

               sqlCommand.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = DescOperacion;
               sqlCommand.Parameters.Add("@Ingreso", SqlDbType.Float).Value = ImporteOperacion;
               sqlCommand.Parameters.Add("@Egreso", SqlDbType.Float).Value = ImporteOperacion;
               sqlCommand.Parameters.Add("@FechaOperacion", SqlDbType.DateTime).Value = FechaOperacion;
               sqlCommand.Parameters.Add("@FechaPos", SqlDbType.DateTime).Value = FechaPos;
               sqlCommand.Parameters.Add("@Estado", SqlDbType.VarChar).Value = 'C';
               sqlCommand.Parameters.Add("@CajaInicial", SqlDbType.Float).Value = CajaInicial;
               sqlCommand.ExecuteNonQuery();

               conexion.Close();
           }
           catch (Exception Ex)
           {
               Exception excepcionManejada = new Exception("Error al dar de Alta un Ingreso", Ex);
               throw excepcionManejada;
           }
       }
    }
}
