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
    public partial class GestionCaja : DevExpress.XtraEditors.XtraForm
    {

        char chrEstado;
        Negocio.MarcaNegocios Marca = new Negocio.MarcaNegocios();
        
        
        public GestionCaja()
        {
            InitializeComponent();
        }



        string privilegio;

        public string Privilegio
        {

            get { return privilegio; }
            set { privilegio = value; }

        }




        private void FormABMTipoArticulo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gestionCC.ViResultadoCajaDiaria' Puede moverla o quitarla según sea necesario.
            this.viResultadoCajaDiariaTableAdapter.Fill(this.gestionCC.ViResultadoCajaDiaria);

            if (Privilegio == "Administrador")
            {

                btnAgregarEgreso.Enabled = true;

            }
            else
            {


                btnAgregarEgreso.Enabled = false;
            }
                
        }

        private void btnAgregarTipoArticulo_Click(object sender, EventArgs e)
        {
            AltaIngreso();
        }

        private void AltaIngreso()
        {
           chrEstado = 'I';
           grbDatosTiposArticulos.Visible = true;

           grbDatosTiposArticulos.Text = "Alta de Ingreso";

           //Limpio los txtbox.
           txtDescOperacion.Clear();
            txtImporteOperacion.Clear();
            txtDescOperacion.Visible = true;
            txtImporteOperacion.Visible = true;
            lblDescripcionTipoArticulo.Visible = true;
            lblImporte.Visible = true;
        }
           
        

        private void btnModificarTipoArticulo_Click(object sender, EventArgs e)
        {
            AltaEgreso();
        }

        private void AltaEgreso()
        {
            chrEstado = 'E';
            grbDatosTiposArticulos.Visible = true;

            grbDatosTiposArticulos.Text = "Alta de Egreso";

            //Limpio los txtbox.
            txtDescOperacion.Clear();
            txtImporteOperacion.Clear();
            txtDescOperacion.Visible = true;
            txtImporteOperacion.Visible = true;
            lblDescripcionTipoArticulo.Visible = true;
            lblImporte.Visible = true;
        }
        

        

        

        private void btnGuardarTipoArticulo_Click(object sender, EventArgs e)
        {
            GuardarDatos();
        }

        private void GuardarDatos()
        {
            DateTime FechaOperacion = DateTime.Parse(dtpFecha.Value.ToShortDateString());
            
            Negocio.CajaDiariaNegocios CajaDiaria = new Negocio.CajaDiariaNegocios();

            try
            {

                if (chrEstado == 'I')
                {
                    string DescOperacion = txtDescOperacion.Text.ToString();
                    float ImporteOperacion = float.Parse(txtImporteOperacion.Text.ToString());

                    CajaDiaria.AgregarIngreso(FechaOperacion, DescOperacion, ImporteOperacion);
                }

                if (chrEstado == 'E')
                {
                    string DescOperacion = txtDescOperacion.Text.ToString();
                    float ImporteOperacion = float.Parse(txtImporteOperacion.Text.ToString());

                    CajaDiaria.AgregarEgreso(FechaOperacion, DescOperacion, ImporteOperacion);
                }



                XtraMessageBox.Show("Se agregó la operación correctamente", "Alta Ingreso/Egreso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.viResultadoCajaDiariaTableAdapter.Fill(this.gestionCC.ViResultadoCajaDiaria);

                grbDatosTiposArticulos.Visible = false;
            }

            catch 
            {

                XtraMessageBox.Show("No pudo agregarse la operación solicitada", "Alta Ingreso/Egreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
           grbDatosTiposArticulos.Visible = false;
        }

        private void grbDatosTiposArticulos_Enter(object sender, EventArgs e)
        {

        }

        private void btnCerrarCaja_Click(object sender, EventArgs e)
        {

            chrEstado = 'C';


            FormCiereCaja CierreCaja = new FormCiereCaja();
            
            CierreCaja.ShowDialog();

            

            this.viResultadoCajaDiariaTableAdapter.Fill(this.gestionCC.ViResultadoCajaDiaria);

        }

      
        
  
    }
}


