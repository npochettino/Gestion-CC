using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio
{
    public class ParametrosCliente
    {
        int idCliente;
        string StrNombreCliente;
        string StrApellidoCliente;
       

        public int IdCliente
        {

            get { return idCliente; }
            set { idCliente = value; }

        }


      

        public string strNombreCliente
        {
            get { return StrNombreCliente; }
            set { StrNombreCliente = value; }
        }

        public string strApellidoCliente
        {
            get { return StrApellidoCliente; }
            set { StrApellidoCliente = value; }
        }

       
    }
}
