using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace Negocio
{
    public class ArticulosNegocio
    {
        Datos.ArticulosDatos CadArticulos = new Datos.ArticulosDatos();
        
        
        
        public void AgregarArticulo(string DescripcionArticulo, float Precio, int TipoProducto, string codigo,int stock, int Marca,float Costo,string Talle)
        {
            CadArticulos.AgregarArticulos(DescripcionArticulo,Precio,TipoProducto,codigo,stock,Marca,Costo,Talle);
        }

        public void ModificarArticulo(string DescripcionArticulo, float Precio, int TipoProducto,  int id_Articulo, string codigo, int stock,int Marca,float Costo,string Talle)
        {
            CadArticulos.ModificarArticulos(DescripcionArticulo, Precio, TipoProducto, id_Articulo,codigo,stock,Marca,Costo,Talle);
        }

        public void BajaArticulo(string intIdArticulo)
        {
            CadArticulos.BajaArticulo(intIdArticulo);
        }

        public void ActualizarStock(int intIdArticulo, int intCantidad,string strEstado)
        {
            CadArticulos.ActualizarStock(intIdArticulo,intCantidad,strEstado);
        }

        public DataSet BuscarUltimoCodigo()
        {
            DataSet dsArticulo = new DataSet();
            dsArticulo = CadArticulos.BuscarUltimoCodigo();


            return dsArticulo;
        }

        public DataSet VerificarUnicidadCodigo(string p)
        {
            DataSet bandera = CadArticulos.VerificarUnicidadCodigo(p);

            return bandera;
        
        }
    }
}
