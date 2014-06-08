using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
   public class ClientesDatos
   {
       static private String strCadenaDeConexion = ConfigurationManager.ConnectionStrings["GestionCC"].ConnectionString;

       public void AgregarCliente(string strNombreCliente,string strApellidoCliente, string Dni,string strDireccion, string strLocalidad, string intTelefono, string strComentario,string Email)
       {
           int Id_Cliente = 0;

           try
           {
               SqlConnection conexion = new SqlConnection(strCadenaDeConexion);
               conexion.Open();

               SqlCommand sqlCommand = new SqlCommand();
               sqlCommand.Connection = new SqlConnection(strCadenaDeConexion);
               sqlCommand.Connection.Open();
               sqlCommand.CommandType = CommandType.StoredProcedure;
               sqlCommand.CommandText = "sp_ABMClientes";

               sqlCommand.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = strNombreCliente;
               sqlCommand.Parameters.Add("@Apellido", SqlDbType.VarChar).Value = strApellidoCliente;
               sqlCommand.Parameters.Add("@dni", SqlDbType.VarChar).Value = Dni;
               sqlCommand.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = strDireccion;
               sqlCommand.Parameters.Add("@Localidad", SqlDbType.VarChar).Value = strLocalidad;
               sqlCommand.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = intTelefono;
               sqlCommand.Parameters.Add("@Comentario", SqlDbType.VarChar).Value = strComentario;
               sqlCommand.Parameters.Add("@Estado", SqlDbType.VarChar).Value = 'A';
               sqlCommand.Parameters.Add("@Id_cliente", SqlDbType.Int).Value = Id_Cliente;
               sqlCommand.Parameters.Add("@Importe", SqlDbType.Float).Value = 0;
               sqlCommand.Parameters.Add("@Email", SqlDbType.VarChar).Value = Email;
               
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

       public void ModificarDatosCliente(int id_cliente, string apellido, string nombre, string Dni, string strLocalidad, string strDireccion, string intTelefono, string comentario,string Email)
       {
           try
           {
               SqlConnection conexion = new SqlConnection(strCadenaDeConexion);
               conexion.Open();

               SqlCommand sqlCommand = new SqlCommand();
               sqlCommand.Connection = new SqlConnection(strCadenaDeConexion);
               sqlCommand.Connection.Open();
               sqlCommand.CommandType = CommandType.StoredProcedure;
               sqlCommand.CommandText = "sp_ABMClientes";

               sqlCommand.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = nombre;
               sqlCommand.Parameters.Add("@Apellido", SqlDbType.VarChar).Value = apellido;
               sqlCommand.Parameters.Add("@dni", SqlDbType.VarChar).Value = Dni;
               sqlCommand.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = strDireccion;
               sqlCommand.Parameters.Add("@Localidad", SqlDbType.VarChar).Value = strLocalidad;
               sqlCommand.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = intTelefono;
               sqlCommand.Parameters.Add("@Comentario", SqlDbType.VarChar).Value = comentario;
               sqlCommand.Parameters.Add("@Estado", SqlDbType.VarChar).Value = 'M';
               sqlCommand.Parameters.Add("@Id_cliente", SqlDbType.Int).Value = id_cliente;
               sqlCommand.Parameters.Add("@Importe", SqlDbType.Int).Value = 0;
               sqlCommand.Parameters.Add("@Email", SqlDbType.VarChar).Value = Email;
              
               sqlCommand.ExecuteNonQuery();

               conexion.Close();
           }
           catch (Exception Ex)
           {
               Exception excepcionManejada = new Exception("Error al Modificar un Cliente", Ex);
               throw excepcionManejada;
           }
       }

       public void EliminarCliente(string id_cliente)
       {
           string nombre = " ";
           string apellido = "";
           int intDni = 0;
           string strDireccion = "";
           string strLocalidad = "";
           string intTelefono = "";
           string comentario = "";
           string Email = "";

           try
           {
               SqlConnection conexion = new SqlConnection(strCadenaDeConexion);
               conexion.Open();

               SqlCommand sqlCommand = new SqlCommand();
               sqlCommand.Connection = new SqlConnection(strCadenaDeConexion);
               sqlCommand.Connection.Open();
               sqlCommand.CommandType = CommandType.StoredProcedure;
               sqlCommand.CommandText = "sp_ABMClientes";

               sqlCommand.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = nombre;
               sqlCommand.Parameters.Add("@Apellido", SqlDbType.VarChar).Value = apellido;
               sqlCommand.Parameters.Add("@dni", SqlDbType.Int).Value = intDni;
               sqlCommand.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = strDireccion;
               sqlCommand.Parameters.Add("@Localidad", SqlDbType.VarChar).Value = strLocalidad;
               sqlCommand.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = intTelefono;
               sqlCommand.Parameters.Add("@Comentario", SqlDbType.VarChar).Value = comentario;
               sqlCommand.Parameters.Add("@Estado", SqlDbType.VarChar).Value = 'B';
               sqlCommand.Parameters.Add("@Id_cliente", SqlDbType.Int).Value = id_cliente;
               sqlCommand.Parameters.Add("@Importe", SqlDbType.Int).Value = 0;
               sqlCommand.Parameters.Add("@Email", SqlDbType.VarChar).Value = Email;
               
               sqlCommand.ExecuteNonQuery();

               conexion.Close();
           }
           catch (Exception Ex)
           {
               Exception excepcionManejada = new Exception("Error al dar de Baja un Usuario", Ex);
               throw excepcionManejada;
           }     
       }

       public static DataSet ObtenerClienteSeleccionado(string Parametro)
       {
           
           DataSet dsCliente= new DataSet();

            try
            {
                SqlConnection conexion = new SqlConnection(strCadenaDeConexion);
                String consulta = "SELECT Id_Cliente,Apellido+' '+Nombre,DNI FROM Cliente WHERE (Apellido+' '+Nombre LIKE '"+"%"+@Parametro+"%"+"') OR (CONVERT(VARCHAR,DNI) = '"+@Parametro+"')";
                SqlDataAdapter daEspecialidad = new SqlDataAdapter(consulta, conexion);
                daEspecialidad.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daEspecialidad.Fill(dsCliente, "Cliente");
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return dsCliente;
          
       }

       public static DataSet ConsultarSaldo(int IdCliente)
       {
           DataSet dsSaldoCliente= new DataSet();


           try
           {
               SqlConnection conexion = new SqlConnection(strCadenaDeConexion);
               String consulta = "SELECT Importe FROM Cliente WHERE Id_Cliente='"+IdCliente+"'";
               SqlDataAdapter daEspecialidad = new SqlDataAdapter(consulta, conexion);
               daEspecialidad.MissingSchemaAction = MissingSchemaAction.AddWithKey;
               daEspecialidad.Fill(dsSaldoCliente, "Cliente");
           }
           catch (Exception ex)
           {
               throw (ex);
           }



           return dsSaldoCliente;
       }

       public DataTable SelectOne(int IDCliente)
       {
           try
           {
               SqlConnection conexion = new SqlConnection(strCadenaDeConexion);
               conexion.Open();

               SqlCommand sqlCommand = new SqlCommand();
               sqlCommand.Connection = new SqlConnection(strCadenaDeConexion);
               sqlCommand.Connection.Open();
               sqlCommand.CommandType = CommandType.StoredProcedure;
               sqlCommand.CommandText = "sp_Cliente_SelectOne";

               sqlCommand.Parameters.Add("@pIDCliente", SqlDbType.Int).Value = IDCliente;

               SqlDataReader MyReader = sqlCommand.ExecuteReader();
               conexion.Close();

               DataTable oDataTable = new DataTable();
               oDataTable.Load(MyReader);

               return oDataTable;
           }
           catch (Exception Ex)
           {
               Exception excepcionManejada = new Exception("Error al Modificar un Cliente", Ex);
               throw excepcionManejada;
           }
       }
   }
}
