using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Datos
{
    public class ConfigDatos
    {
        static private String strCadenaDeConexion = ConfigurationManager.ConnectionStrings["GestionCC"].ConnectionString;

        public DataTable Select ()
        {
            try
            {
                SqlConnection conexion = new SqlConnection(strCadenaDeConexion);
                conexion.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = new SqlConnection(strCadenaDeConexion);
                sqlCommand.Connection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_Config_Select";

                SqlDataReader MyReader = sqlCommand.ExecuteReader();
                conexion.Close();

                DataTable oDataTable = new DataTable();
                oDataTable.Load(MyReader);

                return oDataTable;
            }
            catch (Exception Ex)
            {
                Exception excepcionManejada = new Exception("Error al obtener los datos de configuración.", Ex);
                throw excepcionManejada;
            }
        }

        public void Update(bool AlwaysSend, bool AlwaysAsk, string Password, string MailFrom, string DefaultText)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(strCadenaDeConexion);
                conexion.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = new SqlConnection(strCadenaDeConexion);
                sqlCommand.Connection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_Config_Update";

                sqlCommand.Parameters.Add("@pAlwaysSend", SqlDbType.VarChar).Value = AlwaysSend;
                sqlCommand.Parameters.Add("@pAlwaysAsk", SqlDbType.VarChar).Value = AlwaysAsk;
                sqlCommand.Parameters.Add("@pPassword", SqlDbType.VarChar).Value = Password;
                sqlCommand.Parameters.Add("@pMailFrom", SqlDbType.VarChar).Value = MailFrom;
                sqlCommand.Parameters.Add("@pDefaultText", SqlDbType.VarChar).Value = DefaultText;

                sqlCommand.ExecuteNonQuery();

                conexion.Close();
            }
            catch (Exception Ex)
            {
                Exception excepcionManejada = new Exception("Error al actualizar los datos de configuración.", Ex);
                throw excepcionManejada;
            }
        }
    }
}
