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
        float Tarjeta, Cheque, Efectivo, CuentaCorriente,Importe;
        bool Combinado;

        public FormaPagoCombinada()
        {
            InitializeComponent();
        }

        public FormaPagoCombinada(float Efectivo, float Tarjeta, float Cheque, float CuentaCorriente, bool Combinado, float Importe)
        {
            this.Importe = Importe;
            this.lblMontoTotal.Text = lblMontoTotal.Text + Importe.ToString();
            this.lblMontoRestante.Text = lblMontoRestante.Text + (Importe - Efectivo - Tarjeta - Cheque - CuentaCorriente).ToString();
            this.Efectivo = Efectivo;
            this.Cheque = Cheque;
            this.CuentaCorriente = CuentaCorriente;
            this.Tarjeta = Tarjeta;
            this.Combinado = Combinado;
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
                Efectivo = float.Parse(this.txtEfectivo.Text);

                this.lblMontoRestante.Text = lblMontoRestante.Text.Split(':')[0] + (Importe - Efectivo - Tarjeta - Cheque - CuentaCorriente).ToString();

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
                Tarjeta = float.Parse(this.txtTarjeta.Text);

                this.lblMontoRestante.Text = lblMontoRestante.Text.Split(':')[0] + (Importe - Efectivo - Tarjeta - Cheque - CuentaCorriente).ToString();

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
                this.Cheque = float.Parse(this.txtCheque.Text);

                e.Handled = true; // quitamos caracter

                this.lblMontoRestante.Text = lblMontoRestante.Text.Split(':')[0] + (Importe - Efectivo - Tarjeta - Cheque - CuentaCorriente).ToString();
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
                CuentaCorriente = float.Parse(this.txtCuentaCorriente.Text);

                e.Handled = true; // quitamos caracter

                this.lblMontoRestante.Text = lblMontoRestante.Text.Split(':')[0] + (Importe - Efectivo - Tarjeta - Cheque - CuentaCorriente).ToString();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (float.Parse(lblMontoTotal.Text.Split(':')[1]) != float.Parse(lblMontoRestante.Text.Split(':')[1]))
                XtraMessageBox.Show("Hay diferencias entre el pago y el monto total", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Combinado = true;
                this.Dispose();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Combinado = false;
            this.Dispose();
        }
    }
}