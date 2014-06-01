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
    public partial class FormABMTipoArticulo : DevExpress.XtraEditors.XtraForm
    {

        char chrEstado;
        Negocio.TipoArticuloNegocio CadTipoArticulo = new Negocio.TipoArticuloNegocio();
        public FormABMTipoArticulo()
        {
            InitializeComponent();
        }

        private void FormABMTipoArticulo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gestionCC.TipoArticulo' Puede moverla o quitarla según sea necesario.
            this.tipoArticuloTableAdapter.Fill(this.gestionCC.TipoArticulo);

        }

        private void btnAgregarTipoArticulo_Click(object sender, EventArgs e)
        {
            AltaTipoArticulo();
        }

        private void AltaTipoArticulo()
        {
            chrEstado = 'A';
            grbDatosTiposArticulos.Visible = true;

            grbDatosTiposArticulos.Text = "Alta de Tipo Artículo";

            //Limpio los txtbox.
            txtTipoArticulo.Clear();

        }

        private void btnModificarTipoArticulo_Click(object sender, EventArgs e)
        {
            CargaDatos();
        }

        private void CargaDatos()
        {
            grbDatosTiposArticulos.Text = "Modificación de Tipo Artículo";

            int[] arrIntFilasSeleccionadas = ((GridView)this.dtTipoArticulo.MainView).GetSelectedRows();

            if (arrIntFilasSeleccionadas.Length != 0)
            {
                chrEstado = 'M';
                grbDatosTiposArticulos.Visible = true;

                DataRowView drvFilaSeleccionada = (DataRowView)(((GridView)dtTipoArticulo.MainView).GetRow(arrIntFilasSeleccionadas[0]));

                this.txtTipoArticulo.Text = drvFilaSeleccionada[1].ToString();
            }
            else
            {
                XtraMessageBox.Show("Seleccione un Tipo de Artículo", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminarTipoArticulo_Click(object sender, EventArgs e)
        {
            EliminarTipoArticulo();
        }

        private void EliminarTipoArticulo()
        {        
                int[] arrIntFilasSeleccionadas = ((GridView)this.dtTipoArticulo.MainView).GetSelectedRows();

                if (arrIntFilasSeleccionadas.Length != 0)
                {
                    DataRowView drvFilaSeleccionada = (DataRowView)(((GridView)dtTipoArticulo.MainView).GetRow(arrIntFilasSeleccionadas[0]));

                    string strIdTipoArticulo = drvFilaSeleccionada[0].ToString();
                    string strArticulo = drvFilaSeleccionada[1].ToString();

                    if (XtraMessageBox.Show("¿Esta seguro que desea eliminar el articulo " + strArticulo + "? ", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        try
                        {
                            CadTipoArticulo.BajaTipoArticulo(strIdTipoArticulo);
                            XtraMessageBox.Show("Se ha eliminado el artículo " + strArticulo + " con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.tipoArticuloTableAdapter.Fill(this.gestionCC.TipoArticulo);
                        }
                        catch (Exception Ex)
                        {
                            XtraMessageBox.Show(Ex.ToString(), "Eliminar artículo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    XtraMessageBox.Show("Seleccione un Tipo de Artículo", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
        }

        private void btnGuardarTipoArticulo_Click(object sender, EventArgs e)
        {
            GuardarDatos();
        }

        private void GuardarDatos()
        {
            string strDescripcionTipoArticulo = txtTipoArticulo.Text;

            if (validarDatosDelForm())
            {
                if (chrEstado == 'A')
                {
                    try
                    {
                        CadTipoArticulo.AgregarTipoArticulo(strDescripcionTipoArticulo);

                        XtraMessageBox.Show("Se agregó el Tipo de articulo correctamente", "Alta Tipo Articulo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception Ex)
                    {
                        XtraMessageBox.Show(Ex.ToString(), "Eliminar articulo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (chrEstado == 'M')
                {

                    try
                    {
                        int[] arrIntFilasSeleccionadas = ((GridView)this.dtTipoArticulo.MainView).GetSelectedRows();

                        DataRowView drvFilaSeleccionada = (DataRowView)(((GridView)dtTipoArticulo.MainView).GetRow(arrIntFilasSeleccionadas[0]));

                        int Id_TipoArticulo = Convert.ToInt32(drvFilaSeleccionada[0]);

                        CadTipoArticulo.ModificarTipoArticulo(strDescripcionTipoArticulo, Id_TipoArticulo);

                        XtraMessageBox.Show("Se modificó el tipo de articulo correctamente", "Modificación Articulo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception Ex)
                    {
                        XtraMessageBox.Show(Ex.ToString(), "Eliminar articulo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                grbDatosTiposArticulos.Visible = false;
                this.tipoArticuloTableAdapter.Fill(this.gestionCC.TipoArticulo);
            }
        }

        private bool validarDatosDelForm()
        {
            bool bandera = true;
            string errores = "Por favor, corrija los siguientes errores: \n\n";

            if (this.txtTipoArticulo.Text == "")
            {
                bandera = false;
                errores = errores + "-Complete el campo Descripción\n";
            }

            if (!bandera)
            {
                XtraMessageBox.Show(errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return bandera;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            grbDatosTiposArticulos.Visible = false;
        }

        private void dtTipoArticulo_Click(object sender, EventArgs e)
        {
            if (chrEstado == 'M')
            {
                try
                {
                    int[] arrIntFilasSeleccionadas = ((GridView)this.dtTipoArticulo.MainView).GetSelectedRows();

                    DataRowView drvFilaSeleccionada = (DataRowView)(((GridView)dtTipoArticulo.MainView).GetRow(arrIntFilasSeleccionadas[0]));

                    this.txtTipoArticulo.Text = drvFilaSeleccionada[1].ToString();                  
                }
                catch
                {
                }
            }
        }

        private void txtTipoArticulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != 32))
            {
                e.Handled = true;
                return;
            }
        }
    }
}