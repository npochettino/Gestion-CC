using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Datos;

namespace Presentacion
{
    public partial class Config : DevExpress.XtraEditors.XtraForm
    {
        public Config()
        {
            InitializeComponent();

            LoadData(new ConfigDatos().Select());

            btnAplicar.Enabled = false;
        }

        private void LoadData(DataTable oDataTable)
        {
            chkPregunta.Checked = Convert.ToBoolean(oDataTable.Rows[0]["AlwaysAsk"]);
            chkAutomatico.Checked = Convert.ToBoolean(oDataTable.Rows[0]["AlwaysSend"]);

            txtContrasena.Text = oDataTable.Rows[0]["Password"].ToString();
            txtMailEnvio.Text = oDataTable.Rows[0]["MailFrom"].ToString();
            txtTextoPorDefecto.Text = oDataTable.Rows[0]["DefaultText"].ToString();
        }

        private void txtMailEnvio_KeyPress(object sender, KeyPressEventArgs e)
        {
            btnAplicar.Enabled = true;
        }

        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            btnAplicar.Enabled = true;
        }

        private void txtTextoPorDefecto_KeyPress(object sender, KeyPressEventArgs e)
        {
            btnAplicar.Enabled = true;
        }

        private void chkAutomatico_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAutomatico.Checked)
            {
                chkPregunta.Checked = true;
                chkPregunta.Enabled = false;
            }
            else
                chkPregunta.Enabled = true;

            btnAplicar.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea guardar los cambios?", "Información", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                new ConfigDatos().Update(chkAutomatico.Checked, chkPregunta.Checked, txtContrasena.Text, txtMailEnvio.Text, txtTextoPorDefecto.Text);
                MessageBox.Show("La configuración ha sido guardada exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnAplicar.Enabled = false;
            }
        }
    }
}