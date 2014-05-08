using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Presentacion
{
    public class AuxiliarVenta
    {
        public AuxiliarVenta(int idArticulo, string descripcion, string tipoArticulo, string precio, int cantidad,float Costo,int stock,int descuento)
        {
            this.idArticulo = idArticulo;
            this.descripcion = descripcion;
            this.tipoArticulo = tipoArticulo;
            this.precio = precio;
            this.cantidad = cantidad;
            this.costo = Costo;
            this.stock = stock;
            this.MontoParcial = MontoParcial;
            this.descuento = descuento;
            
        }

        private int _idArticulo;

        public int idArticulo
        {
            get { return _idArticulo; }
            set { _idArticulo = value; }
        }

        private int _cantidad;

        public int cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }



        private int _descuento;

        public int descuento
        {
            get { return _descuento; }
            set { _descuento = value; }
        }


        private int _stock;

        public int stock
        {
            get { return _stock; }
            set { _stock = value; }
        }




        private string _descripcion;

        public string descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        private string _tipoArticulo;

        public string tipoArticulo
        {
            get { return _tipoArticulo; }
            set { _tipoArticulo = value; }
        }

        private string _precio;

        public string precio
        {
            get { return _precio; }
            set { _precio = value; }
        }

        private float _costo;

        public float costo
        {
            get { return _costo; }
            set { _costo = value; }
        }

        private float _MontoParcial;

        public float MontoParcial
        {
            get { return _MontoParcial; }
            set { _MontoParcial = value; }
        }





    }
}
