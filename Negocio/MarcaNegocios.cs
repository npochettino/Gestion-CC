using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio
{
    public class MarcaNegocios
    {

        Datos.MarcaDatos Marca = new Datos.MarcaDatos();
        public void AgregarMarca(string strDescripcionMarca)
        {
            Marca.AgregarMarca(strDescripcionMarca);
        }

        public void ModificarTipoArticulo(string strDescripcionMarca, int Id_Marca)
        {
            Marca.ModificarMarca(strDescripcionMarca,Id_Marca);
        }

        public void EliminarMarca(string strMarca, string strIdMarca)
        {
            Marca.EliminarMarca(strMarca, strIdMarca);
        }
    }
}
