using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class UsuariosDatos
    {
        static private String strCadenaDeConexion = ConfigurationManager.ConnectionStrings["GestionCC"].ConnectionString; // @"Data Source=|DataDirectory|\BBDD.sdf";

        public void AltaUsuario(string strUsuario, string strContraseña, int intPrivilegio)
        {
            int intIdUsuario = 0;

            try
            {
                SqlConnection conexion = new SqlConnection(strCadenaDeConexion);
                conexion.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = new SqlConnection(strCadenaDeConexion);
                sqlCommand.Connection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_ABMusuarios";

                sqlCommand.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = strUsuario;
                sqlCommand.Parameters.Add("@Contraseña", SqlDbType.VarChar).Value = strContraseña;
                sqlCommand.Parameters.Add("@Privilegio", SqlDbType.Int).Value = intPrivilegio;
                sqlCommand.Parameters.Add("@Estado", SqlDbType.VarChar).Value = 'A';
                sqlCommand.Parameters.Add("@Id_Usu", SqlDbType.Int).Value = intIdUsuario;

                sqlCommand.ExecuteNonQuery();

                conexion.Close();
            }
            catch (Exception Ex)
            {
                Exception excepcionManejada = new Exception("Error al dar de Alta un Usuario", Ex);
                throw excepcionManejada;
            }
        }

        public void BajaUsuarios(string strIdUsuario)
        {
            string strUsuario = "";
            string strContraseña = "";
            int intPrivilegio = 0;

            try
            {
                SqlConnection conexion = new SqlConnection(strCadenaDeConexion);
                conexion.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = new SqlConnection(strCadenaDeConexion);
                sqlCommand.Connection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_ABMusuarios";

                sqlCommand.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = strUsuario;
                sqlCommand.Parameters.Add("@Contraseña", SqlDbType.VarChar).Value = strContraseña;
                sqlCommand.Parameters.Add("@Privilegio", SqlDbType.Int).Value = intPrivilegio;
                sqlCommand.Parameters.Add("@Estado", SqlDbType.VarChar).Value = 'B';
                sqlCommand.Parameters.Add("@Id_Usu", SqlDbType.Int).Value = strIdUsuario;

                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception excepcionManejada = new Exception("Error al dar de Baja un Usuario", Ex);
                throw excepcionManejada;
            }
        }

        public void Modificacion(string strUsuario, string strContraseña, int intPrivilegio, int intIdUsuario)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(strCadenaDeConexion);
                conexion.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = new SqlConnection(strCadenaDeConexion);
                sqlCommand.Connection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_ABMusuarios";

                sqlCommand.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = strUsuario;
                sqlCommand.Parameters.Add("@Contraseña", SqlDbType.VarChar).Value = strContraseña;
                sqlCommand.Parameters.Add("@Privilegio", SqlDbType.Int).Value = intPrivilegio;
                sqlCommand.Parameters.Add("@Estado", SqlDbType.VarChar).Value = 'M';
                sqlCommand.Parameters.Add("@Id_Usu", SqlDbType.Int).Value = intIdUsuario;

                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception excepcionManejada = new Exception("Error al Modificar un Usuario", Ex);
                throw excepcionManejada;
            }
        }

        

        public bool ValidarUsuario(string strUsuario, string strContraseña)
        {

            int intPrivilegio = 0;
            int intIdUsuario = 0;
            Boolean result;
            try
            {
                SqlConnection conexion = new SqlConnection(strCadenaDeConexion);
                conexion.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = new SqlConnection(strCadenaDeConexion);
                sqlCommand.Connection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_ABMusuarios";

                sqlCommand.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = strUsuario;
                sqlCommand.Parameters.Add("@Contraseña", SqlDbType.VarChar).Value = strContraseña;
                sqlCommand.Parameters.Add("@Privilegio", SqlDbType.Int).Value = intPrivilegio;
                sqlCommand.Parameters.Add("@Estado", SqlDbType.VarChar).Value = 'V';
                sqlCommand.Parameters.Add("@Id_Usu", SqlDbType.Int).Value = intIdUsuario;
                

                sqlCommand.Parameters.Add("@Result", SqlDbType.Bit).Direction = ParameterDirection.ReturnValue;
                sqlCommand.ExecuteNonQuery();
                result = Convert.ToBoolean(sqlCommand.ExecuteScalar());


                
            }
            catch (Exception Ex)
            {
                Exception excepcionManejada = new Exception("Error al Modificar un Usuario", Ex);
                throw excepcionManejada;
            }


            return result;
        
        
        }

        public DataSet ObtenerPrivilegio(string strUsuario, string strContrasena)
        {

            DataSet dsUsuario = new DataSet();

            try
            {
                SqlConnection conexion = new SqlConnection(strCadenaDeConexion);
                String consulta = "SELECT TU.Descripcion FROM Usuario as U INNER JOIN TipoUsuario AS TU ON TU.CodTipo=U.Id_TipoUsuario WHERE U.Usuario='"+strUsuario+"' AND Contrasenia='"+strContrasena+"'";
                SqlDataAdapter daEspecialidad = new SqlDataAdapter(consulta, conexion);
                daEspecialidad.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daEspecialidad.Fill(dsUsuario, "Usuario");
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return dsUsuario;
        }
    }
}
