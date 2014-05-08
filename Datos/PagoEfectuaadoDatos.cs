using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class PagoEfectuaadoDatos
    {
        static private String strCadenaDeConexion = ConfigurationManager.ConnectionStrings["GestionCC"].ConnectionString;

        public void AgregarPago(int Id_Cliente, string FechaPago, float Monto)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(strCadenaDeConexion);
                conexion.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = new SqlConnection(strCadenaDeConexion);
                sqlCommand.Connection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_ABMPagosEfectuados";


                sqlCommand.Parameters.Add("@Id_Cliente", SqlDbType.Int).Value = Id_Cliente;
                sqlCommand.Parameters.Add("@FechaPago", SqlDbType.DateTime).Value = FechaPago;
                sqlCommand.Parameters.Add("@Monto", SqlDbType.Float).Value = Monto;
                sqlCommand.Parameters.Add("@Estado", SqlDbType.VarChar).Value = 'A';
                sqlCommand.Parameters.Add("@Id_Pago", SqlDbType.Int).Value = 0;
                
                sqlCommand.ExecuteNonQuery();

                conexion.Close();
            }
            catch (Exception Ex)
            {
                Exception excepcionManejada = new Exception("Error al dar de Alta un Pago", Ex);
                throw excepcionManejada;
            }
        }

        public void EliminarPago(int intIdPago, float Monto,int Id_Cliente)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(strCadenaDeConexion);
                conexion.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = new SqlConnection(strCadenaDeConexion);
                sqlCommand.Connection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_ABMPagosEfectuados";


                sqlCommand.Parameters.Add("@Id_Cliente", SqlDbType.Int).Value = Id_Cliente;
                sqlCommand.Parameters.Add("@FechaPago", SqlDbType.DateTime).Value = DateTime.Today.Date.ToShortDateString();
                sqlCommand.Parameters.Add("@Monto", SqlDbType.Float).Value = Monto;
                sqlCommand.Parameters.Add("@Estado", SqlDbType.VarChar).Value = 'B';
                sqlCommand.Parameters.Add("@Id_Pago", SqlDbType.Int).Value = intIdPago;

                sqlCommand.ExecuteNonQuery();

                conexion.Close();
            }
            catch (Exception Ex)
            {
                Exception excepcionManejada = new Exception("Error al dar de Baja un Pago", Ex);
                throw excepcionManejada;
            }
        }
    }
}
