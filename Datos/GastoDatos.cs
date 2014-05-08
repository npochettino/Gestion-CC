using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class GastoDatos
    {
        static private String strCadenaDeConexion = ConfigurationManager.ConnectionStrings["GestionCC"].ConnectionString;

        public void AgregarGasto(string strDescripcionGasto, float fltImporteGasto, string strFechaGasto,char AfectaCaja)
        {

            int intId_Gasto= 0;
            
            try
            {
                SqlConnection conexion = new SqlConnection(strCadenaDeConexion);
                conexion.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = new SqlConnection(strCadenaDeConexion);
                sqlCommand.Connection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_ABMGastos";

                sqlCommand.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = strDescripcionGasto;
                
                sqlCommand.Parameters.Add("@Importe", SqlDbType.Float).Value = fltImporteGasto;
                sqlCommand.Parameters.Add("@FechaGasto", SqlDbType.DateTime).Value = strFechaGasto;
                sqlCommand.Parameters.Add("@Id_Gasto", SqlDbType.Int).Value = intId_Gasto;
                sqlCommand.Parameters.Add("@AfectaCaja", SqlDbType.Char).Value = AfectaCaja;
                sqlCommand.Parameters.Add("@Estado", SqlDbType.VarChar).Value = 'A';
                
                sqlCommand.ExecuteNonQuery();

                conexion.Close();
            }
            catch (Exception Ex)
            {
                Exception excepcionManejada = new Exception("Error al dar de Alta un Artículo", Ex);
                throw excepcionManejada;
            }
        }

        public void ModificarGasto(int Id_Gasto, string strDescripcionGasto, float fltImporteGasto, string dtmFechaGasto,char AfectaCaja)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(strCadenaDeConexion);
                conexion.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = new SqlConnection(strCadenaDeConexion);
                sqlCommand.Connection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_ABMGastos";

                sqlCommand.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = strDescripcionGasto;

                sqlCommand.Parameters.Add("@Importe", SqlDbType.Float).Value = fltImporteGasto;
                sqlCommand.Parameters.Add("@FechaGasto", SqlDbType.DateTime).Value = dtmFechaGasto;
                sqlCommand.Parameters.Add("@Id_Gasto", SqlDbType.Int).Value = Id_Gasto;
                sqlCommand.Parameters.Add("@AfectaCaja", SqlDbType.Char).Value = AfectaCaja;
                sqlCommand.Parameters.Add("@Estado", SqlDbType.VarChar).Value = 'M';

                sqlCommand.ExecuteNonQuery();

                conexion.Close();
            }
            catch (Exception Ex)
            {
                Exception excepcionManejada = new Exception("Error al dar de Alta un Artículo", Ex);
                throw excepcionManejada;
            }
        }

        public void EliminarGasto(int intIdGasto)
        {

            string strDescripcionGasto = "";
            float fltImporteGasto = 0;
            DateTime dtmFechaGasto = DateTime.Now;
            char AfectaCaja = 'N';
                
            try
            {
                SqlConnection conexion = new SqlConnection(strCadenaDeConexion);
                conexion.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = new SqlConnection(strCadenaDeConexion);
                sqlCommand.Connection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_ABMGastos";

                sqlCommand.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = strDescripcionGasto;

                sqlCommand.Parameters.Add("@Importe", SqlDbType.Float).Value = fltImporteGasto;
                sqlCommand.Parameters.Add("@FechaGasto", SqlDbType.DateTime).Value = dtmFechaGasto;
                sqlCommand.Parameters.Add("@Id_Gasto", SqlDbType.Int).Value = intIdGasto;
                sqlCommand.Parameters.Add("@AfectaCaja", SqlDbType.Char).Value = AfectaCaja;
                sqlCommand.Parameters.Add("@Estado", SqlDbType.VarChar).Value = 'B';

                sqlCommand.ExecuteNonQuery();

                conexion.Close();
            }
            catch (Exception Ex)
            {
                Exception excepcionManejada = new Exception("Error al dar de Alta un Artículo", Ex);
                throw excepcionManejada;
            }
        }
    }
}
