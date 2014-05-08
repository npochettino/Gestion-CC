using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio
{
    public class TipoArticuloNegocio
    {
        Datos.TipoArticuloDatos CadTipoArticulo = new Datos.TipoArticuloDatos();
        
        public void ModificarTipoArticulo(string DescripcionTipoArticulo, int Id_TipoArticulo)
        {
            CadTipoArticulo.ModificarTipoArticulo(DescripcionTipoArticulo, Id_TipoArticulo);
        }

        public void AgregarTipoArticulo(string DescripcionTipoArticulo)
        {
            CadTipoArticulo.AgregarTipoArticulo(DescripcionTipoArticulo);
        }

        public void BajaTipoArticulo(string intIdTipoArticulo)
        {
            CadTipoArticulo.EliminarTipoArticulo(intIdTipoArticulo);
        }
    }
}
