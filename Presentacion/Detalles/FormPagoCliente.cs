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
    public partial class FormCiereCaja : DevExpress.XtraEditors.XtraForm 
    {
        public FormCiereCaja()
        {
            InitializeComponent();

        }




   
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.metodoBtnCancelarClick();
        }

        private void metodoBtnCancelarClick()
        {
            this.Dispose();
        }

       

    

        public void FormPagoCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.metodoBtnCancelarClick();
        }

        private void FormPagoCliente_Load(object sender, EventArgs e)
        {
            
        }

        

       
  

   

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            Negocio.CajaDiariaNegocios CajaDiaria = new Negocio.CajaDiariaNegocios();

                DateTime Fecha = DateTime.Parse(FechaCierre.Value.ToShortDateString());
                DateTime FechaPos = Fecha.AddDays(1);
                CajaDiaria.CerrarCaja(Fecha, FechaPos);

                this.Close();

        }

        private void FormCiereCaja_Load(object sender, EventArgs e)
        {

        }
        
    }
}