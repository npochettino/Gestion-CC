using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Datos;
using System.Data;

namespace Negocio
{
    public class ClientesNegocio
    {
        ClientesDatos clienteDatos = new ClientesDatos();


        public void AgregarCliente(string strApellido, string strNombre, string Dni,string strDireccion, string strLocalidad, string lngTelefono, string strComentario,string Email)
        {
            try
            {
                clienteDatos.AgregarCliente(strNombre, strApellido, Dni, strDireccion, strLocalidad, lngTelefono, strComentario,Email);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        public void ModificarDatos(int id_cliente, string apellido, string nombre, string Dni, string strLocalidad, string strDireccion, string lngTelefono, string comentario,string Email)
        {
            try
            {
                clienteDatos.ModificarDatosCliente(id_cliente, apellido, nombre, Dni, strLocalidad, strDireccion, lngTelefono, comentario,Email);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        public void BajaCliente(string id_cliente)
        {
            try
            {
                clienteDatos.EliminarCliente(id_cliente);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        public System.Data.DataSet ObtenerClienteSeleccionado(string Parametro)
        {
            System.Data.DataSet dsCliente = new System.Data.DataSet();
            
            dsCliente = ClientesDatos.ObtenerClienteSeleccionado(Parametro);

            return dsCliente;
        }

        public DataSet ConsultarSaldo(int IdCliente)
        {
            DataSet dsSaldoCliente= new DataSet();
            
            dsSaldoCliente= ClientesDatos.ConsultarSaldo(IdCliente);


            return  dsSaldoCliente;
        }
    }
}
