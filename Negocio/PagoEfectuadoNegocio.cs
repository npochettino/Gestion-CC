using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio
{
    public class PagoEfectuadoNegocio
    {
        Datos.PagoEfectuaadoDatos CadPagosEfectuados = new Datos.PagoEfectuaadoDatos();

        public void AgregarPago(int Id_Cliente, string FechaPago, float Monto)
        {
            CadPagosEfectuados.AgregarPago(Id_Cliente,FechaPago,Monto);
        }

        public void EliminarPago(int intIdPago,float Monto,int Id_Cliente)
        {
            CadPagosEfectuados.EliminarPago(intIdPago,Monto,Id_Cliente);
        }
    }

}
