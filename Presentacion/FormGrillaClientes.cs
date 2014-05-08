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
    public partial class FormGrillaClientes : DevExpress.XtraEditors.XtraForm
    {
        public FormGrillaClientes()
        {
            InitializeComponent();
        }

        private void FormGrillaClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gestionCC.Cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.gestionCC.Cliente);

        }

        private void sbtnOK_Click(object sender, EventArgs e)
        {

            ObtenerSeleccion();
            ObtenerSeleccion2();
            
           
        }

        private void ObtenerSeleccion2()
        {
            //Int32 selectedCellCount = Convert.ToInt32((GridView)this.dgcClientes.MainView).GetSelectedCells());
        }

        private void ObtenerSeleccion()
        {
            int[] arrIntFilasSeleccionadas = ((GridView)this.dgcClientes.MainView).GetSelectedRows();

            DataRowView drvFilaSeleccionada = (DataRowView)(((GridView)dgcClientes.MainView).GetRow(arrIntFilasSeleccionadas[0]));

            int IntId_Cliente= Convert.ToInt32(drvFilaSeleccionada[0].ToString());
            string strNombre = drvFilaSeleccionada[5].ToString();
            string strApellido = drvFilaSeleccionada[6].ToString();

            Negocio.ParametrosCliente ParCliente = new Negocio.ParametrosCliente();

            ParCliente.IdCliente = IntId_Cliente;

            
            ParCliente.strNombreCliente = strNombre;
            ParCliente.strApellidoCliente = strApellido;

            Presentacion.FormReporteVentas RepVentas = new FormReporteVentas();


            RepVentas.EnviarParametros(IntId_Cliente,strApellido,strNombre);

            //RepVentas.Parent = this;
           
            this.Close();


                
        }
    }
}