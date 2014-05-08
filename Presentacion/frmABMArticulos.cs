using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System.Data;

namespace Presentacion
{
    public partial class frmABMArticulos : DevExpress.XtraEditors.XtraForm
    {
        Negocio.ArticulosNegocio CadArticulo = new Negocio.ArticulosNegocio();
        char chrEstado;
        float Costo = 0;
        

        public frmABMArticulos()
        {
            InitializeComponent();


        }


        string privilegio;

        public string Privilegio
        {

            get { return privilegio; }
            set { privilegio = value; }

        }

      

        private void frmABMArticulos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gestionCC.Marca' Puede moverla o quitarla según sea necesario.
            this.marcaTableAdapter.Fill(this.gestionCC.Marca);
            // TODO: esta línea de código carga datos en la tabla 'gestionCC.TipoArticulo' Puede moverla o quitarla según sea necesario.
            this.tipoArticuloTableAdapter.Fill(this.gestionCC.TipoArticulo);
            // TODO: esta línea de código carga datos en la tabla 'gestionCC.ArticulosEmpresa' Puede moverla o quitarla según sea necesario.
            this.articulosEmpresaTableAdapter.Fill(this.gestionCC.ArticulosEmpresa);
            // TODO: esta línea de código carga datos en la tabla 'gestionCC.ArticuloParaVenta' Puede moverla o quitarla según sea necesario.
          //  this.articuloParaVentaTableAdapter.Fill(this.gestionCC.ArticuloParaVenta);
            // TODO: esta línea de código carga datos en la tabla 'gestionCC.ArticulosEmpresa' Puede moverla o quitarla según sea necesario.
            this.articulosEmpresaTableAdapter.Fill(this.gestionCC.ArticulosEmpresa);
            // TODO: esta línea de código carga datos en la tabla 'gestionCC.Articulo' Puede moverla o quitarla según sea necesario.
           // this.articuloTableAdapter.Fill(this.gestionCC.Articulo);

            this.tipoArticuloTableAdapter.Fill(this.gestionCC.TipoArticulo);


                
        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            txtCosto.Visible = true;
            txtStock.Enabled = true;
            Agregar();
        }

        private void Agregar()
        {
            chrEstado = 'A';
            grbDatosArticulos.Visible = true;

            grbDatosArticulos.Text = "Alta Articulo";

            //Voy a buscar el ultimo codigo cargado y relleno el campo codigo con el consecutivo

            DataSet dsArticulo = new System.Data.DataSet();
            
           dsArticulo = CadArticulo.BuscarUltimoCodigo();

           
            string UltimoCodigo =dsArticulo.Tables["Articulo"].Rows[0][0].ToString();
            int Posterior = Convert.ToInt32(UltimoCodigo)+1; 

            //Limpio los txtbox.
            txtDescripcionArticulo.Clear();
            txtPrecioArticulo.Clear();
            txtCodigo.Text = Posterior.ToString();
            txtStock.Clear();
            txtCosto.Clear();
            txtTalle.Clear();
        
        
        
        }



        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            grbDatosArticulos.Visible = false;
        }

        private void btnGuardarArticulo_Click(object sender, EventArgs e)
        {
            if (validarDatosDelForm())
                GuardarDatos();
            
        }

        private void GuardarDatos()
        {
            string DescripcionArticulo = txtDescripcionArticulo.Text;
            float Precio = float.Parse(txtPrecioArticulo.Text);
            int TipoProducto = Convert.ToInt16(cmbTipoArticulo.SelectedValue.ToString());

            string codigo=string.Empty;

            if(this.txtCodigo.Text.Length<5)
            {
                for(int i=0;i<5-txtCodigo.Text.Length;i++)
                    codigo +="0";
                codigo += this.txtCodigo.Text;
            }
            else
            codigo =this.txtCodigo.Text;

            int stock = Convert.ToInt16(txtStock.Text);
            int Marca = Convert.ToInt16(cmbMarca.SelectedValue.ToString());
            
            if (txtCosto.Text!="")
            {
            Costo = float.Parse(txtCosto.Text);
            }
            string Talle = txtTalle.Text;

            if (this.validarDatosDelForm())
            {
                if (chrEstado == 'A')
                {
                    
                    try
                    {
                       CadArticulo.AgregarArticulo(DescripcionArticulo, Precio, TipoProducto,codigo,stock,Marca,Costo,Talle);

                        XtraMessageBox.Show("Se agregó el Artículo correctamente", "Alta de Artículo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.articulosEmpresaTableAdapter.Fill(this.gestionCC.ArticulosEmpresa);

                        
                    
                    }
                    catch (Exception Ex)
                    {
                        XtraMessageBox.Show(Ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (chrEstado == 'M')
                {
                    
                    try
                    {
                        int[] arrIntFilasSeleccionadas = ((GridView)this.dtDatosArticulos.MainView).GetSelectedRows();

                        DataRowView drvFilaSeleccionada = (DataRowView)(((GridView)dtDatosArticulos.MainView).GetRow(arrIntFilasSeleccionadas[0]));

                       int Id_Articulo = Convert.ToInt32(drvFilaSeleccionada[0]);

                        CadArticulo.ModificarArticulo(DescripcionArticulo, Precio, TipoProducto, Id_Articulo,codigo,stock,Marca,Costo,Talle);

                        XtraMessageBox.Show("Se modificó el artículo correctamente", "Modificación de Artículo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
       
                        //obtener la posicion de fila que acabo de modificar.

                        int Posicion = arrIntFilasSeleccionadas[0];

                        //Actualizar la grilla para que se vean los cambios.
                        
                        this.articulosEmpresaTableAdapter.Fill(this.gestionCC.ArticulosEmpresa);
                        
                        //Ir a la fila de la posicion seleccioada

                        gridView1.FocusedRowHandle = Posicion;
                    
                    
                    }
                    catch (Exception Ex)
                    {
                        XtraMessageBox.Show(Ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                grbDatosArticulos.Visible = false;
            }

            //this.articuloBindingSource.Fill(this.gestionCC.Articulo);
            this.tipoArticuloTableAdapter.Fill(this.gestionCC.TipoArticulo);
        }

        private bool validarDatosDelForm()
        {
            bool bandera = true;
            string errores = "Por favor, corrija los siguientes errores: \n\n";

            if (this.txtCodigo.Text == "")
            {
                bandera = false;
                errores = errores + "-Complete el campo Código\n";
            }

            if (this.txtDescripcionArticulo.Text == "")
            {
                bandera = false;
                errores = errores + "-Complete el campo Descripción\n";
            }

            if (this.cmbTipoArticulo.SelectedItem == null)
            {
                bandera = false;
                errores = errores + "-Agregue un Tipo de Artículo\n";
            }

            if (this.txtPrecioArticulo.Text == "")
            {
                bandera = false;
                errores = errores + "-Complete el campo Precio\n";
            }

            if (this.txtPrecioArticulo.Text != "" && this.txtPrecioArticulo.Text.Substring(0, 1) == ",")
            {
                bandera = false;
                errores = errores + "-El Precio ingresado no es válido";
            }


            if (this.txtDescripcionArticulo.Text.Length > 20)
            {
                bandera = false;
                errores = errores + "-La Descripción supera los 20 Caracteres";
            }


            if (this.txtStock.Text == "")
            {
                bandera = false;
                errores = errores + "-Complete el campo Stock\n";
            }

            

            if (this.txtTalle.Text.Trim() == "")
            {
                bandera = false;
                errores = errores + "-Complete el campo Talle\n";
            }

           

            ////Voy a ver si esta repetido el codigo del articulo

            //DataSet bandera01;

            //bandera01 = CadArticulo.VerificarUnicidadCodigo(txtCodigo.Text);

            //int CodigoUnico = 0;
            // CodigoUnico = Convert.ToInt16(bandera01.Tables["Articulo"].Rows[0][0].ToString());

            //if (CodigoUnico!=0)
            //{
            //    bandera = false;
            //    errores = errores + "-El codigo seleccionado ya esta asignado\n";
            
            //}
            



            if (!bandera)
            {
                XtraMessageBox.Show(errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return bandera;
        }

        private void btnModificaraArticulo_Click(object sender, EventArgs e)
        {

            //Cargar los privilegios que posee el operador en cuestion

            if (Privilegio == "Administrador")
            {

                txtCosto.Visible = true;
                txtStock.Enabled = true;

            }
            else
            {

                txtCosto.Visible = false;
                txtStock.Enabled = false;

            }
                    
            //Cargo los datos
            CargarDatos();

            

            
        }

        private void CargarDatos()
        {
            chrEstado = 'M';


            try
            {
                int[] arrIntFilasSeleccionadas = ((GridView)this.dtDatosArticulos.MainView).GetSelectedRows();

                if (arrIntFilasSeleccionadas.Length != 0)
                {
                    grbDatosArticulos.Visible = true;
                    grbDatosArticulos.Text = "Modificación de articulo";

                    DataRowView drvFilaSeleccionada = (DataRowView)(((GridView)dtDatosArticulos.MainView).GetRow(arrIntFilasSeleccionadas[0]));

                    this.txtDescripcionArticulo.Text = drvFilaSeleccionada[1].ToString();
                    this.txtPrecioArticulo.Text = drvFilaSeleccionada[2].ToString();
                    this.cmbTipoArticulo.Text = drvFilaSeleccionada[3].ToString();
                    this.txtCodigo.Text = drvFilaSeleccionada[9].ToString();
                    this.txtStock.Text = drvFilaSeleccionada[5].ToString();
                    this.cmbMarca.Text = drvFilaSeleccionada[6].ToString();
                    this.txtCosto.Text = drvFilaSeleccionada[7].ToString();
                    this.txtTalle.Text = drvFilaSeleccionada[8].ToString();
                }
                else
                    XtraMessageBox.Show("No hay ningún Artículo seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);          
            }
            catch
            {
            }
        }

        private void dtDatosArticulos_Click(object sender, EventArgs e)
        {

           
            
            if (chrEstado == 'M') 
            
            {
                try
                {
                    int[] arrIntFilasSeleccionadas = ((GridView)this.dtDatosArticulos.MainView).GetSelectedRows();

                    DataRowView drvFilaSeleccionada = (DataRowView)(((GridView)dtDatosArticulos.MainView).GetRow(arrIntFilasSeleccionadas[0]));

                    this.txtDescripcionArticulo.Text = drvFilaSeleccionada[1].ToString();
                    this.txtPrecioArticulo.Text = drvFilaSeleccionada[3].ToString();
                    this.cmbTipoArticulo.Text = drvFilaSeleccionada[2].ToString();



                }
                catch
                {
                }
            
            
            
            
            
            }
        }

        private void btnEliminarArticulo_Click(object sender, EventArgs e)
        {
            EliminarArticulo();
        }

        private void EliminarArticulo()
        {
            try
            {
                int[] arrIntFilasSeleccionadas = ((GridView)this.dtDatosArticulos.MainView).GetSelectedRows();

                if (arrIntFilasSeleccionadas.Length != 0)
                {
                    DataRowView drvFilaSeleccionada = (DataRowView)(((GridView)dtDatosArticulos.MainView).GetRow(arrIntFilasSeleccionadas[0]));

                    string intIdArticulo = drvFilaSeleccionada[0].ToString();
                    string strArticulo = drvFilaSeleccionada[1].ToString();

                    if (XtraMessageBox.Show("¿Esta seguro que desea eliminar el articulo '" + strArticulo + "'? ", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        try
                        {
                            CadArticulo.BajaArticulo(intIdArticulo);
                            XtraMessageBox.Show("Se ha eliminado el articulo '" + strArticulo + "' con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);


                            this.articulosEmpresaTableAdapter.Fill(this.gestionCC.ArticulosEmpresa);
                        }
                        catch (Exception Ex)
                        {
                            XtraMessageBox.Show(Ex.ToString(), "Eliminar articulo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                    XtraMessageBox.Show("No hay ningún Artículo seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);          
            }
            catch
            {
                XtraMessageBox.Show("Ha ocurrido un error en la eliminación del articulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }

        private void btnAgregarTipoArticulo_Click(object sender, EventArgs e)
        {
            FormABMTipoArticulo TipoArticulo = new FormABMTipoArticulo();
            TipoArticulo.ShowDialog();

            this.tipoArticuloTableAdapter.Fill(this.gestionCC.TipoArticulo);
        }

        private void txtPrecioArticulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == (int)Keys.Back)
            {
                // cualquier cosa;
                return;
            }

            // punto decimal
            if (e.KeyChar == 44)
            {
                if (this.txtPrecioArticulo.Text.IndexOf(",") >= 0)
                    e.Handled = true;
                return;
            }

            // del cero al nueve only,...y backspace
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true; // quitamos caracter
        }

        private void txtDescripcionArticulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != 32))
            {
                e.Handled = true;
                return;
            }
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            Presentacion.FormABMarca Marcas = new FormABMarca();

            Marcas.ShowDialog();

            this.marcaTableAdapter.Fill(this.gestionCC.Marca);
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.txtStock.Text.Length < 8 || (e.KeyChar == 8))
            {
                if ((char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back))
                {
                    e.Handled = false;
                    return;
                }
                else
                {
                    e.Handled = true;
                    return;
                }
            }
            else
            {
                e.Handled = true;
                return;
            }
        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == (int)Keys.Back)
            {
                // cualquier cosa;
                return;
            }

            // punto decimal
            if (e.KeyChar == 44)
            {
                if (this.txtCosto.Text.IndexOf(",") >= 0)
                    e.Handled = true;
                return;
            }

            // del cero al nueve only,...y backspace
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true; // quitamos caracter
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.txtCodigo.Text.Length < 5 || (e.KeyChar == 8))
            {
                if ((char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back))
                {
                    e.Handled = false;
                    return;
                }
                else
                {
                    e.Handled = true;
                    return;
                }
            }
            else
            {
                e.Handled = true;
                return;
            }
        }
    }
}