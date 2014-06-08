using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System.Net.Mail;
using Datos;

namespace Presentacion
{
    public partial class FormAMVenta : DevExpress.XtraEditors.XtraForm
    {
        int idCliente;
        string StrNombreCliente;
        string StrApellidoCliente;

        float ImporteTotal = 0;

        public float _Tarjeta = 0, _Cheque = 0, _Efectivo = 0, _CuentaCorriente = 0;
        bool _Combinado = false;

        public float Tarjeta
        {
            get
            {
                return _Tarjeta;
            }
            set
            {
                _Tarjeta = value;
            }
        }

        public float Cheque
        {
            get
            {
                return _Cheque;
            }
            set
            {
                _Cheque = value;
            }
        }

        public float Efectivo
        {
            get
            {
                return _Efectivo;
            }
            set
            {
                _Efectivo = value;
            }
        }

        public float CuentaCorriente
        {
            get
            {
                return _CuentaCorriente;
            }
            set
            {
                _CuentaCorriente = value;
            }
        }

        public bool Combinado
        {
            get
            {
                return _Combinado;
            }
            set
            {
                _Combinado = value;
            }
        }

        Negocio.PagoEfectuadoNegocio CadPagoEfectuado = new Negocio.PagoEfectuadoNegocio();


        public int IdCliente
        {

            get { return idCliente; }
            set { idCliente = value; }

        }

        public string strNombreCliente
        {
            get { return StrNombreCliente; }
            set { StrNombreCliente = value; }
        }

        public string strApellidoCliente
        {
            get { return StrApellidoCliente; }
            set { StrApellidoCliente = value; }
        }

        public float _ImporteTotal
        {
            get { return ImporteTotal; }
            set { ImporteTotal = value; }
        }



        BindingList<AuxiliarVenta> gridDataList = new BindingList<AuxiliarVenta>();

        Negocio.VentasNegocio CadVentas = new Negocio.VentasNegocio();
        Negocio.VentaParcialNegocio CadVentasParcial = new Negocio.VentaParcialNegocio();
        Negocio.DetalleVentaNegocio CadDetalleVenta = new Negocio.DetalleVentaNegocio();

        public FormAMVenta()
        {
            InitializeComponent();

            this.dgvVenta.DataSource = gridDataList;

            repositoryItemTextEdit1.Mask.EditMask = "#########";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            CadVentasParcial.ReestablecerArticulos();

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmABMClientes ABMCliente = new frmABMClientes();

            ABMCliente.ShowDialog();
        }

        private void FormAMVenta_Load(object sender, EventArgs e)
        {

            RestablecerPantallaVenta();


            // TODO: esta línea de código carga datos en la tabla 'gestionCC.ArticuloParaVenta' Puede moverla o quitarla según sea necesario.
            this.articuloParaVentaTableAdapter1.Fill(this.gestionCC.ArticuloParaVenta);




            // TODO: esta línea de código carga datos en la tabla 'gestionCC.VentaParcial' Puede moverla o quitarla según sea necesario.
            this.ventaParcialTableAdapter.Fill(this.gestionCC.VentaParcial);
            // TODO: esta línea de código carga datos en la tabla 'gestionCC.Articulo' Puede moverla o quitarla según sea necesario.


            lblNombreCliente.Text = strApellidoCliente + " " + strNombreCliente;



        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {
            AgregarItem();
        }

        private void AgregarItem()
        {
            if (this.dgdArticulos.MainView.RowCount != 0)
            {
                int[] arrIntFilasSeleccionadas = ((GridView)this.dgdArticulos.MainView).GetSelectedRows();

                DataRowView drvFilaSeleccionada = (DataRowView)(((GridView)dgdArticulos.MainView).GetRow(arrIntFilasSeleccionadas[0]));

                int intIdArticulo = Convert.ToInt32(drvFilaSeleccionada[0]);
                string strDescripción = drvFilaSeleccionada[1].ToString();
                string strTipoArticulo = drvFilaSeleccionada[2].ToString();
                string strPrecio = drvFilaSeleccionada[3].ToString();
                int intId_TipoArticulo = Convert.ToInt32(drvFilaSeleccionada[4].ToString());
                float flCosto = float.Parse(drvFilaSeleccionada[7].ToString());
                int stock = Convert.ToInt32(drvFilaSeleccionada[6].ToString());


                if (flCosto > 0)
                {

                    gridDataList.Add(new AuxiliarVenta(intIdArticulo, strDescripción, strTipoArticulo, strPrecio, 1, flCosto, stock, 0));

                    CadVentasParcial.AgregarItem(intIdArticulo, strDescripción, intId_TipoArticulo);

                    this.articuloParaVentaTableAdapter1.Fill(this.gestionCC.ArticuloParaVenta);
                }


                else
                {
                    XtraMessageBox.Show("El Articulo no tiene Asignado Costo, Asignelo y luego realice la venta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }




            }
            else
            {
                XtraMessageBox.Show("No hay Artículos para vender", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnIzquierda_Click(object sender, EventArgs e)
        {
            this.quitarItem();
        }

        private void quitarItem()
        {
            if (this.dgvVenta.MainView.RowCount != 0)
            {
                int[] arrIntFilasSeleccionadas = ((GridView)this.dgvVenta.MainView).GetSelectedRows();



                AuxiliarVenta selRow = (AuxiliarVenta)(((GridView)this.dgvVenta.MainView).GetRow(arrIntFilasSeleccionadas[0]));

                int intIdArticulo = selRow.idArticulo;


                gridDataList.RemoveAt(gridView1.FocusedRowHandle);


                CadVentasParcial.QuitarItem(intIdArticulo);

                this.articuloParaVentaTableAdapter1.Fill(this.gestionCC.ArticuloParaVenta);

            }
            else
            {
                XtraMessageBox.Show("No hay Artículos para vender", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            AsignarValores();

            if (rdbCombinado.Checked == true)
            {
                if (Combinado)
                {
                    if (ValidarDatosDelForm())
                    {
                        Agregadodelaventa();
                        RestablecerPantallaVenta();
                    }
                }
                else
                {

                }
            }
            else
            {
                if (ValidarDatosDelForm())
                {
                    Agregadodelaventa();
                    RestablecerPantallaVenta();
                }
            }
        }

        private void Agregadodelaventa()
        {
            AgregarVenta();

            this.articuloParaVentaTableAdapter1.Fill(this.gestionCC.ArticuloParaVenta);

            if (float.Parse(txtEntrega.Text) > 0)
            {
                CadPagoEfectuado.AgregarPago(idCliente, DateTime.Now.ToString(), float.Parse(txtEntrega.Text));
            }

            //Voy a buscar el saldo actual del cliente luego de realizar la venta para mostrarlo en la pantalla.

            Negocio.ClientesNegocio Cliente = new Negocio.ClientesNegocio();

            DataSet dsSaldoCliente = new DataSet();

            dsSaldoCliente = Cliente.ConsultarSaldo(IdCliente);

            float Saldo = float.Parse(dsSaldoCliente.Tables["Cliente"].Rows[0][0].ToString());


            //Muestro En pantalla

            XtraMessageBox.Show("Se ha registrado la venta \r\n\r\n Cliente: " + lblNombreCliente.Text + " \r\n\r\n Importe Venta: " + _ImporteTotal + "\r\n\r\n Saldo Actual: " + Saldo + "", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.articuloParaVentaTableAdapter1.Fill(this.gestionCC.ArticuloParaVenta);

            EnviarCorreo();
        }

        private void EnviarCorreo()
        {
            DataTable oDataTable = new ConfigDatos().Select();

            if (Convert.ToBoolean(oDataTable.Rows[0]["AlwaysSend"]))
                EnvioMail(oDataTable);
            else
                if (Convert.ToBoolean(oDataTable.Rows[0]["AlwaysAsk"])&&XtraMessageBox.Show("Desea enviar un mail por la venta efectuada?","Pregunta",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
                    EnvioMail(oDataTable);
        }

        private void EnvioMail(DataTable oDataTable)    
        {
            Cursor.Current = Cursors.WaitCursor;

            DataTable oDataTableCliente = new ClientesDatos().SelectOne(idCliente);

            if (!String.IsNullOrEmpty(oDataTableCliente.Rows[0]["Email"].ToString()))
                Mailer.SendMail(oDataTable.Rows[0]["MailFrom"].ToString(), new ClientesDatos().SelectOne(idCliente).Rows[0]["Email"].ToString(), MailBody(), oDataTable.Rows[0]["Password"].ToString(), "Gracias por su compra!");
            else
                XtraMessageBox.Show("El mail no pudo ser enviado debido a que no tiene asignado ningun Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            Cursor.Current = Cursors.Default;
        }

        private string MailBody()
        {
            string Body= new ConfigDatos().Select().Rows[0]["DefaultText"].ToString() + "\n";

            for (int i = 0; i < dgvVenta.MainView.RowCount; i++)
            {
                AuxiliarVenta oAuxiliarVenta = (AuxiliarVenta)this.gridView1.GetRow(i);
                Body += "Descripcion: " + oAuxiliarVenta.descripcion + ", Cantidad: " + oAuxiliarVenta.cantidad.ToString() + ", Precio: $" + oAuxiliarVenta.precio.ToString() + ", Descuento: " + (oAuxiliarVenta.descuento).ToString() + "%, Precio Final: " + (float.Parse(oAuxiliarVenta.precio)*float.Parse(oAuxiliarVenta.cantidad.ToString())*(float.Parse((oAuxiliarVenta.descuento/100).ToString()))).ToString()  +"\n";
            }

            Body += "Importe Total: $" + CalcularImporte().ToString();

            return Body;
        }

        private void AsignarValores()
        {
            if (rdbCtaCte.Checked == true)
            {

                CuentaCorriente = CalcularImporte();
            }

            if (rdbEfectivo.Checked == true)
            {


                Efectivo = CalcularImporte();
            }


            if (rdbTarjeta.Checked == true)
            {

                Tarjeta = CalcularImporte();
            }

            if (rdbCheque.Checked == true)
            {

                Cheque = CalcularImporte();
            }

            if (rdbCombinado.Checked)
            {

                Efectivo = 0;
                Tarjeta = 0;
                Cheque = 0;
                CuentaCorriente = 0;

                FormaPagoCombinada oFormaPagoCombinada = new FormaPagoCombinada(this, Efectivo, Tarjeta, Cheque, CuentaCorriente, Combinado, CalcularImporte());
                oFormaPagoCombinada.ShowDialog();

            }
        }

        private bool ValidarDatosDelForm()
        {
            bool bandera = true;
            string errores = "Se han producido los siguientes errores:\n";
            if (this.lblNombreCliente.Text == " ")
            {
                bandera = false;
                errores += "-Seleccione un Cliente\n";
            }



            if (this.dgvVenta.MainView.RowCount == 0)
            {
                bandera = false;
                errores += "-No hay artículos registrados en la Venta\n";
            }

            if (this.dgvVenta.MainView.RowCount != 0 && !ValidarStock())
            {
                bandera = false;
                errores += "-Uno o màs artículos no cuentan con el stock suficiente\n";
            }

            if (!VerificarMontosAsignados(CalcularImporte()))
            {
                bandera = false;
                errores += "-El total de pago no coincide con el importe";
            }



            if (bandera)
            {
                return true;
            }
            else
            {
                XtraMessageBox.Show(errores, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }



        private void AgregarVenta()
        {
            DateTime DtmFechaVenta = dtpFechaVenta.Value;
            bool bolCtaCte = rdbCtaCte.Checked;


            float fltImportaTotalVenta = 0;

            float fltImporteCostoVenta = 0;
            //Primero agrego la venta en la tabla venta para luego agregar cada item venta y calcular el monto total de la venta.

            CadVentas.AgregarVenta(idCliente, DtmFechaVenta, Efectivo, Cheque, Tarjeta, CuentaCorriente);

            //Recorro la grilla de la venta para ir calculando por item.

            for (int i = 0; i < dgvVenta.MainView.RowCount; i++)
            {
                AuxiliarVenta row = (AuxiliarVenta)this.gridView1.GetRow(i);

                int intIdArticulo = row.idArticulo;
                int intCantidad = row.cantidad;
                float fltPrecio = float.Parse(row.precio);
                float fltCosto = row.costo;
                int stock = row.stock;
                string Descripcion = row.descripcion;
                int Descuento = row.descuento;

                //Agrego el item a la tabla de deatlle de venta

                CadDetalleVenta.AgregarItemDetalle(intIdArticulo, intCantidad, fltPrecio);

                //Sumar el importe de la venta

                fltImportaTotalVenta = float.Parse(Math.Round(fltImportaTotalVenta + ((fltPrecio * intCantidad) - ((fltPrecio * intCantidad) * Descuento / 100)), 2).ToString());

                //Sumar el costo de la venta
                fltImporteCostoVenta = fltImporteCostoVenta + (fltCosto * intCantidad);

                //Descuento el stock de el articulo por la cantidad de esta venta
                string Estado = "A";

                ActualizarStock(intIdArticulo, intCantidad, Estado);
            }
            //Actualizo el importe total de venta,el saldo del cliente y el costo de la venta
            CadVentas.ActualizarImporteTotal(fltImportaTotalVenta, IdCliente, fltImporteCostoVenta, CuentaCorriente);

            _ImporteTotal = fltImportaTotalVenta;

            Efectivo = 0;
            CuentaCorriente = 0;
            Tarjeta = 0;
            Cheque = 0;
        }

        private float CalcularImporte()
        {
            float Suma = 0;

            for (int i = 0; i < dgvVenta.MainView.RowCount; i++)
            {
                AuxiliarVenta row = (AuxiliarVenta)this.gridView1.GetRow(i);
                Suma = float.Parse(Math.Round(Suma + ((float.Parse(row.precio.ToString()) * float.Parse(row.cantidad.ToString())) - ((float.Parse(row.precio.ToString()) * float.Parse(row.cantidad.ToString())) * row.descuento / 100)), 2).ToString());
            }

            return Suma;
        }

        private bool VerificarMontosAsignados(float ImporteTotalVenta)
        {
            return ImporteTotalVenta == Efectivo + Cheque + Tarjeta + CuentaCorriente;
        }

        private bool ValidarStock()
        {
            for (int i = 0; i < dgvVenta.MainView.RowCount; i++)
            {
                AuxiliarVenta row = (AuxiliarVenta)this.gridView1.GetRow(i);

                if (row.stock < row.cantidad)
                {
                    return false;
                }
            }

            return true;
        }

        private void RestablecerPantallaVenta()
        {
            txtEntrega.Text = "0";
            float MontoParcial = 0;

            for (int j = 0; j < dgvVenta.MainView.RowCount; j++)
            {
                AuxiliarVenta row = (AuxiliarVenta)this.gridView1.GetRow(0);

                gridDataList.RemoveAt(0);

                CadVentasParcial.QuitarItem(row.idArticulo);
            }
            MontoParcial = 0;
            this.articuloParaVentaTableAdapter1.Fill(this.gestionCC.ArticuloParaVenta);
        }

        private void ActualizarStock(int intIdArticulo, int intCantidad, string strEstado)
        {
            Negocio.ArticulosNegocio CadArticulo = new Negocio.ArticulosNegocio();

            CadArticulo.ActualizarStock(intIdArticulo, intCantidad, strEstado);

        }

        private void FormAMVenta_FormClosed(object sender, FormClosedEventArgs e)
        {
            CadVentasParcial.ReestablecerArticulos();

            Presentacion.FormVentasCliente VentasClientes = new FormVentasCliente();
            VentasClientes.ActualizarGrillaClientes();
        }

        private void barButtonItem2_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //FormReporteVenta frmReporteVenta = new FormReporteVenta();
            //frmReporteVenta.ShowDialog();
        }

        private void rdbCtaCte_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCtaCte.Checked == true)
            {

                txtEntrega.Enabled = true;

            }
            else
            {
                txtEntrega.Enabled = false;
                txtEntrega.Text = "0";

            }
        }

        public EventArgs e { get; set; }

        public object sender { get; set; }

        private void btnSelecCliente_Click(object sender, EventArgs e)
        {
            BuscarCliente();
        }

        public void BuscarCliente()
        {
            string Parametro = txtcliente.Text;

            DataSet dsCliente = new DataSet();

            Negocio.ClientesNegocio CadCliente = new Negocio.ClientesNegocio();

            try
            {
                dsCliente = CadCliente.ObtenerClienteSeleccionado(Parametro);

                IdCliente = Convert.ToInt32(dsCliente.Tables["Cliente"].Rows[0][0].ToString());

                lblNombreCliente.Text = dsCliente.Tables["Cliente"].Rows[0][1].ToString();

                lblNombreCliente.Refresh();
            }
            catch { }

        }

        private void txtEntrega_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == (int)Keys.Back)
            {
                // cualquier cosa;
                return;
            }

            // punto decimal
            if (e.KeyChar == 44)
            {
                if (this.txtEntrega.Text.IndexOf(",") >= 0)
                    e.Handled = true;
                return;
            }

            // del cero al nueve only,...y backspace
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true; // quitamos caracter
        }

        private void txtcliente_TextChanged(object sender, EventArgs e)
        {
            BuscarCliente();
        }


    }
}