using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Helpers;
using System.IO;
using DevExpress.XtraGrid.Views.Grid;

namespace Presentacion
{
    public partial class Clientes : DevExpress.XtraEditors.XtraForm
    {
        public Clientes()
        {
            //Pongo al cursor en "modo carga" hasta que se termine de realizar toda la carga de componentes y/o datos 
            Cursor = Cursors.WaitCursor;

            InitializeComponent();

            Cursor = Cursors.Default;
        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            int[] selRows = ((GridView)this.dgvClientes.MainView).GetSelectedRows();

            if (selRows.Length != 0)
            {
                DataRowView selRow = (DataRowView)(((GridView)dgvClientes.MainView).GetRow(selRows[0]));

                int id_cliente = Convert.ToInt32(selRow[0]);


                FormPagoCliente formPagoCliente = new FormPagoCliente();
                formPagoCliente.id_cliente = id_cliente;

                formPagoCliente.ShowDialog();
            }
            else
                XtraMessageBox.Show("No hay ningún Cliente seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Clientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.guardarLookAndFeel();
        }

        private void guardarLookAndFeel()
        {
            defaultLookAndFeel1.LookAndFeel.SkinName = LookAndFeel.ActiveSkinName;
            Properties.Settings.Default.Skin = defaultLookAndFeel1.LookAndFeel.SkinName;
            Properties.Settings.Default.Save();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            Help.ShowHelp(this, Path.Combine(Application.StartupPath, "ayuda.chm"));
            //Help.ShowHelp(this, @"C:\Users\PC\Desktop\CuentaCorriente\Presentacion\Ayuda.chm", HelpNavigator.Topic, "Systemrequirements.htm");//
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Presentacion.FormVentasCliente CadAMVentaCliente = new FormVentasCliente();

            int[] arrIntFilasSeleccionadas = ((GridView)this.dgvClientes.MainView).GetSelectedRows();

            if (arrIntFilasSeleccionadas.Length != 0)
            {

                DataRowView drvFilaSeleccionada = (DataRowView)(((GridView)dgvClientes.MainView).GetRow(arrIntFilasSeleccionadas[0]));

                int Id_Cliente = Convert.ToInt32(drvFilaSeleccionada[0]);
                string strNombreCliente = drvFilaSeleccionada[1].ToString();
                string strApellidoCliente = drvFilaSeleccionada[7].ToString();

                FormVentasCliente formVentasCliente = new FormVentasCliente();
                formVentasCliente.IdCliente = Id_Cliente;
                formVentasCliente.strNombreCliente = strNombreCliente;
                formVentasCliente.strApellidoCliente = strApellidoCliente;

                formVentasCliente.ShowDialog();
            }
            else
                XtraMessageBox.Show("No hay ningún Cliente seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Clientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gestionCC.Cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.gestionCC.Cliente);
        }

        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            int[] selRows = ((GridView)this.dgvClientes.MainView).GetSelectedRows();

            if (selRows.Length != 0)
            {
                DataRowView selRow = (DataRowView)(((GridView)dgvClientes.MainView).GetRow(selRows[0]));

                string strNombreCliente = selRow[6].ToString();
                string strApellidoCliente = selRow[5].ToString();
                int id_cliente = Convert.ToInt32(selRow[0]);


                FormPagosEfectuados frmPagosEfectuados = new FormPagosEfectuados(strNombreCliente, strApellidoCliente, id_cliente);
                frmPagosEfectuados.ShowDialog();
            }
            else
                XtraMessageBox.Show("No hay ningún Cliente seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmABMClientes frmABMClientes = new frmABMClientes();
            frmABMClientes.ShowDialog();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmABMClientes frmABMClientes = new frmABMClientes();
            frmABMClientes.ShowDialog();
        }


        public void ActualizarGrillaClientes()
        {
            this.clienteTableAdapter.Fill(this.gestionCC.Cliente);
        }
    }
}