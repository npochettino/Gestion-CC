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
    public partial class FrmABMusuarios : DevExpress.XtraEditors.XtraForm
    {

        char chrEstado;

        public FrmABMusuarios()
        {
            InitializeComponent();
        }

        private void AltaUsuario()
        {
            chrEstado = 'A';
            gbDatos.Visible = true;
            gbDatos.Text = "Alta de Usuario";

            this.txtUsuario.Clear();
            this.txtPass.Clear();
        }

        private void FrmABMusuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gestionCC.TipoUsuario' Puede moverla o quitarla según sea necesario.
            this.tipoUsuarioTableAdapter.Fill(this.gestionCC.TipoUsuario);
            // TODO: esta línea de código carga datos en la tabla 'gestionCC.TipoArticulo' Puede moverla o quitarla según sea necesario.

            // TODO: esta línea de código carga datos en la tabla 'gestionCC.DataTable1' Puede moverla o quitarla según sea necesario.
            

            // TODO: esta línea de código carga datos en la tabla 'gestionCC.DataTable1' Puede moverla o quitarla según sea necesario.
            this.dataTable1TableAdapter.Fill(this.gestionCC.DataTable1);
        }

        private void GuardarDatos()
        {
            if (validarDatosFormulario())
            {
                UsuariosNegocios usuarioNegocio = new UsuariosNegocios();

                string strUsuario = txtUsuario.Text;
                string strContraseña = txtPass.Text;
                int intPrivilegio = Convert.ToInt16(cbPrivilegio.SelectedValue);

                try
                {
                    if (chrEstado == 'A')
                    {
                        usuarioNegocio.AltaUsuario(strUsuario, strContraseña, intPrivilegio);

                        XtraMessageBox.Show("Se Agregó el usuario correctamente", "Alta Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception Ex)
                {
                    XtraMessageBox.Show(Ex.ToString(), "Alta Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                try
                {
                    if (chrEstado == 'M')
                    {
                        int[] arrIntFilasSeleccionadas = ((GridView)this.dtDatosUsuario.MainView).GetSelectedRows();

                        DataRowView drvFilaSeleccionada = (DataRowView)(((GridView)dtDatosUsuario.MainView).GetRow(arrIntFilasSeleccionadas[0]));

                        int intIdUsuario = Convert.ToInt32(drvFilaSeleccionada[3]);

                        usuarioNegocio.ModificarUsuario(strUsuario, strContraseña, intPrivilegio, intIdUsuario);

                        XtraMessageBox.Show("Se modificó el usuario correctamente", "Modificar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch(Exception Ex)
                {
                    XtraMessageBox.Show(Ex.ToString(), "Modificar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                gbDatos.Visible = false;
            }

            this.dataTable1TableAdapter.Fill(this.gestionCC.DataTable1);
        }

        private void EliminarUsuario()
        {
            int[] arrIntFilasSeleccionadas = ((GridView)this.dtDatosUsuario.MainView).GetSelectedRows();

            if (arrIntFilasSeleccionadas.Length != 0)
            {
                DataRowView drvFilaSeleccionada = (DataRowView)(((GridView)dtDatosUsuario.MainView).GetRow(arrIntFilasSeleccionadas[0]));

                string intIdUsuario = drvFilaSeleccionada[3].ToString();
                string strUsuario = drvFilaSeleccionada[0].ToString();

                if (XtraMessageBox.Show("¿Esta seguro que desea eliminar el usuario '" + strUsuario + "'? ", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    try
                    {
                        UsuariosNegocios usuarioNegocio = new UsuariosNegocios();

                        usuarioNegocio.BajaUsuario(intIdUsuario);
                        XtraMessageBox.Show("Se ha eliminado el Usuario '" + strUsuario + "' con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.dataTable1TableAdapter.Fill(this.gestionCC.DataTable1);
                    }
                    catch (Exception Ex)
                    {
                        XtraMessageBox.Show(Ex.ToString(), "Eliminar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                XtraMessageBox.Show("Debe seleccionar un Usuario", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }    

        private void CargarDatos()
        {
            gbDatos.Text = "Modificación de Usuario";

            int[] arrIntFilasSeleccionadas = ((GridView)this.dtDatosUsuario.MainView).GetSelectedRows();

            if (arrIntFilasSeleccionadas.Length != 0)
            {
                gbDatos.Visible = true;
                chrEstado = 'M';

                DataRowView drvFilaSeleccionada = (DataRowView)(((GridView)dtDatosUsuario.MainView).GetRow(arrIntFilasSeleccionadas[0]));

                this.txtUsuario.Text = drvFilaSeleccionada[0].ToString();
                this.txtPass.Text = drvFilaSeleccionada[1].ToString();
                this.cbPrivilegio.Text = drvFilaSeleccionada[2].ToString();
            }
            else
            {
                XtraMessageBox.Show("Debe seleccionar un Usuario", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dtDatosUsuario_Click(object sender, EventArgs e)
        {
            if (chrEstado=='M')
            {
            int[] arrIntFilasSeleccionadas = ((GridView)this.dtDatosUsuario.MainView).GetSelectedRows();

            DataRowView drvFilaSeleccionada = (DataRowView)(((GridView)dtDatosUsuario.MainView).GetRow(arrIntFilasSeleccionadas[0]));

            txtUsuario.Text = drvFilaSeleccionada[0].ToString();
            txtPass.Text = drvFilaSeleccionada[1].ToString();
            cbPrivilegio.Text = drvFilaSeleccionada[2].ToString();
            }
        }

        //Se ocupa de realizar las validaciones de los campos que se encuentran en el formulario
        private bool validarDatosFormulario()
        {
            bool bolBandera = true;
            string strIncorrecto = "Se han producido los siguientes errores: \n\n";

            if (this.txtUsuario.Text == "")
            {
                strIncorrecto = strIncorrecto + "-No ha ingresado ningún Usuario\n";
                bolBandera = false;
            }

            if (this.txtPass.Text == "")
            {
                strIncorrecto = strIncorrecto + "-El campo Contraseña está vacío";
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

        #region Eventos de componentes del WinForm

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gbDatos.Visible = false;
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            EliminarUsuario();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AltaUsuario();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarDatos();
        }

        #endregion


    }
}
