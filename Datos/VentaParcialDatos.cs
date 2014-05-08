using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class VentaParcialDatos
    {
        static private String strCadenaDeConexion = ConfigurationManager.ConnectionStrings["GestionCC"].ConnectionString;
        
        
        public void AgregarItem(int intIdArticulo, string strDescripción, int intId_TipoArticulo)
        {
            DataSet dsObraSocial = new DataSet();
            try
            {
                SqlConnection conexion = new SqlConnection(strCadenaDeConexion);
                String consulta = "INSERT INTO VentaParcial(Id_Articulo,Descripcion,Id_TipoArticulo) VALUES ('"+intIdArticulo+"','"+strDescripción+"','"+intId_TipoArticulo+"')";
                SqlDataAdapter daOS = new SqlDataAdapter(consulta, conexion);
                daOS.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daOS.Fill(dsObraSocial, "VentaParcial");
                SqlCommandBuilder cbuilder = new SqlCommandBuilder(daOS);
                

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public void QuitarItem(int intIdArticulo)
        {
            DataSet dsObraSocial = new DataSet();
            try
            {
                SqlConnection conexion = new SqlConnection(strCadenaDeConexion);
                String consulta = "DELETE FROM VentaParcial  Where VentaParcial.Id_Articulo='" + intIdArticulo + "'";
                SqlDataAdapter daOS = new SqlDataAdapter(consulta, conexion);
                daOS.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daOS.Fill(dsObraSocial, "VentaParcial");
                SqlCommandBuilder cbuilder = new SqlCommandBuilder(daOS);


            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public void ReestablecerArticulos()
        {
            DataSet dsObraSocial = new DataSet();
            try
            {
                SqlConnection conexion = new SqlConnection(strCadenaDeConexion);
                String consulta = "DELETE FROM VentaParcial";
                SqlDataAdapter daOS = new SqlDataAdapter(consulta, conexion);
                daOS.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daOS.Fill(dsObraSocial, "VentaParcial");
                SqlCommandBuilder cbuilder = new SqlCommandBuilder(daOS);


            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
    }
}
