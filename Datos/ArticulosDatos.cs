using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class ArticulosDatos
    {
        static private String strCadenaDeConexion = ConfigurationManager.ConnectionStrings["GestionCC"].ConnectionString;
        
        public void AgregarArticulos(string DescripcionArticulo, float Precio, int Id_TipoArticulo,string codigo,int stock,int Marca,float Costo,string Talle)
        {
            int Id_Articulo = 0;

            try
            {
                SqlConnection conexion = new SqlConnection(strCadenaDeConexion);
                conexion.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = new SqlConnection(strCadenaDeConexion);
                sqlCommand.Connection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_ABMArticulos";

                sqlCommand.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = DescripcionArticulo;
                sqlCommand.Parameters.Add("@Id_Articulo", SqlDbType.Int).Value =Id_Articulo ;
                sqlCommand.Parameters.Add("@Precio", SqlDbType.Float).Value = Precio;
                sqlCommand.Parameters.Add("@Id_TipoArticulo", SqlDbType.VarChar).Value = Id_TipoArticulo;
                sqlCommand.Parameters.Add("@Estado", SqlDbType.VarChar).Value = 'A';
                sqlCommand.Parameters.Add("@Codigo", SqlDbType.VarChar).Value = codigo;
                sqlCommand.Parameters.Add("@Stock", SqlDbType.Int).Value = stock;
                sqlCommand.Parameters.Add("@Marca", SqlDbType.Int).Value = Marca;
                sqlCommand.Parameters.Add("@Costo", SqlDbType.Float).Value = Costo;
                sqlCommand.Parameters.Add("@Talle", SqlDbType.VarChar).Value = Talle;
                sqlCommand.ExecuteNonQuery();

                conexion.Close();
            }
            catch (Exception Ex)
            {
                Exception excepcionManejada = new Exception("Error al dar de Alta un Artículo", Ex);
                throw excepcionManejada;
            }
        }

        public void ModificarArticulos(string DescripcionArticulo, float Precio, int Id_TipoArticulo, int id_Articulo,string codigo,int stock,int Marca,float Costo,string Talle)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(strCadenaDeConexion);
                conexion.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = new SqlConnection(strCadenaDeConexion);
                sqlCommand.Connection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_ABMArticulos";

                sqlCommand.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = DescripcionArticulo;
                sqlCommand.Parameters.Add("@Id_Articulo", SqlDbType.Int).Value = id_Articulo;
                sqlCommand.Parameters.Add("@Precio", SqlDbType.Float).Value = Precio;
                sqlCommand.Parameters.Add("@Id_TipoArticulo", SqlDbType.Int).Value = Id_TipoArticulo;
                sqlCommand.Parameters.Add("@Estado", SqlDbType.VarChar).Value = 'M';
                sqlCommand.Parameters.Add("@Codigo", SqlDbType.VarChar).Value = codigo;
                sqlCommand.Parameters.Add("@Stock", SqlDbType.Int).Value = stock;
                sqlCommand.Parameters.Add("@Marca", SqlDbType.Int).Value = Marca;
                sqlCommand.Parameters.Add("@Costo", SqlDbType.Float).Value =Costo;
                sqlCommand.Parameters.Add("@Talle", SqlDbType.VarChar).Value = Talle;
                
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception excepcionManejada = new Exception("Error al Modificar el Artículo", Ex);
                throw excepcionManejada;
            }
        }

        public void BajaArticulo(string intIdArticulo)
        {
            string strDescripcion = "";
            float fltPrecio = 0;
            int intId_TipoArticulo = 0;
            int codigo = 0;
            int stock = 0;
            int Marca = 0;
            float Costo = 0;
            string Talle = "";

            try
            {
                SqlConnection conexion = new SqlConnection(strCadenaDeConexion);
                conexion.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = new SqlConnection(strCadenaDeConexion);
                sqlCommand.Connection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_ABMArticulos";

                sqlCommand.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = strDescripcion;
                sqlCommand.Parameters.Add("@Id_Articulo", SqlDbType.Int).Value = intIdArticulo;
                sqlCommand.Parameters.Add("@Precio", SqlDbType.Float).Value = fltPrecio;
                sqlCommand.Parameters.Add("@Id_TipoArticulo", SqlDbType.Int).Value = intId_TipoArticulo;
                sqlCommand.Parameters.Add("@Estado", SqlDbType.VarChar).Value = 'B';
                sqlCommand.Parameters.Add("@Codigo", SqlDbType.VarChar).Value = codigo;
                sqlCommand.Parameters.Add("@Stock", SqlDbType.Int).Value = stock;
                sqlCommand.Parameters.Add("@Marca", SqlDbType.Int).Value = Marca;
                sqlCommand.Parameters.Add("@Costo", SqlDbType.Float).Value = Costo;
                sqlCommand.Parameters.Add("@Talle", SqlDbType.VarChar).Value = Talle;
             
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception excepcionManejada = new Exception("Error al dar de Baja el Artículo", Ex);
                throw excepcionManejada;
            }
        }

        public void ActualizarStock(int intIdArticulo, int intCantidad,string strEstado)
        {

           string DescripcionArticulo = "";
           float Precio = 0;
           int Id_TipoArticulo = 0;
           int codigo = 0;
           int stock = 0;
           
            try
            {
                SqlConnection conexion = new SqlConnection(strCadenaDeConexion);
                conexion.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = new SqlConnection(strCadenaDeConexion);
                sqlCommand.Connection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_ActualizarStock";

                
                sqlCommand.Parameters.Add("@Id_Articulo", SqlDbType.VarChar).Value = intIdArticulo;
                sqlCommand.Parameters.Add("@Cantidad", SqlDbType.Int).Value = intCantidad;
                sqlCommand.Parameters.Add("@Estado", SqlDbType.VarChar).Value = strEstado;
                

                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception excepcionManejada = new Exception("Error al actualizar el stock Artículo", Ex);
                throw excepcionManejada;
            }
        }

        public DataSet BuscarUltimoCodigo()
        {
            DataSet dsArticulo = new DataSet();

            try
            {
                SqlConnection conexion = new SqlConnection(strCadenaDeConexion);
                String consulta = "SELECT MAX(CODIGO) FROM ARTICULO";
                SqlDataAdapter daEspecialidad = new SqlDataAdapter(consulta, conexion);
                daEspecialidad.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daEspecialidad.Fill(dsArticulo, "Articulo");
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return dsArticulo;
        }

        public DataSet VerificarUnicidadCodigo(string p)
        {
            DataSet dsArticulo = new DataSet();

            try
            {
                SqlConnection conexion = new SqlConnection(strCadenaDeConexion);
                String consulta = "SELECT id_articulo FROM ARTICULO WHERE Codigo='"+p+"'";
                SqlDataAdapter daEspecialidad = new SqlDataAdapter(consulta, conexion);
                daEspecialidad.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daEspecialidad.Fill(dsArticulo, "Articulo");
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return dsArticulo;
        }
    }
}
