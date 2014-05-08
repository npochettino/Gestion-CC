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
    public partial class FormABMGastos : DevExpress.XtraEditors.XtraForm
    {

        char chrEstado;
        Negocio.GastoNegocios Gasto = new Negocio.GastoNegocios();
        
        
        public FormABMGastos()
        {
            InitializeComponent();
        }

        private void FormABMTipoArticulo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gestionCC.Gasto' Puede moverla o quitarla según sea necesario.
            this.gastoTableAdapter.Fill(this.gestionCC.Gasto);
            
        }

        private void btnAgregarTipoArticulo_Click(object sender, EventArgs e)
        {
            AltaGasto();
        }

        private void AltaGasto()
        {
            chrEstado = 'A';
           grbDatosTiposArticulos.Visible = true;

           grbDatosTiposArticulos.Text = "Alta de Gasto";

            //Limpio los txtbox.
            txtDescGasto.Clear();

        }

        private void btnModificarTipoArticulo_Click(object sender, EventArgs e)
        {
            CargaDatos();
        }

        private void CargaDatos()
        {
            grbDatosTiposArticulos.Text = "Modificación de Gasto";

           int[] arrIntFilasSeleccionadas = ((GridView)this.dtGasto.MainView).GetSelectedRows();

            if (arrIntFilasSeleccionadas.Length != 0)
            {
                chrEstado = 'M';
                grbDatosTiposArticulos.Visible = true;

                DataRowView drvFilaSeleccionada = (DataRowView)(((GridView)dtGasto.MainView).GetRow(arrIntFilasSeleccionadas[0]));

                this.txtDescGasto.Text = drvFilaSeleccionada[1].ToString();
                this.txtImporteGasto.Text = drvFilaSeleccionada[2].ToString();
                this.dtpFechaPago.Value = DateTime.Parse(drvFilaSeleccionada[3].ToString());
                if(drvFilaSeleccionada[4].ToString() =="S")
                {
                    chkAfectaCaja.Checked = true;
                }
                else
                {
                    chkAfectaCaja.Checked = false;
                }
            }
            else
            {
                XtraMessageBox.Show("Seleccione un Gasto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminarTipoArticulo_Click(object sender, EventArgs e)
        {
            EliminarGasto();
        }

        private void EliminarGasto()
        {        
                int[] arrIntFilasSeleccionadas = ((GridView)this.dtGasto.MainView).GetSelectedRows();

                if (arrIntFilasSeleccionadas.Length != 0)
                {
                    DataRowView drvFilaSeleccionada = (DataRowView)(((GridView)dtGasto.MainView).GetRow(arrIntFilasSeleccionadas[0]));

                    int intIdMarca = Convert.ToInt32(drvFilaSeleccionada[0].ToString());
                    string strMarca = drvFilaSeleccionada[1].ToString();

                    if (XtraMessageBox.Show("¿Esta seguro que desea eliminar el Gasto " + strMarca + "? ", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        try
                        {
                            Gasto.EliminarGasto(intIdMarca);
                            XtraMessageBox.Show("Se ha eliminado el Gasto " + strMarca+ " con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                            this.gastoTableAdapter.Fill(gestionCC.Gasto);
                        }
                        catch (Exception Ex)
                        {
                            XtraMessageBox.Show(Ex.ToString(), "Eliminar Gasto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    XtraMessageBox.Show("Seleccione una Gasto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
        }

        private void btnGuardarTipoArticulo_Click(object sender, EventArgs e)
        {
            GuardarDatos();
        }

        private void GuardarDatos()
        {
           string strDescripcionGasto = txtDescGasto.Text;
           float fltImporteGasto = float.Parse(txtImporteGasto.Text);
           string dtmFechaGasto = dtpFechaPago.Value.ToShortDateString();
           char AfectaCaja;
           
            if (chkAfectaCaja.Checked==true)
            {
                AfectaCaja = 'S';
            
            }
            else
            {
                AfectaCaja = 'N';
            
            }

            if (validarDatosDelForm())
            {
                if (chrEstado == 'A')
                {
                    try
                    {
                        Gasto.AgregarGasto(strDescripcionGasto, fltImporteGasto, dtmFechaGasto,AfectaCaja);

                        XtraMessageBox.Show("Se agregó la gasto correctamente", "Alta gasto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        this.gastoTableAdapter.Fill(gestionCC.Gasto);
                    
                    
                    }
                    catch (Exception Ex)
                    {
                        XtraMessageBox.Show(Ex.ToString(), "Eliminar Gasto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (chrEstado == 'M')
                {

                    try
                    {
                        int[] arrIntFilasSeleccionadas = ((GridView)this.dtGasto.MainView).GetSelectedRows();

                        DataRowView drvFilaSeleccionada = (DataRowView)(((GridView)dtGasto.MainView).GetRow(arrIntFilasSeleccionadas[0]));

                        int Id_Gasto = Convert.ToInt32(drvFilaSeleccionada[0]);

                        Gasto.ModificarGasto(Id_Gasto,strDescripcionGasto,fltImporteGasto,dtmFechaGasto,AfectaCaja);

                        XtraMessageBox.Show("Se modificó la marca correctamente", "Modificación Gasto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        this.gastoTableAdapter.Fill(gestionCC.Gasto);
                    
                    }
                    catch (Exception Ex)
                    {
                        XtraMessageBox.Show(Ex.ToString(), "Eliminar Gasto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                 grbDatosTiposArticulos.Visible = false;
                this.gastoTableAdapter.Fill(this.gestionCC.Gasto);
            }
        }

        private bool validarDatosDelForm()
        {
            bool bandera = true;
            string errores = "Por favor, corrija los siguientes errores: \n\n";

            if (this.txtDescGasto.Text == "")
            {
                bandera = false;
                errores = errores + "-Complete el campo Descripción\n";
            }

            if (this.txtImporteGasto.Text== "")
            {
                bandera = false;
                errores = errores + "-Complete el campo Importe\n";
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
                    int[] arrIntFilasSeleccionadas = ((GridView)this.dtGasto.MainView).GetSelectedRows();

                    DataRowView drvFilaSeleccionada = (DataRowView)(((GridView)dtGasto.MainView).GetRow(arrIntFilasSeleccionadas[0]));

                    this.txtDescGasto.Text = drvFilaSeleccionada[1].ToString();
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