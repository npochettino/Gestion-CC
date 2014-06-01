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
    public partial class FormPagoCliente : DevExpress.XtraEditors.XtraForm 
    {
        public FormPagoCliente()
        {
            InitializeComponent();

            this.chkReporte.Visible = false;

            this.txtFechaDePago.Text = DateTime.Today.Date.ToShortDateString();
        }




        int Id_Cliente;

        public int id_cliente
        {
            get { return Id_Cliente; }
            set { Id_Cliente = value; }

        }



        

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.metodoBtnCancelarClick();
        }

        private void metodoBtnCancelarClick()
        {
            this.Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.metodoBtnAceptarClick();
        }

        private void metodoBtnAceptarClick()
        {
            if (this.validarDatosDelFormulario())
            {


                barButtonItem1.Enabled = true;
            }

            float Monto = float.Parse(txtMonto.Text);
            string FechaPago= txtFechaDePago.Text;
            

            Negocio.PagoEfectuadoNegocio CadPagoCliente = new Negocio.PagoEfectuadoNegocio();

            
            try
            {
                CadPagoCliente.AgregarPago(id_cliente, FechaPago, Monto);

                XtraMessageBox.Show("Se agregó el pago correctamente", "Alta Pago Efectuado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception Ex)
            {
                XtraMessageBox.Show(Ex.ToString(), "Ha ocurrido un problema, intentelo mas tarde", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        
        }


        private bool validarDatosDelFormulario()
        {
            string incorrecto = "Se han producido los siguientes errores: \n\n";
            bool bandera=true;

            if (this.txtMonto.Text == "")
            {
                incorrecto = incorrecto + "-Complete el campo Monto\n\n";
                bandera = false;
            }

            if (!bandera)
            {
                XtraMessageBox.Show(incorrecto, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == (int)Keys.Return)
            {
                // cualquier cosa;
                return;
            }

            // coma decimal
            if (e.KeyChar == 44)
            {
                if (this.txtMonto.Text.IndexOf(",") >= 0)
                    e.Handled = true;
                return;
            }

            // del cero al nueve only,...y backspace
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true; // quitamos caracter
        }

        public void FormPagoCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.metodoBtnCancelarClick();
        }

        private void FormPagoCliente_Load(object sender, EventArgs e)
        {
            
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormReportePago frmReportePago = new FormReportePago();
            frmReportePago.ShowDialog();
        }

        private void txtMonto_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == (int)Keys.Return)
            {
                // cualquier cosa;
                return;
            }

            // coma decimal
            if (e.KeyChar == 44)
            {
                if (this.txtMonto.Text.IndexOf(",") >= 0)
                    e.Handled = true;
                return;
            }

            // del cero al nueve only,...y backspace
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true; // quitamos caracter
        }
        
    }
}