using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Presentacion
{
    public partial class FormCancelacionVenta :DevExpress.XtraEditors.XtraForm
    {
        Negocio.VentasNegocio CadVenta = new Negocio.VentasNegocio();

        int IntId_Venta;
        int IntId_Cliente;
        float FltImporteTotal;
        string FormaPago;


        public int intId_Venta
        {

            get { return IntId_Venta; }
            set { IntId_Venta = value; }

        }

        public string formaPago
        
        {
    

            get { return FormaPago; }
            set { FormaPago = value; }

        }




        public int intId_Cliente
        {

            get { return IntId_Cliente; }
            set { IntId_Cliente = value; }

        }


        public float fltImporteTotal
        {

            get { return FltImporteTotal; }
            set { FltImporteTotal = value; }

        }



        
        public FormCancelacionVenta()
        {
            InitializeComponent();

            this.txtFechaCancelacion.Text = DateTime.Today.ToShortDateString();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.metodoBtnAceptarClick();
            this.Dispose();
        }

        private void metodoBtnAceptarClick()
        {
            if (this.validarDatosFormulario())
            {
                string strMotivoCancelacion = this.txtMotivoCancelacion.Text;
                string strFechaCancelacion = this.txtFechaCancelacion.Text;
                string FormaPago = formaPago;
                
                CadVenta.CancelarVenta(IntId_Venta,IntId_Cliente,FltImporteTotal,FormaPago);

                
    
            }



            XtraMessageBox.Show("Se ha eliminado la venta correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            

            
        } 


        private bool validarDatosFormulario()
        {
            bool bolBandera = true;
            string strIncorrecto = "Se han producido los siguientes errores: \n\n";

            //if (this.txtMotivoCancelacion.Text == "")
            //{
            //    strIncorrecto = strIncorrecto + "-No ha ingresado ningún Usuario\n";
            //    bolBandera = false;
            //}

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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Presentacion.FormVentasCliente FormVentaCliene = new FormVentasCliente();

            //FormVentaCliene.ActualizarGrillaVenta();
        }

        
    }
}