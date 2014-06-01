namespace Presentacion
{
    partial class FormABMGastos
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
            this.dtGasto = new DevExpress.XtraGrid.GridControl();
            this.gastoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionCC = new Presentacion.GestionCC();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId_Gasto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaGasto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesGasto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImporte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColAfectaCaja = new DevExpress.XtraGrid.Columns.GridColumn();
            this.marcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoArticuloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoArticuloTableAdapter = new Presentacion.GestionCCTableAdapters.TipoArticuloTableAdapter();
            this.grbDatosTiposArticulos = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblFechaGasto = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardarTipoArticulo = new DevExpress.XtraEditors.SimpleButton();
            this.txtDescGasto = new System.Windows.Forms.TextBox();
            this.lblDescripcionGasto = new System.Windows.Forms.Label();
            this.lblImporteGasto = new System.Windows.Forms.Label();
            this.txtImporteGasto = new System.Windows.Forms.TextBox();
            this.dtpFechaPago = new System.Windows.Forms.DateTimePicker();
            this.chkAfectaCaja = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.marcaTableAdapter = new Presentacion.GestionCCTableAdapters.MarcaTableAdapter();
            this.gastoTableAdapter = new Presentacion.GestionCCTableAdapters.GastoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtGasto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gastoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionCC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoArticuloBindingSource)).BeginInit();
            this.grbDatosTiposArticulos.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
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
            // dtGasto
            // 
            this.dtGasto.DataSource = this.gastoBindingSource;
            this.dtGasto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGasto.Location = new System.Drawing.Point(294, 3);
            this.dtGasto.MainView = this.gridView1;
            this.dtGasto.Name = "dtGasto";
            this.dtGasto.Size = new System.Drawing.Size(460, 252);
            this.dtGasto.TabIndex = 3;
            this.dtGasto.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.dtGasto.Click += new System.EventHandler(this.dtTipoArticulo_Click);
            // 
            // gastoBindingSource
            // 
            this.gastoBindingSource.DataMember = "Gasto";
            this.gastoBindingSource.DataSource = this.gestionCC;
            // 
            // gestionCC
            // 
            this.gestionCC.DataSetName = "GestionCC";
            this.gestionCC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId_Gasto,
            this.colFechaGasto,
            this.colDesGasto,
            this.colImporte,
            this.ColAfectaCaja});
            this.gridView1.GridControl = this.dtGasto;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            // 
            // colId_Gasto
            // 
            this.colId_Gasto.FieldName = "Id_Gasto";
            this.colId_Gasto.Name = "colId_Gasto";
            this.colId_Gasto.OptionsColumn.ReadOnly = true;
            // 
            // colFechaGasto
            // 
            this.colFechaGasto.FieldName = "FechaGasto";
            this.colFechaGasto.Name = "colFechaGasto";
            this.colFechaGasto.OptionsColumn.AllowEdit = false;
            this.colFechaGasto.OptionsColumn.AllowFocus = false;
            this.colFechaGasto.OptionsColumn.ReadOnly = true;
            this.colFechaGasto.Visible = true;
            this.colFechaGasto.VisibleIndex = 2;
            // 
            // colDesGasto
            // 
            this.colDesGasto.Caption = "Descripcion Gasto";
            this.colDesGasto.FieldName = "DesGasto";
            this.colDesGasto.Name = "colDesGasto";
            this.colDesGasto.OptionsColumn.AllowEdit = false;
            this.colDesGasto.OptionsColumn.AllowFocus = false;
            this.colDesGasto.OptionsColumn.ReadOnly = true;
            this.colDesGasto.Visible = true;
            this.colDesGasto.VisibleIndex = 0;
            // 
            // colImporte
            // 
            this.colImporte.Caption = "Importe Gasto";
            this.colImporte.FieldName = "Importe";
            this.colImporte.Name = "colImporte";
            this.colImporte.OptionsColumn.AllowEdit = false;
            this.colImporte.OptionsColumn.AllowFocus = false;
            this.colImporte.OptionsColumn.ReadOnly = true;
            this.colImporte.Visible = true;
            this.colImporte.VisibleIndex = 1;
            // 
            // ColAfectaCaja
            // 
            this.ColAfectaCaja.Caption = "Afecta a Caja Diaria";
            this.ColAfectaCaja.FieldName = "AfectaCaja";
            this.ColAfectaCaja.Name = "ColAfectaCaja";
            this.ColAfectaCaja.OptionsColumn.AllowEdit = false;
            this.ColAfectaCaja.OptionsColumn.AllowFocus = false;
            this.ColAfectaCaja.OptionsColumn.ReadOnly = true;
            this.ColAfectaCaja.Visible = true;
            this.ColAfectaCaja.VisibleIndex = 3;
            // 
            // marcaBindingSource
            // 
            this.marcaBindingSource.DataMember = "Marca";
            this.marcaBindingSource.DataSource = this.gestionCC;
            // 
            // tipoArticuloBindingSource
            // 
            this.tipoArticuloBindingSource.DataMember = "TipoArticulo";
            this.tipoArticuloBindingSource.DataSource = this.gestionCC;
            // 
            // tipoArticuloTableAdapter
            // 
            this.tipoArticuloTableAdapter.ClearBeforeFill = true;
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
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.lblFechaGasto, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtDescGasto, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblDescripcionGasto, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblImporteGasto, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtImporteGasto, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.dtpFechaPago, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.chkAfectaCaja, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.81643F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.24352F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.17098F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(279, 193);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // lblFechaGasto
            // 
            this.lblFechaGasto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFechaGasto.AutoSize = true;
            this.lblFechaGasto.Location = new System.Drawing.Point(46, 26);
            this.lblFechaGasto.Name = "lblFechaGasto";
            this.lblFechaGasto.Size = new System.Drawing.Size(71, 13);
            this.lblFechaGasto.TabIndex = 4;
            this.lblFechaGasto.Text = "Fecha Gasto:";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.btnCancelar, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnGuardarTipoArticulo, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(123, 146);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(153, 44);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.Location = new System.Drawing.Point(79, 10);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(71, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardarTipoArticulo
            // 
            this.btnGuardarTipoArticulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardarTipoArticulo.Location = new System.Drawing.Point(3, 10);
            this.btnGuardarTipoArticulo.Name = "btnGuardarTipoArticulo";
            this.btnGuardarTipoArticulo.Size = new System.Drawing.Size(70, 23);
            this.btnGuardarTipoArticulo.TabIndex = 2;
            this.btnGuardarTipoArticulo.Text = "Guardar";
            this.btnGuardarTipoArticulo.Click += new System.EventHandler(this.btnGuardarTipoArticulo_Click);
            // 
            // txtDescGasto
            // 
            this.txtDescGasto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescGasto.Location = new System.Drawing.Point(129, 75);
            this.txtDescGasto.Name = "txtDescGasto";
            this.txtDescGasto.Size = new System.Drawing.Size(141, 21);
            this.txtDescGasto.TabIndex = 0;
            this.txtDescGasto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTipoArticulo_KeyPress);
            // 
            // lblDescripcionGasto
            // 
            this.lblDescripcionGasto.AccessibleName = "";
            this.lblDescripcionGasto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDescripcionGasto.AutoSize = true;
            this.lblDescripcionGasto.Location = new System.Drawing.Point(52, 79);
            this.lblDescripcionGasto.Name = "lblDescripcionGasto";
            this.lblDescripcionGasto.Size = new System.Drawing.Size(65, 13);
            this.lblDescripcionGasto.TabIndex = 1;
            this.lblDescripcionGasto.Text = "Descripción:";
            // 
            // lblImporteGasto
            // 
            this.lblImporteGasto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblImporteGasto.AutoSize = true;
            this.lblImporteGasto.Location = new System.Drawing.Point(68, 118);
            this.lblImporteGasto.Name = "lblImporteGasto";
            this.lblImporteGasto.Size = new System.Drawing.Size(49, 13);
            this.lblImporteGasto.TabIndex = 5;
            this.lblImporteGasto.Text = "Importe:";
            // 
            // txtImporteGasto
            // 
            this.txtImporteGasto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtImporteGasto.Location = new System.Drawing.Point(129, 114);
            this.txtImporteGasto.Name = "txtImporteGasto";
            this.txtImporteGasto.Size = new System.Drawing.Size(141, 21);
            this.txtImporteGasto.TabIndex = 6;
            // 
            // dtpFechaPago
            // 
            this.dtpFechaPago.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFechaPago.Location = new System.Drawing.Point(123, 22);
            this.dtpFechaPago.Name = "dtpFechaPago";
            this.dtpFechaPago.Size = new System.Drawing.Size(153, 21);
            this.dtpFechaPago.TabIndex = 7;
            // 
            // chkAfectaCaja
            // 
            this.chkAfectaCaja.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkAfectaCaja.AutoSize = true;
            this.chkAfectaCaja.Location = new System.Drawing.Point(3, 159);
            this.chkAfectaCaja.Name = "chkAfectaCaja";
            this.chkAfectaCaja.Size = new System.Drawing.Size(113, 17);
            this.chkAfectaCaja.TabIndex = 8;
            this.chkAfectaCaja.Text = "Afecta Caja Diaria";
            this.chkAfectaCaja.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 291F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dtGasto, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(757, 258);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grbDatosTiposArticulos);
            this.panel1.Controls.Add(this.btnModificarTipoArticulo);
            this.panel1.Controls.Add(this.btnEliminarTipoArticulo);
            this.panel1.Controls.Add(this.btnAgregarTipoArticulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 242);
            this.panel1.TabIndex = 4;
            // 
            // marcaTableAdapter
            // 
            this.marcaTableAdapter.ClearBeforeFill = true;
            // 
            // gastoTableAdapter
            // 
            this.gastoTableAdapter.ClearBeforeFill = true;
            // 
            // FormABMGastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 258);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormABMGastos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Gastos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormABMTipoArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGasto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gastoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionCC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoArticuloBindingSource)).EndInit();
            this.grbDatosTiposArticulos.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnAgregarTipoArticulo;
        private DevExpress.XtraEditors.SimpleButton btnModificarTipoArticulo;
        private DevExpress.XtraEditors.SimpleButton btnEliminarTipoArticulo;
        private DevExpress.XtraGrid.GridControl dtGasto;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private GestionCC gestionCC;
        private System.Windows.Forms.BindingSource tipoArticuloBindingSource;
        private GestionCCTableAdapters.TipoArticuloTableAdapter tipoArticuloTableAdapter;
        private System.Windows.Forms.GroupBox grbDatosTiposArticulos;
        private System.Windows.Forms.Label lblDescripcionGasto;
        private System.Windows.Forms.TextBox txtDescGasto;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnGuardarTipoArticulo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource marcaBindingSource;
        private GestionCCTableAdapters.MarcaTableAdapter marcaTableAdapter;
        private System.Windows.Forms.BindingSource gastoBindingSource;
        private GestionCCTableAdapters.GastoTableAdapter gastoTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colId_Gasto;
        private DevExpress.XtraGrid.Columns.GridColumn colDesGasto;
        private DevExpress.XtraGrid.Columns.GridColumn colImporte;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaGasto;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lblFechaGasto;
        private System.Windows.Forms.Label lblImporteGasto;
        private System.Windows.Forms.TextBox txtImporteGasto;
        private System.Windows.Forms.DateTimePicker dtpFechaPago;
        private System.Windows.Forms.CheckBox chkAfectaCaja;
        private DevExpress.XtraGrid.Columns.GridColumn ColAfectaCaja;
    }
}