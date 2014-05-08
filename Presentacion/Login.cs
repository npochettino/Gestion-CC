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
    public partial class LogIn : DevExpress.XtraEditors.XtraForm
    {

        Negocio.UsuariosNegocios Usuario = new Negocio.UsuariosNegocios();


        
        public LogIn()
        {
            InitializeComponent();

            buscarLookAndFeel();

            txtContrasena.PasswordChar = '*';



        }

        


        private void buscarLookAndFeel()
        {
            this.LookAndFeel.SkinName = Properties.Settings.Default.Skin;
            defaultLookAndFeel1.LookAndFeel.SkinName = Properties.Settings.Default.Skin;
        }

        private void btnIngresar_Click_1(object sender, EventArgs e)
        {
            this.metodoBtnIngresarClick();            
        }

        private void metodoBtnIngresarClick()
        {
            if (this.validarDatosFormulario() && this.validarUsuarioYContrasena())
            {
              
                FormPrincipal formPrincipal = new FormPrincipal();

                this.Hide();

                //Obtengo el nivel de usuario del operador

                DataSet dsUsuario = new DataSet();

                string usuario = txtUsuario.Text;
                string pass = txtContrasena.Text;


                dsUsuario = Usuario.ObtenerPrivilegio(usuario, pass);



                string Privilegio = dsUsuario.Tables["Usuario"].Rows[0][0].ToString();

                formPrincipal.Privilegio = Privilegio;

                


                
                formPrincipal.CargarPrivilegios();
                formPrincipal.ShowDialog();
                this.buscarLookAndFeel();
                
                //Limpiamos los TextBoxes preparando el Form para un nuevo Logueo
                this.txtContrasena.Text = "";
                this.txtUsuario.Text = "";
                this.Show();
            }
        }

        private bool validarUsuarioYContrasena()
        {
            string strIncorrecto = "Se han producido los siguientes errores: \n\n";

            if(!Usuario.ValidadUsuario(txtUsuario.Text, txtContrasena.Text))
            {
                strIncorrecto = strIncorrecto + "-El Usuario y/o Contraseña ingresados no son correctos";
                XtraMessageBox.Show(strIncorrecto, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        //Se ocupa de realizar las validaciones de los campos que se encuentran en el formulario
        private bool validarDatosFormulario()
        {
            bool bolBandera = true;
            string strIncorrecto = "Se han producido los siguientes errores: \n\n";

            if (this.txtUsuario.Text == "")
            {
                strIncorrecto = strIncorrecto + "-No ha ingresado ningún Usuario\n";
                bolBandera = false;
            }

            if (this.txtContrasena.Text == "")
            {
                strIncorrecto = strIncorrecto + "-El campo Contraseña está vacío";
                bolBandera = false;
            }

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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}