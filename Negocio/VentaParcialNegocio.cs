using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio
{
   public class VentaParcialNegocio
    {

       Datos.VentaParcialDatos CadVentaParcial = new Datos.VentaParcialDatos();
       
       
       public void AgregarItem(int intIdArticulo, string strDescripción, int intId_TipoArticulo)
        {
            CadVentaParcial.AgregarItem(intIdArticulo,strDescripción,intId_TipoArticulo);
        }

       public void QuitarItem(int intIdArticulo)
       {
           CadVentaParcial.QuitarItem(intIdArticulo);
       }

       public void ReestablecerArticulos()
       {
           
           CadVentaParcial.ReestablecerArticulos();
       }
    }
}
