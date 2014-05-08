﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class VentasDatos
    {

        static private String strCadenaDeConexion = ConfigurationManager.ConnectionStrings["GestionCC"].ConnectionString;


        public DataTable ObtenerArticulo(int Id_Articulo)
        {
            DataTable dsArticulo = new DataTable();



            try
            {



                SqlConnection conexion = new SqlConnection(strCadenaDeConexion);
                String consulta = "SELECT Articulo.Id_Articulo, Articulo.Descripcion,Precio.Precio as Precio,TipoArticulo.Descripcion as TipoArticulo FROM Articulo  INNER JOIN Precio ON Articulo.Id_Articulo = Precio.Id_Articulo INNER JOIN TipoArticulo ON Articulo.id_TipoArticulo = TipoArticulo.Id_TipoArticulo AND  Precio.FechaPrecio =(SELECT MAX(FechaPrecio) FROM Precio as P WHERE P.Id_Articulo=Articulo.Id_Articulo) AND Articulo.Id_Articulo='"+Id_Articulo+"' ";
                SqlDataAdapter daTurnos = new SqlDataAdapter(consulta, conexion);
                daTurnos.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daTurnos.Fill(dsArticulo);

            }

            catch (Exception ex)
            {

            }

            return dsArticulo;

        }

        public void AgregarVenta(int idCliente, DateTime DtmFechaVenta, string strFormaPago)
        {
            int Id_Venta=0;
            float fltImportaTotalVenta = 0;
            float fltCostoVenta = 0;
            try
            {
                SqlConnection conexion = new SqlConnection(strCadenaDeConexion);
                conexion.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = new SqlConnection(strCadenaDeConexion);
                sqlCommand.Connection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_ABMVentas";

                sqlCommand.Parameters.Add("@Id_Cliente", SqlDbType.Int).Value = idCliente;
                sqlCommand.Parameters.Add("@FormaPago", SqlDbType.VarChar).Value = strFormaPago;
                sqlCommand.Parameters.Add("@FechaVenta", SqlDbType.DateTime).Value = DtmFechaVenta;
                sqlCommand.Parameters.Add("@Estado", SqlDbType.VarChar).Value = 'A';
                sqlCommand.Parameters.Add("@Id_Venta", SqlDbType.Int).Value = Id_Venta;
                sqlCommand.Parameters.Add("@ImporteTotal", SqlDbType.Float).Value = fltImportaTotalVenta;
                sqlCommand.Parameters.Add("@CostoVenta", SqlDbType.Float).Value = fltCostoVenta;
                sqlCommand.ExecuteNonQuery();


                conexion.Close();



            }
            catch (Exception Ex)
            {
                Exception excepcionManejada = new Exception("Error al dar de Alta una Venta", Ex);
                throw excepcionManejada;
            }
        }

        public void CancelarVenta(int IntId_Venta, int IntId_Cliente, float FltImporteTotal,string FormaPago)
        {
            
            
            DateTime DtmFechaVenta =DateTime.Now;

            float ImporteCostoVenta = 0;
            
            try
            {
                SqlConnection conexion = new SqlConnection(strCadenaDeConexion);
                conexion.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = new SqlConnection(strCadenaDeConexion);
                sqlCommand.Connection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_ABMVentas";

                sqlCommand.Parameters.Add("@Id_Cliente", SqlDbType.Int).Value = IntId_Cliente;
                sqlCommand.Parameters.Add("@FormaPago", SqlDbType.VarChar).Value = FormaPago;
                sqlCommand.Parameters.Add("@FechaVenta", SqlDbType.DateTime).Value = DtmFechaVenta;
                sqlCommand.Parameters.Add("@Estado", SqlDbType.VarChar).Value = 'B';
                sqlCommand.Parameters.Add("@Id_Venta", SqlDbType.Int).Value = IntId_Venta;
                sqlCommand.Parameters.Add("@ImporteTotal", SqlDbType.Float).Value = FltImporteTotal;
                sqlCommand.Parameters.Add("@CostoVenta", SqlDbType.Float).Value = ImporteCostoVenta;
                sqlCommand.ExecuteNonQuery();


                conexion.Close();



            }
            catch (Exception Ex)
            {
                Exception excepcionManejada = new Exception("Error al dar de Baja una Venta", Ex);
                throw excepcionManejada;
            }
        }

        public void ActualizarImporteTotal(float fltImportaTotalVenta,int Id_Cliente,string FormaPago,float ImporteCostoVenta)
        {
            
            
            DateTime DtmFechaVenta = DateTime.Now;
            int IntId_Venta = 0;
            try
            {
                SqlConnection conexion = new SqlConnection(strCadenaDeConexion);
                conexion.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = new SqlConnection(strCadenaDeConexion);
                sqlCommand.Connection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_ABMVentas";

                sqlCommand.Parameters.Add("@Id_Cliente", SqlDbType.Int).Value =Id_Cliente;
                sqlCommand.Parameters.Add("@FormaPago", SqlDbType.VarChar).Value = FormaPago;
                sqlCommand.Parameters.Add("@FechaVenta", SqlDbType.DateTime).Value = DtmFechaVenta;
                sqlCommand.Parameters.Add("@Estado", SqlDbType.VarChar).Value = 'C';
                sqlCommand.Parameters.Add("@Id_Venta", SqlDbType.Int).Value = IntId_Venta;
                sqlCommand.Parameters.Add("@ImporteTotal", SqlDbType.Float).Value = fltImportaTotalVenta;
                sqlCommand.Parameters.Add("@CostoVenta", SqlDbType.Float).Value = ImporteCostoVenta;
                sqlCommand.ExecuteNonQuery();


                conexion.Close();



            }
            catch (Exception Ex)
            {
                Exception excepcionManejada = new Exception("Error al dar de Baja una Venta", Ex);
                throw excepcionManejada;
            }
        }
    }
}
