using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio
{
    public class GastoNegocios
    {
        Datos.GastoDatos CadGastos = new Datos.GastoDatos();

        public void AgregarGasto(string strDescripcionGasto, float fltImporteGasto, string strFechaGasto,char AfectaCaja)
        {
            CadGastos.AgregarGasto(strDescripcionGasto,fltImporteGasto,strFechaGasto,AfectaCaja);
        }

        public void ModificarGasto(int Id_Gasto, string strDescripcionGasto, float fltImporteGasto, string dtmFechaGasto, char AfectaCaja)
        {
            CadGastos.ModificarGasto(Id_Gasto,strDescripcionGasto,fltImporteGasto,dtmFechaGasto,AfectaCaja);
        }

        public void EliminarGasto(int intIdGasto)
        {
            CadGastos.EliminarGasto(intIdGasto);
        }
    }
}
