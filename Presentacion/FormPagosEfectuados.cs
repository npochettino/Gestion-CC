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
    public partial class FormPagosEfectuados : DevExpress.XtraEditors.XtraForm
    {
        public FormPagosEfectuados(string strNombreCliente, string strApellidoCliente,int id_Cliente)
        {
            InitializeComponent();

            this.Text = this.Text + strNombreCliente + ", " + strApellidoCliente;


            this.pagoEfectuadoTableAdapter.Fill(this.gestionCC.PagoEfectuado, id_Cliente);
        }

        private void btnEmitirCertificado_Click(object sender, EventArgs e)
        {
            
            int[] selRows = ((GridView)this.dgvPagosEfectuados.MainView).GetSelectedRows();

            if (selRows.Length != 0)
            {
                DataRowView selRow = (DataRowView)(((GridView)dgvPagosEfectuados.MainView).GetRow(selRows[0]));

                FormReportePagosEfectuados frmReportePagosEfectuados = new FormReportePagosEfectuados();
                frmReportePagosEfectuados.ShowDialog();
            }
        }

        private void dgvPagosEfectuados_MouseDown(object sender, MouseEventArgs e)
        {
            dgvPagosEfectuados.ContextMenuStrip = CMSPagos;
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int[] arrIntFilasSeleccionadas = ((GridView)this.dgvPagosEfectuados.MainView).GetSelectedRows();

                DataRowView drvFilaSeleccionada = (DataRowView)(((GridView)dgvPagosEfectuados.MainView).GetRow(arrIntFilasSeleccionadas[0]));

                int intIdPago = Convert.ToInt32(drvFilaSeleccionada[0]);
                float Monto = float.Parse(drvFilaSeleccionada[2].ToString());
                int Id_Cliente = Convert.ToInt32(drvFilaSeleccionada[1]);

                Negocio.PagoEfectuadoNegocio Pago = new Negocio.PagoEfectuadoNegocio();

                Pago.EliminarPago(intIdPago,Monto,Id_Cliente);

                XtraMessageBox.Show("El pago fue eliminado con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.pagoEfectuadoTableAdapter.Fill(this.gestionCC.PagoEfectuado, Id_Cliente);
            
            }


            catch { XtraMessageBox.Show("No se pudo eliminar el pago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            
        }

       
       
    }
}