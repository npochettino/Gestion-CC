using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio
{
    public class DetalleVentaNegocio
    {

        Datos.DetalleVentaDatos CadDetalleVenta = new Datos.DetalleVentaDatos();



        public void AgregarItemDetalle(int intIdArticulo, int intCantidad,float fltPrecio)
        {
            CadDetalleVenta.AgregarItemDetalle(intIdArticulo,intCantidad,fltPrecio);
        }
    }
}
