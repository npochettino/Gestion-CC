using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Negocio;

namespace Presentacion
{
    public partial class frmABMClientes : DevExpress.XtraEditors.XtraForm
    {
        ClientesNegocio clienteNegocio = new ClientesNegocio();

        char estado;

        public frmABMClientes()
        {
            InitializeComponent();
        }

        private void frmABMClientes_Load(object sender, EventArgs e)
        {           
            // TODO: esta línea de código carga datos en la tabla 'gestionCC.Cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.gestionCC.Cliente);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarCliente();
        }

        private void AgregarCliente()
        {
            estado = 'A';
            gbDatosCliente.Visible = true;

            gbDatosCliente.Text = "Alta Cliente";
            
            //Limpio los txtbox.
            txtApellido.Clear();
            txtNombre.Clear();
            txtDNI.Clear();
            txtLocalidad.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtComentario.Clear();
            txtEmail.Clear();
        }         

        private void AltaCliente()
        { 
            string Apellido =txtApellido.Text;
            string Nombre = txtNombre.Text;
            string dni = txtDNI.Text;
            string direccion= txtDireccion.Text;
            string localidad = txtLocalidad.Text;
            string telefono = txtTelefono.Text;
            string Comentario = txtComentario.Text;
            string Email = txtEmail.Text;

            clienteNegocio.AgregarCliente(Apellido, Nombre, dni, direccion, localidad, telefono, Comentario,Email);

            XtraMessageBox.Show("Se agregó el cliente correctamente", "Alta Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarDatosFormulario())
            {
                try
                {
                    if (estado == 'A')
                    {
                        AltaCliente();
                    }
                }
                catch (Exception Ex)
                {
                    XtraMessageBox.Show(Ex.ToString(), "Alta Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                try
                {
                    if (estado == 'M')
                    {
                        ModificarCliente();
                    }
                }
                catch (Exception Ex)
                {
                    XtraMessageBox.Show(Ex.ToString(), "Modificar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                gbDatosCliente.Visible = false;
            }

            this.clienteTableAdapter.Fill(this.gestionCC.Cliente);
        }

        private bool validarDatosFormulario()
        {
            bool bolBandera = true;
            string strIncorrecto = "Se han producido los siguientes errores: \n\n";

            if (this.txtNombre.Text == "")
            {
                strIncorrecto = strIncorrecto + "-El campo Nombre se encuentra vacío\n";
                bolBandera = false;
            }

            if (this.txtApellido.Text == "")
            {
                strIncorrecto = strIncorrecto + "-El campo Apellido se encuentra vacío\n";
                bolBandera = false;
            }

            //if (this.txtDNI.Text == "")
            //{
            //    strIncorrecto = strIncorrecto + "-El campo DNI se encuentra vacío\n";
            //    bolBandera = false;
            //}

            //if (this.txtDNI.Text != "" && this.txtDNI.Text.Length!=8)
            //{
            //    strIncorrecto = strIncorrecto + "-El DNI ingresado no es válido\n";
            //    bolBandera = false;
            //}

            //if (this.txtLocalidad.Text == "")
            //{
            //    strIncorrecto = strIncorrecto + "-El campo Localidad se encuentra vacío\n";
            //    bolBandera = false;
            //}

            //if (this.txtDireccion.Text == "")
            //{
            //    strIncorrecto = strIncorrecto + "-El campo Dirección se encuentra vacío\n";
            //    bolBandera = false;
            //}

            if (this.txtTelefono.Text == "")
            {
                strIncorrecto = strIncorrecto + "-El campo Telefono se encuentra vacío\n";
                bolBandera = false;
            }

            if (!bolBandera)
            {
                XtraMessageBox.Show(strIncorrecto, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void ModificarCliente()
        {
            string apellido = txtApellido.Text;
            string nombre = txtNombre.Text;
            string dni = txtDNI.Text;
            string localidad = txtLocalidad.Text;
            string direccion = txtDireccion.Text;
            string telefono = txtTelefono.Text.ToString();
            string comentario = txtComentario.Text;
            string Email = txtEmail.Text;


            int[] selRows = ((GridView)this.gridControl1.MainView).GetSelectedRows();

            DataRowView selRow = (DataRowView)(((GridView)gridControl1.MainView).GetRow(selRows[0]));

            int id_cliente = Convert.ToInt32(selRow[0]);

            try
            {
                clienteNegocio.ModificarDatos(id_cliente, apellido, nombre, dni, localidad, direccion, telefono, comentario,Email);

                XtraMessageBox.Show("Se modificó el cliente correctamente", "Modifcar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch 
            { 
                XtraMessageBox.Show("Hubo un problema, intentelo mas tarde", "Modificar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            CargarDatos();          
        }
       
        private void CargarDatos()
        {
            estado = 'M';

            try
            {
                int[] selRows = ((GridView)this.gridControl1.MainView).GetSelectedRows();

                if (selRows.Length != 0)
                {
                    gbDatosCliente.Visible = true;
                    gbDatosCliente.Text = "Modificar Cliente";

                    DataRowView selRow = (DataRowView)(((GridView)gridControl1.MainView).GetRow(selRows[0]));

                    txtDNI.Text = selRow[2].ToString();
                    txtApellido.Text = selRow[7].ToString();
                    txtNombre.Text = selRow[1].ToString();

                    txtLocalidad.Text = selRow[4].ToString();
                    txtDireccion.Text = selRow[3].ToString();
                    txtTelefono.Text = selRow[5].ToString();
                    txtComentario.Text = selRow[6].ToString();
                    txtEmail.Text = selRow[9].ToString();
                }
                else
                    XtraMessageBox.Show("No hay ningún Cliente seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);   
            }
            catch 
            { 
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gbDatosCliente.Visible = false;
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            if (estado=='M')
            {
                CargarDatos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int[] selRows = ((GridView)this.gridControl1.MainView).GetSelectedRows();

            if (selRows.Length != 0)
            {
                DataRowView selRow = (DataRowView)(((GridView)gridControl1.MainView).GetRow(selRows[0]));

                string nombre = selRow[1].ToString();
                string apellido = selRow[7].ToString();
                string id_cliente = selRow[0].ToString();

                string cliente = apellido + ' ' + nombre;

                if (XtraMessageBox.Show("¿Esta seguro que desea eliminar el cliente " + cliente + "? ", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    try
                    {
                        clienteNegocio.BajaCliente(id_cliente);

                        XtraMessageBox.Show("Se ha eliminado el cliente " + cliente + " con exito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.clienteTableAdapter.Fill(this.gestionCC.Cliente);
                    }
                    catch (Exception Ex)
                    {
                        XtraMessageBox.Show(Ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
                XtraMessageBox.Show("No hay ningún Cliente seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);   
        }

        private void soloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(char.IsSeparator(e.KeyChar)))
            {
                e.Handled = true;
                return;
            }
        }

        private void soloNumerosLimitado_KeyPress(object sender, KeyPressEventArgs e)
       {
            if (this.txtDNI.Text.Length < 8 || (e.KeyChar == 8))
            {
                if ((char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back))
                {
                    e.Handled = false;
                    return;
                }
                else
                {
                    e.Handled = true;
                    return;
                }
            }
            else
            {
                e.Handled = true;
                return;
            }
        }

        private void soloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }
    }
}