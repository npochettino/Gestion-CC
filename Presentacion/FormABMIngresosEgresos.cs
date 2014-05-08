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
    public partial class FormABMIngresosEgresos : DevExpress.XtraEditors.XtraForm
    {

        char chrEstado;
        //Negocio.MarcaNegocios Marca = new Negocio.MarcaNegocios();
        
        
        public FormABMIngresosEgresos()
        {
            InitializeComponent();
        }

        

        private void btnAgregarTipoArticulo_Click(object sender, EventArgs e)
        {
            AltaTipoArticulo();
        }

        private void AltaTipoArticulo()
        {
            chrEstado = 'A';
           grbDatosIE.Visible = true;

           grbDatosIE.Text = "Alta de Marca";

            //Limpio los txtbox.
            txtDescOperacion.Clear();
            txtImporteOperacion.Clear();

        }

        private void btnModificarTipoArticulo_Click(object sender, EventArgs e)
        {
            CargaDatos();
        }

        private void CargaDatos()
        {
            grbDatosIE.Text = "Modificación de Marca";

           int[] arrIntFilasSeleccionadas = ((GridView)this.dtMarca.MainView).GetSelectedRows();

            if (arrIntFilasSeleccionadas.Length != 0)
            {
                chrEstado = 'M';
                grbDatosIE.Visible = true;

                DataRowView drvFilaSeleccionada = (DataRowView)(((GridView)dtMarca.MainView).GetRow(arrIntFilasSeleccionadas[0]));

                
            }
            else
            {
                XtraMessageBox.Show("Seleccione una Marca", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminarTipoArticulo_Click(object sender, EventArgs e)
        {
            EliminarTipoArticulo();
        }

        private void EliminarTipoArticulo()
        {        
                int[] arrIntFilasSeleccionadas = ((GridView)this.dtMarca.MainView).GetSelectedRows();

                if (arrIntFilasSeleccionadas.Length != 0)
                {
                    DataRowView drvFilaSeleccionada = (DataRowView)(((GridView)dtMarca.MainView).GetRow(arrIntFilasSeleccionadas[0]));

                    string strIdMarca = drvFilaSeleccionada[1].ToString();
                    string strMarca = drvFilaSeleccionada[0].ToString();

                    if (XtraMessageBox.Show("¿Está seguro que desea eliminar la Marca " + strMarca + "? ", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        try
                        {
                            //Marca.EliminarMarca(strMarca,strIdMarca);
                            XtraMessageBox.Show("Se ha eliminado la Marca " + strMarca+ " con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                        }
                        catch (Exception Ex)
                        {
                            XtraMessageBox.Show(Ex.ToString(), "Eliminar Marca", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    XtraMessageBox.Show("Seleccione una Marca", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
        }

        private void btnGuardarTipoArticulo_Click(object sender, EventArgs e)
        {
            GuardarDatos();
        }

        private void GuardarDatos()
        {
           string strDescripcionOperacion = txtImporteOperacion.Text;

            if (validarDatosDelForm())
            {
                if (chrEstado == 'A')
                {
                    try
                    {
                        //Marca.AgregarMarca(strDescripcionMarca);

                        XtraMessageBox.Show("Se agregó la marca correctamente", "Alta Marca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception Ex)
                    {
                        XtraMessageBox.Show(Ex.ToString(), "Eliminar Marca", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (chrEstado == 'M')
                {

                    try
                    {
                        int[] arrIntFilasSeleccionadas = ((GridView)this.dtMarca.MainView).GetSelectedRows();

                        DataRowView drvFilaSeleccionada = (DataRowView)(((GridView)dtMarca.MainView).GetRow(arrIntFilasSeleccionadas[0]));

                        int Id_Marca = Convert.ToInt32(drvFilaSeleccionada[1]);

                        //Marca.ModificarTipoArticulo(strDescripcionMarca, Id_Marca);

                        XtraMessageBox.Show("Se modificó la marca correctamente", "Modificación Marca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception Ex)
                    {
                        XtraMessageBox.Show(Ex.ToString(), "Eliminar Marca", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                 grbDatosIE.Visible = false;
               
            }
        }

        private bool validarDatosDelForm()
        {
            bool bandera = true;
            string errores = "Por favor, corrija los siguientes errores: \n\n";

            if (this.txtImporteOperacion.Text == "")
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
           grbDatosIE.Visible = false;
        }

        private void dtTipoArticulo_Click(object sender, EventArgs e)
        {
            if (chrEstado == 'M')
            {
                try
                {
                    int[] arrIntFilasSeleccionadas = ((GridView)this.dtMarca.MainView).GetSelectedRows();

                    DataRowView drvFilaSeleccionada = (DataRowView)(((GridView)dtMarca.MainView).GetRow(arrIntFilasSeleccionadas[0]));

                    this.txtDescOperacion.Text = drvFilaSeleccionada[1].ToString();
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

        private void FormABMIngresosEgresos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gestionCC.IngresosEgresos' Puede moverla o quitarla según sea necesario.
            this.ingresosEgresosTableAdapter.Fill(this.gestionCC.IngresosEgresos);

        }
    }
}