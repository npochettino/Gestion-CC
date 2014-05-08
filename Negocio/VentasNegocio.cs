﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Negocio
{
   public class VentasNegocio
    {

       Datos.VentasDatos CadVentas = new Datos.VentasDatos();
       
       public void AgregarItem(int Id_Articulo)
        {
            throw new NotImplementedException();
        }

      

       public DataTable ObtenerArticulo(int Id_Articulo)
       {
           DataTable dsArticulo = new DataTable();

            dsArticulo = CadVentas.ObtenerArticulo(Id_Articulo);

           return dsArticulo;
       }

       public void AgregarVenta(int idCliente, DateTime DtmFechaVenta, string strFormapago)
       {
           CadVentas.AgregarVenta(idCliente, DtmFechaVenta, strFormapago);
       }

       public void CancelarVenta(int IntId_Venta, int IntId_Cliente, float FltImporteTotal,string FormaPago)
       {
           CadVentas.CancelarVenta(IntId_Venta, IntId_Cliente, FltImporteTotal,FormaPago);
       }

       

       public void ActualizarImporteTotal(float fltImportaTotalVenta,int Id_Cliente,string FormaPago,float fltImporteCostoVenta)
       {
           CadVentas.ActualizarImporteTotal(fltImportaTotalVenta,Id_Cliente,FormaPago,fltImporteCostoVenta);
       }
    }
}