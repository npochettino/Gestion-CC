namespace Presentacion
{
    partial class FormABMIngresosEgresos
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
            this.btnAgregarTipoArticulo = new DevExpress.XtraEditors.SimpleButton();
            this.btnModificarTipoArticulo = new DevExpress.XtraEditors.SimpleButton();
            this.btnEliminarTipoArticulo = new DevExpress.XtraEditors.SimpleButton();
            this.dtMarca = new DevExpress.XtraGrid.GridControl();
            this.ingresosEgresosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionCC = new Presentacion.GestionCC();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId_Caja = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIngreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEgreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaOperacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcionOperacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCajaInicial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grbDatosIE = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ingresosEgresosTableAdapter = new Presentacion.GestionCCTableAdapters.IngresosEgresosTableAdapter();
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
            ((System.ComponentModel.ISupportInitialize)(this.dtMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingresosEgresosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionCC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.grbDatosIE.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregarTipoArticulo
            // 
            this.btnAgregarTipoArticulo.Location = new System.Drawing.Point(100, 55);
            this.btnAgregarTipoArticulo.Name = "btnAgregarTipoArticulo";
            this.btnAgregarTipoArticulo.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarTipoArticulo.TabIndex = 0;
            this.btnAgregarTipoArticulo.Text = "Agregar";
            this.btnAgregarTipoArticulo.Click += new System.EventHandler(this.btnAgregarTipoArticulo_Click);
            // 
            // btnModificarTipoArticulo
            // 
            this.btnModificarTipoArticulo.Location = new System.Drawing.Point(100, 97);
            this.btnModificarTipoArticulo.Name = "btnModificarTipoArticulo";
            this.btnModificarTipoArticulo.Size = new System.Drawing.Size(75, 23);
            this.btnModificarTipoArticulo.TabIndex = 1;
            this.btnModificarTipoArticulo.Text = "Modificar";
            this.btnModificarTipoArticulo.Click += new System.EventHandler(this.btnModificarTipoArticulo_Click);
            // 
            // btnEliminarTipoArticulo
            // 
            this.btnEliminarTipoArticulo.Location = new System.Drawing.Point(100, 140);
            this.btnEliminarTipoArticulo.Name = "btnEliminarTipoArticulo";
            this.btnEliminarTipoArticulo.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarTipoArticulo.TabIndex = 2;
            this.btnEliminarTipoArticulo.Text = "Eliminar";
            this.btnEliminarTipoArticulo.Click += new System.EventHandler(this.btnEliminarTipoArticulo_Click);
            // 
            // dtMarca
            // 
            this.dtMarca.DataSource = this.ingresosEgresosBindingSource;
            this.dtMarca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtMarca.Location = new System.Drawing.Point(294, 3);
            this.dtMarca.MainView = this.gridView1;
            this.dtMarca.Name = "dtMarca";
            this.dtMarca.Size = new System.Drawing.Size(397, 469);
            this.dtMarca.TabIndex = 3;
            this.dtMarca.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.dtMarca.Click += new System.EventHandler(this.dtTipoArticulo_Click);
            // 
            // ingresosEgresosBindingSource
            // 
            this.ingresosEgresosBindingSource.DataMember = "IngresosEgresos";
            this.ingresosEgresosBindingSource.DataSource = this.gestionCC;
            // 
            // gestionCC
            // 
            this.gestionCC.DataSetName = "GestionCC";
            this.gestionCC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId_Caja,
            this.colIngreso,
            this.colEgreso,
            this.colFechaOperacion,
            this.colDescripcionOperacion,
            this.colCajaInicial});
            this.gridView1.GridControl = this.dtMarca;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            // 
            // colId_Caja
            // 
            this.colId_Caja.FieldName = "Id_Caja";
            this.colId_Caja.Name = "colId_Caja";
            this.colId_Caja.OptionsColumn.ReadOnly = true;
            // 
            // colIngreso
            // 
            this.colIngreso.Caption = "Ingreso";
            this.colIngreso.FieldName = "Ingreso";
            this.colIngreso.Name = "colIngreso";
            this.colIngreso.OptionsColumn.AllowEdit = false;
            this.colIngreso.OptionsColumn.AllowFocus = false;
            this.colIngreso.OptionsColumn.ReadOnly = true;
            this.colIngreso.Visible = true;
            this.colIngreso.VisibleIndex = 2;
            // 
            // colEgreso
            // 
            this.colEgreso.Caption = "Egreso";
            this.colEgreso.FieldName = "Egreso";
            this.colEgreso.Name = "colEgreso";
            this.colEgreso.OptionsColumn.AllowEdit = false;
            this.colEgreso.OptionsColumn.AllowFocus = false;
            this.colEgreso.OptionsColumn.ReadOnly = true;
            this.colEgreso.Visible = true;
            this.colEgreso.VisibleIndex = 3;
            // 
            // colFechaOperacion
            // 
            this.colFechaOperacion.FieldName = "FechaOperacion";
            this.colFechaOperacion.Name = "colFechaOperacion";
            this.colFechaOperacion.OptionsColumn.AllowEdit = false;
            this.colFechaOperacion.OptionsColumn.AllowFocus = false;
            this.colFechaOperacion.OptionsColumn.ReadOnly = true;
            this.colFechaOperacion.Visible = true;
            this.colFechaOperacion.VisibleIndex = 0;
            // 
            // colDescripcionOperacion
            // 
            this.colDescripcionOperacion.FieldName = "DescripcionOperacion";
            this.colDescripcionOperacion.Name = "colDescripcionOperacion";
            this.colDescripcionOperacion.OptionsColumn.AllowEdit = false;
            this.colDescripcionOperacion.OptionsColumn.AllowFocus = false;
            this.colDescripcionOperacion.OptionsColumn.ReadOnly = true;
            this.colDescripcionOperacion.Visible = true;
            this.colDescripcionOperacion.VisibleIndex = 1;
            // 
            // colCajaInicial
            // 
            this.colCajaInicial.FieldName = "CajaInicial";
            this.colCajaInicial.Name = "colCajaInicial";
            // 
            // grbDatosIE
            // 
            this.grbDatosIE.Controls.Add(this.tableLayoutPanel2);
            this.grbDatosIE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbDatosIE.Location = new System.Drawing.Point(0, 0);
            this.grbDatosIE.Name = "grbDatosIE";
            this.grbDatosIE.Size = new System.Drawing.Size(285, 242);
            this.grbDatosIE.TabIndex = 4;
            this.grbDatosIE.TabStop = false;
            this.grbDatosIE.Text = "Gestión de datos";
            this.grbDatosIE.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 291F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dtMarca, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(694, 475);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grbDatosIE);
            this.panel1.Controls.Add(this.btnModificarTipoArticulo);
            this.panel1.Controls.Add(this.btnEliminarTipoArticulo);
            this.panel1.Controls.Add(this.btnAgregarTipoArticulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 242);
            this.panel1.TabIndex = 4;
            // 
            // ingresosEgresosTableAdapter
            // 
            this.ingresosEgresosTableAdapter.ClearBeforeFill = true;
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
            this.tableLayoutPanel2.TabIndex = 5;
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
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.Location = new System.Drawing.Point(104, 13);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            // 
            // FormABMIngresosEgresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 475);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormABMIngresosEgresos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Ingresos/Egresos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormABMIngresosEgresos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingresosEgresosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionCC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.grbDatosIE.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnAgregarTipoArticulo;
        private DevExpress.XtraEditors.SimpleButton btnModificarTipoArticulo;
        private DevExpress.XtraEditors.SimpleButton btnEliminarTipoArticulo;
        private DevExpress.XtraGrid.GridControl dtMarca;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox grbDatosIE;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private GestionCC gestionCC;
        private System.Windows.Forms.BindingSource ingresosEgresosBindingSource;
        private GestionCCTableAdapters.IngresosEgresosTableAdapter ingresosEgresosTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colId_Caja;
        private DevExpress.XtraGrid.Columns.GridColumn colIngreso;
        private DevExpress.XtraGrid.Columns.GridColumn colEgreso;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaOperacion;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcionOperacion;
        private DevExpress.XtraGrid.Columns.GridColumn colCajaInicial;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFechaOperacion;
        private System.Windows.Forms.Label lblDescripcionTipoArticulo;
        private System.Windows.Forms.TextBox txtDescOperacion;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.TextBox txtImporteOperacion;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private DevExpress.XtraEditors.SimpleButton btnGuardarTipoArticulo;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
    }
}