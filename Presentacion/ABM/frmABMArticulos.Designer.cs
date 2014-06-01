namespace Presentacion
{
    partial class frmABMArticulos
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
            this.gestionCC = new Presentacion.GestionCC();
            this.btnAgregarArticulo = new DevExpress.XtraEditors.SimpleButton();
            this.btnModificaraArticulo = new DevExpress.XtraEditors.SimpleButton();
            this.btnEliminarArticulo = new DevExpress.XtraEditors.SimpleButton();
            this.grbDatosArticulos = new System.Windows.Forms.GroupBox();
            this.txtTalle = new System.Windows.Forms.TextBox();
            this.lblTalle = new System.Windows.Forms.Label();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.lblCosto = new System.Windows.Forms.Label();
            this.btnAgregarMarca = new DevExpress.XtraEditors.SimpleButton();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.marcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.btnAgregarTipoArticulo = new DevExpress.XtraEditors.SimpleButton();
            this.cmbTipoArticulo = new System.Windows.Forms.ComboBox();
            this.tipoArticuloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtPrecioArticulo = new System.Windows.Forms.TextBox();
            this.txtDescripcionArticulo = new System.Windows.Forms.TextBox();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardarArticulo = new DevExpress.XtraEditors.SimpleButton();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblTipoArticulo = new System.Windows.Forms.Label();
            this.lblDescripcionArticulo = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dtDatosArticulos = new DevExpress.XtraGrid.GridControl();
            this.articulosEmpresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId_Articulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoArticulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId_TipoArticulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMarca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Talle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.articulosEmpresaTableAdapter = new Presentacion.GestionCCTableAdapters.ArticulosEmpresaTableAdapter();
            this.tipoArticuloTableAdapter = new Presentacion.GestionCCTableAdapters.TipoArticuloTableAdapter();
            this.marcaTableAdapter = new Presentacion.GestionCCTableAdapters.MarcaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gestionCC)).BeginInit();
            this.grbDatosArticulos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoArticuloBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtDatosArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articulosEmpresaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gestionCC
            // 
            this.gestionCC.DataSetName = "GestionCC";
            this.gestionCC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAgregarArticulo
            // 
            this.btnAgregarArticulo.Location = new System.Drawing.Point(106, 48);
            this.btnAgregarArticulo.Name = "btnAgregarArticulo";
            this.btnAgregarArticulo.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarArticulo.TabIndex = 2;
            this.btnAgregarArticulo.Text = "Agregar";
            this.btnAgregarArticulo.Click += new System.EventHandler(this.btnAgregarArticulo_Click);
            // 
            // btnModificaraArticulo
            // 
            this.btnModificaraArticulo.Location = new System.Drawing.Point(106, 94);
            this.btnModificaraArticulo.Name = "btnModificaraArticulo";
            this.btnModificaraArticulo.Size = new System.Drawing.Size(75, 23);
            this.btnModificaraArticulo.TabIndex = 3;
            this.btnModificaraArticulo.Text = "Modificar";
            this.btnModificaraArticulo.Click += new System.EventHandler(this.btnModificaraArticulo_Click);
            // 
            // btnEliminarArticulo
            // 
            this.btnEliminarArticulo.Location = new System.Drawing.Point(106, 138);
            this.btnEliminarArticulo.Name = "btnEliminarArticulo";
            this.btnEliminarArticulo.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarArticulo.TabIndex = 4;
            this.btnEliminarArticulo.Text = "Eliminar";
            this.btnEliminarArticulo.Click += new System.EventHandler(this.btnEliminarArticulo_Click);
            // 
            // grbDatosArticulos
            // 
            this.grbDatosArticulos.Controls.Add(this.txtTalle);
            this.grbDatosArticulos.Controls.Add(this.lblTalle);
            this.grbDatosArticulos.Controls.Add(this.txtCosto);
            this.grbDatosArticulos.Controls.Add(this.lblCosto);
            this.grbDatosArticulos.Controls.Add(this.btnAgregarMarca);
            this.grbDatosArticulos.Controls.Add(this.cmbMarca);
            this.grbDatosArticulos.Controls.Add(this.lblMarca);
            this.grbDatosArticulos.Controls.Add(this.txtCodigo);
            this.grbDatosArticulos.Controls.Add(this.lblCodigo);
            this.grbDatosArticulos.Controls.Add(this.txtStock);
            this.grbDatosArticulos.Controls.Add(this.lblStock);
            this.grbDatosArticulos.Controls.Add(this.btnAgregarTipoArticulo);
            this.grbDatosArticulos.Controls.Add(this.cmbTipoArticulo);
            this.grbDatosArticulos.Controls.Add(this.txtPrecioArticulo);
            this.grbDatosArticulos.Controls.Add(this.txtDescripcionArticulo);
            this.grbDatosArticulos.Controls.Add(this.btnCancelar);
            this.grbDatosArticulos.Controls.Add(this.btnGuardarArticulo);
            this.grbDatosArticulos.Controls.Add(this.lblPrecio);
            this.grbDatosArticulos.Controls.Add(this.lblTipoArticulo);
            this.grbDatosArticulos.Controls.Add(this.lblDescripcionArticulo);
            this.grbDatosArticulos.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbDatosArticulos.Location = new System.Drawing.Point(0, 0);
            this.grbDatosArticulos.Name = "grbDatosArticulos";
            this.grbDatosArticulos.Size = new System.Drawing.Size(294, 313);
            this.grbDatosArticulos.TabIndex = 19;
            this.grbDatosArticulos.TabStop = false;
            this.grbDatosArticulos.Text = "Alta de Artículo";
            this.grbDatosArticulos.Visible = false;
            // 
            // txtTalle
            // 
            this.txtTalle.Location = new System.Drawing.Point(210, 209);
            this.txtTalle.Name = "txtTalle";
            this.txtTalle.Size = new System.Drawing.Size(72, 21);
            this.txtTalle.TabIndex = 20;
            // 
            // lblTalle
            // 
            this.lblTalle.AutoSize = true;
            this.lblTalle.Location = new System.Drawing.Point(162, 212);
            this.lblTalle.Name = "lblTalle";
            this.lblTalle.Size = new System.Drawing.Size(33, 13);
            this.lblTalle.TabIndex = 19;
            this.lblTalle.Text = "Talle:";
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(210, 174);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(72, 21);
            this.txtCosto.TabIndex = 18;
            this.txtCosto.Text = "0";
            this.txtCosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCosto_KeyPress);
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(162, 177);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(39, 13);
            this.lblCosto.TabIndex = 17;
            this.lblCosto.Text = "Costo:";
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.Location = new System.Drawing.Point(262, 141);
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Size = new System.Drawing.Size(26, 23);
            this.btnAgregarMarca.TabIndex = 16;
            this.btnAgregarMarca.Click += new System.EventHandler(this.btnAgregarMarca_Click);
            // 
            // cmbMarca
            // 
            this.cmbMarca.DataSource = this.marcaBindingSource;
            this.cmbMarca.DisplayMember = "Descripcion";
            this.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(111, 141);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(134, 21);
            this.cmbMarca.TabIndex = 15;
            this.cmbMarca.ValueMember = "Id_Marca";
            // 
            // marcaBindingSource
            // 
            this.marcaBindingSource.DataMember = "Marca";
            this.marcaBindingSource.DataSource = this.gestionCC;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(26, 141);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 13);
            this.lblMarca.TabIndex = 14;
            this.lblMarca.Text = "Marca:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(111, 34);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(134, 21);
            this.txtCodigo.TabIndex = 13;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(26, 37);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(44, 13);
            this.lblCodigo.TabIndex = 12;
            this.lblCodigo.Text = "Codigo:";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(76, 206);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(72, 21);
            this.txtStock.TabIndex = 11;
            this.txtStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStock_KeyPress);
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(27, 209);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(37, 13);
            this.lblStock.TabIndex = 10;
            this.lblStock.Text = "Stock:";
            // 
            // btnAgregarTipoArticulo
            // 
            this.btnAgregarTipoArticulo.Location = new System.Drawing.Point(262, 109);
            this.btnAgregarTipoArticulo.Name = "btnAgregarTipoArticulo";
            this.btnAgregarTipoArticulo.Size = new System.Drawing.Size(26, 23);
            this.btnAgregarTipoArticulo.TabIndex = 9;
            this.btnAgregarTipoArticulo.Click += new System.EventHandler(this.btnAgregarTipoArticulo_Click);
            // 
            // cmbTipoArticulo
            // 
            this.cmbTipoArticulo.DataSource = this.tipoArticuloBindingSource;
            this.cmbTipoArticulo.DisplayMember = "Descripcion";
            this.cmbTipoArticulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoArticulo.FormattingEnabled = true;
            this.cmbTipoArticulo.Location = new System.Drawing.Point(111, 109);
            this.cmbTipoArticulo.Name = "cmbTipoArticulo";
            this.cmbTipoArticulo.Size = new System.Drawing.Size(134, 21);
            this.cmbTipoArticulo.TabIndex = 8;
            this.cmbTipoArticulo.ValueMember = "Id_TipoArticulo";
            // 
            // tipoArticuloBindingSource
            // 
            this.tipoArticuloBindingSource.DataMember = "TipoArticulo";
            this.tipoArticuloBindingSource.DataSource = this.gestionCC;
            // 
            // txtPrecioArticulo
            // 
            this.txtPrecioArticulo.Location = new System.Drawing.Point(76, 174);
            this.txtPrecioArticulo.Name = "txtPrecioArticulo";
            this.txtPrecioArticulo.Size = new System.Drawing.Size(72, 21);
            this.txtPrecioArticulo.TabIndex = 7;
            this.txtPrecioArticulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioArticulo_KeyPress);
            // 
            // txtDescripcionArticulo
            // 
            this.txtDescripcionArticulo.Location = new System.Drawing.Point(111, 67);
            this.txtDescripcionArticulo.Name = "txtDescripcionArticulo";
            this.txtDescripcionArticulo.Size = new System.Drawing.Size(134, 21);
            this.txtDescripcionArticulo.TabIndex = 5;
            this.txtDescripcionArticulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcionArticulo_KeyPress);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(185, 255);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(82, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnGuardarArticulo
            // 
            this.btnGuardarArticulo.Location = new System.Drawing.Point(91, 255);
            this.btnGuardarArticulo.Name = "btnGuardarArticulo";
            this.btnGuardarArticulo.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarArticulo.TabIndex = 3;
            this.btnGuardarArticulo.Text = "Guardar";
            this.btnGuardarArticulo.Click += new System.EventHandler(this.btnGuardarArticulo_Click);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(26, 177);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblTipoArticulo
            // 
            this.lblTipoArticulo.AutoSize = true;
            this.lblTipoArticulo.Location = new System.Drawing.Point(6, 109);
            this.lblTipoArticulo.Name = "lblTipoArticulo";
            this.lblTipoArticulo.Size = new System.Drawing.Size(85, 13);
            this.lblTipoArticulo.TabIndex = 1;
            this.lblTipoArticulo.Text = "Tipo de Artículo:";
            // 
            // lblDescripcionArticulo
            // 
            this.lblDescripcionArticulo.AutoSize = true;
            this.lblDescripcionArticulo.Location = new System.Drawing.Point(26, 70);
            this.lblDescripcionArticulo.Name = "lblDescripcionArticulo";
            this.lblDescripcionArticulo.Size = new System.Drawing.Size(65, 13);
            this.lblDescripcionArticulo.TabIndex = 0;
            this.lblDescripcionArticulo.Text = "Descripción:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dtDatosArticulos, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(757, 328);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // dtDatosArticulos
            // 
            this.dtDatosArticulos.DataSource = this.articulosEmpresaBindingSource;
            this.dtDatosArticulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtDatosArticulos.Location = new System.Drawing.Point(303, 3);
            this.dtDatosArticulos.MainView = this.gridView1;
            this.dtDatosArticulos.Name = "dtDatosArticulos";
            this.dtDatosArticulos.Size = new System.Drawing.Size(451, 322);
            this.dtDatosArticulos.TabIndex = 2;
            this.dtDatosArticulos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // articulosEmpresaBindingSource
            // 
            this.articulosEmpresaBindingSource.DataMember = "ArticulosEmpresa";
            this.articulosEmpresaBindingSource.DataSource = this.gestionCC;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId_Articulo,
            this.colDescripcion,
            this.colPrecio,
            this.colCodigo,
            this.colTipoArticulo,
            this.colId_TipoArticulo,
            this.colStock,
            this.colMarca,
            this.Talle});
            this.gridView1.GridControl = this.dtDatosArticulos;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            // 
            // colId_Articulo
            // 
            this.colId_Articulo.FieldName = "Id_Articulo";
            this.colId_Articulo.Name = "colId_Articulo";
            this.colId_Articulo.OptionsColumn.ReadOnly = true;
            this.colId_Articulo.Width = 62;
            // 
            // colDescripcion
            // 
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.OptionsColumn.AllowEdit = false;
            this.colDescripcion.OptionsColumn.AllowFocus = false;
            this.colDescripcion.OptionsColumn.ReadOnly = true;
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 0;
            this.colDescripcion.Width = 200;
            // 
            // colPrecio
            // 
            this.colPrecio.FieldName = "Precio";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.OptionsColumn.AllowEdit = false;
            this.colPrecio.OptionsColumn.AllowFocus = false;
            this.colPrecio.OptionsColumn.ReadOnly = true;
            this.colPrecio.Visible = true;
            this.colPrecio.VisibleIndex = 1;
            this.colPrecio.Width = 37;
            // 
            // colCodigo
            // 
            this.colCodigo.FieldName = "Codigo";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.OptionsColumn.AllowEdit = false;
            this.colCodigo.OptionsColumn.AllowFocus = false;
            this.colCodigo.OptionsColumn.ReadOnly = true;
            this.colCodigo.Visible = true;
            this.colCodigo.VisibleIndex = 3;
            this.colCodigo.Width = 37;
            // 
            // colTipoArticulo
            // 
            this.colTipoArticulo.FieldName = "TipoArticulo";
            this.colTipoArticulo.Name = "colTipoArticulo";
            this.colTipoArticulo.OptionsColumn.AllowEdit = false;
            this.colTipoArticulo.OptionsColumn.AllowFocus = false;
            this.colTipoArticulo.OptionsColumn.ReadOnly = true;
            this.colTipoArticulo.Visible = true;
            this.colTipoArticulo.VisibleIndex = 2;
            this.colTipoArticulo.Width = 37;
            // 
            // colId_TipoArticulo
            // 
            this.colId_TipoArticulo.FieldName = "Id_TipoArticulo";
            this.colId_TipoArticulo.Name = "colId_TipoArticulo";
            this.colId_TipoArticulo.OptionsColumn.ReadOnly = true;
            // 
            // colStock
            // 
            this.colStock.FieldName = "Stock";
            this.colStock.Name = "colStock";
            this.colStock.OptionsColumn.AllowEdit = false;
            this.colStock.OptionsColumn.AllowFocus = false;
            this.colStock.OptionsColumn.ReadOnly = true;
            this.colStock.Visible = true;
            this.colStock.VisibleIndex = 4;
            this.colStock.Width = 37;
            // 
            // colMarca
            // 
            this.colMarca.FieldName = "Marca";
            this.colMarca.Name = "colMarca";
            this.colMarca.OptionsColumn.AllowEdit = false;
            this.colMarca.OptionsColumn.AllowFocus = false;
            this.colMarca.OptionsColumn.ReadOnly = true;
            this.colMarca.Visible = true;
            this.colMarca.VisibleIndex = 5;
            this.colMarca.Width = 37;
            // 
            // Talle
            // 
            this.Talle.Caption = "Talle";
            this.Talle.FieldName = "Talle";
            this.Talle.Name = "Talle";
            this.Talle.OptionsColumn.AllowEdit = false;
            this.Talle.OptionsColumn.AllowFocus = false;
            this.Talle.OptionsColumn.ReadOnly = true;
            this.Talle.Visible = true;
            this.Talle.VisibleIndex = 6;
            this.Talle.Width = 48;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grbDatosArticulos);
            this.panel1.Controls.Add(this.btnAgregarArticulo);
            this.panel1.Controls.Add(this.btnModificaraArticulo);
            this.panel1.Controls.Add(this.btnEliminarArticulo);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 322);
            this.panel1.TabIndex = 1;
            // 
            // articulosEmpresaTableAdapter
            // 
            this.articulosEmpresaTableAdapter.ClearBeforeFill = true;
            // 
            // tipoArticuloTableAdapter
            // 
            this.tipoArticuloTableAdapter.ClearBeforeFill = true;
            // 
            // marcaTableAdapter
            // 
            this.marcaTableAdapter.ClearBeforeFill = true;
            // 
            // frmABMArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 328);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmABMArticulos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Artículos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmABMArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gestionCC)).EndInit();
            this.grbDatosArticulos.ResumeLayout(false);
            this.grbDatosArticulos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoArticuloBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtDatosArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articulosEmpresaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnAgregarArticulo;
        private DevExpress.XtraEditors.SimpleButton btnModificaraArticulo;
        private DevExpress.XtraEditors.SimpleButton btnEliminarArticulo;
        private System.Windows.Forms.GroupBox grbDatosArticulos;
        private System.Windows.Forms.ComboBox cmbTipoArticulo;
        private System.Windows.Forms.TextBox txtPrecioArticulo;
        private System.Windows.Forms.TextBox txtDescripcionArticulo;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnGuardarArticulo;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblTipoArticulo;
        private System.Windows.Forms.Label lblDescripcionArticulo;
        private GestionCC gestionCC;
        private GestionCCTableAdapters.ArticuloTableAdapter articuloTableAdapter;
        private DevExpress.XtraEditors.SimpleButton btnAgregarTipoArticulo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private DevExpress.XtraGrid.GridControl dtDatosArticulos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource articulosEmpresaBindingSource;
        private GestionCCTableAdapters.ArticulosEmpresaTableAdapter articulosEmpresaTableAdapter;
        private System.Windows.Forms.BindingSource tipoArticuloBindingSource;
        private GestionCCTableAdapters.TipoArticuloTableAdapter tipoArticuloTableAdapter;
        private DevExpress.XtraEditors.SimpleButton btnAgregarMarca;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.BindingSource marcaBindingSource;
        private GestionCCTableAdapters.MarcaTableAdapter marcaTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colId_Articulo;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecio;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoArticulo;
        private DevExpress.XtraGrid.Columns.GridColumn colId_TipoArticulo;
        private DevExpress.XtraGrid.Columns.GridColumn colStock;
        private DevExpress.XtraGrid.Columns.GridColumn colMarca;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.TextBox txtTalle;
        private System.Windows.Forms.Label lblTalle;
        private DevExpress.XtraGrid.Columns.GridColumn Talle;
    }
}