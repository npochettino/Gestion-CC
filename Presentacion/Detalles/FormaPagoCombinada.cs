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
    public partial class FormaPagoCombinada : DevExpress.XtraEditors.XtraForm
    {
        public float Tarjeta, Cheque, Efectivo, CuentaCorriente,Importe;
        bool Combinado; FormAMVenta Source;

        public FormaPagoCombinada()
        {
            InitializeComponent();

            
        }

        public FormaPagoCombinada(FormAMVenta Venta,float Efectivo,float Tarjeta,float Cheque,float CuentaCorriente,bool Combinado, float Importe) : this()
        {
            this.Importe = Importe;
            this.lblMontoTotal.Text = lblMontoTotal.Text + Importe.ToString();
            this.lblMontoRestante.Text = lblMontoRestante.Text + (Importe - Efectivo - Tarjeta - Cheque - CuentaCorriente).ToString();

            Source = Venta;
            Venta.Efectivo = Efectivo;
            Venta.Cheque = Cheque;
            Venta.CuentaCorriente = CuentaCorriente;
            Venta.Tarjeta = Tarjeta;
            Venta.Combinado = Combinado;
        }

        private void txtEfectivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == (int)Keys.Back)
            {
                // cualquier cosa;
                return;
            }

            // punto decimal
            if (e.KeyChar == 44)
            {
                if (this.txtEfectivo.Text.IndexOf(",") >= 0)
                    e.Handled = true;
                return;
            }

            // del cero al nueve only,...y backspace
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true; // quitamos caracter
            }
        }

        private void txtTarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == (int)Keys.Back)
            {
                // cualquier cosa;
                return;
            }

            // punto decimal
            if (e.KeyChar == 44)
            {
                if (this.txtTarjeta.Text.IndexOf(",") >= 0)
                    e.Handled = true;
                return;
            }

            // del cero al nueve only,...y backspace
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true; // quitamos caracter
            }
        }

        private void txtCheque_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == (int)Keys.Back)
            {
                // cualquier cosa;
                return;
            }

            // punto decimal
            if (e.KeyChar == 44)
            {
                if (this.txtCheque.Text.IndexOf(",") >= 0)
                    e.Handled = true;
                return;
            }

            // del cero al nueve only,...y backspace
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true; // quitamos caracter

                
            }
        }

        private void txtCuentaCorriente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == (int)Keys.Back)
            {
                // cualquier cosa;
                return;
            }

            // punto decimal
            if (e.KeyChar == 44)
            {
                if (this.txtCuentaCorriente.Text.IndexOf(",") >= 0)
                    e.Handled = true;
                return;
            }

            // del cero al nueve only,...y backspace
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true; // quitamos caracter
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            float MontoTotal = float.Parse(lblMontoTotal.Text.Split(':')[1]);
            float MontoRestante = float.Parse(lblMontoRestante.Text.Split(':')[1]);

            if (0 != float.Parse(lblMontoRestante.Text.Split(':')[1]))
                XtraMessageBox.Show("Hay diferencias entre el pago y el monto total", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Combinado = true;
                Source.Efectivo = float.Parse(txtEfectivo.Text);
                Source.Tarjeta = float.Parse(txtTarjeta.Text);
                Source.CuentaCorriente = float.Parse(txtCuentaCorriente.Text);
                Source.Cheque = float.Parse(txtCheque.Text);
                Source.Combinado = true;

                

                this.Dispose();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Source.Combinado = false;
            
            this.Dispose();

        }

        private void txtEfectivo_KeyUp(object sender, KeyEventArgs e)
        {
            Efectivo = this.txtEfectivo.Text == "" ? 0 : float.Parse(this.txtEfectivo.Text);
            this.lblMontoRestante.Text = lblMontoRestante.Text.Split(':')[0] + ":" + (Importe - Efectivo - Tarjeta - Cheque - CuentaCorriente).ToString();
        }

        private void txtTarjeta_KeyUp(object sender, KeyEventArgs e)
        {
            Tarjeta = this.txtTarjeta.Text == "" ?  0 : float.Parse(this.txtTarjeta.Text);
            this.lblMontoRestante.Text = lblMontoRestante.Text.Split(':')[0] + ":" + (Importe - Efectivo - Tarjeta - Cheque - CuentaCorriente).ToString();
        }

        private void txtCheque_KeyUp(object sender, KeyEventArgs e)
        {
            this.Cheque = this.txtCheque.Text == "" ? 0 : float.Parse(this.txtCheque.Text);
            this.lblMontoRestante.Text = lblMontoRestante.Text.Split(':')[0] + ":" + (Importe - Efectivo - Tarjeta - Cheque - CuentaCorriente).ToString();
        }

        private void txtCuentaCorriente_KeyUp(object sender, KeyEventArgs e)
        {
            CuentaCorriente = this.txtCuentaCorriente.Text == "" ? 0 : float.Parse(this.txtCuentaCorriente.Text);
            this.lblMontoRestante.Text = lblMontoRestante.Text.Split(':')[0] + ":" + (Importe - Efectivo - Tarjeta - Cheque - CuentaCorriente).ToString();
        }
    }
}