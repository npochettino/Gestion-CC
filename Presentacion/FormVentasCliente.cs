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
    public partial class FormVentasCliente : DevExpress.XtraEditors.XtraForm
    {

        int idCliente;
        string StrNombreCliente;
        string StrApellidoCliente;


        Negocio.VentasNegocio CadVenta = new Negocio.VentasNegocio();

        public int IdCliente
        {

            get { return idCliente; }
            set { idCliente = value; }

        }


        public string strNombreCliente
        { 
          get {return StrNombreCliente; }
          set { StrNombreCliente = value; }
        }

        public string strApellidoCliente
        {
            get { return StrApellidoCliente; }
            set { StrApellidoCliente = value; }
        }

        public FormVentasCliente()
        {
            InitializeComponent();
        }

        private void nbiNuevaVenta_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FormAMVenta formVenta = new FormAMVenta();
            int IntIdCliente = idCliente;

            formVenta.IdCliente = IntIdCliente;
            formVenta.strApellidoCliente = StrApellidoCliente;
            formVenta.strNombreCliente = StrNombreCliente;
            

            formVenta.ShowDialog();


        }

        private void nbiModificarVenta_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            int[] selRows = ((GridView)this.dgvVentas.MainView).GetSelectedRows();

            if (selRows.Length != 0)
            {
                FormAMVenta formVenta = new FormAMVenta();
                formVenta.ShowDialog();
                //formVenta.IdCliente = IntIdCliente;
                formVenta.strApellidoCliente = StrApellidoCliente;
                formVenta.strNombreCliente = StrNombreCliente;
            }
            else
            {
                XtraMessageBox.Show("Debe seleccionar una Venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nbiCancelarVenta_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            int[] selRows = ((GridView)this.dgvVentas.MainView).GetSelectedRows();

           if( XtraMessageBox.Show("¿Está seguro que desea eliminar la venta?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {




                if (selRows.Length != 0)
                {
                    DataRowView selRow = (DataRowView)(((GridView)dgvVentas.MainView).GetRow(selRows[0]));


                    int id_cliente = Convert.ToInt32(selRow[1]);
                    int IntId_Venta = Convert.ToInt32(selRow[0]);
                    float fltImporteTotal = float.Parse(selRow[3].ToString());

                    string FormaPago = selRow[4].ToString();

                    CadVenta.CancelarVenta(IntId_Venta, id_cliente, fltImporteTotal, FormaPago);


                    XtraMessageBox.Show("Se ha eliminado la venta correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.ventaTableAdapter.Fill(this.gestionCC.Venta, idCliente);


                }
                else
                {
                    XtraMessageBox.Show("Debe seleccionar una Venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            
            }

        public void FormVentasCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gestionCC.Venta' Puede moverla o quitarla según sea necesario.
            this.ventaTableAdapter.Fill(this.gestionCC.Venta,idCliente);
           
            LblNombreCLiente.Text = strApellidoCliente + " " + strNombreCliente;
        }

        private void la(object sender, EventArgs e)
        {

        }



        internal void ActualizarGrillaClientes()
        {
            this.ventaTableAdapter.Fill(this.gestionCC.Venta, idCliente);
        }

        private void nbiEmitirInforme_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            
            int[] selRows = ((GridView)this.dgvVentas.MainView).GetSelectedRows();

            if (selRows.Length != 0)
            {
                DataRowView selRow = (DataRowView)(((GridView)dgvVentas.MainView).GetRow(selRows[0]));

                //FormReporteVenta frmReporteVenta = new FormReporteVenta();
                //frmReporteVenta.ShowDialog();
            }
        }
    }
}