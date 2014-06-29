using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace Presentacion
{
    class ConsultaReporteVentas
    {

        public static GestionCC ReporteVenta()
        {

            GestionCC dtVentas = new GestionCC();

            string Parametro = "1,2,3";


            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["GestionCC"].ToString()))
            {
                string query = "";
                SqlCommand cmd = new SqlCommand(query, cnn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                
                da.Fill(dtVentas, "Venta");
                
                return dtVentas;
            }





        }


    }
}
