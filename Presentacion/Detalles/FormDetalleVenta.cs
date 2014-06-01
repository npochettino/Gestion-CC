using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace Presentacion
{
    public partial class FormDetalleVenta : DevExpress.XtraEditors.XtraForm
    {


        public FormDetalleVenta(int IdVentaa)
        {

            InitializeComponent();

            this.ventaDetalleTableAdapter.Fill(this.gestionCC.VentaDetalle, IdVentaa);


        }


        int idVenta;

        public int IdVenta
        {

            get { return idVenta; }
            set { idVenta = value; }

        }
        
        public void FormDetalleVenta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gestionCC.Venta' Puede moverla o quitarla según sea necesario.
            this.ventaDetalleTableAdapter.Fill(this.gestionCC.VentaDetalle, idVenta);

            //LblNombreCLiente.Text = strApellidoCliente + " " + strNombreCliente;
        }







    }
}