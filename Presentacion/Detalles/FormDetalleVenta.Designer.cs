namespace Presentacion
{
    partial class FormDetalleVenta
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvPagosEfectuados = new DevExpress.XtraGrid.GridControl();
            this.ventaDetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionCC = new Presentacion.GestionCC();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoArticulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMarca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_Venta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_Articulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ventaDetalleTableAdapter = new Presentacion.GestionCCTableAdapters.VentaDetalleTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagosEfectuados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaDetalleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionCC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgvPagosEfectuados, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(478, 262);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvPagosEfectuados
            // 
            this.dgvPagosEfectuados.DataSource = this.ventaDetalleBindingSource;
            this.dgvPagosEfectuados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPagosEfectuados.Location = new System.Drawing.Point(3, 3);
            this.dgvPagosEfectuados.MainView = this.gridView1;
            this.dgvPagosEfectuados.Name = "dgvPagosEfectuados";
            this.dgvPagosEfectuados.Size = new System.Drawing.Size(472, 205);
            this.dgvPagosEfectuados.TabIndex = 0;
            this.dgvPagosEfectuados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // ventaDetalleBindingSource
            // 
            this.ventaDetalleBindingSource.DataMember = "VentaDetalle";
            this.ventaDetalleBindingSource.DataSource = this.gestionCC;
            // 
            // gestionCC
            // 
            this.gestionCC.DataSetName = "GestionCC";
            this.gestionCC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodigo,
            this.colDescripcion,
            this.colTipoArticulo,
            this.colMarca,
            this.colTalle,
            this.colCantidad,
            this.colPrecio,
            this.colid_Venta,
            this.colid_Articulo});
            this.gridView1.GridControl = this.dgvPagosEfectuados;
            this.gridView1.Name = "gridView1";
            // 
            // colCodigo
            // 
            this.colCodigo.FieldName = "Codigo";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.OptionsColumn.AllowEdit = false;
            this.colCodigo.OptionsColumn.AllowFocus = false;
            this.colCodigo.OptionsColumn.ReadOnly = true;
            this.colCodigo.Visible = true;
            this.colCodigo.VisibleIndex = 0;
            // 
            // colDescripcion
            // 
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.OptionsColumn.AllowEdit = false;
            this.colDescripcion.OptionsColumn.AllowFocus = false;
            this.colDescripcion.OptionsColumn.ReadOnly = true;
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 1;
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
            // 
            // colMarca
            // 
            this.colMarca.FieldName = "Marca";
            this.colMarca.Name = "colMarca";
            this.colMarca.OptionsColumn.AllowEdit = false;
            this.colMarca.OptionsColumn.AllowFocus = false;
            this.colMarca.OptionsColumn.ReadOnly = true;
            this.colMarca.Visible = true;
            this.colMarca.VisibleIndex = 3;
            // 
            // colTalle
            // 
            this.colTalle.FieldName = "Talle";
            this.colTalle.Name = "colTalle";
            this.colTalle.OptionsColumn.AllowEdit = false;
            this.colTalle.OptionsColumn.AllowFocus = false;
            this.colTalle.OptionsColumn.ReadOnly = true;
            this.colTalle.Visible = true;
            this.colTalle.VisibleIndex = 4;
            // 
            // colCantidad
            // 
            this.colCantidad.FieldName = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.OptionsColumn.AllowEdit = false;
            this.colCantidad.OptionsColumn.AllowFocus = false;
            this.colCantidad.OptionsColumn.ReadOnly = true;
            this.colCantidad.Visible = true;
            this.colCantidad.VisibleIndex = 5;
            // 
            // colPrecio
            // 
            this.colPrecio.FieldName = "Precio";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.OptionsColumn.AllowEdit = false;
            this.colPrecio.OptionsColumn.AllowFocus = false;
            this.colPrecio.OptionsColumn.ReadOnly = true;
            this.colPrecio.Visible = true;
            this.colPrecio.VisibleIndex = 6;
            // 
            // colid_Venta
            // 
            this.colid_Venta.FieldName = "id_Venta";
            this.colid_Venta.Name = "colid_Venta";
            // 
            // colid_Articulo
            // 
            this.colid_Articulo.FieldName = "id_Articulo";
            this.colid_Articulo.Name = "colid_Articulo";
            // 
            // ventaDetalleTableAdapter
            // 
            this.ventaDetalleTableAdapter.ClearBeforeFill = true;
            // 
            // FormDetalleVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 262);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormDetalleVenta";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle de Venta";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagosEfectuados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaDetalleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionCC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl dgvPagosEfectuados;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private GestionCC gestionCC;
        private System.Windows.Forms.BindingSource ventaDetalleBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoArticulo;
        private DevExpress.XtraGrid.Columns.GridColumn colMarca;
        private DevExpress.XtraGrid.Columns.GridColumn colTalle;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecio;
        private DevExpress.XtraGrid.Columns.GridColumn colid_Venta;
        private DevExpress.XtraGrid.Columns.GridColumn colid_Articulo;
        private GestionCCTableAdapters.VentaDetalleTableAdapter ventaDetalleTableAdapter;
    }
}