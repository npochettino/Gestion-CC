using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio
{
   public class CajaDiariaNegocios
   {
        Datos.CajaDiariaDatos CajaDiaria = new Datos.CajaDiariaDatos();
        public void AgregarIngreso(DateTime FechaOperacion, string DescOperacion, float ImporteOperacion)
        {
            CajaDiaria.AgregarIngreso(FechaOperacion,DescOperacion,ImporteOperacion);

        }

        public void AgregarEgreso(DateTime FechaOperacion, string DescOperacion, float ImporteOperacion)
        {
            CajaDiaria.AgregarEgreso(FechaOperacion, DescOperacion, ImporteOperacion);
        }

      

        public void CerrarCaja(DateTime FechaOperacion, DateTime FechaOperacionPos)
        {
            CajaDiaria.CerrarCaja(FechaOperacion,FechaOperacionPos);
        }
   }
}
