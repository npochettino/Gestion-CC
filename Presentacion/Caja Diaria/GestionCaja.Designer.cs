namespace Presentacion
{
    partial class GestionCaja
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnAgregarIngreso = new DevExpress.XtraEditors.SimpleButton();
            this.btnAgregarEgreso = new DevExpress.XtraEditors.SimpleButton();
            this.dtMarca = new DevExpress.XtraGrid.GridControl();
            this.viResultadoCajaDiariaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionCC = new Presentacion.GestionCC();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIngresos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEgresos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPagos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVentas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGastos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Resultado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CajaInicial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grbDatosTiposArticulos = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFechaOperacion = new System.Windows.Forms.Label();
            this.lblDescripcionTipoArticulo = new System.Windows.Forms.Label();
            this.txtDescOperacion = new System.Windows.Forms.TextBox();
            this.lblImporte = new System.Windows.Forms.Label();
            this.txtImporteOperacion = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnGuardarTipoArticulo = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrarCaja = new DevExpress.XtraEditors.SimpleButton();
            this.viResultadoCajaDiariaTableAdapter = new Presentacion.GestionCCTableAdapters.ViResultadoCajaDiariaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viResultadoCajaDiariaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionCC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.grbDatosTiposArticulos.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregarIngreso
            // 
            this.btnAgregarIngreso.Location = new System.Drawing.Point(100, 55);
            this.btnAgregarIngreso.Name = "btnAgregarIngreso";
            this.btnAgregarIngreso.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarIngreso.TabIndex = 0;
            this.btnAgregarIngreso.Text = "Ingreso";
            this.btnAgregarIngreso.Click += new System.EventHandler(this.btnAgregarTipoArticulo_Click);
            // 
            // btnAgregarEgreso
            // 
            this.btnAgregarEgreso.Location = new System.Drawing.Point(100, 97);
            this.btnAgregarEgreso.Name = "btnAgregarEgreso";
            this.btnAgregarEgreso.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarEgreso.TabIndex = 1;
            this.btnAgregarEgreso.Text = "Egreso";
            this.btnAgregarEgreso.Click += new System.EventHandler(this.btnModificarTipoArticulo_Click);
            // 
            // dtMarca
            // 
            this.dtMarca.DataSource = this.viResultadoCajaDiariaBindingSource;
            this.dtMarca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtMarca.Location = new System.Drawing.Point(294, 3);
            this.dtMarca.MainView = this.gridView1;
            this.dtMarca.Name = "dtMarca";
            this.dtMarca.Size = new System.Drawing.Size(519, 301);
            this.dtMarca.TabIndex = 3;
            this.dtMarca.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // viResultadoCajaDiariaBindingSource
            // 
            this.viResultadoCajaDiariaBindingSource.DataMember = "ViResultadoCajaDiaria";
            this.viResultadoCajaDiariaBindingSource.DataSource = this.gestionCC;
            // 
            // gestionCC
            // 
            this.gestionCC.DataSetName = "GestionCC";
            this.gestionCC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFecha,
            this.colIngresos,
            this.colEgresos,
            this.colPagos,
            this.colVentas,
            this.colGastos,
            this.Resultado,
            this.CajaInicial});
            this.gridView1.GridControl = this.dtMarca;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            // 
            // colFecha
            // 
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.OptionsColumn.AllowEdit = false;
            this.colFecha.OptionsColumn.AllowFocus = false;
            this.colFecha.OptionsColumn.ReadOnly = true;
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 0;
            this.colFecha.Width = 56;
            // 
            // colIngresos
            // 
            this.colIngresos.Caption = "Ingresos De Caja";
            this.colIngresos.FieldName = "Ingresos";
            this.colIngresos.Name = "colIngresos";
            this.colIngresos.OptionsColumn.AllowEdit = false;
            this.colIngresos.OptionsColumn.AllowFocus = false;
            this.colIngresos.OptionsColumn.ReadOnly = true;
            this.colIngresos.Visible = true;
            this.colIngresos.VisibleIndex = 2;
            this.colIngresos.Width = 56;
            // 
            // colEgresos
            // 
            this.colEgresos.Caption = "Egresos De Caja";
            this.colEgresos.FieldName = "Egresos";
            this.colEgresos.Name = "colEgresos";
            this.colEgresos.OptionsColumn.AllowEdit = false;
            this.colEgresos.OptionsColumn.AllowFocus = false;
            this.colEgresos.OptionsColumn.ReadOnly = true;
            this.colEgresos.Visible = true;
            this.colEgresos.VisibleIndex = 3;
            this.colEgresos.Width = 43;
            // 
            // colPagos
            // 
            this.colPagos.Caption = "Pagos Recibidos";
            this.colPagos.FieldName = "Pagos";
            this.colPagos.Name = "colPagos";
            this.colPagos.OptionsColumn.AllowEdit = false;
            this.colPagos.OptionsColumn.AllowFocus = false;
            this.colPagos.OptionsColumn.ReadOnly = true;
            this.colPagos.Visible = true;
            this.colPagos.VisibleIndex = 4;
            this.colPagos.Width = 109;
            // 
            // colVentas
            // 
            this.colVentas.Caption = "Ventas Realizadas En Efectivo";
            this.colVentas.FieldName = "Ventas";
            this.colVentas.Name = "colVentas";
            this.colVentas.OptionsColumn.AllowEdit = false;
            this.colVentas.OptionsColumn.AllowFocus = false;
            this.colVentas.OptionsColumn.ReadOnly = true;
            this.colVentas.Visible = true;
            this.colVentas.VisibleIndex = 5;
            this.colVentas.Width = 69;
            // 
            // colGastos
            // 
            this.colGastos.Caption = "Gastos Pagados";
            this.colGastos.FieldName = "Gastos";
            this.colGastos.Name = "colGastos";
            this.colGastos.OptionsColumn.AllowEdit = false;
            this.colGastos.OptionsColumn.AllowFocus = false;
            this.colGastos.OptionsColumn.ReadOnly = true;
            this.colGastos.Visible = true;
            this.colGastos.VisibleIndex = 6;
            this.colGastos.Width = 54;
            // 
            // Resultado
            // 
            this.Resultado.Caption = "Saldo Caja";
            this.Resultado.FieldName = "Resultado";
            this.Resultado.Name = "Resultado";
            this.Resultado.OptionsColumn.AllowEdit = false;
            this.Resultado.OptionsColumn.AllowFocus = false;
            this.Resultado.OptionsColumn.ReadOnly = true;
            this.Resultado.Visible = true;
            this.Resultado.VisibleIndex = 7;
            this.Resultado.Width = 58;
            // 
            // CajaInicial
            // 
            this.CajaInicial.Caption = "CajaInicial";
            this.CajaInicial.FieldName = "CajaInicial";
            this.CajaInicial.Name = "CajaInicial";
            this.CajaInicial.OptionsColumn.AllowEdit = false;
            this.CajaInicial.OptionsColumn.AllowFocus = false;
            this.CajaInicial.OptionsColumn.ReadOnly = true;
            this.CajaInicial.Visible = true;
            this.CajaInicial.VisibleIndex = 1;
            this.CajaInicial.Width = 56;
            // 
            // grbDatosTiposArticulos
            // 
            this.grbDatosTiposArticulos.Controls.Add(this.tableLayoutPanel2);
            this.grbDatosTiposArticulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbDatosTiposArticulos.Location = new System.Drawing.Point(0, 0);
            this.grbDatosTiposArticulos.Name = "grbDatosTiposArticulos";
            this.grbDatosTiposArticulos.Size = new System.Drawing.Size(285, 242);
            this.grbDatosTiposArticulos.TabIndex = 4;
            this.grbDatosTiposArticulos.TabStop = false;
            this.grbDatosTiposArticulos.Text = "Gestión de datos";
            this.grbDatosTiposArticulos.Visible = false;
            this.grbDatosTiposArticulos.Enter += new System.EventHandler(this.grbDatosTiposArticulos_Enter);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.dtpFecha, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblFechaOperacion, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblDescripcionTipoArticulo, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtDescOperacion, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblImporte, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtImporteOperacion, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.06742F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.93258F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(279, 196);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFecha.Location = new System.Drawing.Point(84, 17);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(192, 21);
            this.dtpFecha.TabIndex = 3;
            // 
            // lblFechaOperacion
            // 
            this.lblFechaOperacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaOperacion.AutoSize = true;
            this.lblFechaOperacion.Location = new System.Drawing.Point(3, 21);
            this.lblFechaOperacion.Name = "lblFechaOperacion";
            this.lblFechaOperacion.Size = new System.Drawing.Size(75, 13);
            this.lblFechaOperacion.TabIndex = 1;
            this.lblFechaOperacion.Text = "Fecha";
            this.lblFechaOperacion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDescripcionTipoArticulo
            // 
            this.lblDescripcionTipoArticulo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDescripcionTipoArticulo.AutoSize = true;
            this.lblDescripcionTipoArticulo.Location = new System.Drawing.Point(13, 69);
            this.lblDescripcionTipoArticulo.Name = "lblDescripcionTipoArticulo";
            this.lblDescripcionTipoArticulo.Size = new System.Drawing.Size(65, 13);
            this.lblDescripcionTipoArticulo.TabIndex = 1;
            this.lblDescripcionTipoArticulo.Text = "Descripción:";
            // 
            // txtDescOperacion
            // 
            this.txtDescOperacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescOperacion.Location = new System.Drawing.Point(100, 65);
            this.txtDescOperacion.Name = "txtDescOperacion";
            this.txtDescOperacion.Size = new System.Drawing.Size(159, 21);
            this.txtDescOperacion.TabIndex = 0;
            // 
            // lblImporte
            // 
            this.lblImporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblImporte.AutoSize = true;
            this.lblImporte.Location = new System.Drawing.Point(3, 111);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(75, 13);
            this.lblImporte.TabIndex = 4;
            this.lblImporte.Text = "Importe";
            this.lblImporte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtImporteOperacion
            // 
            this.txtImporteOperacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtImporteOperacion.Location = new System.Drawing.Point(101, 107);
            this.txtImporteOperacion.Name = "txtImporteOperacion";
            this.txtImporteOperacion.Size = new System.Drawing.Size(158, 21);
            this.txtImporteOperacion.TabIndex = 5;
            this.txtImporteOperacion.Text = "0";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btnGuardarTipoArticulo, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnCancelar, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(84, 144);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(192, 49);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // btnGuardarTipoArticulo
            // 
            this.btnGuardarTipoArticulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardarTipoArticulo.Location = new System.Drawing.Point(8, 13);
            this.btnGuardarTipoArticulo.Name = "btnGuardarTipoArticulo";
            this.btnGuardarTipoArticulo.Size = new System.Drawing.Size(80, 23);
            this.btnGuardarTipoArticulo.TabIndex = 2;
            this.btnGuardarTipoArticulo.Text = "Guardar";
            this.btnGuardarTipoArticulo.Click += new System.EventHandler(this.btnGuardarTipoArticulo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.Location = new System.Drawing.Point(104, 13);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 291F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtMarca, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(816, 307);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grbDatosTiposArticulos);
            this.panel1.Controls.Add(this.btnCerrarCaja);
            this.panel1.Controls.Add(this.btnAgregarEgreso);
            this.panel1.Controls.Add(this.btnAgregarIngreso);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 242);
            this.panel1.TabIndex = 4;
            // 
            // btnCerrarCaja
            // 
            this.btnCerrarCaja.Location = new System.Drawing.Point(101, 138);
            this.btnCerrarCaja.Name = "btnCerrarCaja";
            this.btnCerrarCaja.Size = new System.Drawing.Size(73, 30);
            this.btnCerrarCaja.TabIndex = 5;
            this.btnCerrarCaja.Text = "Cerrar Caja";
            this.btnCerrarCaja.Click += new System.EventHandler(this.btnCerrarCaja_Click);
            // 
            // viResultadoCajaDiariaTableAdapter
            // 
            this.viResultadoCajaDiariaTableAdapter.ClearBeforeFill = true;
            // 
            // GestionCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 307);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "GestionCaja";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Caja Diaria";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormABMTipoArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viResultadoCajaDiariaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionCC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.grbDatosTiposArticulos.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnAgregarIngreso;
        private DevExpress.XtraEditors.SimpleButton btnAgregarEgreso;
        private DevExpress.XtraGrid.GridControl dtMarca;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private GestionCC gestionCC;
        private System.Windows.Forms.GroupBox grbDatosTiposArticulos;
        private System.Windows.Forms.Label lblDescripcionTipoArticulo;
        private System.Windows.Forms.TextBox txtDescOperacion;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnGuardarTipoArticulo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource viResultadoCajaDiariaBindingSource;
        private GestionCCTableAdapters.ViResultadoCajaDiariaTableAdapter viResultadoCajaDiariaTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colIngresos;
        private DevExpress.XtraGrid.Columns.GridColumn colEgresos;
        private DevExpress.XtraGrid.Columns.GridColumn colPagos;
        private DevExpress.XtraGrid.Columns.GridColumn colVentas;
        private DevExpress.XtraGrid.Columns.GridColumn Resultado;
        private System.Windows.Forms.Label lblFechaOperacion;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private DevExpress.XtraGrid.Columns.GridColumn CajaInicial;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.TextBox txtImporteOperacion;
        private DevExpress.XtraEditors.SimpleButton btnCerrarCaja;
        private DevExpress.XtraGrid.Columns.GridColumn colGastos;
    }
}