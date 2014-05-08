using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Datos;
namespace Negocio
{
    public class UsuariosNegocios
    {

        UsuariosDatos usuarioDatos = new UsuariosDatos();
    
        public void AltaUsuario(string strUsuario, string strContraseña, int intPrivilegio)
        {
            try
            {
                usuarioDatos.AltaUsuario(strUsuario, strContraseña, intPrivilegio);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        public void BajaUsuario(string strIdUsuario)
        {
            try
            {
                usuarioDatos.BajaUsuarios(strIdUsuario);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        public void ModificarUsuario(string strUsuario, string strContraseña, int intPrivilegio, int strIdUsuario)
        {
            try
            {
                usuarioDatos.Modificacion(strUsuario, strContraseña, intPrivilegio, strIdUsuario);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        public Boolean ValidadUsuario(string strUsuario, string strContraseña)
        {
            Boolean bandera = usuarioDatos.ValidarUsuario(strUsuario,strContraseña);
            
            return bandera;
            
        }

        public System.Data.DataSet ObtenerPrivilegio(string strUsuario, string strContrasena)
        {
            System.Data.DataSet dsUsuario = new System.Data.DataSet();
            
             dsUsuario= usuarioDatos.ObtenerPrivilegio(strUsuario,strContrasena);

             return dsUsuario;
        }
    }
}
